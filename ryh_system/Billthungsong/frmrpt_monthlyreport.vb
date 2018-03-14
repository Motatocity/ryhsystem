Public Class frmrpt_monthlyreport

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton2.Checked = True Then
            Dim sql As String

            sql = "SELECT ryh_main.name as 'name'  , ryh_main.tell as 'tell' ,ryh_sum as 'SUM' , ryh_date as 'dately' , ryh_date1 as 'dately1'  , count from  ryh_main JOIN rajyindee_db.ryh_sumdetail ON ryh_main.idryh_main =  ryh_sumdetail.idryh_main   JOIN  ryh_billdet ON  ryh_sumdetail.idryh_sumdetail = ryh_billdet.idryh_sumdet  WHERE ryh_date >= '" & DateTimePicker2.Value.Year.ToString & DateTimePicker2.Value.ToString("-MM-dd") & "' and ryh_date <= '" & DateTimePicker1.Value.Year.ToString & DateTimePicker1.Value.ToString("-MM-dd") & "';"

            Dim nextform As New frmrpt_monthly(DateTimePicker2.Value.ToString("dd-MM-") + DateTimePicker2.Value.Year.ToString, DateTimePicker1.Value.ToString("dd-MM-") + DateTimePicker1.Value.Year.ToString, sql, 1)
            nextform.Show()
        ElseIf RadioButton1.Checked Then

            Dim sql As String
            sql = "SELECT ryh_main.name as 'name'  , ryh_main.tell as 'tell' ,ROUND( sum * 1.5 ) as 'SUM'  , count from  ryh_main JOIN rajyindee_db.ryh_sumdetail ON ryh_main.idryh_main =  ryh_sumdetail.idryh_main    WHERE count = " & TextBox1.Text & " and checkryh= 0 ;"
            Dim nextform As New frmrpt_monthly(sql, "2")
            nextform.Show()
        End If


    End Sub

    Private Sub frmrpt_monthlyreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupControl1.Enabled = False
            GroupControl2.Enabled = True
        Else
            GroupControl1.Enabled = True
            GroupControl2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupControl1.Enabled = False
            GroupControl2.Enabled = True
        Else
            GroupControl1.Enabled = True
            GroupControl2.Enabled = False
        End If
    End Sub
End Class