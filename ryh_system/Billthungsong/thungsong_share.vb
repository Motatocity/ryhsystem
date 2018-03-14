Imports DevComponents.DotNetBar.SuperGrid

Public Class thungsong_share

    Dim isThongsongHosital As Boolean = False
    Dim idPersonBuy As Integer = 0
    Dim idPersonSell As Integer = 0
    Dim Bill As Integer

    Public Sub New(ByVal f_ThongSong As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isThongsongHosital = f_ThongSong
    End Sub

    Private Sub thungsong_share_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As FILTERCLASS
        Dim sql As String

        AddHandler ListRegToday.GetCellStyle, AddressOf SuperGridControl1GetCellStyle

        If isThongsongHosital Then
            sql = "SELECT idthungsongDB,name FROM rajyindee_db.thungsongdb;"
        Else
            sql = "SELECT idryh_main,name FROM rajyindee_db.ryh_main;"
        End If

        s = New FILTERCLASS(TextBoxX1, sql, "id,ชื่อ - นามสกุล", "10,320", "0,1", "1,1")
        s = New FILTERCLASS(TextBoxX2, sql, "id,ชื่อ - นามสกุล", "10,320", "0,1", "1,1")
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub SuperGridControl1GetCellStyle(sender As Object, e As GridGetCellStyleEventArgs)
        If e.GridCell.GridColumn.Name.Equals("สถานะ") = True Then
            If CStr(e.GridCell.Value).Equals("1") = True Then
                e.GridCell.GridRow.Item(4).CellStyles.Default.Background.Color1 = Color.Orange
                e.GridCell.GridRow.Item(4).CellStyles.Default.Background.Color2 = Color.Orange
            End If
        End If
    End Sub

    Sub getDetail()
        Dim db As ConnecDBRYH = ConnecDBRYH.NewConnection
        Dim sql As String
        idPersonSell = TextBoxX2.Tag
        If isThongsongHosital Then
            sql = "SELECT thungsong_round.idthungsong_round AS 'id',thungsong_round1 AS 'งวดที่',thungsong_rundsum AS 'จำนวนหุ้น', thungsong_rundshare AS 'จำนวนเงิน',thungsong_sumshare AS 'จำนวนเงินที่ชำระแล้ว' , thungsong_rundstat AS 'สถานะ' FROM (SELECT SUM(thungsong_sum) AS thungsong_sum  ,SUM(thungsong_sumshare)  as thungsong_sumshare  , idthungsong_round FROM rajyindee_db.thungsong_rec GROUP by idthungsong_round) AS A RIGHT JOIN  rajyindee_db.thungsong_round ON A.idthungsong_round = thungsong_round.idthungsong_round where thungsong_roundbill = '" & TextBoxX2.Tag.ToString & "' order by thungsong_round.idthungsong_round ASC;"
            Dim dt As DataTable = db.GetTable(sql)
            ListRegToday.PrimaryGrid.DataSource = dt
        Else
            sql = "SELECT idryh_sumdetail AS 'id',ryh_sumdetail.count as 'งวดที่' , ryh_sumdetail.sum as 'จำนวนหุ้น',(ryh_sumdetail.sum * 1.5) as 'จำนวนเงิน',checkryh AS 'สถานะ' FROM ryh_sumdetail JOIN ryh_main  ON ryh_main.idryh_main  = ryh_sumdetail.idryh_main  where ryh_main.idryh_main = '" & TextBoxX2.Tag.ToString & "' ORDER BY idryh_sumdetail; "
            Dim dt As DataTable = db.GetTable(sql)
            ListRegToday.PrimaryGrid.DataSource = dt
        End If
        db.Dispose()
    End Sub

    Private Sub TextBoxX2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX2.TextChanged
        If Not (TextBoxX2.Tag Is Nothing) Then
            getDetail()
        End If
    End Sub

    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim db As ConnecDBRYH = ConnecDBRYH.NewConnection
            Dim sql As String
            If isThongsongHosital Then
                sql = "SELECT * FROM rajyindee_db.thungsongdb WHERE idcardname = '" & MaskedTextBox1.Text & "';"

                Dim dt As DataTable = db.GetTable(sql)
                If dt.Rows.Count > 0 Then
                    txtNewPerson.Text = "ผู้ถือหุ้นในระบบ"
                    idPersonBuy = dt.Rows(0).Item("idthungsongDB")
                    txtNewPerson.ForeColor = SystemColors.ControlText
                    TextBoxX1.Text = dt.Rows(0).Item("name2").ToString
                    'TextBoxX1.Text = dt.Rows(0).Item("name2").ToString.Substring(0, 3)
                    'Dim StrName As String() = dt.Rows(0).Item("name").ToString.Split(New String() {" "}, StringSplitOptions.None)
                    'If StrName.Length = 2 Then
                    '    TextBoxX8.Text = StrName(1)
                    'Else
                    '    TextBoxX8.Text = StrName(2)
                    'End If
                    'TextBoxX7.Text = StrName(0)

                    TextBoxX4.Text = dt.Rows(0).Item("address").ToString
                    TextBoxX5.Text = dt.Rows(0).Item("tell").ToString
                    ComboBox1.Text = dt.Rows(0).Item("type").ToString
                Else
                    txtNewPerson.Text = "ผู้ถือหุ้นรายใหม่"
                    txtNewPerson.ForeColor = Color.Crimson
                    idPersonBuy = 0
                End If

            Else
                sql = "SELECT * FROM rajyindee_db.ryh_main WHERE idcard = '" & MaskedTextBox1.Text & "';"

                Dim dt As DataTable = db.GetTable(sql)
                If dt.Rows.Count > 0 Then
                    txtNewPerson.Text = "ผู้ถือหุ้นในระบบ"
                    idPersonBuy = dt.Rows(0).Item("idryh_main")
                    txtNewPerson.ForeColor = SystemColors.ControlText
                    TextBoxX1.Text = dt.Rows(0).Item("name").ToString
                    'Dim StrName As String() = dt.Rows(0).Item("name").ToString.Split(New String() {" "}, StringSplitOptions.None)
                    'If StrName.Length = 2 Then
                    '    TextBoxX8.Text = StrName(1)
                    'Else
                    '    TextBoxX8.Text = StrName(2)
                    'End If
                    'TextBoxX7.Text = StrName(0)

                    TextBoxX4.Text = dt.Rows(0).Item("address").ToString
                    TextBoxX5.Text = dt.Rows(0).Item("tell").ToString
                    ComboBox1.SelectedIndex = 0
                Else
                    txtNewPerson.Text = "ผู้ถือหุ้นรายใหม่"
                    txtNewPerson.ForeColor = Color.Crimson
                    idPersonBuy = 0
                End If

            End If

            db.Dispose()
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        CheckNewPerson()
        SaveChangeShare()
        Me.Close()
    End Sub

    Sub SaveChangeShare()
        Dim db As ConnecDBRYH = ConnecDBRYH.NewConnection
        Dim sql As String = ""
        Dim dt As DataTable = ListRegToday.PrimaryGrid.DataSource

        If isThongsongHosital Then
            For i = 0 To dt.Rows.Count - 1
                Dim bill As String = dt.Rows(i).Item("id").ToString
                sql += "INSERT INTO rajyindee_db.share_history(bill,person_sell,person_buy,hospital,u_date,status) VALUE('" & bill & "','" & idPersonSell & "','" & idPersonBuy & "','1',NOW(),'1');"
                sql += "UPDATE rajyindee_db.thungsong_round SET thungsong_roundbill = " & idPersonBuy & " WHERE idthungsong_round = " & bill & ";"
            Next
        Else
            For i = 0 To dt.Rows.Count - 1
                Dim bill As String = dt.Rows(i).Item("id").ToString
                sql += "INSERT INTO rajyindee_db.share_history(bill,person_sell,person_buy,hospital,u_date,status) VALUE('" & bill & "','" & idPersonSell & "','" & idPersonBuy & "','2',NOW(),'1');"
                sql += "UPDATE rajyindee_db.ryh_sumdetail SET idryh_main = " & idPersonBuy & " WHERE idryh_sumdetail = " & bill & ";"
            Next
        End If

        Try
            db.BeginTrans()
            db.ExecuteNonQuery(sql)
            db.CommitTrans()
        Catch ex As Exception
            db.RollbackTrans()
        End Try
        db.Dispose()
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.TextChanged
        If TextBoxX1.Text <> "" Then
            Dim db As ConnecDBRYH = ConnecDBRYH.NewConnection
            Dim sql As String
            If isThongsongHosital Then
                sql = "SELECT * FROM rajyindee_db.thungsongdb WHERE idthungsongDB = '" & TextBoxX1.Tag & "';"

                Dim dt As DataTable = db.GetTable(sql)
                If dt.Rows.Count > 0 Then
                    txtNewPerson.Text = "ผู้ถือหุ้นในระบบ"
                    idPersonBuy = dt.Rows(0).Item("idthungsongDB")
                    txtNewPerson.ForeColor = SystemColors.ControlText
                    MaskedTextBox1.Text = dt.Rows(0).Item("idcardname").ToString
                    'TextBoxX1.Text = dt.Rows(0).Item("name2").ToString.Substring(0, 3)
                    'Dim StrName As String() = dt.Rows(0).Item("name").ToString.Split(New String() {" "}, StringSplitOptions.None)
                    'If StrName.Length = 2 Then
                    '    TextBoxX8.Text = StrName(1)
                    'Else
                    '    TextBoxX8.Text = StrName(2)
                    'End If
                    'TextBoxX7.Text = StrName(0)

                    TextBoxX4.Text = dt.Rows(0).Item("address").ToString
                    TextBoxX5.Text = dt.Rows(0).Item("tell").ToString
                    ComboBox1.Text = dt.Rows(0).Item("type").ToString
                Else
                    txtNewPerson.Text = "ผู้ถือหุ้นรายใหม่"
                    txtNewPerson.ForeColor = Color.Crimson
                    idPersonBuy = 0
                End If

            Else
                sql = "SELECT * FROM rajyindee_db.ryh_main WHERE idryh_main = '" & TextBoxX1.Tag & "';"

                Dim dt As DataTable = db.GetTable(sql)
                If dt.Rows.Count > 0 Then
                    txtNewPerson.Text = "ผู้ถือหุ้นในระบบ"
                    idPersonBuy = dt.Rows(0).Item("idryh_main")
                    txtNewPerson.ForeColor = SystemColors.ControlText
                    MaskedTextBox1.Text = dt.Rows(0).Item("idcard").ToString
                    'Dim StrName As String() = dt.Rows(0).Item("name").ToString.Split(New String() {" "}, StringSplitOptions.None)
                    'If StrName.Length = 2 Then
                    '    TextBoxX8.Text = StrName(1)
                    'Else
                    '    TextBoxX8.Text = StrName(2)
                    'End If
                    'TextBoxX7.Text = StrName(0)

                    TextBoxX4.Text = dt.Rows(0).Item("address").ToString
                    TextBoxX5.Text = dt.Rows(0).Item("tell").ToString
                    ComboBox1.SelectedIndex = 0
                Else
                    txtNewPerson.Text = "ผู้ถือหุ้นรายใหม่"
                    txtNewPerson.ForeColor = Color.Crimson
                    idPersonBuy = 0
                End If

            End If
            db.Dispose()
        Else
            TextBoxX1.Tag = Nothing
            MaskedTextBox1.Text = ""
            TextBoxX4.Text = ""
            TextBoxX5.Text = ""
            ComboBox1.SelectedIndex = 0
            txtNewPerson.Text = "ผู้ถือหุ้นรายใหม่"
            txtNewPerson.ForeColor = Color.Crimson
            idPersonBuy = 0
        End If

    End Sub

    Sub CheckNewPerson()

        If txtNewPerson.Text = "ผู้ถือหุ้นรายใหม่" Then
            Dim db As ConnecDBRYH = ConnecDBRYH.NewConnection
            Dim sql As String

            If isThongsongHosital Then
                Dim StrName As String() = TextBoxX1.Text.Split(New String() {" "}, StringSplitOptions.None)
                sql = "INSERT INTO rajyindee_db.thungsongdb(name,name2,idcardname,address,tell,type,mname,lname) VALUE('" & TextBoxX1.Text & "','" & TextBoxX1.Text & "','" & MaskedTextBox1.Text & "','" & TextBoxX4.Text & "','" & TextBoxX5.Text & "','" & ComboBox1.SelectedItem & "','" & StrName(0) & "','" & StrName(1) & "');"
                Try
                    db.BeginTrans()
                    db.ExecuteNonQuery(sql)
                    db.CommitTrans()
                    idPersonBuy = db.GetTable("SELECT MAX(idthungsongdb) FROM thungsongdb;").Rows(0).Item(0).ToString
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    db.RollbackTrans()
                End Try
            Else
                Dim StrName As String() = TextBoxX1.Text.Split(New String() {" "}, StringSplitOptions.None)
                sql = "INSERT INTO rajyindee_db.ryh_main(name,idcard,address,tell) VALUE('" & TextBoxX1.Text & "','" & MaskedTextBox1.Text & "','" & TextBoxX4.Text & "','" & TextBoxX5.Text & "');"
                Try
                    db.BeginTrans()
                    db.ExecuteNonQuery(sql)
                    db.CommitTrans()
                    idPersonBuy = db.GetTable("SELECT MAX(idryh_main) FROM ryh_main;").Rows(0).Item(0).ToString
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    db.RollbackTrans()
                End Try
            End If
            db.Dispose()
        End If
    End Sub

End Class