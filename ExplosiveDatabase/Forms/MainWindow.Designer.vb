<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.ProductListView = New System.Windows.Forms.ListView()
		Me.colMine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colProduct = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UnitDisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImperialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MetricToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DatabseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RemoveEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExportRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.InfoPanel = New ExplosiveDatabase.ExplosiveInfoPanel()
		Me.MenuStrip1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ProductListView
		'
		Me.ProductListView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ProductListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colMine, Me.colProduct})
		Me.ProductListView.FullRowSelect = True
		Me.ProductListView.HideSelection = False
		Me.ProductListView.Location = New System.Drawing.Point(12, 36)
		Me.ProductListView.MultiSelect = False
		Me.ProductListView.Name = "ProductListView"
		Me.ProductListView.Size = New System.Drawing.Size(1162, 453)
		Me.ProductListView.TabIndex = 0
		Me.ProductListView.UseCompatibleStateImageBehavior = False
		Me.ProductListView.View = System.Windows.Forms.View.Details
		'
		'colMine
		'
		Me.colMine.Text = "Mine"
		Me.colMine.Width = 193
		'
		'colProduct
		'
		Me.colProduct.Text = "Product Name"
		Me.colProduct.Width = 514
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.DatabseToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1186, 33)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDatabaseToolStripMenuItem, Me.OpenDatabaseToolStripMenuItem, Me.SaveDatabaseToolStripMenuItem, Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'NewDatabaseToolStripMenuItem
		'
		Me.NewDatabaseToolStripMenuItem.Name = "NewDatabaseToolStripMenuItem"
		Me.NewDatabaseToolStripMenuItem.Size = New System.Drawing.Size(220, 30)
		Me.NewDatabaseToolStripMenuItem.Text = "New Database"
		'
		'OpenDatabaseToolStripMenuItem
		'
		Me.OpenDatabaseToolStripMenuItem.Name = "OpenDatabaseToolStripMenuItem"
		Me.OpenDatabaseToolStripMenuItem.Size = New System.Drawing.Size(220, 30)
		Me.OpenDatabaseToolStripMenuItem.Text = "Open Database"
		'
		'SaveDatabaseToolStripMenuItem
		'
		Me.SaveDatabaseToolStripMenuItem.Enabled = False
		Me.SaveDatabaseToolStripMenuItem.Name = "SaveDatabaseToolStripMenuItem"
		Me.SaveDatabaseToolStripMenuItem.Size = New System.Drawing.Size(220, 30)
		Me.SaveDatabaseToolStripMenuItem.Text = "Save Database"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(220, 30)
		Me.ExitToolStripMenuItem.Text = "Exit"
		'
		'SettingsToolStripMenuItem
		'
		Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitDisplayToolStripMenuItem})
		Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
		Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
		Me.SettingsToolStripMenuItem.Text = "Settings"
		'
		'UnitDisplayToolStripMenuItem
		'
		Me.UnitDisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImperialToolStripMenuItem, Me.MetricToolStripMenuItem})
		Me.UnitDisplayToolStripMenuItem.Name = "UnitDisplayToolStripMenuItem"
		Me.UnitDisplayToolStripMenuItem.Size = New System.Drawing.Size(192, 30)
		Me.UnitDisplayToolStripMenuItem.Text = "Unit Display"
		'
		'ImperialToolStripMenuItem
		'
		Me.ImperialToolStripMenuItem.Checked = True
		Me.ImperialToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ImperialToolStripMenuItem.Name = "ImperialToolStripMenuItem"
		Me.ImperialToolStripMenuItem.Size = New System.Drawing.Size(161, 30)
		Me.ImperialToolStripMenuItem.Text = "Imperial"
		'
		'MetricToolStripMenuItem
		'
		Me.MetricToolStripMenuItem.Name = "MetricToolStripMenuItem"
		Me.MetricToolStripMenuItem.Size = New System.Drawing.Size(161, 30)
		Me.MetricToolStripMenuItem.Text = "Metric"
		'
		'DatabseToolStripMenuItem
		'
		Me.DatabseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditSelectedToolStripMenuItem, Me.NewEntryToolStripMenuItem, Me.RemoveEntryToolStripMenuItem, Me.ExportRecordToolStripMenuItem})
		Me.DatabseToolStripMenuItem.Enabled = False
		Me.DatabseToolStripMenuItem.Name = "DatabseToolStripMenuItem"
		Me.DatabseToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
		Me.DatabseToolStripMenuItem.Text = "Record"
		'
		'EditSelectedToolStripMenuItem
		'
		Me.EditSelectedToolStripMenuItem.Enabled = False
		Me.EditSelectedToolStripMenuItem.Name = "EditSelectedToolStripMenuItem"
		Me.EditSelectedToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
		Me.EditSelectedToolStripMenuItem.Text = "Edit Selected"
		'
		'NewEntryToolStripMenuItem
		'
		Me.NewEntryToolStripMenuItem.Name = "NewEntryToolStripMenuItem"
		Me.NewEntryToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
		Me.NewEntryToolStripMenuItem.Text = "New Entry"
		'
		'RemoveEntryToolStripMenuItem
		'
		Me.RemoveEntryToolStripMenuItem.Enabled = False
		Me.RemoveEntryToolStripMenuItem.Name = "RemoveEntryToolStripMenuItem"
		Me.RemoveEntryToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
		Me.RemoveEntryToolStripMenuItem.Text = "Delete Entry"
		'
		'ExportRecordToolStripMenuItem
		'
		Me.ExportRecordToolStripMenuItem.Enabled = False
		Me.ExportRecordToolStripMenuItem.Name = "ExportRecordToolStripMenuItem"
		Me.ExportRecordToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
		Me.ExportRecordToolStripMenuItem.Text = "Export Entry"
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.InfoPanel)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 495)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1162, 633)
		Me.GroupBox1.TabIndex = 3
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Information"
		'
		'InfoPanel
		'
		Me.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.InfoPanel.Location = New System.Drawing.Point(3, 22)
		Me.InfoPanel.Margin = New System.Windows.Forms.Padding(0)
		Me.InfoPanel.Name = "InfoPanel"
		Me.InfoPanel.Padding = New System.Windows.Forms.Padding(3)
		Me.InfoPanel.Size = New System.Drawing.Size(1156, 608)
		Me.InfoPanel.TabIndex = 2
		'
		'MainWindow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1186, 1140)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.ProductListView)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "MainWindow"
		Me.Text = "Explosives Database"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ProductListView As ListView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoPanel As ExplosiveInfoPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents colMine As ColumnHeader
    Friend WithEvents colProduct As ColumnHeader
    Friend WithEvents NewDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitDisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImperialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetricToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExportRecordToolStripMenuItem As ToolStripMenuItem
End Class
