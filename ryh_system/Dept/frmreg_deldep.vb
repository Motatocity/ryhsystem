Imports MySql.Data.MySqlClient
Public Class frmreg_deldep
    Dim mysql As MySqlConnection = main_reg.mysql
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim respone As Object
    Dim iddep As String
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If ListView1.SelectedItems.Count Then

            deleteData()


        End If
    End Sub

    Public Sub deleteData()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim respone As Object

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then


            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Try

                mySqlCommand.CommandText = "DELETE FROM department where iddepartment = '" & iddep & "';"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql

                mySqlCommand.ExecuteNonQuery()
                mysql.Close()
                searchdata()

            Catch ex As Exception

                MsgBox(ex.ToString)
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub frmreg_deldep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        mySqlCommand.CommandText = "Select * from department;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("iddepartment"))
                    .SubItems.Add(mySqlReader("namedepart"))
                    .SubItems.Add(mySqlReader("nickdepart"))
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


    End Sub

    Public Sub searchdata()
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "Select * from department where namedepart like '%" & TextBoxItem2.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ListView1.Items.Clear()
            While (mySqlReader.Read())
                With ListView1.Items.Add(mySqlReader("iddepartment"))
                    .SubItems.Add(mySqlReader("namedepart"))
                    .SubItems.Add(mySqlReader("nickdepart"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        searchdata()
    End Sub

    Private Sub TextBoxItem2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxItem2.KeyDown


        If e.KeyCode = Keys.Enter Then
            searchdata()
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click


        iddep = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub
End Class