Public Class frmclothdept_send
    Dim cloth As CLOTHCLASS = New CLOTHCLASS
    Dim dt As New DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dt As New DataTable
        dt = cloth.SEARCHDEPCLOTH(frmlogin_dept.iddep)
        DGVCLOTH.PrimaryGrid.DataSource = dt

    End Sub
    Private Sub frmclothdept_send_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class