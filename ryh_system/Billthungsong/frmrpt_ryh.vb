Public Class frmrpt_ryh
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim rpt1 As New CrystalReport8
    Private Sub frmrpt_ryh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim dt As New DataTable
        sql = "SELECT ryh_sum.IDNO as ID,name,share,sum / 2 AS sum FROM rajyindee_db.ryh_main left join ryh_sum on ryh_main.idryh_main = ryh_sum.ID;"
        Dim set1 As DataSet = New DataSet("ryh1")
        dt = ConnectionDB.GetTable(sql)
        rpt1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt1
    End Sub
End Class