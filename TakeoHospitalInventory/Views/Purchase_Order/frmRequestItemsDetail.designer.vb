<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestItemsDetail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim GridItemUsed_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestItemsDetail))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.DGVItemInStock = New System.Windows.Forms.DataGridView
        Me.cChecked = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCategory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cUnitItem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cContaining = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cInStock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cLaboratory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitsInStock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DepartID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LblItemInstock = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cbItems = New System.Windows.Forms.ComboBox
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBoxItemUsed = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblAddMorePercent = New System.Windows.Forms.Label
        Me.ChItemUsed = New System.Windows.Forms.CheckBox
        Me.GridItemUsed = New Janus.Windows.GridEX.GridEX
        Me.BtnViewItemUsed = New System.Windows.Forms.Button
        Me.DateUsedTo = New System.Windows.Forms.DateTimePicker
        Me.DateUsedFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.VSForOpticalshop = New Janus.Windows.Common.VisualStyleManager(Me.components)
        CType(Me.DGVItemInStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBoxItemUsed.SuspendLayout()
        CType(Me.GridItemUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "C"
        Me.Label1.Text = "Enter Item Name :"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.ForeColor = System.Drawing.Color.White
        Me.btnFind.Location = New System.Drawing.Point(543, 17)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 29)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "&Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'DGVItemInStock
        '
        Me.DGVItemInStock.AllowUserToAddRows = False
        Me.DGVItemInStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVItemInStock.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGVItemInStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVItemInStock.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGVItemInStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVItemInStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVItemInStock.ColumnHeadersHeight = 35
        Me.DGVItemInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVItemInStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cChecked, Me.cItemNo, Me.cItemName, Me.cCategory, Me.cUnitItem, Me.cContaining, Me.cInStock, Me.cRQuantity, Me.cBarcode, Me.cLaboratory, Me.UnitsInStock, Me.DepartID})
        Me.DGVItemInStock.EnableHeadersVisualStyles = False
        Me.DGVItemInStock.Location = New System.Drawing.Point(10, 78)
        Me.DGVItemInStock.MultiSelect = False
        Me.DGVItemInStock.Name = "DGVItemInStock"
        Me.DGVItemInStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVItemInStock.Size = New System.Drawing.Size(989, 184)
        Me.DGVItemInStock.TabIndex = 8
        '
        'cChecked
        '
        Me.cChecked.HeaderText = ""
        Me.cChecked.Name = "cChecked"
        Me.cChecked.Width = 30
        '
        'cItemNo
        '
        Me.cItemNo.DataPropertyName = "ItemID"
        Me.cItemNo.HeaderText = "ItemNo"
        Me.cItemNo.Name = "cItemNo"
        Me.cItemNo.ReadOnly = True
        Me.cItemNo.Visible = False
        '
        'cItemName
        '
        Me.cItemName.DataPropertyName = "ItemName"
        Me.cItemName.HeaderText = "Item Name"
        Me.cItemName.Name = "cItemName"
        Me.cItemName.ReadOnly = True
        Me.cItemName.Width = 300
        '
        'cCategory
        '
        Me.cCategory.DataPropertyName = "CateName"
        Me.cCategory.HeaderText = "Cetegory"
        Me.cCategory.Name = "cCategory"
        Me.cCategory.ReadOnly = True
        Me.cCategory.Visible = False
        '
        'cUnitItem
        '
        Me.cUnitItem.DataPropertyName = "ItemUnitName"
        Me.cUnitItem.HeaderText = "Unit of Measuring"
        Me.cUnitItem.Name = "cUnitItem"
        Me.cUnitItem.ReadOnly = True
        Me.cUnitItem.Visible = False
        Me.cUnitItem.Width = 150
        '
        'cContaining
        '
        Me.cContaining.DataPropertyName = "ContainerName"
        Me.cContaining.HeaderText = "Containing"
        Me.cContaining.Name = "cContaining"
        Me.cContaining.ReadOnly = True
        Me.cContaining.Visible = False
        '
        'cInStock
        '
        Me.cInStock.DataPropertyName = "UnitsInStock"
        Me.cInStock.HeaderText = "Current Stock"
        Me.cInStock.Name = "cInStock"
        Me.cInStock.ReadOnly = True
        Me.cInStock.Visible = False
        Me.cInStock.Width = 200
        '
        'cRQuantity
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cRQuantity.DefaultCellStyle = DataGridViewCellStyle2
        Me.cRQuantity.HeaderText = "Request Quantity"
        Me.cRQuantity.Name = "cRQuantity"
        Me.cRQuantity.Width = 250
        '
        'cBarcode
        '
        Me.cBarcode.DataPropertyName = "Barcode"
        Me.cBarcode.HeaderText = "Barcode"
        Me.cBarcode.Name = "cBarcode"
        Me.cBarcode.ReadOnly = True
        Me.cBarcode.Visible = False
        '
        'cLaboratory
        '
        Me.cLaboratory.DataPropertyName = "LabourFacName"
        Me.cLaboratory.HeaderText = "Laboratory"
        Me.cLaboratory.Name = "cLaboratory"
        Me.cLaboratory.Visible = False
        '
        'UnitsInStock
        '
        Me.UnitsInStock.DataPropertyName = "UnitsInStock"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UnitsInStock.DefaultCellStyle = DataGridViewCellStyle3
        Me.UnitsInStock.HeaderText = "Units InStock"
        Me.UnitsInStock.Name = "UnitsInStock"
        Me.UnitsInStock.ReadOnly = True
        Me.UnitsInStock.Visible = False
        '
        'DepartID
        '
        Me.DepartID.DataPropertyName = "DepartID"
        Me.DepartID.HeaderText = "DepartID"
        Me.DepartID.Name = "DepartID"
        Me.DepartID.Visible = False
        '
        'LblItemInstock
        '
        Me.LblItemInstock.AutoSize = True
        Me.LblItemInstock.BackColor = System.Drawing.SystemColors.Control
        Me.LblItemInstock.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemInstock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblItemInstock.Location = New System.Drawing.Point(6, 55)
        Me.LblItemInstock.Name = "LblItemInstock"
        Me.LblItemInstock.Size = New System.Drawing.Size(152, 20)
        Me.LblItemInstock.TabIndex = 9
        Me.LblItemInstock.Tag = "C"
        Me.LblItemInstock.Text = "Items available in stock "
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(827, 561)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(97, 31)
        Me.btnOK.TabIndex = 15
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(930, 560)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 32)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cbItems
        '
        Me.cbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItems.FormattingEnabled = True
        Me.cbItems.Location = New System.Drawing.Point(660, 18)
        Me.cbItems.Name = "cbItems"
        Me.cbItems.Size = New System.Drawing.Size(139, 28)
        Me.cbItems.TabIndex = 17
        Me.cbItems.Visible = False
        '
        'TxtItemName
        '
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.Location = New System.Drawing.Point(105, 18)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(432, 26)
        Me.TxtItemName.TabIndex = 18
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBoxItemUsed)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtItemName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbItems)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGVItemInStock)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnFind)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LblItemInstock)
        Me.SplitContainer1.Size = New System.Drawing.Size(1011, 547)
        Me.SplitContainer1.SplitterDistance = 273
        Me.SplitContainer1.TabIndex = 19
        '
        'GroupBoxItemUsed
        '
        Me.GroupBoxItemUsed.Controls.Add(Me.Label4)
        Me.GroupBoxItemUsed.Controls.Add(Me.LblAddMorePercent)
        Me.GroupBoxItemUsed.Controls.Add(Me.ChItemUsed)
        Me.GroupBoxItemUsed.Controls.Add(Me.GridItemUsed)
        Me.GroupBoxItemUsed.Controls.Add(Me.BtnViewItemUsed)
        Me.GroupBoxItemUsed.Controls.Add(Me.DateUsedTo)
        Me.GroupBoxItemUsed.Controls.Add(Me.DateUsedFrom)
        Me.GroupBoxItemUsed.Controls.Add(Me.Label3)
        Me.GroupBoxItemUsed.Controls.Add(Me.Label2)
        Me.GroupBoxItemUsed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxItemUsed.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxItemUsed.Name = "GroupBoxItemUsed"
        Me.GroupBoxItemUsed.Size = New System.Drawing.Size(1011, 273)
        Me.GroupBoxItemUsed.TabIndex = 0
        Me.GroupBoxItemUsed.TabStop = False
        Me.GroupBoxItemUsed.Text = "List of Item Used "
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(923, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Add% :"
        '
        'LblAddMorePercent
        '
        Me.LblAddMorePercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAddMorePercent.AutoSize = True
        Me.LblAddMorePercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddMorePercent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblAddMorePercent.Location = New System.Drawing.Point(980, 24)
        Me.LblAddMorePercent.Name = "LblAddMorePercent"
        Me.LblAddMorePercent.Size = New System.Drawing.Size(18, 20)
        Me.LblAddMorePercent.TabIndex = 21
        Me.LblAddMorePercent.Text = "0"
        '
        'ChItemUsed
        '
        Me.ChItemUsed.AutoSize = True
        Me.ChItemUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChItemUsed.ForeColor = System.Drawing.Color.Red
        Me.ChItemUsed.Location = New System.Drawing.Point(599, 19)
        Me.ChItemUsed.Name = "ChItemUsed"
        Me.ChItemUsed.Size = New System.Drawing.Size(228, 24)
        Me.ChItemUsed.TabIndex = 20
        Me.ChItemUsed.Text = "Add Reques from Item used"
        Me.ChItemUsed.UseVisualStyleBackColor = True
        '
        'GridItemUsed
        '
        Me.GridItemUsed.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridItemUsed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridItemUsed_DesignTimeLayout.LayoutString = resources.GetString("GridItemUsed_DesignTimeLayout.LayoutString")
        Me.GridItemUsed.DesignTimeLayout = GridItemUsed_DesignTimeLayout
        Me.GridItemUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridItemUsed.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridItemUsed.GroupByBoxVisible = False
        Me.GridItemUsed.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridItemUsed.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Snow
        Me.GridItemUsed.HeaderFormatStyle.FontSize = 12.0!
        Me.GridItemUsed.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridItemUsed.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridItemUsed.Location = New System.Drawing.Point(10, 51)
        Me.GridItemUsed.Name = "GridItemUsed"
        Me.GridItemUsed.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridItemUsed.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.GridItemUsed.RecordNavigator = True
        Me.GridItemUsed.RowFormatStyle.FontSize = 12.0!
        Me.GridItemUsed.Size = New System.Drawing.Size(995, 216)
        Me.GridItemUsed.TabIndex = 5
        Me.GridItemUsed.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridItemUsed.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'BtnViewItemUsed
        '
        Me.BtnViewItemUsed.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnViewItemUsed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewItemUsed.FlatAppearance.BorderSize = 0
        Me.BtnViewItemUsed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewItemUsed.ForeColor = System.Drawing.Color.White
        Me.BtnViewItemUsed.Location = New System.Drawing.Point(462, 16)
        Me.BtnViewItemUsed.Name = "BtnViewItemUsed"
        Me.BtnViewItemUsed.Size = New System.Drawing.Size(107, 28)
        Me.BtnViewItemUsed.TabIndex = 4
        Me.BtnViewItemUsed.Text = "View Item Used"
        Me.BtnViewItemUsed.UseVisualStyleBackColor = False
        '
        'DateUsedTo
        '
        Me.DateUsedTo.CustomFormat = "dd/MM/yyyy"
        Me.DateUsedTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateUsedTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateUsedTo.Location = New System.Drawing.Point(312, 19)
        Me.DateUsedTo.Name = "DateUsedTo"
        Me.DateUsedTo.Size = New System.Drawing.Size(124, 26)
        Me.DateUsedTo.TabIndex = 3
        '
        'DateUsedFrom
        '
        Me.DateUsedFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateUsedFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateUsedFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateUsedFrom.Location = New System.Drawing.Point(100, 19)
        Me.DateUsedFrom.Name = "DateUsedFrom"
        Me.DateUsedFrom.Size = New System.Drawing.Size(123, 26)
        Me.DateUsedFrom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Used To date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Used From date:"
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
        'frmRequestItemsDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 596)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRequestItemsDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        CType(Me.DGVItemInStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBoxItemUsed.ResumeLayout(False)
        Me.GroupBoxItemUsed.PerformLayout()
        CType(Me.GridItemUsed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents DGVItemInStock As System.Windows.Forms.DataGridView
    Friend WithEvents LblItemInstock As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cbItems As System.Windows.Forms.ComboBox
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBoxItemUsed As System.Windows.Forms.GroupBox
    Friend WithEvents DateUsedTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateUsedFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnViewItemUsed As System.Windows.Forms.Button
    Friend WithEvents GridItemUsed As Janus.Windows.GridEX.GridEX
    Friend WithEvents ChItemUsed As System.Windows.Forms.CheckBox
    Friend WithEvents VSForOpticalshop As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents cChecked As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUnitItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContaining As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cInStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cLaboratory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitsInStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblAddMorePercent As System.Windows.Forms.Label
End Class
