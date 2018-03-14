Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.Odbc
Imports System.Threading

Public Class frmit_himexcel
    Dim excel As EXCELCLASS1 = New EXCELCLASS1
    Private Sub frmit_himexcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel File 2003 (*.xls)|*.xls|Excel File 2007-2013 (*.xlsx)|*.xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = TextBox1.Text & "_MASTER.xlsx"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            'MsgBox(saveFileDialog1.FileName.ToString)
            excel.ExportData(saveFileDialog1.FileName, TextBox1.Text)
        End If
        'If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Try
        '        Dim t = New Thread(New ThreadStart(AddressOf excelReport))
        '        t.Start()

        '    Catch ex As Exception

        '    End Try
        'End If

    End Sub

    Private Sub excelReport()


        Dim pathExcel As String
        Dim count As Integer = 7


        pathExcel = FolderBrowserDialog1.SelectedPath
        excel.ExportData(pathExcel, TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel File 2003 (*.xls)|*.xls|Excel File 2007-2013 (*.xlsx)|*.xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = TextBox4.Text & "_MASTER.xlsx"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            'MsgBox(saveFileDialog1.FileName.ToString)
            excel.ExportData1(saveFileDialog1.FileName, TextBox4.Text)
        End If
    End Sub
End Class
Public Class EXCELCLASS1
    Dim xApp As Excel.Application
    Dim xBook As Excel.Workbook
    Dim xSheet As Excel.Worksheet

    Public Overridable ReadOnly Property GetSheet() As Excel.Worksheet
        Get
            Return xSheet
        End Get
    End Property

    Public Sub NewFile(ByVal saveLocation As String, ByVal tableName As String)
        Dim db = connectHIM.NewConnection
        Dim dt As New DataTable()
        Dim sql As String
        If tableName = "Drugitem" Then
            sql = "SHOW COLUMNS FROM " & tableName & ""
        ElseIf tableName = "Lab_order" Then
            sql = "SHOW COLUMNS FROM " & tableName & ""
        ElseIf tableName = "provider" Then
            sql = "SHOW COLUMNS FROM " & tableName & ""
        ElseIf tableName = "masclinic" Then
            sql = "SHOW COLUMNS FROM " & tableName & ""
        ElseIf tableName = "mashosp" Then
            sql = "SHOW COLUMNS FROM " & tableName & ""
        Else
            sql = "SHOW COLUMNS FROM " & tableName & " WHERE(`Key` <> 'PRI');"
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
        Dim db = connectHIM.NewConnection
        Dim dt As New DataTable()
        Try
            xApp = New Excel.Application
            xBook = xApp.Workbooks.Add()
            xSheet = CType(xBook.Worksheets(1), Excel.Worksheet)

            Dim sql As String = "SHOW COLUMNS FROM RYHPFV5." & tableName & ";"
            sql = " SELECT        COLUMN_NAME"
            sql += "   FROM  qsys2.syscolumns "
            sql += " WHERE        (table_schema = 'RYHPFV5') AND (table_name = '" & tableName & "')"
            dt = db.GetTable(sql)
            For i As Integer = 1 To dt.Rows.Count
                Dim xRng As Excel.Range = CType(xSheet.Cells(1, i), Excel.Range)
                xRng.Value = dt.Rows(i - 1)("COLUMN_NAME").ToString()
                xRng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xRng.EntireColumn.AutoFit()
            Next i

            sql = "SELECT * FROM RYHPFV5." & tableName & ""
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
            MsgBox(ex.ToString)
            xBook.Close()
            xApp.Quit()
            xSheet = Nothing
        End Try

        xBook.Close()
        xApp.Quit()
        OpenFile(saveLocation)
    End Sub
    Public Sub ExportData1(ByVal saveLocation As String, ByVal tableName As String)
        Dim db = ConnecDBRYH.NewConnection
        Dim dt As New DataTable()
        Try
            xApp = New Excel.Application
            xBook = xApp.Workbooks.Add()
            xSheet = CType(xBook.Worksheets(1), Excel.Worksheet)
            Dim sql As String = "SHOW COLUMNS FROM rajyindee_db." & tableName & ";"
            dt = db.GetTable(sql)
            For i As Integer = 1 To dt.Rows.Count
                Dim xRng As Excel.Range = CType(xSheet.Cells(1, i), Excel.Range)
                xRng.Value = dt.Rows(i - 1)("COLUMN_NAME").ToString()
                xRng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xRng.EntireColumn.AutoFit()
            Next i

            sql = "SELECT * FROM RYHPFV5." & tableName & ""
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
            MsgBox(ex.ToString)
            xBook.Close()
            xApp.Quit()
            xSheet = Nothing
        End Try

        xBook.Close()
        xApp.Quit()
        OpenFile(saveLocation)
    End Sub
End Class

Public Class connectHIM
    Implements IDisposable
    Private Shared ReadOnly strCommon As String = "DSN=RYHPFV5;uid=mse;Password=m0116;"

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
            Using selectCommand As New OdbcCommand(sql, Me.mConnection)
                selectCommand.CommandTimeout = 0
                Using adapter As New OdbcDataAdapter(selectCommand)
                    adapter.Fill(result)
                End Using

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