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

Imports Microsoft.Office.Interop
Imports System.Threading
Public Class frmsend_msg
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim SelectedEmployee As String
    Dim iddepartment As String
    Dim mysql As MySqlConnection = frmmain_thungsong.mysql1
    Dim namedepartment As String
    Dim nicknamedepartment As String
    Dim count As String
    Public Delegate Sub DelegateSub(ByVal x As Integer)
    Dim txtsummessage As String = ""
    Dim space As String
    Dim responseFromServer As String
    Private Sub frmsend_msg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim num As Integer
        Dim tell() As String

        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        mySqlCommand.CommandText = "Select * from thungsongdb;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())

                With ListView2.Items.Add(mySqlReader("idthungsongDB"))
                    .SubItems.add(mySqlReader("name"))
                    .SubItems.add(mySqlReader("tell"))

                    .SubItems.add(mySqlReader("tell1"))


                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Try

            For x = 0 To ListView1.Items.Count - 1
                space = Trim(ListView1.Items(x).SubItems(2).Text)
                sendmessage()

            Next
            CircularProgress1.IsRunning = True
        Catch ex As Exception
            CircularProgress1.IsRunning = False
        End Try

    End Sub


    Private Sub showResult(ByVal Num As Integer)
        If Label10.InvokeRequired Then
            Dim dlg As New DelegateSub(AddressOf showResult)
            Me.Invoke(dlg, Num)

        Else


        End If
    End Sub
    Public Sub sendmessage()
        Try
            System.Net.ServicePointManager.Expect100Continue = False
            Dim request As WebRequest = WebRequest.Create("https://www.sms-delivery.com/api.php?")
            request.Method = "POST"

            '  Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอขอบคุณที่ใช้บริการ  ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย โรงพยาบาลราษฎร์ยินดี  Thank you for using our service. Wish you good health.") + "&msgtype=" + System.Uri.EscapeUriString("0")

            Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + space + "&message=" + System.Uri.EscapeUriString(RichTextBox1.Text) + "&msgtype=" + System.Uri.EscapeUriString("0")
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
            responseFromServer = reader.ReadToEnd()
            showResult(responseFromServer)
            Console.WriteLine(responseFromServer)
            reader.Close()
            dataStream.Close()
            response.Close()

        Catch ex As Exception

        End Try

        CircularProgress1.IsRunning = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        searchlist()
    End Sub

    Public Sub searchlist()
        ListView2.Items.Clear()
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        mySqlCommand.CommandText = "Select * from thungsongdb where name like '%" & TextBox1.Text & "%' or idcardname like '%" & TextBox1.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())

                With ListView2.Items.Add(mySqlReader("idthungsongDB"))
                    .SubItems.add(mySqlReader("name"))
                    .SubItems.add(mySqlReader("tell"))

                    .SubItems.add(mySqlReader("tell1"))


                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        Label2.Text = "จำนวนรายชื่อ  " + ListView1.Items.Count.ToString

    End Sub
    Public Sub checklistview()
        SelectedEmployee = ListView2.SelectedItems(0).SubItems(0).Text
        TextBox1.Text = ""
        Dim CheckIndex As Integer
        Dim i As Integer
        Dim CheckData As Boolean
        CheckData = False
        CheckIndex = ListView1.Items.Count
        For i = 0 To CheckIndex - 1
            If SelectedEmployee <> ListView1.Items(i).Text Then
                CheckData = True
            Else
                CheckData = False
                Exit For
            End If
        Next i



        If CheckData = False And CheckIndex <> 0 Then
            MsgBox("มีรายชื่อนี้อยู่แล้ว", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning Message")
        End If
        If CheckData = True Or CheckIndex = 0 Then



            'ListView1.Items



            With ListView1.Items.Add(ListView2.SelectedItems(0).SubItems(0).Text)
                .SubItems.Add(ListView2.SelectedItems(0).SubItems(1).Text)
                .SubItems.Add(ListView2.SelectedItems(0).SubItems(2).Text)
                .SubItems.Add(ListView2.SelectedItems(0).SubItems(3).Text)

            End With





        End If


        Label2.Text = "จำนวนรายชื่อ  " + ListView1.Items.Count.ToString

    End Sub

    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListView2.DoubleClick
        checklistview()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            searchlist()


        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress



    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        ListView1.Items.Clear()

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Dim num As Integer
        Dim tell() As String

        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        ListView1.Items.Clear()

        mySqlCommand.CommandText = "Select * from thungsongdb;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("idthungsongDB"))
                    .SubItems.add(mySqlReader("name"))
                    .SubItems.add(mySqlReader("tell"))

                    .SubItems.add(mySqlReader("tell1"))


                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        Label2.Text = "จำนวนรายชื่อ  " + ListView1.Items.Count.ToString
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        checklistview()
    End Sub
End Class