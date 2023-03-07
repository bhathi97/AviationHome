Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows

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






End Class