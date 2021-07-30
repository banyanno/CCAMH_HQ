<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCItemExpiredDate
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
        Dim GridItemExpiredDate_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCItemExpiredDate))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridItemExpiredDate = New Janus.Windows.GridEX.GridEX()
        Me.CRVReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPrintReport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadByDateReceived = New System.Windows.Forms.RadioButton()
        Me.RadByDateExpiered = New System.Windows.Forms.RadioButton()
        Me.DateReceiveTo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboCategory = New System.Windows.Forms.ComboBox()
        Me.ChCategory = New System.Windows.Forms.CheckBox()
        Me.BtnCheckItemExpiry = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DTPToDate = New System.Windows.Forms.DateTimePicker()
        Me.ChBActivePeriod = New System.Windows.Forms.CheckBox()
        Me.DTPFDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateReceiveFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnPreview = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RBViewTable = New System.Windows.Forms.RadioButton()
        Me.RBViewReport = New System.Windows.Forms.RadioButton()
        Me.CBItem = New System.Windows.Forms.ComboBox()
        Me.ChBAllItem = New System.Windows.Forms.CheckBox()
        Me.BGWExpiredDate = New System.ComponentModel.BackgroundWorker()
        Me.BGRunExpirReceive = New System.ComponentModel.BackgroundWorker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridItemExpiredDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1123, 694)
        Me.SplitContainer1.SplitterDistance = 892
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridItemExpiredDate)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CRVReportViewer)
        Me.SplitContainer2.Size = New System.Drawing.Size(892, 694)
        Me.SplitContainer2.SplitterDistance = 371
        Me.SplitContainer2.TabIndex = 0
        '
        'GridItemExpiredDate
        '
        Me.GridItemExpiredDate.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridItemExpiredDate_DesignTimeLayout.LayoutString = resources.GetString("GridItemExpiredDate_DesignTimeLayout.LayoutString")
        Me.GridItemExpiredDate.DesignTimeLayout = GridItemExpiredDate_DesignTimeLayout
        Me.GridItemExpiredDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemExpiredDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridItemExpiredDate.GroupByBoxVisible = False
        Me.GridItemExpiredDate.Location = New System.Drawing.Point(0, 0)
        Me.GridItemExpiredDate.Margin = New System.Windows.Forms.Padding(2)
        Me.GridItemExpiredDate.Name = "GridItemExpiredDate"
        Me.GridItemExpiredDate.RecordNavigator = True
        Me.GridItemExpiredDate.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridItemExpiredDate.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridItemExpiredDate.Size = New System.Drawing.Size(892, 371)
        Me.GridItemExpiredDate.TabIndex = 4
        Me.GridItemExpiredDate.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridItemExpiredDate.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'CRVReportViewer
        '
        Me.CRVReportViewer.ActiveViewIndex = -1
        Me.CRVReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CRVReportViewer.Name = "CRVReportViewer"
        Me.CRVReportViewer.SelectionFormula = ""
        Me.CRVReportViewer.Size = New System.Drawing.Size(892, 319)
        Me.CRVReportViewer.TabIndex = 0
        Me.CRVReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRVReportViewer.ViewTimeSelectionFormula = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPrintReport)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.CboCategory)
        Me.GroupBox1.Controls.Add(Me.ChCategory)
        Me.GroupBox1.Controls.Add(Me.BtnCheckItemExpiry)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DateReceiveFrom)
        Me.GroupBox1.Controls.Add(Me.BtnPreview)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RBViewTable)
        Me.GroupBox1.Controls.Add(Me.RBViewReport)
        Me.GroupBox1.Controls.Add(Me.CBItem)
        Me.GroupBox1.Controls.Add(Me.ChBAllItem)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 694)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Filter"
        '
        'BtnPrintReport
        '
        Me.BtnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintReport.Location = New System.Drawing.Point(11, 146)
        Me.BtnPrintReport.Name = "BtnPrintReport"
        Me.BtnPrintReport.Size = New System.Drawing.Size(208, 37)
        Me.BtnPrintReport.TabIndex = 17
        Me.BtnPrintReport.Text = "Print Preview Report"
        Me.BtnPrintReport.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Number Print Expiry"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadByDateReceived)
        Me.GroupBox3.Controls.Add(Me.RadByDateExpiered)
        Me.GroupBox3.Controls.Add(Me.DateReceiveTo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(22, 339)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(162, 126)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Exired of Item"
        Me.GroupBox3.Visible = False
        '
        'RadByDateReceived
        '
        Me.RadByDateReceived.AutoSize = True
        Me.RadByDateReceived.Location = New System.Drawing.Point(17, 65)
        Me.RadByDateReceived.Name = "RadByDateReceived"
        Me.RadByDateReceived.Size = New System.Drawing.Size(172, 22)
        Me.RadByDateReceived.TabIndex = 15
        Me.RadByDateReceived.Text = "View By Date received"
        Me.RadByDateReceived.UseVisualStyleBackColor = True
        '
        'RadByDateExpiered
        '
        Me.RadByDateExpiered.AutoSize = True
        Me.RadByDateExpiered.Checked = True
        Me.RadByDateExpiered.Location = New System.Drawing.Point(17, 29)
        Me.RadByDateExpiered.Name = "RadByDateExpiered"
        Me.RadByDateExpiered.Size = New System.Drawing.Size(169, 22)
        Me.RadByDateExpiered.TabIndex = 14
        Me.RadByDateExpiered.TabStop = True
        Me.RadByDateExpiered.Text = "View By date expiered"
        Me.RadByDateExpiered.UseVisualStyleBackColor = True
        '
        'DateReceiveTo
        '
        Me.DateReceiveTo.CustomFormat = "dd/MM/yyyy"
        Me.DateReceiveTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceiveTo.Location = New System.Drawing.Point(16, 116)
        Me.DateReceiveTo.Name = "DateReceiveTo"
        Me.DateReceiveTo.Size = New System.Drawing.Size(209, 24)
        Me.DateReceiveTo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "To Date :"
        '
        'CboCategory
        '
        Me.CboCategory.Enabled = False
        Me.CboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Location = New System.Drawing.Point(22, 233)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(225, 28)
        Me.CboCategory.TabIndex = 12
        Me.CboCategory.Visible = False
        '
        'ChCategory
        '
        Me.ChCategory.AutoSize = True
        Me.ChCategory.Checked = True
        Me.ChCategory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChCategory.Location = New System.Drawing.Point(22, 216)
        Me.ChCategory.Name = "ChCategory"
        Me.ChCategory.Size = New System.Drawing.Size(82, 17)
        Me.ChCategory.TabIndex = 11
        Me.ChCategory.Text = "All Category"
        Me.ChCategory.UseVisualStyleBackColor = True
        Me.ChCategory.Visible = False
        '
        'BtnCheckItemExpiry
        '
        Me.BtnCheckItemExpiry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCheckItemExpiry.Location = New System.Drawing.Point(11, 103)
        Me.BtnCheckItemExpiry.Name = "BtnCheckItemExpiry"
        Me.BtnCheckItemExpiry.Size = New System.Drawing.Size(208, 37)
        Me.BtnCheckItemExpiry.TabIndex = 13
        Me.BtnCheckItemExpiry.Text = "Check Item Expiry"
        Me.BtnCheckItemExpiry.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTPToDate)
        Me.GroupBox2.Controls.Add(Me.ChBActivePeriod)
        Me.GroupBox2.Controls.Add(Me.DTPFDate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(172, 436)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(71, 80)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'DTPToDate
        '
        Me.DTPToDate.CustomFormat = "dd/MM/yyyy"
        Me.DTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPToDate.Location = New System.Drawing.Point(77, 45)
        Me.DTPToDate.Name = "DTPToDate"
        Me.DTPToDate.Size = New System.Drawing.Size(143, 20)
        Me.DTPToDate.TabIndex = 3
        '
        'ChBActivePeriod
        '
        Me.ChBActivePeriod.AutoSize = True
        Me.ChBActivePeriod.Checked = True
        Me.ChBActivePeriod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBActivePeriod.Location = New System.Drawing.Point(12, 19)
        Me.ChBActivePeriod.Name = "ChBActivePeriod"
        Me.ChBActivePeriod.Size = New System.Drawing.Size(135, 17)
        Me.ChBActivePeriod.TabIndex = 9
        Me.ChBActivePeriod.Text = "Specific Period of Time"
        Me.ChBActivePeriod.UseVisualStyleBackColor = True
        '
        'DTPFDate
        '
        Me.DTPFDate.CustomFormat = "dd/MM/yyyy"
        Me.DTPFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFDate.Location = New System.Drawing.Point(77, 19)
        Me.DTPFDate.Name = "DTPFDate"
        Me.DTPFDate.Size = New System.Drawing.Size(143, 20)
        Me.DTPFDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To Date :"
        '
        'DateReceiveFrom
        '
        Me.DateReceiveFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateReceiveFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReceiveFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceiveFrom.Location = New System.Drawing.Point(12, 43)
        Me.DateReceiveFrom.Name = "DateReceiveFrom"
        Me.DateReceiveFrom.Size = New System.Drawing.Size(206, 26)
        Me.DateReceiveFrom.TabIndex = 2
        '
        'BtnPreview
        '
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.Location = New System.Drawing.Point(156, 287)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(91, 28)
        Me.BtnPreview.TabIndex = 8
        Me.BtnPreview.Text = "Preview"
        Me.BtnPreview.UseVisualStyleBackColor = True
        Me.BtnPreview.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From Date :"
        Me.Label3.Visible = False
        '
        'RBViewTable
        '
        Me.RBViewTable.AutoSize = True
        Me.RBViewTable.Checked = True
        Me.RBViewTable.Location = New System.Drawing.Point(25, 298)
        Me.RBViewTable.Name = "RBViewTable"
        Me.RBViewTable.Size = New System.Drawing.Size(88, 17)
        Me.RBViewTable.TabIndex = 7
        Me.RBViewTable.TabStop = True
        Me.RBViewTable.Text = "View as table"
        Me.RBViewTable.UseVisualStyleBackColor = True
        Me.RBViewTable.Visible = False
        '
        'RBViewReport
        '
        Me.RBViewReport.AutoSize = True
        Me.RBViewReport.Location = New System.Drawing.Point(25, 270)
        Me.RBViewReport.Name = "RBViewReport"
        Me.RBViewReport.Size = New System.Drawing.Size(92, 17)
        Me.RBViewReport.TabIndex = 6
        Me.RBViewReport.Text = "View as report"
        Me.RBViewReport.UseVisualStyleBackColor = True
        Me.RBViewReport.Visible = False
        '
        'CBItem
        '
        Me.CBItem.Enabled = False
        Me.CBItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBItem.FormattingEnabled = True
        Me.CBItem.Location = New System.Drawing.Point(18, 522)
        Me.CBItem.Name = "CBItem"
        Me.CBItem.Size = New System.Drawing.Size(225, 28)
        Me.CBItem.TabIndex = 1
        Me.CBItem.Visible = False
        '
        'ChBAllItem
        '
        Me.ChBAllItem.AutoSize = True
        Me.ChBAllItem.Checked = True
        Me.ChBAllItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBAllItem.Location = New System.Drawing.Point(18, 499)
        Me.ChBAllItem.Name = "ChBAllItem"
        Me.ChBAllItem.Size = New System.Drawing.Size(60, 17)
        Me.ChBAllItem.TabIndex = 0
        Me.ChBAllItem.Text = "All Item"
        Me.ChBAllItem.UseVisualStyleBackColor = True
        Me.ChBAllItem.Visible = False
        '
        'BGWExpiredDate
        '
        '
        'BGRunExpirReceive
        '
        '
        'UCItemExpiredDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCItemExpiredDate"
        Me.Size = New System.Drawing.Size(1123, 694)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridItemExpiredDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChBActivePeriod As System.Windows.Forms.CheckBox
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents RBViewTable As System.Windows.Forms.RadioButton
    Friend WithEvents RBViewReport As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBItem As System.Windows.Forms.ComboBox
    Friend WithEvents ChBAllItem As System.Windows.Forms.CheckBox
    Friend WithEvents BGWExpiredDate As System.ComponentModel.BackgroundWorker
    Friend WithEvents GridItemExpiredDate As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CRVReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ChCategory As System.Windows.Forms.CheckBox
    Friend WithEvents CboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCheckItemExpiry As System.Windows.Forms.Button
    Friend WithEvents BGRunExpirReceive As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateReceiveTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateReceiveFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadByDateReceived As System.Windows.Forms.RadioButton
    Friend WithEvents RadByDateExpiered As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintReport As System.Windows.Forms.Button

End Class
