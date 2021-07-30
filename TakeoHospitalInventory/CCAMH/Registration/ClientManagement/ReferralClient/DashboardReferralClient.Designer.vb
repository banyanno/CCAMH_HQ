<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardReferralClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardReferralClient))
        Dim GridClientReferDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridListOfRefer_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.MenuThearpist = New System.Windows.Forms.ToolStrip()
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNewRefer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNewReferTo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPrintReport = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridClientReferDetail = New Janus.Windows.GridEX.GridEX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtDateRefer = New System.Windows.Forms.TextBox()
        Me.TxtClientName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtReferTo = New System.Windows.Forms.TextBox()
        Me.TxtReferNote = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridListOfRefer = New Janus.Windows.GridEX.GridEX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.CboSearchReferral = New System.Windows.Forms.ComboBox()
        Me.RadRefer = New System.Windows.Forms.RadioButton()
        Me.TxtSearchClientName = New System.Windows.Forms.TextBox()
        Me.RadClientName = New System.Windows.Forms.RadioButton()
        Me.RadClientNo = New System.Windows.Forms.RadioButton()
        Me.DateSearchReferTo = New System.Windows.Forms.DateTimePicker()
        Me.TxtSearchClientNo = New System.Windows.Forms.TextBox()
        Me.DateSearchReferFrom = New System.Windows.Forms.DateTimePicker()
        Me.RadDateReferTo = New System.Windows.Forms.RadioButton()
        Me.MenuThearpist.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridClientReferDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridListOfRefer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuThearpist
        '
        Me.MenuThearpist.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuThearpist.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuThearpist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator4, Me.BtnNewRefer, Me.ToolStripSeparator1, Me.BtnNewReferTo, Me.ToolStripSeparator3, Me.BtnPrintReport})
        Me.MenuThearpist.Location = New System.Drawing.Point(0, 0)
        Me.MenuThearpist.Name = "MenuThearpist"
        Me.MenuThearpist.Size = New System.Drawing.Size(1384, 58)
        Me.MenuThearpist.TabIndex = 1
        Me.MenuThearpist.Text = "ToolStrip1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(107, 55)
        Me.BtnRefresh.Text = "     Refresh     "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 58)
        '
        'BtnNewRefer
        '
        Me.BtnNewRefer.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnNewRefer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnNewRefer.Image = CType(resources.GetObject("BtnNewRefer.Image"), System.Drawing.Image)
        Me.BtnNewRefer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewRefer.Name = "BtnNewRefer"
        Me.BtnNewRefer.Size = New System.Drawing.Size(123, 55)
        Me.BtnNewRefer.Text = "   New Referral   "
        Me.BtnNewRefer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'BtnNewReferTo
        '
        Me.BtnNewReferTo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnNewReferTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnNewReferTo.Image = CType(resources.GetObject("BtnNewReferTo.Image"), System.Drawing.Image)
        Me.BtnNewReferTo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewReferTo.Name = "BtnNewReferTo"
        Me.BtnNewReferTo.Size = New System.Drawing.Size(143, 55)
        Me.BtnNewReferTo.Text = "   New Referral To   "
        Me.BtnNewReferTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 58)
        '
        'BtnPrintReport
        '
        Me.BtnPrintReport.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnPrintReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPrintReport.Image = CType(resources.GetObject("BtnPrintReport.Image"), System.Drawing.Image)
        Me.BtnPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintReport.Name = "BtnPrintReport"
        Me.BtnPrintReport.Size = New System.Drawing.Size(128, 55)
        Me.BtnPrintReport.Text = "     Print Report    "
        Me.BtnPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1384, 639)
        Me.SplitContainer1.SplitterDistance = 1056
        Me.SplitContainer1.TabIndex = 2
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1056, 639)
        Me.SplitContainer2.SplitterDistance = 484
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridClientReferDetail)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1054, 482)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cllient referral detail"
        '
        'GridClientReferDetail
        '
        Me.GridClientReferDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientReferDetail.BackColor = System.Drawing.Color.White
        Me.GridClientReferDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridClientReferDetail.CardBorders = False
        GridClientReferDetail_DesignTimeLayout.LayoutString = resources.GetString("GridClientReferDetail_DesignTimeLayout.LayoutString")
        Me.GridClientReferDetail.DesignTimeLayout = GridClientReferDetail_DesignTimeLayout
        Me.GridClientReferDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientReferDetail.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GridClientReferDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientReferDetail.GroupByBoxVisible = False
        Me.GridClientReferDetail.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClientReferDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridClientReferDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClientReferDetail.Location = New System.Drawing.Point(3, 20)
        Me.GridClientReferDetail.Name = "GridClientReferDetail"
        Me.GridClientReferDetail.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom
        Me.GridClientReferDetail.RecordNavigator = True
        Me.GridClientReferDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientReferDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientReferDetail.SelectedFormatStyle.BackColor = System.Drawing.Color.Gray
        Me.GridClientReferDetail.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Gray
        Me.GridClientReferDetail.Size = New System.Drawing.Size(1048, 459)
        Me.GridClientReferDetail.TabIndex = 3
        Me.GridClientReferDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientReferDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtDateRefer)
        Me.GroupBox3.Controls.Add(Me.TxtClientName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtReferTo)
        Me.GroupBox3.Controls.Add(Me.TxtReferNote)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1054, 149)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Refer Detail"
        '
        'TxtDateRefer
        '
        Me.TxtDateRefer.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateRefer.Location = New System.Drawing.Point(193, 102)
        Me.TxtDateRefer.Name = "TxtDateRefer"
        Me.TxtDateRefer.Size = New System.Drawing.Size(133, 30)
        Me.TxtDateRefer.TabIndex = 15
        Me.TxtDateRefer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtClientName
        '
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(9, 103)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.Size = New System.Drawing.Size(169, 30)
        Me.TxtClientName.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Date Refer:"
        '
        'TxtReferTo
        '
        Me.TxtReferTo.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferTo.Location = New System.Drawing.Point(9, 47)
        Me.TxtReferTo.Name = "TxtReferTo"
        Me.TxtReferTo.Size = New System.Drawing.Size(315, 30)
        Me.TxtReferTo.TabIndex = 7
        '
        'TxtReferNote
        '
        Me.TxtReferNote.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferNote.Location = New System.Drawing.Point(332, 47)
        Me.TxtReferNote.Multiline = True
        Me.TxtReferNote.Name = "TxtReferNote"
        Me.TxtReferNote.Size = New System.Drawing.Size(317, 85)
        Me.TxtReferNote.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(332, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Refer note:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Client Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Refer To:"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer3.Size = New System.Drawing.Size(322, 637)
        Me.SplitContainer3.SplitterDistance = 313
        Me.SplitContainer3.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridListOfRefer)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 313)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Refer information"
        '
        'GridListOfRefer
        '
        Me.GridListOfRefer.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridListOfRefer.BackColor = System.Drawing.Color.White
        Me.GridListOfRefer.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridListOfRefer_DesignTimeLayout.LayoutString = resources.GetString("GridListOfRefer_DesignTimeLayout.LayoutString")
        Me.GridListOfRefer.DesignTimeLayout = GridListOfRefer_DesignTimeLayout
        Me.GridListOfRefer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridListOfRefer.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridListOfRefer.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridListOfRefer.GroupByBoxVisible = False
        Me.GridListOfRefer.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridListOfRefer.HeaderFormatStyle.FontSize = 11.0!
        Me.GridListOfRefer.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GridListOfRefer.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridListOfRefer.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridListOfRefer.Location = New System.Drawing.Point(3, 20)
        Me.GridListOfRefer.Name = "GridListOfRefer"
        Me.GridListOfRefer.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom
        Me.GridListOfRefer.RecordNavigator = True
        Me.GridListOfRefer.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridListOfRefer.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridListOfRefer.Size = New System.Drawing.Size(316, 290)
        Me.GridListOfRefer.TabIndex = 24
        Me.GridListOfRefer.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridListOfRefer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnFind)
        Me.GroupBox4.Controls.Add(Me.CboSearchReferral)
        Me.GroupBox4.Controls.Add(Me.RadRefer)
        Me.GroupBox4.Controls.Add(Me.TxtSearchClientName)
        Me.GroupBox4.Controls.Add(Me.RadClientName)
        Me.GroupBox4.Controls.Add(Me.RadClientNo)
        Me.GroupBox4.Controls.Add(Me.DateSearchReferTo)
        Me.GroupBox4.Controls.Add(Me.TxtSearchClientNo)
        Me.GroupBox4.Controls.Add(Me.DateSearchReferFrom)
        Me.GroupBox4.Controls.Add(Me.RadDateReferTo)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(322, 320)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Find more referral"
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.Maroon
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatAppearance.BorderSize = 0
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(2, 274)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(314, 42)
        Me.BtnFind.TabIndex = 18
        Me.BtnFind.Text = "Finding"
        Me.BtnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'CboSearchReferral
        '
        Me.CboSearchReferral.Enabled = False
        Me.CboSearchReferral.FormattingEnabled = True
        Me.CboSearchReferral.Location = New System.Drawing.Point(3, 242)
        Me.CboSearchReferral.Name = "CboSearchReferral"
        Me.CboSearchReferral.Size = New System.Drawing.Size(313, 26)
        Me.CboSearchReferral.TabIndex = 17
        '
        'RadRefer
        '
        Me.RadRefer.AutoSize = True
        Me.RadRefer.Location = New System.Drawing.Point(3, 213)
        Me.RadRefer.Name = "RadRefer"
        Me.RadRefer.Size = New System.Drawing.Size(144, 22)
        Me.RadRefer.TabIndex = 16
        Me.RadRefer.Text = "Select By Referral"
        Me.RadRefer.UseVisualStyleBackColor = True
        '
        'TxtSearchClientName
        '
        Me.TxtSearchClientName.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchClientName.Location = New System.Drawing.Point(3, 176)
        Me.TxtSearchClientName.Name = "TxtSearchClientName"
        Me.TxtSearchClientName.Size = New System.Drawing.Size(313, 30)
        Me.TxtSearchClientName.TabIndex = 15
        '
        'RadClientName
        '
        Me.RadClientName.AutoSize = True
        Me.RadClientName.Location = New System.Drawing.Point(3, 146)
        Me.RadClientName.Name = "RadClientName"
        Me.RadClientName.Size = New System.Drawing.Size(137, 22)
        Me.RadClientName.TabIndex = 14
        Me.RadClientName.Text = "Client Name Eng"
        Me.RadClientName.UseVisualStyleBackColor = True
        '
        'RadClientNo
        '
        Me.RadClientNo.AutoSize = True
        Me.RadClientNo.Location = New System.Drawing.Point(6, 82)
        Me.RadClientNo.Name = "RadClientNo"
        Me.RadClientNo.Size = New System.Drawing.Size(91, 22)
        Me.RadClientNo.TabIndex = 5
        Me.RadClientNo.Text = "Client No:"
        Me.RadClientNo.UseVisualStyleBackColor = True
        '
        'DateSearchReferTo
        '
        Me.DateSearchReferTo.Checked = False
        Me.DateSearchReferTo.CustomFormat = "dd/MM/yyyy"
        Me.DateSearchReferTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateSearchReferTo.Location = New System.Drawing.Point(164, 52)
        Me.DateSearchReferTo.Name = "DateSearchReferTo"
        Me.DateSearchReferTo.Size = New System.Drawing.Size(152, 24)
        Me.DateSearchReferTo.TabIndex = 4
        '
        'TxtSearchClientNo
        '
        Me.TxtSearchClientNo.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchClientNo.Location = New System.Drawing.Point(3, 110)
        Me.TxtSearchClientNo.Name = "TxtSearchClientNo"
        Me.TxtSearchClientNo.Size = New System.Drawing.Size(313, 30)
        Me.TxtSearchClientNo.TabIndex = 13
        '
        'DateSearchReferFrom
        '
        Me.DateSearchReferFrom.Checked = False
        Me.DateSearchReferFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateSearchReferFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateSearchReferFrom.Location = New System.Drawing.Point(6, 52)
        Me.DateSearchReferFrom.Name = "DateSearchReferFrom"
        Me.DateSearchReferFrom.Size = New System.Drawing.Size(152, 24)
        Me.DateSearchReferFrom.TabIndex = 3
        '
        'RadDateReferTo
        '
        Me.RadDateReferTo.AutoSize = True
        Me.RadDateReferTo.Checked = True
        Me.RadDateReferTo.Location = New System.Drawing.Point(6, 23)
        Me.RadDateReferTo.Name = "RadDateReferTo"
        Me.RadDateReferTo.Size = New System.Drawing.Size(130, 22)
        Me.RadDateReferTo.TabIndex = 0
        Me.RadDateReferTo.TabStop = True
        Me.RadDateReferTo.Text = "Date Referral to"
        Me.RadDateReferTo.UseVisualStyleBackColor = True
        '
        'DashboardReferralClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuThearpist)
        Me.Name = "DashboardReferralClient"
        Me.Size = New System.Drawing.Size(1384, 697)
        Me.MenuThearpist.ResumeLayout(False)
        Me.MenuThearpist.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridClientReferDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridListOfRefer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuThearpist As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewRefer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewReferTo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridListOfRefer As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents CboSearchReferral As System.Windows.Forms.ComboBox
    Friend WithEvents RadRefer As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSearchClientName As System.Windows.Forms.TextBox
    Friend WithEvents RadClientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents DateSearchReferTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtSearchClientNo As System.Windows.Forms.TextBox
    Friend WithEvents DateSearchReferFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadDateReferTo As System.Windows.Forms.RadioButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridClientReferDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDateRefer As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtReferTo As System.Windows.Forms.TextBox
    Friend WithEvents TxtReferNote As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintReport As System.Windows.Forms.ToolStripButton

End Class
