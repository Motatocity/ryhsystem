Public Class frmregister
    Dim condb As CONNECTDB
    Private Sub frmregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        condb = CONNECTDB.NewConnection(IpAddressInput1.Value, USERTXT.Text, PASTXT.Text, PORTTXT.Text, DATABASE.Text)
        LOADDGV()
        count()
    End Sub
    Public Sub LOADDGV()
        Dim sql As String
        sql = "SELECT idryh_main as 'ID' , name as 'ชื่อนามสกุล' ,IDCARD as 'รหัสประจำตัวประชาชน' ,ryh_main.check AS 'Check' ,ryh_main.check1 AS 'มาแทน' FROM  ryh_main join ryh_sum ON ryh_main.idryh_main = ryh_sum.ID  "
        condb = CONNECTDB.NewConnection(IpAddressInput1.Value, USERTXT.Text, PASTXT.Text, PORTTXT.Text, DATABASE.Text)
        MASDGV.PrimaryGrid.DataSource = condb.GetTable(sql)
        condb.Dispose()
    End Sub
    Public Sub count()
        Dim sql As String
        condb = CONNECTDB.NewConnection(IpAddressInput1.Value, USERTXT.Text, PASTXT.Text, PORTTXT.Text, DATABASE.Text)
        sql = "SELECT COUNT(idryh_main) as 'sum' FROM ryh_main WHERE  ryh_main.check = '1'"
        Dim dt As DataTable

        dt = condb.GetTable(sql)
        TextBox1.Text = dt.Rows(0)("sum").ToString

        condb.Dispose()
        condb = CONNECTDB.NewConnection(IpAddressInput1.Value, USERTXT.Text, PASTXT.Text, PORTTXT.Text, DATABASE.Text)
        sql = "SELECT COUNT(idryh_main) as 'sum' FROM ryh_main WHERE  ryh_main.check1 = '1'"
        'Dim dt As DataTable
        dt = condb.GetTable(sql)
        TextBox2.Text = dt.Rows(0)("sum").ToString

        condb.Dispose()
        condb = CONNECTDB.NewConnection(IpAddressInput1.Value, USERTXT.Text, PASTXT.Text, PORTTXT.Text, DATABASE.Text)
        sql = "SELECT SUM(ryh_sum.sum) as 'SUM' FROM  ryh_main join ryh_sum ON ryh_main.idryh_main = ryh_sum.ID  WHERE ryh_main.check= '1' or  ryh_main.check1 = '1'"

        dt = condb.GetTable(sql)
        TextBox3.Text = dt.Rows(0)("SUM").ToString




        condb.Dispose()
        condb = CONNECTDB.NewConnection(IpAddressInput1.Value, USERTXT.Text, PASTXT.Text, PORTTXT.Text, DATABASE.Text)
        sql = "SELECT SUM(ryh_sum.sum) as 'SUM' FROM  ryh_main join ryh_sum ON ryh_main.idryh_main = ryh_sum.ID "

        dt = condb.GetTable(sql)
        TextBox4.Text = dt.Rows(0)("SUM").ToString
        TextBox5.Text = CInt(TextBox3.Text) / CInt(TextBox4.Text)

    End Sub
    Public Sub UPDATESTATUS(IDTH As String)
        Dim sql As String
        sql = "UPDATE ryh_main SET ryh_main.check = 1 WHERE idryh_main = " & IDTH & ";"
        condb = CONNECTDB.NewConnection(IpAddressInput1.Value, USERTXT.Text, PASTXT.Text, PORTTXT.Text, DATABASE.Text)
        condb.ExecuteNonQuery(sql)
        condb.Dispose()
        LOADDGV()
    End Sub
    Public Sub UPDATESTATUS1(IDTH As String)
        Dim sql As String
        sql = "UPDATE ryh_main SET check1 = 1 WHERE idryh_main = " & IDTH & ";"
        condb = CONNECTDB.NewConnection(IpAddressInput1.Value, USERTXT.Text, PASTXT.Text, PORTTXT.Text, DATABASE.Text)
        condb.ExecuteNonQuery(sql)
        condb.Dispose()
        LOADDGV()
    End Sub
    Private Sub MASDGV_CellClick(sender As Object, e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles MASDGV.CellClick

        If e.GridCell.GridColumn.Name = "Check" Then
            Dim IDTH As String

            IDTH = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value.ToString.Trim
            UPDATESTATUS(IDTH)
            count()
        ElseIf e.GridCell.GridColumn.Name = "มาแทน" Then
            Dim IDTH As String

            IDTH = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value.ToString.Trim
            UPDATESTATUS1(IDTH)
            count()
        End If



    End Sub
End Class