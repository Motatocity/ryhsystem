Imports MySql.Data.MySqlClient
Public Class main_reg
    Public Shared mysql As MySqlConnection
    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click


        Dim NewMDIChild As New frmreg_adddep
        Try
            For Each f As frmreg_adddep In Me.MdiChildren
                If (TypeOf (f) Is frmreg_adddep) Then
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
            NewMDIChild = New frmreg_adddep
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim NewMDIChild As New frmreg_editdep
        Try
            For Each f As frmreg_editdep In Me.MdiChildren
                If (TypeOf (f) Is frmreg_editdep) Then
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
            NewMDIChild = New frmreg_editdep
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim NewMDIChild As New frmreg_deldep
        Try
            For Each f As frmreg_deldep In Me.MdiChildren
                If (TypeOf (f) Is frmreg_deldep) Then
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
            NewMDIChild = New frmreg_deldep
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub main_reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=rajyindee_db;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try


        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If



    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        Dim NewMDIChild As New frmreg_deluser
        Try
            For Each f As frmreg_deluser In Me.MdiChildren
                If (TypeOf (f) Is frmreg_deluser) Then
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
            NewMDIChild = New frmreg_deluser
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Dim NewMDIChild As New frmreg_sendsms
        Try
            For Each f As frmreg_sendsms In Me.MdiChildren
                If (TypeOf (f) Is frmreg_sendsms) Then
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
            NewMDIChild = New frmreg_sendsms
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        Dim NewMDIChild As New frmreg_adduser
        Try
            For Each f As frmreg_adduser In Me.MdiChildren
                If (TypeOf (f) Is frmreg_adduser) Then
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
            NewMDIChild = New frmreg_adduser
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        Dim NewMDIChild As New frmreg_edituser
        Try
            For Each f As frmreg_edituser In Me.MdiChildren
                If (TypeOf (f) Is frmreg_edituser) Then
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
            NewMDIChild = New frmreg_edituser
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub
End Class