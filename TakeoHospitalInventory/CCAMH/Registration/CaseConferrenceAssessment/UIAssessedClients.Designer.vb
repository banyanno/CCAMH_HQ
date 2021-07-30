<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIAssessedClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIAssessedClients))
        Dim DataGridClient_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnViewDetail = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnClientRefresh = New System.Windows.Forms.ToolStripButton
        Me.DataGridClient = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnViewDetail, Me.ToolStripSeparator1, Me.btnReport, Me.ToolStripSeparator7, Me.BtnClientRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(816, 58)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnViewDetail
        '
        Me.BtnViewDetail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnViewDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnViewDetail.Image = CType(resources.GetObject("BtnViewDetail.Image"), System.Drawing.Image)
        Me.BtnViewDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewDetail.Name = "BtnViewDetail"
        Me.BtnViewDetail.Size = New System.Drawing.Size(92, 55)
        Me.BtnViewDetail.Text = "View Detail"
        Me.BtnViewDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReport.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(100, 55)
        Me.btnReport.Text = "Print Report      "
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 58)
        '
        'BtnClientRefresh
        '
        Me.BtnClientRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BtnClientRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClientRefresh.Image = CType(resources.GetObject("BtnClientRefresh.Image"), System.Drawing.Image)
        Me.BtnClientRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClientRefresh.Name = "BtnClientRefresh"
        Me.BtnClientRefresh.Size = New System.Drawing.Size(104, 55)
        Me.BtnClientRefresh.Text = "        Refresh       "
        Me.BtnClientRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridClient
        '
        Me.DataGridClient.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.DataGridClient.BackColor = System.Drawing.Color.White
        Me.DataGridClient.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.DataGridClient.CardBorders = False
        DataGridClient_DesignTimeLayout.LayoutString = resources.GetString("DataGridClient_DesignTimeLayout.LayoutString")
        Me.DataGridClient.DesignTimeLayout = DataGridClient_DesignTimeLayout
        Me.DataGridClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridClient.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridClient.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.DataGridClient.GroupByBoxVisible = False
        Me.DataGridClient.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.DataGridClient.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridClient.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.DataGridClient.Location = New System.Drawing.Point(0, 58)
        Me.DataGridClient.Name = "DataGridClient"
        Me.DataGridClient.RecordNavigator = True
        Me.DataGridClient.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.DataGridClient.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.DataGridClient.Size = New System.Drawing.Size(816, 441)
        Me.DataGridClient.TabIndex = 3
        Me.DataGridClient.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.DataGridClient.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'UIAssessedClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridClient)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UIAssessedClients"
        Me.Size = New System.Drawing.Size(816, 499)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridClient As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnViewDetail As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClientRefresh As System.Windows.Forms.ToolStripButton

End Class
