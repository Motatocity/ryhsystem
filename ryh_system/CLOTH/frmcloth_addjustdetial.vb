Public Class frmcloth_addjustdetial
    Dim cloth As CLOTHCLASS = New CLOTHCLASS
    Public Sub New(ByVal dept As Integer, ByRef IDMAS As Integer)



        ' This call is required by the designer.
        InitializeComponent()

        DGVCLOTHDT.PrimaryGrid.DataSource = cloth.SEARCHSTOCKDTBYDEF(dept, IDMAS)

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmcloth_addjustdetial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



End Class