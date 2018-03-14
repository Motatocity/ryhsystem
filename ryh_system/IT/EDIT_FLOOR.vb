Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class EDIT_FLOOR
    Dim sql As MySqlConnection
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim idkey As String
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String)
        InitializeComponent()
        mysqlpass = mysql_pass
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
    End Sub
    Private Sub EDIT_SECTION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = New MySqlConnection
        sql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            sql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM floor  order by idFloor;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewfloor.Items.Clear()

            While (mySqlReader.Read())

                With ListViewfloor.Items.Add(mySqlReader("idFloor"))
                    .SubItems.Add(mySqlReader("floor_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub


    Private Sub ListViewfloor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewfloor.Click
        idkey = ListViewfloor.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        mySqlCommand.CommandText = "SELECT * FROM Floor where idFloor = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtnamefloor.Text = mySqlReader("floor_name")
                txtidfloor.Text = mySqlReader("idFloor")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtidfloor.Text <> "" And txtnamefloor.Text <> "" Then

            savedata()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txtidfloor.Text = ""
        txtnamefloor.Text = ""
    End Sub
    Private Sub savedata()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object
        Dim commandText2 As String

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then

            If txtidfloor.Text <> "" Then
                Try
                    commandText2 = "UPDATE Floor SET floor_name = '" & txtnamefloor.Text & "'  WHERE idFloor = " & txtidfloor.Text & "; "
                    mySqlCommand.CommandText = commandText2
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
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
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM Floor order by idFloor ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewfloor.Items.Clear()

            While (mySqlReader.Read())

                With ListViewfloor.Items.Add(mySqlReader("idFloor"))
                    .subitems.add(mySqlReader("floor_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If txtidfloor.Text <> "" Then

            DeleteData()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txtidfloor.Text = ""
        txtnamefloor.Text = ""
    End Sub
    Private Sub DeleteData()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object
        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If txtidfloor.Text <> "" Then

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If
                Try

                    mySqlCommand.CommandText = "DELETE FROM Floor where idFloor = '" & txtidfloor.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql

                    mySqlCommand.ExecuteNonQuery()
                    sql.Close()
                Catch ex As Exception

                    MsgBox(ex.ToString)
                    Exit Sub
                End Try

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If
            End If
        End If
        showdata()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim NextForm As ADD_FLOOR = New ADD_FLOOR(mysqlpass, ipconnect, usernamedb, dbname)
        NextForm.Show()
        Me.Hide()
    End Sub
End Class