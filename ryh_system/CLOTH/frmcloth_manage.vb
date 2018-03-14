Public Class frmcloth_manage
    Dim s As FILTERCLASS
    Private Sub SearchSTOCKTxt()
        Dim sql2 As String
        sql2 = "SELECT iduserdep,dep,description FROM rajyindee_db.userdep"
        s = New FILTERCLASS(deptxt, sql2, "รหัส,แผนก,ชื่อแผนก", "25,50,100", "1,1,1", "1,1,1")
        s.SetShowBorder = True
        s.SetTextIndex = 1
    End Sub
    Private Sub frmcloth_manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchSTOCKTxt()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal DEP As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class