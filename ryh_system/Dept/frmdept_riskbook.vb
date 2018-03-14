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
Imports DevComponents.DotNetBar.SuperGrid

Public Class frmdept_riskbook
    Dim mysql As MySqlConnection = frmlogin_dept.mysql
    Dim mysql_ryh As MySqlConnection
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Dim inbtIndex As Integer
    Dim inbtIndex1 As Integer
    Dim cmd_result As Integer
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim check As String = "0"
    Dim checksu As String = "0"
    Dim idmain As String = ""
    Dim idsubmain As String = ""
    Private Sub frmdept_riskbook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
        LOADFILTER()
        AddHandler DataInformation2.GetCellStyle, AddressOf SuperGridControl1GetCellStyle1

        selectdb()

    End Sub
    Public Sub selectdb()
        mysql.Close()
        Try
            mysql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer
        Dim statstr As String
        count = 0
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        'mySqlCommand.CommandText = "SELECT * FROM risk_book where risk_dep ='" & frmlogin_dept.dept & "';"
        'mySqlCommand.Connection = mysql
        'mySqlAdaptor.SelectCommand = mySqlCommand
        Dim sql As String
        sql = "SELECT risk_date AS 'Date',risk_point AS 'เหตุการณ์',risk_pro AS 'สรุปเหตุการณ์',risk_type AS 'ความเสี่ยง',risk_location AS 'หน่วยงานที่เกี่ยวข้อง',risk_volume AS 'รุนแรง', CASE WHEN risk_statcheck ='TRUE' THEN 'ตรวจสอบแล้ว' ELSE 'ยังไม่ได้ตรวจสอบ' END สถานะ ,idrisk_book FROM risk_book Where risk_dep ='" & frmlogin_dept.dept & "' ORDER BY สถานะ DESC , Date ASC ;"
        Dim con As ConnecDBRYH
        con = ConnecDBRYH.NewConnection
        DataInformation2.PrimaryGrid.DataSource = con.GetTable(sql)


        Dim sql1 As String
        sql1 = "SELECT risk_date AS 'Date',risk_point AS 'เหตุการณ์',risk_pro AS 'สรุปเหตุการณ์',risk_type AS 'ความเสี่ยง',risk_location AS 'หน่วยงานที่เกี่ยวข้อง',risk_volume AS 'รุนแรง', CASE WHEN risk_statcheck ='TRUE' THEN 'ตรวจสอบแล้ว' ELSE 'ยังไม่ได้ตรวจสอบ' END สถานะ ,idrisk_book FROM risk_book Where risk_ocrdep ='" & frmlogin_dept.dept & "' and risk_ocr ='True' ORDER BY สถานะ DESC , Date ASC ;"

        con = ConnecDBRYH.NewConnection
        DataInformation1.PrimaryGrid.DataSource = con.GetTable(sql1)
        Dim sql2 As String
        sql2 = "SELECT count(idrisk_book) as idrisk   FROM risk_book Where risk_ocrdep ='" & frmlogin_dept.dept & "' and risk_ocr ='True' AND risk_ocrcheck ='False'; "
        con = ConnecDBRYH.NewConnection



    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        deleteDB()
    End Sub
    Public Sub deleteDB()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim StatusDate As String
        Dim commandText3 As String
        Dim respone As Object
        respone = MsgBox("ต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then


            Try
                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If

                commandText3 = "Delete FROM risk_book  where idrisk_book = '" & inbtIndex & "'; "
                mySqlCommand.CommandText = commandText3
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mysql.Close()
            selectdb()
        End If
        mysql.Close()
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM risk_book  where idrisk_book ='" & inbtIndex & "';"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                'Dim strdate() As String
                'strdate = Split(mySqlReader("risk_date").ToString, "/")
                'If strdate(0).Length = 1 Then
                '    strdate(0) = "0" + strdate(0).ToString
                'End If
                'If strdate(1).Length = 1 Then
                '    strdate(1) = "0" + strdate(1).ToString
                'End If
                Dim strdate As Date
                strdate = mySqlReader("risk_date")
                DateTimePicker2.Value = strdate
                strdate = mySqlReader("risk_date_s")
                DateTimePicker3.Value = strdate
                If mySqlReader("risk_sec") = "ลับ" Then
                    RadioButton1.Checked = True
                ElseIf mySqlReader("risk_sec") = "ไม่ลับ" Then
                    RadioButton2.Checked = True
                Else

                End If
                TextBoxX1.Text = mySqlReader("risk_hn")
                TextBoxX2.Text = mySqlReader("risk_an")
                TextBoxX3.Text = mySqlReader("risk_name")
                ComboBox2.Text = mySqlReader("risk_type")
                ComboBox4.Text = mySqlReader("risk_volume")
                TextBoxX5.Text = mySqlReader("risk_point")
                TextBoxX6.Text = mySqlReader("risk_pro")
                If mySqlReader("risk_ocr") = "True" Then
                    CheckBoxX1.Checked = True

                Else

                End If
                If mySqlReader("risk_time") = "True" Then
                    CheckBoxX2.Checked = True
                End If
                If mySqlReader("risk_repeat") = "True" Then
                    CheckBoxX3.Checked = True
                End If
                If mySqlReader("risk_upd") = "True" Then
                    CheckBoxX4.Checked = True
                End If
                End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        checksu = "1"
    End Sub

    Public Sub LOADFILTER()
        Dim sql As String
        sql = "SELECT dep,description FROM userdep;"
        Dim s1 As New FILTERCLASS(DEPOCR, sql, "CODE,DESCRIPTION", "80,160", "1,1", "1,1")
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click


        If checksu = "0" Then



            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Try

                mySqlCommand.Parameters.Clear()
                mySqlCommand.CommandText = "insert into risk_book (risk_date, risk_group,risk_dep,risk_sec,risk_hn,risk_an,risk_name,risk_date_s,risk_type,risk_volume,risk_point,risk_pro,risk_ocr,risk_time,risk_repeat,risk_upd,risk_stat,ptsafety,prm,clinicrisk,a1,a21,a22,a221,a222,a223,a224,b1,b2,c1,c2,rm2,rm3,identification,slow1,culturerisk,servicerisk,risk_statcheck,risk_ocrdep) values (@risk_date,@risk_group,@risk_dep,@risk_sec,@risk_hn,@risk_an,@risk_name,@risk_date_s,@risk_type,@risk_volume,@risk_point,@risk_pro,@risk_ocr,@risk_time,@risk_repeat,@risk_upd,@risk_stat,@ptsafety,@prm,@clinicrisk,@a1,@a21,@a22,@a221,@a222,@a223,@a224,@b1,@b2,@c1,@c2,@rm2,@rm3,@identification,@slow1,@culturerisk,@servicerisk,@risk_statcheck,@risk_ocrdep)"
                mySqlCommand.Connection = mysql
                Dim myDate As DateTime
                Try
                    myDate = DateTime.Parse(DateTimePicker2.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))

                Catch ex As Exception
                    myDate = DateTime.Now
                End Try
                Dim myDate1 As DateTime
                Try
                    myDate1 = DateTime.Parse(DateTimePicker3.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))

                Catch ex As Exception
                    myDate1 = DateTime.Now
                End Try

                mySqlCommand.Parameters.AddWithValue("@risk_date", DateTimePicker2.Value.Year.ToString + DateTimePicker2.Value.ToString("-MM-dd"))
                mySqlCommand.Parameters.AddWithValue("@risk_group", "")
                If RadioButton1.Checked = True Then
                    mySqlCommand.Parameters.AddWithValue("@risk_sec", "ลับ")
                ElseIf RadioButton2.Checked = True Then
                    mySqlCommand.Parameters.AddWithValue("@risk_sec", "ไม่ลับ")
                End If

                mySqlCommand.Parameters.AddWithValue("@risk_dep", frmlogin_dept.dept)
                mySqlCommand.Parameters.AddWithValue("@risk_hn", TextBoxX1.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_an", TextBoxX2.Text)

                mySqlCommand.Parameters.AddWithValue("@risk_name", TextBoxX3.Text)

                mySqlCommand.Parameters.AddWithValue("@risk_date_s", DateTimePicker3.Value.Year.ToString + DateTimePicker3.Value.ToString("-MM-dd"))
                mySqlCommand.Parameters.AddWithValue("@risk_type", ComboBox2.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_volume", ComboBox4.Text)

                mySqlCommand.Parameters.AddWithValue("@risk_point", TextBoxX5.Text)
                mySqlCommand.Parameters.AddWithValue("@risk_pro", TextBoxX6.Text)
                If CheckBoxX1.Checked = True Then
                    mySqlCommand.Parameters.AddWithValue("@risk_ocr", "True")
                    mySqlCommand.Parameters.AddWithValue("@risk_ocrdep", Convert.ToString(DEPOCR.Tag))

                Else
                    mySqlCommand.Parameters.AddWithValue("@risk_ocrdep", " ")
                    mySqlCommand.Parameters.AddWithValue("@risk_ocr", "False")
                End If

                If CheckBoxX2.Checked = True Then
                    mySqlCommand.Parameters.AddWithValue("@risk_time", "True")
                Else
                    mySqlCommand.Parameters.AddWithValue("@risk_time", "False")
                End If

                If CheckBoxX3.Checked = True Then
                    mySqlCommand.Parameters.AddWithValue("@risk_repeat", "True")
                Else
                    mySqlCommand.Parameters.AddWithValue("@risk_repeat", "False")
                End If

                If CheckBoxX4.Checked = True Then
                    mySqlCommand.Parameters.AddWithValue("@risk_upd", "True")
                Else
                    mySqlCommand.Parameters.AddWithValue("@risk_upd", "False")
                End If

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




                mySqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
                mysql.Close()
            End Try
            MsgBox("บันทึกเสร็จสิ้น")
            selectdb()
        Else

            Dim risksec As String = ""
            Dim riskocr As String = ""
            Dim risktime As String = ""
            Dim riskrepeat As String = ""
            Dim riskupd As String = ""
            Dim riskstatcheck As String = ""
            Dim commandText2 As String
            Dim mySqlCommand As New MySqlCommand
            mysql.Close()
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            Try
                If RadioButton1.Checked = True Then
                    risksec = "ลับ"
                ElseIf RadioButton2.Checked = True Then
                    risksec = "ไม่ลับ"
                End If

                If CheckBoxX1.Checked = True Then
                    riskocr = "True"
                Else
                    riskocr = "False"
                End If

                If CheckBoxX2.Checked = True Then
                    risktime = "True"
                Else
                    risktime = "False"
                End If

                If CheckBoxX3.Checked = True Then
                    riskrepeat = "True"
                Else
                    riskrepeat = "False"
                End If

                If CheckBoxX4.Checked = True Then
                    riskupd = "True"
                Else
                    riskupd = "False"
                End If
                Dim myDate As DateTime
                Try
                    myDate = DateTime.Parse(DateTimePicker2.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))

                Catch ex As Exception
                    myDate = DateTime.Now
                End Try
                Dim myDate1 As DateTime
                Try
                    myDate1 = DateTime.Parse(DateTimePicker3.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))

                Catch ex As Exception
                    myDate1 = DateTime.Now
                End Try


                commandText2 = "UPDATE risk_book SET risk_date = '" & DateTimePicker2.Value.Year.ToString + DateTimePicker2.Value.ToString("-MM-dd") & "',risk_dep ='" & frmlogin_dept.dept & "',risk_sec='" & risksec & "',risk_hn='" & TextBoxX1.Text & "',risk_an ='" & TextBoxX2.Text & "',risk_name= '" & TextBoxX3.Text & "',risk_date_s ='" & DateTimePicker3.Value.Year.ToString + DateTimePicker3.Value.ToString("-MM-dd") & "',risk_type = '" & ComboBox2.Text & "',risk_volume = '" & ComboBox4.Text & "',risk_point ='" & TextBoxX5.Text & "',risk_pro ='" & TextBoxX6.Text & "',risk_ocr ='" & riskocr & "',risk_time ='" & risktime & "',risk_repeat = '" & riskrepeat & "',risk_upd= '" & riskupd & "' , risk_ocrcheck ='" & Convert.ToString(DEPOCR.Tag) & "', risk_ocrdep = '" & riskocr & "' WHERE idrisk_book = '" & inbtIndex & "'; "
                mySqlCommand.CommandText = commandText2

                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
                mysql.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Exit Sub
            End Try

            MsgBox("แก้ไขเรียบร้อย")

        End If
        selectdb()

        cleartext()

    End Sub
    Public Sub cleartext()


        TextBoxX1.Text = ""
        TextBoxX2.Text = ""
        TextBoxX3.Text = ""
        ComboBox2.Text = ""
        ComboBox4.Text = ""

        LabelX3.Text = ""

        TextBoxX5.Text = ""
        TextBoxX6.Text = ""
        checksu = "0"
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim nextform As rpt_risk = New rpt_risk
        nextform.Show()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If Trim(ComboBox4.Text) = "A" Then

            LabelX3.Text = "เหตุการณ์ที่มีโอกาสทำให้เกิดความผิดพลาด"
        ElseIf Trim(ComboBox4.Text) = "B" Then
            LabelX3.Text = "เกิดความผิดพลาดแต่ไม่ถึงตัวผู้ป่วย"

        ElseIf Trim(ComboBox4.Text) = "ต่ำ" Then
            LabelX3.Text = "ยังไม่เกิดผลกระทบกับผู้ป่วย/พนักงาน /ชื่อเสียง/ทรัพย์สิน /ชื่อเสียงองค์กร"
        End If
    End Sub


    Private Sub TextBoxX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                MyODBCConnection.Open()
            Catch ex As Exception
                MsgBox("โปรดใช้เครื่องระบบ ในการกรอก Req")
            End Try
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF   WHERE RMSHNREF = '" & TextBoxX1.Text & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    TextBoxX3.Text = dr.GetString(0).Trim + "  " + dr.GetString(1).Trim

                    'End the loop
                End While
                'Reset the cursor


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If




    End Sub
    Private Sub SuperGridControl1GetCellStyle1(sender As Object, e As GridGetCellStyleEventArgs)
        If e.GridCell.GridColumn.Name.Equals("สถานะ") = True Then
            If CStr(e.GridCell.Value).Equals("ตรวจสอบแล้ว") = True Then
                e.Style.Background.Color1 = Color.BlueViolet
            ElseIf CStr(e.GridCell.Value).Equals("ยังไม่ได้ตรวจสอบ") = True Then
                e.Style.Background.Color1 = Color.Orange
                e.Style.Background.Color2 = Color.DarkOrange
            ElseIf CStr(e.GridCell.Value).Equals("1") = True Then
                e.Style.Background.Color1 = Color.Yellow
                e.Style.Background.Color2 = Color.Gold
            Else
                e.Style.Background.Color1 = Color.Yellow
                e.Style.Background.Color2 = Color.Gold
            End If
        End If
    End Sub
    Private Sub DataInformation_CellClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles DataInformation2.CellClick

        Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
        grid = e.GridPanel.ActiveRow

        inbtIndex = grid.Cells.Item("idrisk_book").Value
    End Sub

    Private Sub DataInformation1_CellClick(sender As Object, e As GridCellClickEventArgs) Handles DataInformation1.CellClick
        Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
        grid = e.GridPanel.ActiveRow
        inbtIndex1 = grid.Cells.Item("idrisk_book").Value
        TextBoxX8.Text = grid.Cells.Item("เหตุการณ์").Value

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        Dim commandText2 As String
        Dim check As String
        If CheckBox1.Checked = True Then
            check = "True"
        Else
            check = "False"
        End If
        mysql.Close()
        Try
            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            commandText2 = "UPDATE risk_book SET risk_ocrcheck='" & check & "'"
            commandText2 += ",risk_editdep = '" & TextBoxX9.Text & "'  WHERE idrisk_book = '" & inbtIndex1 & "'; "
            '" & TextBoxX4.Text & "'  WHERE idrisk_book = '" & inbtIndex & "'; "
            mySqlCommand.CommandText = commandText2
            mySqlCommand.Connection = mysql
            mySqlCommand.ExecuteNonQuery()
            mysql.Close()
            MsgBox("บันทึกข้อมูลเสร็จสิ้น")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TextBoxX8.Text = ""
        TextBoxX9.Text = ""
        CheckBox1.Checked = False
    End Sub


    Private Sub btiRequeseQue_Click_1(sender As Object, e As EventArgs) Handles btiRequeseQue.Click

    End Sub
    Private Sub btnCompQue_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btiRequeseQue_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SuperTabControlPanel1_Click(sender As Object, e As EventArgs) Handles SuperTabControlPanel1.Click

    End Sub

    Private Sub DataInformation1_DataBindingComplete(sender As Object, e As GridDataBindingCompleteEventArgs) Handles DataInformation1.DataBindingComplete
        btiRequeseQue.NotificationMarkText = (DataInformation1.PrimaryGrid.DataSource).rows.count
    End Sub
End Class