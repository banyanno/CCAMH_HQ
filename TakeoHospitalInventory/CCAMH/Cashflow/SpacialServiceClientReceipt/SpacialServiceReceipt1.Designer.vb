<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpacialServiceReceipt1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpacialServiceReceipt1))
        Dim GridServiceMed_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.PanelMain = New System.Windows.Forms.Panel
        Me.LblPrinting = New System.Windows.Forms.Label
        Me.PicLoading = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.CboPackage = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.BtnRemoveItem = New System.Windows.Forms.Button
        Me.BtnAddItem = New System.Windows.Forms.Button
        Me.CboSkill = New System.Windows.Forms.ComboBox
        Me.TxtSpacialServicePrice = New System.Windows.Forms.TextBox
        Me.TxtRecieveBy = New System.Windows.Forms.TextBox
        Me.GridServiceMed = New Janus.Windows.GridEX.GridEX
        Me.VSMInterface = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
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
        Me.DateReceipt = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.TxtAmmountInword = New System.Windows.Forms.TextBox
        Me.TxtReceiptAmmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GBSocialServieType = New System.Windows.Forms.GroupBox
        Me.LblSocialType = New System.Windows.Forms.Label
        Me.LblSpacialName = New System.Windows.Forms.Label
        Me.LblServicePrice = New System.Windows.Forms.Label
        Me.RadServiceB = New System.Windows.Forms.RadioButton
        Me.LblSpacialID = New System.Windows.Forms.Label
        Me.RadServiceC = New System.Windows.Forms.RadioButton
        Me.RadServiceA = New System.Windows.Forms.RadioButton
        Me.ErrNewReceipt = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BGSaveAndPrintReceipt = New System.ComponentModel.BackgroundWorker
        Me.PanelMain.SuspendLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GridServiceMed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GBSocialServieType.SuspendLayout()
        CType(Me.ErrNewReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelMain.Controls.Add(Me.Panel1)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(818, 714)
        Me.PanelMain.TabIndex = 1
        '
        'LblPrinting
        '
        Me.LblPrinting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPrinting.AutoSize = True
        Me.LblPrinting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LblPrinting.Location = New System.Drawing.Point(4, 660)
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
        Me.PicLoading.Location = New System.Drawing.Point(5, 685)
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
        Me.BtnClose.Location = New System.Drawing.Point(709, 667)
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
        Me.BtnSave.Location = New System.Drawing.Point(603, 667)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 37)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Add"
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
        Me.Label2.Size = New System.Drawing.Size(234, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(Cash Receipt for Spacial Service)"
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
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.CboPackage)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.BtnRemoveItem)
        Me.Panel3.Controls.Add(Me.BtnAddItem)
        Me.Panel3.Controls.Add(Me.CboSkill)
        Me.Panel3.Controls.Add(Me.TxtSpacialServicePrice)
        Me.Panel3.Controls.Add(Me.GBSocialServieType)
        Me.Panel3.Controls.Add(Me.TxtRecieveBy)
        Me.Panel3.Controls.Add(Me.GridServiceMed)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TxtAmmountInword)
        Me.Panel3.Controls.Add(Me.TxtReceiptAmmount)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Font = New System.Drawing.Font("Khmer OS Battambang", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(5, 147)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(804, 532)
        Me.Panel3.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(220, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 34)
        Me.Button1.TabIndex = 16
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(264, 169)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 22)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Select Package"
        '
        'CboPackage
        '
        Me.CboPackage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboPackage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboPackage.FormattingEnabled = True
        Me.CboPackage.Location = New System.Drawing.Point(259, 194)
        Me.CboPackage.Name = "CboPackage"
        Me.CboPackage.Size = New System.Drawing.Size(246, 35)
        Me.CboPackage.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(592, 171)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 22)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Price"
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveItem.FlatAppearance.BorderSize = 0
        Me.BtnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.BtnRemoveItem.Image = CType(resources.GetObject("BtnRemoveItem.Image"), System.Drawing.Image)
        Me.BtnRemoveItem.Location = New System.Drawing.Point(738, 196)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(35, 33)
        Me.BtnRemoveItem.TabIndex = 10
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
        Me.BtnAddItem.Location = New System.Drawing.Point(702, 196)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(32, 33)
        Me.BtnAddItem.TabIndex = 9
        Me.BtnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'CboSkill
        '
        Me.CboSkill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSkill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSkill.FormattingEnabled = True
        Me.CboSkill.Location = New System.Drawing.Point(5, 194)
        Me.CboSkill.Name = "CboSkill"
        Me.CboSkill.Size = New System.Drawing.Size(213, 35)
        Me.CboSkill.TabIndex = 8
        '
        'TxtSpacialServicePrice
        '
        Me.TxtSpacialServicePrice.Location = New System.Drawing.Point(511, 195)
        Me.TxtSpacialServicePrice.Name = "TxtSpacialServicePrice"
        Me.TxtSpacialServicePrice.Size = New System.Drawing.Size(186, 35)
        Me.TxtSpacialServicePrice.TabIndex = 7
        Me.TxtSpacialServicePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRecieveBy
        '
        Me.TxtRecieveBy.Location = New System.Drawing.Point(556, 522)
        Me.TxtRecieveBy.Name = "TxtRecieveBy"
        Me.TxtRecieveBy.ReadOnly = True
        Me.TxtRecieveBy.Size = New System.Drawing.Size(241, 35)
        Me.TxtRecieveBy.TabIndex = 6
        Me.TxtRecieveBy.Visible = False
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
        Me.GridServiceMed.Location = New System.Drawing.Point(5, 236)
        Me.GridServiceMed.Name = "GridServiceMed"
        Me.GridServiceMed.RecordNavigator = True
        Me.GridServiceMed.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridServiceMed.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridServiceMed.Size = New System.Drawing.Size(791, 201)
        Me.GridServiceMed.TabIndex = 6
        Me.GridServiceMed.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridServiceMed.VisualStyleManager = Me.VSMInterface
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
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.Black
        Me.VSMInterface.ColorSchemes.Add(JanusColorScheme1)
        Me.VSMInterface.DefaultColorScheme = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(528, 563)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(269, 27)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "សំគាល់៖ បង់ប្រាក់ហើយមិនអាយដកវិញបាន"
        Me.Label11.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 22)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Service"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.TxtClientAge)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TxtClientSex)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtClientName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TxtClientNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.DateReceipt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtReceiptNo)
        Me.Panel1.Location = New System.Drawing.Point(549, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 164)
        Me.Panel1.TabIndex = 0
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(239, 57)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(35, 32)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.UseVisualStyleBackColor = True
        Me.BtnFind.Visible = False
        '
        'TxtClientAge
        '
        Me.TxtClientAge.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientAge.Location = New System.Drawing.Point(244, 118)
        Me.TxtClientAge.Name = "TxtClientAge"
        Me.TxtClientAge.ReadOnly = True
        Me.TxtClientAge.Size = New System.Drawing.Size(52, 32)
        Me.TxtClientAge.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(243, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 25)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Age:"
        '
        'TxtClientSex
        '
        Me.TxtClientSex.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientSex.Location = New System.Drawing.Point(178, 118)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(57, 32)
        Me.TxtClientSex.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(177, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 25)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Sex:"
        '
        'TxtClientName
        '
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(4, 118)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.ReadOnly = True
        Me.TxtClientName.Size = New System.Drawing.Size(168, 32)
        Me.TxtClientName.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 25)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Name:"
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.TxtClientNo.Location = New System.Drawing.Point(4, 57)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.ReadOnly = True
        Me.TxtClientNo.Size = New System.Drawing.Size(231, 32)
        Me.TxtClientNo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 25)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Client No:"
        '
        'DateReceipt
        '
        Me.DateReceipt.CustomFormat = "dd/MM/yyyy"
        Me.DateReceipt.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.DateReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceipt.Location = New System.Drawing.Point(302, 118)
        Me.DateReceipt.Name = "DateReceipt"
        Me.DateReceipt.Size = New System.Drawing.Size(228, 32)
        Me.DateReceipt.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Receive From:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(302, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ថ្ងៃចេញវិក្កយបត្រ(Date Receipt)"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-1, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(544, 1)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "លេខវិក្កយបត្រ (Receipt Nº)"
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.BackColor = System.Drawing.Color.White
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.TxtReceiptNo.ForeColor = System.Drawing.Color.Navy
        Me.TxtReceiptNo.Location = New System.Drawing.Point(302, 61)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.ReadOnly = True
        Me.TxtReceiptNo.Size = New System.Drawing.Size(228, 32)
        Me.TxtReceiptNo.TabIndex = 1
        '
        'TxtAmmountInword
        '
        Me.TxtAmmountInword.BackColor = System.Drawing.Color.White
        Me.TxtAmmountInword.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmmountInword.Location = New System.Drawing.Point(131, 549)
        Me.TxtAmmountInword.Name = "TxtAmmountInword"
        Me.TxtAmmountInword.ReadOnly = True
        Me.TxtAmmountInword.Size = New System.Drawing.Size(391, 32)
        Me.TxtAmmountInword.TabIndex = 4
        '
        'TxtReceiptAmmount
        '
        Me.TxtReceiptAmmount.BackColor = System.Drawing.Color.White
        Me.TxtReceiptAmmount.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptAmmount.Location = New System.Drawing.Point(131, 511)
        Me.TxtReceiptAmmount.Name = "TxtReceiptAmmount"
        Me.TxtReceiptAmmount.ReadOnly = True
        Me.TxtReceiptAmmount.Size = New System.Drawing.Size(391, 32)
        Me.TxtReceiptAmmount.TabIndex = 3
        Me.TxtReceiptAmmount.Text = "0"
        Me.TxtReceiptAmmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(636, 497)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "អ្នកទទួលប្រាក់ (Received by):"
        Me.Label10.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 559)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ជាអក្សរ (In word):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 521)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ចំនួនទឹកប្រាក់ (Amount):"
        '
        'GBSocialServieType
        '
        Me.GBSocialServieType.BackColor = System.Drawing.Color.Transparent
        Me.GBSocialServieType.Controls.Add(Me.LblSocialType)
        Me.GBSocialServieType.Controls.Add(Me.LblSpacialName)
        Me.GBSocialServieType.Controls.Add(Me.LblServicePrice)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceB)
        Me.GBSocialServieType.Controls.Add(Me.LblSpacialID)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceC)
        Me.GBSocialServieType.Controls.Add(Me.RadServiceA)
        Me.GBSocialServieType.Location = New System.Drawing.Point(78, 13)
        Me.GBSocialServieType.Name = "GBSocialServieType"
        Me.GBSocialServieType.Size = New System.Drawing.Size(379, 164)
        Me.GBSocialServieType.TabIndex = 5
        Me.GBSocialServieType.TabStop = False
        Me.GBSocialServieType.Text = "Social Economic Service Types"
        '
        'LblSocialType
        '
        Me.LblSocialType.AutoSize = True
        Me.LblSocialType.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSocialType.Location = New System.Drawing.Point(152, 100)
        Me.LblSocialType.Name = "LblSocialType"
        Me.LblSocialType.Size = New System.Drawing.Size(17, 22)
        Me.LblSocialType.TabIndex = 14
        Me.LblSocialType.Text = "0"
        '
        'LblSpacialName
        '
        Me.LblSpacialName.AutoSize = True
        Me.LblSpacialName.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpacialName.Location = New System.Drawing.Point(152, 42)
        Me.LblSpacialName.Name = "LblSpacialName"
        Me.LblSpacialName.Size = New System.Drawing.Size(17, 22)
        Me.LblSpacialName.TabIndex = 15
        Me.LblSpacialName.Text = "0"
        '
        'LblServicePrice
        '
        Me.LblServicePrice.AutoSize = True
        Me.LblServicePrice.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServicePrice.Location = New System.Drawing.Point(153, 130)
        Me.LblServicePrice.Name = "LblServicePrice"
        Me.LblServicePrice.Size = New System.Drawing.Size(17, 22)
        Me.LblServicePrice.TabIndex = 13
        Me.LblServicePrice.Text = "0"
        '
        'RadServiceB
        '
        Me.RadServiceB.AutoSize = True
        Me.RadServiceB.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceB.Location = New System.Drawing.Point(11, 64)
        Me.RadServiceB.Name = "RadServiceB"
        Me.RadServiceB.Size = New System.Drawing.Size(93, 33)
        Me.RadServiceB.TabIndex = 2
        Me.RadServiceB.Text = "Servic B"
        Me.RadServiceB.UseVisualStyleBackColor = True
        '
        'LblSpacialID
        '
        Me.LblSpacialID.AutoSize = True
        Me.LblSpacialID.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpacialID.Location = New System.Drawing.Point(152, 75)
        Me.LblSpacialID.Name = "LblSpacialID"
        Me.LblSpacialID.Size = New System.Drawing.Size(17, 22)
        Me.LblSpacialID.TabIndex = 12
        Me.LblSpacialID.Text = "0"
        '
        'RadServiceC
        '
        Me.RadServiceC.AutoSize = True
        Me.RadServiceC.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceC.Location = New System.Drawing.Point(11, 97)
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
        Me.RadServiceA.Checked = True
        Me.RadServiceA.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadServiceA.Location = New System.Drawing.Point(11, 31)
        Me.RadServiceA.Name = "RadServiceA"
        Me.RadServiceA.Size = New System.Drawing.Size(102, 33)
        Me.RadServiceA.TabIndex = 0
        Me.RadServiceA.TabStop = True
        Me.RadServiceA.Text = "Service A"
        Me.RadServiceA.UseVisualStyleBackColor = True
        '
        'ErrNewReceipt
        '
        Me.ErrNewReceipt.ContainerControl = Me
        '
        'BGSaveAndPrintReceipt
        '
        '
        'SpacialServiceReceipt1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 714)
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SpacialServiceReceipt1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicine Client Receipt"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GridServiceMed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GBSocialServieType.ResumeLayout(False)
        Me.GBSocialServieType.PerformLayout()
        CType(Me.ErrNewReceipt, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ErrNewReceipt As System.Windows.Forms.ErrorProvider
    Friend WithEvents BGSaveAndPrintReceipt As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GridServiceMed As Janus.Windows.GridEX.GridEX
    Friend WithEvents VSMInterface As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents CboSkill As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSpacialServicePrice As System.Windows.Forms.TextBox
    Friend WithEvents LblSpacialID As System.Windows.Forms.Label
    Friend WithEvents LblSocialType As System.Windows.Forms.Label
    Friend WithEvents LblServicePrice As System.Windows.Forms.Label
    Friend WithEvents LblSpacialName As System.Windows.Forms.Label
    Friend WithEvents CboPackage As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
