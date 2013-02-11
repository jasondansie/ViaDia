Imports MySql.Data.MySqlClient

Public Class DB_Connect


    Shared Function Convert_Month(ByRef Imonth As Integer) As String

        Dim Table_name As String

        Table_name = "January"

        If Imonth = 1 Then
            Table_name = "january"
        ElseIf Imonth = 2 Then
            Table_name = "february"
        ElseIf Imonth = 3 Then
            Table_name = "march"
        ElseIf Imonth = 4 Then
            Table_name = "april"
        ElseIf Imonth = 5 Then
            Table_name = "may"
        ElseIf Imonth = 6 Then
            Table_name = "june"
        ElseIf Imonth = 7 Then
            Table_name = "july"
        ElseIf Imonth = 8 Then
            Table_name = "august"
        ElseIf Imonth = 9 Then
            Table_name = "september"
        ElseIf Imonth = 10 Then
            Table_name = "october"
        ElseIf Imonth = 11 Then
            Table_name = "november"
        ElseIf Imonth = 12 Then
            Table_name = "december"
        End If

        Return Table_name

    End Function
    Shared Sub Insert2DB(ByRef Imonth As Integer, ByRef table_num As String, ByRef Rname As String, ByRef email As String, ByRef phone_num As String, ByRef bdate As String, ByRef edate As String, ByRef editor As String, ByRef week_num As String, ByRef comments As String)

        Dim connString As String = "Database=viadia;Data Source=localhost;" _
          & "User Id=root;Password="

        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()
        Dim query As String
        Dim Table_name As String


        Try
            conn.Open()

            Table_name = Convert_Month(Imonth)

            cmd.Connection = conn
            query = "INSERT INTO " & Table_name & "(Table_num, Reserver_name, Email, Phone_num, Begin_date, End_date, Editor_Name, Reserved, week_num, comments) VALUES('" + table_num + "', '" + Rname + "', '" + email + "', '" + phone_num + "', '" + bdate + "', '" + edate + "', '" + editor + "', '1', '" + week_num + "', '" + comments + "')"


            cmd.CommandText = query
            cmd.Prepare()


            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("Reservation saved successfully!")

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
        End Try



    End Sub

    Public Shared Sub Check_Single_Reservation(ByRef table_num As Integer, ByRef Imonth As Integer)

        Dim connString As String = "Database=viadia;Data Source=localhost;" _
          & "User Id=root;Password="

        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()
        Dim objDataset As New DataSet()
        Dim objDataAdapter As New MySqlDataAdapter()
        Dim Table_name As String

        Table_name = Convert_Month(Imonth)

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM " & Table_name & " WHERE Table_num = " & table_num

            Try
                objDataAdapter.SelectCommand = New MySqlCommand(query, conn)
                objDataAdapter.Fill(objDataset)

                If objDataset.Tables("Table").Rows.Count = 1 Then

                    Reserve.Name_TextBox.Text = objDataset.Tables("Table").Rows(0).Item(2)
                    Reserve.Email_TextBox.Text = objDataset.Tables("Table").Rows(0).Item(3)
                    Reserve.DateTimePicker1.Text = objDataset.Tables("Table").Rows(0).Item(5).ToString
                    Reserve.DateTimePicker2.Text = objDataset.Tables("Table").Rows(0).Item(6).ToString
                    Reserve.Phone_Num_TextBox.Text = objDataset.Tables("Table").Rows(0).Item(4)
                    Reserve.Editor_TextBox.Text = objDataset.Tables("Table").Rows(0).Item(7)
                    Reserve.Week_Label.Enabled = True
                    Reserve.Week_Label.Text = objDataset.Tables("Table").Rows(0).Item(9)
                    Reserve.Comment_TextBox.Text = objDataset.Tables("Table").Rows(0).Item(10)
                    Reserve.Reseved_label.BackColor = Color.Red
                    Reserve.Reseved_label.Text = "Resevered"

                End If
            Catch ex As MySqlException
                MsgBox("Error: " & ex.ToString())
            End Try

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
            MsgBox("Error: " & ex.ToString())
        End Try

    End Sub

    Public Shared Sub Update_Table_Color(ByRef Imonth As Integer)
        Dim Table_name As String
        Dim Table_num As String
        Dim j As Integer
        Dim count As Integer
        Dim ButtonText As String
        Dim tablenums() As Integer
        Dim connString As String = "Database=viadia;Data Source=localhost;" _
          & "User Id=root;Password="

        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()
        Dim objDataset As New DataSet()
        Dim objDataAdapter As New MySqlDataAdapter()


        Table_name = Convert_Month(Imonth)




        Try
            conn.Open()

            Dim query As String = "SELECT * FROM " & Table_name & " WHERE Reserved= 1"



            Try
                objDataAdapter.SelectCommand = New MySqlCommand(query, conn)
                objDataAdapter.Fill(objDataset)

                count = objDataset.Tables("Table").Rows.Count
                ReDim tablenums(0 To count)

                count = count - 1


                For j = 0 To count
                    tablenums(j) = objDataset.Tables("Table").Rows(j).Item(1)
                Next j


                Dim cControl As Control
                For Each cControl In MainForm.Controls

                    If TypeName(cControl) = "Button" Then

                        ButtonText = cControl.Text.ToString

                        For j = 0 To count
                            If tablenums(j) > 0 Then

                                Table_num = tablenums(j).ToString

                                If Table_num = ButtonText Then

                                    cControl.BackColor = Color.Red

                                Else

                                    'cControl.BackColor = Color.Lime

                                End If

                            End If
                        Next j

                    End If

                Next cControl



            Catch ex As MySqlException
                MsgBox("Error: " & ex.ToString())
            End Try

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
        End Try




    End Sub

    Public Shared Sub Delete_row(ByRef Table_num As Integer, ByRef Imonth As String)
        Dim connString As String = "Database=viadia;Data Source=localhost;" _
         & "User Id=root;Password="

        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()
        Dim objDataset As New DataSet()
        Dim objDataAdapter As New MySqlDataAdapter()
        Dim rname As String
        Dim email As String
        Dim phone_num As String
        Dim bdate As String
        Dim edate As String
        Dim editor As String
        Dim tablenum As String
        Dim Table_name As String
        Dim Week_num As String
        Dim comments As String

        Try
            Table_name = Convert_Month(Imonth)
            conn.Open()

            Dim query As String = "SELECT * FROM " & Table_name & " WHERE Table_num= " & Table_num

            objDataAdapter.SelectCommand = New MySqlCommand(query, conn)
            objDataAdapter.Fill(objDataset)

            tablenum = Table_num.ToString
            rname = objDataset.Tables("Table").Rows(0).Item(2)
            email = objDataset.Tables("Table").Rows(0).Item(3)
            phone_num = objDataset.Tables("Table").Rows(0).Item(4)
            bdate = Reserve.DateTimePicker1.Text
            edate = Reserve.DateTimePicker2.Text
            editor = objDataset.Tables("Table").Rows(0).Item(7)
            Week_num = objDataset.Tables("Table").Rows(0).Item(9)
            comments = objDataset.Tables("Table").Rows(0).Item(10)

            cmd.Connection = conn





            Try
                cmd.CommandText = "INSERT INTO savetable(Table_num, Reserver_Name, Email, phone_num, Begin_date, End_date, Editor_Name, Edit_type, week_num, comments) VALUES('" + tablenum + "', '" + rname + "', '" + email + "', '" + phone_num + "', '" + bdate + "', '" + edate + "', '" + editor + "', 'Update', '" + Week_num + "', '" + comments + "')"
                cmd.Prepare()
                cmd.ExecuteNonQuery()

            Catch ex As MySqlException
                MsgBox("Error: " & ex.ToString())
            End Try

            Try



                cmd.CommandText = "DELETE FROM " & Table_name & " WHERE Table_num = " & Table_num
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                conn.Close()
                MsgBox("Reservation delete successfully!")
            Catch ex As MySqlException
                MsgBox("Error: " & ex.ToString())
            End Try

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
        End Try

    End Sub
    Public Shared Sub Edit_row(ByRef table_num As String, ByRef Imonth As Integer)
        Dim connString As String = "Database=viadia;Data Source=localhost;" _
         & "User Id=root;Password="

        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()
        Dim objDataset As New DataSet()
        Dim objDataAdapter As New MySqlDataAdapter()

        Dim rname As String
        Dim email As String
        Dim phone_num As String
        Dim bdate As String
        Dim edate As String
        Dim editor As String
        Dim tablenum As String
        Dim Edit_Table_name As String
        Dim Table_name As String
        Dim Week_num As String
        Dim comments As String

        Try
            conn.Open()



            Table_name = Convert_Month(Imonth)

            Dim query As String = "SELECT * FROM " & Table_name & " WHERE Table_num= " & table_num

            objDataAdapter.SelectCommand = New MySqlCommand(query, conn)
            objDataAdapter.Fill(objDataset)

            tablenum = table_num.ToString
            rname = objDataset.Tables("Table").Rows(0).Item(2)
            email = objDataset.Tables("Table").Rows(0).Item(3)
            phone_num = objDataset.Tables("Table").Rows(0).Item(4)
            bdate = Reserve.DateTimePicker1.Text
            edate = Reserve.DateTimePicker2.Text
            editor = objDataset.Tables("Table").Rows(0).Item(7)
            Week_num = objDataset.Tables("Table").Rows(0).Item(9)
            comments = objDataset.Tables("Table").Rows(0).Item(10)

            cmd.Connection = conn

            Try
                cmd.CommandText = "INSERT INTO savetable(Table_num, Reserver_Name, Email, phone_num, Begin_date, End_date, Editor_Name, Edit_type, week_num, comments) VALUES('" + tablenum + "', '" + rname + "', '" + email + "', '" + phone_num + "', '" + bdate + "', '" + edate + "', '" + editor + "', 'Update', '" + Week_num + "', '" + comments + "')"
                cmd.Prepare()
                cmd.ExecuteNonQuery()

            Catch ex As MySqlException
                MsgBox("Error: " & ex.ToString())
            End Try

            Try

                Edit_Table_name = "UPDATE " & Table_name & " set Table_num = '" + table_num + "', Reserver_name = '" + Reserve.Name_TextBox.Text + "', Email = '" + Reserve.Email_TextBox.Text + "', Phone_num = '" + Reserve.Phone_Num_TextBox.Text + "', Begin_date = '" + Reserve.DateTimePicker1.Text + "', End_date = '" + Reserve.DateTimePicker2.Text + "', Editor_Name = '" + Reserve.Editor_TextBox.Text + "', Reserved = '1', week_num = '" + Reserve.Week_ComboBox.Text + "', comments = '" + Reserve.Comment_TextBox.Text + "'  WHERE Table_num = '" + table_num + "'"

                cmd.CommandText = Edit_Table_name
                'MsgBox(cmd.CommandText)
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                conn.Close()
                MsgBox("Reservation updated successfully!")
            Catch ex As MySqlException
                MsgBox("Error: " & ex.ToString())
            End Try

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
        End Try
    End Sub

End Class
