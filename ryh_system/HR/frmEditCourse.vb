Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmEditCourse
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Public Shared idcourse As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim commandText2 As String
        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Try
            commandText2 = "UPDATE Course SET course_name = '" & txt_CourseName.Text & "' , course_trainer = '" & txt_Trainer.Text & "' , course_trainer = '" & txt_Trainer.Text & "' , course_start_date = '" & DateTimePicker1.Value.Year.ToString() & "-" & DateTimePicker1.Value.Month.ToString() & "-" & DateTimePicker1.Value.Day.ToString() & "' , course_duration = '" & txt_CourseDuration.Text & "' WHERE course_id = " & SelectTraining.idcourse & "; "
            mySqlCommand.CommandText = commandText2
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql

            mySqlCommand.ExecuteNonQuery()
            mysql.Close()
        Catch ex As Exception

        End Try


        Dim cf As New SelectTraining

        cf.MdiParent = Me.MdiParent
        Me.Close()
        cf.Dock = DockStyle.Fill
        cf.Show()



    End Sub

    Private Sub frmEditCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        Dim mysqlda As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim mysqldr As MySql.Data.MySqlClient.MySqlDataReader

        Dim comsql As String = "SELECT * FROM Course where course_id = '" & SelectTraining.idcourse & "';"
        Dim adater As New MySqlCommand


        Try
            adater.CommandText = comsql
            adater.Connection = mysql
            mysqlda.SelectCommand = adater
            mysqldr = adater.ExecuteReader
            While (mysqldr.Read())
                txt_CourseName.Text = mysqldr("course_name")

                txt_Trainer.Text = mysqldr("course_trainer")
                txt_CourseDuration.Text = mysqldr("course_duration")
                DateTimePicker1.Text = mysqldr("course_start_date")
            End While
            mysqldr.Close()
            'Catch ex As MySqlException
            'MsgBox(ex.Message)
        Catch
        End Try
        mysql.Close()



    End Sub
End Class