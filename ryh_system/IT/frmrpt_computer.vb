
Public Class frmrpt_computer
    Protected ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Dim rpt1 As New CrystalReport2

    Private Sub frmrpt_computer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim dt As New DataTable
        sql = "SELECT  c_cpu ,  section_name , section.idFloor as floorid,iddata_device,c_ram as cram, c_harddisk as chd,c_ipnumber as ipaddress  from it_rajyindee.data_device left join it_rajyindee.location on data_device.idlocation = location.idlocation left join it_rajyindee.section on section.idsection = location.idsection where type ='Computer' order by  section.idFloor DESC;"
        Dim set1 As DataSet = New DataSet("computer")

        dt = ConnectionDB.GetTable(sql)


        rpt1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt1


    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class