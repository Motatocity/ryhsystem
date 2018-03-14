Imports Microsoft.Office

Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop

Public Class Class1
    Dim xApp As Excel.Application
    Dim xBook As Excel.Workbook
    Dim xSheet As Excel.Worksheet
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim mysql As MySqlConnection = frmdevice_main.mysqlconection2
    Dim arrayspilt() As String
    Dim idlast As String
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Public Sub TEST()
        Dim dt As New DataTable
        Try
            If MyODBCConnection.State = ConnectionState.Closed Then

                MyODBCConnection.Open()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Try


            xApp = New Excel.Application
            xBook = xApp.Workbooks.Add()
            xSheet = CType(xBook.Worksheets(1), Excel.Worksheet)


            Dim sql As String = "SHOW COLUMNS FROM REGCONV5PF;"
            Dim selectCMD As OdbcCommand = New OdbcCommand(sql)
            'selectCMD.Connection = MyODBCConnection
            Dim sqlAdapter As New OdbcDataAdapter(selectCMD)
            'sqlAdapter.Fill(dt)

            'MyODBCConnection.Close()
            'For i As Integer = 1 To dt.Rows.Count
            '    Dim xRng As Excel.Range = CType(xSheet.Cells(1, i), Excel.Range)
            '    xRng.Value = dt.Rows(i - 1)("Field").ToString()
            '    xRng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            '    xRng.EntireColumn.AutoFit()
            'Next i

            Try
                If MyODBCConnection.State = ConnectionState.Closed Then

                    MyODBCConnection.Open()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            '   Dim adapter As New OdbcDataAdapter
            sql = "SELECT * FROM  REGMASV5PF"
            Using adapter As New OdbcDataAdapter(sql, MyODBCConnection)
                adapter.Fill(dt)
            End Using

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
            xBook.SaveAs("C:\REGCONV5PF.xlsx")
            xApp.DisplayAlerts = True

        Catch ex As Exception
            xBook.Close()
            xApp.Quit()
            xSheet = Nothing
            MsgBox(ex.ToString)
        End Try

        xBook.Close()
        xApp.Quit()
    End Sub
End Class
