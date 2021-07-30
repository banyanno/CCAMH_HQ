<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCome
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
        Dim GridRelativeCome_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboTypeOfRelative = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTypeRelative = New System.Windows.Forms.TextBox()
        Me.ErrRelative = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GridRelativeCome = New Janus.Windows.GridEX.GridEX()
        Me.LblSaveOption = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCancle = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        CType(Me.ErrRelative, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridRelativeCome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type of family:"
        '
        'CboTypeOfRelative
        '
        Me.CboTypeOfRelative.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTypeOfRelative.FormattingEnabled = True
        Me.CboTypeOfRelative.Items.AddRange(New Object() {"", "Relatives", "NGOs", "Other"})
        Me.CboTypeOfRelative.Location = New System.Drawing.Point(12, 73)
        Me.CboTypeOfRelative.Name = "CboTypeOfRelative"
        Me.CboTypeOfRelative.Size = New System.Drawing.Size(230, 26)
        Me.CboTypeOfRelative.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Come with:"
        '
        'TxtTypeRelative
        '
        Me.TxtTypeRelative.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTypeRelative.Location = New System.Drawing.Point(248, 73)
        Me.TxtTypeRelative.Name = "TxtTypeRelative"
        Me.TxtTypeRelative.Size = New System.Drawing.Size(230, 26)
        Me.TxtTypeRelative.TabIndex = 3
        '
        'ErrRelative
        '
        Me.ErrRelative.ContainerControl = Me
        '
        'GridRelativeCome
        '
        Me.GridRelativeCome.AllowColumnDrag = False
        Me.GridRelativeCome.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridRelativeCome.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        GridRelativeCome_DesignTimeLayout.LayoutString = resources.GetString("GridRelativeCome_DesignTimeLayout.LayoutString")
        Me.GridRelativeCome.DesignTimeLayout = GridRelativeCome_DesignTimeLayout
        Me.GridRelativeCome.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridRelativeCome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridRelativeCome.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridRelativeCome.GroupByBoxVisible = False
        Me.GridRelativeCome.HeaderFormatStyle.FontSize = 8.0!
        Me.GridRelativeCome.Location = New System.Drawing.Point(12, 105)
        Me.GridRelativeCome.Name = "GridRelativeCome"
        Me.GridRelativeCome.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom
        Me.GridRelativeCome.RowHeaderFormatStyle.FontSize = 8.0!
        Me.GridRelativeCome.Size = New System.Drawing.Size(466, 327)
        Me.GridRelativeCome.TabIndex = 100
        Me.GridRelativeCome.TableHeaderFormatStyle.FontSize = 8.0!
        Me.GridRelativeCome.ThemedAreas = CType((Janus.Windows.GridEX.ThemedArea.TreeGliphs Or Janus.Windows.GridEX.ThemedArea.GroupRows), Janus.Windows.GridEX.ThemedArea)
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(12, 435)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(16, 18)
        Me.LblSaveOption.TabIndex = 101
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 18)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Double click on record to update"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.BtnSave, Me.ToolStripSeparator2, Me.BtnDelete, Me.ToolStripSeparator3, Me.BtnCancle})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(497, 48)
        Me.ToolStrip1.TabIndex = 103
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnSave
        '
        Me.BtnSave.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 45)
        Me.BtnSave.Text = "    Save   "
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
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
        'FormCome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.GridRelativeCome)
        Me.Controls.Add(Me.TxtTypeRelative)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboTypeOfRelative)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCome"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relative come setting"
        CType(Me.ErrRelative, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridRelativeCome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboTypeOfRelative As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTypeRelative As System.Windows.Forms.TextBox
    Friend WithEvents ErrRelative As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridRelativeCome As Janus.Windows.GridEX.GridEX
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancle As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
