Imports System
Imports System.Text
Imports System.Net
Imports System.Web
Imports System.IO
Imports System.Xml
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Globalization
Public Class frmit_check
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader



    Dim mySqlCommand1 As New MySqlCommand
    Dim mySqlAdaptor1 As New MySqlDataAdapter
    Dim mySqlReader1 As MySqlDataReader
    Dim mysql As MySqlConnection = frmdevice_main.mysqlconection2

    Dim mysql1 As MySqlConnection = frmdevice_main.mysqlconection1
    Dim postData As String
    Private Sub frmit_check_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
    End Sub

    Public Sub check_message()
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim commandText2 As String
        Dim id As String
        mySqlCommand.CommandText = "Select * from transection_id;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())
                id = mySqlReader("idtransection_id")
                With ListView1.Items.Add(mySqlReader("transection"))
                    .SubItems.Add(mySqlReader("tellnumber"))
                    Try
                        System.Net.ServicePointManager.Expect100Continue = False
                        Dim request As WebRequest = WebRequest.Create("https://sms-delivery.com/delivery.php?")
                        request.Method = "POST"

                        '  Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอขอบคุณที่ใช้บริการ  ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย โรงพยาบาลราษฎร์ยินดี  Thank you for using our service. Wish you good health.") + "&msgtype=" + System.Uri.EscapeUriString("0")

                        postData = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&transid=" & mySqlReader("transection") & ""
                        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
                        request.ContentType = "application/x-www-form-urlencoded"
                        request.ContentLength = byteArray.Length
                        Dim dataStream As Stream = request.GetRequestStream()
                        dataStream.Write(byteArray, 0, byteArray.Length)
                        dataStream.Close()
                        Dim response As WebResponse = request.GetResponse()
                        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
                        dataStream = response.GetResponseStream()
                        Dim reader As New StreamReader(dataStream)
                        Dim responseFromServer As String = reader.ReadToEnd()
                        Console.WriteLine(responseFromServer)
                        .SubItems.Add(responseFromServer)
                        reader.Close()
                        dataStream.Close()
                        response.Close()
                        mysql1.Close()

                        If mysql1.State = ConnectionState.Closed Then
                            mysql1.Open()
                        End If

                        Try
                            commandText2 = "UPDATE rajyindee_db.transection_id SET statdeliver = '" & responseFromServer & "'  WHERE idtransection_id = '" & id & "'; "
                            mySqlCommand1.CommandText = commandText2

                            mySqlCommand1.Connection = mysql1
                            mySqlCommand1.ExecuteNonQuery()

                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try


                    Catch ex As Exception

                    End Try
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        check_message()
    End Sub


End Class