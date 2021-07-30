<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrescription))
        Dim GridPrescription_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.LblPrinting = New System.Windows.Forms.Label()
        Me.LblSaveOption = New System.Windows.Forms.Label()
        Me.PicLoading = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtMedicineOut = New System.Windows.Forms.TextBox()
        Me.TxtReceiptAmmount = New System.Windows.Forms.TextBox()
        Me.TxtServicePrice = New System.Windows.Forms.TextBox()
        Me.TxtAmmountInword = New System.Windows.Forms.TextBox()
        Me.RadMedicineOutcenter = New System.Windows.Forms.RadioButton()
        Me.RadMedicineIncenter = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCorrentQTY = New System.Windows.Forms.TextBox()
        Me.TxtPrescriptNote = New System.Windows.Forms.TextBox()
        Me.GridPrescription = New Janus.Windows.GridEX.GridEX()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateNextVisit = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtQTY = New System.Windows.Forms.TextBox()
        Me.TxtE = New System.Windows.Forms.TextBox()
        Me.TxtN = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnRemoveItem = New System.Windows.Forms.Button()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.CboItem = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtM = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAddMoreDoctor = New System.Windows.Forms.Button()
        Me.GBSocialServieType = New System.Windows.Forms.GroupBox()
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox()
        Me.LblSocialTypePrice = New System.Windows.Forms.Label()
        Me.LblCatName = New System.Windows.Forms.Label()
        Me.RadServiceB = New System.Windows.Forms.RadioButton()
        Me.LblCategoryId = New System.Windows.Forms.Label()
        Me.RadServiceC = New System.Windows.Forms.RadioButton()
        Me.RadServiceA = New System.Windows.Forms.RadioButton()
        Me.CboDoctor = New System.Windows.Forms.ComboBox()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.TxtClientAge = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtClientSex = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtClientName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DatePrescription = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrPrescription = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgLoadingPrescription = New System.ComponentModel.BackgroundWorker()
        Me.PanelMain.SuspendLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GBSocialServieType.SuspendLayout()
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.LblPrinting)
        Me.PanelMain.Controls.Add(Me.LblSaveOption)
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
        Me.PanelMain.Size = New System.Drawing.Size(932, 696)
        Me.PanelMain.TabIndex = 0
        '
        'LblPrinting
        '
        Me.LblPrinting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPrinting.AutoSize = True
        Me.LblPrinting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LblPrinting.Location = New System.Drawing.Point(4, 643)
        Me.LblPrinting.Name = "LblPrinting"
        Me.LblPrinting.Size = New System.Drawing.Size(124, 25)
        Me.LblPrinting.TabIndex = 204
        Me.LblPrinting.Text = "Printing Receipt..."
        Me.LblPrinting.Visible = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(187, 661)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(20, 25)
        Me.LblSaveOption.TabIndex = 18
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'PicLoading
        '
        Me.PicLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicLoading.Image = Global.KTGSYS.My.Resources.Resources.loadgraphic
        Me.PicLoading.Location = New System.Drawing.Point(5, 668)
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
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(827, 652)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 39)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Cancel"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(721, 652)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 39)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(337, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(Client Prescription)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Mool1", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(358, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "វេជ្ជបញ្ជា"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtMedicineOut)
        Me.Panel3.Controls.Add(Me.TxtReceiptAmmount)
        Me.Panel3.Controls.Add(Me.TxtServicePrice)
        Me.Panel3.Controls.Add(Me.TxtAmmountInword)
        Me.Panel3.Controls.Add(Me.RadMedicineOutcenter)
        Me.Panel3.Controls.Add(Me.RadMedicineIncenter)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TxtCorrentQTY)
        Me.Panel3.Controls.Add(Me.TxtPrescriptNote)
        Me.Panel3.Controls.Add(Me.GridPrescription)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.DateNextVisit)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.TxtQTY)
        Me.Panel3.Controls.Add(Me.TxtE)
        Me.Panel3.Controls.Add(Me.TxtN)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.BtnRemoveItem)
        Me.Panel3.Controls.Add(Me.BtnAddItem)
        Me.Panel3.Controls.Add(Me.CboItem)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TxtM)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Font = New System.Drawing.Font("Khmer OS Battambang", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(5, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(921, 573)
        Me.Panel3.TabIndex = 0
        '
        'TxtMedicineOut
        '
        Me.TxtMedicineOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMedicineOut.Enabled = False
        Me.TxtMedicineOut.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedicineOut.Location = New System.Drawing.Point(317, 167)
        Me.TxtMedicineOut.Name = "TxtMedicineOut"
        Me.TxtMedicineOut.Size = New System.Drawing.Size(264, 32)
        Me.TxtMedicineOut.TabIndex = 23
        Me.TxtMedicineOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtReceiptAmmount
        '
        Me.TxtReceiptAmmount.BackColor = System.Drawing.Color.White
        Me.TxtReceiptAmmount.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptAmmount.Location = New System.Drawing.Point(746, 162)
        Me.TxtReceiptAmmount.Name = "TxtReceiptAmmount"
        Me.TxtReceiptAmmount.ReadOnly = True
        Me.TxtReceiptAmmount.Size = New System.Drawing.Size(59, 32)
        Me.TxtReceiptAmmount.TabIndex = 205
        Me.TxtReceiptAmmount.Text = "0"
        Me.TxtReceiptAmmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtReceiptAmmount.Visible = False
        '
        'TxtServicePrice
        '
        Me.TxtServicePrice.Location = New System.Drawing.Point(746, 200)
        Me.TxtServicePrice.Name = "TxtServicePrice"
        Me.TxtServicePrice.Size = New System.Drawing.Size(59, 35)
        Me.TxtServicePrice.TabIndex = 16
        Me.TxtServicePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtServicePrice.Visible = False
        '
        'TxtAmmountInword
        '
        Me.TxtAmmountInword.BackColor = System.Drawing.Color.White
        Me.TxtAmmountInword.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmmountInword.Location = New System.Drawing.Point(671, 162)
        Me.TxtAmmountInword.Name = "TxtAmmountInword"
        Me.TxtAmmountInword.ReadOnly = True
        Me.TxtAmmountInword.Size = New System.Drawing.Size(59, 32)
        Me.TxtAmmountInword.TabIndex = 206
        Me.TxtAmmountInword.Visible = False
        '
        'RadMedicineOutcenter
        '
        Me.RadMedicineOutcenter.AutoSize = True
        Me.RadMedicineOutcenter.Location = New System.Drawing.Point(317, 138)
        Me.RadMedicineOutcenter.Name = "RadMedicineOutcenter"
        Me.RadMedicineOutcenter.Size = New System.Drawing.Size(165, 31)
        Me.RadMedicineOutcenter.TabIndex = 22
        Me.RadMedicineOutcenter.Text = "Medicince out center"
        Me.RadMedicineOutcenter.UseVisualStyleBackColor = True
        '
        'RadMedicineIncenter
        '
        Me.RadMedicineIncenter.AutoSize = True
        Me.RadMedicineIncenter.Checked = True
        Me.RadMedicineIncenter.Location = New System.Drawing.Point(4, 134)
        Me.RadMedicineIncenter.Name = "RadMedicineIncenter"
        Me.RadMedicineIncenter.Size = New System.Drawing.Size(156, 31)
        Me.RadMedicineIncenter.TabIndex = 21
        Me.RadMedicineIncenter.TabStop = True
        Me.RadMedicineIncenter.Text = "Medicince in center"
        Me.RadMedicineIncenter.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(476, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 22)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "In stock Pharmacy"
        '
        'TxtCorrentQTY
        '
        Me.TxtCorrentQTY.BackColor = System.Drawing.Color.White
        Me.TxtCorrentQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCorrentQTY.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorrentQTY.Location = New System.Drawing.Point(475, 226)
        Me.TxtCorrentQTY.Name = "TxtCorrentQTY"
        Me.TxtCorrentQTY.ReadOnly = True
        Me.TxtCorrentQTY.Size = New System.Drawing.Size(106, 32)
        Me.TxtCorrentQTY.TabIndex = 19
        Me.TxtCorrentQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPrescriptNote
        '
        Me.TxtPrescriptNote.Location = New System.Drawing.Point(5, 501)
        Me.TxtPrescriptNote.Multiline = True
        Me.TxtPrescriptNote.Name = "TxtPrescriptNote"
        Me.TxtPrescriptNote.Size = New System.Drawing.Size(431, 63)
        Me.TxtPrescriptNote.TabIndex = 18
        '
        'GridPrescription
        '
        Me.GridPrescription.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPrescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPrescription.BackColor = System.Drawing.Color.White
        Me.GridPrescription.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridPrescription_DesignTimeLayout.LayoutString = resources.GetString("GridPrescription_DesignTimeLayout.LayoutString")
        Me.GridPrescription.DesignTimeLayout = GridPrescription_DesignTimeLayout
        Me.GridPrescription.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridPrescription.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPrescription.GroupByBoxVisible = False
        Me.GridPrescription.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridPrescription.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPrescription.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPrescription.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPrescription.Location = New System.Drawing.Point(3, 262)
        Me.GridPrescription.Name = "GridPrescription"
        Me.GridPrescription.RecordNavigator = True
        Me.GridPrescription.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridPrescription.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPrescription.Size = New System.Drawing.Size(912, 233)
        Me.GridPrescription.TabIndex = 8
        Me.GridPrescription.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridPrescription.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(317, 202)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 22)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Total"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(260, 202)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 22)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "E"
        '
        'DateNextVisit
        '
        Me.DateNextVisit.Checked = False
        Me.DateNextVisit.CustomFormat = "dd/MM/yyyy"
        Me.DateNextVisit.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.DateNextVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateNextVisit.Location = New System.Drawing.Point(449, 530)
        Me.DateNextVisit.Name = "DateNextVisit"
        Me.DateNextVisit.ShowCheckBox = True
        Me.DateNextVisit.Size = New System.Drawing.Size(162, 32)
        Me.DateNextVisit.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(30, 202)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 22)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "M"
        '
        'TxtQTY
        '
        Me.TxtQTY.BackColor = System.Drawing.Color.White
        Me.TxtQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQTY.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQTY.Location = New System.Drawing.Point(317, 226)
        Me.TxtQTY.Name = "TxtQTY"
        Me.TxtQTY.Size = New System.Drawing.Size(119, 32)
        Me.TxtQTY.TabIndex = 5
        Me.TxtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtE
        '
        Me.TxtE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtE.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtE.Location = New System.Drawing.Point(226, 226)
        Me.TxtE.Name = "TxtE"
        Me.TxtE.Size = New System.Drawing.Size(74, 32)
        Me.TxtE.TabIndex = 4
        Me.TxtE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtN
        '
        Me.TxtN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtN.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtN.Location = New System.Drawing.Point(115, 226)
        Me.TxtN.Name = "TxtN"
        Me.TxtN.Size = New System.Drawing.Size(71, 32)
        Me.TxtN.TabIndex = 3
        Me.TxtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(145, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 22)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "N"
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveItem.FlatAppearance.BorderSize = 0
        Me.BtnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.BtnRemoveItem.Image = CType(resources.GetObject("BtnRemoveItem.Image"), System.Drawing.Image)
        Me.BtnRemoveItem.Location = New System.Drawing.Point(633, 224)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(37, 32)
        Me.BtnRemoveItem.TabIndex = 7
        Me.BtnRemoveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRemoveItem.UseVisualStyleBackColor = False
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddItem.FlatAppearance.BorderSize = 0
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.ForeColor = System.Drawing.Color.White
        Me.BtnAddItem.Image = CType(resources.GetObject("BtnAddItem.Image"), System.Drawing.Image)
        Me.BtnAddItem.Location = New System.Drawing.Point(591, 224)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(37, 32)
        Me.BtnAddItem.TabIndex = 6
        Me.BtnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'CboItem
        '
        Me.CboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboItem.FormattingEnabled = True
        Me.CboItem.Location = New System.Drawing.Point(4, 166)
        Me.CboItem.Name = "CboItem"
        Me.CboItem.Size = New System.Drawing.Size(296, 35)
        Me.CboItem.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(452, 507)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Date next visit:"
        '
        'TxtM
        '
        Me.TxtM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtM.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtM.Location = New System.Drawing.Point(5, 226)
        Me.TxtM.Name = "TxtM"
        Me.TxtM.Size = New System.Drawing.Size(69, 32)
        Me.TxtM.TabIndex = 2
        Me.TxtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnAddMoreDoctor)
        Me.Panel1.Controls.Add(Me.GBSocialServieType)
        Me.Panel1.Controls.Add(Me.CboDoctor)
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.TxtClientAge)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TxtClientSex)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtClientName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TxtClientNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.DatePrescription)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 128)
        Me.Panel1.TabIndex = 0
        '
        'BtnAddMoreDoctor
        '
        Me.BtnAddMoreDoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMoreDoctor.FlatAppearance.BorderSize = 0
        Me.BtnAddMoreDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMoreDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMoreDoctor.ForeColor = System.Drawing.Color.White
        Me.BtnAddMoreDoctor.Image = CType(resources.GetObject("BtnAddMoreDoctor.Image"), System.Drawing.Image)
        Me.BtnAddMoreDoctor.Location = New System.Drawing.Point(509, 91)
        Me.BtnAddMoreDoctor.Name = "BtnAddMoreDoctor"
        Me.BtnAddMoreDoctor.Size = New System.Drawing.Size(35, 30)
        Me.BtnAddMoreDoctor.TabIndex = 207
        Me.BtnAddMoreDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddMoreDoctor.UseVisualStyleBackColor = False
        '
        'GBSocialServieType
        '
        Me.GBSocialServieType.BackColor = System.Drawing.Color.Transparent
        Me.GBSocialServieType.Controls.Add(Me.TxtReceiptNo)
        Me.GBSocialServieType.Controls.Add(Me.LblSocialTypePrice)
        Me.GBSocialServieType.Controls.Add(Me.LblCatName)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceB)
        Me.GBSocialServieType.Controls.Add(Me.LblCategoryId)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceC)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceA)
        Me.GBSocialServieType.Location = New System.Drawing.Point(667, -2)
        Me.GBSocialServieType.Name = "GBSocialServieType"
        Me.GBSocialServieType.Size = New System.Drawing.Size(240, 121)
        Me.GBSocialServieType.TabIndex = 11
        Me.GBSocialServieType.TabStop = False
        Me.GBSocialServieType.Text = "Social Economic Service Types"
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.BackColor = System.Drawing.Color.White
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.TxtReceiptNo.ForeColor = System.Drawing.Color.Navy
        Me.TxtReceiptNo.Location = New System.Drawing.Point(110, 55)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.ReadOnly = True
        Me.TxtReceiptNo.Size = New System.Drawing.Size(116, 32)
        Me.TxtReceiptNo.TabIndex = 16
        Me.TxtReceiptNo.Visible = False
        '
        'LblSocialTypePrice
        '
        Me.LblSocialTypePrice.AutoSize = True
        Me.LblSocialTypePrice.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSocialTypePrice.Location = New System.Drawing.Point(152, 92)
        Me.LblSocialTypePrice.Name = "LblSocialTypePrice"
        Me.LblSocialTypePrice.Size = New System.Drawing.Size(17, 22)
        Me.LblSocialTypePrice.TabIndex = 14
        Me.LblSocialTypePrice.Text = "0"
        Me.LblSocialTypePrice.Visible = False
        '
        'LblCatName
        '
        Me.LblCatName.AutoSize = True
        Me.LblCatName.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCatName.Location = New System.Drawing.Point(152, 34)
        Me.LblCatName.Name = "LblCatName"
        Me.LblCatName.Size = New System.Drawing.Size(17, 22)
        Me.LblCatName.TabIndex = 15
        Me.LblCatName.Text = "0"
        Me.LblCatName.Visible = False
        '
        'RadServiceB
        '
        Me.RadServiceB.AutoSize = True
        Me.RadServiceB.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceB.Location = New System.Drawing.Point(11, 56)
        Me.RadServiceB.Name = "RadServiceB"
        Me.RadServiceB.Size = New System.Drawing.Size(93, 33)
        Me.RadServiceB.TabIndex = 1
        Me.RadServiceB.Text = "Servic B"
        Me.RadServiceB.UseVisualStyleBackColor = True
        '
        'LblCategoryId
        '
        Me.LblCategoryId.AutoSize = True
        Me.LblCategoryId.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategoryId.Location = New System.Drawing.Point(152, 67)
        Me.LblCategoryId.Name = "LblCategoryId"
        Me.LblCategoryId.Size = New System.Drawing.Size(17, 22)
        Me.LblCategoryId.TabIndex = 12
        Me.LblCategoryId.Text = "0"
        Me.LblCategoryId.Visible = False
        '
        'RadServiceC
        '
        Me.RadServiceC.AutoSize = True
        Me.RadServiceC.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceC.Location = New System.Drawing.Point(11, 89)
        Me.RadServiceC.Name = "RadServiceC"
        Me.RadServiceC.Size = New System.Drawing.Size(103, 33)
        Me.RadServiceC.TabIndex = 2
        Me.RadServiceC.TabStop = True
        Me.RadServiceC.Text = "Service C"
        Me.RadServiceC.UseVisualStyleBackColor = True
        '
        'RadServiceA
        '
        Me.RadServiceA.AutoSize = True
        Me.RadServiceA.Checked = True
        Me.RadServiceA.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceA.Location = New System.Drawing.Point(11, 23)
        Me.RadServiceA.Name = "RadServiceA"
        Me.RadServiceA.Size = New System.Drawing.Size(102, 33)
        Me.RadServiceA.TabIndex = 0
        Me.RadServiceA.TabStop = True
        Me.RadServiceA.Text = "Service A"
        Me.RadServiceA.UseVisualStyleBackColor = True
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(313, 87)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(192, 35)
        Me.CboDoctor.TabIndex = 5
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(239, 28)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(35, 32)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtClientAge
        '
        Me.TxtClientAge.BackColor = System.Drawing.Color.White
        Me.TxtClientAge.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientAge.Location = New System.Drawing.Point(244, 89)
        Me.TxtClientAge.Name = "TxtClientAge"
        Me.TxtClientAge.ReadOnly = True
        Me.TxtClientAge.Size = New System.Drawing.Size(52, 32)
        Me.TxtClientAge.TabIndex = 4
        Me.TxtClientAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(243, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 27)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Age:"
        '
        'TxtClientSex
        '
        Me.TxtClientSex.BackColor = System.Drawing.Color.White
        Me.TxtClientSex.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientSex.Location = New System.Drawing.Point(178, 89)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(57, 32)
        Me.TxtClientSex.TabIndex = 3
        Me.TxtClientSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(177, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 27)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Sex:"
        '
        'TxtClientName
        '
        Me.TxtClientName.BackColor = System.Drawing.Color.White
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(4, 89)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.ReadOnly = True
        Me.TxtClientName.Size = New System.Drawing.Size(168, 32)
        Me.TxtClientName.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 27)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Name:"
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.TxtClientNo.Location = New System.Drawing.Point(4, 28)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.Size = New System.Drawing.Size(231, 32)
        Me.TxtClientNo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 27)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Client No:"
        '
        'DatePrescription
        '
        Me.DatePrescription.CustomFormat = "dd/MM/yyyy"
        Me.DatePrescription.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.DatePrescription.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePrescription.Location = New System.Drawing.Point(313, 28)
        Me.DatePrescription.Name = "DatePrescription"
        Me.DatePrescription.Size = New System.Drawing.Size(192, 32)
        Me.DatePrescription.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Prescription by:"
        '
        'ErrPrescription
        '
        Me.ErrPrescription.ContainerControl = Me
        '
        'BgLoadingPrescription
        '
        '
        'FormPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 696)
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrescription"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrescription"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GBSocialServieType.ResumeLayout(False)
        Me.GBSocialServieType.PerformLayout()
        CType(Me.ErrPrescription, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ErrPrescription As System.Windows.Forms.ErrorProvider
    Friend WithEvents BgLoadingPrescription As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadMedicineOutcenter As System.Windows.Forms.RadioButton
    Friend WithEvents RadMedicineIncenter As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCorrentQTY As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrescriptNote As System.Windows.Forms.TextBox
    Friend WithEvents GridPrescription As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DateNextVisit As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtQTY As System.Windows.Forms.TextBox
    Friend WithEvents TxtE As System.Windows.Forms.TextBox
    Friend WithEvents TxtN As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents CboItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtM As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnAddMoreDoctor As System.Windows.Forms.Button
    Friend WithEvents TxtAmmountInword As System.Windows.Forms.TextBox
    Friend WithEvents TxtServicePrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtReceiptAmmount As System.Windows.Forms.TextBox
    Friend WithEvents GBSocialServieType As System.Windows.Forms.GroupBox
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents LblSocialTypePrice As System.Windows.Forms.Label
    Friend WithEvents LblCatName As System.Windows.Forms.Label
    Friend WithEvents RadServiceB As System.Windows.Forms.RadioButton
    Friend WithEvents LblCategoryId As System.Windows.Forms.Label
    Friend WithEvents RadServiceC As System.Windows.Forms.RadioButton
    Friend WithEvents RadServiceA As System.Windows.Forms.RadioButton
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtClientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtClientSex As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DatePrescription As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMedicineOut As System.Windows.Forms.TextBox
End Class
