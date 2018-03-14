Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frm_addtraining
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Dim respone As Object
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Dim mySqlCommand As New MySqlCommand

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Please complete all field", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning Message")
        Else
            respone = MsgBox("Are you sure to save data", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
            If respone = 1 Then
                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If

                Try
                    mySqlCommand.CommandText = "INSERT INTO Course (course_name,course_start_date,course_trainer,course_duration) VALUES ('" & TextBox1.Text & "','" & DateTimePicker1.Value.Year.ToString() & "-" & DateTimePicker1.Value.Month.ToString() & "-" & DateTimePicker1.Value.Day.ToString() & "', '" & TextBox2.Text & "','" & TextBox4.Text & "');"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql

                    mySqlCommand.ExecuteNonQuery()

                Catch ex As Exception

                    MsgBox("Please check your data again!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning Message")
                    Exit Sub

                End Try



                mysql.Close()


                '=========================================


            End If
        End If

    End Sub

    Private Sub frm_addtraining_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=testremote;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
    End Sub
End Class