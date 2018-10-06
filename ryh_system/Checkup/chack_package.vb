Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Public Class chack_package
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
 
    Private Sub chack_package_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.load
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
        mySqlCommand.CommandText = "SELECT * FROM healthycare_ryh order by idhealthycare DESC LIMIT 100;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("p_id"))
                    .SubItems.Add(mySqlReader("p_name"))
                    .SubItems.Add(mySqlReader("p_date"))
                    .SubItems.Add(mySqlReader("package_type"))
                    .SubItems.Add(mySqlReader("idhealthycare"))
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

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
        mySqlCommand.CommandText = "SELECT * FROM healthycare_ryh where idhealthycare like" + "'%" + key + "%' or  p_id like '%" + key + "%'  or  p_name like '%" + key + "%'   or  package_type like '%" + key + "%' order by idhealthycare DESC LIMIT 100;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())
                With ListView1.Items.Add(mySqlReader("p_id"))
                    .SubItems.Add(mySqlReader("p_name"))
                    .SubItems.Add(mySqlReader("p_date"))
                    .SubItems.Add(mySqlReader("package_type"))
                    .SubItems.Add(mySqlReader("idhealthycare"))
                End With
            End While
        Catch
            MsgBox("ห้ามใส่เครื่องหมาย ' ในช่องค้นหา", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning Message")
        End Try
        mysql.Close()
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = "13" Then
            showdata()
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim key As String


        key = ListView1.SelectedItems(0).SubItems(3).Text
        ipconnect = "192.0.0.200"
        mysqlpass = "software"
        usernamedb = "june"
        dbname = "rajyindee_db"

        If key = "P6" Then
            Dim NextForm As package6 = New package6(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()

        ElseIf key = "P5" Then
            Dim NextForm As package5 = New package5(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "P4" Then
            Dim NextForm As package4 = New package4(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "P3" Then
            Dim NextForm As package3 = New package3(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "P2" Then
            Dim NextForm As package2 = New package2(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "P1" Then
            Dim NextForm As package1 = New package1(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "Oil" Then
            Dim NextForm As packageoil = New packageoil(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        End If
    End Sub

 


    Private Sub DeleteData()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Try

            mySqlCommand.CommandText = "DELETE FROM healthycare_ryh where idhealthycare = '" & ListView1.SelectedItems(0).SubItems(4).Text & "';"
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


        mySqlCommand.CommandText = "SELECT * FROM healthycare_ryh order by idhealthycare;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("p_id"))
                    .SubItems.Add(mySqlReader("p_name"))
                    .SubItems.Add(mySqlReader("p_date"))
                    .SubItems.Add(mySqlReader("package_type"))
                    .SubItems.Add(mySqlReader("idhealthycare"))
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub

   
    Private Sub buttonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX1.Click
        showdata()
    End Sub

    Private Sub txtsearch_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = "13" Then
            showdata()
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        DeleteData()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Dim key As String


        key = ListView1.SelectedItems(0).SubItems(3).Text
        ipconnect = "192.0.0.200"
        mysqlpass = "software"
        usernamedb = "june"
        dbname = "rajyindee_db"

        If key = "P6" Then
            Dim NextForm As package6 = New package6(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()

        ElseIf key = "P5" Then
            Dim NextForm As package5 = New package5(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "P4" Then
            Dim NextForm As package4 = New package4(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "P3" Then
            Dim NextForm As package3 = New package3(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "P2" Then
            Dim NextForm As package2 = New package2(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "P1" Then
            Dim NextForm As package1 = New package1(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        ElseIf key = "Oil" Then
            Dim NextForm As packageoil = New packageoil(mysqlpass, ipconnect, usernamedb, dbname, ListView1.SelectedItems(0).SubItems(4).Text)
            '  Dim NextForm As main_user = New main_user()
            NextForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Dim NextForm As main = New main()
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl1.Click

    End Sub
End Class