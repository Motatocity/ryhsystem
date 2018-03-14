Public Class frmrpt_boj5
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim rpt1 As New BOJ5
    Private Sub frmrpt_boj5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim dt As New DataTable
        sql = " SELECT name2 as name ,address , price as fund ,thungsongdb.name  , number_start , number_to  FROM rajyindee_db.thungsongdb ORDER BY thungsongdb.number_start ASC  ;"
        Dim set1 As DataSet = New DataSet("BOJ")

        dt = ConnectionDB.GetTable(sql)

        rpt1.SetDataSource(dt)
        rpt1.SetParameterValue("glass_2", "<p ><font>&#10003;</font></p>")
        CrystalReportViewer1.ReportSource = rpt1
    End Sub
End Class