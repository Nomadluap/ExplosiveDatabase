Imports System.Collections
Imports IringProgrammingSkills

Public Class MainWindow
    Private products As List(Of ExplosiveProduct) = New List(Of ExplosiveProduct) ' holds the products pulled from the database
    Private deletedProducts As List(Of ExplosiveProduct) = New List(Of ExplosiveProduct) ' holds products that are to be deleted on the next save. 
    Private dbConnection As DatabaseConnection ' connection to the database. 
    Private _units As UnitSystem = UnitSystem.IMPERIAL
	Private selectedProductIndex As Integer = -1
	Private editWindow As New EditWindow()
	Private _allowRecordActions As Boolean

	Friend Property Units As UnitSystem
		Get
			Return _units
		End Get
		Set(value As UnitSystem)
			_units = value
			Me.InfoPanel.Units = value
			Me.editWindow.Units = value
		End Set
	End Property

	Public Property AllowRecordActions As Boolean
		Get
			Return _allowRecordActions
		End Get
		Set(value As Boolean)
			Me._allowRecordActions = value
			EditSelectedToolStripMenuItem.Enabled = value
			RemoveEntryToolStripMenuItem.Enabled = value
			ExportRecordToolStripMenuItem.Enabled = value
		End Set
	End Property

	''' <summary>
	''' Summon a file open dialog to select a new database to open. The products in the database will be loaded into the products list. 
	''' </summary>
	Private Sub OpenDatabase()
        ' summon the open file dialog to get a filename
        Dim fileDialog = New OpenFileDialog()

		fileDialog.RestoreDirectory = True

        ' Display the dialog and pull the file string
        If fileDialog.ShowDialog() = DialogResult.OK Then
			Try
				Dim filename = fileDialog.FileName
				Trace.WriteLine("Open file path: " & filename)
                ' Attempt to open database connection and pull the information. 
                Me.dbConnection = New DatabaseConnection(filename)
                ' Now pull the list of products into the product list
                Me.products = dbConnection.ReadAllProducts()
				Me.EnableUI()
			Catch ex As Exception
				MessageBox.Show("An error occured: " & ex.Message)
			End Try
		End If
		Me.GenerateProductListView()
	End Sub

    ''' <summary>
    ''' Create a new database and initialize it with empty tables. 
    ''' </summary>
    Private Sub CreateNewDatabase()
        ' summon the save file dialog to request location of new database
        Dim fileDialog = New SaveFileDialog()
		fileDialog.RestoreDirectory = True

		If fileDialog.ShowDialog() = DialogResult.OK Then
			dbConnection = DatabaseConnection.CreateNewDatabase(fileDialog.FileName)
			Me.EnableUI()
		End If
	End Sub

    ''' <summary>
    ''' Writes out the current state of the product list to the database. Also removes any entries that have been deleted from the list. 
    ''' </summary>
    Private Sub SaveDatabase()
		If dbConnection Is Nothing Then
			CreateNewDatabase()
		End If
		For Each entry As ExplosiveProduct In products
			dbConnection.UpdateOrInsertProduct(entry)
		Next
		For Each entry As ExplosiveProduct In deletedProducts
			dbConnection.DeleteProduct(entry)
		Next
	End Sub

    ''' <summary>
    ''' Deletes the currently selected item in the product list. 
    ''' </summary>
    Private Sub DeleteSelectedEntry()
		If Me.selectedProductIndex >= 0 Then
			Me.deletedProducts.Add(Me.products.ElementAt(selectedProductIndex))
			Me.products.RemoveAt(selectedProductIndex)
			Me.ProductListView.Items.RemoveAt(selectedProductIndex)
		End If

	End Sub

    ''' <summary>
    ''' Generate the product list view from the product list. 
    ''' This should be called after making changes to the product list. 
    ''' </summary>
    Private Sub GenerateProductListView()
		Me.ProductListView.Items.Clear()
		For Each product As ExplosiveProduct In products
			Dim line = New ListViewItem({product.MineName, product.ProductName})
			ProductListView.Items.Add(line)
		Next
	End Sub

	Private Sub ProductListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductListView.SelectedIndexChanged
		If ProductListView.SelectedIndices.Count > 0 Then
			Me.selectedProductIndex = ProductListView.SelectedIndices.Item(0)
			Trace.WriteLine("MainWindow list selection changed to " & selectedProductIndex)
			Try
				Me.InfoPanel.Product = products.ElementAt(selectedProductIndex) ' update the info panel with the currently selected product
				Me.AllowRecordActions = True
			Catch ex As ArgumentOutOfRangeException
				Me.InfoPanel.Product = New ExplosiveProduct()
			End Try
		Else
			Trace.WriteLine("Mainwindow list selection was lost")
			Me.InfoPanel.Product = New ExplosiveProduct()
			Me.AllowRecordActions = False
		End If

	End Sub

	Private Sub OpenDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDatabaseToolStripMenuItem.Click
		Me.OpenDatabase()
	End Sub

	Private Sub SaveDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDatabaseToolStripMenuItem.Click
		Me.SaveDatabase()
	End Sub

	Private Sub NewDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDatabaseToolStripMenuItem.Click
		Me.CreateNewDatabase()
	End Sub

	Private Sub ImperialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImperialToolStripMenuItem.Click
		MetricToolStripMenuItem.Checked = False
		ImperialToolStripMenuItem.Checked = True
		Me.Units = UnitSystem.IMPERIAL
	End Sub

	Private Sub MetricToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MetricToolStripMenuItem.Click
		MetricToolStripMenuItem.Checked = True
		ImperialToolStripMenuItem.Checked = False
		Me.Units = UnitSystem.METRIC
	End Sub

	Private Sub NewEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEntryToolStripMenuItem.Click
		editWindow.Product = New ExplosiveProduct()
		If editWindow.ShowDialog() = DialogResult.OK Then
			Me.products.Add(editWindow.Product)
			Me.GenerateProductListView()
		End If
	End Sub

	Private Sub EditSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedToolStripMenuItem.Click
		If Me.ProductListView.SelectedIndices.Count > 0 Then
			editWindow.Product = New ExplosiveProduct(products.ElementAt(Me.selectedProductIndex))
			If editWindow.ShowDialog() = DialogResult.OK Then
				products.Item(selectedProductIndex) = editWindow.Product
				InfoPanel.Product = editWindow.Product
			End If
		End If
	End Sub

	Private Sub RemoveEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveEntryToolStripMenuItem.Click
		DeleteSelectedEntry()
	End Sub

	Private Sub ExportRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportRecordToolStripMenuItem.Click
		If Me.ProductListView.SelectedIndices.Count > 0 Then
			Dim reportForm = New ReportForm()
			reportForm.Product = New ExplosiveProduct(products.ElementAt(Me.selectedProductIndex))
			reportForm.ShowDialog()
		End If
	End Sub

	''' <summary>
	''' Called when one of the database-opening subroutines is called to unlock the UI. Locked UI prevents adding entries with 
	''' a null database connection. 
	''' </summary>
	Private Sub EnableUI()
		DatabseToolStripMenuItem.Enabled = True
		SaveDatabaseToolStripMenuItem.Enabled = True
	End Sub

	''' <summary>
	''' Open the edit window for the selected item on double click
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub ProductListView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ProductListView.MouseDoubleClick
		Me.EditSelectedToolStripMenuItem_Click(sender, e)
	End Sub
End Class