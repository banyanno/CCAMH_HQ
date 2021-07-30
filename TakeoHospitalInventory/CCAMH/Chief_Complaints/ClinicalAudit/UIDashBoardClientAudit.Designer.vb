<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIDashBoardClientAudit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIDashBoardClientAudit))
        Dim GridClientCaseDropOut_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridClinicalAudit_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.ToolCaseAudit = New System.Windows.Forms.ToolStrip()
        Me.BtnNewCaseAudit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUpdateCashAudit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDeleteCaseAudit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPrintCaseDropOut = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridClientCaseDropOut = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.RadDropOut = New System.Windows.Forms.RadioButton()
        Me.RadStopVisit = New System.Windows.Forms.RadioButton()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnnFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadAllCaseAudit = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ClinicalAudit = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridClinicalAudit = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.DateFullYear = New System.Windows.Forms.DateTimePicker()
        Me.RadFullYear = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DateYear = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateClinicalAuditTo = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CboWeekOfYear = New System.Windows.Forms.ComboBox()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateAuditOn = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblWeek = New System.Windows.Forms.Label()
        Me.LblTotalReferralBTB = New System.Windows.Forms.Label()
        Me.LblTotalReferralKGChnang = New System.Windows.Forms.Label()
        Me.LblTotalReferralToKgCham = New System.Windows.Forms.Label()
        Me.LblTotalNaro = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblTotalPsycology = New System.Windows.Forms.Label()
        Me.LblTotalClinicAudit = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StartDateWeek = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EndDateWeek = New System.Windows.Forms.DateTimePicker()
        Me.RadClinicalAuditWeek = New System.Windows.Forms.RadioButton()
        Me.DateClinicalAuditFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnFindClinicalAudit = New System.Windows.Forms.Button()
        Me.TxtClinicalClientName = New System.Windows.Forms.TextBox()
        Me.TxtClinicalClientNo = New System.Windows.Forms.TextBox()
        Me.RadClinicalClientName = New System.Windows.Forms.RadioButton()
        Me.RadClinicalAuditClientNo = New System.Windows.Forms.RadioButton()
        Me.RadClinicalAudit = New System.Windows.Forms.RadioButton()
        Me.ToolClinicalAudit = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateClinicalAudit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDeleteClinicalAudit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPrintClinicalAudit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnListClientAudit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.CashAudit = New System.Windows.Forms.TabPage()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolCaseAudit.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridClientCaseDropOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ClinicalAudit.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridClinicalAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        Me.ToolClinicalAudit.SuspendLayout()
        Me.CashAudit.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolCaseAudit
        '
        Me.ToolCaseAudit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolCaseAudit.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolCaseAudit.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolCaseAudit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewCaseAudit, Me.ToolStripSeparator1, Me.BtnUpdateCashAudit, Me.ToolStripSeparator2, Me.BtnDeleteCaseAudit, Me.ToolStripSeparator3, Me.BtnPrintCaseDropOut})
        Me.ToolCaseAudit.Location = New System.Drawing.Point(3, 3)
        Me.ToolCaseAudit.Name = "ToolCaseAudit"
        Me.ToolCaseAudit.Size = New System.Drawing.Size(1023, 53)
        Me.ToolCaseAudit.TabIndex = 0
        Me.ToolCaseAudit.Text = "ToolStrip1"
        '
        'BtnNewCaseAudit
        '
        Me.BtnNewCaseAudit.Image = CType(resources.GetObject("BtnNewCaseAudit.Image"), System.Drawing.Image)
        Me.BtnNewCaseAudit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewCaseAudit.Name = "BtnNewCaseAudit"
        Me.BtnNewCaseAudit.Size = New System.Drawing.Size(148, 50)
        Me.BtnNewCaseAudit.Text = "   New Case Audit   "
        Me.BtnNewCaseAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'BtnUpdateCashAudit
        '
        Me.BtnUpdateCashAudit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUpdateCashAudit.Image = CType(resources.GetObject("BtnUpdateCashAudit.Image"), System.Drawing.Image)
        Me.BtnUpdateCashAudit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateCashAudit.Name = "BtnUpdateCashAudit"
        Me.BtnUpdateCashAudit.Size = New System.Drawing.Size(162, 50)
        Me.BtnUpdateCashAudit.Text = "   Update Case Audit  "
        Me.BtnUpdateCashAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'BtnDeleteCaseAudit
        '
        Me.BtnDeleteCaseAudit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDeleteCaseAudit.Image = CType(resources.GetObject("BtnDeleteCaseAudit.Image"), System.Drawing.Image)
        Me.BtnDeleteCaseAudit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteCaseAudit.Name = "BtnDeleteCaseAudit"
        Me.BtnDeleteCaseAudit.Size = New System.Drawing.Size(156, 50)
        Me.BtnDeleteCaseAudit.Text = "   Delete Case Audit  "
        Me.BtnDeleteCaseAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'BtnPrintCaseDropOut
        '
        Me.BtnPrintCaseDropOut.Image = CType(resources.GetObject("BtnPrintCaseDropOut.Image"), System.Drawing.Image)
        Me.BtnPrintCaseDropOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintCaseDropOut.Name = "BtnPrintCaseDropOut"
        Me.BtnPrintCaseDropOut.Size = New System.Drawing.Size(126, 50)
        Me.BtnPrintCaseDropOut.Text = "   Print Preveiw  "
        Me.BtnPrintCaseDropOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 56)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridClientCaseDropOut)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UiGroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1023, 816)
        Me.SplitContainer1.SplitterDistance = 738
        Me.SplitContainer1.TabIndex = 1
        '
        'GridClientCaseDropOut
        '
        Me.GridClientCaseDropOut.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientCaseDropOut.BackColor = System.Drawing.Color.White
        Me.GridClientCaseDropOut.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridClientCaseDropOut.CardBorders = False
        GridClientCaseDropOut_DesignTimeLayout.LayoutString = resources.GetString("GridClientCaseDropOut_DesignTimeLayout.LayoutString")
        Me.GridClientCaseDropOut.DesignTimeLayout = GridClientCaseDropOut_DesignTimeLayout
        Me.GridClientCaseDropOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientCaseDropOut.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GridClientCaseDropOut.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientCaseDropOut.GroupByBoxVisible = False
        Me.GridClientCaseDropOut.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClientCaseDropOut.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClientCaseDropOut.Location = New System.Drawing.Point(0, 0)
        Me.GridClientCaseDropOut.Name = "GridClientCaseDropOut"
        Me.GridClientCaseDropOut.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.GridClientCaseDropOut.RecordNavigator = True
        Me.GridClientCaseDropOut.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientCaseDropOut.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientCaseDropOut.Size = New System.Drawing.Size(736, 814)
        Me.GridClientCaseDropOut.TabIndex = 4
        Me.GridClientCaseDropOut.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientCaseDropOut.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.RadDropOut)
        Me.UiGroupBox1.Controls.Add(Me.RadStopVisit)
        Me.UiGroupBox1.Controls.Add(Me.DTo)
        Me.UiGroupBox1.Controls.Add(Me.DFrom)
        Me.UiGroupBox1.Controls.Add(Me.BtnnFind)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.RadAllCaseAudit)
        Me.UiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom
        Me.UiGroupBox1.Size = New System.Drawing.Size(279, 814)
        Me.UiGroupBox1.TabIndex = 7
        Me.UiGroupBox1.Text = "Find Client audit"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'RadDropOut
        '
        Me.RadDropOut.AutoSize = True
        Me.RadDropOut.Location = New System.Drawing.Point(142, 124)
        Me.RadDropOut.Name = "RadDropOut"
        Me.RadDropOut.Size = New System.Drawing.Size(93, 24)
        Me.RadDropOut.TabIndex = 10
        Me.RadDropOut.Text = "Drop-Out"
        Me.RadDropOut.UseVisualStyleBackColor = True
        '
        'RadStopVisit
        '
        Me.RadStopVisit.AutoSize = True
        Me.RadStopVisit.Location = New System.Drawing.Point(13, 124)
        Me.RadStopVisit.Name = "RadStopVisit"
        Me.RadStopVisit.Size = New System.Drawing.Size(95, 24)
        Me.RadStopVisit.TabIndex = 9
        Me.RadStopVisit.Text = "Stop Visit"
        Me.RadStopVisit.UseVisualStyleBackColor = True
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(133, 51)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(119, 26)
        Me.DTo.TabIndex = 5
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(13, 51)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(118, 26)
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
        Me.BtnnFind.Location = New System.Drawing.Point(7, 159)
        Me.BtnnFind.Name = "BtnnFind"
        Me.BtnnFind.Size = New System.Drawing.Size(248, 42)
        Me.BtnnFind.TabIndex = 8
        Me.BtnnFind.Text = "Find"
        Me.BtnnFind.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date To"
        '
        'RadAllCaseAudit
        '
        Me.RadAllCaseAudit.AutoSize = True
        Me.RadAllCaseAudit.Checked = True
        Me.RadAllCaseAudit.Location = New System.Drawing.Point(13, 94)
        Me.RadAllCaseAudit.Name = "RadAllCaseAudit"
        Me.RadAllCaseAudit.Size = New System.Drawing.Size(157, 24)
        Me.RadAllCaseAudit.TabIndex = 2
        Me.RadAllCaseAudit.TabStop = True
        Me.RadAllCaseAudit.Text = "View all case audit"
        Me.RadAllCaseAudit.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ClinicalAudit)
        Me.TabControl1.Controls.Add(Me.CashAudit)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1037, 908)
        Me.TabControl1.TabIndex = 2
        '
        'ClinicalAudit
        '
        Me.ClinicalAudit.Controls.Add(Me.SplitContainer2)
        Me.ClinicalAudit.Controls.Add(Me.ToolClinicalAudit)
        Me.ClinicalAudit.Location = New System.Drawing.Point(4, 29)
        Me.ClinicalAudit.Name = "ClinicalAudit"
        Me.ClinicalAudit.Padding = New System.Windows.Forms.Padding(3)
        Me.ClinicalAudit.Size = New System.Drawing.Size(1029, 875)
        Me.ClinicalAudit.TabIndex = 0
        Me.ClinicalAudit.Text = "     Clinical Audit      "
        Me.ClinicalAudit.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 56)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridClinicalAudit)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.UiGroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1023, 816)
        Me.SplitContainer2.SplitterDistance = 765
        Me.SplitContainer2.TabIndex = 6
        '
        'GridClinicalAudit
        '
        Me.GridClinicalAudit.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClinicalAudit.BackColor = System.Drawing.Color.White
        Me.GridClinicalAudit.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridClinicalAudit.CardBorders = False
        GridClinicalAudit_DesignTimeLayout.LayoutString = resources.GetString("GridClinicalAudit_DesignTimeLayout.LayoutString")
        Me.GridClinicalAudit.DesignTimeLayout = GridClinicalAudit_DesignTimeLayout
        Me.GridClinicalAudit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClinicalAudit.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GridClinicalAudit.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClinicalAudit.GroupByBoxFormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.GridClinicalAudit.GroupByBoxVisible = False
        Me.GridClinicalAudit.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridClinicalAudit.GroupRowFormatStyle.FontSize = 14.0!
        Me.GridClinicalAudit.GroupRowFormatStyle.ForeColor = System.Drawing.Color.DarkRed
        Me.GridClinicalAudit.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClinicalAudit.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClinicalAudit.Location = New System.Drawing.Point(0, 0)
        Me.GridClinicalAudit.Name = "GridClinicalAudit"
        Me.GridClinicalAudit.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.GridClinicalAudit.RecordNavigator = True
        Me.GridClinicalAudit.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClinicalAudit.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClinicalAudit.Size = New System.Drawing.Size(763, 814)
        Me.GridClinicalAudit.TabIndex = 5
        Me.GridClinicalAudit.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClinicalAudit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Controls.Add(Me.DateFullYear)
        Me.UiGroupBox2.Controls.Add(Me.RadFullYear)
        Me.UiGroupBox2.Controls.Add(Me.Label15)
        Me.UiGroupBox2.Controls.Add(Me.DateYear)
        Me.UiGroupBox2.Controls.Add(Me.Label14)
        Me.UiGroupBox2.Controls.Add(Me.DateClinicalAuditTo)
        Me.UiGroupBox2.Controls.Add(Me.Label13)
        Me.UiGroupBox2.Controls.Add(Me.CboWeekOfYear)
        Me.UiGroupBox2.Controls.Add(Me.UiGroupBox3)
        Me.UiGroupBox2.Controls.Add(Me.RadClinicalAuditWeek)
        Me.UiGroupBox2.Controls.Add(Me.DateClinicalAuditFrom)
        Me.UiGroupBox2.Controls.Add(Me.BtnFindClinicalAudit)
        Me.UiGroupBox2.Controls.Add(Me.TxtClinicalClientName)
        Me.UiGroupBox2.Controls.Add(Me.TxtClinicalClientNo)
        Me.UiGroupBox2.Controls.Add(Me.RadClinicalClientName)
        Me.UiGroupBox2.Controls.Add(Me.RadClinicalAuditClientNo)
        Me.UiGroupBox2.Controls.Add(Me.RadClinicalAudit)
        Me.UiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.UiGroupBox2.FormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom
        Me.UiGroupBox2.Size = New System.Drawing.Size(252, 814)
        Me.UiGroupBox2.TabIndex = 8
        Me.UiGroupBox2.Text = "Clinical Audit"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'DateFullYear
        '
        Me.DateFullYear.Checked = False
        Me.DateFullYear.CustomFormat = "yyyy"
        Me.DateFullYear.Enabled = False
        Me.DateFullYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFullYear.Location = New System.Drawing.Point(10, 117)
        Me.DateFullYear.Name = "DateFullYear"
        Me.DateFullYear.ShowCheckBox = True
        Me.DateFullYear.Size = New System.Drawing.Size(114, 26)
        Me.DateFullYear.TabIndex = 23
        '
        'RadFullYear
        '
        Me.RadFullYear.AutoSize = True
        Me.RadFullYear.Location = New System.Drawing.Point(8, 89)
        Me.RadFullYear.Name = "RadFullYear"
        Me.RadFullYear.Size = New System.Drawing.Size(122, 24)
        Me.RadFullYear.TabIndex = 22
        Me.RadFullYear.Text = "Audit full year"
        Me.RadFullYear.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(123, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 20)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Select Year"
        '
        'DateYear
        '
        Me.DateYear.Checked = False
        Me.DateYear.CustomFormat = "yyyy"
        Me.DateYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateYear.Location = New System.Drawing.Point(126, 57)
        Me.DateYear.Name = "DateYear"
        Me.DateYear.ShowCheckBox = True
        Me.DateYear.Size = New System.Drawing.Size(114, 26)
        Me.DateYear.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(125, 173)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 20)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "To:"
        '
        'DateClinicalAuditTo
        '
        Me.DateClinicalAuditTo.CustomFormat = "dd/MM/yyyy"
        Me.DateClinicalAuditTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateClinicalAuditTo.Location = New System.Drawing.Point(125, 196)
        Me.DateClinicalAuditTo.Name = "DateClinicalAuditTo"
        Me.DateClinicalAuditTo.Size = New System.Drawing.Size(117, 26)
        Me.DateClinicalAuditTo.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 20)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "From:"
        '
        'CboWeekOfYear
        '
        Me.CboWeekOfYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboWeekOfYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboWeekOfYear.FormattingEnabled = True
        Me.CboWeekOfYear.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52"})
        Me.CboWeekOfYear.Location = New System.Drawing.Point(8, 55)
        Me.CboWeekOfYear.Name = "CboWeekOfYear"
        Me.CboWeekOfYear.Size = New System.Drawing.Size(112, 28)
        Me.CboWeekOfYear.TabIndex = 15
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.Controls.Add(Me.Label3)
        Me.UiGroupBox3.Controls.Add(Me.DateAuditOn)
        Me.UiGroupBox3.Controls.Add(Me.Label11)
        Me.UiGroupBox3.Controls.Add(Me.LblWeek)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalReferralBTB)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalReferralKGChnang)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalReferralToKgCham)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalNaro)
        Me.UiGroupBox3.Controls.Add(Me.Label12)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalPsycology)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalClinicAudit)
        Me.UiGroupBox3.Controls.Add(Me.Label10)
        Me.UiGroupBox3.Controls.Add(Me.Label4)
        Me.UiGroupBox3.Controls.Add(Me.Label9)
        Me.UiGroupBox3.Controls.Add(Me.Label8)
        Me.UiGroupBox3.Controls.Add(Me.StartDateWeek)
        Me.UiGroupBox3.Controls.Add(Me.Label7)
        Me.UiGroupBox3.Controls.Add(Me.Label6)
        Me.UiGroupBox3.Controls.Add(Me.Label5)
        Me.UiGroupBox3.Controls.Add(Me.EndDateWeek)
        Me.UiGroupBox3.Location = New System.Drawing.Point(5, 400)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(248, 408)
        Me.UiGroupBox3.TabIndex = 12
        Me.UiGroupBox3.Text = "Clinical Audit Summary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Date Audit On"
        '
        'DateAuditOn
        '
        Me.DateAuditOn.Checked = False
        Me.DateAuditOn.CustomFormat = "dd/MM/yyyy"
        Me.DateAuditOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAuditOn.Location = New System.Drawing.Point(5, 49)
        Me.DateAuditOn.Name = "DateAuditOn"
        Me.DateAuditOn.ShowCheckBox = True
        Me.DateAuditOn.Size = New System.Drawing.Size(144, 26)
        Me.DateAuditOn.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Week:"
        '
        'LblWeek
        '
        Me.LblWeek.AutoSize = True
        Me.LblWeek.Location = New System.Drawing.Point(67, 146)
        Me.LblWeek.Name = "LblWeek"
        Me.LblWeek.Size = New System.Drawing.Size(18, 20)
        Me.LblWeek.TabIndex = 24
        Me.LblWeek.Text = "0"
        '
        'LblTotalReferralBTB
        '
        Me.LblTotalReferralBTB.AutoSize = True
        Me.LblTotalReferralBTB.Location = New System.Drawing.Point(118, 310)
        Me.LblTotalReferralBTB.Name = "LblTotalReferralBTB"
        Me.LblTotalReferralBTB.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalReferralBTB.TabIndex = 23
        Me.LblTotalReferralBTB.Text = "0"
        '
        'LblTotalReferralKGChnang
        '
        Me.LblTotalReferralKGChnang.AutoSize = True
        Me.LblTotalReferralKGChnang.Location = New System.Drawing.Point(165, 281)
        Me.LblTotalReferralKGChnang.Name = "LblTotalReferralKGChnang"
        Me.LblTotalReferralKGChnang.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalReferralKGChnang.TabIndex = 22
        Me.LblTotalReferralKGChnang.Text = "0"
        '
        'LblTotalReferralToKgCham
        '
        Me.LblTotalReferralToKgCham.AutoSize = True
        Me.LblTotalReferralToKgCham.Location = New System.Drawing.Point(151, 252)
        Me.LblTotalReferralToKgCham.Name = "LblTotalReferralToKgCham"
        Me.LblTotalReferralToKgCham.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalReferralToKgCham.TabIndex = 21
        Me.LblTotalReferralToKgCham.Text = "0"
        '
        'LblTotalNaro
        '
        Me.LblTotalNaro.AutoSize = True
        Me.LblTotalNaro.Location = New System.Drawing.Point(67, 223)
        Me.LblTotalNaro.Name = "LblTotalNaro"
        Me.LblTotalNaro.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalNaro.TabIndex = 20
        Me.LblTotalNaro.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(150, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "End Date Week:"
        '
        'LblTotalPsycology
        '
        Me.LblTotalPsycology.AutoSize = True
        Me.LblTotalPsycology.Location = New System.Drawing.Point(67, 198)
        Me.LblTotalPsycology.Name = "LblTotalPsycology"
        Me.LblTotalPsycology.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalPsycology.TabIndex = 19
        Me.LblTotalPsycology.Text = "0"
        '
        'LblTotalClinicAudit
        '
        Me.LblTotalClinicAudit.AutoSize = True
        Me.LblTotalClinicAudit.Location = New System.Drawing.Point(67, 173)
        Me.LblTotalClinicAudit.Name = "LblTotalClinicAudit"
        Me.LblTotalClinicAudit.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalClinicAudit.TabIndex = 18
        Me.LblTotalClinicAudit.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Refer to BTB:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Start Date Week:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Refer to Kg.Chnang:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Refer to Kg.Cham:"
        '
        'StartDateWeek
        '
        Me.StartDateWeek.Checked = False
        Me.StartDateWeek.CustomFormat = "dd/MM/yyyy"
        Me.StartDateWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDateWeek.Location = New System.Drawing.Point(5, 104)
        Me.StartDateWeek.Name = "StartDateWeek"
        Me.StartDateWeek.ShowCheckBox = True
        Me.StartDateWeek.Size = New System.Drawing.Size(144, 26)
        Me.StartDateWeek.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Psy+N:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total:"
        '
        'EndDateWeek
        '
        Me.EndDateWeek.Checked = False
        Me.EndDateWeek.CustomFormat = "dd/MM/yyyy"
        Me.EndDateWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDateWeek.Location = New System.Drawing.Point(154, 104)
        Me.EndDateWeek.Name = "EndDateWeek"
        Me.EndDateWeek.ShowCheckBox = True
        Me.EndDateWeek.Size = New System.Drawing.Size(122, 26)
        Me.EndDateWeek.TabIndex = 5
        '
        'RadClinicalAuditWeek
        '
        Me.RadClinicalAuditWeek.AutoSize = True
        Me.RadClinicalAuditWeek.Checked = True
        Me.RadClinicalAuditWeek.Location = New System.Drawing.Point(8, 25)
        Me.RadClinicalAuditWeek.Name = "RadClinicalAuditWeek"
        Me.RadClinicalAuditWeek.Size = New System.Drawing.Size(72, 24)
        Me.RadClinicalAuditWeek.TabIndex = 9
        Me.RadClinicalAuditWeek.TabStop = True
        Me.RadClinicalAuditWeek.Text = "Week "
        Me.RadClinicalAuditWeek.UseVisualStyleBackColor = True
        '
        'DateClinicalAuditFrom
        '
        Me.DateClinicalAuditFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateClinicalAuditFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateClinicalAuditFrom.Location = New System.Drawing.Point(10, 196)
        Me.DateClinicalAuditFrom.Name = "DateClinicalAuditFrom"
        Me.DateClinicalAuditFrom.Size = New System.Drawing.Size(112, 26)
        Me.DateClinicalAuditFrom.TabIndex = 4
        '
        'BtnFindClinicalAudit
        '
        Me.BtnFindClinicalAudit.BackColor = System.Drawing.Color.Maroon
        Me.BtnFindClinicalAudit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindClinicalAudit.FlatAppearance.BorderSize = 0
        Me.BtnFindClinicalAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindClinicalAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFindClinicalAudit.ForeColor = System.Drawing.Color.White
        Me.BtnFindClinicalAudit.Location = New System.Drawing.Point(8, 352)
        Me.BtnFindClinicalAudit.Name = "BtnFindClinicalAudit"
        Me.BtnFindClinicalAudit.Size = New System.Drawing.Size(230, 42)
        Me.BtnFindClinicalAudit.TabIndex = 8
        Me.BtnFindClinicalAudit.Text = "Find"
        Me.BtnFindClinicalAudit.UseVisualStyleBackColor = False
        '
        'TxtClinicalClientName
        '
        Me.TxtClinicalClientName.Enabled = False
        Me.TxtClinicalClientName.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClinicalClientName.Location = New System.Drawing.Point(8, 313)
        Me.TxtClinicalClientName.Name = "TxtClinicalClientName"
        Me.TxtClinicalClientName.Size = New System.Drawing.Size(232, 32)
        Me.TxtClinicalClientName.TabIndex = 6
        '
        'TxtClinicalClientNo
        '
        Me.TxtClinicalClientNo.Enabled = False
        Me.TxtClinicalClientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClinicalClientNo.Location = New System.Drawing.Point(10, 253)
        Me.TxtClinicalClientNo.Name = "TxtClinicalClientNo"
        Me.TxtClinicalClientNo.Size = New System.Drawing.Size(230, 27)
        Me.TxtClinicalClientNo.TabIndex = 5
        '
        'RadClinicalClientName
        '
        Me.RadClinicalClientName.AutoSize = True
        Me.RadClinicalClientName.Location = New System.Drawing.Point(8, 286)
        Me.RadClinicalClientName.Name = "RadClinicalClientName"
        Me.RadClinicalClientName.Size = New System.Drawing.Size(150, 24)
        Me.RadClinicalClientName.TabIndex = 3
        Me.RadClinicalClientName.Text = "Client Name Eng:"
        Me.RadClinicalClientName.UseVisualStyleBackColor = True
        '
        'RadClinicalAuditClientNo
        '
        Me.RadClinicalAuditClientNo.AutoSize = True
        Me.RadClinicalAuditClientNo.Location = New System.Drawing.Point(10, 229)
        Me.RadClinicalAuditClientNo.Name = "RadClinicalAuditClientNo"
        Me.RadClinicalAuditClientNo.Size = New System.Drawing.Size(95, 24)
        Me.RadClinicalAuditClientNo.TabIndex = 2
        Me.RadClinicalAuditClientNo.Text = "Client No:"
        Me.RadClinicalAuditClientNo.UseVisualStyleBackColor = True
        '
        'RadClinicalAudit
        '
        Me.RadClinicalAudit.AutoSize = True
        Me.RadClinicalAudit.Location = New System.Drawing.Point(8, 149)
        Me.RadClinicalAudit.Name = "RadClinicalAudit"
        Me.RadClinicalAudit.Size = New System.Drawing.Size(185, 24)
        Me.RadClinicalAudit.TabIndex = 1
        Me.RadClinicalAudit.Text = "Date Clinical Audit On:"
        Me.RadClinicalAudit.UseVisualStyleBackColor = True
        '
        'ToolClinicalAudit
        '
        Me.ToolClinicalAudit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolClinicalAudit.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolClinicalAudit.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolClinicalAudit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.UpdateClinicalAudit, Me.ToolStripSeparator5, Me.BtnDeleteClinicalAudit, Me.ToolStripSeparator6, Me.BtnPrintClinicalAudit, Me.ToolStripSeparator7, Me.BtnListClientAudit, Me.ToolStripSeparator8})
        Me.ToolClinicalAudit.Location = New System.Drawing.Point(3, 3)
        Me.ToolClinicalAudit.Name = "ToolClinicalAudit"
        Me.ToolClinicalAudit.Size = New System.Drawing.Size(1023, 53)
        Me.ToolClinicalAudit.TabIndex = 1
        Me.ToolClinicalAudit.Text = "ToolStrip2"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 53)
        '
        'UpdateClinicalAudit
        '
        Me.UpdateClinicalAudit.ForeColor = System.Drawing.Color.Maroon
        Me.UpdateClinicalAudit.Image = CType(resources.GetObject("UpdateClinicalAudit.Image"), System.Drawing.Image)
        Me.UpdateClinicalAudit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateClinicalAudit.Name = "UpdateClinicalAudit"
        Me.UpdateClinicalAudit.Size = New System.Drawing.Size(159, 50)
        Me.UpdateClinicalAudit.Text = "   Update Conference"
        Me.UpdateClinicalAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 53)
        '
        'BtnDeleteClinicalAudit
        '
        Me.BtnDeleteClinicalAudit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDeleteClinicalAudit.Image = CType(resources.GetObject("BtnDeleteClinicalAudit.Image"), System.Drawing.Image)
        Me.BtnDeleteClinicalAudit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteClinicalAudit.Name = "BtnDeleteClinicalAudit"
        Me.BtnDeleteClinicalAudit.Size = New System.Drawing.Size(156, 50)
        Me.BtnDeleteClinicalAudit.Text = "   Delete Case Audit  "
        Me.BtnDeleteClinicalAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnDeleteClinicalAudit.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 53)
        Me.ToolStripSeparator6.Visible = False
        '
        'BtnPrintClinicalAudit
        '
        Me.BtnPrintClinicalAudit.Image = CType(resources.GetObject("BtnPrintClinicalAudit.Image"), System.Drawing.Image)
        Me.BtnPrintClinicalAudit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintClinicalAudit.Name = "BtnPrintClinicalAudit"
        Me.BtnPrintClinicalAudit.Size = New System.Drawing.Size(179, 50)
        Me.BtnPrintClinicalAudit.Text = "   Print Case Conference"
        Me.BtnPrintClinicalAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 53)
        '
        'BtnListClientAudit
        '
        Me.BtnListClientAudit.Image = CType(resources.GetObject("BtnListClientAudit.Image"), System.Drawing.Image)
        Me.BtnListClientAudit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnListClientAudit.Name = "BtnListClientAudit"
        Me.BtnListClientAudit.Size = New System.Drawing.Size(219, 50)
        Me.BtnListClientAudit.Text = "   List of Client Clinical Audit   "
        Me.BtnListClientAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 53)
        '
        'CashAudit
        '
        Me.CashAudit.Controls.Add(Me.SplitContainer1)
        Me.CashAudit.Controls.Add(Me.ToolCaseAudit)
        Me.CashAudit.Location = New System.Drawing.Point(4, 29)
        Me.CashAudit.Name = "CashAudit"
        Me.CashAudit.Padding = New System.Windows.Forms.Padding(3)
        Me.CashAudit.Size = New System.Drawing.Size(1029, 875)
        Me.CashAudit.TabIndex = 1
        Me.CashAudit.Text = "     Case Stop and Drop-Out     "
        Me.CashAudit.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UIDashBoardClientAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "UIDashBoardClientAudit"
        Me.Size = New System.Drawing.Size(1037, 908)
        Me.ToolCaseAudit.ResumeLayout(False)
        Me.ToolCaseAudit.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridClientCaseDropOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ClinicalAudit.ResumeLayout(False)
        Me.ClinicalAudit.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridClinicalAudit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        Me.ToolClinicalAudit.ResumeLayout(False)
        Me.ToolClinicalAudit.PerformLayout()
        Me.CashAudit.ResumeLayout(False)
        Me.CashAudit.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolCaseAudit As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnUpdateCashAudit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteCaseAudit As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridClientCaseDropOut As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnnFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadAllCaseAudit As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintCaseDropOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ClinicalAudit As System.Windows.Forms.TabPage
    Friend WithEvents CashAudit As System.Windows.Forms.TabPage
    Friend WithEvents ToolClinicalAudit As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateClinicalAudit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteClinicalAudit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintClinicalAudit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridClinicalAudit As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents EndDateWeek As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateClinicalAuditFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFindClinicalAudit As System.Windows.Forms.Button
    Friend WithEvents TxtClinicalClientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtClinicalClientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadClinicalClientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadClinicalAuditClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadClinicalAudit As System.Windows.Forms.RadioButton
    Friend WithEvents StartDateWeek As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadClinicalAuditWeek As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnListClientAudit As System.Windows.Forms.ToolStripButton
    Friend WithEvents RadDropOut As System.Windows.Forms.RadioButton
    Friend WithEvents RadStopVisit As System.Windows.Forms.RadioButton
    Friend WithEvents BtnNewCaseAudit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblWeek As System.Windows.Forms.Label
    Friend WithEvents LblTotalReferralBTB As System.Windows.Forms.Label
    Friend WithEvents LblTotalReferralKGChnang As System.Windows.Forms.Label
    Friend WithEvents LblTotalReferralToKgCham As System.Windows.Forms.Label
    Friend WithEvents LblTotalNaro As System.Windows.Forms.Label
    Friend WithEvents LblTotalPsycology As System.Windows.Forms.Label
    Friend WithEvents LblTotalClinicAudit As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboWeekOfYear As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DateClinicalAuditTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DateYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFullYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadFullYear As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateAuditOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator

End Class
