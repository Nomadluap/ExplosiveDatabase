<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditWindow
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
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TxtFumeClass = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtEndUse = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtProductName = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtMine = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtVelocity = New System.Windows.Forms.TextBox()
		Me.txtDiameter = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TxtDensity = New System.Windows.Forms.TextBox()
		Me.VelocityList = New System.Windows.Forms.ListView()
		Me.CartridgeDiameter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.DetonationVelocity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Panel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label5
		'
		Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(51, 134)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(105, 20)
		Me.Label5.TabIndex = 16
		Me.Label5.Text = "Density (g/cc)"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'TxtFumeClass
		'
		Me.TxtFumeClass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtFumeClass.Location = New System.Drawing.Point(162, 99)
		Me.TxtFumeClass.Name = "TxtFumeClass"
		Me.TxtFumeClass.Size = New System.Drawing.Size(577, 26)
		Me.TxtFumeClass.TabIndex = 4
		'
		'Label4
		'
		Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(63, 102)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(93, 20)
		Me.Label4.TabIndex = 15
		Me.Label4.Text = "Fume Class"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label2
		'
		Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 70)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(153, 20)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Application End Use"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'TxtEndUse
		'
		Me.TxtEndUse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtEndUse.Location = New System.Drawing.Point(162, 67)
		Me.TxtEndUse.Name = "TxtEndUse"
		Me.TxtEndUse.Size = New System.Drawing.Size(577, 26)
		Me.TxtEndUse.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(22, 38)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(134, 20)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Explosive Product"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'TxtProductName
		'
		Me.TxtProductName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtProductName.Location = New System.Drawing.Point(162, 35)
		Me.TxtProductName.Name = "TxtProductName"
		Me.TxtProductName.Size = New System.Drawing.Size(577, 26)
		Me.TxtProductName.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(113, 6)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(43, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Mine"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'TxtMine
		'
		Me.TxtMine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtMine.Location = New System.Drawing.Point(162, 3)
		Me.TxtMine.Name = "TxtMine"
		Me.TxtMine.Size = New System.Drawing.Size(577, 26)
		Me.TxtMine.TabIndex = 1
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
		Me.Panel1.Controls.Add(Me.btnDelete)
		Me.Panel1.Controls.Add(Me.btnAdd)
		Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
		Me.Panel1.Controls.Add(Me.TxtDensity)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.TxtFumeClass)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Controls.Add(Me.VelocityList)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.TxtEndUse)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.TxtProductName)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.TxtMine)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(742, 662)
		Me.Panel1.TabIndex = 18
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.btnCancel, 1, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 607)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(727, 45)
		Me.TableLayoutPanel2.TabIndex = 21
		'
		'btnSave
		'
		Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnSave.Location = New System.Drawing.Point(3, 3)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(357, 39)
		Me.btnSave.TabIndex = 0
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnCancel.Location = New System.Drawing.Point(366, 3)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(358, 39)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnDelete
		'
		Me.btnDelete.Enabled = False
		Me.btnDelete.Location = New System.Drawing.Point(450, 554)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(289, 35)
		Me.btnDelete.TabIndex = 9
		Me.btnDelete.Text = "Delete Selected"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(453, 504)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(286, 32)
		Me.btnAdd.TabIndex = 8
		Me.btnAdd.Text = "Add Table Entry"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.txtVelocity, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.txtDiameter, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 501)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(435, 100)
		Me.TableLayoutPanel1.TabIndex = 18
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(3, 50)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(147, 20)
		Me.Label7.TabIndex = 19
		Me.Label7.Text = "Detonation Velocity"
		'
		'txtVelocity
		'
		Me.txtVelocity.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtVelocity.Location = New System.Drawing.Point(156, 53)
		Me.txtVelocity.Name = "txtVelocity"
		Me.txtVelocity.Size = New System.Drawing.Size(276, 26)
		Me.txtVelocity.TabIndex = 7
		'
		'txtDiameter
		'
		Me.txtDiameter.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtDiameter.Location = New System.Drawing.Point(156, 3)
		Me.txtDiameter.Name = "txtDiameter"
		Me.txtDiameter.Size = New System.Drawing.Size(276, 26)
		Me.txtDiameter.TabIndex = 6
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(3, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(143, 20)
		Me.Label6.TabIndex = 17
		Me.Label6.Text = "Cartridge Diameter"
		'
		'TxtDensity
		'
		Me.TxtDensity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxtDensity.Location = New System.Drawing.Point(162, 131)
		Me.TxtDensity.Name = "TxtDensity"
		Me.TxtDensity.Size = New System.Drawing.Size(577, 26)
		Me.TxtDensity.TabIndex = 5
		'
		'VelocityList
		'
		Me.VelocityList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.VelocityList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CartridgeDiameter, Me.DetonationVelocity})
		Me.VelocityList.FullRowSelect = True
		Me.VelocityList.Location = New System.Drawing.Point(3, 163)
		Me.VelocityList.MultiSelect = False
		Me.VelocityList.Name = "VelocityList"
		Me.VelocityList.Size = New System.Drawing.Size(736, 317)
		Me.VelocityList.TabIndex = 12
		Me.VelocityList.UseCompatibleStateImageBehavior = False
		Me.VelocityList.View = System.Windows.Forms.View.Details
		'
		'CartridgeDiameter
		'
		Me.CartridgeDiameter.Text = "Cartridge Diameter"
		Me.CartridgeDiameter.Width = 164
		'
		'DetonationVelocity
		'
		Me.DetonationVelocity.Text = "Detination Velocity"
		Me.DetonationVelocity.Width = 157
		'
		'EditWindow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(742, 662)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "EditWindow"
		Me.Text = "EditWindow"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Label5 As Label
    Friend WithEvents TxtFumeClass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEndUse As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMine As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents VelocityList As ListView
    Friend WithEvents CartridgeDiameter As ColumnHeader
    Friend WithEvents DetonationVelocity As ColumnHeader
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVelocity As TextBox
    Friend WithEvents txtDiameter As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents TxtDensity As TextBox
End Class
