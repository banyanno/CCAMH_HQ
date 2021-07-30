<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardSettingMedicincePrice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardSettingMedicincePrice))
        Dim GridDrugPrice_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewPrice = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.GridDrugPrice = New Janus.Windows.GridEX.GridEX
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtFindByName = New System.Windows.Forms.TextBox
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridDrugPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator4, Me.BtnNewPrice, Me.ToolStripSeparator1, Me.BtnReport, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(495, 53)
        Me.ToolStrip1.TabIndex = 48
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(127, 50)
        Me.BtnRefresh.Text = "        Refresh       "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 53)
        '
        'BtnNewPrice
        '
        Me.BtnNewPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNewPrice.Image = CType(resources.GetObject("BtnNewPrice.Image"), System.Drawing.Image)
        Me.BtnNewPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewPrice.Name = "BtnNewPrice"
        Me.BtnNewPrice.Size = New System.Drawing.Size(165, 50)
        Me.BtnNewPrice.Text = "    Set new drug price   "
        Me.BtnNewPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'BtnReport
        '
        Me.BtnReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnReport.Image = CType(resources.GetObject("BtnReport.Image"), System.Drawing.Image)
        Me.BtnReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(151, 50)
        Me.BtnReport.Text = "     Report Drug Price"
        Me.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'GridDrugPrice
        '
        Me.GridDrugPrice.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDrugPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDrugPrice.BackColor = System.Drawing.Color.White
        Me.GridDrugPrice.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridDrugPrice_DesignTimeLayout.LayoutString = resources.GetString("GridDrugPrice_DesignTimeLayout.LayoutString")
        Me.GridDrugPrice.DesignTimeLayout = GridDrugPrice_DesignTimeLayout
        Me.GridDrugPrice.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridDrugPrice.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridDrugPrice.GroupByBoxVisible = False
        Me.GridDrugPrice.HeaderFormatStyle.BackColor = System.Drawing.Color.Ivory
        Me.GridDrugPrice.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridDrugPrice.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridDrugPrice.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridDrugPrice.Location = New System.Drawing.Point(0, 53)
        Me.GridDrugPrice.Name = "GridDrugPrice"
        Me.GridDrugPrice.RecordNavigator = True
        Me.GridDrugPrice.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridDrugPrice.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDrugPrice.Size = New System.Drawing.Size(797, 483)
        Me.GridDrugPrice.TabIndex = 49
        Me.GridDrugPrice.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridDrugPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(607, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Find by item name"
        '
        'TxtFindByName
        '
        Me.TxtFindByName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFindByName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFindByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindByName.Location = New System.Drawing.Point(610, 25)
        Me.TxtFindByName.Name = "TxtFindByName"
        Me.TxtFindByName.Size = New System.Drawing.Size(182, 26)
        Me.TxtFindByName.TabIndex = 51
        '
        'BgLoadingReport
        '
        '
        'DashboardSettingMedicincePrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TxtFindByName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridDrugPrice)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardSettingMedicincePrice"
        Me.Size = New System.Drawing.Size(797, 536)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridDrugPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridDrugPrice As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFindByName As System.Windows.Forms.TextBox
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker

End Class
