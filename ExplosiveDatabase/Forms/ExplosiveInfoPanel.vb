
Public Class ExplosiveInfoPanel

    Private _units As UnitSystem = UnitSystem.IMPERIAL
    Private _product = New ExplosiveProduct() ' initialize with empty product. 


    ' UI strings
    Private Const STRING_VELOCITY_IMPERIAL = "Detonation Velocity (ft/sec)"
    Private Const STRING_VELOCITY_METRIC = "Detonation Velocity (m/sec)"
    Private Const STRING_DIAMETER_IMPERIAL = "Cartridge Diameter (in.)"
    Private Const STRING_DIAMETER_METRIC = "Cartridge Diameter (mm)"


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Units = UnitSystem.IMPERIAL

    End Sub

    ''' <summary>
    ''' Specifies the units used for display of this control. May be either metric or imperial. 
    ''' </summary>
    ''' <returns></returns>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Friend Property Units As UnitSystem
        Get
            Return _units
        End Get
        Set(value As UnitSystem)
            _units = value
            ' We need to set the headings for the velocity table to reflect the unit. 
            If _units = UnitSystem.IMPERIAL Then
                VelocityList.Columns.Item(0).Text = STRING_DIAMETER_IMPERIAL
                VelocityList.Columns.Item(1).Text = STRING_VELOCITY_IMPERIAL
            Else
                VelocityList.Columns.Item(0).Text = STRING_DIAMETER_METRIC
                VelocityList.Columns.Item(1).Text = STRING_VELOCITY_METRIC
            End If
            ' re-add the current product to update the unit display
            Me.Product = Me.Product
        End Set
    End Property

    ''' <summary>
    ''' The explosive product currently being displayed by this control. 
    ''' </summary>
    ''' <returns></returns>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> ' so the designer doesn't complain about non-serializable properties.
    Public Property Product As ExplosiveProduct
		Get
			Return _product
		End Get
		Set(value As ExplosiveProduct)
			_product = value
            ' populate the fields. Also ensure that the units are controlled properly. 
            Me.TxtMine.Text = value.MineName
			Me.TxtProductName.Text = value.ProductName
			Me.TxtEndUse.Text = value.ApplicationEndUse
			Me.TxtFumeClass.Text = value.FumeClass
			Me.TxtDensity.Text = String.Format("{0:#.##}", value.Density)
            ' zero-out then repopulate the velocity list
            Me.VelocityList.Items.Clear()
			For Each entry As DetVelocityEntry In value.VelocityEntries
				Dim diameter As String
				Dim velocity As String
                ' account for units
                If Me._units = UnitSystem.IMPERIAL Then
					diameter = String.Format("{0:#.##}", entry.Diameter)
					velocity = String.Format("{0:#.##}", entry.DetVelocity)
				Else
					diameter = String.Format("{0:#.##}", InchToMm(entry.Diameter))
					velocity = String.Format("{0:#.##}", FeetToMetres(entry.DetVelocity))
				End If
				Dim line = New ListViewItem({diameter, velocity})
				Me.VelocityList.Items.Add(line)
			Next
		End Set
	End Property
End Class
