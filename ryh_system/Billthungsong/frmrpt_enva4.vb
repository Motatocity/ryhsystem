Public Class frmrpt_enva4
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()

    Public Sub New()
        'rpt1.SetParameterValue("share", frmmain_thungsong.text1)
        'rpt1.Refresh()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmrpt_enva4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        'rpt1.SetParameterValue("share", frmmain_thungsong.text1)
        If frmmain_thungsong.checkTHUNGANDRYH = "0" Then
            Dim sql As String

            sql = "SELECT name2 as name1 ,address FROM rajyindee_db.thungsongdb ;"
            Dim set1 As DataSet = New DataSet("envelop")

            dt = ConnectionDB.GetTable(sql)
            Dim rpt1 As New CrystalReport7
            rpt1.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt1
        ElseIf frmmain_thungsong.checkTHUNGANDRYH = "1" Then
            Dim sql As String

            sql = "SELECT name as name1 ,address FROM rajyindee_db.ryh_main ;"
            Dim set1 As DataSet = New DataSet("envelop")

            dt = ConnectionDB.GetTable(sql)
            Dim rpt1 As New CrystalReport10
            rpt1.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt1

        End If



    End Sub

End Class