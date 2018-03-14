Public Class frmmain_dep
 
    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim NewMDIChild As New frmmain_dep
        'Try
        '    For Each f As frmmain_dep In Me.MdiChildren
        '        If (TypeOf (f) Is frmmain_dep) Then
        '            NewMDIChild = f
        '            NewMDIChild.Activate()
        '            Exit Sub
        '        Else
        '            For Each _Form As Form In Me.MdiChildren
        '                _Form.Close()
        '            Next
        '        End If
        '    Next
        'Catch ex As Exception
        '    For Each _Form As Form In Me.MdiChildren
        '        _Form.Close()
        '    Next
        'End Try

        'If (NewMDIChild Is Nothing) Then
        '    NewMDIChild = New frmmain_dep
        'End If
        'NewMDIChild.MdiParent = Me
        'NewMDIChild.Show()
        'NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If frmrisk_book.dept = "OPD" Or frmrisk_book.dept = "ER" Or frmrisk_book.dept = "ICU" Or frmrisk_book.dept = "W3" Or frmrisk_book.dept = "W4" Or frmrisk_book.dept = "W5" Or frmrisk_book.dept = "W6" Or frmrisk_book.dept = "LR" Or frmrisk_book.dept = "OR" Or frmrisk_book.dept = "HD" Or frmrisk_book.dept = "IT" Then
            Dim NewMDIChild As New frmmain_census
            Try
                For Each f As frmmain_census In Me.MdiChildren
                    If (TypeOf (f) Is frmmain_census) Then
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
                NewMDIChild = New frmmain_census
            End If
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.Dock = DockStyle.Fill
        Else
            MsgBox("ไม่สมารถเข้าใช้งานในส่วนนี้ได้")
        End If

    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  
    End Sub

    Private Sub frmmain_dep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Application.ChangeCulture("th-TH")
        LabelItem1.Text = "หน่วย" + frmlogin_dept.dept
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ButtonItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click

        If frmlogin_dept.dept = "OPD" Then
            Dim NewMDIChild As New frmdept_cenopd
            Try
                For Each f As frmdept_cenopd In Me.MdiChildren
                    If (TypeOf (f) Is frmdept_cenopd) Then
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
                NewMDIChild = New frmdept_cenopd
            End If
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.Dock = DockStyle.Fill

        ElseIf frmlogin_dept.dept = "W3" Or frmlogin_dept.dept = "W4" Or frmlogin_dept.dept = "W5" Or frmlogin_dept.dept = "W6" Or frmlogin_dept.dept = "ICU" Then
            Dim NewMDIChild As New frmdept_cenipd
            Try
                For Each f As frmdept_cenipd In Me.MdiChildren
                    If (TypeOf (f) Is frmdept_cenipd) Then
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
                NewMDIChild = New frmdept_cenipd
            End If
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.Dock = DockStyle.Fill
        ElseIf frmlogin_dept.dept = "OR" Then
            Dim NewMDIChild As New frmdept_cenor
            Try
                For Each f As frmdept_cenor In Me.MdiChildren
                    If (TypeOf (f) Is frmdept_cenor) Then
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
                NewMDIChild = New frmdept_cenor
            End If
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.Dock = DockStyle.Fill
        ElseIf frmlogin_dept.dept = "LR/NS" Then

            Dim NewMDIChild As New frmdept_cenlr
            Try
                For Each f As frmdept_cenlr In Me.MdiChildren
                    If (TypeOf (f) Is frmdept_cenlr) Then
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
                NewMDIChild = New frmdept_cenlr
            End If
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.Dock = DockStyle.Fill

        ElseIf frmlogin_dept.dept = "HD" Or frmlogin_dept.dept = "MEC" Then

            Dim NewMDIChild As New frmdept_cenhd
            Try
                For Each f As frmdept_cenhd In Me.MdiChildren
                    If (TypeOf (f) Is frmdept_cenhd) Then
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
                NewMDIChild = New frmdept_cenhd
            End If
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.Dock = DockStyle.Fill

        ElseIf frmlogin_dept.dept = "ER" Then


            Dim NewMDIChild As New frmdept_cener
            Try
                For Each f As frmdept_cener In Me.MdiChildren
                    If (TypeOf (f) Is frmdept_cener) Then
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
                NewMDIChild = New frmdept_cener
            End If
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.Dock = DockStyle.Fill
        Else

            MsgBox("User นี้ไม่สามารถใช้งานโปรแกรมได้")

        End If
    



    End Sub

    Private Sub ButtonItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim NewMDIChild As New frmdept_riskbook
        Try
            For Each f As frmdept_riskbook In Me.MdiChildren
                If (TypeOf (f) Is frmdept_riskbook) Then
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
            NewMDIChild = New frmdept_riskbook
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        If frmlogin_dept.dept = "AC" Or frmlogin_dept.dept = "IT" Then
            Dim NewMDIChild As New main_pramern
            Try
                For Each f As main_pramern In Me.MdiChildren
                    If (TypeOf (f) Is main_pramern) Then
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
                NewMDIChild = New main_pramern
            End If
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.Dock = DockStyle.Fill
        Else
            MsgBox("User นี้ไม่สามารถเข้าใช้งานระบบได้")
        End If
       


    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        If frmlogin_dept.dept = "OPD" Or frmlogin_dept.dept = "IT" Then
            Dim NewMDIChild As New frmdept_kpi
            Try
                For Each f As frmdept_kpi In Me.MdiChildren
                    If (TypeOf (f) Is frmdept_kpi) Then
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
                NewMDIChild = New frmdept_kpi
            End If
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.Dock = DockStyle.Fill
        Else
            MsgBox("User นี้ไม่สามารถเข้าใช้งานระบบได้")
        End If
    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        Dim nextform As rpt_risk = New rpt_risk
        nextform.Show()

    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem9_Click(sender As Object, e As EventArgs)
        Dim NewMDIChild As New frmclothdept_main
        Try
            For Each f As frmclothdept_main In Me.MdiChildren
                If (TypeOf (f) Is frmclothdept_main) Then
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
            NewMDIChild = New frmclothdept_main
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem16_Click_1(sender As Object, e As EventArgs) Handles ButtonItem16.Click
        Dim NewMDIChild As New frmupload_reg
        Try
            For Each f As frmupload_reg In Me.MdiChildren
                If (TypeOf (f) Is frmupload_reg) Then
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
            NewMDIChild = New frmupload_reg
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem9_Click_1(sender As Object, e As EventArgs) Handles ButtonItem9.Click
        Dim NewMDIChild As New Form3
        Try
            For Each f As Form3 In Me.MdiChildren
                If (TypeOf (f) Is Form3) Then
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
            NewMDIChild = New Form3
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Dock = DockStyle.Fill
        NewMDIChild.Show()

    End Sub

End Class