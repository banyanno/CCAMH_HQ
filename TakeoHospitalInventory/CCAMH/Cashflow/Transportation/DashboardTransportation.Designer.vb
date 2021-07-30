<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardTransportation
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
        Dim GridClientTransportation_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardTransportation))
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim GridTransDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GridClientTransportation = New Janus.Windows.GridEX.GridEX()
        Me.ContextTransport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnUpdateTransport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDeleteTransport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUndoTransport = New System.Windows.Forms.ToolStripMenuItem()
        Me.VSMInterface = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridTransDetail = New Janus.Windows.GridEX.GridEX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadAllClient = New System.Windows.Forms.RadioButton()
        Me.TxtSearchClientName = New System.Windows.Forms.TextBox()
        Me.TxtSearchClientNo = New System.Windows.Forms.TextBox()
        Me.RadByClientname = New System.Windows.Forms.RadioButton()
        Me.BtnFindClientReceipt = New System.Windows.Forms.Button()
        Me.RadByClientNo = New System.Windows.Forms.RadioButton()
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.btnTransportPara = New System.Windows.Forms.Button()
        Me.BtnNewTransportation = New System.Windows.Forms.Button()
        CType(Me.GridClientTransportation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextTransport.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridTransDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridClientTransportation
        '
        Me.GridClientTransportation.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientTransportation.BackColor = System.Drawing.Color.White
        Me.GridClientTransportation.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridClientTransportation.ContextMenuStrip = Me.ContextTransport
        GridClientTransportation_DesignTimeLayout.LayoutString = resources.GetString("GridClientTransportation_DesignTimeLayout.LayoutString")
        Me.GridClientTransportation.DesignTimeLayout = GridClientTransportation_DesignTimeLayout
        Me.GridClientTransportation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientTransportation.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridClientTransportation.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientTransportation.GroupByBoxVisible = False
        Me.GridClientTransportation.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClientTransportation.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridClientTransportation.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridClientTransportation.Location = New System.Drawing.Point(0, 0)
        Me.GridClientTransportation.Name = "GridClientTransportation"
        Me.GridClientTransportation.RecordNavigator = True
        Me.GridClientTransportation.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientTransportation.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientTransportation.Size = New System.Drawing.Size(872, 485)
        Me.GridClientTransportation.TabIndex = 12
        Me.GridClientTransportation.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientTransportation.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientTransportation.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ContextTransport
        '
        Me.ContextTransport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnUpdateTransport, Me.ToolStripMenuItem1, Me.BtnDeleteTransport, Me.ToolStripMenuItem2, Me.BtnUndoTransport})
        Me.ContextTransport.Name = "ContextTransport"
        Me.ContextTransport.Size = New System.Drawing.Size(165, 82)
        '
        'BtnUpdateTransport
        '
        Me.BtnUpdateTransport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdateTransport.Name = "BtnUpdateTransport"
        Me.BtnUpdateTransport.Size = New System.Drawing.Size(164, 22)
        Me.BtnUpdateTransport.Text = "Update Transport"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 6)
        '
        'BtnDeleteTransport
        '
        Me.BtnDeleteTransport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteTransport.Name = "BtnDeleteTransport"
        Me.BtnDeleteTransport.Size = New System.Drawing.Size(164, 22)
        Me.BtnDeleteTransport.Text = "Delete Transport"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(161, 6)
        '
        'BtnUndoTransport
        '
        Me.BtnUndoTransport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUndoTransport.Name = "BtnUndoTransport"
        Me.BtnUndoTransport.Size = New System.Drawing.Size(164, 22)
        Me.BtnUndoTransport.Text = "Undo Transport"
        '
        'VSMInterface
        '
        JanusColorScheme2.ActiveCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme2.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme2.ControlColor = System.Drawing.Color.White
        JanusColorScheme2.ControlDarkColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme2.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme2.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme2.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme2.HighlightTextColor = System.Drawing.Color.White
        JanusColorScheme2.InfoColor = System.Drawing.Color.White
        JanusColorScheme2.InfoTextColor = System.Drawing.Color.Black
        JanusColorScheme2.MenuColor = System.Drawing.Color.White
        JanusColorScheme2.MenuTextColor = System.Drawing.Color.Black
        JanusColorScheme2.Name = "DefaultInterface"
        JanusColorScheme2.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.UseThemes = False
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme2.WindowColor = System.Drawing.Color.White
        JanusColorScheme2.WindowTextColor = System.Drawing.Color.Black
        Me.VSMInterface.ColorSchemes.Add(JanusColorScheme2)
        Me.VSMInterface.DefaultColorScheme = Nothing
        '
        'DFrom
        '
        Me.DFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(5, 48)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(104, 23)
        Me.DFrom.TabIndex = 15
        '
        'DTo
        '
        Me.DTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTo.CustomFormat = "dd/MM/yyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(128, 48)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(104, 23)
        Me.DTo.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "To:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 64)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1121, 630)
        Me.SplitContainer1.SplitterDistance = 874
        Me.SplitContainer1.TabIndex = 20
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridClientTransportation)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GridTransDetail)
        Me.SplitContainer2.Size = New System.Drawing.Size(872, 628)
        Me.SplitContainer2.SplitterDistance = 485
        Me.SplitContainer2.TabIndex = 13
        '
        'GridTransDetail
        '
        Me.GridTransDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTransDetail.BackColor = System.Drawing.Color.White
        Me.GridTransDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridTransDetail_DesignTimeLayout.LayoutString = resources.GetString("GridTransDetail_DesignTimeLayout.LayoutString")
        Me.GridTransDetail.DesignTimeLayout = GridTransDetail_DesignTimeLayout
        Me.GridTransDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTransDetail.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridTransDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridTransDetail.GroupByBoxVisible = False
        Me.GridTransDetail.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridTransDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridTransDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridTransDetail.Location = New System.Drawing.Point(0, 0)
        Me.GridTransDetail.Name = "GridTransDetail"
        Me.GridTransDetail.RecordNavigator = True
        Me.GridTransDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridTransDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridTransDetail.Size = New System.Drawing.Size(872, 139)
        Me.GridTransDetail.TabIndex = 15
        Me.GridTransDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridTransDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridTransDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadAllClient)
        Me.GroupBox1.Controls.Add(Me.DTo)
        Me.GroupBox1.Controls.Add(Me.TxtSearchClientName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSearchClientNo)
        Me.GroupBox1.Controls.Add(Me.DFrom)
        Me.GroupBox1.Controls.Add(Me.RadByClientname)
        Me.GroupBox1.Controls.Add(Me.BtnFindClientReceipt)
        Me.GroupBox1.Controls.Add(Me.RadByClientNo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 628)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Client Transportation"
        '
        'RadAllClient
        '
        Me.RadAllClient.AutoSize = True
        Me.RadAllClient.Checked = True
        Me.RadAllClient.Location = New System.Drawing.Point(6, 83)
        Me.RadAllClient.Name = "RadAllClient"
        Me.RadAllClient.Size = New System.Drawing.Size(82, 22)
        Me.RadAllClient.TabIndex = 23
        Me.RadAllClient.TabStop = True
        Me.RadAllClient.Text = "All Client"
        Me.RadAllClient.UseVisualStyleBackColor = True
        '
        'TxtSearchClientName
        '
        Me.TxtSearchClientName.Enabled = False
        Me.TxtSearchClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchClientName.Location = New System.Drawing.Point(6, 194)
        Me.TxtSearchClientName.Name = "TxtSearchClientName"
        Me.TxtSearchClientName.Size = New System.Drawing.Size(228, 26)
        Me.TxtSearchClientName.TabIndex = 22
        '
        'TxtSearchClientNo
        '
        Me.TxtSearchClientNo.Enabled = False
        Me.TxtSearchClientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchClientNo.Location = New System.Drawing.Point(6, 137)
        Me.TxtSearchClientNo.Name = "TxtSearchClientNo"
        Me.TxtSearchClientNo.Size = New System.Drawing.Size(228, 26)
        Me.TxtSearchClientNo.TabIndex = 21
        '
        'RadByClientname
        '
        Me.RadByClientname.AutoSize = True
        Me.RadByClientname.Location = New System.Drawing.Point(6, 168)
        Me.RadByClientname.Name = "RadByClientname"
        Me.RadByClientname.Size = New System.Drawing.Size(128, 22)
        Me.RadByClientname.TabIndex = 20
        Me.RadByClientname.Text = "By Client Name"
        Me.RadByClientname.UseVisualStyleBackColor = True
        '
        'BtnFindClientReceipt
        '
        Me.BtnFindClientReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindClientReceipt.FlatAppearance.BorderSize = 0
        Me.BtnFindClientReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFindClientReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFindClientReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFindClientReceipt.Image = CType(resources.GetObject("BtnFindClientReceipt.Image"), System.Drawing.Image)
        Me.BtnFindClientReceipt.Location = New System.Drawing.Point(6, 224)
        Me.BtnFindClientReceipt.Name = "BtnFindClientReceipt"
        Me.BtnFindClientReceipt.Size = New System.Drawing.Size(228, 55)
        Me.BtnFindClientReceipt.TabIndex = 11
        Me.BtnFindClientReceipt.Text = "Find Client"
        Me.BtnFindClientReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnFindClientReceipt.UseVisualStyleBackColor = True
        '
        'RadByClientNo
        '
        Me.RadByClientNo.AutoSize = True
        Me.RadByClientNo.Location = New System.Drawing.Point(6, 112)
        Me.RadByClientNo.Name = "RadByClientNo"
        Me.RadByClientNo.Size = New System.Drawing.Size(108, 22)
        Me.RadByClientNo.TabIndex = 19
        Me.RadByClientNo.Text = "By Client No"
        Me.RadByClientNo.UseVisualStyleBackColor = True
        '
        'BtnReport
        '
        Me.BtnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReport.FlatAppearance.BorderSize = 0
        Me.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnReport.Image = CType(resources.GetObject("BtnReport.Image"), System.Drawing.Image)
        Me.BtnReport.Location = New System.Drawing.Point(152, 4)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(143, 55)
        Me.BtnReport.TabIndex = 22
        Me.BtnReport.Text = "Reports"
        Me.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnReport.UseVisualStyleBackColor = True
        '
        'btnTransportPara
        '
        Me.btnTransportPara.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransportPara.FlatAppearance.BorderSize = 0
        Me.btnTransportPara.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransportPara.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransportPara.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTransportPara.Image = CType(resources.GetObject("btnTransportPara.Image"), System.Drawing.Image)
        Me.btnTransportPara.Location = New System.Drawing.Point(300, 4)
        Me.btnTransportPara.Name = "btnTransportPara"
        Me.btnTransportPara.Size = New System.Drawing.Size(143, 55)
        Me.btnTransportPara.TabIndex = 19
        Me.btnTransportPara.Text = "Trans Offer Setting"
        Me.btnTransportPara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTransportPara.UseVisualStyleBackColor = True
        '
        'BtnNewTransportation
        '
        Me.BtnNewTransportation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewTransportation.FlatAppearance.BorderSize = 0
        Me.BtnNewTransportation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewTransportation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewTransportation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNewTransportation.Image = CType(resources.GetObject("BtnNewTransportation.Image"), System.Drawing.Image)
        Me.BtnNewTransportation.Location = New System.Drawing.Point(3, 4)
        Me.BtnNewTransportation.Name = "BtnNewTransportation"
        Me.BtnNewTransportation.Size = New System.Drawing.Size(143, 55)
        Me.BtnNewTransportation.TabIndex = 10
        Me.BtnNewTransportation.Text = "New Transport"
        Me.BtnNewTransportation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnNewTransportation.UseVisualStyleBackColor = True
        '
        'DashboardTransportation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.BtnNewTransportation)
        Me.Controls.Add(Me.btnTransportPara)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "DashboardTransportation"
        Me.Size = New System.Drawing.Size(1127, 697)
        CType(Me.GridClientTransportation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextTransport.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridTransDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnFindClientReceipt As System.Windows.Forms.Button
    Friend WithEvents BtnNewTransportation As System.Windows.Forms.Button
    Friend WithEvents GridClientTransportation As Janus.Windows.GridEX.GridEX
    Friend WithEvents VSMInterface As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTransportPara As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridTransDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents ContextTransport As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnUpdateTransport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteTransport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUndoTransport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnReport As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TxtSearchClientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSearchClientNo As System.Windows.Forms.TextBox
    Friend WithEvents RadByClientname As System.Windows.Forms.RadioButton
    Friend WithEvents RadByClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllClient As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
