Public Class CLOTHDEPTCLASS
    Dim CONDB As ConnecDBRYH = ConnecDBRYH.NewConnection
    Public Sub REQUESTSENDCLOTHBYDEPT()



    End Sub

    Public Function SEARCHUSECLOTH(ByRef DEPT As Integer) As DataTable
        Dim dt As New DataTable
        CONDB = ConnecDBRYH.NewConnection
        Try
            Dim sql As String
            sql = " SELECT  idmainstock AS ID , clothname as 'ชื่อ'  ,(qtycloth + qty1cloth ) AS 'ทั้งหมด', qtycloth as 'เหลือ' , qty1cloth as 'ใช้งานแล้ว' , 0 as 'เพิ่มใช้งานแล้ว' , qty1cloth as 'รวมใช้งานแล้ว'  FROM  mainstock  JOIN mascloth ON mainstock.idmascloth   = mascloth.idmascloth WHERE mainstock.deptcloth = " & DEPT & "; "
            dt = CONDB.GetTable(sql)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        CONDB.Dispose()
        Return dt
    End Function

End Class
