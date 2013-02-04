Public Class Reserve

    Private Sub Save_Button_Click(sender As System.Object, e As System.EventArgs) Handles Save_Button.Click
        Dim button As String = "Button"
        Dim Imonth As String
        Dim Cmonth As Integer

        Imonth = MainForm.MonthCalendar1.SelectionStart.ToShortDateString()
        Cmonth = Val(Imonth)

        DB_Connect.Insert2DB(Cmonth, Table_num_TextBox.Text, Name_TextBox.Text, Email_TextBox.Text, Phone_Num_TextBox.Text, DateTimePicker1.Text, DateTimePicker2.Text, Editor_TextBox.Text)

        
        button = button & Table_num_TextBox.Text
        Me.Close()
        MainForm.clearbuttons()
        DB_Connect.Update_Table_Color(Cmonth)


    End Sub

    Public Sub Check_table()
        Dim table_num As Integer
        Dim Imonth As Integer
        table_num = Table_num_TextBox.Text
        Imonth = MainForm.MonthCalendar1.SelectionStart.Month
        DB_Connect.Check_Single_Reservation(table_num, Imonth)

    End Sub

    Private Sub Close_Button_Click(sender As System.Object, e As System.EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Delete_Button_Click(sender As System.Object, e As System.EventArgs) Handles Delete_Button.Click

        Dim intResponse As Integer
        Dim Imonth As String
        Dim Cmonth As Integer

        Imonth = MainForm.MonthCalendar1.SelectionStart.ToShortDateString()
        Cmonth = Val(Imonth)

        intResponse = MsgBox("Are you sure you want to delete this record?", _
                             vbYesNo + vbQuestion, _
                             "Quit")

        If intResponse = vbYes Then

            imonth = MainForm.MonthCalendar1.SelectionStart.ToShortDateString()
            DB_Connect.Delete_row(Table_num_TextBox.Text, Cmonth)
            Me.Close()
            MainForm.clearbuttons()
            DB_Connect.Update_Table_Color(Cmonth)

        End If

       

    End Sub

    Private Sub Reserve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"
        DateTimePicker1.Text = MainForm.Get_date()
        DateTimePicker2.Text = MainForm.Get_date()



    End Sub

    Private Sub Edit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_Button.Click

        Dim intResponse As Integer
        Dim Imonth As String
        Dim Cmonth As Integer

        Imonth = MainForm.MonthCalendar1.SelectionStart.ToShortDateString()
        Cmonth = Val(Imonth)

        intResponse = MsgBox("Are you sure you want to change this record?", _
                             vbYesNo + vbQuestion, _
                             "Quit")

        If intResponse = vbYes Then

            Imonth = MainForm.MonthCalendar1.SelectionStart.ToShortDateString()
            DB_Connect.Edit_row(Table_num_TextBox.Text, Cmonth)
            Me.Close()
            MainForm.clearbuttons()
            DB_Connect.Update_Table_Color(Cmonth)

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "0" Then
            DateTimePicker2.Value = DateTimePicker1.Value

        ElseIf ComboBox1.Text = "1" Then
            Num_week.Text = "1"

            DateTimePicker2.Value = DateTimePicker2.Value.AddDays(7)

        ElseIf ComboBox1.Text = "2" Then
            Num_week.Text = "2"
            DateTimePicker2.Value = DateTimePicker2.Value.AddDays(+13)

        ElseIf ComboBox1.Text = "3" Then

            Num_week.Text = "3"
            DateTimePicker2.Value = DateTimePicker2.Value.AddDays(+20)

        ElseIf ComboBox1.Text = "4" Then
            Num_week.Text = "4"
            DateTimePicker2.Value = DateTimePicker2.Value.AddDays(+27)

        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_Week.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.Value = DateTimePicker1.Value

    End Sub
    Private Sub ComboBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBox1.MouseClick
        If ComboBox1.Capture = True Then
            DateTimePicker2.Value = DateTimePicker1.Value
        End If

    End Sub

End Class