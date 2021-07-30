<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReceiveMoreExistingItem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReceiveMoreExistingItem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbUserRequest = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpRDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReOrNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtReceiveAtributeNote = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTPRecItemExpired = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGivenQty = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.RbDonator = New System.Windows.Forms.RadioButton()
        Me.RbVendor = New System.Windows.Forms.RadioButton()
        Me.CbVendor = New System.Windows.Forms.ComboBox()
        Me.TxtCost = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbCost = New System.Windows.Forms.ComboBox()
        Me.CbDonation = New System.Windows.Forms.ComboBox()
        Me.LblBarCode = New System.Windows.Forms.Label()
        Me.ErrorValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboItemList = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAddMorenote = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtRecQuantity = New System.Windows.Forms.TextBox()
        Me.LblRequestID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtBatchNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CboBrandName = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gridProviderDetail = New System.Windows.Forms.DataGridView()
        Me.ProviderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GivenQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProviderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiveAtributeNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BRAND_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridProviderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbUserRequest)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpRDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtReOrNum)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request Info"
        '
        'lbUserRequest
        '
        Me.lbUserRequest.BackColor = System.Drawing.Color.White
        Me.lbUserRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbUserRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserRequest.Location = New System.Drawing.Point(183, 20)
        Me.lbUserRequest.Name = "lbUserRequest"
        Me.lbUserRequest.Size = New System.Drawing.Size(395, 26)
        Me.lbUserRequest.TabIndex = 0
        Me.lbUserRequest.Text = "Chan Vibol"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Request Creator :"
        '
        'dtpRDate
        '
        Me.dtpRDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRDate.Enabled = False
        Me.dtpRDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRDate.Location = New System.Drawing.Point(183, 77)
        Me.dtpRDate.Name = "dtpRDate"
        Me.dtpRDate.Size = New System.Drawing.Size(395, 26)
        Me.dtpRDate.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Request Order Date :"
        '
        'txtReOrNum
        '
        Me.txtReOrNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReOrNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReOrNum.Enabled = False
        Me.txtReOrNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReOrNum.Location = New System.Drawing.Point(183, 48)
        Me.txtReOrNum.Name = "txtReOrNum"
        Me.txtReOrNum.Size = New System.Drawing.Size(395, 26)
        Me.txtReOrNum.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Request Order Number :"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Maroon
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(1036, 662)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 37)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Maroon
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(945, 662)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 37)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.gridProviderDetail)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TxtBatchNo)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.CboBrandName)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtReceiveAtributeNote)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DTPRecItemExpired)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtGivenQty)
        Me.GroupBox3.Controls.Add(Me.BtnAdd)
        Me.GroupBox3.Controls.Add(Me.BtnDelete)
        Me.GroupBox3.Controls.Add(Me.RbDonator)
        Me.GroupBox3.Controls.Add(Me.RbVendor)
        Me.GroupBox3.Controls.Add(Me.CbVendor)
        Me.GroupBox3.Controls.Add(Me.TxtCost)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.CbCost)
        Me.GroupBox3.Controls.Add(Me.CbDonation)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1113, 442)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Provider Info"
        '
        'TxtReceiveAtributeNote
        '
        Me.TxtReceiveAtributeNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiveAtributeNote.Location = New System.Drawing.Point(80, 146)
        Me.TxtReceiveAtributeNote.Name = "TxtReceiveAtributeNote"
        Me.TxtReceiveAtributeNote.Size = New System.Drawing.Size(540, 26)
        Me.TxtReceiveAtributeNote.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Note"
        '
        'DTPRecItemExpired
        '
        Me.DTPRecItemExpired.Checked = False
        Me.DTPRecItemExpired.CustomFormat = "dd/MM/yyyy"
        Me.DTPRecItemExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPRecItemExpired.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPRecItemExpired.Location = New System.Drawing.Point(645, 112)
        Me.DTPRecItemExpired.Name = "DTPRecItemExpired"
        Me.DTPRecItemExpired.ShowCheckBox = True
        Me.DTPRecItemExpired.Size = New System.Drawing.Size(152, 26)
        Me.DTPRecItemExpired.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Expired Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Receive Quantity * :"
        '
        'TxtGivenQty
        '
        Me.TxtGivenQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGivenQty.Location = New System.Drawing.Point(327, 112)
        Me.TxtGivenQty.Name = "TxtGivenQty"
        Me.TxtGivenQty.Size = New System.Drawing.Size(133, 26)
        Me.TxtGivenQty.TabIndex = 2
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(643, 142)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 27)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(724, 142)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 27)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'RbDonator
        '
        Me.RbDonator.AutoSize = True
        Me.RbDonator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDonator.Location = New System.Drawing.Point(12, 117)
        Me.RbDonator.Name = "RbDonator"
        Me.RbDonator.Size = New System.Drawing.Size(63, 17)
        Me.RbDonator.TabIndex = 2
        Me.RbDonator.TabStop = True
        Me.RbDonator.Text = "Donator"
        Me.RbDonator.UseVisualStyleBackColor = True
        '
        'RbVendor
        '
        Me.RbVendor.AutoSize = True
        Me.RbVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVendor.Location = New System.Drawing.Point(12, 84)
        Me.RbVendor.Name = "RbVendor"
        Me.RbVendor.Size = New System.Drawing.Size(59, 17)
        Me.RbVendor.TabIndex = 0
        Me.RbVendor.TabStop = True
        Me.RbVendor.Text = "Vendor"
        Me.RbVendor.UseVisualStyleBackColor = True
        '
        'CbVendor
        '
        Me.CbVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbVendor.FormattingEnabled = True
        Me.CbVendor.Location = New System.Drawing.Point(80, 78)
        Me.CbVendor.Name = "CbVendor"
        Me.CbVendor.Size = New System.Drawing.Size(241, 28)
        Me.CbVendor.TabIndex = 0
        '
        'TxtCost
        '
        Me.TxtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCost.Location = New System.Drawing.Point(468, 112)
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(70, 26)
        Me.TxtCost.TabIndex = 3
        Me.TxtCost.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(548, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Currency:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(473, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "New Cost * :"
        '
        'CbCost
        '
        Me.CbCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCost.FormattingEnabled = True
        Me.CbCost.Location = New System.Drawing.Point(547, 110)
        Me.CbCost.Name = "CbCost"
        Me.CbCost.Size = New System.Drawing.Size(73, 28)
        Me.CbCost.TabIndex = 4
        '
        'CbDonation
        '
        Me.CbDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDonation.FormattingEnabled = True
        Me.CbDonation.Location = New System.Drawing.Point(80, 110)
        Me.CbDonation.Name = "CbDonation"
        Me.CbDonation.Size = New System.Drawing.Size(241, 28)
        Me.CbDonation.TabIndex = 1
        '
        'LblBarCode
        '
        Me.LblBarCode.AutoSize = True
        Me.LblBarCode.Location = New System.Drawing.Point(808, 126)
        Me.LblBarCode.Name = "LblBarCode"
        Me.LblBarCode.Size = New System.Drawing.Size(13, 13)
        Me.LblBarCode.TabIndex = 44
        Me.LblBarCode.Text = "0"
        Me.LblBarCode.Visible = False
        '
        'ErrorValidation
        '
        Me.ErrorValidation.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Item Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CboItemList)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtAddMorenote)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtRecQuantity)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 81)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item receive info"
        '
        'CboItemList
        '
        Me.CboItemList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboItemList.FormattingEnabled = True
        Me.CboItemList.Location = New System.Drawing.Point(120, 12)
        Me.CboItemList.Name = "CboItemList"
        Me.CboItemList.Size = New System.Drawing.Size(229, 28)
        Me.CboItemList.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Note"
        '
        'TxtAddMorenote
        '
        Me.TxtAddMorenote.BackColor = System.Drawing.Color.White
        Me.TxtAddMorenote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddMorenote.Location = New System.Drawing.Point(359, 14)
        Me.TxtAddMorenote.Multiline = True
        Me.TxtAddMorenote.Name = "TxtAddMorenote"
        Me.TxtAddMorenote.Size = New System.Drawing.Size(240, 59)
        Me.TxtAddMorenote.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Received Quantity :"
        '
        'TxtRecQuantity
        '
        Me.TxtRecQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtRecQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecQuantity.Location = New System.Drawing.Point(120, 47)
        Me.TxtRecQuantity.Name = "TxtRecQuantity"
        Me.TxtRecQuantity.ReadOnly = True
        Me.TxtRecQuantity.Size = New System.Drawing.Size(76, 26)
        Me.TxtRecQuantity.TabIndex = 1
        Me.TxtRecQuantity.Text = "0"
        '
        'LblRequestID
        '
        Me.LblRequestID.AutoSize = True
        Me.LblRequestID.Location = New System.Drawing.Point(712, 126)
        Me.LblRequestID.Name = "LblRequestID"
        Me.LblRequestID.Size = New System.Drawing.Size(13, 13)
        Me.LblRequestID.TabIndex = 45
        Me.LblRequestID.Text = "0"
        Me.LblRequestID.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(327, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 29)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtBatchNo
        '
        Me.TxtBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBatchNo.Location = New System.Drawing.Point(386, 39)
        Me.TxtBatchNo.Name = "TxtBatchNo"
        Me.TxtBatchNo.Size = New System.Drawing.Size(234, 26)
        Me.TxtBatchNo.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(386, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Batch No:"
        '
        'CboBrandName
        '
        Me.CboBrandName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboBrandName.FormattingEnabled = True
        Me.CboBrandName.Location = New System.Drawing.Point(80, 37)
        Me.CboBrandName.Name = "CboBrandName"
        Me.CboBrandName.Size = New System.Drawing.Size(241, 28)
        Me.CboBrandName.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(77, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Brand Name:"
        '
        'gridProviderDetail
        '
        Me.gridProviderDetail.AllowUserToAddRows = False
        Me.gridProviderDetail.AllowUserToDeleteRows = False
        Me.gridProviderDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridProviderDetail.BackgroundColor = System.Drawing.Color.White
        Me.gridProviderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridProviderDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridProviderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProviderDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProviderName, Me.GivenQty, Me.Cost, Me.Currency, Me.TotalCost, Me.ProviderID, Me.CurrencyID, Me.ExpiredDate, Me.ReceiveAtributeNote, Me.BrandName, Me.BatchNo, Me.BRAND_ID})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridProviderDetail.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridProviderDetail.Location = New System.Drawing.Point(6, 183)
        Me.gridProviderDetail.Name = "gridProviderDetail"
        Me.gridProviderDetail.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridProviderDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridProviderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridProviderDetail.Size = New System.Drawing.Size(1107, 253)
        Me.gridProviderDetail.TabIndex = 36
        '
        'ProviderName
        '
        Me.ProviderName.DataPropertyName = "ProviderName"
        Me.ProviderName.HeaderText = "Vendor / Donator"
        Me.ProviderName.Name = "ProviderName"
        Me.ProviderName.ReadOnly = True
        Me.ProviderName.Width = 150
        '
        'GivenQty
        '
        Me.GivenQty.HeaderText = "Given Quantity"
        Me.GivenQty.Name = "GivenQty"
        Me.GivenQty.ReadOnly = True
        Me.GivenQty.Width = 150
        '
        'Cost
        '
        Me.Cost.HeaderText = "Cost"
        Me.Cost.Name = "Cost"
        Me.Cost.ReadOnly = True
        Me.Cost.Visible = False
        Me.Cost.Width = 70
        '
        'Currency
        '
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Name = "Currency"
        Me.Currency.ReadOnly = True
        '
        'TotalCost
        '
        Me.TotalCost.HeaderText = "Total Cost"
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.ReadOnly = True
        Me.TotalCost.Visible = False
        Me.TotalCost.Width = 150
        '
        'ProviderID
        '
        Me.ProviderID.HeaderText = "ProviderID"
        Me.ProviderID.Name = "ProviderID"
        Me.ProviderID.ReadOnly = True
        Me.ProviderID.Visible = False
        '
        'CurrencyID
        '
        Me.CurrencyID.HeaderText = "CurrencyID"
        Me.CurrencyID.Name = "CurrencyID"
        Me.CurrencyID.ReadOnly = True
        Me.CurrencyID.Visible = False
        '
        'ExpiredDate
        '
        Me.ExpiredDate.HeaderText = "Expired Date"
        Me.ExpiredDate.Name = "ExpiredDate"
        Me.ExpiredDate.ReadOnly = True
        Me.ExpiredDate.Width = 150
        '
        'ReceiveAtributeNote
        '
        Me.ReceiveAtributeNote.DataPropertyName = "ReceiveAtributeNote"
        Me.ReceiveAtributeNote.HeaderText = "Note"
        Me.ReceiveAtributeNote.Name = "ReceiveAtributeNote"
        Me.ReceiveAtributeNote.ReadOnly = True
        Me.ReceiveAtributeNote.Width = 250
        '
        'BrandName
        '
        Me.BrandName.DataPropertyName = "BrandName"
        Me.BrandName.HeaderText = "Brand Name"
        Me.BrandName.Name = "BrandName"
        Me.BrandName.ReadOnly = True
        '
        'BatchNo
        '
        Me.BatchNo.DataPropertyName = "BatchNo"
        Me.BatchNo.HeaderText = "Batch No"
        Me.BatchNo.Name = "BatchNo"
        Me.BatchNo.ReadOnly = True
        '
        'BRAND_ID
        '
        Me.BRAND_ID.HeaderText = "BRAND_ID"
        Me.BRAND_ID.Name = "BRAND_ID"
        Me.BRAND_ID.ReadOnly = True
        Me.BRAND_ID.Visible = False
        '
        'FormReceiveMoreExistingItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 702)
        Me.Controls.Add(Me.LblRequestID)
        Me.Controls.Add(Me.LblBarCode)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReceiveMoreExistingItem"
        Me.Text = "Add more existing received"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gridProviderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbUserRequest As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpRDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtReOrNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtReceiveAtributeNote As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTPRecItemExpired As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtGivenQty As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents RbDonator As System.Windows.Forms.RadioButton
    Friend WithEvents RbVendor As System.Windows.Forms.RadioButton
    Friend WithEvents CbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbCost As System.Windows.Forms.ComboBox
    Friend WithEvents CbDonation As System.Windows.Forms.ComboBox
    Friend WithEvents LblBarCode As System.Windows.Forms.Label
    Friend WithEvents ErrorValidation As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtRecQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblRequestID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAddMorenote As System.Windows.Forms.TextBox
    Friend WithEvents CboItemList As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtBatchNo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CboBrandName As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gridProviderDetail As System.Windows.Forms.DataGridView
    Friend WithEvents ProviderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GivenQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Currency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProviderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpiredDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiveAtributeNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatchNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BRAND_ID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
