<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardMedicineSale
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
        Dim GridListWaitingMedicine_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardMedicineSale))
        Dim GridPrescription_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GridListWaitingMedicine = New Janus.Windows.GridEX.GridEX()
        Me.BtnMedicineOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadWaitingMedicine = New System.Windows.Forms.RadioButton()
        Me.TxtClientNameEng = New System.Windows.Forms.TextBox()
        Me.RadClientNameEng = New System.Windows.Forms.RadioButton()
        Me.TxtClientNameKH = New System.Windows.Forms.TextBox()
        Me.RadClientNameKH = New System.Windows.Forms.RadioButton()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.RadAllClient = New System.Windows.Forms.RadioButton()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.RadClientNo = New System.Windows.Forms.RadioButton()
        Me.RadReceiptNo = New System.Windows.Forms.RadioButton()
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox()
        Me.GridPrescription = New Janus.Windows.GridEX.GridEX()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnGiveMedicine = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEidtMedicinePrescription = New System.Windows.Forms.ToolStripButton()
        Me.bgPrescription = New System.ComponentModel.BackgroundWorker()
        Me.TimerCheckPrescription = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GridListWaitingMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridListWaitingMedicine
        '
        Me.GridListWaitingMedicine.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridListWaitingMedicine.BackColor = System.Drawing.Color.White
        Me.GridListWaitingMedicine.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        GridListWaitingMedicine_DesignTimeLayout.LayoutString = resources.GetString("GridListWaitingMedicine_DesignTimeLayout.LayoutString")
        Me.GridListWaitingMedicine.DesignTimeLayout = GridListWaitingMedicine_DesignTimeLayout
        Me.GridListWaitingMedicine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridListWaitingMedicine.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridListWaitingMedicine.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridListWaitingMedicine.GroupByBoxVisible = False
        Me.GridListWaitingMedicine.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridListWaitingMedicine.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridListWaitingMedicine.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridListWaitingMedicine.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridListWaitingMedicine.Location = New System.Drawing.Point(0, 0)
        Me.GridListWaitingMedicine.Name = "GridListWaitingMedicine"
        Me.GridListWaitingMedicine.RecordNavigator = True
        Me.GridListWaitingMedicine.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridListWaitingMedicine.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridListWaitingMedicine.Size = New System.Drawing.Size(954, 474)
        Me.GridListWaitingMedicine.TabIndex = 7
        Me.GridListWaitingMedicine.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridListWaitingMedicine.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'BtnMedicineOut
        '
        Me.BtnMedicineOut.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnMedicineOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMedicineOut.Image = CType(resources.GetObject("BtnMedicineOut.Image"), System.Drawing.Image)
        Me.BtnMedicineOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMedicineOut.Name = "BtnMedicineOut"
        Me.BtnMedicineOut.Size = New System.Drawing.Size(174, 55)
        Me.BtnMedicineOut.Text = "List of medicine outsite"
        Me.BtnMedicineOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(131, 55)
        Me.BtnRefresh.Text = "        Refresh        "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridPrescription)
        Me.SplitContainer1.Size = New System.Drawing.Size(1257, 695)
        Me.SplitContainer1.SplitterDistance = 476
        Me.SplitContainer1.TabIndex = 10
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridListWaitingMedicine)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1257, 476)
        Me.SplitContainer2.SplitterDistance = 956
        Me.SplitContainer2.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(289, 451)
        Me.Panel3.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadWaitingMedicine)
        Me.Panel1.Controls.Add(Me.TxtClientNameEng)
        Me.Panel1.Controls.Add(Me.RadClientNameEng)
        Me.Panel1.Controls.Add(Me.TxtClientNameKH)
        Me.Panel1.Controls.Add(Me.RadClientNameKH)
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.RadAllClient)
        Me.Panel1.Controls.Add(Me.DTo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DFrom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtClientNo)
        Me.Panel1.Controls.Add(Me.RadClientNo)
        Me.Panel1.Controls.Add(Me.RadReceiptNo)
        Me.Panel1.Controls.Add(Me.TxtReceiptNo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 449)
        Me.Panel1.TabIndex = 2
        '
        'RadWaitingMedicine
        '
        Me.RadWaitingMedicine.AutoSize = True
        Me.RadWaitingMedicine.Checked = True
        Me.RadWaitingMedicine.Location = New System.Drawing.Point(5, 18)
        Me.RadWaitingMedicine.Name = "RadWaitingMedicine"
        Me.RadWaitingMedicine.Size = New System.Drawing.Size(191, 22)
        Me.RadWaitingMedicine.TabIndex = 18
        Me.RadWaitingMedicine.TabStop = True
        Me.RadWaitingMedicine.Text = "All Waiting Give Medicine"
        Me.RadWaitingMedicine.UseVisualStyleBackColor = True
        '
        'TxtClientNameEng
        '
        Me.TxtClientNameEng.Enabled = False
        Me.TxtClientNameEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameEng.Location = New System.Drawing.Point(5, 357)
        Me.TxtClientNameEng.Name = "TxtClientNameEng"
        Me.TxtClientNameEng.Size = New System.Drawing.Size(278, 29)
        Me.TxtClientNameEng.TabIndex = 17
        '
        'RadClientNameEng
        '
        Me.RadClientNameEng.AutoSize = True
        Me.RadClientNameEng.Location = New System.Drawing.Point(5, 328)
        Me.RadClientNameEng.Name = "RadClientNameEng"
        Me.RadClientNameEng.Size = New System.Drawing.Size(137, 22)
        Me.RadClientNameEng.TabIndex = 16
        Me.RadClientNameEng.Text = "Client Name Eng"
        Me.RadClientNameEng.UseVisualStyleBackColor = True
        '
        'TxtClientNameKH
        '
        Me.TxtClientNameKH.Enabled = False
        Me.TxtClientNameKH.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameKH.Location = New System.Drawing.Point(5, 293)
        Me.TxtClientNameKH.Name = "TxtClientNameKH"
        Me.TxtClientNameKH.Size = New System.Drawing.Size(278, 30)
        Me.TxtClientNameKH.TabIndex = 15
        '
        'RadClientNameKH
        '
        Me.RadClientNameKH.AutoSize = True
        Me.RadClientNameKH.Location = New System.Drawing.Point(5, 264)
        Me.RadClientNameKH.Name = "RadClientNameKH"
        Me.RadClientNameKH.Size = New System.Drawing.Size(129, 22)
        Me.RadClientNameKH.TabIndex = 14
        Me.RadClientNameKH.Text = "Client Name Kh"
        Me.RadClientNameKH.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.Maroon
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatAppearance.BorderSize = 0
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Location = New System.Drawing.Point(4, 394)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(279, 37)
        Me.BtnFind.TabIndex = 13
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'RadAllClient
        '
        Me.RadAllClient.AutoSize = True
        Me.RadAllClient.Location = New System.Drawing.Point(5, 55)
        Me.RadAllClient.Name = "RadAllClient"
        Me.RadAllClient.Size = New System.Drawing.Size(82, 22)
        Me.RadAllClient.TabIndex = 12
        Me.RadAllClient.Text = "All Client"
        Me.RadAllClient.UseVisualStyleBackColor = True
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(156, 109)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(122, 24)
        Me.DTo.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date To"
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(5, 109)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(135, 24)
        Me.DFrom.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date From"
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Enabled = False
        Me.TxtClientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNo.Location = New System.Drawing.Point(5, 229)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.Size = New System.Drawing.Size(278, 29)
        Me.TxtClientNo.TabIndex = 7
        '
        'RadClientNo
        '
        Me.RadClientNo.AutoSize = True
        Me.RadClientNo.Location = New System.Drawing.Point(5, 200)
        Me.RadClientNo.Name = "RadClientNo"
        Me.RadClientNo.Size = New System.Drawing.Size(91, 22)
        Me.RadClientNo.TabIndex = 6
        Me.RadClientNo.Text = "Client No:"
        Me.RadClientNo.UseVisualStyleBackColor = True
        '
        'RadReceiptNo
        '
        Me.RadReceiptNo.AutoSize = True
        Me.RadReceiptNo.Location = New System.Drawing.Point(5, 141)
        Me.RadReceiptNo.Name = "RadReceiptNo"
        Me.RadReceiptNo.Size = New System.Drawing.Size(100, 22)
        Me.RadReceiptNo.TabIndex = 6
        Me.RadReceiptNo.Text = "Receipt No"
        Me.RadReceiptNo.UseVisualStyleBackColor = True
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.Enabled = False
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptNo.Location = New System.Drawing.Point(5, 165)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.Size = New System.Drawing.Size(278, 29)
        Me.TxtReceiptNo.TabIndex = 5
        '
        'GridPrescription
        '
        Me.GridPrescription.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPrescription.BackColor = System.Drawing.Color.White
        Me.GridPrescription.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridPrescription_DesignTimeLayout.LayoutString = resources.GetString("GridPrescription_DesignTimeLayout.LayoutString")
        Me.GridPrescription.DesignTimeLayout = GridPrescription_DesignTimeLayout
        Me.GridPrescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrescription.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridPrescription.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPrescription.GroupByBoxVisible = False
        Me.GridPrescription.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPrescription.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPrescription.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPrescription.Location = New System.Drawing.Point(0, 0)
        Me.GridPrescription.Name = "GridPrescription"
        Me.GridPrescription.RecordNavigator = True
        Me.GridPrescription.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridPrescription.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPrescription.Size = New System.Drawing.Size(1255, 213)
        Me.GridPrescription.TabIndex = 41
        Me.GridPrescription.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator2, Me.BtnGiveMedicine, Me.ToolStripSeparator4, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.BtnMedicineOut, Me.ToolStripSeparator3, Me.BtnEidtMedicinePrescription})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1257, 58)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnGiveMedicine
        '
        Me.BtnGiveMedicine.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnGiveMedicine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGiveMedicine.Image = CType(resources.GetObject("BtnGiveMedicine.Image"), System.Drawing.Image)
        Me.BtnGiveMedicine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGiveMedicine.Name = "BtnGiveMedicine"
        Me.BtnGiveMedicine.Size = New System.Drawing.Size(136, 55)
        Me.BtnGiveMedicine.Text = "      Give medicine"
        Me.BtnGiveMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(158, 55)
        Me.ToolStripButton1.Text = "   Print Prescription   "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 58)
        '
        'BtnEidtMedicinePrescription
        '
        Me.BtnEidtMedicinePrescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnEidtMedicinePrescription.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEidtMedicinePrescription.Image = CType(resources.GetObject("BtnEidtMedicinePrescription.Image"), System.Drawing.Image)
        Me.BtnEidtMedicinePrescription.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEidtMedicinePrescription.Name = "BtnEidtMedicinePrescription"
        Me.BtnEidtMedicinePrescription.Size = New System.Drawing.Size(211, 55)
        Me.BtnEidtMedicinePrescription.Text = "Edit Medicine In Prescription"
        Me.BtnEidtMedicinePrescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bgPrescription
        '
        '
        'TimerCheckPrescription
        '
        Me.TimerCheckPrescription.Interval = 1000
        '
        'DashboardMedicineSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardMedicineSale"
        Me.Size = New System.Drawing.Size(1257, 753)
        CType(Me.GridListWaitingMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridListWaitingMedicine As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnMedicineOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnGiveMedicine As System.Windows.Forms.ToolStripButton
    Friend WithEvents bgPrescription As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadAllClient As System.Windows.Forms.RadioButton
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadReceiptNo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents GridPrescription As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TimerCheckPrescription As System.Windows.Forms.Timer
    Friend WithEvents TxtClientNameEng As System.Windows.Forms.TextBox
    Friend WithEvents RadClientNameEng As System.Windows.Forms.RadioButton
    Friend WithEvents TxtClientNameKH As System.Windows.Forms.TextBox
    Friend WithEvents RadClientNameKH As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEidtMedicinePrescription As System.Windows.Forms.ToolStripButton
    Friend WithEvents RadWaitingMedicine As System.Windows.Forms.RadioButton

End Class
