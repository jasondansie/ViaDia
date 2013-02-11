Public Class MainForm

    Public Shared Sub clearbuttons()

        Dim cControl As Control
        For Each cControl In MainForm.Controls

            If TypeName(cControl) = "Button" Then
                cControl.BackColor = Color.Lime
            End If
        Next cControl

        MainForm.Button83.BackColor = Color.Red
        MainForm.Update_tables_Button.BackColor = Color.LightGray
        MainForm.Done_Button.BackColor = Color.LightGray
       

    End Sub

    Shared Function Get_date() As String
        Dim Input_Date As String
        Dim Idate As Date

        Idate = MainForm.MonthCalendar1.SelectionStart.ToShortDateString

        Input_Date = Idate.Year & "/" & Idate.Month & "/" & Idate.Day

        Return Input_Date
    End Function

    Private Sub Update_tables_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_tables_Button.Click
        Dim Input_Date As String
        Dim Idate As Date

        Idate = MonthCalendar1.SelectionStart.ToShortDateString


        Input_Date = Get_date()

        MsgBox(Input_Date)
        If Idate.Month = 1 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(1)
            Button83.BackColor = Color.Red

        ElseIf Idate.Month = 2 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(2)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 3 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(3)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 4 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(4)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 5 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(5)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 6 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(6)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 7 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(7)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 8 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(8)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 9 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(9)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 10 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(10)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 11 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(11)
            Button83.BackColor = Color.Red
        ElseIf Idate.Month = 12 Then
            clearbuttons()
            DB_Connect.Update_Table_Color(12)
            Button83.BackColor = Color.Red

        End If
       
    End Sub


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 1
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 2
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 3
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 4
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 5
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()

    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 6
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 7
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 8
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 9
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 10
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 11
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 12
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 13
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 14
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 15
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 16
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 17
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 18
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 19
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 20
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 21
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 22
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 23
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 24
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub


    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 25
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 26
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 27
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 28
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 29
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 30
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 31
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 32
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 33
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 34
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 35
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 36
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 37
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 38
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 39
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 40
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 41
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 42
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 43
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 44
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 45
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 46
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 47
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 48
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 49
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 50
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 51
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 52
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 53
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 54
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 55
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 56
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 57
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 58
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 59
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 60
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 61
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 62
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button63.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 63
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button64.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 64
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button65.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 65
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button66.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 66
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button67.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 67
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button68.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 68
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button69.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 69
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button70.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 70
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button71.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 71
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button72.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 72
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button73.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 73
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button74.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 74
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
       
    End Sub

    Private Sub Button75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button75.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 75
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button76.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 76
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button77.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 77
        If Button1.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Done_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Done_Button.Click

        Dim intResponse As Integer

        intResponse = MsgBox("Are you sure you want to quit?", _
                             vbYesNo + vbQuestion, _
                             "Quit")

        If intResponse = vbYes Then
            Me.Close()
        End If


    End Sub

   
    Private Sub Button81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button81.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 83
        If Button81.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button78.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 91
        If Button78.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button79.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 80
        If Button79.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button84.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 82
        If Button84.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button80.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 84
        If Button80.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button85.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 85
        If Button85.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button86.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 86
        If Button86.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button87.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 87
        If Button87.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button88.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 88
        If Button88.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button89.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 89
        If Button89.BackColor = Color.Red Then

            Reserve.Reseved_label.BackColor = Color.Red
            Reserve.Reseved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
