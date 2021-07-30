<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIDrugAudit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIDrugAudit))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridDrugReport = New Janus.Windows.GridEX.GridEX()
        Me.CryViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ChGetCurrrentStock = New System.Windows.Forms.CheckBox()
        Me.CboDepartment = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtNumberPercent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnGeneratReport = New System.Windows.Forms.Button()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.BGRunSummary = New System.ComponentModel.BackgroundWorker()
        Me.ErrDrugAudit = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgSaveDrugAudit = New System.ComponentModel.BackgroundWorker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridDrugReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrDrugAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChGetCurrrentStock)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CboDepartment)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtNumberPercent)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DFrom)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnGeneratReport)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DTo)
        Me.SplitContainer1.Size = New System.Drawing.Size(1176, 662)
        Me.SplitContainer1.SplitterDistance = 947
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 4
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
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(945, 660)
        Me.SplitContainer2.SplitterDistance = 270
        Me.SplitContainer2.TabIndex = 7
        '
        'GridDrugReport
        '
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
        Me.GridDrugReport.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridDrugReport.Location = New System.Drawing.Point(0, 0)
        Me.GridDrugReport.Margin = New System.Windows.Forms.Padding(2)
        Me.GridDrugReport.Name = "GridDrugReport"
        Me.GridDrugReport.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.GridDrugReport.RecordNavigator = True
        Me.GridDrugReport.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridDrugReport.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridDrugReport.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDrugReport.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridDrugReport.Size = New System.Drawing.Size(945, 660)
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
        Me.CryViewer.Size = New System.Drawing.Size(150, 46)
        Me.CryViewer.TabIndex = 6
        Me.CryViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ChGetCurrrentStock
        '
        Me.ChGetCurrrentStock.AutoSize = True
        Me.ChGetCurrrentStock.Location = New System.Drawing.Point(7, 248)
        Me.ChGetCurrrentStock.Name = "ChGetCurrrentStock"
        Me.ChGetCurrrentStock.Size = New System.Drawing.Size(168, 17)
        Me.ChGetCurrrentStock.TabIndex = 10
        Me.ChGetCurrrentStock.Text = "Get No.In book=Current stock"
        Me.ChGetCurrrentStock.UseVisualStyleBackColor = True
        '
        'CboDepartment
        '
        Me.CboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDepartment.FormattingEnabled = True
        Me.CboDepartment.Location = New System.Drawing.Point(7, 203)
        Me.CboDepartment.Name = "CboDepartment"
        Me.CboDepartment.Size = New System.Drawing.Size(198, 28)
        Me.CboDepartment.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 182)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Select Department"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(4, 317)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(198, 37)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "Save and Generate Report Drug Audit"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtNumberPercent
        '
        Me.TxtNumberPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumberPercent.Location = New System.Drawing.Point(7, 37)
        Me.TxtNumberPercent.Name = "TxtNumberPercent"
        Me.TxtNumberPercent.Size = New System.Drawing.Size(193, 26)
        Me.TxtNumberPercent.TabIndex = 6
        Me.TxtNumberPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number add %"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Drug issue To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date Drug issue from"
        '
        'DFrom
        '
        Me.DFrom.Checked = False
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(7, 96)
        Me.DFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.ShowCheckBox = True
        Me.DFrom.Size = New System.Drawing.Size(196, 24)
        Me.DFrom.TabIndex = 1
        '
        'BtnGeneratReport
        '
        Me.BtnGeneratReport.Location = New System.Drawing.Point(4, 272)
        Me.BtnGeneratReport.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGeneratReport.Name = "BtnGeneratReport"
        Me.BtnGeneratReport.Size = New System.Drawing.Size(198, 37)
        Me.BtnGeneratReport.TabIndex = 0
        Me.BtnGeneratReport.Text = "Pupulate Data"
        Me.BtnGeneratReport.UseVisualStyleBackColor = True
        '
        'DTo
        '
        Me.DTo.Checked = False
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(7, 152)
        Me.DTo.Margin = New System.Windows.Forms.Padding(6)
        Me.DTo.Name = "DTo"
        Me.DTo.ShowCheckBox = True
        Me.DTo.Size = New System.Drawing.Size(196, 24)
        Me.DTo.TabIndex = 2
        '
        'BGRunSummary
        '
        Me.BGRunSummary.WorkerReportsProgress = True
        Me.BGRunSummary.WorkerSupportsCancellation = True
        '
        'ErrDrugAudit
        '
        Me.ErrDrugAudit.ContainerControl = Me
        '
        'BgSaveDrugAudit
        '
        Me.BgSaveDrugAudit.WorkerReportsProgress = True
        Me.BgSaveDrugAudit.WorkerSupportsCancellation = True
        '
        'UIDrugAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UIDrugAudit"
        Me.Size = New System.Drawing.Size(1176, 662)
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
        CType(Me.ErrDrugAudit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridDrugReport As Janus.Windows.GridEX.GridEX
    Friend WithEvents CryViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnGeneratReport As System.Windows.Forms.Button
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BGRunSummary As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtNumberPercent As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrDrugAudit As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BgSaveDrugAudit As System.ComponentModel.BackgroundWorker
    Friend WithEvents CboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChGetCurrrentStock As System.Windows.Forms.CheckBox

End Class
