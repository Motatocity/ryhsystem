
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms.DataVisualization.Charting

Public Class graphKPI
    Dim mysql As MySqlConnection
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


        If RadioButton2.Checked = True Then
            Chart1.Series.Dispose()

            Chart1.Series.Clear()
            Chart1.Name = "เปรียบเทียบคะแนน"
            Chart1.Series.Add("คะแนนประเมิน1")
            Chart1.Series.Add("คะแนนประเมิน2")

            Chart1.Series("คะแนนประเมิน1").IsValueShownAsLabel = True
            Chart1.Series("คะแนนประเมิน2").IsValueShownAsLabel = True
      


            for_date = DateTimePicker1.Value.ToString("dd")
            for_date1 = DateTimePicker2.Value.ToString("dd")

            For i = for_date To for_date1
                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
                If i < 10 Then
                    format_month_string = "0" + i.ToString
                Else
                    format_month_string = i
                End If

                Dim date_time_string As String = DateTimePicker1.Value.Date.ToString("yyyy") + DateTimePicker1.Value.Date.ToString("MM") + format_month_string

                mySqlCommand.CommandText = "SELECT SUM(percent_1), SUM(percent_2) , COUNT(idkpi_pramern) FROM `rajyindee_db`.`kpi_pramern` where date_day like '" & date_time_string & "';"
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
                    Chart1.Series("คะแนนประเมิน1").Points.AddXY("วันที่" + i.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", 0)
                Else
                    Chart1.Series("คะแนนประเมิน1").Points.AddXY("วันที่" + i.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", CInt(sum_1 / total_number))
                End If


                If total_number = 0 Then
                    Chart1.Series("คะแนนประเมิน2").Points.AddXY("วันที่" + i.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", 0)
                Else
                    Chart1.Series("คะแนนประเมิน2").Points.AddXY("วันที่" + i.ToString + Environment.NewLine + "จำนวน" + total_number.ToString + "คน", CInt(sum_2 / total_number))
                End If





            Next






        ElseIf RadioButton3.Checked = True Then

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
                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If

                If value < 10 Then
                    format_month_string = "0" + value.ToString
                Else
                    format_month_string = value
                End If
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
                Dim date_time As String = DateTimePicker1.Value.ToString("yyyy") + format_month_string


                mySqlCommand.CommandText = "SELECT SUM(percent_1), SUM(percent_2) , COUNT(idkpi_pramern) FROM `rajyindee_db`.`kpi_pramern` where date_day like '" & date_time & "%';"
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





        End If


        'mySqlCommand.CommandText = "SELECT DISTINCT * from Employee where dept_id in (SELECT dept_id from Department where dept_name like" + " '%" + TextBox1.Text + "%' )" + " or emp_name like " + "'%" + TextBox1.Text + "%'" + " or emp_surname like " + "'%" + TextBox1.Text + "%'" + " or emp_position like " + "'%" + TextBox1.Text + "%'" + " or emp_level like " + "'%" + TextBox1.Text + "%'" + ";"

    End Sub

    Private Sub graphKPI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        mysql = New MySqlConnection
        ' mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        ipconnect = "ryh1"
        mysqlpass = "software"
        usernamedb = "june"
        dbname = "rajyindee_db"
        mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)
            Me.Close()
        End Try
        Dim LG As Legend = Chart1.Legends(0)
        '~~> Changing the Back Color of the Legend 
        LG.BackColor = Color.Wheat
        '~~> Changing the Fore Color of the Legend
        LG.ForeColor = Color.DarkSlateBlue
        '~~> Setting Font, Font Size and Bold
        LG.Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Bold)
        '~~> Assigning a title for the legend
        LG.Title = "Legend"
        Me.WindowState = FormWindowState.Maximized
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        mySqlCommand.CommandText = "Select * from department;"
        ' mySqlCommand.CommandText = 
        MySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = MySqlCommand

        Try
            mySqlReader = MySqlCommand.ExecuteReader

            While (mySqlReader.Read())
                ComboBox1.Items.Add(mySqlReader("namedepart"))
               
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        mysql.Close()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        mySqlCommand.CommandText = "Select * from department where namedepart ='" & Trim(ComboBox1.Text) & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())
                iddepartment = mySqlReader("iddepartment")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        mysql.Close()


    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim for_date As Integer
        Dim for_date1 As Integer
        Dim format_month_string As String
        Dim sum_1 As Integer
        Chart1.Series.Dispose()

        Chart1.Series.Clear()
        Chart1.ResetAutoValues()

        Chart1.Name = "สถิติผู้ป่วย"
        Chart1.Series.Add("สถิติผู้ป่วย")


        Chart1.Series("สถิติผู้ป่วย").IsValueShownAsLabel = True




        for_date = DateTimeInput1.Value.ToString("dd")
        for_date1 = DateTimeInput2.Value.ToString("dd")

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


            Dim date_time_string As String = DateTimeInput1.Value.Date.ToString("yyyy") + DateTimeInput1.Value.Date.ToString("MM") + format_month_string
            mySqlCommand.CommandText = "SELECT * FROM `rajyindee_db`.`result_patient` where datept = '" & date_time_string & "' and iddep ='" & iddepartment & "';"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())


                    If mySqlReader("number") IsNot DBNull.Value Then
                        sum_1 = CInt(mySqlReader("number"))
                    Else
                        sum_1 = 0
                    End If
                    If sum_1 = 0 Then
                        Chart1.Series("สถิติผู้ป่วย").Points.AddXY("วันที่ " + value.ToString + DateTimeInput1.Value.Date.ToString("-MM-yyyy") + Environment.NewLine, 0)
                    Else
                        Chart1.Series("สถิติผู้ป่วย").Points.AddXY("วันที่ " + value.ToString + DateTimeInput1.Value.Date.ToString("-MM-yyyy") + Environment.NewLine, sum_1)

                    End If



                End While
            Catch ex As Exception

            End Try





        Next
    End Sub

   
    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub
End Class