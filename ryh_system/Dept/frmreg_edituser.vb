Imports MySql.Data.MySqlClient
Public Class frmreg_edituser
    Dim mysql As MySqlConnection = main_reg.mysql
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim respone As Object
    Dim iddep As String
    Private Sub frmreg_edituser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        mySqlCommand.CommandText = "Select * from tellmd;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("idtellmd"))
                    .SubItems.Add(mySqlReader("namemd"))
                    .SubItems.Add(mySqlReader("nickname"))
                    .SubItems.Add(mySqlReader("tellephone"))
                End With

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
        Try
            Dim commandText2 As String
            commandText2 = "UPDATE tellmd SET namemd = '" & txtcustomer.Text & "' , nickname = '" & TextBox1.Text & "',tellephone= '" & txtcustomer_address.Text & "'  WHERE idtellmd = " & iddep & "; "
            mySqlCommand.CommandText = commandText2
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql

            mySqlCommand.ExecuteNonQuery()
            mysql.Close()
            txtcustomer.Text = ""
            TextBox1.Text = ""
            txtcustomer_address.Text = ""
            MsgBox("แก้ไขข้อเรียบร้อย")
            searchdata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try






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

                mySqlCommand.CommandText = "DELETE FROM tellmd where idtellmd = '" & iddep & "';"
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

    Public Sub searchdata()
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "Select * from tellmd where idtellmd like '%" & TextBoxItem2.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ListView1.Items.Clear()
            While (mySqlReader.Read())
                With ListView1.Items.Add(mySqlReader("idtellmd"))
                    .SubItems.Add(mySqlReader("namemd"))
                    .SubItems.Add(mySqlReader("nickname"))
                    .SubItems.Add(mySqlReader("tellephone"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


    End Sub
    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click


        iddep = ListView1.SelectedItems(0).SubItems(0).Text


        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        mySqlCommand.CommandText = "Select * from tellmd where idtellmd ='" & iddep & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())
                txtcustomer.Text = mySqlReader("namemd")
                txtcustomer_address.Text = mySqlReader("tellephone")
                TextBox1.Text = mySqlReader("nickname")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

    End Sub
End Class