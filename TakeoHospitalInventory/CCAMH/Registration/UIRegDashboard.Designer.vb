<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIRegDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIRegDashboard))
        Dim GridEX2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNewRegistration = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnClientFollowupRegis = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUpdateOrViewClientRegister = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPatientArchive = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnExportFile = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblImpGreen = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblImpPink = New System.Windows.Forms.Label()
        Me.lblFollowUpTotal = New System.Windows.Forms.Label()
        Me.lblImpYellow = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblImpBlue = New System.Windows.Forms.Label()
        Me.lblNewRegisterTotal = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblFollowUpF = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblNewRegisterF = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblFollowUpM = New System.Windows.Forms.Label()
        Me.lblNewRegisterM = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnUpdatePatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeletePatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnViewDetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEnterDiagnosis = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrognosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridClientRegistration = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CLIENT_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_SOCIAL_SERVICETYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_DATE_REG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_OLD_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_NAME_KHM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_SEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_AGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_AGE_MONTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_ADDRESS_PHONE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_DOB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT_DATE_SEEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PROV_EN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIST_EN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COMM_EN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VILL_EN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RowNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab()
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage()
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.TxtClientNameEng = New System.Windows.Forms.TextBox()
        Me.RadClientNameEng = New System.Windows.Forms.RadioButton()
        Me.TxtOldClientNo = New System.Windows.Forms.TextBox()
        Me.RadOldClientNo = New System.Windows.Forms.RadioButton()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtClientTel = New System.Windows.Forms.TextBox()
        Me.TxtClientNameKh = New System.Windows.Forms.TextBox()
        Me.RadClientTel = New System.Windows.Forms.RadioButton()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.RadClientNameKH = New System.Windows.Forms.RadioButton()
        Me.RadClientNo = New System.Windows.Forms.RadioButton()
        Me.RadViewAllClient = New System.Windows.Forms.RadioButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridClientRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.GhostWhite
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewRegistration, Me.ToolStripSeparator2, Me.BtnClientFollowupRegis, Me.ToolStripSeparator3, Me.BtnUpdateOrViewClientRegister, Me.ToolStripSeparator7, Me.ToolStripButton1, Me.ToolStripSeparator8, Me.BtnPatientArchive, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1653, 58)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewRegistration
        '
        Me.BtnNewRegistration.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnNewRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnNewRegistration.Image = CType(resources.GetObject("BtnNewRegistration.Image"), System.Drawing.Image)
        Me.BtnNewRegistration.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewRegistration.Name = "BtnNewRegistration"
        Me.BtnNewRegistration.Size = New System.Drawing.Size(178, 55)
        Me.BtnNewRegistration.Text = "Client New Registration"
        Me.BtnNewRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'BtnClientFollowupRegis
        '
        Me.BtnClientFollowupRegis.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnClientFollowupRegis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnClientFollowupRegis.Image = CType(resources.GetObject("BtnClientFollowupRegis.Image"), System.Drawing.Image)
        Me.BtnClientFollowupRegis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClientFollowupRegis.Name = "BtnClientFollowupRegis"
        Me.BtnClientFollowupRegis.Size = New System.Drawing.Size(199, 55)
        Me.BtnClientFollowupRegis.Text = "Client Followup Regisation"
        Me.BtnClientFollowupRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 58)
        '
        'BtnUpdateOrViewClientRegister
        '
        Me.BtnUpdateOrViewClientRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnUpdateOrViewClientRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnUpdateOrViewClientRegister.Image = CType(resources.GetObject("BtnUpdateOrViewClientRegister.Image"), System.Drawing.Image)
        Me.BtnUpdateOrViewClientRegister.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnUpdateOrViewClientRegister.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateOrViewClientRegister.Name = "BtnUpdateOrViewClientRegister"
        Me.BtnUpdateOrViewClientRegister.Size = New System.Drawing.Size(164, 55)
        Me.BtnUpdateOrViewClientRegister.Text = "Update or View detail"
        Me.BtnUpdateOrViewClientRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(193, 55)
        Me.ToolStripButton1.Text = "       Print application form "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 58)
        '
        'BtnPatientArchive
        '
        Me.BtnPatientArchive.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnPatientArchive.Image = CType(resources.GetObject("BtnPatientArchive.Image"), System.Drawing.Image)
        Me.BtnPatientArchive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPatientArchive.Name = "BtnPatientArchive"
        Me.BtnPatientArchive.Size = New System.Drawing.Size(158, 55)
        Me.BtnPatientArchive.Text = "Create Client archived"
        Me.BtnPatientArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1383, 85)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.BtnExportFile)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.lblImpGreen)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblImpPink)
        Me.Panel2.Controls.Add(Me.lblFollowUpTotal)
        Me.Panel2.Controls.Add(Me.lblImpYellow)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblImpBlue)
        Me.Panel2.Controls.Add(Me.lblNewRegisterTotal)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lblFollowUpF)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lblNewRegisterF)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.lblFollowUpM)
        Me.Panel2.Controls.Add(Me.lblNewRegisterM)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-7, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1397, 77)
        Me.Panel2.TabIndex = 0
        '
        'BtnExportFile
        '
        Me.BtnExportFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExportFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportFile.Location = New System.Drawing.Point(1189, 14)
        Me.BtnExportFile.Name = "BtnExportFile"
        Me.BtnExportFile.Size = New System.Drawing.Size(196, 54)
        Me.BtnExportFile.TabIndex = 23
        Me.BtnExportFile.Text = "Export File"
        Me.BtnExportFile.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Gray
        Me.Label21.Location = New System.Drawing.Point(161, -3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(1, 71)
        Me.Label21.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Gray
        Me.Label20.Location = New System.Drawing.Point(333, -3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(1, 71)
        Me.Label20.TabIndex = 21
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Gray
        Me.Label24.Location = New System.Drawing.Point(473, -3)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(1, 71)
        Me.Label24.TabIndex = 20
        Me.Label24.Visible = False
        '
        'lblImpGreen
        '
        Me.lblImpGreen.AutoSize = True
        Me.lblImpGreen.Location = New System.Drawing.Point(650, 50)
        Me.lblImpGreen.Name = "lblImpGreen"
        Me.lblImpGreen.Size = New System.Drawing.Size(15, 16)
        Me.lblImpGreen.TabIndex = 19
        Me.lblImpGreen.Text = "0"
        Me.lblImpGreen.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(343, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total: "
        Me.Label9.Visible = False
        '
        'lblImpPink
        '
        Me.lblImpPink.AutoSize = True
        Me.lblImpPink.Location = New System.Drawing.Point(650, 29)
        Me.lblImpPink.Name = "lblImpPink"
        Me.lblImpPink.Size = New System.Drawing.Size(15, 16)
        Me.lblImpPink.TabIndex = 18
        Me.lblImpPink.Text = "0"
        Me.lblImpPink.Visible = False
        '
        'lblFollowUpTotal
        '
        Me.lblFollowUpTotal.AutoSize = True
        Me.lblFollowUpTotal.Location = New System.Drawing.Point(216, 50)
        Me.lblFollowUpTotal.Name = "lblFollowUpTotal"
        Me.lblFollowUpTotal.Size = New System.Drawing.Size(15, 16)
        Me.lblFollowUpTotal.TabIndex = 9
        Me.lblFollowUpTotal.Text = "0"
        '
        'lblImpYellow
        '
        Me.lblImpYellow.AutoSize = True
        Me.lblImpYellow.Location = New System.Drawing.Point(553, 50)
        Me.lblImpYellow.Name = "lblImpYellow"
        Me.lblImpYellow.Size = New System.Drawing.Size(15, 16)
        Me.lblImpYellow.TabIndex = 17
        Me.lblImpYellow.Text = "0"
        Me.lblImpYellow.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(442, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "F:"
        Me.Label10.Visible = False
        '
        'lblImpBlue
        '
        Me.lblImpBlue.AutoSize = True
        Me.lblImpBlue.Location = New System.Drawing.Point(553, 29)
        Me.lblImpBlue.Name = "lblImpBlue"
        Me.lblImpBlue.Size = New System.Drawing.Size(15, 16)
        Me.lblImpBlue.TabIndex = 16
        Me.lblImpBlue.Text = "0"
        Me.lblImpBlue.Visible = False
        '
        'lblNewRegisterTotal
        '
        Me.lblNewRegisterTotal.AutoSize = True
        Me.lblNewRegisterTotal.Location = New System.Drawing.Point(60, 49)
        Me.lblNewRegisterTotal.Name = "lblNewRegisterTotal"
        Me.lblNewRegisterTotal.Size = New System.Drawing.Size(15, 16)
        Me.lblNewRegisterTotal.TabIndex = 6
        Me.lblNewRegisterTotal.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(605, 50)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 16)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Green:"
        Me.Label17.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(346, 29)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "M:"
        Me.Label11.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(605, 29)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Pink:"
        Me.Label13.Visible = False
        '
        'lblFollowUpF
        '
        Me.lblFollowUpF.AutoSize = True
        Me.lblFollowUpF.Location = New System.Drawing.Point(290, 28)
        Me.lblFollowUpF.Name = "lblFollowUpF"
        Me.lblFollowUpF.Size = New System.Drawing.Size(15, 16)
        Me.lblFollowUpF.TabIndex = 8
        Me.lblFollowUpF.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(505, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Yellow:"
        Me.Label14.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label12.Location = New System.Drawing.Point(346, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Case Conference:"
        Me.Label12.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(505, 29)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 16)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Blue:"
        Me.Label15.Visible = False
        '
        'lblNewRegisterF
        '
        Me.lblNewRegisterF.AutoSize = True
        Me.lblNewRegisterF.Location = New System.Drawing.Point(124, 28)
        Me.lblNewRegisterF.Name = "lblNewRegisterF"
        Me.lblNewRegisterF.Size = New System.Drawing.Size(15, 16)
        Me.lblNewRegisterF.TabIndex = 5
        Me.lblNewRegisterF.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label16.Location = New System.Drawing.Point(503, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 16)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Impression:"
        Me.Label16.Visible = False
        '
        'lblFollowUpM
        '
        Me.lblFollowUpM.AutoSize = True
        Me.lblFollowUpM.Location = New System.Drawing.Point(201, 28)
        Me.lblFollowUpM.Name = "lblFollowUpM"
        Me.lblFollowUpM.Size = New System.Drawing.Size(15, 16)
        Me.lblFollowUpM.TabIndex = 7
        Me.lblFollowUpM.Text = "0"
        '
        'lblNewRegisterM
        '
        Me.lblNewRegisterM.AutoSize = True
        Me.lblNewRegisterM.Location = New System.Drawing.Point(49, 27)
        Me.lblNewRegisterM.Name = "lblNewRegisterM"
        Me.lblNewRegisterM.Size = New System.Drawing.Size(15, 16)
        Me.lblNewRegisterM.TabIndex = 4
        Me.lblNewRegisterM.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(172, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(267, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "F:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "F:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(175, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "M:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "M:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(171, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Follow up:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(19, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Registered:"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUpdatePatient, Me.btnDeletePatient})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(153, 48)
        '
        'btnUpdatePatient
        '
        Me.btnUpdatePatient.Name = "btnUpdatePatient"
        Me.btnUpdatePatient.Size = New System.Drawing.Size(152, 22)
        Me.btnUpdatePatient.Text = "Update Patient"
        '
        'btnDeletePatient
        '
        Me.btnDeletePatient.Name = "btnDeletePatient"
        Me.btnDeletePatient.Size = New System.Drawing.Size(152, 22)
        Me.btnDeletePatient.Text = "Delete Patient"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnViewDetail, Me.ToolStripSeparator4, Me.BtnEnterDiagnosis, Me.ToolStripSeparator5, Me.ToolStripMenuItem3, Me.ToolStripSeparator6, Me.ToolStripMenuItem4, Me.PrognosisToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 132)
        '
        'BtnViewDetail
        '
        Me.BtnViewDetail.Name = "BtnViewDetail"
        Me.BtnViewDetail.Size = New System.Drawing.Size(155, 22)
        Me.BtnViewDetail.Text = "View Detail"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(152, 6)
        '
        'BtnEnterDiagnosis
        '
        Me.BtnEnterDiagnosis.Name = "BtnEnterDiagnosis"
        Me.BtnEnterDiagnosis.Size = New System.Drawing.Size(155, 22)
        Me.BtnEnterDiagnosis.Text = "Enter Diagnosis"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(152, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem3.Text = "Refer To ..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(152, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem4.Text = "Impression"
        '
        'PrognosisToolStripMenuItem
        '
        Me.PrognosisToolStripMenuItem.Name = "PrognosisToolStripMenuItem"
        Me.PrognosisToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PrognosisToolStripMenuItem.Text = "Prognosis"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridClientRegistration)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UiTab1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1383, 702)
        Me.SplitContainer1.SplitterDistance = 471
        Me.SplitContainer1.TabIndex = 3
        '
        'GridClientRegistration
        '
        Me.GridClientRegistration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientRegistration.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridClientRegistration.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridClientRegistration.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridClientRegistration.Location = New System.Drawing.Point(0, 85)
        Me.GridClientRegistration.MainView = Me.GridView1
        Me.GridClientRegistration.Name = "GridClientRegistration"
        Me.GridClientRegistration.Size = New System.Drawing.Size(1383, 386)
        Me.GridClientRegistration.TabIndex = 3
        Me.GridClientRegistration.UseEmbeddedNavigator = True
        Me.GridClientRegistration.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.GridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CLIENT_ID, Me.CLIENT_SOCIAL_SERVICETYPE, Me.CLIENT_DATE_REG, Me.CLIENT_NO, Me.CLIENT_OLD_NO, Me.CLIENT_NAME_KHM, Me.CLIENT_NAME, Me.CLIENT_SEX, Me.CLIENT_AGE, Me.CLIENT_AGE_MONTH, Me.CLIENT_ADDRESS_PHONE, Me.CLIENT_DOB, Me.CLIENT_DATE_SEEN, Me.PROV_EN, Me.DIST_EN, Me.COMM_EN, Me.VILL_EN, Me.RowNo})
        Me.GridView1.GridControl = Me.GridClientRegistration
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.RowHeight = 35
        '
        'CLIENT_ID
        '
        Me.CLIENT_ID.Caption = "CLIENT_ID"
        Me.CLIENT_ID.FieldName = "CLIENT_ID"
        Me.CLIENT_ID.Name = "CLIENT_ID"
        Me.CLIENT_ID.OptionsColumn.AllowEdit = False
        '
        'CLIENT_SOCIAL_SERVICETYPE
        '
        Me.CLIENT_SOCIAL_SERVICETYPE.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_SOCIAL_SERVICETYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIENT_SOCIAL_SERVICETYPE.Caption = "Socail Type"
        Me.CLIENT_SOCIAL_SERVICETYPE.FieldName = "CLIENT_SOCIAL_SERVICETYPE"
        Me.CLIENT_SOCIAL_SERVICETYPE.Name = "CLIENT_SOCIAL_SERVICETYPE"
        Me.CLIENT_SOCIAL_SERVICETYPE.OptionsColumn.AllowEdit = False
        Me.CLIENT_SOCIAL_SERVICETYPE.Visible = True
        Me.CLIENT_SOCIAL_SERVICETYPE.VisibleIndex = 1
        Me.CLIENT_SOCIAL_SERVICETYPE.Width = 85
        '
        'CLIENT_DATE_REG
        '
        Me.CLIENT_DATE_REG.Caption = "Date Register"
        Me.CLIENT_DATE_REG.FieldName = "CLIENT_DATE_REG"
        Me.CLIENT_DATE_REG.Name = "CLIENT_DATE_REG"
        Me.CLIENT_DATE_REG.OptionsColumn.AllowEdit = False
        Me.CLIENT_DATE_REG.Visible = True
        Me.CLIENT_DATE_REG.VisibleIndex = 2
        Me.CLIENT_DATE_REG.Width = 108
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
        Me.CLIENT_NO.Width = 141
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
        Me.CLIENT_OLD_NO.Width = 102
        '
        'CLIENT_NAME_KHM
        '
        Me.CLIENT_NAME_KHM.AppearanceCell.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENT_NAME_KHM.AppearanceCell.Options.UseFont = True
        Me.CLIENT_NAME_KHM.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_NAME_KHM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_NAME_KHM.Caption = "Name Kh"
        Me.CLIENT_NAME_KHM.FieldName = "CLIENT_NAME_KHM"
        Me.CLIENT_NAME_KHM.Name = "CLIENT_NAME_KHM"
        Me.CLIENT_NAME_KHM.OptionsColumn.AllowEdit = False
        Me.CLIENT_NAME_KHM.Visible = True
        Me.CLIENT_NAME_KHM.VisibleIndex = 5
        Me.CLIENT_NAME_KHM.Width = 161
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
        Me.CLIENT_NAME.Width = 139
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
        Me.CLIENT_SEX.Width = 71
        '
        'CLIENT_AGE
        '
        Me.CLIENT_AGE.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_AGE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_AGE.Caption = "Age"
        Me.CLIENT_AGE.FieldName = "CLIENT_AGE"
        Me.CLIENT_AGE.Name = "CLIENT_AGE"
        Me.CLIENT_AGE.OptionsColumn.AllowEdit = False
        Me.CLIENT_AGE.Visible = True
        Me.CLIENT_AGE.VisibleIndex = 8
        Me.CLIENT_AGE.Width = 84
        '
        'CLIENT_AGE_MONTH
        '
        Me.CLIENT_AGE_MONTH.Caption = "Age with Month"
        Me.CLIENT_AGE_MONTH.FieldName = "CLIENT_AGE_MONTH"
        Me.CLIENT_AGE_MONTH.Name = "CLIENT_AGE_MONTH"
        Me.CLIENT_AGE_MONTH.OptionsColumn.AllowEdit = False
        Me.CLIENT_AGE_MONTH.Visible = True
        Me.CLIENT_AGE_MONTH.VisibleIndex = 9
        Me.CLIENT_AGE_MONTH.Width = 127
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
        Me.CLIENT_ADDRESS_PHONE.VisibleIndex = 10
        Me.CLIENT_ADDRESS_PHONE.Width = 151
        '
        'CLIENT_DOB
        '
        Me.CLIENT_DOB.AppearanceCell.Options.UseTextOptions = True
        Me.CLIENT_DOB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CLIENT_DOB.Caption = "DOB"
        Me.CLIENT_DOB.FieldName = "CLIENT_DOB"
        Me.CLIENT_DOB.Name = "CLIENT_DOB"
        Me.CLIENT_DOB.OptionsColumn.AllowEdit = False
        Me.CLIENT_DOB.Visible = True
        Me.CLIENT_DOB.VisibleIndex = 11
        Me.CLIENT_DOB.Width = 128
        '
        'CLIENT_DATE_SEEN
        '
        Me.CLIENT_DATE_SEEN.Caption = "CLIENT_DATE_SEEN"
        Me.CLIENT_DATE_SEEN.FieldName = "CLIENT_DATE_SEEN"
        Me.CLIENT_DATE_SEEN.Name = "CLIENT_DATE_SEEN"
        Me.CLIENT_DATE_SEEN.OptionsColumn.AllowEdit = False
        Me.CLIENT_DATE_SEEN.Width = 76
        '
        'PROV_EN
        '
        Me.PROV_EN.Caption = "Province"
        Me.PROV_EN.FieldName = "PROV_EN"
        Me.PROV_EN.Name = "PROV_EN"
        Me.PROV_EN.OptionsColumn.AllowEdit = False
        Me.PROV_EN.Visible = True
        Me.PROV_EN.VisibleIndex = 12
        Me.PROV_EN.Width = 126
        '
        'DIST_EN
        '
        Me.DIST_EN.Caption = "District"
        Me.DIST_EN.FieldName = "DIST_EN"
        Me.DIST_EN.Name = "DIST_EN"
        Me.DIST_EN.OptionsColumn.AllowEdit = False
        Me.DIST_EN.Visible = True
        Me.DIST_EN.VisibleIndex = 13
        Me.DIST_EN.Width = 66
        '
        'COMM_EN
        '
        Me.COMM_EN.Caption = "Commune"
        Me.COMM_EN.FieldName = "COMM_EN"
        Me.COMM_EN.Name = "COMM_EN"
        Me.COMM_EN.OptionsColumn.AllowEdit = False
        Me.COMM_EN.Visible = True
        Me.COMM_EN.VisibleIndex = 14
        Me.COMM_EN.Width = 66
        '
        'VILL_EN
        '
        Me.VILL_EN.Caption = "Village"
        Me.VILL_EN.FieldName = "VILL_EN"
        Me.VILL_EN.Name = "VILL_EN"
        Me.VILL_EN.OptionsColumn.AllowEdit = False
        Me.VILL_EN.Visible = True
        Me.VILL_EN.VisibleIndex = 15
        Me.VILL_EN.Width = 107
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
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom
        Me.UiTab1.OfficeCustomColor = System.Drawing.Color.GhostWhite
        Me.UiTab1.Size = New System.Drawing.Size(1383, 227)
        Me.UiTab1.TabIndex = 0
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage2})
        Me.UiTab1.UseThemes = False
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.GridEX2)
        Me.UiTabPage2.Key = "Chief complain and impression"
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1381, 198)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Chief complain and impression"
        '
        'GridEX2
        '
        Me.GridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX2.BackColor = System.Drawing.Color.White
        Me.GridEX2.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridEX2.CardBorders = False
        Me.GridEX2.ContextMenuStrip = Me.ContextMenuStrip2
        GridEX2_DesignTimeLayout.LayoutString = resources.GetString("GridEX2_DesignTimeLayout.LayoutString")
        Me.GridEX2.DesignTimeLayout = GridEX2_DesignTimeLayout
        Me.GridEX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GridEX2.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridEX2.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEX2.Location = New System.Drawing.Point(0, 0)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom
        Me.GridEX2.OfficeCustomColor = System.Drawing.Color.GhostWhite
        Me.GridEX2.RecordNavigator = True
        Me.GridEX2.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridEX2.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX2.Size = New System.Drawing.Size(1381, 198)
        Me.GridEX2.TabIndex = 4
        Me.GridEX2.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridEX2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.UiGroupBox1.Controls.Add(Me.TxtClientNameEng)
        Me.UiGroupBox1.Controls.Add(Me.RadClientNameEng)
        Me.UiGroupBox1.Controls.Add(Me.TxtOldClientNo)
        Me.UiGroupBox1.Controls.Add(Me.RadOldClientNo)
        Me.UiGroupBox1.Controls.Add(Me.BtnFind)
        Me.UiGroupBox1.Controls.Add(Me.Label19)
        Me.UiGroupBox1.Controls.Add(Me.Label18)
        Me.UiGroupBox1.Controls.Add(Me.TxtClientTel)
        Me.UiGroupBox1.Controls.Add(Me.TxtClientNameKh)
        Me.UiGroupBox1.Controls.Add(Me.RadClientTel)
        Me.UiGroupBox1.Controls.Add(Me.TxtClientNo)
        Me.UiGroupBox1.Controls.Add(Me.DTo)
        Me.UiGroupBox1.Controls.Add(Me.DFrom)
        Me.UiGroupBox1.Controls.Add(Me.RadClientNameKH)
        Me.UiGroupBox1.Controls.Add(Me.RadClientNo)
        Me.UiGroupBox1.Controls.Add(Me.RadViewAllClient)
        Me.UiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(262, 702)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Find client by:"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'TxtClientNameEng
        '
        Me.TxtClientNameEng.Enabled = False
        Me.TxtClientNameEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameEng.Location = New System.Drawing.Point(8, 273)
        Me.TxtClientNameEng.Name = "TxtClientNameEng"
        Me.TxtClientNameEng.Size = New System.Drawing.Size(247, 26)
        Me.TxtClientNameEng.TabIndex = 15
        '
        'RadClientNameEng
        '
        Me.RadClientNameEng.AutoSize = True
        Me.RadClientNameEng.Location = New System.Drawing.Point(8, 243)
        Me.RadClientNameEng.Name = "RadClientNameEng"
        Me.RadClientNameEng.Size = New System.Drawing.Size(136, 22)
        Me.RadClientNameEng.TabIndex = 14
        Me.RadClientNameEng.Text = "Client name eng:"
        Me.RadClientNameEng.UseVisualStyleBackColor = True
        '
        'TxtOldClientNo
        '
        Me.TxtOldClientNo.Enabled = False
        Me.TxtOldClientNo.Location = New System.Drawing.Point(8, 213)
        Me.TxtOldClientNo.Name = "TxtOldClientNo"
        Me.TxtOldClientNo.Size = New System.Drawing.Size(245, 24)
        Me.TxtOldClientNo.TabIndex = 13
        '
        'RadOldClientNo
        '
        Me.RadOldClientNo.AutoSize = True
        Me.RadOldClientNo.Location = New System.Drawing.Point(8, 187)
        Me.RadOldClientNo.Name = "RadOldClientNo"
        Me.RadOldClientNo.Size = New System.Drawing.Size(107, 22)
        Me.RadOldClientNo.TabIndex = 12
        Me.RadOldClientNo.Text = "Old number "
        Me.RadOldClientNo.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatAppearance.BorderSize = 0
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Location = New System.Drawing.Point(8, 445)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(250, 47)
        Me.BtnFind.TabIndex = 11
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(139, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 18)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Date to:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 18)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Date from:"
        '
        'TxtClientTel
        '
        Me.TxtClientTel.Enabled = False
        Me.TxtClientTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientTel.Location = New System.Drawing.Point(8, 413)
        Me.TxtClientTel.Name = "TxtClientTel"
        Me.TxtClientTel.Size = New System.Drawing.Size(247, 26)
        Me.TxtClientTel.TabIndex = 8
        '
        'TxtClientNameKh
        '
        Me.TxtClientNameKh.Enabled = False
        Me.TxtClientNameKh.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameKh.Location = New System.Drawing.Point(8, 344)
        Me.TxtClientNameKh.Name = "TxtClientNameKh"
        Me.TxtClientNameKh.Size = New System.Drawing.Size(247, 32)
        Me.TxtClientNameKh.TabIndex = 7
        '
        'RadClientTel
        '
        Me.RadClientTel.AutoSize = True
        Me.RadClientTel.Location = New System.Drawing.Point(8, 385)
        Me.RadClientTel.Name = "RadClientTel"
        Me.RadClientTel.Size = New System.Drawing.Size(91, 22)
        Me.RadClientTel.TabIndex = 6
        Me.RadClientTel.Text = "Client Tel:"
        Me.RadClientTel.UseVisualStyleBackColor = True
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Enabled = False
        Me.TxtClientNo.Location = New System.Drawing.Point(8, 160)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.Size = New System.Drawing.Size(245, 24)
        Me.TxtClientNo.TabIndex = 5
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(145, 58)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(115, 23)
        Me.DTo.TabIndex = 4
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(5, 58)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(117, 23)
        Me.DFrom.TabIndex = 3
        '
        'RadClientNameKH
        '
        Me.RadClientNameKH.AutoSize = True
        Me.RadClientNameKH.Location = New System.Drawing.Point(8, 314)
        Me.RadClientNameKH.Name = "RadClientNameKH"
        Me.RadClientNameKH.Size = New System.Drawing.Size(128, 22)
        Me.RadClientNameKH.TabIndex = 2
        Me.RadClientNameKH.Text = "Client name kh:"
        Me.RadClientNameKH.UseVisualStyleBackColor = True
        '
        'RadClientNo
        '
        Me.RadClientNo.AutoSize = True
        Me.RadClientNo.Location = New System.Drawing.Point(8, 133)
        Me.RadClientNo.Name = "RadClientNo"
        Me.RadClientNo.Size = New System.Drawing.Size(91, 22)
        Me.RadClientNo.TabIndex = 1
        Me.RadClientNo.Text = "Client No:"
        Me.RadClientNo.UseVisualStyleBackColor = True
        '
        'RadViewAllClient
        '
        Me.RadViewAllClient.AutoSize = True
        Me.RadViewAllClient.Checked = True
        Me.RadViewAllClient.Location = New System.Drawing.Point(8, 97)
        Me.RadViewAllClient.Name = "RadViewAllClient"
        Me.RadViewAllClient.Size = New System.Drawing.Size(113, 22)
        Me.RadViewAllClient.TabIndex = 0
        Me.RadViewAllClient.TabStop = True
        Me.RadViewAllClient.Text = "View all client"
        Me.RadViewAllClient.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.UiGroupBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1653, 704)
        Me.SplitContainer2.SplitterDistance = 1385
        Me.SplitContainer2.TabIndex = 4
        '
        'UIRegDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UIRegDashboard"
        Me.Size = New System.Drawing.Size(1653, 762)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridClientRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnViewDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnEnterDiagnosis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PrognosisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnUpdatePatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDeletePatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNewRegisterM As System.Windows.Forms.Label
    Friend WithEvents lblNewRegisterTotal As System.Windows.Forms.Label
    Friend WithEvents lblNewRegisterF As System.Windows.Forms.Label
    Friend WithEvents lblFollowUpTotal As System.Windows.Forms.Label
    Friend WithEvents lblFollowUpF As System.Windows.Forms.Label
    Friend WithEvents lblFollowUpM As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblImpGreen As System.Windows.Forms.Label
    Friend WithEvents lblImpPink As System.Windows.Forms.Label
    Friend WithEvents lblImpYellow As System.Windows.Forms.Label
    Friend WithEvents lblImpBlue As System.Windows.Forms.Label
    Friend WithEvents BtnNewRegistration As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents RadClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadViewAllClient As System.Windows.Forms.RadioButton
    Friend WithEvents RadClientNameKH As System.Windows.Forms.RadioButton
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TxtClientNameKh As System.Windows.Forms.TextBox
    Friend WithEvents RadClientTel As System.Windows.Forms.RadioButton
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtClientTel As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateOrViewClientRegister As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnClientFollowupRegis As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtOldClientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadOldClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtClientNameEng As System.Windows.Forms.TextBox
    Friend WithEvents RadClientNameEng As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPatientArchive As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridClientRegistration As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CLIENT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_SOCIAL_SERVICETYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_DATE_REG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_OLD_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NAME_KHM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_SEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_AGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_AGE_MONTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_ADDRESS_PHONE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_DOB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENT_DATE_SEEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PROV_EN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIST_EN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COMM_EN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VILL_EN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents RowNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnExportFile As System.Windows.Forms.Button

End Class
