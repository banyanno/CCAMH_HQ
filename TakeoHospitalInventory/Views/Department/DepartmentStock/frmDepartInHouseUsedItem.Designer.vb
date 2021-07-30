<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartInHouseUsedItem
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartInHouseUsedItem))
        Dim gridUsedItemDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.BtnModify = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dptUsedDate = New System.Windows.Forms.DateTimePicker
        Me.cbItem = New System.Windows.Forms.ComboBox
        Me.TxtStockQty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rtbComment = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictItem = New System.Windows.Forms.PictureBox
        Me.LblItemID = New System.Windows.Forms.Label
        Me.TxtUsedQTY = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtItemBarcode = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnSaveNewUsed = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.gridUsedItemDetail = New Janus.Windows.GridEX.GridEX
        Me.VSForOpticalshop = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.ErrorInHouseUsed = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridUsedItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorInHouseUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridUsedItemDetail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Size = New System.Drawing.Size(1150, 593)
        Me.SplitContainer1.SplitterDistance = 285
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.BtnModify)
        Me.GroupBox4.Controls.Add(Me.BtnAdd)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.dptUsedDate)
        Me.GroupBox4.Controls.Add(Me.cbItem)
        Me.GroupBox4.Controls.Add(Me.TxtStockQty)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.rtbComment)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.PictItem)
        Me.GroupBox4.Controls.Add(Me.LblItemID)
        Me.GroupBox4.Controls.Add(Me.TxtUsedQTY)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TxtItemBarcode)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 31)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(1150, 254)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Item Information"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(465, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 36)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Remove Item"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnModify
        '
        Me.BtnModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModify.FlatAppearance.BorderSize = 0
        Me.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModify.ForeColor = System.Drawing.Color.White
        Me.BtnModify.Image = CType(resources.GetObject("BtnModify.Image"), System.Drawing.Image)
        Me.BtnModify.Location = New System.Drawing.Point(465, 64)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(170, 36)
        Me.BtnModify.TabIndex = 44
        Me.BtnModify.Text = "Update Item"
        Me.BtnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModify.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(465, 26)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(170, 36)
        Me.BtnAdd.TabIndex = 43
        Me.BtnAdd.Text = "Add Item"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(429, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(427, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "*"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(427, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(428, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Date:"
        '
        'dptUsedDate
        '
        Me.dptUsedDate.Checked = False
        Me.dptUsedDate.CustomFormat = "dd/MM/yyyy"
        Me.dptUsedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptUsedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptUsedDate.Location = New System.Drawing.Point(111, 96)
        Me.dptUsedDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptUsedDate.Name = "dptUsedDate"
        Me.dptUsedDate.Size = New System.Drawing.Size(312, 26)
        Me.dptUsedDate.TabIndex = 2
        '
        'cbItem
        '
        Me.cbItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItem.FormattingEnabled = True
        Me.cbItem.Location = New System.Drawing.Point(111, 26)
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(312, 28)
        Me.cbItem.TabIndex = 0
        '
        'TxtStockQty
        '
        Me.TxtStockQty.Enabled = False
        Me.TxtStockQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStockQty.Location = New System.Drawing.Point(111, 164)
        Me.TxtStockQty.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtStockQty.Name = "TxtStockQty"
        Me.TxtStockQty.Size = New System.Drawing.Size(312, 26)
        Me.TxtStockQty.TabIndex = 4
        Me.TxtStockQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 171)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Stock Quantity: "
        '
        'rtbComment
        '
        Me.rtbComment.Location = New System.Drawing.Point(111, 196)
        Me.rtbComment.Name = "rtbComment"
        Me.rtbComment.Size = New System.Drawing.Size(312, 44)
        Me.rtbComment.TabIndex = 5
        Me.rtbComment.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 203)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Comment:"
        '
        'PictItem
        '
        Me.PictItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictItem.Location = New System.Drawing.Point(863, 79)
        Me.PictItem.Margin = New System.Windows.Forms.Padding(2)
        Me.PictItem.Name = "PictItem"
        Me.PictItem.Size = New System.Drawing.Size(248, 161)
        Me.PictItem.TabIndex = 8
        Me.PictItem.TabStop = False
        Me.PictItem.Visible = False
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Location = New System.Drawing.Point(640, 194)
        Me.LblItemID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(13, 13)
        Me.LblItemID.TabIndex = 7
        Me.LblItemID.Text = "0"
        Me.LblItemID.Visible = False
        '
        'TxtUsedQTY
        '
        Me.TxtUsedQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsedQTY.Location = New System.Drawing.Point(111, 130)
        Me.TxtUsedQTY.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUsedQTY.Name = "TxtUsedQTY"
        Me.TxtUsedQTY.Size = New System.Drawing.Size(312, 26)
        Me.TxtUsedQTY.TabIndex = 3
        Me.TxtUsedQTY.Text = "0"
        Me.TxtUsedQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 137)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Used Qty:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 34)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Item Name:"
        '
        'TxtItemBarcode
        '
        Me.TxtItemBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtItemBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemBarcode.Location = New System.Drawing.Point(111, 61)
        Me.TxtItemBarcode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtItemBarcode.Name = "TxtItemBarcode"
        Me.TxtItemBarcode.Size = New System.Drawing.Size(312, 26)
        Me.TxtItemBarcode.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 70)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Item Barcode:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSaveNewUsed, Me.ToolStripSeparator1, Me.BtnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1150, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnSaveNewUsed
        '
        Me.BtnSaveNewUsed.ForeColor = System.Drawing.Color.White
        Me.BtnSaveNewUsed.Image = CType(resources.GetObject("BtnSaveNewUsed.Image"), System.Drawing.Image)
        Me.BtnSaveNewUsed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSaveNewUsed.Name = "BtnSaveNewUsed"
        Me.BtnSaveNewUsed.Size = New System.Drawing.Size(136, 28)
        Me.BtnSaveNewUsed.Text = "Save Used Item List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BtnCancel
        '
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(71, 28)
        Me.BtnCancel.Text = "Cancel"
        '
        'gridUsedItemDetail
        '
        Me.gridUsedItemDetail.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound
        gridUsedItemDetail_DesignTimeLayout.LayoutString = resources.GetString("gridUsedItemDetail_DesignTimeLayout.LayoutString")
        Me.gridUsedItemDetail.DesignTimeLayout = gridUsedItemDetail_DesignTimeLayout
        Me.gridUsedItemDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridUsedItemDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridUsedItemDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridUsedItemDetail.GroupByBoxVisible = False
        Me.gridUsedItemDetail.Location = New System.Drawing.Point(0, 29)
        Me.gridUsedItemDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.gridUsedItemDetail.Name = "gridUsedItemDetail"
        Me.gridUsedItemDetail.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.gridUsedItemDetail.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.gridUsedItemDetail.RecordNavigator = True
        Me.gridUsedItemDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridUsedItemDetail.Size = New System.Drawing.Size(1150, 275)
        Me.gridUsedItemDetail.TabIndex = 34
        Me.gridUsedItemDetail.VisualStyleManager = Me.VSForOpticalshop
        '
        'VSForOpticalshop
        '
        JanusColorScheme1.ActiveCaptionColor = System.Drawing.Color.Tomato
        JanusColorScheme1.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme1.ControlDarkColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(102, Byte), Integer))
        JanusColorScheme1.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        JanusColorScheme1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(67, Byte), Integer))
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme1.InfoColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme1.InfoTextColor = System.Drawing.Color.FloralWhite
        JanusColorScheme1.MenuColor = System.Drawing.SystemColors.ActiveCaption
        JanusColorScheme1.MenuTextColor = System.Drawing.Color.DimGray
        JanusColorScheme1.Name = "Header"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.DarkBlue
        Me.VSForOpticalshop.ColorSchemes.Add(JanusColorScheme1)
        Me.VSForOpticalshop.DefaultColorScheme = "Header"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1150, 29)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Used Item List"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorInHouseUsed
        '
        Me.ErrorInHouseUsed.ContainerControl = Me
        '
        'frmDepartInHouseUsedItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 593)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmDepartInHouseUsedItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In House Used Item"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridUsedItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorInHouseUsed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictItem As System.Windows.Forms.PictureBox
    Friend WithEvents LblItemID As System.Windows.Forms.Label
    Friend WithEvents TxtUsedQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtItemBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rtbComment As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSaveNewUsed As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gridUsedItemDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtStockQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorInHouseUsed As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dptUsedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents VSForOpticalshop As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnModify As System.Windows.Forms.Button
End Class
