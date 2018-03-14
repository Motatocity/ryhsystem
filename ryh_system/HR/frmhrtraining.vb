Public Class frmhrtraining

    Private Sub frmhrtraining_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NewMDIChild As New frmsearch_annual
        Try
            For Each f As frmsearch_annual In Me.MdiChildren
                If (TypeOf (f) Is frmsearch_annual) Then
                    NewMDIChild = f
                    NewMDIChild.Activate()
                    Exit Sub
                Else
                    For Each _Form As Form In Me.MdiChildren
                        _Form.Close()
                    Next
                End If
            Next
        Catch ex As Exception
            For Each _Form As Form In Me.MdiChildren
                _Form.Close()
            Next
        End Try

        If (NewMDIChild Is Nothing) Then
            NewMDIChild = New frmsearch_annual
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

  

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim NewMDIChild As New frm_addtraining
        Try
            For Each f As frm_addtraining In Me.MdiChildren
                If (TypeOf (f) Is frm_addtraining) Then
                    NewMDIChild = f
                    NewMDIChild.Activate()
                    Exit Sub
                Else
                    For Each _Form As Form In Me.MdiChildren
                        _Form.Close()
                    Next
                End If
            Next
        Catch ex As Exception
            For Each _Form As Form In Me.MdiChildren
                _Form.Close()
            Next
        End Try

        If (NewMDIChild Is Nothing) Then
            NewMDIChild = New frm_addtraining
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim NewMDIChild As New SelectTraining
        Try
            For Each f As SelectTraining In Me.MdiChildren
                If (TypeOf (f) Is SelectTraining) Then
                    NewMDIChild = f
                    NewMDIChild.Activate()
                    Exit Sub
                Else
                    For Each _Form As Form In Me.MdiChildren
                        _Form.Close()
                    Next
                End If
            Next
        Catch ex As Exception
            For Each _Form As Form In Me.MdiChildren
                _Form.Close()
            Next
        End Try

        If (NewMDIChild Is Nothing) Then
            NewMDIChild = New SelectTraining
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        Dim NewMDIChild As New frmsearch_annual
        Try
            For Each f As frmsearch_annual In Me.MdiChildren
                If (TypeOf (f) Is frmsearch_annual) Then
                    NewMDIChild = f
                    NewMDIChild.Activate()
                    Exit Sub
                Else
                    For Each _Form As Form In Me.MdiChildren
                        _Form.Close()
                    Next
                End If
            Next
        Catch ex As Exception
            For Each _Form As Form In Me.MdiChildren
                _Form.Close()
            Next
        End Try

        If (NewMDIChild Is Nothing) Then
            NewMDIChild = New frmsearch_annual
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        Dim NewMDIChild As New frmpersonal1
        Try
            For Each f As frmpersonal1 In Me.MdiChildren
                If (TypeOf (f) Is frmpersonal1) Then
                    NewMDIChild = f
                    NewMDIChild.Activate()
                    Exit Sub
                Else
                    For Each _Form As Form In Me.MdiChildren
                        _Form.Close()
                    Next
                End If
            Next
        Catch ex As Exception
            For Each _Form As Form In Me.MdiChildren
                _Form.Close()
            Next
        End Try

        If (NewMDIChild Is Nothing) Then
            NewMDIChild = New frmpersonal1
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub
End Class