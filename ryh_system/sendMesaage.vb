Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Public Class sendMesaage
    Dim id_primay As String
    Dim mysql As MySqlConnection
    Dim stat As String
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Dim mySqlCommand As New MySqlCommand
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Try
            mySqlCommand.CommandText = "INSERT INTO message_send (message_to,message_send,date_time,readornot) VALUES ('" & sendto.Text & "','" & sendmassage.Text & "','" & Date.Now.Date.ToString("dd/MM/yyyy HH:mm") & "', 'ยังไม่ได้อ่าน');"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql

            mySqlCommand.ExecuteNonQuery()
            mysql.Close()

            ToastNotification.Show(Me, "ท่านได้ส่งข้อความหา" + sendto.Text + "เป็นทีเรียบร้อยแล้ว")

            sendmassage.Text = ""
            sendto.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub

        End Try


    End Sub

    Private Sub sendMesaage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

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