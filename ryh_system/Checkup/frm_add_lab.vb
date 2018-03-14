Imports MySql.Data.MySqlClient
Public Class frm_add_lab
    Dim position_user As String
    Public selectedEmployee As String
    Dim idcheck_name As String
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim export_id As String
    Dim id_hn As String
    Public respone As Object
    Dim mysql As MySqlConnection
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String)
        InitializeComponent()
        mysqlpass = mysql_pass

        selectedEmployee = ""
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name

    End Sub
    Private Sub frm_add_lab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mysql = New MySqlConnection
        mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            mysql.Open()
            ''MsgBox("CONNECTED TO DATABASE")
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
        mySqlCommand.CommandText = "SELECT * FROM check_name;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())
                With ListView1.Items.Add(mySqlReader("idcheck_name"))

                    .SubItems.Add(mySqlReader("type_name"))

                End With
            End While
        Catch

        End Try
        mysql.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String


        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Try

                mySqlCommand.CommandText = "INSERT INTO check_name (type_name,normal_value_s,normal_value_e,unit_value) VALUES ('" & txt_name_lab.Text & "','" & txt_start_value.Text & "', '" & txt_end_value.Text & "', '" & txt_unit.Text & "');"

                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql

                mySqlCommand.ExecuteNonQuery()
                MsgBox("ข้อมูลการตรวจบันทึกผลสุขภาพ    " + txt_name_lab.Text + " ถูกบันถึกเข้าฐานข้อมูลเรียบร้อยแล้ว")


                txt_end_value.Text = ""
                txt_name_lab.Text = ""
                txt_start_value.Text = ""
                txt_unit.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("กรุณาอย่าใช้อักขระพิเศษ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning Message")
                mysql.Close()
                Exit Sub

            End Try




        End If
        mysql.Close()
        Me.Refresh()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        idcheck_name = ListView1.SelectedItems(0).SubItems(0).Text


        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        mySqlCommand.CommandText = "SELECT * FROM check_name where idcheck_name = '" & idcheck_name & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())
                tab1_txt_name_check.Text = mySqlReader("type_name")
                tab1_txt_start.Text = mySqlReader("normal_value_s")
                tab1_txt_end.Text = mySqlReader("normal_value_e")
                tab1_txt_unit.Text = mySqlReader("unit_value")
            End While


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click

    End Sub
End Class