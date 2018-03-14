Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms.DataVisualization.Charting


Imports Microsoft.Office.Interop

Public Class frmdept_kpi
    Dim mysql As MySqlConnection = frmlogin_dept.mysql
    Dim id_user As String
    Dim position_user As String
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim idcompany As String = ""
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim id_hn As String
    Dim export_id As String
    Dim iddepartment As String
    Private trd As Thread
    Dim combo As String
    Dim date_time As String


    Private Sub frmdept_kpi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        Dim format_month_string As String
        Dim date_time1 As String
        Dim date_time2 As String
        Dim for_date As Integer
        Dim for_date1 As Integer
        Dim sum_1 As Integer
        Dim sum_2 As Integer
        Dim total_number As Integer


        Dim date_day As String
        Dim hh As String



        'If RadioButton1.Checked = True Then


        '    Chart1.Series.Clear()
        '    Chart1.Name = "เปรียบเทียบคะแนน"
        '    Chart1.Series.Add("คะแนนประเมิน1")
        '    Chart1.Series.Add("คะแนนประเมิน2")

        '    Chart1.Series("คะแนนประเมิน1").IsValueShownAsLabel = True
        '    Chart1.Series("คะแนนประเมิน2").IsValueShownAsLabel = True

        '    date_day = DateTimePicker1.Value.ToString("dd")
        '    Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        '    for_date = DateTimePicker1.Value.ToString("MM")
        '    If for_date < 10 Then
        '        format_month_string = "0" + for_date.ToString
        '    Else
        '        format_month_string = for_date.ToString
        '    End If
        '    Dim date_time As String = DateTimePicker1.Value.ToString("yyyy") + format_month_string + date_day

        '    For i = 0 To 20
        '        mysql.Close()
        '        If i < 10 Then
        '            date_day = "0" + i.ToString
        '        Else
        '            date_day = i
        '        End If
        '        If mysql.State = ConnectionState.Closed Then
        '            mysql.Open()
        '        End If
        '        mySqlCommand.CommandText = "SELECT SUM(percent_1), SUM(percent_2) , COUNT(idkpi_pramern)  from kpi_pramern where date_day = '" & date_time & "' and  timeofday  > '" & date_day & "01' and timeofday < '" & date_day & "59';"
        '        mySqlCommand.Connection = mysql
        '        mySqlAdaptor.SelectCommand = mySqlCommand
        '        Try
        '            mySqlReader = mySqlCommand.ExecuteReader
        '            While (mySqlReader.Read())


        '                If mySqlReader.GetValue(0) IsNot DBNull.Value Then
        '                    sum_1 = mySqlReader.GetValue(0)
        '                Else
        '                    sum_1 = 0
        '                End If


        '                If mySqlReader.GetValue(1) IsNot DBNull.Value Then
        '                    sum_2 = mySqlReader.GetValue(1)
        '                Else
        '                    sum_2 = 0
        '                End If


        '                If mySqlReader.GetValue(2) IsNot DBNull.Value Then
        '                    total_number = mySqlReader.GetValue(2)
        '                    If total_number = 0 Then
        '                        total_number = 0
        '                    End If
        '                Else
        '                    total_number = 0
        '                End If

        '            End While
        '            mysql.Close()
        '        Catch ex As Exception
        '            MsgBox(ex.ToString)
        '        End Try
        '        mysql.Close()



        '        If total_number = 0 Then
        '            Chart1.Series("คะแนนประเมิน1").Points.AddXY(date_day.ToString + ":00 " + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", 0)

        '        Else
        '            Chart1.Series("คะแนนประเมิน1").Points.AddXY(date_day.ToString + ":00 " + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", CInt(sum_1 / total_number))
        '        End If
        '        If total_number = 0 Then

        '            Chart1.Series("คะแนนประเมิน2").Points.AddXY(date_day.ToString + ":00 " + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", 0)

        '        Else
        '            Chart1.Series("คะแนนประเมิน2").Points.AddXY(date_day.ToString + ":00 " + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", CInt(sum_2 / total_number))

        '        End If



        '    Next


        'If RadioButton2.Checked = True Then
        '    Chart1.Series.Dispose()

        '    Chart1.Series.Clear()
        '    Chart1.Name = "เปรียบเทียบคะแนน"
        '    Chart1.Series.Add("คะแนนประเมิน1")
        '    Chart1.Series.Add("คะแนนประเมิน2")

        '    Chart1.Series("คะแนนประเมิน1").IsValueShownAsLabel = True
        '    Chart1.Series("คะแนนประเมิน2").IsValueShownAsLabel = True



        '    for_date = DateTimePicker1.Value.ToString("dd")
        '    for_date1 = DateTimePicker2.Value.ToString("dd")

        '    For i = for_date To for_date1
        '        If mysql.State = ConnectionState.Closed Then
        '            mysql.Open()
        '        End If
        '        If i < 10 Then
        '            format_month_string = "0" + i.ToString
        '        Else
        '            format_month_string = i
        '        End If

        '        Dim date_time_string As String = DateTimePicker1.Value.Date.ToString("yyyy") + DateTimePicker1.Value.Date.ToString("MM") + format_month_string

        '        mySqlCommand.CommandText = "SELECT SUM(percent_1), SUM(percent_2) , COUNT(idkpi_pramern) FROM `rajyindee_db`.`kpi_pramern` where date_day like '" & date_time_string & "';"
        '        mySqlCommand.Connection = mysql
        '        mySqlAdaptor.SelectCommand = mySqlCommand

        '        Try
        '            mySqlReader = mySqlCommand.ExecuteReader
        '            While (mySqlReader.Read())


        '                If mySqlReader.GetValue(0) IsNot DBNull.Value Then
        '                    sum_1 = mySqlReader.GetValue(0)
        '                Else
        '                    sum_1 = 0
        '                End If


        '                If mySqlReader.GetValue(1) IsNot DBNull.Value Then
        '                    sum_2 = mySqlReader.GetValue(1)
        '                Else
        '                    sum_2 = 0
        '                End If


        '                If mySqlReader.GetValue(2) IsNot DBNull.Value Then
        '                    total_number = mySqlReader.GetValue(2)
        '                    If total_number = 0 Then
        '                        total_number = 0
        '                    End If
        '                Else
        '                    total_number = 0
        '                End If
        '            End While

        '        Catch ex As Exception
        '            MsgBox(ex.ToString)
        '        End Try
        '        mysql.Close()





        '        If total_number = 0 Then
        '            Chart1.Series("คะแนนประเมิน1").Points.AddXY("วันที่" + i.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", 0)
        '        Else
        '            Chart1.Series("คะแนนประเมิน1").Points.AddXY("วันที่" + i.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", CInt(sum_1 / total_number))
        '        End If


        '        If total_number = 0 Then
        '            Chart1.Series("คะแนนประเมิน2").Points.AddXY("วันที่" + i.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", 0)
        '        Else
        '            Chart1.Series("คะแนนประเมิน2").Points.AddXY("วันที่" + i.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", CInt(sum_2 / total_number))
        '        End If





        '    Next



        'ElseIf RadioButton3.Checked = True Then

        Chart1.Series.Dispose()

        Chart1.Series.Clear()
        Chart1.Series.Add("คะแนนประเมิน1")
        Chart1.Series.Add("คะแนนประเมิน2")
        Chart1.Series.Add("จำนวน(คน)")
        Chart1.Series("คะแนนประเมิน1").IsValueShownAsLabel = True
        Chart1.Series("คะแนนประเมิน2").IsValueShownAsLabel = True


        for_date = DateTimePicker1.Value.ToString("MM")
        for_date1 = DateTimePicker2.Value.ToString("MM")
        For value As Integer = for_date To for_date1
            mysql.Close()

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            If value < 10 Then
                format_month_string = "0" + value.ToString
            Else
                format_month_string = value
            End If
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            date_time = DateTimePicker1.Value.ToString("yyyy") + format_month_string


            mySqlCommand.CommandText = "SELECT SUM(percent_1), SUM(percent_2) , COUNT(idkpi_pramern) FROM `rajyindee_db`.`kpi_pramern` where date_day like '" & date_time & "%' and dep ='" & ComboBox1.Text & "' ;"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())


                    If mySqlReader.GetValue(0) IsNot DBNull.Value Then
                        sum_1 = mySqlReader.GetValue(0)
                    Else
                        sum_1 = 0
                    End If
                    If mySqlReader.GetValue(1) IsNot DBNull.Value Then
                        sum_2 = mySqlReader.GetValue(1)
                    Else
                        sum_2 = 0
                    End If


                    If mySqlReader.GetValue(2) IsNot DBNull.Value Then
                        total_number = mySqlReader.GetValue(2)
                        If total_number = 0 Then
                            total_number = 0
                        End If
                    Else
                        total_number = 0
                    End If

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()



            If total_number = 0 Then
                Chart1.Series("คะแนนประเมิน1").Points.AddXY("เดือน" + value.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", 0)
            Else
                Chart1.Series("คะแนนประเมิน1").Points.AddXY("เดือน" + value.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", CInt(sum_1 / total_number))

            End If


            If total_number = 0 Then
                Chart1.Series("คะแนนประเมิน2").Points.AddXY("เดือน" + value.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", 0)
            Else
                Chart1.Series("คะแนนประเมิน2").Points.AddXY("เดือน" + value.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", CInt(sum_2 / total_number))

            End If

        Next



        Dim sqlcommand As String
        Dim connect As ConnecDBRYH = ConnecDBRYH.NewConnection

        sqlcommand = "select date_day as 'DATE',dep as 'DEPT',opinion as 'COMMENT' from kpi_pramern where length(opinion) > 1 and  date_day like '" & date_time & "%' and dep ='" & ComboBox1.Text & "' ;"

        dgvItem.PrimaryGrid.DataSource = connect.GetTable(sqlcommand)
        connect.Dispose()

        'End If
    End Sub

    Private Sub DateTimePicker2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Click

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        combo = ComboBox1.Text
        FolderBrowserDialog1.Description = "Pick Folder to store Excecl files"
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.SelectedPath = "C:\"
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim t = New Thread(New ThreadStart(AddressOf excelReport))
                t.Start()
                CircularProgress1.IsRunning = True
            Catch ex As Exception

            End Try
        End If

 


    End Sub
    Private Sub excelReport()

        Dim pathExcel As String

        Dim count_Row As Integer = 5
        Dim count_Row2 As Integer = 9

        pathExcel = FolderBrowserDialog1.SelectedPath

        Dim excelapp As New Excel.Application
        Dim excelbooks As Excel.Workbook
        Dim excelsheets As Excel.Worksheet
        excelbooks = excelapp.Workbooks.Add
        excelsheets = CType(excelbooks.Worksheets(1), Excel.Worksheet)
        excelsheets.Rows("3:3").rowheight = 20


        With (excelsheets)
            .Range("A1:Q900").Font.Name = "Angsana New"

            .Range("A2:Q900").Font.Size = 14
            Dim CheckIndex As Integer
            Dim i As Integer
            Dim CheckData As Boolean
            CheckData = False

            Dim J As Integer
            For J = 7 To 10
                .Range("A4").Borders(J).Weight = 2 ' xlThin
                .Range("B4").Borders(J).Weight = 2 ' xlThin
                .Range("C4").Borders(J).Weight = 2 ' xlThin
                .Range("D4").Borders(J).Weight = 2 ' xlThin
                .Range("E4").Borders(J).Weight = 2 ' xlThin
                .Range("F4").Borders(J).Weight = 2 ' xlThin
                .Range("G4").Borders(J).Weight = 2 ' xlThin
                .Range("H4").Borders(J).Weight = 2 ' xlThin
                .Range("I4").Borders(J).Weight = 2 ' xlThin

            Next


            With .Range("A4")

                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Font.Bold = True
                .Value = "วันที่"
                .ColumnWidth = 15
            End With
            With .Range("B4")

                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Font.Bold = True
                .Value = "เวลา"
                .ColumnWidth = 12
            End With

            With .Range("C4")


                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Font.Bold = True
                .Value = "คะแนน Percent"
                .Font.Size = 14
                .ColumnWidth = 14
            End With
            With .Range("D4")

                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Font.Bold = True
                .Value = "เพิ่มเติม"
                .Font.Size = 14
                ''.ColumnWidth = 12
            End With
            With .Range("E4")

                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Font.Bold = True
                .Value = "HN"
                .Font.Size = 14
                ''.ColumnWidth = 20
            End With
            With .Range("F4")

                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Font.Bold = True
                .Value = "Comunicate"
                .Font.Size = 14
                ''.ColumnWidth = 20
            End With
            With .Range("G4")

                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Font.Bold = True
                .Value = "Fast"
                .Font.Size = 14
                ''.ColumnWidth = 20
            End With
            With .Range("H4")

                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Font.Bold = True
                .Value = "Quality"
                .Font.Size = 14
                ''.ColumnWidth = 20
            End With

            With .Range("I4")

                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Font.Bold = True
                .Value = "Clean"
                .Font.Size = 14
                ''.ColumnWidth = 20
            End With
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            mySqlCommand.CommandText = "SELECT date_day, timeofday, percent_1,opinion,hn , CASe communicate WHEN '1' THEN 'ควรปรับปรุง' ELSE '' END as 'communicate' ,  CASe fast WHEN '1' THEN 'ควรปรับปรุง' ELSE '' END as 'fast'   ,  CASe quality WHEN '1' THEN 'ควรปรับปรุง' ELSE '' END as 'quality'    ,   CASe clean WHEN '1' THEN 'ควรปรับปรุง' ELSE '' END as 'clean'   from  `rajyindee_db`.`kpi_pramern` where date_day like '" & date_time & "%' and dep ='" & combo & "' ;"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader

                While (mySqlReader.Read())

                    With .Range("A" + count_Row.ToString)
                        .Value = mySqlReader("date_day")
                    End With

                    With .Range("B" + count_Row.ToString)
                        .Value = mySqlReader("timeofday")
                    End With
                    With .Range("C" + count_Row.ToString)
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        .Value = mySqlReader("percent_1")
                    End With
                    With .Range("D" + count_Row.ToString)
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        .Value = mySqlReader("opinion").ToString.Trim
                    End With
                    With .Range("E" + count_Row.ToString)
                        .Value = mySqlReader("hn")
                    End With
                    With .Range("F" + count_Row.ToString)
                        .Value = mySqlReader("communicate")
                    End With
                    With .Range("G" + count_Row.ToString)
                        .Value = mySqlReader("fast")
                    End With
                    With .Range("H" + count_Row.ToString)
                        .Value = mySqlReader("quality")
                    End With
                    With .Range("I" + count_Row.ToString)
                        .Value = mySqlReader("clean")
                    End With
                    count_Row += 1
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


            For i = 5 To count_Row
                .Range("B" & i.ToString() & ":B" & i.ToString()).Borders(7).Weight = 2
                .Range("A" & i.ToString() & ":A" & i.ToString()).Borders(7).Weight = 2
                .Range("C" & i.ToString() & ":C" & i.ToString()).Borders(7).Weight = 2
                .Range("D" & i.ToString() & ":D" & i.ToString()).Borders(7).Weight = 2
                .Range("E" & i.ToString() & ":E" & i.ToString()).Borders(7).Weight = 2
                .Range("F" & i.ToString() & ":F" & i.ToString()).Borders(7).Weight = 2
                .Range("G" & i.ToString() & ":G" & i.ToString()).Borders(7).Weight = 2
                .Range("H" & i.ToString() & ":H" & i.ToString()).Borders(7).Weight = 2
                .Range("I" & i.ToString() & ":I" & i.ToString()).Borders(7).Weight = 2
            Next
            count_Row += 1
            With .Range("A" + count_Row.ToString + ":H" + count_Row.ToString)
                .Borders(8).Weight = 2
            End With

        End With


        excelapp.Windows.Application.ActiveWindow.DisplayGridlines = False
        Try
            excelbooks.SaveAs(pathExcel.ToString + "\" + "Report" + "Dep" + combo + " -" + Date.Now.Day.ToString + "-" + Date.Now.Month.ToString + "-" + Date.Now.Year.ToString + ".xlsx")
            MsgBox("Report Complete", MsgBoxStyle.Information, "Complete Report")
            excelsheets = Nothing
            excelbooks.Close()


            excelapp.Quit()

            excelbooks = Nothing


            excelapp = Nothing
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class