Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class ADD_FLOOR
    Dim sql As MySqlConnection
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String)
        InitializeComponent()
        mysqlpass = mysql_pass
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
    End Sub
    Private Sub ADD_FLOOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = New MySqlConnection
        sql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            sql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Try
            ''เช็คข้อมูลที่บังคับป้อน
            If txtfloor.Text <> "" Then
                mySqlCommand.CommandText = "INSERT INTO floor (floor_name) VALUES ('" & txtfloor.Text & "' );"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()
                MessageBox.Show("เก็บเข้าฐานข้อมูลแล้วจ้า!!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtfloor.Text = ""

            Else
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วนนะจ้า!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtfloor.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
            sql.Close()
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtfloor.Text = ""
        txtfloor.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
    End Sub

    Private Sub btneditfloor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditfloor.Click
        Dim NextForm As EDIT_FLOOR = New EDIT_FLOOR(mysqlpass, ipconnect, usernamedb, dbname)
        NextForm.Show()
        Me.Hide()
    End Sub
End Class