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
End Class