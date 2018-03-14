Option Explicit On

Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports System.Threading
Public Class frmnure_rpt
    Dim sql As MySqlConnection = frmmain_nurse.mysqlconection
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Public Delegate Sub DelegateSub(ByVal x As Integer)
    Dim stringDate() As String
    Dim count As Integer = 1
    Dim hdsum As Integer
    Dim roundcount As Integer



    Dim timedate As Integer = 15
    Dim ersum As Integer
    Dim subdate1() As String
    Dim subdate2() As String
    Dim date1 As Date
    Dim date2 As Date
    Dim diff1 As TimeSpan
    Dim valuedate As String
    Dim cenna As Integer
    Dim cenpn As Integer
    Dim cenrn As Integer
    Dim cenwc As Integer



    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        FolderBrowserDialog1.Description = "Pick Folder to store Excecl files"
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.SelectedPath = "C:\"
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try


                Dim t = New Thread(New ThreadStart(AddressOf excelDaily))
                t.Start()

                CircularProgress1.IsRunning = True


            Catch ex As Exception
                CircularProgress1.IsRunning = False
            End Try
        End If



    End Sub
    Private Sub excelDaily()
        Dim pathExcel As String
        Dim count As Integer = 11

        Dim countcontainer As Integer = 1
        pathExcel = FolderBrowserDialog1.SelectedPath
        Dim excelapp As New Excel.Application
        Dim excelbooks As Excel.Workbook
        Dim excelsheets As Excel.Worksheet
        Dim excelsheets2 As Excel.Worksheet
        Dim excelsheets3 As Excel.Worksheet


        excelbooks = excelapp.Workbooks.Add

        excelsheets = CType(excelbooks.Worksheets(1), Excel.Worksheet)
        excelsheets2 = CType(excelbooks.Worksheets(2), Excel.Worksheet)
        Dim ws As Excel.Worksheet
  
        excelsheets3 = CType(excelbooks.Worksheets(3), Excel.Worksheet)


        With excelsheets


            .Range("A1:S500").Font.Name = "Tahoma"
            .Range("A1:S500").Font.Size = 11
            .Range("A1").ColumnWidth = 5.0
            .Range("B1").ColumnWidth = 5.0
            .Range("C1").ColumnWidth = 9
            .Range("D1").ColumnWidth = 9.5
            .Range("E1").ColumnWidth = 4
            .Range("F1").ColumnWidth = 4
            .Range("G1").ColumnWidth = 4
            .Range("H1").ColumnWidth = 4
            .Range("I1").ColumnWidth = 4
            .Range("J1").ColumnWidth = 4
            .Range("K1").ColumnWidth = 4
            .Range("L1").ColumnWidth = 4
            .Range("M1").ColumnWidth = 4
            .Range("N1").ColumnWidth = 4
            .Range("O1").ColumnWidth = 9.25
            .Range("P1").ColumnWidth = 7.5

            .Rows("1:6").rowheight = 33
            .Rows("7:600").rowheight = 21
            For J = 7 To 10
                .Range("B5:B6").Borders(J).Weight = 2 ' xlThin
                .Range("C5:C6").Borders(J).Weight = 2 ' xlThin
                .Range("D5:D6").Borders(J).Weight = 2 ' xlThin
                .Range("E5:I5").Borders(J).Weight = 2 ' xlThin
                .Range("E6:E6").Borders(J).Weight = 2 ' xlThin
                .Range("F6:F6").Borders(J).Weight = 2 ' xlThin
                .Range("G6:G6").Borders(J).Weight = 2 ' xlThin
                .Range("H6:H6").Borders(J).Weight = 2 ' xlThin
                .Range("I6:I6").Borders(J).Weight = 2 ' xlThin
                .Range("J6:J6").Borders(J).Weight = 2 ' xlThin
                .Range("K6:K6").Borders(J).Weight = 2 ' xlThin
                .Range("L6:L6").Borders(J).Weight = 2 ' xlThin
                .Range("M6:M6").Borders(J).Weight = 2 ' xlThin
                .Range("N6:N6").Borders(J).Weight = 2 ' xlThin
                .Range("O5:O6").Borders(J).Weight = 2 ' xlThin
                .Range("P5:P6").Borders(J).Weight = 2 ' xlThin

                .Range("J5:N6").Borders(J).Weight = 2 ' xlThin

            Next

            .Range("B7:P15").Borders.Weight = 2 ' xlThin








            With .Range("B3:P3")
                .Merge()
                .Font.Size = 18
                .Value = "สรุปผลการประเมิน Productivity ทางการพยาบาล"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With



            With .Range("B4:P4")
                .Merge()
                .Font.Size = 18
                .Value = "วันที่ " + MaskedTextBoxAdv2.Text + "ถึงวันที่ " + MaskedTextBoxAdv1.Text
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With






            With .Range("B5:B6")
                .Merge()
                .Value = "ลำดับ"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("C5:C6")
                .Merge()
                .Value = "หน่วยงาน"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            End With

            With .Range("D5:D6")
                .Merge()
                .WrapText = True
                .Value = "จำนวนผู้ป่วยเฉลี่ย/วัน"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("E5:I5")
                .Merge()
                .WrapText = True

                .Value = "จำนวน จนท.ที่มีอยู่จริง"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("J5:N5")
                .Merge()
                .WrapText = True
                .Value = "จำนวน จนท.ที่ควรมี"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("E6:E6")
                .Merge()
                .Value = "RN"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F6:F6")
                .Merge()
                .Value = "TN"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("G6:G6")
                .Merge()
                .Value = "NA"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("H6:H6")
                .Merge()
                .Value = "WC"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("I6:I6")
                .Merge()
                .Value = "รวม"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E6:E6")
                .Merge()
                .Value = "RN"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F6:F6")
                .Merge()
                .Value = "PN"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("G6:G6")
                .Merge()
                .Value = "NA"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("H6:H6")
                .Merge()
                .Value = "WC"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("I6:I6")
                .Merge()
                .Value = "รวม"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With




            With .Range("J6:J6")
                .Merge()
                .Value = "RN"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("K6:K6")
                .Merge()
                .Value = "PN"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("L6:L6")
                .Merge()
                .Value = "NA"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("M6:M6")
                .Merge()
                .Value = "WC"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("N6:N6")
                .Merge()
                .Value = "รวม"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("O5:O6")
                .Merge()
                .WrapText = True
                .Value = "จำนวนจนท. ที่ปฎิบัติงาน/วัน"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("P5:P6")
                .Merge()
                .WrapText = True
                .Value = "% ผลผลิต"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With




            subdate2 = Split(MaskedTextBoxAdv2.Text, "-")
            subdate1 = Split(MaskedTextBoxAdv1.Text, "-")
            date1 = New System.DateTime(subdate1(2), subdate1(1), subdate1(0), 0, 0, 0)
            date2 = New System.DateTime(subdate2(2), subdate2(1), subdate2(0), 0, 0, 0)
            diff1 = date1.Subtract(date2)
            valuedate = diff1.TotalDays.ToString
            If valuedate = "0" Then
                valuedate = "1"
            Else
                valuedate = CInt(valuedate) + 1
            End If
            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            Dim TextBoxX1 As Integer
            Dim TextBoxX3 As Integer
            Dim TextBoxX4 As Integer
            Dim TextBoxX5 As Integer
            Dim TextBoxX2 As Integer
            Dim TextBoxX6 As Integer
            Dim TextBoxX7 As Integer
            Dim TextBoxX8 As Integer
            Dim TextBoxX9 As Integer
            Dim TextBoxX10 As Integer
            Dim TextBoxX11 As Integer
            Dim TextBoxX14 As String
            Dim TextBoxX15 As Integer
            Dim TextBoxX16 As Integer
            Dim TextBoxX12 As Integer
            Dim TextBoxX13 As Integer
            mySqlCommand.CommandText = "call summation_er('ER','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    TextBoxX1 = CInt(mySqlReader("eremergency"))
                    TextBoxX3 = CInt(mySqlReader("erurgent"))
                    TextBoxX4 = CInt(mySqlReader("ernonurgent"))
                    TextBoxX5 = CInt(mySqlReader("ernonacute"))

                    TextBoxX2 = CInt(mySqlReader("erambuin"))
                    TextBoxX6 = CInt(mySqlReader("erambuout"))
                    ersum = CInt(mySqlReader("ersum"))
                    cenna = CInt(mySqlReader("cenna"))
                    cenrn = CInt(mySqlReader("cenrn"))
                    cenpn = CInt(mySqlReader("cenpn"))
                    cenwc = CInt(mySqlReader("cenwc"))



             
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try




            TextBoxX7 = Math.Round((CInt(TextBoxX1) * 3.2 + CInt(TextBoxX3) * 2.5 + CInt(TextBoxX4) * 0.5 + CInt(TextBoxX5) * 0.25 + CInt(TextBoxX2) * 0.5 + CInt(TextBoxX6) * 1.5) / ersum, 0)
            TextBoxX8 = Math.Round((CInt(TextBoxX7) * CInt(TextBoxX6) * 1.17 * 1.2) / (7), 0)
            TextBoxX9 = Math.Round(CInt(TextBoxX8) * 6 * valuedate, 0)
            TextBoxX10 = Math.Round(CInt(TextBoxX9) / valuedate, 0)
            TextBoxX11 = Math.Round(CInt(TextBoxX10) / 8, 0)

         

            TextBoxX14 = CStr(Math.Round((CInt(TextBoxX6) * CInt(TextBoxX7) * 100) / ((cenrn + cenpn) * 7), 0))


            With .Range("B7:B7")
                .Merge()
                .WrapText = True
                .Value = "1"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("C7:C7")
                .Merge()
                .WrapText = True
                .Value = "ER"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("D7:D7")
                .Merge()
                .WrapText = True
                .Value = ersum
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E7:E7")
                .Merge()
                .WrapText = True
                .Value = cenrn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F7:F7")
                .Merge()
                .WrapText = True
                .Value = cenpn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("A7:P50")

                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("G7:G7")
                .Merge()
                .WrapText = True
                .Value = cenna
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("H7:H7")          
                .Value = cenwc           
            End With

            With .Range("I7:I7")
                .Value = "=SUM(E7:H7)"
            End With

            With .Range("J7:J7")
                .Value = 0.65 * CInt(TextBoxX8)
            End With
            With .Range("K7:K7")
                .Value = 0.25 * CInt(TextBoxX8)
            End With
            With .Range("L7:L7")
                .Value = 0.1 * CInt(TextBoxX8)
            End With
            With .Range("N7:N7")
                .Value = "=SUM(J7:M7)"
            End With
            With .Range("O7:O7")
                .Value = Math.Round(CInt(TextBoxX10) / 8, 0)
            End With

            With .Range("P7:P7")
                .Value = CStr(Math.Round((CInt(TextBoxX6) * CInt(TextBoxX7) * 100) / ((cenrn + cenpn) * 7), 0)) + " %"
            End With


            TextBoxX1 = 0
            TextBoxX3 = 0
            TextBoxX4 = 0
            TextBoxX5 = 0
            TextBoxX2 = 0
            TextBoxX6 = 0
            TextBoxX7 = 0
            TextBoxX8 = 0
            TextBoxX9 = 0
            TextBoxX10 = 0
            TextBoxX11 = 0
            TextBoxX14 = 0
            TextBoxX15 = 0
            TextBoxX16 = 0
            TextBoxX12 = 0
            TextBoxX13 = 0




            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            mySqlCommand.CommandText = "call summation_hd('HD','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try


                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())
                    hdsum = CInt(mySqlReader("hdsum"))
                    roundcount = CInt(mySqlReader("roundcount"))
                    cenna = CInt(mySqlReader("cenna"))
                    cenrn = CInt(mySqlReader("cenrn"))
                    cenpn = CInt(mySqlReader("cenpn"))
                    cenwc = CInt(mySqlReader("cenwc"))

                    TextBoxX15 = cenrn
                    TextBoxX13 = cenpn
                    TextBoxX12 = cenna
                    TextBoxX16 = cenwc
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            TextBoxX1 = hdsum



            TextBoxX8 = Math.Round((hdsum * 2.3 * 1.17 * 1.2) / (7), 0)
            TextBoxX9 = Math.Round(CInt(TextBoxX8) * 6 * valuedate, 0)
            TextBoxX10 = Math.Round(CInt(TextBoxX9) / valuedate, 0)
            TextBoxX11 = Math.Round(CInt(TextBoxX10) / 8, 0)


            TextBoxX14 = CStr(Math.Round((hdsum * 2.3 * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"


            With .Range("B8:B8")
                .Merge()
                .WrapText = True
                .Value = "2"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("C8:C8")
                .Merge()
                .WrapText = True
                .Value = "HD"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("D8:D8")
                .Merge()
                .WrapText = True
                .Value = hdsum
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E8:E8")
                .Merge()
                .WrapText = True
                .Value = cenrn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F8:F8")
                .Merge()
                .WrapText = True
                .Value = cenpn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

          
            With .Range("G8:G8")
                .Merge()
                .WrapText = True
                .Value = cenna
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("H8:H8")
                .Value = cenwc
            End With

            With .Range("I8:I8")
                .Value = "=SUM(E8:H8)"
            End With

            With .Range("J8:J8")
                .Value = 0.65 * CInt(TextBoxX8)
            End With
            With .Range("K8:K8")
                .Value = 0.25 * CInt(TextBoxX8)
            End With
            With .Range("L8:L8")
                .Value = 0.1 * CInt(TextBoxX8)
            End With
            With .Range("N8:N8")
                .Value = "=SUM(J8:M8)"
            End With
            With .Range("O8:O8")
                .Value = Math.Round(CInt(TextBoxX10) / 8, 0)
            End With
            With .Range("P8:P8")
                .Value = CStr(Math.Round((hdsum * 2.3 * 100) / ((cenrn + cenpn) * 7), 0)) + " %"
            End With












            TextBoxX1 = 0
            TextBoxX3 = 0
            TextBoxX4 = 0
            TextBoxX5 = 0
            TextBoxX2 = 0
            TextBoxX6 = 0
            TextBoxX7 = 0
            TextBoxX8 = 0
            TextBoxX9 = 0
            TextBoxX10 = 0
            TextBoxX11 = 0
            TextBoxX14 = 0
            TextBoxX15 = 0
            TextBoxX16 = 0
            TextBoxX12 = 0
            TextBoxX13 = 0


            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            mySqlCommand.CommandText = "call summation('LR','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try


                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())
                    TextBoxX1 = CInt(mySqlReader("lrwbirth"))
                    TextBoxX4 = CInt(mySqlReader("lrns"))
                    TextBoxX3 = CInt(mySqlReader("lrdiag"))
                    TextBoxX5 = CInt(mySqlReader("lrbirth"))
                    TextBoxX6 = CInt(mySqlReader("STD"))
                    cenna = CInt(mySqlReader("cenna"))
                    cenrn = CInt(mySqlReader("cenrn"))
                    cenpn = CInt(mySqlReader("cenpn"))
                    cenwc = CInt(mySqlReader("cenwc"))

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            TextBoxX7 = Math.Round((CInt(TextBoxX1) * 7.5 + CInt(TextBoxX3) * 5.5 + CInt(TextBoxX4) * 3.5 + CInt(TextBoxX5) * 1.5) / CInt(TextBoxX6), 0)
            TextBoxX8 = Math.Round((CInt(TextBoxX7) * CInt(TextBoxX6) * 1.17 * 1.2) / (7), 0)
            TextBoxX9 = Math.Round(CInt(TextBoxX8) * 6 * valuedate, 0)
            TextBoxX10 = Math.Round(CInt(TextBoxX9) / valuedate, 0)
            TextBoxX11 = Math.Round(CInt(TextBoxX10) / 8, 0)


            TextBoxX14 = CStr(Math.Round((CInt(TextBoxX6) * CInt(TextBoxX7) * 100) / ((cenrn + cenpn) * 7), 0))


            With .Range("B9:B9")
                .Merge()
                .WrapText = True
                .Value = "3"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("C9:C9")
                .Merge()
                .WrapText = True
                .Value = "LR"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("D9:D9")
                .Merge()
                .WrapText = True
                .Value = TextBoxX6
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E9:E9")
                .Merge()
                .WrapText = True
                .Value = cenrn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F9:F9")
                .Merge()
                .WrapText = True
                .Value = cenpn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("G9:G9")
                .Merge()
                .WrapText = True
                .Value = cenna
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("H9:H9")
                .Value = cenwc
            End With

            With .Range("I9:I9")
                .Value = "=SUM(E9:H9)"
            End With

            With .Range("J9:J9")
                .Value = 0.65 * CInt(TextBoxX8)
            End With
            With .Range("K9:K9")
                .Value = 0.25 * CInt(TextBoxX8)
            End With
            With .Range("L9:L9")
                .Value = 0.1 * CInt(TextBoxX8)
            End With
            With .Range("N9:N9")
                .Value = "=SUM(J9:M9)"
            End With
            With .Range("O9:O9")
                .Value = TextBoxX11
            End With
            With .Range("P9:P9")
                .Value = TextBoxX14 + " %"
            End With






            TextBoxX1 = 0
            TextBoxX3 = 0
            TextBoxX4 = 0
            TextBoxX5 = 0
            TextBoxX2 = 0
            TextBoxX6 = 0
            TextBoxX7 = 0
            TextBoxX8 = 0
            TextBoxX9 = 0
            TextBoxX10 = 0
            TextBoxX11 = 0
            TextBoxX14 = 0
            TextBoxX15 = 0
            TextBoxX16 = 0
            TextBoxX12 = 0
            TextBoxX13 = 0

            Dim sumtotal_scope As Integer
            Dim sumtotal_minor As Integer
            Dim sumtotal_major As Integer

            Dim sumall As Integer


            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            mySqlCommand.CommandText = "call summantion_or('OR','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try


                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    sumtotal_scope = (CInt(mySqlReader("scope")) + CInt(mySqlReader("small"))) * 4.7
                    sumtotal_minor = CInt(mySqlReader("minorcase")) * 6.3
          
                    sumtotal_major = CInt(mySqlReader("majorcase")) * 7.8
                    sumall = CInt(mySqlReader("sumall"))
                    cenna = CInt(mySqlReader("cenna"))
                    cenrn = CInt(mySqlReader("cenrn"))
                    cenpn = CInt(mySqlReader("cenpn"))
                    cenwc = CInt(mySqlReader("cenwc"))


                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try





            TextBoxX7 = Math.Round(((sumtotal_scope * 4.7) + (sumtotal_minor * 6.3) + (sumtotal_major * 7.8)) / sumall, 0)

            TextBoxX8 = Math.Round((CInt(TextBoxX7) * sumall * 1.17 * 1.2) / (7), 0)
            TextBoxX3 = Math.Round(CInt(TextBoxX8) * 6 * valuedate, 0)
            TextBoxX2 = Math.Round(CInt(TextBoxX3) / valuedate, 0)
            TextBoxX1 = Math.Round(CInt(TextBoxX2) / 8, 0)


            TextBoxX14 = CStr(Math.Round((sumall * CInt(TextBoxX7) * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"





            With .Range("B10:B10")
                .Merge()
                .WrapText = True
                .Value = "4"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("C10:C10")
                .Merge()
                .WrapText = True
                .Value = "OR"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("D10:D10")
                .Merge()
                .WrapText = True
                .Value = TextBoxX1
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E10:E10")
                .Merge()
                .WrapText = True
                .Value = cenrn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F10:F10")
                .Merge()
                .WrapText = True
                .Value = cenpn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("G10:G10")
                .Merge()
                .WrapText = True
                .Value = cenna
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("H10:H10")
                .Value = cenwc
            End With

            With .Range("I10:I10")
                .Value = "=SUM(E10:H10)"
            End With

            With .Range("J10:J10")
                .Value = 0.65 * CInt(TextBoxX8)
            End With
            With .Range("K10:K10")
                .Value = 0.25 * CInt(TextBoxX8)
            End With
            With .Range("L10:L10")
                .Value = 0.1 * CInt(TextBoxX8)
            End With
            With .Range("N10:N10")
                .Value = "=SUM(J10:M10)"
            End With
            With .Range("O10:O10")
                .Value = TextBoxX11
            End With
            With .Range("P10:P10")
                .Value = TextBoxX14
            End With




            Dim countline As Integer = 11
            Dim countround As Integer = 5


            TextBoxX1 = 0
            TextBoxX3 = 0
            TextBoxX4 = 0
            TextBoxX5 = 0
            TextBoxX2 = 0
            TextBoxX6 = 0
            TextBoxX7 = 0
            TextBoxX8 = 0
            TextBoxX9 = 0
            TextBoxX10 = 0
            TextBoxX11 = 0
            TextBoxX14 = 0
            TextBoxX15 = 0
            TextBoxX16 = 0
            TextBoxX12 = 0
            TextBoxX13 = 0
            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            mySqlCommand.CommandText = "call summation_wrd('W3','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    TextBoxX1 = CInt(mySqlReader("ipdicu"))
                    TextBoxX3 = CInt(mySqlReader("ci"))
                    TextBoxX4 = CInt(mySqlReader("si"))
                    TextBoxX5 = CInt(mySqlReader("mi"))
                    TextBoxX2 = CInt(mySqlReader("cl"))
                    TextBoxX6 = CInt(mySqlReader("ipdsum"))
                    cenna = CInt(mySqlReader("cenna"))
                    cenrn = CInt(mySqlReader("cenrn"))
                    cenpn = CInt(mySqlReader("cenpn"))
                    cenwc = CInt(mySqlReader("cenwc"))



                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



            TextBoxX7 = Math.Round((CInt(TextBoxX1) * 12 + CInt(TextBoxX3) * 7.5 + CInt(TextBoxX4) * 5.5 + CInt(TextBoxX5) * 3.5 + CInt(TextBoxX2) * 1.5) / CInt(TextBoxX6), 0)
            TextBoxX8 = Math.Round((CInt(TextBoxX7) * CInt(TextBoxX6) * 1.17 * 1.2) / (7), 0)
            TextBoxX9 = Math.Round(CInt(TextBoxX8) * 6 * valuedate, 0)
            TextBoxX10 = Math.Round(CInt(TextBoxX9) / valuedate, 0)
            TextBoxX11 = Math.Round(CInt(TextBoxX10) / 8, 0)

          

            TextBoxX14 = CStr(Math.Round((CInt(TextBoxX6) * CInt(TextBoxX7) * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"






            With .Range("B" + countline.ToString + ":B" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = countround
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("C" + countline.ToString + ":C" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = "W3"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("D" + countline.ToString + ":D" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = TextBoxX6
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E" + countline.ToString + ":E" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenrn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F" + countline.ToString + ":F" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenpn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("G" + countline.ToString + ":G" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenna
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("H" + countline.ToString + ":H" + countline.ToString)
                .Value = cenwc
            End With

            With .Range("I" + countline.ToString + ":I" + countline.ToString)
                .Value = "=SUM(E" + countline.ToString + ":H" + countline.ToString + ")"
            End With

            With .Range("J" + countline.ToString + ":J" + countline.ToString)
                .Value = 0.65 * CInt(TextBoxX8)
            End With
            With .Range("K" + countline.ToString + ":K" + countline.ToString)
                .Value = 0.25 * CInt(TextBoxX8)
            End With
            With .Range("L" + countline.ToString + ":L" + countline.ToString)
                .Value = 0.1 * CInt(TextBoxX8)
            End With
            With .Range("N" + countline.ToString + ":N" + countline.ToString)
                .Value = "=SUM(J" + countline.ToString + ":M" + countline.ToString + ")"
            End With
            With .Range("O" + countline.ToString + ":O" + countline.ToString)
                .Value = TextBoxX11
            End With
            With .Range("P" + countline.ToString + ":P" + countline.ToString)
                .Value = TextBoxX14
            End With




            TextBoxX1 = 0
            TextBoxX3 = 0
            TextBoxX4 = 0
            TextBoxX5 = 0
            TextBoxX2 = 0
            TextBoxX6 = 0
            TextBoxX7 = 0
            TextBoxX8 = 0
            TextBoxX9 = 0
            TextBoxX10 = 0
            TextBoxX11 = 0
            TextBoxX14 = 0
            TextBoxX15 = 0
            TextBoxX16 = 0
            TextBoxX12 = 0
            TextBoxX13 = 0



            countline += 1
            countround += 1
            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            mySqlCommand.CommandText = "call summation_wrd('W4','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    TextBoxX1 = CInt(mySqlReader("ipdicu"))
                    TextBoxX3 = CInt(mySqlReader("ci"))
                    TextBoxX4 = CInt(mySqlReader("si"))
                    TextBoxX5 = CInt(mySqlReader("mi"))
                    TextBoxX2 = CInt(mySqlReader("cl"))
                    TextBoxX6 = CInt(mySqlReader("ipdsum"))
                    cenna = CInt(mySqlReader("cenna"))
                    cenrn = CInt(mySqlReader("cenrn"))
                    cenpn = CInt(mySqlReader("cenpn"))
                    cenwc = CInt(mySqlReader("cenwc"))



                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



            TextBoxX7 = Math.Round((CInt(TextBoxX1) * 12 + CInt(TextBoxX3) * 7.5 + CInt(TextBoxX4) * 5.5 + CInt(TextBoxX5) * 3.5 + CInt(TextBoxX2) * 1.5) / CInt(TextBoxX6), 0)
            TextBoxX8 = Math.Round((CInt(TextBoxX7) * CInt(TextBoxX6) * 1.17 * 1.2) / (7), 0)
            TextBoxX9 = Math.Round(CInt(TextBoxX8) * 6 * valuedate, 0)
            TextBoxX10 = Math.Round(CInt(TextBoxX9) / valuedate, 0)
            TextBoxX11 = Math.Round(CInt(TextBoxX10) / 8, 0)



            TextBoxX14 = CStr(Math.Round((CInt(TextBoxX6) * CInt(TextBoxX7) * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"






            With .Range("B" + countline.ToString + ":B" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = countround
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("C" + countline.ToString + ":C" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = "W4"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("D" + countline.ToString + ":D" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = TextBoxX6
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E" + countline.ToString + ":E" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenrn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F" + countline.ToString + ":F" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenpn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("G" + countline.ToString + ":G" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenna
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("H" + countline.ToString + ":H" + countline.ToString)
                .Value = cenwc
            End With

            With .Range("I" + countline.ToString + ":I" + countline.ToString)
                .Value = "=SUM(E" + countline.ToString + ":H" + countline.ToString + ")"
            End With

            With .Range("J" + countline.ToString + ":J" + countline.ToString)
                .Value = 0.65 * CInt(TextBoxX8)
            End With
            With .Range("K" + countline.ToString + ":K" + countline.ToString)
                .Value = 0.25 * CInt(TextBoxX8)
            End With
            With .Range("L" + countline.ToString + ":L" + countline.ToString)
                .Value = 0.1 * CInt(TextBoxX8)
            End With
            With .Range("N" + countline.ToString + ":N" + countline.ToString)
                .Value = "=SUM(J" + countline.ToString + ":M" + countline.ToString + ")"
            End With
            With .Range("O" + countline.ToString + ":O" + countline.ToString)
                .Value = TextBoxX11
            End With
            With .Range("P" + countline.ToString + ":P" + countline.ToString)
                .Value = TextBoxX14
            End With







            TextBoxX1 = 0
            TextBoxX3 = 0
            TextBoxX4 = 0
            TextBoxX5 = 0
            TextBoxX2 = 0
            TextBoxX6 = 0
            TextBoxX7 = 0
            TextBoxX8 = 0
            TextBoxX9 = 0
            TextBoxX10 = 0
            TextBoxX11 = 0
            TextBoxX14 = 0
            TextBoxX15 = 0
            TextBoxX16 = 0
            TextBoxX12 = 0
            TextBoxX13 = 0



            countline += 1
            countround += 1
            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            mySqlCommand.CommandText = "call summation_wrd('W5','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    TextBoxX1 = CInt(mySqlReader("ipdicu"))
                    TextBoxX3 = CInt(mySqlReader("ci"))
                    TextBoxX4 = CInt(mySqlReader("si"))
                    TextBoxX5 = CInt(mySqlReader("mi"))
                    TextBoxX2 = CInt(mySqlReader("cl"))
                    TextBoxX6 = CInt(mySqlReader("ipdsum"))
                    cenna = CInt(mySqlReader("cenna"))
                    cenrn = CInt(mySqlReader("cenrn"))
                    cenpn = CInt(mySqlReader("cenpn"))
                    cenwc = CInt(mySqlReader("cenwc"))



                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



            TextBoxX7 = Math.Round((CInt(TextBoxX1) * 12 + CInt(TextBoxX3) * 7.5 + CInt(TextBoxX4) * 5.5 + CInt(TextBoxX5) * 3.5 + CInt(TextBoxX2) * 1.5) / CInt(TextBoxX6), 0)
            TextBoxX8 = Math.Round((CInt(TextBoxX7) * CInt(TextBoxX6) * 1.17 * 1.2) / (7), 0)
            TextBoxX9 = Math.Round(CInt(TextBoxX8) * 6 * valuedate, 0)
            TextBoxX10 = Math.Round(CInt(TextBoxX9) / valuedate, 0)
            TextBoxX11 = Math.Round(CInt(TextBoxX10) / 8, 0)



            TextBoxX14 = CStr(Math.Round((CInt(TextBoxX6) * CInt(TextBoxX7) * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"






            With .Range("B" + countline.ToString + ":B" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = countround
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("C" + countline.ToString + ":C" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = "W5"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("D" + countline.ToString + ":D" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = TextBoxX6
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E" + countline.ToString + ":E" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenrn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F" + countline.ToString + ":F" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenpn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("G" + countline.ToString + ":G" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenna
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("H" + countline.ToString + ":H" + countline.ToString)
                .Value = cenwc
            End With

            With .Range("I" + countline.ToString + ":I" + countline.ToString)
                .Value = "=SUM(E" + countline.ToString + ":H" + countline.ToString + ")"
            End With

            With .Range("J" + countline.ToString + ":J" + countline.ToString)
                .Value = 0.65 * CInt(TextBoxX8)
            End With
            With .Range("K" + countline.ToString + ":K" + countline.ToString)
                .Value = 0.25 * CInt(TextBoxX8)
            End With
            With .Range("L" + countline.ToString + ":L" + countline.ToString)
                .Value = 0.1 * CInt(TextBoxX8)
            End With
            With .Range("N" + countline.ToString + ":N" + countline.ToString)
                .Value = "=SUM(J" + countline.ToString + ":M" + countline.ToString + ")"
            End With
            With .Range("O" + countline.ToString + ":O" + countline.ToString)
                .Value = TextBoxX11
            End With
            With .Range("P" + countline.ToString + ":P" + countline.ToString)
                .Value = TextBoxX14
            End With







            countline += 1
            countround += 1






            TextBoxX1 = 0
            TextBoxX3 = 0
            TextBoxX4 = 0
            TextBoxX5 = 0
            TextBoxX2 = 0
            TextBoxX6 = 0
            TextBoxX7 = 0
            TextBoxX8 = 0
            TextBoxX9 = 0
            TextBoxX10 = 0
            TextBoxX11 = 0
            TextBoxX14 = 0
            TextBoxX15 = 0
            TextBoxX16 = 0
            TextBoxX12 = 0
            TextBoxX13 = 0
            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            mySqlCommand.CommandText = "call summation_wrd('W6','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    TextBoxX1 = CInt(mySqlReader("ipdicu"))
                    TextBoxX3 = CInt(mySqlReader("ci"))
                    TextBoxX4 = CInt(mySqlReader("si"))
                    TextBoxX5 = CInt(mySqlReader("mi"))
                    TextBoxX2 = CInt(mySqlReader("cl"))
                    TextBoxX6 = CInt(mySqlReader("ipdsum"))
                    cenna = CInt(mySqlReader("cenna"))
                    cenrn = CInt(mySqlReader("cenrn"))
                    cenpn = CInt(mySqlReader("cenpn"))
                    cenwc = CInt(mySqlReader("cenwc"))



                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



            TextBoxX7 = Math.Round((CInt(TextBoxX1) * 12 + CInt(TextBoxX3) * 7.5 + CInt(TextBoxX4) * 5.5 + CInt(TextBoxX5) * 3.5 + CInt(TextBoxX2) * 1.5) / CInt(TextBoxX6), 0)
            TextBoxX8 = Math.Round((CInt(TextBoxX7) * CInt(TextBoxX6) * 1.17 * 1.2) / (7), 0)
            TextBoxX9 = Math.Round(CInt(TextBoxX8) * 6 * valuedate, 0)
            TextBoxX10 = Math.Round(CInt(TextBoxX9) / valuedate, 0)
            TextBoxX11 = Math.Round(CInt(TextBoxX10) / 8, 0)



            TextBoxX14 = CStr(Math.Round((CInt(TextBoxX6) * CInt(TextBoxX7) * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"






            With .Range("B" + countline.ToString + ":B" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = countround
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("C" + countline.ToString + ":C" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = "W3"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("D" + countline.ToString + ":D" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = TextBoxX6
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E" + countline.ToString + ":E" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenrn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F" + countline.ToString + ":F" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenpn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("G" + countline.ToString + ":G" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenna
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("H" + countline.ToString + ":H" + countline.ToString)
                .Value = cenwc
            End With

            With .Range("I" + countline.ToString + ":I" + countline.ToString)
                .Value = "=SUM(E" + countline.ToString + ":H" + countline.ToString + ")"
            End With

            With .Range("J" + countline.ToString + ":J" + countline.ToString)
                .Value = 0.65 * CInt(TextBoxX8)
            End With
            With .Range("K" + countline.ToString + ":K" + countline.ToString)
                .Value = 0.25 * CInt(TextBoxX8)
            End With
            With .Range("L" + countline.ToString + ":L" + countline.ToString)
                .Value = 0.1 * CInt(TextBoxX8)
            End With
            With .Range("N" + countline.ToString + ":N" + countline.ToString)
                .Value = "=SUM(J" + countline.ToString + ":M" + countline.ToString + ")"
            End With
            With .Range("O" + countline.ToString + ":O" + countline.ToString)
                .Value = TextBoxX11
            End With
            With .Range("P" + countline.ToString + ":P" + countline.ToString)
                .Value = TextBoxX14
            End With











            countline += 1
            countround += 1






            TextBoxX1 = 0
            TextBoxX3 = 0
            TextBoxX4 = 0
            TextBoxX5 = 0
            TextBoxX2 = 0
            TextBoxX6 = 0
            TextBoxX7 = 0
            TextBoxX8 = 0
            TextBoxX9 = 0
            TextBoxX10 = 0
            TextBoxX11 = 0
            TextBoxX14 = 0
            TextBoxX15 = 0
            TextBoxX16 = 0
            TextBoxX12 = 0
            TextBoxX13 = 0
            sql.Close()
            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If
            mySqlCommand.CommandText = "call summation_wrd('ICU','" & MaskedTextBoxAdv2.Text & "','" & MaskedTextBoxAdv1.Text & "','" & CInt(valuedate) & "');"
            ' mySqlCommand.CommandText = 
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand
            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    TextBoxX1 = CInt(mySqlReader("ipdicu"))
                    TextBoxX3 = CInt(mySqlReader("ci"))
                    TextBoxX4 = CInt(mySqlReader("si"))
                    TextBoxX5 = CInt(mySqlReader("mi"))
                    TextBoxX2 = CInt(mySqlReader("cl"))
                    TextBoxX6 = CInt(mySqlReader("ipdsum"))
                    cenna = CInt(mySqlReader("cenna"))
                    cenrn = CInt(mySqlReader("cenrn"))
                    cenpn = CInt(mySqlReader("cenpn"))
                    cenwc = CInt(mySqlReader("cenwc"))



                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



            TextBoxX7 = Math.Round((CInt(TextBoxX1) * 12 + CInt(TextBoxX3) * 7.5 + CInt(TextBoxX4) * 5.5 + CInt(TextBoxX5) * 3.5 + CInt(TextBoxX2) * 1.5) / CInt(TextBoxX6), 0)
            TextBoxX8 = Math.Round((CInt(TextBoxX7) * CInt(TextBoxX6) * 1.17 * 1.2) / (7), 0)
            TextBoxX9 = Math.Round(CInt(TextBoxX8) * 6 * valuedate, 0)
            TextBoxX10 = Math.Round(CInt(TextBoxX9) / valuedate, 0)
            TextBoxX11 = Math.Round(CInt(TextBoxX10) / 8, 0)



            TextBoxX14 = CStr(Math.Round((CInt(TextBoxX6) * CInt(TextBoxX7) * 100) / ((cenrn + cenpn) * 7), 0)) + "  %"






            With .Range("B" + countline.ToString + ":B" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = countround
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("C" + countline.ToString + ":C" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = "ICU"
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("D" + countline.ToString + ":D" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = TextBoxX6
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            With .Range("E" + countline.ToString + ":E" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenrn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With
            With .Range("F" + countline.ToString + ":F" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenpn
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("G" + countline.ToString + ":G" + countline.ToString)
                .Merge()
                .WrapText = True
                .Value = cenna
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With


            With .Range("H" + countline.ToString + ":H" + countline.ToString)
                .Value = cenwc
            End With

            With .Range("I" + countline.ToString + ":I" + countline.ToString)
                .Value = "=SUM(E" + countline.ToString + ":H" + countline.ToString + ")"
            End With

            With .Range("J" + countline.ToString + ":J" + countline.ToString)
                .Value = 0.65 * CInt(TextBoxX8)
            End With
            With .Range("K" + countline.ToString + ":K" + countline.ToString)
                .Value = 0.25 * CInt(TextBoxX8)
            End With
            With .Range("L" + countline.ToString + ":L" + countline.ToString)
                .Value = 0.1 * CInt(TextBoxX8)
            End With
            With .Range("N" + countline.ToString + ":N" + countline.ToString)
                .Value = "=SUM(J" + countline.ToString + ":M" + countline.ToString + ")"
            End With
            With .Range("O" + countline.ToString + ":O" + countline.ToString)
                .Value = TextBoxX11
            End With
            With .Range("P" + countline.ToString + ":P" + countline.ToString)
                .Value = TextBoxX14
            End With














        End With



        Try
            'excelbooks.SaveAs(pathExcel.ToString + "\KAN03" + DateTimePicker2.ToString("yyyyMMdd") + ".xlsx")
            excelbooks.SaveAs(pathExcel.ToString + "\รายงานฝ่ายการพยาบาล Productivity.xlsx")

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
        CircularProgress1.IsRunning = False
    End Sub



    Private Sub showResult(ByVal Num As Integer)
        If Label10.InvokeRequired Then
            Dim dlg As New DelegateSub(AddressOf showResult)
            Me.Invoke(dlg, Num)

        Else


        End If
    End Sub

    Private Sub frmnure_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
    End Sub
End Class