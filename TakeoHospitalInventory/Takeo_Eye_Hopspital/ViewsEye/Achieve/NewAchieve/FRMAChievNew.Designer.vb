<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMAChievNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMAChievNew))
        Me.DateRegistration = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtPatientFee = New System.Windows.Forms.TextBox
        Me.TxtOldPatientNo = New System.Windows.Forms.TextBox
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.CboCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ErrNewOut = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TxtOccupation = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChTypeOther = New System.Windows.Forms.CheckBox
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.CboOther = New System.Windows.Forms.ComboBox
        Me.TxtAgePatient = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.CboProNo = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CboDisNo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CboCommNo = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.CboSexPatien = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtNameKhmer = New System.Windows.Forms.TextBox
        Me.TxtNameEng = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtNewPatientNo = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        CType(Me.ErrNewOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateRegistration
        '
        Me.DateRegistration.CalendarForeColor = System.Drawing.Color.Red
        Me.DateRegistration.Checked = False
        Me.DateRegistration.CustomFormat = "dd/MM/yyyy"
        Me.DateRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRegistration.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRegistration.Location = New System.Drawing.Point(135, 26)
        Me.DateRegistration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateRegistration.Name = "DateRegistration"
        Me.DateRegistration.ShowCheckBox = True
        Me.DateRegistration.Size = New System.Drawing.Size(263, 45)
        Me.DateRegistration.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(-3, 38)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 40)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Date Regis:"
        '
        'TxtPatientFee
        '
        Me.TxtPatientFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientFee.Location = New System.Drawing.Point(127, 618)
        Me.TxtPatientFee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPatientFee.Name = "TxtPatientFee"
        Me.TxtPatientFee.Size = New System.Drawing.Size(312, 30)
        Me.TxtPatientFee.TabIndex = 11
        Me.TxtPatientFee.Text = "0"
        Me.TxtPatientFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtOldPatientNo
        '
        Me.TxtOldPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOldPatientNo.Location = New System.Drawing.Point(129, 128)
        Me.TxtOldPatientNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtOldPatientNo.Name = "TxtOldPatientNo"
        Me.TxtOldPatientNo.Size = New System.Drawing.Size(263, 34)
        Me.TxtOldPatientNo.TabIndex = 2
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptNo.Location = New System.Drawing.Point(129, 86)
        Me.TxtReceiptNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.Size = New System.Drawing.Size(263, 30)
        Me.TxtReceiptNo.TabIndex = 1
        Me.TxtReceiptNo.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 719)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 28)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Other:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 623)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Patient Fee:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 133)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Old patient No:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receipt No:"
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(127, 660)
        Me.CboDiagnosis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(312, 37)
        Me.CboDiagnosis.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 670)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 28)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Diagnosis:"
        '
        'CboCancel
        '
        Me.CboCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboCancel.Location = New System.Drawing.Point(405, 778)
        Me.CboCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboCancel.Name = "CboCancel"
        Me.CboCancel.Size = New System.Drawing.Size(100, 43)
        Me.CboCancel.TabIndex = 1
        Me.CboCancel.Text = "&Cancel"
        Me.CboCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(296, 778)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 43)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ErrNewOut
        '
        Me.ErrNewOut.ContainerControl = Me
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TxtOccupation)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.ChTypeOther)
        Me.GroupBox5.Controls.Add(Me.LblSaveOption)
        Me.GroupBox5.Controls.Add(Me.CboOther)
        Me.GroupBox5.Controls.Add(Me.CboDiagnosis)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.DateRegistration)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.TxtOldPatientNo)
        Me.GroupBox5.Controls.Add(Me.TxtPatientFee)
        Me.GroupBox5.Controls.Add(Me.TxtAgePatient)
        Me.GroupBox5.Controls.Add(Me.TxtReceiptNo)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.TxtTel)
        Me.GroupBox5.Controls.Add(Me.CboSexPatien)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.TxtNameKhmer)
        Me.GroupBox5.Controls.Add(Me.TxtNameEng)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TxtNewPatientNo)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(783, 753)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ព័ត៌មានអ្នកជំងឺចាស់"
        '
        'TxtOccupation
        '
        Me.TxtOccupation.FormattingEnabled = True
        Me.TxtOccupation.Location = New System.Drawing.Point(129, 334)
        Me.TxtOccupation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtOccupation.Name = "TxtOccupation"
        Me.TxtOccupation.Size = New System.Drawing.Size(265, 36)
        Me.TxtOccupation.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.KTGSYS.My.Resources.Resources.Warning
        Me.PictureBox1.Location = New System.Drawing.Point(403, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(433, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 64)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "ចំណាំ -សូមមេត្តា ប្រយ័ត្នបញ្ជូល ថ្ងៃចុះឈ្មោះអ្នកជំងឺមកដំបូងខុស(OLD PATIENT)"
        '
        'ChTypeOther
        '
        Me.ChTypeOther.AutoSize = True
        Me.ChTypeOther.Location = New System.Drawing.Point(448, 654)
        Me.ChTypeOther.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChTypeOther.Name = "ChTypeOther"
        Me.ChTypeOther.Size = New System.Drawing.Size(106, 32)
        Me.ChTypeOther.TabIndex = 13
        Me.ChTypeOther.Text = "Type Other"
        Me.ChTypeOther.UseVisualStyleBackColor = True
        Me.ChTypeOther.Visible = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(419, 171)
        Me.LblSaveOption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(20, 28)
        Me.LblSaveOption.TabIndex = 61
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'CboOther
        '
        Me.CboOther.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboOther.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOther.FormattingEnabled = True
        Me.CboOther.Location = New System.Drawing.Point(127, 711)
        Me.CboOther.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboOther.Name = "CboOther"
        Me.CboOther.Size = New System.Drawing.Size(312, 33)
        Me.CboOther.TabIndex = 14
        '
        'TxtAgePatient
        '
        Me.TxtAgePatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAgePatient.Location = New System.Drawing.Point(129, 255)
        Me.TxtAgePatient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtAgePatient.Name = "TxtAgePatient"
        Me.TxtAgePatient.Size = New System.Drawing.Size(68, 34)
        Me.TxtAgePatient.TabIndex = 6
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CboProNo)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.CboDisNo)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.TxtAddress)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.CboCommNo)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 370)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(767, 242)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Address infomation"
        '
        'CboProNo
        '
        Me.CboProNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboProNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.CboProNo.FormattingEnabled = True
        Me.CboProNo.Location = New System.Drawing.Point(127, 33)
        Me.CboProNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboProNo.Name = "CboProNo"
        Me.CboProNo.Size = New System.Drawing.Size(425, 37)
        Me.CboProNo.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 46)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 28)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Province:"
        '
        'CboDisNo
        '
        Me.CboDisNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDisNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDisNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.CboDisNo.FormattingEnabled = True
        Me.CboDisNo.Location = New System.Drawing.Point(127, 80)
        Me.CboDisNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboDisNo.Name = "CboDisNo"
        Me.CboDisNo.Size = New System.Drawing.Size(425, 37)
        Me.CboDisNo.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 153)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 28)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Full Address:"
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(12, 180)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ReadOnly = True
        Me.TxtAddress.Size = New System.Drawing.Size(745, 52)
        Me.TxtAddress.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 92)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 28)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "District:"
        '
        'CboCommNo
        '
        Me.CboCommNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboCommNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboCommNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.CboCommNo.FormattingEnabled = True
        Me.CboCommNo.Location = New System.Drawing.Point(127, 126)
        Me.CboCommNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboCommNo.Name = "CboCommNo"
        Me.CboCommNo.Size = New System.Drawing.Size(425, 37)
        Me.CboCommNo.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 129)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 28)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Commune:"
        '
        'TxtTel
        '
        Me.TxtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(129, 294)
        Me.TxtTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(265, 30)
        Me.TxtTel.TabIndex = 8
        '
        'CboSexPatien
        '
        Me.CboSexPatien.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSexPatien.FormattingEnabled = True
        Me.CboSexPatien.Items.AddRange(New Object() {"F", "M"})
        Me.CboSexPatien.Location = New System.Drawing.Point(249, 252)
        Me.CboSexPatien.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboSexPatien.MaxLength = 1
        Me.CboSexPatien.Name = "CboSexPatien"
        Me.CboSexPatien.Size = New System.Drawing.Size(68, 37)
        Me.CboSexPatien.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(91, 300)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 28)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Tel:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(37, 341)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 28)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Occupation:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(204, 262)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 28)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Sex:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(85, 261)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 28)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Age:"
        '
        'TxtNameKhmer
        '
        Me.TxtNameKhmer.Font = New System.Drawing.Font("Wat Phnom T3", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameKhmer.Location = New System.Drawing.Point(489, 198)
        Me.TxtNameKhmer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNameKhmer.Name = "TxtNameKhmer"
        Me.TxtNameKhmer.Size = New System.Drawing.Size(285, 53)
        Me.TxtNameKhmer.TabIndex = 5
        '
        'TxtNameEng
        '
        Me.TxtNameEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameEng.Location = New System.Drawing.Point(129, 213)
        Me.TxtNameEng.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNameEng.Name = "TxtNameEng"
        Me.TxtNameEng.Size = New System.Drawing.Size(263, 34)
        Me.TxtNameEng.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(393, 219)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 28)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Name Khmer:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(45, 213)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 28)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Name Eng:"
        '
        'TxtNewPatientNo
        '
        Me.TxtNewPatientNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNewPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNewPatientNo.Location = New System.Drawing.Point(129, 171)
        Me.TxtNewPatientNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNewPatientNo.Name = "TxtNewPatientNo"
        Me.TxtNewPatientNo.ReadOnly = True
        Me.TxtNewPatientNo.Size = New System.Drawing.Size(263, 34)
        Me.TxtNewPatientNo.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 176)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(113, 28)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "New patient No:"
        '
        'FRMAChievNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KTGSYS.My.Resources.Resources.Bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(801, 836)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.CboCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMAChievNew"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Archive For NEW PATIENT BOOK"
        CType(Me.ErrNewOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CboCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtOldPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientFee As System.Windows.Forms.TextBox
    Friend WithEvents DateRegistration As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrNewOut As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAgePatient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CboProNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CboDisNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CboCommNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents CboSexPatien As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtNameKhmer As System.Windows.Forms.TextBox
    Friend WithEvents TxtNameEng As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtNewPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CboOther As System.Windows.Forms.ComboBox
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ChTypeOther As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtOccupation As System.Windows.Forms.ComboBox
End Class
