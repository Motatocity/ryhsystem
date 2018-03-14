Imports MySql.Data.MySqlClient
Imports System.IO
Public Class SelectTraining
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Public Shared idcourse As String

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If ListView1.SelectedItems.Count > 0 Then
            Dim cf As New SelectGrpupTraining

            cf.MdiParent = Me.MdiParent
            Me.Close()
            cf.Dock = DockStyle.Fill
            cf.Show()
        Else
            MsgBox("กรุณาเลือกคอร์สอบรม")
        End If

    End Sub

    Private Sub SelectTraining_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql = New MySqlConnection
        mysql.ConnectionString = "server=ryh1;port = 3306;user id=" + "june" + ";password=" + "software" + ";database=testremote;Character Set =utf8"

        'mysql.ConnectionString = "Server=172.26.8.182;Database=testremote;Uid=root;Pwd=software;CharSet=UTF8;"
        Try
            mysql.Open()
            '    MsgBox("CONNECTED TO DATABASE")
        Catch ex As Exception
            MsgBox("Can't Connect to database" + ex.Message)

            Me.Close()
        End Try
        Dim mySqlCommand As New MySqlCommand
        Dim mySqlAdaptor As New MySqlDataAdapter
        Dim mySqlReader As MySqlDataReader
        mySqlCommand.CommandText = "SELECT * FROM course;"
        ' mySqlCommand.CommandText = 
        mySqlCommand.Connection = mysql
        mySqlAdaptor.SelectCommand = mySqlCommand
        Try
            mySqlReader = mySqlCommand.ExecuteReader

            ListView1.Items.Clear()

            While (mySqlReader.Read())

                With ListView1.Items.Add(mySqlReader("course_id"))

                    .SubItems.Add(mySqlReader("course_name"))
                    .SubItems.Add(mySqlReader("course_trainer"))
                    .SubItems.Add(mySqlReader("course_start_date"))
            
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mysql.Close()


    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        idcourse = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim cf As New frmEditCourse

            cf.MdiParent = Me.MdiParent
            Me.Close()
            cf.Dock = DockStyle.Fill
            cf.Show()
        Else
            MsgBox("กรุณาเลือกคอร์สอบรม")
        End If
    End Sub
End Class