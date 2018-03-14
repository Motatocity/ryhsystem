Public Class frmclothdept_main

    Private Sub frmclothdept_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(frmlogin_dept.iddep)
    End Sub

    Private Sub Node2_NodeClick(sender As Object, e As EventArgs) Handles Node2.NodeClick
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmclothdept_send Then
                f.Activate()
                f.Refresh()
                f.BringToFront()
                Exit Sub
            Else

            End If
        Next
        'Dim CMSPHERE As New SOFTWARELIST("testja") ไว้ส่งค่าข้ามฟอร์ม
        'Me.PanelEx1.Parent = Nothing
        Dim CMSPHERE As New frmclothdept_send()
        CMSPHERE.MdiParent = Me.MdiParent
        CMSPHERE.Parent = Me.PanelEx1
        CMSPHERE.Dock = DockStyle.Fill

        'Me.AdvTree1.Dock = DockStyle.Right
        'Me.AdvTree1.Visible = True
        CMSPHERE.Show()
        CMSPHERE.BringToFront()




    End Sub

    Private Sub Node4_NodeClick(sender As Object, e As EventArgs) Handles Node4.NodeClick
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmclothdept_adduse Then
                f.Activate()
                f.Refresh()
                f.BringToFront()
                Exit Sub
            Else

            End If
        Next
        'Dim CMSPHERE As New SOFTWARELIST("testja") ไว้ส่งค่าข้ามฟอร์ม
        'Me.PanelEx1.Parent = Nothing
        Dim CMSPHERE As New frmclothdept_adduse()
        CMSPHERE.MdiParent = Me.MdiParent
        CMSPHERE.Parent = Me.PanelEx1
        CMSPHERE.Dock = DockStyle.Fill

        'Me.AdvTree1.Dock = DockStyle.Right
        'Me.AdvTree1.Visible = True
        CMSPHERE.Show()
        CMSPHERE.BringToFront()
    End Sub
End Class