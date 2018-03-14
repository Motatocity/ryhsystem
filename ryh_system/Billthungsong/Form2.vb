Public Class Form2
    Dim rpt1 As New CrystalReport6
    Dim ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "SELECT name2,sum( if (thungsong_rundstat='1',thungsong_rundshare,0)) as sumall ,thungsong_roundbill FROM rajyindee_db.thungsong_round join thungsongdb on thungsong_round.thungsong_roundbill = thungsongdb.idthungsongDB  GROUP BY thungsong_roundbill;"
        Dim dt As New DataTable
        Dim set1 As DataSet = New DataSet("vote")

        dt = ConnectionDB.GetTable(sql)


        rpt1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt1
    End Sub
End Class