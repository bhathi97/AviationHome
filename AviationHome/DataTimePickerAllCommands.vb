Module DataTimePickerAllCommands

    Public Sub changeDayLblWhenLoading(obj As HomeForm)
        ' Get the selected date from the DateTimePicker
        Dim selectedDate As Date = obj.tpDate.Value
        Dim dayName As String = selectedDate.ToString("dddd")
        ' Extract the day from the selected date
        Dim day As Integer = selectedDate.Day
        ' Display the day in a Label
        obj.lblForShowingDay.Text = dayName.ToString()

    End Sub


    Public Sub DayLblWhenPickerValueChanged(obj As HomeForm)
        'Get the selected date from the DateTimePicker
        Dim selectedChangeDate As Date = obj.tpDate.Value
        Dim dayChangeName As String = selectedChangeDate.ToString("dddd")
        'Extract the day from the selected date
        Dim day As Integer = selectedChangeDate.Day
        'Display the day in a Label
        obj.lblForShowingDay.Text = dayChangeName.ToString()
    End Sub


End Module
