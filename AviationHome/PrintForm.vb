﻿Imports System.Windows
Imports System.Windows.Controls
Imports PdfSharpCore.Drawing
Imports PdfSharpCore.Pdf
Imports System.Drawing



'-------------------

Imports PdfSharpCore
Imports System.IO
Imports System.Drawing.Imaging



'-------------------



Public Class PrintForm


    Public Property Data As DataTable

    Private Sub PrintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateShower.Text = HomeForm.tpDate.Text 'load date from home form
        shiftTimeShower.Text = HomeForm.cbShiftTime.Text 'load shift time from home form 
        dayShower.Text = HomeForm.lblForShowingDay.Text 'load day from home form
        shiftShower.Text = HomeForm.lblShiftShowing.Text 'load shift from home form

        ' Load the data from the DataTable into the DataGridView
        dgPrint.AutoGenerateColumns = False
        dgPrint.DataSource = Data
        dgPrint.Columns("Column1").DataPropertyName = "Column1"
        dgPrint.Columns("Column2").DataPropertyName = "Column2"
        dgPrint.Columns("Column3").DataPropertyName = "Column3"
        dgPrint.Columns("Column4").DataPropertyName = "Column4"
        dgPrint.Columns("Column5").DataPropertyName = "Column5"
        dgPrint.Columns("Column6").DataPropertyName = "Column6"
        dgPrint.Columns("Column7").DataPropertyName = "Column7"
        dgPrint.Columns("Column8").DataPropertyName = "Column8"
        dgPrint.Columns("Column9").DataPropertyName = "Column9"


    End Sub



    Private Sub btnPdf_Click(sender As Object, e As EventArgs) Handles btnPdf.Click

        CreatePDF()

    End Sub



    Public Sub CreatePDF()
        ' Create a new PDF document
        Dim document As New PdfDocument()

        ' Add a new page to the document
        Dim page As PdfPage = document.AddPage()

        ' Set the page size to A4
        page.Width = XUnit.FromMillimeter(210)
        page.Height = XUnit.FromMillimeter(297)

        ' Create a PDF graphics object to draw on the page
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

        ' Add some text to the page
        Dim font As New XFont("Times New Roman", 16.5)
        gfx.DrawString("CEYLON PETROLEUM CORPORATION - AVIATION FUNCTION", font, XBrushes.Black, New XRect(45, 10, page.Width.Point - 100, 50), XStringFormats.Center)

        Dim font1 As New XFont("Times New Roman", 14, XFontStyle.Bold Or XFontStyle.Underline)
        gfx.DrawString("DAILY WORK SCHEDULE", font1, XBrushes.Black, New XRect(55, 32, page.Width.Point - 100, 50), XStringFormats.Center)

        ' Get the image from the picture box
        Dim image As System.Drawing.Image = PictureBox2.Image

        ' Convert the image to a byte array
        Dim ms As New MemoryStream()
        image.Save(ms, image.RawFormat)
        Dim imageBytes() As Byte = ms.ToArray()

        ' Create a new XImage object from the byte array
        Dim xImage As XImage = XImage.FromStream(Function() New MemoryStream(imageBytes))

        ' Draw the image on the page
        gfx.DrawImage(xImage, New XRect(10, 40, 100, 50))
        gfx.DrawImage(xImage, New XRect(480, 40, 100, 50))



        '------------
        ' Draw the dateShower label text on the page
        Dim fontLbl As New XFont("Times New Roman", 13)

        Dim dateText As String = "Date:           " + dateShower.Text '  Label control data of date
        gfx.DrawString(dateText, fontLbl, XBrushes.Black, New XRect(100, 75, page.Width.Point - 20, 50), XStringFormats.TopLeft)


        Dim shiftTimeText As String = "Shift Time: " + shiftTimeShower.Text '  Label control of shift time 
        gfx.DrawString(shiftTimeText, fontLbl, XBrushes.Black, New XRect(100, 90, page.Width.Point - 20, 50), XStringFormats.TopLeft)

        Dim dayText As String = "Day:  " + dayShower.Text '  Label control of day 
        gfx.DrawString(dayText, fontLbl, XBrushes.Black, New XRect(400, 75, page.Width.Point - 20, 50), XStringFormats.TopLeft)

        Dim shiftText As String = "Shift: " + shiftShower.Text '  Label control of day 
        gfx.DrawString(shiftText, fontLbl, XBrushes.Black, New XRect(400, 90, page.Width.Point - 20, 50), XStringFormats.TopLeft)


        'draw datagridview----------------------------------
        ' Define the table layout
        Dim tableWidth As Double = 570
        Dim columnWidths As Double() = {50, 30, 70, 60, 80, 70, 70, 70, 70}
        Dim rowHeight As Double = 40
        Dim tableTop As Double = 110


        ' Draw the table header
        Dim tableHeaderFont As New XFont("Times New Roman", 12, XFontStyle.Bold)
        Dim tableHeaderPen As New XPen(XColors.Black, 1) ' Set the border color and width
        Dim tableHeaderRect As XRect


        ' Draw the header cells and their borders
        tableHeaderRect = New XRect(10, tableTop, 50, rowHeight)
        gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
        gfx.DrawString("BAY NO", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

        tableHeaderRect = New XRect(10 + 50, tableTop, 30, rowHeight)
        gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
        gfx.DrawString("NO", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

        tableHeaderRect = New XRect(10 + 80, tableTop, 70, rowHeight)
        gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
        gfx.DrawString("FLIGHT", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

        tableHeaderRect = New XRect(10 + 150, tableTop, 60, rowHeight)
        gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
        gfx.DrawString("ETA", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

        tableHeaderRect = New XRect(10 + 210, tableTop, 80, rowHeight)
        gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
        gfx.DrawString("AIRLINES", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

        tableHeaderRect = New XRect(10 + 290, tableTop, 70, rowHeight)
        gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
        gfx.DrawString("RIC", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

        tableHeaderRect = New XRect(10 + 360, tableTop, 70, rowHeight)
        gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
        gfx.DrawString("OPERATOR", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

        tableHeaderRect = New XRect(10 + 430, tableTop, 70, rowHeight)
        gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
        gfx.DrawString("CREWMAN", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

        tableHeaderRect = New XRect(10 + 500, tableTop, 70, rowHeight)
        gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
        gfx.DrawString("REMARKS", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)



        ' Repeat for all table columns


        ' Draw the table data
        Dim tableFont As New XFont("Times New Roman", 10)
        Dim tableLeft As Double = 10
        Dim tableBottom As Double = tableTop + (16 * rowHeight) ' Only draw first 16 rows
        Dim currentRow As Integer = 0



        ' Draw the table border
        Dim pen As New XPen(XColors.Black, 0.5)
        Dim x1 As Double = tableLeft
        Dim x2 As Double = tableLeft + tableWidth
        Dim y1 As Double = tableTop
        Dim y2 As Double = tableBottom
        gfx.DrawLine(pen, x1, y1, x2, y1) ' top border
        gfx.DrawLine(pen, x1, y2, x2, y2) ' bottom border
        gfx.DrawLine(pen, x1, y1, x1, y2) ' left border
        gfx.DrawLine(pen, x2, y1, x2, y2) ' right border

        ' Draw the rows
        Dim rowPen As New XPen(XColors.Black, 0.2) ' Set the border color and width
        For i As Integer = 0 To dgPrint.Rows.Count - 1 ' loop through rows including header row
            If i >= 16 Then Exit For ' Only draw first 16 rows

            Dim y As Double = tableTop + (i + 1) * rowHeight
            gfx.DrawLine(rowPen, x1, y, x2, y) ' draw horizontal line between rows

            ' Draw the data in the cells
            Dim cellRect As New XRect(tableLeft, y, 50, rowHeight)
            gfx.DrawRectangle(rowPen, cellRect)
            gfx.DrawString(dgPrint.Rows(i).Cells("Column1").Value.ToString(), tableFont, XBrushes.Black, cellRect, XStringFormats.Center)

            cellRect = New XRect(tableLeft + 50, y, 30, rowHeight)
            gfx.DrawRectangle(rowPen, cellRect)
            gfx.DrawString(dgPrint.Rows(i).Cells("Column2").Value.ToString(), tableFont, XBrushes.Black, cellRect, XStringFormats.Center)

            cellRect = New XRect(tableLeft + 80, y, 70, rowHeight)
            gfx.DrawRectangle(rowPen, cellRect)
            gfx.DrawString(dgPrint.Rows(i).Cells("Column3").Value.ToString(), tableFont, XBrushes.Black, cellRect, XStringFormats.Center)

            cellRect = New XRect(tableLeft + 150, y, 60, rowHeight)
            gfx.DrawRectangle(rowPen, cellRect)
            gfx.DrawString(dgPrint.Rows(i).Cells("Column4").Value.ToString(), tableFont, XBrushes.Black, cellRect, XStringFormats.Center)

            cellRect = New XRect(tableLeft + 210, y, 80, rowHeight)
            gfx.DrawRectangle(rowPen, cellRect)
            gfx.DrawString(dgPrint.Rows(i).Cells("Column5").Value.ToString(), tableFont, XBrushes.Black, cellRect, XStringFormats.Center)

            cellRect = New XRect(tableLeft + 290, y, 70, rowHeight)
            gfx.DrawRectangle(rowPen, cellRect)
            gfx.DrawString(dgPrint.Rows(i).Cells("Column6").Value.ToString(), tableFont, XBrushes.Black, cellRect, XStringFormats.Center)

            cellRect = New XRect(tableLeft + 360, y, 70, rowHeight)
            gfx.DrawRectangle(rowPen, cellRect)
            gfx.DrawString(dgPrint.Rows(i).Cells("Column7").Value.ToString(), tableFont, XBrushes.Black, cellRect, XStringFormats.Center)

            cellRect = New XRect(tableLeft + 430, y, 70, rowHeight)
            gfx.DrawRectangle(rowPen, cellRect)
            gfx.DrawString(dgPrint.Rows(i).Cells("Column8").Value.ToString(), tableFont, XBrushes.Black, cellRect, XStringFormats.Center)

            cellRect = New XRect(tableLeft + 500, y, 70, rowHeight)
            gfx.DrawRectangle(rowPen, cellRect)
            gfx.DrawString(dgPrint.Rows(i).Cells("Column9").Value.ToString(), tableFont, XBrushes.Black, cellRect, XStringFormats.Center)


            ' ... repeat for all table columns
        Next

        ' Save the document to the desktop
        Dim desktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim filename As String = desktopFolder + "\test.pdf"
        document.Save(filename)


        MsgBox("dffeefeg")
    End Sub





End Class