<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIssueReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIssueReceipt))
        Dim GridServiceMed_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PanelMain = New System.Windows.Forms.Panel
        Me.LblPrinting = New System.Windows.Forms.Label
        Me.PicLoading = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GBSocialServieType = New System.Windows.Forms.GroupBox
        Me.RadServiceB = New System.Windows.Forms.RadioButton
        Me.RadServiceC = New System.Windows.Forms.RadioButton
        Me.RadServiceA = New System.Windows.Forms.RadioButton
        Me.TxtRecieveBy = New System.Windows.Forms.TextBox
        Me.DateReceipt = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtClientAge = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtClientSex = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtClientName = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtClientNo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtAmmountInword = New System.Windows.Forms.TextBox
        Me.TxtReceiptAmmount = New System.Windows.Forms.TextBox
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.NewClient = New System.Windows.Forms.TabPage
        Me.FollowUP = New System.Windows.Forms.TabPage
        Me.Medicine = New System.Windows.Forms.TabPage
        Me.SpacialService = New System.Windows.Forms.TabPage
        Me.Label17 = New System.Windows.Forms.Label
        Me.CboPackage = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.BtnRemoveItem = New System.Windows.Forms.Button
        Me.BtnAddItem = New System.Windows.Forms.Button
        Me.CboSkill = New System.Windows.Forms.ComboBox
        Me.TxtSpacialServicePrice = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GridServiceMed = New Janus.Windows.GridEX.GridEX
        Me.Label18 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CboItem = New System.Windows.Forms.ComboBox
        Me.TxtQTY = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.PanelMain.SuspendLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GBSocialServieType.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Medicine.SuspendLayout()
        Me.SpacialService.SuspendLayout()
        CType(Me.GridServiceMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.LblPrinting)
        Me.PanelMain.Controls.Add(Me.PicLoading)
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
        Me.PanelMain.Size = New System.Drawing.Size(848, 649)
        Me.PanelMain.TabIndex = 1
        '
        'LblPrinting
        '
        Me.LblPrinting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPrinting.AutoSize = True
        Me.LblPrinting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LblPrinting.Location = New System.Drawing.Point(4, 595)
        Me.LblPrinting.Name = "LblPrinting"
        Me.LblPrinting.Size = New System.Drawing.Size(124, 25)
        Me.LblPrinting.TabIndex = 204
        Me.LblPrinting.Text = "Printing Receipt..."
        Me.LblPrinting.Visible = False
        '
        'PicLoading
        '
        Me.PicLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicLoading.Image = Global.KTGSYS.My.Resources.Resources.loadgraphic
        Me.PicLoading.Location = New System.Drawing.Point(5, 620)
        Me.PicLoading.Name = "PicLoading"
        Me.PicLoading.Size = New System.Drawing.Size(157, 24)
        Me.PicLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLoading.TabIndex = 203
        Me.PicLoading.TabStop = False
        Me.PicLoading.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 1)
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
        Me.BtnClose.Location = New System.Drawing.Point(735, 607)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 37)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
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
        Me.BtnSave.Location = New System.Drawing.Point(629, 607)
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
        Me.Label2.Location = New System.Drawing.Point(81, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(Cash Receipt for New Client)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Mool1", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(76, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "បង្កាន់ដៃទទួលប្រាក់អថិជន"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Controls.Add(Me.GBSocialServieType)
        Me.Panel3.Controls.Add(Me.TxtRecieveBy)
        Me.Panel3.Controls.Add(Me.DateReceipt)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.TxtAmmountInword)
        Me.Panel3.Controls.Add(Me.TxtReceiptAmmount)
        Me.Panel3.Controls.Add(Me.TxtReceiptNo)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(5, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(830, 528)
        Me.Panel3.TabIndex = 0
        '
        'GBSocialServieType
        '
        Me.GBSocialServieType.BackColor = System.Drawing.Color.Transparent
        Me.GBSocialServieType.Controls.Add(Me.RadServiceB)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceC)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceA)
        Me.GBSocialServieType.Location = New System.Drawing.Point(315, 75)
        Me.GBSocialServieType.Name = "GBSocialServieType"
        Me.GBSocialServieType.Size = New System.Drawing.Size(316, 63)
        Me.GBSocialServieType.TabIndex = 5
        Me.GBSocialServieType.TabStop = False
        Me.GBSocialServieType.Text = "Social Economic Service Types"
        '
        'RadServiceB
        '
        Me.RadServiceB.AutoSize = True
        Me.RadServiceB.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceB.Location = New System.Drawing.Point(114, 19)
        Me.RadServiceB.Name = "RadServiceB"
        Me.RadServiceB.Size = New System.Drawing.Size(93, 33)
        Me.RadServiceB.TabIndex = 2
        Me.RadServiceB.TabStop = True
        Me.RadServiceB.Text = "Servic B"
        Me.RadServiceB.UseVisualStyleBackColor = True
        '
        'RadServiceC
        '
        Me.RadServiceC.AutoSize = True
        Me.RadServiceC.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceC.Location = New System.Drawing.Point(214, 19)
        Me.RadServiceC.Name = "RadServiceC"
        Me.RadServiceC.Size = New System.Drawing.Size(103, 33)
        Me.RadServiceC.TabIndex = 1
        Me.RadServiceC.TabStop = True
        Me.RadServiceC.Text = "Service C"
        Me.RadServiceC.UseVisualStyleBackColor = True
        '
        'RadServiceA
        '
        Me.RadServiceA.AutoSize = True
        Me.RadServiceA.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceA.Location = New System.Drawing.Point(7, 19)
        Me.RadServiceA.Name = "RadServiceA"
        Me.RadServiceA.Size = New System.Drawing.Size(102, 33)
        Me.RadServiceA.TabIndex = 0
        Me.RadServiceA.TabStop = True
        Me.RadServiceA.Text = "Service A"
        Me.RadServiceA.UseVisualStyleBackColor = True
        '
        'TxtRecieveBy
        '
        Me.TxtRecieveBy.Location = New System.Drawing.Point(668, 453)
        Me.TxtRecieveBy.Name = "TxtRecieveBy"
        Me.TxtRecieveBy.ReadOnly = True
        Me.TxtRecieveBy.Size = New System.Drawing.Size(157, 30)
        Me.TxtRecieveBy.TabIndex = 6
        '
        'DateReceipt
        '
        Me.DateReceipt.CustomFormat = "dd/MM/yyyy"
        Me.DateReceipt.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.DateReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceipt.Location = New System.Drawing.Point(530, 37)
        Me.DateReceipt.Name = "DateReceipt"
        Me.DateReceipt.Size = New System.Drawing.Size(188, 32)
        Me.DateReceipt.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(529, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ថ្ងៃចេញវិក្កយបត្រ(Date Receipt)"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.TxtClientAge)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TxtClientSex)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtClientName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TxtClientNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(3, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 148)
        Me.Panel1.TabIndex = 0
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(239, 49)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(35, 32)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtClientAge
        '
        Me.TxtClientAge.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientAge.Location = New System.Drawing.Point(244, 110)
        Me.TxtClientAge.Name = "TxtClientAge"
        Me.TxtClientAge.ReadOnly = True
        Me.TxtClientAge.Size = New System.Drawing.Size(52, 32)
        Me.TxtClientAge.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(243, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 22)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Age:"
        '
        'TxtClientSex
        '
        Me.TxtClientSex.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientSex.Location = New System.Drawing.Point(178, 110)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(57, 32)
        Me.TxtClientSex.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(177, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 22)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Sex:"
        '
        'TxtClientName
        '
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(4, 110)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.ReadOnly = True
        Me.TxtClientName.Size = New System.Drawing.Size(168, 32)
        Me.TxtClientName.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 22)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Name:"
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.TxtClientNo.Location = New System.Drawing.Point(4, 49)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.Size = New System.Drawing.Size(231, 32)
        Me.TxtClientNo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 22)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Client No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Receive From:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-1, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 1)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'TxtAmmountInword
        '
        Me.TxtAmmountInword.BackColor = System.Drawing.Color.White
        Me.TxtAmmountInword.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmmountInword.Location = New System.Drawing.Point(140, 491)
        Me.TxtAmmountInword.Name = "TxtAmmountInword"
        Me.TxtAmmountInword.ReadOnly = True
        Me.TxtAmmountInword.Size = New System.Drawing.Size(403, 32)
        Me.TxtAmmountInword.TabIndex = 4
        '
        'TxtReceiptAmmount
        '
        Me.TxtReceiptAmmount.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptAmmount.Location = New System.Drawing.Point(140, 453)
        Me.TxtReceiptAmmount.Name = "TxtReceiptAmmount"
        Me.TxtReceiptAmmount.Size = New System.Drawing.Size(268, 32)
        Me.TxtReceiptAmmount.TabIndex = 3
        Me.TxtReceiptAmmount.Text = "0"
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.BackColor = System.Drawing.Color.White
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.TxtReceiptNo.ForeColor = System.Drawing.Color.Navy
        Me.TxtReceiptNo.Location = New System.Drawing.Point(315, 37)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.ReadOnly = True
        Me.TxtReceiptNo.Size = New System.Drawing.Size(209, 32)
        Me.TxtReceiptNo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(608, 501)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(217, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "សំគាល់៖ បង់ប្រាក់ហើយមិនអាយដកវិញបាន"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(501, 461)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "អ្នកទទួលប្រាក់ (Received by):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 495)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ជាអក្សរ (In word):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 461)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ចំនួនទឹកប្រាក់ (Amount):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "លេខវិក្កយបត្រ (Receipt Nº)"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.NewClient)
        Me.TabControl1.Controls.Add(Me.FollowUP)
        Me.TabControl1.Controls.Add(Me.Medicine)
        Me.TabControl1.Controls.Add(Me.SpacialService)
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(3, 168)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(822, 267)
        Me.TabControl1.TabIndex = 7
        '
        'NewClient
        '
        Me.NewClient.Location = New System.Drawing.Point(4, 34)
        Me.NewClient.Name = "NewClient"
        Me.NewClient.Padding = New System.Windows.Forms.Padding(3)
        Me.NewClient.Size = New System.Drawing.Size(814, 229)
        Me.NewClient.TabIndex = 0
        Me.NewClient.Text = "New Client"
        Me.NewClient.UseVisualStyleBackColor = True
        '
        'FollowUP
        '
        Me.FollowUP.Location = New System.Drawing.Point(4, 34)
        Me.FollowUP.Name = "FollowUP"
        Me.FollowUP.Padding = New System.Windows.Forms.Padding(3)
        Me.FollowUP.Size = New System.Drawing.Size(814, 229)
        Me.FollowUP.TabIndex = 1
        Me.FollowUP.Text = "Follow UP"
        Me.FollowUP.UseVisualStyleBackColor = True
        '
        'Medicine
        '
        Me.Medicine.Controls.Add(Me.GridEX1)
        Me.Medicine.Controls.Add(Me.Label18)
        Me.Medicine.Controls.Add(Me.Button1)
        Me.Medicine.Controls.Add(Me.Button2)
        Me.Medicine.Controls.Add(Me.CboItem)
        Me.Medicine.Controls.Add(Me.TxtQTY)
        Me.Medicine.Controls.Add(Me.Label19)
        Me.Medicine.Location = New System.Drawing.Point(4, 34)
        Me.Medicine.Name = "Medicine"
        Me.Medicine.Padding = New System.Windows.Forms.Padding(3)
        Me.Medicine.Size = New System.Drawing.Size(814, 229)
        Me.Medicine.TabIndex = 2
        Me.Medicine.Text = "Medicine"
        Me.Medicine.UseVisualStyleBackColor = True
        '
        'SpacialService
        '
        Me.SpacialService.Controls.Add(Me.GridServiceMed)
        Me.SpacialService.Controls.Add(Me.Label17)
        Me.SpacialService.Controls.Add(Me.CboPackage)
        Me.SpacialService.Controls.Add(Me.Label16)
        Me.SpacialService.Controls.Add(Me.BtnRemoveItem)
        Me.SpacialService.Controls.Add(Me.BtnAddItem)
        Me.SpacialService.Controls.Add(Me.CboSkill)
        Me.SpacialService.Controls.Add(Me.TxtSpacialServicePrice)
        Me.SpacialService.Controls.Add(Me.Label9)
        Me.SpacialService.Location = New System.Drawing.Point(4, 34)
        Me.SpacialService.Name = "SpacialService"
        Me.SpacialService.Padding = New System.Windows.Forms.Padding(3)
        Me.SpacialService.Size = New System.Drawing.Size(814, 229)
        Me.SpacialService.TabIndex = 3
        Me.SpacialService.Text = "Spacial Service"
        Me.SpacialService.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(223, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 22)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Select Package"
        '
        'CboPackage
        '
        Me.CboPackage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboPackage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboPackage.FormattingEnabled = True
        Me.CboPackage.Location = New System.Drawing.Point(227, 28)
        Me.CboPackage.Name = "CboPackage"
        Me.CboPackage.Size = New System.Drawing.Size(265, 30)
        Me.CboPackage.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(510, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 22)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Price"
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveItem.FlatAppearance.BorderSize = 0
        Me.BtnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.BtnRemoveItem.Location = New System.Drawing.Point(753, 29)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(42, 30)
        Me.BtnRemoveItem.TabIndex = 18
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
        Me.BtnAddItem.Location = New System.Drawing.Point(706, 29)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(42, 30)
        Me.BtnAddItem.TabIndex = 17
        Me.BtnAddItem.Text = "+"
        Me.BtnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'CboSkill
        '
        Me.CboSkill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSkill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSkill.FormattingEnabled = True
        Me.CboSkill.Location = New System.Drawing.Point(8, 28)
        Me.CboSkill.Name = "CboSkill"
        Me.CboSkill.Size = New System.Drawing.Size(213, 30)
        Me.CboSkill.TabIndex = 16
        '
        'TxtSpacialServicePrice
        '
        Me.TxtSpacialServicePrice.Location = New System.Drawing.Point(514, 29)
        Me.TxtSpacialServicePrice.Name = "TxtSpacialServicePrice"
        Me.TxtSpacialServicePrice.Size = New System.Drawing.Size(186, 30)
        Me.TxtSpacialServicePrice.TabIndex = 15
        Me.TxtSpacialServicePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 22)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Select Skill"
        '
        'GridServiceMed
        '
        Me.GridServiceMed.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridServiceMed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridServiceMed.BackColor = System.Drawing.Color.White
        Me.GridServiceMed.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridServiceMed_DesignTimeLayout.LayoutString = resources.GetString("GridServiceMed_DesignTimeLayout.LayoutString")
        Me.GridServiceMed.DesignTimeLayout = GridServiceMed_DesignTimeLayout
        Me.GridServiceMed.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridServiceMed.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridServiceMed.GroupByBoxVisible = False
        Me.GridServiceMed.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridServiceMed.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridServiceMed.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridServiceMed.Location = New System.Drawing.Point(9, 64)
        Me.GridServiceMed.Name = "GridServiceMed"
        Me.GridServiceMed.RecordNavigator = True
        Me.GridServiceMed.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridServiceMed.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridServiceMed.Size = New System.Drawing.Size(793, 161)
        Me.GridServiceMed.TabIndex = 22
        Me.GridServiceMed.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(356, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 22)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "QTY"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(605, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 31)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "-"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(556, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "+"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CboItem
        '
        Me.CboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboItem.FormattingEnabled = True
        Me.CboItem.Location = New System.Drawing.Point(6, 28)
        Me.CboItem.Name = "CboItem"
        Me.CboItem.Size = New System.Drawing.Size(348, 30)
        Me.CboItem.TabIndex = 14
        '
        'TxtQTY
        '
        Me.TxtQTY.Location = New System.Drawing.Point(356, 28)
        Me.TxtQTY.Name = "TxtQTY"
        Me.TxtQTY.Size = New System.Drawing.Size(186, 30)
        Me.TxtQTY.TabIndex = 13
        Me.TxtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 22)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Select Medicine"
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.BackColor = System.Drawing.Color.White
        Me.GridEX1.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridEX1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEX1.Location = New System.Drawing.Point(6, 66)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.Size = New System.Drawing.Size(800, 158)
        Me.GridEX1.TabIndex = 18
        Me.GridEX1.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'FrmIssueReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 649)
        Me.Controls.Add(Me.PanelMain)
        Me.Name = "FrmIssueReceipt"
        Me.Text = "FrmIssueReceipt"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GBSocialServieType.ResumeLayout(False)
        Me.GBSocialServieType.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Medicine.ResumeLayout(False)
        Me.Medicine.PerformLayout()
        Me.SpacialService.ResumeLayout(False)
        Me.SpacialService.PerformLayout()
        CType(Me.GridServiceMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents LblPrinting As System.Windows.Forms.Label
    Friend WithEvents PicLoading As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GBSocialServieType As System.Windows.Forms.GroupBox
    Friend WithEvents RadServiceB As System.Windows.Forms.RadioButton
    Friend WithEvents RadServiceC As System.Windows.Forms.RadioButton
    Friend WithEvents RadServiceA As System.Windows.Forms.RadioButton
    Friend WithEvents TxtRecieveBy As System.Windows.Forms.TextBox
    Friend WithEvents DateReceipt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtClientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtClientSex As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtAmmountInword As System.Windows.Forms.TextBox
    Friend WithEvents TxtReceiptAmmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents NewClient As System.Windows.Forms.TabPage
    Friend WithEvents FollowUP As System.Windows.Forms.TabPage
    Friend WithEvents Medicine As System.Windows.Forms.TabPage
    Friend WithEvents SpacialService As System.Windows.Forms.TabPage
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CboPackage As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents CboSkill As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSpacialServicePrice As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GridServiceMed As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CboItem As System.Windows.Forms.ComboBox
    Friend WithEvents TxtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
End Class
