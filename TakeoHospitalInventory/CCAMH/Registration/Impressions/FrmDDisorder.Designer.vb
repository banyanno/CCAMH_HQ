<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDDisorder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDDisorder))
        Dim GridDDisorder_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSymptom = New System.Windows.Forms.TextBox()
        Me.lblDisorderSave = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCancle = New System.Windows.Forms.ToolStripButton()
        Me.GridDDisorder = New Janus.Windows.GridEX.GridEX()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridDDisorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtDescription.Font = New System.Drawing.Font("Kh Battambang", 10.0!)
        Me.txtDescription.HideSelection = False
        Me.txtDescription.Location = New System.Drawing.Point(15, 128)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(323, 45)
        Me.txtDescription.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Symptom:"
        '
        'txtSymptom
        '
        Me.txtSymptom.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtSymptom.Font = New System.Drawing.Font("Kh Battambang", 10.0!)
        Me.txtSymptom.HideSelection = False
        Me.txtSymptom.Location = New System.Drawing.Point(15, 72)
        Me.txtSymptom.Name = "txtSymptom"
        Me.txtSymptom.Size = New System.Drawing.Size(323, 32)
        Me.txtSymptom.TabIndex = 8
        '
        'lblDisorderSave
        '
        Me.lblDisorderSave.AutoSize = True
        Me.lblDisorderSave.Location = New System.Drawing.Point(445, 91)
        Me.lblDisorderSave.Name = "lblDisorderSave"
        Me.lblDisorderSave.Size = New System.Drawing.Size(13, 13)
        Me.lblDisorderSave.TabIndex = 7
        Me.lblDisorderSave.Text = "0"
        Me.lblDisorderSave.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.BtnDelete, Me.ToolStripSeparator3, Me.BtnCancle})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(606, 48)
        Me.ToolStrip1.TabIndex = 105
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
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
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
        'GridDDisorder
        '
        Me.GridDDisorder.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDDisorder.BackColor = System.Drawing.SystemColors.Control
        GridDDisorder_DesignTimeLayout.LayoutString = resources.GetString("GridDDisorder_DesignTimeLayout.LayoutString")
        Me.GridDDisorder.DesignTimeLayout = GridDDisorder_DesignTimeLayout
        Me.GridDDisorder.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridDDisorder.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridDDisorder.GroupByBoxVisible = False
        Me.GridDDisorder.HeaderFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridDDisorder.HeaderFormatStyle.FontSize = 9.0!
        Me.GridDDisorder.HeaderFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.GridDDisorder.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridDDisorder.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridDDisorder.Location = New System.Drawing.Point(12, 179)
        Me.GridDDisorder.Name = "GridDDisorder"
        Me.GridDDisorder.RecordNavigator = True
        Me.GridDDisorder.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridDDisorder.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDDisorder.Size = New System.Drawing.Size(585, 326)
        Me.GridDDisorder.TabIndex = 106
        Me.GridDDisorder.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'FrmDDisorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 517)
        Me.Controls.Add(Me.GridDDisorder)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSymptom)
        Me.Controls.Add(Me.lblDisorderSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDDisorder"
        Me.ShowInTaskbar = False
        Me.Text = "Developmental Disorder"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridDDisorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSymptom As System.Windows.Forms.TextBox
    Friend WithEvents lblDisorderSave As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancle As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridDDisorder As Janus.Windows.GridEX.GridEX
End Class
