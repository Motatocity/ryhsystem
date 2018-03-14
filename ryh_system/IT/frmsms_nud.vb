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
Public Class frmsms_nud
    Dim date_time1() As String
    Dim date_time2() As String
    Dim date_one As String
    Dim date_two As String
    Public Sql As MySqlConnection
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Dim mysql_pass As String
    Dim ip_connect As String
    Dim user_namedb As String
    Dim responseFromServer As String
    Dim db_name As String
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")   'Open the connection\
    Private Sub sendmessage(ByRef tell_send As String, ByRef date_send As String, ByRef tell_ad As String)



        Dim sms As New SENDSMS
        sms.SENDSMS(tell_ad, "รพ.ราษฎร์ยินดี แจ้งเตือนนัดหมายวันที่" + date_send + "ด้วยความห่วงใย" + tell_send)
        'Try
        '    System.Net.ServicePointManager.Expect100Continue = False
        '    Dim request As WebRequest = WebRequest.Create("https://www.sms-delivery.com/api.php?")
        '    request.Method = "POST"
        '    'Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอขอบคุณที่ใช้บริการ  ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย โรงพยาบาลราษฎร์ยินดี  Thank you for using our service. Wish you good health.") + "&msgtype=" + System.Uri.EscapeUriString("0")

        '    Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_ad + "&message=" + System.Uri.EscapeUriString() + "&msgtype=" + System.Uri.EscapeUriString("0")
        '    Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        '    request.ContentType = "application/x-www-form-urlencoded"
        '    request.ContentLength = byteArray.Length
        '    Dim dataStream As Stream = request.GetRequestStream()
        '    dataStream.Write(byteArray, 0, byteArray.Length)
        '    dataStream.Close()
        '    Dim response As WebResponse = request.GetResponse()
        '    Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        '    dataStream = response.GetResponseStream()
        '    Dim reader As New StreamReader(dataStream)
        '    responseFromServer = reader.ReadToEnd()
        '    Console.WriteLine(responseFromServer)
        '    reader.Close()
        '    dataStream.Close()
        '    response.Close()

        '    'MessageBox.Show(responseFromServer)
        'Catch ex As Exception

        'End Try

        'Dim reponse() As String
        ' reponse = responseFromServer.Split("_")
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
    Private Sub frmsms_nud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'sendmessage("0887902830")
        'sendmessage("0897336036")
        'sendmessage("0805402145")
        ' sendmessage("0913108714")
        mysql = New MySqlConnection
        'mysql_pass = "stomsite"
        ip_connect = "ryh1"
        '  ip_connect = "119.59.99.151"
        ' user_namedb = "tmcport_shipping"
        db_name = "rajyindee_db"
        '  ip_connect = "127.0.0.1"
        mysql_pass = "software"
        user_namedb = "june"
        ' db_name = "tmc_shpipping"
        mysql.ConnectionString = "server=" + ip_connect + ";user id=" + user_namedb + ";password=" + mysql_pass + ";database=" + db_name + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
      
        End Try
        'select_listview()
        'sendmessage("074200208", "12/10/2556", "1111111")
        'If Date.Now.Hour = 16 Then
        '    ListView1.Items.Clear()
        '    select_listview()
        '    message_send()

        'End If

    End Sub
    Private Sub select_listview()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim date_year As String
        Dim date_month As String
        Dim date_day As String
        Dim date_split As String
        Dim department As String
        Dim date1 As DateTime
        'Dim CultureInfo As Globalization.CultureInfo = New System.Globalization.CultureInfo("en-US")
        'Dim dt As DateTime = DateTime.Now.Today.AddDays(1).ToString("dd-MM-yyyy")
        'MsgBox(dt.ToString())
        date_time1 = Split(Date.Now.Today.AddDays(1).ToString("dd-MM-yyyy"), "-")
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        date_time2 = Split(Date.Now.Today.AddDays(3).ToString("dd-MM-yyyy"), "-")

        Dim count As Integer = 0
        Dim tell() As String
        Dim num As Integer = 0
        ListView1.Items.Clear()
        Dim count_list As Integer = 0
        date_one = date_time1(0).ToString

        date_two = date_time2(0).ToString

        If date_one.Length = 1 Then
            date_one = "0" + date_one
        End If
        If date_two.Length = 1 Then
            date_two = "0" + date_two
        End If
        MyODBCConnection.Close()

        MyODBCConnection.Open()


        '  Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT DAPIOPD,DAPDRCOD,DAPAPPHN,DAPAPPDTE,DAPDRORD1,RMSNAME,RMSSURNAM,RDTTEL FROM REGMASV5PF,DRAPPV5PF,REGDETV5PF WHERE REGMASV5PF.RMSHNREF = DRAPPV5PF.DAPAPPHN and REGDETV5PF.RDTHN = REGMASV5PF.RMSHNREF and DAPIOPD= 'O'  and  DAPAPPDTE >= '" & date_time1(2) + date_time1(1) + date_time1(0) & "' and DAPAPPDTE <= '" & date_time2(2) + date_time2(1) + date_time2(0) & "'")

        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT DAPDRCOD,RTBDIVCOD,DAPAPPHN,DAPAPPDTE,DAPDRORD1,RMSNAME,RMSSURNAM,RDTTEL,RDTMOBTEL FROM REGMASV5PF,DRAPPV5PF,REGDETV5PF,DRMASV5PF,REGTABV5PF WHERE REGMASV5PF.RMSHNREF = DRAPPV5PF.DAPAPPHN and REGDETV5PF.RDTHN = REGMASV5PF.RMSHNREF and DRMASV5PF.DMSDRCOD = DRAPPV5PF.DAPDRCOD  and  DRMASV5PF.DMSDRCATE = REGTABV5PF.RTBTABCOD  and ( DAPAPPDTE = '" & date_time2(2) + date_time2(1) + date_one & "' or DAPAPPDTE = '" & date_time2(2) + date_time2(1) + date_two & "') and RTBTABTYP = '54' and DAPAPPFLG ='A'")

        selectCMD.Connection = MyODBCConnection


        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader
            'start the Read loop
            While dr.Read
                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                If dr.GetString(1).Trim <> "PED" Then


                    With ListView1.Items.Add(count)
                        .SubItems.Add(dr.GetString(0))
                        .SubItems.Add(dr.GetString(1))
                        .SubItems.Add(dr.GetString(2))


                        date_split = dr.GetString(3).Trim
                        'MsgBox(date_split)
                        date_year = date_split.Substring(0, 4)
                        date_month = date_split.Substring(4, 2)
                        date_day = date_split.Substring(6, 2)
                        ' MsgBox(date_day + date_month + date_year)

                        'date_month = date_split.Substring(0, 1)
                        'MsgBox(date_month)
                        'date_day = date_split.Substring(7)
                        .SubItems.Add(date_day + "/" + date_month + "/" + date_year)
                        '.SubItems.Add(dr.GetString(3))
                        ' .SubItems.Add(dr.GetString(4))
                        department = dr.GetString(1).Trim
                        If department = "OP1" Or department = "ESC" Then
                            .SubItems.Add("074200202")
                        ElseIf department = "ER" Then
                            .SubItems.Add("074200201")
                        ElseIf department = "OP3" Then
                            .SubItems.Add("074200267")
                        ElseIf department = "MEC" Then
                            .SubItems.Add("074200230")
                        ElseIf department = "DN" Then
                            .SubItems.Add("074200208")
                        ElseIf department = "OP4" Then
                            .SubItems.Add("074200250")
                        ElseIf department = "OP2" Then
                            .SubItems.Add("074200202")
                        Else
                            .SubItems.Add("")
                        End If


                        .SubItems.Add(dr.GetString(5) + "  " + dr.GetString(6))

                        num = InStr(1, dr.GetString(7), "-", 1)
                        If num > 0 Then
                            tell = Split(dr.GetString(7).Trim, "-")

                            .SubItems.Add(tell(0) + tell(1))
                            num = 0
                        Else
                            .SubItems.Add(dr.GetString(7).Trim)
                        End If
                        .SubItems.Add(dr.GetString(8).Trim)
                        count = count + 1
                    End With
                End If
                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception

        End Try

        MyODBCConnection.Close()


        Label4.Text = ListView1.Items.Count


        For i As Integer = 0 To ListView1.Items.Count - 1

            Try
                If ((ListView1.Items(i).SubItems(7).Text).Trim).Length = 10 And ((ListView1.Items(i).SubItems(8).Text).Trim).Length = 10 Then
                    'some code
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If

                    'mySqlCommand.CommandText = "INSERT INTO message_tell (hn,name,opd,cod,date_send,date_assign,tell1) VALUES ('" & (ListView1.Items(i).SubItems(3).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(6).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(1).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(2).Text).Trim.ToString & "', '" & Date.Now.Date.ToString & "','" & (ListView1.Items(i).SubItems(4).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(7).Text).Trim.ToString & "');"
                    '  mySqlCommand.CommandType = CommandType.Text
                    ' mySqlCommand.Connection = mysql
                    '  mySqlCommand.ExecuteNonQuery()
                    '   mysql.Close()
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If



                ElseIf ((ListView1.Items(i).SubItems(7).Text).Trim).Length = 10 And ((ListView1.Items(i).SubItems(8).Text).Trim).Length = 0 Then
                    'some code
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If


                    mySqlCommand.CommandText = "INSERT INTO message_tell (hn,name,opd,cod,date_send,date_assign,tell2) VALUES ('" & (ListView1.Items(i).SubItems(3).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(6).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(1).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(2).Text).Trim.ToString & "', '" & Date.Now.Date.ToString & "','" & (ListView1.Items(i).SubItems(4).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(7).Text).Trim.ToString & "');"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql
                    mySqlCommand.ExecuteNonQuery()
                    mysql.Close()

                ElseIf ((ListView1.Items(i).SubItems(7).Text).Trim).Length = 9 And ((ListView1.Items(i).SubItems(8).Text).Trim).Length = 10 Then
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If
                    mySqlCommand.CommandText = "INSERT INTO message_tell (hn,name,opd,cod,date_send,date_assign,tell1) VALUES ('" & (ListView1.Items(i).SubItems(3).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(6).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(1).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(2).Text).Trim.ToString & "', '" & Date.Now.Date.ToString & "','" & (ListView1.Items(i).SubItems(4).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(8).Text).Trim.ToString & "');"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql
                    mySqlCommand.ExecuteNonQuery()

                    mysql.Close()

                ElseIf ((ListView1.Items(i).SubItems(7).Text).Trim).Length = 0 And ((ListView1.Items(i).SubItems(8).Text).Trim).Length = 10 Then

                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If
                    mySqlCommand.CommandText = "INSERT INTO message_tell (hn,name,opd,cod,date_send,date_assign,tell1) VALUES ('" & (ListView1.Items(i).SubItems(3).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(6).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(1).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(2).Text).Trim.ToString & "', '" & Date.Now.Date.ToString & "','" & (ListView1.Items(i).SubItems(4).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(8).Text).Trim.ToString & "');"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql
                    mySqlCommand.ExecuteNonQuery()
                    mysql.Close()


                Else
                    If mysql.State = ConnectionState.Closed Then
                        mysql.Open()
                    End If
                    mySqlCommand.CommandText = "INSERT INTO no_tell (hn,name,opd,cod,date_send,date_assign,tell1) VALUES ('" & (ListView1.Items(i).SubItems(3).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(6).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(1).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(2).Text).Trim.ToString & "', '" & Date.Now.Date.ToString & "','" & (ListView1.Items(i).SubItems(4).Text).Trim.ToString & "','0');"
                    mySqlCommand.CommandType = CommandType.Text
                    mySqlCommand.Connection = mysql
                    mySqlCommand.ExecuteNonQuery()
                    mysql.Close()

                End If

                ListView2.Items.Add(count_list)
                count_list = 0
                mysql.Close()

            Catch ex As Exception

            End Try

        Next






    End Sub
    Public Sub check_message(ByRef tell_send As String)
        Try
            System.Net.ServicePointManager.Expect100Continue = False
            Dim request As WebRequest = WebRequest.Create("https://www.sms-delivery.com/api.php?")
            request.Method = "POST"

            '  Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอขอบคุณที่ใช้บริการ  ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย โรงพยาบาลราษฎร์ยินดี  Thank you for using our service. Wish you good health.") + "&msgtype=" + System.Uri.EscapeUriString("0")

            Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย รพ.ราษฎร์ยินดี เราอยากให้ท่านสุขภาพแข็งแรง ปรึกษาโปรแกรมตรวจสุขภาพราคาประหยัด ได้ที่ 074-200250") + "&msgtype=" + System.Uri.EscapeUriString("0")
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
    Public Sub message_send()
        For i As Integer = 0 To ListView1.Items.Count - 1
            Try
                If ((ListView1.Items(i).SubItems(7).Text).Trim).Length = 10 And ((ListView1.Items(i).SubItems(8).Text).Trim).Length = 10 Then
                    'some code
                    sendmessage(ListView1.Items(i).SubItems(5).Text, ListView1.Items(i).SubItems(4).Text, ListView1.Items(i).SubItems(7).Text)

                ElseIf ((ListView1.Items(i).SubItems(7).Text).Trim).Length = 10 And ((ListView1.Items(i).SubItems(8).Text).Trim).Length = 0 Then
                    'some code
                    sendmessage(ListView1.Items(i).SubItems(5).Text, ListView1.Items(i).SubItems(4).Text, ListView1.Items(i).SubItems(7).Text)

                ElseIf ((ListView1.Items(i).SubItems(7).Text).Trim).Length = 9 And ((ListView1.Items(i).SubItems(8).Text).Trim).Length = 10 Then

                    sendmessage(ListView1.Items(i).SubItems(5).Text, ListView1.Items(i).SubItems(4).Text, ListView1.Items(i).SubItems(8).Text)

                ElseIf ((ListView1.Items(i).SubItems(7).Text).Trim).Length = 0 And ((ListView1.Items(i).SubItems(8).Text).Trim).Length = 10 Then
                    sendmessage(ListView1.Items(i).SubItems(5).Text, ListView1.Items(i).SubItems(4).Text, ListView1.Items(i).SubItems(8).Text)

                Else

                End If
            Catch ex As Exception

            End Try




        Next
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Date.Now.Hour = 16 Then
            ListView1.Items.Clear()
            select_listview()
            message_send()
        End If
        Dim nextform As frmsms_nud = New frmsms_nud
        nextform.Show()

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
  
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class