Public Class frmrpt_byalone
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim rpt1 As New rpt_alone
    Private Sub frmrpt_byalone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim dt As New DataTable
        sql = "SELECT idthungsong_bill as idkey, thungsongdb.name2 as name ,  1, thungsong_date as datenow , thungsong_sum as price , thungsong_sumshare as share  FROM rajyindee_db.thungsong_bill join thungsongdb on thungsongdb.idthungsongDB = thungsong_bill.idname ;"
        Dim set1 As DataSet = New DataSet("alonedb")

        dt = ConnectionDB.GetTable(sql)


        rpt1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt1
    End Sub
End Class