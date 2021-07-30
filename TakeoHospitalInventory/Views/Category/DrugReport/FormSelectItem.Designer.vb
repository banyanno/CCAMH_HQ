<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectItem
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
        Dim GridItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectItem))
        Me.GridItem = New Janus.Windows.GridEX.GridEX()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        CType(Me.GridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridItem
        '
        Me.GridItem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridItem_DesignTimeLayout.LayoutString = resources.GetString("GridItem_DesignTimeLayout.LayoutString")
        Me.GridItem.DesignTimeLayout = GridItem_DesignTimeLayout
        Me.GridItem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridItem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridItem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridItem.GroupByBoxVisible = False
        Me.GridItem.HeaderFormatStyle.FontSize = 12.0!
        Me.GridItem.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridItem.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridItem.Location = New System.Drawing.Point(3, 8)
        Me.GridItem.Margin = New System.Windows.Forms.Padding(2)
        Me.GridItem.Name = "GridItem"
        Me.GridItem.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.GridItem.RecordNavigator = True
        Me.GridItem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridItem.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridItem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridItem.Size = New System.Drawing.Size(832, 485)
        Me.GridItem.TabIndex = 6
        Me.GridItem.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.Location = New System.Drawing.Point(603, 498)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(114, 44)
        Me.BtnOk.TabIndex = 7
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(723, 498)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(114, 44)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormSelectItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 546)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.GridItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectItem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Item"
        CType(Me.GridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridItem As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
