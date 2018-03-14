Public Class frmsetup_shareryh
    Dim ConnectionDB As ConnecDBRYH = ConnecDBRYH.NewConnection()
    Private Sub frmsetup_shareryh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT idryh_sum ,sum,(sum + sum*4) / 4  AS TOTAL , ROUND( ((sum + sum*4) / 4) /3 )  AS T1 ,  ROUND( ((sum + sum*4) / 4) /3 )  AS T2  , ( ((sum + sum*4) / 4 )  -  ROUND( ((sum + sum*4) / 4) /3 ) -  ROUND( ((sum + sum*4) / 4) /3 )  )  as T3 FROM rajyindee_db.ryh_main join ryh_sum ON ryh_main.idryh_main = ryh_sum.ID ;"
        Dim dt As DataTable = New DataTable
        dt = ConnectionDB.GetTable(sql)
        ConnectionDB.Dispose()

        For a As Integer = 0 To dt.Rows.Count - 1
            Try
                ConnectionDB = ConnecDBRYH.NewConnection
                ConnectionDB.BeginTrans()
                Dim sql2 As String
                sql2 = "INSERT INTO ryh_sumdetail (idryh_sum,sum,count,checkryh) VALUES "
                sql2 += " ( "
                sql2 += " '" & dt.Rows(a)("idryh_sum").ToString & "', "
                sql2 += " '" & dt.Rows(a)("T1").ToString & "', "
                sql2 += " '1', "
                sql2 += " '0'"
                sql2 += " ) ;"
                ConnectionDB.ExecuteNonQuery(sql2)
                Dim sql3 As String
                sql3 = "INSERT INTO ryh_sumdetail (idryh_sum,sum,count,checkryh) VALUES "
                sql3 += " ( "
                sql3 += " '" & dt.Rows(a)("idryh_sum").ToString & "', "
                sql3 += " '" & dt.Rows(a)("T2").ToString & "', "
                sql3 += " '2', "
                sql3 += " '0'"
                sql3 += " ) ;"
                ConnectionDB.ExecuteNonQuery(sql3)
                Dim sql4 As String
                sql4 = "INSERT INTO ryh_sumdetail (idryh_sum,sum,count,checkryh) VALUES "
                sql4 += " ( "
                sql4 += " '" & dt.Rows(a)("idryh_sum").ToString & "', "
                sql4 += " '" & dt.Rows(a)("T3").ToString & "', "
                sql4 += " '3', "
                sql4 += " '0'"
                sql4 += " ) ;"
                ConnectionDB.ExecuteNonQuery(sql4)
                ConnectionDB.CommitTrans()
                ConnectionDB.Dispose()
            Catch ex As Exception
                ConnectionDB.RollbackTrans()
                ConnectionDB.Dispose()
            End Try
        
        Next

    End Sub
End Class