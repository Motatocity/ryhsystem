Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.Odbc

Public Class SelectGrpupTraining
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Public Shared idcourse As String
    Dim SelectedEmployee As String
    Public respone As Object
    Public test As String
    Public time_start As String
    Public time_end As String
    '---- Datetime Variable ---
    Dim date_split() As String
    Dim date_split2() As String
    Dim start_date_hh As String
    Dim start_date_mm As String
    Dim end_date_hh As String
    Dim end_date_mm As String
    Dim start_date As Date
    Dim end_date As Date
    Dim select_start_date As String
    Dim select_end_date As String

    Dim MyODBCConnection As New OdbcConnection("dsn=RYHV4; Userid=JUNE;Password=it5;")
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub SelectGrpupTraining_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=testremote;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM course where course_id = '" & SelectTraining.idcourse & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader



            While (mySqlReader.Read())
                TextBox2.Text = mySqlReader("course_name")
                DateTimePicker1.Text = mySqlReader("course_start_date")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()





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

        If ListView1.Items.Count = 1 Then

        End If


    End Sub
    Private Sub RecalculateTime()

        'Dim date1 As TimeSpan
        'Dim sum As String
        Dim dateTime As Date
        Dim dateTime2 As Date
        'Dim datetime_sub As Date
        'Dim hours As String
        Dim full_hours As Integer = 1440
        Dim int_hours As Integer
        Dim int_min As Integer

        'Dim result_hours As Integer
        Dim result_min As String

        Dim tempmin1 As Integer
        Dim tempmin2 As Integer

        Dim tempresultmin As Integer

        'datetime_sub = #12:00:00 AM#

        'Dim test As String
        dateTime = DateTimePicker2.Value
        dateTime2 = DateTimePicker3.Value

        test = dateTime2.Subtract(dateTime).ToString
        'MsgBox(test)

        Dim test1 As String
        test1 = Mid(test, 1, 1)
        ''MsgBox(test)
        '' MsgBox(test1)

        '' MsgBox(time_start)
        ''MsgBox(time_end)

        addZero(dateTime.Hour.ToString, dateTime.Minute.ToString, dateTime2.Hour.ToString, dateTime2.Minute.ToString)




        If test1 = "-" Then

            tempmin1 = CInt(dateTime.Hour.ToString()) * 60 + CInt(dateTime.Minute.ToString())
            tempmin2 = CInt(dateTime2.Hour.ToString()) * 60 + CInt(dateTime2.Minute.ToString())

            tempresultmin = tempmin2 - tempmin1

            tempresultmin = (24 * 60) + tempresultmin

            int_min = tempresultmin Mod 60

            int_hours = tempresultmin \ 60

            result_min = (dateTime.Minute - dateTime2.Minute)



            If (Len(int_hours.ToString) = 1) Then

                ''   MsgBox(txt_totalhr.Text)


                If (Len(int_min.ToString) = 1) Then

                    txt_totalhr.Text = "0" + int_hours.ToString + ".0" + int_min.ToString

                Else
                    txt_totalhr.Text = "0" + int_hours.ToString + "." + int_min.ToString
                End If


            ElseIf (Len(int_min.ToString) = 1) Then
                'addZero(int_min.ToString)
                txt_totalhr.Text = int_hours.ToString + ".0" + int_min.ToString

            Else

                txt_totalhr.Text = int_hours.ToString + "." + int_min.ToString


            End If


        Else

            tempmin1 = CInt(dateTime.Hour.ToString()) * 60 + CInt(dateTime.Minute.ToString())
            tempmin2 = CInt(dateTime2.Hour.ToString()) * 60 + CInt(dateTime2.Minute.ToString())

            tempresultmin = tempmin2 - tempmin1

            ''tempresultmin = tempresultmin + 60

            int_min = tempresultmin Mod 60

            int_hours = tempresultmin \ 60

            result_min = (dateTime2.Minute - dateTime.Minute)

            '' If (dateTime.Minute < dateTime2.Minute) Then

            ''If result_min > 30 Then
            ''int_hours = int_hours - 1
            ''End If
            ''End If

            If (Len(int_hours.ToString) = 1) Then

                ''   MsgBox(txt_totalhr.Text)


                If (Len(int_min.ToString) = 1) Then
                    txt_totalhr.Text = "0" + int_hours.ToString + ".0" + int_min.ToString

                Else
                    txt_totalhr.Text = "0" + int_hours.ToString + "." + int_min.ToString
                End If


            ElseIf (Len(int_min.ToString) = 1) Then
                'addZero(int_min.ToString)
                txt_totalhr.Text = int_hours.ToString + ".0" + int_min.ToString

            Else

                txt_totalhr.Text = int_hours.ToString + "." + int_min.ToString


            End If


            ''txt_totalhr.Text = test

        End If

        ''txt_totalhr.Text = trainingHour
        ''Label18.Text = trainingMin


    End Sub
    Public Sub addZero(ByVal hours1 As String, ByVal min1 As String, ByVal hours2 As String, ByVal min2 As String)

        If (Len(hours1) < 2) Then
            time_start = "0" + hours1
        Else
            time_start = hours1
        End If

        If (Len(min1) < 2) Then
            time_start = time_start + ".0" + min1
        Else
            time_start = time_start + "." + min1
        End If




        If (Len(hours2) < 2) Then
            time_end = "0" + hours2
        Else
            time_end = hours2
        End If
        If (Len(min2) < 2) Then
            time_end = time_end + ".0" + min2
        Else
            time_end = time_end + "." + min2
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        searchEmp()

    End Sub
    Public Sub searchEmp()
        Dim stringCmd As String

        If IsNumeric(TextBox1.Text) Then
            stringCmd = "SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE  SMSDIVCOD <> '001' and SMSDIVCOD <> 'RT' and (SMSDIVCOD like '%" & TextBox1.Text & "%' or SMSHN like '%" & CInt(TextBox1.Text) & "%' or SMSSTFNO like '%" & CInt(TextBox1.Text) & "%' or SMSNAME like '%" & TextBox1.Text & "%')"
        Else
            stringCmd = "SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE  SMSDIVCOD <> '001' and SMSDIVCOD <> 'RT' and (SMSDIVCOD like '%" & TextBox1.Text & "%' or SMSHN like '%" & TextBox1.Text & "%' or SMSSTFNO like '%" & TextBox1.Text & "%' or SMSNAME like '%" & TextBox1.Text & "%')"

        End If



        Dim selectCMD As OdbcCommand = New OdbcCommand(stringCmd)
        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If


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

        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        If ListView1.Items.Count = 1 Then
            SelectedEmployee = ListView1.Items(0).Text
            TextBox1.Text = ""
            Dim CheckIndex As Integer
            Dim i As Integer
            Dim CheckData As Boolean
            CheckData = False
            CheckIndex = ListView3.Items.Count
            For i = 0 To CheckIndex - 1
                If SelectedEmployee <> ListView3.Items(i).Text Then
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



                Try

                    If MyODBCConnection.State = ConnectionState.Closed Then
                        MyODBCConnection.Open()
                    End If
                    Dim selectCMD1 As OdbcCommand = New OdbcCommand("SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE SMSSTFNO = '" & SelectedEmployee & "' ")


                    selectCMD1.Connection = MyODBCConnection

                    Dim dr As OdbcDataReader = selectCMD.ExecuteReader


                    While (dr.Read())



                        With ListView3.Items.Add(dr.GetString(0).Trim)
                            .SubItems.Add(dr.GetString(1).Trim)
                            .SubItems.Add(dr.GetString(2).Trim)
                            .SubItems.Add(dr.GetString(3).Trim + " " + dr.GetString(4).Trim)
                            .SubItems.Add(dr.GetString(5).Trim)
                            .SubItems.Add(txt_totalhr.Text)
                        End With


                    End While
                    dr.Close()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                End Try
            End If
        End If
        TextBox1.Focus()
        Label2.Text = "Total  " + ListView3.Items.Count.ToString + "  คน"


    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchEmp()
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click

        SelectedEmployee = ListView1.SelectedItems(0).Text

    End Sub

    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick

        Dim Listview3_Index As Integer
        Listview3_Index = ListView3.SelectedIndices(0)
        'ListView3.Items.RemoveAt(Listview3_Index)
        'SelectedEmployee = ListView3.SelectedItems(0).Text
        'MsgBox(SelectedEmployee)
        ListView3.Items.RemoveAt(Listview3_Index)


    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick

        Dim CheckIndex As Integer
        Dim i As Integer
        Dim CheckData As Boolean
        CheckData = False
        CheckIndex = ListView3.Items.Count
        For i = 0 To CheckIndex - 1
            If SelectedEmployee <> ListView3.Items(i).Text Then
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



            Try

                If MyODBCConnection.State = ConnectionState.Closed Then
                    MyODBCConnection.Open()
                End If
                Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE SMSSTFNO = '" & SelectedEmployee & "' ")


                selectCMD.Connection = MyODBCConnection

                Dim dr As OdbcDataReader = selectCMD.ExecuteReader


                While (dr.Read())



                    With ListView3.Items.Add(dr.GetString(0).Trim)
                        .SubItems.Add(dr.GetString(1).Trim)
                        .SubItems.Add(dr.GetString(2).Trim)
                        .SubItems.Add(dr.GetString(3).Trim + " " + dr.GetString(4).Trim)
                        .SubItems.Add(dr.GetString(5).Trim)
                        .SubItems.Add(txt_totalhr.Text)
                    End With


                End While
                dr.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        RecalculateTime()
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        RecalculateTime()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim commandtext As String

        If Len(txt_totalhr.Text) = 0 Then
            MsgBox("Please Check field data", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning Message")
            Exit Sub
        End If
        If CheckBox1.Checked = True Then
            For counter1 = 0 To ListView3.Items.Count - 1

                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If

                commandtext = "INSERT INTO training (emp_code,course_id,training_date,time_start,time_end,training_hours) VALUES ('" & ListView3.Items(counter1).SubItems(0).Text & "', '" & SelectTraining.idcourse & "', '" & DateTimePicker1.Value.Year.ToString() & "-" & DateTimePicker1.Value.Month.ToString() & "-" & DateTimePicker1.Value.Day.ToString() & "','" & time_start & "', '" & time_end & "', '" & ListView3.Items(counter1).SubItems(5).Text & "');"
                MySqlCommand.CommandText = commandText
                MySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql

                MySqlCommand.ExecuteNonQuery()
                mysql.Close()
            Next

            Dim cf As New SelectTraining

            cf.MdiParent = Me.MdiParent
            Me.Close()
            cf.Dock = DockStyle.Fill
            cf.Show()


        Else
            MsgBox("Please Check Approve")
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class