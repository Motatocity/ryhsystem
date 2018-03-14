Public Class frmmain_cloth

    Private Sub frmmain_cloth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CMDmasPatientInformation_Executed(sender As Object, e As EventArgs) Handles cmdmanage.Executed
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmcloth_manage Then
                f.Activate()
                Exit Sub
            Else

            End If
        Next
        Dim doc As New frmcloth_manage()
        doc.Text = "จัดการข้อมูลคลังผ้า"
        doc.MdiParent = Me
        doc.WindowState = FormWindowState.Maximized
        doc.Show()
        doc.Update()
    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
        cmdmanage.Execute()
    End Sub

    Private Sub cmdadjust_Executed(sender As Object, e As EventArgs) Handles cmdadjust.Executed
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmcloth_adjust Then
                f.Activate()
                Exit Sub
            Else

            End If
        Next
        Dim doc As New frmcloth_adjust()
        doc.Text = "จัดการข้อมูลคลังผ้า"
        doc.MdiParent = Me
        doc.WindowState = FormWindowState.Maximized
        doc.Show()
        doc.Update()
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        cmdadjust.Execute()
    End Sub
End Class