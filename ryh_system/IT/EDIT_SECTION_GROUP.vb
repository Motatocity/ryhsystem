Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class EDIT_SECTION_GROUP
    Dim sql As MySqlConnection = frmdevice_main.mysqlconection
    Dim idkey As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim inbtIndex As Integer

    Private Sub EDIT_SECTION_GROUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql.Close()
        Try
            sql.Open()
            ' MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearch.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device join floor join section join location where (data_device.idlocation = location.idlocation and location.idsection = section.idsection and section.idFloor = floor.idFloor) and state_device = 'ถูกใช้งาน' order by iddata_device  DESC ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            DataGridViewX1.Rows.Clear()


            While (mySqlReader.Read())
                DataGridViewX1.Rows.Add({mySqlReader("iddata_device"), mySqlReader("type"), mySqlReader("s_type"), mySqlReader("name"), mySqlReader("floor_name"), mySqlReader("section_name"), mySqlReader("location_name"), mySqlReader("state_device"), mySqlReader("serialnumber")})


            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        mySqlCommand.CommandText = "SELECT * FROM floor  order by idFloor;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewfloor.Items.Clear()

            While (mySqlReader.Read())

                With ListViewfloor.Items.Add(mySqlReader("idFloor"))
                    .SubItems.Add(mySqlReader("floor_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
        txtshow.Text = DataGridViewX1.Rows.Count
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = "13" Then
            showdata()
        End If
    End Sub
    Private Sub showdata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim key As String
        Dim count As Integer

        count = 0
        key = txtsearch.Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM data_device join floor join section join location where (data_device.idlocation = location.idlocation and location.idsection = section.idsection and section.idFloor = floor.idFloor)and (type like '%" + key + "%' or floor_name like '%" + key + "%' or section_name like '%" + key + "%' or location_name like '%" + key + "%' or serialnumber like '%" + key + "%' or s_type like '%" + key + "%' or detail like '%" + key + "%' or s_type like '%" + key + "%' or name like '%" + key + "%' or model like '%" + key + "%' or detail like '%" + key + "%' or iddata_device like '%" + key + "%'  ) and state_device = 'ถูกใช้งาน' order by iddata_device;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader



            DataGridViewX1.Rows.Clear()


            While (mySqlReader.Read())

                DataGridViewX1.Rows.Add({mySqlReader("iddata_device"), mySqlReader("type"), mySqlReader("s_type"), mySqlReader("name"), mySqlReader("floor_name"), mySqlReader("section_name"), mySqlReader("location_name"), mySqlReader("state_device"), mySqlReader("serialnumber")})

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("ห้ามใส่เครื่องหมาย ' ในช่องค้นหา", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning Message")
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewfloor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewfloor.Click
        idkey = ListViewfloor.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM section where idFloor = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewsection.Items.Clear()
            ListViewlocat.Items.Clear()
            While (mySqlReader.Read())

                With ListViewsection.Items.Add(mySqlReader("idsection"))
                    .subitems.add(mySqlReader("section_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewsection_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewsection.Click
        idkey = ListViewsection.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM location where idsection = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlocat.Items.Clear()

            While (mySqlReader.Read())

                With ListViewlocat.Items.Add(mySqlReader("idlocation"))
                    .subitems.add(mySqlReader("location_name"))
                    .subitems.add(mySqlReader("description_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewlocat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewlocat.Click
        idkey = ListViewlocat.SelectedItems(0).SubItems(0).Text

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM location  where idlocation = '" & idkey & "' ;"
        mySqlCommand.Connection = sql
        mySqlAdaptor.SelectCommand = mySqlCommand


        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtidlocation.Text = mySqlReader("idlocation")
                txtlocation.Text = mySqlReader("location_name")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sql.Close()
    End Sub

    Private Sub ListViewshow_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

        'ListViewshow.Items.RemoveAt(Listview3_Index)
    End Sub
    Private Sub add_aoi()
        Dim iddata_device As String = DataGridViewX1.Rows(inbtIndex).Cells(0).Value

        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        Dim CheckIndex As Integer
        Dim i As Integer
        Dim CheckData As Boolean

        CheckData = False
        CheckIndex = ListViewshowdata.Items.Count


        For i = 0 To CheckIndex - 1
            If iddata_device <> ListViewshowdata.Items(i).SubItems(0).Text Then

                CheckData = True

            Else

                CheckData = False
                Exit For
            End If
        Next i

        If CheckData = False And CheckIndex <> 0 Then
            MsgBox("มีรายชื่อนี้อยู่แล้ว", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning Message")

        End If

        If CheckData = True Or CheckIndex = 0 Then

            Dim mySqlCommand As New MySqlCommand
            Dim mySqlAdaptor As New MySqlDataAdapter
            Dim mySqlReader As MySqlDataReader

            mySqlCommand.CommandText = "SELECT * FROM data_device where iddata_device= '" & iddata_device & "';"
            mySqlCommand.Connection = sql
            mySqlAdaptor.SelectCommand = mySqlCommand

            Try
                mySqlReader = mySqlCommand.ExecuteReader
                While (mySqlReader.Read())

                    With ListViewshowdata.Items.Add(mySqlReader("iddata_device"))



                        If mySqlReader("type") = "Computer" Then
                            .SubItems.Add("Computer")
                        End If
                        If mySqlReader("type") = "Printer" Then
                            .SubItems.Add("Printer")
                        End If
                        If mySqlReader("type") = "Monitor" Then
                            .SubItems.Add("Monitor")
                        End If
                        If mySqlReader("type") = "Other" Then
                            .SubItems.Add("Other")
                        End If
                        If mySqlReader("type") = "License" Then
                            .SubItems.add("Licens")
                        End If
                        If mySqlReader("type") = "Network" Then
                            .SubItems.add("Network")
                        End If
                        If mySqlReader("type") = "Spare Part" Then
                            .subitems.add("Spare Part")
                        End If
                        .SubItems.Add(mySqlReader("name"))
                        If mySqlReader("state_device") IsNot DBNull.Value Then
                            .SubItems.Add(mySqlReader("state_device"))
                        End If
                        .SubItems.Add(mySqlReader("serialnumber"))

                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("ห้ามใส่เครื่องหมาย ' ในช่องค้นหา", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Warning Message")
            End Try
            sql.Close()
        End If
    End Sub

    Private Sub ListViewshowdata_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewshowdata.DoubleClick
        Dim Listview3_Index As Integer
        Listview3_Index = ListViewshowdata.SelectedIndices(0)
        ListViewshowdata.Items.RemoveAt(Listview3_Index)
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtidlocation.Text <> "" And ListViewshowdata.Items.Count > 0 Then

            savedata()
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลในตาราง", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub savedata()
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        Dim size As String
        Dim condition As String
        Dim respone As Object
        Dim commandText As String
        Dim commandText2 As String
        Dim commandText3 As String
        Dim counter1 As Integer = 0
        If sql.State = ConnectionState.Closed Then
            sql.Open()
        End If
        respone = MsgBox("ยืนยันข้อมูลถูกต้อง", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Warning Messsage")

        For counter1 = 0 To ListViewshowdata.Items.Count - 1

            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            commandText = "UPDATE data_device SET state_device = 'ถูกใช้งาน' , idlocation = '" & txtidlocation.Text & "' WHERE iddata_device = '" & ListViewshowdata.Items(counter1).SubItems(0).Text & "' "
            mySqlCommand.CommandText = commandText
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = sql
            mySqlCommand.ExecuteNonQuery()
            sql.Close()

            If sql.State = ConnectionState.Closed Then
                sql.Open()
            End If

            Try
                mySqlCommand.CommandText = "INSERT INTO device_location (iddata_device,idlocation,date_time_book) VALUES ('" & ListViewshowdata.Items(counter1).SubItems(0).Text & "',  '" & txtidlocation.Text & "','" & Date.Now.ToString & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = sql
                mySqlCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
            sql.Close()
        Next counter1
        ListViewshowdata.Items.Clear()
        txtidlocation.Text = ""

        showdata()

    End Sub



    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        showdata()
    End Sub


    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Try
            inbtIndex = e.RowIndex

            DataGridViewX1.Rows(inbtIndex).Selected = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridViewX1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellDoubleClick
        add_aoi()
    End Sub

    Private Sub DataGridViewX1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridViewX1.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub


End Class