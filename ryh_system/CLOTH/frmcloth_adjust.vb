Public Class frmcloth_adjust

    Private Sub frmcloth_adjust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Node2_NodeClick(sender As Object, e As EventArgs) Handles Node2.NodeClick
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmcloth_addjust1 Then
                f.Activate()
                f.Refresh()
                f.BringToFront()
                Exit Sub
            Else

            End If
        Next
        'Dim CMSPHERE As New SOFTWARELIST("testja") ไว้ส่งค่าข้ามฟอร์ม
        'Me.PanelEx1.Parent = Nothing
        Dim CMSPHERE As New frmcloth_addjust1()
        CMSPHERE.MdiParent = Me.MdiParent
        CMSPHERE.Parent = Me.PanelEx1
        CMSPHERE.Dock = DockStyle.Fill
        CMSPHERE.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Me.AdvTree1.Dock = DockStyle.Right
        'Me.AdvTree1.Visible = True
        CMSPHERE.Show()
        CMSPHERE.BringToFront()
    End Sub

    Private Sub Node4_NodeClick(sender As Object, e As EventArgs) Handles Node4.NodeClick
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmcloth_add Then
                f.Activate()
                f.Refresh()
                f.BringToFront()
                Exit Sub
            Else

            End If
        Next
        'Dim CMSPHERE As New SOFTWARELIST("testja") ไว้ส่งค่าข้ามฟอร์ม
        'Me.PanelEx1.Parent = Nothing
        Dim CMSPHERE As New frmcloth_add()
        CMSPHERE.MdiParent = Me.MdiParent
        CMSPHERE.Parent = Me.PanelEx1
        CMSPHERE.Dock = DockStyle.Fill
        CMSPHERE.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Me.AdvTree1.Dock = DockStyle.Right
        'Me.AdvTree1.Visible = True
        CMSPHERE.Show()
        CMSPHERE.BringToFront()
    End Sub

    Private Sub AdvTree1_Click(sender As Object, e As EventArgs) Handles AdvTree1.Click

    End Sub
End Class