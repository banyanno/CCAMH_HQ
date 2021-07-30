<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCashCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCashCollection))
        Dim GridDialyCashCollection_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridWeekllyCollection_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnPreviewDialy = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintCashDistribute = New System.Windows.Forms.ToolStripButton
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridDialyCashCollection = New Janus.Windows.GridEX.GridEX
        Me.UiTabPageContrition = New Janus.Windows.UI.Tab.UITabPage
        Me.DContTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DContFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnWeeklly = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintWeeklyCashReport = New System.Windows.Forms.ToolStripButton
        Me.GridWeekllyCollection = New Janus.Windows.GridEX.GridEX
        Me.BGloadDiallyCollection = New System.ComponentModel.BackgroundWorker
        Me.BGLoadingWeeklly = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.GridDialyCashCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPageContrition.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.GridWeekllyCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPreviewDialy, Me.ToolStripSeparator1, Me.BtnPrintCashDistribute})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(379, 52)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnPreviewDialy
        '
        Me.BtnPreviewDialy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPreviewDialy.Image = CType(resources.GetObject("BtnPreviewDialy.Image"), System.Drawing.Image)
        Me.BtnPreviewDialy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPreviewDialy.Name = "BtnPreviewDialy"
        Me.BtnPreviewDialy.Size = New System.Drawing.Size(201, 49)
        Me.BtnPreviewDialy.Text = "          Preview Cash Contribute          "
        Me.BtnPreviewDialy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'BtnPrintCashDistribute
        '
        Me.BtnPrintCashDistribute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPrintCashDistribute.Image = CType(resources.GetObject("BtnPrintCashDistribute.Image"), System.Drawing.Image)
        Me.BtnPrintCashDistribute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintCashDistribute.Name = "BtnPrintCashDistribute"
        Me.BtnPrintCashDistribute.Size = New System.Drawing.Size(169, 49)
        Me.BtnPrintCashDistribute.Text = "Print Preveiw Cash Contribute"
        Me.BtnPrintCashDistribute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.FlatBorderColor = System.Drawing.Color.Cornsilk
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiTab1.ImageSize = New System.Drawing.Size(30, 30)
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.MultiLine = True
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(1444, 699)
        Me.UiTab1.TabIndex = 1
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage2, Me.UiTabPageContrition})
        Me.UiTab1.UseThemes = False
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.DTo)
        Me.UiTabPage2.Controls.Add(Me.ToolStrip1)
        Me.UiTabPage2.Controls.Add(Me.Label8)
        Me.UiTabPage2.Controls.Add(Me.DFrom)
        Me.UiTabPage2.Controls.Add(Me.Label1)
        Me.UiTabPage2.Controls.Add(Me.GridDialyCashCollection)
        Me.UiTabPage2.Image = CType(resources.GetObject("UiTabPage2.Image"), System.Drawing.Image)
        Me.UiTabPage2.Key = "DialCashCollection"
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 37)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1442, 661)
        Me.UiTabPage2.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Dially Cash Collection"
        '
        'DTo
        '
        Me.DTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTo.CustomFormat = "dd-MM-yyyy"
        Me.DTo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(587, 34)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(114, 24)
        Me.DTo.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(505, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 27)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Date To"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DFrom
        '
        Me.DFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DFrom.CustomFormat = "dd-MM-yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(587, 6)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(114, 24)
        Me.DFrom.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(505, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 27)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Date From:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridDialyCashCollection
        '
        Me.GridDialyCashCollection.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDialyCashCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDialyCashCollection.BackColor = System.Drawing.Color.White
        Me.GridDialyCashCollection.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridDialyCashCollection.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.AllCells
        GridDialyCashCollection_DesignTimeLayout.LayoutString = resources.GetString("GridDialyCashCollection_DesignTimeLayout.LayoutString")
        Me.GridDialyCashCollection.DesignTimeLayout = GridDialyCashCollection_DesignTimeLayout
        Me.GridDialyCashCollection.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridDialyCashCollection.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridDialyCashCollection.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridDialyCashCollection.GroupByBoxVisible = False
        Me.GridDialyCashCollection.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridDialyCashCollection.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridDialyCashCollection.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridDialyCashCollection.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridDialyCashCollection.Location = New System.Drawing.Point(0, 62)
        Me.GridDialyCashCollection.Name = "GridDialyCashCollection"
        Me.GridDialyCashCollection.RecordNavigator = True
        Me.GridDialyCashCollection.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridDialyCashCollection.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDialyCashCollection.SettingsKey = "GridClientWaitingPayment"
        Me.GridDialyCashCollection.Size = New System.Drawing.Size(1442, 593)
        Me.GridDialyCashCollection.TabIndex = 7
        Me.GridDialyCashCollection.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridDialyCashCollection.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDialyCashCollection.UseCompatibleTextRendering = False
        Me.GridDialyCashCollection.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'UiTabPageContrition
        '
        Me.UiTabPageContrition.Controls.Add(Me.DContTo)
        Me.UiTabPageContrition.Controls.Add(Me.Label2)
        Me.UiTabPageContrition.Controls.Add(Me.DContFrom)
        Me.UiTabPageContrition.Controls.Add(Me.Label3)
        Me.UiTabPageContrition.Controls.Add(Me.ToolStrip2)
        Me.UiTabPageContrition.Controls.Add(Me.GridWeekllyCollection)
        Me.UiTabPageContrition.Image = CType(resources.GetObject("UiTabPageContrition.Image"), System.Drawing.Image)
        Me.UiTabPageContrition.Key = "ClientContributestatement"
        Me.UiTabPageContrition.Location = New System.Drawing.Point(1, 37)
        Me.UiTabPageContrition.Name = "UiTabPageContrition"
        Me.UiTabPageContrition.Size = New System.Drawing.Size(1442, 661)
        Me.UiTabPageContrition.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.UiTabPageContrition.TabStop = True
        Me.UiTabPageContrition.Text = "Client Contribute statement"
        '
        'DContTo
        '
        Me.DContTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DContTo.CustomFormat = "dd-MM-yyyy"
        Me.DContTo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DContTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DContTo.Location = New System.Drawing.Point(587, 33)
        Me.DContTo.Name = "DContTo"
        Me.DContTo.Size = New System.Drawing.Size(113, 24)
        Me.DContTo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(522, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 27)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Date To"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DContFrom
        '
        Me.DContFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DContFrom.CustomFormat = "dd-MM-yyyy"
        Me.DContFrom.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DContFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DContFrom.Location = New System.Drawing.Point(587, 5)
        Me.DContFrom.Name = "DContFrom"
        Me.DContFrom.Size = New System.Drawing.Size(113, 24)
        Me.DContFrom.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(507, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 27)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Date From:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnWeeklly, Me.ToolStripSeparator2, Me.BtnPrintWeeklyCashReport})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(343, 52)
        Me.ToolStrip2.TabIndex = 9
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnWeeklly
        '
        Me.BtnWeeklly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnWeeklly.Image = CType(resources.GetObject("BtnWeeklly.Image"), System.Drawing.Image)
        Me.BtnWeeklly.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnWeeklly.Name = "BtnWeeklly"
        Me.BtnWeeklly.Size = New System.Drawing.Size(168, 49)
        Me.BtnWeeklly.Text = "     Preview Income Sumary     "
        Me.BtnWeeklly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'BtnPrintWeeklyCashReport
        '
        Me.BtnPrintWeeklyCashReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPrintWeeklyCashReport.Image = CType(resources.GetObject("BtnPrintWeeklyCashReport.Image"), System.Drawing.Image)
        Me.BtnPrintWeeklyCashReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintWeeklyCashReport.Name = "BtnPrintWeeklyCashReport"
        Me.BtnPrintWeeklyCashReport.Size = New System.Drawing.Size(166, 49)
        Me.BtnPrintWeeklyCashReport.Text = "Print Preview Income Sumary"
        Me.BtnPrintWeeklyCashReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GridWeekllyCollection
        '
        Me.GridWeekllyCollection.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridWeekllyCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridWeekllyCollection.BackColor = System.Drawing.Color.White
        Me.GridWeekllyCollection.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridWeekllyCollection.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.AllCells
        GridWeekllyCollection_DesignTimeLayout.LayoutString = resources.GetString("GridWeekllyCollection_DesignTimeLayout.LayoutString")
        Me.GridWeekllyCollection.DesignTimeLayout = GridWeekllyCollection_DesignTimeLayout
        Me.GridWeekllyCollection.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridWeekllyCollection.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridWeekllyCollection.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridWeekllyCollection.GroupByBoxVisible = False
        Me.GridWeekllyCollection.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridWeekllyCollection.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridWeekllyCollection.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridWeekllyCollection.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridWeekllyCollection.Location = New System.Drawing.Point(3, 59)
        Me.GridWeekllyCollection.Name = "GridWeekllyCollection"
        Me.GridWeekllyCollection.RecordNavigator = True
        Me.GridWeekllyCollection.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridWeekllyCollection.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridWeekllyCollection.SettingsKey = "GridClientWaitingPayment"
        Me.GridWeekllyCollection.Size = New System.Drawing.Size(1436, 598)
        Me.GridWeekllyCollection.TabIndex = 8
        Me.GridWeekllyCollection.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridWeekllyCollection.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridWeekllyCollection.UseCompatibleTextRendering = False
        Me.GridWeekllyCollection.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'BGloadDiallyCollection
        '
        '
        'BGLoadingWeeklly
        '
        '
        'FormCashCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 699)
        Me.Controls.Add(Me.UiTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCashCollection"
        Me.ShowInTaskbar = False
        Me.Text = "CCAMH-Cash Collection"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        Me.UiTabPage2.PerformLayout()
        CType(Me.GridDialyCashCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPageContrition.ResumeLayout(False)
        Me.UiTabPageContrition.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.GridWeekllyCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPageContrition As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents BtnPreviewDialy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintCashDistribute As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridDialyCashCollection As Janus.Windows.GridEX.GridEX
    Friend WithEvents BGloadDiallyCollection As System.ComponentModel.BackgroundWorker
    Friend WithEvents GridWeekllyCollection As Janus.Windows.GridEX.GridEX
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnWeeklly As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintWeeklyCashReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents BGLoadingWeeklly As System.ComponentModel.BackgroundWorker
    Friend WithEvents DContTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DContFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
