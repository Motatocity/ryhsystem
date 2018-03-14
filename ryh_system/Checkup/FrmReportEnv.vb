Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Public Class FrmReportEnv
    Dim position_user As String
    Public selectedEmployee As String
    Dim idcontainer As String
    Dim mysqlpass As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim id_hn As String
    Dim mysql As MySqlConnection
    Dim rpt1 As New LetterExam
    Dim cryRpt As New ReportDocument
    Dim namelast As String
    Dim companyname1 As String
    Dim check1 As String

    Public Sub New(ByRef name_last As String, ByRef company_name As String, ByRef checksub As String)
        namelast = name_last
        companyname1 = company_name
        check1 = checksub
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FrmReportEnv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        rpt1.SetParameterValue("nameHealth", namelast)
        rpt1.SetParameterValue("nameCompany", companyname1)
        If check1 = "1" Then
            rpt1.SetParameterValue("name", "Health Examination Summary")

        ElseIf check1 = "0" Then
            rpt1.SetParameterValue("name", "ผลตรวจสุขภาพ")
        End If

        CrystalReportViewer1.ReportSource = rpt1
        CrystalReportViewer1.Refresh()

    End Sub
End Class