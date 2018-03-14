Public Class frmrpt_risk
    Public Shared date1 As String
    Public Shared date2 As String

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        date1 = DateTimePicker1.Value.ToString("dd/MM/yyyy")
        date2 = DateTimePicker2.Value.ToString("dd/MM/yyyy")
        Dim nextform As rpt_risk = New rpt_risk
        nextform.Show()
    End Sub

    Private Sub frmrpt_risk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class