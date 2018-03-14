Public Class frmrisk_book
    Public Shared dept As String
    Private Sub frmrisk_book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub MetroTileItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ER.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "ER"
    End Sub

    Private Sub MetroTileItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HD.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "HD"
    End Sub

    Private Sub MetroTileItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LRNS.Click
        dept = "LRNS"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ICU.Click
        dept = "ICU"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSSD.Click
        dept = "CSSD"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEC.Click
        dept = "MEC"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles W3.Click
        dept = "W3"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles W4.Click
        dept = "W4"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHARMACY.Click
        dept = "PHARMACY"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SECMEDICAL.Click
        dept = "SECMEDICAL"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DOCTOR.Click
        dept = "DOCTOR"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHYSICAL.Click
        dept = "PHYSICAL"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACC.Click
        dept = "ACC"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRADLE.Click
        dept = "CRADLE"
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
    End Sub

    Private Sub MetroTileItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEAN.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "CLEAN"
    End Sub

    Private Sub MetroTileItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IBL.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "IBL"
    End Sub

    Private Sub MetroTileItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAB.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "LAB"
    End Sub

    Private Sub MetroTileItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XRAY.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "XRAY"
    End Sub

    Private Sub MetroTileItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DENTIST.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "DENTIST"
    End Sub

    Private Sub MetroTileItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIET.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "DIET"
    End Sub

    Private Sub MetroTileItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROOMSHIRT.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "ROOMSHIRT"
    End Sub

    Private Sub MetroTileItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SINCHEER.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "SINCHEER"
    End Sub

    Private Sub MetroTileItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OBL.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "OBL"
    End Sub

    Private Sub MetroTileItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITEM.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "ITEM"
    End Sub

    Private Sub MetroTileItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STAT.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "STAT"
    End Sub

    Private Sub MetroTileItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PURCHASE.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "PURCHASE"
    End Sub

    Private Sub MetroTileItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles W6.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "W6"
    End Sub

    Private Sub MetroTileItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles W5.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "w5"
    End Sub

    Private Sub UR1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UR1.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "UR"
    End Sub

    Private Sub MK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MK.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "MK"
    End Sub

    Private Sub AC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AC.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "AC"
    End Sub

    Private Sub REG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REG.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "REG"
    End Sub

    Private Sub IT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IT.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "IT"
    End Sub

    Private Sub HR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HR.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "HR"
    End Sub

    Private Sub REPAIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPAIR.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "REPAIR"
    End Sub

    Private Sub OPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPD.Click
        Dim nextform As frmmain_dep = New frmmain_dep
        nextform.Show()
        dept = "OPD"
    End Sub
End Class