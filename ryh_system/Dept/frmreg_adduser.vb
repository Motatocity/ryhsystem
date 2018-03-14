Imports MySql.Data.MySqlClient
Public Class frmreg_adduser
    Dim mysql As MySqlConnection = main_reg.mysql
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim respone As Object

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            Try
                mySqlCommand.Parameters.Clear()
                mySqlCommand.CommandText = "insert into tellmd (namemd, nickname,tellephone) values (@conname,@conadd,@contell)"
                mySqlCommand.Connection = mysql


                mySqlCommand.Parameters.AddWithValue("@conname", txtcustomer.Text)
                mySqlCommand.Parameters.AddWithValue("@conadd", TextBox1.Text)
                mySqlCommand.Parameters.AddWithValue("@contell", txtcustomer_address.Text)


                mySqlCommand.ExecuteNonQuery()
                mysql.Close()
                txtcustomer.Text = ""
                txtcustomer_address.Text = ""
                TextBox1.Text = ""
                MsgBox("Save Complete")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        mysql.Close()


    End Sub

    Private Sub frmreg_adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


    End Sub
End Class