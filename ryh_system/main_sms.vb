Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports System
Imports System.Text
Imports System.Net
Imports System.Web
Imports System.IO
Imports System.Xml
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class main_sms
    Dim key As String
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHV4; Userid=JUNE;Password=it5;")
    Dim responseFromServer As String
    Private Sub ComboBoxItem2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxItem2.KeyDown
        If e.KeyCode = Keys.Enter Then
            FilterSMS()
        End If


    End Sub

    Private Sub main_sms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 
        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO  WHERE SMSDIVCOD <> 'RT' and SMSDIVCOD <> '001' ")

        selectCMD.Connection = MyODBCConnection

        Try
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader


            ListView1.Items.Clear()
            While (dr.Read())



                With ListView1.Items.Add(dr.GetString(0).Trim)

                    .SubItems.Add(dr.GetString(1).Trim)
                    .SubItems.Add(dr.GetString(2).Trim)
                    .SubItems.Add(dr.GetString(3).Trim + " " + dr.GetString(4).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)
                    .SubItems.Add(dr.GetString(6).Trim)

                End With


            End While
            dr.Close()

            'Catch ex As MySqlException
            'MsgBox(ex.Message)
        Catch ex As MySqlException
            MsgBox(ex.ToString)

        End Try
        MyODBCConnection.Close()







        TextBoxItem2.Text = ListView1.Items.Count.ToString
    End Sub

    Public Sub FilterSMS()
        Dim stringCmd As String
        If checkBoxItem4.Checked = True Then
            stringCmd = "SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE SMSDIVCOD <> '001' and SMSDIVCOD <> 'RT'"
            If ComboBoxItem2.Text <> "" Then
                stringCmd = "SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE SMSDIVCOD like '%" & ComboBoxItem2.Text & "%' and SMSDIVCOD <> '001' and SMSDIVCOD <> 'RT'"
            End If
        ElseIf checkBoxItem5.Checked = True Then
            stringCmd = "SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE   SMSDIVCOD NOT LIKE '9%' and SMSDIVCOD <> '001' and SMSDIVCOD <> 'RT'"
            If ComboBoxItem2.Text <> "" Then
                stringCmd = "SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE  SMSDIVCOD NOT LIKE '9%' and SMSDIVCOD like '%" & ComboBoxItem2.Text & "%' and SMSDIVCOD <> 'RT' "
            End If
        ElseIf checkBoxItem6.Checked = True Then

            stringCmd = "SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE   SMSDIVCOD Like '9%' and SMSDIVCOD <> 'RT' "
            If ComboBoxItem2.Text <> "" Then
                stringCmd = "SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO  WHERE  SMSDIVCOD Like '9%' and SMSDIVCOD like '%" & ComboBoxItem2.Text & "%' and SMSDIVCOD <> 'RT' "
            End If
        End If

            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If



        Dim selectCMD As OdbcCommand = New OdbcCommand(stringCmd)


            selectCMD.Connection = MyODBCConnection

            Try
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader

                ListView1.Items.Clear()
                While (dr.Read())



                    With ListView1.Items.Add(dr.GetString(0).Trim)
                        .SubItems.Add(dr.GetString(1).Trim)
                        .SubItems.Add(dr.GetString(2).Trim)
                        .SubItems.Add(dr.GetString(3).Trim + " " + dr.GetString(4).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)
                    .SubItems.Add(dr.GetString(6).Trim)
                    End With


                End While
                dr.Close()

                'Catch ex As MySqlException
                'MsgBox(ex.Message)
            Catch ex As MySqlException
                MsgBox(ex.ToString)

            End Try
            MyODBCConnection.Close()


            TextBoxItem2.Text = ListView1.Items.Count.ToString
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        For i As Integer = 0 To ListView1.Items.Count - 1

            sendmessage(ListView1.Items(i).SubItems(5).Text, TextBoxItem1.Text)
        Next


    End Sub
    Private Sub sendmessage(ByRef tell_send As String, ByRef message As String)
        Try
            System.Net.ServicePointManager.Expect100Continue = False
            Dim request As WebRequest = WebRequest.Create("https://www.sms-delivery.com/api.php?")
            request.Method = "POST"
            'Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอขอบคุณที่ใช้บริการ  ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย โรงพยาบาลราษฎร์ยินดี  Thank you for using our service. Wish you good health.") + "&msgtype=" + System.Uri.EscapeUriString("0")

            Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("RYHCQI") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString(message) + "&msgtype=" + System.Uri.EscapeUriString("0")
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
            Console.WriteLine(responseFromServer)
            reader.Close()
            dataStream.Close()
            response.Close()

            'MessageBox.Show(responseFromServer)
        Catch ex As Exception

        End Try

        'Dim reponse() As String
        '   reponse = responseFromServer.Split("_")
        'MsgBox(reponse(1))
        '' Dim returnData As String = responseFromServer
        '' Dim xml As New Xml.XmlDocument()
        '' xml.LoadXml(returnData)
        ' Dim xnList = xml.SelectNodes("/SMS")
        ' Dim count_node As Integer = xnList.Count
        ' If count_node > 0 Then
        ' For Each xn In xnList
        ''Dim xnSubList = Xml.SelectNodes("/SMS/QUEUE")
        '  Dim countSubNode As Integer = xnSubList.Count
        ' If countSubNode > 0 Then
        ' For Each xnSub In xnSubList
        '    'If xnSub("Status").InnerText.ToString() = "1" Then
        '    Dim msisdnReturn As String = xnSub("Msisdn").InnerText
        '     Dim useCredit As String = xnSub("UsedCredit").InnerText
        '  Dim creditRemain As String = xnSub("RemainCredit").InnerText
        'MsgBox("Send SMS to " + msisdnReturn + " Success.Use credit " + useCredit + " credit, Credit Remain " + creditRemain + " Credit")
        '  Else
        '  Dim sub_status_detail As String = xnSub("Detail").InnerText
        '  MsgBox("Error: " + sub_status_detail)
        ' End If
        ' Next
        ' Else
        'If xn("Status").InnerText = "0" Then
        'Dim status_detail As String = xn("Detail").InnerText
        'MsgBox("Error: " + status_detail)
        ' Else
        'MsgBox("Error: Can not read data(Not XML Format)")
        ' End If
        ' End If
        'Next
        'Else
        ' MsgBox("Error: Can not read data(Not XML Format)")
        'End If
    End Sub



    Private Sub ButtonItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click

        For i As Integer = 0 To ListView1.Items.Count - 1

            sendmessage(ListView1.Items(i).SubItems(5).Text, TextBoxItem1.Text)
        Next

    End Sub

    Private Sub checkBoxItem4_CheckedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.CheckBoxChangeEventArgs) Handles checkBoxItem4.CheckedChanged
        FilterSMS()
    End Sub

    Private Sub checkBoxItem5_CheckedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.CheckBoxChangeEventArgs) Handles checkBoxItem5.CheckedChanged
        FilterSMS()
    End Sub

    Private Sub checkBoxItem6_CheckedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.CheckBoxChangeEventArgs) Handles checkBoxItem6.CheckedChanged
        FilterSMS()
    End Sub

    Private Sub ComboBoxItem2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl1.Click

    End Sub
End Class