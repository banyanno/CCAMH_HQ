<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAssetCategory
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAssetCategory))
        Dim GridAssetCategory_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCancle = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAssetCategory = New System.Windows.Forms.TextBox()
        Me.GridAssetCategory = New Janus.Windows.GridEX.GridEX()
        Me.lblSaveOption = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridAssetCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.BtnDelete, Me.ToolStripSeparator3, Me.BtnCancle})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(351, 48)
        Me.ToolStrip1.TabIndex = 109
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(78, 45)
        Me.BtnNew.Text = "    New    "
        Me.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(75, 45)
        Me.ToolStripButton1.Text = "    Save   "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        'BtnDelete
        '
        Me.BtnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(82, 45)
        Me.BtnDelete.Text = "   Delete   "
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnDelete.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        Me.ToolStripSeparator3.Visible = False
        '
        'BtnCancle
        '
        Me.BtnCancle.ForeColor = System.Drawing.Color.Maroon
        Me.BtnCancle.Image = CType(resources.GetObject("BtnCancle.Image"), System.Drawing.Image)
        Me.BtnCancle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(80, 45)
        Me.BtnCancle.Text = "  Close     "
        Me.BtnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Asset Category:"
        '
        'txtAssetCategory
        '
        Me.txtAssetCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtAssetCategory.Font = New System.Drawing.Font("Kh Battambang", 10.0!)
        Me.txtAssetCategory.HideSelection = False
        Me.txtAssetCategory.Location = New System.Drawing.Point(12, 73)
        Me.txtAssetCategory.Name = "txtAssetCategory"
        Me.txtAssetCategory.Size = New System.Drawing.Size(323, 32)
        Me.txtAssetCategory.TabIndex = 110
        '
        'GridAssetCategory
        '
        Me.GridAssetCategory.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridAssetCategory.BackColor = System.Drawing.Color.White
        Me.GridAssetCategory.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridAssetCategory_DesignTimeLayout.LayoutString = resources.GetString("GridAssetCategory_DesignTimeLayout.LayoutString")
        Me.GridAssetCategory.DesignTimeLayout = GridAssetCategory_DesignTimeLayout
        Me.GridAssetCategory.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridAssetCategory.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridAssetCategory.GroupByBoxVisible = False
        Me.GridAssetCategory.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridAssetCategory.HeaderFormatStyle.FontSize = 9.0!
        Me.GridAssetCategory.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridAssetCategory.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridAssetCategory.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridAssetCategory.Location = New System.Drawing.Point(12, 111)
        Me.GridAssetCategory.Name = "GridAssetCategory"
        Me.GridAssetCategory.RecordNavigator = True
        Me.GridAssetCategory.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridAssetCategory.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridAssetCategory.Size = New System.Drawing.Size(322, 383)
        Me.GridAssetCategory.TabIndex = 113
        Me.GridAssetCategory.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'lblSaveOption
        '
        Me.lblSaveOption.AutoSize = True
        Me.lblSaveOption.Location = New System.Drawing.Point(284, 57)
        Me.lblSaveOption.Name = "lblSaveOption"
        Me.lblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.lblSaveOption.TabIndex = 112
        Me.lblSaveOption.Text = "0"
        Me.lblSaveOption.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormAssetCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 500)
        Me.Controls.Add(Me.GridAssetCategory)
        Me.Controls.Add(Me.lblSaveOption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAssetCategory)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAssetCategory"
        Me.Text = "Asset Category:"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridAssetCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancle As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAssetCategory As System.Windows.Forms.TextBox
    Friend WithEvents GridAssetCategory As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
