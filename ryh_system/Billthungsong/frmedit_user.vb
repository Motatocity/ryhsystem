Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data

Public Class frmedit_user
     Dim mysql As MySqlConnection = frmmain_thungsong.mysql
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader

    Dim sum As Integer
    Dim sumshare As Integer

    Dim check As Boolean
    Dim intbindex As Integer
    Public Shared idlast As Integer
    Public Shared thaitext As String

    Private Sub frmedit_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        searchDBGridnew()
    End Sub

    Public Sub searchDBGridnew()

        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM thungsongdb where idthungsongdb = '" & frmmain_thungsong.idkey & "' ;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                TextBoxX1.Text = mySqlReader("name2")

                TextBoxX3.Text = mySqlReader("address")
                TextBoxX2.Text = mySqlReader("idcardname")
                TextBoxX6.Text = mySqlReader("tell")
                TextBoxX7.Text = mySqlReader("tell1")

                TextBoxX4.Text = mySqlReader("share")
                TextBoxX5.Text = mySqlReader("price")


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim commandText2 As String


        Try
            commandText2 = "UPDATE thungsongdb SET name2 = '" & TextBoxX1.Text & "' ,  idcardname ='" & TextBoxX2.Text & "',  address ='" & TextBoxX3.Text & "',tell ='" & TextBoxX6.Text & "',tell1 ='" & TextBoxX7.Text & "' WHERE idthungsongDB = " & frmmain_thungsong.idkey & "; "
            mySqlCommand.CommandText = commandText2
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql
            mySqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()


    End Sub

    Private Sub TextBoxX4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxX4.KeyDown

        If e.KeyCode = Keys.Enter Then

            TextBoxX5.Text = CInt(TextBoxX4.Text) * 10

        End If

    End Sub
End Class