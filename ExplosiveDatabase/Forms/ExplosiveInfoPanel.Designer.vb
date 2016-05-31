<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExplosiveInfoPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMine = New System.Windows.Forms.TextBox()
        Me.TxtProductName = New System.Windows.Forms.TextBox()
        Me.TxtEndUse = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFumeClass = New System.Windows.Forms.TextBox()
        Me.TxtDensity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VelocityList = New System.Windows.Forms.ListView()
        Me.CartridgeDiameter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DetonationVelocity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TxtMine.ReadOnly = True
        Me.TxtMine.Size = New System.Drawing.Size(621, 26)
        Me.TxtMine.TabIndex = 3
        '
        'TxtProductName
        '
        Me.TxtProductName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtProductName.Location = New System.Drawing.Point(162, 35)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.ReadOnly = True
        Me.TxtProductName.Size = New System.Drawing.Size(621, 26)
        Me.TxtProductName.TabIndex = 4
        '
        'TxtEndUse
        '
        Me.TxtEndUse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEndUse.Location = New System.Drawing.Point(162, 67)
        Me.TxtEndUse.Name = "TxtEndUse"
        Me.TxtEndUse.ReadOnly = True
        Me.TxtEndUse.Size = New System.Drawing.Size(621, 26)
        Me.TxtEndUse.TabIndex = 5
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
        'TxtFumeClass
        '
        Me.TxtFumeClass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFumeClass.Location = New System.Drawing.Point(162, 99)
        Me.TxtFumeClass.Name = "TxtFumeClass"
        Me.TxtFumeClass.ReadOnly = True
        Me.TxtFumeClass.Size = New System.Drawing.Size(621, 26)
        Me.TxtFumeClass.TabIndex = 13
        '
        'TxtDensity
        '
        Me.TxtDensity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDensity.Location = New System.Drawing.Point(162, 131)
        Me.TxtDensity.Name = "TxtDensity"
        Me.TxtDensity.ReadOnly = True
        Me.TxtDensity.Size = New System.Drawing.Size(621, 26)
        Me.TxtDensity.TabIndex = 14
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
        'Panel1
        '
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
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 1037)
        Me.Panel1.TabIndex = 17
        '
        'VelocityList
        '
        Me.VelocityList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VelocityList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CartridgeDiameter, Me.DetonationVelocity})
        Me.VelocityList.Location = New System.Drawing.Point(3, 163)
        Me.VelocityList.Name = "VelocityList"
        Me.VelocityList.Size = New System.Drawing.Size(780, 871)
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
        'ExplosiveInfoPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ExplosiveInfoPanel"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(792, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMine As TextBox
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents TxtEndUse As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFumeClass As TextBox
    Friend WithEvents TxtDensity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents VelocityList As ListView
    Friend WithEvents CartridgeDiameter As ColumnHeader
    Friend WithEvents DetonationVelocity As ColumnHeader
End Class
