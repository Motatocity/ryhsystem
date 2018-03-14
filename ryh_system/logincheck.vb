Public Class logincheck

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If txtusername.Text = "er" Then
            Dim nextform As ambulance = New ambulance
            nextform.Show()
            Me.Close()

        ElseIf txtusername.Text = "oper" Then

            Dim nextform As tell_main = New tell_main
            nextform.Show()
            Me.Close()

        ElseIf txtusername.Text = "checkup" Then
            Dim nextform As main = New main
            nextform.Show()
            Me.Close()



        ElseIf txtusername.Text = "sms" Then
            Dim nextform As main_sms = New main_sms
            nextform.Show()
            Me.Close()
        ElseIf txtusername.Text = "ac" Then
            Dim nextform As main_pramern = New main_pramern
            nextform.Show()
            Me.Close()

        ElseIf txtusername.Text = "@Piya191919" Then
            Dim nextform As graphKPI = New graphKPI
            nextform.Show()
            Me.Close()
        ElseIf txtusername.Text = "reg" Then
            Dim nextform As main_reg = New main_reg
            nextform.Show()
            Me.Close()
        ElseIf txtusername.Text = "hr" Then
            Dim nextform As frmhrtraining = New frmhrtraining
            nextform.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown


        If e.KeyCode = Keys.Enter Then
            If txtusername.Text = "er" Then
                Dim nextform As ambulance = New ambulance
                nextform.Show()
                Me.Close()

            ElseIf txtusername.Text = "oper" Then

                Dim nextform As tell_main = New tell_main
                nextform.Show()
                Me.Close()

            ElseIf txtusername.Text = "checkup" Then
                Dim nextform As main = New main
                nextform.Show()
                Me.Close()

      

            ElseIf txtusername.Text = "sms" Then
                Dim nextform As main_sms = New main_sms
                nextform.Show()
                Me.Close()
            ElseIf txtusername.Text = "reg" Then
                Dim nextform As main_reg = New main_reg
                nextform.Show()
                Me.Close()

            ElseIf txtusername.Text = "@Piya191919" Then
                Dim nextform As graphKPI = New graphKPI
                nextform.Show()
                Me.Close()
            ElseIf txtusername.Text = "ac" Then
                Dim nextform As main_pramern = New main_pramern
                nextform.Show()
                Me.Close()
            ElseIf txtusername.Text = "hr" Then
                Dim nextform As frmhrtraining = New frmhrtraining
                nextform.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub logincheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusername.Focus()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class