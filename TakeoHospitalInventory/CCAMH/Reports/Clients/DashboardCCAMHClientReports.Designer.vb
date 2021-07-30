<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCCAMHClientReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardCCAMHClientReports))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.CryViewReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BtnPrintPreviewWeekly = New System.Windows.Forms.Button()
        Me.GroupDiagnosisBreakup = New System.Windows.Forms.GroupBox()
        Me.RadAllDiagnosticBreakup = New System.Windows.Forms.RadioButton()
        Me.RadPsychological = New System.Windows.Forms.RadioButton()
        Me.RadDevelopmental = New System.Windows.Forms.RadioButton()
        Me.RadPhysical = New System.Windows.Forms.RadioButton()
        Me.GroupPatient = New System.Windows.Forms.GroupBox()
        Me.RadOldPatient = New System.Windows.Forms.RadioButton()
        Me.RadNewPatient = New System.Windows.Forms.RadioButton()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadDiagnosisBreakup = New System.Windows.Forms.RadioButton()
        Me.RadPatient = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.GroupDiagnosisBreakup.SuspendLayout()
        Me.GroupPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UiTab1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnPrintPreviewWeekly)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupDiagnosisBreakup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupPatient)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateFrom)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RadDiagnosisBreakup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RadPatient)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1140, 695)
        Me.SplitContainer1.SplitterDistance = 905
        Me.SplitContainer1.TabIndex = 0
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Black
        Me.UiTab1.Size = New System.Drawing.Size(903, 693)
        Me.UiTab1.TabIndex = 7
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.CryViewReport)
        Me.UiTabPage1.Key = "Weekly Report"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(901, 664)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Client Profile-Daily Audit"
        '
        'CryViewReport
        '
        Me.CryViewReport.ActiveViewIndex = -1
        Me.CryViewReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.CryViewReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CryViewReport.Location = New System.Drawing.Point(0, 0)
        Me.CryViewReport.Name = "CryViewReport"
        Me.CryViewReport.SelectionFormula = ""
        Me.CryViewReport.ShowCloseButton = False
        Me.CryViewReport.ShowGroupTreeButton = False
        Me.CryViewReport.ShowRefreshButton = False
        Me.CryViewReport.Size = New System.Drawing.Size(901, 664)
        Me.CryViewReport.TabIndex = 2
        Me.CryViewReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CryViewReport.ViewTimeSelectionFormula = ""
        '
        'BtnPrintPreviewWeekly
        '
        Me.BtnPrintPreviewWeekly.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintPreviewWeekly.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPrintPreviewWeekly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreviewWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintPreviewWeekly.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreviewWeekly.Image = CType(resources.GetObject("BtnPrintPreviewWeekly.Image"), System.Drawing.Image)
        Me.BtnPrintPreviewWeekly.Location = New System.Drawing.Point(3, 632)
        Me.BtnPrintPreviewWeekly.Name = "BtnPrintPreviewWeekly"
        Me.BtnPrintPreviewWeekly.Size = New System.Drawing.Size(223, 58)
        Me.BtnPrintPreviewWeekly.TabIndex = 8
        Me.BtnPrintPreviewWeekly.Text = "Print preview"
        Me.BtnPrintPreviewWeekly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnPrintPreviewWeekly.UseVisualStyleBackColor = False
        '
        'GroupDiagnosisBreakup
        '
        Me.GroupDiagnosisBreakup.Controls.Add(Me.RadAllDiagnosticBreakup)
        Me.GroupDiagnosisBreakup.Controls.Add(Me.RadPsychological)
        Me.GroupDiagnosisBreakup.Controls.Add(Me.RadDevelopmental)
        Me.GroupDiagnosisBreakup.Controls.Add(Me.RadPhysical)
        Me.GroupDiagnosisBreakup.Enabled = False
        Me.GroupDiagnosisBreakup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDiagnosisBreakup.Location = New System.Drawing.Point(6, 270)
        Me.GroupDiagnosisBreakup.Name = "GroupDiagnosisBreakup"
        Me.GroupDiagnosisBreakup.Size = New System.Drawing.Size(219, 150)
        Me.GroupDiagnosisBreakup.TabIndex = 7
        Me.GroupDiagnosisBreakup.TabStop = False
        '
        'RadAllDiagnosticBreakup
        '
        Me.RadAllDiagnosticBreakup.AutoSize = True
        Me.RadAllDiagnosticBreakup.Checked = True
        Me.RadAllDiagnosticBreakup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAllDiagnosticBreakup.Location = New System.Drawing.Point(11, 19)
        Me.RadAllDiagnosticBreakup.Name = "RadAllDiagnosticBreakup"
        Me.RadAllDiagnosticBreakup.Size = New System.Drawing.Size(147, 19)
        Me.RadAllDiagnosticBreakup.TabIndex = 3
        Me.RadAllDiagnosticBreakup.TabStop = True
        Me.RadAllDiagnosticBreakup.Text = "All Diagnostic breakup"
        Me.RadAllDiagnosticBreakup.UseVisualStyleBackColor = True
        '
        'RadPsychological
        '
        Me.RadPsychological.AutoSize = True
        Me.RadPsychological.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPsychological.Location = New System.Drawing.Point(11, 116)
        Me.RadPsychological.Name = "RadPsychological"
        Me.RadPsychological.Size = New System.Drawing.Size(150, 19)
        Me.RadPsychological.TabIndex = 2
        Me.RadPsychological.Text = "Psychological Problem"
        Me.RadPsychological.UseVisualStyleBackColor = True
        '
        'RadDevelopmental
        '
        Me.RadDevelopmental.AutoSize = True
        Me.RadDevelopmental.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDevelopmental.Location = New System.Drawing.Point(11, 83)
        Me.RadDevelopmental.Name = "RadDevelopmental"
        Me.RadDevelopmental.Size = New System.Drawing.Size(142, 19)
        Me.RadDevelopmental.TabIndex = 2
        Me.RadDevelopmental.Text = "Developmental Delay"
        Me.RadDevelopmental.UseVisualStyleBackColor = True
        '
        'RadPhysical
        '
        Me.RadPhysical.AutoSize = True
        Me.RadPhysical.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPhysical.Location = New System.Drawing.Point(11, 51)
        Me.RadPhysical.Name = "RadPhysical"
        Me.RadPhysical.Size = New System.Drawing.Size(120, 19)
        Me.RadPhysical.TabIndex = 2
        Me.RadPhysical.Text = "Physical Problem"
        Me.RadPhysical.UseVisualStyleBackColor = True
        '
        'GroupPatient
        '
        Me.GroupPatient.Controls.Add(Me.RadOldPatient)
        Me.GroupPatient.Controls.Add(Me.RadNewPatient)
        Me.GroupPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPatient.Location = New System.Drawing.Point(6, 151)
        Me.GroupPatient.Name = "GroupPatient"
        Me.GroupPatient.Size = New System.Drawing.Size(219, 85)
        Me.GroupPatient.TabIndex = 6
        Me.GroupPatient.TabStop = False
        '
        'RadOldPatient
        '
        Me.RadOldPatient.AutoSize = True
        Me.RadOldPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadOldPatient.Location = New System.Drawing.Point(11, 49)
        Me.RadOldPatient.Name = "RadOldPatient"
        Me.RadOldPatient.Size = New System.Drawing.Size(179, 19)
        Me.RadOldPatient.TabIndex = 2
        Me.RadOldPatient.Text = "Old Patients (Follow-up visit)"
        Me.RadOldPatient.UseVisualStyleBackColor = True
        '
        'RadNewPatient
        '
        Me.RadNewPatient.AutoSize = True
        Me.RadNewPatient.Checked = True
        Me.RadNewPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNewPatient.Location = New System.Drawing.Point(11, 19)
        Me.RadNewPatient.Name = "RadNewPatient"
        Me.RadNewPatient.Size = New System.Drawing.Size(200, 19)
        Me.RadNewPatient.TabIndex = 2
        Me.RadNewPatient.TabStop = True
        Me.RadNewPatient.Text = "New Patients (First consultation)"
        Me.RadNewPatient.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(15, 99)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(146, 26)
        Me.DateTo.TabIndex = 5
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(15, 49)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(146, 26)
        Me.DateFrom.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Date To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date From:"
        '
        'RadDiagnosisBreakup
        '
        Me.RadDiagnosisBreakup.AutoSize = True
        Me.RadDiagnosisBreakup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDiagnosisBreakup.Location = New System.Drawing.Point(6, 244)
        Me.RadDiagnosisBreakup.Name = "RadDiagnosisBreakup"
        Me.RadDiagnosisBreakup.Size = New System.Drawing.Size(213, 24)
        Me.RadDiagnosisBreakup.TabIndex = 1
        Me.RadDiagnosisBreakup.Text = "DIAGNOSTIC BREAK-UP"
        Me.RadDiagnosisBreakup.UseVisualStyleBackColor = True
        '
        'RadPatient
        '
        Me.RadPatient.AutoSize = True
        Me.RadPatient.Checked = True
        Me.RadPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPatient.Location = New System.Drawing.Point(11, 131)
        Me.RadPatient.Name = "RadPatient"
        Me.RadPatient.Size = New System.Drawing.Size(89, 24)
        Me.RadPatient.TabIndex = 1
        Me.RadPatient.TabStop = True
        Me.RadPatient.Text = "Patients:"
        Me.RadPatient.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "OUT - PATIENT REPORT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DashboardCCAMHClientReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DashboardCCAMHClientReports"
        Me.Size = New System.Drawing.Size(1140, 695)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.GroupDiagnosisBreakup.ResumeLayout(False)
        Me.GroupDiagnosisBreakup.PerformLayout()
        Me.GroupPatient.ResumeLayout(False)
        Me.GroupPatient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CryViewReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadPatient As System.Windows.Forms.RadioButton
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupPatient As System.Windows.Forms.GroupBox
    Friend WithEvents RadNewPatient As System.Windows.Forms.RadioButton
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents RadOldPatient As System.Windows.Forms.RadioButton
    Friend WithEvents GroupDiagnosisBreakup As System.Windows.Forms.GroupBox
    Friend WithEvents RadPsychological As System.Windows.Forms.RadioButton
    Friend WithEvents RadDevelopmental As System.Windows.Forms.RadioButton
    Friend WithEvents RadPhysical As System.Windows.Forms.RadioButton
    Friend WithEvents RadDiagnosisBreakup As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPrintPreviewWeekly As System.Windows.Forms.Button
    Friend WithEvents RadAllDiagnosticBreakup As System.Windows.Forms.RadioButton

End Class
