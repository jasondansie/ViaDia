Imports MySql.Data.MySqlClient

Public Class DB_Connect



    Shared Sub Insert2DB(ByRef table_num As String, ByRef Rname As String, ByRef email As String, ByRef bdate As String, ByRef edate As String)

        Dim connString As String = "Database=test;Data Source=localhost;" _
          & "User Id=r;Password="

        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()

            cmd.Connection = conn

            cmd.CommandText = "INSERT INTO viadia(Table_num, Reserver_name, Email, Begin_date, End_date, Reserved) VALUES('" + table_num + "', '" + Rname + "', '" + email + "', '" + bdate + "', '" + edate + "', '1')"
            cmd.Prepare()


            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("Reservation saved successfully!")

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
        End Try



    End Sub

    Public Shared Sub Check_Single_Reservation(ByRef table_num As Integer)

        Dim connString As String = "Database=test;Data Source=localhost;" _
          & "User Id=r;Password="

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

                    Reserve.Name_TextBox.Text = objDataset.Tables("Table").Rows(0).Item(1)
                    Reserve.Email_TextBox.Text = objDataset.Tables("Table").Rows(0).Item(2)
                    Reserve.Bdate_TextBox.Text = objDataset.Tables("Table").Rows(0).Item(3)
                    Reserve.Edate_TextBox.Text = objDataset.Tables("Table").Rows(0).Item(4)
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
        Dim connString As String = "Database=test;Data Source=localhost;" _
          & "User Id=r;Password="

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
                    tablenums(j) = objDataset.Tables("Table").Rows(j).Item(0)
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

                    MainForm.Reset_Button.BackColor = Color.LightGray
                    MainForm.Update_tables_Button.BackColor = Color.LightGray


            Catch ex As MySqlException
                MsgBox("Error: " & ex.ToString())
            End Try

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
        End Try




    End Sub

    Public Shared Sub Delete_row(ByRef Table_num As Integer)
        Dim connString As String = "Database=test;Data Source=localhost;" _
         & "User Id=r;Password="

        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()

            cmd.Connection = conn

            cmd.CommandText = "DELETE FROM viadia WHERE Table_num = " & Table_num
            cmd.Prepare()


            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("Reservation delete successfully!")

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString())
        End Try

    End Sub


End Class
