<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.grpInterpolationSettings = New System.Windows.Forms.GroupBox()
		Me.unitMilimeters = New System.Windows.Forms.RadioButton()
		Me.unitInches = New System.Windows.Forms.RadioButton()
		Me.txtNumEntries = New System.Windows.Forms.TextBox()
		Me.txtLargestDiameter = New System.Windows.Forms.TextBox()
		Me.txtSmallestDiameter = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnInterpolatedVelocities = New System.Windows.Forms.RadioButton()
		Me.btnPreDefinedVelocities = New System.Windows.Forms.RadioButton()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.checkDisplayMetric = New System.Windows.Forms.CheckBox()
		Me.checkDisplayImperial = New System.Windows.Forms.CheckBox()
		Me.checkDisplayProductInfo = New System.Windows.Forms.CheckBox()
		Me.btnCSV = New System.Windows.Forms.Button()
		Me.printDialog = New System.Windows.Forms.PrintDialog()
		Me.printDocument = New System.Drawing.Printing.PrintDocument()
		Me.GroupBox1.SuspendLayout()
		Me.grpInterpolationSettings.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.grpInterpolationSettings)
		Me.GroupBox1.Controls.Add(Me.btnInterpolatedVelocities)
		Me.GroupBox1.Controls.Add(Me.btnPreDefinedVelocities)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(464, 239)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Velocity Table Configuration"
		'
		'grpInterpolationSettings
		'
		Me.grpInterpolationSettings.Controls.Add(Me.unitMilimeters)
		Me.grpInterpolationSettings.Controls.Add(Me.unitInches)
		Me.grpInterpolationSettings.Controls.Add(Me.txtNumEntries)
		Me.grpInterpolationSettings.Controls.Add(Me.txtLargestDiameter)
		Me.grpInterpolationSettings.Controls.Add(Me.txtSmallestDiameter)
		Me.grpInterpolationSettings.Controls.Add(Me.Label3)
		Me.grpInterpolationSettings.Controls.Add(Me.Label2)
		Me.grpInterpolationSettings.Controls.Add(Me.Label1)
		Me.grpInterpolationSettings.Location = New System.Drawing.Point(7, 86)
		Me.grpInterpolationSettings.Name = "grpInterpolationSettings"
		Me.grpInterpolationSettings.Size = New System.Drawing.Size(439, 133)
		Me.grpInterpolationSettings.TabIndex = 2
		Me.grpInterpolationSettings.TabStop = False
		'
		'unitMilimeters
		'
		Me.unitMilimeters.AutoSize = True
		Me.unitMilimeters.Location = New System.Drawing.Point(278, 57)
		Me.unitMilimeters.Name = "unitMilimeters"
		Me.unitMilimeters.Size = New System.Drawing.Size(60, 24)
		Me.unitMilimeters.TabIndex = 7
		Me.unitMilimeters.Text = "mm"
		Me.unitMilimeters.UseVisualStyleBackColor = True
		'
		'unitInches
		'
		Me.unitInches.AutoSize = True
		Me.unitInches.Checked = True
		Me.unitInches.Location = New System.Drawing.Point(278, 29)
		Me.unitInches.Name = "unitInches"
		Me.unitInches.Size = New System.Drawing.Size(82, 24)
		Me.unitInches.TabIndex = 6
		Me.unitInches.TabStop = True
		Me.unitInches.Text = "Inches"
		Me.unitInches.UseVisualStyleBackColor = True
		'
		'txtNumEntries
		'
		Me.txtNumEntries.Location = New System.Drawing.Point(155, 92)
		Me.txtNumEntries.Name = "txtNumEntries"
		Me.txtNumEntries.Size = New System.Drawing.Size(100, 26)
		Me.txtNumEntries.TabIndex = 5
		'
		'txtLargestDiameter
		'
		Me.txtLargestDiameter.Location = New System.Drawing.Point(155, 59)
		Me.txtLargestDiameter.Name = "txtLargestDiameter"
		Me.txtLargestDiameter.Size = New System.Drawing.Size(100, 26)
		Me.txtLargestDiameter.TabIndex = 4
		'
		'txtSmallestDiameter
		'
		Me.txtSmallestDiameter.Location = New System.Drawing.Point(155, 26)
		Me.txtSmallestDiameter.Name = "txtSmallestDiameter"
		Me.txtSmallestDiameter.Size = New System.Drawing.Size(100, 26)
		Me.txtSmallestDiameter.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 95)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(137, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Number of Entries"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(17, 62)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(132, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Largest Diameter"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 29)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(139, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Smallest Diameter"
		'
		'btnInterpolatedVelocities
		'
		Me.btnInterpolatedVelocities.AutoSize = True
		Me.btnInterpolatedVelocities.Location = New System.Drawing.Point(6, 55)
		Me.btnInterpolatedVelocities.Name = "btnInterpolatedVelocities"
		Me.btnInterpolatedVelocities.Size = New System.Drawing.Size(275, 24)
		Me.btnInterpolatedVelocities.TabIndex = 1
		Me.btnInterpolatedVelocities.Text = "Interpolated Detonation Velocities"
		Me.btnInterpolatedVelocities.UseVisualStyleBackColor = True
		'
		'btnPreDefinedVelocities
		'
		Me.btnPreDefinedVelocities.AutoSize = True
		Me.btnPreDefinedVelocities.Checked = True
		Me.btnPreDefinedVelocities.Location = New System.Drawing.Point(6, 25)
		Me.btnPreDefinedVelocities.Name = "btnPreDefinedVelocities"
		Me.btnPreDefinedVelocities.Size = New System.Drawing.Size(274, 24)
		Me.btnPreDefinedVelocities.TabIndex = 0
		Me.btnPreDefinedVelocities.TabStop = True
		Me.btnPreDefinedVelocities.Text = "Pre-Defined Detonation Velocities"
		Me.btnPreDefinedVelocities.UseVisualStyleBackColor = True
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(12, 383)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(464, 29)
		Me.btnPrint.TabIndex = 3
		Me.btnPrint.Text = "Print Report"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.checkDisplayMetric)
		Me.GroupBox3.Controls.Add(Me.checkDisplayImperial)
		Me.GroupBox3.Controls.Add(Me.checkDisplayProductInfo)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 258)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(464, 119)
		Me.GroupBox3.TabIndex = 4
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Display Configuration"
		'
		'checkDisplayMetric
		'
		Me.checkDisplayMetric.AutoSize = True
		Me.checkDisplayMetric.Location = New System.Drawing.Point(7, 85)
		Me.checkDisplayMetric.Name = "checkDisplayMetric"
		Me.checkDisplayMetric.Size = New System.Drawing.Size(208, 24)
		Me.checkDisplayMetric.TabIndex = 2
		Me.checkDisplayMetric.Text = "Metric velocity table data"
		Me.checkDisplayMetric.UseVisualStyleBackColor = True
		'
		'checkDisplayImperial
		'
		Me.checkDisplayImperial.AutoSize = True
		Me.checkDisplayImperial.Checked = True
		Me.checkDisplayImperial.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkDisplayImperial.Location = New System.Drawing.Point(6, 55)
		Me.checkDisplayImperial.Name = "checkDisplayImperial"
		Me.checkDisplayImperial.Size = New System.Drawing.Size(221, 24)
		Me.checkDisplayImperial.TabIndex = 1
		Me.checkDisplayImperial.Text = "Imperial velocity table data"
		Me.checkDisplayImperial.UseVisualStyleBackColor = True
		'
		'checkDisplayProductInfo
		'
		Me.checkDisplayProductInfo.AutoSize = True
		Me.checkDisplayProductInfo.Checked = True
		Me.checkDisplayProductInfo.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkDisplayProductInfo.Location = New System.Drawing.Point(6, 25)
		Me.checkDisplayProductInfo.Name = "checkDisplayProductInfo"
		Me.checkDisplayProductInfo.Size = New System.Drawing.Size(175, 24)
		Me.checkDisplayProductInfo.TabIndex = 0
		Me.checkDisplayProductInfo.Text = "Product Information"
		Me.checkDisplayProductInfo.UseVisualStyleBackColor = True
		'
		'btnCSV
		'
		Me.btnCSV.Location = New System.Drawing.Point(12, 418)
		Me.btnCSV.Name = "btnCSV"
		Me.btnCSV.Size = New System.Drawing.Size(464, 29)
		Me.btnCSV.TabIndex = 5
		Me.btnCSV.Text = "Export CSV"
		Me.btnCSV.UseVisualStyleBackColor = True
		'
		'printDialog
		'
		Me.printDialog.UseEXDialog = True
		'
		'printDocument
		'
		'
		'ReportForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(482, 455)
		Me.Controls.Add(Me.btnCSV)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "ReportForm"
		Me.Text = "ReportForm"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.grpInterpolationSettings.ResumeLayout(False)
		Me.grpInterpolationSettings.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpInterpolationSettings As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInterpolatedVelocities As RadioButton
    Friend WithEvents btnPreDefinedVelocities As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents unitMilimeters As RadioButton
    Friend WithEvents unitInches As RadioButton
    Friend WithEvents txtNumEntries As TextBox
    Friend WithEvents txtLargestDiameter As TextBox
    Friend WithEvents txtSmallestDiameter As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents checkDisplayMetric As CheckBox
    Friend WithEvents checkDisplayImperial As CheckBox
    Friend WithEvents checkDisplayProductInfo As CheckBox
    Friend WithEvents btnCSV As Button
    Friend WithEvents printDialog As PrintDialog
    Friend WithEvents printDocument As Printing.PrintDocument
End Class
