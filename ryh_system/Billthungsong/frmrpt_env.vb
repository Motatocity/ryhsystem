Public Class frmrpt_env
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim rpt1 As New rpt_envelopdl
    Public Sub New()
        rpt1.SetParameterValue("share", frmmain_thungsong.text1)
        rpt1.Refresh()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmrpt_env_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim dt As New DataTable
        sql = "SELECT name2 as name1 ,address FROM rajyindee_db.thungsongdb ;"
        Dim set1 As DataSet = New DataSet("envelop")

        dt = ConnectionDB.GetTable(sql)

        rpt1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt1
    End Sub
End Class