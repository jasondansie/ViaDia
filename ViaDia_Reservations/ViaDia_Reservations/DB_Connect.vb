Imports MySql.Data.MySqlClient

Public Class DB_Connect



    Shared Sub Insert2DB(ByRef table_num As String, ByRef Rname As String, ByRef email As String, ByRef phone_num As String, ByRef bdate As String, ByRef edate As String, ByRef editor As String)

        Dim connString As String = "Database=viadia;Data Source=localhost;" _
          & "User Id=root;Password="

        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()

            cmd.Connection = conn

            cmd.CommandText = "INSERT INTO viadia(Table_num, Reserver_name, Email, Phone_num, Begin_date, End_date, Editor_Name, Reserved) VALUES('" + table_num + "', '" + Rname + "', '" + email + "', '" + phone_num + "', '" + bdate + "', '" + edate + "', '" + editor + "', '1')"
            cmd.Prepare()


            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("Reservation saved successfully!")

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
        End Try



    End Sub

    Public Shared Sub Check_Single_Reservation(ByRef table_num As Integer)

        Dim connString As String = "Database=viadia;Data Source=localhost;" _
          & "User Id=root;Password="

        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()
        Dim objDataset As New DataSet()
        Dim objDataAdapter As New MySqlDataAdapter()


        Try
            conn.Open()

            Dim query As String = "SELECT * FROM viadia WHERE Table_num = " & table_num
           
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

    Public Shared Sub Update_Table_Color()
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


        Try
            conn.Open()

            Dim query As String = "SELECT * FROM viadia WHERE Reserved= 1"

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

    Public Shared Sub Delete_row(ByRef Table_num As Integer)
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

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM viadia WHERE Table_num= " & Table_num

            objDataAdapter.SelectCommand = New MySqlCommand(query, conn)
            objDataAdapter.Fill(objDataset)

            tablenum = Table_num.ToString
            rname = objDataset.Tables("Table").Rows(0).Item(2)
            email = objDataset.Tables("Table").Rows(0).Item(3)
            phone_num = objDataset.Tables("Table").Rows(0).Item(4)
            bdate = Reserve.DateTimePicker1.Text
            edate = Reserve.DateTimePicker2.Text
            editor = objDataset.Tables("Table").Rows(0).Item(7)

            cmd.Connection = conn

            Try
                cmd.CommandText = "INSERT INTO savetable(Table_num, Reserver_Name, Email, phone_num, Begin_date, End_date, Editor_Name, Edit_type) VALUES('" + tablenum + "', '" + rname + "', '" + email + "', '" + phone_num + "', '" + bdate + "', '" + edate + "', '" + editor + "', 'Deletion')"
                cmd.Prepare()
                cmd.ExecuteNonQuery()

            Catch ex As MySqlException
                MsgBox("Error: " & ex.ToString())
            End Try

            Try
                cmd.CommandText = "DELETE FROM viadia WHERE Table_num = " & Table_num
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
    Public Shared Sub Edit_row(ByRef table_num As String)
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

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM viadia WHERE Table_num= " & Table_num

            objDataAdapter.SelectCommand = New MySqlCommand(query, conn)
            objDataAdapter.Fill(objDataset)

            tablenum = Table_num.ToString
            rname = objDataset.Tables("Table").Rows(0).Item(2)
            email = objDataset.Tables("Table").Rows(0).Item(3)
            phone_num = objDataset.Tables("Table").Rows(0).Item(4)
            bdate = Reserve.DateTimePicker1.Text
            edate = Reserve.DateTimePicker2.Text
            editor = objDataset.Tables("Table").Rows(0).Item(7)

            cmd.Connection = conn

            Try
                cmd.CommandText = "INSERT INTO savetable(Table_num, Reserver_Name, Email, phone_num, Begin_date, End_date, Editor_Name, Edit_type) VALUES('" + tablenum + "', '" + rname + "', '" + email + "', '" + phone_num + "', '" + bdate + "', '" + edate + "', '" + editor + "', 'Update')"
                cmd.Prepare()
                cmd.ExecuteNonQuery()

            Catch ex As MySqlException
                MsgBox("Error: " & ex.ToString())
            End Try

            Try
                cmd.CommandText = "UPDATE viadia set Table_num = '" + table_num + "', Reserver_name = '" + Reserve.Name_TextBox.Text + "', Email = '" + Reserve.Email_TextBox.Text + "', Phone_num = '" + Reserve.Phone_Num_TextBox.Text + "', Begin_date = '" + Reserve.DateTimePicker1.Text + "', End_date = '" + Reserve.DateTimePicker2.Text + "', Editor_Name = '" + Reserve.Editor_TextBox.Text + "', Reserved = '1'  WHERE Table_num = '" + table_num + "'"
                MsgBox(cmd.CommandText)
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
