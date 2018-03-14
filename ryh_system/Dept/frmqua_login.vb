Public Class frmqua_login

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If TextBoxX1.Text = "qua" And TextBoxX2.Text = "quaqua226" Then
            Dim nextform As frmmain_qua = New frmmain_qua
            nextform.Show()
            Me.Close()

        Else

            MsgBox("Username หรือ Password ไม่ถูกต้อง")
        End If



    End Sub

    Private Sub frmqua_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub

    Private Sub TextBoxX2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBoxX1.Text = "qua" And TextBoxX2.Text = "quaqua226" Then
                Dim nextform As frmmain_qua = New frmmain_qua
                nextform.Show()
                Me.Close()

            Else

                MsgBox("Username หรือ Password ไม่ถูกต้อง")
            End If
        Else

        End If
    End Sub

    Private Sub MetroStatusBar1_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroStatusBar1.ItemClick

    End Sub
End Class