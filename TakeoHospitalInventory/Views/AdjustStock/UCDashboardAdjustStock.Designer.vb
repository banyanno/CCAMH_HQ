<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDashboardAdjustStock
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
        Dim gridAdjustmentHistory_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDashboardAdjustStock))
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.gridAdjustmentHistory = New Janus.Windows.GridEX.GridEX()
        Me.VSForOpticalshop = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateAdjTo = New System.Windows.Forms.DateTimePicker()
        Me.DateAdjFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnApproved = New System.Windows.Forms.ToolStripButton()
        Me.BtnRevert = New System.Windows.Forms.ToolStripButton()
        Me.BtnRefreshData = New System.Windows.Forms.ToolStripButton()
        Me.BtnFinItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridAdjustmentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 59)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnApproved, Me.ToolStripSeparator4, Me.BtnRevert, Me.BtnRefreshData, Me.ToolStripSeparator1, Me.BtnFinItem})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1222, 59)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'gridAdjustmentHistory
        '
        Me.gridAdjustmentHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        gridAdjustmentHistory_DesignTimeLayout.LayoutString = resources.GetString("gridAdjustmentHistory_DesignTimeLayout.LayoutString")
        Me.gridAdjustmentHistory.DesignTimeLayout = gridAdjustmentHistory_DesignTimeLayout
        Me.gridAdjustmentHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridAdjustmentHistory.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridAdjustmentHistory.GroupByBoxVisible = False
        Me.gridAdjustmentHistory.Location = New System.Drawing.Point(3, 51)
        Me.gridAdjustmentHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.gridAdjustmentHistory.Name = "gridAdjustmentHistory"
        Me.gridAdjustmentHistory.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Silver
        Me.gridAdjustmentHistory.OfficeCustomColor = System.Drawing.SystemColors.Control
        Me.gridAdjustmentHistory.RecordNavigator = True
        Me.gridAdjustmentHistory.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridAdjustmentHistory.Size = New System.Drawing.Size(1219, 275)
        Me.gridAdjustmentHistory.TabIndex = 34
        Me.gridAdjustmentHistory.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.gridAdjustmentHistory.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridAdjustmentHistory.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'VSForOpticalshop
        '
        JanusColorScheme1.ActiveCaptionColor = System.Drawing.Color.Tomato
        JanusColorScheme1.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme1.ControlDarkColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(102, Byte), Integer))
        JanusColorScheme1.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        JanusColorScheme1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(67, Byte), Integer))
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme1.InfoColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme1.InfoTextColor = System.Drawing.Color.FloralWhite
        JanusColorScheme1.MenuColor = System.Drawing.SystemColors.ActiveCaption
        JanusColorScheme1.MenuTextColor = System.Drawing.Color.DimGray
        JanusColorScheme1.Name = "Header"
        JanusColorScheme1.OfficeColorScheme = Janus.Windows.Common.OfficeColorScheme.Silver
        JanusColorScheme1.OfficeCustomColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.DarkBlue
        Me.VSForOpticalshop.ColorSchemes.Add(JanusColorScheme1)
        Me.VSForOpticalshop.DefaultColorScheme = "Header"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateAdjTo)
        Me.GroupBox1.Controls.Add(Me.DateAdjFrom)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.gridAdjustmentHistory)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1222, 378)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Approve Adjust Information"
        '
        'DateAdjTo
        '
        Me.DateAdjTo.CustomFormat = "dd/MM/yyyy"
        Me.DateAdjTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAdjTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAdjTo.Location = New System.Drawing.Point(245, 19)
        Me.DateAdjTo.Name = "DateAdjTo"
        Me.DateAdjTo.Size = New System.Drawing.Size(116, 26)
        Me.DateAdjTo.TabIndex = 40
        '
        'DateAdjFrom
        '
        Me.DateAdjFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateAdjFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAdjFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAdjFrom.Location = New System.Drawing.Point(71, 19)
        Me.DateAdjFrom.Name = "DateAdjFrom"
        Me.DateAdjFrom.Size = New System.Drawing.Size(116, 26)
        Me.DateAdjFrom.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(195, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Date To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Date From:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1216, 45)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Note:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(161, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Waiting Approval"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(39, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Approved"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.ImageList = Me.ImageList1
        Me.Label2.Location = New System.Drawing.Point(127, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 24)
        Me.Label2.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "circle_red.png")
        Me.ImageList1.Images.SetKeyName(1, "circle_blue.png")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.ImageList = Me.ImageList1
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 24)
        Me.Label1.TabIndex = 0
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 59)
        '
        'BtnApproved
        '
        Me.BtnApproved.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnApproved.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnApproved.Image = CType(resources.GetObject("BtnApproved.Image"), System.Drawing.Image)
        Me.BtnApproved.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnApproved.Name = "BtnApproved"
        Me.BtnApproved.Size = New System.Drawing.Size(116, 56)
        Me.BtnApproved.Text = "Approve Adjust"
        Me.BtnApproved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnRevert
        '
        Me.BtnRevert.AutoSize = False
        Me.BtnRevert.Image = Global.KTGSYS.My.Resources.Resources.RightLeft2Red
        Me.BtnRevert.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRevert.Name = "BtnRevert"
        Me.BtnRevert.Size = New System.Drawing.Size(80, 31)
        Me.BtnRevert.Text = "Revert"
        Me.BtnRevert.Visible = False
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnRefreshData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefreshData.Image = CType(resources.GetObject("BtnRefreshData.Image"), System.Drawing.Image)
        Me.BtnRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Size = New System.Drawing.Size(98, 56)
        Me.BtnRefreshData.Text = "Refresh Data"
        Me.BtnRefreshData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnFinItem
        '
        Me.BtnFinItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnFinItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFinItem.Image = CType(resources.GetObject("BtnFinItem.Image"), System.Drawing.Image)
        Me.BtnFinItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFinItem.Name = "BtnFinItem"
        Me.BtnFinItem.Size = New System.Drawing.Size(107, 56)
        Me.BtnFinItem.Text = "    Find Item    "
        Me.BtnFinItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UCDashboardAdjustStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCDashboardAdjustStock"
        Me.Size = New System.Drawing.Size(1222, 437)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridAdjustmentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnApproved As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRevert As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnRefreshData As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridAdjustmentHistory As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DateAdjFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateAdjTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents VSForOpticalshop As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFinItem As System.Windows.Forms.ToolStripButton

End Class
