<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCOpticalshopIncomStatement
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
        Me.components = New System.ComponentModel.Container
        Dim GridReceipt_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCOpticalshopIncomStatement))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadReportNil = New System.Windows.Forms.RadioButton
        Me.RadReceiptNil = New System.Windows.Forms.RadioButton
        Me.RadReportCancel = New System.Windows.Forms.RadioButton
        Me.RadViewReport = New System.Windows.Forms.RadioButton
        Me.RadReceiptCancel = New System.Windows.Forms.RadioButton
        Me.RadAsTable = New System.Windows.Forms.RadioButton
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainerIncomstatement = New System.Windows.Forms.SplitContainer
        Me.GridReceipt = New Janus.Windows.GridEX.GridEX
        Me.VSForOpticalshop = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.CryViewOpticalshopIncome = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.BtnImpReceipt = New System.Windows.Forms.Button
        Me.BGImpOpticalTEH = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainerIncomstatement.Panel1.SuspendLayout()
        Me.SplitContainerIncomstatement.Panel2.SuspendLayout()
        Me.SplitContainerIncomstatement.SuspendLayout()
        CType(Me.GridReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnImpReceipt)
        Me.GroupBox1.Controls.Add(Me.RadReportNil)
        Me.GroupBox1.Controls.Add(Me.RadReceiptNil)
        Me.GroupBox1.Controls.Add(Me.RadReportCancel)
        Me.GroupBox1.Controls.Add(Me.RadViewReport)
        Me.GroupBox1.Controls.Add(Me.RadReceiptCancel)
        Me.GroupBox1.Controls.Add(Me.RadAsTable)
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1149, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optical Shop Income Statement"
        '
        'RadReportNil
        '
        Me.RadReportNil.AutoSize = True
        Me.RadReportNil.Location = New System.Drawing.Point(674, 36)
        Me.RadReportNil.Name = "RadReportNil"
        Me.RadReportNil.Size = New System.Drawing.Size(113, 17)
        Me.RadReportNil.TabIndex = 5
        Me.RadReportNil.TabStop = True
        Me.RadReportNil.Text = "View Nil As Report"
        Me.RadReportNil.UseVisualStyleBackColor = True
        '
        'RadReceiptNil
        '
        Me.RadReceiptNil.AutoSize = True
        Me.RadReceiptNil.Location = New System.Drawing.Point(674, 15)
        Me.RadReceiptNil.Name = "RadReceiptNil"
        Me.RadReceiptNil.Size = New System.Drawing.Size(108, 17)
        Me.RadReceiptNil.TabIndex = 4
        Me.RadReceiptNil.TabStop = True
        Me.RadReceiptNil.Text = "View Nil As Table"
        Me.RadReceiptNil.UseVisualStyleBackColor = True
        '
        'RadReportCancel
        '
        Me.RadReportCancel.AutoSize = True
        Me.RadReportCancel.Location = New System.Drawing.Point(571, 38)
        Me.RadReportCancel.Name = "RadReportCancel"
        Me.RadReportCancel.Size = New System.Drawing.Size(93, 17)
        Me.RadReportCancel.TabIndex = 3
        Me.RadReportCancel.Text = "Report Cancel"
        Me.RadReportCancel.UseVisualStyleBackColor = True
        '
        'RadViewReport
        '
        Me.RadViewReport.AutoSize = True
        Me.RadViewReport.Location = New System.Drawing.Point(462, 38)
        Me.RadViewReport.Name = "RadViewReport"
        Me.RadViewReport.Size = New System.Drawing.Size(98, 17)
        Me.RadViewReport.TabIndex = 3
        Me.RadViewReport.Text = "View As Report"
        Me.RadViewReport.UseVisualStyleBackColor = True
        '
        'RadReceiptCancel
        '
        Me.RadReceiptCancel.AutoSize = True
        Me.RadReceiptCancel.Location = New System.Drawing.Point(571, 15)
        Me.RadReceiptCancel.Name = "RadReceiptCancel"
        Me.RadReceiptCancel.Size = New System.Drawing.Size(96, 17)
        Me.RadReceiptCancel.TabIndex = 3
        Me.RadReceiptCancel.Text = "Invoice Cancel"
        Me.RadReceiptCancel.UseVisualStyleBackColor = True
        '
        'RadAsTable
        '
        Me.RadAsTable.AutoSize = True
        Me.RadAsTable.Location = New System.Drawing.Point(462, 15)
        Me.RadAsTable.Name = "RadAsTable"
        Me.RadAsTable.Size = New System.Drawing.Size(93, 17)
        Me.RadAsTable.TabIndex = 3
        Me.RadAsTable.Text = "View As Table"
        Me.RadAsTable.UseVisualStyleBackColor = True
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreview.Image = CType(resources.GetObject("BtnPrintPreview.Image"), System.Drawing.Image)
        Me.BtnPrintPreview.Location = New System.Drawing.Point(327, 16)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(131, 39)
        Me.BtnPrintPreview.TabIndex = 2
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrintPreview.UseVisualStyleBackColor = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(195, 28)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(127, 23)
        Me.DateTo.TabIndex = 1
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(39, 28)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(127, 23)
        Me.DateFrom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'SplitContainerIncomstatement
        '
        Me.SplitContainerIncomstatement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerIncomstatement.Location = New System.Drawing.Point(0, 62)
        Me.SplitContainerIncomstatement.Name = "SplitContainerIncomstatement"
        '
        'SplitContainerIncomstatement.Panel1
        '
        Me.SplitContainerIncomstatement.Panel1.Controls.Add(Me.GridReceipt)
        '
        'SplitContainerIncomstatement.Panel2
        '
        Me.SplitContainerIncomstatement.Panel2.Controls.Add(Me.CryViewOpticalshopIncome)
        Me.SplitContainerIncomstatement.Panel2Collapsed = True
        Me.SplitContainerIncomstatement.Size = New System.Drawing.Size(1149, 532)
        Me.SplitContainerIncomstatement.SplitterDistance = 220
        Me.SplitContainerIncomstatement.TabIndex = 1
        '
        'GridReceipt
        '
        GridReceipt_DesignTimeLayout.LayoutString = resources.GetString("GridReceipt_DesignTimeLayout.LayoutString")
        Me.GridReceipt.DesignTimeLayout = GridReceipt_DesignTimeLayout
        Me.GridReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridReceipt.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridReceipt.GroupByBoxVisible = False
        Me.GridReceipt.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GridReceipt.HeaderFormatStyle.ForeColor = System.Drawing.Color.White
        Me.GridReceipt.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridReceipt.Location = New System.Drawing.Point(0, 0)
        Me.GridReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.GridReceipt.Name = "GridReceipt"
        Me.GridReceipt.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridReceipt.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.GridReceipt.RecordNavigator = True
        Me.GridReceipt.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridReceipt.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReceipt.Size = New System.Drawing.Size(1149, 532)
        Me.GridReceipt.TabIndex = 4
        Me.GridReceipt.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReceipt.VisualStyleManager = Me.VSForOpticalshop
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
        'CryViewOpticalshopIncome
        '
        Me.CryViewOpticalshopIncome.ActiveViewIndex = -1
        Me.CryViewOpticalshopIncome.AutoScroll = True
        Me.CryViewOpticalshopIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewOpticalshopIncome.DisplayGroupTree = False
        Me.CryViewOpticalshopIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CryViewOpticalshopIncome.Location = New System.Drawing.Point(0, 0)
        Me.CryViewOpticalshopIncome.Name = "CryViewOpticalshopIncome"
        Me.CryViewOpticalshopIncome.SelectionFormula = ""
        Me.CryViewOpticalshopIncome.ShowGroupTreeButton = False
        Me.CryViewOpticalshopIncome.ShowRefreshButton = False
        Me.CryViewOpticalshopIncome.Size = New System.Drawing.Size(96, 100)
        Me.CryViewOpticalshopIncome.TabIndex = 0
        Me.CryViewOpticalshopIncome.ViewTimeSelectionFormula = ""
        '
        'BgLoadingReport
        '
        Me.BgLoadingReport.WorkerReportsProgress = True
        Me.BgLoadingReport.WorkerSupportsCancellation = True
        '
        'BtnImpReceipt
        '
        Me.BtnImpReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnImpReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImpReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImpReceipt.ForeColor = System.Drawing.Color.White
        Me.BtnImpReceipt.Image = CType(resources.GetObject("BtnImpReceipt.Image"), System.Drawing.Image)
        Me.BtnImpReceipt.Location = New System.Drawing.Point(793, 16)
        Me.BtnImpReceipt.Name = "BtnImpReceipt"
        Me.BtnImpReceipt.Size = New System.Drawing.Size(155, 39)
        Me.BtnImpReceipt.TabIndex = 6
        Me.BtnImpReceipt.Text = "Import Receipt"
        Me.BtnImpReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnImpReceipt.UseVisualStyleBackColor = False
        '
        'BGImpOpticalTEH
        '
        Me.BGImpOpticalTEH.WorkerReportsProgress = True
        Me.BGImpOpticalTEH.WorkerSupportsCancellation = True
        '
        'UCOpticalshopIncomStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerIncomstatement)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCOpticalshopIncomStatement"
        Me.Size = New System.Drawing.Size(1149, 594)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainerIncomstatement.Panel1.ResumeLayout(False)
        Me.SplitContainerIncomstatement.Panel2.ResumeLayout(False)
        Me.SplitContainerIncomstatement.ResumeLayout(False)
        CType(Me.GridReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerIncomstatement As System.Windows.Forms.SplitContainer
    Friend WithEvents CryViewOpticalshopIncome As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents RadViewReport As System.Windows.Forms.RadioButton
    Friend WithEvents RadAsTable As System.Windows.Forms.RadioButton
    Friend WithEvents GridReceipt As Janus.Windows.GridEX.GridEX
    Friend WithEvents RadReportCancel As System.Windows.Forms.RadioButton
    Friend WithEvents RadReceiptCancel As System.Windows.Forms.RadioButton
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadReportNil As System.Windows.Forms.RadioButton
    Friend WithEvents RadReceiptNil As System.Windows.Forms.RadioButton
    Friend WithEvents VSForOpticalshop As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents BtnImpReceipt As System.Windows.Forms.Button
    Friend WithEvents BGImpOpticalTEH As System.ComponentModel.BackgroundWorker

End Class
