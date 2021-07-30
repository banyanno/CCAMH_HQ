<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIDrugReport
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
        Me.components = New System.ComponentModel.Container()
        Dim GridDrugReport_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIDrugReport))
        Me.BtnGeneratReport = New System.Windows.Forms.Button()
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridDrugReport = New Janus.Windows.GridEX.GridEX()
        Me.CryViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BGRunSummary = New System.ComponentModel.BackgroundWorker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChFormulaAdjustock = New System.Windows.Forms.CheckBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridDrugReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGeneratReport
        '
        Me.BtnGeneratReport.Location = New System.Drawing.Point(6, 175)
        Me.BtnGeneratReport.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGeneratReport.Name = "BtnGeneratReport"
        Me.BtnGeneratReport.Size = New System.Drawing.Size(198, 37)
        Me.BtnGeneratReport.TabIndex = 0
        Me.BtnGeneratReport.Text = "Generate Data"
        Me.BtnGeneratReport.UseVisualStyleBackColor = True
        '
        'DFrom
        '
        Me.DFrom.Checked = False
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(6, 85)
        Me.DFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.ShowCheckBox = True
        Me.DFrom.Size = New System.Drawing.Size(196, 24)
        Me.DFrom.TabIndex = 1
        '
        'DTo
        '
        Me.DTo.Checked = False
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(6, 141)
        Me.DTo.Margin = New System.Windows.Forms.Padding(6)
        Me.DTo.Name = "DTo"
        Me.DTo.ShowCheckBox = True
        Me.DTo.Size = New System.Drawing.Size(196, 24)
        Me.DTo.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChFormulaAdjustock)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DFrom)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnGeneratReport)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DTo)
        Me.SplitContainer1.Size = New System.Drawing.Size(1738, 870)
        Me.SplitContainer1.SplitterDistance = 1510
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridDrugReport)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CryViewer)
        Me.SplitContainer2.Size = New System.Drawing.Size(1508, 868)
        Me.SplitContainer2.SplitterDistance = 335
        Me.SplitContainer2.TabIndex = 7
        '
        'GridDrugReport
        '
        Me.GridDrugReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridDrugReport_DesignTimeLayout.LayoutString = resources.GetString("GridDrugReport_DesignTimeLayout.LayoutString")
        Me.GridDrugReport.DesignTimeLayout = GridDrugReport_DesignTimeLayout
        Me.GridDrugReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDrugReport.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridDrugReport.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridDrugReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridDrugReport.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridDrugReport.GroupByBoxVisible = False
        Me.GridDrugReport.HeaderFormatStyle.FontSize = 12.0!
        Me.GridDrugReport.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridDrugReport.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridDrugReport.Location = New System.Drawing.Point(0, 0)
        Me.GridDrugReport.Margin = New System.Windows.Forms.Padding(2)
        Me.GridDrugReport.Name = "GridDrugReport"
        Me.GridDrugReport.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.GridDrugReport.RecordNavigator = True
        Me.GridDrugReport.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridDrugReport.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridDrugReport.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDrugReport.Size = New System.Drawing.Size(1508, 335)
        Me.GridDrugReport.TabIndex = 5
        Me.GridDrugReport.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridDrugReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'CryViewer
        '
        Me.CryViewer.ActiveViewIndex = -1
        Me.CryViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CryViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CryViewer.Location = New System.Drawing.Point(0, 0)
        Me.CryViewer.Name = "CryViewer"
        Me.CryViewer.Size = New System.Drawing.Size(1508, 529)
        Me.CryViewer.TabIndex = 6
        Me.CryViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 535)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generate Data"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date From:"
        '
        'BGRunSummary
        '
        Me.BGRunSummary.WorkerReportsProgress = True
        Me.BGRunSummary.WorkerSupportsCancellation = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ChFormulaAdjustock
        '
        Me.ChFormulaAdjustock.AutoSize = True
        Me.ChFormulaAdjustock.Location = New System.Drawing.Point(11, 54)
        Me.ChFormulaAdjustock.Name = "ChFormulaAdjustock"
        Me.ChFormulaAdjustock.Size = New System.Drawing.Size(151, 22)
        Me.ChFormulaAdjustock.TabIndex = 6
        Me.ChFormulaAdjustock.Text = "Formula Add Ajust:"
        Me.ChFormulaAdjustock.UseVisualStyleBackColor = True
        '
        'UIDrugReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UIDrugReport"
        Me.Size = New System.Drawing.Size(1738, 870)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridDrugReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnGeneratReport As System.Windows.Forms.Button
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridDrugReport As Janus.Windows.GridEX.GridEX
    Friend WithEvents BGRunSummary As System.ComponentModel.BackgroundWorker
    Friend WithEvents CryViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ChFormulaAdjustock As System.Windows.Forms.CheckBox

End Class
