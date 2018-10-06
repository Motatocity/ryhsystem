Public Class frmrpt_checkuprecheck
    Dim rpt1 As New reportOilCompany_2
    Private Sub frmrpt_checkuprecheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CrystalReportViewer1.ReportSource = rpt1


        CrystalReportViewer1.Refresh()

    End Sub
End Class