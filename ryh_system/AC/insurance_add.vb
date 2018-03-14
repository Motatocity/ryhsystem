Imports MySql.Data.MySqlClient
Public Class insurance_add
    Dim mysql As MySqlConnection
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        Dim respone As Object

        Dim size As String
        Dim condition As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            Try

                mySqlCommand.CommandText = "INSERT INTO insurance (name_insurance,nameof_insurance,tell_insurance,tell2_insurance) VALUES ('" & txt_comname.Text & "','" & txt_comaddress.Text & "', '" & txt_comtell.Text & "', '" & txt_comfax.Text & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
                MsgBox("ข้อมูลบริษัทประกัน " + txt_comname.Text + " ถูกบันทึกเข้าฐานข้อมูลเรียบร้อยแล้ว")
                clear()
                mysql.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
                mysql.Close()
                Exit Sub

            End Try


        End If

    End Sub

    Private Sub insurance_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

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
        txt_comname.Text = ""
        txt_comaddress.Text = ""
        txt_comtell.Text = ""
        txt_comfax.Text = ""
    End Sub
End Class