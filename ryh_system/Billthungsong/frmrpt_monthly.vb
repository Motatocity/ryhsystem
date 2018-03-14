Public Class frmrpt_monthly
    Dim rpt1 As New rpt_monthly
    Dim rpt2 As New rptreport_count
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim dates As String
    Dim dateend As String
    Dim sqlstring As String
    Dim check As String
    Public Sub New(ByVal sql As String, ByVal check1 As String)

        ' This call is required by the designer.
        InitializeComponent()
        sqlstring = sql
        ' Add any initialization after the InitializeComponent() call.
        check = check1
    End Sub
    Public Sub New(ByVal date1 As String, ByVal date2 As String, ByVal sql As String, ByVal check1 As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sqlstring = sql
        dates = date1
        dateend = date2
        check = check1

    End Sub
    Private Sub frmrpt_monthly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If check = "1" Then
            Dim dt As New DataTable
            dt = ConnectionDB.GetTable(sqlstring)

            rpt1.SetDataSource(dt)
            rpt1.SetParameterValue("date1", dates)
            rpt1.SetParameterValue("date2", dateend)
            CrystalReportViewer1.ReportSource = rpt1
            CrystalReportViewer1.Refresh()
        ElseIf check = "2" Then
            Dim dt As New DataTable
            dt = ConnectionDB.GetTable(sqlstring)

            rpt2.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt2
            CrystalReportViewer1.Refresh()


        End If

    End Sub
End Class