<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewClientReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewClientReceipt))
        Me.PanelMain = New System.Windows.Forms.Panel
        Me.LblSaveOption = New System.Windows.Forms.Label
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
        Me.TxtAmmountInword = New System.Windows.Forms.TextBox
        Me.TxtReceiptAmmount = New System.Windows.Forms.TextBox
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ErrNewReceipt = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BGSaveAndPrintReceipt = New System.ComponentModel.BackgroundWorker
        Me.TxtClientNameKH = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanelMain.SuspendLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GBSocialServieType.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrNewReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.LblSaveOption)
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
        Me.PanelMain.Size = New System.Drawing.Size(749, 434)
        Me.PanelMain.TabIndex = 0
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(229, 409)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(20, 25)
        Me.LblSaveOption.TabIndex = 205
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'LblPrinting
        '
        Me.LblPrinting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPrinting.AutoSize = True
        Me.LblPrinting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LblPrinting.Location = New System.Drawing.Point(4, 380)
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
        Me.PicLoading.Location = New System.Drawing.Point(5, 405)
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
        Me.BtnClose.Location = New System.Drawing.Point(641, 390)
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
        Me.BtnSave.Location = New System.Drawing.Point(535, 390)
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
        Me.Panel3.Location = New System.Drawing.Point(5, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(736, 311)
        Me.Panel3.TabIndex = 0
        '
        'GBSocialServieType
        '
        Me.GBSocialServieType.BackColor = System.Drawing.Color.Transparent
        Me.GBSocialServieType.Controls.Add(Me.RadServiceB)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceC)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceA)
        Me.GBSocialServieType.Location = New System.Drawing.Point(3, 206)
        Me.GBSocialServieType.Name = "GBSocialServieType"
        Me.GBSocialServieType.Size = New System.Drawing.Size(433, 94)
        Me.GBSocialServieType.TabIndex = 5
        Me.GBSocialServieType.TabStop = False
        Me.GBSocialServieType.Text = "Social Economic Service Types"
        '
        'RadServiceB
        '
        Me.RadServiceB.AutoSize = True
        Me.RadServiceB.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceB.Location = New System.Drawing.Point(179, 39)
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
        Me.RadServiceC.Location = New System.Drawing.Point(312, 39)
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
        Me.RadServiceA.Location = New System.Drawing.Point(32, 39)
        Me.RadServiceA.Name = "RadServiceA"
        Me.RadServiceA.Size = New System.Drawing.Size(102, 33)
        Me.RadServiceA.TabIndex = 0
        Me.RadServiceA.TabStop = True
        Me.RadServiceA.Text = "Service A"
        Me.RadServiceA.UseVisualStyleBackColor = True
        '
        'TxtRecieveBy
        '
        Me.TxtRecieveBy.Location = New System.Drawing.Point(477, 239)
        Me.TxtRecieveBy.Name = "TxtRecieveBy"
        Me.TxtRecieveBy.ReadOnly = True
        Me.TxtRecieveBy.Size = New System.Drawing.Size(241, 30)
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
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.TxtClientNameKH)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtClientAge)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TxtClientSex)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtClientName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TxtClientNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(3, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 185)
        Me.Panel1.TabIndex = 0
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(261, 26)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(35, 32)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtClientAge
        '
        Me.TxtClientAge.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientAge.Location = New System.Drawing.Point(216, 25)
        Me.TxtClientAge.Name = "TxtClientAge"
        Me.TxtClientAge.ReadOnly = True
        Me.TxtClientAge.Size = New System.Drawing.Size(34, 32)
        Me.TxtClientAge.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(215, 1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 22)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Age:"
        '
        'TxtClientSex
        '
        Me.TxtClientSex.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientSex.Location = New System.Drawing.Point(178, 25)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(33, 32)
        Me.TxtClientSex.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(177, 1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 22)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Sex:"
        '
        'TxtClientName
        '
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(3, 85)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.ReadOnly = True
        Me.TxtClientName.Size = New System.Drawing.Size(293, 32)
        Me.TxtClientName.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 22)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Name:"
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.TxtClientNo.Location = New System.Drawing.Point(3, 24)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.Size = New System.Drawing.Size(168, 32)
        Me.TxtClientNo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 22)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Client No:"
        '
        'TxtAmmountInword
        '
        Me.TxtAmmountInword.BackColor = System.Drawing.Color.White
        Me.TxtAmmountInword.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmmountInword.Location = New System.Drawing.Point(315, 168)
        Me.TxtAmmountInword.Name = "TxtAmmountInword"
        Me.TxtAmmountInword.ReadOnly = True
        Me.TxtAmmountInword.Size = New System.Drawing.Size(403, 32)
        Me.TxtAmmountInword.TabIndex = 4
        '
        'TxtReceiptAmmount
        '
        Me.TxtReceiptAmmount.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptAmmount.Location = New System.Drawing.Point(315, 102)
        Me.TxtReceiptAmmount.Name = "TxtReceiptAmmount"
        Me.TxtReceiptAmmount.Size = New System.Drawing.Size(403, 32)
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
        Me.Label11.Location = New System.Drawing.Point(505, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(217, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "សំគាល់៖ បង់ប្រាក់ហើយមិនអាយដកវិញបាន"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(474, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "អ្នកទទួលប្រាក់ (Received by):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(315, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ជាអក្សរ (In word):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(315, 74)
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
        'ErrNewReceipt
        '
        Me.ErrNewReceipt.ContainerControl = Me
        '
        'BGSaveAndPrintReceipt
        '
        '
        'TxtClientNameKH
        '
        Me.TxtClientNameKH.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameKH.Location = New System.Drawing.Point(1, 143)
        Me.TxtClientNameKH.Name = "TxtClientNameKH"
        Me.TxtClientNameKH.ReadOnly = True
        Me.TxtClientNameKH.Size = New System.Drawing.Size(295, 37)
        Me.TxtClientNameKH.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Name KH:"
        '
        'NewClientReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 434)
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewClientReceipt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Client Receipt"
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
        CType(Me.ErrNewReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
    Friend WithEvents TxtAmmountInword As System.Windows.Forms.TextBox
    Friend WithEvents TxtReceiptAmmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GBSocialServieType As System.Windows.Forms.GroupBox
    Friend WithEvents RadServiceB As System.Windows.Forms.RadioButton
    Friend WithEvents RadServiceC As System.Windows.Forms.RadioButton
    Friend WithEvents RadServiceA As System.Windows.Forms.RadioButton
    Friend WithEvents PicLoading As System.Windows.Forms.PictureBox
    Friend WithEvents LblPrinting As System.Windows.Forms.Label
    Friend WithEvents ErrNewReceipt As System.Windows.Forms.ErrorProvider
    Friend WithEvents BGSaveAndPrintReceipt As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents TxtClientNameKH As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
