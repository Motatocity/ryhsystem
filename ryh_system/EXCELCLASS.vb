
Imports Excel = Microsoft.Office.Interop.Excel
Public Class EXCELCLASS
    Dim xApp As Excel.Application
    Dim xBook As Excel.Workbook
    Dim xSheet As Excel.Worksheet

    Public Overridable ReadOnly Property GetSheet() As Excel.Worksheet
        Get
            Return xSheet
        End Get
    End Property

    Public Sub NewFile(ByVal saveLocation As String, ByVal tableName As String)
        Dim db = ConnecDBRYH.NewConnection
        Dim dt As New DataTable()
        Dim sql As String
        If tableName = "Drugitem" Then
            sql = "SHOW COLUMNS FROM myfriendsdb." & tableName & ""
        ElseIf tableName = "Lab_order" Then
            sql = "SHOW COLUMNS FROM myfriendsdb." & tableName & ""
        Else
            sql = "SHOW COLUMNS FROM myfriendsdb." & tableName & " WHERE(`Key` <> 'PRI');"
        End If
        dt = db.GetTable(sql)
        db.Dispose()
        Try
            xApp = New Excel.Application
            xBook = xApp.Workbooks.Add()
            xSheet = CType(xBook.Worksheets(1), Excel.Worksheet)
            For i As Integer = 1 To dt.Rows.Count
                Dim xRng As Excel.Range = CType(xSheet.Cells(1, i), Excel.Range)
                xRng.Value = dt.Rows(i - 1)("Field").ToString()
                xRng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xRng.EntireColumn.AutoFit()
            Next i
            xApp.DisplayAlerts = False
            xBook.SaveAs(saveLocation)
            xApp.DisplayAlerts = True
        Catch ex As Exception
            xBook.Close()
            xApp.Quit()
            xSheet = Nothing
        End Try
        xBook.Close()
        xApp.Quit()
        OpenFile(saveLocation)
    End Sub

    Public Sub OpenFile(ByVal dir As String)
        CloseFile()
        xApp = New Excel.Application
        Try
            xBook = xApp.Workbooks.Open(dir)
            xSheet = xBook.Worksheets(1)
            xApp.Visible = True
        Catch
            xApp.Quit()
        End Try
    End Sub

    Public Sub CloseFile()
        releaseObject(xApp)
        releaseObject(xBook)
        releaseObject(xSheet)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub ExportData(ByVal saveLocation As String, ByVal tableName As String)
        Dim db = ConnecDBRYH.NewConnection
        Dim dt As New DataTable()
        Try
            xApp = New Excel.Application
            xBook = xApp.Workbooks.Add()
            xSheet = CType(xBook.Worksheets(1), Excel.Worksheet)

            Dim sql As String = "SHOW COLUMNS FROM myfriendsdb." & tableName & ";"
            dt = db.GetTable(sql)
            For i As Integer = 1 To dt.Rows.Count
                Dim xRng As Excel.Range = CType(xSheet.Cells(1, i), Excel.Range)
                xRng.Value = dt.Rows(i - 1)("Field").ToString()
                xRng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xRng.EntireColumn.AutoFit()
            Next i

            sql = "SELECT * FROM " & tableName & "  ;"
            dt = db.GetTable(sql)
            db.Dispose()

            For i As Integer = 0 To dt.Rows.Count - 1
                For j As Integer = 0 To dt.Columns.Count - 1
                    Dim xRng As Excel.Range = CType(xSheet.Cells(i + 2, j + 1), Excel.Range)
                    xRng.Value = dt.Rows(i)(j).ToString()
                    If xRng.Value IsNot Nothing And TypeOf (xRng.Value) Is Boolean Then
                        If Convert.ToBoolean(xRng.Value) = True Then
                            xRng.Value = 1
                        ElseIf Convert.ToBoolean(xRng.Value) = False Then
                            xRng.Value = 0
                        End If
                    End If
                    xRng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    'xRng.EntireColumn.AutoFit()
                Next j
            Next i

            xApp.DisplayAlerts = False
            xBook.SaveAs(saveLocation)
            xApp.DisplayAlerts = True

        Catch ex As Exception
            xBook.Close()
            xApp.Quit()
            xSheet = Nothing
        End Try

        xBook.Close()
        xApp.Quit()
        OpenFile(saveLocation)
    End Sub

End Class

