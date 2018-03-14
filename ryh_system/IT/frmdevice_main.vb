Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class frmdevice_main
    Public Shared dbname As String
    Public Shared user As String
    Public Shared password As String
    Public Shared ip As String
    Public Shared mysqlconection As MySqlConnection = New MySqlConnection
    Public Shared mysqlconection1 As MySqlConnection = New MySqlConnection
    Public Shared mysqlconection2 As MySqlConnection = New MySqlConnection

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmdevice_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbname = "it_rajyindee"
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

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim NewMDIChild As New ADD_DEVICE_GROUP_DEPARTMENT
        Try
            For Each f As ADD_DEVICE_GROUP_DEPARTMENT In Me.MdiChildren
                If (TypeOf (f) Is ADD_DEVICE_GROUP_DEPARTMENT) Then
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
            NewMDIChild = New ADD_DEVICE_GROUP_DEPARTMENT
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        Dim NewMDIChild As New btnsaveprinnew
        Try
            For Each f As btnsaveprinnew In Me.MdiChildren
                If (TypeOf (f) Is btnsaveprinnew) Then
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
            NewMDIChild = New btnsaveprinnew
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NewMDIChild As New EDIT_SECTION_GROUP
        Try
            For Each f As EDIT_SECTION_GROUP In Me.MdiChildren
                If (TypeOf (f) Is EDIT_SECTION_GROUP) Then
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
            NewMDIChild = New EDIT_SECTION_GROUP
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NewMDIChild As New ADD_HISTORY
        Try
            For Each f As ADD_HISTORY In Me.MdiChildren
                If (TypeOf (f) Is ADD_HISTORY) Then
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
            NewMDIChild = New ADD_HISTORY
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click

        Dim NewMDIChild As New SHOW_HISTORY_DEVICE
        Try
            For Each f As SHOW_HISTORY_DEVICE In Me.MdiChildren
                If (TypeOf (f) Is SHOW_HISTORY_DEVICE) Then
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
            NewMDIChild = New SHOW_HISTORY_DEVICE
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        Dim NextForm As EDIT_FLOOR = New EDIT_FLOOR(password, "ryh1", user, dbname)
        NextForm.Show()
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        Dim NextForm As ADD_FLOOR = New ADD_FLOOR(password, "ryh1", user, dbname)
        NextForm.Show()
    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        Dim NextForm As ADD_DEPARTMENT = New ADD_DEPARTMENT(password, "ryh1", user, dbname)
        NextForm.Show()
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        Dim NextForm As EDIT_SECTION = New EDIT_SECTION(password, "ryh1", user, dbname)
        NextForm.Show()
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        Dim NextForm As ADD_LOCATION = New ADD_LOCATION(password, "ryh1", user, dbname)
        NextForm.Show()
    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        Dim NextForm As EDIT_LOCATION = New EDIT_LOCATION(password, "ryh1", user, dbname)
        NextForm.Show()
    End Sub

    Private Sub RibbonTabItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonTabItem3.Click








    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        Dim NextForm As frmsms_ibl = New frmsms_ibl
        NextForm.Show()
    End Sub

    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        Dim NextForm As frmsms_obl = New frmsms_obl
        NextForm.Show()


    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        Dim NextForm As frmsms_nud = New frmsms_nud
        NextForm.Show()

    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        Dim NewMDIChild As New frmcheck_sms_nud
        Try
            For Each f As frmcheck_sms_nud In Me.MdiChildren
                If (TypeOf (f) Is frmcheck_sms_nud) Then
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
            NewMDIChild = New frmcheck_sms_nud
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        Dim NewMDIChild As New Help_Add
        Try
            For Each f As Help_Add In Me.MdiChildren
                If (TypeOf (f) Is Help_Add) Then
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
            NewMDIChild = New Help_Add
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click
        Dim NewMDIChild As New Help_Edit
        Try
            For Each f As Help_Edit In Me.MdiChildren
                If (TypeOf (f) Is Help_Edit) Then
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
            NewMDIChild = New Help_Edit
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        Dim NewMDIChild As New Help_Show
        Try
            For Each f As Help_Show In Me.MdiChildren
                If (TypeOf (f) Is Help_Show) Then
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
            NewMDIChild = New Help_Show
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Dim NewMDIChild As New EDIT_SECTION_GROUP
        Try
            For Each f As EDIT_SECTION_GROUP In Me.MdiChildren
                If (TypeOf (f) Is EDIT_SECTION_GROUP) Then
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
            NewMDIChild = New EDIT_SECTION_GROUP
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim NewMDIChild As New frmit_muser
        Try
            For Each f As frmit_muser In Me.MdiChildren
                If (TypeOf (f) Is frmit_muser) Then
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
            NewMDIChild = New frmit_muser
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim NewMDIChild As New frmit_mdept
        Try
            For Each f As frmit_mdept In Me.MdiChildren
                If (TypeOf (f) Is frmit_mdept) Then
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
            NewMDIChild = New frmit_mdept
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click
        Dim NewMDIChild As New frmit_mprogram
        Try
            For Each f As frmit_mprogram In Me.MdiChildren
                If (TypeOf (f) Is frmit_mprogram) Then
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
            NewMDIChild = New frmit_mprogram
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        Dim NewMDIChild As New frmit_dept
        Try
            For Each f As frmit_dept In Me.MdiChildren
                If (TypeOf (f) Is frmit_dept) Then
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
            NewMDIChild = New frmit_dept
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        Dim NewMDIChild As frmrpt_computer = New frmrpt_computer
        NewMDIChild.Show()
       
    End Sub

    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
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

    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click
        Dim NewMDIChild As New frmsend_msg
        Try
            For Each f As frmsend_msg In Me.MdiChildren
                If (TypeOf (f) Is frmsend_msg) Then
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
            NewMDIChild = New frmsend_msg
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub

    Private Sub ButtonItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem27.Click
        Dim nextform As frmit_check = New frmit_check
        nextform.Show()

    End Sub

    Private Sub ButtonItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem28.Click
        Dim nextform As frmit_himexcel = New frmit_himexcel
        nextform.Show()
    End Sub

    Private Sub ButtonItem29_Click(sender As Object, e As EventArgs) Handles ButtonItem29.Click
        Dim NewMDIChild As New frmit_opdtime
        Try
            For Each f As frmit_opdtime In Me.MdiChildren
                If (TypeOf (f) Is frmit_opdtime) Then
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
            NewMDIChild = New frmit_opdtime
        End If
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.Dock = DockStyle.Fill
    End Sub
End Class