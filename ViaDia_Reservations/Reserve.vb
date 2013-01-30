Public Class Reserve

    Private Sub Save_Button_Click(sender As System.Object, e As System.EventArgs) Handles Save_Button.Click
        Dim button As String = "Button"

        DB_Connect.Insert2DB(Table_num_TextBox.Text, Name_TextBox.Text, Email_TextBox.Text, Bdate_TextBox.Text, Edate_TextBox.Text)

        button = button & Table_num_TextBox.Text
        Me.Close()
        MainForm.clearbuttons()
        DB_Connect.Update_Table_Color()


    End Sub

    Public Sub Check_table()
        Dim table_num As Integer
        table_num = Table_num_TextBox.Text
        DB_Connect.Check_Single_Reservation(table_num)

    End Sub

    Private Sub Close_Button_Click(sender As System.Object, e As System.EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Delete_Button_Click(sender As System.Object, e As System.EventArgs) Handles Delete_Button.Click

        DB_Connect.Delete_row(Table_num_TextBox.Text)
        Me.Close()
        MainForm.clearbuttons()
        DB_Connect.Update_Table_Color()

    End Sub
End Class