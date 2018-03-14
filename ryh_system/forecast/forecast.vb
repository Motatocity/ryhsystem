Imports OfficeOpenXml
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports Microsoft.Office.Core
Imports System.Threading

Public Class forecast

    Private Sub forecast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Excel()
        Dim StartDate As Integer
        Dim Enddate As Integer
        Dim StartDateS As String
        Dim Enddates As String
        Dim Smonth As Integer
        Dim Ystart As Integer
        Dim Yloop As Integer
        Dim Yend As Integer
        Dim Sloop As Integer
        StartDate = CInt(TextBox1.Text)
        Enddate = CInt(TextBox2.Text)
        StartDateS = TextBox1.Text
        Enddates = TextBox2.Text


        Ystart = CInt(StartDateS.Substring(0, 4))
        Smonth = CInt(StartDateS.Substring(4, 2))
        Yend = CInt(Enddates.Substring(0, 4))
        Sloop = Smonth
        Yloop = Ystart
        Dim connecdb As connectHIM = connectHIM.NewConnection
        Dim tmpl As FileInfo = New FileInfo(FolderBrowserDialog1.SelectedPath + "\Forecast  " + TextBox3.Text + ".xlsx")
        Dim package As ExcelPackage = New ExcelPackage(tmpl)
        Dim dt As DataTable = New DataTable
        connecdb = connectHIM.NewConnection

        connecdb.BeginTrans()
        Dim sqlcommand As String
        Dim sqldate As String = ""
        Dim ii As Integer

        For i As Integer = StartDate To Enddate Step 100

            If Sloop <= 12 Then
                ii = i + 30
                sqldate += " SUM(CASE WHEN (SBDBLFDTE > " & i - 1 & " AND SBDBLFDTE < " & ii + 1 & ") THEN SBDSALQTYO+SBDISSQTY+SBDSALQTYI ELSE 0 END) AS D" & ii & " ,  "
            Else
                If Yloop < Yend Then
                    Yloop += 1
                    i = CInt(CStr(Yloop) + "0001")
                    Sloop = 1
                End If
            End If

            Sloop += 1
        Next

        Dim rows As Integer = 5
        sqlcommand = "SELECT       NEW2.PRDPRDNO,NEW2.PRDPRDNAM ,NEW2.PRDORDCVF ,"


        sqlcommand += sqldate
        'sqlcommand += "  SUM(CASE WHEN (SBDBLFDTE >= 25570101 AND SBDBLFDTE <= 25570131) "

        'sqlcommand += "  THEN SBDTRFQTY ELSE 0 END) AS JAN57 , SUM(CASE WHEN (SBDBLFDTE >= 25570131 AND SBDBLFDTE <= 25570131) THEN SBDONHQTY ELSE 0 END)  "
        'sqlcommand += "  AS TOTAL_JAN, SUM(CASE WHEN (SBDBLFDTE >= 25570201 AND SBDBLFDTE <= 25570228) THEN SBDTRFQTY ELSE 0 END) AS FEB57, "
        'sqlcommand += "  SUM(CASE WHEN (SBDBLFDTE >= 25570128 AND SBDBLFDTE <= 25570128) THEN SBDONHQTY ELSE 0 END) AS TOTAL_FEB, "
        'sqlcommand += "  SUM(CASE WHEN (SBDBLFDTE >= 25570301 AND SBDBLFDTE <= 25570331) THEN SBDTRFQTY ELSE 0 END) AS MARCH57, "
        'sqlcommand += "  SUM(CASE WHEN (SBDBLFDTE >= 25570331 AND SBDBLFDTE <= 25570331) THEN SBDONHQTY ELSE 0 END) AS TOTAL_MARCH , "
        sqlcommand += "   NEW2.PRDORDUM   , NEW2.PRDACTCST  "
        If RadioButton1.Checked = True Then
            sqlcommand += "  FROM   ( SELECT PRDPRDNO,PRDPRDNAM,PRDORDCVF,PRDORDUM,PRDACTCST  FROM RYHPFV5.PRDMASV5PF WHERE RYHPFV5.PRDMASV5PF.PRDPRDTYP = 'M' AND RYHPFV5.PRDMASV5PF.PRDGNCNAM <> ' ' ) NEW2 LEFT JOIN "
        Else
            sqlcommand += "  FROM   ( SELECT PRDPRDNO,PRDPRDNAM,PRDORDCVF,PRDORDUM,PRDACTCST  FROM RYHPFV5.PRDMASV5PF WHERE  RYHPFV5.PRDMASV5PF.PRDGNCNAM <> ' ' ) NEW2 LEFT JOIN "

        End If
      
        '' sqlcommand += "  FROM   ( SELECT PRDPRDNO,PRDPRDNAM,PRDORDCVF,PRDORDUM,PRDACTCST  FROM RYHPFV5.PRDMASV5PF WHERE  RYHPFV5.PRDMASV5PF.PRDPRDNAM <> ' ' ) NEW2 LEFT JOIN "


        sqlcommand += "  (SELECT DISTINCT * FROM RYHPFV5.STKBLDV5PF "
        '   sqlcommand += "    WHERE (SBDSTRNO = '10') AND (SBDBLFDTE > '" & StartDate - 1 & "') AND (SBDBLFDTE < '" & Enddate + 1 & "')) NEW1"
      If CheckBox1.Checked = True Then
            sqlcommand += "    WHERE  (SBDBLFDTE > '" & StartDate - 1 & "') AND (SBDBLFDTE < '" & Enddate + 1 & "') AND SBDSTRNO ='10') NEW1"
        Else
            sqlcommand += "    WHERE  (SBDBLFDTE > '" & StartDate - 1 & "') AND (SBDBLFDTE < '" & Enddate + 1 & "')) NEW1"


        End If
        sqlcommand += "  ON  NEW2.PRDPRDNO = NEW1.SBDPRDNO  "
        sqlcommand += "  GROUP BY NEW2.PRDPRDNO, NEW2.PRDPRDNAM ,   NEW2.PRDORDUM, NEW2.PRDACTCST,NEW2.PRDORDCVF "
        sqlcommand += "  ORDER BY NEW2.PRDPRDNO "
        dt = connecdb.GetTable(sqlcommand)


        With package
            Dim wrksheet As ExcelWorksheet
            Dim wrksheet1 As ExcelWorksheet
            Dim wrksheet2 As ExcelWorksheet
            wrksheet = package.Workbook.Worksheets.Add("Forecast")
            wrksheet1 = package.Workbook.Worksheets.Add("StockPlan")
            wrksheet2 = package.Workbook.Worksheets.Add("Pending Order")
            wrksheet.Column(1).Width = 10
            wrksheet.Column(2).Width = 70
            wrksheet.Column(1).Width = 15
            wrksheet.Cells(rows, 1).Value = "รหัสสินค้า"
            wrksheet.Cells(rows, 2).Value = "ชื่อสินค้า"
            wrksheet.Cells(rows, 3).Value = "หน่วย"
            wrksheet.Cells(rows, 4).Value = "CVF"
            wrksheet.Cells(rows, 5).Value = "ราคาทุน"
            wrksheet.Cells(rows, 6).Value = "Total Consumption"
            wrksheet.Cells("A5:AP5").AutoFilter = True

            Sloop = Smonth
            Yloop = Ystart
            Dim column As Integer = 7
            For i As Integer = StartDate To Enddate Step 100

                If Sloop <= 12 Then
                    ii = i + 30
                    wrksheet.Cells(rows, column).Value = "D" + ii.ToString
                Else
                    If Yloop < Yend Then
                        Yloop += 1
                        i = CInt(CStr(Yloop) + "0001")
                        Sloop = 1
                        column -= 1
                    End If
                End If

                Sloop += 1
                column += 1
            Next

            wrksheet.Cells(6, 5, dt.Rows.Count + 6, column + 12).Style.Numberformat.Format = "#,##0"

            wrksheet.Cells(rows, column).Value = "Average 9 months"
            wrksheet.Cells(rows, column + 1).Value = "Average 6 months"
            wrksheet.Cells(rows, column + 2).Value = "Average 4 months"
            wrksheet.Cells(rows, column + 3).Value = "Average 3 months"
            wrksheet.Cells(rows, column + 4).Value = "Average W"
            wrksheet.Cells(rows, column + 5).Value = "Average Consumtion"
            wrksheet.Cells(rows, column + 6).Value = "Average Consumtion Value"
            wrksheet.Cells(rows, column + 7).Value = "Forecast"
            wrksheet.Cells(rows, column + 8).Value = "+20%"
            wrksheet.Cells(rows, column + 9).Value = "-20%"
            wrksheet.Cells(rows, column + 10).Value = "Cover 6"
            wrksheet.Cells(rows, column + 11).Value = "Cover 4"
            wrksheet.Cells(rows, column + 12).Value = "Cover 3"
            For a As Integer = 0 To dt.Rows.Count - 1
                rows += 1
                column = 7
                wrksheet.Cells(rows, 1).Value = dt.Rows(a)("PRDPRDNO")
                wrksheet.Cells(rows, 2).Value = dt.Rows(a)("PRDPRDNAM")
                wrksheet.Cells(rows, 3).Value = dt.Rows(a)("PRDORDUM")
                wrksheet.Cells(rows, 4).Value = dt.Rows(a)("PRDORDCVF")
                wrksheet.Cells(rows, 5).Value = dt.Rows(a)("PRDACTCST")
                Sloop = Smonth
                Yloop = Ystart
                For i As Integer = StartDate To Enddate Step 100

                    If Sloop <= 12 Then
                        ii = i + 30
                        wrksheet.Cells(rows, column).Value = dt.Rows(a)("D" + ii.ToString)
                    Else
                        If Yloop < Yend Then
                            Yloop += 1
                            i = CInt(CStr(Yloop) + "0001")
                            Sloop = 0
                            column -= 1
                        End If
                    End If
                    Sloop += 1
                    column += 1
                Next
                wrksheet.Cells(rows, 6).Formula = "=Sum(" + wrksheet.Cells(rows, 7).Address + ":" + wrksheet.Cells(rows, column - 1).Address + ")"
                wrksheet.Cells(rows, column).Formula = "=AVERAGE(" + wrksheet.Cells(rows, column - 10).Address + ":" + wrksheet.Cells(rows, column - 1).Address + ")"
                wrksheet.Cells(rows, column + 1).Formula = "=AVERAGE(" + wrksheet.Cells(rows, column - 7).Address + ":" + wrksheet.Cells(rows, column - 1).Address + ")"
                wrksheet.Cells(rows, column + 2).Formula = "=AVERAGE(" + wrksheet.Cells(rows, column - 5).Address + ":" + wrksheet.Cells(rows, column - 1).Address + ")"
                wrksheet.Cells(rows, column + 3).Formula = "=AVERAGE(" + wrksheet.Cells(rows, column - 4).Address + ":" + wrksheet.Cells(rows, column - 1).Address + ")"
                wrksheet.Cells(rows, column + 4).Formula = "=AVERAGE(" + wrksheet.Cells(rows, column + 1).Address + ":" + wrksheet.Cells(rows, column + 3).Address + ")"
                wrksheet.Cells(rows, column + 5).Formula = "=" + wrksheet.Cells(rows, column + 4).Address
                wrksheet.Cells(rows, column + 6).Formula = "=" + wrksheet.Cells(rows, column + 4).Address + "*$" + wrksheet.Cells(rows, 5).Address

                wrksheet.Cells(rows, column + 7).Formula = "=" + wrksheet.Cells(rows, column + 4).Address + ""
                wrksheet.Cells(rows, column + 8).Formula = "=" + wrksheet.Cells(rows, column + 7).Address + "*1.2"
                wrksheet.Cells(rows, column + 9).Formula = "=" + wrksheet.Cells(rows, column + 7).Address + "*0.8"

                wrksheet.Cells(rows, column + 10).Formula = "=" + wrksheet.Cells(rows, column + 1).Address
                wrksheet.Cells(rows, column + 11).Formula = "=" + wrksheet.Cells(rows, column + 2).Address
                wrksheet.Cells(rows, column + 12).Formula = "=" + wrksheet.Cells(rows, column + 3).Address
                'Try

                '    wrksheet.Cells(rows, column).Formula = "=AVERAGE(" + wrksheet.Cells(rows, 7).Address + ":" + wrksheet.Cells(column - 1).Address + ")"
                'Catch ex As Exception
                '    MsgBox(ex.TargetSite)
                'End Try




            Next

            With wrksheet1
                rows = 5
                Dim sql As String

                sql = "SELECT RYHPFV5.PRDMASV5PF.PRDPRDNAM, RYHPFV5.PRDMASV5PF.PRDPRDNO, NEW3.STKONHQTY  ,"
                sql += " CASE WHEN ( Expr2.POQTY IS NULL ) THEN 0 ELSE   Expr2.POQTY END AS POQTY"
                sql += " FROM ( SELECT        SBDPRDNO, SUM(SBDONHSTK) AS STKONHQTY  FROM RYHPFV5.STKBLDV5PF WHERE SBDBLFDTE = '" & TextBox3.Text & "'"
                sql += " GROUP BY SBDPRDNO )"
                sql += "  NEW3 ,RYHPFV5.PRDMASV5PF LEFT JOIN "
                sql += " (SELECT RYHPFV5.POSTODV5PF.PODPRDNO, "
                sql += " SUM(RYHPFV5.POSTODV5PF.PODORDQTY * RYHPFV5.POSTODV5PF.PODORDCVF + RYHPFV5.POSTODV5PF.PODSAMQTY * RYHPFV5.POSTODV5PF.PODSAMCVF)"
                sql += " AS POQTY"
                sql += " FROM RYHPFV5.POSTOMV5PF LEFT JOIN "
                sql += " RYHPFV5.POSTODV5PF ON RYHPFV5.POSTOMV5PF.POMPONO = RYHPFV5.POSTODV5PF.PODPONO "
                sql += " WHERE (RYHPFV5.POSTOMV5PF.POMREFFLG = 'P')"
                sql += " GROUP BY RYHPFV5.POSTODV5PF.PODPRDNO) Expr2 ON Expr2.PODPRDNO = RYHPFV5.PRDMASV5PF.PRDPRDNO "
                If RadioButton1.Checked = True Then
                    sql += " WHERE NEW3.SBDPRDNO = RYHPFV5.PRDMASV5PF.PRDPRDNO AND (RYHPFV5.PRDMASV5PF.PRDPRDTYP = 'M')  "

                Else
                    sql += " WHERE NEW3.SBDPRDNO = RYHPFV5.PRDMASV5PF.PRDPRDNO "

                End If
                'sql += " WHERE NEW3.SBDPRDNO = RYHPFV5.PRDMASV5PF.PRDPRDNO AND (RYHPFV5.PRDMASV5PF.PRDPRDTYP = 'M') AND "
                'sql += " WHERE NEW3.SBDPRDNO = RYHPFV5.PRDMASV5PF.PRDPRDNO "

                sql += "  AND (RYHPFV5.PRDMASV5PF.PRDPRDNAM <> ' ')"
                sql += " GROUP BY RYHPFV5.PRDMASV5PF.PRDPRDNAM, RYHPFV5.PRDMASV5PF.PRDPRDNO, NEW3.STKONHQTY, "
                sql += "  Expr2.POQTY"
                sql += " ORDER BY RYHPFV5.PRDMASV5PF.PRDPRDNO"

                dt = connecdb.GetTable(sql)
                connecdb.CommitTrans()
                connecdb.Dispose()





                wrksheet1.Cells("A5:AZ5").AutoFilter = True
                wrksheet1.Cells(6, 5, dt.Rows.Count + 6, column + 20).Style.Numberformat.Format = "#,##0"
                wrksheet1.Column(1).Width = 15
                wrksheet1.Column(2).Width = 7
                wrksheet1.Column(3).Width = 10
                wrksheet1.Column(4).Width = 30
                wrksheet1.Column(5).Width = 10
                wrksheet1.Column(6).Width = 15
                wrksheet1.Column(7).Width = 10
                wrksheet1.Column(8).Width = 10
                wrksheet1.Column(9).Width = 10
                wrksheet1.Cells(rows, 1).Value = "Comment on Status"
                wrksheet1.Cells(rows, 2).Value = "Suplier"
                wrksheet1.Cells(rows, 3).Value = "Product Code"
                wrksheet1.Cells(rows, 4).Value = "Description"
                wrksheet1.Cells(rows, 5).Value = "Unit Cost"
                wrksheet1.Cells(rows, 6).Value = "Safety Stock / Unit in Day"
                wrksheet1.Cells(rows, 7).Value = "Ending Stock"
                wrksheet1.Cells(rows, 8).Value = "Cost"
                wrksheet1.Cells(rows, 9).Value = "Cover Stock Day"
                wrksheet1.Cells(rows, 10).Value = "Total Pending PO"

                wrksheet1.Cells(rows, 1, rows, 10).Style.Border.Left.Style = Style.ExcelBorderStyle.Medium
                wrksheet1.Cells(rows, 1, rows, 10).Style.Border.Right.Style = Style.ExcelBorderStyle.Medium
                wrksheet1.Cells(rows, 1, rows, 10).Style.Border.Top.Style = Style.ExcelBorderStyle.Medium
                wrksheet1.Cells(rows, 1, rows, 10).Style.Border.Bottom.Style = Style.ExcelBorderStyle.Medium

                wrksheet1.Cells(rows, 1, rows, 50).Style.WrapText = True
                wrksheet1.Cells(rows, 1, rows, 50).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                wrksheet1.Cells(rows, 1, rows, 50).Style.VerticalAlignment = Style.ExcelVerticalAlignment.Center

                Dim x As Integer = 11
                For a As Integer = 0 To 9
                    wrksheet1.Cells(rows - 1, x).Value = Date.Now.AddMonths(a).ToString("MM-yyyy")
                    wrksheet1.Cells(rows - 1, x, rows - 1, x + 3).Merge = True
                    wrksheet1.Cells(rows - 1, x, rows - 1, x + 3).Style.Font.Bold = True
                    wrksheet1.Cells(rows - 1, x, rows - 1, x + 3).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    wrksheet1.Cells(rows - 1, x, rows - 1, x + 3).Style.Border.Left.Style = Style.ExcelBorderStyle.Medium
                    wrksheet1.Cells(rows - 1, x, rows - 1, x + 3).Style.Border.Right.Style = Style.ExcelBorderStyle.Medium
                    wrksheet1.Cells(rows - 1, x, rows - 1, x + 3).Style.Border.Top.Style = Style.ExcelBorderStyle.Medium
                    wrksheet1.Cells(rows - 1, x, rows - 1, x + 3).Style.Border.Bottom.Style = Style.ExcelBorderStyle.Medium
                    wrksheet1.Cells(rows, x).Value = "Forecast"
                    wrksheet1.Cells(rows, x + 1).Value = "Purchase Forecast"
                    wrksheet1.Cells(rows, x + 2).Value = "Expected End INVT"
                    wrksheet1.Cells(rows, x + 3).Value = "Cover Days"
                    wrksheet1.Cells(rows, x).Style.Border.Left.Style = Style.ExcelBorderStyle.Medium
                    wrksheet1.Cells(rows, x).Style.Border.Top.Style = Style.ExcelBorderStyle.Medium
                    wrksheet1.Cells(rows, x).Style.Border.Bottom.Style = Style.ExcelBorderStyle.Medium
                    wrksheet1.Cells(rows, x + 1, rows, x + 3).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    wrksheet1.Cells(rows, x + 1, rows, x + 3).Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
                    wrksheet1.Cells(rows, x + 1, rows, x + 3).Style.Border.Top.Style = Style.ExcelBorderStyle.Medium
                    wrksheet1.Cells(rows, x + 1, rows, x + 3).Style.Border.Bottom.Style = Style.ExcelBorderStyle.Medium
                    x += 4
                Next

                '=IF(ISERROR(VLOOKUP($C6,Forecast!$A:$AV,26,0)),0,VLOOKUP($C6,Forecast!$A:$AV,26,0))' 

                For a As Integer = 0 To dt.Rows.Count - 1

                    rows += 1

                    wrksheet1.Cells(rows, 3).Value = dt.Rows(a)("PRDPRDNO")
                    wrksheet1.Cells(rows, 4).Value = dt.Rows(a)("PRDPRDNAM")
                    wrksheet1.Cells(rows, 5).Value = wrksheet.Cells(rows, 5).Value
                    wrksheet1.Cells(rows, 6).Value = "45"
                    wrksheet1.Cells(rows, 7).Value = dt.Rows(a)("STKONHQTY")
                    wrksheet1.Cells(rows, 8).Formula = "=" + wrksheet.Cells(rows, 7).Address + "*$" + wrksheet.Cells(rows, 5).Address
                    wrksheet1.Cells(rows, 10).Value = dt.Rows(a)("POQTY")





                    wrksheet1.Cells(rows, 1, rows, 10).Style.Border.Left.Style = Style.ExcelBorderStyle.Thin
                    wrksheet1.Cells(rows, 1, rows, 10).Style.Border.Right.Style = Style.ExcelBorderStyle.Thin
                    wrksheet1.Cells(rows, 1, rows, 10).Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
                    wrksheet1.Cells(rows, 1, rows, 10).Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin


                    x = 11

                    Dim y As Integer = 0
                    For s As Integer = 0 To 9


                        wrksheet1.Cells(rows, x).Style.Border.Left.Style = Style.ExcelBorderStyle.Medium
                        wrksheet1.Cells(rows, x, rows, x + 3).Style.Border.Right.Style = Style.ExcelBorderStyle.Thin
                        wrksheet1.Cells(rows, x, rows, x + 3).Style.Border.Top.Style = Style.ExcelBorderStyle.Thin
                        wrksheet1.Cells(rows, x, rows, x + 3).Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin


                        wrksheet1.Cells(rows, x).Formula = "=IF(ISERROR(VLOOKUP($C" + rows.ToString + ",Forecast!$A:$AV," & CStr(column + 7).ToString & ",0)),0,VLOOKUP($C" + rows.ToString + ",Forecast!$A:$AV," & CStr(column + 7).ToString & ",0))"
                        If y < 3 Then
                            If y = 0 Then
                                wrksheet1.Cells(rows, x + 2).Formula = "=" + wrksheet1.Cells(rows, 7).Address + "+" + wrksheet1.Cells(rows, 10).Address + "+" + wrksheet1.Cells(rows, x + 1).Address + "-" + wrksheet1.Cells(rows, x).Address

                            End If

                            If y >= 1 Then
                                wrksheet1.Cells(rows, x + 2).Formula = "=" + wrksheet1.Cells(rows, x - 2).Address + "-" + wrksheet1.Cells(rows, x).Address + "+" + wrksheet1.Cells(rows, x + 1).Address


                            End If

                            y += 1
                        Else
                            wrksheet1.Cells(rows, x + 2).Formula = "=IF((AVERAGE(" + wrksheet1.Cells(rows, x + 4).Address + "," + wrksheet1.Cells(rows, x + 8).Address + " ," + wrksheet1.Cells(rows, x + 12).Address + ")*$" + wrksheet1.Cells(rows, 6).Address + ")/30<(" + wrksheet1.Cells(rows, x - 2).Address + "-" + wrksheet1.Cells(rows, x).Address + "),(" + wrksheet1.Cells(rows, x - 2).Address + "-" + wrksheet1.Cells(rows, x).Address + "),(AVERAGE(" + wrksheet1.Cells(rows, x + 4).Address + "," + wrksheet1.Cells(rows, x + 8).Address + " ," + wrksheet1.Cells(rows, x + 12).Address + ")*$" + wrksheet1.Cells(rows, 6).Address + ")/30)"

                            wrksheet1.Cells(rows, x + 1).Formula = "=IF(" + wrksheet1.Cells(rows, x + 2).Address + "+" + wrksheet1.Cells(rows, x).Address + "-" + wrksheet1.Cells(rows, x - 2).Address + "<0,0," + wrksheet1.Cells(rows, x + 2).Address + "+" + wrksheet1.Cells(rows, x).Address + "-" + wrksheet1.Cells(rows, x - 2).Address + ")"
                            y += 1
                        End If

                        wrksheet1.Cells(rows, x + 3).Formula = "=IF(ISERROR((" + wrksheet1.Cells(rows, x + 2).Address + "*30 )/AVERAGE(" + wrksheet1.Cells(rows, x + 4).Address + "," + wrksheet1.Cells(rows, x + 8).Address + "," + wrksheet1.Cells(rows, x + 12).Address + ")),0,(" + wrksheet1.Cells(rows, x + 2).Address + "*30 )/AVERAGE(" + wrksheet1.Cells(rows, x + 4).Address + "," + wrksheet1.Cells(rows, x + 8).Address + "," + wrksheet1.Cells(rows, x + 12).Address + "))"


                        x += 4
                    Next

                    wrksheet1.Cells(rows, x).Formula = "=IF(ISERROR(VLOOKUP($C" + rows.ToString + ",Forecast!$A:$AV," & CStr(column + 7).ToString & ",0)),0,VLOOKUP($C" + rows.ToString + ",Forecast!$A:$AV," & CStr(column + 7).ToString & ",0))"

                Next

                rows = 5
                sql = "SELECT        RYHPFV5.PRDMASV5PF.PRDPRDNAM, RYHPFV5.POSTODV5PF.PODPONO AS PODPONO, RYHPFV5.PRDMASV5PF.PRDPRDNO, "
                sql += "RYHPFV5.POSTODV5PF.PODORDUM AS PODORDUM,SUM(RYHPFV5.POSTODV5PF.PODORDQTY * RYHPFV5.POSTODV5PF.PODORDCVF + RYHPFV5.POSTODV5PF.PODSAMQTY * RYHPFV5.POSTODV5PF.PODSAMCVF) AS POQTY, "
                sql += "    RYHPFV5.POSTODV5PF.PODPODTE AS PODPODTE  "
                sql += " FROM            RYHPFV5.PRDMASV5PF, RYHPFV5.POSTODV5PF  JOIN  "
                sql += " RYHPFV5.POSTOMV5PF ON RYHPFV5.POSTODV5PF.PODPONO = RYHPFV5.POSTOMV5PF.POMPONO  "
                sql += "  WHERE        RYHPFV5.PRDMASV5PF.PRDPRDNO = RYHPFV5.POSTODV5PF.PODPRDNO AND (RYHPFV5.POSTOMV5PF.POMREFFLG = 'P') "
                sql += " GROUP BY  RYHPFV5.PRDMASV5PF.PRDPRDNAM,RYHPFV5.POSTODV5PF.PODPONO , RYHPFV5.PRDMASV5PF.PRDPRDNO ,RYHPFV5.POSTODV5PF.PODORDUM ,RYHPFV5.POSTODV5PF.PODPODTE "
                sql += " Order By RYHPFV5.PRDMASV5PF.PRDPRDNO "

                connecdb = connectHIM.NewConnection
                dt = connecdb.GetTable(sql)
                connecdb.CommitTrans()
                connecdb.Dispose()





                wrksheet2.Column(1).Width = 10
                wrksheet2.Column(2).Width = 70
                wrksheet2.Column(1).Width = 15
                wrksheet2.Cells(rows, 1).Value = "รหัสสินค้า"
                wrksheet2.Cells(rows, 2).Value = "ชื่อสินค้า"
                wrksheet2.Cells(rows, 3).Value = "หน่วย"


                wrksheet2.Cells(rows, 4).Value = "Order Qty"
                wrksheet2.Cells(rows, 5).Value = "Date Order(วันที่สั่ง)"
                wrksheet2.Cells(rows, 6).Value = "PO"
                wrksheet2.Cells("A5:AP5").AutoFilter = True







                For a As Integer = 0 To dt.Rows.Count - 1
                    rows += 1
                    column = 7
                    wrksheet2.Cells(rows, 1).Value = dt.Rows(a)("PRDPRDNO")
                    wrksheet2.Cells(rows, 2).Value = dt.Rows(a)("PRDPRDNAM")
                    wrksheet2.Cells(rows, 3).Value = dt.Rows(a)("PODORDUM")

                    wrksheet2.Cells(rows, 4).Value = dt.Rows(a)("POQTY")
                    wrksheet2.Cells(rows, 5).Value = dt.Rows(a)("PODPODTE")
                    wrksheet2.Cells(rows, 6).Value = dt.Rows(a)("PODPONO")


                Next





            End With

            'package.SaveAs(REsponse.out)



            package.Save()
            MsgBox("Save Complete")
        End With
        package.Dispose()
        CircularProgress1.IsRunning = False
        connecdb.Dispose()
    End Sub


    Public Class connectHIM
        Implements IDisposable
        Private Shared ReadOnly strCommon As String = "dsn=RYHPFV5; Userid=mse;Password=m0116;"

        Public Shared Function NewConnection() As connectHIM
            Return New connectHIM(strCommon)
        End Function

        Public mConnection As OdbcConnection
        Private mTransaction As OdbcTransaction
        Private mIsInTransaction As Boolean

        Public Sub New(ByVal connectionString As String)
            mConnection = New OdbcConnection(connectionString)
            mIsInTransaction = False
            mConnection.Open()
        End Sub

        Public Sub BeginTrans()
            If (Not mIsInTransaction) Then
                mTransaction = mConnection.BeginTransaction()
                mIsInTransaction = True
            End If
        End Sub

        Public Sub RollbackTrans()
            If (mIsInTransaction) Then
                mTransaction.Rollback()
                mTransaction.Dispose()
                mIsInTransaction = False
            End If
        End Sub

        Public Sub CommitTrans()
            If (mIsInTransaction) Then
                mTransaction.Commit()
                mTransaction.Dispose()
                mIsInTransaction = False
            End If
        End Sub

        Public Function ExecuteNonQuery(ByVal sql As String) As Integer
            Dim result As Integer
            If (Me.mIsInTransaction) Then
                Using cmd As New OdbcCommand(sql, mConnection, mTransaction)
                    result = cmd.ExecuteNonQuery()
                End Using
            Else
                Using cmd As New OdbcCommand(sql, Me.mConnection)
                    result = cmd.ExecuteNonQuery()
                End Using
            End If
            Return result
        End Function

        Public Function ExecuteScalar(ByVal sql As String) As Object
            Dim result As Object
            If (Me.mIsInTransaction) Then
                Using cmd As New OdbcCommand(sql, Me.mConnection, Me.mTransaction)
                    result = cmd.ExecuteScalar()
                End Using
            Else
                Using cmd As New OdbcCommand(sql, Me.mConnection)
                    result = cmd.ExecuteScalar()
                End Using
            End If
            Return result
        End Function

        Public Function GetTable(ByVal sql As String) As DataTable
            Dim result As New DataTable()
            If (Me.mIsInTransaction) Then
                Using selectCommand As New OdbcCommand(sql, Me.mConnection, Me.mTransaction)
                    selectCommand.CommandTimeout = 0
                    Using adapter As New OdbcDataAdapter(selectCommand)
                        adapter.Fill(result)
                    End Using
                End Using
            Else
                Using adapter As New OdbcDataAdapter(sql, Me.mConnection)
                    adapter.Fill(result)
                End Using
            End If
            Return result
        End Function





#Region "IDisposable Support"
        Private disposedValue As Boolean

        Protected Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                End If

                If (mIsInTransaction) Then
                    mTransaction.Rollback()
                    mTransaction.Dispose()
                End If
                mConnection.Close()
                mConnection.Dispose()

            End If
            Me.disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region



    End Class



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try


                Dim t = New Thread(New ThreadStart(AddressOf Excel))
                t.Start()

                CircularProgress1.IsRunning = True


            Catch ex As Exception

            End Try
        End If


    End Sub
End Class