Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Media
Imports System.Text
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports System.Threading
Imports DevComponents.DotNetBar
Imports NCalc


Public Class frmqua_reportvb
    Dim commandKey As String = ""
    Dim cmdKey As String
    Dim inbtIndex As Integer
    Dim sql As MySqlConnection = frmmain_qua.mysqlconection
    Dim idkey As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String

    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader

    Dim idstring() As String
    Dim idstring2() As String
    Dim idstring3() As String
    Dim idkeyindex As String
    Public Delegate Sub DelegateSub(ByVal x As Integer)
    Private Sub frmqua_reportvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
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

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM risk_book left join userdep on userdep.dep = risk_book.risk_dep;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            DataGridViewX1.Rows.Clear()


            While (mySqlReader.Read())
                If mySqlReader("risk_statcheck") IsNot DBNull.Value Then
                    If mySqlReader("risk_statcheck") = "True" Then
                        statstr = "ตรวจสอบแล้ว"
                    Else
                        statstr = "ไม่ได้ตรวจสอบ"
                    End If
                Else

                    statstr = "ไม่ได้ตรวจสอบ"
                End If
                DataGridViewX1.Rows.Add({mySqlReader("risk_date_s").ToString, mySqlReader("risk_group"), mySqlReader("description"), mySqlReader("risk_type"), mySqlReader("risk_volume"), mySqlReader("risk_point"), mySqlReader("risk_pro"), statstr})
            End While

        Catch ex As Exception

        End Try
        sql.Close()




    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        searchData()

    End Sub
    Public Sub searchData()


        Dim inbtIndex As Integer
        Dim commandKey1 As String = ""
        Dim commandkey2 As String = ""
        Dim commandkey3 As String = ""

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer
        Dim statstr As String

        count = 0

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        If Trim(date_eta_penang.Text) <> "/  /" And Trim(MaskedTextBoxAdv3.Text) <> "/  /" Then
            Dim dates() As String = date_eta_penang.Text.ToString.Split("/")
            Dim datee() As String = MaskedTextBoxAdv3.Text.ToString.Split("/")
            commandKey1 = "risk_date >= '" & dates(2) + "-" + dates(1) + "-" + dates(0) & "' and risk_date <= '" & datee(2) + "-" + datee(1) + "-" + datee(0) & "'"
        End If

        If ComboBox2.Text = "ทั้งหมด" Then
            commandkey2 = ""
        Else
            commandkey2 = "risk_type  = '" & ComboBox2.Text & "'"
        End If

        If ComboBox4.Text = "ทั้งหมด" Then
            commandkey3 = ""
        Else
            commandkey3 = "risk_volume = '" & ComboBox4.Text & "'"
        End If

        If commandKey1.Length > 3 And commandkey2.Length > 3 And commandkey3.Length > 3 Then
            commandKey = " Where " + commandKey1 + " and " + commandkey2 + " and " + commandkey3
        ElseIf commandKey1.Length > 3 And commandkey2.Length > 3 And commandkey3.Length < 3 Then
            commandKey = " Where " + commandKey1 + " and " + commandkey2

        ElseIf commandKey1.Length > 3 And commandkey2.Length < 3 And commandkey3.Length > 3 Then
            commandKey = " Where " + commandKey1 + " and " + commandkey3

        ElseIf commandKey.Length < 3 And commandkey2.Length > 3 And commandkey3.Length > 3 Then
            commandKey = " Where " + commandkey2 + " and " + commandkey3

        ElseIf commandKey1.Length > 3 And commandkey2.Length < 3 And commandkey3.Length < 3 Then
            commandKey = " Where " + commandKey1

        ElseIf commandKey1.Length < 3 And commandkey2.Length > 3 And commandkey3.Length < 3 Then
            commandKey = " Where " + commandkey2

        ElseIf commandKey1.Length < 3 And commandkey2.Length < 3 And commandkey3.Length > 3 Then
            commandKey = " Where " + commandkey3

        Else
            commandKey = ""
        End If



        If ComboBox1.Text = "ทั้งหมด" Then
            mySqlCommand.CommandText = "SELECT * FROM risk_book  " & commandKey & " order by idrisk_book ASC;"
        Else
            If commandKey1.Length > 3 Then
                mySqlCommand.CommandText = "SELECT * FROM risk_book  " & commandKey & " and risk_dep = '" & ComboBox1.Text & "' order by idrisk_book ASC;"
            Else
                mySqlCommand.CommandText = "SELECT * FROM risk_book  where risk_dep = '" & ComboBox1.Text & "' order by idrisk_book ASC;"

            End If
        End If



        mySqlCommand.Connection = sql


        Try
            mySqlReader = mySqlCommand.ExecuteReader

            DataGridViewX1.Rows.Clear()


            While (mySqlReader.Read())
                If mySqlReader("risk_statcheck") = "True" Then
                    statstr = "ตรวจสอบแล้ว"
                Else
                    statstr = "ไม่ได้ตรวจสอบ"
                End If
                DataGridViewX1.Rows.Add({mySqlReader("risk_date"), mySqlReader("risk_group"), mySqlReader("risk_dep"), mySqlReader("risk_type"), mySqlReader("risk_volume"), mySqlReader("risk_point"), mySqlReader("risk_pro"), statstr})
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()



    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        Dim inbtIndex As Integer
        Dim commandKey1 As String = ""
        Dim commandkey2 As String = ""
        Dim commandkey3 As String = ""

        If Trim(date_eta_penang.Text) <> "/  /" And Trim(MaskedTextBoxAdv3.Text) <> "/  /" Then
            Dim dates() As String = date_eta_penang.Text.ToString.Split("/")
            Dim datee() As String = MaskedTextBoxAdv3.Text.ToString.Split("/")
            commandKey1 = "risk_date >= '" & dates(2) + "-" + dates(1) + "-" + dates(0) & "' and risk_date <= '" & datee(2) + "-" + datee(1) + "-" + datee(0) & "'"
        End If

        If ComboBox2.Text = "ทั้งหมด" Then
            commandkey2 = ""
        Else
            commandkey2 = "risk_type  = '" & ComboBox2.Text & "'"
        End If

        If ComboBox4.Text = "ทั้งหมด" Then
            commandkey3 = ""
        Else
            commandkey3 = "risk_volume = '" & ComboBox4.Text & "'"
        End If

        If commandKey1.Length > 3 And commandkey2.Length > 3 And commandkey3.Length > 3 Then
            commandKey = " Where " + commandKey1 + " and " + commandkey2 + " and " + commandkey3
        ElseIf commandKey1.Length > 3 And commandkey2.Length > 3 And commandkey3.Length < 3 Then
            commandKey = " Where " + commandKey1 + " and " + commandkey2

        ElseIf commandKey1.Length > 3 And commandkey2.Length < 3 And commandkey3.Length > 3 Then
            commandKey = " Where " + commandKey1 + " and " + commandkey3

        ElseIf commandKey.Length < 3 And commandkey2.Length > 3 And commandkey3.Length > 3 Then
            commandKey = " Where " + commandkey2 + " and " + commandkey3

        ElseIf commandKey1.Length > 3 And commandkey2.Length < 3 And commandkey3.Length < 3 Then
            commandKey = " Where " + commandKey1

        ElseIf commandKey1.Length < 3 And commandkey2.Length > 3 And commandkey3.Length < 3 Then
            commandKey = " Where " + commandkey2

        ElseIf commandKey1.Length < 3 And commandkey2.Length < 3 And commandkey3.Length > 3 Then
            commandKey = " Where " + commandkey3

        Else
            commandKey = ""
        End If



        If ComboBox1.Text = "ทั้งหมด" Then
            cmdKey = "SELECT * FROM risk_book  " & commandKey & " order by idrisk_book ASC;"
        Else
            If commandKey1.Length > 3 Then
                cmdKey = "SELECT * FROM risk_book  " & commandKey & " and risk_dep = '" & ComboBox1.Text & "' order by idrisk_book ASC;"
            Else
                cmdKey = "SELECT * FROM risk_book  where risk_dep = '" & ComboBox1.Text & "' order by idrisk_book ASC;"

            End If
        End If



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
        Dim count As Integer = 7


        pathExcel = FolderBrowserDialog1.SelectedPath
        Dim excelapp As New Excel.Application
        Dim excelbooks As Excel.Workbook
        Dim excelsheets As Excel.Worksheet
        excelbooks = excelapp.Workbooks.Add

        excelsheets = CType(excelbooks.Worksheets(1), Excel.Worksheet)
        excelsheets.Name = "S"
        With excelsheets
            .PageSetup.PaperSize = Excel.XlPaperSize.xlPaperA4
            .PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape

            .ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange, .Range("$B$2:$Z$7"), , Excel.XlYesNoGuess.xlYes).Name = "Table1"


            .Range("A1:M500").Font.Name = "Tahoma"
            .Range("A1:M500").Font.Size = 10
            .Rows("1:500").rowheight = 21
            With .Range("A2:A2")

                .Value = "เดือน"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("B2:B2")

                .Value = "เดือน"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("C2:C2")

                .Value = "วันที่เกิดเดือน"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("D2:D2")

                .Value = "ฝ่าย"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("E2:E2")

                .Value = "หน่วย"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("F2:F2")

                .Value = "ประเภท"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("G2:G2")

                .Value = "ระดับความรุนแรง"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("H2:H2")

                .Value = "TYPE OF RISK"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("I2:I2")

                .Value = "รายงานเป็น OCR"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With


            With .Range("J2:J2")

                .Value = "Pt Safety"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("K2:K2")

                .Value = "Program RM"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("L2:L2")

                .Value = "Clinical Risk"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("M2:M2")

                .Value = "A1 สิทธิของผู้ป่วย"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("N2:N2")

                .Value = "A2 ความปลอดภัย"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With


            With .Range("O2:O2")

                .Value = "A2-1 ความเสี่ยงคลินิคทั่วไป"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With


            With .Range("P2:P2")

                .Value = "A2-2 ความเสี่ยงคลินิคเฉพาะโรค"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With


            With .Range("Q2:Q2")

                .Value = "A2-2-1 ความเสี่ยงเกี่ยวกับการผ่าตัด"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("R2:R2")

                .Value = "A2-2-2 ความเสี่ยงเกี่ยวกับโรค ทางอายุรกรรม"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("S2:S2")

                .Value = "A2-2-3 ความเสี่ยงเกี่ยวกับโรค ทางสูติกรรม"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With


            With .Range("T2:T2")

                .Value = "A2-2-4 ความเสี่ยงเกี่ยวกับโรค ทางกุมารเวชกรรม"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With


            With .Range("U2:U2")

                .Value = "RM2 สิ่งแวดล้อมและชีวอนามัย"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("V2:V2")

                .Value = "B1 สิ่งแวดล้อม พลังงาน โครงสร้างกายภาพ"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("W2:W2")

                .Value = "B2 อาชีวอนามัยและความปลอดภัยของบุคคลากร"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("X2:X2")

                .Value = "RM3 ชื่อเสียง"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("Y2:Y2")

                .Value = "C1 การฟ้องร้อง กฎหมาย"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("Z2:Z2")

                .Value = "สาเหตุ"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("AA2:AA2")

                .Value = "การจัดการปัญหาความเสี่ยง"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("AB2:AB2")

                .Value = "แนวทางป้องกันการเกิดซ้ำ"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("AC2:AC2")

                .Value = "Identification"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("AD2:AD2")

                .Value = "ล่าช้า"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("AE2:AE2")

                .Value = "C2 ข้อร้องเรียนของผู้ใช้บริการ"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("AF2:AF2")

                .Value = "สิ่งแวดล้อม / เครื่องมือ"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("AG2:AG2")

                .Value = "การบริการ"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("A2:AG2")
                '.WrapText = True
                .EntireColumn.AutoFit()
                '.EntireRow.AutoFit()

            End With

            sql.Close()

            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            Dim countline As Integer = 3

            mySqlCommand.Connection = sql
            mySqlCommand.CommandText = cmdKey
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader

                While (mySqlReader.Read())
                    With .Range("A" + countline.ToString + ":A" + countline.ToString)

                        .Value = mySqlReader("idrisk_book")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("B" + countline.ToString + ":B" + countline.ToString)

                        .Value = mySqlReader("risk_date")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("C" + countline.ToString + ":C" + countline.ToString)

                        .Value = mySqlReader("risk_date_s")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("D" + countline.ToString + ":D" + countline.ToString)

                        .Value = mySqlReader("risk_group")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("E" + countline.ToString + ":E" + countline.ToString)

                        .Value = mySqlReader("risk_dep")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("F" + countline.ToString + ":F" + countline.ToString)

                        .Value = mySqlReader("risk_group")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With



                    With .Range("G" + countline.ToString + ":G" + countline.ToString + "")

                        .Value = mySqlReader("risk_volume")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("H" + countline.ToString + ":H" + countline.ToString + "")

                        .Value = "TYPE OF RISK"
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("I" + countline.ToString + ":I" + countline.ToString + "")

                        .Value = mySqlReader("risk_ocr")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With


                    With .Range("J" + countline.ToString + ":J" + countline.ToString + "")

                        .Value = mySqlReader("ptsafety")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("K" + countline.ToString + ":K" + countline.ToString + "")

                        .Value = mySqlReader("prm")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("L" + countline.ToString + ":L" + countline.ToString + "")

                        .Value = mySqlReader("clinicrisk")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("M" + countline.ToString + ":M" + countline.ToString + "")

                        .Value = mySqlReader("a1")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("N" + countline.ToString + ":N" + countline.ToString + "")

                        .Value = mySqlReader("clinicrisk")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With


                    With .Range("O" + countline.ToString + ":O" + countline.ToString + "")

                        .Value = mySqlReader("a21")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With


                    With .Range("P" + countline.ToString + ":P" + countline.ToString + "")

                        .Value = mySqlReader("a22")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With


                    With .Range("Q" + countline.ToString + ":Q" + countline.ToString + "")

                        .Value = mySqlReader("a221")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("R" + countline.ToString + ":R" + countline.ToString + "")

                        .Value = mySqlReader("a222")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("S" + countline.ToString + ":S" + countline.ToString + "")

                        .Value = mySqlReader("a223")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With


                    With .Range("T" + countline.ToString + ":T" + countline.ToString + "")

                        .Value = mySqlReader("a224")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With


                    With .Range("U" + countline.ToString + ":U" + countline.ToString + "")

                        .Value = mySqlReader("rm2")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("V" + countline.ToString + ":V" + countline.ToString + "")

                        .Value = mySqlReader("b1")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("W" + countline.ToString + ":W" + countline.ToString + "")

                        .Value = mySqlReader("b2")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("X" + countline.ToString + ":X" + countline.ToString + "")

                        .Value = mySqlReader("rm3")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("Y" + countline.ToString + ":Y" + countline.ToString + "")

                        .Value = mySqlReader("c1")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("Z" + countline.ToString + ":Z" + countline.ToString + "")

                        .Value = mySqlReader("risk_point")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("AA" + countline.ToString + ":AA" + countline.ToString + "")

                        .Value = mySqlReader("risk_pro")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("AB" + countline.ToString + ":AB" + countline.ToString + "")

                        .Value =
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("AC" + countline.ToString + ":AC" + countline.ToString + "")

                        .Value = mySqlReader("identification")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("AD" + countline.ToString + ":AD" + countline.ToString + "")

                        .Value = mySqlReader("slow1")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With

                    With .Range("AE" + countline.ToString + ":AE" + countline.ToString + "")

                        .Value = mySqlReader("c2")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("AF" + countline.ToString + ":AF" + countline.ToString + "")

                        .Value = mySqlReader("culturerisk")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With
                    With .Range("AG" + countline.ToString + ":AG" + countline.ToString + "")

                        .Value = mySqlReader("servicerisk")
                        .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .HorizontalAlignment = Excel.Constants.xlLeft
                        .Font.Bold = True
                    End With












                    countline += 1



                End While


            Catch ex As Exception

            End Try







        End With


        Try
            excelbooks.SaveAs(pathExcel.ToString + "\qua.xlsx")

            excelbooks.Close()
            excelapp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelapp)
            excelbooks = Nothing
            excelsheets = Nothing
            excelapp = Nothing
            Dim proc As System.Diagnostics.Process

            For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                proc.Kill()
            Next
            MsgBox("Report Complete")


        Catch ex As Exception

            excelbooks.Close()
            excelapp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelapp)
            excelbooks = Nothing
            excelsheets = Nothing
            excelapp = Nothing
            Dim proc As System.Diagnostics.Process

            For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                proc.Kill()
            Next


        End Try
        showResult(200)
        CircularProgress1.IsRunning = False
    End Sub
    Private Sub showResult(ByVal Num As Integer)
        If Label10.InvokeRequired Then
            Dim dlg As New DelegateSub(AddressOf showResult)
            Me.Invoke(dlg, Num)

        Else
            CircularProgress1.IsRunning = False

        End If
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

                commandText3 = "Delete FROM risk_book  where idrisk_book = '" & DataGridViewX1.Rows(inbtIndex).Cells(10).Value & "'; "
                mySqlCommand.CommandText = commandText3
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            sql.Close()

        End If
        sql.Close()
    End Sub

    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        inbtIndex = e.RowIndex
    End Sub
End Class