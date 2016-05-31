''' <summary>
''' Simple tuple class representing a single entry in the detonation velocity chart of an explosive product. 
''' </summary>
Public Class DetVelocityEntry
    Implements IComparable(Of DetVelocityEntry)

    ''' <summary>
    ''' Cartridge Diameter, in inches
    ''' </summary>
    Private _diameter As Double

    ''' <summary>
    ''' Detonation Velocity, in Feet per Second
    ''' </summary>
    Private _detVelocity As Double

    Public Property Diameter As Double
        Get
            Return _diameter
        End Get
        Set(value As Double)
            _diameter = value
        End Set
    End Property

    Public Property DetVelocity As Double
        Get
            Return _detVelocity
        End Get
        Set(value As Double)
            _detVelocity = value
        End Set
    End Property

    Public Property rowID As Integer

    Public Sub New(diameter As Double, detVelocity As Double)
        Me.Diameter = diameter
        Me.DetVelocity = detVelocity
        Me.rowID = -1
    End Sub

    ''' <summary>
    ''' Copy constructor.
    ''' </summary>
    ''' <param name="other"></param>
    Public Sub New(other As DetVelocityEntry)
        Me.rowID = other.rowID
        Me.Diameter = other.Diameter
        Me.DetVelocity = other.DetVelocity
    End Sub

    Public Function CompareTo(other As DetVelocityEntry) As Integer Implements IComparable(Of DetVelocityEntry).CompareTo
        If Me.diameter < other.diameter Then
            Return -1
        ElseIf Me.diameter = other.diameter Then
            Return 0
        Else
            Return 1
        End If

    End Function
    ' should also implement comparison operators. 
End Class
