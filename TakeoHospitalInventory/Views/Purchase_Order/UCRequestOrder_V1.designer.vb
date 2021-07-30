<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRequestOrder_V1
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
        Dim GridRequestDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCRequestOrder_V1))
        Dim GridItemRequestDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim gridRequestHis_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridItemDetial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadReceived = New System.Windows.Forms.RadioButton()
        Me.RadResponse = New System.Windows.Forms.RadioButton()
        Me.RadSent = New System.Windows.Forms.RadioButton()
        Me.RadOpen = New System.Windows.Forms.RadioButton()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TVRequestOrderStatus = New System.Windows.Forms.TreeView()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridRequestDetail = New Janus.Windows.GridEX.GridEX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridItemRequestDetail = New Janus.Windows.GridEX.GridEX()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnCompareStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.gridRequestHis = New Janus.Windows.GridEX.GridEX()
        Me.GridItemDetial = New Janus.Windows.GridEX.GridEX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGridDisplay = New System.Windows.Forms.Button()
        Me.dptToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.dptFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnMarkOrderChecked = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnPatialReceived = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnReceivedAll = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintRequest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ImgTV = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridRequestDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridItemRequestDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.gridRequestHis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridItemDetial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 59)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TVRequestOrderStatus)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1042, 810)
        Me.SplitContainer1.SplitterDistance = 138
        Me.SplitContainer1.SplitterWidth = 7
        Me.SplitContainer1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.RadReceived)
        Me.GroupBox1.Controls.Add(Me.RadResponse)
        Me.GroupBox1.Controls.Add(Me.RadSent)
        Me.GroupBox1.Controls.Add(Me.RadOpen)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 597)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "History"
        '
        'RadReceived
        '
        Me.RadReceived.AutoSize = True
        Me.RadReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadReceived.Location = New System.Drawing.Point(6, 108)
        Me.RadReceived.Name = "RadReceived"
        Me.RadReceived.Size = New System.Drawing.Size(76, 19)
        Me.RadReceived.TabIndex = 3
        Me.RadReceived.TabStop = True
        Me.RadReceived.Text = "Received"
        Me.RadReceived.UseVisualStyleBackColor = True
        '
        'RadResponse
        '
        Me.RadResponse.AutoSize = True
        Me.RadResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadResponse.Location = New System.Drawing.Point(6, 85)
        Me.RadResponse.Name = "RadResponse"
        Me.RadResponse.Size = New System.Drawing.Size(89, 19)
        Me.RadResponse.TabIndex = 2
        Me.RadResponse.TabStop = True
        Me.RadResponse.Text = "Responded"
        Me.RadResponse.UseVisualStyleBackColor = True
        '
        'RadSent
        '
        Me.RadSent.AutoSize = True
        Me.RadSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadSent.Location = New System.Drawing.Point(6, 62)
        Me.RadSent.Name = "RadSent"
        Me.RadSent.Size = New System.Drawing.Size(50, 19)
        Me.RadSent.TabIndex = 1
        Me.RadSent.TabStop = True
        Me.RadSent.Text = "Sent"
        Me.RadSent.UseVisualStyleBackColor = True
        '
        'RadOpen
        '
        Me.RadOpen.AutoSize = True
        Me.RadOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadOpen.Location = New System.Drawing.Point(6, 39)
        Me.RadOpen.Name = "RadOpen"
        Me.RadOpen.Size = New System.Drawing.Size(55, 19)
        Me.RadOpen.TabIndex = 0
        Me.RadOpen.TabStop = True
        Me.RadOpen.Text = "Open"
        Me.RadOpen.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 210)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(138, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'TVRequestOrderStatus
        '
        Me.TVRequestOrderStatus.BackColor = System.Drawing.Color.White
        Me.TVRequestOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TVRequestOrderStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.TVRequestOrderStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVRequestOrderStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TVRequestOrderStatus.HideSelection = False
        Me.TVRequestOrderStatus.Location = New System.Drawing.Point(0, 0)
        Me.TVRequestOrderStatus.Margin = New System.Windows.Forms.Padding(5)
        Me.TVRequestOrderStatus.Name = "TVRequestOrderStatus"
        Me.TVRequestOrderStatus.Size = New System.Drawing.Size(138, 210)
        Me.TVRequestOrderStatus.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer3.Size = New System.Drawing.Size(897, 810)
        Me.SplitContainer3.SplitterDistance = 494
        Me.SplitContainer3.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridRequestDetail)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(897, 494)
        Me.SplitContainer2.SplitterDistance = 237
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 0
        '
        'GridRequestDetail
        '
        Me.GridRequestDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridRequestDetail_DesignTimeLayout.LayoutString = resources.GetString("GridRequestDetail_DesignTimeLayout.LayoutString")
        Me.GridRequestDetail.DesignTimeLayout = GridRequestDetail_DesignTimeLayout
        Me.GridRequestDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRequestDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridRequestDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridRequestDetail.GroupByBoxVisible = False
        Me.GridRequestDetail.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridRequestDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridRequestDetail.Location = New System.Drawing.Point(0, 27)
        Me.GridRequestDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridRequestDetail.Name = "GridRequestDetail"
        Me.GridRequestDetail.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Silver
        Me.GridRequestDetail.OfficeCustomColor = System.Drawing.SystemColors.Control
        Me.GridRequestDetail.RecordNavigator = True
        Me.GridRequestDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridRequestDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridRequestDetail.Size = New System.Drawing.Size(897, 210)
        Me.GridRequestDetail.TabIndex = 0
        Me.GridRequestDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridRequestDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(897, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request information detail"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridItemRequestDetail)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(897, 252)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Item Detaile"
        '
        'GridItemRequestDetail
        '
        Me.GridItemRequestDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridItemRequestDetail.ContextMenuStrip = Me.ContextMenuStrip1
        GridItemRequestDetail_DesignTimeLayout.LayoutString = resources.GetString("GridItemRequestDetail_DesignTimeLayout.LayoutString")
        Me.GridItemRequestDetail.DesignTimeLayout = GridItemRequestDetail_DesignTimeLayout
        Me.GridItemRequestDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemRequestDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridItemRequestDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridItemRequestDetail.GroupByBoxVisible = False
        Me.GridItemRequestDetail.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridItemRequestDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridItemRequestDetail.Location = New System.Drawing.Point(3, 17)
        Me.GridItemRequestDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridItemRequestDetail.Name = "GridItemRequestDetail"
        Me.GridItemRequestDetail.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Silver
        Me.GridItemRequestDetail.OfficeCustomColor = System.Drawing.SystemColors.Control
        Me.GridItemRequestDetail.RecordNavigator = True
        Me.GridItemRequestDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridItemRequestDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridItemRequestDetail.Size = New System.Drawing.Size(891, 231)
        Me.GridItemRequestDetail.TabIndex = 1
        Me.GridItemRequestDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridItemRequestDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCompareStock, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 32)
        '
        'btnCompareStock
        '
        Me.btnCompareStock.Name = "btnCompareStock"
        Me.btnCompareStock.Size = New System.Drawing.Size(122, 22)
        Me.btnCompareStock.Text = "InStock..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 6)
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 48)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.gridRequestHis)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.GridItemDetial)
        Me.SplitContainer4.Size = New System.Drawing.Size(897, 264)
        Me.SplitContainer4.SplitterDistance = 143
        Me.SplitContainer4.TabIndex = 5
        '
        'gridRequestHis
        '
        Me.gridRequestHis.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridRequestHis_DesignTimeLayout.LayoutString = resources.GetString("gridRequestHis_DesignTimeLayout.LayoutString")
        Me.gridRequestHis.DesignTimeLayout = gridRequestHis_DesignTimeLayout
        Me.gridRequestHis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridRequestHis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridRequestHis.GroupByBoxVisible = False
        Me.gridRequestHis.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gridRequestHis.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridRequestHis.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridRequestHis.Hierarchical = True
        Me.gridRequestHis.Location = New System.Drawing.Point(0, 0)
        Me.gridRequestHis.Name = "gridRequestHis"
        Me.gridRequestHis.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Silver
        Me.gridRequestHis.OfficeCustomColor = System.Drawing.SystemColors.Control
        Me.gridRequestHis.RecordNavigator = True
        Me.gridRequestHis.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridRequestHis.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridRequestHis.Size = New System.Drawing.Size(897, 143)
        Me.gridRequestHis.TabIndex = 3
        '
        'GridItemDetial
        '
        Me.GridItemDetial.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridItemDetial_DesignTimeLayout.LayoutString = resources.GetString("GridItemDetial_DesignTimeLayout.LayoutString")
        Me.GridItemDetial.DesignTimeLayout = GridItemDetial_DesignTimeLayout
        Me.GridItemDetial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemDetial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridItemDetial.GroupByBoxVisible = False
        Me.GridItemDetial.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GridItemDetial.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridItemDetial.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridItemDetial.Hierarchical = True
        Me.GridItemDetial.Location = New System.Drawing.Point(0, 0)
        Me.GridItemDetial.Name = "GridItemDetial"
        Me.GridItemDetial.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Silver
        Me.GridItemDetial.OfficeCustomColor = System.Drawing.SystemColors.Control
        Me.GridItemDetial.RecordNavigator = True
        Me.GridItemDetial.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridItemDetial.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridItemDetial.Size = New System.Drawing.Size(897, 117)
        Me.GridItemDetial.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btnGridDisplay)
        Me.GroupBox3.Controls.Add(Me.dptToDate)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btnPreview)
        Me.GroupBox3.Controls.Add(Me.dptFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(897, 48)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'btnGridDisplay
        '
        Me.btnGridDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnGridDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGridDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGridDisplay.ForeColor = System.Drawing.Color.White
        Me.btnGridDisplay.Image = CType(resources.GetObject("btnGridDisplay.Image"), System.Drawing.Image)
        Me.btnGridDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGridDisplay.Location = New System.Drawing.Point(451, 9)
        Me.btnGridDisplay.Name = "btnGridDisplay"
        Me.btnGridDisplay.Size = New System.Drawing.Size(112, 35)
        Me.btnGridDisplay.TabIndex = 17
        Me.btnGridDisplay.Text = "Display"
        Me.btnGridDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGridDisplay.UseVisualStyleBackColor = False
        '
        'dptToDate
        '
        Me.dptToDate.Checked = False
        Me.dptToDate.CustomFormat = "dd/MM/yyyy"
        Me.dptToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptToDate.Location = New System.Drawing.Point(288, 17)
        Me.dptToDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptToDate.Name = "dptToDate"
        Me.dptToDate.Size = New System.Drawing.Size(151, 26)
        Me.dptToDate.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "To Date:"
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(566, 9)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(112, 35)
        Me.btnPreview.TabIndex = 2
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'dptFromDate
        '
        Me.dptFromDate.Checked = False
        Me.dptFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dptFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptFromDate.Location = New System.Drawing.Point(72, 17)
        Me.dptFromDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptFromDate.Name = "dptFromDate"
        Me.dptFromDate.Size = New System.Drawing.Size(151, 26)
        Me.dptFromDate.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "From Date:"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 59)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 59)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 59)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 59)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.btnMarkOrderChecked, Me.ToolStripSeparator4, Me.btnDelete, Me.ToolStripSeparator3, Me.btnPatialReceived, Me.ToolStripSeparator5, Me.btnReceivedAll, Me.ToolStripSeparator6, Me.btnPrintRequest, Me.ToolStripSeparator7, Me.BtnRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1042, 59)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.CheckOnClick = True
        Me.BtnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(98, 56)
        Me.BtnNew.Text = "       New        "
        Me.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEdit
        '
        Me.btnEdit.CheckOnClick = True
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(103, 56)
        Me.btnEdit.Text = "         Edit        "
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnMarkOrderChecked
        '
        Me.btnMarkOrderChecked.CheckOnClick = True
        Me.btnMarkOrderChecked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMarkOrderChecked.Image = CType(resources.GetObject("btnMarkOrderChecked.Image"), System.Drawing.Image)
        Me.btnMarkOrderChecked.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarkOrderChecked.Name = "btnMarkOrderChecked"
        Me.btnMarkOrderChecked.Size = New System.Drawing.Size(103, 56)
        Me.btnMarkOrderChecked.Text = "        Send       "
        Me.btnMarkOrderChecked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 59)
        '
        'btnDelete
        '
        Me.btnDelete.CheckOnClick = True
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 56)
        Me.btnDelete.Text = "       Delete        "
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnPatialReceived
        '
        Me.btnPatialReceived.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPatialReceived.Image = CType(resources.GetObject("btnPatialReceived.Image"), System.Drawing.Image)
        Me.btnPatialReceived.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPatialReceived.Name = "btnPatialReceived"
        Me.btnPatialReceived.Size = New System.Drawing.Size(102, 56)
        Me.btnPatialReceived.Text = "Patial Received"
        Me.btnPatialReceived.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPatialReceived.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 59)
        Me.ToolStripSeparator5.Visible = False
        '
        'btnReceivedAll
        '
        Me.btnReceivedAll.Checked = True
        Me.btnReceivedAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnReceivedAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReceivedAll.Image = CType(resources.GetObject("btnReceivedAll.Image"), System.Drawing.Image)
        Me.btnReceivedAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReceivedAll.Name = "btnReceivedAll"
        Me.btnReceivedAll.Size = New System.Drawing.Size(139, 56)
        Me.btnReceivedAll.Text = "       Received All       "
        Me.btnReceivedAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnPrintRequest
        '
        Me.btnPrintRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintRequest.Image = CType(resources.GetObject("btnPrintRequest.Image"), System.Drawing.Image)
        Me.btnPrintRequest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintRequest.Name = "btnPrintRequest"
        Me.btnPrintRequest.Size = New System.Drawing.Size(104, 56)
        Me.btnPrintRequest.Text = "       Print         "
        Me.btnPrintRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 59)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.CheckOnClick = True
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(123, 56)
        Me.BtnRefresh.Text = "    Refresh Data    "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImgTV
        '
        Me.ImgTV.ImageStream = CType(resources.GetObject("ImgTV.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgTV.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgTV.Images.SetKeyName(0, "Folder_50px.png")
        Me.ImgTV.Images.SetKeyName(1, "Paper Plane_50px.png")
        Me.ImgTV.Images.SetKeyName(2, "Charity_50px.png")
        Me.ImgTV.Images.SetKeyName(3, "Approved_50px.png")
        '
        'UCRequestOrder_V1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCRequestOrder_V1"
        Me.Size = New System.Drawing.Size(1042, 869)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridRequestDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridItemRequestDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.gridRequestHis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridItemDetial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TVRequestOrderStatus As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridRequestDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnCompareStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridItemRequestDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnMarkOrderChecked As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPatialReceived As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnReceivedAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImgTV As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrintRequest As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadReceived As System.Windows.Forms.RadioButton
    Friend WithEvents RadResponse As System.Windows.Forms.RadioButton
    Friend WithEvents RadSent As System.Windows.Forms.RadioButton
    Friend WithEvents RadOpen As System.Windows.Forms.RadioButton
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents gridRequestHis As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dptToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dptFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnGridDisplay As System.Windows.Forms.Button
    Protected Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridItemDetial As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip

End Class
