Imports System.IO
Imports MathNet.Numerics

Public Class ReportForm
    Private _product As ExplosiveProduct
	Private Const CSV_SEPARATOR As String = ","
	Private Const PRINT_SEPARATOR As String = " "
	Private Const TABLE_COLUMN_WIDTH = 25
	Private Const INFO_COLUMN_WIDTH = 25
	Private outputLines As List(Of String)

	Public Property Product As ExplosiveProduct
        Get
            Return _product
        End Get
        Set(value As ExplosiveProduct)
            _product = value
        End Set
    End Property

    ''' <summary>
    ''' Builds the string that can either be exported as a CSV or printed to the print document. 
    ''' </summary>
    ''' <param name="sep">String containing the character separator to use between fields. </param>
    ''' <returns></returns>
    Private Function PrepareDocumentStrings(sep As String) As List(Of String)
        Dim lines = New List(Of String)
		If checkDisplayProductInfo.Checked Then ' print product information if required
			' using padright to align all entries. 
			' TODO: pretty formatting if any text is longer than max. line length.
			lines.Add("Mine".PadRight(INFO_COLUMN_WIDTH) & sep & Product.MineName)
			lines.Add("Product Name".PadRight(INFO_COLUMN_WIDTH) & sep & Product.ProductName)
			lines.Add("Application End Use".PadRight(INFO_COLUMN_WIDTH) & sep & Product.ApplicationEndUse)
			lines.Add("Fume Class".PadRight(INFO_COLUMN_WIDTH) & sep & Product.FumeClass)
			lines.Add("Explosive Density (g/cc)".PadRight(INFO_COLUMN_WIDTH & sep & String.Format("{0:#.##}", Product.Density)))
			lines.Add("") ' separate the table from the header information
		End If
		If checkDisplayImperial.Checked Or checkDisplayMetric.Checked Then
			' print header info in the proper form
			Dim s As String = ""
			If checkDisplayMetric.Checked Then
				s += "Cart. Diameter (mm)".PadRight(TABLE_COLUMN_WIDTH) & sep
			End If
			If checkDisplayImperial.Checked Then
				s += "Cart. Diameter (inches)".PadRight(TABLE_COLUMN_WIDTH)
			End If
			If checkDisplayMetric.Checked Then
				s += sep & "Det. Velocity (m/sec)".PadRight(TABLE_COLUMN_WIDTH)
			End If
			If checkDisplayImperial.Checked Then
				s += sep & "Det. Velocity (ft/sec)".PadRight(TABLE_COLUMN_WIDTH)
			End If
			lines.Add(s)
			If btnPreDefinedVelocities.Checked Then ' For pre-defined velocities we just pull the velocity entries that live in the table. 
				For Each entry As DetVelocityEntry In Product.VelocityEntries ' populate the velocity table. 
					lines.Add(GetTableString(entry, sep))
				Next

			ElseIf btnInterpolatedVelocities.Checked Then ' create a linear spacing and attempt to perform an interpolation
				Dim startDiam As Double
				Dim stopDiam As Double
				Dim n = Integer.Parse(txtNumEntries.Text)
				If unitInches.Checked Then
					startDiam = Double.Parse(txtSmallestDiameter.Text)
					stopDiam = Double.Parse(txtLargestDiameter.Text)
				ElseIf unitMilimeters.Checked Then
					startDiam = MmToInch(Double.Parse(txtSmallestDiameter.Text))
					stopDiam = MmToInch(Double.Parse(txtLargestDiameter.Text))
				End If
				Dim xx = Generate.LinearSpaced(n, startDiam, stopDiam)
				For Each x As Double In xx
					Trace.WriteLine("adding velocity entry for diameter" & x)
					' possible RegressionException trickles up if it occurs, is caught in the button press handler. 
					lines.Add(GetTableString(New DetVelocityEntry(x, Product.InterpolateDetVelocity(x)), sep))
				Next

			End If
		End If
		Return lines
	End Function

	''' <summary>
	''' Generate a table row for the specified velocity entry. 
	''' </summary>
	''' <param name="entry"></param>
	''' <param name="sep"></param>
	''' <returns></returns>
	Private Function GetTableString(entry As DetVelocityEntry, sep As String) As String
		Dim l As String = ""
		If checkDisplayMetric.Checked Then
			l += String.Format("{0:#.##}", InchToMm(entry.Diameter)).PadRight(TABLE_COLUMN_WIDTH) & sep
		End If
		If checkDisplayImperial.Checked Then
			l += String.Format("{0:#.##}", entry.Diameter).PadRight(TABLE_COLUMN_WIDTH)
		End If
		If checkDisplayMetric.Checked Then
			l += sep & String.Format("{0:#.##}", FeetToMetres(entry.DetVelocity)).PadRight(TABLE_COLUMN_WIDTH)
		End If
		If checkDisplayImperial.Checked Then
			l += sep & String.Format("{0:#.##}", entry.DetVelocity).PadRight(TABLE_COLUMN_WIDTH)
		End If
		Return l
	End Function

	Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDocument.PrintPage
		Dim linesPerPage As Double = 0
		Dim yPos As Double = 0
		Dim count As Integer = 0
		Dim leftMargin As Double = e.MarginBounds.Left
		Dim topMargin As Double = e.MarginBounds.Top
		Dim line As String = Nothing
		Dim font As New Font("Courier New", 10)

		' calculate number of lines per page
		linesPerPage = e.MarginBounds.Height / font.GetHeight(e.Graphics)
		' print each line of the file
		While count < linesPerPage
			If outputLines.Count = 0 Then
				Exit While
			End If
			line = outputLines.ElementAt(0)
			outputLines.RemoveAt(0)
			If line Is Nothing Then
				Exit While
			End If
			yPos = topMargin + count * font.GetHeight(e.Graphics)
			e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos, New StringFormat())
			count += 1
		End While
		' if more lines exist, print another page
		If line IsNot Nothing Then
			e.HasMorePages = True
		Else
			e.HasMorePages = False
		End If
	End Sub

	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
		Try
			Me.outputLines = PrepareDocumentStrings(PRINT_SEPARATOR)
		Catch ex As RegressionException ' the regression fails because there are not enough velocity entries
			MsgBox(ex.Message)
			Return
		End Try

		printDialog.PrinterSettings.DefaultPageSettings.Landscape = True ' so the columns fit on the page properly. 
		If printDialog.ShowDialog() = DialogResult.OK Then
			printDocument.PrinterSettings = printDialog.PrinterSettings
			printDocument.Print()
		End If

	End Sub

	Private Sub btnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
		Try
			Me.outputLines = PrepareDocumentStrings(CSV_SEPARATOR)
		Catch ex As RegressionException ' the regression fails because there are not enough velocity entries
			MsgBox(ex.Message)
			Return
		End Try
		Dim saveDialog = New SaveFileDialog()
		saveDialog.DefaultExt = "csv"
		If saveDialog.ShowDialog = DialogResult.OK Then
			Dim f = New StreamWriter(saveDialog.FileName)
			For Each line As String In outputLines
				f.WriteLine(line)
			Next
			f.Close()
		End If
	End Sub

	' Pre-defined velocities button disables the interpolate settings since settings dont' matter
	Private Sub btnPreDefinedVelocities_CheckedChanged(sender As Object, e As EventArgs) Handles btnPreDefinedVelocities.CheckedChanged
		If btnPreDefinedVelocities.Checked Then
			grpInterpolationSettings.Enabled = False
		End If
	End Sub

	Private Sub btnInterpolatedVelocities_CheckedChanged(sender As Object, e As EventArgs) Handles btnInterpolatedVelocities.CheckedChanged
		If btnInterpolatedVelocities.Checked Then
			grpInterpolationSettings.Enabled = True
		End If
	End Sub

End Class