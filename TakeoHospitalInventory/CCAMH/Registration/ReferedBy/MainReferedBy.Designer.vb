<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainReferedBy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainReferedBy))
        Dim GridReferBy_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNewReferedBy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUPdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDetel = New System.Windows.Forms.ToolStripButton()
        Me.GridReferBy = New Janus.Windows.GridEX.GridEX()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridReferBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator3, Me.BtnNewReferedBy, Me.ToolStripSeparator1, Me.BtnUPdate, Me.ToolStripSeparator2, Me.BtnDetel, Me.ToolStripSeparator4, Me.BtnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(712, 44)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(91, 41)
        Me.ToolStripButton1.Text = "   Refresh   "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 44)
        '
        'BtnNewReferedBy
        '
        Me.BtnNewReferedBy.Image = CType(resources.GetObject("BtnNewReferedBy.Image"), System.Drawing.Image)
        Me.BtnNewReferedBy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewReferedBy.Name = "BtnNewReferedBy"
        Me.BtnNewReferedBy.Size = New System.Drawing.Size(145, 41)
        Me.BtnNewReferedBy.Text = "    New refered by  "
        Me.BtnNewReferedBy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'BtnUPdate
        '
        Me.BtnUPdate.Image = CType(resources.GetObject("BtnUPdate.Image"), System.Drawing.Image)
        Me.BtnUPdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUPdate.Name = "BtnUPdate"
        Me.BtnUPdate.Size = New System.Drawing.Size(96, 41)
        Me.BtnUPdate.Text = "    Update    "
        Me.BtnUPdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'BtnDetel
        '
        Me.BtnDetel.Image = CType(resources.GetObject("BtnDetel.Image"), System.Drawing.Image)
        Me.BtnDetel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDetel.Name = "BtnDetel"
        Me.BtnDetel.Size = New System.Drawing.Size(82, 41)
        Me.BtnDetel.Text = "    Delete  "
        Me.BtnDetel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GridReferBy
        '
        Me.GridReferBy.AllowColumnDrag = False
        Me.GridReferBy.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridReferBy_DesignTimeLayout.LayoutString = resources.GetString("GridReferBy_DesignTimeLayout.LayoutString")
        Me.GridReferBy.DesignTimeLayout = GridReferBy_DesignTimeLayout
        Me.GridReferBy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReferBy.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridReferBy.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridReferBy.GroupByBoxVisible = False
        Me.GridReferBy.Location = New System.Drawing.Point(0, 44)
        Me.GridReferBy.Name = "GridReferBy"
        Me.GridReferBy.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom
        Me.GridReferBy.Size = New System.Drawing.Size(712, 521)
        Me.GridReferBy.TabIndex = 1
        Me.GridReferBy.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 44)
        '
        'BtnClose
        '
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(84, 41)
        Me.BtnClose.Text = "     Close   "
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MainReferedBy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridReferBy)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainReferedBy"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main refered by"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridReferBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewReferedBy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUPdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDetel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridReferBy As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClose As System.Windows.Forms.ToolStripButton
End Class
