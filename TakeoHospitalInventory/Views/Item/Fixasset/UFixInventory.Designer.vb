<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UFixInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UFixInventory))
        Dim GridFixAsset_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridAssetCheck_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUpdateFixAsset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDeleteAsset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewAsset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNewCheckAsset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnFindAsset = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CRVFixAsset = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridFixAsset = New Janus.Windows.GridEX.GridEX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GridAssetCheck = New Janus.Windows.GridEX.GridEX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CboDepartment = New System.Windows.Forms.ComboBox()
        Me.ChSelectStatus = New System.Windows.Forms.CheckBox()
        Me.ChByWithoutDate = New System.Windows.Forms.CheckBox()
        Me.CboAssetStatus = New System.Windows.Forms.ComboBox()
        Me.DateSelect = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadSelectByDepartment = New System.Windows.Forms.RadioButton()
        Me.RadAllStatus = New System.Windows.Forms.RadioButton()
        Me.BtnPrintPreview = New System.Windows.Forms.Button()
        Me.DateBuyTo = New System.Windows.Forms.DateTimePicker()
        Me.DateBuyFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TreeDepartment = New System.Windows.Forms.TreeView()
        Me.Error1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DToDiposal = New System.Windows.Forms.DateTimePicker()
        Me.DFromDiposal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupDisposal = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridFixAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridAssetCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDisposal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.BtnUpdateFixAsset, Me.ToolStripSeparator2, Me.BtnDeleteAsset, Me.ToolStripSeparator3, Me.ViewAsset, Me.ToolStripSeparator5, Me.BtnNewCheckAsset, Me.ToolStripSeparator4, Me.BtnFindAsset})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1449, 58)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(110, 55)
        Me.ToolStripButton1.Text = "New Fix Asset"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'BtnUpdateFixAsset
        '
        Me.BtnUpdateFixAsset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdateFixAsset.Image = CType(resources.GetObject("BtnUpdateFixAsset.Image"), System.Drawing.Image)
        Me.BtnUpdateFixAsset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateFixAsset.Name = "BtnUpdateFixAsset"
        Me.BtnUpdateFixAsset.Size = New System.Drawing.Size(128, 55)
        Me.BtnUpdateFixAsset.Text = "Update Fix Asset"
        Me.BtnUpdateFixAsset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'BtnDeleteAsset
        '
        Me.BtnDeleteAsset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteAsset.Image = CType(resources.GetObject("BtnDeleteAsset.Image"), System.Drawing.Image)
        Me.BtnDeleteAsset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteAsset.Name = "BtnDeleteAsset"
        Me.BtnDeleteAsset.Size = New System.Drawing.Size(91, 55)
        Me.BtnDeleteAsset.Text = "Delet Asset"
        Me.BtnDeleteAsset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 58)
        '
        'ViewAsset
        '
        Me.ViewAsset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewAsset.Image = CType(resources.GetObject("ViewAsset.Image"), System.Drawing.Image)
        Me.ViewAsset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewAsset.Name = "ViewAsset"
        Me.ViewAsset.Size = New System.Drawing.Size(111, 55)
        Me.ViewAsset.Text = "View All Asset"
        Me.ViewAsset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 58)
        '
        'BtnNewCheckAsset
        '
        Me.BtnNewCheckAsset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNewCheckAsset.Image = CType(resources.GetObject("BtnNewCheckAsset.Image"), System.Drawing.Image)
        Me.BtnNewCheckAsset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewCheckAsset.Name = "BtnNewCheckAsset"
        Me.BtnNewCheckAsset.Size = New System.Drawing.Size(133, 55)
        Me.BtnNewCheckAsset.Text = "New Check Asset"
        Me.BtnNewCheckAsset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 58)
        '
        'BtnFindAsset
        '
        Me.BtnFindAsset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFindAsset.Image = CType(resources.GetObject("BtnFindAsset.Image"), System.Drawing.Image)
        Me.BtnFindAsset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFindAsset.Name = "BtnFindAsset"
        Me.BtnFindAsset.Size = New System.Drawing.Size(109, 55)
        Me.BtnFindAsset.Text = "   Find Asset   "
        Me.BtnFindAsset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CRVFixAsset)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1449, 817)
        Me.SplitContainer1.SplitterDistance = 1179
        Me.SplitContainer1.TabIndex = 1
        '
        'CRVFixAsset
        '
        Me.CRVFixAsset.ActiveViewIndex = -1
        Me.CRVFixAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVFixAsset.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVFixAsset.Location = New System.Drawing.Point(825, 22)
        Me.CRVFixAsset.Name = "CRVFixAsset"
        Me.CRVFixAsset.SelectionFormula = ""
        Me.CRVFixAsset.Size = New System.Drawing.Size(316, 613)
        Me.CRVFixAsset.TabIndex = 1
        Me.CRVFixAsset.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRVFixAsset.ViewTimeSelectionFormula = ""
        Me.CRVFixAsset.Visible = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 22)
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
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(880, 666)
        Me.SplitContainer2.SplitterDistance = 489
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridFixAsset)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(880, 666)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Products"
        '
        'GridFixAsset
        '
        GridFixAsset_DesignTimeLayout.LayoutString = resources.GetString("GridFixAsset_DesignTimeLayout.LayoutString")
        Me.GridFixAsset.DesignTimeLayout = GridFixAsset_DesignTimeLayout
        Me.GridFixAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFixAsset.DynamicFiltering = True
        Me.GridFixAsset.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridFixAsset.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridFixAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GridFixAsset.GroupByBoxVisible = False
        Me.GridFixAsset.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridFixAsset.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridFixAsset.Location = New System.Drawing.Point(3, 22)
        Me.GridFixAsset.Name = "GridFixAsset"
        Me.GridFixAsset.RecordNavigator = True
        Me.GridFixAsset.Size = New System.Drawing.Size(874, 641)
        Me.GridFixAsset.TabIndex = 0
        Me.GridFixAsset.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridAssetCheck)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 46)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Check List Detail"
        '
        'GridAssetCheck
        '
        GridAssetCheck_DesignTimeLayout.LayoutString = resources.GetString("GridAssetCheck_DesignTimeLayout.LayoutString")
        Me.GridAssetCheck.DesignTimeLayout = GridAssetCheck_DesignTimeLayout
        Me.GridAssetCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAssetCheck.GroupByBoxVisible = False
        Me.GridAssetCheck.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridAssetCheck.Location = New System.Drawing.Point(3, 22)
        Me.GridAssetCheck.Name = "GridAssetCheck"
        Me.GridAssetCheck.RecordNavigator = True
        Me.GridAssetCheck.Size = New System.Drawing.Size(144, 21)
        Me.GridAssetCheck.TabIndex = 1
        Me.GridAssetCheck.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Splitter1)
        Me.GroupBox1.Controls.Add(Me.TreeDepartment)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 817)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of location"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupDisposal)
        Me.GroupBox4.Controls.Add(Me.CboDepartment)
        Me.GroupBox4.Controls.Add(Me.ChSelectStatus)
        Me.GroupBox4.Controls.Add(Me.ChByWithoutDate)
        Me.GroupBox4.Controls.Add(Me.CboAssetStatus)
        Me.GroupBox4.Controls.Add(Me.DateSelect)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.RadSelectByDepartment)
        Me.GroupBox4.Controls.Add(Me.RadAllStatus)
        Me.GroupBox4.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox4.Controls.Add(Me.DateBuyTo)
        Me.GroupBox4.Controls.Add(Me.DateBuyFrom)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 223)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(260, 591)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fix Asset Report"
        '
        'CboDepartment
        '
        Me.CboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDepartment.Enabled = False
        Me.CboDepartment.FormattingEnabled = True
        Me.CboDepartment.Location = New System.Drawing.Point(8, 134)
        Me.CboDepartment.Name = "CboDepartment"
        Me.CboDepartment.Size = New System.Drawing.Size(239, 28)
        Me.CboDepartment.TabIndex = 1
        '
        'ChSelectStatus
        '
        Me.ChSelectStatus.AutoSize = True
        Me.ChSelectStatus.Location = New System.Drawing.Point(8, 167)
        Me.ChSelectStatus.Name = "ChSelectStatus"
        Me.ChSelectStatus.Size = New System.Drawing.Size(124, 24)
        Me.ChSelectStatus.TabIndex = 8
        Me.ChSelectStatus.Text = "Select Status"
        Me.ChSelectStatus.UseVisualStyleBackColor = True
        '
        'ChByWithoutDate
        '
        Me.ChByWithoutDate.AutoSize = True
        Me.ChByWithoutDate.Checked = True
        Me.ChByWithoutDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChByWithoutDate.Location = New System.Drawing.Point(6, 362)
        Me.ChByWithoutDate.Name = "ChByWithoutDate"
        Me.ChByWithoutDate.Size = New System.Drawing.Size(206, 24)
        Me.ChByWithoutDate.TabIndex = 14
        Me.ChByWithoutDate.Text = "View all without Buy Date"
        Me.ChByWithoutDate.UseVisualStyleBackColor = True
        '
        'CboAssetStatus
        '
        Me.CboAssetStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAssetStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAssetStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAssetStatus.DropDownWidth = 350
        Me.CboAssetStatus.Enabled = False
        Me.CboAssetStatus.FormattingEnabled = True
        Me.CboAssetStatus.Items.AddRange(New Object() {"", "ACTUAL", "DISPOSAL"})
        Me.CboAssetStatus.Location = New System.Drawing.Point(8, 193)
        Me.CboAssetStatus.Name = "CboAssetStatus"
        Me.CboAssetStatus.Size = New System.Drawing.Size(239, 28)
        Me.CboAssetStatus.TabIndex = 7
        '
        'DateSelect
        '
        Me.DateSelect.Checked = False
        Me.DateSelect.CustomFormat = "yyyy"
        Me.DateSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateSelect.Location = New System.Drawing.Point(8, 48)
        Me.DateSelect.Name = "DateSelect"
        Me.DateSelect.ShowCheckBox = True
        Me.DateSelect.Size = New System.Drawing.Size(237, 26)
        Me.DateSelect.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Select  Year for do report:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date Buy from:"
        '
        'RadSelectByDepartment
        '
        Me.RadSelectByDepartment.AutoSize = True
        Me.RadSelectByDepartment.Location = New System.Drawing.Point(8, 110)
        Me.RadSelectByDepartment.Name = "RadSelectByDepartment"
        Me.RadSelectByDepartment.Size = New System.Drawing.Size(137, 24)
        Me.RadSelectByDepartment.TabIndex = 9
        Me.RadSelectByDepartment.Text = "Select Location"
        Me.RadSelectByDepartment.UseVisualStyleBackColor = True
        '
        'RadAllStatus
        '
        Me.RadAllStatus.AutoSize = True
        Me.RadAllStatus.Checked = True
        Me.RadAllStatus.Location = New System.Drawing.Point(8, 80)
        Me.RadAllStatus.Name = "RadAllStatus"
        Me.RadAllStatus.Size = New System.Drawing.Size(187, 24)
        Me.RadAllStatus.TabIndex = 8
        Me.RadAllStatus.TabStop = True
        Me.RadAllStatus.Text = "Select Asset all Status"
        Me.RadAllStatus.UseVisualStyleBackColor = True
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.Location = New System.Drawing.Point(6, 499)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(237, 46)
        Me.BtnPrintPreview.TabIndex = 6
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'DateBuyTo
        '
        Me.DateBuyTo.Checked = False
        Me.DateBuyTo.CustomFormat = "dd/MM/yyyy"
        Me.DateBuyTo.Enabled = False
        Me.DateBuyTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateBuyTo.Location = New System.Drawing.Point(6, 467)
        Me.DateBuyTo.Name = "DateBuyTo"
        Me.DateBuyTo.ShowCheckBox = True
        Me.DateBuyTo.Size = New System.Drawing.Size(237, 26)
        Me.DateBuyTo.TabIndex = 5
        '
        'DateBuyFrom
        '
        Me.DateBuyFrom.Checked = False
        Me.DateBuyFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateBuyFrom.Enabled = False
        Me.DateBuyFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateBuyFrom.Location = New System.Drawing.Point(6, 412)
        Me.DateBuyFrom.Name = "DateBuyFrom"
        Me.DateBuyFrom.ShowCheckBox = True
        Me.DateBuyFrom.Size = New System.Drawing.Size(237, 26)
        Me.DateBuyFrom.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 443)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date Buy  to:"
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(3, 213)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(260, 10)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'TreeDepartment
        '
        Me.TreeDepartment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TreeDepartment.Dock = System.Windows.Forms.DockStyle.Top
        Me.TreeDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeDepartment.ForeColor = System.Drawing.Color.Blue
        Me.TreeDepartment.FullRowSelect = True
        Me.TreeDepartment.HideSelection = False
        Me.TreeDepartment.Indent = 21
        Me.TreeDepartment.ItemHeight = 28
        Me.TreeDepartment.Location = New System.Drawing.Point(3, 22)
        Me.TreeDepartment.Name = "TreeDepartment"
        Me.TreeDepartment.Size = New System.Drawing.Size(260, 191)
        Me.TreeDepartment.TabIndex = 0
        '
        'Error1
        '
        Me.Error1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Disposal From:"
        '
        'DToDiposal
        '
        Me.DToDiposal.Checked = False
        Me.DToDiposal.CustomFormat = "dd/MM/yyyy"
        Me.DToDiposal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DToDiposal.Location = New System.Drawing.Point(6, 100)
        Me.DToDiposal.Name = "DToDiposal"
        Me.DToDiposal.ShowCheckBox = True
        Me.DToDiposal.Size = New System.Drawing.Size(225, 26)
        Me.DToDiposal.TabIndex = 17
        '
        'DFromDiposal
        '
        Me.DFromDiposal.Checked = False
        Me.DFromDiposal.CustomFormat = "dd/MM/yyyy"
        Me.DFromDiposal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFromDiposal.Location = New System.Drawing.Point(6, 45)
        Me.DFromDiposal.Name = "DFromDiposal"
        Me.DFromDiposal.ShowCheckBox = True
        Me.DFromDiposal.Size = New System.Drawing.Size(225, 26)
        Me.DFromDiposal.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Disposal To:"
        '
        'GroupDisposal
        '
        Me.GroupDisposal.Controls.Add(Me.Label1)
        Me.GroupDisposal.Controls.Add(Me.DToDiposal)
        Me.GroupDisposal.Controls.Add(Me.Label5)
        Me.GroupDisposal.Controls.Add(Me.DFromDiposal)
        Me.GroupDisposal.Enabled = False
        Me.GroupDisposal.Location = New System.Drawing.Point(6, 222)
        Me.GroupDisposal.Name = "GroupDisposal"
        Me.GroupDisposal.Size = New System.Drawing.Size(237, 137)
        Me.GroupDisposal.TabIndex = 2
        Me.GroupDisposal.TabStop = False
        Me.GroupDisposal.Text = "Date Disposal:"
        '
        'UFixInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UFixInventory"
        Me.Size = New System.Drawing.Size(1449, 875)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridFixAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridAssetCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDisposal.ResumeLayout(False)
        Me.GroupDisposal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TreeDepartment As System.Windows.Forms.TreeView
    Friend WithEvents GridFixAsset As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridAssetCheck As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateFixAsset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteAsset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewAsset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewCheckAsset As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents DateBuyTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateBuyFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents CRVFixAsset As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Error1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFindAsset As System.Windows.Forms.ToolStripButton
    Friend WithEvents CboAssetStatus As System.Windows.Forms.ComboBox
    Friend WithEvents RadAllStatus As System.Windows.Forms.RadioButton
    Friend WithEvents RadSelectByDepartment As System.Windows.Forms.RadioButton
    Friend WithEvents ChSelectStatus As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateSelect As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChByWithoutDate As System.Windows.Forms.CheckBox
    Friend WithEvents GroupDisposal As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DToDiposal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DFromDiposal As System.Windows.Forms.DateTimePicker

End Class
