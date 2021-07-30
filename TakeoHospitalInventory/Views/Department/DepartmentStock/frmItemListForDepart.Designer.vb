<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemListForDepart
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
        Me.components = New System.ComponentModel.Container
        Dim gridItemInDepart_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemListForDepart))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim GridItemAvailable_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.gridItemInDepart = New Janus.Windows.GridEX.GridEX
        Me.VSForOpticalshop = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.FilterEditor2 = New Janus.Windows.FilterEditor.FilterEditor
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridItemAvailable = New Janus.Windows.GridEX.GridEX
        Me.FilterEditor1 = New Janus.Windows.FilterEditor.FilterEditor
        Me.ImageAddItem = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnOK = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrorInitialStockItem = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnAdd = New Janus.Windows.EditControls.UIButton
        Me.BtnDelete = New Janus.Windows.EditControls.UIButton
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridItemInDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridItemAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorInitialStockItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.gridItemInDepart)
        Me.GroupBox2.Controls.Add(Me.FilterEditor2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(618, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 506)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Items in department"
        '
        'gridItemInDepart
        '
        Me.gridItemInDepart.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemInDepart_DesignTimeLayout.LayoutString = resources.GetString("gridItemInDepart_DesignTimeLayout.LayoutString")
        Me.gridItemInDepart.DesignTimeLayout = gridItemInDepart_DesignTimeLayout
        Me.gridItemInDepart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemInDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gridItemInDepart.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemInDepart.GroupByBoxVisible = False
        Me.gridItemInDepart.Location = New System.Drawing.Point(3, 71)
        Me.gridItemInDepart.Margin = New System.Windows.Forms.Padding(2)
        Me.gridItemInDepart.Name = "gridItemInDepart"
        Me.gridItemInDepart.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.gridItemInDepart.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.gridItemInDepart.RecordNavigator = True
        Me.gridItemInDepart.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridItemInDepart.Size = New System.Drawing.Size(589, 432)
        Me.gridItemInDepart.TabIndex = 15
        Me.gridItemInDepart.VisualStyleManager = Me.VSForOpticalshop
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
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.DarkBlue
        Me.VSForOpticalshop.ColorSchemes.Add(JanusColorScheme1)
        Me.VSForOpticalshop.DefaultColorScheme = "Header"
        '
        'FilterEditor2
        '
        Me.FilterEditor2.AutoApply = True
        Me.FilterEditor2.BackColor = System.Drawing.Color.Transparent
        Me.FilterEditor2.DefaultConditionOperator = Janus.Data.ConditionOperator.Equal
        Me.FilterEditor2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterEditor2.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor2.Location = New System.Drawing.Point(3, 22)
        Me.FilterEditor2.MinSize = New System.Drawing.Size(16, 49)
        Me.FilterEditor2.Name = "FilterEditor2"
        Me.FilterEditor2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.[Default]
        Me.FilterEditor2.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor2.ScrollStep = 15
        Me.FilterEditor2.Size = New System.Drawing.Size(589, 49)
        Me.FilterEditor2.SourceControl = Me.gridItemInDepart
        Me.FilterEditor2.VisualStyleManager = Me.VSForOpticalshop
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GridItemAvailable)
        Me.GroupBox1.Controls.Add(Me.FilterEditor1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 506)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List items available for department"
        '
        'GridItemAvailable
        '
        Me.GridItemAvailable.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridItemAvailable_DesignTimeLayout.LayoutString = resources.GetString("GridItemAvailable_DesignTimeLayout.LayoutString")
        Me.GridItemAvailable.DesignTimeLayout = GridItemAvailable_DesignTimeLayout
        Me.GridItemAvailable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridItemAvailable.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridItemAvailable.GroupByBoxVisible = False
        Me.GridItemAvailable.Location = New System.Drawing.Point(3, 72)
        Me.GridItemAvailable.Margin = New System.Windows.Forms.Padding(2)
        Me.GridItemAvailable.Name = "GridItemAvailable"
        Me.GridItemAvailable.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridItemAvailable.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.GridItemAvailable.RecordNavigator = True
        Me.GridItemAvailable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridItemAvailable.Size = New System.Drawing.Size(533, 431)
        Me.GridItemAvailable.TabIndex = 14
        Me.GridItemAvailable.VisualStyleManager = Me.VSForOpticalshop
        '
        'FilterEditor1
        '
        Me.FilterEditor1.AutoApply = True
        Me.FilterEditor1.BackColor = System.Drawing.Color.Transparent
        Me.FilterEditor1.DefaultConditionOperator = Janus.Data.ConditionOperator.Equal
        Me.FilterEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor1.Location = New System.Drawing.Point(3, 22)
        Me.FilterEditor1.MinSize = New System.Drawing.Size(16, 49)
        Me.FilterEditor1.Name = "FilterEditor1"
        Me.FilterEditor1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.[Default]
        Me.FilterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor1.ScrollStep = 15
        Me.FilterEditor1.Size = New System.Drawing.Size(533, 50)
        Me.FilterEditor1.SourceControl = Me.GridItemAvailable
        Me.FilterEditor1.VisualStyleManager = Me.VSForOpticalshop
        '
        'ImageAddItem
        '
        Me.ImageAddItem.ImageStream = CType(resources.GetObject("ImageAddItem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageAddItem.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageAddItem.Images.SetKeyName(0, "Vista (199).png")
        Me.ImageAddItem.Images.SetKeyName(1, "Vista (198).png")
        Me.ImageAddItem.Images.SetKeyName(2, "delete.ico")
        Me.ImageAddItem.Images.SetKeyName(3, "app_48.ico")
        '
        'BtnOK
        '
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnOK.Image = Global.KTGSYS.My.Resources.Resources.save
        Me.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOK.Location = New System.Drawing.Point(13, 522)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(85, 35)
        Me.BtnOK.TabIndex = 7
        Me.BtnOK.Text = "Save"
        Me.BtnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Image = Global.KTGSYS.My.Resources.Resources.cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(102, 522)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(85, 35)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrorInitialStockItem
        '
        Me.ErrorInitialStockItem.ContainerControl = Me
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Location = New System.Drawing.Point(557, 229)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.BtnAdd.Size = New System.Drawing.Size(52, 35)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = ">>"
        Me.BtnAdd.VisualStyleManager = Me.VSForOpticalshop
        '
        'BtnDelete
        '
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Location = New System.Drawing.Point(557, 270)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.BtnDelete.Size = New System.Drawing.Size(52, 35)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "<<"
        Me.BtnDelete.VisualStyleManager = Me.VSForOpticalshop
        '
        'frmItemListForDepart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1226, 562)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmItemListForDepart"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Initial Item in Department"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridItemInDepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridItemAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorInitialStockItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridItemInDepart As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridItemAvailable As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ImageAddItem As System.Windows.Forms.ImageList
    Friend WithEvents ErrorInitialStockItem As System.Windows.Forms.ErrorProvider
    Friend WithEvents FilterEditor1 As Janus.Windows.FilterEditor.FilterEditor
    Friend WithEvents FilterEditor2 As Janus.Windows.FilterEditor.FilterEditor
    Friend WithEvents BtnDelete As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents VSForOpticalshop As Janus.Windows.Common.VisualStyleManager
End Class
