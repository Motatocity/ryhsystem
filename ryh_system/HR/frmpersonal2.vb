Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Public Class frmpersonal2
    Public mysql As MySqlConnection
    Public newcourseid As String
    Public newname3_2_1 As String
    Public newcode3_2_1 As String
    Public checkedApp As Integer
    Public Path_Picture As String
    Dim trainingHour As Integer
    Dim respone As Object

    Dim course_name As String
    Dim trainer As String
    Dim date_train As String
    Dim duration As String
    Dim course_cost As String
    Dim employee_name As String
    Dim employee_code As String

    Dim training_approve As String
    Dim training_type As String

    Public time_start As String
    Public time_end As String
    Dim total_cost_on As Integer = 0
    Dim total_cost_group As Integer = 0
    Dim total_hours_on As Date
    Dim total_hours_group As Date
    Dim start_date As String
    Dim count As Double
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHV4; Userid=JUNE;Password=it5;")
    Private Sub frmpersonal2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MyODBCConnection.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim annualtext As String


        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO  WHERE SMSSTFNO = '" & frmpersonal1.idpersonal & "'")


        selectCMD.Connection = MyODBCConnection

        Try
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader

            ListView2.Items.Clear()
            While (dr.Read())

                txt_empCode.Text = dr.GetString(0).Trim
                txt_empName.Text = dr.GetString(3).Trim + " " + dr.GetString(4).Trim
                txt_department.Text = dr.GetString(5).Trim
                txt_thai_id.Text = dr.GetString(2).Trim
                txt_level.Text = dr.GetDecimal(1)

            End While
            dr.Close()

            'Catch ex As MySqlException
            'MsgBox(ex.Message)
        Catch ex As MySqlException
            MsgBox(ex.ToString)

        End Try
        MyODBCConnection.Close()

        MySql = New MySqlConnection
        MySql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=testremote;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            MySql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try




        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM training join course on training.course_id = course.course_id where emp_code ='" & frmpersonal1.idpersonal & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView2.Items.Clear()

            While (mySqlReader.Read())

                With ListView2.Items.Add(mySqlReader("course_name"))

                    .SubItems.Add(mySqlReader("course_trainer"))
                    .SubItems.Add(mySqlReader("course_start_date"))
                    .SubItems.Add(mySqlReader("time_start") + "-" + mySqlReader("time_end"))
                    .SubItems.Add(mySqlReader("training_hours"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        Dim total_h_on As Integer = 0
        Dim total_h_Group As Integer = 0
        Dim total_m_on As Integer = 0
        Dim total_m_Group As Integer = 0

        Dim mod_m As Integer
        Dim divide_m_group As Integer
        Dim divide_m_on As Integer
        Dim split_hours() As String
        For J = 0 To ListView2.Items.Count - 1
            'MsgBox(ListView1.Items(J).SubItems(4).Text)

            split_hours = Split(ListView2.Items(J).SubItems(4).Text, ".")
            total_h_Group += CInt(split_hours(0))
            total_m_Group += CInt(split_hours(1))
        Next

        mod_m = total_m_Group \ 60
        total_h_Group += mod_m
        divide_m_group = total_m_Group Mod 60
        addZero(total_h_Group, divide_m_group)
        txt_totalHr_On.Text = time_start
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM annaul where idpersonal ='" & frmpersonal1.idpersonal & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()
            While (mySqlReader.Read())

                If mySqlReader("typeannaul") = "1" Then
                    annualtext = "ป่วย"
                ElseIf mySqlReader("typeannaul") = "2" Then
                    annualtext = "ลากิจ"
                ElseIf mySqlReader("typeannaul") = "3" Then
                    annualtext = "ขาด"
                ElseIf mySqlReader("typeannaul") = "4" Then
                    annualtext = "พักร้อน"
                ElseIf mySqlReader("typeannaul") = "5" Then
                    annualtext = "คลอด"
                ElseIf mySqlReader("typeannaul") = "6" Then
                    annualtext = "อบรม"
                ElseIf mySqlReader("typeannaul") = "7" Then
                    annualtext = "ไม่รับค่าจ้าง"
                ElseIf mySqlReader("typeannaul") = "8" Then
                    annualtext = "อื่นๆ"

                End If
                With ListView1.Items.Add(annualtext)

                    .SubItems.Add(mySqlReader("startdate"))
                    .SubItems.Add(mySqlReader("enddate"))
                    .SubItems.Add(mySqlReader("totalhr"))
                    .SubItems.Add(mySqlReader("total_cal"))
                    count += CDbl(mySqlReader("total_cal"))
                End With

            End While
            TextBox1.Text = count.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub DateTimeStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimeStart.ValueChanged

    End Sub

    Public Sub addZero(ByVal hours1 As String, ByVal min1 As String)
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
    End Sub
    Private Sub txt_totalHr_On_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_totalHr_On.TextChanged

    End Sub
End Class