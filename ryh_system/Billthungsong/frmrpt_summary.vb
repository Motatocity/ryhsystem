Public Class frmrpt_summary
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim rpt1 As New CrystalReport3
    Dim rpt2 As New rpt_sumryh
    Public Sub New(ByVal sql As String, ByVal check As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If check = 0 Then
            Dim dt As New DataTable
            dt = ConnectionDB.GetTable(sql)
            rpt2.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt2

        End If
    End Sub
    Private Sub frmrpt_summary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim sql As String
        'Dim dt As New DataTable
        'sql = "select  idthungsongDB , thungsongdb.name2 as name, thungsongdb.share as total , share , idcardname from thungsongdb left join (SELECT sum( CASE when thungsong_round.thungsong_rundstat ='1' then   thungsong_round.thungsong_rundsum  else   0 end) as  share ,  thungsong_roundbill thungsong_round ) as thungsong_round  on thungsongdb.idthungsongDB = thungsong_round.thungsong_roundbill  group by idthungsongDB ORDER BY total;"
        'Dim set1 As DataSet = New DataSet("thungsong")

        'dt = ConnectionDB.GetTable(sql)


        'rpt1.SetDataSource(dt)
        'CrystalReportViewer1.ReportSource = rpt1
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class