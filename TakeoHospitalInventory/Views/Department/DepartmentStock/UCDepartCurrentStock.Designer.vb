<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDepartCurrentStock
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
        Dim gridDepartItems_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDepartCurrentStock))
        Dim gridItemUsed_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gridDepartItems = New Janus.Windows.GridEX.GridEX()
        Me.PictItem = New System.Windows.Forms.PictureBox()
        Me.lbLocaInCabi = New System.Windows.Forms.Label()
        Me.gridItemUsed = New Janus.Windows.GridEX.GridEX()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbItem = New System.Windows.Forms.ComboBox()
        Me.dptToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dptFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.BtnNewInhouseUsed = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnInitialItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnAdjustStock = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUsedItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnRefreshData = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUseTemplet = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnViewHistory = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.CRVItemMonthlyUsed = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridDepartItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItemUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridItemUsed)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Search)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1610, 628)
        Me.SplitContainer1.SplitterDistance = 874
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gridDepartItems)
        Me.GroupBox1.Controls.Add(Me.PictItem)
        Me.GroupBox1.Controls.Add(Me.lbLocaInCabi)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(874, 628)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'gridDepartItems
        '
        Me.gridDepartItems.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridDepartItems_DesignTimeLayout.LayoutString = resources.GetString("gridDepartItems_DesignTimeLayout.LayoutString")
        Me.gridDepartItems.DesignTimeLayout = gridDepartItems_DesignTimeLayout
        Me.gridDepartItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDepartItems.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.gridDepartItems.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.gridDepartItems.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.gridDepartItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridDepartItems.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridDepartItems.GroupByBoxVisible = False
        Me.gridDepartItems.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.gridDepartItems.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridDepartItems.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridDepartItems.Location = New System.Drawing.Point(3, 45)
        Me.gridDepartItems.Name = "gridDepartItems"
        Me.gridDepartItems.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Silver
        Me.gridDepartItems.OfficeCustomColor = System.Drawing.SystemColors.Control
        Me.gridDepartItems.RecordNavigator = True
        Me.gridDepartItems.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridDepartItems.Size = New System.Drawing.Size(868, 580)
        Me.gridDepartItems.TabIndex = 13
        Me.gridDepartItems.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.gridDepartItems.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'PictItem
        '
        Me.PictItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictItem.Location = New System.Drawing.Point(759, 232)
        Me.PictItem.Name = "PictItem"
        Me.PictItem.Size = New System.Drawing.Size(109, 353)
        Me.PictItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictItem.TabIndex = 9
        Me.PictItem.TabStop = False
        Me.PictItem.Visible = False
        '
        'lbLocaInCabi
        '
        Me.lbLocaInCabi.BackColor = System.Drawing.SystemColors.Control
        Me.lbLocaInCabi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbLocaInCabi.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbLocaInCabi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLocaInCabi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbLocaInCabi.Location = New System.Drawing.Point(3, 16)
        Me.lbLocaInCabi.Name = "lbLocaInCabi"
        Me.lbLocaInCabi.Size = New System.Drawing.Size(868, 29)
        Me.lbLocaInCabi.TabIndex = 12
        Me.lbLocaInCabi.Text = "Item Dashboard"
        Me.lbLocaInCabi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gridItemUsed
        '
        gridItemUsed_DesignTimeLayout.LayoutString = resources.GetString("gridItemUsed_DesignTimeLayout.LayoutString")
        Me.gridItemUsed.DesignTimeLayout = gridItemUsed_DesignTimeLayout
        Me.gridItemUsed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemUsed.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.gridItemUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemUsed.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemUsed.GroupByBoxVisible = False
        Me.gridItemUsed.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.gridItemUsed.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.gridItemUsed.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridItemUsed.Hierarchical = True
        Me.gridItemUsed.Location = New System.Drawing.Point(0, 72)
        Me.gridItemUsed.Name = "gridItemUsed"
        Me.gridItemUsed.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Silver
        Me.gridItemUsed.OfficeCustomColor = System.Drawing.SystemColors.Control
        Me.gridItemUsed.RecordNavigator = True
        Me.gridItemUsed.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemUsed.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridItemUsed.Size = New System.Drawing.Size(732, 556)
        Me.gridItemUsed.TabIndex = 14
        Me.gridItemUsed.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.gridItemUsed.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridItemUsed.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Search
        '
        Me.Search.Controls.Add(Me.Label4)
        Me.Search.Controls.Add(Me.cbItem)
        Me.Search.Controls.Add(Me.dptToDate)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.dptFromDate)
        Me.Search.Controls.Add(Me.Label2)
        Me.Search.Dock = System.Windows.Forms.DockStyle.Top
        Me.Search.Location = New System.Drawing.Point(0, 0)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(732, 72)
        Me.Search.TabIndex = 13
        Me.Search.TabStop = False
        Me.Search.Text = "View By Date To Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(451, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Item Name:"
        Me.Label4.Visible = False
        '
        'cbItem
        '
        Me.cbItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItem.FormattingEnabled = True
        Me.cbItem.Location = New System.Drawing.Point(452, 35)
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(208, 28)
        Me.cbItem.TabIndex = 11
        Me.cbItem.Visible = False
        '
        'dptToDate
        '
        Me.dptToDate.Checked = False
        Me.dptToDate.CustomFormat = "dd/MM/yyyy"
        Me.dptToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptToDate.Location = New System.Drawing.Point(170, 32)
        Me.dptToDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptToDate.Name = "dptToDate"
        Me.dptToDate.Size = New System.Drawing.Size(151, 26)
        Me.dptToDate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "To Date:"
        '
        'dptFromDate
        '
        Me.dptFromDate.Checked = False
        Me.dptFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dptFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptFromDate.Location = New System.Drawing.Point(9, 33)
        Me.dptFromDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptFromDate.Name = "dptFromDate"
        Me.dptFromDate.Size = New System.Drawing.Size(151, 26)
        Me.dptFromDate.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From Date:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewInhouseUsed, Me.ToolStripSeparator7, Me.ToolStripButton1, Me.ToolStripSeparator8, Me.ToolStripButton2})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(72, 31)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "ToolStrip2"
        Me.ToolStrip2.Visible = False
        '
        'BtnNewInhouseUsed
        '
        Me.BtnNewInhouseUsed.Image = Global.KTGSYS.My.Resources.Resources.download
        Me.BtnNewInhouseUsed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewInhouseUsed.Name = "BtnNewInhouseUsed"
        Me.BtnNewInhouseUsed.Size = New System.Drawing.Size(133, 28)
        Me.BtnNewInhouseUsed.Text = "New Inhouse Used"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.KTGSYS.My.Resources.Resources.view_refresh
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(103, 28)
        Me.ToolStripButton1.Text = "Preview Data"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.KTGSYS.My.Resources.Resources.document_print
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(60, 28)
        Me.ToolStripButton2.Text = "Print"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnInitialItem, Me.ToolStripSeparator4, Me.BtnAdjustStock, Me.ToolStripSeparator3, Me.BtnUsedItem, Me.ToolStripSeparator1, Me.BtnRefreshData, Me.ToolStripSeparator5, Me.BtnPrint, Me.ToolStripSeparator2, Me.BtnUseTemplet, Me.ToolStripSeparator6, Me.BtnViewHistory})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1610, 46)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnInitialItem
        '
        Me.BtnInitialItem.ForeColor = System.Drawing.Color.Maroon
        Me.BtnInitialItem.Image = CType(resources.GetObject("BtnInitialItem.Image"), System.Drawing.Image)
        Me.BtnInitialItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnInitialItem.Name = "BtnInitialItem"
        Me.BtnInitialItem.Size = New System.Drawing.Size(85, 43)
        Me.BtnInitialItem.Text = "     Init Item     "
        Me.BtnInitialItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 46)
        '
        'BtnAdjustStock
        '
        Me.BtnAdjustStock.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAdjustStock.Image = CType(resources.GetObject("BtnAdjustStock.Image"), System.Drawing.Image)
        Me.BtnAdjustStock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdjustStock.Name = "BtnAdjustStock"
        Me.BtnAdjustStock.Size = New System.Drawing.Size(107, 43)
        Me.BtnAdjustStock.Text = "     Adjust Stock     "
        Me.BtnAdjustStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 46)
        '
        'BtnUsedItem
        '
        Me.BtnUsedItem.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUsedItem.Image = CType(resources.GetObject("BtnUsedItem.Image"), System.Drawing.Image)
        Me.BtnUsedItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUsedItem.Name = "BtnUsedItem"
        Me.BtnUsedItem.Size = New System.Drawing.Size(144, 43)
        Me.BtnUsedItem.Text = "     In-house Used Item     "
        Me.BtnUsedItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 46)
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.ForeColor = System.Drawing.Color.Maroon
        Me.BtnRefreshData.Image = CType(resources.GetObject("BtnRefreshData.Image"), System.Drawing.Image)
        Me.BtnRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Size = New System.Drawing.Size(107, 43)
        Me.BtnRefreshData.Text = "     Refresh Data     "
        Me.BtnRefreshData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 46)
        '
        'BtnPrint
        '
        Me.BtnPrint.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(98, 43)
        Me.BtnPrint.Text = "     Print Items     "
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 46)
        '
        'BtnUseTemplet
        '
        Me.BtnUseTemplet.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUseTemplet.Image = CType(resources.GetObject("BtnUseTemplet.Image"), System.Drawing.Image)
        Me.BtnUseTemplet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUseTemplet.Name = "BtnUseTemplet"
        Me.BtnUseTemplet.Size = New System.Drawing.Size(148, 43)
        Me.BtnUseTemplet.Text = "   Monthly Used Templet   "
        Me.BtnUseTemplet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 46)
        '
        'BtnViewHistory
        '
        Me.BtnViewHistory.ForeColor = System.Drawing.Color.Maroon
        Me.BtnViewHistory.Image = CType(resources.GetObject("BtnViewHistory.Image"), System.Drawing.Image)
        Me.BtnViewHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewHistory.Name = "BtnViewHistory"
        Me.BtnViewHistory.Size = New System.Drawing.Size(151, 43)
        Me.BtnViewHistory.Text = "   View History Used Item   "
        Me.BtnViewHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 46)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CRVItemMonthlyUsed)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(1610, 628)
        Me.SplitContainer2.SplitterDistance = 329
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 1
        '
        'CRVItemMonthlyUsed
        '
        Me.CRVItemMonthlyUsed.ActiveViewIndex = -1
        Me.CRVItemMonthlyUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVItemMonthlyUsed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVItemMonthlyUsed.Location = New System.Drawing.Point(0, 0)
        Me.CRVItemMonthlyUsed.Margin = New System.Windows.Forms.Padding(2)
        Me.CRVItemMonthlyUsed.Name = "CRVItemMonthlyUsed"
        Me.CRVItemMonthlyUsed.SelectionFormula = ""
        Me.CRVItemMonthlyUsed.ShowGroupTreeButton = False
        Me.CRVItemMonthlyUsed.Size = New System.Drawing.Size(150, 46)
        Me.CRVItemMonthlyUsed.TabIndex = 0
        Me.CRVItemMonthlyUsed.ViewTimeSelectionFormula = ""
        '
        'BgLoadingReport
        '
        Me.BgLoadingReport.WorkerSupportsCancellation = True
        '
        'UCDepartCurrentStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCDepartCurrentStock"
        Me.Size = New System.Drawing.Size(1610, 674)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridDepartItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItemUsed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbLocaInCabi As System.Windows.Forms.Label
    Friend WithEvents gridDepartItems As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnInitialItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnAdjustStock As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUsedItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshData As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictItem As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUseTemplet As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents CRVItemMonthlyUsed As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewInhouseUsed As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Search As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbItem As System.Windows.Forms.ComboBox
    Friend WithEvents dptToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dptFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridItemUsed As Janus.Windows.GridEX.GridEX
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker

End Class
