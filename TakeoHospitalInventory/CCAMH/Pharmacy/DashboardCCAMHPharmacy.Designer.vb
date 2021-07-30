<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCCAMHPharmacy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardCCAMHPharmacy))
        Dim GridPrescription_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPrescriptionDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewPrescriptionPrescription = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEditPrescription = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintCashDistribute = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnFindPrescription = New System.Windows.Forms.ToolStripButton
        Me.GridPrescription = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.PanelMain = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadAllClient = New System.Windows.Forms.RadioButton
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtClientName = New System.Windows.Forms.TextBox
        Me.RadClientName = New System.Windows.Forms.RadioButton
        Me.RadClientNo = New System.Windows.Forms.RadioButton
        Me.TxtClientNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridPrescriptionDetail = New Janus.Windows.GridEX.GridEX
        Me.bgPrescription = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridPrescriptionDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator3, Me.BtnNewPrescriptionPrescription, Me.ToolStripSeparator1, Me.BtnEditPrescription, Me.ToolStripSeparator4, Me.BtnPrintCashDistribute, Me.ToolStripSeparator2, Me.BtnFindPrescription})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(960, 52)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(98, 49)
        Me.BtnRefresh.Text = "         Refresh       "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'BtnNewPrescriptionPrescription
        '
        Me.BtnNewPrescriptionPrescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNewPrescriptionPrescription.Image = CType(resources.GetObject("BtnNewPrescriptionPrescription.Image"), System.Drawing.Image)
        Me.BtnNewPrescriptionPrescription.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewPrescriptionPrescription.Name = "BtnNewPrescriptionPrescription"
        Me.BtnNewPrescriptionPrescription.Size = New System.Drawing.Size(145, 49)
        Me.BtnNewPrescriptionPrescription.Text = "          New Presciption      "
        Me.BtnNewPrescriptionPrescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'BtnEditPrescription
        '
        Me.BtnEditPrescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEditPrescription.Image = CType(resources.GetObject("BtnEditPrescription.Image"), System.Drawing.Image)
        Me.BtnEditPrescription.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditPrescription.Name = "BtnEditPrescription"
        Me.BtnEditPrescription.Size = New System.Drawing.Size(118, 49)
        Me.BtnEditPrescription.Text = "    Edit Prescription   "
        Me.BtnEditPrescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 52)
        '
        'BtnPrintCashDistribute
        '
        Me.BtnPrintCashDistribute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPrintCashDistribute.Image = CType(resources.GetObject("BtnPrintCashDistribute.Image"), System.Drawing.Image)
        Me.BtnPrintCashDistribute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintCashDistribute.Name = "BtnPrintCashDistribute"
        Me.BtnPrintCashDistribute.Size = New System.Drawing.Size(123, 49)
        Me.BtnPrintCashDistribute.Text = "    Print Prescription   "
        Me.BtnPrintCashDistribute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'BtnFindPrescription
        '
        Me.BtnFindPrescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFindPrescription.Image = CType(resources.GetObject("BtnFindPrescription.Image"), System.Drawing.Image)
        Me.BtnFindPrescription.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFindPrescription.Name = "BtnFindPrescription"
        Me.BtnFindPrescription.Size = New System.Drawing.Size(118, 49)
        Me.BtnFindPrescription.Text = "   Find Prescription   "
        Me.BtnFindPrescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnFindPrescription.Visible = False
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
        Me.GridPrescription.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridPrescription.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPrescription.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPrescription.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPrescription.Location = New System.Drawing.Point(0, 0)
        Me.GridPrescription.Name = "GridPrescription"
        Me.GridPrescription.RecordNavigator = True
        Me.GridPrescription.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridPrescription.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPrescription.Size = New System.Drawing.Size(626, 334)
        Me.GridPrescription.TabIndex = 7
        Me.GridPrescription.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridPrescription.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridPrescriptionDetail)
        Me.SplitContainer1.Size = New System.Drawing.Size(960, 497)
        Me.SplitContainer1.SplitterDistance = 334
        Me.SplitContainer1.TabIndex = 8
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridPrescription)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.PanelMain)
        Me.SplitContainer2.Size = New System.Drawing.Size(960, 334)
        Me.SplitContainer2.SplitterDistance = 626
        Me.SplitContainer2.TabIndex = 8
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.Panel3)
        Me.PanelMain.Controls.Add(Me.Label2)
        Me.PanelMain.Controls.Add(Me.Label1)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(330, 334)
        Me.PanelMain.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BtnFind)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 271)
        Me.Panel3.TabIndex = 0
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatAppearance.BorderSize = 0
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(3, 228)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(314, 38)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.Text = "Find"
        Me.BtnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadAllClient)
        Me.Panel1.Controls.Add(Me.DTo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DFrom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtClientName)
        Me.Panel1.Controls.Add(Me.RadClientName)
        Me.Panel1.Controls.Add(Me.RadClientNo)
        Me.Panel1.Controls.Add(Me.TxtClientNo)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 219)
        Me.Panel1.TabIndex = 2
        '
        'RadAllClient
        '
        Me.RadAllClient.AutoSize = True
        Me.RadAllClient.Checked = True
        Me.RadAllClient.Location = New System.Drawing.Point(5, 73)
        Me.RadAllClient.Name = "RadAllClient"
        Me.RadAllClient.Size = New System.Drawing.Size(85, 29)
        Me.RadAllClient.TabIndex = 12
        Me.RadAllClient.TabStop = True
        Me.RadAllClient.Text = "All Client"
        Me.RadAllClient.UseVisualStyleBackColor = True
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(166, 35)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(136, 32)
        Me.DTo.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(166, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date To"
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(5, 35)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(135, 32)
        Me.DFrom.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date From"
        '
        'TxtClientName
        '
        Me.TxtClientName.Enabled = False
        Me.TxtClientName.Location = New System.Drawing.Point(6, 173)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.Size = New System.Drawing.Size(297, 32)
        Me.TxtClientName.TabIndex = 7
        '
        'RadClientName
        '
        Me.RadClientName.AutoSize = True
        Me.RadClientName.Location = New System.Drawing.Point(5, 144)
        Me.RadClientName.Name = "RadClientName"
        Me.RadClientName.Size = New System.Drawing.Size(107, 29)
        Me.RadClientName.TabIndex = 6
        Me.RadClientName.Text = "Client Name"
        Me.RadClientName.UseVisualStyleBackColor = True
        '
        'RadClientNo
        '
        Me.RadClientNo.AutoSize = True
        Me.RadClientNo.Location = New System.Drawing.Point(166, 73)
        Me.RadClientNo.Name = "RadClientNo"
        Me.RadClientNo.Size = New System.Drawing.Size(92, 29)
        Me.RadClientNo.TabIndex = 6
        Me.RadClientNo.Text = "Client No:"
        Me.RadClientNo.UseVisualStyleBackColor = True
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Enabled = False
        Me.TxtClientNo.Location = New System.Drawing.Point(6, 108)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.Size = New System.Drawing.Size(297, 32)
        Me.TxtClientNo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(124, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Find Client "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Mool1", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(89, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ស្វែងរកអតិថិជន"
        '
        'GridPrescriptionDetail
        '
        Me.GridPrescriptionDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPrescriptionDetail.BackColor = System.Drawing.Color.White
        Me.GridPrescriptionDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridPrescriptionDetail_DesignTimeLayout.LayoutString = resources.GetString("GridPrescriptionDetail_DesignTimeLayout.LayoutString")
        Me.GridPrescriptionDetail.DesignTimeLayout = GridPrescriptionDetail_DesignTimeLayout
        Me.GridPrescriptionDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrescriptionDetail.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridPrescriptionDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPrescriptionDetail.GroupByBoxVisible = False
        Me.GridPrescriptionDetail.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridPrescriptionDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPrescriptionDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPrescriptionDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPrescriptionDetail.Location = New System.Drawing.Point(0, 0)
        Me.GridPrescriptionDetail.Name = "GridPrescriptionDetail"
        Me.GridPrescriptionDetail.RecordNavigator = True
        Me.GridPrescriptionDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridPrescriptionDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPrescriptionDetail.Size = New System.Drawing.Size(960, 159)
        Me.GridPrescriptionDetail.TabIndex = 8
        Me.GridPrescriptionDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridPrescriptionDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'bgPrescription
        '
        '
        'DashboardCCAMHPharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardCCAMHPharmacy"
        Me.Size = New System.Drawing.Size(960, 549)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridPrescriptionDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewPrescriptionPrescription As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintCashDistribute As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridPrescription As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridPrescriptionDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFindPrescription As System.Windows.Forms.ToolStripButton
    Friend WithEvents bgPrescription As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditPrescription As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadAllClient As System.Windows.Forms.RadioButton
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtClientName As System.Windows.Forms.TextBox
    Friend WithEvents RadClientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
