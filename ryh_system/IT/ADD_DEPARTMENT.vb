Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class ADD_DEPARTMENT
    'ประกาศตัวแปรตัวเชื่อมต่อ
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection
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
    Private Sub ADD_DEPARTMENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql.Close()

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

        mySqlCommand.CommandText = "SELECT * FROM floor order by idFloor ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand


        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewsection.Items.Clear()

            While (mySqlReader.Read())

                With ListViewsection.Items.Add(mySqlReader("idFloor"))
                    .SubItems.Add(mySqlReader("floor_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

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
            If txtsection.Text <> "" Then
                mySqlCommand.CommandText = "INSERT INTO section (section_name,idFloor) VALUES ('" & txtsection.Text & "','" & txtid.Text & "' );"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()
                MessageBox.Show("เก็บเข้าฐานข้อมูลแล้ว", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtsection.Text = ""

            Else
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtsection.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
            sql.Close()
        End Try
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        txtsection.Text = ""
        txtsection.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
    End Sub

    Private Sub ListViewsection_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewsection.Click
        idkey = ListViewsection.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        mySqlCommand.CommandText = "SELECT * FROM Floor where idFloor = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtid.Text = mySqlReader("idFloor")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub btneditsection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditsection.Click
        Dim NextForm As EDIT_SECTION = New EDIT_SECTION(mysqlpass, ipconnect, usernamedb, dbname)
        NextForm.Show()
        Me.Hide()
    End Sub
End Class