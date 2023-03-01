Module CrewMembersOrderChangingCommand

    'have to implemet to real data entering form  

    'for CrewMan >>

    'when the left mouse click happen  drag the item
    Public Sub dragWantedItem(sender As Object, e As MouseEventArgs, obj As HomeForm)

        If e.Button = MouseButtons.Left AndAlso obj.lvCrewman.SelectedIndex >= 0 Then
            obj.lvCrewman.DoDragDrop(obj.lvCrewman.SelectedItem, DragDropEffects.Move)

        ElseIf e.Button = MouseButtons.Left AndAlso obj.lvRic.SelectedIndex >= 0 Then
            obj.lvRic.DoDragDrop(obj.lvRic.SelectedItem, DragDropEffects.Move)
        End If

    End Sub

    'When the dragged item go over items but not dropped
    Public Sub dragOverOtherItems(sender As Object, e As DragEventArgs)

        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", True) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    'When drop the dragged item
    Public Sub dropWantedItem(sender As Object, e As DragEventArgs, obj As HomeForm)

        'for Crewman
        If e.Data.GetDataPresent(GetType(String)) Then
            Dim dragItemCM As String = CType(e.Data.GetData(GetType(String)), String)
            Dim targetIndexCM As Integer = obj.lvCrewman.IndexFromPoint(obj.lvCrewman.PointToClient(New Point(e.X, e.Y)))
            If targetIndexCM >= 0 AndAlso targetIndexCM <> obj.lvCrewman.Items.IndexOf(dragItemCM) Then
                obj.lvCrewman.Items.Remove(dragItemCM)
                obj.lvCrewman.Items.Insert(targetIndexCM, dragItemCM)
                obj.lvCrewman.SetSelected(targetIndexCM, True)
            End If
        End If

        'for RIC
        If e.Data.GetDataPresent(GetType(String)) Then
            Dim dragItem As String = CType(e.Data.GetData(GetType(String)), String)
            Dim targetIndex As Integer = obj.lvRic.IndexFromPoint(obj.lvRic.PointToClient(New Point(e.X, e.Y)))
            If targetIndex >= 0 AndAlso targetIndex <> obj.lvRic.Items.IndexOf(dragItem) Then
                obj.lvRic.Items.Remove(dragItem)
                obj.lvRic.Items.Insert(targetIndex, dragItem)
                obj.lvRic.SetSelected(targetIndex, True)
            End If
        End If
    End Sub


End Module
