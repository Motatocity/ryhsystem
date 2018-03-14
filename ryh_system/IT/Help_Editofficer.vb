Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class Help_Editofficer
    Dim mysql As MySqlConnection
    Dim idkey As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim mysql_pass As String
    Dim ip_connect As String
    Dim user_namedb As String
    Dim db_name As String
    Dim idkey1 As String
    Private Sub Help_Editofficer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySql = New MySqlConnection
       ip_connect = "ryh1"
        db_name = "it_rajyindee"
        mysql_pass = "software"
        user_namedb = "june"

        MySql.ConnectionString = "server=" + ip_connect + ";user id=" + user_namedb + ";password=" + mysql_pass + ";database=" + db_name + ";Character Set =utf8;"
        Try
            MySql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
        If MySql.State = ConnectionState.Closed Then
            MySql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM officer  order by idofficer ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewofficer.Items.Clear()

            While (mySqlReader.Read())

                With ListViewofficer.Items.Add(mySqlReader("idofficer"))
                    .SubItems.Add(mySqlReader("officer_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub btnxsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxsave.Click
        If txtidofficer.Text <> "" And txtnameofficer.Text <> "" Then

            savedata()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txtidofficer.Text = ""
        txtnameofficer.Text = ""
    End Sub
    Private Sub savedata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object
        Dim commandText2 As String

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then

            If txtidofficer.Text <> "" Then
                Try
                    commandText2 = "UPDATE officer SET officer_name = '" & txtnameofficer.Text & "'  WHERE idofficer = " & txtidofficer.Text & "; "
                    mySqlCommand.CommandText = commandText2
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql
                    mySqlCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
            End If
        End If
        showdata()
    End Sub
    Private Sub showdata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer
        count = 0
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM officer order by idofficer ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewofficer.Items.Clear()

            While (mySqlReader.Read())

                With ListViewofficer.Items.Add(mySqlReader("idofficer"))
                    .subitems.add(mySqlReader("officer_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        If txtidofficer.Text <> "" Then

            DeleteData()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txtidofficer.Text = ""
        txtnameofficer.Text = ""
    End Sub
    Private Sub DeleteData()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object
        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If txtidofficer.Text <> "" Then

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
                Try

                    mySqlCommand.CommandText = "DELETE FROM officer where idofficer = '" & txtidofficer.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql

                    mySqlCommand.ExecuteNonQuery()
                    mysql.Close()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
            End If
        End If
        showdata()
    End Sub

    Private Sub btnxback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxback.Click
        Dim NextForm As Help_Add = New Help_Add
        NextForm.Show()
        Me.Hide()
    End Sub
End Class