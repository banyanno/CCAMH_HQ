<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransportation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransportation))
        Dim GridTransDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim JanusColorScheme4 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.LblSaveOption = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnRemoveItem = New System.Windows.Forms.Button()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.TxtAmountOffer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CboOffer = New System.Windows.Forms.ComboBox()
        Me.GridTransDetail = New Janus.Windows.GridEX.GridEX()
        Me.TxtRemark = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboProvince = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtAmmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChIsInCenter = New System.Windows.Forms.CheckBox()
        Me.TxtAllocateTo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.TxtClientAge = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtClientSex = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtClientName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.DateReceipt = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VSMInterface = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.ErrTransportation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GridTransDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrTransportation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.LblSaveOption)
        Me.PanelMain.Controls.Add(Me.PictureBox1)
        Me.PanelMain.Controls.Add(Me.BtnClose)
        Me.PanelMain.Controls.Add(Me.BtnSave)
        Me.PanelMain.Controls.Add(Me.Label2)
        Me.PanelMain.Controls.Add(Me.Label1)
        Me.PanelMain.Controls.Add(Me.Panel3)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(484, 731)
        Me.PanelMain.TabIndex = 0
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(8, 697)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(20, 25)
        Me.LblSaveOption.TabIndex = 17
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
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
        Me.BtnClose.Location = New System.Drawing.Point(378, 667)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 37)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Cancel"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(272, 667)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 37)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(81, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(Transportation Serviec for Client)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Mool1", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(76, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ថ្លៃធ្វើដំណើររបស់ អតិថិជន"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BtnRemoveItem)
        Me.Panel3.Controls.Add(Me.BtnAddItem)
        Me.Panel3.Controls.Add(Me.TxtAmountOffer)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.CboOffer)
        Me.Panel3.Controls.Add(Me.GridTransDetail)
        Me.Panel3.Controls.Add(Me.TxtRemark)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.CboProvince)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TxtAmmount)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Font = New System.Drawing.Font("Khmer OS Battambang", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(5, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(474, 584)
        Me.Panel3.TabIndex = 0
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveItem.FlatAppearance.BorderSize = 0
        Me.BtnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.BtnRemoveItem.Location = New System.Drawing.Point(423, 217)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(42, 33)
        Me.BtnRemoveItem.TabIndex = 20
        Me.BtnRemoveItem.Text = "-"
        Me.BtnRemoveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRemoveItem.UseVisualStyleBackColor = False
        '
        'BtnAddItem
        '
        Me.BtnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddItem.FlatAppearance.BorderSize = 0
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.ForeColor = System.Drawing.Color.White
        Me.BtnAddItem.Location = New System.Drawing.Point(376, 217)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(42, 33)
        Me.BtnAddItem.TabIndex = 19
        Me.BtnAddItem.Text = "+"
        Me.BtnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'TxtAmountOffer
        '
        Me.TxtAmountOffer.Location = New System.Drawing.Point(202, 215)
        Me.TxtAmountOffer.Name = "TxtAmountOffer"
        Me.TxtAmountOffer.Size = New System.Drawing.Size(169, 35)
        Me.TxtAmountOffer.TabIndex = 18
        Me.TxtAmountOffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(247, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 27)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Amount(៛)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 27)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Offer"
        '
        'CboOffer
        '
        Me.CboOffer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboOffer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboOffer.FormattingEnabled = True
        Me.CboOffer.Location = New System.Drawing.Point(5, 215)
        Me.CboOffer.Name = "CboOffer"
        Me.CboOffer.Size = New System.Drawing.Size(183, 35)
        Me.CboOffer.TabIndex = 15
        '
        'GridTransDetail
        '
        Me.GridTransDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTransDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridTransDetail.BackColor = System.Drawing.Color.White
        Me.GridTransDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridTransDetail_DesignTimeLayout.LayoutString = resources.GetString("GridTransDetail_DesignTimeLayout.LayoutString")
        Me.GridTransDetail.DesignTimeLayout = GridTransDetail_DesignTimeLayout
        Me.GridTransDetail.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridTransDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridTransDetail.GroupByBoxVisible = False
        Me.GridTransDetail.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridTransDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridTransDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridTransDetail.Location = New System.Drawing.Point(5, 256)
        Me.GridTransDetail.Name = "GridTransDetail"
        Me.GridTransDetail.RecordNavigator = True
        Me.GridTransDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridTransDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridTransDetail.Size = New System.Drawing.Size(459, 171)
        Me.GridTransDetail.TabIndex = 14
        Me.GridTransDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridTransDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtRemark
        '
        Me.TxtRemark.Location = New System.Drawing.Point(3, 523)
        Me.TxtRemark.Multiline = True
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(462, 52)
        Me.TxtRemark.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 498)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 27)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Remark:"
        '
        'CboProvince
        '
        Me.CboProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProvince.FormattingEnabled = True
        Me.CboProvince.Location = New System.Drawing.Point(3, 460)
        Me.CboProvince.Name = "CboProvince"
        Me.CboProvince.Size = New System.Drawing.Size(214, 35)
        Me.CboProvince.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 27)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Province:"
        '
        'TxtAmmount
        '
        Me.TxtAmmount.Location = New System.Drawing.Point(238, 460)
        Me.TxtAmmount.Name = "TxtAmmount"
        Me.TxtAmmount.Size = New System.Drawing.Size(226, 35)
        Me.TxtAmmount.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 430)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Transportation Ammount:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ChIsInCenter)
        Me.Panel1.Controls.Add(Me.TxtAllocateTo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.TxtClientAge)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TxtClientSex)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtClientName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TxtClientNo)
        Me.Panel1.Controls.Add(Me.DateReceipt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 179)
        Me.Panel1.TabIndex = 1
        '
        'ChIsInCenter
        '
        Me.ChIsInCenter.AutoSize = True
        Me.ChIsInCenter.Checked = True
        Me.ChIsInCenter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChIsInCenter.Location = New System.Drawing.Point(5, 40)
        Me.ChIsInCenter.Name = "ChIsInCenter"
        Me.ChIsInCenter.Size = New System.Drawing.Size(159, 31)
        Me.ChIsInCenter.TabIndex = 20
        Me.ChIsInCenter.Text = "Client No In Center:"
        Me.ChIsInCenter.UseVisualStyleBackColor = True
        '
        'TxtAllocateTo
        '
        Me.TxtAllocateTo.Location = New System.Drawing.Point(307, 129)
        Me.TxtAllocateTo.Name = "TxtAllocateTo"
        Me.TxtAllocateTo.Size = New System.Drawing.Size(153, 35)
        Me.TxtAllocateTo.TabIndex = 19
        Me.TxtAllocateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(307, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 27)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Allocate To"
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(244, 74)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(52, 32)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtClientAge
        '
        Me.TxtClientAge.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientAge.Location = New System.Drawing.Point(244, 132)
        Me.TxtClientAge.Name = "TxtClientAge"
        Me.TxtClientAge.ReadOnly = True
        Me.TxtClientAge.Size = New System.Drawing.Size(52, 32)
        Me.TxtClientAge.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(243, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 27)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Age:"
        '
        'TxtClientSex
        '
        Me.TxtClientSex.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientSex.Location = New System.Drawing.Point(178, 132)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(57, 32)
        Me.TxtClientSex.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(177, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 27)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Sex:"
        '
        'TxtClientName
        '
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(4, 132)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.ReadOnly = True
        Me.TxtClientName.Size = New System.Drawing.Size(168, 32)
        Me.TxtClientName.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 27)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Name:"
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.TxtClientNo.Location = New System.Drawing.Point(4, 74)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.Size = New System.Drawing.Size(231, 32)
        Me.TxtClientNo.TabIndex = 0
        '
        'DateReceipt
        '
        Me.DateReceipt.Checked = False
        Me.DateReceipt.CustomFormat = "dd/MM/yyyy"
        Me.DateReceipt.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.DateReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceipt.Location = New System.Drawing.Point(307, 74)
        Me.DateReceipt.Name = "DateReceipt"
        Me.DateReceipt.ShowCheckBox = True
        Me.DateReceipt.Size = New System.Drawing.Size(153, 32)
        Me.DateReceipt.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 27)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Receive From:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Battambang", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(308, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 27)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date Transportation"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-1, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(465, 1)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'VSMInterface
        '
        JanusColorScheme4.ActiveCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme4.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme4.ControlColor = System.Drawing.Color.White
        JanusColorScheme4.ControlDarkColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme4.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme4.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme4.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme4.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme4.HighlightTextColor = System.Drawing.Color.White
        JanusColorScheme4.InfoColor = System.Drawing.Color.White
        JanusColorScheme4.InfoTextColor = System.Drawing.Color.Black
        JanusColorScheme4.MenuColor = System.Drawing.Color.White
        JanusColorScheme4.MenuTextColor = System.Drawing.Color.Black
        JanusColorScheme4.Name = "DefaultInterface"
        JanusColorScheme4.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme4.UseThemes = False
        JanusColorScheme4.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme4.WindowColor = System.Drawing.Color.White
        JanusColorScheme4.WindowTextColor = System.Drawing.Color.Black
        Me.VSMInterface.ColorSchemes.Add(JanusColorScheme4)
        Me.VSMInterface.DefaultColorScheme = Nothing
        '
        'ErrTransportation
        '
        Me.ErrTransportation.ContainerControl = Me
        '
        'FormTransportation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 731)
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransportation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicine Client Receipt"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GridTransDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrTransportation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrTransportation As System.Windows.Forms.ErrorProvider
    Friend WithEvents VSMInterface As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TxtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtAmmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtClientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtClientSex As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents DateReceipt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridTransDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CboOffer As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAmountOffer As System.Windows.Forms.TextBox
    Friend WithEvents BtnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents TxtAllocateTo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ChIsInCenter As System.Windows.Forms.CheckBox
End Class
