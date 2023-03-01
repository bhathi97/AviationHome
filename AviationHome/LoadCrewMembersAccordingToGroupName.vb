Imports System.Data.SqlClient

Module LoadCrewMembersAccordingToGroupName
    Public Sub LoadDataToListBoxes(sender As Object, e As EventArgs, obj As HomeForm)

        'get selected data to a variable'
        Dim var_GroupName As String
        var_GroupName = obj.cbGroupPicker.Text

        ' Clear the existing items in the ListView control
        obj.lvCrewman.Items.Clear()
        obj.lvRic.Items.Clear()

        ' Clear the existing items in the ListView control
        obj.lvCrewman.Items.Clear()
        obj.lvRic.Items.Clear()

        Dim con As New SqlConnection(obj.str)

        Try
            con.Open()
            '----------------------> crew
            Dim cmd As New SqlCommand("SELECT * FROM [GroupMembers_MASTER_Table] WHERE [Group] = @GroupName AND [Position] = 'CREWMAN'", con)
            cmd.Parameters.AddWithValue("@GroupName", var_GroupName)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim value As String = reader("Name").ToString() 'get value from the table
                obj.lvCrewman.Items.Add(value)
            End While
            reader.Close()

            '----------------------->RIC
            Dim cmdToLoadRIC As New SqlCommand("SELECT * FROM [GroupMembers_MASTER_Table] WHERE [Group] = @GroupName AND [Position] = 'RIC'", con)
            cmdToLoadRIC.Parameters.AddWithValue("@GroupName", var_GroupName)

            Dim readerRics As SqlDataReader = cmdToLoadRIC.ExecuteReader()
            While readerRics.Read()
                Dim valueRIC As String = readerRics("Name").ToString() 'get values
                obj.lvRic.Items.Add(valueRIC)
            End While
            readerRics.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

End Module
