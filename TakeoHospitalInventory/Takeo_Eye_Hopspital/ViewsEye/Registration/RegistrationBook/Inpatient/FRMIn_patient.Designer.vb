<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMIn_patient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMIn_patient))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateIn = New System.Windows.Forms.DateTimePicker
        Me.LblLoadData = New System.Windows.Forms.LinkLabel
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.CboOperationType = New System.Windows.Forms.ComboBox
        Me.TxtSex = New System.Windows.Forms.Label
        Me.TxtAge = New System.Windows.Forms.Label
        Me.TxtAddress = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.Label
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.TxtPatientNo = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtOther = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RRielSSFee = New System.Windows.Forms.RadioButton
        Me.RDolarSSFee = New System.Windows.Forms.RadioButton
        Me.TxtFullFee = New System.Windows.Forms.TextBox
        Me.TxtSosialServiceFee = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtHosFee = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RDolarFFee = New System.Windows.Forms.RadioButton
        Me.RReilFFee = New System.Windows.Forms.RadioButton
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ErrInpatient = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ChDonation = New System.Windows.Forms.CheckBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.CboDonation = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtDonationPay = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.LblReceiptNoHid = New System.Windows.Forms.Label
        Me.LblPatientNameEng = New System.Windows.Forms.Label
        Me.LblCombindReferal = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.LblConsultID = New System.Windows.Forms.Label
        Me.LblSendBy = New System.Windows.Forms.Label
        Me.lblConsultFor = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.LblConsultDate = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.LblConsultType = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrInpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DateIn)
        Me.GroupBox1.Controls.Add(Me.LblLoadData)
        Me.GroupBox1.Controls.Add(Me.TxtReceiptNo)
        Me.GroupBox1.Controls.Add(Me.CboDiagnosis)
        Me.GroupBox1.Controls.Add(Me.CboOperationType)
        Me.GroupBox1.Controls.Add(Me.TxtSex)
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.TxtAddress)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 384)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Info"
        '
        'DateIn
        '
        Me.DateIn.Checked = False
        Me.DateIn.CustomFormat = "dd/MM/yyyy"
        Me.DateIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateIn.Location = New System.Drawing.Point(95, 20)
        Me.DateIn.Name = "DateIn"
        Me.DateIn.ShowCheckBox = True
        Me.DateIn.Size = New System.Drawing.Size(184, 26)
        Me.DateIn.TabIndex = 0
        '
        'LblLoadData
        '
        Me.LblLoadData.AutoSize = True
        Me.LblLoadData.Location = New System.Drawing.Point(284, 67)
        Me.LblLoadData.Name = "LblLoadData"
        Me.LblLoadData.Size = New System.Drawing.Size(31, 13)
        Me.LblLoadData.TabIndex = 6
        Me.LblLoadData.TabStop = True
        Me.LblLoadData.Text = "Load"
        Me.LblLoadData.Visible = False
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.BackColor = System.Drawing.SystemColors.Window
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptNo.Location = New System.Drawing.Point(95, 54)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.ReadOnly = True
        Me.TxtReceiptNo.Size = New System.Drawing.Size(184, 26)
        Me.TxtReceiptNo.TabIndex = 1
        Me.TxtReceiptNo.Text = "0"
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(109, 269)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(221, 28)
        Me.CboDiagnosis.TabIndex = 7
        '
        'CboOperationType
        '
        Me.CboOperationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboOperationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboOperationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOperationType.FormattingEnabled = True
        Me.CboOperationType.Location = New System.Drawing.Point(109, 307)
        Me.CboOperationType.Name = "CboOperationType"
        Me.CboOperationType.Size = New System.Drawing.Size(221, 28)
        Me.CboOperationType.TabIndex = 7
        '
        'TxtSex
        '
        Me.TxtSex.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSex.Location = New System.Drawing.Point(229, 163)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.Size = New System.Drawing.Size(50, 23)
        Me.TxtSex.TabIndex = 5
        Me.TxtSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(138, 163)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(50, 23)
        Me.TxtAge.TabIndex = 4
        Me.TxtAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(13, 194)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(317, 62)
        Me.TxtAddress.TabIndex = 6
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtPatientName.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(95, 121)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(235, 32)
        Me.TxtPatientName.TabIndex = 3
        Me.TxtPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.BackColor = System.Drawing.Color.Transparent
        Me.LblSaveOption.Location = New System.Drawing.Point(302, 16)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 5
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(95, 90)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(235, 23)
        Me.TxtPatientNo.TabIndex = 2
        Me.TxtPatientNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Diagnosis:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 315)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Type of operation:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sex:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name of patient:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patient No:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Date In:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receipt No:"
        '
        'TxtOther
        '
        Me.TxtOther.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtOther.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOther.FormattingEnabled = True
        Me.TxtOther.Location = New System.Drawing.Point(511, 393)
        Me.TxtOther.Name = "TxtOther"
        Me.TxtOther.Size = New System.Drawing.Size(73, 28)
        Me.TxtOther.TabIndex = 8
        Me.TxtOther.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(466, 401)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Other: "
        Me.Label15.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.TxtFullFee)
        Me.GroupBox2.Controls.Add(Me.TxtSosialServiceFee)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtHosFee)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(356, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 117)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Fee"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Wat Phnom T3", 8.0!)
        Me.Label13.Location = New System.Drawing.Point(233, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 22)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "erol"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RRielSSFee)
        Me.GroupBox3.Controls.Add(Me.RDolarSSFee)
        Me.GroupBox3.Location = New System.Drawing.Point(230, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 33)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'RRielSSFee
        '
        Me.RRielSSFee.AutoSize = True
        Me.RRielSSFee.BackColor = System.Drawing.Color.Transparent
        Me.RRielSSFee.Checked = True
        Me.RRielSSFee.Font = New System.Drawing.Font("Wat Phnom T3", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRielSSFee.Location = New System.Drawing.Point(11, 10)
        Me.RRielSSFee.Name = "RRielSSFee"
        Me.RRielSSFee.Size = New System.Drawing.Size(49, 24)
        Me.RRielSSFee.TabIndex = 13
        Me.RRielSSFee.TabStop = True
        Me.RRielSSFee.Text = "erol"
        Me.RRielSSFee.UseVisualStyleBackColor = False
        '
        'RDolarSSFee
        '
        Me.RDolarSSFee.AutoSize = True
        Me.RDolarSSFee.BackColor = System.Drawing.Color.Transparent
        Me.RDolarSSFee.Font = New System.Drawing.Font("Wat Phnom T3", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDolarSSFee.Location = New System.Drawing.Point(91, 10)
        Me.RDolarSSFee.Name = "RDolarSSFee"
        Me.RDolarSSFee.Size = New System.Drawing.Size(54, 24)
        Me.RDolarSSFee.TabIndex = 14
        Me.RDolarSSFee.Text = "duløar"
        Me.RDolarSSFee.UseVisualStyleBackColor = False
        '
        'TxtFullFee
        '
        Me.TxtFullFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFullFee.Location = New System.Drawing.Point(59, 84)
        Me.TxtFullFee.Name = "TxtFullFee"
        Me.TxtFullFee.Size = New System.Drawing.Size(168, 26)
        Me.TxtFullFee.TabIndex = 2
        Me.TxtFullFee.Text = "0"
        Me.TxtFullFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSosialServiceFee
        '
        Me.TxtSosialServiceFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSosialServiceFee.Location = New System.Drawing.Point(104, 49)
        Me.TxtSosialServiceFee.Name = "TxtSosialServiceFee"
        Me.TxtSosialServiceFee.Size = New System.Drawing.Size(123, 26)
        Me.TxtSosialServiceFee.TabIndex = 1
        Me.TxtSosialServiceFee.Text = "0"
        Me.TxtSosialServiceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Full Fee:"
        '
        'TxtHosFee
        '
        Me.TxtHosFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHosFee.Location = New System.Drawing.Point(59, 16)
        Me.TxtHosFee.Name = "TxtHosFee"
        Me.TxtHosFee.Size = New System.Drawing.Size(168, 26)
        Me.TxtHosFee.TabIndex = 0
        Me.TxtHosFee.Text = "0"
        Me.TxtHosFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Social Service Fee:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Hos. Fee:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RDolarFFee)
        Me.GroupBox4.Controls.Add(Me.RReilFFee)
        Me.GroupBox4.Location = New System.Drawing.Point(230, 76)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(153, 34)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'RDolarFFee
        '
        Me.RDolarFFee.AutoSize = True
        Me.RDolarFFee.BackColor = System.Drawing.Color.Transparent
        Me.RDolarFFee.Font = New System.Drawing.Font("Wat Phnom T3", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDolarFFee.Location = New System.Drawing.Point(91, 11)
        Me.RDolarFFee.Name = "RDolarFFee"
        Me.RDolarFFee.Size = New System.Drawing.Size(54, 24)
        Me.RDolarFFee.TabIndex = 16
        Me.RDolarFFee.Text = "duløar"
        Me.RDolarFFee.UseVisualStyleBackColor = False
        '
        'RReilFFee
        '
        Me.RReilFFee.AutoSize = True
        Me.RReilFFee.BackColor = System.Drawing.Color.Transparent
        Me.RReilFFee.Checked = True
        Me.RReilFFee.Font = New System.Drawing.Font("Wat Phnom T3", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RReilFFee.Location = New System.Drawing.Point(11, 11)
        Me.RReilFFee.Name = "RReilFFee"
        Me.RReilFFee.Size = New System.Drawing.Size(49, 24)
        Me.RReilFFee.TabIndex = 15
        Me.RReilFFee.TabStop = True
        Me.RReilFFee.Text = "erol"
        Me.RReilFFee.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(359, 400)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 35)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(260, 401)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(90, 35)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ErrInpatient
        '
        Me.ErrInpatient.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.KTGSYS.My.Resources.Resources.Warning
        Me.PictureBox1.Location = New System.Drawing.Point(356, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(388, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 45)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "សំរាប់កត់ត្រាព័ត៌មានអ្នកជម្ងឺចូល IN-PATIENT BOOK NILL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChDonation
        '
        Me.ChDonation.AutoSize = True
        Me.ChDonation.BackColor = System.Drawing.Color.Transparent
        Me.ChDonation.Location = New System.Drawing.Point(360, 302)
        Me.ChDonation.Margin = New System.Windows.Forms.Padding(2)
        Me.ChDonation.Name = "ChDonation"
        Me.ChDonation.Size = New System.Drawing.Size(69, 17)
        Me.ChDonation.TabIndex = 8
        Me.ChDonation.Text = "Donation"
        Me.ChDonation.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.CboDonation)
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Controls.Add(Me.TxtDonationPay)
        Me.GroupBox8.Controls.Add(Me.Label20)
        Me.GroupBox8.Location = New System.Drawing.Point(356, 305)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(389, 81)
        Me.GroupBox8.TabIndex = 9
        Me.GroupBox8.TabStop = False
        '
        'CboDonation
        '
        Me.CboDonation.Enabled = False
        Me.CboDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDonation.FormattingEnabled = True
        Me.CboDonation.Location = New System.Drawing.Point(99, 16)
        Me.CboDonation.Margin = New System.Windows.Forms.Padding(2)
        Me.CboDonation.Name = "CboDonation"
        Me.CboDonation.Size = New System.Drawing.Size(270, 28)
        Me.CboDonation.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(353, 57)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(16, 17)
        Me.Label21.TabIndex = 213
        Me.Label21.Text = "$"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 20)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 13)
        Me.Label19.TabIndex = 212
        Me.Label19.Text = "Donate Name:"
        '
        'TxtDonationPay
        '
        Me.TxtDonationPay.Enabled = False
        Me.TxtDonationPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDonationPay.Location = New System.Drawing.Point(99, 48)
        Me.TxtDonationPay.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDonationPay.Name = "TxtDonationPay"
        Me.TxtDonationPay.Size = New System.Drawing.Size(250, 26)
        Me.TxtDonationPay.TabIndex = 4
        Me.TxtDonationPay.Text = "0"
        Me.TxtDonationPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 61)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 212
        Me.Label20.Text = "Donate:"
        '
        'LblReceiptNoHid
        '
        Me.LblReceiptNoHid.AutoSize = True
        Me.LblReceiptNoHid.Location = New System.Drawing.Point(51, 408)
        Me.LblReceiptNoHid.Name = "LblReceiptNoHid"
        Me.LblReceiptNoHid.Size = New System.Drawing.Size(13, 13)
        Me.LblReceiptNoHid.TabIndex = 10
        Me.LblReceiptNoHid.Text = "0"
        Me.LblReceiptNoHid.Visible = False
        '
        'LblPatientNameEng
        '
        Me.LblPatientNameEng.AutoSize = True
        Me.LblPatientNameEng.Location = New System.Drawing.Point(356, 69)
        Me.LblPatientNameEng.Name = "LblPatientNameEng"
        Me.LblPatientNameEng.Size = New System.Drawing.Size(101, 13)
        Me.LblPatientNameEng.TabIndex = 11
        Me.LblPatientNameEng.Text = "LblPatientNameEng"
        Me.LblPatientNameEng.Visible = False
        '
        'LblCombindReferal
        '
        Me.LblCombindReferal.AutoSize = True
        Me.LblCombindReferal.Location = New System.Drawing.Point(353, 102)
        Me.LblCombindReferal.Name = "LblCombindReferal"
        Me.LblCombindReferal.Size = New System.Drawing.Size(96, 13)
        Me.LblCombindReferal.TabIndex = 12
        Me.LblCombindReferal.Text = "LblCombindReferal"
        Me.LblCombindReferal.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LblConsultID)
        Me.GroupBox6.Controls.Add(Me.LblSendBy)
        Me.GroupBox6.Controls.Add(Me.lblConsultFor)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.LblConsultDate)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.LblConsultType)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Red
        Me.GroupBox6.Location = New System.Drawing.Point(520, 43)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(225, 136)
        Me.GroupBox6.TabIndex = 210
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Information From Consult"
        '
        'LblConsultID
        '
        Me.LblConsultID.AutoSize = True
        Me.LblConsultID.Location = New System.Drawing.Point(188, 23)
        Me.LblConsultID.Name = "LblConsultID"
        Me.LblConsultID.Size = New System.Drawing.Size(18, 20)
        Me.LblConsultID.TabIndex = 8
        Me.LblConsultID.Text = "0"
        Me.LblConsultID.Visible = False
        '
        'LblSendBy
        '
        Me.LblSendBy.AutoSize = True
        Me.LblSendBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSendBy.ForeColor = System.Drawing.Color.Red
        Me.LblSendBy.Location = New System.Drawing.Point(100, 108)
        Me.LblSendBy.Name = "LblSendBy"
        Me.LblSendBy.Size = New System.Drawing.Size(77, 17)
        Me.LblSendBy.TabIndex = 7
        Me.LblSendBy.Text = "No Consult"
        '
        'lblConsultFor
        '
        Me.lblConsultFor.AutoSize = True
        Me.lblConsultFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultFor.ForeColor = System.Drawing.Color.Red
        Me.lblConsultFor.Location = New System.Drawing.Point(100, 80)
        Me.lblConsultFor.Name = "lblConsultFor"
        Me.lblConsultFor.Size = New System.Drawing.Size(77, 17)
        Me.lblConsultFor.TabIndex = 6
        Me.lblConsultFor.Text = "No Consult"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(6, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 17)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Consult For:"
        '
        'LblConsultDate
        '
        Me.LblConsultDate.AutoSize = True
        Me.LblConsultDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultDate.ForeColor = System.Drawing.Color.Red
        Me.LblConsultDate.Location = New System.Drawing.Point(100, 26)
        Me.LblConsultDate.Name = "LblConsultDate"
        Me.LblConsultDate.Size = New System.Drawing.Size(77, 17)
        Me.LblConsultDate.TabIndex = 4
        Me.LblConsultDate.Text = "No Consult"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.Location = New System.Drawing.Point(6, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 17)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Date Consult:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(6, 108)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 17)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Consult By:"
        '
        'LblConsultType
        '
        Me.LblConsultType.AutoSize = True
        Me.LblConsultType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultType.ForeColor = System.Drawing.Color.Red
        Me.LblConsultType.Location = New System.Drawing.Point(100, 53)
        Me.LblConsultType.Name = "LblConsultType"
        Me.LblConsultType.Size = New System.Drawing.Size(77, 17)
        Me.LblConsultType.TabIndex = 1
        Me.LblConsultType.Text = "No Consult"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(6, 53)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 17)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Consult Type:"
        '
        'FRMIn_patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(757, 442)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.LblCombindReferal)
        Me.Controls.Add(Me.TxtOther)
        Me.Controls.Add(Me.LblPatientNameEng)
        Me.Controls.Add(Me.LblReceiptNoHid)
        Me.Controls.Add(Me.ChDonation)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMIn_patient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IN PATIENT BOOK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrInpatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblLoadData As System.Windows.Forms.LinkLabel
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents CboOperationType As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSex As System.Windows.Forms.Label
    Friend WithEvents TxtAge As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.Label
    Friend WithEvents TxtPatientName As System.Windows.Forms.Label
    Friend WithEvents TxtPatientNo As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrInpatient As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtFullFee As System.Windows.Forms.TextBox
    Friend WithEvents TxtSosialServiceFee As System.Windows.Forms.TextBox
    Friend WithEvents TxtHosFee As System.Windows.Forms.TextBox
    Friend WithEvents TxtOther As System.Windows.Forms.ComboBox
    Friend WithEvents DateIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RDolarFFee As System.Windows.Forms.RadioButton
    Friend WithEvents RReilFFee As System.Windows.Forms.RadioButton
    Friend WithEvents RDolarSSFee As System.Windows.Forms.RadioButton
    Friend WithEvents RRielSSFee As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ChDonation As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents CboDonation As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtDonationPay As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblReceiptNoHid As System.Windows.Forms.Label
    Friend WithEvents LblPatientNameEng As System.Windows.Forms.Label
    Friend WithEvents LblCombindReferal As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LblConsultID As System.Windows.Forms.Label
    Friend WithEvents LblSendBy As System.Windows.Forms.Label
    Friend WithEvents lblConsultFor As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LblConsultDate As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LblConsultType As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
End Class
