Public Class frmnurse_login

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If TextBoxX1.Text = "nso" And TextBoxX2.Text = "nsonso" Then
            Dim nextform As frmmain_nurse = New frmmain_nurse
            nextform.Show()
            Me.Close()

        Else

            MsgBox("Username หรือ Password ไม่ถูกต้อง")
        End If



    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Private Sub TextBoxX2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX2.KeyDown
        If e.KeyCode = Keys.Enter Then

            If TextBoxX1.Text = "nso" And TextBoxX2.Text = "nsonso" Then
                Dim nextform As frmmain_nurse = New frmmain_nurse
                nextform.Show()
                Me.Close()
            Else
                MsgBox("Username หรือ Password ไม่ถูกต้อง")
            End If

        Else

        End If
    End Sub
End Class