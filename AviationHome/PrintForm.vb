Imports System.Windows
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
        gfx.DrawString(dateText, fontLbl, XBrushes.Black, New XRect(100, 85, page.Width.Point - 20, 50), XStringFormats.TopLeft)


        Dim shiftTimeText As String = "Shift Time: " + shiftTimeShower.Text '  Label control of shift time 
        gfx.DrawString(shiftTimeText, fontLbl, XBrushes.Black, New XRect(100, 100, page.Width.Point - 20, 50), XStringFormats.TopLeft)

        Dim dayText As String = "Day:  " + dayShower.Text '  Label control of day 
        gfx.DrawString(dayText, fontLbl, XBrushes.Black, New XRect(400, 85, page.Width.Point - 20, 50), XStringFormats.TopLeft)

        Dim shiftText As String = "Shift: " + shiftShower.Text '  Label control of day 
        gfx.DrawString(shiftText, fontLbl, XBrushes.Black, New XRect(400, 100, page.Width.Point - 20, 50), XStringFormats.TopLeft)






        ' Save the document to the desktop
        Dim desktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim filename As String = desktopFolder + "\test.pdf"
        document.Save(filename)


        MsgBox("dffeefeg")
    End Sub





End Class