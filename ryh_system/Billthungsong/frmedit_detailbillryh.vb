Public Class frmedit_detailbillryh
    Dim condb As ConnecDBRYH = ConnecDBRYH.NewConnection
    Private Sub frmedit_detailbillryh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADSQL()
        loadname()
    End Sub
    Public Sub loadname()
        Dim sql As String
        sql = "SELECT idryh_main as 'ID',name as 'รายชื่อผู้ถือหุ้น' FROM ryh_main"
        Dim dt As DataTable
        condb = ConnecDBRYH.NewConnection
        dt = condb.GetTable(sql)
        SuperGridControl1.PrimaryGrid.DataSource = dt
        condb.Dispose()

    End Sub
    Public Sub LOADSQL()
        Dim sql As String
        condb = ConnecDBRYH.NewConnection
        sql = "SELECT  idryh_billdet as 'เลขที่ใบเสร็จ'  from rajyindee_db.ryh_billdet WHERE idryh_sumdet = 0  "
        Dim dt As DataTable
        dt = condb.GetTable(sql)
        Grid1.PrimaryGrid.DataSource = dt
        condb.Dispose()
    End Sub

    Private Sub Grid1_CellClick(sender As Object, e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles Grid1.CellClick

        Dim sql As String
        sql = "Select * from ryh_billdet WHERE  idryh_billdet  ='" & CType(Grid1.PrimaryGrid.Rows(e.GridCell.GridRow.RowIndex), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("เลขที่ใบเสร็จ").Value.ToString & "'"
        Dim dt As DataTable
        Dim condb As ConnecDBRYH = ConnecDBRYH.NewConnection
        dt = condb.GetTable(sql)
        TextBox4.Text = dt.Rows(0)("idryh_billdet").ToString
        If dt.Rows(0)("ryh_type").ToString = "โอน" Then
            RadioButton1.Checked = True
        ElseIf dt.Rows(0)("ryh_type").ToString = "เช็ค" Then
            RadioButton2.Checked = True
        ElseIf dt.Rows(0)("ryh_type").ToString = "เงินสด" Then
            RadioButton3.Checked = True
        Else

        End If


        TextBox5.Text = dt.Rows(0)("ryh_bank").ToString
        TextBox6.Text = dt.Rows(0)("ryh_banksub").ToString
        TextBox7.Text = dt.Rows(0)("ryh_bankid").ToString


    End Sub

    Private Sub SuperGridControl1_CellClick(sender As Object, e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles SuperGridControl1.CellClick
        Dim sql As String
        Dim condb As ConnecDBRYH
        condb = ConnecDBRYH.NewConnection
        Dim dt As DataTable
        sql = "SELECT idryh_main , ryh_main.name from ryh_main where idryh_main = '" & CType(SuperGridControl1.PrimaryGrid.Rows(e.GridCell.GridRow.RowIndex), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value.ToString & "'"

        dt = condb.GetTable(sql)
        TextBox8.Text = dt.Rows(0)("idryh_main").ToString
        TextBox1.Text = dt.Rows(0)("name").ToString
        sql = "SELECT * from ryh_sumdetail where idryh_main ='" & TextBox8.Text & "' and count = 1;"
        condb.Dispose()
        condb = ConnecDBRYH.NewConnection
        dt = condb.GetTable(sql)
        TextBox2.Text = dt.Rows(0)("idryh_sumdetail")
        condb.Dispose()


    End Sub

    Public Sub cleardata()
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox8.Text = ""
        TextBox1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click


        If TextBox4.Text <> "" And TextBox8.Text <> "" Then

            Dim sql As String
            sql = "UPDATE  ryh_sumdetail SET checkryh = '1' where count = 1 and idryh_sumdetail  = '" & TextBox2.Text & "'"
            Dim condb As ConnecDBRYH = ConnecDBRYH.NewConnection
            condb.ExecuteNonQuery(sql)
            sql = "UPDATE ryh_billdet SET idryh_sumdet ='" & TextBox2.Text & "' where  idryh_billdet = '" & TextBox4.Text & "'"
            condb.ExecuteNonQuery(sql)
        End If
        cleardata()
        LOADSQL()

    End Sub
End Class