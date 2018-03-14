Public Class CLOTHCLASS
    Private clothname As String
    Private F_STAT As Boolean
    Private IDMASCLOTH As Integer


    Private deptadjust As Integer
    Private qty1 As Integer
    Private qty2 As Integer


    Private idmainstock As Integer
    Private qtycloth As Integer
    Private qty1cloth As Integer

    Dim condb As ConnecDBRYH






    Public Property idmainstock_ As Integer
        Get
            Return idmainstock
        End Get
        Set(value As Integer)
            idmainstock = value
        End Set
    End Property

    Public Property qtycloth_ As Integer
        Get
            Return qtycloth
        End Get
        Set(value As Integer)
            qtycloth = value
        End Set
    End Property

    Public Property qty1cloth_ As Integer
        Get
            Return qty1cloth
        End Get
        Set(value As Integer)
            qty1cloth = value
        End Set
    End Property

    Public Property deptadjust_ As Integer
        Get
            Return deptadjust
        End Get
        Set(value As Integer)
            deptadjust = value
        End Set
    End Property

    Public Property qty1_ As Integer
        Get
            Return qty1
        End Get
        Set(value As Integer)
            qty1 = value
        End Set
    End Property

    Public Property qty2_ As Integer
        Get
            Return qty2
        End Get
        Set(value As Integer)
            qty2 = value
        End Set
    End Property

    Public Property clothname_ As String
        Get
            Return clothname
        End Get
        Set(value As String)
            clothname = value
        End Set
    End Property
    Public Property IDMASCLOTH_ As Integer
        Get
            Return IDMASCLOTH
        End Get
        Set(value As Integer)
            IDMASCLOTH = value
        End Set
    End Property

    Public Property F_STAT_ As Boolean
        Get
            Return F_STAT
        End Get
        Set(value As Boolean)
            F_STAT = value
        End Set
    End Property
    Public Sub INSERTMASCLOTH()
        condb = ConnecDBRYH.NewConnection
        Try
            Dim sql As String
            sql = "INSERT INTO mascloth (clothname,F_STAT) VALUES ('" & clothname & "' , " & Convert.ToInt16(F_STAT) & ")"
            condb.ExecuteNonQuery(sql)
            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว")
        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try
        condb.Dispose()

    End Sub
    Public Sub UPDATEMASCLOTH()
        condb = ConnecDBRYH.NewConnection
        Try
            Dim sql As String
            sql = "UPDATE mascloth SET clothname ='" & clothname & "' , F_STAT  = " & F_STAT & " WHERE  idmascloth = " & IDMASCLOTH & ""
            condb.ExecuteNonQuery(sql)
            'condb.Dispose()
            MsgBox("อัพเดทข้อมูลเรียบร้อยแล้ว")

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        condb.Dispose()
    End Sub
    Public Function SEARCHMASCLOTH() As DataTable
        condb = ConnecDBRYH.NewConnection
        Dim dt As New DataTable
        Try
            Dim sql As String
            sql = "SELECT idmascloth AS ID , clothname AS ชื่อ  , F_STAT AS สถานะ FROM mascloth "
            dt = condb.GetTable(sql)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        condb.Dispose()
        Return dt
    End Function
    Public Sub INSERTMAINSTOCKDT()
        condb = ConnecDBRYH.NewConnection
        Try
            Dim sql As String
            sql = "INSERT INTO mainstock_dt (deptadjust,qty1,qty2,idmascloth,dateadjust) VALUES (" & deptadjust & " , " & qty1 & ", " & qty2 & " , " & IDMASCLOTH & " ,current_timestamp() );"
            condb.ExecuteNonQuery(sql)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        condb.Dispose()
    End Sub
    Public Sub UPDATEMAINSTOCK()
        condb = ConnecDBRYH.NewConnection
        Try

            Dim sql As String
            sql = "UPDATE mainstock SET qtycloth = " & qtycloth & "  , qty1cloth =" & qty1cloth & " WHERE  idmainstock = " & idmainstock & "; "
            condb.ExecuteNonQuery(sql)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        condb.Dispose()
    End Sub
    Public Function SEARCHADJUST(ByVal ID As Integer, ByVal IDDEPT As Integer) As DataTable
        Dim dt As New DataTable
        condb = ConnecDBRYH.NewConnection
        Try
            Dim sql As String
            sql = "SELECT * FROM  mainstock JOIN mascloth ON mainstock.idmascloth = mascloth.idmascloth WHERE mascloth.idmascloth = " & ID & " and deptcloth = " & IDDEPT & " ;"
            dt = condb.GetTable(sql)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        condb.Dispose()
        Return dt
    End Function


    Public Sub INSERTSTOCKMAINFIRST()
        condb = ConnecDBRYH.NewConnection
        Try
            Dim sql As String
            sql = "INSERT INTO  mainstock (idmascloth,qtycloth,qty1cloth,deptcloth ) VALUES "
            sql += " ( " & IDMASCLOTH & "  , " & qtycloth & " , " & qty1cloth & ", " & deptadjust_ & " ) "

            condb.ExecuteNonQuery(sql)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        condb.Dispose()
    End Sub
    Public Function SEARCHDEPCLOTH(ByVal IDDEPT As Integer) As DataTable
        Dim dt As New DataTable
        condb = ConnecDBRYH.NewConnection
        Try
            Dim sql As String
            sql = " SELECT idmainstock AS ID , clothname as 'ชื่อ' , qtycloth as 'จำนวน' , qty1cloth as 'ใช้งานแล้ว'  , F_STAT as 'สถานะ' FROM mainstock join mascloth ON mainstock.idmascloth = mascloth.idmascloth WHERE  deptcloth = '" & IDDEPT & "' "
            dt = condb.GetTable(sql)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        condb.Dispose()
        Return dt
    End Function


    Public Function SEARCHSTOCKDTBYDEF(ByVal dept As Integer, ByVal IDMAS As Integer) As DataTable
        Dim dt As New DataTable
        condb = ConnecDBRYH.NewConnection
        Try
            Dim sql As String
            sql = " SELECT  idmainstock_dt AS ID , clothname as 'ชื่อ'  , qty1 as 'เหลือ' , qty2 as 'ใช้งานแล้ว' ,dateadjust as 'วันที่ปรับปรุง'    FROM  mainstock_dt  JOIN mascloth ON mainstock_dt.idmascloth   = mascloth.idmascloth WHERE mainstock_dt.deptadjust = " & dept & " and mainstock_dt.idmascloth = " & IDMAS & "; "
            dt = condb.GetTable(sql)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        condb.Dispose()
        Return dt
    End Function


   
End Class
