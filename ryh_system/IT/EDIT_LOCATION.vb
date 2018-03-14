Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class EDIT_LOCATION
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
    Private Sub EDIT_LOCATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        mySqlCommand.CommandText = "SELECT * FROM section  where idsection ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListVieweditlocation.Items.Clear()

            While (mySqlReader.Read())

                With ListVieweditlocation.Items.Add(mySqlReader("idsection"))
                    .SubItems.Add(mySqlReader("section_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshowsec.Text = ListVieweditlocation.Items.Count.ToString
    End Sub

    Private Sub ListVieweditlocation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListVieweditlocation.Click
        idkey = ListVieweditlocation.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM location where idsection = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlocation.Items.Clear()

            While (mySqlReader.Read())

                With ListViewlocation.Items.Add(mySqlReader("idlocation"))
                    .subitems.add(mySqlReader("location_name"))
                    .subitems.add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshowlo.Text = ListViewlocation.Items.Count.ToString
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtidlocation.Text <> "" Then

            savedata()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub savedata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim commandText2 As String

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If txtidlocation.Text <> "" Then
                Try
                    commandText2 = "UPDATE location SET location_name = '" & txtlocation.Text & "' , description_name = '" & TextBox1.Text & "' WHERE idlocation = " & txtidlocation.Text & "; "
                    mySqlCommand.CommandText = commandText2
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                sql.Close()
            End If
        End If
        txtfloor.Text = ""
        txtidlocation.Text = ""
        txtlocation.Text = ""
        txtsection.Text = ""

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        idkey = ListVieweditlocation.SelectedItems(0).SubItems(0).Text
        mySqlCommand.CommandText = "SELECT * FROM location where idsection = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlocation.Items.Clear()

            While (mySqlReader.Read())

                With ListViewlocation.Items.Add(mySqlReader("idlocation"))
                    .subitems.add(mySqlReader("location_name"))
                    .subitems.add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub
    Private Sub showdata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM section  where idsection ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListVieweditlocation.Items.Clear()

            While (mySqlReader.Read())

                With ListVieweditlocation.Items.Add(mySqlReader("idsection"))
                    .SubItems.Add(mySqlReader("section_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        sql.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If txtidlocation.Text <> "" Then

            DeleteData()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        showdata()
    End Sub
    Private Sub DeleteData()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If txtidlocation.Text <> "" Then
                Try

                    mySqlCommand.CommandText = "DELETE FROM location where idlocation = '" & txtidlocation.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Exit Sub
                End Try
                sql.Close()

            End If
        End If
        showdata()
        txtidlocation.Text = ""
        txtfloor.Text = ""
        txtsection.Text = ""
        txtlocation.Text = ""
        sql.Close()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        idkey = ListVieweditlocation.SelectedItems(0).SubItems(0).Text
        mySqlCommand.CommandText = "SELECT * FROM location where idsection = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlocation.Items.Clear()

            While (mySqlReader.Read())
                With ListViewlocation.Items.Add(mySqlReader("idlocation"))
                    .subitems.add(mySqlReader("location_name"))
                    .subitems.add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
    End Sub

    Private Sub ListViewlocation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewlocation.Click

        idkey = ListViewlocation.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM location join section join floor where (location.idfloor = floor.idfloor and section.idfloor = floor.idfloor and location.idsection = section.idsection )and idlocation = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand


        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtfloor.Text = mySqlReader("floor_name")
                txtsection.Text = mySqlReader("section_name")
                txtidlocation.Text = mySqlReader("idlocation")
                txtlocation.Text = mySqlReader("location_name")
                TextBox1.Text = mySqlReader("description_name")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim NextForm As ADD_LOCATION = New ADD_LOCATION(mysqlpass, ipconnect, usernamedb, dbname)
        NextForm.Show()
        Me.Hide()
    End Sub
End Class