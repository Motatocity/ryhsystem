Imports System.IO.MemoryStream
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Public Class Help_Add
    Dim mysql As MySqlConnection
    Dim idkey As String
    Dim ipconnect As String
    Dim usernamedb As String
    Dim dbname As String
    Dim mysqlpass As String
    Dim id_user As String
    Dim position_user As String
    Dim mysql_pass As String
    Dim ip_connect As String
    Dim user_namedb As String
    Dim db_name As String
    Dim mstream As New System.IO.MemoryStream
    Dim desciptionname As String = " "
    Dim inbtIndex As Integer


    Dim checkstat As String = "0"
  
    Private Sub Help_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySql = New MySqlConnection
      ip_connect = "ryh1"
        db_name = "it_rajyindee"
        mysql_pass = "software"
        user_namedb = "june"

        MySql.ConnectionString = "server=" + ip_connect + ";user id=" + user_namedb + ";password=" + mysql_pass + ";database=" + db_name + ";Character Set =utf8;"
        Try
            MySql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
        Dim mysqlcommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mysqlreader As MySqlDataReader
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        mysqlcommand.CommandText = "SELECT * FROM helpdesk order by state_problem ,idhelpdesk DESC ;"
        mysqlcommand.Connection = mysql
        mySqlAdaptor.SelectCommand = MySqlCommand
        Try
            mysqlreader = MySqlCommand.ExecuteReader
            DataGridViewX1.Rows.Clear()
            While (mysqlreader.Read())

                DataGridViewX1.Rows.Add({mysqlreader("idhelpdesk"), mysqlreader("type_problem"), mysqlreader("agencies"), mysqlreader("location"), mysqlreader("problem"), mysqlreader("edit_problem"), mysqlreader("state_problem"), mysqlreader("officer"), mysqlreader("date")})



            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        MySqlCommand.CommandText = "SELECT * FROM officer order by idofficer ;"
        mysqlcommand.Connection = mysql
        mySqlAdaptor.SelectCommand = MySqlCommand
        Try
            mysqlreader = MySqlCommand.ExecuteReader
            ComboBoxofficer.Items.Clear()
            While (mysqlreader.Read())
                ComboBoxofficer.Items.Add(mysqlreader("officer_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        MySqlCommand.CommandText = "SELECT * FROM floor order by idFloor;"
        mysqlcommand.Connection = mysql
        mySqlAdaptor.SelectCommand = MySqlCommand

        Try
            mysqlreader = MySqlCommand.ExecuteReader
            ListViewfloor.Items.Clear()
            While (mysqlreader.Read())

                With ListViewfloor.Items.Add(mysqlreader("idFloor"))
                    .SubItems.Add(mysqlreader("floor_name"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        mysqlcommand.CommandText = "SELECT * FROM rajyindee_db.department;"
        mysqlcommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mysqlcommand

        Try
            mysqlreader = mysqlcommand.ExecuteReader
            ComboBox1.Items.Clear()

            While (mysqlreader.Read())

                ComboBox1.Items.Add(mysqlreader("nickdepart"))

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




        mysql.Close()
        txtnameperson.Focus()
        checkcolor()
    End Sub
    Public Sub checkcolor()


        For i As Integer = 0 To DataGridViewX1.Rows.Count - 1
            If DataGridViewX1.Rows(i).Cells(6).Value = "กำลังดำเนินการ" Then

                'DGV1.DefaultCellStyle.SelectionForeColor = Color.Red

                DataGridViewX1.Rows(i).Cells(6).Style.BackColor = Color.DarkOrange
            Else
                DataGridViewX1.Rows(i).Cells(6).Style.BackColor = Color.CadetBlue
            End If



        Next
    End Sub

    Private Sub btnxsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxsave.Click

        Dim mysqlcommand As New MySqlCommand
        Dim mysqladeptor As New MySqlDataAdapter
        Dim mysqlreader As MySqlDataReader
        If checkstat = "0" Then


            'Dim count As String
            'Dim respone As String
            'Dim FileSize As UInt32
            'Dim rawData() As Byte
            'Dim fs As FileStream

            'fs = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            'FileSize = fs.Length

            'rawData = New Byte(FileSize) {}
            'fs.Read(rawData, 0, FileSize)
            'fs.Close()

            mysql.Close()

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If
            'โค้ดบังคับกรอกข้อมูล

            If txtproblem.Text = "" Or txteditproblem.Text = "" Or txtnamesection.Text = "" Or ComboBoxofficer.Text = "" Or ComboBoxstate.Text = "" Or ComboBoxtype.Text = "" Then

                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    'mysqlcommand.CommandText = "INSERT INTO helpdesk (name_person,agencies,type_problem,location,problem,officer,date,state_problem,edit_problem,image_photo,size_photo,file_name) VALUES ('" & txtnameperson.Text & "' , '" & txtnamesection.Text & "', '" & ComboBoxtype.Text & "','" & txtidlocat.Text & "', '" & txtproblem.Text & "', '" & ComboBoxofficer.Text & "', '" + Date.Now.Day.ToString + "/" + Date.Now.Month.ToString + "/" + Date.Now.Year.ToString + "' , '" & ComboBoxstate.Text & "', '" & txteditproblem.Text & "' ,@photo,@FileSize,@name) ; "
                    'mysqlcommand.CommandType = CommandType.Text
                    'mysqlcommand.Connection = sql
                    'mysqlcommand.Parameters.AddWithValue("@name", OpenFileDialog1.FileName)
                    'mysqlcommand.Parameters.AddWithValue("@FileSize", FileSize)
                    'mysqlcommand.Parameters.AddWithValue("@photo", rawData)

                    mysqlcommand.CommandText = "INSERT INTO helpdesk (name_person,agencies,type_problem,location,problem,officer,date,state_problem,edit_problem,idlocation,idsection,description_name,timing,dept) VALUES ('" & txtnameperson.Text & "' , '" & txtnamesection.Text & "', '" & ComboBoxtype.Text & "','" & txtnamelocat.Text & "', '" & txtproblem.Text & "', '" & ComboBoxofficer.Text & "', '" + Date.Now.Day.ToString + "/" + Date.Now.Month.ToString + "/" + Date.Now.Year.ToString + "' , '" & ComboBoxstate.Text & "', '" & txteditproblem.Text & "', '" & txtidlocat.Text & "', '" & txtidsection.Text & "','" & desciptionname & "','" & TextBox1.Text & "','" & ComboBox1.Text & "') ; "
                    mysqlcommand.CommandType = CommandType.Text
                    mysqlcommand.Connection = mysql

                    mysqlcommand.ExecuteNonQuery()
                    MessageBox.Show("เก็บเข้าฐานข้อมูลแล้วจ้า", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtnameperson.Text = ""
                    txtnamesection.Text = ""
                    ComboBoxtype.Text = ""
                    txtproblem.Text = ""
                    ComboBoxofficer.Text = ""
                    ComboBoxstate.Text = ""
                    txteditproblem.Text = ""
                    txtidlocat.Text = ""
                    txtnamelocat.Text = ""
                    txtidsection.Text = ""
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
            End If
            mysql.Close()

            If mysql.State = ConnectionState.Closed Then
                mysql.Open()
            End If

        ElseIf checkstat = "1" Then
            Dim commandText2 As String

            Try
                commandText2 = "UPDATE helpdesk SET name_person = '" & txtnameperson.Text & "'  , type_problem = '" & ComboBoxtype.Text & "', problem = '" & txtproblem.Text & "' , officer = '" & ComboBoxofficer.Text & "'  , state_problem = '" & ComboBoxstate.Text & "' , edit_problem = '" & txteditproblem.Text & "' , timing ='" & TextBox1.Text & "', dept ='" & ComboBox1.Text & "' WHERE idhelpdesk = " & Label6.Text & "; "
                mysqlcommand.CommandText = commandText2
                mysqlcommand.CommandType = CommandType.Text
                mysqlcommand.Connection = mysql
                mysqlcommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try








        End If
        MySqlCommand.CommandText = "SELECT * FROM helpdesk order by idhelpdesk DESC ;"
        MySqlCommand.Connection = mysql
        mysqladeptor.SelectCommand = MySqlCommand

        Try
            mysqlreader = MySqlCommand.ExecuteReader
            DataGridViewX1.Rows.Clear()
            While (mysqlreader.Read())

                DataGridViewX1.Rows.Add({mysqlreader("idhelpdesk"), mysqlreader("type_problem"), mysqlreader("agencies"), mysqlreader("location"), mysqlreader("problem"), mysqlreader("edit_problem"), mysqlreader("state_problem"), mysqlreader("officer"), mysqlreader("date")})




            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        checkcolor()
    End Sub
    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        txtnameperson.Text = ""
        txtproblem.Text = ""
        txtnamesection.Text = ""
        ComboBoxofficer.Text = ""
        ComboBoxtype.Text = ""
        ComboBoxstate.Text = ""
        txtidlocat.Text = ""
        txtnamelocat.Text = ""
        txteditproblem.Text = ""
        txtnameperson.Focus()
    End Sub
    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mysqlcommand As New MySqlCommand
        Dim mysqladeptor As New MySqlDataAdapter
        Dim mysqlreader As MySqlDataReader

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mysqlcommand.CommandText = "SELECT * FROM helpdesk order by idhelpdesk DESC ;"
        mysqlcommand.Connection = mysql
        mysqladeptor.SelectCommand = mysqlcommand

        Try
            mysqlreader = mysqlcommand.ExecuteReader
            DataGridViewX1.Rows.Clear()
            While (mysqlreader.Read())

                DataGridViewX1.Rows.Add({mysqlreader("idhelpdesk"), mysqlreader("type_problem"), mysqlreader("agencies"), mysqlreader("location"), mysqlreader("problem"), mysqlreader("edit_problem"), mysqlreader("state_problem"), mysqlreader("officer"), mysqlreader("date")})



            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        checkcolor()
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Input As String
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Try
            Input = InputBox("ADD OFFICER")
            If Input.Length > 0 Then

                mySqlCommand.CommandText = "INSERT INTO officer (officer_name) VALUES ('" & Input & "');"
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.Connection = mysql
                mySqlCommand.ExecuteNonQuery()
                MessageBox.Show("เก็บเข้าฐานข้อมูลแล้ว", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM officer order by idofficer ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ComboBoxofficer.Items.Clear()
            While (mySqlReader.Read())
                ComboBoxofficer.Items.Add(mySqlReader("officer_name"))

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NextForm As Help_Editofficer = New Help_Editofficer
        NextForm.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NextForm As Help_Show = New Help_Show
        NextForm.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "ยืนยันออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnxbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxbrowse.Click
        OpenFileDialog1.Filter = ("ไฟล์รูปภาพ JPEG,GIF,PNG,BMP|*.jpg; *.gif; *.png; *.bmp")
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtxphoto.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ListViewfloor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewfloor.Click
        idkey = ListViewfloor.SelectedItems(0).SubItems(0).Text

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT * FROM section where idFloor = '" & idkey & "' ;"
        mySqlCommand.Connection = mysql
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
        mysql.Close()
    End Sub
    Public Sub searchdept()
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        DataGridViewX1.Rows.Clear()

        mySqlCommand.CommandText = "SELECT * FROM department;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                ComboBox1.Items.Add(mySqlReader("nickdepart"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub
    Private Sub ListViewsection_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewsection.Click
        idkey = ListViewsection.SelectedItems(0).SubItems(0).Text

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader


        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim count As Integer = 1

        mySqlCommand.CommandText = "SELECT location.idlocation,location_name,c_ipnumber,description_name    FROM location left join data_device on location.idlocation = data_device.idlocation where idsection = '" & idkey & "' and type = 'Computer' ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListViewlocat.Items.Clear()

            While (mySqlReader.Read())

                With ListViewlocat.Items.Add(mySqlReader("idlocation"))
                    .subitems.add(mySqlReader("location_name"))
                    .subitems.add(mySqlReader("description_name"))
                    .subitems.add(mySqlReader("c_ipnumber"))

                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "SELECT * FROM section  where idsection = '" & idkey & "' ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand


        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtnamesection.Text = mySqlReader("section_name")
                txtidsection.Text = mySqlReader("idsection")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub ListViewlocat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewlocat.Click
        idkey = ListViewlocat.SelectedItems(0).SubItems(0).Text

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader

        mySqlCommand.CommandText = "SELECT * FROM location  where idlocation = '" & idkey & "' ;"
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand




        Try
            mySqlReader = mySqlCommand.ExecuteReader
            While (mySqlReader.Read())
                txtnamelocat.Text = mySqlReader("location_name")
                txtidlocat.Text = mySqlReader("idlocation")
                desciptionname = mySqlReader("description_name")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub ListViewhelp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        checkstat = "1"
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Dim mysqlcommand As New MySqlCommand
        Dim mysqladeptor As New MySqlDataAdapter
        Dim mysqlreader As MySqlDataReader

        mysqlcommand.CommandText = " SELECT * FROM helpdesk where idhelpdesk = '" & idkey & "' ;"
        mysqlcommand.Connection = mysql
        mysqladeptor.SelectCommand = mysqlcommand

        Try
            mysqlreader = mysqlcommand.ExecuteReader
            While (mysqlreader.Read())
                Label6.Text = mysqlreader("idhelpdesk")
                txtnameperson.Text = mysqlreader("name_person")
                txtproblem.Text = mysqlreader("problem")
                txteditproblem.Text = mysqlreader("edit_problem")
                ComboBoxofficer.Text = mysqlreader("officer")
                ComboBoxstate.Text = mysqlreader("state_problem")
                ComboBoxtype.Text = mysqlreader("type_problem")

                If mysqlreader("dept") Is DBNull.Value Then
                Else
                    ComboBox1.Text = mysqlreader("dept")
                End If

                If mysqlreader("timing") Is DBNull.Value Then
                Else
                    TextBox1.Text = mysqlreader("timing")
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()
    End Sub

    Private Sub DataGridViewX1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        inbtIndex = e.RowIndex
        idkey = DataGridViewX1.Rows(inbtIndex).Cells(0).Value
    End Sub

    Private Sub DataGridViewX1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter

    End Sub

    Private Sub DataGridViewX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewX1.Click

    End Sub
End Class