<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClinicalAuditAssessment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClinicalAuditAssessment))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateClinicalAuditOn = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClientNameEng = New System.Windows.Forms.TextBox()
        Me.txtClientAge = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProvisionalDiagnosis = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddTherapist = New System.Windows.Forms.Button()
        Me.cboTherapist = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.txtOtherTherapies = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtResponseToTherapy = New System.Windows.Forms.TextBox()
        Me.txtEngagement = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtActionPlan = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtLiasion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtClientSex = New System.Windows.Forms.TextBox()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtClientClientNameKh = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DateRegister = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtWeekUnderReview = New System.Windows.Forms.TextBox()
        Me.TxtNumberVisit = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtFinalDiagnosis = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtAssessmentCompleted = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtAssessmentBeDone = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblSaveOption = New System.Windows.Forms.Label()
        Me.DateDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateNextVisist = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LblWeekLabel = New System.Windows.Forms.TextBox()
        Me.EndDateWeek = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.StartDateWeek = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CboCall = New System.Windows.Forms.ComboBox()
        Me.CboOnlyDiscuss = New System.Windows.Forms.ComboBox()
        Me.CboDiscussWriting = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtAuditRemark = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ErrClininicalAudit = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TxtRefferedBy = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrClininicalAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date Clinical Audit On:"
        '
        'DateClinicalAuditOn
        '
        Me.DateClinicalAuditOn.Checked = False
        Me.DateClinicalAuditOn.CustomFormat = "dd/MM/yyyy"
        Me.DateClinicalAuditOn.Enabled = False
        Me.DateClinicalAuditOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateClinicalAuditOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateClinicalAuditOn.Location = New System.Drawing.Point(7, 54)
        Me.DateClinicalAuditOn.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.DateClinicalAuditOn.Name = "DateClinicalAuditOn"
        Me.DateClinicalAuditOn.ShowCheckBox = True
        Me.DateClinicalAuditOn.Size = New System.Drawing.Size(225, 26)
        Me.DateClinicalAuditOn.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(13, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Therapist"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(523, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Client Name Eng:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(27, 129)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Age:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(162, 129)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sex:"
        '
        'txtClientNameEng
        '
        Me.txtClientNameEng.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientNameEng.Location = New System.Drawing.Point(523, 92)
        Me.txtClientNameEng.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtClientNameEng.Name = "txtClientNameEng"
        Me.txtClientNameEng.ReadOnly = True
        Me.txtClientNameEng.Size = New System.Drawing.Size(282, 32)
        Me.txtClientNameEng.TabIndex = 7
        '
        'txtClientAge
        '
        Me.txtClientAge.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.txtClientAge.Location = New System.Drawing.Point(14, 154)
        Me.txtClientAge.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtClientAge.Name = "txtClientAge"
        Me.txtClientAge.ReadOnly = True
        Me.txtClientAge.Size = New System.Drawing.Size(88, 32)
        Me.txtClientAge.TabIndex = 8
        Me.txtClientAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(523, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Refered By:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(9, 188)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Provisional Diagnosis:"
        '
        'txtProvisionalDiagnosis
        '
        Me.txtProvisionalDiagnosis.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvisionalDiagnosis.Location = New System.Drawing.Point(14, 220)
        Me.txtProvisionalDiagnosis.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtProvisionalDiagnosis.Multiline = True
        Me.txtProvisionalDiagnosis.Name = "txtProvisionalDiagnosis"
        Me.txtProvisionalDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtProvisionalDiagnosis.Size = New System.Drawing.Size(370, 107)
        Me.txtProvisionalDiagnosis.TabIndex = 13
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1036, 614)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 49)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(893, 614)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 49)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAddTherapist
        '
        Me.btnAddTherapist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTherapist.Location = New System.Drawing.Point(249, 33)
        Me.btnAddTherapist.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnAddTherapist.Name = "btnAddTherapist"
        Me.btnAddTherapist.Size = New System.Drawing.Size(35, 29)
        Me.btnAddTherapist.TabIndex = 3
        Me.btnAddTherapist.Text = "+"
        Me.btnAddTherapist.UseVisualStyleBackColor = True
        Me.btnAddTherapist.Visible = False
        '
        'cboTherapist
        '
        Me.cboTherapist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTherapist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTherapist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTherapist.FormattingEnabled = True
        Me.cboTherapist.Location = New System.Drawing.Point(13, 34)
        Me.cboTherapist.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.cboTherapist.Name = "cboTherapist"
        Me.cboTherapist.Size = New System.Drawing.Size(226, 28)
        Me.cboTherapist.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(11, 469)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 25)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Meication:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(391, 469)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 25)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Other Thearapies:"
        '
        'txtMedication
        '
        Me.txtMedication.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedication.Location = New System.Drawing.Point(13, 495)
        Me.txtMedication.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtMedication.Multiline = True
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMedication.Size = New System.Drawing.Size(371, 107)
        Me.txtMedication.TabIndex = 17
        '
        'txtOtherTherapies
        '
        Me.txtOtherTherapies.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherTherapies.Location = New System.Drawing.Point(394, 495)
        Me.txtOtherTherapies.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtOtherTherapies.Multiline = True
        Me.txtOtherTherapies.Name = "txtOtherTherapies"
        Me.txtOtherTherapies.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOtherTherapies.Size = New System.Drawing.Size(411, 107)
        Me.txtOtherTherapies.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(9, 614)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 25)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Response to Therapy:"
        '
        'txtResponseToTherapy
        '
        Me.txtResponseToTherapy.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponseToTherapy.Location = New System.Drawing.Point(14, 645)
        Me.txtResponseToTherapy.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtResponseToTherapy.Multiline = True
        Me.txtResponseToTherapy.Name = "txtResponseToTherapy"
        Me.txtResponseToTherapy.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResponseToTherapy.Size = New System.Drawing.Size(370, 109)
        Me.txtResponseToTherapy.TabIndex = 19
        '
        'txtEngagement
        '
        Me.txtEngagement.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngagement.Location = New System.Drawing.Point(394, 645)
        Me.txtEngagement.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtEngagement.Multiline = True
        Me.txtEngagement.Name = "txtEngagement"
        Me.txtEngagement.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEngagement.Size = New System.Drawing.Size(411, 109)
        Me.txtEngagement.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Khmer OS Battambang", 7.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(394, 607)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(253, 36)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Rapport/Engagemnet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (Tredency to Drop-out / Need to Re-establish contact)"
        '
        'txtActionPlan
        '
        Me.txtActionPlan.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActionPlan.Location = New System.Drawing.Point(394, 789)
        Me.txtActionPlan.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtActionPlan.Multiline = True
        Me.txtActionPlan.Name = "txtActionPlan"
        Me.txtActionPlan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtActionPlan.Size = New System.Drawing.Size(411, 107)
        Me.txtActionPlan.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(388, 760)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 25)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Action Plan:"
        '
        'txtLiasion
        '
        Me.txtLiasion.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiasion.Location = New System.Drawing.Point(16, 789)
        Me.txtLiasion.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtLiasion.Multiline = True
        Me.txtLiasion.Name = "txtLiasion"
        Me.txtLiasion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLiasion.Size = New System.Drawing.Size(368, 109)
        Me.txtLiasion.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Maroon
        Me.Label19.Location = New System.Drawing.Point(12, 760)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(223, 25)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Liasion/Referal To Other Agency:"
        '
        'TxtClientSex
        '
        Me.TxtClientSex.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.TxtClientSex.Location = New System.Drawing.Point(137, 154)
        Me.TxtClientSex.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(102, 32)
        Me.TxtClientSex.TabIndex = 9
        Me.TxtClientSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNo.Location = New System.Drawing.Point(14, 92)
        Me.TxtClientNo.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.ReadOnly = True
        Me.TxtClientNo.Size = New System.Drawing.Size(225, 32)
        Me.TxtClientNo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(14, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Client No:"
        '
        'TxtClientClientNameKh
        '
        Me.TxtClientClientNameKh.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientClientNameKh.Location = New System.Drawing.Point(249, 92)
        Me.TxtClientClientNameKh.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtClientClientNameKh.Name = "TxtClientClientNameKh"
        Me.TxtClientClientNameKh.ReadOnly = True
        Me.TxtClientClientNameKh.Size = New System.Drawing.Size(264, 32)
        Me.TxtClientClientNameKh.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label20.ForeColor = System.Drawing.Color.Maroon
        Me.Label20.Location = New System.Drawing.Point(249, 66)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(114, 25)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Client Name Kh:"
        '
        'DateRegister
        '
        Me.DateRegister.CustomFormat = "dd/MM/yyyy"
        Me.DateRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRegister.Location = New System.Drawing.Point(383, 160)
        Me.DateRegister.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.DateRegister.Name = "DateRegister"
        Me.DateRegister.Size = New System.Drawing.Size(129, 26)
        Me.DateRegister.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Maroon
        Me.Label21.Location = New System.Drawing.Point(383, 129)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 25)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Date Register:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(7, 151)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(138, 25)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "Week under review:"
        '
        'TxtWeekUnderReview
        '
        Me.TxtWeekUnderReview.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWeekUnderReview.Location = New System.Drawing.Point(7, 179)
        Me.TxtWeekUnderReview.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtWeekUnderReview.Name = "TxtWeekUnderReview"
        Me.TxtWeekUnderReview.ReadOnly = True
        Me.TxtWeekUnderReview.Size = New System.Drawing.Size(129, 32)
        Me.TxtWeekUnderReview.TabIndex = 4
        Me.TxtWeekUnderReview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNumberVisit
        '
        Me.TxtNumberVisit.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumberVisit.Location = New System.Drawing.Point(7, 249)
        Me.TxtNumberVisit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtNumberVisit.Name = "TxtNumberVisit"
        Me.TxtNumberVisit.Size = New System.Drawing.Size(132, 32)
        Me.TxtNumberVisit.TabIndex = 0
        Me.TxtNumberVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Maroon
        Me.Label23.Location = New System.Drawing.Point(7, 224)
        Me.Label23.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 25)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Number Of Visit:"
        '
        'txtFinalDiagnosis
        '
        Me.txtFinalDiagnosis.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalDiagnosis.Location = New System.Drawing.Point(394, 220)
        Me.txtFinalDiagnosis.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtFinalDiagnosis.Multiline = True
        Me.txtFinalDiagnosis.Name = "txtFinalDiagnosis"
        Me.txtFinalDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFinalDiagnosis.Size = New System.Drawing.Size(411, 107)
        Me.txtFinalDiagnosis.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Maroon
        Me.Label24.Location = New System.Drawing.Point(395, 198)
        Me.Label24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(113, 25)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "Final Diagnosis:"
        '
        'TxtAssessmentCompleted
        '
        Me.TxtAssessmentCompleted.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAssessmentCompleted.Location = New System.Drawing.Point(14, 358)
        Me.TxtAssessmentCompleted.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtAssessmentCompleted.Multiline = True
        Me.TxtAssessmentCompleted.Name = "TxtAssessmentCompleted"
        Me.TxtAssessmentCompleted.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtAssessmentCompleted.Size = New System.Drawing.Size(370, 107)
        Me.TxtAssessmentCompleted.TabIndex = 15
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label25.ForeColor = System.Drawing.Color.Maroon
        Me.Label25.Location = New System.Drawing.Point(9, 332)
        Me.Label25.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(164, 25)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "Assessment Completed:"
        '
        'TxtAssessmentBeDone
        '
        Me.TxtAssessmentBeDone.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAssessmentBeDone.Location = New System.Drawing.Point(394, 358)
        Me.TxtAssessmentBeDone.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtAssessmentBeDone.Multiline = True
        Me.TxtAssessmentBeDone.Name = "TxtAssessmentBeDone"
        Me.TxtAssessmentBeDone.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtAssessmentBeDone.Size = New System.Drawing.Size(411, 107)
        Me.TxtAssessmentBeDone.TabIndex = 16
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label26.ForeColor = System.Drawing.Color.Maroon
        Me.Label26.Location = New System.Drawing.Point(389, 332)
        Me.Label26.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(172, 25)
        Me.Label26.TabIndex = 60
        Me.Label26.Text = "Assessment To Be Done:"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.ForeColor = System.Drawing.Color.Maroon
        Me.LblSaveOption.Location = New System.Drawing.Point(169, 337)
        Me.LblSaveOption.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(20, 25)
        Me.LblSaveOption.TabIndex = 62
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'DateDOB
        '
        Me.DateDOB.CustomFormat = "dd/MM/yyyy"
        Me.DateDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDOB.Location = New System.Drawing.Point(244, 160)
        Me.DateDOB.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.DateDOB.Name = "DateDOB"
        Me.DateDOB.Size = New System.Drawing.Size(129, 26)
        Me.DateDOB.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(244, 131)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 25)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "DOB"
        '
        'DateNextVisist
        '
        Me.DateNextVisist.Checked = False
        Me.DateNextVisist.CustomFormat = "dd/MM/yyyy"
        Me.DateNextVisist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateNextVisist.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateNextVisist.Location = New System.Drawing.Point(157, 252)
        Me.DateNextVisist.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.DateNextVisist.Name = "DateNextVisist"
        Me.DateNextVisist.ShowCheckBox = True
        Me.DateNextVisist.Size = New System.Drawing.Size(129, 26)
        Me.DateNextVisist.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(157, 221)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 25)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Next Visit:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.LblWeekLabel)
        Me.GroupBox1.Controls.Add(Me.EndDateWeek)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.StartDateWeek)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.CboCall)
        Me.GroupBox1.Controls.Add(Me.CboOnlyDiscuss)
        Me.GroupBox1.Controls.Add(Me.CboDiscussWriting)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.TxtAuditRemark)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtNumberVisit)
        Me.GroupBox1.Controls.Add(Me.TxtWeekUnderReview)
        Me.GroupBox1.Controls.Add(Me.DateNextVisist)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateClinicalAuditOn)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(813, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 590)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clinical Audit:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Maroon
        Me.Label28.Location = New System.Drawing.Point(157, 145)
        Me.Label28.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(137, 25)
        Me.Label28.TabIndex = 80
        Me.Label28.Text = "Week Review Label"
        '
        'LblWeekLabel
        '
        Me.LblWeekLabel.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWeekLabel.Location = New System.Drawing.Point(157, 176)
        Me.LblWeekLabel.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.LblWeekLabel.Name = "LblWeekLabel"
        Me.LblWeekLabel.ReadOnly = True
        Me.LblWeekLabel.Size = New System.Drawing.Size(133, 32)
        Me.LblWeekLabel.TabIndex = 79
        Me.LblWeekLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EndDateWeek
        '
        Me.EndDateWeek.Checked = False
        Me.EndDateWeek.CustomFormat = "dd/MM/yyyy"
        Me.EndDateWeek.Enabled = False
        Me.EndDateWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDateWeek.Location = New System.Drawing.Point(157, 119)
        Me.EndDateWeek.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.EndDateWeek.Name = "EndDateWeek"
        Me.EndDateWeek.ShowCheckBox = True
        Me.EndDateWeek.Size = New System.Drawing.Size(129, 26)
        Me.EndDateWeek.TabIndex = 77
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Maroon
        Me.Label31.Location = New System.Drawing.Point(157, 88)
        Me.Label31.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(111, 25)
        Me.Label31.TabIndex = 78
        Me.Label31.Text = "End Date Week"
        '
        'StartDateWeek
        '
        Me.StartDateWeek.Checked = False
        Me.StartDateWeek.CustomFormat = "dd/MM/yyyy"
        Me.StartDateWeek.Enabled = False
        Me.StartDateWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDateWeek.Location = New System.Drawing.Point(7, 119)
        Me.StartDateWeek.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.StartDateWeek.Name = "StartDateWeek"
        Me.StartDateWeek.ShowCheckBox = True
        Me.StartDateWeek.Size = New System.Drawing.Size(129, 26)
        Me.StartDateWeek.TabIndex = 74
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Maroon
        Me.Label29.Location = New System.Drawing.Point(7, 88)
        Me.Label29.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(116, 25)
        Me.Label29.TabIndex = 75
        Me.Label29.Text = "Start Date Week"
        '
        'CboCall
        '
        Me.CboCall.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboCall.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboCall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCall.FormattingEnabled = True
        Me.CboCall.Items.AddRange(New Object() {"", "Yes", "No"})
        Me.CboCall.Location = New System.Drawing.Point(7, 358)
        Me.CboCall.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.CboCall.Name = "CboCall"
        Me.CboCall.Size = New System.Drawing.Size(129, 28)
        Me.CboCall.TabIndex = 4
        '
        'CboOnlyDiscuss
        '
        Me.CboOnlyDiscuss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboOnlyDiscuss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboOnlyDiscuss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboOnlyDiscuss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOnlyDiscuss.FormattingEnabled = True
        Me.CboOnlyDiscuss.Items.AddRange(New Object() {"", "Yes", "No"})
        Me.CboOnlyDiscuss.Location = New System.Drawing.Point(157, 306)
        Me.CboOnlyDiscuss.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.CboOnlyDiscuss.Name = "CboOnlyDiscuss"
        Me.CboOnlyDiscuss.Size = New System.Drawing.Size(129, 28)
        Me.CboOnlyDiscuss.TabIndex = 3
        '
        'CboDiscussWriting
        '
        Me.CboDiscussWriting.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiscussWriting.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiscussWriting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDiscussWriting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiscussWriting.FormattingEnabled = True
        Me.CboDiscussWriting.Items.AddRange(New Object() {"", "Yes", "No"})
        Me.CboDiscussWriting.Location = New System.Drawing.Point(7, 306)
        Me.CboDiscussWriting.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.CboDiscussWriting.Name = "CboDiscussWriting"
        Me.CboDiscussWriting.Size = New System.Drawing.Size(127, 28)
        Me.CboDiscussWriting.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Maroon
        Me.Label27.Location = New System.Drawing.Point(8, 390)
        Me.Label27.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 25)
        Me.Label27.TabIndex = 73
        Me.Label27.Text = "Remark:"
        '
        'TxtAuditRemark
        '
        Me.TxtAuditRemark.Font = New System.Drawing.Font("Khmer OS Battambang", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAuditRemark.Location = New System.Drawing.Point(8, 416)
        Me.TxtAuditRemark.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtAuditRemark.Multiline = True
        Me.TxtAuditRemark.Name = "TxtAuditRemark"
        Me.TxtAuditRemark.Size = New System.Drawing.Size(375, 163)
        Me.TxtAuditRemark.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(7, 337)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 25)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Call:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(157, 280)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 25)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Only Discuss:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(7, 281)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 25)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Discuss Writing:"
        '
        'ErrClininicalAudit
        '
        Me.ErrClininicalAudit.ContainerControl = Me
        '
        'TxtRefferedBy
        '
        Me.TxtRefferedBy.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRefferedBy.Location = New System.Drawing.Point(522, 156)
        Me.TxtRefferedBy.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtRefferedBy.Name = "TxtRefferedBy"
        Me.TxtRefferedBy.ReadOnly = True
        Me.TxtRefferedBy.Size = New System.Drawing.Size(282, 32)
        Me.TxtRefferedBy.TabIndex = 12
        '
        'FormClinicalAuditAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 906)
        Me.Controls.Add(Me.TxtRefferedBy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateDOB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtAssessmentBeDone)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TxtAssessmentCompleted)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtFinalDiagnosis)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.DateRegister)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TxtClientClientNameKh)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtClientNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtClientSex)
        Me.Controls.Add(Me.txtLiasion)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtActionPlan)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtEngagement)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtResponseToTherapy)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtOtherTherapies)
        Me.Controls.Add(Me.txtMedication)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboTherapist)
        Me.Controls.Add(Me.btnAddTherapist)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtProvisionalDiagnosis)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtClientAge)
        Me.Controls.Add(Me.txtClientNameEng)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Name = "FormClinicalAuditAssessment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clinical Audit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrClininicalAudit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateClinicalAuditOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtClientNameEng As System.Windows.Forms.TextBox
    Friend WithEvents txtClientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtProvisionalDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddTherapist As System.Windows.Forms.Button
    Friend WithEvents cboTherapist As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMedication As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherTherapies As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtResponseToTherapy As System.Windows.Forms.TextBox
    Friend WithEvents txtEngagement As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtActionPlan As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLiasion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtClientSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtClientClientNameKh As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DateRegister As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtWeekUnderReview As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumberVisit As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtFinalDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtAssessmentCompleted As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtAssessmentBeDone As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents DateDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateNextVisist As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TxtAuditRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ErrClininicalAudit As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtRefferedBy As System.Windows.Forms.TextBox
    Friend WithEvents CboOnlyDiscuss As System.Windows.Forms.ComboBox
    Friend WithEvents CboDiscussWriting As System.Windows.Forms.ComboBox
    Friend WithEvents CboCall As System.Windows.Forms.ComboBox
    Friend WithEvents EndDateWeek As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents StartDateWeek As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents LblWeekLabel As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
