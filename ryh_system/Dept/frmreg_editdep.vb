Imports MySql.Data.MySqlClient
Public Class frmreg_editdep
    Dim mysql As MySqlConnection = main_reg.mysql
    Dim mySqlCommand As New MySqlCommand
    Dim mySqlAdaptor As New MySqlDataAdapter
    Dim mySqlReader As MySqlDataReader
    Dim respone As Object
    Dim iddep As String
    Private Sub frmreg_editdep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        mySqlCommand.CommandText = "Select * from department;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("iddepartment"))
                    .SubItems.Add(mySqlReader("namedepart"))
                    .SubItems.Add(mySqlReader("nickdepart"))
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


    End Sub

   

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        iddep = ListView1.SelectedItems(0).SubItems(0).Text


        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If


        mySqlCommand.CommandText = "Select * from department where iddepartment ='" & iddep & "';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader

            While (mySqlReader.Read())
                txtcustomer.Text = mySqlReader("namedepart")
                txtcustomer_address.Text = mySqlReader("nickdepart")

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()



    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click


        mysql.Close()
        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If
        Try
            Dim commandText2 As String
            commandText2 = "UPDATE department SET namedepart = '" & txtcustomer.Text & "' , nickdepart = '" & txtcustomer_address.Text & "'  WHERE iddepartment = " & iddep & "; "
            mySqlCommand.CommandText = commandText2
            mySqlCommand.CommandType = CommandType.Text
            mySqlCommand.Connection = mysql

            mySqlCommand.ExecuteNonQuery()
            mysql.Close()
            txtcustomer.Text = ""
            txtcustomer_address.Text = ""
            MsgBox("แก้ไขข้อเรียบร้อย")
            searchdata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        searchdata()
    End Sub

    Public Sub searchdata()
        mysql.Close()

        If mysql.State = ConnectionState.Closed Then
            mysql.Open()
        End If

        mySqlCommand.CommandText = "Select * from department where namedepart like '%" & TextBoxItem2.Text & "%';"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand

        Try
            mySqlReader = mySqlCommand.ExecuteReader
            ListView1.Items.Clear()
            While (mySqlReader.Read())
                With ListView1.Items.Add(mySqlReader("iddepartment"))
                    .SubItems.Add(mySqlReader("namedepart"))
                    .SubItems.Add(mySqlReader("nickdepart"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


    End Sub

    Private Sub TextBoxItem2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxItem2.KeyDown

        If e.KeyCode = Keys.Enter Then
            searchdata()
        End If


    End Sub
End Class