'Created by Paul Belanger, 20160525
Imports System.Math
Imports MathNet.Numerics.LinearRegression
Imports MathNet.Numerics.LinearAlgebra


''' <summary>
''' The ExplosiveProduct class represents a single explosive product in the database. 
''' </summary>
Public Class ExplosiveProduct
    Private _mineName As String ' Name of mine
    Private _productName As String ' Name of explosive Product
    Private _applicationEndUse As String ' End use of explosive product
    Private _fumeClass As String ' Fume class of explosive product
    Private _density As Double ' Density of the explosive product, in grams per cc. 
    Private _velocityEntries As New List(Of DetVelocityEntry)

    ' Coeffecients for the regression formula. Either calculated based on the entries in the table or supplied manually. 
    Private _regressionA As Double
    Private _regressionB As Double
    Private _regressionC As Double

    Private _tableId As Integer = -1 ' the table index storing this product. A negative value represents a NULL. 

    Public Property MineName As String
        Get
            Return _mineName
        End Get
        Set(value As String)
            _mineName = value
        End Set
    End Property

    Public Property ProductName As String
        Get
            Return _productName
        End Get
        Set(value As String)
            _productName = value
        End Set
    End Property

    Public Property ApplicationEndUse As String
        Get
            Return _applicationEndUse
        End Get
        Set(value As String)
            _applicationEndUse = value
        End Set
    End Property

    Public Property FumeClass As String
        Get
            Return _fumeClass
        End Get
        Set(value As String)
            _fumeClass = value
        End Set
    End Property

    Public Property Density As Double
        Get
            Return _density
        End Get
        Set(value As Double)
            _density = value
        End Set
    End Property

    Public Property VelocityEntries As List(Of DetVelocityEntry)
        Get
            Return _velocityEntries
        End Get
        Set(value As List(Of DetVelocityEntry))
            _velocityEntries = value
        End Set
    End Property

    Public Property RowID As Integer
        Get
            Return _tableId
        End Get
        Set(value As Integer)
            _tableId = value
        End Set
    End Property

    Public Property RegressionA As Double
        Get
            Return _regressionA
        End Get
        Set(value As Double)
            _regressionA = value
        End Set
    End Property

    Public Property RegressionB As Double
        Get
            Return _regressionB
        End Get
        Set(value As Double)
            _regressionB = value
        End Set
    End Property

    Public Property RegressionC As Double
        Get
            Return _regressionC
        End Get
        Set(value As Double)
            _regressionC = value
        End Set
    End Property

    ''' <summary>
    ''' Construct a new ExplosiveProduct using specified parameters. 
    ''' </summary>
    ''' <param name="mineName">Name of the mine</param>
    ''' <param name="productName">Name of explosive Product</param>
    ''' <param name="applicationEndUse">End use of explosive product</param>
    ''' <param name="fumeClass">fume class of the explosive product</param>
    ''' <param name="density">density of explosive product, in g/cc</param>
    ''' <param name="velocityEntries">Enumerable containing the entries of the explosive velocity table. </param>
    Public Sub New(mineName As String, productName As String, applicationEndUse As String, fumeClass As String, density As Double, velocityEntries As IEnumerable(Of DetVelocityEntry))
        Me.MineName = mineName
        Me.ProductName = productName
        Me.ApplicationEndUse = applicationEndUse
        Me.FumeClass = fumeClass
        Me.Density = density
        Me.VelocityEntries = New List(Of DetVelocityEntry)(velocityEntries)
        'We are always under the assumption that the velocityEntries are sorted. 
        Me.VelocityEntries.Sort()

        Me.RegressionA = 0.0
        Me.RegressionB = 0.0
        Me.RegressionC = 0.0
    End Sub

    ''' <summary>
    ''' Construct a new ExplosiveProduct using specified parameters. The velocity table will be empty. 
    ''' </summary>
    ''' <param name="mineName">Name of the mine</param>
    ''' <param name="productName">Name of explosive Product</param>
    ''' <param name="applicationEndUse">End use of explosive product</param>
    ''' <param name="fumeClass">fume class of the explosive product</param>
    ''' <param name="density">density of explosive product, in g/cc</param>
    Public Sub New(mineName As String, productName As String, applicationEndUse As String, fumeClass As String, density As Double)
        Me.New(mineName, productName, applicationEndUse, fumeClass, density, New List(Of DetVelocityEntry))
    End Sub

    ''' <summary>
    ''' Copy Constructor. Deep copies velocity entries. 
    ''' </summary>
    ''' <param name="other">The ExplosiveProduct to copy. </param>
    Public Sub New(other As ExplosiveProduct)
        Me.MineName = other.MineName
        Me.ProductName = other.ProductName
        Me.ApplicationEndUse = other.ApplicationEndUse
        Me.FumeClass = other.FumeClass
        Me.Density = other.Density
        Me.RowID = other.RowID
        For Each i As DetVelocityEntry In other.VelocityEntries
            Me.VelocityEntries.Add(New DetVelocityEntry(i))
        Next
    End Sub

    ''' <summary>
    ''' Construct a new ExplosiveProduct using empty default parameters. The object will have empty parameters
    ''' and will have an empty velocity table.
    ''' </summary>
    Public Sub New()
        Me.MineName = ""
        Me.ProductName = ""
        Me.ApplicationEndUse = ""
        Me.FumeClass = ""
        Me.Density = 0.0
        Me.VelocityEntries = New List(Of DetVelocityEntry)

        Me.RegressionA = 0.0
        Me.RegressionB = 0.0
        Me.RegressionC = 0.0
    End Sub

    ''' <summary>
    ''' Add an entry into the velocity table. 
    ''' </summary>
    ''' <param name="entry">line to add. </param>
    Public Sub AddVelocityEntry(entry As DetVelocityEntry)
        Console.WriteLine("adding velocity entry")
        Me._velocityEntries.Add(entry)
        Me._velocityEntries.Sort()
    End Sub

    ''' <summary>
    ''' Calculate the A, B, C coefficients of the regression calculation using supplied table data.
    ''' Requires that the velocity table has at least three entries. 
	''' This subroutine uses Mathnet for its linear regression capabilities
    ''' </summary>
    Public Sub CalculateRegressionCoefficients()
		If Me.VelocityEntries.Count >= 3 Then ' three variables needs at least 3 entries in the table
			Dim M = Matrix(Of Double).Build.Dense(Me.VelocityEntries.Count, 3)
			Dim y = Vector(Of Double).Build.Dense(Me.VelocityEntries.Count)
			For n As Integer = 0 To Me.VelocityEntries.Count - 1 ' populate the matrix and vector
				M(n, 0) = 1
				M(n, 1) = Me.VelocityEntries(n).Diameter
				M(n, 2) = Exp(-1 * Me.VelocityEntries(n).Diameter)

				y(n) = Me.VelocityEntries(n).DetVelocity
			Next

			' Then our linear system is a * alpha + b * beta + c * gamma = Y
			' so our system of three eqns is M * x = y, solve for x
			Dim x = MultipleRegression.NormalEquations(M, y)
			Trace.WriteLine("solved system gives" & x.ToString())
			' now populate the properties
			Me.RegressionA = x(0)
			Me.RegressionB = x(1)
			Me.RegressionC = x(2)
		Else
			Throw New RegressionException("Regression requires at least 3 velocity table entries")
		End If
	End Sub

    ''' <summary>
    ''' Set the A, B, C coefficients of the regression calculation using pre-calculated values
	''' Not actually used at this time. 
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <param name="c"></param>
    Public Sub SetRegressionCoefficients(a As Double, b As Double, c As Double)
		Me.RegressionA = a
		Me.RegressionB = b
		Me.RegressionC = c
	End Sub

	''' <summary>
	''' Invalidate the regression coefficients. This method should be called whenever the velocity table changes. 
	''' </summary>
	Public Sub InvalidateRegression()
		Me.RegressionA = 0
		Me.RegressionB = 0
		Me.RegressionC = 0
	End Sub

    ''' <summary>
    ''' use calculated regression coefficients to interpolate a detonation velocity. 
    ''' Requires that the regression coefficients be either calculated with CalculateRegressionCoeffients() or
    ''' supplied manually with SetRegressionCoefficients() before use. 
    ''' </summary>
    ''' <param name="diameterInches"></param>
    ''' <returns></returns>
    Public Function InterpolateDetVelocity(diameterInches As Double)
		If Me.RegressionA = 0.0 And Me.RegressionB = 0.0 And Me.RegressionC = 0.0 Then
			Me.CalculateRegressionCoefficients()
		End If ' otherwise the coefficients have been caluclated and we can return. 
		Return Me.RegressionA + Me.RegressionB * diameterInches + Me.RegressionC * Exp(-diameterInches)
	End Function

End Class
