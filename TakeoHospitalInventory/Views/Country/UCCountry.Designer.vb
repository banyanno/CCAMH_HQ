<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCountry
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
        Dim gridCountry_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCountry))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNew = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.gridCountry = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.BtnRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(880, 34)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.AutoSize = False
        Me.BtnNew.Image = Global.KTGSYS.My.Resources.Resources.blue_new
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(70, 31)
        Me.BtnNew.Text = "New "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = False
        Me.btnEdit.Image = Global.KTGSYS.My.Resources.Resources.edit
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 31)
        Me.btnEdit.Text = "Edit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.AutoSize = False
        Me.BtnRefresh.Image = Global.KTGSYS.My.Resources.Resources.view_refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(120, 31)
        Me.BtnRefresh.Text = "Refresh Data"
        '
        'gridCountry
        '
        Me.gridCountry.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridCountry_DesignTimeLayout.LayoutString = resources.GetString("gridCountry_DesignTimeLayout.LayoutString")
        Me.gridCountry.DesignTimeLayout = gridCountry_DesignTimeLayout
        Me.gridCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridCountry.GroupByBoxVisible = False
        Me.gridCountry.Location = New System.Drawing.Point(0, 34)
        Me.gridCountry.Name = "gridCountry"
        Me.gridCountry.RecordNavigator = True
        Me.gridCountry.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridCountry.Size = New System.Drawing.Size(880, 329)
        Me.gridCountry.TabIndex = 6
        Me.gridCountry.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'UCCountry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridCountry)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCCountry"
        Me.Size = New System.Drawing.Size(880, 363)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridCountry As Janus.Windows.GridEX.GridEX

End Class
