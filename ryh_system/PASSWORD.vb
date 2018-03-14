Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data

Public Class PASSWORD
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim idkey As String
    Dim idkey4 As String
    Dim idkey1 As String
    Dim idkey5 As String
    Dim idkey6 As String
    Dim idkey7 As String
    Dim idkey8 As String
    Dim idkey9 As String
    Dim idkey10 As String
    Dim mysql_pass As String
    Dim ip_connect As String
    Dim user_namedb As String
    Dim db_name As String

    Public Sub New(ByRef idkey1 As String, ByRef idkey As String, ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        idkey4 = idkey
        idkey5 = idkey1
        idkey6 = idkey
        idkey7 = idkey
        idkey8 = idkey
        idkey9 = idkey
        idkey10 = idkey
        mysqlpass = mysql_pass
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub PASSWORD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpass.Text = "hs9lfj" Then
                DeleteData1()
                Me.Close()
            Else
                MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub

    Private Sub DeleteData1()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim respone As Object
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        respone = MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If idkey4 <> "" Then

                Try
                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & idkey4 & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()

                Catch ex As Exception

                    MsgBox(ex.ToString)

                End Try

                sql.Close()

            End If

            If idkey5 <> "" Then

                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If
                Try

                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & idkey5 & "';"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()

                Catch ex As Exception

                    MsgBox(ex.ToString)

                End Try

                sql.Close()

                If idkey6 <> "" Then

                    If sql.State = ConnectionState.Closed Then
                        sql.Open()
                    End If
                    Try
                        mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & idkey6 & "';"
                        mySqlCommand.CommandType = CommandType.Text
                        mySqlCommand.Connection = sql
                        mySqlCommand.ExecuteNonQuery()

                    Catch ex As Exception

                        MsgBox(ex.ToString)

                    End Try
                    sql.Close()

                    If idkey8 <> "" Then
                        If sql.State = ConnectionState.Closed Then
                            sql.Open()
                        End If

                        Try

                            mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & idkey8 & "';"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = sql
                            mySqlCommand.ExecuteNonQuery()

                        Catch ex As Exception

                            MsgBox(ex.ToString)

                        End Try
                        sql.Close()

                        If idkey9 <> "" Then

                            Try

                                mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & idkey9 & "';"
                                mySqlCommand.CommandType = CommandType.Text
                                mySqlCommand.Connection = sql
                                mySqlCommand.ExecuteNonQuery()

                            Catch ex As Exception

                                MsgBox(ex.ToString)

                            End Try
                            sql.Close()

                            If idkey10 <> "" Then
                                If sql.State = ConnectionState.Closed Then
                                    sql.Open()
                                End If
                                Try

                                    mySqlCommand.CommandText = "DELETE FROM data_device where iddata_device = '" & idkey10 & "';"
                                    mySqlCommand.CommandType = CommandType.Text
                                    mySqlCommand.Connection = sql
                                    mySqlCommand.ExecuteNonQuery()

                                Catch ex As Exception

                                    MsgBox(ex.ToString)

                                End Try
                            End If
                        End If

                    End If
                End If

            End If
        End If

        sql.Close()
    End Sub

End Class
