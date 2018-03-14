Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Public Class frmannual
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
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHV4; Userid=JUNE;Password=it5;")
    Private Sub frmannual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MyODBCConnection.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO  WHERE SMSSTFNO = '" & frmsearch_annual.idpersonal & "'")


        selectCMD.Connection = MyODBCConnection

        Try
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader

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


    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim checkTypeannual As String
        Dim textmessage As String = ""
        If RadioButton1.Checked = True Then
            checkTypeannual = "1"
        ElseIf RadioButton2.Checked = True Then
            checkTypeannual = "2"
        ElseIf RadioButton3.Checked = True Then
            checkTypeannual = "3"
        ElseIf RadioButton4.Checked = True Then
            checkTypeannual = "4"
        ElseIf RadioButton5.Checked = True Then
            checkTypeannual = "5"
        ElseIf RadioButton6.Checked = True Then
            checkTypeannual = "6"
        ElseIf RadioButton7.Checked = True Then
            checkTypeannual = "7"
        ElseIf RadioButton8.Checked = True Then
            checkTypeannual = "8"
            textmessage = TextBox1.Text
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader



        Dim size As String
        Dim condition As String
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

            Try

                mySqlCommand.CommandText = "INSERT INTO annaul (idpersonal,startdate,enddate,typeannaul,totalhr,total_cal,typetextannual) VALUES ('" & txt_empCode.Text & "','" & DateTimePicker1.Value.Date.ToString("dd-MM-yyyy") & "', '" & DateTimePicker2.Value.Date.ToString("dd-MM-yyyy") & "', '" & checkTypeannual & "','" & txt_hr.Text & "','" & txt_sum.Text & "','" & textmessage & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
        
                mysql.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
                mysql.Close()
                Exit Sub

            End Try


        End If





    End Sub

    Private Sub SwitchButton1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub txt_hr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_hr.KeyDown


    End Sub

    Private Sub txt_hr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_hr.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If (e.KeyChar.ToString >= "A" And e.KeyChar.ToString <= "Z") Or (e.KeyChar.ToString >= "a" And e.KeyChar.ToString <= "z") Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(Keys.Enter) Then
                    day_cal()
                End If

            End If
        End If
    End Sub
    Public Sub day_cal()
        txt_sum.Text = CInt(txt_hr.Text) * 0.125
    End Sub
End Class