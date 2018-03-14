Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class frmpackage2_1
    Public Sql As MySqlConnection
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Dim id_user As String

    Dim position_user As String
    Public selectedEmployee As String
    Dim idcontainer As String
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim id_hn As String
    Dim export_id As String
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String, ByRef hn As String)

        mysqlpass = mysql_pass

        selectedEmployee = ""
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        id_hn = hn
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NextForm As frmpackage2 = New frmpackage2(mysqlpass, ipconnect, usernamedb, dbname, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub frmpackage2_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
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
        mySqlCommand.CommandText = "Select * from checkup_export where hn like '" + id_hn + "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("checkup_export_id"))

                    .SubItems.Add(mySqlReader("hn"))

                    .SubItems.Add(mySqlReader("t_name") + mySqlReader("f_name") + "  " + mySqlReader("l_name"))


                    .SubItems.Add(mySqlReader("export_date"))
                End With


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        export_id = ListView1.SelectedItems(0).SubItems(0).Text

        Dim NextForm As frmpackage2 = New frmpackage2(mysqlpass, ipconnect, usernamedb, dbname, id_hn, export_id)
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub
End Class