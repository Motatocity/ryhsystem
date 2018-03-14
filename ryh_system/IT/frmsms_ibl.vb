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
Public Class frmsms_ibl
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Dim iddoc_no As String
    Dim id_hn As String
    Dim id_an As String
    Dim responseFromServer As String
    Dim mysql As MySqlConnection
    Dim mysql1 As MySqlConnection
    Dim mysql_pass As String
    Dim ip_connect As String
    Dim user_namedb As String

    Dim db_name As String
    Private Sub frmsms_ibl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            MyODBCConnection.Open()
        Catch ex As Exception

        End Try
        mysql = New MySqlConnection
        mysql1 = New MySqlConnection
        'mysql_pass = "stomsite"
        ip_connect = "ryh1"
        '  ip_connect = "119.59.99.151"
        ' user_namedb = "tmcport_shipping"
        db_name = "rajyindee_db"
        '  ip_connect = "127.0.0.1"
        mysql_pass = "software"
        user_namedb = "june"
        mysql.ConnectionString = "server=" + ip_connect + ";user id=" + user_namedb + ";password=" + mysql_pass + ";database=" + db_name + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try


        mysql1.ConnectionString = "server=" + ip_connect + ";user id=" + user_namedb + ";password=" + mysql_pass + ";database=" + db_name + ";Character Set =utf8;"
        Try
            mysql1.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try


        Dim timeofday() As String
        Dim hours() As String
        Dim days_string As String
        Dim timecheck As String
        ListView1.Items.Clear()
        days_string = Date.Now.AddMinutes(-15)
        timeofday = Split(days_string, " ")
        hours = Split(timeofday(1), ":")

        timecheck = hours(0) + hours(1)
        Dim tell() As String
        Dim num As Integer = 0


        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If


        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT DISTINCT IBMHN,IBMRCPDTE,IBMRCPTIM,RDTTEL,RDTMOBTEL FROM IBLMASV5PF JOIN REGDETV5PF ON IBLMASV5PF.IBMHN =  REGDETV5PF.RDTHN WHERE IBMRCPTIM >= '" & timecheck & "' and IBMRCPDTE = '" & Date.Now.Date.ToString("yyyyMMdd") & "'")

        selectCMD.Connection = MyODBCConnection


        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader


            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                With ListView1.Items.Add(dr.GetString(0).Trim)
                    .SubItems.Add(dr.GetString(1).Trim)
                    .SubItems.Add(dr.GetString(2).Trim)

                    num = InStr(1, dr.GetString(3), "-", 1)
                    If num > 0 Then
                        tell = Split(dr.GetString(3).Trim, "-")

                        .SubItems.Add(tell(0) + tell(1))
                        num = 0
                    Else
                        .SubItems.Add(dr.GetString(3).Trim)
                    End If
                    .SubItems.Add(dr.GetString(4).Trim)

                End With


                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyODBCConnection.Close()




    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim timeofday() As String
        Dim hours() As String
        Dim days_string As String
        Dim timecheck As String
        ListView1.Items.Clear()
        days_string = Date.Now.AddMinutes(-15)
        timeofday = Split(days_string, " ")
        hours = Split(timeofday(1), ":")

        timecheck = hours(0) + hours(1)
        Dim tell() As String
        Dim num As Integer = 0


        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If


        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT DISTINCT IBMHN,IBMRCPDTE,IBMRCPTIM,RDTTEL,RDTMOBTEL FROM IBLMASV5PF JOIN REGDETV5PF ON IBLMASV5PF.IBMHN =  REGDETV5PF.RDTHN WHERE IBMRCPTIM >= '" & timecheck & "' and IBMRCPDTE = '" & Date.Now.Date.ToString("yyyyMMdd") & "'")
        selectCMD.Connection = MyODBCConnection


        Try
            'Set the mouse to show a Wait cursor
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader


            'start the Read loop
            While dr.Read

                'Note: the numbers in double quotes represent the column number from the AS400 database
                'Add the data to the list view
                With ListView1.Items.Add(dr.GetString(0).Trim)
                    .SubItems.Add(dr.GetString(1).Trim)
                    .SubItems.Add(dr.GetString(2).Trim)

                    num = InStr(1, dr.GetString(3), "-", 1)
                    If num > 0 Then
                        tell = Split(dr.GetString(3).Trim, "-")

                        .SubItems.Add(tell(0) + tell(1))
                        num = 0
                    Else
                        .SubItems.Add(dr.GetString(3).Trim)
                    End If
                    .SubItems.Add(dr.GetString(4).Trim)

                End With


                'End the loop
            End While
            'Reset the cursor


        Catch ex As Exception

        End Try
        MyODBCConnection.Close()




        message_send()
    End Sub
    Public Sub message_send()


        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        Dim mySqlCommand1 As New MySqlCommand
        Dim mySqlAdaptor1 As New MySqlDataAdapter
        Dim mySqlReader1 As MySqlDataReader

        For i As Integer = 0 To ListView1.Items.Count - 1
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand1.CommandText = "SELECT  COUNT(idreference_service) as count_a  FROM reference_service where OAPHN = '" & ListView1.Items(i).SubItems(0).Text & "' and OAPREGDTE = '" & ListView1.Items(i).SubItems(2).Text & "' ;"
            ' mySqlCommand.CommandText = 
            mySqlCommand1.Connection = mysql
            mySqlAdaptor1.SelectCommand = mySqlCommand1

            Try
                mySqlReader1 = mySqlCommand1.ExecuteReader
                While (mySqlReader1.Read())

                    If CInt(mySqlReader1("count_a")) = 0 Then



                        If ((ListView1.Items(i).SubItems(3).Text).Trim).Length = 10 And ((ListView1.Items(i).SubItems(4).Text).Trim).Length = 10 Then
                            'some code
                            sendmessage(ListView1.Items(i).SubItems(4).Text, ListView1.Items(i).SubItems(3).Text)

                            If mysql1.State = ConnectionState.Closed Then
                                mysql1.Open()
                            End If

                            mySqlCommand.CommandText = "INSERT INTO reference_service (OAPHN,OAPREGDTE,OAPSECTIM,tell1,tell2) VALUES ('" & (ListView1.Items(i).SubItems(0).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(1).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(2).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(3).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(4).Text).Trim.ToString & "');"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = mysql1
                            mySqlCommand.ExecuteNonQuery()
                            mysql1.Close()

                        ElseIf ((ListView1.Items(i).SubItems(3).Text).Trim).Length = 10 And ((ListView1.Items(i).SubItems(4).Text).Trim).Length = 0 Then
                            'some code
                            sendmessage(ListView1.Items(i).SubItems(4).Text, ListView1.Items(i).SubItems(3).Text)

                            If mysql1.State = ConnectionState.Closed Then
                                mysql1.Open()
                            End If

                            mySqlCommand.CommandText = "INSERT INTO reference_service (OAPHN,OAPREGDTE,OAPSECTIM,tell1,tell2) VALUES ('" & (ListView1.Items(i).SubItems(0).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(1).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(2).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(3).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(4).Text).Trim.ToString & "');"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = mysql1
                            mySqlCommand.ExecuteNonQuery()
                            mysql1.Close()

                        ElseIf ((ListView1.Items(i).SubItems(3).Text).Trim).Length = 9 And ((ListView1.Items(i).SubItems(4).Text).Trim).Length = 10 Then

                            sendmessage(ListView1.Items(i).SubItems(4).Text, ListView1.Items(i).SubItems(4).Text)

                            If mysql1.State = ConnectionState.Closed Then
                                mysql1.Open()
                            End If
                            mySqlCommand.CommandText = "INSERT INTO reference_service (OAPHN,OAPREGDTE,OAPSECTIM,tell1,tell2) VALUES ('" & (ListView1.Items(i).SubItems(0).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(1).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(2).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(3).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(4).Text).Trim.ToString & "');"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = mysql1
                            mySqlCommand.ExecuteNonQuery()
                            mysql1.Close()

                        ElseIf ((ListView1.Items(i).SubItems(3).Text).Trim).Length = 0 And ((ListView1.Items(i).SubItems(4).Text).Trim).Length = 10 Then
                            sendmessage(ListView1.Items(i).SubItems(4).Text, ListView1.Items(i).SubItems(4).Text)


                            If mysql1.State = ConnectionState.Closed Then
                                mysql1.Open()
                            End If

                            mySqlCommand.CommandText = "INSERT INTO reference_service (OAPHN,OAPREGDTE,OAPSECTIM,tell1,tell2) VALUES ('" & (ListView1.Items(i).SubItems(0).Text).Trim.ToString & "','" & (ListView1.Items(i).SubItems(1).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(2).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(3).Text).Trim.ToString & "', '" & (ListView1.Items(i).SubItems(4).Text).Trim.ToString & "');"
                            mySqlCommand.CommandType = CommandType.Text
                            mySqlCommand.Connection = mysql1
                            mySqlCommand.ExecuteNonQuery()
                            mysql1.Close()

                        Else

                        End If


                    End If


                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Next
    End Sub
    Private Sub sendmessage(ByRef date_timefull As String, ByRef tell_send As String)
        Try
            System.Net.ServicePointManager.Expect100Continue = False
            Dim request As WebRequest = WebRequest.Create("https://www.sms-delivery.com/api.php?")
            request.Method = "POST"
            'Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอขอบคุณที่ใช้บริการ  ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย โรงพยาบาลราษฎร์ยินดี  Thank you for using our service. Wish you good health.") + "&msgtype=" + System.Uri.EscapeUriString("0")

            'Dim postData As String = "userid=" + System.Uri.EscapeUriString("rajyindee2") + "&password=" + System.Uri.EscapeUriString("1260") + "&sender=" + System.Uri.EscapeUriString("Rajyindee") + "&recipient=" + tell_send + "&message=" + System.Uri.EscapeUriString("ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย รพ.ราษฎร์ยินดี เราอยากให้ท่านสุขภาพแข็งแรง ปรึกษาโปรแกรมตรวจสุขภาพราคาพิเศษ ได้ที่ 074-200250") + "&msgtype=" + System.Uri.EscapeUriString("0")
            'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)

            Dim sms As New SENDSMS

            sms.SENDSMS(tell_send, "ขอให้สุขภาพดีขึ้นภายในเร็ววัน ด้วยความห่วงใย รพ.ราษฎร์ยินดี เราอยากให้ท่านสุขภาพแข็งแรง ปรึกษาโปรแกรมตรวจสุขภาพราคาพิเศษ ได้ที่ 074-200250")

            'request.ContentType = "application/x-www-form-urlencoded"
            'request.ContentLength = byteArray.Length
            'Dim dataStream As Stream = request.GetRequestStream()
            'dataStream.Write(byteArray, 0, byteArray.Length)
            'dataStream.Close()
            'Dim response As WebResponse = request.GetResponse()
            'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            'dataStream = response.GetResponseStream()
            'Dim reader As New StreamReader(dataStream)
            'responseFromServer = reader.ReadToEnd()
            'Console.WriteLine(responseFromServer)
            'reader.Close()
            'dataStream.Close()
            'response.Close()

            'MessageBox.Show(responseFromServer)
        Catch ex As Exception

        End Try

        Dim reponse() As String
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
End Class