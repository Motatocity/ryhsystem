Imports MySql.Data.MySqlClient
Public Class tell_company_add
    Dim id_primay As String
    Dim mysql As MySqlConnection
    Dim respone As Object

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader



        Dim size As String
        Dim condition As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            Try

                mySqlCommand.CommandText = "INSERT INTO company_name (com_name,com_add,com_tell,com_fax) VALUES ('" & txt_comname.Text & "','" & txt_comaddress.Text & "', '" & txt_comtell.Text & "', '" & txt_comfax.Text & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
                MsgBox("ข้อมูลบริษัท " + txt_comname.Text + " ถูกบันถึกเข้าฐานข้อมูลเรียบร้อยแล้ว")
                clear()
                mysql.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
                mysql.Close()
                Exit Sub

            End Try


        End If

    End Sub

    Private Sub tell_company_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=telephone;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
    End Sub

    Public Sub clear()
        txt_comaddress.Text = ""
        txt_comfax.Text = ""
        txt_comname.Text = ""
        txt_comtell.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim nextform As tell_company_search = New tell_company_search
        nextform.Show()
        Me.Close()


    End Sub
End Class