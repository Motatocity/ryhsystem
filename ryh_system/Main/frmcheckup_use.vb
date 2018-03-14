Public Class frmcheckup_use
    Dim contran As ConnecDBRYH
    Dim data As DataTable
    Private Sub frmcheckup_use_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub getDATA()
        Dim sql As String
        sql = "Select date_register AS Date,date_end as วันหมดอายุ , lotcard as LOTCARD , hn as HN , namelastname as 'ชื่อ - นามสกุล'  ,case when( status = 0) then 'ยังไมได้ใช้โปรโมชั่น' else 'ใช้โปรโมชั่นแล้ว' end as สถานะ  from checkup"
        ConTran = ConnecDBRYH.NewConnection

        data = ConTran.GetTable(sql)
        DataInformation.PrimaryGrid.DataSource = data

        ConTran.Dispose()
    End Sub
End Class