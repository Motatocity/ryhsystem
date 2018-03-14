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
Public Class frmqua_checkrisk
    Dim sql As MySqlConnection = frmmain_qua.mysqlconection
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim idrisk As String
    Dim inbtIndex As Integer
    Dim x As FriendsDate = New FriendsDate
    Public Sub LOADFILTER()
        Dim sql As String
        sql = "SELECT dep,description FROM userdep;"
        Dim s1 As New FILTERCLASS(TextBoxX4, sql, "CODE,DESCRIPTION", "80,160", "1,1", "1,1")
    End Sub
    Private Sub frmqua_checkrisk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        x.TO_EN_US()
        LOADFILTER()
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
        AddHandler DataInformation.GetCellStyle, AddressOf SuperGridControl1GetCellStyle
        'DateTimePicker2.Value = "28/05/2557 00:00"
        sql.Close()
        Try
            sql.Open()
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
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim sqltext As String

        'mySqlCommand.CommandText = "SELECT * FROM risk_book join userdep on risk_book.risk_dep =  userdep.dep order by risk_statcheck ASC ;"
        'mySqlCommand.Connection = sql
        'mySqlAdaptor.SelectCommand = mySqlCommand

        Dim connect As ConnecDBRYH = ConnecDBRYH.NewConnection

        sqltext = "SELECT CAST(risk_date AS CHAR(15)) as 'DATE',risk_group as 'ฝ่าย' ,risk_dep  as 'หน่วย' ,  description  as 'Description' ,risk_point as 'เหตุการณ์' , risk_pro as 'สรุปเหตุการณ์' ,risk_type as 'ความเสี่ยง' , risk_volume as 'รุนแรง' ,case risk_statcheck when 'True' then 'ตรวจสอบแล้ว'  ELSE 'ยังไม่ได้ตรวจสอบ' end as 'สถานะ' , idrisk_book  FROM risk_book join userdep on risk_book.risk_dep =  userdep.dep order by risk_statcheck ASC"
        DataInformation.PrimaryGrid.DataSource = connect.GetTable(sqltext)
        connect.Dispose()
        'Try
        '    mySqlReader = mySqlCommand.ExecuteReader

        '    DataGridViewX1.Rows.Clear()


        '    While (mySqlReader.Read())
        '        If mySqlReader("risk_statcheck") IsNot DBNull.Value Then
        '            If mySqlReader("risk_statcheck") = "True" Then
        '                statstr = "ตรวจสอบแล้ว"
        '            Else
        '                statstr = "ไม่ได้ตรวจสอบ"
        '            End If
        '        Else

        '            statstr = "ไม่ได้ตรวจสอบ"
        '        End If

        '        DataGridViewX1.Rows.Add({mySqlReader("risk_date"), mySqlReader("risk_group"), mySqlReader("risk_dep"), mySqlReader("description"), mySqlReader("risk_point"), mySqlReader("risk_pro"), mySqlReader("risk_type"), mySqlReader("risk_volume"), statstr, mySqlReader("risk_statcheck"), mySqlReader("idrisk_book")})
        '    End While

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try





        'sql.Close()



        'For i As Integer = 0 To DataGridViewX1.Rows.Count - 1

        '    If DataGridViewX1.Rows(i).Cells(9).Value = "True" Then

        '        'DGV1.Rows(i).Cells(3).Style.ForeColor = Color.Red

        '        'DGV1.DefaultCellStyle.SelectionForeColor = Color.Red

        '        DataGridViewX1.Rows(i).Cells(8).Style.BackColor = Color.DeepSkyBlue
        '    ElseIf DataGridViewX1.Rows(i).Cells(9).Value = "False" Then

        '        DataGridViewX1.Rows(i).Cells(8).Style.BackColor = Color.DarkOrange

        '    End If

        'Next




    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Try
            Dim myDate As DateTime

            Try
                myDate = DateTime.Parse(DateTimePicker2.Text)

            Catch ex As Exception
                myDate = DateTime.Now

            End Try
          

            Dim myDate1 As DateTime
            Try
                myDate1 = DateTime.Parse(DateTimePicker3.Text)

            Catch ex As Exception
                myDate1 = DateTime.Now
            End Try



            mySqlCommand.Parameters.Clear()
            mySqlCommand.CommandText = "insert into risk_book (risk_date, risk_group,risk_dep,risk_sec,risk_hn,risk_an,risk_name,risk_date_s,risk_type,risk_volume,risk_point,risk_pro,risk_ocr,risk_time,risk_repeat,risk_upd,risk_location,risk_stat,ptsafety,prm,clinicrisk,a1,a21,a22,a221,a222,a223,a224,b1,b2,c1,c2,rm2,rm3,identification,slow1,culturerisk,servicerisk,risk_statcheck) values (@risk_date,@risk_group,@risk_dep,@risk_sec,@risk_hn,@risk_an,@risk_name,@risk_date_s,@risk_type,@risk_volume,@risk_point,@risk_pro,@risk_ocr,@risk_time,@risk_repeat,@risk_upd,@risk_location,@risk_stat,@ptsafety,@prm,@clinicrisk,@a1,@a21,@a22,@a221,@a222,@a223,@a224,@b1,@b2,@c1,@c2,@rm2,@rm3,@identification,@slow1,@culturerisk,@servicerisk,@risk_statcheck)"
            mySqlCommand.Connection = sql

            mySqlCommand.Parameters.AddWithValue("@risk_date", DateTimePicker2.Value.Year.ToString & DateTimePicker2.Value.ToString("-MM-dd"))
            mySqlCommand.Parameters.AddWithValue("@risk_group", ComboBox5.Text)
            If RadioButton1.Checked = True Then
                mySqlCommand.Parameters.AddWithValue("@risk_sec", "ลับ")
            ElseIf RadioButton2.Checked = True Then
                mySqlCommand.Parameters.AddWithValue("@risk_sec", "ไม่ลับ")
            End If

            mySqlCommand.Parameters.AddWithValue("@risk_dep", ComboBox1.Text)
            mySqlCommand.Parameters.AddWithValue("@risk_hn", TextBoxX1.Text)
            mySqlCommand.Parameters.AddWithValue("@risk_an", TextBoxX2.Text)

            mySqlCommand.Parameters.AddWithValue("@risk_name", TextBoxX3.Text)
            mySqlCommand.Parameters.AddWithValue("@risk_date_s", DateTimePicker3.Value.Year.ToString & DateTimePicker3.Value.ToString("-MM-dd"))
            mySqlCommand.Parameters.AddWithValue("@risk_type", ComboBox2.Text)
            mySqlCommand.Parameters.AddWithValue("@risk_volume", ComboBox4.Text)

            mySqlCommand.Parameters.AddWithValue("@risk_point", TextBoxX5.Text)
            mySqlCommand.Parameters.AddWithValue("@risk_pro", TextBoxX6.Text)
            If CheckBoxX1.Checked = True Then
                mySqlCommand.Parameters.AddWithValue("@risk_ocr", "True")
            Else
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

            mySqlCommand.Parameters.AddWithValue("@risk_location", TextBoxX4.Text)
            mySqlCommand.Parameters.AddWithValue("@risk_stat", ComboBox3.Text)

            mySqlCommand.Parameters.AddWithValue("@ptsafety", ComboBox3.Text)
            mySqlCommand.Parameters.AddWithValue("@prm", ComboBox6.Text)
            mySqlCommand.Parameters.AddWithValue("@clinicrisk", ComboBox7.Text)
            mySqlCommand.Parameters.AddWithValue("@a1", ComboBox12.Text)
            mySqlCommand.Parameters.AddWithValue("@a21", ComboBox8.Text)
            mySqlCommand.Parameters.AddWithValue("@a22", ComboBox9.Text)
            mySqlCommand.Parameters.AddWithValue("@a221", ComboBox13.Text)
            mySqlCommand.Parameters.AddWithValue("@a222", ComboBox10.Text)
            mySqlCommand.Parameters.AddWithValue("@a223", ComboBox11.Text)
            mySqlCommand.Parameters.AddWithValue("@a224", ComboBox24.Text)
            mySqlCommand.Parameters.AddWithValue("@b1", ComboBox14.Text)
            mySqlCommand.Parameters.AddWithValue("@b2", ComboBox15.Text)
            mySqlCommand.Parameters.AddWithValue("@c1", ComboBox16.Text)
            mySqlCommand.Parameters.AddWithValue("@c2", ComboBox17.Text)
            mySqlCommand.Parameters.AddWithValue("@rm2", ComboBox18.Text)
            mySqlCommand.Parameters.AddWithValue("@rm3", ComboBox19.Text)
            mySqlCommand.Parameters.AddWithValue("@identification", ComboBox20.Text)
            mySqlCommand.Parameters.AddWithValue("@slow1", ComboBox21.Text)
            mySqlCommand.Parameters.AddWithValue("@culturerisk", ComboBox22.Text)
            mySqlCommand.Parameters.AddWithValue("@servicerisk", ComboBox23.Text)
            If CheckBoxX5.Checked = True Then
                mySqlCommand.Parameters.AddWithValue("@risk_statcheck", "True")

            ElseIf CheckBoxX5.Checked = False Then
                mySqlCommand.Parameters.AddWithValue("@risk_statcheck", "False")

            End If


            mySqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            sql.Close()
        End Try
        searchDaata()




        clear()

    End Sub
    Public Sub clear()
        DateTimePicker2.Text = ""
        ComboBox5.Text = ""
        ComboBox1.Text = ""
        DateTimePicker3.Text = ""
        TextBoxX4.Text = ""
        TextBoxX1.Text = ""
        TextBoxX2.Text = ""
        TextBoxX3.Text = ""
        ComboBox2.Text = ""
        ComboBox4.Text = ""
        CheckBoxX1.Checked = False
        CheckBoxX2.Checked = False
        CheckBoxX4.Checked = False
        CheckBoxX3.Checked = False
        TextBoxX5.Text = ""
        TextBoxX6.Text = ""
        ComboBox3.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox12.Text = ""
        ComboBox14.Text = ""
        ComboBox8.Text = ""
        ComboBox15.Text = ""
        ComboBox9.Text = ""
        ComboBox16.Text = ""
        ComboBox13.Text = ""
        ComboBox17.Text = ""
        ComboBox10.Text = ""
        ComboBox18.Text = ""
        ComboBox11.Text = ""
        ComboBox19.Text = ""

        ComboBox24.Text = ""
        ComboBox21.Text = ""
        ComboBox22.Text = ""
        ComboBox20.Text = ""
        ComboBox23.Text = ""

    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        Dim risksec As String = ""
        Dim riskocr As String = ""
        Dim risktime As String = ""
        Dim riskrepeat As String = ""
        Dim riskupd As String = ""
        Dim riskstatcheck As String = ""
        Dim commandText2 As String
        Dim mySqlCommand As New MySqlCommand
        sql.Close()
        If sql.State = ConnectionState.Closed Then
            sql.Open()
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


            If CheckBoxX5.Checked = True Then
                riskstatcheck = "True"
            ElseIf CheckBoxX5.Checked = False Then
                riskstatcheck = "False"
            End If
            Dim myDate As DateTime = DateTime.Parse(DateTimePicker2.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
            Dim myDate1 As DateTime
            Try
                myDate1 = DateTime.Parse(DateTimePicker3.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))

            Catch ex As Exception
                myDate1 = DateTime.Now
            End Try



            commandText2 = "UPDATE risk_book SET risk_date = '" & DateTimePicker2.Value.Year.ToString & DateTimePicker2.Value.ToString("-MM-dd") & "',risk_group = '" & ComboBox5.Text & "',risk_dep ='" & ComboBox1.Text & "',risk_sec='" & risksec & "',risk_hn='" & TextBoxX1.Text & "',risk_an ='" & TextBoxX2.Text & "',risk_name= '" & TextBoxX3.Text & "',risk_date_s ='" & DateTimePicker3.Value.Year.ToString & DateTimePicker3.Value.ToString("-MM-dd") & "',risk_type = '" & ComboBox2.Text & "',risk_volume = '" & ComboBox4.Text & "',risk_point ='" & TextBoxX5.Text & "',risk_pro ='" & TextBoxX6.Text & "',risk_time ='" & risktime & "',risk_repeat = '" & riskrepeat & "',risk_upd= '" & riskupd & "',risk_location = '" & TextBoxX4.Text & "' ,risk_stat ='" & ComboBox3.Text & "',ptsafety ='" & ComboBox3.Text & "' , prm='" & ComboBox6.Text & "',clinicrisk ='" & ComboBox7.Text & "',a1='" & ComboBox12.Text & "',a21 ='" & ComboBox8.Text & "',a22 ='" & ComboBox9.Text & "',a221='" & ComboBox13.Text & "',a222 ='" & ComboBox10.Text & "',a223 ='" & ComboBox11.Text & "' , a224='" & ComboBox24.Text & "',b1='" & ComboBox14.Text & "' , b2 ='" & ComboBox15.Text & "' , c1 ='" & ComboBox16.Text & "' , c2 ='" & ComboBox17.Text & "' , rm2 ='" & ComboBox18.Text & "' ,rm3 ='" & ComboBox19.Text & "',identification ='" & ComboBox20.Text & "',slow1 ='" & ComboBox21.Text & "' , culturerisk ='" & ComboBox22.Text & "' , servicerisk ='" & ComboBox23.Text & "',risk_statcheck ='" & riskstatcheck & "' "
            If CheckBoxX1.Checked = True Then
              
                commandText2 += " ,risk_ocr = 'True' , risk_ocrdep = '" & Convert.ToString(TextBoxX4.Tag) & "'   "

            Else

                commandText2 += " ,risk_ocr = 'False' , risk_ocrdep = ' '   "

            End If

            commandText2 += "  WHERE idrisk_book = '" & inbtIndex & "'; "
            mySqlCommand.CommandText = commandText2

            mySqlCommand.Connection = sql
            mySqlCommand.ExecuteNonQuery()
            sql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        searchDaata()
        clear()
        MsgBox("แก้ไขข้อมูลเสร็จสิ้น")
    End Sub

    Public Sub searchDaata()

     Dim connect As ConnecDBRYH = ConnecDBRYH.NewConnection
        Dim sqltext As String
        sqltext = "SELECT CAST(risk_date AS CHAR(15)) AS  'DATE',risk_group as 'ฝ่าย' ,risk_dep  as 'หน่วย' ,  description  as 'Description' ,risk_point as 'เหตุการณ์' , risk_pro as 'สรุปเหตุการณ์' ,risk_type as 'ความเสี่ยง' , risk_volume as 'รุนแรง' ,case risk_statcheck when 'True' then 'ตรวจสอบแล้ว'  ELSE 'ยังไม่ได้ตรวจสอบ' end as 'สถานะ' , idrisk_book  FROM risk_book join userdep on risk_book.risk_dep =  userdep.dep order by risk_statcheck ASC"
        DataInformation.PrimaryGrid.DataSource = connect.GetTable(sqltext)
        connect.Dispose()
        'Try


    End Sub




    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim StatusDate As String
        Dim commandText3 As String
        Dim respone As Object
        respone = MsgBox("ต้องการลบข้อมูลนี้ใช่หรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")
        If respone = 1 Then


            Try
                If sql.State = ConnectionState.Closed Then
                    sql.Open()
                End If

                commandText3 = "Delete FROM risk_book  where idrisk_book = '" & inbtIndex & "'; "
                mySqlCommand.CommandText = commandText3
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            sql.Close()
            searchDaata()
        End If
        sql.Close()


    End Sub

    Private Sub SuperGridControl1GetCellStyle(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridGetCellStyleEventArgs)
        If e.GridCell.GridColumn.Name.Equals("สถานะ") = True Then
            If CStr(e.GridCell.Value).Equals("ตรวจสอบแล้ว") = True Then
                e.Style.Background.Color1 = Color.LightSkyBlue

            End If
            If CStr(e.GridCell.Value).Equals("ยังไม่ได้ตรวจสอบ") = True Then
                e.Style.Background.Color1 = Color.Yellow

            End If
        End If
    End Sub

    Private Sub DataInformation_CellClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles DataInformation.CellClick
        Try

            Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
            grid = e.GridPanel.ActiveRow

            inbtIndex = grid.Cells.Item("idrisk_book").Value
            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader
            Dim key As String
            Dim count As Integer

            count = 0

            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            mySqlCommand.CommandText = "SELECT * FROM risk_book  where idrisk_book ='" & inbtIndex & "';"
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())
                    Dim strdate() As String

                    ComboBox5.Text = mySqlReader("risk_group")
                    ComboBox1.Text = mySqlReader("risk_dep")
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
                    TextBoxX4.Text = mySqlReader("risk_location")
                    ComboBox3.Text = mySqlReader("ptsafety")
                    ComboBox6.Text = mySqlReader("prm")
                    ComboBox7.Text = mySqlReader("clinicrisk")
                    ComboBox12.Text = mySqlReader("a1")
                    ComboBox8.Text = mySqlReader("a21")
                    ComboBox9.Text = mySqlReader("a22")
                    ComboBox13.Text = mySqlReader("a221")
                    ComboBox10.Text = mySqlReader("a222")
                    ComboBox11.Text = mySqlReader("a223")
                    ComboBox24.Text = mySqlReader("a224")
                    ComboBox14.Text = mySqlReader("b1")
                    ComboBox15.Text = mySqlReader("b2")
                    ComboBox16.Text = mySqlReader("c1")
                    ComboBox17.Text = mySqlReader("c2")
                    ComboBox18.Text = mySqlReader("rm2")
                    ComboBox19.Text = mySqlReader("rm3")
                    ComboBox20.Text = mySqlReader("identification")
                    ComboBox21.Text = mySqlReader("slow1")
                    ComboBox22.Text = mySqlReader("culturerisk")
                    ComboBox23.Text = mySqlReader("servicerisk")
                    If mySqlReader("risk_statcheck") = "True" Then
                        CheckBoxX5.Checked = True
                    Else
                        CheckBoxX5.Checked = False
                    End If


                    'strdate = Split(mySqlReader("risk_date").ToString, "/")

                    strdate = Split(mySqlReader("risk_date").ToString, "/")
                    If strdate(0).Length = 1 Then
                        strdate(0) = "0" + strdate(0).ToString
                    End If
                    If strdate(1).Length = 1 Then
                        strdate(1) = "0" + strdate(1).ToString
                    End If
                    DateTimePicker2.Text = strdate(0) + "/" + strdate(1) + "/" + strdate(2)
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            sql.Close()
        Catch ex As Exception

        End Try

    End Sub


End Class