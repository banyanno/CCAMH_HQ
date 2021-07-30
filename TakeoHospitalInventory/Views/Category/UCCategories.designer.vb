<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCategories
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
        Dim gridItems_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCategories))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim GridExpireDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim gridItemPrice_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim gridItemRecTrans_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim gridItemProvider_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.TVCategories = New System.Windows.Forms.TreeView()
        Me.MenuCreateCatAndItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridItems = New Janus.Windows.GridEX.GridEX()
        Me.VSMInterface = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtItemName = New System.Windows.Forms.TextBox()
        Me.PicItem = New System.Windows.Forms.PictureBox()
        Me.TxtBarcodeNo = New System.Windows.Forms.TextBox()
        Me.RadItemName = New System.Windows.Forms.RadioButton()
        Me.RadBarcodNo = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab()
        Me.UiTabPage5 = New Janus.Windows.UI.Tab.UITabPage()
        Me.GridExpireDetail = New Janus.Windows.GridEX.GridEX()
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage()
        Me.gridItemPrice = New Janus.Windows.GridEX.GridEX()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.TBNewPrice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEditPrice = New System.Windows.Forms.ToolStripButton()
        Me.TBSetCurPrice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBCurrentPrice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnRefreshData = New System.Windows.Forms.ToolStripButton()
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage()
        Me.gridItemRecTrans = New Janus.Windows.GridEX.GridEX()
        Me.UiTabPage4 = New Janus.Windows.UI.Tab.UITabPage()
        Me.gridItemProvider = New Janus.Windows.GridEX.GridEX()
        Me.lblCateName = New System.Windows.Forms.Label()
        Me.ImageListCate = New System.Windows.Forms.ImageList(Me.components)
        Me.BgLoadingCategories = New System.ComponentModel.BackgroundWorker()
        Me.BgAfterTVSelected = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNewCategory1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEditItem1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnAjustStock = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnViewDetail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnItemAttribute = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelete1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.BtnPrintItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintItemsInCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintItemsAlertQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintItemsAlertExpiredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnBrand = New System.Windows.Forms.ToolStripButton()
        Me.MenuCreateCatAndItem.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage5.SuspendLayout()
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage3.SuspendLayout()
        CType(Me.gridItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.gridItemRecTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage4.SuspendLayout()
        CType(Me.gridItemProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVCategories
        '
        Me.TVCategories.BackColor = System.Drawing.SystemColors.Window
        Me.TVCategories.ContextMenuStrip = Me.MenuCreateCatAndItem
        Me.TVCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVCategories.HideSelection = False
        Me.TVCategories.Location = New System.Drawing.Point(0, 0)
        Me.TVCategories.Name = "TVCategories"
        Me.TVCategories.Size = New System.Drawing.Size(277, 202)
        Me.TVCategories.TabIndex = 6
        '
        'MenuCreateCatAndItem
        '
        Me.MenuCreateCatAndItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCategoryToolStripMenuItem, Me.ToolStripMenuItem3, Me.NewItemToolStripMenuItem})
        Me.MenuCreateCatAndItem.Name = "MenuCreateCatAndItem"
        Me.MenuCreateCatAndItem.Size = New System.Drawing.Size(150, 54)
        '
        'NewCategoryToolStripMenuItem
        '
        Me.NewCategoryToolStripMenuItem.Name = "NewCategoryToolStripMenuItem"
        Me.NewCategoryToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewCategoryToolStripMenuItem.Text = "New Category"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(146, 6)
        '
        'NewItemToolStripMenuItem
        '
        Me.NewItemToolStripMenuItem.Name = "NewItemToolStripMenuItem"
        Me.NewItemToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewItemToolStripMenuItem.Text = "New Item"
        '
        'gridItems
        '
        Me.gridItems.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridItems.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        gridItems_DesignTimeLayout.LayoutString = resources.GetString("gridItems_DesignTimeLayout.LayoutString")
        Me.gridItems.DesignTimeLayout = gridItems_DesignTimeLayout
        Me.gridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItems.GroupByBoxVisible = False
        Me.gridItems.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridItems.Location = New System.Drawing.Point(0, 0)
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RecordNavigator = True
        Me.gridItems.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItems.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridItems.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridItems.Size = New System.Drawing.Size(1046, 256)
        Me.gridItems.TabIndex = 7
        Me.gridItems.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.gridItems.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        Me.gridItems.WatermarkImage.Alpha = 150
        Me.gridItems.WatermarkImage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.gridItems.WatermarkImage.Size = New System.Drawing.Size(150, 150)
        '
        'VSMInterface
        '
        JanusColorScheme1.ActiveCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme1.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme1.ControlColor = System.Drawing.Color.White
        JanusColorScheme1.ControlDarkColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme1.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.White
        JanusColorScheme1.InfoColor = System.Drawing.Color.White
        JanusColorScheme1.InfoTextColor = System.Drawing.Color.Black
        JanusColorScheme1.MenuColor = System.Drawing.Color.White
        JanusColorScheme1.MenuTextColor = System.Drawing.Color.Black
        JanusColorScheme1.Name = "DefaultInterface"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.Black
        Me.VSMInterface.ColorSchemes.Add(JanusColorScheme1)
        Me.VSMInterface.DefaultColorScheme = Nothing
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCateName)
        Me.SplitContainer1.Size = New System.Drawing.Size(1331, 491)
        Me.SplitContainer1.SplitterDistance = 279
        Me.SplitContainer1.TabIndex = 8
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TVCategories)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(277, 464)
        Me.SplitContainer3.SplitterDistance = 202
        Me.SplitContainer3.SplitterWidth = 3
        Me.SplitContainer3.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtItemName)
        Me.GroupBox1.Controls.Add(Me.PicItem)
        Me.GroupBox1.Controls.Add(Me.TxtBarcodeNo)
        Me.GroupBox1.Controls.Add(Me.RadItemName)
        Me.GroupBox1.Controls.Add(Me.RadBarcodNo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(277, 259)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Item By"
        '
        'TxtItemName
        '
        Me.TxtItemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.Location = New System.Drawing.Point(4, 88)
        Me.TxtItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(269, 26)
        Me.TxtItemName.TabIndex = 4
        '
        'PicItem
        '
        Me.PicItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicItem.Location = New System.Drawing.Point(4, 201)
        Me.PicItem.Margin = New System.Windows.Forms.Padding(2)
        Me.PicItem.Name = "PicItem"
        Me.PicItem.Size = New System.Drawing.Size(269, 54)
        Me.PicItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicItem.TabIndex = 3
        Me.PicItem.TabStop = False
        '
        'TxtBarcodeNo
        '
        Me.TxtBarcodeNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBarcodeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcodeNo.Location = New System.Drawing.Point(4, 40)
        Me.TxtBarcodeNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBarcodeNo.Name = "TxtBarcodeNo"
        Me.TxtBarcodeNo.Size = New System.Drawing.Size(269, 26)
        Me.TxtBarcodeNo.TabIndex = 1
        '
        'RadItemName
        '
        Me.RadItemName.AutoSize = True
        Me.RadItemName.Location = New System.Drawing.Point(4, 67)
        Me.RadItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.RadItemName.Name = "RadItemName"
        Me.RadItemName.Size = New System.Drawing.Size(79, 17)
        Me.RadItemName.TabIndex = 0
        Me.RadItemName.Text = "Item Name:"
        Me.RadItemName.UseVisualStyleBackColor = True
        '
        'RadBarcodNo
        '
        Me.RadBarcodNo.AutoSize = True
        Me.RadBarcodNo.Checked = True
        Me.RadBarcodNo.Location = New System.Drawing.Point(4, 19)
        Me.RadBarcodNo.Margin = New System.Windows.Forms.Padding(2)
        Me.RadBarcodNo.Name = "RadBarcodNo"
        Me.RadBarcodNo.Size = New System.Drawing.Size(85, 17)
        Me.RadBarcodNo.TabIndex = 0
        Me.RadBarcodNo.TabStop = True
        Me.RadBarcodNo.Text = "Barcode No:"
        Me.RadBarcodNo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Categories"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 26)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.gridItems)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1048, 465)
        Me.SplitContainer2.SplitterDistance = 258
        Me.SplitContainer2.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UiTab1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1046, 201)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'UiTab1
        '
        Me.UiTab1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.UiTab1.ForeColor = System.Drawing.Color.Maroon
        Me.UiTab1.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.UiTab1.Location = New System.Drawing.Point(3, 16)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Black
        Me.UiTab1.PageBorder = Janus.Windows.UI.Tab.PageBorder.None
        Me.UiTab1.Size = New System.Drawing.Size(1040, 182)
        Me.UiTab1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.UiTab1.TabIndex = 0
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage5, Me.UiTabPage3, Me.UiTabPage2, Me.UiTabPage4})
        Me.UiTab1.UseThemes = False
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage5
        '
        Me.UiTabPage5.Controls.Add(Me.GridExpireDetail)
        Me.UiTabPage5.Key = "QTY Expire Date"
        Me.UiTabPage5.Location = New System.Drawing.Point(0, 27)
        Me.UiTabPage5.Name = "UiTabPage5"
        Me.UiTabPage5.Size = New System.Drawing.Size(1040, 155)
        Me.UiTabPage5.TabStop = True
        Me.UiTabPage5.Text = "    QTY Expire Date    "
        '
        'GridExpireDetail
        '
        Me.GridExpireDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridExpireDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridExpireDetail_DesignTimeLayout.LayoutString = resources.GetString("GridExpireDetail_DesignTimeLayout.LayoutString")
        Me.GridExpireDetail.DesignTimeLayout = GridExpireDetail_DesignTimeLayout
        Me.GridExpireDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridExpireDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridExpireDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridExpireDetail.GroupByBoxVisible = False
        Me.GridExpireDetail.Location = New System.Drawing.Point(0, 0)
        Me.GridExpireDetail.Name = "GridExpireDetail"
        Me.GridExpireDetail.RecordNavigator = True
        Me.GridExpireDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridExpireDetail.Size = New System.Drawing.Size(1040, 155)
        Me.GridExpireDetail.TabIndex = 10
        Me.GridExpireDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridExpireDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridExpireDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.gridItemPrice)
        Me.UiTabPage3.Controls.Add(Me.ToolStrip2)
        Me.UiTabPage3.Key = "Item Price"
        Me.UiTabPage3.Location = New System.Drawing.Point(0, 27)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(1040, 155)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "    Item Price    "
        '
        'gridItemPrice
        '
        Me.gridItemPrice.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridItemPrice.BackColor = System.Drawing.Color.White
        gridItemPrice_DesignTimeLayout.LayoutString = resources.GetString("gridItemPrice_DesignTimeLayout.LayoutString")
        Me.gridItemPrice.DesignTimeLayout = gridItemPrice_DesignTimeLayout
        Me.gridItemPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemPrice.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemPrice.GroupByBoxVisible = False
        Me.gridItemPrice.Location = New System.Drawing.Point(0, 40)
        Me.gridItemPrice.Name = "gridItemPrice"
        Me.gridItemPrice.RecordNavigator = True
        Me.gridItemPrice.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemPrice.Size = New System.Drawing.Size(1040, 115)
        Me.gridItemPrice.TabIndex = 7
        Me.gridItemPrice.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.gridItemPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TBNewPrice, Me.ToolStripSeparator2, Me.ToolStripSeparator6, Me.BtnEditPrice, Me.TBSetCurPrice, Me.ToolStripSeparator3, Me.TBCurrentPrice, Me.ToolStripSeparator5, Me.BtnRefreshData})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip2.Size = New System.Drawing.Size(1040, 40)
        Me.ToolStrip2.TabIndex = 8
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'TBNewPrice
        '
        Me.TBNewPrice.Image = Global.KTGSYS.My.Resources.Resources.price
        Me.TBNewPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBNewPrice.Name = "TBNewPrice"
        Me.TBNewPrice.Size = New System.Drawing.Size(103, 37)
        Me.TBNewPrice.Text = "    New Price    "
        Me.TBNewPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TBNewPrice.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 40)
        Me.ToolStripSeparator6.Visible = False
        '
        'BtnEditPrice
        '
        Me.BtnEditPrice.Image = Global.KTGSYS.My.Resources.Resources.edit
        Me.BtnEditPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditPrice.Name = "BtnEditPrice"
        Me.BtnEditPrice.Size = New System.Drawing.Size(108, 37)
        Me.BtnEditPrice.Text = "     Edit Price     "
        Me.BtnEditPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TBSetCurPrice
        '
        Me.TBSetCurPrice.Image = Global.KTGSYS.My.Resources.Resources.check
        Me.TBSetCurPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBSetCurPrice.Name = "TBSetCurPrice"
        Me.TBSetCurPrice.Size = New System.Drawing.Size(166, 37)
        Me.TBSetCurPrice.Text = "    Set As Current Price    "
        Me.TBSetCurPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TBSetCurPrice.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'TBCurrentPrice
        '
        Me.TBCurrentPrice.Image = Global.KTGSYS.My.Resources.Resources.preview
        Me.TBCurrentPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBCurrentPrice.Name = "TBCurrentPrice"
        Me.TBCurrentPrice.Size = New System.Drawing.Size(124, 37)
        Me.TBCurrentPrice.Text = "    Current Price    "
        Me.TBCurrentPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TBCurrentPrice.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 40)
        Me.ToolStripSeparator5.Visible = False
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.Image = Global.KTGSYS.My.Resources.Resources.view_refresh
        Me.BtnRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Size = New System.Drawing.Size(123, 37)
        Me.BtnRefreshData.Text = "    Refresh Data    "
        Me.BtnRefreshData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnRefreshData.Visible = False
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.gridItemRecTrans)
        Me.UiTabPage2.Key = "Item Received Transaction"
        Me.UiTabPage2.Location = New System.Drawing.Point(0, 27)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1040, 155)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "   Item Received Transaction    "
        '
        'gridItemRecTrans
        '
        Me.gridItemRecTrans.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemRecTrans_DesignTimeLayout.LayoutString = resources.GetString("gridItemRecTrans_DesignTimeLayout.LayoutString")
        Me.gridItemRecTrans.DesignTimeLayout = gridItemRecTrans_DesignTimeLayout
        Me.gridItemRecTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemRecTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemRecTrans.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemRecTrans.GroupByBoxVisible = False
        Me.gridItemRecTrans.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridItemRecTrans.Location = New System.Drawing.Point(0, 0)
        Me.gridItemRecTrans.Name = "gridItemRecTrans"
        Me.gridItemRecTrans.RecordNavigator = True
        Me.gridItemRecTrans.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemRecTrans.Size = New System.Drawing.Size(1040, 155)
        Me.gridItemRecTrans.TabIndex = 8
        Me.gridItemRecTrans.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.gridItemRecTrans.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'UiTabPage4
        '
        Me.UiTabPage4.Controls.Add(Me.gridItemProvider)
        Me.UiTabPage4.Key = "Item Provider"
        Me.UiTabPage4.Location = New System.Drawing.Point(0, 27)
        Me.UiTabPage4.Name = "UiTabPage4"
        Me.UiTabPage4.Size = New System.Drawing.Size(1040, 155)
        Me.UiTabPage4.TabStop = True
        Me.UiTabPage4.Text = "    Item Provider    "
        '
        'gridItemProvider
        '
        Me.gridItemProvider.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemProvider_DesignTimeLayout.LayoutString = resources.GetString("gridItemProvider_DesignTimeLayout.LayoutString")
        Me.gridItemProvider.DesignTimeLayout = gridItemProvider_DesignTimeLayout
        Me.gridItemProvider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemProvider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemProvider.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemProvider.GroupByBoxVisible = False
        Me.gridItemProvider.Location = New System.Drawing.Point(0, 0)
        Me.gridItemProvider.Name = "gridItemProvider"
        Me.gridItemProvider.RecordNavigator = True
        Me.gridItemProvider.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemProvider.Size = New System.Drawing.Size(1040, 155)
        Me.gridItemProvider.TabIndex = 9
        Me.gridItemProvider.VisualStyleManager = Me.VSMInterface
        '
        'lblCateName
        '
        Me.lblCateName.BackColor = System.Drawing.SystemColors.Control
        Me.lblCateName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCateName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCateName.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCateName.Location = New System.Drawing.Point(0, 0)
        Me.lblCateName.Name = "lblCateName"
        Me.lblCateName.Size = New System.Drawing.Size(1048, 26)
        Me.lblCateName.TabIndex = 14
        Me.lblCateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageListCate
        '
        Me.ImageListCate.ImageStream = CType(resources.GetObject("ImageListCate.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListCate.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListCate.Images.SetKeyName(0, "CategoryItem.png")
        '
        'BgLoadingCategories
        '
        '
        'BgAfterTVSelected
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewCategory1, Me.ToolStripSeparator8, Me.ToolStripButton2, Me.ToolStripSeparator9, Me.BtnNewItem1, Me.ToolStripSeparator10, Me.BtnEditItem1, Me.ToolStripSeparator11, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.BtnAjustStock, Me.ToolStripSeparator14, Me.BtnViewDetail, Me.ToolStripSeparator15, Me.BtnItemAttribute, Me.BtnDelete1, Me.ToolStripSeparator1, Me.ToolStripSplitButton1, Me.ToolStripSeparator7, Me.BtnBrand})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1331, 58)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewCategory1
        '
        Me.BtnNewCategory1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNewCategory1.Image = CType(resources.GetObject("BtnNewCategory1.Image"), System.Drawing.Image)
        Me.BtnNewCategory1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewCategory1.Name = "BtnNewCategory1"
        Me.BtnNewCategory1.Size = New System.Drawing.Size(137, 55)
        Me.BtnNewCategory1.Text = "   New Category   "
        Me.BtnNewCategory1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(131, 55)
        Me.ToolStripButton2.Text = "   Edit Category   "
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 58)
        '
        'BtnNewItem1
        '
        Me.BtnNewItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNewItem1.Image = CType(resources.GetObject("BtnNewItem1.Image"), System.Drawing.Image)
        Me.BtnNewItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewItem1.Name = "BtnNewItem1"
        Me.BtnNewItem1.Size = New System.Drawing.Size(105, 55)
        Me.BtnNewItem1.Text = "   New Item   "
        Me.BtnNewItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 58)
        '
        'BtnEditItem1
        '
        Me.BtnEditItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEditItem1.Image = CType(resources.GetObject("BtnEditItem1.Image"), System.Drawing.Image)
        Me.BtnEditItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditItem1.Name = "BtnEditItem1"
        Me.BtnEditItem1.Size = New System.Drawing.Size(99, 55)
        Me.BtnEditItem1.Text = "   Edit Item   "
        Me.BtnEditItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(103, 55)
        Me.ToolStripButton1.Text = "Refresh Data"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 58)
        '
        'BtnAjustStock
        '
        Me.BtnAjustStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAjustStock.Image = CType(resources.GetObject("BtnAjustStock.Image"), System.Drawing.Image)
        Me.BtnAjustStock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAjustStock.Name = "BtnAjustStock"
        Me.BtnAjustStock.Size = New System.Drawing.Size(99, 55)
        Me.BtnAjustStock.Text = "Adjust Stock"
        Me.BtnAjustStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 58)
        '
        'BtnViewDetail
        '
        Me.BtnViewDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnViewDetail.Image = CType(resources.GetObject("BtnViewDetail.Image"), System.Drawing.Image)
        Me.BtnViewDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewDetail.Name = "BtnViewDetail"
        Me.BtnViewDetail.Size = New System.Drawing.Size(127, 55)
        Me.BtnViewDetail.Text = "View Item Detail"
        Me.BtnViewDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 58)
        '
        'BtnItemAttribute
        '
        Me.BtnItemAttribute.ForeColor = System.Drawing.Color.Maroon
        Me.BtnItemAttribute.Image = CType(resources.GetObject("BtnItemAttribute.Image"), System.Drawing.Image)
        Me.BtnItemAttribute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnItemAttribute.Name = "BtnItemAttribute"
        Me.BtnItemAttribute.Size = New System.Drawing.Size(148, 55)
        Me.BtnItemAttribute.Text = "     Item attribute     "
        Me.BtnItemAttribute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnDelete1
        '
        Me.BtnDelete1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDelete1.Image = CType(resources.GetObject("BtnDelete1.Image"), System.Drawing.Image)
        Me.BtnDelete1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete1.Name = "BtnDelete1"
        Me.BtnDelete1.Size = New System.Drawing.Size(82, 55)
        Me.BtnDelete1.Text = "   Delete   "
        Me.BtnDelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnDelete1.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 30
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintItem1, Me.ToolStripMenuItem7, Me.PrintItemsInCategoryToolStripMenuItem, Me.ToolStripMenuItem8, Me.PrintItemsAlertQuantityToolStripMenuItem, Me.ToolStripMenuItem9, Me.PrintItemsAlertExpiredToolStripMenuItem})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(158, 55)
        Me.ToolStripSplitButton1.Text = "Print Item Utility"
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnPrintItem1
        '
        Me.BtnPrintItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPrintItem1.Name = "BtnPrintItem1"
        Me.BtnPrintItem1.Size = New System.Drawing.Size(256, 26)
        Me.BtnPrintItem1.Text = "Print All Items"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(253, 6)
        '
        'PrintItemsInCategoryToolStripMenuItem
        '
        Me.PrintItemsInCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintItemsInCategoryToolStripMenuItem.Name = "PrintItemsInCategoryToolStripMenuItem"
        Me.PrintItemsInCategoryToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.PrintItemsInCategoryToolStripMenuItem.Text = "Print Items In Category"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(253, 6)
        '
        'PrintItemsAlertQuantityToolStripMenuItem
        '
        Me.PrintItemsAlertQuantityToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintItemsAlertQuantityToolStripMenuItem.Name = "PrintItemsAlertQuantityToolStripMenuItem"
        Me.PrintItemsAlertQuantityToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.PrintItemsAlertQuantityToolStripMenuItem.Text = "Print Items Alert Quantity"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(253, 6)
        '
        'PrintItemsAlertExpiredToolStripMenuItem
        '
        Me.PrintItemsAlertExpiredToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintItemsAlertExpiredToolStripMenuItem.Name = "PrintItemsAlertExpiredToolStripMenuItem"
        Me.PrintItemsAlertExpiredToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.PrintItemsAlertExpiredToolStripMenuItem.Text = "Print Items Alert Expired"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 58)
        '
        'BtnBrand
        '
        Me.BtnBrand.Image = CType(resources.GetObject("BtnBrand.Image"), System.Drawing.Image)
        Me.BtnBrand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBrand.Name = "BtnBrand"
        Me.BtnBrand.Size = New System.Drawing.Size(152, 55)
        Me.BtnBrand.Text = "Add Item Brand"
        '
        'UCCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCCategories"
        Me.Size = New System.Drawing.Size(1331, 549)
        Me.MenuCreateCatAndItem.ResumeLayout(False)
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage5.ResumeLayout(False)
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage3.ResumeLayout(False)
        Me.UiTabPage3.PerformLayout()
        CType(Me.gridItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.gridItemRecTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage4.ResumeLayout(False)
        CType(Me.gridItemProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TVCategories As System.Windows.Forms.TreeView
    Friend WithEvents gridItems As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ImageListCate As System.Windows.Forms.ImageList
    Friend WithEvents BgLoadingCategories As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCateName As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridItemPrice As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents RadItemName As System.Windows.Forms.RadioButton
    Friend WithEvents RadBarcodNo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtBarcodeNo As System.Windows.Forms.TextBox
    Friend WithEvents PicItem As System.Windows.Forms.PictureBox
    Friend WithEvents MenuCreateCatAndItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BgAfterTVSelected As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridItemRecTrans As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage4 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridItemProvider As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents TBNewPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBSetCurPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBCurrentPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshData As System.Windows.Forms.ToolStripButton
    Friend WithEvents UiTabPage5 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridExpireDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents VSMInterface As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewCategory1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnAjustStock As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewDetail As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents BtnPrintItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintItemsInCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintItemsAlertQuantityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintItemsAlertExpiredToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnItemAttribute As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnBrand As System.Windows.Forms.ToolStripButton

End Class
