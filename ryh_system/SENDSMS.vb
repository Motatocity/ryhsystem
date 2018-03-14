Imports System
Imports System.Text
Imports System.Net
Imports System.Web
Imports System.IO
Imports System.Xml
Public Class SENDSMS
    Dim sendername As String = "RAJYINDEE"
    Dim force As String = "premium"
    Dim Scheduled As String = ""
    Dim username As String = "rajyindee"
    Dim password As String = "450481"
    Public Sub SENDSMS(ByVal TELL As String, ByVal msg As String)
        System.Net.ServicePointManager.Expect100Continue = False
        Dim request As WebRequest = WebRequest.Create("http://www.thaibulksms.com/sms_api.php")
        request.Method = "POST"
        Dim postData As String = "username=" + System.Uri.EscapeUriString(username) +
                "&password=" + System.Uri.EscapeUriString(password) +
                "&msisdn=" + System.Uri.EscapeUriString(TELL) +
                "&message=" + System.Uri.EscapeUriString(msg) +
                "&sender=" + System.Uri.EscapeUriString(sendername) +
                "&ScheduledDelivery=" + System.Uri.EscapeUriString(Scheduled) +
                "&force=" + System.Uri.EscapeUriString(force)
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




        'Dim returnData As String = responseFromServer
        'Dim xml As New Xml.XmlDocument()
        'xml.LoadXml(returnData)
        'Dim xnList = xml.SelectNodes("/SMS")
        'Dim count_node As Integer = xnList.Count
        'If count_node > 0 Then
        '    For Each xn In xnList
        '        Dim xnSubList = xml.SelectNodes("/SMS/QUEUE")
        '        Dim countSubNode As Integer = xnSubList.Count
        '        If countSubNode > 0 Then
        '            For Each xnSub In xnSubList
        '                If xnSub("Status").InnerText.ToString() = "1" Then
        '                    Dim msisdnReturn As String = xnSub("Msisdn").InnerText
        '                    Dim useCredit As String = xnSub("UsedCredit").InnerText
        '                    Dim creditRemain As String = xnSub("RemainCredit").InnerText
        '                    MessageBox.Show("Send SMS to " + msisdnReturn + " Success.Use credit " + useCredit + " credit, Credit Remain " + creditRemain + " Credit")
        '                Else
        '                    Dim sub_status_detail As String = xnSub("Detail").InnerText
        '                    MessageBox.Show("Error: " + sub_status_detail)
        '                End If
        '            Next
        '        Else
        '            If xn("Status").InnerText = "0" Then
        '                Dim status_detail As String = xn("Detail").InnerText
        '                MessageBox.Show("Error: " + status_detail)
        '            Else
        '                MessageBox.Show("Error: Can not read data(Not XML Format)")
        '            End If
        '        End If
        '    Next
        'Else
        '    MessageBox.Show("Error: Can not read data(Not XML Format)")
        'End If
    End Sub
End Class
