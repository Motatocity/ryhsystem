Public Class rpt_risk
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim rpt1 As New report_riskbook
    'SELECT risk_date_s as dateday , risk_point as riskpoint , risk_volume as riskvolume , risk_pro as riskprok , risk_statcheck as riskstatcheck,idrisk_book as idkey FROM rajyindee_db.risk_book;
    Private Sub rpt_risk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sql As String
        Dim dt As New DataTable
        sql = "SELECT risk_date_s as dateday , risk_point as riskpoint , risk_volume as riskvolume , risk_pro as riskpro , risk_statcheck as riskstatcheck,idrisk_book as idkey FROM rajyindee_db.risk_book where risk_dep ='" & frmlogin_dept.dept & "';"
        Dim set1 As DataSet = New DataSet("riskdb")

        dt = ConnectionDB.GetTable(sql)


        rpt1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt1
    End Sub
End Class