Public Class frmrpt_result
    Dim rpt1 As New CrystalReport5
    Dim ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Private Sub frmrpt_result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "SELECT name2,price,share,address,tell,thungsong_round1,  IF(thungsong_rundstat = 1,'ชำระเรียบร้อย','ยังไม่ได้ชำระ') as thungsong_rundstat   ,thungsong_rundsum,thungsong_rundshare,thungsong_date FROM rajyindee_db.thungsongdb join thungsong_round on thungsong_round.thungsong_roundbill = thungsongdb.idthungsongDB;"

        Dim dt As New DataTable
        Dim set1 As DataSet = New DataSet("result")

        dt = ConnectionDB.GetTable(sql)


        rpt1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt1

    End Sub
End Class