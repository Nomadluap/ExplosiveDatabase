Public Class EditWindow
	Private _units As UnitSystem = UnitSystem.IMPERIAL
	Private _product As New ExplosiveProduct() ' initialize with empty product. 
    Private velocityEntries As New List(Of DetVelocityEntry)
	Private velocityListSelectionIndex As Integer = -1 ' negative value represents no selection

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

        ' If constructed as editable, then re-enable the text boxes. 

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
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
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
            Me.velocityEntries = New List(Of DetVelocityEntry)(value.VelocityEntries)
			Me.PopulateVelocityList()
		End Set
	End Property

	Private Sub PopulateVelocityList()
		Me.VelocityList.Items.Clear()
		Me.Product.VelocityEntries.Sort()
		For Each entry As DetVelocityEntry In Me.velocityEntries
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
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' pull the values from the dialog and apply to the product
        Try
            Product.MineName = TxtMine.Text
            Product.ProductName = TxtProductName.Text
            Product.ApplicationEndUse = TxtEndUse.Text
			Product.FumeClass = TxtFumeClass.Text
			Product.Density = Double.Parse(TxtDensity.Text)
			Product.VelocityEntries = Me.velocityEntries
			Product.InvalidateRegression()
			Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch exeption As FormatException
            MsgBox("Density must be numeric.")
        End Try
    End Sub

    Private Sub VelocityList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VelocityList.SelectedIndexChanged
        If VelocityList.SelectedIndices.Count > 0 Then
            Me.velocityListSelectionIndex = VelocityList.SelectedIndices.Item(0)
            btnDelete.Enabled = True
        Else
            velocityListSelectionIndex = -1
            btnDelete.Enabled = False
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Delete the currently selected item from the velocity list. 
        If velocityListSelectionIndex >= 0 Then
			velocityEntries.RemoveAt(velocityListSelectionIndex)
			VelocityList.Items.RemoveAt(velocityListSelectionIndex)
		End If
	End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' pull the values from the boxes
        Try
            Dim diam = Double.Parse(txtDiameter.Text)
            Dim vel = Double.Parse(txtVelocity.Text)
            ' do conversion to imperial if the UI is in metric mode. 
            If Me.Units = UnitSystem.METRIC Then
				diam = MmToInch(diam)
				vel = MetresToFeet(vel)
			End If
			velocityEntries.Add(New DetVelocityEntry(diam, vel))
			velocityEntries.Sort()
			PopulateVelocityList()
        Catch ex As FormatException
            MsgBox("Both values must be numeric")
        End Try

    End Sub
End Class