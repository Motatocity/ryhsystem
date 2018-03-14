Imports MySql.Data.MySqlClient
Public Class frmreg_adddep
    Dim mysql As MySqlConnection = main_reg.mysql
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim respone As Object

    Private Sub frmreg_adddep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If




    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            Try
                mySqlCommand.Parameters.Clear()
                mySqlCommand.CommandText = "insert into department (namedepart, nickdepart) values (@conname,@conadd)"
                mySqlCommand.Connection = mysql


                mySqlCommand.Parameters.AddWithValue("@conname", txtcustomer.Text)
                mySqlCommand.Parameters.AddWithValue("@conadd", txtcustomer_address.Text)
   

                mySqlCommand.ExecuteNonQuery()
                mysql.Close()
                txtcustomer.Text = ""
                txtcustomer_address.Text = ""
    
                MsgBox("Save Complete")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        mysql.Close()


    End Sub
End Class