Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmmain_qua
    Public Shared dbname As String
    Public Shared user As String
    Public Shared password As String
    Public Shared ip As String
    Public Shared mysqlconection As MySqlConnection = New MySqlConnection
    Public Shared mysqlconection1 As MySqlConnection = New MySqlConnection
    Public Shared mysqlconection2 As MySqlConnection = New MySqlConnection
    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim NewMDIChild As New frmqua_checkrisk
        Try
            For Each f As frmqua_checkrisk In Me.MdiChildren
                If (TypeOf (f) Is frmqua_checkrisk) Then
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
            NewMDIChild = New frmqua_checkrisk
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub frmmain_qua_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim NewMDIChild As New frmqua_reportvb
        Try
            For Each f As frmqua_reportvb In Me.MdiChildren
                If (TypeOf (f) Is frmqua_reportvb) Then
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
            NewMDIChild = New frmqua_reportvb
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim NewMDIChild As New frmdept_tool
        Try
            For Each f As frmdept_tool In Me.MdiChildren
                If (TypeOf (f) Is frmdept_tool) Then
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
            NewMDIChild = New frmdept_tool
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Dim NewMDIChild As New frmdept_quatool
        Try
            For Each f As frmdept_quatool In Me.MdiChildren
                If (TypeOf (f) Is frmdept_quatool) Then
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
            NewMDIChild = New frmdept_quatool
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub
End Class