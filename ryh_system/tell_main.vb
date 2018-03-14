Public Class tell_main

    Private Sub เบอร์โทรศัพท์บุคลากร_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles เบอร์โทรศัพท์บุคลากร.Click
        Dim NextForm As tell_search = New tell_search '(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim nextform As tell_doctor_search = New tell_doctor_search
        nextform.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim NextForm As tell_company_search = New tell_company_search '(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")
        '  Dim NextForm As main_user = New main_user()
        NextForm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NextForm As insurance_search = New insurance_search '(mysql_pass, ip_connect, user_namedb, db_name, "0", "0")

        NextForm.Show()
        Me.Close()
    End Sub
End Class