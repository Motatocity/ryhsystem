Imports MySql.Data.MySqlClient
Imports System.Data
Imports System

Public Class company_oil
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

        mysqlpass = mysql_pass

        selectedEmployee = ""
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub company_oil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        ' mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"

        ipconnect = "ryh1"
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
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click


        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader



        Dim size As String
        Dim condition As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            Try

                mySqlCommand.CommandText = "INSERT INTO company_name (com_name,com_add,com_tell,com_fax) VALUES ('" & txt_comname.Text & "','" & txt_comaddress.Text & "', '" & txt_comtell.Text & "', '" & txt_comfax.Text & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
                MsgBox("ข้อมูลบริษัท " + txt_comname.Text + " ถูกบันถึกเข้าฐานข้อมูลเรียบร้อยแล้ว")
                clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
                mysql.Close()
                Exit Sub

            End Try


        End If




    End Sub

    Public Sub clear()
        txt_comaddress.Text = ""
        txt_comfax.Text = ""
        txt_comname.Text = ""
        txt_comtell.Text = ""
    End Sub



    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim NextForm As main = New main()
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub
End Class