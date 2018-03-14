Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class frmadd_user
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim mysql As MySqlConnection = frmmain_thungsong.mysql
    Dim idlast As Integer
    Private Sub frmadd_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Try
            mySqlCommand.Parameters.Clear()
            mySqlCommand.CommandText = "insert into thungsongdb ( name,name2,idcardname, pricedis, price, share, address,tell,tell1,type) values( @name,@name2, @idcardname,@pricedis, @price, @share, @address,@tell,@tell1,'1') ;SELECT LAST_INSERT_ID();"
            mySqlCommand.Connection = mysql
            mySqlCommand.Parameters.AddWithValue("@name", TextBoxX1.Text)
            mySqlCommand.Parameters.AddWithValue("@name2", TextBoxX1.Text)
            mySqlCommand.Parameters.AddWithValue("@idcardname", TextBoxX2.Text)
            mySqlCommand.Parameters.AddWithValue("@pricedis", "")
            mySqlCommand.Parameters.AddWithValue("@price", TextBoxX5.Text)
            mySqlCommand.Parameters.AddWithValue("@share", TextBoxX4.Text)
            mySqlCommand.Parameters.AddWithValue("@address", TextBoxX3.Text)
            mySqlCommand.Parameters.AddWithValue("@tell", TextBoxX6.Text)
            mySqlCommand.Parameters.AddWithValue("@tell1", "")


            idlast = mySqlCommand.ExecuteScalar()





        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Try
            mySqlCommand.Parameters.Clear()
            mySqlCommand.CommandText = "insert into thungsong_round ( thungsong_round1,thungsong_roundbill,thungsong_rounddate, thungsong_roundcheck,thungsong_rundstat,thungsong_rundsum,thungsong_rundshare ) values ( @thungsong_round1,@thungsong_roundbill,@thungsong_rounddate, @thungsong_roundcheck,@thungsong_rundstat,@thungsong_rundsum,@thungsong_rundshare ) ;SELECT LAST_INSERT_ID();"
            mySqlCommand.Connection = mysql
            mySqlCommand.Parameters.AddWithValue("@thungsong_round1", "1")
            mySqlCommand.Parameters.AddWithValue("@thungsong_roundbill", idlast)
            mySqlCommand.Parameters.AddWithValue("@thungsong_rounddate", "")
            mySqlCommand.Parameters.AddWithValue("@thungsong_roundcheck", "0")
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundstat", "0")
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundshare", CInt(TextBoxX4.Text) * 0.1)
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundsum", CInt(TextBoxX5.Text) * 0.1)
            mySqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Try
            mySqlCommand.Parameters.Clear()
            mySqlCommand.CommandText = "insert into thungsong_round ( thungsong_round1,thungsong_roundbill,thungsong_rounddate, thungsong_roundcheck,thungsong_rundstat,thungsong_rundsum,thungsong_rundshare ) values ( @thungsong_round1,@thungsong_roundbill,@thungsong_rounddate, @thungsong_roundcheck,@thungsong_rundstat,@thungsong_rundsum,@thungsong_rundshare ) ;SELECT LAST_INSERT_ID();"
            mySqlCommand.Connection = mysql
            mySqlCommand.Parameters.AddWithValue("@thungsong_round1", "2")
            mySqlCommand.Parameters.AddWithValue("@thungsong_roundbill", idlast)
            mySqlCommand.Parameters.AddWithValue("@thungsong_rounddate", "")
            mySqlCommand.Parameters.AddWithValue("@thungsong_roundcheck", "0")
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundstat", "0")
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundshare", CInt(TextBoxX4.Text) * 0.3)
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundsum", CInt(TextBoxX5.Text) * 0.3)
            mySqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()



        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Try
            mySqlCommand.Parameters.Clear()
            mySqlCommand.CommandText = "insert into thungsong_round ( thungsong_round1,thungsong_roundbill,thungsong_rounddate, thungsong_roundcheck,thungsong_rundstat,thungsong_rundsum,thungsong_rundshare ) values ( @thungsong_round1,@thungsong_roundbill,@thungsong_rounddate, @thungsong_roundcheck,@thungsong_rundstat,@thungsong_rundsum,@thungsong_rundshare ) ;SELECT LAST_INSERT_ID();"
            mySqlCommand.Connection = mysql
            mySqlCommand.Parameters.AddWithValue("@thungsong_round1", "3")
            mySqlCommand.Parameters.AddWithValue("@thungsong_roundbill", idlast)
            mySqlCommand.Parameters.AddWithValue("@thungsong_rounddate", "")
            mySqlCommand.Parameters.AddWithValue("@thungsong_roundcheck", "0")
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundstat", "0")
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundshare", CInt(TextBoxX4.Text) * 0.3)
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundsum", CInt(TextBoxX5.Text) * 0.3)
            mySqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()



        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Try
            mySqlCommand.Parameters.Clear()
            mySqlCommand.CommandText = "insert into thungsong_round ( thungsong_round1,thungsong_roundbill,thungsong_rounddate, thungsong_roundcheck,thungsong_rundstat,thungsong_rundsum,thungsong_rundshare ) values ( @thungsong_round1,@thungsong_roundbill,@thungsong_rounddate, @thungsong_roundcheck,@thungsong_rundstat,@thungsong_rundsum,@thungsong_rundshare ) ;SELECT LAST_INSERT_ID();"
            mySqlCommand.Connection = mysql
            mySqlCommand.Parameters.AddWithValue("@thungsong_round1", "4")
            mySqlCommand.Parameters.AddWithValue("@thungsong_roundbill", idlast)
            mySqlCommand.Parameters.AddWithValue("@thungsong_rounddate", "")
            mySqlCommand.Parameters.AddWithValue("@thungsong_roundcheck", "0")
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundstat", "0")
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundshare", CInt(TextBoxX4.Text) * 0.3)
            mySqlCommand.Parameters.AddWithValue("@thungsong_rundsum", CInt(TextBoxX5.Text) * 0.3)
            mySqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


        MsgBox("บันทึกข้อมูลเสร็จสิ้น")
        Me.Close()
    End Sub

    Private Sub TextBoxX4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX4.KeyDown

        If e.KeyCode = Keys.Enter Then

            TextBoxX5.Text = CInt(TextBoxX4.Text) * 10

        End If


    End Sub
End Class