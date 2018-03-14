Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmit_muser
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
    Private Sub frmit_muser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
        Catch ex As Exception

        End Try

        searchdept()

        searchdata()
    End Sub
    Public Sub searchdept()
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
                ComboBox2.Items.Add(mySqlReader("nickdepart"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
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

        mySqlCommand.CommandText = "SELECT * FROM userdep;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                DataGridViewX1.Rows.Add({mySqlReader("iduserdep"), mySqlReader("username"), mySqlReader("password"), mySqlReader("name"), mySqlReader("description"), mySqlReader("dep")})
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

    End Sub



    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Trim(ComboBox2.Text) <> "" And TextBoxX2.Text <> "" And TextBoxX3.Text <> "" Then
            sql.Close()
            Dim commandText2 As String
            If check = False Then
                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If
                Try
                    mySqlCommand.CommandText = "INSERT INTO userdep (username,password,description,name,dep) VALUES ('" & TextBoxX3.Text & "','" & TextBoxX2.Text & "','" & TextBoxX1.Text & "','" & TextBoxX4.Text & "','" & ComboBox2.Text & "');"
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
                    commandText2 = "UPDATE userdep SET username = '" & TextBoxX3.Text & "',  password= '" & TextBoxX2.Text & "' ,name = '" & TextBoxX4.Text & "' , description = '" & TextBoxX1.Text & "' ,dep ='" & ComboBox2.Text & "'  WHERE iduserdep = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "'; "

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



    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        inbtIndex = e.RowIndex
        Try
            idkey = DataGridViewX1.Rows(inbtIndex).Cells(0).Value
        Catch ex As Exception

        End Try


    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        check = True
        TextBoxX3.Text = DataGridViewX1.Rows(inbtIndex).Cells(1).Value
        TextBoxX2.Text = DataGridViewX1.Rows(inbtIndex).Cells(2).Value
        TextBoxX1.Text = DataGridViewX1.Rows(inbtIndex).Cells(4).Value
        ComboBox2.Text = DataGridViewX1.Rows(inbtIndex).Cells(5).Value
        TextBoxX4.Text = DataGridViewX1.Rows(inbtIndex).Cells(3).Value
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

                commandText3 = "Delete FROM userdep  where iduserdep = '" & DataGridViewX1.Rows(inbtIndex).Cells(0).Value & "'; "
                mySqlCommand.CommandText = commandText3
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            sql.Close()
        Else
            MsgBox("Password º‘¥æ≈“¥")

        End If

        searchdata()
    End Sub

    Private Sub DataSet1BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class