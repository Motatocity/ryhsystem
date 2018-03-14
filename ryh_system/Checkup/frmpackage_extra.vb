Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class frmpackage_extra
    Dim dentall As String
    Dim resulteye As String = ""
    Dim resultphy As String = ""
    Dim resultxray As String = ""
    Dim result_redmorphology As String = ""
    Dim resultplate As String = ""
    Dim check_sub As Integer = 0
    Dim check_group As String = ""
    Dim count_group As Integer = 1
    Dim check_form As String = "0"
    Dim count_result As Integer
    Public Shared result_all As String = " "
    Public Shared urine_other As String = " "
    Public Shared pap_text As String = " "
    Public Shared pap_result As String = " "
    Public Shared under As String = " "
    Dim position_user As String
    Public selectedEmployee As String
    Dim idcontainer As String
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim export_id As String
    Dim id_hn As String
    Public Shared vir_igt As String = " "
    Public Shared date_string As String
    Public Shared red_homology As String = " "
    Public Shared address As String = " "
    Public Shared export_date As String = " "
    Public Shared tellephone As String = " "
    Public Shared result_phy As String = " "
    Public Shared result_hematology As String = " "
    Public Shared result_urine As String = " "
    Public Shared result_physical As String = " "
    Public Shared result_xray As String = " "
    Public Shared result_ultrasound As String = " "
    Public Shared result_ekg As String = " "
    Public Shared result_bloodchem As String = " "
    Public Shared result_bun As String = " "
    Public Shared result_creatinine As String = " "
    Public Shared result_uricacid As String = " "
    Public Shared result_cholesterol As String = " "
    Public Shared result_triglyceride As String = " "
    Public Shared result_hdl As String = " "
    Public Shared result_ldl As String = " "
    Public Shared result_sgot As String = " "
    Public Shared result_sgpt As String = " "
    Public Shared result_alkaline As String = " "
    Public Shared name_lastname As String = " "
    Public Shared result_afp As String = " "
    Public Shared result_pfp As String = " "
    Public Shared result_fbs As String = " "
    Public Shared phy_height As String = "-"
    Public Shared phy_weight As String = "-"
    Public Shared phy_bmi As String = "-"
    Public Shared phy_bloodpressure As String = "- "
    Public Shared phy_pulse As String = "- "
    Public Shared phy_eye_left As String = "-"
    Public Shared phy_eye_right As String = " -"
    Public Shared phy_dental As String = "-"
    Public Shared tab2_redcell As String = " "
    Public Shared doctor_name As String = " "
    Public Shared result_pulserate As String = " "
    Public Shared result_eye As String = " "
    Dim address_text As String = ""
    Dim mysql1 As MySqlConnection
    Dim mysql As MySqlConnection
    Dim mysql_ryh As MySqlConnection
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    '  Dim MyODBCConnection As New OdbcConnection("Server=192.0.0.222; dsn=RYHV5; User Id=mse;Password=m0116
    Private myTabRect As System.Drawing.Rectangle
    Public Sub New(ByRef mysql_pass As String, ByRef ip_connect As String, ByRef user_namedb As String, ByRef db_name As String, ByRef idexport As String, ByRef idhn As String, ByRef check_sub1 As String)

        mysqlpass = mysql_pass
        selectedEmployee = ""
        ipconnect = ip_connect
        usernamedb = user_namedb
        dbname = db_name
        export_id = idhn
        id_hn = idexport
        check_sub = check_sub1
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        excelReport()
    End Sub
    Public Sub excelReport()
        Dim pathExcel As String

        FolderBrowserDialog1.Description = "Pick Folder to store Excecl files"
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.SelectedPath = "C:\"
        FolderBrowserDialog1.ShowDialog()

        pathExcel = FolderBrowserDialog1.SelectedPath
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("th-TH")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        Dim excelapp As New Excel.Application

        Dim excelbooks As Excel.Workbook
        Dim excelsheets As Excel.Worksheet
        excelbooks = excelapp.Workbooks.Add

        Dim hn_start As String
        Dim hn_first As String
        id_hn = txtsearch.Text
        hn_start = id_hn.Substring(id_hn.Length - 2)

        hn_first = Microsoft.VisualBasic.Left(id_hn, id_hn.Length - 2)

        excelsheets = CType(excelbooks.Worksheets(1), Excel.Worksheet)


        With excelsheets

            .PageSetup.PaperSize = Excel.XlPaperSize.xlPaperA5
            .PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait
            Dim xl As New Microsoft.Office.Interop.Excel.Application

            With .PageSetup
                .LeftMargin = xl.InchesToPoints(0.64 / 2.5)
                .RightMargin = xl.InchesToPoints(0.64 / 2.5)
                .TopMargin = xl.InchesToPoints(1.91 / 2.5)
                .BottomMargin = xl.InchesToPoints(1.91 / 2.5)
                .HeaderMargin = xl.InchesToPoints(0.76 / 2.5)
                .FooterMargin = xl.InchesToPoints(0.76 / 2.5)
            End With




            .Range("A1:L500").Font.Name = "Angsana New"
            .Range("A2:L500").Font.Size = 15
            .Range("A1").ColumnWidth = 3.29
            .Range("B1").ColumnWidth = 3.29
            .Range("C1").ColumnWidth = 5.29
            .Range("D1").ColumnWidth = 5.29
            .Range("E1").ColumnWidth = 5.29
            .Range("F1").ColumnWidth = 5.29
            .Range("G1").ColumnWidth = 5.29
            .Range("H1").ColumnWidth = 5.29
            .Range("I1").ColumnWidth = 5.29
            .Range("J1").ColumnWidth = 5.29
            .Range("K1").ColumnWidth = 5.29
            .Range("L1").ColumnWidth = 8.0
            For J = 7 To 10
                .Range("B24:K24").Borders(J).Weight = 2 ' xlThin
                .Range("B28:K32").Borders(J).Weight = 2 ' xlThin
                .Range("B46:K46").Borders(J).Weight = 2 ' xlThin
                .Range("B59:K59").Borders(J).Weight = 2 ' xlThin
            Next

            .Range("B69:K69").Borders(9).Weight = 2 ' xlThin
            .Range("B89:K89").Borders(9).Weight = 2 ' xlThin
            .Range("B116:K116").Borders(9).Weight = 2 ' xlThin


            .Rows("46:66").rowheight = 20
            .Rows("89:168").rowheight = 18
            .Rows("87:87").rowheight = 57
            .Rows("45:68").rowheight = 18.75
            .Rows("58:58").rowheight = 51.75
            With .Range("B68:C68")
                .Merge()
                .Font.Size = 11
                .Value = hn_first + "-" + hn_start
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("E68:G68")
                .Merge()
                .Font.Size = 11
                .Value = txt_name.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("B44:C44")
                .Merge()
                .Font.Size = 11
                .Value = hn_first + "-" + hn_start
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
            With .Range("E44:G44")
                .Merge()

                .Font.Size = 11
                .Value = txt_name.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With


            With .Range("B88:C88")
                .Merge()

                .Font.Size = 11
                .Value = hn_first + "-" + hn_start
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("E88:G88")
                .Merge()

                .Font.Size = 11
                .Value = txt_name.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("B115:C115")
                .Merge()

                .Font.Size = 11
                .Value = hn_first + "-" + hn_start
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("E115:G115")
                .Merge()

                .Font.Size = 11
                .Value = txt_name.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("B142:C142")
                .Merge()

                .Font.Size = 11
                .Value = hn_first + "-" + hn_start
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With

            With .Range("E142:G142")
                .Merge()

                .Font.Size = 11
                .Value = txt_name.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .HorizontalAlignment = Excel.Constants.xlLeft
                .Font.Bold = True
            End With
 




            With .Range("J23:K23")
                .Merge()
                .NumberFormat = "@"
                .Font.Size = 11
                .Value = txt_date.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .Font.Bold = True
            End With
            With .Range("J45:K45")
                .Merge()
                .Font.Size = 11
                .NumberFormat = "@"
                .Value = txt_date.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .Font.Bold = True
            End With
            With .Range("J69:K69")
                .Merge()
                .Font.Size = 11
                .NumberFormat = "@"
                .Value = txt_date.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .Font.Bold = True
            End With
            With .Range("J89:K89")
                .Merge()
                .Font.Size = 11
                .NumberFormat = "@"
                .Value = txt_date.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .Font.Bold = True
            End With
            With .Range("J116:K116")
                .Merge()
                .Font.Size = 11
                .NumberFormat = "@"
                .Value = txt_date.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
                .Font.Bold = True
            End With
          

            With .Range("A2:B2")
                With excelsheets.Shapes.AddShape(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRoundedRectangle, _
                    30, 30, 320, 80)
                    .TextEffect.Alignment = MsoTextEffectAlignment.msoTextEffectAlignmentLeft
                    .Fill.ForeColor.RGB = RGB(255, 255, 255)
                    .TextEffect.FontSize = 16
                    .TextEffect.Text = "The Colonoscopy 2016" & vbCrLf & "รายงานผลตรวจสุขภาพ" & vbCrLf & "Medical Examination Report"
                    .TextEffect.Alignment = MsoTextEffectAlignment.msoTextEffectAlignmentCentered
                    .DrawingObject.Font.Color = RGB(0, 0, 0)
                End With
            End With
            With .Range("C7:E7")
                .Merge()
                .Value = "ชื่อ-นามสกุล  :"
                .Font.Bold = True
            End With

            With .Range("C8:E8")
                .Merge()
                .Value = "Name - Last Name"
                .Font.Bold = True
            End With
            With .Range("F7:J8")
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Merge()
                .Value = txt_name.Text
            End With




            With .Range("C9:E9")
                .Merge()
                .Value = "วันที่ตรวจ  :  "
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("C10:E10")
                .Merge()
                .Value = "Date of Examination "
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("F9:J10")

                .Merge()
                .NumberFormat = "@"
                .Value = txt_date.Text
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            End With





            With .Range("C11:E11")
                .Merge()
                .Value = "เลขประจำตัว HN :"
                .Font.Bold = True
            End With


            With .Range("F11:K11")
                .Merge()
                .NumberFormat = "@"
                .Value = hn_first + "-" + hn_start

                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With



            With .Range("C12:D12")
                .Merge()
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Value = "อายุ(Age) :"
                .Font.Bold = True
            End With


            With .Range("E12")
                .Merge()
                .Value = "  " + txt_age.Text
                .NumberFormat = "@"
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("F12:H12")
                .Merge()
                .Value = "ปี(Years) / เพศ (Sex) :"
                .Font.Bold = True
            End With

            With .Range("I12")
                .Merge()
                .Value = txt_sex.Text
            End With



            With .Range("C13:D13")
                .Merge()
                .Value = "ที่อยู่ (Address) :"
                .Font.Bold = True
            End With
            With .Range("C14:K15")
                .Merge()
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .Value = txt_address.Text
                .WrapText = True
            End With


            With .Range("C16:E16")
                .Merge()
                .Value = "โทรศัพท์ (Telephone)  :"
                .Font.Bold = True
            End With
            With .Range("F16:G16")
                .Merge()
                .NumberFormat = "@"
                If Trim(txt_tell.Text) = "-   -" Then

                Else
                    .Value = txt_tell.Text
                End If

                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("C17:H17")
                .Merge()
                .Value = "โรคประจำตัว (Underlying disease)  :"
                .Font.Bold = True
            End With
            With .Range("C18:K18")
                .Merge()
                .Value = txt_aid.Text
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("B23:D23")
                .Merge()
                .Value = "Medical Examination Report"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With
            With .Range("E23:H23")
                .Merge()
                .NumberFormat = "@"
                .Value = "2/6"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With


            With .Range("B24:K24")
                .Merge()
                .Value = "การตรวจร่างกาย (Physical Examination)"
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Interior.Color = RGB(128, 128, 128)
            End With


            With .Range("B25:D25")
                .Merge()
                .Value = "ส่วนสูง(Height) :"

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B26:D26")
                .Merge()
                .Value = "น้ำหนัก (Weight) :"

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("J25:K25")
                .Merge()
                .Value = "ซม.(cm.)"

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("H25")
                .Merge()
                .Value = tab1_txt_height.Text

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("H26")
                .Merge()
                .Value = tab1_tab_weight.Text

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("J26:K26")
                .Merge()
                .Value = "กก. (kg.)"

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("B27:G27")
                .Merge()
                .Value = "ค่าดัชนีมวลร่างกาย Body Mass Index (BMI) :"

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("H27:J27")
                .Merge()
                .Value = tab1_txt_bmi.Text

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B28:K28")
                .Merge()
                .Value = "ค่าดัชนีมวลร่างกาย  Body Mass Index (BMI)  18.5 - 24.9  ปกติ"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Interior.Color = RGB(128, 128, 128)

            End With


            With .Range("B29:K29")
                .Merge()
                .Value = "ต่ำกว่า  18.5  น้ำหนักน้อยกว่าเกณฑ์ปกติ  แนะนำบริโภคอาหารให้ครบ 5 หมู่และออกกำลังกายสม่ำเสมอ"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Interior.Color = RGB(128, 128, 128)
            End With


            With .Range("B30:K30")
                .Merge()
                .Value = "  25 - 29.9  น้ำหนักมากกว่าเกณฑ์ปกติ  แนะนำจำกัดปริมาณอาหารและออกกำลังกายสม่ำเสมอ"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Interior.Color = RGB(128, 128, 128)
            End With
            With .Range("B31:K31")
                .Merge()
                .Value = " มากกว่าหรือเท่ากับ  30.0  โรคอ้วน  ปรับเปลี่ยนพฤติกรรมบริโภค จำกัดปริมาณอาหาร"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Interior.Color = RGB(128, 128, 128)
            End With
            With .Range("B32:K32")
                .Merge()
                .Value = " และกำลังกายสม่ำเสมอ สัปดาห์ละ 3 ครั้ง ครั้งละ 30 นาที อย่างเคร่งครัด"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Interior.Color = RGB(128, 128, 128)
            End With

            With .Range("B33:D33")
                .Merge()
                .Value = "ชีพจร (Pulse rate) :"

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            End With

            With .Range("G33:H33")
                .Merge()
                .Value = tab1_txt_pulserate.Text
                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            End With
            With .Range("I33:K33")
                .Merge()
                .Value = "ครั้งต่อนาที (BPM)"

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B34:F34")
                .Merge()
                .Value = "ความดันโลหิต (Blood Pressure) :"

                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("G34:H34")
                .Merge()
                .Value = tab1_txt_bloodp.Text
                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("I34:K34")
                .Merge()
                .Value = "มม.ปรอท (mmHg)"
                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B35:K35")
                .Merge()
                .Value = tab1_result_pulse.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop

            End With








            With .Range("B45:D45")
                .Merge()
                .Value = "Medical Examination Report"
                .Font.Size = 11
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With
            With .Range("E45:H45")
                .Merge()
                .NumberFormat = "@"
                .Value = "3/6"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With
            With .Range("B46:K46")
                .Merge()

                .Value = "โลหิตวิทยา (Hematology)"
                .Font.Bold = True
                .Font.Size = 16
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Interior.Color = RGB(128, 128, 128)
            End With

            With .Range("B47:E47")
                .Merge()
                .Value = "หมู่เลือด (Blood Group-ABO)"

                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            End With

            With .Range("F47:G47")
                .Merge()
                .Value = tab2_txt_groupblood.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            End With

            With .Range("H47:I47")
                .Merge()
                .Value = "หมู่เลือด (Rh) :"

                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("J47:K47")
                .Merge()
                .Value = tab2_txt_rh.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("B48")
                .Merge()
                .Value = "การตรวจความสมบูรณ์ของเม็ดเลือด ( Complete blood Count )"

                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("B49")
                .Merge()
                .Value = "Hb:"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("C49:D49")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_hb.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("E49")
                .Merge()
                .Value = "gm%"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("F49")
                .Merge()
                .Value = "Hct: "
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("G49:H49")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_hct.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("I49")
                .Merge()
                .Value = "%"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("B50:I50")
                .Merge()
                .Value = "เม็ดเลือดขาวและแยกประเภท (White blood count & differentiation) :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B51:C51")
                .Merge()
                .Value = "WBC :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("D51:E51")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_wbc.Text

                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            Dim name As String = "*103 cells/mm3"
            With .Range("F51:H51")
                .Merge()
                .Value = name
                .Characters(4, 1).Font.Superscript = True
                .Characters(14, 1).Font.Superscript = True
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With

            With .Range("B52")
                .Merge()
                .Value = "Neutrophils :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("D52:E52")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_neutrophils.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("F52")
                .Merge()
                .Value = "%"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("G52:H52")
                .Merge()
                .Value = "Lymphocytes :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("I52:J52")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_lymphocytes.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("K52")
                .Merge()
                .Value = "%"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B53:C53")
                .Merge()
                .Value = "Eosinophils :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("D53:E53")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_eosinophils.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("F53")
                .Merge()
                .Value = "%"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("G53:H53")
                .Merge()
                .Value = "Monocytes :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("I53:J53")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_monocytes.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("K53")
                .Merge()
                .Value = "%"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B54:C54")
                .Merge()
                .Value = "Basophils :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("D54:E54")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_bashophils.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("F54")
                .Merge()
                .Value = "%"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("G54:H54")
                .Merge()
                .Value = "Atypical lymph :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("I54:J54")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_atypical.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("K54")
                .Merge()
                .Value = "%"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B55:K55")
                .Merge()
                .Value = "ลักษณะเม็ดเลือดแดง (Red Cell Morphology) : "
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With



            With .Range("B56:K56")
                .Merge()
                .NumberFormat = "@"
                If Trim(tab2_txt_redcell.Text) = "" Then
                    .Value = "อยู่ในเกณฑ์ปกติ (Normal)"
                Else
                    .Value = tab2_txt_redcell.Text
                End If

                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .WrapText = True
            End With
            With .Range("B57:E57")
                .Merge()
                .Value = "เกล็ดเลือด (Platelet count) :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("F57:G57")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_txt_plate.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("H57:J57")
                .Merge()
                .Value = "*103 cells/mm3"
                .Font.Size = 14
                .Characters(4, 1).Font.Superscript = True
                .Characters(14, 1).Font.Superscript = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With
            With .Range("B58:C58")
                .Merge()
                .Value = "สรุปผล :"
                .Font.Size = 14
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            End With
            With .Range("D58:K58")
                .Merge()
                .NumberFormat = "@"
                .Value = tab2_result_redmorphology.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .WrapText = True
            End With
            With .Range("B59:K59")
                .Merge()
                .Value = "การวิเคราะห์ปัสสาวะ (Urine Analysis)"
                .Font.Bold = True
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Interior.Color = RGB(128, 128, 128)
            End With
            With .Range("B60:C60")
                .Merge()
                .Value = "Color :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("D60:F60")
                .Merge()
                .Value = tab3_txt_color.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B61:C61")
                .Merge()
                .Value = "Appearance :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("D61:F61")
                .Merge()
                .Value = tab3_txt_appearance.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With



            With .Range("B64:C64")
                .Merge()
                .Value = "Albumin :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("D64:F64")
                .Merge()
                .Value = tab3_txt_albumin.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With




            With .Range("G60:H60")
                .Merge()
                .Value = "Glucose :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("I60:J60")
                .Merge()
                .Value = tab3_txt_glucose.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With



            With .Range("B62:C62")
                .Merge()
                .Value = "Sp. Gr. :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("D62:F62")
                .Merge()
                .NumberFormat = "@"
                .Value = tab3_txt_spgr.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("G61:H61")
                .Merge()
                .Value = "Blood :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("I61:J61")
                .Merge()
                .NumberFormat = "@"
                .Value = tab3_txt_blood.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            End With

            With .Range("B63:C63")
                .Merge()
                .Value = "pH :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("D63:F63")
                .Merge()
                .NumberFormat = "@"
                .Value = tab3_txt_ph.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("G62:H62")
                .Merge()
                .Value = "RBC :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("I62:K62")
                .Merge()
                .NumberFormat = "@"

                If tab3_txt_rbc.Text.Length <> 8 And tab3_txt_rbc.Text.Length <> 5 Then
                    .Value = tab3_txt_rbc.Text + "  Cells/HP"
                Else
                    .Value = tab3_txt_rbc.Text
                End If

                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("G63:H63")
                .Merge()
                .Value = "WBC :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("I63:J63")
                .Merge()
                .Value = tab3_txt_wbc.Text + "  Cells/HP"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("G64:H64")
                .Merge()
                .Value = "Epi :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("I64:K64")
                .Merge()
                .Value = tab3_txt_epi.Text + "  Cells/HP"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B65:C65")
                .Merge()
                .Value = "Other :"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("B66:C66")
                .Merge()
                .Value = "สรุปผล :"
                .Font.Size = 14
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With


            With .Range("D66:K67")
                .Merge()
                .Value = tab3_txt_comment.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .WrapText = True
            End With


            With .Range("B69:D69")
                .Merge()
                .Value = "Medical Examination Report"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With
            With .Range("E69:H69")
                .Merge()
                .NumberFormat = "@"
                .Value = "4/6"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With




            With .Range("B70:K70")
                .Merge()
                .Value = "ตรวจร่างกาย (Physical Examination)"
                .Font.Size = 14
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B71:K72")
                .Merge()
                .Value = tab4_result_phy.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .WrapText = True
            End With




            With .Range("B73:K73")
                .Merge()
                .Value = "เอกซเรย์ทรวงอกเพื่อดูสภาพปอดและหัวใจ (Chest X-Ray)"
                .Font.Size = 14
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B74:K75")
                .Merge()
                .Value = tab4_result_x_ray.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .WrapText = True
            End With
            With .Range("B76:K76")
                .Merge()
                .Value = "การส่องกล้องตรวจลำไส้ใหญ่ ( COLONOSCOPY ) "
                .Font.Size = 14
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("B77:K78")
                .Merge()
                .Value = TextBox1.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .WrapText = True
            End With


            With .Range("B79:K79")
                .Merge()
                .Value = "ตรวจคลื่นไฟฟ้าหัวใจ (EKG)"
                .Font.Size = 14
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("B80:K81")
                .Merge()
                .Value = tab4_result_ekg.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .WrapText = True
            End With



            With .Range("B89:D89")
                .Merge()
                .Value = "Medical Examination Report"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With

            With .Range("E89:H89")
                .Merge()
                .NumberFormat = "@"
                .Value = "5/6"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With

            With .Range("B90:K90")
                .Merge()
                .Value = "ตรวจวิเคราะห์สารเคมีในเลือด (Blood Chemistry)"
                .Font.Size = 14
                .Font.Bold = True
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With




            With .Range("B91:K91")
                .Merge()
                .Value = "ตรวจสมรรถภาพการทำงานของไต (BUN)"
                .Font.Bold = True
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B92:C92")
                .Merge()
                .Value = "ผล(Result)"
                .Font.Size = 14

                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("D92")
                .Merge()
                If IsNumeric(tab5_txt_bun.Text) Then
                    If tab5_txt_bun.Text.Length > 1 Then
                        If CDbl(tab5_txt_bun.Text) > 20 And IsNumeric(tab5_txt_bun.Text) Then
                            .Font.Bold = True
                        Else
                            .Font.Bold = False
                        End If
                    End If
                End If
                .Value = tab5_txt_bun.Text
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("E92")
                .Merge()
                .Value = "mg/dl"
                .Font.Size = 14

                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("F92:H92")
                .Merge()
                .Value = "ค่าปกติ(Normal Value)"
                .Font.Size = 14

                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("I92:J92")
                .Merge()
                .NumberFormat = "@"
                .Value = "7.0-20.0"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("K92")
                .Merge()
                .NumberFormat = "@"
                .Value = "mg/dl"
                .Font.Size = 14

                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("B93:K96")
                .Merge()
                If IsNumeric(tab5_txt_bun.Text) Then
                    .Font.Size = 14
                    If tab5_txt_bun.Text.Length > 1 Then
                        If CDbl(tab5_txt_bun.Text) > 20 And IsNumeric(tab5_txt_bun.Text) Then
                            .Font.Bold = True

                        Else

                        End If
                    End If
                End If
                .Value = tab5_result_bun.Text

                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .WrapText = True
            End With


            With .Range("B97:K97")
                .Merge()
                .Value = "ตรวจสมรรถภาพการทำงานของไต (Creatinine)"
                .Font.Bold = True
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B98:C98")
                .Merge()
                .Value = "ผล(Result)"
                .Font.Size = 14

                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("D98")
                .Merge()
                .Value = tab5_txt_creatinine.Text
                .Font.Size = 14
                If IsNumeric(tab5_txt_creatinine.Text) Then
                    If tab5_txt_creatinine.Text.Length > 1 Then
                        If CDbl(tab5_txt_creatinine.Text) > 1.5 And IsNumeric(tab5_txt_creatinine.Text) Then
                            .Font.Bold = True
                        Else
                            .Font.Bold = False
                        End If
                    End If

                End If

                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("E98")
                .Merge()
                .Value = "mg/dl"
                .Font.Size = 14

                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("F98:H98")
                .Merge()
                .Value = "ค่าปกติ(Normal Value)"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("I98:J98")
                .Merge()
                .NumberFormat = "@"
                .Value = "0.7-1.5"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("K98")
                .Merge()
                .NumberFormat = "@"
                .Value = "mg/dl"
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("B99:K102")
                .Merge()
                If IsNumeric(tab5_txt_creatinine.Text) Then
                    If tab5_txt_creatinine.Text.Length > 1 Then
                        If CDbl(tab5_txt_creatinine.Text) > 1.5 And IsNumeric(tab5_txt_creatinine.Text) Then
                            .Font.Bold = True
                            .Font.Size = 14
                        Else

                            .Font.Size = 14
                        End If
                    End If
                End If


                .Value = tab5_result_creatinine.Text

                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .WrapText = True
            End With


            With .Range("B116:D116")
                .Merge()
                .Value = "Medical Examination Report"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With
            With .Range("E116:H116")
                .Merge()
                .NumberFormat = "@"
                .Value = "6/6"
                .Font.Bold = True
                .Font.Size = 11
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            End With

            With .Range("B117:D117")
                .Merge()
                .Value = "สรุปผลการตรวจ :"
                .Font.Bold = True
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            With .Range("B118:K136")
                .Merge()
                .Value = RichTextBox2.Text
                .Font.Bold = True
                .Font.Size = 14
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            End With



            With .Range("B137:K137")
                .Merge()
                .Value = "ลายเซ็นแพทย์ผู้ตรวจ................................................."
                .Font.Bold = True
                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            End With


            With .Range("B138:K138")
                .Merge()
                .Value = "แพทย์:  " + txt_doctor_name.Text
                .Font.Bold = True
                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            End With

            With .Range("B139:K139")
                .Merge()
                .Value = "ลายเซ็นพยาบาลผู้ตรวจทาน........................................"
                .Font.Bold = True
                .Font.Size = 15
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            End With
            With .Range("B140:K140")
                .Merge()
                .Value = "มีข้อสงสัยเกี่ยวกับผลตรวจสุขภาพกรุณาติดต่อ 0-7420-0250 , 0-7420-0273"
                .Font.Bold = True
                .Font.Size = 12
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .Interior.Color = RGB(128, 128, 128)
            End With
            With .Range("B141:K141")
                .Merge()
                .Value = "เวลา 8.00 น. - 17.00 น."
                .Font.Bold = True
                .Font.Size = 12
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                .Interior.Color = RGB(128, 128, 128)
            End With


        End With



        Try
            excelbooks.SaveAs(pathExcel.ToString + "\" + txt_name.Text + "The Colonoscopy" + ".xlsx")

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

    End Sub
    Private Sub frmpackage_extra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("th-TH")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
        Dim string_redcell As String = ""
        clear()

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mysql_ryh = New MySqlConnection
        mysql_ryh.ConnectionString = "server=ryh1;user id=june;password=software;database=rajyindee_db;Character Set=utf8;"

        Try
            mysql_ryh.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try


        If mysql_ryh.State = ConnectionState.Closed Then
            mysql_ryh.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM name_doctor;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql_ryh
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            listview1.Items.Clear()

            While (mySqlReader.Read())

                With listview1.Items.Add(mySqlReader("license"))
                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("name_eng"))


                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql_ryh.Close()
        count_result = 1
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=" + ipconnect + ";user id=" + usernamedb + ";password=" + mysqlpass + ";database=" + dbname + ";Character Set =utf8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try

        clear()

        If id_hn <> "0" And export_id <> "0" Then
            txtsearch.Text = id_hn
            Dim amp As String
            Dim prv As String
            Dim tmp As String
            Dim zipcode As String


            Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
            'Open the connection
            Try
                MyODBCConnection.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            ' Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT * FROM REGMASV5PF WHERE RMSHNNO='7708' and RMSHNYR = '56'")
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT * FROM REGDETV5PF WHERE RDTHN = '" & id_hn & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    address_text = dr.GetString(2).Trim

                    txt_tell.Text = dr.GetString(9).Trim

                    amp = dr.GetString(4)
                    prv = dr.GetString(3)
                    tmp = dr.GetString(5)
                    zipcode = dr.GetString(6)
                    'End the loop
                End While
                'Reset the cursor


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


            MyODBCConnection.Close()

            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If

            selectCMD = New OdbcCommand("SELECT TPVPRVNAM,TMPAMPNAM,TBNTBNNAM FROM TABPRVV5PF,TABAMPV5PF,TABTBNV5PF WHERE TABPRVV5PF.TPVPRVCOD = TABAMPV5PF.TMPPRVCOD AND TABAMPV5PF.TMPAMPCOD = TABTBNV5PF.TBNAMPCOD AND TABAMPV5PF.TMPPRVCOD = TABTBNV5PF.TBNPRVCOD AND (TABAMPV5PF.TMPPRVCOD = '" & prv & "') AND (TABTBNV5PF.TBNTBNCOD = '" & tmp & "') AND (TABAMPV5PF.TMPAMPCOD = '" & amp & "')")

            selectCMD.Connection = MyODBCConnection




            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    If dr.GetString(2) IsNot DBNull.Value Then
                        address_text = address_text + " ตำบล " + dr.GetString(2).Trim

                    End If
                    If dr.GetString(1) IsNot DBNull.Value Then

                        address_text = address_text + " อำเภอ " + dr.GetString(1).Trim

                    End If
                    If dr.GetString(0) IsNot DBNull.Value Then
                        address_text = address_text + " จังหวัด " + dr.GetString(0).Trim

                    End If

                    address_text = address_text + " " + zipcode
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            txt_address.Text = address_text
            MyODBCConnection.Close()



            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.CommandText = "Select * from checkup_export where hn like '" + id_hn + "' and checkup_export_id like '" + export_id + "' ;"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader

                While mySqlReader.Read()
                    txt_name.Text = "คุณ " + mySqlReader("f_name") + " " + mySqlReader("l_name")
                    If mySqlReader("sex_code") = "3" Then
                        txt_sex.Text = "หญิง (Female)"
                    Else
                        txt_sex.Text = "ชาย (Male)"
                    End If
                    txt_age.Text = mySqlReader("age_y")
                    txt_date.Text = mySqlReader("export_date")

                    'tab2

                    If mySqlReader("R17") Is "Normal" Then

                        tab2_txt_redcell.Text = "อยู่ในเกณฑ์ปกติ(Normal Value)"

                    ElseIf mySqlReader("R17") Is DBNull.Value Then

                        If mySqlReader("R18") Is DBNull.Value Then

                        Else
                            If mySqlReader("R18") = "Few" Then
                                string_redcell = string_redcell + "Hypochromia-" + mySqlReader("R18") + ","
                            Else
                                string_redcell = string_redcell + "Hypochromia " + mySqlReader("R18") + ","
                            End If
                        End If

                        If mySqlReader("R19") Is DBNull.Value Then

                        Else
                            If mySqlReader("R19") = "Few" Then
                                string_redcell = string_redcell + "Anisocytosis-" + mySqlReader("R19") + ","
                            Else
                                string_redcell = string_redcell + "Anisocytosis " + mySqlReader("R19") + ","
                            End If

                        End If
                        If mySqlReader("R20") Is DBNull.Value Then
                        Else
                            If mySqlReader("R20") = "Few" Then
                                string_redcell = string_redcell + "Microcyte-" + mySqlReader("R20") + ","
                            Else
                                string_redcell = string_redcell + "Microcyte " + mySqlReader("R20") + ","
                            End If

                        End If
                        If mySqlReader("R21") Is DBNull.Value Then
                        Else
                            If mySqlReader("R21") = "Few" Then
                                string_redcell = string_redcell + "Macrocyte-" + mySqlReader("R21") + ","
                            Else
                                string_redcell = string_redcell + "Macrocyte " + mySqlReader("R21") + ","
                            End If
                        End If
                        If mySqlReader("R22") Is DBNull.Value Then
                        Else
                            If mySqlReader("R22") = "Few" Then
                                string_redcell = string_redcell + "Poikilocytosis-" + mySqlReader("R22") + ","
                            Else
                                string_redcell = string_redcell + "Poikilocytosis " + mySqlReader("R22") + ","
                            End If


                        End If
                        If mySqlReader("R23") Is DBNull.Value Then
                        Else
                            If mySqlReader("R23") = "Few" Then
                                string_redcell = string_redcell + "Ovalocyte-" + mySqlReader("R22") + ","
                            Else
                                string_redcell = string_redcell + "Ovalocyte " + mySqlReader("R22") + ","
                            End If
                        End If

                        If mySqlReader("R24") Is DBNull.Value Then
                        Else
                            If mySqlReader("R24") = "Few" Then
                                string_redcell = string_redcell + "Schistocyte-" + mySqlReader("R24") + ","
                            Else
                                string_redcell = string_redcell + "Schistocyte " + mySqlReader("R24") + ","
                            End If
                        End If
                        If mySqlReader("R25") Is DBNull.Value Then
                        Else
                            If mySqlReader("R25") = "Few" Then
                                string_redcell = string_redcell + "Burr-" + mySqlReader("R25") + ","
                            Else
                                string_redcell = string_redcell + "Burr " + mySqlReader("R25") + ","
                            End If
                        End If
                        If mySqlReader("R26") Is DBNull.Value Then
                        Else
                            If mySqlReader("R26") = "Few" Then
                                string_redcell = string_redcell + "Target Cell-" + mySqlReader("R26") + ","
                            Else
                                string_redcell = string_redcell + "Target Cell " + mySqlReader("R26") + ","
                            End If

                        End If
                        If mySqlReader("R27") Is DBNull.Value Then
                        Else
                            If mySqlReader("R27") = "Few" Then
                                string_redcell = string_redcell + "Polychromasia-" + mySqlReader("R27") + ","
                            Else
                                string_redcell = string_redcell + "Polychromasia " + mySqlReader("R27") + ","
                            End If

                        End If
                        If mySqlReader("R28") Is DBNull.Value Then
                        Else
                            If mySqlReader("R28") = "Few" Then
                                string_redcell = string_redcell + "Basophilic-" + mySqlReader("R28") + ","
                            Else
                                string_redcell = string_redcell + "Basophilic " + mySqlReader("R28") + ","
                            End If

                        End If



                        tab2_txt_redcell.Text = string_redcell
                    End If


                    If mySqlReader("R79") Is DBNull.Value Then
                        tab2_txt_groupblood.Text = "-"
                        tab2_txt_groupblood.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_groupblood.Text = mySqlReader("R79")

                    End If
                    If mySqlReader("R80") Is DBNull.Value Then
                        tab2_txt_rh.Text = "-"
                        tab2_txt_rh.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_rh.Text = mySqlReader("R80")

                    End If


                    If mySqlReader("R3") Is DBNull.Value Then
                        tab2_txt_hb.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_hb.Text = mySqlReader("R3")


                        Dim txt_hb As Double

                        If IsNumeric(tab2_txt_hb.Text) Then
                            txt_hb = Double.Parse(tab2_txt_hb.Text)
                            If txt_hb < 12.0 Then
                                result_redmorphology = result_redmorphology + "ตรวจความสมบูรณ์ของเม็ดเลือด มีภาวะโลหิตจาง ควรปรึกษาแพทย์เพื่อตรวจหาสาเหตุเพิ่มเติม" + Environment.NewLine

                            End If
                        End If
                    End If
                    If mySqlReader("R4") Is DBNull.Value Then
                        tab2_txt_hct.Text = "-"
                        tab2_txt_hct.BackColor = Color.DarkSeaGreen
                    Else

                        tab2_txt_hct.Text = mySqlReader("R4")

                    End If
                    If mySqlReader("R1") Is DBNull.Value Then
                        tab2_txt_wbc.BackColor = Color.DarkSeaGreen
                    Else

                        tab2_txt_wbc.Text = mySqlReader("R1")
                        Dim txt_wbc As Double

                        If IsNumeric(tab2_txt_wbc.Text) Then
                            txt_wbc = Double.Parse(tab2_txt_wbc.Text)
                            If txt_wbc > 10.0 Then
                                result_redmorphology = result_redmorphology + "เม็ดเลือดขาวสูงกว่าปกติ อาจมีการอักเสบหรือติดเชื่อในร่างกาย ควรตรวจซ้ำ" + Environment.NewLine
                            ElseIf txt_wbc > 3.5 And txt_wbc < 4.9 Then
                                result_redmorphology = result_redmorphology + "ต่ำกว่าเกณฑ์ปกติเล็กน้อย ควรติดตาม" + Environment.NewLine
                            ElseIf txt_wbc <= 3.5 Then
                                result_redmorphology = result_redmorphology + "ต่ำกว่าเกณฑ์ปกติ แนะนำปรึกษาแพทย์" + Environment.NewLine
                            End If
                        End If

                    End If
                    If mySqlReader("R15") Is DBNull.Value Then
                        tab2_txt_atypical.Text = "-"
                        tab2_txt_atypical.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_atypical.Text = mySqlReader("R15")

                    End If

                    If mySqlReader("R14") Is DBNull.Value Then
                        tab2_txt_bashophils.Text = "-"

                        tab2_txt_bashophils.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_bashophils.Text = mySqlReader("R14")
                    End If

                    If mySqlReader("R13") Is DBNull.Value Then
                        tab2_txt_eosinophils.Text = "-"
                        tab2_txt_eosinophils.BackColor = Color.DarkSeaGreen
                    Else

                        tab2_txt_eosinophils.Text = mySqlReader("R13")
                    End If

                    If mySqlReader("R11") Is DBNull.Value Then
                        tab2_txt_lymphocytes.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_lymphocytes.Text = mySqlReader("R11")
                    End If

                    If mySqlReader("R12") Is DBNull.Value Then
                        tab2_txt_monocytes.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_monocytes.Text = mySqlReader("R12")
                    End If

                    If mySqlReader("R10") Is DBNull.Value Then
                        tab2_txt_neutrophils.Text = "-"
                        tab2_txt_neutrophils.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_neutrophils.Text = mySqlReader("R10")
                    End If


                    If mySqlReader("R8") Is DBNull.Value Then
                        tab2_txt_plate.Text = "-"
                        tab2_txt_plate.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_plate.Text = mySqlReader("R8")
                    End If


                    ' tab3


                    If mySqlReader("R32") Is DBNull.Value Then
                        tab3_txt_color.Text = "-"
                        tab3_txt_color.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_color.Text = mySqlReader("R32")
                    End If


                    If mySqlReader("R33") Is DBNull.Value Then
                        tab3_txt_appearance.Text = "-"
                        tab3_txt_appearance.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_appearance.Text = mySqlReader("R33")
                    End If

                    If mySqlReader("R34") Is DBNull.Value Then
                        tab3_txt_spgr.Text = "-"
                        tab3_txt_spgr.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_spgr.Text = mySqlReader("R34")
                    End If
                    If mySqlReader("R36") Is DBNull.Value Then
                        tab3_txt_albumin.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_albumin.Text = mySqlReader("R36")
                    End If

                    If mySqlReader("R37") Is DBNull.Value Then
                        tab3_txt_glucose.Text = "-"
                        tab3_txt_glucose.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_glucose.Text = mySqlReader("R37")
                    End If


                    If mySqlReader("R41") Is DBNull.Value Then

                        tab3_txt_blood.Text = "-"
                        tab3_txt_blood.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_blood.Text = mySqlReader("R41")
                    End If

                    If mySqlReader("R35") Is DBNull.Value Then
                        tab3_txt_ph.Text = "-"
                        tab3_txt_ph.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_ph.Text = mySqlReader("R35")
                    End If


                    If mySqlReader("R44") Is DBNull.Value Then
                        tab3_txt_rbc.Text = "-"
                        tab3_txt_rbc.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_rbc.Text = mySqlReader("R44")
                    End If


                    If mySqlReader("R45") Is DBNull.Value Then
                        tab3_txt_wbc.Text = "-"
                        tab3_txt_wbc.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_wbc.Text = mySqlReader("R45")
                    End If


                    If mySqlReader("R46") Is DBNull.Value Then
                        tab3_txt_epi.Text = "-"
                        tab3_txt_epi.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_epi.Text = mySqlReader("R46")
                    End If
                    'tab5
                    If mySqlReader("R55") Is DBNull.Value Then
                        tab5_txt_bun.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_bun.Text = mySqlReader("R55")
                        If IsNumeric(tab5_txt_bun.Text) Then
                            Dim int_bun As Integer
                            int_bun = Integer.Parse(tab5_txt_bun.Text)
                            tab5_txt_bun.Text = int_bun

                            If int_bun >= 7 And int_bun <= 20 Then
                                tab5_result_bun.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_bun > 20 Then
                                If check_sub = 0 Then
                                    tab5_result_bun.Text = "การทำงานของไตสูงกว่าปกติ แนะนำ ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_bun.Text = "The hardness of renal function Follow up every year"
                                End If
                            ElseIf int_bun < 7 Then
                                If check_sub = 0 Then
                                    tab5_result_bun.Text = "ไม่มีผลต่อการวินิจฉัย แนะนำ ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_bun.Text = "Non effect to diagnosis"
                                End If
                            End If
                        End If

                    End If


            

                    If mySqlReader("R56") Is DBNull.Value Then
                        tab5_txt_creatinine.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_creatinine.Text = mySqlReader("R56")
                        Dim int_creatinine As Double
                        If IsNumeric(tab5_txt_creatinine.Text) Then
                            int_creatinine = Double.Parse(tab5_txt_creatinine.Text)
                            tab5_txt_creatinine.Text = int_creatinine

                            If int_creatinine >= 0.7 And int_creatinine <= 1.5 Then
                                tab5_result_creatinine.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_creatinine > 1.5 Then
                                If check_sub = 0 Then

                                    tab5_result_creatinine.Text = "การทำงานของไตสูงกว่าปกติ แนะนำ ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_creatinine.Text = "Renal Insuffciency Follow up every year"

                                End If

                            ElseIf int_creatinine < 0.7 Then

                                If check_sub = 0 Then
                                    tab5_result_creatinine.Text = "ไม่มีผลต่อการวินิจฉัย แนะนำ ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_creatinine.Text = "Non effect to diagnosis"
                                End If
                            End If
                        End If

                    End If



                End While
                mysql.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


            Dim date_one As String
            Dim date_two As String
            Dim date_time1() As String
            Dim date_new As String

            date_time1 = Split(txt_date.Text, "/")
            date_one = Trim(date_time1(0).ToString)
            date_two = Trim(date_time1(1).ToString)
            If date_one.Length = 1 Then
                date_one = "0" + date_one
            End If
            If date_two.Length = 1 Then
                date_two = "0" + date_two
            End If

            date_new = date_time1(2).ToString + date_two + date_one
            MyODBCConnection.Close()
            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If


            selectCMD = New OdbcCommand("SELECT OPHRESULT,OPHOTHTYP,OPHOTHCOD FROM OPDOTHV5PF WHERE OPHREGDTE like '" & date_new & "' and OPHHN like '" & id_hn & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    If dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "01" Then
                        tab1_tab_weight.Text = dr.GetString(0).Trim
                    ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "03" Then
                        tab1_txt_height.Text = dr.GetString(0).Trim
                    ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "04" Then
                        tab1_txt_pulserate.Text = dr.GetString(0).Trim
                    ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "05" Then
                        tab1_txt_bloodp.Text = dr.GetString(0).Trim
                    End If
                    'End the loop
                End While
                'Reset the cursor


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MyODBCConnection.Close()
            bmi_cal()
        End If

    End Sub
    Private Sub clear()
        check_group = ""
        count_group = 1
        check_form = "0"
        under = " "
        tab1_txt_bmi.Text = " "

        tab1_txt_pulserate.Text = " "
        tab1_txt_bloodp.Text = "  "
        tab1_txt_height.Text = " "
        tab1_tab_weight.Text = " "
        result_all = " "
        urine_other = " "

        red_homology = " "
        address = " "
        export_date = " "
        tellephone = " "
        result_phy = " "
        result_hematology = " "
        result_urine = " "
        result_physical = " "
        result_xray = " "
        result_ultrasound = " "
        result_ekg = " "
        result_bloodchem = " "
        result_bun = " "
        result_creatinine = " "
        result_uricacid = " "
        result_cholesterol = " "
        result_triglyceride = " "
        result_hdl = " "
        result_ldl = " "
        result_sgot = " "
        result_sgpt = " "
        result_alkaline = " "
        result_afp = " "
        result_pfp = " "
        result_fbs = " "
        phy_height = "-"
        phy_weight = "-"
        phy_bmi = " "
        phy_bloodpressure = " "
        phy_pulse = " "
        phy_eye_left = " "
        phy_eye_right = " "
        phy_dental = " "
        tab2_redcell = " "


        tab1_result_pulse.Text = " "
        tab2_result_redmorphology.Text = " "
        tab2_result_platecount.Text = " "
        tab3_txt_comment.Text = " "
        tab4_result_phy.Text = " "
        tab4_result_ekg.Text = " "
        tab4_result_x_ray.Text = " "






        tab1_result_pulse.Text = " "


        'tab2 
        tab2_txt_hb.BackColor = Color.Empty
        tab2_txt_hct.BackColor = Color.Empty
        tab2_txt_atypical.BackColor = Color.Empty
        tab2_txt_bashophils.BackColor = Color.Empty
        tab2_txt_eosinophils.BackColor = Color.Empty
        tab2_txt_groupblood.BackColor = Color.Empty
        tab2_txt_lymphocytes.BackColor = Color.Empty
        tab2_txt_neutrophils.BackColor = Color.Empty
        tab2_txt_plate.BackColor = Color.Empty
        tab2_txt_redcell.BackColor = Color.Empty
        tab2_txt_wbc.BackColor = Color.Empty
        tab2_txt_monocytes.BackColor = Color.Empty

        tab2_txt_monocytes.Text = " "
        tab2_txt_wbc.Text = " "
        tab2_txt_rh.Text = " "
        tab2_txt_wbc.Text = " "
        tab2_txt_hb.Text = " "
        tab2_txt_hct.Text = " "
        tab2_txt_atypical.Text = " "
        tab2_txt_bashophils.Text = " "
        tab2_txt_eosinophils.Text = " "
        tab2_txt_groupblood.Text = " "
        tab2_txt_lymphocytes.Text = " "
        tab2_txt_neutrophils.Text = " "
        tab2_txt_plate.Text = " "
        tab2_txt_redcell.Text = " "
        tab2_txt_rh.Text = " "
        tab2_txt_wbc.Text = " "



        'tab 3
        tab3_txt_albumin.BackColor = Color.Empty
        tab3_txt_albumin.Text = " "

        tab3_txt_appearance.BackColor = Color.Empty
        tab3_txt_appearance.Text = " "

        tab3_txt_blood.BackColor = Color.Empty
        tab3_txt_blood.Text = " "

        tab3_txt_color.BackColor = Color.Empty
        tab3_txt_color.Text = " "

        tab3_txt_comment.BackColor = Color.Empty
        tab3_txt_comment.Text = " "

        tab3_txt_epi.BackColor = Color.Empty
        tab3_txt_epi.Text = " "

        tab3_txt_glucose.BackColor = Color.Empty
        tab3_txt_glucose.Text = " "

        tab3_txt_other.BackColor = Color.Empty
        tab3_txt_other.Text = "-"

        tab3_txt_ph.BackColor = Color.Empty
        tab3_txt_ph.Text = " "

        tab3_txt_rbc.BackColor = Color.Empty
        tab3_txt_rbc.Text = " "

        tab3_txt_spgr.BackColor = Color.Empty
        tab3_txt_spgr.Text = " "

        tab3_txt_wbc.BackColor = Color.Empty

        tab3_txt_wbc.Text = " "
        tab3_txt_comment.Text = " "
        tab4_result_ekg.Text = " "

        tab4_result_phy.Text = " "

        tab4_result_x_ray.Text = " "

        tab5_txt_bun.BackColor = Color.Empty
        tab5_txt_bun.Text = " "
        tab5_result_bun.Text = " "

        tab5_txt_creatinine.BackColor = Color.Empty
        tab5_txt_creatinine.Text = " "
        tab5_result_creatinine.Text = " "
      
  


        Me.Refresh()
    End Sub
    Public Sub bmi_cal()
        Dim height As Double
        Dim weight As Double
        Dim result As Double



        If tab1_tab_weight.Text <> " " And tab1_txt_height.Text <> " " Then
            height = CDbl(tab1_txt_height.Text.Trim)
            weight = CDbl(tab1_tab_weight.Text.Trim)
            height = height / 100
            weight = weight / height
            weight = weight / height

            tab1_txt_bmi.Text = Format(weight, "##.##")
        End If
    End Sub
    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown


        Dim string_count As Integer = 0
        Dim string_redcell As String = " "

        count_result = 1
        If e.KeyCode = "13" Then
            result_all = ""
            clear()
            id_hn = txtsearch.Text
            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader
            Dim amp As String
            Dim prv As String
            Dim tmp As String
            Dim zipcode As String


            Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
            'Open the connection
            Try
                MyODBCConnection.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            ' Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT * FROM REGMASV5PF WHERE RMSHNNO='7708' and RMSHNYR = '56'")
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT * FROM REGDETV5PF WHERE RDTHN = '" & id_hn & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    address_text = dr.GetString(2).Trim

                    txt_tell.Text = dr.GetString(9).Trim

                    amp = dr.GetString(4)
                    prv = dr.GetString(3)
                    tmp = dr.GetString(5)
                    zipcode = dr.GetString(6)
                    'End the loop
                End While
                'Reset the cursor


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


            MyODBCConnection.Close()

            If MyODBCConnection.State = ConnectionState.Closed Then
                MyODBCConnection.Open()
            End If

            selectCMD = New OdbcCommand("SELECT TPVPRVNAM,TMPAMPNAM,TBNTBNNAM FROM TABPRVV5PF,TABAMPV5PF,TABTBNV5PF WHERE TABPRVV5PF.TPVPRVCOD = TABAMPV5PF.TMPPRVCOD AND TABAMPV5PF.TMPAMPCOD = TABTBNV5PF.TBNAMPCOD AND TABAMPV5PF.TMPPRVCOD = TABTBNV5PF.TBNPRVCOD AND (TABAMPV5PF.TMPPRVCOD = '" & prv & "') AND (TABTBNV5PF.TBNTBNCOD = '" & tmp & "') AND (TABAMPV5PF.TMPAMPCOD = '" & amp & "')")

            selectCMD.Connection = MyODBCConnection




            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    If dr.GetString(2) IsNot DBNull.Value Then
                        address_text = address_text + " ตำบล " + dr.GetString(2).Trim

                    End If
                    If dr.GetString(1) IsNot DBNull.Value Then

                        address_text = address_text + " อำเภอ " + dr.GetString(1).Trim

                    End If
                    If dr.GetString(0) IsNot DBNull.Value Then
                        address_text = address_text + " จังหวัด " + dr.GetString(0).Trim

                    End If

                    address_text = address_text + " " + zipcode
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            txt_address.Text = address_text
            MyODBCConnection.Close()


            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            mySqlCommand.CommandText = "Select * from checkup_export where hn like '" + txtsearch.Text + "';"
            mySqlCommand.Connection = mysql
            mySqlAdaptor.SelectCommand = mySqlCommand


            mySqlReader = mySqlCommand.ExecuteReader
            While mySqlReader.Read()
                string_count = string_count + 1

            End While
            mysql.Close()


            If string_count = 1 Then


                If mysql.State = ConnectionState.Closed Then
                    mysql.Open()
                End If
                mySqlCommand.CommandText = "Select * from checkup_export where hn like '" + txtsearch.Text + "';"
                mySqlCommand.Connection = mysql
                mySqlAdaptor.SelectCommand = mySqlCommand

                mySqlReader = mySqlCommand.ExecuteReader
                While mySqlReader.Read()

                    txt_name.Text = "คุณ " + mySqlReader("f_name") + " " + mySqlReader("l_name")
                    If mySqlReader("sex_code") = "3" Then
                        txt_sex.Text = "หญิง (Female)"
                    Else
                        txt_sex.Text = "ชาย (Male)"
                    End If

                    txt_age.Text = mySqlReader("age_y")
                    txt_date.Text = mySqlReader("export_date")

                    'tab2

                    If mySqlReader("R17") Is "Normal" Then

                        tab2_txt_redcell.Text = "อยู่ในเกณฑ์ปกติ(Normal Value)"

                    ElseIf mySqlReader("R17") Is DBNull.Value Then


                        If mySqlReader("R18") Is DBNull.Value Then

                        Else
                            If mySqlReader("R18") = "Few" Then
                                string_redcell = string_redcell + "Hypochromia-" + mySqlReader("R18") + ","
                            Else
                                string_redcell = string_redcell + "Hypochromia " + mySqlReader("R18") + ","
                            End If
                        End If

                        If mySqlReader("R19") Is DBNull.Value Then

                        Else
                            If mySqlReader("R19") = "Few" Then
                                string_redcell = string_redcell + "Anisocytosis-" + mySqlReader("R19") + ","
                            Else
                                string_redcell = string_redcell + "Anisocytosis " + mySqlReader("R19") + ","
                            End If

                        End If
                        If mySqlReader("R20") Is DBNull.Value Then
                        Else
                            If mySqlReader("R20") = "Few" Then
                                string_redcell = string_redcell + "Microcyte-" + mySqlReader("R20") + ","
                            Else
                                string_redcell = string_redcell + "Microcyte " + mySqlReader("R20") + ","
                            End If

                        End If
                        If mySqlReader("R21") Is DBNull.Value Then
                        Else
                            If mySqlReader("R21") = "Few" Then
                                string_redcell = string_redcell + "Macrocyte-" + mySqlReader("R21") + ","
                            Else
                                string_redcell = string_redcell + "Macrocyte " + mySqlReader("R21") + ","
                            End If
                        End If
                        If mySqlReader("R22") Is DBNull.Value Then
                        Else
                            If mySqlReader("R22") = "Few" Then
                                string_redcell = string_redcell + "Poikilocytosis-" + mySqlReader("R22") + ","
                            Else
                                string_redcell = string_redcell + "Poikilocytosis " + mySqlReader("R22") + ","
                            End If


                        End If
                        If mySqlReader("R23") Is DBNull.Value Then
                        Else
                            If mySqlReader("R23") = "Few" Then
                                string_redcell = string_redcell + "Ovalocyte-" + mySqlReader("R22") + ","
                            Else
                                string_redcell = string_redcell + "Ovalocyte " + mySqlReader("R22") + ","
                            End If
                        End If

                        If mySqlReader("R24") Is DBNull.Value Then
                        Else
                            If mySqlReader("R24") = "Few" Then
                                string_redcell = string_redcell + "Schistocyte-" + mySqlReader("R24") + ","
                            Else
                                string_redcell = string_redcell + "Schistocyte " + mySqlReader("R24") + ","
                            End If
                        End If
                        If mySqlReader("R25") Is DBNull.Value Then
                        Else
                            If mySqlReader("R25") = "Few" Then
                                string_redcell = string_redcell + "Burr-" + mySqlReader("R25") + ","
                            Else
                                string_redcell = string_redcell + "Burr " + mySqlReader("R25") + ","
                            End If
                        End If
                        If mySqlReader("R26") Is DBNull.Value Then
                        Else
                            If mySqlReader("R26") = "Few" Then
                                string_redcell = string_redcell + "Target Cell-" + mySqlReader("R26") + ","
                            Else
                                string_redcell = string_redcell + "Target Cell " + mySqlReader("R26") + ","
                            End If

                        End If
                        If mySqlReader("R27") Is DBNull.Value Then
                        Else
                            If mySqlReader("R27") = "Few" Then
                                string_redcell = string_redcell + "Polychromasia-" + mySqlReader("R27") + ","
                            Else
                                string_redcell = string_redcell + "Polychromasia " + mySqlReader("R27") + ","
                            End If

                        End If
                        If mySqlReader("R28") Is DBNull.Value Then
                        Else
                            If mySqlReader("R28") = "Few" Then
                                string_redcell = string_redcell + "Basophilic-" + mySqlReader("R28") + ","
                            Else
                                string_redcell = string_redcell + "Basophilic " + mySqlReader("R28") + ","
                            End If

                        End If



                        tab2_txt_redcell.Text = string_redcell
                    End If
                    If mySqlReader("R79") Is DBNull.Value Then
                        tab2_txt_groupblood.Text = "-"
                        tab2_txt_groupblood.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_groupblood.Text = mySqlReader("R79")

                    End If
                    If mySqlReader("R80") Is DBNull.Value Then
                        tab2_txt_rh.Text = "-"
                        tab2_txt_rh.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_rh.Text = mySqlReader("R80")

                    End If

                    If mySqlReader("R3") Is DBNull.Value Then
                        tab2_txt_hb.Text = "-"
                        tab2_txt_hb.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_hb.Text = mySqlReader("R3")

                        Dim txt_hb As Double

                        If IsNumeric(tab2_txt_hb.Text) Then
                            txt_hb = Double.Parse(tab2_txt_hb.Text)
                            If txt_hb < 12.0 Then
                                result_redmorphology = result_redmorphology + "ตรวจความสมบูรณ์ของเม็ดเลือด มีภาวะโลหิตจาง ควรปรึกษาแพทย์เพื่อตรวจหาสาเหตุเพิ่มเติม" + Environment.NewLine
                                ComboBox3.Text = "2.ผิดปกติ"
                            End If
                        End If
                    End If



                    If mySqlReader("R4") Is DBNull.Value Then
                        tab2_txt_hct.Text = "-"
                        tab2_txt_hct.BackColor = Color.DarkSeaGreen
                    Else

                        tab2_txt_hct.Text = mySqlReader("R4")

                    End If
                    If mySqlReader("R1") Is DBNull.Value Then
                        tab2_txt_wbc.Text = "-"
                        tab2_txt_wbc.BackColor = Color.DarkSeaGreen
                    Else

                        tab2_txt_wbc.Text = mySqlReader("R1")
                        Dim txt_wbc As Double

                        If IsNumeric(tab2_txt_wbc.Text) Then
                            txt_wbc = Double.Parse(tab2_txt_wbc.Text)
                            If txt_wbc > 10.0 Then
                                result_redmorphology = result_redmorphology + "เม็ดเลือดขาวสูงกว่าปกติ อาจมีการอักเสบหรือติดเชื่อในร่างกาย ควรตรวจซ้ำ" + Environment.NewLine
                                ComboBox3.Text = "2.ผิดปกติ"
                            ElseIf txt_wbc > 3.5 And txt_wbc < 4.9 Then
                                ComboBox3.Text = "2.ผิดปกติ"
                                result_redmorphology = result_redmorphology + "ต่ำกว่าเกณฑ์ปกติเล็กน้อย ควรติดตาม" + Environment.NewLine
                            ElseIf txt_wbc <= 3.5 Then
                                ComboBox3.Text = "2.ผิดปกติ"
                                result_redmorphology = result_redmorphology + "ต่ำกว่าเกณฑ์ปกติ แนะนำปรึกษาแพทย์" + Environment.NewLine
                            End If
                        End If



                    End If
                    If mySqlReader("R15") Is DBNull.Value Then
                        tab2_txt_atypical.Text = "-"
                        tab2_txt_atypical.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_atypical.Text = mySqlReader("R15")

                    End If

                    If mySqlReader("R14") Is DBNull.Value Then
                        tab2_txt_bashophils.Text = "-"
                        tab2_txt_bashophils.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_bashophils.Text = mySqlReader("R14")
                    End If

                    If mySqlReader("R13") Is DBNull.Value Then
                        tab2_txt_eosinophils.Text = "-"
                        tab2_txt_eosinophils.BackColor = Color.DarkSeaGreen
                    Else

                        tab2_txt_eosinophils.Text = mySqlReader("R13")
                        Dim txt_eosin As Double

                        If IsNumeric(tab2_txt_eosinophils.Text) Then
                            txt_eosin = Double.Parse(tab2_txt_eosinophils.Text)
                            If txt_eosin > 10.0 Then
                                ComboBox3.Text = "2.ผิดปกติ"
                                result_redmorphology = result_redmorphology + "อาจเกิดจากภาวะภูมิแพ้ หรือมีพยาธิในอุจจาระ หลีกเลี่ยงสัมผัสสิ่งกระตุ้นการแพ้เช่น ไรฝุ่น" + Environment.NewLine

                            End If
                        End If



                    End If

                    If mySqlReader("R11") Is DBNull.Value Then
                        tab2_txt_lymphocytes.Text = "-"
                        tab2_txt_lymphocytes.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_lymphocytes.Text = mySqlReader("R11")
                    End If

                    If mySqlReader("R12") Is DBNull.Value Then
                        tab2_txt_monocytes.Text = "-"
                        tab2_txt_monocytes.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_monocytes.Text = mySqlReader("R12")
                    End If

                    If mySqlReader("R10") Is DBNull.Value Then
                        tab2_txt_neutrophils.Text = "-"
                        tab2_txt_neutrophils.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_neutrophils.Text = mySqlReader("R10")
                    End If


                    If mySqlReader("R8") Is DBNull.Value Then
                        tab2_txt_plate.Text = "-"
                        tab2_txt_plate.BackColor = Color.DarkSeaGreen
                    Else
                        tab2_txt_plate.Text = mySqlReader("R8")

                        Dim txt_plate As Double

                        If IsNumeric(tab2_txt_plate.Text) Then
                            txt_plate = Double.Parse(tab2_txt_plate.Text)
                            If txt_plate > 400 Then
                                resultplate = "เกล็ดเลือดสูง High platelet ตรวจซ้ำ " + Environment.NewLine
                            ElseIf txt_plate < 100 Then
                                resultplate = "เกล็ดเลือดต่ำ Low Platelet ปรึกษาแพทย์"
                            ElseIf txt_plate >= 100 And txt_plate <= 140 Then
                                resultplate = "เกล็ดเลือดต่ำ เล็กน้อย"
                            Else
                                resultplate = "อยู่ในเกณฑ์ปกติ (Normal)"
                            End If
                            tab2_result_platecount.Text = resultplate
                        End If



                    End If


                    ' tab3


                    If mySqlReader("R32") Is DBNull.Value Then
                        tab3_txt_color.Text = "-"
                        tab3_txt_color.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_color.Text = mySqlReader("R32")
                    End If


                    If mySqlReader("R33") Is DBNull.Value Then
                        tab3_txt_appearance.Text = "-"
                        tab3_txt_appearance.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_appearance.Text = mySqlReader("R33")
                    End If

                    If mySqlReader("R34") Is DBNull.Value Then
                        tab3_txt_spgr.Text = "-"
                        tab3_txt_spgr.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_spgr.Text = mySqlReader("R34")
                    End If
                    If mySqlReader("R36") Is DBNull.Value Then
                        tab3_txt_albumin.Text = "-"
                        tab3_txt_albumin.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_albumin.Text = mySqlReader("R36")
                    End If

                    If mySqlReader("R37") Is DBNull.Value Then
                        tab3_txt_glucose.Text = "-"
                        tab3_txt_glucose.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_glucose.Text = mySqlReader("R37")
                    End If


                    If mySqlReader("R41") Is DBNull.Value Then
                        tab3_txt_blood.Text = "-"
                        tab3_txt_blood.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_blood.Text = mySqlReader("R41")
                    End If

                    If mySqlReader("R35") Is DBNull.Value Then
                        tab3_txt_ph.Text = "-"
                        tab3_txt_ph.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_ph.Text = mySqlReader("R35")
                    End If


                    If mySqlReader("R44") Is DBNull.Value Then
                        tab3_txt_rbc.Text = "-"
                        tab3_txt_rbc.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_rbc.Text = mySqlReader("R44")
                    End If


                    If mySqlReader("R45") Is DBNull.Value Then
                        tab3_txt_wbc.Text = "-"
                        tab3_txt_wbc.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_wbc.Text = mySqlReader("R45")
                    End If


                    If mySqlReader("R46") Is DBNull.Value Then
                        tab3_txt_epi.Text = "-"
                        tab3_txt_epi.BackColor = Color.DarkSeaGreen
                    Else
                        tab3_txt_epi.Text = mySqlReader("R46")
                    End If




                    'tab5
                    If mySqlReader("R55") Is DBNull.Value Then
                        tab5_txt_bun.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_bun.Text = mySqlReader("R55")
                        Dim int_bun As Integer
                        If IsNumeric(tab5_txt_bun.Text) Then
                            int_bun = Integer.Parse(tab5_txt_bun.Text)
                            tab5_txt_bun.Text = int_bun

                            If int_bun >= 7 And int_bun <= 20 Then

                                tab5_result_bun.Text = "อยู่ในเกณฑ์ปกติ (Normal)"


                            ElseIf int_bun > 20 Then
                                If check_sub = 0 Then
                                    tab5_result_bun.Text = "การทำงานของไตสูงกว่าปกติ แนะนำ ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_bun.Text = "The hardness of renal function Follow up every year"
                                End If

                            ElseIf int_bun < 7 Then
                                If check_sub = 0 Then
                                    tab5_result_bun.Text = "ไม่มีผลต่อการวินิจฉัย แนะนำ ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_bun.Text = "Non effect to diagnosis"

                                End If

                            End If
                        End If

                    End If



                    If mySqlReader("R56") Is DBNull.Value Then
                        tab5_txt_creatinine.BackColor = Color.DarkSeaGreen
                    Else
                        tab5_txt_creatinine.Text = mySqlReader("R56")
                        Dim int_creatinine As Double
                        If IsNumeric(tab5_txt_creatinine.Text) Then
                            int_creatinine = Double.Parse(tab5_txt_creatinine.Text)
                            tab5_txt_creatinine.Text = int_creatinine

                            If int_creatinine >= 0.7 And int_creatinine <= 1.5 Then
                                tab5_result_creatinine.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
                            ElseIf int_creatinine > 1.5 Then
                                If check_sub = 0 Then

                                    tab5_result_creatinine.Text = "การทำงานของไตสูงกว่าปกติ แนะนำ ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_creatinine.Text = "Renal Insuffciency Follow up every year"

                                End If

                            ElseIf int_creatinine < 0.7 Then

                                If check_sub = 0 Then
                                    tab5_result_creatinine.Text = "ไม่มีผลต่อการวินิจฉัย แนะนำ ตรวจติดตามทุกปี"
                                ElseIf check_sub = 1 Then
                                    tab5_result_creatinine.Text = "Non effect to diagnosis"
                                End If
                            End If
                        End If

                    End If





                End While
                mysql.Close()
                Dim date_one As String
                Dim date_two As String
                Dim date_time1() As String
                Dim date_new As String

                date_time1 = Split(txt_date.Text, "/")
                date_one = Trim(date_time1(0).ToString)
                date_two = Trim(date_time1(1).ToString)
                If date_one.Length = 1 Then
                    date_one = "0" + date_one
                End If
                If date_two.Length = 1 Then
                    date_two = "0" + date_two
                End If

                date_new = date_time1(2).ToString + date_two + date_one
                MyODBCConnection.Close()
                If MyODBCConnection.State = ConnectionState.Closed Then
                    MyODBCConnection.Open()
                End If


                selectCMD = New OdbcCommand("SELECT OPHRESULT,OPHOTHTYP,OPHOTHCOD FROM OPDOTHV5PF WHERE OPHREGDTE like '" & date_new & "' and OPHHN like '" & id_hn & "'")

                selectCMD.Connection = MyODBCConnection


                Try
                    'Set the mouse to show a Wait cursor
                    Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                    'start the Read loop
                    While dr.Read
                        'Note: the numbers in double quotes represent the column number from the AS400 database
                        'Add the data to the list view
                        If dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "01" Then
                            tab1_tab_weight.Text = dr.GetString(0).Trim
                        ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "03" Then
                            tab1_txt_height.Text = dr.GetString(0).Trim
                        ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "04" Then
                            tab1_txt_pulserate.Text = dr.GetString(0).Trim
                        ElseIf dr.GetString(1).Trim = "01" And dr.GetString(2).Trim = "05" Then
                            tab1_txt_bloodp.Text = dr.GetString(0).Trim
                        End If
                        'End the loop
                    End While
                    'Reset the cursor


                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                MyODBCConnection.Close()
                bmi_cal()

            Else

                Dim NextForm As frmpackage4_1 = New frmpackage4_1(mysqlpass, ipconnect, usernamedb, dbname, txtsearch.Text)
                '  Dim NextForm As main_user = New main_user()
                NextForm.Show()
                Me.Close()


            End If
        End If






    End Sub
    Private Sub ComboBox22_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox22.SelectedIndexChanged
        If ComboBox22.Text = "1.ปกติ" Then
            tab1_result_pulse.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox22.Text = "2.ความดันโลหิตต่ำ" Then
            tab1_result_pulse.Text = "ความดันโลหิตต่ำ ควรพักผ่อนให้เพียงพอ และออกกำลังกายสม่ำเสมอ"
        ElseIf ComboBox22.Text = "3.ความดันโลหิตสูงเล็กน้อย" Then
            tab1_result_pulse.Text = "ความดันโลหิตสูงเล็กน้อย ควรลดอาหารเค็มและตรวจติดตาม"
        ElseIf ComboBox22.Text = "4.ความดันโลหิตสูง" Then
            tab1_result_pulse.Text = "ความดันโลหิตสูง ควรงดอาหารเค็ม และปรึกษาแพทย์เพื่อรับการรักษา"
        End If
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.Text = "1.ปกติ" Then
            tab4_result_ekg.Text = "อยู่ในเกณฑ์ปกติ (Normal)"
        ElseIf ComboBox6.Text = "2.หัวใจเต้นช้ากว่าปกติ" Then
            tab4_result_ekg.Text = "ตรวจคลื่นไฟฟ้าหัวใจ หัวใจเต้นช้ากว่าปกติ ควรสังเกตุอาการผิดปกเช่น หน้ามืด ปรึกษาแพทย์"
        ElseIf ComboBox6.Text = "3.หัวใจโตกว่าปกติ" Then
            tab4_result_ekg.Text = "ตรวจคลื่นไฟฟ้าหัวใจ หัวใจโตกว่าปกติ ปรึกษาแพทย์"
        ElseIf ComboBox6.Text = "4.การนำไฟฟ้าหัวใจซึกซ้ายช้ากว่าปกติ" Then
            tab4_result_ekg.Text = "ตรวจคลื่นไฟฟ้าหัวใจ การนำไฟฟ้าหัวใจซึกซ้ายช้ากว่าปกติ ปรึกษาอายุรแพทย์โรคหัวใจ"
        ElseIf ComboBox6.Text = "5.การนำไฟฟ้าหัวใจซีกขวาช้ากว่าปกติ" Then
            tab4_result_ekg.Text = "ตรวจคลื่นไฟฟ้าหัวใจ การนำไฟฟ้าหัวใจซีกขวาช้ากว่าปกติ ปรึกษาอายุรแพทย์โรคหัวใจ"
        ElseIf ComboBox6.Text = "6.สงสัยผนังกั้นห้องหัวใจรั่ว" Then
            tab4_result_ekg.Text = "ตรวจคลื่นไฟฟ้าหัวใจ สงสัยผนังกั้นห้องหัวใจรั่ว แนะนำพบแพทย์ตรวจเพิ่มเติม"
        End If
    End Sub
    Sub ChangFocus(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tab1_txt_height.KeyPress, tab1_tab_weight.KeyPress, tab1_txt_bmi.KeyPress, tab1_txt_pulserate.KeyPress, tab1_txt_bloodp.KeyPress, tab1_txt_eyer.KeyPress, tab1_txt_eyel.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub txt_search_doctor_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search_doctor.KeyDown
        If e.KeyCode = Keys.Enter Then
            search_data_name()
        End If
    End Sub
    Private Sub search_data_name()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        If mysql_ryh.State = ConnectionState.Closed Then
            mysql_ryh.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM name_doctor where name_thai like '%" & txt_search_doctor.Text & "%' or name_eng like '%" & txt_search_doctor.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql_ryh
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            listview1.Items.Clear()

            While (mySqlReader.Read())

                With listview1.Items.Add(mySqlReader("license"))
                    .SubItems.Add(mySqlReader("name_thai"))
                    .SubItems.Add(mySqlReader("name_eng"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql_ryh.Close()

    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txt_search_doctor.Text <> "" Then
            search_data_name()

        End If
    End Sub
    Private Sub listview1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listview1.Click

            txt_doctor_name.Text = listview1.SelectedItems(0).SubItems(1).Text
     

    End Sub
    Private Sub tab1_tab_weight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tab1_tab_weight.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If (e.KeyChar.ToString >= "A" And e.KeyChar.ToString <= "Z") Or (e.KeyChar.ToString >= "a" And e.KeyChar.ToString <= "z") Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(Keys.Enter) Then
                    bmi_cal()
                End If
            End If
        End If
    End Sub
    Private Sub tab1_txt_height_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tab1_txt_height.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If (e.KeyChar.ToString >= "A" And e.KeyChar.ToString <= "Z") Or (e.KeyChar.ToString >= "a" And e.KeyChar.ToString <= "z") Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(Keys.Enter) Then
                    bmi_cal()
                End If
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TabPageEX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageEX1.Click

    End Sub

    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick
        If ComboBox4.Text <> "1.ปกติ" Then
            resultphy = resultphy + ListView3.SelectedItems(0).SubItems(0).Text
            tab4_result_phy.Text = resultphy
        Else
            tab4_result_phy.Text = "อยู่ในเกณฑ์ปกติ(Normal)"
        End If

    End Sub

    Private Sub ListView4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView4.DoubleClick

        If ComboBox7.Text <> "1.ปกติ" Then
            resultxray = resultxray + ListView4.SelectedItems(0).SubItems(0).Text
            tab4_result_x_ray.Text = resultxray
        Else
            tab4_result_x_ray.Text = "อยู่ในเกณฑ์ปกติ(Normal)"
        End If
    End Sub
End Class