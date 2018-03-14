Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmlogin_dept
    Public Shared mysql As MySqlConnection
    Dim mysql_ryh As MySqlConnection
    ' Public Shared MyODBCConnection As New ODBCConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Dim inbtIndex As Integer
    Dim cmd_result As Integer
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim check As String = "0"
    Public Shared username As String
    Public Shared iddep As Integer
    Public Shared dept As String
    Public Shared password As String
    Public Shared name As String

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        checklogin()

    End Sub
    Public Sub checklogin()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        mySqlCommand.CommandText = "Select * from userdep  where  username ='" & TextBoxX1.Text & "' ;"
        mySqlAdaptor.SelectCommand = mySqlCommand
        mySqlCommand.Connection = mysql
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())

                If TextBoxX1.Text = mySqlReader("username") Then

                    If TextBoxX2.Text = mySqlReader("password") Then
                        iddep = mySqlReader("iduserdep")
                        username = mySqlReader("username")
                        dept = mySqlReader("dep")
                        password = mySqlReader("password")
                        name = mySqlReader("name")

                        Dim nextform As frmmain_dep = New frmmain_dep
                        nextform.Show()
                        Me.Close()


                    Else
                        MsgBox("Password ไม่ถูกต้อง")
                    End If
                Else
                    MsgBox("Username ไม่ถูกต้อง")
                End If

            End While

        Catch ex As Exception

        End Try
       

    End Sub
    Private Sub frmlogin_dept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("th-TH")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
     
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
    End Sub



    Private Sub TextBoxX2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX2.KeyDown
        If e.KeyCode = Keys.Enter Then
            checklogin()
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
End Class