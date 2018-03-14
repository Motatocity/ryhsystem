Imports DevComponents.DotNetBar
Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar.Metro.ColorTables
Public Class frmmain_ryh
    Dim m_AlertOnLoad As DevComponents.DotNetBar.Balloon
    Private Sub MetroTileItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem1.Click
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Enabled = False
        showLoadalert()
    End Sub
    Private Sub showLoadalert()
        m_AlertOnLoad = New alertCustom()

        Dim r As Rectangle = Screen.GetWorkingArea(Me)
        m_AlertOnLoad.Location = New Point(r.Right - m_AlertOnLoad.Width, r.Bottom - m_AlertOnLoad.Height)
        m_AlertOnLoad.AutoClose = True
        m_AlertOnLoad.AutoCloseTimeOut = 15
        m_AlertOnLoad.AlertAnimation = eAlertAnimation.BottomToTop
        m_AlertOnLoad.AlertAnimationDuration = 300
        m_AlertOnLoad.Show(False)
    End Sub


    Private Sub MetroTileItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub

    Private Sub MetroTileItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub

    Private Sub MetroTileItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem12.Click
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub

    Private Sub MetroTileItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem7.Click
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub

    Private Sub MetroTileItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem8.Click
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub

    Private Sub MetroTileItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem11.Click
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub

    Private Sub MetroTileItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem4.Click
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub

    Private Sub MetroTileItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem3.Click
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub

    Private Sub MetroTileItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem2.Click
        Dim nextform As logincheck = New logincheck
        nextform.Show()
    End Sub

    Private Sub MetroTilePanel1_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTilePanel1.ItemClick

    End Sub

    Private Sub MetroTileItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nextform As frmrisk_1 = New frmrisk_1
        nextform.Show()

    End Sub

    Private Sub MetroTileItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem18.Click

        Dim nextform As frmqua_login = New frmqua_login
        nextform.Show()
    End Sub

    Private Sub MetroTileItem19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MetroTileItem19.Click

        Dim nextform As Form4 = New Form4
        nextform.Show()

    End Sub

    Private Sub MetroTileItem10_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MetroTileItem10.Click
        Dim nextform As frmmain_census = New frmmain_census
        nextform.Show()
    End Sub

    Private Sub MetroTileItem20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MetroTileItem20.Click
        Dim nextform As frmnurse_login = New frmnurse_login
        nextform.Show()
    End Sub

    Private Sub frmmain_ryh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Settings.PATH
    End Sub

    Private Sub MetroTileItem21_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MetroTileItem21.CheckedChanged

    End Sub

    Private Sub MetroTileItem21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MetroTileItem21.Click

        Dim nextform As frmlogin_dept = New frmlogin_dept
        nextform.Show()
    End Sub

    Private Sub MetroTileItem22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MetroTileItem22.Click

        Dim nextform As frmmain_premium = New frmmain_premium
        nextform.Show()
    End Sub

    Private Sub MetroTileItem16_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MetroTileItem16.Click
        Dim nextform As frmmain_bill = New frmmain_bill
        nextform.Show()
    End Sub

    Private Sub MetroTileItem23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MetroTileItem23.Click
        Dim nextform As forecast = New forecast
        nextform.Show()
    End Sub

    Private Sub MetroTileItem24_Click(sender As Object, e As EventArgs) Handles MetroTileItem24.Click
        Dim nextform As frmmain_cloth = New frmmain_cloth
        nextform.Show()
    End Sub
End Class