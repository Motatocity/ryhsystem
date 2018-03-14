Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.Odbc
Public Class frmpersonal1
    Public Path_SQL As String
    Dim mysql As MySqlConnection
    Public Shared idcourse As String
    Dim SelectedEmployee As String
    Public respone As Object
    Public test As String
    Public time_start As String
    Public time_end As String
    '---- Datetime Variable ---
    Dim date_split() As String
    Dim date_split2() As String
    Dim start_date_hh As String
    Dim start_date_mm As String
    Dim end_date_hh As String
    Dim end_date_mm As String
    Dim start_date As Date
    Dim end_date As Date
    Dim select_start_date As String
    Dim select_end_date As String
    Public Shared idpersonal As String
    Dim MyODBCConnection As New OdbcConnection("dsn=RYHV4; Userid=JUNE;Password=it5;")
    Private Sub frmpersonal1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If
        Dim selectCMD As OdbcCommand = New OdbcCommand("SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO  WHERE SMSDIVCOD <> 'RT' and SMSDIVCOD <> '001' ")

        selectCMD.Connection = MyODBCConnection

        Try
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader


            ListView1.Items.Clear()
            While (dr.Read())



                With ListView1.Items.Add(dr.GetString(0).Trim)

                    .SubItems.Add(dr.GetString(1).Trim)
                    .SubItems.Add(dr.GetString(2).Trim)
                    .SubItems.Add(dr.GetString(3).Trim + " " + dr.GetString(4).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)
                    .SubItems.Add(dr.GetString(6).Trim)

                End With


            End While
            dr.Close()

            'Catch ex As MySqlException
            'MsgBox(ex.Message)
        Catch ex As MySqlException
            MsgBox(ex.ToString)

        End Try
        MyODBCConnection.Close()


    End Sub
    Public Sub searchEmp()
        Dim stringCmd As String
        stringCmd = "SELECT SMSSTFNO,SMSHN,SMSIDNO,SMSNAME,SMSSURNAM,SMSDIVCOD,SFDCURTEL FROM STFMASV4PF join STFDETV4PF on STFMASV4PF.SMSSTFNO = STFDETV4PF.SFDSTFNO WHERE  SMSDIVCOD <> '001' and SMSDIVCOD <> 'RT' and (SMSDIVCOD like '%" & TextBox1.Text & "%' or SMSHN like '%" & TextBox1.Text & "%' or SMSSTFNO like '%" & TextBox1.Text & "%' or SMSNAME like '%" & TextBox1.Text & "%')"

        Dim selectCMD As OdbcCommand = New OdbcCommand(stringCmd)
        If MyODBCConnection.State = ConnectionState.Closed Then
            MyODBCConnection.Open()
        End If


        selectCMD.Connection = MyODBCConnection

        Try
            Dim dr As OdbcDataReader = selectCMD.ExecuteReader

            ListView1.Items.Clear()
            While (dr.Read())



                With ListView1.Items.Add(dr.GetString(0).Trim)
                    .SubItems.Add(dr.GetString(1).Trim)
                    .SubItems.Add(dr.GetString(2).Trim)
                    .SubItems.Add(dr.GetString(3).Trim + " " + dr.GetString(4).Trim)
                    .SubItems.Add(dr.GetString(5).Trim)
                    .SubItems.Add(dr.GetString(6).Trim)
                End With


            End While
            dr.Close()

            'Catch ex As MySqlException
            'MsgBox(ex.Message)
        Catch ex As MySqlException
            MsgBox(ex.ToString)

        End Try
        MyODBCConnection.Close()
    End Sub


    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchEmp()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim cf As New frmpersonal2

            cf.MdiParent = Me.MdiParent
            Me.Close()
            cf.Dock = DockStyle.Fill
            cf.Show()
        Else
            MsgBox("กรุณาเลือกพนักงาน")
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        idpersonal = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub
End Class