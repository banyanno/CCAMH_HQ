<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAchievePatient
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BgLoadNewPatientBook = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridNewOutpatient = New System.Windows.Forms.DataGridView
        Me.NewOutPatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewPatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OlePatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecieptNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameEng = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewAge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewSex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientFee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diagnosis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Other = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Prescribed = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Dispensed = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Hearing = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Understand = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Seeing = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Physical = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.NewCreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DateToAchieve = New System.Windows.Forms.DateTimePicker
        Me.DateFromAcheive = New System.Windows.Forms.DateTimePicker
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnDisplay = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridNewOutpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNew
        '
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.Location = New System.Drawing.Point(223, 46)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(141, 36)
        Me.BtnNew.TabIndex = 4
        Me.BtnNew.Text = "&New Patient Achieve"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BgLoadNewPatientBook
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridNewOutpatient)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 832)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NEW PATIENT BOOK"
        '
        'GridNewOutpatient
        '
        Me.GridNewOutpatient.AllowUserToAddRows = False
        Me.GridNewOutpatient.AllowUserToDeleteRows = False
        Me.GridNewOutpatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridNewOutpatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridNewOutpatient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridNewOutpatient.ColumnHeadersHeight = 30
        Me.GridNewOutpatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NewOutPatientNo, Me.NewPatientNo, Me.OlePatientNo, Me.RecieptNo, Me.NameEng, Me.NameKhmer2, Me.NewAge, Me.NewSex, Me.NewAddress, Me.PatientFee, Me.Diagnosis, Me.Other, Me.Prescribed, Me.Dispensed, Me.Hearing, Me.Understand, Me.Seeing, Me.Physical, Me.NewCreateDate})
        Me.GridNewOutpatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNewOutpatient.Location = New System.Drawing.Point(3, 16)
        Me.GridNewOutpatient.Name = "GridNewOutpatient"
        Me.GridNewOutpatient.ReadOnly = True
        Me.GridNewOutpatient.RowHeadersWidth = 50
        Me.GridNewOutpatient.RowTemplate.Height = 30
        Me.GridNewOutpatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridNewOutpatient.Size = New System.Drawing.Size(1032, 813)
        Me.GridNewOutpatient.TabIndex = 1
        '
        'NewOutPatientNo
        '
        Me.NewOutPatientNo.DataPropertyName = "NewOutPatientNo"
        Me.NewOutPatientNo.HeaderText = "No"
        Me.NewOutPatientNo.Name = "NewOutPatientNo"
        Me.NewOutPatientNo.ReadOnly = True
        Me.NewOutPatientNo.Visible = False
        '
        'NewPatientNo
        '
        Me.NewPatientNo.DataPropertyName = "PatientNo"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red
        Me.NewPatientNo.DefaultCellStyle = DataGridViewCellStyle5
        Me.NewPatientNo.HeaderText = "Patient No"
        Me.NewPatientNo.Name = "NewPatientNo"
        Me.NewPatientNo.ReadOnly = True
        Me.NewPatientNo.Width = 150
        '
        'OlePatientNo
        '
        Me.OlePatientNo.DataPropertyName = "OlePatientNo"
        Me.OlePatientNo.HeaderText = "Patient No Old"
        Me.OlePatientNo.Name = "OlePatientNo"
        Me.OlePatientNo.ReadOnly = True
        Me.OlePatientNo.Width = 150
        '
        'RecieptNo
        '
        Me.RecieptNo.DataPropertyName = "ReceiptNo"
        Me.RecieptNo.HeaderText = "Reciept No"
        Me.RecieptNo.Name = "RecieptNo"
        Me.RecieptNo.ReadOnly = True
        Me.RecieptNo.Width = 150
        '
        'NameEng
        '
        Me.NameEng.DataPropertyName = "NameEng"
        Me.NameEng.HeaderText = "NameEng"
        Me.NameEng.Name = "NameEng"
        Me.NameEng.ReadOnly = True
        Me.NameEng.Visible = False
        '
        'NameKhmer2
        '
        Me.NameKhmer2.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NameKhmer2.DefaultCellStyle = DataGridViewCellStyle6
        Me.NameKhmer2.HeaderText = "Name of patient/Hosp"
        Me.NameKhmer2.Name = "NameKhmer2"
        Me.NameKhmer2.ReadOnly = True
        Me.NameKhmer2.Width = 200
        '
        'NewAge
        '
        Me.NewAge.DataPropertyName = "Age"
        Me.NewAge.HeaderText = "Age"
        Me.NewAge.Name = "NewAge"
        Me.NewAge.ReadOnly = True
        Me.NewAge.Width = 50
        '
        'NewSex
        '
        Me.NewSex.DataPropertyName = "Sex"
        Me.NewSex.HeaderText = "Sex"
        Me.NewSex.Name = "NewSex"
        Me.NewSex.ReadOnly = True
        Me.NewSex.Width = 50
        '
        'NewAddress
        '
        Me.NewAddress.DataPropertyName = "Address"
        Me.NewAddress.HeaderText = "Address"
        Me.NewAddress.Name = "NewAddress"
        Me.NewAddress.ReadOnly = True
        Me.NewAddress.Width = 200
        '
        'PatientFee
        '
        Me.PatientFee.DataPropertyName = "PatientFee"
        Me.PatientFee.HeaderText = "Patient Fee"
        Me.PatientFee.Name = "PatientFee"
        Me.PatientFee.ReadOnly = True
        '
        'Diagnosis
        '
        Me.Diagnosis.DataPropertyName = "Diagnosis"
        Me.Diagnosis.HeaderText = "Diagnosis"
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.ReadOnly = True
        Me.Diagnosis.Width = 150
        '
        'Other
        '
        Me.Other.DataPropertyName = "Other"
        Me.Other.HeaderText = "Other"
        Me.Other.Name = "Other"
        Me.Other.ReadOnly = True
        '
        'Prescribed
        '
        Me.Prescribed.DataPropertyName = "Prescribed"
        Me.Prescribed.HeaderText = "Prescribed"
        Me.Prescribed.Name = "Prescribed"
        Me.Prescribed.ReadOnly = True
        Me.Prescribed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Prescribed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Prescribed.Visible = False
        '
        'Dispensed
        '
        Me.Dispensed.DataPropertyName = "Dispensed"
        Me.Dispensed.HeaderText = "Dispensed"
        Me.Dispensed.Name = "Dispensed"
        Me.Dispensed.ReadOnly = True
        Me.Dispensed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dispensed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Dispensed.Visible = False
        '
        'Hearing
        '
        Me.Hearing.DataPropertyName = "Hearing"
        Me.Hearing.HeaderText = "Hearing"
        Me.Hearing.Name = "Hearing"
        Me.Hearing.ReadOnly = True
        Me.Hearing.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Hearing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Hearing.Visible = False
        '
        'Understand
        '
        Me.Understand.DataPropertyName = "Understand"
        Me.Understand.HeaderText = "Understand"
        Me.Understand.Name = "Understand"
        Me.Understand.ReadOnly = True
        Me.Understand.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Understand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Understand.Visible = False
        '
        'Seeing
        '
        Me.Seeing.DataPropertyName = "Seeing"
        Me.Seeing.HeaderText = "Seeing"
        Me.Seeing.Name = "Seeing"
        Me.Seeing.ReadOnly = True
        Me.Seeing.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seeing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Seeing.Visible = False
        '
        'Physical
        '
        Me.Physical.DataPropertyName = "Physical"
        Me.Physical.HeaderText = "Physical"
        Me.Physical.Name = "Physical"
        Me.Physical.ReadOnly = True
        Me.Physical.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Physical.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Physical.Visible = False
        '
        'NewCreateDate
        '
        Me.NewCreateDate.DataPropertyName = "CreateDate"
        Me.NewCreateDate.HeaderText = "Date create"
        Me.NewCreateDate.Name = "NewCreateDate"
        Me.NewCreateDate.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateToAchieve)
        Me.GroupBox4.Controls.Add(Me.DateFromAcheive)
        Me.GroupBox4.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox4.Controls.Add(Me.BtnNew)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.BtnDisplay)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1038, 128)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "By patient info"
        '
        'DateToAchieve
        '
        Me.DateToAchieve.CustomFormat = "dd/MM/yyyy"
        Me.DateToAchieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateToAchieve.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateToAchieve.Location = New System.Drawing.Point(88, 93)
        Me.DateToAchieve.Name = "DateToAchieve"
        Me.DateToAchieve.Size = New System.Drawing.Size(128, 26)
        Me.DateToAchieve.TabIndex = 13
        '
        'DateFromAcheive
        '
        Me.DateFromAcheive.CustomFormat = "dd/MM/yyyy"
        Me.DateFromAcheive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFromAcheive.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFromAcheive.Location = New System.Drawing.Point(88, 61)
        Me.DateFromAcheive.Name = "DateFromAcheive"
        Me.DateFromAcheive.Size = New System.Drawing.Size(128, 26)
        Me.DateFromAcheive.TabIndex = 12
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(88, 22)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(128, 26)
        Me.TxtPatientNo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Between"
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplay.Location = New System.Drawing.Point(222, 85)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(142, 37)
        Me.BtnDisplay.TabIndex = 2
        Me.BtnDisplay.Text = "&Display"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "And"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "New Patient No:"
        '
        'UCAchievePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "UCAchievePatient"
        Me.Size = New System.Drawing.Size(1038, 960)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridNewOutpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BgLoadNewPatientBook As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridNewOutpatient As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateToAchieve As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFromAcheive As System.Windows.Forms.DateTimePicker
    Friend WithEvents NewOutPatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewPatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OlePatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecieptNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameEng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewAge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewSex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diagnosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Other As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prescribed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Dispensed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Hearing As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Understand As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Seeing As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Physical As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NewCreateDate As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
