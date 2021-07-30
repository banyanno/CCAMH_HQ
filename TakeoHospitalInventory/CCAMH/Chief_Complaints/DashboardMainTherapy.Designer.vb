<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardMainTherapy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardMainTherapy))
        Dim GridClientNew_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridListOfTherapist_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.MenuThearpist = New System.Windows.Forms.ToolStrip()
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNewTherapy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPrintTherapis = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridClientNew = New Janus.Windows.GridEX.GridEX()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridListOfTherapist = New Janus.Windows.GridEX.GridEX()
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
        Me.MenuThearpist.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridClientNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridListOfTherapist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuThearpist
        '
        Me.MenuThearpist.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuThearpist.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuThearpist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator4, Me.BtnNewTherapy, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.BtnPrintTherapis})
        Me.MenuThearpist.Location = New System.Drawing.Point(0, 0)
        Me.MenuThearpist.Name = "MenuThearpist"
        Me.MenuThearpist.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuThearpist.Size = New System.Drawing.Size(1296, 58)
        Me.MenuThearpist.TabIndex = 1
        Me.MenuThearpist.Text = "ToolStrip1"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(127, 55)
        Me.ToolStripButton1.Text = "Chang Thearapy"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'BtnPrintTherapis
        '
        Me.BtnPrintTherapis.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnPrintTherapis.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrintTherapis.Image = CType(resources.GetObject("BtnPrintTherapis.Image"), System.Drawing.Image)
        Me.BtnPrintTherapis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintTherapis.Name = "BtnPrintTherapis"
        Me.BtnPrintTherapis.Size = New System.Drawing.Size(268, 55)
        Me.BtnPrintTherapis.Text = "Print List Client Manage By Therapist"
        Me.BtnPrintTherapis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1296, 770)
        Me.SplitContainer1.SplitterDistance = 961
        Me.SplitContainer1.TabIndex = 2
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
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(961, 770)
        Me.SplitContainer2.SplitterDistance = 226
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridClientNew)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(959, 768)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client detail"
        '
        'GridClientNew
        '
        Me.GridClientNew.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientNew.BackColor = System.Drawing.Color.White
        Me.GridClientNew.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridClientNew.CardBorders = False
        GridClientNew_DesignTimeLayout.LayoutString = resources.GetString("GridClientNew_DesignTimeLayout.LayoutString")
        Me.GridClientNew.DesignTimeLayout = GridClientNew_DesignTimeLayout
        Me.GridClientNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientNew.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GridClientNew.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientNew.GroupByBoxVisible = False
        Me.GridClientNew.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClientNew.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClientNew.Location = New System.Drawing.Point(3, 20)
        Me.GridClientNew.Name = "GridClientNew"
        Me.GridClientNew.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.GridClientNew.RecordNavigator = True
        Me.GridClientNew.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientNew.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientNew.Size = New System.Drawing.Size(953, 745)
        Me.GridClientNew.TabIndex = 4
        Me.GridClientNew.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientNew.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.UiGroupBox1)
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(329, 768)
        Me.SplitContainer3.SplitterDistance = 453
        Me.SplitContainer3.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridListOfTherapist)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 768)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of therapist or doctors"
        '
        'GridListOfTherapist
        '
        Me.GridListOfTherapist.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridListOfTherapist.BackColor = System.Drawing.Color.White
        Me.GridListOfTherapist.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridListOfTherapist_DesignTimeLayout.LayoutString = resources.GetString("GridListOfTherapist_DesignTimeLayout.LayoutString")
        Me.GridListOfTherapist.DesignTimeLayout = GridListOfTherapist_DesignTimeLayout
        Me.GridListOfTherapist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridListOfTherapist.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridListOfTherapist.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridListOfTherapist.GroupByBoxVisible = False
        Me.GridListOfTherapist.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridListOfTherapist.HeaderFormatStyle.FontSize = 11.0!
        Me.GridListOfTherapist.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GridListOfTherapist.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridListOfTherapist.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridListOfTherapist.Location = New System.Drawing.Point(3, 20)
        Me.GridListOfTherapist.Name = "GridListOfTherapist"
        Me.GridListOfTherapist.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom
        Me.GridListOfTherapist.RecordNavigator = True
        Me.GridListOfTherapist.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridListOfTherapist.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridListOfTherapist.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.GridListOfTherapist.Size = New System.Drawing.Size(323, 745)
        Me.GridListOfTherapist.TabIndex = 24
        Me.GridListOfTherapist.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridListOfTherapist.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
        Me.UiGroupBox1.Size = New System.Drawing.Size(150, 46)
        Me.UiGroupBox1.TabIndex = 7
        Me.UiGroupBox1.Text = "Find new client"
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
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date To"
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
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.RadClientName.Size = New System.Drawing.Size(111, 22)
        Me.RadClientName.TabIndex = 3
        Me.RadClientName.Text = "Client Name:"
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
        'DashboardMainTherapy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuThearpist)
        Me.Name = "DashboardMainTherapy"
        Me.Size = New System.Drawing.Size(1296, 828)
        Me.MenuThearpist.ResumeLayout(False)
        Me.MenuThearpist.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridClientNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridListOfTherapist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
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
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridListOfTherapist As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridClientNew As Janus.Windows.GridEX.GridEX
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
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintTherapis As System.Windows.Forms.ToolStripButton

End Class
