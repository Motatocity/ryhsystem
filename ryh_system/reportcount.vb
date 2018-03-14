Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core


Public Class reportcount
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Dim adapterfill As DataTable




    Private Sub reportcount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Open the connection
        'Try
        '    If MyODBCConnection.State = ConnectionState.Closed Then

        '        MyODBCConnection.Open()
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        '' Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT * FROM REGMASV5PF WHERE RMSHNNO='7708' and RMSHNYR = '56'")
        'Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT   OMDSURGRP,OMDSURTYP,OMDSURNAM,OMSDOCDTE,OMSHN,RMSNAME,RMSSURNAM,RMSSEX FROM RYHPFV5.ORCMDSV5PF join orcmasv5pf on ORCMDSV5PF.OMDDOCNO =  orcmasv5pf.omsdocno join regmasv5pf on orcmasv5pf.OMSHN = regmasv5pf.rmshnref")

        'selectCMD.Connection = MyODBCConnection


        'Try
        '    'Set the mouse to show a Wait cursor
        '    Dim dr As OdbcDataAdapter = New OdbcDataAdapter

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try


        'MyODBCConnection.Close()

        'CrystalReportViewer1.ReportSource = rpt1
    End Sub

End Class