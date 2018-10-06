Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports AcceleratedIdeas
Public Class oil_company
    Public Sql As MySqlConnection
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Dim id_user As String
    Dim position_user As String
    Public selectedEmployee As String
    Dim idcompany As String = ""
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim id_hn As String
    Dim export_id As String
    Dim id_master As String
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String)

        mysqlpass = mysql_pass

        selectedEmployee = ""
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub oil_company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        ' mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        ipconnect = "ryh1"
        ipconnect = "192.0.0.200"

        mysqlpass = "software"
        usernamedb = "june"
        dbname = "rajyindee_db"

        mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        'mySqlCommand.CommandText = "SELECT DISTINCT * from Employee where dept_id in (SELECT dept_id from Department where dept_name like" + " '%" + TextBox1.Text + "%' )" + " or emp_name like " + "'%" + TextBox1.Text + "%'" + " or emp_surname like " + "'%" + TextBox1.Text + "%'" + " or emp_position like " + "'%" + TextBox1.Text + "%'" + " or emp_level like " + "'%" + TextBox1.Text + "%'" + ";"
        mySqlCommand.CommandText = "SELECT * FROM company_name where idcompany_name >= '319';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("idcompany_name"))
                    .SubItems.Add(mySqlReader("com_name"))
                    .SubItems.Add(mySqlReader("com_add"))
                    .SubItems.Add(mySqlReader("com_tell"))
                    .SubItems.Add(mySqlReader("com_fax"))

                End With



            End While
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        mysql.Close()

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim NextForm As main = New main()
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub showdata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearch.Text

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        'mySqlCommand.CommandText = "SELECT DISTINCT * from Employee where dept_id in (SELECT dept_id from Department where dept_name like" + " '%" + TextBox1.Text + "%' )" + " or emp_name like " + "'%" + TextBox1.Text + "%'" + " or emp_surname like " + "'%" + TextBox1.Text + "%'" + " or emp_position like " + "'%" + TextBox1.Text + "%'" + " or emp_level like " + "'%" + TextBox1.Text + "%'" + ";"
        mySqlCommand.CommandText = "SELECT * FROM company_name where (idcompany_name like" + "'%" + key + "%' or  com_name like '%" + key + "%'  or  com_tell like '%" + key + "%'   or  com_fax like '%" + key + "%') and idcompany_name >= '319';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())
                With ListView1.Items.Add(mySqlReader("idcompany_name"))
                    .SubItems.Add(mySqlReader("com_name"))
                    .SubItems.Add(mySqlReader("com_add"))
                    .SubItems.Add(mySqlReader("com_tell"))
                    .SubItems.Add(mySqlReader("com_fax"))

                End With
            End While
        Catch
            MsgBox("ห้ามใส่เครื่องหมาย ' ในช่องค้นหา", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning Message")
        End Try
        mysql.Close()
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = "13" Then
            showdata()
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        showdata()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If idcompany <> "" Then
            Dim ip_connect As String
            Dim mysql_pass As String
            Dim user_namedb As String
            Dim db_name As String

            ip_connect = "192.0.0.204"
            mysql_pass = "sa"
            user_namedb = "sa"
            db_name = "lab_rajyindee"
            Dim NextForm As frmOilPackage = New frmOilPackage(mysql_pass, ip_connect, user_namedb, db_name, idcompany, "0", "0")
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()


        Else
            MsgBox("กรุณาเลือกข้อมูลบริษัท")
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        id_master = ListView1.SelectedItems(0).SubItems(0).Text
        idcompany = ListView1.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick

        idcompany = ListView1.SelectedItems(0).SubItems(1).Text
        Dim ip_connect As String
        Dim mysql_pass As String
        Dim user_namedb As String
        Dim db_name As String

        ip_connect = "192.0.0.204"
        mysql_pass = "sa"
        user_namedb = "sa"
        db_name = "lab_rajyindee"
        Dim NextForm As frmOilPackage = New frmOilPackage(mysql_pass, ip_connect, user_namedb, db_name, idcompany, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()



    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim NextForm As company_oil = New company_oil(mysqlpass, ipconnect, usernamedb, dbname)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If id_master <> "" Then

            Dim NextForm As company_edit = New company_edit(id_master)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()



        Else
            MsgBox("กรุณาเลือกข้อมูลบริษัท")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListView1.SelectedItems.Count > 0 Then
            id_master = ListView1.SelectedItems(0).SubItems(0).Text
            DeleteData()
        End If
    End Sub

    Private Sub DeleteData()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If id_master <> "" Then

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
                Try

                    mySqlCommand.CommandText = "DELETE FROM  company_name where idcompany_name = '" & id_master & "';"
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



                'mySqlCommand.CommandText = "SELECT DISTINCT * from Employee where dept_id in (SELECT dept_id from Department where dept_name like" + " '%" + TextBox1.Text + "%' )" + " or emp_name like " + "'%" + TextBox1.Text + "%'" + " or emp_surname like " + "'%" + TextBox1.Text + "%'" + " or emp_position like " + "'%" + TextBox1.Text + "%'" + " or emp_level like " + "'%" + TextBox1.Text + "%'" + ";"
                mySqlCommand.CommandText = "SELECT * FROM company_name where idcompany_name >= '319';"
                ' mySqlCommand.CommandText = 
                mySqlCommand.Connection = mysql
                mySqlAdaptor.SelectCommand = mySqlCommand

                Try
                    mySqlReader = mySqlCommand.ExecuteReader

                    ListView1.Items.Clear()

                    While (mySqlReader.Read())

                        With ListView1.Items.Add(mySqlReader("idcompany_name"))
                            .SubItems.Add(mySqlReader("com_name"))
                            .SubItems.Add(mySqlReader("com_add"))
                            .SubItems.Add(mySqlReader("com_tell"))
                            .SubItems.Add(mySqlReader("com_fax"))

                        End With



                    End While
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                mysql.Close()

            Else
                MsgBox("กรุณาเลือกข้อมูลในตารางที่จะลบออก")
            End If
        End If
    End Sub

End Class