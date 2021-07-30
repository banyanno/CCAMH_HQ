<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainStockResponseItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainStockResponseItem))
        Dim GridExpireDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtResponseQuantity = New System.Windows.Forms.TextBox
        Me.rtbComment = New System.Windows.Forms.RichTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblSaveOption = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRequestQuantity = New System.Windows.Forms.TextBox
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtInStock = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblItemID = New System.Windows.Forms.Label
        Me.GridExpireDetail = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblExpireID = New System.Windows.Forms.Label
        Me.TxtQTYExpire = New System.Windows.Forms.TextBox
        Me.txtExpireDate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtProviderName = New System.Windows.Forms.TextBox
        Me.LblPriverID = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtGivenQty = New System.Windows.Forms.TextBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.gridProviderDetail = New System.Windows.Forms.DataGridView
        Me.ProviderName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GivenQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProviderID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPIRE_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPIRE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RbDonator = New System.Windows.Forms.RadioButton
        Me.RbVendor = New System.Windows.Forms.RadioButton
        Me.CbVendor = New System.Windows.Forms.ComboBox
        Me.CbDonation = New System.Windows.Forms.ComboBox
        Me.BtnClose = New System.Windows.Forms.Button
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridProviderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtItemName
        '
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Enabled = False
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtItemName.Location = New System.Drawing.Point(131, 18)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(367, 26)
        Me.txtItemName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Response Quantity :"
        '
        'txtResponseQuantity
        '
        Me.txtResponseQuantity.BackColor = System.Drawing.Color.White
        Me.txtResponseQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResponseQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtResponseQuantity.Location = New System.Drawing.Point(369, 86)
        Me.txtResponseQuantity.Name = "txtResponseQuantity"
        Me.txtResponseQuantity.ReadOnly = True
        Me.txtResponseQuantity.Size = New System.Drawing.Size(129, 30)
        Me.txtResponseQuantity.TabIndex = 4
        Me.txtResponseQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rtbComment
        '
        Me.rtbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbComment.Location = New System.Drawing.Point(131, 123)
        Me.rtbComment.Name = "rtbComment"
        Me.rtbComment.Size = New System.Drawing.Size(367, 96)
        Me.rtbComment.TabIndex = 5
        Me.rtbComment.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Comment :"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Maroon
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(3, 536)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 39)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblSaveOption
        '
        Me.lblSaveOption.AutoSize = True
        Me.lblSaveOption.BackColor = System.Drawing.SystemColors.Control
        Me.lblSaveOption.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSaveOption.Location = New System.Drawing.Point(11, 206)
        Me.lblSaveOption.Name = "lblSaveOption"
        Me.lblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.lblSaveOption.TabIndex = 40
        Me.lblSaveOption.Text = "0"
        Me.lblSaveOption.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Request Quantity :"
        '
        'txtRequestQuantity
        '
        Me.txtRequestQuantity.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtRequestQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRequestQuantity.Enabled = False
        Me.txtRequestQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtRequestQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtRequestQuantity.Location = New System.Drawing.Point(131, 85)
        Me.txtRequestQuantity.Name = "txtRequestQuantity"
        Me.txtRequestQuantity.Size = New System.Drawing.Size(110, 30)
        Me.txtRequestQuantity.TabIndex = 3
        Me.txtRequestQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "In Stock :"
        '
        'txtInStock
        '
        Me.txtInStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInStock.Enabled = False
        Me.txtInStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtInStock.Location = New System.Drawing.Point(131, 50)
        Me.txtInStock.Name = "txtInStock"
        Me.txtInStock.ReadOnly = True
        Me.txtInStock.Size = New System.Drawing.Size(367, 30)
        Me.txtInStock.TabIndex = 2
        Me.txtInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblItemID)
        Me.GroupBox1.Controls.Add(Me.GridExpireDetail)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtInStock)
        Me.GroupBox1.Controls.Add(Me.txtResponseQuantity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRequestQuantity)
        Me.GroupBox1.Controls.Add(Me.rtbComment)
        Me.GroupBox1.Controls.Add(Me.lblSaveOption)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(979, 531)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Quanity Respond"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(507, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(307, 17)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Double Click select Item give expire date:"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Location = New System.Drawing.Point(19, 164)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(13, 13)
        Me.lblItemID.TabIndex = 47
        Me.lblItemID.Text = "0"
        Me.lblItemID.Visible = False
        '
        'GridExpireDetail
        '
        Me.GridExpireDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridExpireDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridExpireDetail_DesignTimeLayout.LayoutString = resources.GetString("GridExpireDetail_DesignTimeLayout.LayoutString")
        Me.GridExpireDetail.DesignTimeLayout = GridExpireDetail_DesignTimeLayout
        Me.GridExpireDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridExpireDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridExpireDetail.GroupByBoxVisible = False
        Me.GridExpireDetail.Location = New System.Drawing.Point(504, 50)
        Me.GridExpireDetail.Name = "GridExpireDetail"
        Me.GridExpireDetail.RecordNavigator = True
        Me.GridExpireDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridExpireDetail.Size = New System.Drawing.Size(461, 169)
        Me.GridExpireDetail.TabIndex = 46
        Me.GridExpireDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridExpireDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridExpireDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblExpireID)
        Me.GroupBox2.Controls.Add(Me.TxtQTYExpire)
        Me.GroupBox2.Controls.Add(Me.txtExpireDate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtProviderName)
        Me.GroupBox2.Controls.Add(Me.LblPriverID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtGivenQty)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Controls.Add(Me.gridProviderDetail)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(968, 287)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Provider Info"
        '
        'LblExpireID
        '
        Me.LblExpireID.AutoSize = True
        Me.LblExpireID.Location = New System.Drawing.Point(554, 15)
        Me.LblExpireID.Name = "LblExpireID"
        Me.LblExpireID.Size = New System.Drawing.Size(13, 13)
        Me.LblExpireID.TabIndex = 28
        Me.LblExpireID.Text = "0"
        Me.LblExpireID.Visible = False
        '
        'TxtQTYExpire
        '
        Me.TxtQTYExpire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQTYExpire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQTYExpire.Location = New System.Drawing.Point(867, 15)
        Me.TxtQTYExpire.Name = "TxtQTYExpire"
        Me.TxtQTYExpire.ReadOnly = True
        Me.TxtQTYExpire.Size = New System.Drawing.Size(138, 26)
        Me.TxtQTYExpire.TabIndex = 27
        Me.TxtQTYExpire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtQTYExpire.Visible = False
        '
        'txtExpireDate
        '
        Me.txtExpireDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpireDate.Location = New System.Drawing.Point(354, 52)
        Me.txtExpireDate.Name = "txtExpireDate"
        Me.txtExpireDate.ReadOnly = True
        Me.txtExpireDate.Size = New System.Drawing.Size(138, 26)
        Me.txtExpireDate.TabIndex = 26
        Me.txtExpireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Expire Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Provider:"
        '
        'TxtProviderName
        '
        Me.TxtProviderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProviderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProviderName.Location = New System.Drawing.Point(116, 15)
        Me.TxtProviderName.Name = "TxtProviderName"
        Me.TxtProviderName.ReadOnly = True
        Me.TxtProviderName.Size = New System.Drawing.Size(162, 26)
        Me.TxtProviderName.TabIndex = 23
        '
        'LblPriverID
        '
        Me.LblPriverID.AutoSize = True
        Me.LblPriverID.Location = New System.Drawing.Point(78, 28)
        Me.LblPriverID.Name = "LblPriverID"
        Me.LblPriverID.Size = New System.Drawing.Size(13, 13)
        Me.LblPriverID.TabIndex = 22
        Me.LblPriverID.Text = "0"
        Me.LblPriverID.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Given Quantity * :"
        '
        'TxtGivenQty
        '
        Me.TxtGivenQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtGivenQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGivenQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGivenQty.Location = New System.Drawing.Point(116, 51)
        Me.TxtGivenQty.Name = "TxtGivenQty"
        Me.TxtGivenQty.Size = New System.Drawing.Size(162, 26)
        Me.TxtGivenQty.TabIndex = 4
        Me.TxtGivenQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(501, 48)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(76, 31)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(585, 48)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(76, 31)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "-"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'gridProviderDetail
        '
        Me.gridProviderDetail.AllowUserToAddRows = False
        Me.gridProviderDetail.AllowUserToDeleteRows = False
        Me.gridProviderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridProviderDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gridProviderDetail.ColumnHeadersHeight = 30
        Me.gridProviderDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProviderName, Me.GivenQty, Me.ProviderID, Me.EXPIRE_DATE, Me.EXPIRE_ID})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridProviderDetail.DefaultCellStyle = DataGridViewCellStyle7
        Me.gridProviderDetail.Location = New System.Drawing.Point(7, 83)
        Me.gridProviderDetail.Name = "gridProviderDetail"
        Me.gridProviderDetail.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridProviderDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.gridProviderDetail.Size = New System.Drawing.Size(951, 197)
        Me.gridProviderDetail.TabIndex = 17
        '
        'ProviderName
        '
        Me.ProviderName.HeaderText = "Vendor / Donator"
        Me.ProviderName.Name = "ProviderName"
        Me.ProviderName.ReadOnly = True
        Me.ProviderName.Visible = False
        Me.ProviderName.Width = 250
        '
        'GivenQty
        '
        Me.GivenQty.HeaderText = "Given Quantity"
        Me.GivenQty.Name = "GivenQty"
        Me.GivenQty.ReadOnly = True
        Me.GivenQty.Width = 200
        '
        'ProviderID
        '
        Me.ProviderID.HeaderText = "ProviderID"
        Me.ProviderID.Name = "ProviderID"
        Me.ProviderID.ReadOnly = True
        Me.ProviderID.Visible = False
        '
        'EXPIRE_DATE
        '
        DataGridViewCellStyle6.Format = "dd/MM/yyyy"
        Me.EXPIRE_DATE.DefaultCellStyle = DataGridViewCellStyle6
        Me.EXPIRE_DATE.HeaderText = "Expire Date"
        Me.EXPIRE_DATE.Name = "EXPIRE_DATE"
        Me.EXPIRE_DATE.ReadOnly = True
        Me.EXPIRE_DATE.Width = 150
        '
        'EXPIRE_ID
        '
        Me.EXPIRE_ID.HeaderText = "EXPIRE_ID"
        Me.EXPIRE_ID.Name = "EXPIRE_ID"
        Me.EXPIRE_ID.ReadOnly = True
        Me.EXPIRE_ID.Visible = False
        '
        'RbDonator
        '
        Me.RbDonator.AutoSize = True
        Me.RbDonator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDonator.Location = New System.Drawing.Point(1030, 365)
        Me.RbDonator.Name = "RbDonator"
        Me.RbDonator.Size = New System.Drawing.Size(63, 17)
        Me.RbDonator.TabIndex = 2
        Me.RbDonator.TabStop = True
        Me.RbDonator.Text = "Donator"
        Me.RbDonator.UseVisualStyleBackColor = True
        Me.RbDonator.Visible = False
        '
        'RbVendor
        '
        Me.RbVendor.AutoSize = True
        Me.RbVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVendor.Location = New System.Drawing.Point(1030, 333)
        Me.RbVendor.Name = "RbVendor"
        Me.RbVendor.Size = New System.Drawing.Size(59, 17)
        Me.RbVendor.TabIndex = 0
        Me.RbVendor.TabStop = True
        Me.RbVendor.Text = "Vendor"
        Me.RbVendor.UseVisualStyleBackColor = True
        Me.RbVendor.Visible = False
        '
        'CbVendor
        '
        Me.CbVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbVendor.FormattingEnabled = True
        Me.CbVendor.Location = New System.Drawing.Point(1000, 292)
        Me.CbVendor.Name = "CbVendor"
        Me.CbVendor.Size = New System.Drawing.Size(187, 28)
        Me.CbVendor.TabIndex = 1
        Me.CbVendor.Visible = False
        '
        'CbDonation
        '
        Me.CbDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDonation.FormattingEnabled = True
        Me.CbDonation.Location = New System.Drawing.Point(1009, 241)
        Me.CbDonation.Name = "CbDonation"
        Me.CbDonation.Size = New System.Drawing.Size(187, 28)
        Me.CbDonation.TabIndex = 3
        Me.CbDonation.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(89, 537)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 37)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Close"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'frmMainStockResponseItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(990, 579)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CbDonation)
        Me.Controls.Add(Me.CbVendor)
        Me.Controls.Add(Me.RbVendor)
        Me.Controls.Add(Me.RbDonator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMainStockResponseItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gridProviderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtResponseQuantity As System.Windows.Forms.TextBox
    Friend WithEvents rtbComment As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblSaveOption As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRequestQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Errors As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInStock As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtGivenQty As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents gridProviderDetail As System.Windows.Forms.DataGridView
    Friend WithEvents RbDonator As System.Windows.Forms.RadioButton
    Friend WithEvents RbVendor As System.Windows.Forms.RadioButton
    Friend WithEvents CbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents CbDonation As System.Windows.Forms.ComboBox
    Friend WithEvents GridExpireDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblItemID As System.Windows.Forms.Label
    Friend WithEvents LblPriverID As System.Windows.Forms.Label
    Friend WithEvents txtExpireDate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtProviderName As System.Windows.Forms.TextBox
    Friend WithEvents TxtQTYExpire As System.Windows.Forms.TextBox
    Friend WithEvents LblExpireID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents ProviderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GivenQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProviderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPIRE_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPIRE_ID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
