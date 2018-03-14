Public Class frmcloth_add
    Dim cloth As CLOTHCLASS = New CLOTHCLASS
    Private Sub addMasgrpusr_Click(sender As Object, e As EventArgs) Handles addMasgrpusr.Click
        cloth.clothname_ = clothname.Text
        cloth.F_STAT_ = clothcheck.Checked
        cloth.INSERTMASCLOTH()
        DGVCLOTH.PrimaryGrid.DataSource = cloth.SEARCHMASCLOTH
        clearform()
    End Sub

    Private Sub editMasgrpusr_Click(sender As Object, e As EventArgs) Handles editMasgrpusr.Click
        If Convert.ToString(clothname.Tag).Length = 0 Then
        Else
            cloth.clothname_ = clothname.Text
            cloth.F_STAT_ = clothcheck.Checked
            cloth.IDMASCLOTH_ = Convert.ToInt16(clothname.Tag)
            cloth.UPDATEMASCLOTH()
            DGVCLOTH.PrimaryGrid.DataSource = cloth.SEARCHMASCLOTH
            clearform()
        End If

    End Sub

    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        For i As Integer = 0 To DGVCLOTH.PrimaryGrid.Rows.Count - 1
            If CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells(0).IsSelected = True Then
                clothname.Tag = Convert.ToInt32(CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value)
                clothname.Text = Convert.ToString(CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ชื่อ").Value)
                clothcheck.Checked = Convert.ToBoolean(CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("สถานะ").Value)
            End If
        Next
    End Sub

    Private Sub frmcloth_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' cloth.INSERTMASCLOTH()
        DGVCLOTH.PrimaryGrid.DataSource = cloth.SEARCHMASCLOTH
    End Sub




    Public Sub clearform()
        cloth = New CLOTHCLASS

        clothname.Tag = Nothing
        clothname.Text = Nothing
        clothcheck.Checked = False

    End Sub
    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        If Convert.ToString(clothname.Tag).Length = 0 Then
        Else


            For i As Integer = 0 To DGVCLOTH.PrimaryGrid.Rows.Count - 1
                If CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells(0).IsSelected = True Then


                    cloth.clothname_ = Convert.ToString(CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ชื่อ").Value)
                    cloth.F_STAT_ = clothcheck.Checked
                    cloth.IDMASCLOTH_ = Convert.ToInt32(CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value)
                    cloth.UPDATEMASCLOTH()
                    DGVCLOTH.PrimaryGrid.DataSource = cloth.SEARCHMASCLOTH
                End If
            Next

        End If

    End Sub
End Class