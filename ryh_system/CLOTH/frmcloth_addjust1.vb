Public Class frmcloth_addjust1
    Dim s As FILTERCLASS
    Dim cloth As CLOTHCLASS = New CLOTHCLASS
    Dim idproduct As Integer
    Private Sub SearchSTOCKTxt()
        Dim sql2 As String
        sql2 = "SELECT iduserdep,dep,description FROM rajyindee_db.userdep"
        s = New FILTERCLASS(deptname, sql2, "รหัส,แผนก,ชื่อแผนก", "25,50,100", "1,1,1", "1,1,1")
        s.SetShowBorder = True
        s.SetTextIndex = 1
    End Sub
    Private Sub SearchProductTxt()
        Dim sql2 As String
        sql2 = "SELECT idmascloth,clothname FROM rajyindee_db.mascloth WHERE F_STAT = 1 "
        s = New FILTERCLASS(product, sql2, "รหัส,Product", "25,100", "1,1", "1,1")
        s.SetShowBorder = True
        s.SetTextIndex = 1
    End Sub
    Private Sub frmcloth_addjust1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchSTOCKTxt()
        SearchProductTxt()
    End Sub

    Public Sub clearform()

        product.Tag = Nothing
        total.Value = 0
        totaluse.Text = "0"
        idproduct = Nothing
        IDMAS.Text = Nothing

        product.Text = ""


    End Sub


    Private Sub product_TextChanged(sender As Object, e As EventArgs) Handles product.TextChanged

        If Convert.ToString(product.Tag).Length = 0 Or Convert.ToString(deptname.Tag).Length = 0 Then

        Else


            LOADADJUST(cloth.SEARCHADJUST(Convert.ToInt16(product.Tag), Convert.ToInt16(deptname.Tag))
)

        End If



    End Sub
    Public Sub LOADADJUST(ByRef dt As DataTable)
        ' Dim dt As New DataTable
        'dt = cloth.SEARCHADJUST(Convert.ToInt16(product.Tag), Convert.ToInt16(deptname.Tag))

        If dt.Rows.Count = 0 Then

        Else
            IDMAS.Text = dt.Rows(0)("idmainstock").ToString
            product.Text = dt.Rows(0)("clothname").ToString
            product.Tag = dt.Rows(0)("idmascloth").ToString
            total.Text = dt.Rows(0)("qtycloth").ToString
            totaluse.Text = dt.Rows(0)("qty1cloth").ToString
        End If
    End Sub
    Private Sub deptname_TextChanged(sender As Object, e As EventArgs) Handles deptname.TextChanged

        If Convert.ToString(deptname.Tag).Length = 0 Then
        Else
            Dim dt As New DataTable
            dt = cloth.SEARCHDEPCLOTH(Convert.ToInt16(deptname.Tag))
            DGVCLOTH.PrimaryGrid.DataSource = dt

        End If


    End Sub

    Private Sub addMasgrpusr_Click(sender As Object, e As EventArgs) Handles addMasgrpusr.Click
        If Convert.ToString(deptname.Tag).Length = 0 Then
            MsgBox("กรุณาเลือกแผนก")
            Exit Sub
        Else
            If Convert.ToString(product.Tag).Length = 0 Then
                MsgBox("กรุณาเลือก Product")
                Exit Sub
            Else

                If IDMAS.Text.Length = 0 Then
                    cloth.IDMASCLOTH_ = CInt(product.Tag)
                    cloth.qty1_ = CInt(total.Value)
                    cloth.qty2_ = CInt(totaluse.Value)
                    cloth.qtycloth_ = CInt(total.Value)
                    cloth.qty1cloth_ = CInt(totaluse.Value)
                    cloth.deptadjust_ = CInt(deptname.Tag)
                    cloth.INSERTMAINSTOCKDT()
                    cloth.INSERTSTOCKMAINFIRST()
                Else
                    cloth.idmainstock_ = CInt(IDMAS.Text)
                    cloth.IDMASCLOTH_ = CInt(product.Tag)
                    cloth.qty1_ = CInt(total.Value)
                    cloth.qty2_ = CInt(totaluse.Value)
                    cloth.qtycloth_ = CInt(total.Value)
                    cloth.qty1cloth_ = CInt(totaluse.Value)
                    cloth.deptadjust_ = CInt(deptname.Tag)
                    cloth.INSERTMAINSTOCKDT()
                    cloth.UPDATEMAINSTOCK()
                End If
            End If

        End If


        DGVCLOTH.PrimaryGrid.DataSource = cloth.SEARCHDEPCLOTH(Convert.ToInt16(deptname.Tag))



        MsgBox("บันทึกข้อมูลเสร็จสิ้น")
        clearform()
    End Sub


    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        If idproduct <> Nothing Then

            LOADADJUST(cloth.SEARCHADJUST(idproduct, Convert.ToInt16(deptname.Tag)))


        End If
    End Sub

    Private Sub DGVCLOTH_CellClick(sender As Object, e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles DGVCLOTH.CellClick

        idproduct = CInt(e.GridCell.GridRow.Item("ID").Value)
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        Dim nextform As New frmcloth_addjustdetial(Convert.ToInt16(deptname.Tag), idproduct)
        nextform.ShowDialog()


    End Sub
End Class