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
        Dim con As New SqlConnection(str)

        Try
            con.Open()



            If Criteria.Length <> 0 Then
                If Criteria = "Day" Then

                    Dim table As DataTable = New DataTable()
                    Dim cmd As New SqlCommand("SELECT FID, ETA FROM [FLIGHT_TIME_TABLE] WHERE [ETA] BETWEEN '07:00:00' AND '19:00:00'", con)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using

                    ' Add the "Flight" column to the DataTable, using the name of the corresponding column in the DataGridView
                    table.Columns.Add("column3", GetType(String))

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
                            row("Flight") = flight
                        End If

                        reader.Close()
                    Next

                    ' Set the DataSource of the DataGridView to the DataTable
                    dgvMain.DataSource = table.DefaultView




                End If


            End If



        Catch ex As Exception

        End Try








    End Sub

End Class