Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class Help_Edit
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
    Dim idkey10 As String
    Dim idkey3 As String
    Dim idkey2 As String
  
    Private Sub Help_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
       ip_connect = "ryh1"
        db_name = "it_rajyindee"
        mysql_pass = "software"
        user_namedb = "june"

        mysql.ConnectionString = "server=" + ip_connect + ";user id=" + user_namedb + ";password=" + mysql_pass + ";database=" + db_name + ";Character Set =utf8;"
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

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim count As String

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM helpdesk order by idhelpdesk DESC ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewhelp2.Items.Clear()

            While (mySqlReader.Read())

                With ListViewhelp2.Items.Add(mySqlReader("idhelpdesk"))
                    .subitems.add(mySqlReader("type_problem"))
                    .subitems.add(mySqlReader("agencies"))
                    .subitems.add(mySqlReader("state_problem"))
                    .subitems.add(mySqlReader("problem"))
                    .subitems.add(mySqlReader("date"))
                    .subitems.add(mySqlReader("edit_problem"))
                    .subitems.add(mySqlReader("officer"))
                    .subitems.add(mySqlReader("location"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM helpdesk where idhelpdesk = '" & idkey1 & "' ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try

            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtidedit.Text = mySqlReader("idhelpdesk")
                txtnameedit.Text = mySqlReader("name_person")
                txtproedit.Text = mySqlReader("problem")
                txteditproedit.Text = mySqlReader("edit_problem")
                ComboBoxoffedit.Text = mySqlReader("officer")
                ComboBoxstatedit.Text = mySqlReader("state_problem")
                ComboBoxtypeproedit.Text = mySqlReader("type_problem")
                ComboBoxlocation.Text = mySqlReader("location")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        'If sql.State = ConnectionState.Closed Then
        '    sql.Open()
        'End If

        'mySqlCommand.CommandText = "SELECT * FROM section order by idsection;"
        'mySqlCommand.Connection = sql
        'mySqlAdaptor.SelectCommand = mySqlCommand

        'Try
        '    mySqlReader = mySqlCommand.ExecuteReader

        '    While (mySqlReader.Read())
        '        ComboBoxagenedit.Items.Add(mySqlReader("section_name"))


        '    End While
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        'sql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT DISTINCT location_name FROM location order by idlocation;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())
                ComboBoxlocation.Items.Add(mySqlReader("location_name"))


            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM officer order by idofficer ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())
                ComboBoxoffedit.Items.Add(mySqlReader("officer_name"))

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM helpdesk where state_problem = 'กำลังดำเนินการ'  order by  idhelpdesk;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ListViewbacklog.Items.Clear()
            While (mySqlReader.Read())

                With ListViewbacklog.Items.Add(mySqlReader("idhelpdesk"))
                    .subitems.add(mySqlReader("state_problem"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM helpdesk where idhelpdesk = '" & idkey2 & "' ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try

            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtidedit.Text = mySqlReader("idhelpdesk")
                txtnameedit.Text = mySqlReader("name_person")
                txtproedit.Text = mySqlReader("problem")
                txteditproedit.Text = mySqlReader("edit_problem")
                ComboBoxoffedit.Text = mySqlReader("officer")
                ComboBoxstatedit.Text = mySqlReader("state_problem")
                ComboBoxtypeproedit.Text = mySqlReader("type_problem")
                ComboBoxlocation.Text = mySqlReader("location")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub btnxsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxsave.Click
        If txtidedit.Text <> "" Then

            savedata()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะแก้ไข", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub savedata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim commandText2 As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        If respone = 1 Then
            Try
                commandText2 = "UPDATE helpdesk SET name_person = '" & txtnameedit.Text & "'  , type_problem = '" & ComboBoxtypeproedit.Text & "', problem = '" & txtproedit.Text & "' , officer = '" & ComboBoxoffedit.Text & "'  , state_problem = '" & ComboBoxstatedit.Text & "' , edit_problem = '" & txteditproedit.Text & "' , location = '" & ComboBoxlocation.Text & "' WHERE idhelpdesk = " & txtidedit.Text & "; "
                mySqlCommand.CommandText = commandText2
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showdataedit()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM helpdesk where state_problem = 'กำลังดำเนินการ'  order by  idhelpdesk;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ListViewbacklog.Items.Clear()
            While (mySqlReader.Read())

                With ListViewbacklog.Items.Add(mySqlReader("idhelpdesk"))
                    .subitems.add(mySqlReader("state_problem"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
    End Sub
    Private Sub showdataedit()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer
        count = 0
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM helpdesk order by idhelpdesk  DESC ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewhelp2.Items.Clear()

            While (mySqlReader.Read())

                With ListViewhelp2.Items.Add(mySqlReader("idhelpdesk"))
                    .subitems.add(mySqlReader("type_problem"))
                    .subitems.add(mySqlReader("agencies"))
                    .subitems.add(mySqlReader("state_problem"))
                    .subitems.add(mySqlReader("problem"))
                    .subitems.add(mySqlReader("date"))
                    .subitems.add(mySqlReader("edit_problem"))
                    .subitems.add(mySqlReader("officer"))
                    .subitems.add(mySqlReader("location"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub btnxclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxclear.Click
        txtidedit.Text = ""
        txteditproedit.Text = ""
        txtnameedit.Text = ""
        txtproedit.Text = ""
        ComboBoxoffedit.Text = ""
        ComboBoxstatedit.Text = ""
        ComboBoxtypeproedit.Text = ""
        ComboBoxlocation.Text = ""
        txtnameedit.Focus()
    End Sub

    Private Sub btnxdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxdelete.Click
        If txtidedit.Text <> "" Then

            DeleteData()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตารางที่จะลบออก", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txteditproedit.Text = ""
        txtnameedit.Text = ""
        txtproedit.Text = ""
        ComboBoxoffedit.Text = ""
        ComboBoxstatedit.Text = ""
        ComboBoxtypeproedit.Text = ""
        ComboBoxlocation.Text = ""
        txtnameedit.Focus()
        showdataedit()
        txtidedit.Text = ""
    End Sub
    Private Sub DeleteData()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object
        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If txtidedit.Text <> "" Then

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
                Try

                    mySqlCommand.CommandText = "DELETE FROM helpdesk where idhelpdesk = '" & txtidedit.Text & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql
                    mySqlCommand.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Exit Sub
                End Try
                mysql.Close()
                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
            End If
        End If
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

    Private Sub ListViewhelp2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewhelp2.Click
        idkey = ListViewhelp2.SelectedItems(0).SubItems(0).Text
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim mysqlcommand As New MySqlCommand
        Dim mysqladeptor As New MySqlDataAdapter
        Dim mysqlreader As MySqlDataReader

        mysqlcommand.CommandText = " SELECT * FROM helpdesk where idhelpdesk = '" & idkey & "' ;"
        mysqlcommand.Connection = mysql
        mysqladeptor.SelectCommand = mysqlcommand

        Try
            mysqlreader = mysqlcommand.ExecuteReader
            While (mysqlreader.Read())
                txtidedit.Text = mysqlreader("idhelpdesk")
                txtnameedit.Text = mysqlreader("name_person")
                txtproedit.Text = mysqlreader("problem")
                txteditproedit.Text = mysqlreader("edit_problem")
                ComboBoxoffedit.Text = mysqlreader("officer")
                ComboBoxstatedit.Text = mysqlreader("state_problem")
                ComboBoxtypeproedit.Text = mysqlreader("type_problem")
                ComboBoxlocation.Text = mysqlreader("location")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub ListViewbacklog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewbacklog.Click
        idkey10 = ListViewbacklog.SelectedItems(0).SubItems(0).Text
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim mysqlcommand As New MySqlCommand
        Dim mysqladeptor As New MySqlDataAdapter
        Dim mysqlreader As MySqlDataReader

        mysqlcommand.CommandText = " SELECT * FROM helpdesk where idhelpdesk = '" & idkey10 & "' ;"
        mysqlcommand.Connection = mysql
        mysqladeptor.SelectCommand = mysqlcommand

        Try

            mysqlreader = mysqlcommand.ExecuteReader
            While (mysqlreader.Read())
                txtidedit.Text = mysqlreader("idhelpdesk")
                txtnameedit.Text = mysqlreader("name_person")
                txtproedit.Text = mysqlreader("problem")
                txteditproedit.Text = mysqlreader("edit_problem")
                ComboBoxoffedit.Text = mysqlreader("officer")
                ComboBoxstatedit.Text = mysqlreader("state_problem")
                ComboBoxtypeproedit.Text = mysqlreader("type_problem")
                ComboBoxlocation.Text = mysqlreader("location")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub
End Class