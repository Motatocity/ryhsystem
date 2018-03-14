Option Explicit On

Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports System.Threading

Public Class frmit_opdtime
    Dim arrayspilt() As String
    Dim path As String
    Dim condb As connectHIM
    '= connectHIM.NewConnection
    Dim dt As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        sql = " SELECT T1.OAPREGDTE , T1.OAPHN, T1.OAPFRMTIM AS REGISTER, T1.OAPSNDTIM AS SENDCARD, T1.OAPAPPTTIM AS SCREENING, T1.OAPINTIM AS NCU, T1.OAPINTIM AS DOCTORIN,  "
        sql += " T1.OAPOUTTIM AS DOCTOROUT, T3.PWDDOCTIM AS SCANDR, T4.BTMINTIM AS REQPRX, T1.OBMRCPTIM AS BILL, T4.BTMCFMTIM AS CONPRX,  "
        sql += "  T4.BTMISSTIM AS SENDPRX , T1.OAPCATE , T1.OAPDRCOD ,T5.RTBTABNAM ,T6.DMSPRENAM ,T6.DMSNAME , T6.DMSSURNAM "
        sql += "  FROM (SELECT RYHPFV5.OPDAPPV5PF.OAPHN, RYHPFV5.OPDAPPV5PF.OAPDIVCOD, RYHPFV5.OPDAPPV5PF.OAPFRMTIM, RYHPFV5.OPDAPPV5PF.OAPSNDTIM, "
        sql += " RYHPFV5.OPDAPPV5PF.OAPAPPTTIM, RYHPFV5.OPDAPPV5PF.OAPINTIM, RYHPFV5.OPDAPPV5PF.OAPREGDTE, RYHPFV5.OPDAPPV5PF.OAPDOCNO,  "
        sql += " RYHPFV5.OPDAPPV5PF.OAPOUTTIM, RYHPFV5.OBLMASV5PF.OBMRCPTIM ,   RYHPFV5.OPDAPPV5PF.OAPDRCOD , RYHPFV5.OPDAPPV5PF.OAPCATE  "
        sql += " FROM RYHPFV5.OPDAPPV5PF, RYHPFV5.OBLMASV5PF "
        sql += " WHERE RYHPFV5.OPDAPPV5PF.OAPHN = RYHPFV5.OBLMASV5PF.OBMHN AND  "
        sql += " RYHPFV5.OPDAPPV5PF.OAPVN = SUBSTR(DIGITS(RYHPFV5.OBLMASV5PF.OBMVN), 7, 4) AND "
        sql += "  RYHPFV5.OPDAPPV5PF.OAPSEQNO = SUBSTR(DIGITS(RYHPFV5.OBLMASV5PF.OBMVN), 11, 2) AND "
        sql += " RYHPFV5.OPDAPPV5PF.OAPREGDTE = RYHPFV5.OBLMASV5PF.OBMRCPDTE AND (RYHPFV5.OPDAPPV5PF.OAPREGDTE > 25571100 AND "
        sql += " OAPREGDTE < 25580230) AND (RYHPFV5.OPDAPPV5PF.OAPCRDSTS <> 'C') AND (RYHPFV5.OPDAPPV5PF.OAPFRMTIM BETWEEN 0000 AND 2400)  ) T1,   "
        sql += "  (SELECT PWDDOCTIM, PWDDOCDTE, PWDDOCNO "
        sql += " FROM RYHPFV5.PRXWRDV5PF "
        sql += " WHERE (PWDDOCTYP = '01')) T3, "
        sql += " (SELECT BTMCFMTIM, BTMINTIM, BTMISSTIM, BTMDOCDTE, BTMDOCNO "
        sql += " FROM RYHPFV5.BILTRMV5PF) T4 , ( SELECT RTBTABCOD, RTBTABNAM "
        sql += " FROM RYHPFV5.REGTABV5PF "
        sql += " WHERE (RTBTABTYP = '54') "
        sql += " ) AS T5  ,( SELECT        DMSDRCOD, DMSPRENAM, DMSNAME, DMSSURNAM "
        sql += " FROM RYHPFV5.DRMASV5PF  ) T6  "
        sql += " WHERE T3.PWDDOCDTE = T1.OAPREGDTE AND T3.PWDDOCNO = T1.OAPDOCNO AND T1.OAPREGDTE = T4.BTMDOCDTE AND T1.OAPDOCNO = T4.BTMDOCNO AND T1.OAPCATE = T5.RTBTABCOD AND T6.DMSDRCOD = T1.OAPDRCOD "
        dt = condb.GetTable(sql)
        FolderBrowserDialog1.Description = "Pick Folder to store Excecl files"
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.SelectedPath = "C:\"
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try


                'Dim t = New Thread(New ThreadStart(AddressOf excelDaily))
                't.Start()
                excelDaily()
                CircularProgress1.IsRunning = True


            Catch ex As Exception
                MsgBox(ex.ToString.Trim)
                CircularProgress1.IsRunning = False
            End Try
        End If

    End Sub

    Private Sub frmit_opdtime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.PATH
    End Sub

    Private Sub excelDaily()

        Dim pathExcel As String
        Dim count As Integer = 11

        Dim countcontainer As Integer = 1
        pathExcel = FolderBrowserDialog1.SelectedPath
        Dim excelapp As New Excel.Application
        Dim excelbooks As Excel.Workbook
        Dim excelsheets As Excel.Worksheet
        excelbooks = excelapp.Workbooks.Add
        excelsheets = CType(excelbooks.Worksheets(1), Excel.Worksheet)

        Dim x As Integer = 1
        With excelsheets
            For i As Integer = 0 To dt.Rows.Count - 1
                ' For i As Integer = 0 To 30

                With .Range("A" + x.ToString.Trim + ":A" + x.ToString.Trim)
                    .Value = dt.Rows(i)("OAPHN").ToString.Trim
                    '.NumberFormat = "hh:MM;@"
                End With
                With .Range("B" + x.ToString.Trim + ":B" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("REGISTER").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("C" + x.ToString.Trim + ":C" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("SENDCARD").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("D" + x.ToString.Trim + ":D" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("SCREENING").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("E" + x.ToString.Trim + ":E" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("NCU").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("F" + x.ToString.Trim + ":F" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("DOCTORIN").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("G" + x.ToString.Trim + ":G" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("DOCTOROUT").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("H" + x.ToString.Trim + ":H" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("SCANDR").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("I" + x.ToString.Trim + ":I" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("REQPRX").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("J" + x.ToString.Trim + ":J" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("BILL").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("K" + x.ToString.Trim + ":K" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("CONPRX").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With
                With .Range("L" + x.ToString.Trim + ":L" + x.ToString.Trim)
                    .Value = SETFORMAT(dt.Rows(i)("SENDPRX").ToString.Trim)
                    .NumberFormat = "hh:MM;@"
                End With

                With .Range("M" + x.ToString.Trim + ":M" + x.ToString.Trim)
                    .Value = dt.Rows(i)("RTBTABNAM").ToString.Trim
                    '    .NumberFormat = "hh:MM;@"
                End With
                With .Range("N" + x.ToString.Trim + ":N" + x.ToString.Trim)
                    .Value = dt.Rows(i)("OAPCATE").ToString.Trim.Trim
                    '   .NumberFormat = "hh:MM;@"
                End With
                With .Range("O" + x.ToString.Trim + ":O" + x.ToString.Trim)
                    .Value = dt.Rows(i)("OAPDRCOD").ToString.Trim.Trim
                    '  .NumberFormat = "hh:MM;@"
                End With
                With .Range("P" + x.ToString.Trim + ":P" + x.ToString.Trim)
                    .Value = dt.Rows(i)("DMSPRENAM").ToString.Trim.Trim + dt.Rows(i)("DMSNAME").ToString.Trim.Trim + dt.Rows(i)("DMSSURNAM").ToString.Trim.Trim
                    '.NumberFormat = "hh:MM;@"
                End With
                With .Range("Q" + x.ToString.Trim + ":Q" + x.ToString.Trim)
                    .Value = dt.Rows(i)("OAPREGDTE").ToString.Trim.Trim
                    '.NumberFormat = "hh:MM;@"
                End With
                ' T1.OAPCATE , T1.OAPDRCOD ,T5.RTBTABNAM ,T6.DMSPRENAM ,T6.DMSNAME , T6.DMSSURNAM "
                x += 1
            Next
        End With


        Try
            excelbooks.SaveAs(pathExcel.ToString.Trim + "\OPTIME.xlsx")

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
    Public Shared Function SETFORMAT(VALUE As String) As String
        If VALUE.ToString.Trim.Length = 1 Then
            Return "00:0" + VALUE
        ElseIf VALUE.ToString.Trim.Length = 2 Then
            Return "00:" + VALUE
        ElseIf VALUE.ToString.Trim.Length = 3 Then
            Return "0" + Microsoft.VisualBasic.Left(VALUE, VALUE.Length - 2) + ":" + VALUE.Substring(VALUE.Length - 2)
        ElseIf VALUE.ToString.Trim.Length = 4 Then
            Return Microsoft.VisualBasic.Left(VALUE, VALUE.Length - 2) + ":" + VALUE.Substring(VALUE.Length - 2)

        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With OpenFileDialog1
            .Filter = "Excel File  (*.xlsx) | *.xls"
            If (.ShowDialog() = DialogResult.OK) Then
                Dim fi As New System.IO.FileInfo(.FileName)
                path = .FileName
                arrayspilt = Split(fi.Name, "_")
            End If
        End With
        getexcel_new()

    End Sub
    Public Sub getexcel_new()
        ListView1.Items.Clear()

        Dim xlApp As New Excel.Application
        Dim xlBook As Excel.Workbook
        Dim xlSheet1 As Excel.Worksheet
        Dim i As Integer
        xlBook = xlApp.Workbooks.Open(path)
        'xlBook.Application.Visible = False
        xlSheet1 = xlBook.Worksheets(1)

        i = 1
        Do While Not Trim(xlSheet1.Cells.Item(i, 1).Value) = ""
            '*** Rows ***'
            Try

                With ListView1.Items.Add(xlSheet1.Cells.Item(i, 1).value.ToString)
                    Try
                        .SubItems.Add(xlSheet1.Cells.Item(i, 2).value.ToString)
                    Catch ex As Exception

                    End Try
                    Try
                        .SubItems.Add(xlSheet1.Cells.Item(i, 3).value.ToString)
                    Catch ex As Exception

                    End Try
                    Try
                        .SubItems.Add(xlSheet1.Cells.Item(i, 4).value.ToString)

                    Catch ex As Exception
                        .SubItems.Add("0")
                    End Try
                    Try
                        .SubItems.Add(xlSheet1.Cells.Item(i, 5).value.ToString)

                    Catch ex As Exception
                        .SubItems.Add("0")
                    End Try
                    Try
                        .SubItems.Add(xlSheet1.Cells.Item(i, 6).value.ToString)

                    Catch ex As Exception

                    End Try
                    Try
                        .SubItems.Add(xlSheet1.Cells.Item(i, 7).value.ToString)
                    Catch ex As Exception

                    End Try
                    Try
                        .SubItems.Add(xlSheet1.Cells.Item(i, 8).value.ToString)

                    Catch ex As Exception

                    End Try
                    Try
                        .SubItems.Add(xlSheet1.Cells.Item(i, 9).value.ToString)

                    Catch ex As Exception

                    End Try
                    Try
                        .SubItems.Add(xlSheet1.Cells.Item(i, 10).value.ToString)
                    Catch ex As Exception

                    End Try

                End With

            Catch ex As Exception
            End Try

            i = i + 1
        Loop
        '*** Quit and Clear Object ***'
        xlBook.Close()
        xlApp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)


        xlSheet1 = Nothing
        xlBook = Nothing
        xlApp = Nothing


        Dim proc As System.Diagnostics.Process

        For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
            proc.Kill()
        Next
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connectdb As connectHIM
        connectdb = connectHIM.NewConnection
        Dim sql As String
        sql = "UPDATE RYHPF.STFTAXV4PF SET  STXBNKAC = 4041571343 WHERE        (STXSTFNO = 560054)"
        connectdb.ExecuteNonQuery(sql)
        connectdb.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connectdb As connectHIM

        '   connectdb.BeginTrans()

        For counter1 = 0 To ListView1.Items.Count - 1

            Try
                connectdb = connectHIM.NewConnection
                Dim sql As String
                sql = "UPDATE RYHPF.STFTAXV4PF SET  STXBNKAC = " & Convert.ToInt64(ListView1.Items(counter1).SubItems(1).Text.ToString.Trim) & " WHERE (STXSTFNO = " & Convert.ToInt64(ListView1.Items(counter1).SubItems(0).Text.ToString.Trim) & ")"
                connectdb.ExecuteNonQuery(sql)
                connectdb.Dispose()

            Catch ex As Exception
                'connectdb.RollbackTrans()
                MsgBox(ex.ToString)
            End Try


        Next
        Try
            ' connectdb.CommitTrans()
        Catch ex As Exception
            'connectdb.RollbackTrans()
            MsgBox(ex.ToString)
        End Try
        MsgBox("Complete ตายแน่")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connectdb As connectHIM

        '   connectdb.BeginTrans()

        For counter1 = 0 To ListView1.Items.Count - 1

            Try
                connectdb = connectHIM.NewConnection
                Dim sql As String
                sql = "UPDATE RYHPFV5.STFTAXV5PF SET  STXBNKAC = " & Convert.ToInt64(ListView1.Items(counter1).SubItems(1).Text.ToString.Trim) & " WHERE (STXSTFNO = " & Convert.ToInt64(ListView1.Items(counter1).SubItems(0).Text.ToString.Trim) & ")"
                connectdb.ExecuteNonQuery(sql)
                connectdb.Dispose()

            Catch ex As Exception
                'connectdb.RollbackTrans()
                MsgBox(ex.ToString)
            End Try


        Next
        Try
            ' connectdb.CommitTrans()
        Catch ex As Exception
            'connectdb.RollbackTrans()
            MsgBox(ex.ToString)
        End Try
        MsgBox("Complete ตายแน่")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim connectdb As ConnecDBRYH

        For counter1 = 0 To ListView1.Items.Count - 1

            Try
                connectdb = connectdb.NewConnection
                Dim sql As String
                sql = "UPDATE rajyindee_db.thungsongdb SET  name = '" & Convert.ToString(ListView1.Items(counter1).SubItems(1).Text.ToString.Trim) & "'  WHERE (idthungsongDB = " & Convert.ToInt64(ListView1.Items(counter1).SubItems(0).Text.ToString.Trim) & ")"
                connectdb.ExecuteNonQuery(sql)
                connectdb.Dispose()

            Catch ex As Exception
                'connectdb.RollbackTrans()
                MsgBox(ex.ToString)
            End Try


        Next
        Try
            ' connectdb.CommitTrans()
        Catch ex As Exception
            'connectdb.RollbackTrans()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim connectdb As ConnecDBRYH

        For counter1 = 0 To ListView1.Items.Count - 1

            Try
                connectdb = ConnecDBRYH.NewConnection
                Dim sql As String
                sql = "UPDATE rajyindee_db.thungsongdb SET name ='" & Convert.ToString(ListView1.Items(counter1).SubItems(1).Text.ToString.Trim) & "'  , share  = '" & Convert.ToInt64(ListView1.Items(counter1).SubItems(2).Text.ToString.Trim) & "' ,   mname = '" & Convert.ToString(ListView1.Items(counter1).SubItems(6).Text.ToString.Trim) & "' , lname ='" & Convert.ToString(ListView1.Items(counter1).SubItems(7).Text.ToString.Trim) & "'  , number_start = " & Convert.ToString(ListView1.Items(counter1).SubItems(8).Text.ToString.Trim) & "  , number_to = " & Convert.ToString(ListView1.Items(counter1).SubItems(9).Text.ToString.Trim) & " , type = '" & Convert.ToString(ListView1.Items(counter1).SubItems(5).Text.ToString.Trim) & "'  WHERE  idthungsongDB = " & Convert.ToInt64(ListView1.Items(counter1).SubItems(0).Text.ToString.Trim) & " ; "

                connectdb.ExecuteNonQuery(sql)
                connectdb.Dispose()

                sql = "SELECT idthungsong_round,thungsong_round1 from thungsong_round WHERE thungsong_roundbill = '" & Convert.ToInt64(ListView1.Items(counter1).SubItems(0).Text.ToString.Trim) & "' AND (   thungsong_round1 = 1 OR thungsong_round1 = 2 ) "
                Dim dt As New DataTable
                connectdb = ConnecDBRYH.NewConnection
                dt = connectdb.GetTable(sql)
                connectdb.Dispose()


                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i)("thungsong_round1") = 1 Then
                        If Convert.ToInt64(ListView1.Items(counter1).SubItems(4).Text.ToString.Trim) > 0 Then
                            sql = "INSERT INTO rajyindee_db.thungsong_rec  (IDTHUNGSONGBILL,idthungsong_round ) VALUES (" & Convert.ToInt64(ListView1.Items(counter1).SubItems(4).Text.ToString.Trim) & " , " & dt.Rows(i)("idthungsong_round") & ") ; "
                            connectdb = ConnecDBRYH.NewConnection

                            connectdb.ExecuteNonQuery(sql)
                            connectdb.Dispose()
                        End If
                    ElseIf dt.Rows(i)("thungsong_round1") = 2 Then
                        If Convert.ToInt64(ListView1.Items(counter1).SubItems(3).Text.ToString.Trim) > 0 Then

                            sql = "INSERT INTO rajyindee_db.thungsong_rec  (IDTHUNGSONGBILL,idthungsong_round ) VALUES (" & Convert.ToInt64(ListView1.Items(counter1).SubItems(3).Text.ToString.Trim) & " , " & dt.Rows(i)("idthungsong_round") & ") ; "
                            connectdb = ConnecDBRYH.NewConnection

                            connectdb.ExecuteNonQuery(sql)
                            connectdb.Dispose()
                        End If

                    End If
                Next
                'sql = "UPDATE rajyindee_db.thungsongdb SET  name = '" & Convert.ToString(ListView1.Items(counter1).SubItems(1).Text.ToString.Trim) & "'  WHERE (idthungsongDB = " & Convert.ToInt64(ListView1.Items(counter1).SubItems(0).Text.ToString.Trim) & ")"
                'connectdb.ExecuteNonQuery(sql)
                connectdb.Dispose()

            Catch ex As Exception
                'connectdb.RollbackTrans()
                MsgBox(ex.ToString)
            End Try


        Next
   


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Settings.PATH = TextBox1.Text
        My.Settings.Save()
        TextBox1.Text = My.Settings.PATH
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim sms As New SENDSMS
        sms.SENDSMS("0869684959", "ทดสอบ1 โย่วแย่")
        sms.SENDSMS("0873919831", "ทดสอบ2 โย่วแย่")
        sms.SENDSMS("0874795771", "ทดสอบ3 โย่วแย่")
        sms.SENDSMS("0835338571", "ทดสอบ4 โย่วแย่")
        sms.SENDSMS("0836358514", "ทดสอบ5 โย่วแย่")
    End Sub
End Class