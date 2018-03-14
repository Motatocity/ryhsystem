<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DataSet11 = New ryh_system.DataSet1()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfilename1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpathfile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidfildetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ryh_system.WaitForm1), True, True)
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchControl1
        '
        Me.SearchControl1.Client = Me.GridControl1
        Me.SearchControl1.Location = New System.Drawing.Point(657, 12)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.SearchControl1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SearchControl1.Properties.Appearance.Options.UseBackColor = True
        Me.SearchControl1.Properties.Appearance.Options.UseForeColor = True
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Properties.Client = Me.GridControl1
        Me.SearchControl1.Size = New System.Drawing.Size(353, 20)
        Me.SearchControl1.TabIndex = 30
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = "FILEFTP"
        Me.GridControl1.DataSource = Me.DataSet11
        Me.GridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.GridControl1.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.GridControl1.Location = New System.Drawing.Point(3, 36)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1007, 479)
        Me.GridControl1.TabIndex = 29
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colname, Me.colfilename1, Me.colpathfile, Me.colidfildetail, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colname
        '
        Me.colname.Caption = "หัวข้อ"
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.OptionsColumn.AllowEdit = False
        Me.colname.OptionsColumn.AllowFocus = False
        Me.colname.OptionsColumn.ReadOnly = True
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        Me.colname.Width = 329
        '
        'colfilename1
        '
        Me.colfilename1.Caption = "ชื่อไฟล์"
        Me.colfilename1.FieldName = "filename1"
        Me.colfilename1.Name = "colfilename1"
        Me.colfilename1.OptionsColumn.AllowEdit = False
        Me.colfilename1.OptionsColumn.AllowFocus = False
        Me.colfilename1.OptionsColumn.ReadOnly = True
        Me.colfilename1.Visible = True
        Me.colfilename1.VisibleIndex = 1
        Me.colfilename1.Width = 511
        '
        'colpathfile
        '
        Me.colpathfile.FieldName = "pathfile"
        Me.colpathfile.Name = "colpathfile"
        Me.colpathfile.OptionsColumn.AllowEdit = False
        Me.colpathfile.OptionsColumn.AllowFocus = False
        Me.colpathfile.OptionsColumn.ReadOnly = True
        '
        'colidfildetail
        '
        Me.colidfildetail.FieldName = "idfildetail"
        Me.colidfildetail.Name = "colidfildetail"
        Me.colidfildetail.OptionsColumn.AllowEdit = False
        Me.colidfildetail.OptionsColumn.AllowFocus = False
        Me.colidfildetail.OptionsColumn.ReadOnly = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "View File"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 149
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Up)})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 600)
        Me.Controls.Add(Me.SearchControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form3"
        Me.Text = "MetroForm"
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfilename1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpathfile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidfildetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents DataSet11 As ryh_system.DataSet1
    Private WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
