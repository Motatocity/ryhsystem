Public Class frmmain_bill

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        Dim NewMDIChild As New frmmain_thungsong
        Try
            For Each f As frmmain_thungsong In Me.MdiChildren
                If (TypeOf (f) Is frmmain_thungsong) Then
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
            NewMDIChild = New frmmain_thungsong
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        Dim NewMDIChild As New frmload_user
        Try
            For Each f As frmload_user In Me.MdiChildren
                If (TypeOf (f) Is frmload_user) Then
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
            NewMDIChild = New frmload_user
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub
End Class