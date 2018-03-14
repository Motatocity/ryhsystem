Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Public Class Help_Show
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
    Dim idkey2 As String
    Private Sub Help_Show_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim mysqlcommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mysqlreader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = ComboBoxsearchname.Text

        mysqlcommand.CommandText = " SELECT * FROM helpdesk order by idhelpdesk ;"
        mysqlcommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mysqlcommand
        Try
            mysqlreader = mysqlcommand.ExecuteReader
            ListViewshow.Items.Clear()
            While (mysqlreader.Read())
                With ListViewshow.Items.Add(mysqlreader("idhelpdesk"))
                    .subitems.add(mysqlreader("problem"))
                    .subitems.add(mysqlreader("edit_problem"))
                    .subitems.add(mysqlreader("name_person"))
                    .subitems.add(mysqlreader("state_problem"))
                    .subitems.add(mysqlreader("officer"))
                    .subitems.add(mysqlreader("date"))
                    .subitems.add(mysqlreader("agencies"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mysqlcommand.CommandText = "SELECT * FROM officer order by idofficer ;"
        mysqlcommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mysqlcommand

        Try
            mysqlreader = mysqlcommand.ExecuteReader
            ComboBoxsearchname.Items.Clear()
            While (mysqlreader.Read())
                ComboBoxsearchname.Items.Add(mysqlreader("officer_name"))

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        txtshowreport.Text = ListViewshow.Items.Count.ToString

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mysqlcommand.CommandText = "SELECT * FROM section order by idsection;"
        mysqlcommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mysqlcommand

        Try
            mysqlreader = mysqlcommand.ExecuteReader

            While (mysqlreader.Read())
                ComboBoxsearchagen.Items.Add(mysqlreader("section_name"))

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub
    Private Sub showdatashow()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = ComboBoxsearchname.Text

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = " SELECT * FROM helpdesk where officer like '%" + key + "%' and agencies like '%" + ComboBoxsearchagen.Text + "%' and type_problem like '%" + ComboBoxsearchtype.Text + "%' order by idhelpdesk ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ListViewshow.Items.Clear()
            While (mySqlReader.Read())
                With ListViewshow.Items.Add(mySqlReader("idhelpdesk"))
                    .subitems.add(mySqlReader("problem"))
                    .subitems.add(mySqlReader("edit_problem"))
                    .subitems.add(mySqlReader("name_person"))
                    .subitems.add(mySqlReader("state_problem"))
                    .subitems.add(mySqlReader("officer"))
                    .subitems.add(mySqlReader("date"))
                    .subitems.add(mySqlReader("agencies"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        txtshowreport.Text = ListViewshow.Items.Count.ToString
    End Sub

    Private Sub btnxback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NextForm As Help_Add = New Help_Add
        NextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnxexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "ยืนยันออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        showdatashow()
        ComboBoxsearchagen.Text = ""
        ComboBoxsearchname.Text = ""
        ComboBoxsearchtype.Text = ""
    End Sub
    Private Sub ComboBoxsearchname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxsearchname.SelectedIndexChanged
        showdatashow()
    End Sub

    Private Sub ComboBoxsearchagen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxsearchagen.SelectedIndexChanged
        showdatashow()
    End Sub

    Private Sub ComboBoxsearchtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxsearchtype.SelectedIndexChanged
        showdatashow()
    End Sub

    Private Sub ListViewshow_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewshow.DoubleClick
    
    End Sub
End Class