<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardRefferFrom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardRefferFrom))
        Dim GridClientReferFrom_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridListOfReferFrom_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.MenuThearpist = New System.Windows.Forms.ToolStrip()
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNewTherapy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridClientReferFrom = New Janus.Windows.GridEX.GridEX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnPrintReferFrom = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnnFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtClientTel = New System.Windows.Forms.TextBox()
        Me.TxtClientName = New System.Windows.Forms.TextBox()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.RadClientTel = New System.Windows.Forms.RadioButton()
        Me.RadClientName = New System.Windows.Forms.RadioButton()
        Me.RadClientNo = New System.Windows.Forms.RadioButton()
        Me.RadAllClient = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridListOfReferFrom = New Janus.Windows.GridEX.GridEX()
        Me.MenuThearpist.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridClientReferFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridListOfReferFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuThearpist
        '
        Me.MenuThearpist.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuThearpist.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuThearpist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator4, Me.BtnNewTherapy, Me.ToolStripSeparator1})
        Me.MenuThearpist.Location = New System.Drawing.Point(0, 0)
        Me.MenuThearpist.Name = "MenuThearpist"
        Me.MenuThearpist.Size = New System.Drawing.Size(1085, 58)
        Me.MenuThearpist.TabIndex = 2
        Me.MenuThearpist.Text = "ToolStrip1"
        Me.MenuThearpist.Visible = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(107, 55)
        Me.BtnRefresh.Text = "     Refresh     "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 58)
        '
        'BtnNewTherapy
        '
        Me.BtnNewTherapy.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnNewTherapy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnNewTherapy.Image = CType(resources.GetObject("BtnNewTherapy.Image"), System.Drawing.Image)
        Me.BtnNewTherapy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewTherapy.Name = "BtnNewTherapy"
        Me.BtnNewTherapy.Size = New System.Drawing.Size(124, 55)
        Me.BtnNewTherapy.Text = "   New Therapy   "
        Me.BtnNewTherapy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1218, 686)
        Me.SplitContainer1.SplitterDistance = 922
        Me.SplitContainer1.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(922, 686)
        Me.SplitContainer2.SplitterDistance = 226
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridClientReferFrom)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 631)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client detail"
        '
        'GridClientReferFrom
        '
        Me.GridClientReferFrom.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientReferFrom.BackColor = System.Drawing.Color.White
        Me.GridClientReferFrom.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridClientReferFrom.CardBorders = False
        GridClientReferFrom_DesignTimeLayout.LayoutString = resources.GetString("GridClientReferFrom_DesignTimeLayout.LayoutString")
        Me.GridClientReferFrom.DesignTimeLayout = GridClientReferFrom_DesignTimeLayout
        Me.GridClientReferFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientReferFrom.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GridClientReferFrom.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientReferFrom.GroupByBoxVisible = False
        Me.GridClientReferFrom.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClientReferFrom.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClientReferFrom.Location = New System.Drawing.Point(3, 20)
        Me.GridClientReferFrom.Name = "GridClientReferFrom"
        Me.GridClientReferFrom.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.GridClientReferFrom.RecordNavigator = True
        Me.GridClientReferFrom.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientReferFrom.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientReferFrom.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridClientReferFrom.Size = New System.Drawing.Size(914, 608)
        Me.GridClientReferFrom.TabIndex = 4
        Me.GridClientReferFrom.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientReferFrom.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintReferFrom, Me.ToolStripSeparator2, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(920, 53)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnPrintReferFrom
        '
        Me.BtnPrintReferFrom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnPrintReferFrom.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrintReferFrom.Image = CType(resources.GetObject("BtnPrintReferFrom.Image"), System.Drawing.Image)
        Me.BtnPrintReferFrom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintReferFrom.Name = "BtnPrintReferFrom"
        Me.BtnPrintReferFrom.Size = New System.Drawing.Size(198, 50)
        Me.BtnPrintReferFrom.Text = "Print Report By Refer from"
        Me.BtnPrintReferFrom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(301, 50)
        Me.ToolStripLabel1.Text = "Select Date and Refer From to print report"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.UiGroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(290, 684)
        Me.SplitContainer3.SplitterDistance = 321
        Me.SplitContainer3.TabIndex = 1
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.DTo)
        Me.UiGroupBox1.Controls.Add(Me.DFrom)
        Me.UiGroupBox1.Controls.Add(Me.BtnnFind)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.TxtClientTel)
        Me.UiGroupBox1.Controls.Add(Me.TxtClientName)
        Me.UiGroupBox1.Controls.Add(Me.TxtClientNo)
        Me.UiGroupBox1.Controls.Add(Me.RadClientTel)
        Me.UiGroupBox1.Controls.Add(Me.RadClientName)
        Me.UiGroupBox1.Controls.Add(Me.RadClientNo)
        Me.UiGroupBox1.Controls.Add(Me.RadAllClient)
        Me.UiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom
        Me.UiGroupBox1.Size = New System.Drawing.Size(290, 321)
        Me.UiGroupBox1.TabIndex = 7
        Me.UiGroupBox1.Text = "Find Client Refer From"
        Me.UiGroupBox1.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(155, 43)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(114, 24)
        Me.DTo.TabIndex = 5
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(29, 43)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(113, 24)
        Me.DFrom.TabIndex = 4
        '
        'BtnnFind
        '
        Me.BtnnFind.BackColor = System.Drawing.Color.Maroon
        Me.BtnnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnnFind.FlatAppearance.BorderSize = 0
        Me.BtnnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnnFind.ForeColor = System.Drawing.Color.White
        Me.BtnnFind.Location = New System.Drawing.Point(29, 266)
        Me.BtnnFind.Name = "BtnnFind"
        Me.BtnnFind.Size = New System.Drawing.Size(228, 42)
        Me.BtnnFind.TabIndex = 8
        Me.BtnnFind.Text = "Find"
        Me.BtnnFind.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "D-From Regis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "D-To Regis"
        '
        'TxtClientTel
        '
        Me.TxtClientTel.Enabled = False
        Me.TxtClientTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientTel.Location = New System.Drawing.Point(29, 235)
        Me.TxtClientTel.Name = "TxtClientTel"
        Me.TxtClientTel.Size = New System.Drawing.Size(227, 27)
        Me.TxtClientTel.TabIndex = 7
        '
        'TxtClientName
        '
        Me.TxtClientName.Enabled = False
        Me.TxtClientName.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(29, 179)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.Size = New System.Drawing.Size(227, 32)
        Me.TxtClientName.TabIndex = 6
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Enabled = False
        Me.TxtClientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNo.Location = New System.Drawing.Point(29, 126)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.Size = New System.Drawing.Size(227, 27)
        Me.TxtClientNo.TabIndex = 5
        '
        'RadClientTel
        '
        Me.RadClientTel.AutoSize = True
        Me.RadClientTel.Location = New System.Drawing.Point(29, 213)
        Me.RadClientTel.Name = "RadClientTel"
        Me.RadClientTel.Size = New System.Drawing.Size(91, 22)
        Me.RadClientTel.TabIndex = 4
        Me.RadClientTel.Text = "Client Tel:"
        Me.RadClientTel.UseVisualStyleBackColor = True
        '
        'RadClientName
        '
        Me.RadClientName.AutoSize = True
        Me.RadClientName.Location = New System.Drawing.Point(29, 155)
        Me.RadClientName.Name = "RadClientName"
        Me.RadClientName.Size = New System.Drawing.Size(136, 22)
        Me.RadClientName.TabIndex = 3
        Me.RadClientName.Text = "Client Name KH:"
        Me.RadClientName.UseVisualStyleBackColor = True
        '
        'RadClientNo
        '
        Me.RadClientNo.AutoSize = True
        Me.RadClientNo.Location = New System.Drawing.Point(29, 101)
        Me.RadClientNo.Name = "RadClientNo"
        Me.RadClientNo.Size = New System.Drawing.Size(91, 22)
        Me.RadClientNo.TabIndex = 2
        Me.RadClientNo.Text = "Client No:"
        Me.RadClientNo.UseVisualStyleBackColor = True
        '
        'RadAllClient
        '
        Me.RadAllClient.AutoSize = True
        Me.RadAllClient.Checked = True
        Me.RadAllClient.Location = New System.Drawing.Point(29, 73)
        Me.RadAllClient.Name = "RadAllClient"
        Me.RadAllClient.Size = New System.Drawing.Size(113, 22)
        Me.RadAllClient.TabIndex = 1
        Me.RadAllClient.TabStop = True
        Me.RadAllClient.Text = "View all client"
        Me.RadAllClient.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridListOfReferFrom)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 359)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Refer From"
        '
        'GridListOfReferFrom
        '
        Me.GridListOfReferFrom.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridListOfReferFrom.BackColor = System.Drawing.Color.White
        Me.GridListOfReferFrom.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridListOfReferFrom_DesignTimeLayout.LayoutString = resources.GetString("GridListOfReferFrom_DesignTimeLayout.LayoutString")
        Me.GridListOfReferFrom.DesignTimeLayout = GridListOfReferFrom_DesignTimeLayout
        Me.GridListOfReferFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridListOfReferFrom.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridListOfReferFrom.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridListOfReferFrom.GroupByBoxVisible = False
        Me.GridListOfReferFrom.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridListOfReferFrom.HeaderFormatStyle.FontSize = 11.0!
        Me.GridListOfReferFrom.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GridListOfReferFrom.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridListOfReferFrom.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridListOfReferFrom.Location = New System.Drawing.Point(3, 20)
        Me.GridListOfReferFrom.Name = "GridListOfReferFrom"
        Me.GridListOfReferFrom.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom
        Me.GridListOfReferFrom.RecordNavigator = True
        Me.GridListOfReferFrom.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridListOfReferFrom.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridListOfReferFrom.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridListOfReferFrom.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridListOfReferFrom.Size = New System.Drawing.Size(284, 336)
        Me.GridListOfReferFrom.TabIndex = 24
        Me.GridListOfReferFrom.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridListOfReferFrom.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'DashboardRefferFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuThearpist)
        Me.Name = "DashboardRefferFrom"
        Me.Size = New System.Drawing.Size(1218, 686)
        Me.MenuThearpist.ResumeLayout(False)
        Me.MenuThearpist.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridClientReferFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridListOfReferFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuThearpist As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewTherapy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridClientReferFrom As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridListOfReferFrom As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnnFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtClientTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadClientTel As System.Windows.Forms.RadioButton
    Friend WithEvents RadClientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllClient As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnPrintReferFrom As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel

End Class
