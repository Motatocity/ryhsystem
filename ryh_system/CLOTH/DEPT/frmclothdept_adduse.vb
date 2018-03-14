Public Class frmclothdept_adduse
    Dim CLOTH As CLOTHDEPTCLASS = New CLOTHDEPTCLASS
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        DGVCLOTH.PrimaryGrid.DataSource = CLOTH.SEARCHUSECLOTH(frmlogin_dept.iddep)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmclothdept_adduse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DGVCLOTH_EndEdit(sender As Object, e As DevComponents.DotNetBar.SuperGrid.GridEditEventArgs) Handles DGVCLOTH.EndEdit
        If DGVCLOTH.PrimaryGrid.Rows.Count = e.GridCell.GridRow.RowIndex Then
            Return
        End If
        If CType(DGVCLOTH.PrimaryGrid.Rows(e.GridCell.RowIndex), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value.ToString.Trim <> "" Then

            For i As Integer = 0 To DGVCLOTH.PrimaryGrid.Rows.Count - 1
                Dim a = CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("เพิ่มใช้งานแล้ว")
                Dim b = CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("เหลือ")
                Dim c = CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ใช้งานแล้ว")
                Dim d = CType(DGVCLOTH.PrimaryGrid.Rows(i), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("รวมใช้งานแล้ว")
                If a.Value > b.Value Then
                    b.Value = 0
                    d.Value = 0
                    On Error Resume Next
                Else
                    d.Value = c.Value + a.Value
                    b.Value = b.Value - a.Value
                End If
            Next




        End If



    End Sub
End Class