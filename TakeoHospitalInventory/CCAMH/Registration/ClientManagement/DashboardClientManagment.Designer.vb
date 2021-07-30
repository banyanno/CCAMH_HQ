<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardClientManagment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardClientManagment))
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.TabClientManagement = New Janus.Windows.UI.Tab.UITab()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.BtnExportFile = New System.Windows.Forms.Button()
        Me.GridClientNewV1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RowNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_MG_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DATE_CREATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_DATE_REG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_OLD_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_NAME_KHM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_SEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_AGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_ADDRESS_PHONE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MAIN_THERAPY_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAGNOSIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IMPRESSION_DIAGNOSIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_ADVISED_ASSESSMENT_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_ADVISED_ASSESSMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_PSYCHIATRIC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CLIENT_NEUROLOGICAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CLIENT_PSYCHOLOGICAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CLIENT_DDISORDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.DIAGNOSIS_CATEGORY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IS_CLIENT_NEWOLD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FULL_ADDRESS_KH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAGNOSIS_CATE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAGNOSIS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MAIN_THERAPY_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PROV_EN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIST_EN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VILL_EN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COMM_EN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PROV_KH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIST_KH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COMM_KH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VILL_KH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolStripNewClient = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnClientRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnGenerateAudit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUpdateAssessment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDiagnosis = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintNewCaseConferenceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintListCaseConferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnViewClientDetail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnAddNewReferTo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNextAppointment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnChangeTherapy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtNewClientOldNo = New System.Windows.Forms.TextBox()
        Me.RadNewClientOldNo = New System.Windows.Forms.RadioButton()
        Me.RadVeiwDetailAssesment = New System.Windows.Forms.RadioButton()
        Me.RadAssStatus = New System.Windows.Forms.RadioButton()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.CboAdviseAssessment = New System.Windows.Forms.ComboBox()
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnnFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNewClientTel = New System.Windows.Forms.TextBox()
        Me.TxtNewClientName = New System.Windows.Forms.TextBox()
        Me.TxtNewClientNo = New System.Windows.Forms.TextBox()
        Me.RadClientTel = New System.Windows.Forms.RadioButton()
        Me.RadClientName = New System.Windows.Forms.RadioButton()
        Me.RadClientNo = New System.Windows.Forms.RadioButton()
        Me.RadAllClient = New System.Windows.Forms.RadioButton()
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab()
        Me.FamilyDetails = New Janus.Windows.UI.Tab.UITabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblNewRegisterTotal = New System.Windows.Forms.Label()
        Me.lblNewRegisterF = New System.Windows.Forms.Label()
        Me.lblNewRegisterM = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GgDiagnosos = New System.Windows.Forms.GroupBox()
        Me.LblTotalDiagnosisNewClient = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblImmeDoneAass = New System.Windows.Forms.Label()
        Me.LblImmeDonotAsses = New System.Windows.Forms.Label()
        Me.LblImmeTotal = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblMediumDoneAsses = New System.Windows.Forms.Label()
        Me.LblMediumDoNotAsses = New System.Windows.Forms.Label()
        Me.LblMediumTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblLaterTotalDoneAssesst = New System.Windows.Forms.Label()
        Me.LblLaterDoNotAss = New System.Windows.Forms.Label()
        Me.LblLaterTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblNormalTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.GridClientFollowupV1 = New DevExpress.XtraGrid.GridControl()
        Me.GridViewFollowup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RowNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IS_MONINTORING = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CLIENT_MG_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DATE_CREATE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_DATE_REG1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUMBER_VISIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_NO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_OLD_NO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_NAME_KHM1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_SEX1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_AGE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_ADDRESS_PHONE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MAIN_THERAPY_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAGNOSIS1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IMPRESSION_DIAGNOSIS1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_ADVISED_ASSESSMENT_DATE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_ADVISED_ASSESSMENT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_PSYCHIATRIC1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CLIENT_NEUROLOGICAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CLIENT_PSYCHOLOGICAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CLIENT_DDISORDER1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.DIAGNOSIS_CATEGORY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IS_CLIENT_NEWOLD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FULL_ADDRESS_KH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAGNOSIS_CATE_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAGNOSIS_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MAIN_THERAPY_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PROV_EN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIST_EN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VILL_EN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COMM_EN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PROV_KH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIST_KH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COMM_KH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VILL_KH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.THERAPY_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolStripClientFollowUp = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEnterDiagnosisFollowup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnViewClientFollowupDetail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNextAppointFollowup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCaseMonitoring = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnChangeTherapy2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnStopVisit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnReferalToOldClient = New System.Windows.Forms.ToolStripButton()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtFollowUpOldClientNo = New System.Windows.Forms.TextBox()
        Me.RadFollowUpOldClientNo = New System.Windows.Forms.RadioButton()
        Me.DateFollowTo = New System.Windows.Forms.DateTimePicker()
        Me.DateFollowFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnFindFollowClient = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtFollowClientTel = New System.Windows.Forms.TextBox()
        Me.TxtFollowName = New System.Windows.Forms.TextBox()
        Me.TxtFollowClientNo = New System.Windows.Forms.TextBox()
        Me.RadFollowTel = New System.Windows.Forms.RadioButton()
        Me.RadFollowClientName = New System.Windows.Forms.RadioButton()
        Me.RadFollowClientNo = New System.Windows.Forms.RadioButton()
        Me.RadFollowUpAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.LblTotalNotMonitoring = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblTotalNotFillDiagnosisFollowup = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblFollowUpTotal = New System.Windows.Forms.Label()
        Me.lblFollowUpF = New System.Windows.Forms.Label()
        Me.lblFollowUpM = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabClientManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabClientManagement.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.GridClientNewV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripNewClient.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.FamilyDetails.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GgDiagnosos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.GridClientFollowupV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewFollowup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripClientFollowUp.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CLIENT_ADVICED_ASSESSMENT_DETAIL
        '
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL.Caption = "Detailed"
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL.FieldName = "CLIENT_ADVICED_ASSESSMENT_DETAIL"
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL.Name = "CLIENT_ADVICED_ASSESSMENT_DETAIL"
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL.Visible = True
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL.VisibleIndex = 13
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'CLIENT_ADVICED_ASSESSMENT_DETAIL1
        '
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1.Caption = "Detailed"
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1.ColumnEdit = Me.RepositoryItemCheckEdit6
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1.FieldName = "CLIENT_ADVICED_ASSESSMENT_DETAIL"
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1.Name = "CLIENT_ADVICED_ASSESSMENT_DETAIL1"
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1.Visible = True
        Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1.VisibleIndex = 16
        '
        'RepositoryItemCheckEdit6
        '
        Me.RepositoryItemCheckEdit6.AutoHeight = False
        Me.RepositoryItemCheckEdit6.Name = "RepositoryItemCheckEdit6"
        '
        'TabClientManagement
        '
        Me.TabClientManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabClientManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabClientManagement.ImageSize = New System.Drawing.Size(30, 30)
        Me.TabClientManagement.Location = New System.Drawing.Point(0, 0)
        Me.TabClientManagement.Name = "TabClientManagement"
        Me.TabClientManagement.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Black
        Me.TabClientManagement.OfficeCustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabClientManagement.Size = New System.Drawing.Size(1960, 701)
        Me.TabClientManagement.TabIndex = 0
        Me.TabClientManagement.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2})
        Me.TabClientManagement.TabsStateStyles.FormatStyle.ForeColor = System.Drawing.Color.Maroon
        Me.TabClientManagement.UseThemes = False
        Me.TabClientManagement.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.SplitContainer3)
        Me.UiTabPage1.Image = CType(resources.GetObject("UiTabPage1.Image"), System.Drawing.Image)
        Me.UiTabPage1.Key = "Client New"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 37)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(1958, 663)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "New Client       "
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.UiTab1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1958, 663)
        Me.SplitContainer3.SplitterDistance = 511
        Me.SplitContainer3.TabIndex = 4
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.BtnExportFile)
        Me.SplitContainer4.Panel1.Controls.Add(Me.GridClientNewV1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.ToolStripNewClient)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.UiGroupBox1)
        Me.SplitContainer4.Size = New System.Drawing.Size(1958, 511)
        Me.SplitContainer4.SplitterDistance = 1709
        Me.SplitContainer4.TabIndex = 5
        '
        'BtnExportFile
        '
        Me.BtnExportFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExportFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExportFile.Location = New System.Drawing.Point(360, 58)
        Me.BtnExportFile.Name = "BtnExportFile"
        Me.BtnExportFile.Size = New System.Drawing.Size(196, 33)
        Me.BtnExportFile.TabIndex = 24
        Me.BtnExportFile.Text = "Export File"
        Me.BtnExportFile.UseVisualStyleBackColor = True
        '
        'GridClientNewV1
        '
        Me.GridClientNewV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientNewV1.Location = New System.Drawing.Point(0, 58)
        Me.GridClientNewV1.MainView = Me.GridView1
        Me.GridClientNewV1.Name = "GridClientNewV1"
        Me.GridClientNewV1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4, Me.RepositoryItemCheckEdit5})
        Me.GridClientNewV1.Size = New System.Drawing.Size(1707, 451)
        Me.GridClientNewV1.TabIndex = 5
        Me.GridClientNewV1.UseEmbeddedNavigator = True
        Me.GridClientNewV1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.GridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.FocusedRow.Options.UseTextOptions = True
        Me.GridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.RowNo, Me.CLIENT_MG_ID, Me.DATE_CREATE, Me.CLIENT_DATE_REG, Me.CLIENT_NO, Me.CLIENT_OLD_NO, Me.CLIENT_NAME_KHM, Me.CLIENT_NAME, Me.CLIENT_SEX, Me.CLIENT_AGE, Me.CLIENT_ADDRESS_PHONE, Me.MAIN_THERAPY_NAME, Me.DIAGNOSIS, Me.IMPRESSION_DIAGNOSIS, Me.CLIENT_ADVICED_ASSESSMENT_DETAIL, Me.CLIENT_ADVISED_ASSESSMENT_DATE, Me.CLIENT_ADVISED_ASSESSMENT, Me.CLIENT_ADVICED_ASSESSMENT_NOTE, Me.CLIENT_PSYCHIATRIC, Me.CLIENT_NEUROLOGICAL, Me.CLIENT_PSYCHOLOGICAL, Me.CLIENT_DDISORDER, Me.DIAGNOSIS_CATEGORY, Me.IS_CLIENT_NEWOLD, Me.FULL_ADDRESS_KH, Me.DIAGNOSIS_CATE_ID, Me.DIAGNOSIS_ID, Me.MAIN_THERAPY_ID, Me.PROV_EN, Me.DIST_EN, Me.VILL_EN, Me.COMM_EN, Me.PROV_KH, Me.DIST_KH, Me.COMM_KH, Me.VILL_KH})
        GridFormatRule1.Column = Me.CLIENT_ADVICED_ASSESSMENT_DETAIL
        GridFormatRule1.Name = "IsDetail"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.GridClientNewV1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.RowHeight = 35
        '
        'RowNo
        '
        Me.RowNo.AppearanceCell.Options.UseTextOptions = True
        Me.RowNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RowNo.Caption = "No"
        Me.RowNo.FieldName = "RowNo"
        Me.RowNo.Name = "RowNo"
        Me.RowNo.OptionsColumn.AllowEdit = False
        Me.RowNo.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.RowNo.Visible = True
        Me.RowNo.VisibleIndex = 0
        Me.RowNo.Width = 59
        '
        'CLIENT_MG_ID
        '
        Me.CLIENT_MG_ID.Caption = "CLIENT_MG_ID"
        Me.CLIENT_MG_ID.FieldName = "CLIENT_MG_ID"
        Me.CLIENT_MG_ID.Name = "CLIENT_MG_ID"
        '
        'DATE_CREATE
        '
        Me.DATE_CREATE.Caption = "Create Date"
        Me.DATE_CREATE.FieldName = "DATE_CREATE"
        Me.DATE_CREATE.Name = "DATE_CREATE"
        Me.DATE_CREATE.OptionsColumn.AllowEdit = False
        Me.DATE_CREATE.Visible = True
        Me.DATE_CREATE.VisibleIndex = 1
        Me.DATE_CREATE.Width = 133
        '
        'CLIENT_DATE_REG
        '
        Me.CLIENT_DATE_REG.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_DATE_REG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIENT_DATE_REG.Caption = "Date Register"
        Me.CLIENT_DATE_REG.FieldName = "CLIENT_DATE_REG"
        Me.CLIENT_DATE_REG.Name = "CLIENT_DATE_REG"
        Me.CLIENT_DATE_REG.OptionsColumn.AllowEdit = False
        Me.CLIENT_DATE_REG.Visible = True
        Me.CLIENT_DATE_REG.VisibleIndex = 2
        Me.CLIENT_DATE_REG.Width = 155
        '
        'CLIENT_NO
        '
        Me.CLIENT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_NO.Caption = "Client No"
        Me.CLIENT_NO.FieldName = "CLIENT_NO"
        Me.CLIENT_NO.Name = "CLIENT_NO"
        Me.CLIENT_NO.OptionsColumn.AllowEdit = False
        Me.CLIENT_NO.Visible = True
        Me.CLIENT_NO.VisibleIndex = 3
        Me.CLIENT_NO.Width = 135
        '
        'CLIENT_OLD_NO
        '
        Me.CLIENT_OLD_NO.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_OLD_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_OLD_NO.Caption = "Client Old No"
        Me.CLIENT_OLD_NO.FieldName = "CLIENT_OLD_NO"
        Me.CLIENT_OLD_NO.Name = "CLIENT_OLD_NO"
        Me.CLIENT_OLD_NO.OptionsColumn.AllowEdit = False
        Me.CLIENT_OLD_NO.Visible = True
        Me.CLIENT_OLD_NO.VisibleIndex = 4
        Me.CLIENT_OLD_NO.Width = 103
        '
        'CLIENT_NAME_KHM
        '
        Me.CLIENT_NAME_KHM.AppearanceCell.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENT_NAME_KHM.AppearanceCell.Options.UseFont = True
        Me.CLIENT_NAME_KHM.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_NAME_KHM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_NAME_KHM.Caption = "Name KH"
        Me.CLIENT_NAME_KHM.FieldName = "CLIENT_NAME_KHM"
        Me.CLIENT_NAME_KHM.Name = "CLIENT_NAME_KHM"
        Me.CLIENT_NAME_KHM.OptionsColumn.AllowEdit = False
        Me.CLIENT_NAME_KHM.Visible = True
        Me.CLIENT_NAME_KHM.VisibleIndex = 5
        Me.CLIENT_NAME_KHM.Width = 165
        '
        'CLIENT_NAME
        '
        Me.CLIENT_NAME.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_NAME.Caption = "Name Eng"
        Me.CLIENT_NAME.FieldName = "CLIENT_NAME"
        Me.CLIENT_NAME.Name = "CLIENT_NAME"
        Me.CLIENT_NAME.OptionsColumn.AllowEdit = False
        Me.CLIENT_NAME.Visible = True
        Me.CLIENT_NAME.VisibleIndex = 6
        Me.CLIENT_NAME.Width = 149
        '
        'CLIENT_SEX
        '
        Me.CLIENT_SEX.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_SEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIENT_SEX.Caption = "Sex"
        Me.CLIENT_SEX.FieldName = "CLIENT_SEX"
        Me.CLIENT_SEX.Name = "CLIENT_SEX"
        Me.CLIENT_SEX.OptionsColumn.AllowEdit = False
        Me.CLIENT_SEX.Visible = True
        Me.CLIENT_SEX.VisibleIndex = 7
        '
        'CLIENT_AGE
        '
        Me.CLIENT_AGE.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_AGE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIENT_AGE.Caption = "Age"
        Me.CLIENT_AGE.FieldName = "CLIENT_AGE"
        Me.CLIENT_AGE.Name = "CLIENT_AGE"
        Me.CLIENT_AGE.OptionsColumn.AllowEdit = False
        Me.CLIENT_AGE.Visible = True
        Me.CLIENT_AGE.VisibleIndex = 8
        '
        'CLIENT_ADDRESS_PHONE
        '
        Me.CLIENT_ADDRESS_PHONE.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_ADDRESS_PHONE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_ADDRESS_PHONE.Caption = "Tel"
        Me.CLIENT_ADDRESS_PHONE.FieldName = "CLIENT_ADDRESS_PHONE"
        Me.CLIENT_ADDRESS_PHONE.Name = "CLIENT_ADDRESS_PHONE"
        Me.CLIENT_ADDRESS_PHONE.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADDRESS_PHONE.Visible = True
        Me.CLIENT_ADDRESS_PHONE.VisibleIndex = 9
        Me.CLIENT_ADDRESS_PHONE.Width = 140
        '
        'MAIN_THERAPY_NAME
        '
        Me.MAIN_THERAPY_NAME.AppearanceCell.Options.UseTextOptions = True
        Me.MAIN_THERAPY_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.MAIN_THERAPY_NAME.Caption = "Main Therapy"
        Me.MAIN_THERAPY_NAME.FieldName = "MAIN_THERAPY_NAME"
        Me.MAIN_THERAPY_NAME.Name = "MAIN_THERAPY_NAME"
        Me.MAIN_THERAPY_NAME.OptionsColumn.AllowEdit = False
        Me.MAIN_THERAPY_NAME.Visible = True
        Me.MAIN_THERAPY_NAME.VisibleIndex = 10
        Me.MAIN_THERAPY_NAME.Width = 141
        '
        'DIAGNOSIS
        '
        Me.DIAGNOSIS.AppearanceCell.Options.UseTextOptions = True
        Me.DIAGNOSIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DIAGNOSIS.Caption = "Diagnosis"
        Me.DIAGNOSIS.FieldName = "DIAGNOSIS"
        Me.DIAGNOSIS.Name = "DIAGNOSIS"
        Me.DIAGNOSIS.OptionsColumn.AllowEdit = False
        Me.DIAGNOSIS.Visible = True
        Me.DIAGNOSIS.VisibleIndex = 11
        Me.DIAGNOSIS.Width = 159
        '
        'IMPRESSION_DIAGNOSIS
        '
        Me.IMPRESSION_DIAGNOSIS.AppearanceCell.Options.UseTextOptions = True
        Me.IMPRESSION_DIAGNOSIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.IMPRESSION_DIAGNOSIS.Caption = "Impression"
        Me.IMPRESSION_DIAGNOSIS.FieldName = "IMPRESSION_DIAGNOSIS"
        Me.IMPRESSION_DIAGNOSIS.Name = "IMPRESSION_DIAGNOSIS"
        Me.IMPRESSION_DIAGNOSIS.OptionsColumn.AllowEdit = False
        Me.IMPRESSION_DIAGNOSIS.Visible = True
        Me.IMPRESSION_DIAGNOSIS.VisibleIndex = 12
        Me.IMPRESSION_DIAGNOSIS.Width = 210
        '
        'CLIENT_ADVISED_ASSESSMENT_DATE
        '
        Me.CLIENT_ADVISED_ASSESSMENT_DATE.Caption = "Ass-Date"
        Me.CLIENT_ADVISED_ASSESSMENT_DATE.FieldName = "CLIENT_ADVISED_ASSESSMENT_DATE"
        Me.CLIENT_ADVISED_ASSESSMENT_DATE.Name = "CLIENT_ADVISED_ASSESSMENT_DATE"
        Me.CLIENT_ADVISED_ASSESSMENT_DATE.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADVISED_ASSESSMENT_DATE.Visible = True
        Me.CLIENT_ADVISED_ASSESSMENT_DATE.VisibleIndex = 14
        Me.CLIENT_ADVISED_ASSESSMENT_DATE.Width = 95
        '
        'CLIENT_ADVISED_ASSESSMENT
        '
        Me.CLIENT_ADVISED_ASSESSMENT.Caption = "Ass-Status"
        Me.CLIENT_ADVISED_ASSESSMENT.FieldName = "CLIENT_ADVISED_ASSESSMENT"
        Me.CLIENT_ADVISED_ASSESSMENT.Name = "CLIENT_ADVISED_ASSESSMENT"
        Me.CLIENT_ADVISED_ASSESSMENT.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADVISED_ASSESSMENT.Visible = True
        Me.CLIENT_ADVISED_ASSESSMENT.VisibleIndex = 15
        Me.CLIENT_ADVISED_ASSESSMENT.Width = 109
        '
        'CLIENT_ADVICED_ASSESSMENT_NOTE
        '
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE.Caption = "Ass-Note"
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE.FieldName = "CLIENT_ADVICED_ASSESSMENT_NOTE"
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE.Name = "CLIENT_ADVICED_ASSESSMENT_NOTE"
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE.Visible = True
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE.VisibleIndex = 16
        '
        'CLIENT_PSYCHIATRIC
        '
        Me.CLIENT_PSYCHIATRIC.Caption = "Psychiatric"
        Me.CLIENT_PSYCHIATRIC.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.CLIENT_PSYCHIATRIC.FieldName = "CLIENT_PSYCHIATRIC"
        Me.CLIENT_PSYCHIATRIC.Name = "CLIENT_PSYCHIATRIC"
        Me.CLIENT_PSYCHIATRIC.OptionsColumn.AllowEdit = False
        Me.CLIENT_PSYCHIATRIC.Visible = True
        Me.CLIENT_PSYCHIATRIC.VisibleIndex = 17
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'CLIENT_NEUROLOGICAL
        '
        Me.CLIENT_NEUROLOGICAL.Caption = "NEUROLOGICAL"
        Me.CLIENT_NEUROLOGICAL.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.CLIENT_NEUROLOGICAL.FieldName = "CLIENT_NEUROLOGICAL"
        Me.CLIENT_NEUROLOGICAL.Name = "CLIENT_NEUROLOGICAL"
        Me.CLIENT_NEUROLOGICAL.OptionsColumn.AllowEdit = False
        Me.CLIENT_NEUROLOGICAL.Visible = True
        Me.CLIENT_NEUROLOGICAL.VisibleIndex = 18
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'CLIENT_PSYCHOLOGICAL
        '
        Me.CLIENT_PSYCHOLOGICAL.Caption = "PSYCHOLOGICAL"
        Me.CLIENT_PSYCHOLOGICAL.ColumnEdit = Me.RepositoryItemCheckEdit5
        Me.CLIENT_PSYCHOLOGICAL.FieldName = "CLIENT_PSYCHOLOGICAL"
        Me.CLIENT_PSYCHOLOGICAL.Name = "CLIENT_PSYCHOLOGICAL"
        Me.CLIENT_PSYCHOLOGICAL.OptionsColumn.AllowEdit = False
        Me.CLIENT_PSYCHOLOGICAL.Visible = True
        Me.CLIENT_PSYCHOLOGICAL.VisibleIndex = 19
        '
        'RepositoryItemCheckEdit5
        '
        Me.RepositoryItemCheckEdit5.AutoHeight = False
        Me.RepositoryItemCheckEdit5.Name = "RepositoryItemCheckEdit5"
        '
        'CLIENT_DDISORDER
        '
        Me.CLIENT_DDISORDER.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_DDISORDER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIENT_DDISORDER.Caption = "DDISORDER"
        Me.CLIENT_DDISORDER.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.CLIENT_DDISORDER.FieldName = "CLIENT_DDISORDER"
        Me.CLIENT_DDISORDER.Name = "CLIENT_DDISORDER"
        Me.CLIENT_DDISORDER.OptionsColumn.AllowEdit = False
        Me.CLIENT_DDISORDER.Visible = True
        Me.CLIENT_DDISORDER.VisibleIndex = 20
        Me.CLIENT_DDISORDER.Width = 100
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'DIAGNOSIS_CATEGORY
        '
        Me.DIAGNOSIS_CATEGORY.Caption = "DIAGNOSIS_CATEGORY"
        Me.DIAGNOSIS_CATEGORY.FieldName = "DIAGNOSIS_CATEGORY"
        Me.DIAGNOSIS_CATEGORY.Name = "DIAGNOSIS_CATEGORY"
        '
        'IS_CLIENT_NEWOLD
        '
        Me.IS_CLIENT_NEWOLD.Caption = "IS_CLIENT_NEWOLD"
        Me.IS_CLIENT_NEWOLD.FieldName = "IS_CLIENT_NEWOLD"
        Me.IS_CLIENT_NEWOLD.Name = "IS_CLIENT_NEWOLD"
        Me.IS_CLIENT_NEWOLD.Width = 140
        '
        'FULL_ADDRESS_KH
        '
        Me.FULL_ADDRESS_KH.AppearanceCell.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FULL_ADDRESS_KH.AppearanceCell.Options.UseFont = True
        Me.FULL_ADDRESS_KH.Caption = "Address"
        Me.FULL_ADDRESS_KH.FieldName = "FULL_ADDRESS_KH"
        Me.FULL_ADDRESS_KH.Name = "FULL_ADDRESS_KH"
        Me.FULL_ADDRESS_KH.OptionsColumn.AllowEdit = False
        Me.FULL_ADDRESS_KH.Visible = True
        Me.FULL_ADDRESS_KH.VisibleIndex = 21
        Me.FULL_ADDRESS_KH.Width = 391
        '
        'DIAGNOSIS_CATE_ID
        '
        Me.DIAGNOSIS_CATE_ID.Caption = "DIAGNOSIS_CATE_ID"
        Me.DIAGNOSIS_CATE_ID.FieldName = "DIAGNOSIS_CATE_ID"
        Me.DIAGNOSIS_CATE_ID.Name = "DIAGNOSIS_CATE_ID"
        '
        'DIAGNOSIS_ID
        '
        Me.DIAGNOSIS_ID.Caption = "DIAGNOSIS_ID"
        Me.DIAGNOSIS_ID.FieldName = "DIAGNOSIS_ID"
        Me.DIAGNOSIS_ID.Name = "DIAGNOSIS_ID"
        Me.DIAGNOSIS_ID.Width = 150
        '
        'MAIN_THERAPY_ID
        '
        Me.MAIN_THERAPY_ID.Caption = "MAIN_THERAPY_ID"
        Me.MAIN_THERAPY_ID.FieldName = "MAIN_THERAPY_ID"
        Me.MAIN_THERAPY_ID.Name = "MAIN_THERAPY_ID"
        '
        'PROV_EN
        '
        Me.PROV_EN.Caption = "Province"
        Me.PROV_EN.FieldName = "PROV_EN"
        Me.PROV_EN.Name = "PROV_EN"
        Me.PROV_EN.OptionsColumn.AllowEdit = False
        Me.PROV_EN.Visible = True
        Me.PROV_EN.VisibleIndex = 22
        '
        'DIST_EN
        '
        Me.DIST_EN.Caption = "DIST_EN"
        Me.DIST_EN.FieldName = "DIST_EN"
        Me.DIST_EN.Name = "DIST_EN"
        Me.DIST_EN.OptionsColumn.AllowEdit = False
        Me.DIST_EN.Visible = True
        Me.DIST_EN.VisibleIndex = 23
        '
        'VILL_EN
        '
        Me.VILL_EN.Caption = "VILL_EN"
        Me.VILL_EN.FieldName = "VILL_EN"
        Me.VILL_EN.Name = "VILL_EN"
        Me.VILL_EN.OptionsColumn.AllowEdit = False
        Me.VILL_EN.Visible = True
        Me.VILL_EN.VisibleIndex = 24
        '
        'COMM_EN
        '
        Me.COMM_EN.Caption = "COMM_EN"
        Me.COMM_EN.FieldName = "COMM_EN"
        Me.COMM_EN.Name = "COMM_EN"
        Me.COMM_EN.OptionsColumn.AllowEdit = False
        Me.COMM_EN.Visible = True
        Me.COMM_EN.VisibleIndex = 25
        '
        'PROV_KH
        '
        Me.PROV_KH.Caption = "PROV_KH"
        Me.PROV_KH.FieldName = "PROV_KH"
        Me.PROV_KH.Name = "PROV_KH"
        Me.PROV_KH.OptionsColumn.AllowEdit = False
        Me.PROV_KH.Visible = True
        Me.PROV_KH.VisibleIndex = 26
        '
        'DIST_KH
        '
        Me.DIST_KH.Caption = "DIST_KH"
        Me.DIST_KH.FieldName = "DIST_KH"
        Me.DIST_KH.Name = "DIST_KH"
        Me.DIST_KH.OptionsColumn.AllowEdit = False
        Me.DIST_KH.Visible = True
        Me.DIST_KH.VisibleIndex = 27
        '
        'COMM_KH
        '
        Me.COMM_KH.Caption = "COMM_KH"
        Me.COMM_KH.FieldName = "COMM_KH"
        Me.COMM_KH.Name = "COMM_KH"
        Me.COMM_KH.OptionsColumn.AllowEdit = False
        Me.COMM_KH.Visible = True
        Me.COMM_KH.VisibleIndex = 28
        '
        'VILL_KH
        '
        Me.VILL_KH.Caption = "VILL_KH"
        Me.VILL_KH.FieldName = "VILL_KH"
        Me.VILL_KH.Name = "VILL_KH"
        Me.VILL_KH.OptionsColumn.AllowEdit = False
        Me.VILL_KH.Visible = True
        Me.VILL_KH.VisibleIndex = 29
        '
        'ToolStripNewClient
        '
        Me.ToolStripNewClient.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripNewClient.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripNewClient.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStripNewClient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BtnClientRefresh, Me.ToolStripSeparator3, Me.BtnGenerateAudit, Me.ToolStripSeparator12, Me.BtnUpdateAssessment, Me.ToolStripSeparator2, Me.BtnDiagnosis, Me.ToolStripSeparator9, Me.ToolStripSplitButton1, Me.ToolStripSeparator10, Me.BtnViewClientDetail, Me.ToolStripSeparator6, Me.BtnAddNewReferTo, Me.ToolStripSeparator4, Me.BtnNextAppointment, Me.ToolStripSeparator13, Me.BtnChangeTherapy, Me.ToolStripSeparator16})
        Me.ToolStripNewClient.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripNewClient.Name = "ToolStripNewClient"
        Me.ToolStripNewClient.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripNewClient.Size = New System.Drawing.Size(1707, 58)
        Me.ToolStripNewClient.TabIndex = 4
        Me.ToolStripNewClient.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'BtnClientRefresh
        '
        Me.BtnClientRefresh.ForeColor = System.Drawing.Color.Maroon
        Me.BtnClientRefresh.Image = CType(resources.GetObject("BtnClientRefresh.Image"), System.Drawing.Image)
        Me.BtnClientRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClientRefresh.Name = "BtnClientRefresh"
        Me.BtnClientRefresh.Size = New System.Drawing.Size(127, 55)
        Me.BtnClientRefresh.Text = "        Refresh       "
        Me.BtnClientRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 58)
        '
        'BtnGenerateAudit
        '
        Me.BtnGenerateAudit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnGenerateAudit.Image = CType(resources.GetObject("BtnGenerateAudit.Image"), System.Drawing.Image)
        Me.BtnGenerateAudit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGenerateAudit.Name = "BtnGenerateAudit"
        Me.BtnGenerateAudit.Size = New System.Drawing.Size(172, 55)
        Me.BtnGenerateAudit.Text = "Generate Clinical Audit"
        Me.BtnGenerateAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 58)
        '
        'BtnUpdateAssessment
        '
        Me.BtnUpdateAssessment.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUpdateAssessment.Image = CType(resources.GetObject("BtnUpdateAssessment.Image"), System.Drawing.Image)
        Me.BtnUpdateAssessment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateAssessment.Name = "BtnUpdateAssessment"
        Me.BtnUpdateAssessment.Size = New System.Drawing.Size(150, 55)
        Me.BtnUpdateAssessment.Text = "Update Assessment"
        Me.BtnUpdateAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'BtnDiagnosis
        '
        Me.BtnDiagnosis.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDiagnosis.Image = CType(resources.GetObject("BtnDiagnosis.Image"), System.Drawing.Image)
        Me.BtnDiagnosis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDiagnosis.Name = "BtnDiagnosis"
        Me.BtnDiagnosis.Size = New System.Drawing.Size(281, 55)
        Me.BtnDiagnosis.Text = "Enter Diagnosis and Next appointment"
        Me.BtnDiagnosis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 25
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.PrintNewCaseConferenceFormToolStripMenuItem, Me.ToolStripMenuItem5, Me.PrintListCaseConferenceToolStripMenuItem, Me.ToolStripMenuItem7})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(155, 55)
        Me.ToolStripSplitButton1.Text = "    Print reports   "
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(304, 6)
        '
        'PrintNewCaseConferenceFormToolStripMenuItem
        '
        Me.PrintNewCaseConferenceFormToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.PrintNewCaseConferenceFormToolStripMenuItem.Name = "PrintNewCaseConferenceFormToolStripMenuItem"
        Me.PrintNewCaseConferenceFormToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.PrintNewCaseConferenceFormToolStripMenuItem.Text = "Print New Case Conference form"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(304, 6)
        '
        'PrintListCaseConferenceToolStripMenuItem
        '
        Me.PrintListCaseConferenceToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.PrintListCaseConferenceToolStripMenuItem.Name = "PrintListCaseConferenceToolStripMenuItem"
        Me.PrintListCaseConferenceToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.PrintListCaseConferenceToolStripMenuItem.Text = "Print list case conference"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(304, 6)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 58)
        '
        'BtnViewClientDetail
        '
        Me.BtnViewClientDetail.ForeColor = System.Drawing.Color.Maroon
        Me.BtnViewClientDetail.Image = CType(resources.GetObject("BtnViewClientDetail.Image"), System.Drawing.Image)
        Me.BtnViewClientDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewClientDetail.Name = "BtnViewClientDetail"
        Me.BtnViewClientDetail.Size = New System.Drawing.Size(136, 55)
        Me.BtnViewClientDetail.Text = "  View client info  "
        Me.BtnViewClientDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 58)
        '
        'BtnAddNewReferTo
        '
        Me.BtnAddNewReferTo.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAddNewReferTo.Image = CType(resources.GetObject("BtnAddNewReferTo.Image"), System.Drawing.Image)
        Me.BtnAddNewReferTo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddNewReferTo.Name = "BtnAddNewReferTo"
        Me.BtnAddNewReferTo.Size = New System.Drawing.Size(112, 55)
        Me.BtnAddNewReferTo.Text = "   Referral To   "
        Me.BtnAddNewReferTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 58)
        Me.ToolStripSeparator4.Visible = False
        '
        'BtnNextAppointment
        '
        Me.BtnNextAppointment.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNextAppointment.Image = CType(resources.GetObject("BtnNextAppointment.Image"), System.Drawing.Image)
        Me.BtnNextAppointment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNextAppointment.Name = "BtnNextAppointment"
        Me.BtnNextAppointment.Size = New System.Drawing.Size(155, 55)
        Me.BtnNextAppointment.Text = "  Next appointment  "
        Me.BtnNextAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnNextAppointment.Visible = False
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 58)
        '
        'BtnChangeTherapy
        '
        Me.BtnChangeTherapy.ForeColor = System.Drawing.Color.Maroon
        Me.BtnChangeTherapy.Image = CType(resources.GetObject("BtnChangeTherapy.Image"), System.Drawing.Image)
        Me.BtnChangeTherapy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnChangeTherapy.Name = "BtnChangeTherapy"
        Me.BtnChangeTherapy.Size = New System.Drawing.Size(127, 55)
        Me.BtnChangeTherapy.Text = "Change Therapy"
        Me.BtnChangeTherapy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 58)
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.TxtNewClientOldNo)
        Me.UiGroupBox1.Controls.Add(Me.RadNewClientOldNo)
        Me.UiGroupBox1.Controls.Add(Me.RadVeiwDetailAssesment)
        Me.UiGroupBox1.Controls.Add(Me.RadAssStatus)
        Me.UiGroupBox1.Controls.Add(Me.DTo)
        Me.UiGroupBox1.Controls.Add(Me.CboAdviseAssessment)
        Me.UiGroupBox1.Controls.Add(Me.DFrom)
        Me.UiGroupBox1.Controls.Add(Me.BtnnFind)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.TxtNewClientTel)
        Me.UiGroupBox1.Controls.Add(Me.TxtNewClientName)
        Me.UiGroupBox1.Controls.Add(Me.TxtNewClientNo)
        Me.UiGroupBox1.Controls.Add(Me.RadClientTel)
        Me.UiGroupBox1.Controls.Add(Me.RadClientName)
        Me.UiGroupBox1.Controls.Add(Me.RadClientNo)
        Me.UiGroupBox1.Controls.Add(Me.RadAllClient)
        Me.UiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiGroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom
        Me.UiGroupBox1.Size = New System.Drawing.Size(243, 509)
        Me.UiGroupBox1.TabIndex = 6
        Me.UiGroupBox1.Text = "Find new client"
        Me.UiGroupBox1.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'TxtNewClientOldNo
        '
        Me.TxtNewClientOldNo.Enabled = False
        Me.TxtNewClientOldNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNewClientOldNo.Location = New System.Drawing.Point(7, 290)
        Me.TxtNewClientOldNo.Name = "TxtNewClientOldNo"
        Me.TxtNewClientOldNo.Size = New System.Drawing.Size(227, 27)
        Me.TxtNewClientOldNo.TabIndex = 18
        '
        'RadNewClientOldNo
        '
        Me.RadNewClientOldNo.AutoSize = True
        Me.RadNewClientOldNo.Location = New System.Drawing.Point(7, 264)
        Me.RadNewClientOldNo.Name = "RadNewClientOldNo"
        Me.RadNewClientOldNo.Size = New System.Drawing.Size(118, 22)
        Me.RadNewClientOldNo.TabIndex = 17
        Me.RadNewClientOldNo.Text = "Client Old No:"
        Me.RadNewClientOldNo.UseVisualStyleBackColor = True
        '
        'RadVeiwDetailAssesment
        '
        Me.RadVeiwDetailAssesment.AutoSize = True
        Me.RadVeiwDetailAssesment.Location = New System.Drawing.Point(7, 114)
        Me.RadVeiwDetailAssesment.Name = "RadVeiwDetailAssesment"
        Me.RadVeiwDetailAssesment.Size = New System.Drawing.Size(172, 22)
        Me.RadVeiwDetailAssesment.TabIndex = 16
        Me.RadVeiwDetailAssesment.Text = "View detail assesment"
        Me.RadVeiwDetailAssesment.UseVisualStyleBackColor = True
        '
        'RadAssStatus
        '
        Me.RadAssStatus.AutoSize = True
        Me.RadAssStatus.Location = New System.Drawing.Point(7, 149)
        Me.RadAssStatus.Name = "RadAssStatus"
        Me.RadAssStatus.Size = New System.Drawing.Size(139, 22)
        Me.RadAssStatus.TabIndex = 15
        Me.RadAssStatus.Text = "Select ass status"
        Me.RadAssStatus.UseVisualStyleBackColor = True
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(133, 51)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(102, 24)
        Me.DTo.TabIndex = 5
        '
        'CboAdviseAssessment
        '
        Me.CboAdviseAssessment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAdviseAssessment.Enabled = False
        Me.CboAdviseAssessment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAdviseAssessment.FormattingEnabled = True
        Me.CboAdviseAssessment.Items.AddRange(New Object() {"", "Immediate", "Medium", "Later", "Free Consultation"})
        Me.CboAdviseAssessment.Location = New System.Drawing.Point(7, 180)
        Me.CboAdviseAssessment.Name = "CboAdviseAssessment"
        Me.CboAdviseAssessment.Size = New System.Drawing.Size(227, 28)
        Me.CboAdviseAssessment.TabIndex = 14
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(7, 51)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(102, 24)
        Me.DFrom.TabIndex = 4
        '
        'BtnnFind
        '
        Me.BtnnFind.BackColor = System.Drawing.Color.Maroon
        Me.BtnnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnnFind.FlatAppearance.BorderSize = 0
        Me.BtnnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnnFind.ForeColor = System.Drawing.Color.White
        Me.BtnnFind.Location = New System.Drawing.Point(6, 434)
        Me.BtnnFind.Name = "BtnnFind"
        Me.BtnnFind.Size = New System.Drawing.Size(228, 42)
        Me.BtnnFind.TabIndex = 8
        Me.BtnnFind.Text = "Find"
        Me.BtnnFind.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date To"
        '
        'TxtNewClientTel
        '
        Me.TxtNewClientTel.Enabled = False
        Me.TxtNewClientTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNewClientTel.Location = New System.Drawing.Point(6, 397)
        Me.TxtNewClientTel.Name = "TxtNewClientTel"
        Me.TxtNewClientTel.Size = New System.Drawing.Size(227, 27)
        Me.TxtNewClientTel.TabIndex = 7
        '
        'TxtNewClientName
        '
        Me.TxtNewClientName.Enabled = False
        Me.TxtNewClientName.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNewClientName.Location = New System.Drawing.Point(6, 341)
        Me.TxtNewClientName.Name = "TxtNewClientName"
        Me.TxtNewClientName.Size = New System.Drawing.Size(227, 32)
        Me.TxtNewClientName.TabIndex = 6
        '
        'TxtNewClientNo
        '
        Me.TxtNewClientNo.Enabled = False
        Me.TxtNewClientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNewClientNo.Location = New System.Drawing.Point(7, 233)
        Me.TxtNewClientNo.Name = "TxtNewClientNo"
        Me.TxtNewClientNo.Size = New System.Drawing.Size(227, 27)
        Me.TxtNewClientNo.TabIndex = 5
        '
        'RadClientTel
        '
        Me.RadClientTel.AutoSize = True
        Me.RadClientTel.Location = New System.Drawing.Point(6, 374)
        Me.RadClientTel.Name = "RadClientTel"
        Me.RadClientTel.Size = New System.Drawing.Size(91, 22)
        Me.RadClientTel.TabIndex = 4
        Me.RadClientTel.Text = "Client Tel:"
        Me.RadClientTel.UseVisualStyleBackColor = True
        '
        'RadClientName
        '
        Me.RadClientName.AutoSize = True
        Me.RadClientName.Location = New System.Drawing.Point(6, 318)
        Me.RadClientName.Name = "RadClientName"
        Me.RadClientName.Size = New System.Drawing.Size(148, 22)
        Me.RadClientName.TabIndex = 3
        Me.RadClientName.Text = "Client Name ENG:"
        Me.RadClientName.UseVisualStyleBackColor = True
        '
        'RadClientNo
        '
        Me.RadClientNo.AutoSize = True
        Me.RadClientNo.Location = New System.Drawing.Point(7, 212)
        Me.RadClientNo.Name = "RadClientNo"
        Me.RadClientNo.Size = New System.Drawing.Size(91, 22)
        Me.RadClientNo.TabIndex = 2
        Me.RadClientNo.Text = "Client No:"
        Me.RadClientNo.UseVisualStyleBackColor = True
        '
        'RadAllClient
        '
        Me.RadAllClient.AutoSize = True
        Me.RadAllClient.Checked = True
        Me.RadAllClient.Location = New System.Drawing.Point(7, 81)
        Me.RadAllClient.Name = "RadAllClient"
        Me.RadAllClient.Size = New System.Drawing.Size(113, 22)
        Me.RadAllClient.TabIndex = 1
        Me.RadAllClient.TabStop = True
        Me.RadAllClient.Text = "View all client"
        Me.RadAllClient.UseVisualStyleBackColor = True
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom
        Me.UiTab1.OfficeCustomColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UiTab1.Size = New System.Drawing.Size(1956, 146)
        Me.UiTab1.TabIndex = 1
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.FamilyDetails})
        Me.UiTab1.UseThemes = False
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'FamilyDetails
        '
        Me.FamilyDetails.AutoScroll = True
        Me.FamilyDetails.Controls.Add(Me.GroupBox5)
        Me.FamilyDetails.Controls.Add(Me.GgDiagnosos)
        Me.FamilyDetails.Controls.Add(Me.GroupBox4)
        Me.FamilyDetails.Controls.Add(Me.GroupBox3)
        Me.FamilyDetails.Controls.Add(Me.GroupBox2)
        Me.FamilyDetails.Controls.Add(Me.GroupBox1)
        Me.FamilyDetails.Key = "FamilyDetails"
        Me.FamilyDetails.Location = New System.Drawing.Point(1, 28)
        Me.FamilyDetails.Name = "FamilyDetails"
        Me.FamilyDetails.Size = New System.Drawing.Size(1954, 117)
        Me.FamilyDetails.TabStop = True
        Me.FamilyDetails.Text = "Assessment summary:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblNewRegisterTotal)
        Me.GroupBox5.Controls.Add(Me.lblNewRegisterF)
        Me.GroupBox5.Controls.Add(Me.lblNewRegisterM)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(1035, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(180, 110)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "New client register"
        '
        'lblNewRegisterTotal
        '
        Me.lblNewRegisterTotal.Location = New System.Drawing.Point(76, 29)
        Me.lblNewRegisterTotal.Name = "lblNewRegisterTotal"
        Me.lblNewRegisterTotal.Size = New System.Drawing.Size(81, 22)
        Me.lblNewRegisterTotal.TabIndex = 7
        Me.lblNewRegisterTotal.Text = "0"
        Me.lblNewRegisterTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNewRegisterF
        '
        Me.lblNewRegisterF.Location = New System.Drawing.Point(76, 80)
        Me.lblNewRegisterF.Name = "lblNewRegisterF"
        Me.lblNewRegisterF.Size = New System.Drawing.Size(81, 22)
        Me.lblNewRegisterF.TabIndex = 6
        Me.lblNewRegisterF.Text = "0"
        Me.lblNewRegisterF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNewRegisterM
        '
        Me.lblNewRegisterM.Location = New System.Drawing.Point(76, 53)
        Me.lblNewRegisterM.Name = "lblNewRegisterM"
        Me.lblNewRegisterM.Size = New System.Drawing.Size(81, 22)
        Me.lblNewRegisterM.TabIndex = 5
        Me.lblNewRegisterM.Text = "0"
        Me.lblNewRegisterM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 22)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "សរុប ចំនួន:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 22)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "ចំនួន ស្រី:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 53)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 22)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "ចំនួន ប្រុស:"
        '
        'GgDiagnosos
        '
        Me.GgDiagnosos.Controls.Add(Me.LblTotalDiagnosisNewClient)
        Me.GgDiagnosos.Controls.Add(Me.Label8)
        Me.GgDiagnosos.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.GgDiagnosos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GgDiagnosos.Location = New System.Drawing.Point(3, 3)
        Me.GgDiagnosos.Name = "GgDiagnosos"
        Me.GgDiagnosos.Size = New System.Drawing.Size(187, 110)
        Me.GgDiagnosos.TabIndex = 4
        Me.GgDiagnosos.TabStop = False
        Me.GgDiagnosos.Text = "Diagnosis មិនទាន់បំពេញ"
        '
        'LblTotalDiagnosisNewClient
        '
        Me.LblTotalDiagnosisNewClient.Location = New System.Drawing.Point(6, 72)
        Me.LblTotalDiagnosisNewClient.Name = "LblTotalDiagnosisNewClient"
        Me.LblTotalDiagnosisNewClient.Size = New System.Drawing.Size(151, 22)
        Me.LblTotalDiagnosisNewClient.TabIndex = 2
        Me.LblTotalDiagnosisNewClient.Text = "0"
        Me.LblTotalDiagnosisNewClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ចំនួនអ្នកមិនបំពេញ Diagnosis:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblImmeDoneAass)
        Me.GroupBox4.Controls.Add(Me.LblImmeDonotAsses)
        Me.GroupBox4.Controls.Add(Me.LblImmeTotal)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(196, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(229, 111)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Immediate:"
        '
        'lblImmeDoneAass
        '
        Me.lblImmeDoneAass.Location = New System.Drawing.Point(159, 73)
        Me.lblImmeDoneAass.Name = "lblImmeDoneAass"
        Me.lblImmeDoneAass.Size = New System.Drawing.Size(62, 29)
        Me.lblImmeDoneAass.TabIndex = 12
        Me.lblImmeDoneAass.Text = "0"
        Me.lblImmeDoneAass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblImmeDonotAsses
        '
        Me.LblImmeDonotAsses.Location = New System.Drawing.Point(159, 46)
        Me.LblImmeDonotAsses.Name = "LblImmeDonotAsses"
        Me.LblImmeDonotAsses.Size = New System.Drawing.Size(62, 29)
        Me.LblImmeDonotAsses.TabIndex = 11
        Me.LblImmeDonotAsses.Text = "0"
        Me.LblImmeDonotAsses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblImmeTotal
        '
        Me.LblImmeTotal.Location = New System.Drawing.Point(159, 22)
        Me.LblImmeTotal.Name = "LblImmeTotal"
        Me.LblImmeTotal.Size = New System.Drawing.Size(62, 29)
        Me.LblImmeTotal.TabIndex = 10
        Me.LblImmeTotal.Text = "0"
        Me.LblImmeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 22)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "ចំនួន មិនទាន់ Assesst"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 22)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "ចំនួន បានធ្វើ Assesst:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 22)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "សរុប ចំនួន:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblMediumDoneAsses)
        Me.GroupBox3.Controls.Add(Me.LblMediumDoNotAsses)
        Me.GroupBox3.Controls.Add(Me.LblMediumTotal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(431, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 110)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Medium"
        '
        'LblMediumDoneAsses
        '
        Me.LblMediumDoneAsses.Location = New System.Drawing.Point(159, 73)
        Me.LblMediumDoneAsses.Name = "LblMediumDoneAsses"
        Me.LblMediumDoneAsses.Size = New System.Drawing.Size(60, 29)
        Me.LblMediumDoneAsses.TabIndex = 12
        Me.LblMediumDoneAsses.Text = "0"
        Me.LblMediumDoneAsses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMediumDoNotAsses
        '
        Me.LblMediumDoNotAsses.Location = New System.Drawing.Point(159, 46)
        Me.LblMediumDoNotAsses.Name = "LblMediumDoNotAsses"
        Me.LblMediumDoNotAsses.Size = New System.Drawing.Size(60, 29)
        Me.LblMediumDoNotAsses.TabIndex = 11
        Me.LblMediumDoNotAsses.Text = "0"
        Me.LblMediumDoNotAsses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMediumTotal
        '
        Me.LblMediumTotal.Location = New System.Drawing.Point(159, 22)
        Me.LblMediumTotal.Name = "LblMediumTotal"
        Me.LblMediumTotal.Size = New System.Drawing.Size(60, 29)
        Me.LblMediumTotal.TabIndex = 10
        Me.LblMediumTotal.Text = "0"
        Me.LblMediumTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 22)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "ចំនួន មិនទាន់ Assesst"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 22)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "ចំនួន បានធ្វើ Assesst:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 22)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "សរុប ចំនួន:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblLaterTotalDoneAssesst)
        Me.GroupBox2.Controls.Add(Me.LblLaterDoNotAss)
        Me.GroupBox2.Controls.Add(Me.LblLaterTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(659, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Later:"
        '
        'LblLaterTotalDoneAssesst
        '
        Me.LblLaterTotalDoneAssesst.Location = New System.Drawing.Point(134, 73)
        Me.LblLaterTotalDoneAssesst.Name = "LblLaterTotalDoneAssesst"
        Me.LblLaterTotalDoneAssesst.Size = New System.Drawing.Size(66, 29)
        Me.LblLaterTotalDoneAssesst.TabIndex = 6
        Me.LblLaterTotalDoneAssesst.Text = "0"
        Me.LblLaterTotalDoneAssesst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblLaterDoNotAss
        '
        Me.LblLaterDoNotAss.Location = New System.Drawing.Point(139, 46)
        Me.LblLaterDoNotAss.Name = "LblLaterDoNotAss"
        Me.LblLaterDoNotAss.Size = New System.Drawing.Size(61, 29)
        Me.LblLaterDoNotAss.TabIndex = 5
        Me.LblLaterDoNotAss.Text = "0"
        Me.LblLaterDoNotAss.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblLaterTotal
        '
        Me.LblLaterTotal.Location = New System.Drawing.Point(134, 22)
        Me.LblLaterTotal.Name = "LblLaterTotal"
        Me.LblLaterTotal.Size = New System.Drawing.Size(66, 29)
        Me.LblLaterTotal.TabIndex = 4
        Me.LblLaterTotal.Text = "0"
        Me.LblLaterTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ចំនួន មិនទាន់ Assesst:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ចំនួន បានធ្វើ Assesst:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "សរុប ចំនួន:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblNormalTotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(877, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free consultation"
        '
        'LblNormalTotal
        '
        Me.LblNormalTotal.AutoSize = True
        Me.LblNormalTotal.Location = New System.Drawing.Point(79, 29)
        Me.LblNormalTotal.Name = "LblNormalTotal"
        Me.LblNormalTotal.Size = New System.Drawing.Size(17, 22)
        Me.LblNormalTotal.TabIndex = 2
        Me.LblNormalTotal.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "សរុប ចំនួន:"
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.SplitContainer5)
        Me.UiTabPage2.Image = CType(resources.GetObject("UiTabPage2.Image"), System.Drawing.Image)
        Me.UiTabPage2.Key = "Client follow up"
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 37)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1958, 663)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Old client (follow up)    "
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.SplitContainer6)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.GroupBox8)
        Me.SplitContainer5.Panel2.Controls.Add(Me.GroupBox7)
        Me.SplitContainer5.Panel2.Controls.Add(Me.GroupBox6)
        Me.SplitContainer5.Size = New System.Drawing.Size(1958, 663)
        Me.SplitContainer5.SplitterDistance = 541
        Me.SplitContainer5.TabIndex = 0
        '
        'SplitContainer6
        '
        Me.SplitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.GridClientFollowupV1)
        Me.SplitContainer6.Panel1.Controls.Add(Me.ToolStripClientFollowUp)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.UiGroupBox2)
        Me.SplitContainer6.Size = New System.Drawing.Size(1958, 541)
        Me.SplitContainer6.SplitterDistance = 1703
        Me.SplitContainer6.TabIndex = 0
        '
        'GridClientFollowupV1
        '
        Me.GridClientFollowupV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientFollowupV1.Location = New System.Drawing.Point(0, 58)
        Me.GridClientFollowupV1.MainView = Me.GridViewFollowup
        Me.GridClientFollowupV1.Name = "GridClientFollowupV1"
        Me.GridClientFollowupV1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit10, Me.RepositoryItemCheckEdit6, Me.RepositoryItemCheckEdit7, Me.RepositoryItemCheckEdit8, Me.RepositoryItemCheckEdit9, Me.RepositoryItemCheckEdit11})
        Me.GridClientFollowupV1.Size = New System.Drawing.Size(1701, 481)
        Me.GridClientFollowupV1.TabIndex = 7
        Me.GridClientFollowupV1.UseEmbeddedNavigator = True
        Me.GridClientFollowupV1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewFollowup})
        '
        'GridViewFollowup
        '
        Me.GridViewFollowup.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.GridViewFollowup.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewFollowup.Appearance.FocusedRow.Options.UseTextOptions = True
        Me.GridViewFollowup.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridViewFollowup.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridViewFollowup.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridViewFollowup.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewFollowup.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridViewFollowup.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridViewFollowup.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewFollowup.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridViewFollowup.Appearance.Row.Options.UseFont = True
        Me.GridViewFollowup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.RowNo1, Me.IS_MONINTORING, Me.CLIENT_MG_ID1, Me.DATE_CREATE1, Me.CLIENT_DATE_REG1, Me.NUMBER_VISIT, Me.CLIENT_NO1, Me.CLIENT_OLD_NO1, Me.CLIENT_NAME_KHM1, Me.CLIENT_NAME1, Me.CLIENT_SEX1, Me.CLIENT_AGE1, Me.CLIENT_ADDRESS_PHONE1, Me.MAIN_THERAPY_NAME1, Me.DIAGNOSIS1, Me.IMPRESSION_DIAGNOSIS1, Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1, Me.CLIENT_ADVISED_ASSESSMENT_DATE1, Me.CLIENT_ADVISED_ASSESSMENT1, Me.CLIENT_ADVICED_ASSESSMENT_NOTE1, Me.CLIENT_PSYCHIATRIC1, Me.CLIENT_NEUROLOGICAL1, Me.CLIENT_PSYCHOLOGICAL1, Me.CLIENT_DDISORDER1, Me.DIAGNOSIS_CATEGORY1, Me.IS_CLIENT_NEWOLD1, Me.FULL_ADDRESS_KH1, Me.DIAGNOSIS_CATE_ID1, Me.DIAGNOSIS_ID1, Me.MAIN_THERAPY_ID1, Me.PROV_EN1, Me.DIST_EN1, Me.VILL_EN1, Me.COMM_EN1, Me.PROV_KH1, Me.DIST_KH1, Me.COMM_KH1, Me.VILL_KH1, Me.THERAPY_NAME})
        GridFormatRule2.Column = Me.CLIENT_ADVICED_ASSESSMENT_DETAIL1
        GridFormatRule2.Name = "IsDetail"
        FormatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        FormatConditionRuleExpression2.Appearance.Options.UseBackColor = True
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        Me.GridViewFollowup.FormatRules.Add(GridFormatRule2)
        Me.GridViewFollowup.GridControl = Me.GridClientFollowupV1
        Me.GridViewFollowup.Name = "GridViewFollowup"
        Me.GridViewFollowup.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridViewFollowup.OptionsView.ColumnAutoWidth = False
        Me.GridViewFollowup.OptionsView.RowAutoHeight = True
        Me.GridViewFollowup.RowHeight = 35
        '
        'RowNo1
        '
        Me.RowNo1.AppearanceCell.Options.UseTextOptions = True
        Me.RowNo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RowNo1.Caption = "No"
        Me.RowNo1.FieldName = "RowNo"
        Me.RowNo1.Name = "RowNo1"
        Me.RowNo1.OptionsColumn.AllowEdit = False
        Me.RowNo1.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.RowNo1.Visible = True
        Me.RowNo1.VisibleIndex = 0
        Me.RowNo1.Width = 59
        '
        'IS_MONINTORING
        '
        Me.IS_MONINTORING.Caption = "Minitoring"
        Me.IS_MONINTORING.ColumnEdit = Me.RepositoryItemCheckEdit11
        Me.IS_MONINTORING.FieldName = "IS_MONINTORING"
        Me.IS_MONINTORING.Name = "IS_MONINTORING"
        Me.IS_MONINTORING.OptionsColumn.AllowEdit = False
        Me.IS_MONINTORING.Visible = True
        Me.IS_MONINTORING.VisibleIndex = 1
        '
        'RepositoryItemCheckEdit11
        '
        Me.RepositoryItemCheckEdit11.AutoHeight = False
        Me.RepositoryItemCheckEdit11.Name = "RepositoryItemCheckEdit11"
        '
        'CLIENT_MG_ID1
        '
        Me.CLIENT_MG_ID1.Caption = "CLIENT_MG_ID"
        Me.CLIENT_MG_ID1.FieldName = "CLIENT_MG_ID"
        Me.CLIENT_MG_ID1.Name = "CLIENT_MG_ID1"
        '
        'DATE_CREATE1
        '
        Me.DATE_CREATE1.Caption = "Create Date"
        Me.DATE_CREATE1.FieldName = "DATE_CREATE"
        Me.DATE_CREATE1.Name = "DATE_CREATE1"
        Me.DATE_CREATE1.OptionsColumn.AllowEdit = False
        Me.DATE_CREATE1.Visible = True
        Me.DATE_CREATE1.VisibleIndex = 2
        Me.DATE_CREATE1.Width = 133
        '
        'CLIENT_DATE_REG1
        '
        Me.CLIENT_DATE_REG1.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_DATE_REG1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIENT_DATE_REG1.Caption = "Date Register"
        Me.CLIENT_DATE_REG1.FieldName = "CLIENT_DATE_REG"
        Me.CLIENT_DATE_REG1.Name = "CLIENT_DATE_REG1"
        Me.CLIENT_DATE_REG1.OptionsColumn.AllowEdit = False
        Me.CLIENT_DATE_REG1.Visible = True
        Me.CLIENT_DATE_REG1.VisibleIndex = 3
        Me.CLIENT_DATE_REG1.Width = 155
        '
        'NUMBER_VISIT
        '
        Me.NUMBER_VISIT.Caption = "Visit"
        Me.NUMBER_VISIT.FieldName = "NUMBER_VISIT"
        Me.NUMBER_VISIT.Name = "NUMBER_VISIT"
        Me.NUMBER_VISIT.OptionsColumn.AllowEdit = False
        Me.NUMBER_VISIT.Visible = True
        Me.NUMBER_VISIT.VisibleIndex = 6
        Me.NUMBER_VISIT.Width = 59
        '
        'CLIENT_NO1
        '
        Me.CLIENT_NO1.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_NO1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_NO1.Caption = "Client No"
        Me.CLIENT_NO1.FieldName = "CLIENT_NO"
        Me.CLIENT_NO1.Name = "CLIENT_NO1"
        Me.CLIENT_NO1.OptionsColumn.AllowEdit = False
        Me.CLIENT_NO1.Visible = True
        Me.CLIENT_NO1.VisibleIndex = 4
        Me.CLIENT_NO1.Width = 135
        '
        'CLIENT_OLD_NO1
        '
        Me.CLIENT_OLD_NO1.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_OLD_NO1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_OLD_NO1.Caption = "Client Old No"
        Me.CLIENT_OLD_NO1.FieldName = "CLIENT_OLD_NO"
        Me.CLIENT_OLD_NO1.Name = "CLIENT_OLD_NO1"
        Me.CLIENT_OLD_NO1.OptionsColumn.AllowEdit = False
        Me.CLIENT_OLD_NO1.Visible = True
        Me.CLIENT_OLD_NO1.VisibleIndex = 5
        Me.CLIENT_OLD_NO1.Width = 103
        '
        'CLIENT_NAME_KHM1
        '
        Me.CLIENT_NAME_KHM1.AppearanceCell.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.CLIENT_NAME_KHM1.AppearanceCell.Options.UseFont = True
        Me.CLIENT_NAME_KHM1.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_NAME_KHM1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_NAME_KHM1.Caption = "Name KH"
        Me.CLIENT_NAME_KHM1.FieldName = "CLIENT_NAME_KHM"
        Me.CLIENT_NAME_KHM1.Name = "CLIENT_NAME_KHM1"
        Me.CLIENT_NAME_KHM1.OptionsColumn.AllowEdit = False
        Me.CLIENT_NAME_KHM1.Visible = True
        Me.CLIENT_NAME_KHM1.VisibleIndex = 7
        Me.CLIENT_NAME_KHM1.Width = 255
        '
        'CLIENT_NAME1
        '
        Me.CLIENT_NAME1.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_NAME1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_NAME1.Caption = "Name Eng"
        Me.CLIENT_NAME1.FieldName = "CLIENT_NAME"
        Me.CLIENT_NAME1.Name = "CLIENT_NAME1"
        Me.CLIENT_NAME1.OptionsColumn.AllowEdit = False
        Me.CLIENT_NAME1.Visible = True
        Me.CLIENT_NAME1.VisibleIndex = 8
        Me.CLIENT_NAME1.Width = 217
        '
        'CLIENT_SEX1
        '
        Me.CLIENT_SEX1.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_SEX1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIENT_SEX1.Caption = "Sex"
        Me.CLIENT_SEX1.FieldName = "CLIENT_SEX"
        Me.CLIENT_SEX1.Name = "CLIENT_SEX1"
        Me.CLIENT_SEX1.OptionsColumn.AllowEdit = False
        Me.CLIENT_SEX1.Visible = True
        Me.CLIENT_SEX1.VisibleIndex = 9
        '
        'CLIENT_AGE1
        '
        Me.CLIENT_AGE1.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_AGE1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIENT_AGE1.Caption = "Age"
        Me.CLIENT_AGE1.FieldName = "CLIENT_AGE"
        Me.CLIENT_AGE1.Name = "CLIENT_AGE1"
        Me.CLIENT_AGE1.OptionsColumn.AllowEdit = False
        Me.CLIENT_AGE1.Visible = True
        Me.CLIENT_AGE1.VisibleIndex = 10
        Me.CLIENT_AGE1.Width = 88
        '
        'CLIENT_ADDRESS_PHONE1
        '
        Me.CLIENT_ADDRESS_PHONE1.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_ADDRESS_PHONE1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_ADDRESS_PHONE1.Caption = "Tel"
        Me.CLIENT_ADDRESS_PHONE1.FieldName = "CLIENT_ADDRESS_PHONE"
        Me.CLIENT_ADDRESS_PHONE1.Name = "CLIENT_ADDRESS_PHONE1"
        Me.CLIENT_ADDRESS_PHONE1.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADDRESS_PHONE1.Visible = True
        Me.CLIENT_ADDRESS_PHONE1.VisibleIndex = 11
        Me.CLIENT_ADDRESS_PHONE1.Width = 140
        '
        'MAIN_THERAPY_NAME1
        '
        Me.MAIN_THERAPY_NAME1.AppearanceCell.Options.UseTextOptions = True
        Me.MAIN_THERAPY_NAME1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.MAIN_THERAPY_NAME1.Caption = "Main Therapy"
        Me.MAIN_THERAPY_NAME1.FieldName = "MAIN_THERAPY_NAME"
        Me.MAIN_THERAPY_NAME1.Name = "MAIN_THERAPY_NAME1"
        Me.MAIN_THERAPY_NAME1.OptionsColumn.AllowEdit = False
        Me.MAIN_THERAPY_NAME1.Visible = True
        Me.MAIN_THERAPY_NAME1.VisibleIndex = 13
        Me.MAIN_THERAPY_NAME1.Width = 231
        '
        'DIAGNOSIS1
        '
        Me.DIAGNOSIS1.AppearanceCell.Options.UseTextOptions = True
        Me.DIAGNOSIS1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DIAGNOSIS1.Caption = "Diagnosis"
        Me.DIAGNOSIS1.FieldName = "DIAGNOSIS"
        Me.DIAGNOSIS1.Name = "DIAGNOSIS1"
        Me.DIAGNOSIS1.OptionsColumn.AllowEdit = False
        Me.DIAGNOSIS1.Visible = True
        Me.DIAGNOSIS1.VisibleIndex = 14
        Me.DIAGNOSIS1.Width = 159
        '
        'IMPRESSION_DIAGNOSIS1
        '
        Me.IMPRESSION_DIAGNOSIS1.AppearanceCell.Options.UseTextOptions = True
        Me.IMPRESSION_DIAGNOSIS1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.IMPRESSION_DIAGNOSIS1.Caption = "Impression"
        Me.IMPRESSION_DIAGNOSIS1.FieldName = "IMPRESSION_DIAGNOSIS"
        Me.IMPRESSION_DIAGNOSIS1.Name = "IMPRESSION_DIAGNOSIS1"
        Me.IMPRESSION_DIAGNOSIS1.OptionsColumn.AllowEdit = False
        Me.IMPRESSION_DIAGNOSIS1.Visible = True
        Me.IMPRESSION_DIAGNOSIS1.VisibleIndex = 15
        Me.IMPRESSION_DIAGNOSIS1.Width = 210
        '
        'CLIENT_ADVISED_ASSESSMENT_DATE1
        '
        Me.CLIENT_ADVISED_ASSESSMENT_DATE1.Caption = "Ass-Date"
        Me.CLIENT_ADVISED_ASSESSMENT_DATE1.FieldName = "CLIENT_ADVISED_ASSESSMENT_DATE"
        Me.CLIENT_ADVISED_ASSESSMENT_DATE1.Name = "CLIENT_ADVISED_ASSESSMENT_DATE1"
        Me.CLIENT_ADVISED_ASSESSMENT_DATE1.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADVISED_ASSESSMENT_DATE1.Visible = True
        Me.CLIENT_ADVISED_ASSESSMENT_DATE1.VisibleIndex = 17
        Me.CLIENT_ADVISED_ASSESSMENT_DATE1.Width = 95
        '
        'CLIENT_ADVISED_ASSESSMENT1
        '
        Me.CLIENT_ADVISED_ASSESSMENT1.Caption = "Ass-Status"
        Me.CLIENT_ADVISED_ASSESSMENT1.FieldName = "CLIENT_ADVISED_ASSESSMENT"
        Me.CLIENT_ADVISED_ASSESSMENT1.Name = "CLIENT_ADVISED_ASSESSMENT1"
        Me.CLIENT_ADVISED_ASSESSMENT1.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADVISED_ASSESSMENT1.Visible = True
        Me.CLIENT_ADVISED_ASSESSMENT1.VisibleIndex = 18
        Me.CLIENT_ADVISED_ASSESSMENT1.Width = 109
        '
        'CLIENT_ADVICED_ASSESSMENT_NOTE1
        '
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE1.Caption = "Ass-Note"
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE1.FieldName = "CLIENT_ADVICED_ASSESSMENT_NOTE"
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE1.Name = "CLIENT_ADVICED_ASSESSMENT_NOTE1"
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE1.OptionsColumn.AllowEdit = False
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE1.Visible = True
        Me.CLIENT_ADVICED_ASSESSMENT_NOTE1.VisibleIndex = 19
        '
        'CLIENT_PSYCHIATRIC1
        '
        Me.CLIENT_PSYCHIATRIC1.Caption = "Psychiatric"
        Me.CLIENT_PSYCHIATRIC1.ColumnEdit = Me.RepositoryItemCheckEdit7
        Me.CLIENT_PSYCHIATRIC1.FieldName = "CLIENT_PSYCHIATRIC"
        Me.CLIENT_PSYCHIATRIC1.Name = "CLIENT_PSYCHIATRIC1"
        Me.CLIENT_PSYCHIATRIC1.OptionsColumn.AllowEdit = False
        Me.CLIENT_PSYCHIATRIC1.Visible = True
        Me.CLIENT_PSYCHIATRIC1.VisibleIndex = 20
        '
        'RepositoryItemCheckEdit7
        '
        Me.RepositoryItemCheckEdit7.AutoHeight = False
        Me.RepositoryItemCheckEdit7.Name = "RepositoryItemCheckEdit7"
        '
        'CLIENT_NEUROLOGICAL1
        '
        Me.CLIENT_NEUROLOGICAL1.Caption = "NEUROLOGICAL"
        Me.CLIENT_NEUROLOGICAL1.ColumnEdit = Me.RepositoryItemCheckEdit8
        Me.CLIENT_NEUROLOGICAL1.FieldName = "CLIENT_NEUROLOGICAL"
        Me.CLIENT_NEUROLOGICAL1.Name = "CLIENT_NEUROLOGICAL1"
        Me.CLIENT_NEUROLOGICAL1.OptionsColumn.AllowEdit = False
        Me.CLIENT_NEUROLOGICAL1.Visible = True
        Me.CLIENT_NEUROLOGICAL1.VisibleIndex = 21
        '
        'RepositoryItemCheckEdit8
        '
        Me.RepositoryItemCheckEdit8.AutoHeight = False
        Me.RepositoryItemCheckEdit8.Name = "RepositoryItemCheckEdit8"
        '
        'CLIENT_PSYCHOLOGICAL1
        '
        Me.CLIENT_PSYCHOLOGICAL1.Caption = "PSYCHOLOGICAL"
        Me.CLIENT_PSYCHOLOGICAL1.ColumnEdit = Me.RepositoryItemCheckEdit9
        Me.CLIENT_PSYCHOLOGICAL1.FieldName = "CLIENT_PSYCHOLOGICAL"
        Me.CLIENT_PSYCHOLOGICAL1.Name = "CLIENT_PSYCHOLOGICAL1"
        Me.CLIENT_PSYCHOLOGICAL1.OptionsColumn.AllowEdit = False
        Me.CLIENT_PSYCHOLOGICAL1.Visible = True
        Me.CLIENT_PSYCHOLOGICAL1.VisibleIndex = 22
        '
        'RepositoryItemCheckEdit9
        '
        Me.RepositoryItemCheckEdit9.AutoHeight = False
        Me.RepositoryItemCheckEdit9.Name = "RepositoryItemCheckEdit9"
        '
        'CLIENT_DDISORDER1
        '
        Me.CLIENT_DDISORDER1.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_DDISORDER1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIENT_DDISORDER1.Caption = "DDISORDER"
        Me.CLIENT_DDISORDER1.ColumnEdit = Me.RepositoryItemCheckEdit10
        Me.CLIENT_DDISORDER1.FieldName = "CLIENT_DDISORDER"
        Me.CLIENT_DDISORDER1.Name = "CLIENT_DDISORDER1"
        Me.CLIENT_DDISORDER1.OptionsColumn.AllowEdit = False
        Me.CLIENT_DDISORDER1.Visible = True
        Me.CLIENT_DDISORDER1.VisibleIndex = 23
        Me.CLIENT_DDISORDER1.Width = 100
        '
        'RepositoryItemCheckEdit10
        '
        Me.RepositoryItemCheckEdit10.AutoHeight = False
        Me.RepositoryItemCheckEdit10.Name = "RepositoryItemCheckEdit10"
        '
        'DIAGNOSIS_CATEGORY1
        '
        Me.DIAGNOSIS_CATEGORY1.Caption = "DIAGNOSIS_CATEGORY"
        Me.DIAGNOSIS_CATEGORY1.FieldName = "DIAGNOSIS_CATEGORY"
        Me.DIAGNOSIS_CATEGORY1.Name = "DIAGNOSIS_CATEGORY1"
        '
        'IS_CLIENT_NEWOLD1
        '
        Me.IS_CLIENT_NEWOLD1.Caption = "IS_CLIENT_NEWOLD"
        Me.IS_CLIENT_NEWOLD1.FieldName = "IS_CLIENT_NEWOLD"
        Me.IS_CLIENT_NEWOLD1.Name = "IS_CLIENT_NEWOLD1"
        Me.IS_CLIENT_NEWOLD1.Width = 140
        '
        'FULL_ADDRESS_KH1
        '
        Me.FULL_ADDRESS_KH1.AppearanceCell.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.FULL_ADDRESS_KH1.AppearanceCell.Options.UseFont = True
        Me.FULL_ADDRESS_KH1.Caption = "Address"
        Me.FULL_ADDRESS_KH1.FieldName = "FULL_ADDRESS_KH"
        Me.FULL_ADDRESS_KH1.Name = "FULL_ADDRESS_KH1"
        Me.FULL_ADDRESS_KH1.OptionsColumn.AllowEdit = False
        Me.FULL_ADDRESS_KH1.Visible = True
        Me.FULL_ADDRESS_KH1.VisibleIndex = 24
        Me.FULL_ADDRESS_KH1.Width = 391
        '
        'DIAGNOSIS_CATE_ID1
        '
        Me.DIAGNOSIS_CATE_ID1.Caption = "DIAGNOSIS_CATE_ID"
        Me.DIAGNOSIS_CATE_ID1.FieldName = "DIAGNOSIS_CATE_ID"
        Me.DIAGNOSIS_CATE_ID1.Name = "DIAGNOSIS_CATE_ID1"
        '
        'DIAGNOSIS_ID1
        '
        Me.DIAGNOSIS_ID1.Caption = "DIAGNOSIS_ID"
        Me.DIAGNOSIS_ID1.FieldName = "DIAGNOSIS_ID"
        Me.DIAGNOSIS_ID1.Name = "DIAGNOSIS_ID1"
        Me.DIAGNOSIS_ID1.Width = 150
        '
        'MAIN_THERAPY_ID1
        '
        Me.MAIN_THERAPY_ID1.Caption = "MAIN_THERAPY_ID"
        Me.MAIN_THERAPY_ID1.FieldName = "MAIN_THERAPY_ID"
        Me.MAIN_THERAPY_ID1.Name = "MAIN_THERAPY_ID1"
        '
        'PROV_EN1
        '
        Me.PROV_EN1.Caption = "Province"
        Me.PROV_EN1.FieldName = "PROV_EN"
        Me.PROV_EN1.Name = "PROV_EN1"
        Me.PROV_EN1.OptionsColumn.AllowEdit = False
        Me.PROV_EN1.Visible = True
        Me.PROV_EN1.VisibleIndex = 25
        '
        'DIST_EN1
        '
        Me.DIST_EN1.Caption = "DIST_EN"
        Me.DIST_EN1.FieldName = "DIST_EN"
        Me.DIST_EN1.Name = "DIST_EN1"
        Me.DIST_EN1.OptionsColumn.AllowEdit = False
        Me.DIST_EN1.Visible = True
        Me.DIST_EN1.VisibleIndex = 26
        '
        'VILL_EN1
        '
        Me.VILL_EN1.Caption = "VILL_EN"
        Me.VILL_EN1.FieldName = "VILL_EN"
        Me.VILL_EN1.Name = "VILL_EN1"
        Me.VILL_EN1.OptionsColumn.AllowEdit = False
        Me.VILL_EN1.Visible = True
        Me.VILL_EN1.VisibleIndex = 27
        '
        'COMM_EN1
        '
        Me.COMM_EN1.Caption = "COMM_EN"
        Me.COMM_EN1.FieldName = "COMM_EN"
        Me.COMM_EN1.Name = "COMM_EN1"
        Me.COMM_EN1.OptionsColumn.AllowEdit = False
        Me.COMM_EN1.Visible = True
        Me.COMM_EN1.VisibleIndex = 28
        '
        'PROV_KH1
        '
        Me.PROV_KH1.Caption = "PROV_KH"
        Me.PROV_KH1.FieldName = "PROV_KH"
        Me.PROV_KH1.Name = "PROV_KH1"
        Me.PROV_KH1.OptionsColumn.AllowEdit = False
        Me.PROV_KH1.Visible = True
        Me.PROV_KH1.VisibleIndex = 29
        '
        'DIST_KH1
        '
        Me.DIST_KH1.Caption = "DIST_KH"
        Me.DIST_KH1.FieldName = "DIST_KH"
        Me.DIST_KH1.Name = "DIST_KH1"
        Me.DIST_KH1.OptionsColumn.AllowEdit = False
        Me.DIST_KH1.Visible = True
        Me.DIST_KH1.VisibleIndex = 30
        '
        'COMM_KH1
        '
        Me.COMM_KH1.Caption = "COMM_KH"
        Me.COMM_KH1.FieldName = "COMM_KH"
        Me.COMM_KH1.Name = "COMM_KH1"
        Me.COMM_KH1.OptionsColumn.AllowEdit = False
        Me.COMM_KH1.Visible = True
        Me.COMM_KH1.VisibleIndex = 31
        '
        'VILL_KH1
        '
        Me.VILL_KH1.Caption = "VILL_KH"
        Me.VILL_KH1.FieldName = "VILL_KH"
        Me.VILL_KH1.Name = "VILL_KH1"
        Me.VILL_KH1.OptionsColumn.AllowEdit = False
        Me.VILL_KH1.Visible = True
        Me.VILL_KH1.VisibleIndex = 32
        '
        'THERAPY_NAME
        '
        Me.THERAPY_NAME.Caption = "Facilater"
        Me.THERAPY_NAME.FieldName = "THERAPY_NAME"
        Me.THERAPY_NAME.Name = "THERAPY_NAME"
        Me.THERAPY_NAME.OptionsColumn.AllowEdit = False
        Me.THERAPY_NAME.Visible = True
        Me.THERAPY_NAME.VisibleIndex = 12
        Me.THERAPY_NAME.Width = 190
        '
        'ToolStripClientFollowUp
        '
        Me.ToolStripClientFollowUp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripClientFollowUp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripClientFollowUp.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStripClientFollowUp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.BtnEnterDiagnosisFollowup, Me.ToolStripSeparator11, Me.BtnViewClientFollowupDetail, Me.ToolStripSeparator7, Me.BtnNextAppointFollowup, Me.ToolStripSeparator8, Me.BtnCaseMonitoring, Me.ToolStripSeparator14, Me.BtnChangeTherapy2, Me.ToolStripSeparator15, Me.BtnStopVisit, Me.ToolStripSeparator17, Me.BtnReferalToOldClient})
        Me.ToolStripClientFollowUp.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripClientFollowUp.Name = "ToolStripClientFollowUp"
        Me.ToolStripClientFollowUp.Size = New System.Drawing.Size(1701, 58)
        Me.ToolStripClientFollowUp.TabIndex = 5
        Me.ToolStripClientFollowUp.Text = "ToolStrip2"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 58)
        '
        'BtnEnterDiagnosisFollowup
        '
        Me.BtnEnterDiagnosisFollowup.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEnterDiagnosisFollowup.Image = CType(resources.GetObject("BtnEnterDiagnosisFollowup.Image"), System.Drawing.Image)
        Me.BtnEnterDiagnosisFollowup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEnterDiagnosisFollowup.Name = "BtnEnterDiagnosisFollowup"
        Me.BtnEnterDiagnosisFollowup.Size = New System.Drawing.Size(281, 55)
        Me.BtnEnterDiagnosisFollowup.Text = "Enter Diagnosis and Next appointment"
        Me.BtnEnterDiagnosisFollowup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 58)
        '
        'BtnViewClientFollowupDetail
        '
        Me.BtnViewClientFollowupDetail.ForeColor = System.Drawing.Color.Maroon
        Me.BtnViewClientFollowupDetail.Image = CType(resources.GetObject("BtnViewClientFollowupDetail.Image"), System.Drawing.Image)
        Me.BtnViewClientFollowupDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewClientFollowupDetail.Name = "BtnViewClientFollowupDetail"
        Me.BtnViewClientFollowupDetail.Size = New System.Drawing.Size(136, 55)
        Me.BtnViewClientFollowupDetail.Text = "  View client info  "
        Me.BtnViewClientFollowupDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 58)
        '
        'BtnNextAppointFollowup
        '
        Me.BtnNextAppointFollowup.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNextAppointFollowup.Image = CType(resources.GetObject("BtnNextAppointFollowup.Image"), System.Drawing.Image)
        Me.BtnNextAppointFollowup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNextAppointFollowup.Name = "BtnNextAppointFollowup"
        Me.BtnNextAppointFollowup.Size = New System.Drawing.Size(155, 55)
        Me.BtnNextAppointFollowup.Text = "  Next appointment  "
        Me.BtnNextAppointFollowup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 58)
        '
        'BtnCaseMonitoring
        '
        Me.BtnCaseMonitoring.ForeColor = System.Drawing.Color.Maroon
        Me.BtnCaseMonitoring.Image = CType(resources.GetObject("BtnCaseMonitoring.Image"), System.Drawing.Image)
        Me.BtnCaseMonitoring.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCaseMonitoring.Name = "BtnCaseMonitoring"
        Me.BtnCaseMonitoring.Size = New System.Drawing.Size(169, 55)
        Me.BtnCaseMonitoring.Text = "Enter Case Monitoring"
        Me.BtnCaseMonitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 58)
        '
        'BtnChangeTherapy2
        '
        Me.BtnChangeTherapy2.ForeColor = System.Drawing.Color.Maroon
        Me.BtnChangeTherapy2.Image = CType(resources.GetObject("BtnChangeTherapy2.Image"), System.Drawing.Image)
        Me.BtnChangeTherapy2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnChangeTherapy2.Name = "BtnChangeTherapy2"
        Me.BtnChangeTherapy2.Size = New System.Drawing.Size(151, 55)
        Me.BtnChangeTherapy2.Text = "   Change Therapy   "
        Me.BtnChangeTherapy2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 58)
        '
        'BtnStopVisit
        '
        Me.BtnStopVisit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnStopVisit.Image = CType(resources.GetObject("BtnStopVisit.Image"), System.Drawing.Image)
        Me.BtnStopVisit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStopVisit.Name = "BtnStopVisit"
        Me.BtnStopVisit.Size = New System.Drawing.Size(143, 55)
        Me.BtnStopVisit.Text = "   Client Stop Visit  "
        Me.BtnStopVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 58)
        '
        'BtnReferalToOldClient
        '
        Me.BtnReferalToOldClient.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReferalToOldClient.Image = CType(resources.GetObject("BtnReferalToOldClient.Image"), System.Drawing.Image)
        Me.BtnReferalToOldClient.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReferalToOldClient.Name = "BtnReferalToOldClient"
        Me.BtnReferalToOldClient.Size = New System.Drawing.Size(112, 55)
        Me.BtnReferalToOldClient.Text = "   Referral To   "
        Me.BtnReferalToOldClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.Controls.Add(Me.TxtFollowUpOldClientNo)
        Me.UiGroupBox2.Controls.Add(Me.RadFollowUpOldClientNo)
        Me.UiGroupBox2.Controls.Add(Me.DateFollowTo)
        Me.UiGroupBox2.Controls.Add(Me.DateFollowFrom)
        Me.UiGroupBox2.Controls.Add(Me.BtnFindFollowClient)
        Me.UiGroupBox2.Controls.Add(Me.Label7)
        Me.UiGroupBox2.Controls.Add(Me.Label9)
        Me.UiGroupBox2.Controls.Add(Me.TxtFollowClientTel)
        Me.UiGroupBox2.Controls.Add(Me.TxtFollowName)
        Me.UiGroupBox2.Controls.Add(Me.TxtFollowClientNo)
        Me.UiGroupBox2.Controls.Add(Me.RadFollowTel)
        Me.UiGroupBox2.Controls.Add(Me.RadFollowClientName)
        Me.UiGroupBox2.Controls.Add(Me.RadFollowClientNo)
        Me.UiGroupBox2.Controls.Add(Me.RadFollowUpAll)
        Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.UiGroupBox2.FormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiGroupBox2.Location = New System.Drawing.Point(4, 5)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom
        Me.UiGroupBox2.Size = New System.Drawing.Size(240, 531)
        Me.UiGroupBox2.TabIndex = 7
        Me.UiGroupBox2.Text = "Find date followup client"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'TxtFollowUpOldClientNo
        '
        Me.TxtFollowUpOldClientNo.Enabled = False
        Me.TxtFollowUpOldClientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFollowUpOldClientNo.Location = New System.Drawing.Point(6, 207)
        Me.TxtFollowUpOldClientNo.Name = "TxtFollowUpOldClientNo"
        Me.TxtFollowUpOldClientNo.Size = New System.Drawing.Size(227, 27)
        Me.TxtFollowUpOldClientNo.TabIndex = 10
        '
        'RadFollowUpOldClientNo
        '
        Me.RadFollowUpOldClientNo.AutoSize = True
        Me.RadFollowUpOldClientNo.Location = New System.Drawing.Point(6, 181)
        Me.RadFollowUpOldClientNo.Name = "RadFollowUpOldClientNo"
        Me.RadFollowUpOldClientNo.Size = New System.Drawing.Size(123, 24)
        Me.RadFollowUpOldClientNo.TabIndex = 9
        Me.RadFollowUpOldClientNo.Text = "Client Old No:"
        Me.RadFollowUpOldClientNo.UseVisualStyleBackColor = True
        '
        'DateFollowTo
        '
        Me.DateFollowTo.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowTo.Location = New System.Drawing.Point(115, 53)
        Me.DateFollowTo.Name = "DateFollowTo"
        Me.DateFollowTo.Size = New System.Drawing.Size(120, 26)
        Me.DateFollowTo.TabIndex = 5
        '
        'DateFollowFrom
        '
        Me.DateFollowFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowFrom.Location = New System.Drawing.Point(7, 53)
        Me.DateFollowFrom.Name = "DateFollowFrom"
        Me.DateFollowFrom.Size = New System.Drawing.Size(102, 26)
        Me.DateFollowFrom.TabIndex = 4
        '
        'BtnFindFollowClient
        '
        Me.BtnFindFollowClient.BackColor = System.Drawing.Color.Maroon
        Me.BtnFindFollowClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindFollowClient.FlatAppearance.BorderSize = 0
        Me.BtnFindFollowClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindFollowClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFindFollowClient.ForeColor = System.Drawing.Color.White
        Me.BtnFindFollowClient.Location = New System.Drawing.Point(6, 368)
        Me.BtnFindFollowClient.Name = "BtnFindFollowClient"
        Me.BtnFindFollowClient.Size = New System.Drawing.Size(229, 42)
        Me.BtnFindFollowClient.TabIndex = 8
        Me.BtnFindFollowClient.Text = "Find"
        Me.BtnFindFollowClient.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Date From"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(121, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Date To"
        '
        'TxtFollowClientTel
        '
        Me.TxtFollowClientTel.Enabled = False
        Me.TxtFollowClientTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFollowClientTel.Location = New System.Drawing.Point(8, 332)
        Me.TxtFollowClientTel.Name = "TxtFollowClientTel"
        Me.TxtFollowClientTel.Size = New System.Drawing.Size(227, 27)
        Me.TxtFollowClientTel.TabIndex = 7
        '
        'TxtFollowName
        '
        Me.TxtFollowName.Enabled = False
        Me.TxtFollowName.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFollowName.Location = New System.Drawing.Point(8, 267)
        Me.TxtFollowName.Name = "TxtFollowName"
        Me.TxtFollowName.Size = New System.Drawing.Size(227, 32)
        Me.TxtFollowName.TabIndex = 6
        '
        'TxtFollowClientNo
        '
        Me.TxtFollowClientNo.Enabled = False
        Me.TxtFollowClientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFollowClientNo.Location = New System.Drawing.Point(6, 142)
        Me.TxtFollowClientNo.Name = "TxtFollowClientNo"
        Me.TxtFollowClientNo.Size = New System.Drawing.Size(227, 27)
        Me.TxtFollowClientNo.TabIndex = 5
        '
        'RadFollowTel
        '
        Me.RadFollowTel.AutoSize = True
        Me.RadFollowTel.Location = New System.Drawing.Point(8, 308)
        Me.RadFollowTel.Name = "RadFollowTel"
        Me.RadFollowTel.Size = New System.Drawing.Size(96, 24)
        Me.RadFollowTel.TabIndex = 4
        Me.RadFollowTel.Text = "Client Tel:"
        Me.RadFollowTel.UseVisualStyleBackColor = True
        '
        'RadFollowClientName
        '
        Me.RadFollowClientName.AutoSize = True
        Me.RadFollowClientName.Location = New System.Drawing.Point(8, 242)
        Me.RadFollowClientName.Name = "RadFollowClientName"
        Me.RadFollowClientName.Size = New System.Drawing.Size(117, 24)
        Me.RadFollowClientName.TabIndex = 3
        Me.RadFollowClientName.Text = "Client Name:"
        Me.RadFollowClientName.UseVisualStyleBackColor = True
        '
        'RadFollowClientNo
        '
        Me.RadFollowClientNo.AutoSize = True
        Me.RadFollowClientNo.Location = New System.Drawing.Point(6, 116)
        Me.RadFollowClientNo.Name = "RadFollowClientNo"
        Me.RadFollowClientNo.Size = New System.Drawing.Size(95, 24)
        Me.RadFollowClientNo.TabIndex = 2
        Me.RadFollowClientNo.Text = "Client No:"
        Me.RadFollowClientNo.UseVisualStyleBackColor = True
        '
        'RadFollowUpAll
        '
        Me.RadFollowUpAll.AutoSize = True
        Me.RadFollowUpAll.Checked = True
        Me.RadFollowUpAll.Location = New System.Drawing.Point(7, 83)
        Me.RadFollowUpAll.Name = "RadFollowUpAll"
        Me.RadFollowUpAll.Size = New System.Drawing.Size(121, 24)
        Me.RadFollowUpAll.TabIndex = 1
        Me.RadFollowUpAll.TabStop = True
        Me.RadFollowUpAll.Text = "View all client"
        Me.RadFollowUpAll.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.LblTotalNotMonitoring)
        Me.GroupBox8.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.GroupBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox8.Location = New System.Drawing.Point(382, 8)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(193, 104)
        Me.GroupBox8.TabIndex = 8
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "ចំនួនអ្នក​ មិនទាន់បញ្ចូល Monitoring"
        '
        'LblTotalNotMonitoring
        '
        Me.LblTotalNotMonitoring.Location = New System.Drawing.Point(26, 52)
        Me.LblTotalNotMonitoring.Name = "LblTotalNotMonitoring"
        Me.LblTotalNotMonitoring.Size = New System.Drawing.Size(151, 22)
        Me.LblTotalNotMonitoring.TabIndex = 2
        Me.LblTotalNotMonitoring.Text = "0"
        Me.LblTotalNotMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblTotalNotFillDiagnosisFollowup)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox7.Location = New System.Drawing.Point(189, 7)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(187, 104)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Diagnosis មិនទាន់បំពេញ"
        '
        'lblTotalNotFillDiagnosisFollowup
        '
        Me.lblTotalNotFillDiagnosisFollowup.Location = New System.Drawing.Point(6, 52)
        Me.lblTotalNotFillDiagnosisFollowup.Name = "lblTotalNotFillDiagnosisFollowup"
        Me.lblTotalNotFillDiagnosisFollowup.Size = New System.Drawing.Size(151, 22)
        Me.lblTotalNotFillDiagnosisFollowup.TabIndex = 2
        Me.lblTotalNotFillDiagnosisFollowup.Text = "0"
        Me.lblTotalNotFillDiagnosisFollowup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ចំនួនអ្នកមិនបំពេញ Diagnosis:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblFollowUpTotal)
        Me.GroupBox6.Controls.Add(Me.lblFollowUpF)
        Me.GroupBox6.Controls.Add(Me.lblFollowUpM)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(180, 105)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Follow up client"
        '
        'lblFollowUpTotal
        '
        Me.lblFollowUpTotal.Location = New System.Drawing.Point(76, 27)
        Me.lblFollowUpTotal.Name = "lblFollowUpTotal"
        Me.lblFollowUpTotal.Size = New System.Drawing.Size(81, 22)
        Me.lblFollowUpTotal.TabIndex = 7
        Me.lblFollowUpTotal.Text = "0"
        Me.lblFollowUpTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFollowUpF
        '
        Me.lblFollowUpF.Location = New System.Drawing.Point(76, 81)
        Me.lblFollowUpF.Name = "lblFollowUpF"
        Me.lblFollowUpF.Size = New System.Drawing.Size(81, 22)
        Me.lblFollowUpF.TabIndex = 6
        Me.lblFollowUpF.Text = "0"
        Me.lblFollowUpF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFollowUpM
        '
        Me.lblFollowUpM.Location = New System.Drawing.Point(76, 53)
        Me.lblFollowUpM.Name = "lblFollowUpM"
        Me.lblFollowUpM.Size = New System.Drawing.Size(81, 22)
        Me.lblFollowUpM.TabIndex = 5
        Me.lblFollowUpM.Text = "0"
        Me.lblFollowUpM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 22)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "សរុប ចំនួន:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 22)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "ចំនួន ស្រី:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 22)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "ចំនួន ប្រុស:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabClientManagement)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(1962, 703)
        Me.SplitContainer1.SplitterDistance = 1014
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.ForeColor = System.Drawing.Color.Maroon
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(96, 100)
        Me.SplitContainer2.SplitterDistance = 75
        Me.SplitContainer2.TabIndex = 0
        '
        'DashboardClientManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DashboardClientManagment"
        Me.Size = New System.Drawing.Size(1962, 703)
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabClientManagement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabClientManagement.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.GridClientNewV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripNewClient.ResumeLayout(False)
        Me.ToolStripNewClient.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.FamilyDetails.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GgDiagnosos.ResumeLayout(False)
        Me.GgDiagnosos.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.UiTabPage2.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel1.PerformLayout()
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.GridClientFollowupV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewFollowup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripClientFollowUp.ResumeLayout(False)
        Me.ToolStripClientFollowUp.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabClientManagement As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents TxtNewClientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadClientTel As System.Windows.Forms.RadioButton
    Friend WithEvents RadClientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllClient As System.Windows.Forms.RadioButton
    Friend WithEvents TxtNewClientTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtNewClientName As System.Windows.Forms.TextBox
    Friend WithEvents BtnnFind As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClientRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNextAppointment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDiagnosis As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripNewClient As System.Windows.Forms.ToolStrip
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents FamilyDetails As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblImmeDoneAass As System.Windows.Forms.Label
    Friend WithEvents LblImmeDonotAsses As System.Windows.Forms.Label
    Friend WithEvents LblImmeTotal As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblMediumDoneAsses As System.Windows.Forms.Label
    Friend WithEvents LblMediumDoNotAsses As System.Windows.Forms.Label
    Friend WithEvents LblMediumTotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblLaterTotalDoneAssesst As System.Windows.Forms.Label
    Friend WithEvents LblLaterDoNotAss As System.Windows.Forms.Label
    Friend WithEvents LblLaterTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblNormalTotal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateAssessment As System.Windows.Forms.ToolStripButton
    Friend WithEvents RadAssStatus As System.Windows.Forms.RadioButton
    Friend WithEvents CboAdviseAssessment As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents PrintNewCaseConferenceFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintListCaseConferenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewClientDetail As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GgDiagnosos As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotalDiagnosisNewClient As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripClientFollowUp As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNextAppointFollowup As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnEnterDiagnosisFollowup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewClientFollowupDetail As System.Windows.Forms.ToolStripButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents DateFollowTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFollowFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFindFollowClient As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtFollowClientTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtFollowName As System.Windows.Forms.TextBox
    Friend WithEvents TxtFollowClientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadFollowTel As System.Windows.Forms.RadioButton
    Friend WithEvents RadFollowClientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadFollowClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadFollowUpAll As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNewRegisterTotal As System.Windows.Forms.Label
    Friend WithEvents lblNewRegisterF As System.Windows.Forms.Label
    Friend WithEvents lblNewRegisterM As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFollowUpTotal As System.Windows.Forms.Label
    Friend WithEvents lblFollowUpF As System.Windows.Forms.Label
    Friend WithEvents lblFollowUpM As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalNotFillDiagnosisFollowup As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnAddNewReferTo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RadVeiwDetailAssesment As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotalNotMonitoring As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCaseMonitoring As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtFollowUpOldClientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadFollowUpOldClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtNewClientOldNo As System.Windows.Forms.TextBox
    Friend WithEvents RadNewClientOldNo As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnChangeTherapy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnChangeTherapy2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnStopVisit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnGenerateAudit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReferalToOldClient As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridClientNewV1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RowNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_MG_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DATE_CREATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_DATE_REG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_OLD_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NAME_KHM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_SEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_AGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADDRESS_PHONE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MAIN_THERAPY_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAGNOSIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IMPRESSION_DIAGNOSIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADVICED_ASSESSMENT_DETAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADVISED_ASSESSMENT_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADVISED_ASSESSMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADVICED_ASSESSMENT_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_PSYCHIATRIC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NEUROLOGICAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_PSYCHOLOGICAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_DDISORDER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAGNOSIS_CATEGORY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IS_CLIENT_NEWOLD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FULL_ADDRESS_KH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAGNOSIS_CATE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAGNOSIS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MAIN_THERAPY_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BtnExportFile As System.Windows.Forms.Button
    Friend WithEvents PROV_EN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIST_EN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VILL_EN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COMM_EN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PROV_KH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIST_KH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COMM_KH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VILL_KH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridClientFollowupV1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewFollowup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RowNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_MG_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DATE_CREATE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_DATE_REG1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_OLD_NO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NAME_KHM1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_SEX1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_AGE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADDRESS_PHONE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MAIN_THERAPY_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAGNOSIS1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IMPRESSION_DIAGNOSIS1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADVICED_ASSESSMENT_DETAIL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents CLIENT_ADVISED_ASSESSMENT_DATE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADVISED_ASSESSMENT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADVICED_ASSESSMENT_NOTE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_PSYCHIATRIC1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents CLIENT_NEUROLOGICAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents CLIENT_PSYCHOLOGICAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents CLIENT_DDISORDER1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DIAGNOSIS_CATEGORY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IS_CLIENT_NEWOLD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FULL_ADDRESS_KH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAGNOSIS_CATE_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAGNOSIS_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MAIN_THERAPY_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PROV_EN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIST_EN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VILL_EN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COMM_EN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PROV_KH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIST_KH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COMM_KH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VILL_KH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IS_MONINTORING As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents NUMBER_VISIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents THERAPY_NAME As DevExpress.XtraGrid.Columns.GridColumn

End Class
