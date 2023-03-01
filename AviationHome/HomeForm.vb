Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel
Imports System.Windows.Forms
Imports System.Windows.Controls
Imports System.Net.Security

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
            ' Loop through the items in the ListBox
            For i As Integer = 0 To lvCrewman.Items.Count - 1
                ' Check for the first empty row in the "crewman" column of the DataGridView
                Dim rowIndex As Integer = -1
                For j As Integer = 0 To dgvMain.Rows.Count - 1
                    If String.IsNullOrEmpty(dgvMain.Rows(j).Cells("Column8").Value) Then
                        rowIndex = j
                        Exit For
                    End If
                Next

                dgvMain.Rows(rowIndex).Cells("Column8").Value = lvCrewman.Items(i).ToString()
            Next

        Catch ex As Exception

        End Try





    End Sub

    Private Sub btnRICAddToTable_Click(sender As Object, e As EventArgs) Handles btnRICAddToTable.Click


        ' Loop through the items in the ListBox
        For i As Integer = 0 To lvRic.Items.Count - 1
            ' Check for the first empty row in the "ric" column of the DataGridView
            Dim rowIndex As Integer = -1
            For j As Integer = 0 To dgvMain.Rows.Count - 1
                If String.IsNullOrEmpty(dgvMain.Rows(j).Cells("Column6").Value) Then
                    rowIndex = j
                    Exit For
                End If
            Next

            ' Set the value of the "ric" column in the first empty row (or new row)
            dgvMain.Rows(rowIndex).Cells("Column6").Value = lvRic.Items(i).ToString()
        Next



    End Sub

    Private Sub btnAddPlanesToTable_Click(sender As Object, e As EventArgs) Handles btnAddPlanesToTable.Click

        'get the time range
        Dim Criteria As String
        Criteria = lblShiftShowing.Text

        Dim today As Date
        today = tpDate.Text
        'MsgBox(today)

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



                    '1234567
                    ' Get the row count of the DataGridView control
                    Dim rowCount As Integer = dgvMain.RowCount

                    ' Add a column to the DataGridView control
                    dgvMain.Columns.Add("Number", "Number")

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


End Class