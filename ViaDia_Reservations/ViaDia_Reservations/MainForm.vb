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

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub



    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 2
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

    
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 3
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()


    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 4
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 5
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()

    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 6
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 7
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 8
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 9
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 10
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 11
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 12
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 13
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 14
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 15
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 16
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 17
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 18
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 19
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 20
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 21
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 22
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 23
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 24
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

        Reserve.Check_table()
    End Sub


    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 25
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 26
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 27
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 28
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 29
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 30
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 31
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 32
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 33
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 34
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 35
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 36
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 37
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 38
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 39
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 40
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 41
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 42
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 43
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 44
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 45
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 46
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 47
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 48
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 49
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 50
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 51
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 52
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 53
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 54
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 55
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 56
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 57
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 58
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 59
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 60
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 61
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 62
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button63.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 63
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button64.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 64
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button65.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 65
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button66.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 66
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button67.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 67
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button68.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 68
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button69.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 69
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button70.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 70
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button71.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 71
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button72.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 72
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button73.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 73
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button74.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 74
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If

    End Sub

    Private Sub Button75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button75.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 75
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button76.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 76
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button77.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 77
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

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
            Login_ViaDia.Close()

        End If
      

    End Sub


    Private Sub Button81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button81.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 83
        If Button81.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button78.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 91
        If Button78.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button79.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 90
        If Button79.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button84.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 82
        If Button84.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button80.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 84
        If Button80.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button85.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 85
        If Button85.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button86.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 86
        If Button86.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button87.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 87
        If Button87.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button88.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 88
        If Button88.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub

    Private Sub Button89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button89.Click
        Reserve.Show()
        Reserve.Table_num_TextBox.Text = 89
        If Button89.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()
    End Sub
   
    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True
        comment.Visible = True


        Reserve.Table_num_TextBox.Text = 1
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
        comment.Text = Reserve.Comment_TextBox.Text
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
        comment.Visible = False


    End Sub

   
    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 2
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button2_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False






    End Sub

   
  
    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 3
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 4
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 5
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 6
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 7
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 8
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 9
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 10
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 11
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 12
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 13
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 14
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 15
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button16.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 16
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button16.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 17
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button18_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 18
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button18_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button19_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button19.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 19
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button19_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button19.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button20_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button20.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 20
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button20_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button20.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button22_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button22.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 22
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button22_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button22.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button23_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button23.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 23
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button23_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button23.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button24_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button24.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 24
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button24_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button24.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button25_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button25.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 25
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button25_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button25.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button26_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button26.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 26
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button26_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button26.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button27_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button27.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 27
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button27_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button27.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button28_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button28.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 28
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button28_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button28.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button29_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button29.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 29
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button29_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button29.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button30_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button30.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 30
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button30_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button30.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button21_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 21
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button21_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button31_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button31.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 31
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button31_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button31.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button32_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button32.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 32
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button32_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button32.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button33_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button33.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 33
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button33_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button33.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button34_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button34.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 34
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button34_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button34.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button35_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button35.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 35
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button35_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button35.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button36_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button36.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 36
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button36_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button36.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button37_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button37.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 37
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button37_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button37.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button38_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button38.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 38
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button38_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button38.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    

    Private Sub Button39_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button39.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 39
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button39_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button39.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button40_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button40.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 40
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button40_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button40.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button41_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button41.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 41
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button41_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button41.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button42_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button42.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 42
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button42_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button42.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button43_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button43.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 43
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button43_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button43.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button44_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button44.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 44
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button44_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button44.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button45_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button45.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 45
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button45_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button45.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button46_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button46.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 46
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button46_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button46.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button47_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button47.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 47
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button47_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button47.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button48_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button48.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 48
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button48_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button48.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button49_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button49.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 49
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button49_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button49.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button50_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button50.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 50
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button50_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button50.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button51_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button51.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 51
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button51_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button51.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button52_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button52.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 52
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button52_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button52.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button53_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button53.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 53
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button53_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button53.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button54_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button54.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 54
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button54_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button54.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button55_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button55.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 55
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button55_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button55.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button56_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button56.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 56
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button56_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button56.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button57_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button57.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 57
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button57_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button57.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button58_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button58.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 58
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button58_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button58.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button59_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button59.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 59
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button59_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button59.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button60_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button60.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 60
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button60_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button60.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button61_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button61.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 61
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button61_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button61.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button62_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button62.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 62
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button62_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button62.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button63_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button63.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 63
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button63_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button63.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button64_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button64.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 64
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button64_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button64.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button65_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button65.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 65
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button65_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button65.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button66_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button66.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 66
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button66_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button66.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button67_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button67.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 67
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button67_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button67.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button68_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button68.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 68
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

   
    Private Sub Button68_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button68.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button69_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button69.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 69
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button69_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button69.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button70_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button70.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 70
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button70_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button70.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button71_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button71.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 71
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button71_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button71.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button72_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button72.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 72
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button72_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button72.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button73_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button73.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 73
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button73_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button73.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button74_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button74.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 74
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button74_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button74.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button75_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button75.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 75
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button75_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button75.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button76_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button76.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 76
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button76_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button76.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button77_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button77.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 77
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button77_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button77.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button78_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button78.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 91
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button78_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button78.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button79_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button79.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 90
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button79_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button79.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button80_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Button80.DragOver

    End Sub

    Private Sub Button80_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button80.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 84
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button80_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button80.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button81_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button81.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 83
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button81_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button81.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button84_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button84.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 82
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button84_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button84.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

   
    Private Sub Button85_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button85.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 85
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button85_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button85.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button86_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button86.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 86
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button86_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button86.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button87_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button87.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 87
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button87_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button87.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub Button88_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button88.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 88
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button88_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button88.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

   
    Private Sub Button89_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button89.MouseHover
        tab_NuM.Visible = True
        Panel1.Visible = True
        Weeks.ForeColor = Color.Red
        Customer_name.Visible = True
        Table_nume.Visible = True
        ' Contrat_date.Visible = True
        start_date.Visible = True
        end_date.Visible = True
        Phone.Visible = True
        Weeks.Visible = True


        Reserve.Table_num_TextBox.Text = 89
        If Button1.BackColor = Color.Red Then

            Reserve.Reserved_label.BackColor = Color.Red
            Reserve.Reserved_label.Text = "Reserved"

        End If
        Reserve.Check_table()

        Customer_name.Text = Reserve.Name_TextBox.Text
        Table_nume.Text = Reserve.Table_num_TextBox.Text
        ' Contrat_date = 
        start_date.Text = Reserve.DateTimePicker1.Value
        end_date.Text = Reserve.DateTimePicker2.Value
        Phone.Text = Reserve.Phone_Num_TextBox.Text
        Weeks.Text = Reserve.Week_Label.Text
    End Sub

    Private Sub Button89_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button89.MouseLeave
        tab_NuM.Visible = False
        Panel1.Visible = False
        Customer_name.Visible = False
        Table_nume.Visible = False
        'Contrat_date.Visible = False
        start_date.Visible = False
        end_date.Visible = False
        Phone.Visible = False
        Weeks.Visible = False
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
  



    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class
