Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Data.Odbc

Public Class frmmain_premium
    Dim USCulture As New System.Globalization.CultureInfo("en-US", True)
    Dim ConTran As ConnecDBRYH
    Dim commandTxt As String
    Dim data As DataTable
    Dim date_birth As Date
    Dim date_end As Date
    Dim date_s As Date
    Dim date_e1 As Date
    Dim date_e() As String
    Dim status As String
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHPFV5; Userid=mse;Password=m0116;")
    Private Sub frmmain_premium_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en-US")
        MaskedTextBox1.Text = Date.Now.ToString("dd/MM/yyyy", USCulture)
        getDATA()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        ConTran = ConnecDBRYH.NewConnection
        Try
            datenow()
            ConTran.BeginTrans()
            commandTxt = "Insert into checkup "
            commandTxt += "(date_register,date_end,lotcard,hn,namelastname,hn1,namelastname1,status,idbill)"
            commandTxt += "VALUES ('" & MaskedTextBox1.Text & "','" & date_birth.ToString("dd/MM/yyyy", USCulture) & "', '" & lotcard.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "','0','" & TextBox3.Text & "');"
            ConTran.ExecuteNonQuery(commandTxt)
            ConTran.CommitTrans()
        Catch ex As Exception
            ConTran.RollbackTrans()
            MsgBox("IDLOT WRONG")
            MsgBox(ex.ToString)
        Finally
            ConTran.Dispose()
            getDATA()
        End Try
        ConTran.Dispose()

    End Sub
    Public Sub getDATA()
        Dim sql As String
        sql = "Select date_register AS Date,date_end as วันหมดอายุโปร , date_register1 as หมดอายุบัตร ,lotcard as LOTCARD , hn as 'HN เจ้าของ' , namelastname as 'ชื่อ - นามสกุล'  ,hn1 as 'HN โปรโมชั่น',namelastname1 as 'ชื่อ นามสกุล',case when( status = 0) then 'ยังไมได้ใช้โปรโมชั่น' else 'ใช้โปรโมชั่นแล้ว' end as สถานะ,idbill  as IDBILL from checkup"
        ConTran = ConnecDBRYH.NewConnection

        data = ConTran.GetTable(sql)
        DataInformation.PrimaryGrid.DataSource = data

        ConTran.Dispose()
    End Sub
    Public Sub datenow()
        Try
            Dim date_birth_s() As String = Split(MaskedTextBox1.Text, "/") 'split แยกเป็น Array วันเดือนปี
            date_birth = New System.DateTime(CInt(date_birth_s(2)), CInt(date_birth_s(1)), CInt(date_birth_s(0)), 0, 0, 0)
            date_birth = date_birth.AddMonths(6)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub dateend_card()
        Try
            Dim date_birth_s() As String = Split(MaskedTextBox2.Text, "/") 'split แยกเป็น Array วันเดือนปี
            date_end = New System.DateTime(CInt(date_birth_s(2)), CInt(date_birth_s(1)), CInt(date_birth_s(0)), 0, 0, 0)
            date_end = date_end.AddMonths(12)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub datesetuse()
        MaskedTextBox2.Text = Date.Now.ToString("dd/MM/yyyy", USCulture)
    End Sub
    Public Sub getDataLot()
        Dim sql As String
        Try
            ConTran = ConnecDBRYH.NewConnection
            sql = "Select date_register AS Date,date_end as วันหมดอายุโปร , date_register1 as หมดอายุบัตร ,lotcard as LOTCARD , hn as 'HN เจ้าของ' , namelastname as 'ชื่อ - นามสกุล'  ,hn1 as 'HN โปรโมชั่น',namelastname1 as 'ชื่อ นามสกุล',case when( status = 0) then 'ยังไมได้ใช้โปรโมชั่น' else 'ใช้โปรโมชั่นแล้ว' end as สถานะ ,idbill ,date_use from checkup where lotcard ='" & lotcard.Text & "'"
            data = ConTran.GetTable(sql)
            TextBox1.Text = data.Rows(0)("HN เจ้าของ").ToString
            TextBox2.Text = data.Rows(0)("ชื่อ - นามสกุล").ToString
            MaskedTextBox1.Text = data.Rows(0)("Date").ToString
            MaskedTextBox2.Text = data.Rows(0)("date_use").ToString
            TextBox3.Text = data.Rows(0)("idbill").ToString
            lotcard.Text = data.Rows(0)("LOTCARD").ToString
            TextBox5.Text = data.Rows(0)("HN โปรโมชั่น").ToString
            TextBox4.Text = data.Rows(0)("ชื่อ นามสกุล").ToString
            MaskedTextBox3.Text = data.Rows(0)("หมดอายุบัตร").ToString
            date_e = Split(data.Rows(0)("วันหมดอายุโปร").ToString, "/")

            date_e1 = New System.DateTime(CInt(date_e(2)), CInt(date_e(1)), CInt(date_e(0)), 0, 0, 0)

            ConTran.Dispose()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub DataInformation_CellClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles DataInformation.CellClick
        Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
        grid = e.GridPanel.ActiveRow
        lotcard.Text = grid.Cells.Item(3).Value
        getDataLot()
        'TextBox1.Text = grid.Cells.Item(3).Value
        'TextBox2.Text = grid.Cells.Item(4).Value
        'status = grid.Cells.Item(5).Value
        'MaskedTextBox1.Text = grid.Cells.Item(0).Value

        'date_e = Split(grid.Cells.Item(1).Value.ToString, "/")

        'date_e1 = New System.DateTime(CInt(date_e(2)), CInt(date_e(1)), CInt(date_e(0)), 0, 0, 0)
     
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        If status = "ใช้โปรโมชั่นแล้ว" Then
            MsgBox("ได้ใช้โปรโมชั่นแล้ว")
        Else
            '

            If date_e1 < Date.Now Then

                MsgBox("บัตรหมดอายุไม่สามารถใช้โปรโมชั่นได้")
            Else
                datesetuse()
                dateend_card()
                Dim sql As String
                ConTran = ConnecDBRYH.NewConnection
                sql = "UPDATE checkup SET status = '1' , date_use = '" & Date.Now.ToString("dd/MM/yyyy") & "' , hn ='" & TextBox1.Text & "' , namelastname = '" & TextBox2.Text & "', hn1 ='" & TextBox5.Text & "' , namelastname1 = '" & TextBox4.Text & "' , date_register1 ='" & date_end.ToString("dd/MM/yyyy") & "' where lotcard = '" & lotcard.Text & "'"
                ConTran.ExecuteNonQuery(sql)
                ConTran.Dispose()
                MsgBox("บันทึกข้อมูลบัตรเรียบร้อยแล้ว")
                getDATA()
            End If
        End If


    End Sub

    Private Sub lotcard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lotcard.KeyDown
        If e.KeyCode = Keys.Enter Then
            getDataLot()
        End If

    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                MyODBCConnection.Open()
            Catch ex As Exception
                MsgBox("โปรดใช้เครื่องระบบ ในการกรอก Req")
            End Try
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF   WHERE RMSHNREF = '" & TextBox1.Text & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    TextBox2.Text = dr.GetString(0).Trim + "  " + dr.GetString(1).Trim

                    'End the loop
                End While
                'Reset the cursor


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If

    End Sub

    Private Sub TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                MyODBCConnection.Open()
            Catch ex As Exception
                MsgBox("โปรดใช้เครื่องระบบ ในการกรอก Req")
            End Try
            Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT RMSNAME,RMSSURNAM FROM REGMASV5PF   WHERE RMSHNREF = '" & TextBox1.Text & "'")

            selectCMD.Connection = MyODBCConnection


            Try
                'Set the mouse to show a Wait cursor
                Dim dr As OdbcDataReader = selectCMD.ExecuteReader
                'start the Read loop
                While dr.Read
                    'Note: the numbers in double quotes represent the column number from the AS400 database
                    'Add the data to the list view
                    TextBox4.Text = dr.GetString(0).Trim + "  " + dr.GetString(1).Trim

                    'End the loop
                End While
                'Reset the cursor


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Dim sql As String
        ConTran = ConnecDBRYH.NewConnection
        sql = "UPDATE checkup SET idbill ='" & TextBox3.Text & "' , hn ='" & TextBox1.Text & "' , namelastname = '" & TextBox2.Text & "', hn1 ='" & TextBox5.Text & "' , namelastname1 = '" & TextBox4.Text & "' , date_register1 ='" & MaskedTextBox3.Text & "' where lotcard = '" & lotcard.Text & "'"
        ConTran.ExecuteNonQuery(sql)
        ConTran.Dispose()
        MsgBox("บันทึกข้อมูลบัตรเรียบร้อยแล้ว")
        getDATA()
    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataInformation_Click(sender As Object, e As EventArgs) Handles DataInformation.Click

    End Sub
End Class