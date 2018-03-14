Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmit_dept
    Dim inbtIndex As Integer
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection2
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim idkey As String
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim check As Boolean = False

    Private Sub frmit_dept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
        Catch ex As Exception

        End Try


        searchdata()
    End Sub
    Public Sub searchdata()
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        DataGridViewX1.Rows.Clear()

        mySqlCommand.CommandText = "SELECT * FROM department;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridViewX1.Rows.Add({mySqlReader("iddepartment"), mySqlReader("namedepart"), mySqlReader("nickdepart")})
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()






    End Sub

    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        inbtIndex = e.RowIndex
        Try
            idkey = DataGridViewX1.Rows(inbtIndex).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        check = True
        TextBoxX4.Text = DataGridViewX1.Rows(inbtIndex).Cells(1).Value
    
        TextBoxX3.Text = DataGridViewX1.Rows(inbtIndex).Cells(2).Value
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Trim(TextBoxX4.Text) <> "" And TextBoxX3.Text <> "" Then
            sql.Close()
            Dim commandText2 As String
            If check = False Then
                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If
                Try
                    mySqlCommand.CommandText = "INSERT INTO department (namedepart,nickdepart) VALUES ('" & TextBoxX4.Text & "','" & TextBoxX3.Text & "');"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                sql.Close()

            ElseIf check = True Then
                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If
                Try
                    commandText2 = "UPDATE department SET namedepart = '" & TextBoxX4.Text & "',  nickdepart= '" & TextBoxX3.Text & "'  WHERE iddepartment = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "'; "

                    mySqlCommand.CommandText = commandText2
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = sql
                    mySqlCommand.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try



            End If

            sql.Close()

            searchdata()



        End If


        check = False


    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class