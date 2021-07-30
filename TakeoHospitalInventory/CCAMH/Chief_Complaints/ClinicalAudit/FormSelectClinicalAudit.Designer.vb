<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectClinicalAudit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectClinicalAudit))
        Dim GridClientNew_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.EndDateWeek = New System.Windows.Forms.DateTimePicker()
        Me.StartDateWeek = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateAuditOn = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblWeek = New System.Windows.Forms.Label()
        Me.LblTotalReferralBTB = New System.Windows.Forms.Label()
        Me.LblTotalReferralKGChnang = New System.Windows.Forms.Label()
        Me.LblTotalReferralToKgCham = New System.Windows.Forms.Label()
        Me.LblTotalNaro = New System.Windows.Forms.Label()
        Me.LblTotalPsycology = New System.Windows.Forms.Label()
        Me.LblTotalClinicAudit = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.GridClientNew = New Janus.Windows.GridEX.GridEX()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridClientNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Controls.Add(Me.EndDateWeek)
        Me.UiGroupBox3.Controls.Add(Me.StartDateWeek)
        Me.UiGroupBox3.Controls.Add(Me.Label3)
        Me.UiGroupBox3.Controls.Add(Me.Label2)
        Me.UiGroupBox3.Controls.Add(Me.DateAuditOn)
        Me.UiGroupBox3.Controls.Add(Me.Label1)
        Me.UiGroupBox3.Controls.Add(Me.Label11)
        Me.UiGroupBox3.Controls.Add(Me.LblWeek)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalReferralBTB)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalReferralKGChnang)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalReferralToKgCham)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalNaro)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalPsycology)
        Me.UiGroupBox3.Controls.Add(Me.LblTotalClinicAudit)
        Me.UiGroupBox3.Controls.Add(Me.Label10)
        Me.UiGroupBox3.Controls.Add(Me.Label9)
        Me.UiGroupBox3.Controls.Add(Me.Label8)
        Me.UiGroupBox3.Controls.Add(Me.Label7)
        Me.UiGroupBox3.Controls.Add(Me.Label6)
        Me.UiGroupBox3.Controls.Add(Me.Label5)
        Me.UiGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(211, 500)
        Me.UiGroupBox3.TabIndex = 13
        Me.UiGroupBox3.Text = "Clinical Audit Summary"
        '
        'EndDateWeek
        '
        Me.EndDateWeek.Checked = False
        Me.EndDateWeek.CustomFormat = "dd/MM/yyyy"
        Me.EndDateWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDateWeek.Location = New System.Drawing.Point(10, 163)
        Me.EndDateWeek.Name = "EndDateWeek"
        Me.EndDateWeek.ShowCheckBox = True
        Me.EndDateWeek.Size = New System.Drawing.Size(151, 26)
        Me.EndDateWeek.TabIndex = 31
        '
        'StartDateWeek
        '
        Me.StartDateWeek.Checked = False
        Me.StartDateWeek.CustomFormat = "dd/MM/yyyy"
        Me.StartDateWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDateWeek.Location = New System.Drawing.Point(10, 110)
        Me.StartDateWeek.Name = "StartDateWeek"
        Me.StartDateWeek.ShowCheckBox = True
        Me.StartDateWeek.Size = New System.Drawing.Size(151, 26)
        Me.StartDateWeek.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Select  End Week"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Select Start Week"
        '
        'DateAuditOn
        '
        Me.DateAuditOn.Checked = False
        Me.DateAuditOn.CustomFormat = "dd/MM/yyyy"
        Me.DateAuditOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAuditOn.Location = New System.Drawing.Point(10, 57)
        Me.DateAuditOn.Name = "DateAuditOn"
        Me.DateAuditOn.ShowCheckBox = True
        Me.DateAuditOn.Size = New System.Drawing.Size(151, 26)
        Me.DateAuditOn.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Clinical Audit On:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Week:"
        '
        'LblWeek
        '
        Me.LblWeek.AutoSize = True
        Me.LblWeek.Location = New System.Drawing.Point(72, 202)
        Me.LblWeek.Name = "LblWeek"
        Me.LblWeek.Size = New System.Drawing.Size(18, 20)
        Me.LblWeek.TabIndex = 24
        Me.LblWeek.Text = "0"
        '
        'LblTotalReferralBTB
        '
        Me.LblTotalReferralBTB.AutoSize = True
        Me.LblTotalReferralBTB.Location = New System.Drawing.Point(114, 366)
        Me.LblTotalReferralBTB.Name = "LblTotalReferralBTB"
        Me.LblTotalReferralBTB.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalReferralBTB.TabIndex = 23
        Me.LblTotalReferralBTB.Text = "0"
        '
        'LblTotalReferralKGChnang
        '
        Me.LblTotalReferralKGChnang.AutoSize = True
        Me.LblTotalReferralKGChnang.Location = New System.Drawing.Point(160, 339)
        Me.LblTotalReferralKGChnang.Name = "LblTotalReferralKGChnang"
        Me.LblTotalReferralKGChnang.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalReferralKGChnang.TabIndex = 22
        Me.LblTotalReferralKGChnang.Text = "0"
        '
        'LblTotalReferralToKgCham
        '
        Me.LblTotalReferralToKgCham.AutoSize = True
        Me.LblTotalReferralToKgCham.Location = New System.Drawing.Point(146, 309)
        Me.LblTotalReferralToKgCham.Name = "LblTotalReferralToKgCham"
        Me.LblTotalReferralToKgCham.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalReferralToKgCham.TabIndex = 21
        Me.LblTotalReferralToKgCham.Text = "0"
        '
        'LblTotalNaro
        '
        Me.LblTotalNaro.AutoSize = True
        Me.LblTotalNaro.Location = New System.Drawing.Point(72, 279)
        Me.LblTotalNaro.Name = "LblTotalNaro"
        Me.LblTotalNaro.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalNaro.TabIndex = 20
        Me.LblTotalNaro.Text = "0"
        '
        'LblTotalPsycology
        '
        Me.LblTotalPsycology.AutoSize = True
        Me.LblTotalPsycology.Location = New System.Drawing.Point(72, 254)
        Me.LblTotalPsycology.Name = "LblTotalPsycology"
        Me.LblTotalPsycology.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalPsycology.TabIndex = 19
        Me.LblTotalPsycology.Text = "0"
        '
        'LblTotalClinicAudit
        '
        Me.LblTotalClinicAudit.AutoSize = True
        Me.LblTotalClinicAudit.Location = New System.Drawing.Point(72, 229)
        Me.LblTotalClinicAudit.Name = "LblTotalClinicAudit"
        Me.LblTotalClinicAudit.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalClinicAudit.TabIndex = 18
        Me.LblTotalClinicAudit.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Refer to BTB:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Refer to Kg.Chnang:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Refer to Kg.Cham:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Psy+N:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSave, Me.ToolStripSeparator1, Me.BtnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1043, 58)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(142, 55)
        Me.BtnSave.Text = "Save Clinical Audit"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(92, 55)
        Me.BtnCancel.Text = "    Cancel    "
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GridClientNew
        '
        Me.GridClientNew.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientNew.BackColor = System.Drawing.Color.White
        Me.GridClientNew.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridClientNew.CardBorders = False
        GridClientNew_DesignTimeLayout.LayoutString = resources.GetString("GridClientNew_DesignTimeLayout.LayoutString")
        Me.GridClientNew.DesignTimeLayout = GridClientNew_DesignTimeLayout
        Me.GridClientNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientNew.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridClientNew.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridClientNew.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GridClientNew.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientNew.GroupByBoxVisible = False
        Me.GridClientNew.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClientNew.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClientNew.Location = New System.Drawing.Point(0, 0)
        Me.GridClientNew.Name = "GridClientNew"
        Me.GridClientNew.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.GridClientNew.RecordNavigator = True
        Me.GridClientNew.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientNew.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientNew.Size = New System.Drawing.Size(824, 500)
        Me.GridClientNew.TabIndex = 15
        Me.GridClientNew.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientNew.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridClientNew)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UiGroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1043, 502)
        Me.SplitContainer1.SplitterDistance = 826
        Me.SplitContainer1.TabIndex = 17
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormSelectClinicalAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 560)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectClinicalAudit"
        Me.ShowInTaskbar = False
        Me.Text = "Select Clinical Audit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridClientNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblWeek As System.Windows.Forms.Label
    Friend WithEvents LblTotalReferralBTB As System.Windows.Forms.Label
    Friend WithEvents LblTotalReferralKGChnang As System.Windows.Forms.Label
    Friend WithEvents LblTotalReferralToKgCham As System.Windows.Forms.Label
    Friend WithEvents LblTotalNaro As System.Windows.Forms.Label
    Friend WithEvents LblTotalPsycology As System.Windows.Forms.Label
    Friend WithEvents LblTotalClinicAudit As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridClientNew As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateAuditOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndDateWeek As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDateWeek As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
