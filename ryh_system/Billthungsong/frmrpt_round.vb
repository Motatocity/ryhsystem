Public Class frmrpt_round
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim rpt1 As New rpt_round
    Private Sub frmrpt_round_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim dt As New DataTable
        sql = "SELECT thungsong_round1 as round ,thungsongdb.name2 as name1 ,tell,tell1,thungsong_rundsum as price,thungsong_rundshare as share FROM rajyindee_db.thungsong_round join thungsongdb on thungsong_round.thungsong_roundbill = thungsongdb.idthungsongDB where thungsong_rundstat  = '0';"
        Dim set1 As DataSet = New DataSet("round")

        dt = ConnectionDB.GetTable(sql)


        rpt1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt1
    End Sub
End Class