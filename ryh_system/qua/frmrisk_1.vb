Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop.Excel
Public Class frmrisk_1

    Dim mysql As MySqlConnection
    Dim mysql_ryh As MySqlConnection
    Dim inbtIndex As Integer
    Dim cmd_result As Integer
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Private Sub frmrisk_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("th-TH")
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("th-TH")
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("th-TH")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("th-TH")
      
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

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

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



        Try
            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Try

                mySqlCommand.Parameters.Clear()
                mySqlCommand.CommandText = "insert into risk_book (risk_date, risk_group,risk_dep,risk_sec,risk_hn,risk_an,risk_name,risk_date_s,risk_type,risk_volume,risk_point,risk_pro,risk_ocr,risk_time,risk_repeat,risk_upd,risk_location,risk_stat,ptsafety,prm,clinicrisk,a1,a21,a22,a221,a222,a223,a224,b1,b2,c1,c2,rm2,rm3,identification,slow1,culturerisk,servicerisk,risk_statcheck) values (@risk_date,@risk_group,@risk_dep,@risk_sec,@risk_hn,@risk_an,@risk_name,@risk_date_s,@risk_type,@risk_volume,@risk_point,@risk_pro,@risk_ocr,@risk_time,@risk_repeat,@risk_upd,@risk_location,@risk_stat,@ptsafety,@prm,@clinicrisk,@a1,@a21,@a22,@a221,@a222,@a223,@a224,@b1,@b2,@c1,@c2,@rm2,@rm3,@identification,@slow1,@culturerisk,@servicerisk,@risk_statcheck)"
                mySqlCommand.Connection = mysql
                mySqlCommand.Parameters.AddWithValue("@risk_date", DateTimePicker2.Value.ToString("dd/MM/yyyy"))
                mySqlCommand.Parameters.AddWithValue("@risk_group", ComboBox5.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_dep", ComboBox1.Text)
                If RadioButton1.Checked = True Then
                    mySqlCommand.Parameters.AddWithValue("@risk_sec", "ลับ")
                ElseIf RadioButton2.Checked = True Then
                    mySqlCommand.Parameters.AddWithValue("@risk_sec", "ไม่ลับ")
                End If

                mySqlCommand.Parameters.AddWithValue("@risk_hn", TextBoxX1.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_an", TextBoxX2.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_name", TextBoxX3.Text)

                mySqlCommand.Parameters.AddWithValue("@risk_date_s", DateTimePicker1.Value.ToString("dd/MM/yyyy"))

                mySqlCommand.Parameters.AddWithValue("@risk_type", TextBoxX1.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_volume", TextBoxX2.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_point", TextBoxX5.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_pro", TextBoxX6.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_location", TextBoxX4.Text)


                mySqlCommand.Parameters.AddWithValue("@risk_ocr", "False")
                mySqlCommand.Parameters.AddWithValue("@risk_time", "False")
                mySqlCommand.Parameters.AddWithValue("@risk_repeat", "False")
                mySqlCommand.Parameters.AddWithValue("@risk_upd", "False")

                mySqlCommand.Parameters.AddWithValue("@risk_stat", "")

                mySqlCommand.Parameters.AddWithValue("@ptsafety", "")
                mySqlCommand.Parameters.AddWithValue("@prm", "")
                mySqlCommand.Parameters.AddWithValue("@clinicrisk", "")
                mySqlCommand.Parameters.AddWithValue("@a1", "")
                mySqlCommand.Parameters.AddWithValue("@a21", "")
                mySqlCommand.Parameters.AddWithValue("@a22", "")
                mySqlCommand.Parameters.AddWithValue("@a221", "")
                mySqlCommand.Parameters.AddWithValue("@a222", "")
                mySqlCommand.Parameters.AddWithValue("@a223", "")
                mySqlCommand.Parameters.AddWithValue("@a224", "")
                mySqlCommand.Parameters.AddWithValue("@b1", "")
                mySqlCommand.Parameters.AddWithValue("@b2", "")
                mySqlCommand.Parameters.AddWithValue("@c1", "")
                mySqlCommand.Parameters.AddWithValue("@c2", "")
                mySqlCommand.Parameters.AddWithValue("@rm2", "")
                mySqlCommand.Parameters.AddWithValue("@rm3", "")
                mySqlCommand.Parameters.AddWithValue("@identification", "")
                mySqlCommand.Parameters.AddWithValue("@slow1", "")
                mySqlCommand.Parameters.AddWithValue("@culturerisk", "")
                mySqlCommand.Parameters.AddWithValue("@servicerisk", "")


                mySqlCommand.Parameters.AddWithValue("@risk_statcheck", "False")

                cmd_result = CInt(mySqlCommand.ExecuteScalar())





            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try





        Catch ex As Exception
            MsgBox(ex.ToString)
            mysql.Close()
            Exit Sub

        End Try
        clear()
        MsgBox("บันทึกเรียบร้อย")


    End Sub
    Public Sub clear()
        ComboBox5.Text = ""
        ComboBox1.Text = ""
        TextBoxX2.Text = ""
        TextBoxX3.Text = ""
        TextBoxX4.Text = ""
        ComboBox2.Text = ""
        ComboBox4.Text = ""
        TextBoxX5.Text = ""
        TextBoxX6.Text = ""
        CheckBoxX1.Checked = False
        CheckBoxX2.Checked = False
        CheckBoxX3.Checked = False
        CheckBoxX4.Checked = False


    End Sub
End Class