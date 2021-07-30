<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReferral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReferral))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtMoreInfo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.ChPickup = New System.Windows.Forms.CheckBox
        Me.DateAppointment = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.BtnNewVA = New System.Windows.Forms.Button
        Me.LblScreenBookID = New System.Windows.Forms.Label
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.DateScreening = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.CboVALeft = New System.Windows.Forms.ComboBox
        Me.CboVARight = New System.Windows.Forms.ComboBox
        Me.cboDiagnosis = New System.Windows.Forms.ComboBox
        Me.CboOnEye = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PatientAge = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PatientSex = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PatientName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 609)
        Me.Panel1.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(277, 563)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 37)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Close"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(171, 563)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 37)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(187, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Referral for Eye Screening"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(192, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TAKEO EYE  HOSPITAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Mool1", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(176, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "មន្ទីរពេទ្យ ភ្នែក តាកែវ"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtMoreInfo)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.ChPickup)
        Me.Panel2.Controls.Add(Me.DateAppointment)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.BtnNewVA)
        Me.Panel2.Controls.Add(Me.LblScreenBookID)
        Me.Panel2.Controls.Add(Me.LblSaveOption)
        Me.Panel2.Controls.Add(Me.DateScreening)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.CboVALeft)
        Me.Panel2.Controls.Add(Me.CboVARight)
        Me.Panel2.Controls.Add(Me.cboDiagnosis)
        Me.Panel2.Controls.Add(Me.CboOnEye)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PatientAge)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.PatientSex)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PatientName)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PatientNo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(8, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(537, 468)
        Me.Panel2.TabIndex = 0
        '
        'TxtMoreInfo
        '
        Me.TxtMoreInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMoreInfo.Location = New System.Drawing.Point(9, 387)
        Me.TxtMoreInfo.Multiline = True
        Me.TxtMoreInfo.Name = "TxtMoreInfo"
        Me.TxtMoreInfo.Size = New System.Drawing.Size(521, 72)
        Me.TxtMoreInfo.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 362)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 20)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "More Info:"
        '
        'ChPickup
        '
        Me.ChPickup.AutoSize = True
        Me.ChPickup.Enabled = False
        Me.ChPickup.Location = New System.Drawing.Point(246, 335)
        Me.ChPickup.Name = "ChPickup"
        Me.ChPickup.Size = New System.Drawing.Size(287, 24)
        Me.ChPickup.TabIndex = 45
        Me.ChPickup.Text = "Pick Up or By Self (Cheked = Pickup)"
        Me.ChPickup.UseVisualStyleBackColor = True
        '
        'DateAppointment
        '
        Me.DateAppointment.Checked = False
        Me.DateAppointment.CustomFormat = "dd/MM/yyyy"
        Me.DateAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAppointment.Location = New System.Drawing.Point(103, 335)
        Me.DateAppointment.Name = "DateAppointment"
        Me.DateAppointment.ShowCheckBox = True
        Me.DateAppointment.Size = New System.Drawing.Size(136, 26)
        Me.DateAppointment.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(98, 307)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 20)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Date Appoint:"
        '
        'BtnNewVA
        '
        Me.BtnNewVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnNewVA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewVA.FlatAppearance.BorderSize = 0
        Me.BtnNewVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewVA.ForeColor = System.Drawing.Color.White
        Me.BtnNewVA.Location = New System.Drawing.Point(398, 272)
        Me.BtnNewVA.Name = "BtnNewVA"
        Me.BtnNewVA.Size = New System.Drawing.Size(29, 29)
        Me.BtnNewVA.TabIndex = 39
        Me.BtnNewVA.Text = "..."
        Me.BtnNewVA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNewVA.UseVisualStyleBackColor = False
        '
        'LblScreenBookID
        '
        Me.LblScreenBookID.AutoSize = True
        Me.LblScreenBookID.Location = New System.Drawing.Point(428, 63)
        Me.LblScreenBookID.Name = "LblScreenBookID"
        Me.LblScreenBookID.Size = New System.Drawing.Size(18, 20)
        Me.LblScreenBookID.TabIndex = 42
        Me.LblScreenBookID.Text = "0"
        Me.LblScreenBookID.Visible = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(428, 29)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.LblSaveOption.TabIndex = 42
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'DateScreening
        '
        Me.DateScreening.CustomFormat = "dd/MM/yyyy"
        Me.DateScreening.Enabled = False
        Me.DateScreening.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateScreening.Location = New System.Drawing.Point(103, 19)
        Me.DateScreening.Name = "DateScreening"
        Me.DateScreening.Size = New System.Drawing.Size(290, 26)
        Me.DateScreening.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Date:"
        '
        'CboVALeft
        '
        Me.CboVALeft.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboVALeft.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboVALeft.FormattingEnabled = True
        Me.CboVALeft.Location = New System.Drawing.Point(251, 272)
        Me.CboVALeft.Name = "CboVALeft"
        Me.CboVALeft.Size = New System.Drawing.Size(142, 28)
        Me.CboVALeft.TabIndex = 37
        '
        'CboVARight
        '
        Me.CboVARight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboVARight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboVARight.FormattingEnabled = True
        Me.CboVARight.Location = New System.Drawing.Point(103, 272)
        Me.CboVARight.Name = "CboVARight"
        Me.CboVARight.Size = New System.Drawing.Size(133, 28)
        Me.CboVARight.TabIndex = 35
        '
        'cboDiagnosis
        '
        Me.cboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDiagnosis.FormattingEnabled = True
        Me.cboDiagnosis.Location = New System.Drawing.Point(103, 212)
        Me.cboDiagnosis.Name = "cboDiagnosis"
        Me.cboDiagnosis.Size = New System.Drawing.Size(292, 28)
        Me.cboDiagnosis.TabIndex = 33
        '
        'CboOnEye
        '
        Me.CboOnEye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboOnEye.FormattingEnabled = True
        Me.CboOnEye.Items.AddRange(New Object() {"", "Right Eye", "Left Eye", "Both Eye"})
        Me.CboOnEye.Location = New System.Drawing.Point(255, 156)
        Me.CboOnEye.Name = "CboOnEye"
        Me.CboOnEye.Size = New System.Drawing.Size(137, 28)
        Me.CboOnEye.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(260, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "VA Left"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(101, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "VA Right"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(101, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Diagnosis:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(306, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "On Eye:"
        '
        'PatientAge
        '
        Me.PatientAge.BackColor = System.Drawing.Color.LightGray
        Me.PatientAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientAge.Location = New System.Drawing.Point(176, 158)
        Me.PatientAge.Name = "PatientAge"
        Me.PatientAge.ReadOnly = True
        Me.PatientAge.Size = New System.Drawing.Size(63, 26)
        Me.PatientAge.TabIndex = 30
        Me.PatientAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(188, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Age"
        '
        'PatientSex
        '
        Me.PatientSex.BackColor = System.Drawing.Color.LightGray
        Me.PatientSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientSex.Location = New System.Drawing.Point(103, 158)
        Me.PatientSex.Name = "PatientSex"
        Me.PatientSex.ReadOnly = True
        Me.PatientSex.Size = New System.Drawing.Size(62, 26)
        Me.PatientSex.TabIndex = 29
        Me.PatientSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Sex:"
        '
        'PatientName
        '
        Me.PatientName.BackColor = System.Drawing.Color.LightGray
        Me.PatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientName.Location = New System.Drawing.Point(103, 97)
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        Me.PatientName.Size = New System.Drawing.Size(290, 30)
        Me.PatientName.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Name:"
        '
        'PatientNo
        '
        Me.PatientNo.BackColor = System.Drawing.Color.LightGray
        Me.PatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.PatientNo.Location = New System.Drawing.Point(103, 57)
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        Me.PatientNo.Size = New System.Drawing.Size(290, 30)
        Me.PatientNo.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Patient No:"
        '
        'FormReferral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 609)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReferral"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReferral"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnNewVA As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents DateScreening As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CboVALeft As System.Windows.Forms.ComboBox
    Friend WithEvents CboVARight As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents CboOnEye As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PatientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PatientSex As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateAppointment As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ChPickup As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMoreInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblScreenBookID As System.Windows.Forms.Label
End Class
