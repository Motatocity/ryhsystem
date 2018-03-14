Public Class Form4

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If TextBoxX1.Text = "Administrator" And TextBoxX2.Text = "ks9lfj" Then
            Dim nextform As frmdevice_main = New frmdevice_main
            nextform.Show()
            Me.Close()

        Else

            MsgBox("Username หรือ Password ไม่ถูกต้อง")
        End If
    End Sub

    Private Sub TextBoxX2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBoxX1.Text = "Administrator" And TextBoxX2.Text = "ks9lfj" Then
                Dim nextform As frmdevice_main = New frmdevice_main
                nextform.Show()
                Me.Close()

            Else

                MsgBox("Username หรือ Password ไม่ถูกต้อง")
            End If
        Else

        End If
    End Sub

  
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
