Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data
Imports Microsoft.Office.Core


Public Class frmload_user
    Dim xApp As Excel.Application
    Dim xBook As Excel.Workbook
    Dim xSheet As Excel.Worksheet
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim mysql As MySqlConnection = frmdevice_main.mysqlconection2
    Dim arrayspilt() As String
    Dim idlast As String
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")

    Private Structure ExcelRows

        Dim C1 As String
        Dim C2 As String
        Dim C3 As String
        Dim C4 As String
        Dim C5 As String
        Dim C6 As String
        Dim C7 As String
        Dim C8 As String

    End Structure
    Private ExcelRowlist As List(Of ExcelRows) = New List(Of ExcelRows)
    Private Sub frmload_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ip = "192.168.10.23"
        mysql.Close()

        mysql.ConnectionString = "server=" + "ryh1" + ";Port=3306;user id=" + "june" + ";password=" + "software" + ";database=" + "rajyindee_db" + ";Character Set =utf8"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)


        End Try
    End Sub
    Public Sub getexcel_new()


        Dim count As Integer
        Dim xlApp As New Excel.Application
        Dim xlBook As Excel.Workbook
        Dim xlSheet1 As Excel.Worksheet
        Dim i As Integer
        xlBook = xlApp.Workbooks.Open(TextBox1.Text)
        'xlBook.Application.Visible = False
        xlSheet1 = xlBook.Worksheets(1)

        i = 1
        Do While Not Trim(xlSheet1.Cells.Item(i, 1).Value) = ""
            '*** Rows ***'
            Try

                With ListView1.Items.Add(xlSheet1.Cells.Item(i, 1).value.ToString)

                    If CStr(xlSheet1.Cells.Item(i, 2).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 2).value.ToString)
                    Else
                        .SubItems.Add("0")
                    End If


                    If CStr(xlSheet1.Cells.Item(i, 3).Value) <> "" Then

                        .SubItems.Add(xlSheet1.Cells.Item(i, 3).value.ToString)
                    Else
                        .SubItems.Add("0")
                    End If
                    If CStr(xlSheet1.Cells.Item(i, 4).Value) <> "" Then

                        .SubItems.Add(xlSheet1.Cells.Item(i, 4).value.ToString)
                    Else
                        .SubItems.Add("0")
                    End If



                    If CStr(xlSheet1.Cells.Item(i, 5).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 5).Value.ToString)
                    Else
                        .SubItems.Add("0")
                    End If



                    If CStr(xlSheet1.Cells.Item(i, 6).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 6).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If


                    If CStr(xlSheet1.Cells.Item(i, 7).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 7).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If



                    If CStr(xlSheet1.Cells.Item(i, 8).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 8).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If


                    If CStr(xlSheet1.Cells.Item(i, 9).Value) <> "" Then


                        .SubItems.Add(xlSheet1.Cells.Item(i, 9).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If


                    If CStr(xlSheet1.Cells.Item(i, 10).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 10).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 11).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 11).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 12).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 12).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 13).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 13).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 14).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 14).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 15).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 15).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 16).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 16).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 17).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 17).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 18).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 18).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 19).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 19).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 20).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 20).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 21).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 21).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 22).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 22).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 23).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 23).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 24).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 24).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 25).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 25).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 26).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 26).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 27).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 27).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 28).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 28).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 29).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 29).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 29).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 29).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 30).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 30).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 31).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 31).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 32).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 32).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 33).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 33).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 34).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 34).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 35).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 35).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 36).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 36).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 37).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 37).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 38).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 38).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 39).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 39).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If


                    If CStr(xlSheet1.Cells.Item(i, 40).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 40).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 41).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 41).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 42).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 42).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                    If CStr(xlSheet1.Cells.Item(i, 43).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 43).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If
                    If CStr(xlSheet1.Cells.Item(i, 44).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 44).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If
                    If CStr(xlSheet1.Cells.Item(i, 45).Value) <> "" Then
                        .SubItems.Add(xlSheet1.Cells.Item(i, 45).Value.ToString)
                    Else
                        .SubItems.Add(" ")
                    End If

                End With

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            i = i + 1
        Loop

        Try
            xlBook.Close()
            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)


            xlSheet1 = Nothing
            xlBook = Nothing
            xlApp = Nothing


            Dim proc As System.Diagnostics.Process

            For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                proc.Kill()
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '*** Quit and Clear Object ***'


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        getexcel_new()
        Label5.Text = ListView1.Items.Count

        'For counter1 = 0 To ListView1.Items.Count - 1

        '    MySql.Close()
        '    If MySql.State = ConnectionState.Closed Then
        '        MySql.Open()
        '    End If
        '    Try
        '        mySqlCommand.Parameters.Clear()
        '        mySqlCommand.CommandText = "insert into ctnmain ( CTNSTRING, CTNSIZE, CTNAGENT, CTNSTAT,CTNCONSI,CTNVOYN,CTNSHIPNAME,CTNBOOKING,CTNYARD) values (@ctnstring,@ctnsize,@ctnagent,@ctnstat,@ctnconsi,@ctnvoyn,@ctnshipname,@ctnbooking,@ctnyard);SELECT LAST_INSERT_ID();"
        '        mySqlCommand.Connection = MySql
        '        mySqlCommand.Parameters.AddWithValue("@ctnstring", ListView1.Items(counter1).SubItems(0).Text)

        '        mySqlCommand.ExecuteNonQuery()
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try
        '    MySql.Close()


        'Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Filter = "Excel File  (*.xlsx) | *.xls"
            If (.ShowDialog() = DialogResult.OK) Then
                Dim fi As New System.IO.FileInfo(.FileName)
                TextBox1.Text = .FileName
                arrayspilt = Split(fi.Name, "_")
            End If
        End With

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'transection()
        For counter1 = 0 To ListView1.Items.Count - 1

            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Try
                mySqlCommand.Parameters.Clear()
                mySqlCommand.CommandText = "insert into thungsongdb ( name,name2,idcardname, pricedis, price, share, address,tell,tell1,type) values( @name,@name2, @idcardname,@pricedis, @price, @share, @address,@tell,@tell1,'1') ;SELECT LAST_INSERT_ID();"
                mySqlCommand.Connection = mysql
                mySqlCommand.Parameters.AddWithValue("@name", ListView1.Items(counter1).SubItems(0).Text)
                mySqlCommand.Parameters.AddWithValue("@name2", ListView1.Items(counter1).SubItems(1).Text)
                mySqlCommand.Parameters.AddWithValue("@idcardname", ListView1.Items(counter1).SubItems(2).Text)
                mySqlCommand.Parameters.AddWithValue("@pricedis", ListView1.Items(counter1).SubItems(3).Text)
                mySqlCommand.Parameters.AddWithValue("@price", ListView1.Items(counter1).SubItems(4).Text)
                mySqlCommand.Parameters.AddWithValue("@share", ListView1.Items(counter1).SubItems(5).Text)
                mySqlCommand.Parameters.AddWithValue("@address", ListView1.Items(counter1).SubItems(6).Text)
                mySqlCommand.Parameters.AddWithValue("@tell", ListView1.Items(counter1).SubItems(7).Text)
                mySqlCommand.Parameters.AddWithValue("@tell1", ListView1.Items(counter1).SubItems(8).Text)


                idlast = mySqlCommand.ExecuteScalar()





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
                mySqlCommand.Parameters.AddWithValue("@thungsong_round1", "1")
                mySqlCommand.Parameters.AddWithValue("@thungsong_roundbill", idlast)
                mySqlCommand.Parameters.AddWithValue("@thungsong_rounddate", "")
                mySqlCommand.Parameters.AddWithValue("@thungsong_roundcheck", "0")
                mySqlCommand.Parameters.AddWithValue("@thungsong_rundstat", "0")
                mySqlCommand.Parameters.AddWithValue("@thungsong_rundshare", CInt(ListView1.Items(counter1).SubItems(9).Text) * 0.1)

                mySqlCommand.Parameters.AddWithValue("@thungsong_rundsum", ListView1.Items(counter1).SubItems(9).Text)


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
                mySqlCommand.Parameters.AddWithValue("@thungsong_rundshare", CInt(ListView1.Items(counter1).SubItems(10).Text) * 0.1)

                mySqlCommand.Parameters.AddWithValue("@thungsong_rundsum", ListView1.Items(counter1).SubItems(10).Text)


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
                mySqlCommand.Parameters.AddWithValue("@thungsong_rundshare", CInt(ListView1.Items(counter1).SubItems(11).Text) * 0.1)

                mySqlCommand.Parameters.AddWithValue("@thungsong_rundsum", ListView1.Items(counter1).SubItems(11).Text)


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
                mySqlCommand.Parameters.AddWithValue("@thungsong_rundshare", CInt(ListView1.Items(counter1).SubItems(11).Text) * 0.1)

                mySqlCommand.Parameters.AddWithValue("@thungsong_rundsum", ListView1.Items(counter1).SubItems(11).Text)


                mySqlCommand.ExecuteNonQuery()





            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()
        Next
    End Sub
    Public Sub transection()
        For counter1 = 0 To ListView1.Items.Count - 1

            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            Try
                mySqlCommand.Parameters.Clear()
                mySqlCommand.CommandText = "insert into transection_id (transection,tellnumber ) values( @transection,@tellnumber) ;SELECT LAST_INSERT_ID();"
                mySqlCommand.Connection = mysql
                mySqlCommand.Parameters.AddWithValue("@transection", ListView1.Items(counter1).SubItems(2).Text)
                mySqlCommand.Parameters.AddWithValue("@tellnumber", ListView1.Items(counter1).SubItems(5).Text)


                mySqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim new2 As Class1 = New Class1
        new2.TEST()
   
        ' OpenFile(saveLocation)
    End Sub
    Public Sub TEST()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim connenct As ConnecDBRYH = ConnecDBRYH.NewConnection
        Dim dt As DataTable = New DataTable
        Try
            connenct.BeginTrans()
            dt = connenct.GetTable("Select risk_date,idrisk_book from risk_book")
            For a As Integer = 0 To dt.Rows.Count - 1
                Dim string1 As String = dt.Rows(a)("risk_date")
                Dim datearrr As String() = string1.Split("/")
                ' MsgBox(datearrr(0) + datearrr(1) + datearrr(2))
                connenct.ExecuteNonQuery("UPDATE risk_book SET risk_date_s ='" & (CInt(datearrr(2) - 1086)).ToString + "-" + datearrr(1) + "-" + datearrr(1) & "' ,risk_date = '" & (CInt(datearrr(2) - 1086)).ToString + "-" + datearrr(1) + "-" + datearrr(0) & "'  WHERE idrisk_book ='" & dt.Rows(a)("idrisk_book") & "' ")

            Next
            connenct.CommitTrans()
        Catch ex As Exception
            MsgBox(ex.ToString)
            connenct.RollbackTrans()
            connenct.Dispose()
        Finally
            connenct.Dispose()
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For counter1 = 0 To ListView1.Items.Count - 1
            'Dim sql As String
            'sql = "INSERT INTO  ryh_billdet (idryh_billdet ,ryh_type ,ryh_sum ,ryh_sumshare ,ryh_bank ,ryh_bankid , ryh_banksub ,ryh_date ,ryh_date1)"
            'sql += "values "
            'sql += " ( '" & ListView1.Items(counter1).SubItems(0).Text & "' ,"
            'sql += " '" & ListView1.Items(counter1).SubItems(1).Text & "' , "
            'sql += " '" & ListView1.Items(counter1).SubItems(2).Text & "' , "
            'sql += "'" & ListView1.Items(counter1).SubItems(3).Text & "' ,"
            'sql += "'" & ListView1.Items(counter1).SubItems(4).Text & "' ,"
            'sql += "'" & ListView1.Items(counter1).SubItems(5).Text & "' ,"
            'sql += "'" & ListView1.Items(counter1).SubItems(6).Text & "' ,"

            'sql += "'" & date1.Year.ToString + date1.ToString("-MM-dd") & "' ,"
            'Dim date2 As Date = ListView1.Items(counter1).SubItems(8).Text
            'sql += "'" & date2.Year.ToString + date2.ToString("-MM-dd") & "'  )"
    
            Dim sql1 As String
            Dim sql2 As String
            sql1 = "idrisk_book, "
            sql2 = "'" & ListView1.Items(counter1).SubItems(0).Text & "', "

            sql1 += "risk_date, "
            Dim date1 As Date = ListView1.Items(counter1).SubItems(1).Text
            sql2 += "'" & date1.Year.ToString + date1.ToString("-MM-dd") & "', "


            sql1 += "risk_group,"
            sql2 += "'" & ListView1.Items(counter1).SubItems(2).Text & "', "


            sql1 += "risk_dep, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(3).Text & "', "

       
            sql1 += "risk_sec, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(4).Text & "', "
            sql1 += "risk_hn, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(5).Text & "', "
            sql1 += "risk_an, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(6).Text & "', "
            sql1 += "risk_name, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(7).Text & "', "



            sql1 += "risk_date_s, "
            Dim date2 As Date = ListView1.Items(counter1).SubItems(8).Text
            sql2 += "'" & date2.Year.ToString + date2.ToString("-MM-dd") & "', "

            sql1 += "risk_type, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(9).Text & "', "

            sql1 += "risk_volume, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(10).Text & "', "


            sql1 += "risk_point, "
            sql2 += "'" & MySqlHelper.EscapeString(ListView1.Items(counter1).SubItems(11).Text) & "', "

            sql1 += "risk_pro, "
            sql2 += "'" & MySqlHelper.EscapeString(ListView1.Items(counter1).SubItems(12).Text) & "', "


            sql1 += "risk_ocr, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(13).Text & "', "

            sql1 += "risk_time, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(14).Text & "', "

            sql1 += "risk_repeat, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(15).Text & "', "

            sql1 += "risk_upd, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(16).Text & "', "

            sql1 += "risk_location, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(17).Text & "', "

            sql1 += "risk_stat, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(18).Text & "', "

            sql1 += "risk_, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(19).Text & "', "

            sql1 += "ptsafety, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(20).Text & "', "

            sql1 += "prm, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(21).Text & "', "

            sql1 += "clinicrisk, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(22).Text & "', "

            sql1 += "a1, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(23).Text & "', "

            sql1 += "a21, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(24).Text & "', "

            sql1 += "a22, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(25).Text & "', "

            sql1 += "a221, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(26).Text & "', "

            sql1 += "a222, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(27).Text & "', "

            sql1 += "a223, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(28).Text & "', "

            sql1 += "a224, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(29).Text & "', "

            sql1 += "b1, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(30).Text & "', "

            sql1 += "b2, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(31).Text & "', "

            sql1 += "c1, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(32).Text & "', "

            sql1 += "c2, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(33).Text & "', "

            sql1 += "rm2, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(34).Text & "', "

            sql1 += "rm3, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(35).Text & "', "

            sql1 += "identification, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(36).Text & "', "

            sql1 += "slow1, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(37).Text & "', "

            sql1 += "culturerisk, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(38).Text & "', "

            sql1 += "servicerisk, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(39).Text & "', "

            sql1 += "risk_statcheck, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(40).Text & "', "

            sql1 += "risk_user, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(41).Text & "', "

            sql1 += "risk_editdep, "
            sql2 += "'" & ListView1.Items(counter1).SubItems(42).Text & "', "

            sql1 += "risk_ocrdep ,"
            sql2 += "'" & ListView1.Items(counter1).SubItems(43).Text & "', "
            sql1 += "risk_ocrcheck "
            sql2 += "'" & ListView1.Items(counter1).SubItems(44).Text & "' "

            Dim condb As ConnecDBRYH = ConnecDBRYH.NewConnection
            condb.ExecuteNonQuery("INSERT INTO risk_book ( " & sql1 & " ) VALUES ( " & sql2 & " ) ;")
            condb.Dispose()


            ' sql2 += "" & date1.Year.ToString + date1.ToString("-MM-dd") & "', "

        Next



    End Sub
End Class