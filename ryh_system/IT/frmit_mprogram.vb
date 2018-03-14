Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmit_mprogram
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

    Private Sub frmit_mprogram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        mySqlCommand.CommandText = "SELECT * FROM nameform;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridViewX1.Rows.Add({mySqlReader("idform"), mySqlReader("nameform"), mySqlReader("namedescription")})
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()


    End Sub

    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        Try
            idkey = DataGridViewX1.Rows(inbtIndex).Cells(0).Value
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridViewX1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewX1.CellMouseDown

        inbtIndex = e.RowIndex

        'Dim rowClicked As DataGridView.HitTestInfo = DataGridViewX1.HitTest(e.X, e.Y)
        ''Select Right Clicked Row if its not the header row
        'If e.Button = Windows.Forms.MouseButtons.Right AndAlso e.RowIndex > -1 Then
        '    'Clear any currently sellected rows
        '    DataGridViewX1.CurrentCell = DataGridViewX1.Rows(e.RowIndex).Cells(e.ColumnIndex)

        '    ContextMenuStrip2.Show(DataGridViewX1, New Point(e.RowIndex, e.ColumnIndex))

        'End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        sql.Close()
        Dim commandText2 As String
        If check = False Then
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            Try
                mySqlCommand.CommandText = "INSERT INTO nameform (nameform,namedescription) VALUES ('" & TextBoxX4.Text & "','" & TextBoxX3.Text & "');"
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
                commandText2 = "UPDATE nameform SET nameform = '" & TextBoxX4.Text & "' , namedescription = '" & TextBoxX3.Text & "'  WHERE idform = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "'; "

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
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click

        Dim StatusDate As String
        StatusDate = Microsoft.VisualBasic.InputBox("Password")

        If StatusDate.Length = 0 Then
        ElseIf StatusDate.ToString = "2531119" Then
            Dim commandText3 As String


            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            Try

                commandText3 = "Delete FROM nameform  where idform = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "'; "
                mySqlCommand.CommandText = commandText3
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            sql.Close()
        Else
            MsgBox("Password ผิดพลาด")

        End If

        searchdata()

    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click

        check = True
        TextBoxX4.Text = DataGridViewX1.Rows(inbtIndex).Cells(1).Value
        TextBoxX3.Text = DataGridViewX1.Rows(inbtIndex).Cells(2).Value
    End Sub
End Class