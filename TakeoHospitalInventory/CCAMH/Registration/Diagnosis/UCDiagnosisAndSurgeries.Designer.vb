<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDiagnosisAndSurgeries
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridDiagnosisCategory_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDiagnosisAndSurgeries))
        Dim GridDiagnosis_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridDiagnosisCategory = New Janus.Windows.GridEX.GridEX
        Me.GridDiagnosis = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridSubDiagnosis = New System.Windows.Forms.DataGridView
        Me.SSID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SID1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SurgerySub = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Code1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextDeleteSubDiagnosis = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSubDiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnNewSurgeries = New System.Windows.Forms.Button
        Me.BtnFindSurgeries = New System.Windows.Forms.Button
        Me.GridSurgeries = New System.Windows.Forms.DataGridView
        Me.TypeSID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Surgeries = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SurgeriesFee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeSurgeries = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SurgDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuSurgeries = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtSurgeries = New System.Windows.Forms.TextBox
        Me.ContextSubDiagnosis = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateSubDiagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteDiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridDiagnosisCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridSubDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextDeleteSubDiagnosis.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridSurgeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuSurgeries.SuspendLayout()
        Me.ContextSubDiagnosis.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(993, 814)
        Me.SplitContainer1.SplitterDistance = 525
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(993, 814)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Diagnosis"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SplitContainer2)
        Me.GroupBox3.Controls.Add(Me.ToolStrip1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(987, 795)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 68)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridDiagnosisCategory)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GridDiagnosis)
        Me.SplitContainer2.Size = New System.Drawing.Size(981, 724)
        Me.SplitContainer2.SplitterDistance = 466
        Me.SplitContainer2.TabIndex = 4
        '
        'GridDiagnosisCategory
        '
        Me.GridDiagnosisCategory.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDiagnosisCategory.BackColor = System.Drawing.Color.White
        Me.GridDiagnosisCategory.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridDiagnosisCategory.CardBorders = False
        GridDiagnosisCategory_DesignTimeLayout.LayoutString = resources.GetString("GridDiagnosisCategory_DesignTimeLayout.LayoutString")
        Me.GridDiagnosisCategory.DesignTimeLayout = GridDiagnosisCategory_DesignTimeLayout
        Me.GridDiagnosisCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiagnosisCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GridDiagnosisCategory.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridDiagnosisCategory.GroupByBoxVisible = False
        Me.GridDiagnosisCategory.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridDiagnosisCategory.Location = New System.Drawing.Point(0, 0)
        Me.GridDiagnosisCategory.Name = "GridDiagnosisCategory"
        Me.GridDiagnosisCategory.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Black
        Me.GridDiagnosisCategory.RecordNavigator = True
        Me.GridDiagnosisCategory.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridDiagnosisCategory.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDiagnosisCategory.Size = New System.Drawing.Size(464, 722)
        Me.GridDiagnosisCategory.TabIndex = 3
        Me.GridDiagnosisCategory.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridDiagnosisCategory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GridDiagnosis
        '
        Me.GridDiagnosis.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDiagnosis.BackColor = System.Drawing.Color.White
        Me.GridDiagnosis.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridDiagnosis.CardBorders = False
        GridDiagnosis_DesignTimeLayout.LayoutString = resources.GetString("GridDiagnosis_DesignTimeLayout.LayoutString")
        Me.GridDiagnosis.DesignTimeLayout = GridDiagnosis_DesignTimeLayout
        Me.GridDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GridDiagnosis.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridDiagnosis.GroupByBoxVisible = False
        Me.GridDiagnosis.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridDiagnosis.Location = New System.Drawing.Point(0, 0)
        Me.GridDiagnosis.Name = "GridDiagnosis"
        Me.GridDiagnosis.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Black
        Me.GridDiagnosis.RecordNavigator = True
        Me.GridDiagnosis.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridDiagnosis.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDiagnosis.Size = New System.Drawing.Size(509, 722)
        Me.GridDiagnosis.TabIndex = 3
        Me.GridDiagnosis.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridDiagnosis.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(981, 52)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(80, 49)
        Me.BtnRefresh.Text = "     Refresh     "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(167, 49)
        Me.ToolStripButton1.Text = "     New Category Diagnosis    "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(119, 49)
        Me.ToolStripButton2.Text = "     New Diagnosis     "
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridSubDiagnosis)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(987, 795)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sub Diagnosis"
        Me.GroupBox4.Visible = False
        '
        'GridSubDiagnosis
        '
        Me.GridSubDiagnosis.AllowUserToAddRows = False
        Me.GridSubDiagnosis.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridSubDiagnosis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.GridSubDiagnosis.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridSubDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridSubDiagnosis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GridSubDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSubDiagnosis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SSID, Me.SID1, Me.SurgerySub, Me.Description1, Me.Code1})
        Me.GridSubDiagnosis.ContextMenuStrip = Me.ContextDeleteSubDiagnosis
        Me.GridSubDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSubDiagnosis.Location = New System.Drawing.Point(3, 16)
        Me.GridSubDiagnosis.MultiSelect = False
        Me.GridSubDiagnosis.Name = "GridSubDiagnosis"
        Me.GridSubDiagnosis.ReadOnly = True
        Me.GridSubDiagnosis.RowHeadersWidth = 50
        Me.GridSubDiagnosis.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSubDiagnosis.RowTemplate.Height = 35
        Me.GridSubDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridSubDiagnosis.Size = New System.Drawing.Size(981, 776)
        Me.GridSubDiagnosis.TabIndex = 0
        '
        'SSID
        '
        Me.SSID.DataPropertyName = "SSID"
        Me.SSID.HeaderText = "SSID"
        Me.SSID.Name = "SSID"
        Me.SSID.ReadOnly = True
        Me.SSID.Visible = False
        '
        'SID1
        '
        Me.SID1.DataPropertyName = "SID"
        Me.SID1.HeaderText = "SID"
        Me.SID1.Name = "SID1"
        Me.SID1.ReadOnly = True
        Me.SID1.Visible = False
        '
        'SurgerySub
        '
        Me.SurgerySub.DataPropertyName = "SurgerySub"
        Me.SurgerySub.HeaderText = "Sub Diagnosis"
        Me.SurgerySub.Name = "SurgerySub"
        Me.SurgerySub.ReadOnly = True
        Me.SurgerySub.Width = 200
        '
        'Description1
        '
        Me.Description1.DataPropertyName = "Description"
        Me.Description1.HeaderText = "Description"
        Me.Description1.Name = "Description1"
        Me.Description1.ReadOnly = True
        Me.Description1.Width = 150
        '
        'Code1
        '
        Me.Code1.DataPropertyName = "Code"
        Me.Code1.HeaderText = "Code"
        Me.Code1.Name = "Code1"
        Me.Code1.ReadOnly = True
        '
        'ContextDeleteSubDiagnosis
        '
        Me.ContextDeleteSubDiagnosis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSubDiagnosisToolStripMenuItem})
        Me.ContextDeleteSubDiagnosis.Name = "ContextDeleteSubDiagnosis"
        Me.ContextDeleteSubDiagnosis.Size = New System.Drawing.Size(185, 26)
        '
        'DeleteSubDiagnosisToolStripMenuItem
        '
        Me.DeleteSubDiagnosisToolStripMenuItem.Name = "DeleteSubDiagnosisToolStripMenuItem"
        Me.DeleteSubDiagnosisToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DeleteSubDiagnosisToolStripMenuItem.Text = "Delete Sub Diagnosis"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnNewSurgeries)
        Me.GroupBox2.Controls.Add(Me.BtnFindSurgeries)
        Me.GroupBox2.Controls.Add(Me.GridSurgeries)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtSurgeries)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Surgeries Type:"
        '
        'BtnNewSurgeries
        '
        Me.BtnNewSurgeries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewSurgeries.Location = New System.Drawing.Point(349, 48)
        Me.BtnNewSurgeries.Name = "BtnNewSurgeries"
        Me.BtnNewSurgeries.Size = New System.Drawing.Size(93, 35)
        Me.BtnNewSurgeries.TabIndex = 2
        Me.BtnNewSurgeries.Text = "New &Surgeries"
        Me.BtnNewSurgeries.UseVisualStyleBackColor = True
        '
        'BtnFindSurgeries
        '
        Me.BtnFindSurgeries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindSurgeries.Location = New System.Drawing.Point(277, 48)
        Me.BtnFindSurgeries.Name = "BtnFindSurgeries"
        Me.BtnFindSurgeries.Size = New System.Drawing.Size(66, 35)
        Me.BtnFindSurgeries.TabIndex = 1
        Me.BtnFindSurgeries.Text = "Fi&nd"
        Me.BtnFindSurgeries.UseVisualStyleBackColor = True
        '
        'GridSurgeries
        '
        Me.GridSurgeries.AllowUserToAddRows = False
        Me.GridSurgeries.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridSurgeries.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridSurgeries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSurgeries.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridSurgeries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridSurgeries.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridSurgeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSurgeries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeSID, Me.Surgeries, Me.SurgeriesFee, Me.TypeSurgeries, Me.SurgDescription})
        Me.GridSurgeries.ContextMenuStrip = Me.ContextMenuSurgeries
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridSurgeries.DefaultCellStyle = DataGridViewCellStyle10
        Me.GridSurgeries.Location = New System.Drawing.Point(7, 105)
        Me.GridSurgeries.Name = "GridSurgeries"
        Me.GridSurgeries.ReadOnly = True
        Me.GridSurgeries.RowHeadersWidth = 50
        Me.GridSurgeries.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSurgeries.RowTemplate.Height = 35
        Me.GridSurgeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridSurgeries.Size = New System.Drawing.Size(83, 0)
        Me.GridSurgeries.TabIndex = 3
        '
        'TypeSID
        '
        Me.TypeSID.DataPropertyName = "SID"
        Me.TypeSID.HeaderText = "No"
        Me.TypeSID.Name = "TypeSID"
        Me.TypeSID.ReadOnly = True
        Me.TypeSID.Visible = False
        Me.TypeSID.Width = 50
        '
        'Surgeries
        '
        Me.Surgeries.DataPropertyName = "Surgeries"
        Me.Surgeries.HeaderText = "Surgeries"
        Me.Surgeries.Name = "Surgeries"
        Me.Surgeries.ReadOnly = True
        Me.Surgeries.Width = 200
        '
        'SurgeriesFee
        '
        Me.SurgeriesFee.DataPropertyName = "SurgeriesFee"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SurgeriesFee.DefaultCellStyle = DataGridViewCellStyle9
        Me.SurgeriesFee.HeaderText = "Surgery Price"
        Me.SurgeriesFee.Name = "SurgeriesFee"
        Me.SurgeriesFee.ReadOnly = True
        Me.SurgeriesFee.Width = 250
        '
        'TypeSurgeries
        '
        Me.TypeSurgeries.DataPropertyName = "Type"
        Me.TypeSurgeries.HeaderText = "Type Other"
        Me.TypeSurgeries.Name = "TypeSurgeries"
        Me.TypeSurgeries.ReadOnly = True
        Me.TypeSurgeries.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TypeSurgeries.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TypeSurgeries.Visible = False
        Me.TypeSurgeries.Width = 150
        '
        'SurgDescription
        '
        Me.SurgDescription.DataPropertyName = "Description"
        Me.SurgDescription.HeaderText = "Description"
        Me.SurgDescription.Name = "SurgDescription"
        Me.SurgDescription.ReadOnly = True
        Me.SurgDescription.Width = 300
        '
        'ContextMenuSurgeries
        '
        Me.ContextMenuSurgeries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ContextMenuSurgeries.Name = "ContextDeleteSubDiagnosis"
        Me.ContextMenuSurgeries.Size = New System.Drawing.Size(108, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem2.Text = "Delete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Surgeries Type:"
        '
        'TxtSurgeries
        '
        Me.TxtSurgeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurgeries.Location = New System.Drawing.Point(93, 57)
        Me.TxtSurgeries.Name = "TxtSurgeries"
        Me.TxtSurgeries.Size = New System.Drawing.Size(170, 26)
        Me.TxtSurgeries.TabIndex = 0
        '
        'ContextSubDiagnosis
        '
        Me.ContextSubDiagnosis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateSubDiagToolStripMenuItem, Me.ToolStripMenuItem1, Me.DeleteDiagnosisToolStripMenuItem})
        Me.ContextSubDiagnosis.Name = "ContextSubDiagnosis"
        Me.ContextSubDiagnosis.Size = New System.Drawing.Size(195, 54)
        '
        'CreateSubDiagToolStripMenuItem
        '
        Me.CreateSubDiagToolStripMenuItem.Name = "CreateSubDiagToolStripMenuItem"
        Me.CreateSubDiagToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CreateSubDiagToolStripMenuItem.Text = "Create Sub Diagnosis..."
        Me.CreateSubDiagToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(191, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'DeleteDiagnosisToolStripMenuItem
        '
        Me.DeleteDiagnosisToolStripMenuItem.Name = "DeleteDiagnosisToolStripMenuItem"
        Me.DeleteDiagnosisToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DeleteDiagnosisToolStripMenuItem.Text = "Delete Diagnosis"
        '
        'UCDiagnosisAndSurgeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCDiagnosisAndSurgeries"
        Me.Size = New System.Drawing.Size(993, 814)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridDiagnosisCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridSubDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextDeleteSubDiagnosis.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridSurgeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuSurgeries.ResumeLayout(False)
        Me.ContextSubDiagnosis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridSubDiagnosis As System.Windows.Forms.DataGridView
    Friend WithEvents ContextSubDiagnosis As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CreateSubDiagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteDiagnosisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextDeleteSubDiagnosis As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSubDiagnosisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurgerySub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Code1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridSurgeries As System.Windows.Forms.DataGridView
    Friend WithEvents BtnNewSurgeries As System.Windows.Forms.Button
    Friend WithEvents BtnFindSurgeries As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSurgeries As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuSurgeries As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypeSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surgeries As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurgeriesFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeSurgeries As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SurgDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridDiagnosisCategory As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridDiagnosis As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
