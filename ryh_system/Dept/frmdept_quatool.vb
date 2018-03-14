Public Class frmdept_quatool
    Dim connectdb As ConnecDBRYH = ConnecDBRYH.NewConnection
    Dim checksaveedit As Boolean = False
    Dim checksaveedit1 As Boolean = False

    Dim idkey As String

    Public Sub loadTool()
        connectdb = ConnecDBRYH.NewConnection
        Dim sql As String = "Select idcategory AS 'ID', category_name As 'GROUP' FROM category_tool"
        DataInformation.PrimaryGrid.DataSource = connectdb.GetTable(sql)
        connectdb.Dispose()
    End Sub
    Public Sub loadTool1()
        connectdb = ConnecDBRYH.NewConnection
        Dim sql As String = "Select idgroup_tool AS 'ID', name As 'ชื่อเครื่องมือ',category_tool,category_name As 'GROUP' FROM group_tool join category_tool on category_tool.idcategory = group_tool.category_tool;"
        SuperGridControl3.PrimaryGrid.DataSource = connectdb.GetTable(sql)
        connectdb.Dispose()

        connectdb = ConnecDBRYH.NewConnection

        Dim dbtable As DataTable
        sql = "Select idcategory,category_name from category_tool;"
        dbtable = connectdb.GetTable(sql)
        Try
            With ComboBox1
                .DataSource = dbtable
                .DisplayMember = "category_name"
                .ValueMember = "idcategory"
                .BindingContext = BindingContext
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub savedata1()
        Dim sql As String
        sql = "Insert into group_tool"
        sql += "(name,category_tool) VALUES "
        sql += "('" & TextBoxX3.Text & "','" & ComboBox1.SelectedValue & "');"
        connectdb = ConnecDBRYH.NewConnection
        connectdb.ExecuteNonQuery(sql)
        connectdb.Dispose()
    End Sub
    Public Sub updateData1()
        Dim sql As String
        sql = "UPDATE group_tool SET "
        sql += "name ='" & TextBoxX3.Text.ToString & "' , category_tool ='" & ComboBox1.SelectedValue & "'"
        sql += " where idgroup_tool ='" & TextBoxX4.Text.ToString & "';"
        connectdb = ConnecDBRYH.NewConnection
        connectdb.ExecuteNonQuery(sql)
        connectdb.Dispose()
    End Sub
    Public Sub savedata()
        Dim sql As String
        sql = "Insert into category_tool"
        sql += "(category_name) VALUES "
        sql += "('" & TextBoxX1.Text & "');"
        connectdb = ConnecDBRYH.NewConnection
        connectdb.ExecuteNonQuery(sql)
        connectdb.Dispose()
    End Sub
    Public Sub updateData()
        Dim sql As String
        sql = "UPDATE category_tool SET "
        sql += "category_name ='" & TextBoxX1.Text.ToString & "' "
        sql += " where idcategory ='" & TextBoxX2.Text.ToString & "';"
        connectdb = ConnecDBRYH.NewConnection
        connectdb.ExecuteNonQuery(sql)
        connectdb.Dispose()
    End Sub
    Public Sub clear()
        checksaveedit = False
        TextBoxX1.Clear()
        TextBoxX2.Clear()
    End Sub
    Public Sub clear1()
        checksaveedit1 = False
        TextBoxX4.Clear()
        ComboBox1.SelectedIndex = -1
        TextBoxX3.Clear()

    End Sub

    Private Sub frmdept_quatool_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadTool()
        loadTool1()
        clear1()
        clear()
    End Sub
 
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If checksaveedit = False Then
            savedata()
              clear()
        Else
            Dim editStat As Integer
            editStat = MsgBox("ท่านต้องการบันทึกข้อมูลใหม่ใช่หรือไม่", MsgBoxStyle.OkCancel)
            If editStat = 1 Then
                savedata()

                clear()
            Else
            End If
        End If

        loadTool()
        loadTool1()


    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If checksaveedit = True Then
            updateData()
            loadTool()
            loadTool1()
            clear()
        Else
        End If
    End Sub

    Private Sub DataInformation_CellClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles DataInformation.CellClick
        Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
        grid = e.GridPanel.ActiveRow
        TextBoxX2.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value()
        TextBoxX1.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("GROUP").Value()
        checksaveedit = True
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        clear()
    End Sub

    Private Sub SuperTabControlPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperTabControlPanel1.Click

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        clear1()
    End Sub

    Private Sub SuperGridControl3_CellClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs) Handles SuperGridControl3.CellClick

        Dim grid As DevComponents.DotNetBar.SuperGrid.GridRow
        grid = e.GridPanel.ActiveRow
        TextBoxX4.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ID").Value()
        TextBoxX3.Text = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("ชื่อเครื่องมือ").Value()
        ComboBox1.SelectedValue = CType(e.GridPanel.ActiveRow, DevComponents.DotNetBar.SuperGrid.GridRow).Cells("category_tool").Value()
        checksaveedit1 = True
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        If checksaveedit1 = False Then
            savedata1()
            loadTool1()
            clear1()
        Else
            Dim editStat As Integer
            editStat = MsgBox("ท่านต้องการบันทึกข้อมูลใหม่ใช่หรือไม่", MsgBoxStyle.OkCancel)
            If editStat = 1 Then
                savedata1()
                loadTool1()
                clear1()
            Else
            End If
        End If
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        If checksaveedit1 = True Then
            updateData1()
            loadTool()
            loadTool1()
            clear1()
        Else
        End If
    End Sub
End Class