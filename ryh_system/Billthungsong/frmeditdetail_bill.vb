Public Class frmeditdetail_bill
    Dim condb As ConnecDBRYH
    Private Sub frmeditdetail_bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox5.AutoCompleteCustomSource.Add("กรุงไทย")
        TextBox5.AutoCompleteCustomSource.Add("กรุงเทพ")
        TextBox5.AutoCompleteCustomSource.Add("กรุงศรีอยุธยา")
        TextBox5.AutoCompleteCustomSource.Add("กสิกรไทย")
        TextBox5.AutoCompleteCustomSource.Add("เกียรตินาคิน")
        TextBox5.AutoCompleteCustomSource.Add("ซีไอเอ็มบีไทย")
        TextBox5.AutoCompleteCustomSource.Add("ทหารไทย")
        TextBox5.AutoCompleteCustomSource.Add("ทิสโก้")
        TextBox5.AutoCompleteCustomSource.Add("ไทยพาณิชย์")
        TextBox5.AutoCompleteCustomSource.Add("ธนชาต")
        TextBox5.AutoCompleteCustomSource.Add("ออมสิน")
        condb = ConnecDBRYH.NewConnection


        Dim dt As DataTable
        Dim sql As String
        sql = "SELECT IDTHUNGSONGBILL as 'เลขที่ใบเสร็จ' FROM thungsong_rec;"
        dt = condb.GetTable(sql)
        Grid1.PrimaryGrid.DataSource = dt
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim stringtype As String

      
        Try
            If TextBox3.Text <> "" Then
                If RadioButton1.Checked = True Then
                    stringtype = "โอน"
                ElseIf RadioButton2.Checked = True Then
                    stringtype = "เช็ค"
                ElseIf RadioButton3.Checked = True Then
                    stringtype = "เงินสด"
                End If

                Dim sql As String
                sql = "update thungsong_rec SET  thungsong_type ='" & stringtype & "',thungsong_sum  = " & TextBox2.Text & ",  thungsong_sumshare = " & CInt(TextBox2.Text) * 0.1 & ",  thungsong_bank = '" & TextBox5.Text & "' ,  thungsong_bankid ='" & TextBox7.Text & "' , thungsong_date = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' , thungsong_date1='" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "' , thungsong_banksub ='" & TextBox6.Text & "' WHERE   IDTHUNGSONGBILL = " & TextBox3.Text & ""
                condb = ConnecDBRYH.NewConnection
                condb.ExecuteNonQuery(sql)
                MsgBox("บันทึกเสร็จสิ้น")
            Else
                MsgBox("กรุณาเลือกบิลใบเสร็จ")
            End If

        Catch ex As Exception

        End Try

        TextBox2.Text = ""
        TextBox1.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Grid1_CellClick(sender As Object, e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles Grid1.CellClick

        Dim sql As String
        sql = " SELECT name2 as name ,address , price as fund ,thungsongdb.name ,thungsong_date1  FROM rajyindee_db.thungsongdb JOIN  ( SELECT thungsong_date1,thungsong_roundbill ,IDTHUNGSONGBILL FROM rajyindee_db.thungsong_round join thungsong_rec ON thungsong_round.idthungsong_round = thungsong_rec.idthungsong_round  ) AS A  ON  A.thungsong_roundbill = thungsongdb.idthungsongDB  WHERE IDTHUNGSONGBILL = '" & CType(Grid1.PrimaryGrid.Rows(e.GridCell.GridRow.RowIndex), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("เลขที่ใบเสร็จ").Value.ToString & "';"
        condb = ConnecDBRYH.NewConnection
        Dim dt As DataTable
        dt = condb.GetTable(sql)
        TextBox3.Text = CType(Grid1.PrimaryGrid.Rows(e.GridCell.GridRow.RowIndex), DevComponents.DotNetBar.SuperGrid.GridRow).Cells("เลขที่ใบเสร็จ").Value.ToString

        TextBox1.Text = dt.Rows(0)("name").ToString

    End Sub
End Class