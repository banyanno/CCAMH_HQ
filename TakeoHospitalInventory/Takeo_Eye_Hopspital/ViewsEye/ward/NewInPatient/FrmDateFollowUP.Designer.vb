<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDateFollowUP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDateFollowUP))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblPatientNo = New System.Windows.Forms.Label
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblDateLeave = New System.Windows.Forms.Label
        Me.DateFollowUp = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.DateDischarge = New System.Windows.Forms.DateTimePicker
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ErDateFollowUp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupVASurgeon = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnNewVARefrac = New System.Windows.Forms.Button
        Me.CboVAPH = New System.Windows.Forms.ComboBox
        Me.CboVAPlain = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CboSurgeonOnEye = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CboDrSurgeon = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.chIsVASurgeon = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblConsellingNo = New System.Windows.Forms.Label
        Me.lblDateConselling = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErDateFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupVASurgeon.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblPatientNo)
        Me.GroupBox1.Controls.Add(Me.CboDoctor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblDateLeave)
        Me.GroupBox1.Controls.Add(Me.DateFollowUp)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 260)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Followup"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Patient No:"
        '
        'lblPatientNo
        '
        Me.lblPatientNo.AutoSize = True
        Me.lblPatientNo.Location = New System.Drawing.Point(95, 25)
        Me.lblPatientNo.Name = "lblPatientNo"
        Me.lblPatientNo.Size = New System.Drawing.Size(13, 13)
        Me.lblPatientNo.TabIndex = 11
        Me.lblPatientNo.Text = "0"
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Enabled = False
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(95, 103)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(171, 28)
        Me.CboDoctor.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "With Doctor:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(9, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 51)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Note: If you don't check [Date Followup]  then patient won't have the followup."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(9, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 58)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ចំណាំ: ប្រសិនបើអ្នកមិនជ្រើសរើសថ្ងៃណាត់ជួប អ្នកជំងឺក៍មិនមានការណាត់ជួបដែរ។"
        '
        'LblDateLeave
        '
        Me.LblDateLeave.AutoSize = True
        Me.LblDateLeave.Location = New System.Drawing.Point(95, 50)
        Me.LblDateLeave.Name = "LblDateLeave"
        Me.LblDateLeave.Size = New System.Drawing.Size(13, 13)
        Me.LblDateLeave.TabIndex = 2
        Me.LblDateLeave.Text = "0"
        '
        'DateFollowUp
        '
        Me.DateFollowUp.Checked = False
        Me.DateFollowUp.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowUp.Location = New System.Drawing.Point(95, 71)
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.ShowCheckBox = True
        Me.DateFollowUp.Size = New System.Drawing.Size(171, 26)
        Me.DateFollowUp.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Date FollowUp:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date Discharge:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "(mm-dd-yyyy)"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(22, 341)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 10
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'DateDischarge
        '
        Me.DateDischarge.Checked = False
        Me.DateDischarge.CustomFormat = "dd/MM/yyyy"
        Me.DateDischarge.Enabled = False
        Me.DateDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDischarge.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDischarge.Location = New System.Drawing.Point(91, 331)
        Me.DateDischarge.Name = "DateDischarge"
        Me.DateDischarge.ShowCheckBox = True
        Me.DateDischarge.Size = New System.Drawing.Size(123, 26)
        Me.DateDischarge.TabIndex = 0
        Me.DateDischarge.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(12, 278)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(112, 31)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ErDateFollowUp
        '
        Me.ErDateFollowUp.ContainerControl = Me
        '
        'GroupVASurgeon
        '
        Me.GroupVASurgeon.Controls.Add(Me.GroupBox3)
        Me.GroupVASurgeon.Controls.Add(Me.CboSurgeonOnEye)
        Me.GroupVASurgeon.Controls.Add(Me.Label7)
        Me.GroupVASurgeon.Controls.Add(Me.CboDrSurgeon)
        Me.GroupVASurgeon.Controls.Add(Me.Label6)
        Me.GroupVASurgeon.Enabled = False
        Me.GroupVASurgeon.Location = New System.Drawing.Point(326, 98)
        Me.GroupVASurgeon.Name = "GroupVASurgeon"
        Me.GroupVASurgeon.Size = New System.Drawing.Size(418, 172)
        Me.GroupVASurgeon.TabIndex = 12
        Me.GroupVASurgeon.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnNewVARefrac)
        Me.GroupBox3.Controls.Add(Me.CboVAPH)
        Me.GroupBox3.Controls.Add(Me.CboVAPlain)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 89)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "VA:"
        '
        'BtnNewVARefrac
        '
        Me.BtnNewVARefrac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewVARefrac.Location = New System.Drawing.Point(296, 52)
        Me.BtnNewVARefrac.Name = "BtnNewVARefrac"
        Me.BtnNewVARefrac.Size = New System.Drawing.Size(43, 27)
        Me.BtnNewVARefrac.TabIndex = 15
        Me.BtnNewVARefrac.Text = "..."
        Me.BtnNewVARefrac.UseVisualStyleBackColor = True
        '
        'CboVAPH
        '
        Me.CboVAPH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboVAPH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboVAPH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboVAPH.FormattingEnabled = True
        Me.CboVAPH.Location = New System.Drawing.Point(112, 51)
        Me.CboVAPH.Name = "CboVAPH"
        Me.CboVAPH.Size = New System.Drawing.Size(170, 28)
        Me.CboVAPH.TabIndex = 14
        '
        'CboVAPlain
        '
        Me.CboVAPlain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboVAPlain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboVAPlain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboVAPlain.FormattingEnabled = True
        Me.CboVAPlain.Location = New System.Drawing.Point(112, 17)
        Me.CboVAPlain.Name = "CboVAPlain"
        Me.CboVAPlain.Size = New System.Drawing.Size(170, 28)
        Me.CboVAPlain.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "i/c PH:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Plain:"
        '
        'CboSurgeonOnEye
        '
        Me.CboSurgeonOnEye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSurgeonOnEye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSurgeonOnEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSurgeonOnEye.FormattingEnabled = True
        Me.CboSurgeonOnEye.Items.AddRange(New Object() {"", "Right Eye", "Left Eye", "Both Eye"})
        Me.CboSurgeonOnEye.Location = New System.Drawing.Point(125, 48)
        Me.CboSurgeonOnEye.Name = "CboSurgeonOnEye"
        Me.CboSurgeonOnEye.Size = New System.Drawing.Size(272, 28)
        Me.CboSurgeonOnEye.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "On Eye:"
        '
        'CboDrSurgeon
        '
        Me.CboDrSurgeon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDrSurgeon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDrSurgeon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDrSurgeon.FormattingEnabled = True
        Me.CboDrSurgeon.Location = New System.Drawing.Point(125, 14)
        Me.CboDrSurgeon.Name = "CboDrSurgeon"
        Me.CboDrSurgeon.Size = New System.Drawing.Size(272, 28)
        Me.CboDrSurgeon.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "With Doctor Surgeon:"
        '
        'chIsVASurgeon
        '
        Me.chIsVASurgeon.AutoSize = True
        Me.chIsVASurgeon.Location = New System.Drawing.Point(326, 17)
        Me.chIsVASurgeon.Name = "chIsVASurgeon"
        Me.chIsVASurgeon.Size = New System.Drawing.Size(111, 17)
        Me.chIsVASurgeon.TabIndex = 13
        Me.chIsVASurgeon.Text = "VA Post operation"
        Me.chIsVASurgeon.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblConsellingNo)
        Me.GroupBox2.Controls.Add(Me.lblDateConselling)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(326, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 55)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conselling info"
        '
        'lblConsellingNo
        '
        Me.lblConsellingNo.AutoSize = True
        Me.lblConsellingNo.Location = New System.Drawing.Point(203, 19)
        Me.lblConsellingNo.Name = "lblConsellingNo"
        Me.lblConsellingNo.Size = New System.Drawing.Size(13, 13)
        Me.lblConsellingNo.TabIndex = 13
        Me.lblConsellingNo.Text = "0"
        Me.lblConsellingNo.Visible = False
        '
        'lblDateConselling
        '
        Me.lblDateConselling.AutoSize = True
        Me.lblDateConselling.Location = New System.Drawing.Point(101, 22)
        Me.lblDateConselling.Name = "lblDateConselling"
        Me.lblDateConselling.Size = New System.Drawing.Size(13, 13)
        Me.lblDateConselling.TabIndex = 12
        Me.lblDateConselling.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Date Conselling:"
        '
        'FrmDateFollowUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chIsVASurgeon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupVASurgeon)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.DateDischarge)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDateFollowUP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date FollowUp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErDateFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupVASurgeon.ResumeLayout(False)
        Me.GroupVASurgeon.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateDischarge As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateFollowUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents LblDateLeave As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErDateFollowUp As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblPatientNo As System.Windows.Forms.Label
    Friend WithEvents GroupVASurgeon As System.Windows.Forms.GroupBox
    Friend WithEvents CboDrSurgeon As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboSurgeonOnEye As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CboVAPH As System.Windows.Forms.ComboBox
    Friend WithEvents CboVAPlain As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnNewVARefrac As System.Windows.Forms.Button
    Friend WithEvents chIsVASurgeon As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblConsellingNo As System.Windows.Forms.Label
    Friend WithEvents lblDateConselling As System.Windows.Forms.Label
End Class
