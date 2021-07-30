<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIFastTrackMainDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIFastTrackMainDashboard))
        Dim GridClientFastTrackingDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintReport = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadViewAllFastTracking = New System.Windows.Forms.RadioButton
        Me.BtnFind = New System.Windows.Forms.Button
        Me.CboTherapy = New System.Windows.Forms.ComboBox
        Me.RadTherapy = New System.Windows.Forms.RadioButton
        Me.TxtSearchClientName = New System.Windows.Forms.TextBox
        Me.RadClientName = New System.Windows.Forms.RadioButton
        Me.RadClientNo = New System.Windows.Forms.RadioButton
        Me.TxtSearchClientNo = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridClientFastTrackingDetail = New Janus.Windows.GridEX.GridEX
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtDateRefer = New System.Windows.Forms.TextBox
        Me.TxtClientName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtReferTo = New System.Windows.Forms.TextBox
        Me.TxtReferNote = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridClientFastTrackingDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.BtnPrintReport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1401, 52)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(98, 49)
        Me.ToolStripButton2.Text = "    Refresh     "
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(139, 49)
        Me.ToolStripButton1.Text = "    New fast track    "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'BtnPrintReport
        '
        Me.BtnPrintReport.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnPrintReport.Image = CType(resources.GetObject("BtnPrintReport.Image"), System.Drawing.Image)
        Me.BtnPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintReport.Name = "BtnPrintReport"
        Me.BtnPrintReport.Size = New System.Drawing.Size(124, 49)
        Me.BtnPrintReport.Text = "     Print report    "
        Me.BtnPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1401, 625)
        Me.SplitContainer1.SplitterDistance = 1112
        Me.SplitContainer1.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadViewAllFastTracking)
        Me.GroupBox4.Controls.Add(Me.BtnFind)
        Me.GroupBox4.Controls.Add(Me.CboTherapy)
        Me.GroupBox4.Controls.Add(Me.RadTherapy)
        Me.GroupBox4.Controls.Add(Me.TxtSearchClientName)
        Me.GroupBox4.Controls.Add(Me.RadClientName)
        Me.GroupBox4.Controls.Add(Me.RadClientNo)
        Me.GroupBox4.Controls.Add(Me.TxtSearchClientNo)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(283, 623)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Find tracking"
        '
        'RadViewAllFastTracking
        '
        Me.RadViewAllFastTracking.AutoSize = True
        Me.RadViewAllFastTracking.Checked = True
        Me.RadViewAllFastTracking.Location = New System.Drawing.Point(6, 39)
        Me.RadViewAllFastTracking.Name = "RadViewAllFastTracking"
        Me.RadViewAllFastTracking.Size = New System.Drawing.Size(171, 24)
        Me.RadViewAllFastTracking.TabIndex = 19
        Me.RadViewAllFastTracking.TabStop = True
        Me.RadViewAllFastTracking.Text = "View all fast tracking"
        Me.RadViewAllFastTracking.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.Maroon
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatAppearance.BorderSize = 0
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(3, 282)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(272, 42)
        Me.BtnFind.TabIndex = 18
        Me.BtnFind.Text = "Finding"
        Me.BtnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'CboTherapy
        '
        Me.CboTherapy.Enabled = False
        Me.CboTherapy.FormattingEnabled = True
        Me.CboTherapy.Location = New System.Drawing.Point(6, 243)
        Me.CboTherapy.Name = "CboTherapy"
        Me.CboTherapy.Size = New System.Drawing.Size(270, 28)
        Me.CboTherapy.TabIndex = 17
        '
        'RadTherapy
        '
        Me.RadTherapy.AutoSize = True
        Me.RadTherapy.Location = New System.Drawing.Point(6, 214)
        Me.RadTherapy.Name = "RadTherapy"
        Me.RadTherapy.Size = New System.Drawing.Size(133, 24)
        Me.RadTherapy.TabIndex = 16
        Me.RadTherapy.Text = "Select Therapy"
        Me.RadTherapy.UseVisualStyleBackColor = True
        '
        'TxtSearchClientName
        '
        Me.TxtSearchClientName.Enabled = False
        Me.TxtSearchClientName.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchClientName.Location = New System.Drawing.Point(6, 177)
        Me.TxtSearchClientName.Name = "TxtSearchClientName"
        Me.TxtSearchClientName.Size = New System.Drawing.Size(270, 30)
        Me.TxtSearchClientName.TabIndex = 15
        '
        'RadClientName
        '
        Me.RadClientName.AutoSize = True
        Me.RadClientName.Location = New System.Drawing.Point(6, 147)
        Me.RadClientName.Name = "RadClientName"
        Me.RadClientName.Size = New System.Drawing.Size(146, 24)
        Me.RadClientName.TabIndex = 14
        Me.RadClientName.Text = "Client Name Eng"
        Me.RadClientName.UseVisualStyleBackColor = True
        '
        'RadClientNo
        '
        Me.RadClientNo.AutoSize = True
        Me.RadClientNo.Location = New System.Drawing.Point(9, 83)
        Me.RadClientNo.Name = "RadClientNo"
        Me.RadClientNo.Size = New System.Drawing.Size(95, 24)
        Me.RadClientNo.TabIndex = 5
        Me.RadClientNo.Text = "Client No:"
        Me.RadClientNo.UseVisualStyleBackColor = True
        '
        'TxtSearchClientNo
        '
        Me.TxtSearchClientNo.Enabled = False
        Me.TxtSearchClientNo.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchClientNo.Location = New System.Drawing.Point(6, 111)
        Me.TxtSearchClientNo.Name = "TxtSearchClientNo"
        Me.TxtSearchClientNo.Size = New System.Drawing.Size(270, 30)
        Me.TxtSearchClientNo.TabIndex = 13
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(285, 625)
        Me.SplitContainer2.SplitterDistance = 470
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridClientFastTrackingDetail)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1110, 623)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fast track details"
        '
        'GridClientFastTrackingDetail
        '
        Me.GridClientFastTrackingDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientFastTrackingDetail.BackColor = System.Drawing.Color.White
        Me.GridClientFastTrackingDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridClientFastTrackingDetail.CardBorders = False
        GridClientFastTrackingDetail_DesignTimeLayout.LayoutString = resources.GetString("GridClientFastTrackingDetail_DesignTimeLayout.LayoutString")
        Me.GridClientFastTrackingDetail.DesignTimeLayout = GridClientFastTrackingDetail_DesignTimeLayout
        Me.GridClientFastTrackingDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientFastTrackingDetail.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GridClientFastTrackingDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientFastTrackingDetail.GroupByBoxVisible = False
        Me.GridClientFastTrackingDetail.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClientFastTrackingDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridClientFastTrackingDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClientFastTrackingDetail.Location = New System.Drawing.Point(3, 22)
        Me.GridClientFastTrackingDetail.Name = "GridClientFastTrackingDetail"
        Me.GridClientFastTrackingDetail.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridClientFastTrackingDetail.RecordNavigator = True
        Me.GridClientFastTrackingDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientFastTrackingDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientFastTrackingDetail.SelectedFormatStyle.BackColor = System.Drawing.Color.Gray
        Me.GridClientFastTrackingDetail.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Gray
        Me.GridClientFastTrackingDetail.Size = New System.Drawing.Size(1104, 598)
        Me.GridClientFastTrackingDetail.TabIndex = 3
        Me.GridClientFastTrackingDetail.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientFastTrackingDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtDateRefer)
        Me.GroupBox3.Controls.Add(Me.TxtClientName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtReferTo)
        Me.GroupBox3.Controls.Add(Me.TxtReferNote)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 44)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Refer Detail"
        '
        'TxtDateRefer
        '
        Me.TxtDateRefer.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateRefer.Location = New System.Drawing.Point(193, 102)
        Me.TxtDateRefer.Name = "TxtDateRefer"
        Me.TxtDateRefer.Size = New System.Drawing.Size(133, 30)
        Me.TxtDateRefer.TabIndex = 15
        Me.TxtDateRefer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtClientName
        '
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(9, 103)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.Size = New System.Drawing.Size(169, 30)
        Me.TxtClientName.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Date Refer:"
        '
        'TxtReferTo
        '
        Me.TxtReferTo.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferTo.Location = New System.Drawing.Point(9, 47)
        Me.TxtReferTo.Name = "TxtReferTo"
        Me.TxtReferTo.Size = New System.Drawing.Size(315, 30)
        Me.TxtReferTo.TabIndex = 7
        '
        'TxtReferNote
        '
        Me.TxtReferNote.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferNote.Location = New System.Drawing.Point(332, 47)
        Me.TxtReferNote.Multiline = True
        Me.TxtReferNote.Name = "TxtReferNote"
        Me.TxtReferNote.Size = New System.Drawing.Size(317, 85)
        Me.TxtReferNote.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(332, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Refer note:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Client Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Refer To:"
        '
        'UIFastTrackMainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UIFastTrackMainDashboard"
        Me.Size = New System.Drawing.Size(1401, 677)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridClientFastTrackingDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents CboTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents RadTherapy As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSearchClientName As System.Windows.Forms.TextBox
    Friend WithEvents RadClientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSearchClientNo As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridClientFastTrackingDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDateRefer As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtReferTo As System.Windows.Forms.TextBox
    Friend WithEvents TxtReferNote As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RadViewAllFastTracking As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPrintReport As System.Windows.Forms.ToolStripButton

End Class
