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
Public Class frmreg_sendsms
    Dim mysql As MySqlConnection = main_reg.mysql
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim SelectedEmployee As String
    Dim iddepartment As String
    Dim namedepartment As String
    Dim nicknamedepartment As String
    Dim count As String
    Dim txtsummessage As String = ""



    Private Sub frmreg_sendsms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtsummessage = Date.Now.Date.AddDays(-1).ToString("dd-MM-yyyy") + Environment.NewLine
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

                With ListView2.Items.Add(mySqlReader("idtellmd"))
                    .SubItems.Add(mySqlReader("namemd"))
                    .SubItems.Add(mySqlReader("nickname"))
                    .SubItems.Add(mySqlReader("tellephone"))
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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
    Private Sub ListView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.Click
        SelectedEmployee = ListView2.SelectedItems(0).SubItems(0).Text


    End Sub
    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        tellmd()
    End Sub
    Public Sub tellmd()

        Dim CheckIndex As Integer
        Dim i As Integer
        Dim CheckData As Boolean
        CheckData = False
        CheckIndex = ListView4.Items.Count
        For i = 0 To CheckIndex - 1
            If SelectedEmployee <> ListView4.Items(i).Text Then
                'MsgBox("ไม่ซ้ำ")
                CheckData = True
            Else
                'MsgBox("ซ้ำ")
                CheckData = False
                Exit For
            End If
        Next i



        If CheckData = False And CheckIndex <> 0 Then
            MsgBox("มีรายชื่อนี้อยู่แล้ว", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning Message")
        End If
        If CheckData = True Or CheckIndex = 0 Then

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If



            mySqlCommand.CommandText = "Select * from tellmd where idtellmd ='" & SelectedEmployee & "';"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader

                While (mySqlReader.Read())

                    With ListView4.Items.Add(mySqlReader("idtellmd"))
                        .SubItems.Add(mySqlReader("namemd"))
                        .SubItems.Add(mySqlReader("nickname"))
                        .SubItems.Add(mySqlReader("tellephone"))
                    End With

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()



        End If


    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
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
            ListView2.Items.Clear()
            ListView4.Items.Clear()
            While (mySqlReader.Read())

                With ListView4.Items.Add(mySqlReader("idtellmd"))
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
    Private Sub ListView4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView4.DoubleClick

        Dim Listview3_Index As Integer
        Listview3_Index = ListView4.SelectedIndices(0)
        'ListView3.Items.RemoveAt(Listview3_Index)
        'SelectedEmployee = ListView3.SelectedItems(0).Text
        'MsgBox(SelectedEmployee)
        ListView4.Items.RemoveAt(Listview3_Index)

    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        tellmd()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        addDepartment()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        iddepartment = ListView1.SelectedItems(0).SubItems(0).Text
        namedepartment = ListView1.SelectedItems(0).SubItems(1).Text
        nicknamedepartment = ListView1.SelectedItems(0).SubItems(2).Text

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        addDepartment()
    End Sub


    Public Sub addDepartment()
        If MaskedTextBoxAdv1.Text = "" AndAlso ListView1.SelectedItems.Count > 0 Then
            MsgBox("กรุณากรอกจำนวนคนไข้")
        Else

            Dim CheckIndex As Integer
            Dim i As Integer
            Dim CheckData As Boolean
            CheckData = False
            CheckIndex = ListView3.Items.Count
            For i = 0 To CheckIndex - 1
                If iddepartment <> ListView3.Items(i).Text Then
                    'MsgBox("ไม่ซ้ำ")
                    CheckData = True
                Else
                    'MsgBox("ซ้ำ")
                    CheckData = False
                    Exit For
                End If
            Next i



            If CheckData = False And CheckIndex <> 0 Then
                MsgBox("มีรายชื่อนี้อยู่แล้ว", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning Message")
            End If
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            If CheckData = True Or CheckIndex = 0 Then
                mySqlCommand.CommandText = "Select * from department where iddepartment ='" & iddepartment & "';"
                ' mySqlCommand.CommandText = 
                mySqlCommand.Connection = mysql
                mySqlAdaptor.SelectCommand = mySqlCommand

                Try
                    mySqlReader = mySqlCommand.ExecuteReader

                    While (mySqlReader.Read())

                        With ListView3.Items.Add(mySqlReader("iddepartment"))
                            .SubItems.Add(mySqlReader("namedepart"))
                            .SubItems.Add(mySqlReader("nickdepart"))
                            .SubItems.add(MaskedTextBoxAdv1.Text)
                        End With
                        txtsummessage = txtsummessage + mySqlReader("nickdepart") + " =" + MaskedTextBoxAdv1.Text + Environment.NewLine
                        RichTextBox1.Text = txtsummessage
                        MaskedTextBoxAdv1.Text = ""
                    End While
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                mysql.Close()

            End If






        End If


    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        txtsummessage = RichTextBox1.Text
        For x = 0 To ListView4.Items.Count - 1
            sendmessage(ListView4.Items(x).SubItems(3).Text)

        Next
        insertDB()
        searchnew()
        MsgBox("Send Complete")

    End Sub
    Public Sub insertDB()
        For i As Integer = 0 To ListView3.Items.Count - 1
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.CommandText = "INSERT INTO result_Patient (iddep,number,datept) VALUES ('" & (ListView3.Items(i).SubItems(0).Text).Trim.ToString & "','" & (ListView3.Items(i).SubItems(3).Text).Trim.ToString & "', '" & Date.Now.Date.ToString("yyyyMMdd") & "');"
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql
            mySqlCommand.ExecuteNonQuery()

            mysql.Close()
        Next

    End Sub
    Public Sub sendmessage(ByRef tellsend As String)
        Try
            System.Net.ServicePointManager.Expect100Continue = False
            Dim request As WebRequest = WebRequest.Create("https://www.sms-delivery.com/api.php?")
            request.Method = "POST"

            '  Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอขอบคุณที่ใช้บริการ  ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย โรงพยาบาลราษฎร์ยินดี  Thank you for using our service. Wish you good health.") + "&msgtype=" + System.Uri.EscapeUriString("0")

            Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tellsend + "&message=" + System.Uri.EscapeUriString(RichTextBox1.Text + " :RYH") + "&msgtype=" + System.Uri.EscapeUriString("0")
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
            reader.Close()
            dataStream.Close()
            response.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        searchnew()

    End Sub
    Public Sub searchnew()
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        txtsummessage = ""
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

                With ListView2.Items.Add(mySqlReader("idtellmd"))
                    .SubItems.Add(mySqlReader("namemd"))
                    .SubItems.Add(mySqlReader("nickname"))
                    .SubItems.Add(mySqlReader("tellephone"))
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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

        MaskedTextBoxAdv1.Text = ""
        ListView3.Items.Clear()
        ListView4.Items.Clear()
    End Sub
End Class