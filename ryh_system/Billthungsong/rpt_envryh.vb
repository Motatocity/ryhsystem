Public Class rpt_envryh
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim rpt1 As New rpt_envelopryh

    Private Sub rpt_envryh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim dt As New DataTable
        sql = "SELECT name ,address FROM ryh_main ;"
        Dim set1 As DataSet = New DataSet("ryhenv")
        dt = ConnectionDB.GetTable(sql)
        rpt1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt1
    End Sub
End Class