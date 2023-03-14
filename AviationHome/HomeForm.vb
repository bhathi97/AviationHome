Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel
Imports System.Windows.Forms
Imports System.Windows.Controls
Imports System.Net.Security
Imports System.Drawing.Printing
Imports Control = System.Windows.Forms.Control
Imports Label = System.Windows.Forms.Label
Imports System.Data.Common
Imports System.Windows.Interop
Imports ClosedXML.Excel
Imports System.Windows
Imports MessageBox = System.Windows.Forms.MessageBox
Imports DragEventArgs = System.Windows.Forms.DragEventArgs




Public Class HomeForm

    'connection string
    Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load simple choices A, B, C, D into cbGroupPicker combo box'
        cbGroupPicker.Items.Add("A")
        cbGroupPicker.Items.Add("B")
        cbGroupPicker.Items.Add("C")
        cbGroupPicker.Items.Add("D")

        'load shift time
        cbShiftTime.Items.Add("07.00 - 19.00")
        cbShiftTime.Items.Add("19.00 - 07.00")

        'load day
        DataTimePickerAllCommands.changeDayLblWhenLoading(Me)

    End Sub

    'adding crew members to listBox
    Private Sub cbGroupPicker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroupPicker.SelectedIndexChanged
        LoadCrewMembersAccordingToGroupName.LoadDataToListBoxes(sender, e, Me)
    End Sub

    'change the order of text of crewman
    Private Sub lvCrewman_MouseDown(sender As Object, e As MouseEventArgs) Handles lvCrewman.MouseDown
        CrewMembersOrderChangingCommand.dragWantedItem(sender, e, Me)
    End Sub

    Private Sub lvCrewman_DragEnter(sender As Object, e As DragEventArgs) Handles lvCrewman.DragEnter
        CrewMembersOrderChangingCommand.dragOverOtherItems(sender, e)
    End Sub

    Private Sub lvCrewman_DragOver(sender As Object, e As DragEventArgs) Handles lvCrewman.DragOver
        CrewMembersOrderChangingCommand.dropWantedItem(sender, e, Me)
    End Sub


    'change the order of RIC lisBox
    Private Sub lvRic_MouseDown(sender As Object, e As MouseEventArgs) Handles lvRic.MouseDown
        CrewMembersOrderChangingCommand.dragWantedItem(sender, e, Me)
    End Sub

    Private Sub lvRic_DragEnter(sender As Object, e As DragEventArgs) Handles lvRic.DragEnter
        CrewMembersOrderChangingCommand.dragOverOtherItems(sender, e)
    End Sub

    Private Sub lvRic_DragOver(sender As Object, e As DragEventArgs) Handles lvRic.DragOver
        CrewMembersOrderChangingCommand.dropWantedItem(sender, e, Me)
    End Sub

    'detlete selected item from boxes
    'CM
    Private Sub RemoveCM_Click(sender As Object, e As EventArgs) Handles RemoveCM.Click
        If lvCrewman.SelectedIndex <> -1 Then

            'to collect removed items
            Dim removedCM = lvCrewman.SelectedItem
            cbRemovedCM.Items.Add(removedCM)
            lvCrewman.Items.RemoveAt(lvCrewman.SelectedIndex)


        End If
    End Sub
    'RIC
    Private Sub RemoveRIC_Click(sender As Object, e As EventArgs) Handles RemoveRIC.Click
        If lvRic.SelectedIndex <> -1 Then

            'to collect removed RIC
            Dim removedRIC = lvRic.SelectedItem
            cbRemovedRIC.Items.Add(removedRIC)
            lvRic.Items.RemoveAt(lvRic.SelectedIndex)
        End If
    End Sub

    'add back to the list
    'CM
    Private Sub btnAddCMBack_Click(sender As Object, e As EventArgs) Handles btnAddCMBack.Click

        Try
            Dim backToList = cbRemovedCM.SelectedItem
            lvCrewman.Items.Add(backToList)
            cbRemovedCM.Items.Remove(backToList)

            'visible item must be hadleled - peena ekath clear venna oona

        Catch ex As Exception

        End Try

    End Sub
    'RIC
    Private Sub btnAddRICBack_Click(sender As Object, e As EventArgs) Handles btnAddRICBack.Click

        Try
            Dim backToRIC = cbRemovedRIC.SelectedItem
            lvRic.Items.Add(backToRIC)
            cbRemovedRIC.Items.Remove(backToRIC)
        Catch ex As Exception

        End Try

    End Sub


    'timePicker
    Private Sub tpDate_ValueChanged(sender As Object, e As EventArgs) Handles tpDate.ValueChanged
        'dat lbl value 
        DataTimePickerAllCommands.DayLblWhenPickerValueChanged(Me)

    End Sub



    Private Sub cbShiftTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbShiftTime.SelectedIndexChanged
        If cbShiftTime.SelectedItem = "07.00 - 19.00" Then
            lblShiftShowing.Text = "Day"
        ElseIf cbShiftTime.SelectedItem = "19.00 - 07.00" Then
            lblShiftShowing.Text = "Night"
        End If
    End Sub

    'add cm to the datagrid 
    Private Sub btnCMAddToTable_Click(sender As Object, e As EventArgs) Handles btnCMAddToTable.Click

        Try

            '--------------
            Dim itemCount As Integer = lvCrewman.Items.Count 'listview column count
            Dim flag As Integer = 0

            'loop thruogh the table rows
            If itemCount <> 1 Then

                For i As Integer = 0 To dgvMain.Rows.Count - 1
                    If flag < itemCount Then

                        dgvMain.Rows(i).Cells("Column8").Value = lvCrewman.Items(flag).ToString()
                        flag += 1
                        If flag = itemCount Then flag = 0 ' reset flag if it reaches the end of the ListView

                    End If
                Next

                'loop thruogh the table rows

                'if there is only one item 

            ElseIf itemCount = 1 Then

                For i As Integer = 0 To dgvMain.RowCount - 1

                    dgvMain.Rows(i).Cells("Column8").Value = lvCrewman.Items(0).ToString()
                Next

            End If


        Catch ex As Exception

        End Try





    End Sub

    Private Sub btnRICAddToTable_Click(sender As Object, e As EventArgs) Handles btnRICAddToTable.Click


        Try

            '--------------
            Dim itemCount1 As Integer = lvRic.Items.Count 'listview column count
            Dim flag1 As Integer = 0

            'loop thruogh the table rows
            If itemCount1 <> 1 Then

                For i As Integer = 0 To dgvMain.Rows.Count - 1
                    If flag1 < itemCount1 Then

                        dgvMain.Rows(i).Cells("Column6").Value = lvRic.Items(flag1).ToString()
                        flag1 += 1
                        If flag1 = itemCount1 Then flag1 = 0 ' reset flag if it reaches the end of the ListView

                    End If
                Next

                'loop thruogh the table rows

                'if there is only one item 

            ElseIf itemCount1 = 1 Then

                For i As Integer = 0 To dgvMain.RowCount - 1

                    dgvMain.Rows(i).Cells("Column6").Value = lvRic.Items(0).ToString()
                Next

            End If


        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnAddPlanesToTable_Click(sender As Object, e As EventArgs) Handles btnAddPlanesToTable.Click

        'get the time range
        Dim Criteria As String
        Criteria = lblShiftShowing.Text

        Dim today As Date
        today = tpDate.Text

        Dim con As New SqlConnection(str)

        Try
            con.Open()

            If Criteria.Length <> 0 Then

                'if select Day
                If Criteria = "Day" Then

                    Dim table As DataTable = New DataTable()
                    Dim cmd As New SqlCommand("SELECT FID, ETA FROM [FLIGHT_TIME_TABLE] WHERE [ETA] BETWEEN '07:00:00' AND '19:00:00' AND [DATE] = @date ", con)
                    cmd.Parameters.AddWithValue("@date", today)

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using

                    ' Add the "Flight" column to the DataTable, using the name of the corresponding column in the DataGridView
                    table.Columns.Add("fli", GetType(String))
                    table.Columns.Add("lines", GetType(String))


                    For Each row As DataRow In table.Rows
                        ' Store FID
                        Dim fid As Integer = row("FID")

                        ' Load second table to get flight information
                        Dim cmd2 As New SqlCommand("SELECT [FLIGHT_NO], [AIRLINE_CODE] FROM [FLIGHT_MASTER_TABLE] WHERE FID = @fid", con)
                        cmd2.Parameters.AddWithValue("@fid", fid)
                        Dim reader As SqlDataReader = cmd2.ExecuteReader()

                        If reader.HasRows Then
                            reader.Read()

                            ' Get flight information
                            Dim fNo As Integer = reader("FLIGHT_NO")
                            Dim fCode As String = reader("AIRLINE_CODE")
                            Dim flight As String = fNo.ToString + "-" + fCode

                            ' Set the value of the "Flight" column in the current row
                            row("Fli") = flight

                            reader.Close()
                            '=======================
                            ' Get airline name from AIRLINE_MASTER_TABLE
                            Dim cmd3 As New SqlCommand("SELECT [AIRLINE_NAME] FROM [AIRLINE_MASTER_TABLE] WHERE [AIRLINE_CODE] = @code", con)
                            cmd3.Parameters.AddWithValue("@code", fCode)
                            Dim airlineName As String = cmd3.ExecuteScalar().ToString()

                            row("lines") = airlineName
                            reader.Close()

                        End If
                    Next

                    dgvMain.AutoGenerateColumns = False ' disable auto-generation of columns

                    dgvMain.Columns("Column4").DataPropertyName = "ETA"
                    dgvMain.Columns("fli").DataPropertyName = "fli"
                    dgvMain.Columns("lines").DataPropertyName = "lines"

                    ' Set the DataSource of the DataGridView to the DataTable
                    dgvMain.DataSource = table.DefaultView

                    ' Get the row count of the DataGridView control
                    Dim rowCount As Integer = dgvMain.RowCount
                    ' Loop through each row in the DataGridView control and add the number to the column
                    For i As Integer = 0 To rowCount - 1
                        dgvMain.Rows(i).Cells("noo").Value = i + 1
                    Next



                End If

                'if select Night
                If Criteria = "Night" Then

                    Dim table As DataTable = New DataTable()
                    Dim cmd As New SqlCommand("SELECT FID, ETA FROM [FLIGHT_TIME_TABLE]WHERE [ETA] BETWEEN '00:00:00' AND '07:00:00' OR [ETA] BETWEEN '19:00:00' AND '23:59:59' AND [DATE] = @date ", con)
                    cmd.Parameters.AddWithValue("@date", today)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using



                    ' Add the "Flight" column to the DataTable, using the name of the corresponding column in the DataGridView
                    table.Columns.Add("fli", GetType(String))
                    table.Columns.Add("lines", GetType(String))

                    For Each row As DataRow In table.Rows
                        ' Store FID
                        Dim fid As Integer = row("FID")

                        ' Load second table to get flight information
                        Dim cmd2 As New SqlCommand("SELECT [FLIGHT_NO], [AIRLINE_CODE] FROM [FLIGHT_MASTER_TABLE] WHERE FID = @fid", con)
                        cmd2.Parameters.AddWithValue("@fid", fid)
                        Dim reader As SqlDataReader = cmd2.ExecuteReader()

                        If reader.HasRows Then
                            reader.Read()

                            ' Get flight information
                            Dim fNo As Integer = reader("FLIGHT_NO")
                            Dim fCode As String = reader("AIRLINE_CODE")
                            Dim flight As String = fNo.ToString + "-" + fCode

                            ' Set the value of the "Flight" column in the current row
                            row("Fli") = flight

                            reader.Close()
                            '=======================
                            ' Get airline name from AIRLINE_MASTER_TABLE
                            Dim cmd3 As New SqlCommand("SELECT [AIRLINE_NAME] FROM [AIRLINE_MASTER_TABLE] WHERE [AIRLINE_CODE] = @code", con)
                            cmd3.Parameters.AddWithValue("@code", fCode)
                            Dim airlineName As String = cmd3.ExecuteScalar().ToString()

                            row("lines") = airlineName
                            reader.Close()

                        End If
                    Next

                    dgvMain.AutoGenerateColumns = False ' disable auto-generation of columns

                    dgvMain.Columns("Column4").DataPropertyName = "ETA"
                    dgvMain.Columns("fli").DataPropertyName = "fli"
                    dgvMain.Columns("lines").DataPropertyName = "lines"

                    ' Set the DataSource of the DataGridView to the DataTable
                    dgvMain.DataSource = table.DefaultView

                    'get row count
                    Dim rowCount As Integer = dgvMain.RowCount
                    ' Loop through each row in the DataGridView control and add the number to the column
                    For i As Integer = 0 To rowCount - 1
                        dgvMain.Rows(i).Cells("noo").Value = i + 1
                    Next


                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    'try to add new row s or delete selected row

    Private Sub dgvMain_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvMain.MouseUp
        If e.Button = MouseButtons.Right Then ' Check if the right mouse button was clicked
            Dim hti As DataGridView.HitTestInfo = dgvMain.HitTest(e.X, e.Y)
            If hti.RowIndex >= 0 Then ' Check if the clicked area is in a valid row
                dgvMain.ClearSelection() ' Clear any existing row selection
                dgvMain.Rows(hti.RowIndex).Selected = True ' Select the clicked row

                Dim menu As New ContextMenuStrip() ' Create a new context menu strip
                menu.Items.Add("Add New Row").Name = "AddRow" ' Add an item to add a new row
                menu.Items.Add("Delete Selected Row").Name = "DeleteRow" ' Add an item to delete the selected row

                AddHandler menu.ItemClicked, AddressOf ContextMenuStrip_ItemClicked ' Add a handler for the menu item clicked event
                menu.Show(dgvMain, e.Location) ' Show the context menu strip at the clicked location
            End If
        End If
        dgvMain.Refresh()
    End Sub

    Private Sub ContextMenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        Try
            Select Case e.ClickedItem.Name

                Case "AddRow"
                    Dim dv As DataView = CType(dgvMain.DataSource, DataView)
                    Dim newRow As DataRowView = dv.AddNew()
                    Dim selectedIndex As Integer = dgvMain.SelectedRows(0).Index ' Get the index of the selected row
                    dv.Table.Rows.InsertAt(newRow.Row, selectedIndex + 1) ' Insert the new row below the selected row
                    newRow.EndEdit()

                    ' Update the NO column values
                    For i As Integer = 0 To dgvMain.Rows.Count - 1
                        dgvMain.Rows(i).Cells("noo").Value = i + 1
                    Next

                Case "DeleteRow"
                    Dim dv As DataView = CType(dgvMain.DataSource, DataView)
                    For Each row As DataGridViewRow In dgvMain.SelectedRows
                        dv.Delete(row.Index) ' Remove the selected rows from the data source
                    Next

                    ' Update the NO column values
                    For i As Integer = 0 To dgvMain.Rows.Count - 1
                        dgvMain.Rows(i).Cells("noo").Value = i + 1
                    Next
            End Select
            dgvMain.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    'load data to a table

    '===================================================================
    Private Sub btntest_Click(sender As Object, e As EventArgs)

        Try


            Dim con As New SqlConnection(str)
            con.Open()
            Dim command As New SqlCommand("INSERT INTO [RECORD_TABLE] ([BAY NO], [NO], [FLIGHT], [ETA], [AIRLINES], [RIC], [OPERATOR], [CREWMAN], [REMARKS], [DATE]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8, @Value9, @Value10)", con)
            command.Parameters.AddWithValue("@Value1", "")
            command.Parameters.AddWithValue("@Value2", "")
            command.Parameters.AddWithValue("@Value3", "")
            command.Parameters.AddWithValue("@Value4", "")
            command.Parameters.AddWithValue("@Value5", "")
            command.Parameters.AddWithValue("@Value6", "")
            command.Parameters.AddWithValue("@Value7", "")
            command.Parameters.AddWithValue("@Value8", "")
            command.Parameters.AddWithValue("@Value9", "")
            command.Parameters.AddWithValue("@Value10", "")
            For Each row As DataGridViewRow In dgvMain.Rows
                command.Parameters("@Value1").Value = If(row.Cells("Column1").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("Column1").Value.ToString()), row.Cells("Column1").Value.ToString(), "")
                command.Parameters("@Value2").Value = If(row.Cells("noo").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("noo").Value.ToString()), row.Cells("noo").Value.ToString(), "")
                command.Parameters("@Value3").Value = If(row.Cells("fli").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("fli").Value.ToString()), row.Cells("fli").Value.ToString(), "")
                command.Parameters("@Value4").Value = If(row.Cells("Column4").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("Column4").Value.ToString()), row.Cells("Column4").Value.ToString(), "")
                command.Parameters("@Value5").Value = If(row.Cells("lines").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("lines").Value.ToString()), row.Cells("lines").Value.ToString(), "")
                command.Parameters("@Value6").Value = If(row.Cells("Column6").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("Column6").Value.ToString()), row.Cells("Column6").Value.ToString(), "")
                command.Parameters("@Value7").Value = If(row.Cells("Column7").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("Column7").Value.ToString()), row.Cells("Column7").Value.ToString(), "")
                command.Parameters("@Value8").Value = If(row.Cells("Column8").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("Column8").Value.ToString()), row.Cells("Column8").Value.ToString(), "")
                command.Parameters("@Value9").Value = If(row.Cells("Column9").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("Column9").Value.ToString()), row.Cells("Column9").Value.ToString(), "")
                command.Parameters("@Value10").Value = tpDate.Text

                command.ExecuteNonQuery()
            Next
            con.Close()

            MsgBox("hgftf")


        Catch ex As Exception

            MsgBox(ex.Message)

        Finally


        End Try


    End Sub


    'load grid data to print


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Try
            Dim data As New DataTable()
            ' Add columns to the DataTable
            data.Columns.Add("Column1")
            data.Columns.Add("Column2")
            data.Columns.Add("Column3")
            data.Columns.Add("Column4")
            data.Columns.Add("Column5")
            data.Columns.Add("Column6")
            data.Columns.Add("Column7")
            data.Columns.Add("Column8")
            data.Columns.Add("Column9")
            data.Columns.Add("Column10")

            ' Add rows to the DataTable and load data into the existing columns of the DataTable
            For Each row As DataGridViewRow In dgvMain.Rows
                ' Add a new row to the DataTable
                Dim newRow As DataRow = data.Rows.Add()

                ' Set the values for each column in the new row
                newRow("Column1") = row.Cells("Column1").Value
                newRow("Column2") = row.Cells("noo").Value
                newRow("Column3") = row.Cells("fli").Value
                newRow("Column4") = row.Cells("Column4").Value
                newRow("Column5") = row.Cells("lines").Value
                newRow("Column6") = row.Cells("Column6").Value
                newRow("Column7") = row.Cells("Column7").Value
                newRow("Column8") = row.Cells("Column8").Value
                newRow("Column9") = row.Cells("Column9").Value
                newRow("Column10") = row.Cells("Column10").Value
            Next

            Dim pForm As New PrintForm()
            pForm.Data = data


            pForm.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub PrintAsDocument_PrintPage(sender As Object, e As PrintPageEventArgs)

    End Sub

    'export as xml
    Private Sub btnXML_Click(sender As Object, e As EventArgs) Handles btnXML.Click
        ' Set the filter to allow only Excel files
        Using sfd As SaveFileDialog = New SaveFileDialog()
            sfd.Filter = "Excel Workbook|*.xlsx"

            ' Show the SaveFileDialog
            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' Create a new instance of the XLWorkbook
                Dim workbook As XLWorkbook = New XLWorkbook()

                ' Create a new worksheet
                Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Sheet1")

                ' Get the columns from the DataGridView and add them to the worksheet
                For columnIndex As Integer = 0 To dgvMain.Columns.Count - 1
                    worksheet.Cell(1, columnIndex + 1).Value = dgvMain.Columns(columnIndex).HeaderText
                Next

                ' Get the rows from the DataGridView and add them to the worksheet
                For rowIndex As Integer = 0 To dgvMain.Rows.Count - 1
                    For columnIndex As Integer = 0 To dgvMain.Columns.Count - 1
                        Dim cellValue As Object = dgvMain.Rows(rowIndex).Cells(columnIndex).Value
                        Dim cellString As String = ""

                        ' Check the data type of the cell value and convert it to a string
                        If cellValue Is Nothing Then
                            cellString = ""
                        ElseIf TypeOf cellValue Is DBNull Then
                            cellString = ""
                        ElseIf TypeOf cellValue Is String Then
                            cellString = cellValue.ToString()
                        ElseIf TypeOf cellValue Is Date Then
                            cellString = CType(cellValue, Date).ToString("yyyy-MM-dd")
                        ElseIf TypeOf cellValue Is Double Or TypeOf cellValue Is Decimal Then
                            cellString = String.Format("{0:F2}", cellValue)
                        ElseIf TypeOf cellValue Is Boolean Then
                            cellString = If(cellValue, "True", "False")
                        Else
                            cellString = cellValue.ToString()
                        End If


                        worksheet.Cell(rowIndex + 2, columnIndex + 1).Value = cellString
                    Next
                Next

                ' Save the workbook to the specified file
                workbook.SaveAs(sfd.FileName.ToString())

                ' Show a message box to inform the user that the export was successful
                MessageBox.Show("Successfully exported to Excel file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using

    End Sub


End Class