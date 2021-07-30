<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBrand
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
        Dim GridBrand_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBrand))
        Me.GridBrand = New Janus.Windows.GridEX.GridEX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNewBrand = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.GridBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridBrand
        '
        GridBrand_DesignTimeLayout.LayoutString = resources.GetString("GridBrand_DesignTimeLayout.LayoutString")
        Me.GridBrand.DesignTimeLayout = GridBrand_DesignTimeLayout
        Me.GridBrand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridBrand.GroupByBoxVisible = False
        Me.GridBrand.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GridBrand.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridBrand.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridBrand.Hierarchical = True
        Me.GridBrand.Location = New System.Drawing.Point(0, 28)
        Me.GridBrand.Name = "GridBrand"
        Me.GridBrand.RecordNavigator = True
        Me.GridBrand.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.GridBrand.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridBrand.Size = New System.Drawing.Size(471, 363)
        Me.GridBrand.TabIndex = 15
        Me.GridBrand.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewBrand, Me.ToolStripSeparator1, Me.BtnRefresh, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(471, 28)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewBrand
        '
        Me.BtnNewBrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNewBrand.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnNewBrand.Image = CType(resources.GetObject("BtnNewBrand.Image"), System.Drawing.Image)
        Me.BtnNewBrand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewBrand.Name = "BtnNewBrand"
        Me.BtnNewBrand.Size = New System.Drawing.Size(86, 25)
        Me.BtnNewBrand.Text = "New Brand"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(91, 25)
        Me.BtnRefresh.Text = "   Refresh   "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'FormBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 391)
        Me.Controls.Add(Me.GridBrand)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBrand"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item Brand"
        CType(Me.GridBrand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridBrand As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewBrand As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
