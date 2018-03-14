Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data

Public Class frmmain_nurse
    Public Shared dbname As String
    Public Shared user As String
    Public Shared password As String
    Public Shared ip As String
    Public Shared mysqlconection As MySqlConnection = New MySqlConnection
    Public Shared mysqlconection1 As MySqlConnection = New MySqlConnection
    Public Shared mysqlconection2 As MySqlConnection = New MySqlConnection



    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader

    Private Sub frmmain_nurse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbname = "rajyindee_db"
        user = "june"
        password = "software"
        ''ip = "7.20.246.166"
        'ip = "YKPSERVER55"
        ip = "ryh1"
        'ip = "192.168.10.23"
        mysqlconection1.Close()
        mysqlconection.Close()
        mysqlconection2.Close()

        mysqlconection.ConnectionString = "server=" + ip + ";Port=3306;user id=" + user + ";password=" + password + ";database=" + dbname + ";Character Set =utf8"
        Try
            mysqlconection.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)


        End Try

        mysqlconection1.ConnectionString = "server=" + ip + ";user id=" + user + ";password=" + password + ";database=" + dbname + ";Character Set =utf8;"
        Try
            mysqlconection1.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)


        End Try



        mysqlconection2.ConnectionString = "server=" + ip + ";user id=" + user + ";password=" + password + ";database=rajyindee_db;Character Set =utf8;"
        Try
            mysqlconection2.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)


        End Try
    End Sub

   
    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim NewMDIChild As New frmnurse_lr
        Try
            For Each f As frmnurse_lr In Me.MdiChildren
                If (TypeOf (f) Is frmnurse_lr) Then
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
            NewMDIChild = New frmnurse_lr
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim NewMDIChild As New frmnurse_or
        Try
            For Each f As frmnurse_or In Me.MdiChildren
                If (TypeOf (f) Is frmnurse_or) Then
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
            NewMDIChild = New frmnurse_or
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        Dim NewMDIChild As New frmnurse_hd
        Try
            For Each f As frmnurse_hd In Me.MdiChildren
                If (TypeOf (f) Is frmnurse_hd) Then
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
            NewMDIChild = New frmnurse_hd
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        Dim NewMDIChild As New frmnurse_w3
        Try
            For Each f As frmnurse_w3 In Me.MdiChildren
                If (TypeOf (f) Is frmnurse_w3) Then
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
            NewMDIChild = New frmnurse_w3
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        Dim NewMDIChild As New frmnurse_er
        Try
            For Each f As frmnurse_er In Me.MdiChildren
                If (TypeOf (f) Is frmnurse_er) Then
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
            NewMDIChild = New frmnurse_er
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        Dim NewMDIChild As New frmnure_rpt
        Try
            For Each f As frmnure_rpt In Me.MdiChildren
                If (TypeOf (f) Is frmnure_rpt) Then
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
            NewMDIChild = New frmnure_rpt
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        Dim NewMDIChild As New frmnurse_daily
        Try
            For Each f As frmnurse_daily In Me.MdiChildren
                If (TypeOf (f) Is frmnurse_daily) Then
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
            NewMDIChild = New frmnurse_daily
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        Dim NewMDIChild As New frmnurse_opd
        Try
            For Each f As frmnurse_opd In Me.MdiChildren
                If (TypeOf (f) Is frmnurse_opd) Then
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
            NewMDIChild = New frmnurse_opd
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub
End Class