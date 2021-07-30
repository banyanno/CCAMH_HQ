<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFillInDiagnosis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFillInDiagnosis))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblDiagnosisID = New System.Windows.Forms.Label()
        Me.LblImpression = New System.Windows.Forms.Label()
        Me.LblSaveOption = New System.Windows.Forms.Label()
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtClientName = New System.Windows.Forms.TextBox()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.ErrFillInDiagnosis = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CboAppointStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupNextApp = New System.Windows.Forms.GroupBox()
        Me.BtnAddTherapist = New System.Windows.Forms.Button()
        Me.TxtAppointmentNote = New System.Windows.Forms.TextBox()
        Me.TimeAppointment = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateAppointment = New System.Windows.Forms.DateTimePicker()
        Me.CboMeetWith = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChNextAppointment = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrFillInDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNextApp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblDiagnosisID)
        Me.Panel1.Controls.Add(Me.LblImpression)
        Me.Panel1.Controls.Add(Me.LblSaveOption)
        Me.Panel1.Controls.Add(Me.CboDiagnosis)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtClientName)
        Me.Panel1.Controls.Add(Me.TxtClientNo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(5, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 183)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Impression:"
        '
        'LblDiagnosisID
        '
        Me.LblDiagnosisID.AutoSize = True
        Me.LblDiagnosisID.Location = New System.Drawing.Point(292, 150)
        Me.LblDiagnosisID.Name = "LblDiagnosisID"
        Me.LblDiagnosisID.Size = New System.Drawing.Size(16, 17)
        Me.LblDiagnosisID.TabIndex = 4
        Me.LblDiagnosisID.Text = "0"
        Me.LblDiagnosisID.Visible = False
        '
        'LblImpression
        '
        Me.LblImpression.AutoSize = True
        Me.LblImpression.Location = New System.Drawing.Point(10, 146)
        Me.LblImpression.Name = "LblImpression"
        Me.LblImpression.Size = New System.Drawing.Size(13, 17)
        Me.LblImpression.TabIndex = 4
        Me.LblImpression.Text = "-"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(240, 150)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(16, 17)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(10, 94)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(301, 28)
        Me.CboDiagnosis.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select Diagnosis:"
        '
        'TxtClientName
        '
        Me.TxtClientName.BackColor = System.Drawing.Color.White
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(152, 36)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.ReadOnly = True
        Me.TxtClientName.Size = New System.Drawing.Size(159, 30)
        Me.TxtClientName.TabIndex = 3
        '
        'TxtClientNo
        '
        Me.TxtClientNo.BackColor = System.Drawing.Color.White
        Me.TxtClientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNo.Location = New System.Drawing.Point(9, 36)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.ReadOnly = True
        Me.TxtClientNo.Size = New System.Drawing.Size(137, 29)
        Me.TxtClientNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client No:"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(140, 476)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(90, 32)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(236, 476)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 32)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'ErrFillInDiagnosis
        '
        Me.ErrFillInDiagnosis.ContainerControl = Me
        '
        'CboAppointStatus
        '
        Me.CboAppointStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAppointStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAppointStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAppointStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAppointStatus.FormattingEnabled = True
        Me.CboAppointStatus.Items.AddRange(New Object() {"", "Regular", "Irregular"})
        Me.CboAppointStatus.Location = New System.Drawing.Point(193, 212)
        Me.CboAppointStatus.Name = "CboAppointStatus"
        Me.CboAppointStatus.Size = New System.Drawing.Size(133, 28)
        Me.CboAppointStatus.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(193, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Appointment status"
        '
        'GroupNextApp
        '
        Me.GroupNextApp.Controls.Add(Me.BtnAddTherapist)
        Me.GroupNextApp.Controls.Add(Me.TxtAppointmentNote)
        Me.GroupNextApp.Controls.Add(Me.TimeAppointment)
        Me.GroupNextApp.Controls.Add(Me.Label8)
        Me.GroupNextApp.Controls.Add(Me.Label9)
        Me.GroupNextApp.Controls.Add(Me.Label7)
        Me.GroupNextApp.Controls.Add(Me.DateAppointment)
        Me.GroupNextApp.Controls.Add(Me.CboMeetWith)
        Me.GroupNextApp.Controls.Add(Me.Label6)
        Me.GroupNextApp.Enabled = False
        Me.GroupNextApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupNextApp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupNextApp.Location = New System.Drawing.Point(5, 247)
        Me.GroupNextApp.Name = "GroupNextApp"
        Me.GroupNextApp.Size = New System.Drawing.Size(319, 223)
        Me.GroupNextApp.TabIndex = 8
        Me.GroupNextApp.TabStop = False
        Me.GroupNextApp.Text = "Appointment Detail:"
        '
        'BtnAddTherapist
        '
        Me.BtnAddTherapist.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAddTherapist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddTherapist.FlatAppearance.BorderSize = 0
        Me.BtnAddTherapist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddTherapist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddTherapist.ForeColor = System.Drawing.Color.White
        Me.BtnAddTherapist.Location = New System.Drawing.Point(285, 44)
        Me.BtnAddTherapist.Name = "BtnAddTherapist"
        Me.BtnAddTherapist.Size = New System.Drawing.Size(31, 27)
        Me.BtnAddTherapist.TabIndex = 7
        Me.BtnAddTherapist.Text = "..."
        Me.BtnAddTherapist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddTherapist.UseVisualStyleBackColor = False
        '
        'TxtAppointmentNote
        '
        Me.TxtAppointmentNote.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppointmentNote.Location = New System.Drawing.Point(7, 153)
        Me.TxtAppointmentNote.Multiline = True
        Me.TxtAppointmentNote.Name = "TxtAppointmentNote"
        Me.TxtAppointmentNote.Size = New System.Drawing.Size(305, 63)
        Me.TxtAppointmentNote.TabIndex = 6
        '
        'TimeAppointment
        '
        Me.TimeAppointment.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeAppointment.CustomFormat = "dd/MM/yyyy"
        Me.TimeAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeAppointment.Location = New System.Drawing.Point(169, 101)
        Me.TimeAppointment.Name = "TimeAppointment"
        Me.TimeAppointment.Size = New System.Drawing.Size(107, 24)
        Me.TimeAppointment.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Appointment note"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Date"
        '
        'DateAppointment
        '
        Me.DateAppointment.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAppointment.Checked = False
        Me.DateAppointment.CustomFormat = "dd/MM/yyyy"
        Me.DateAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAppointment.Location = New System.Drawing.Point(9, 101)
        Me.DateAppointment.Name = "DateAppointment"
        Me.DateAppointment.ShowCheckBox = True
        Me.DateAppointment.Size = New System.Drawing.Size(137, 24)
        Me.DateAppointment.TabIndex = 2
        '
        'CboMeetWith
        '
        Me.CboMeetWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboMeetWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboMeetWith.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMeetWith.FormattingEnabled = True
        Me.CboMeetWith.Location = New System.Drawing.Point(12, 44)
        Me.CboMeetWith.Name = "CboMeetWith"
        Me.CboMeetWith.Size = New System.Drawing.Size(268, 28)
        Me.CboMeetWith.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Meet with "
        '
        'ChNextAppointment
        '
        Me.ChNextAppointment.AutoSize = True
        Me.ChNextAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChNextAppointment.Location = New System.Drawing.Point(7, 216)
        Me.ChNextAppointment.Name = "ChNextAppointment"
        Me.ChNextAppointment.Size = New System.Drawing.Size(165, 24)
        Me.ChNextAppointment.TabIndex = 9
        Me.ChNextAppointment.Text = "Have next apppoint"
        Me.ChNextAppointment.UseVisualStyleBackColor = True
        '
        'FormFillInDiagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 511)
        Me.Controls.Add(Me.ChNextAppointment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupNextApp)
        Me.Controls.Add(Me.CboAppointStatus)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFillInDiagnosis"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fill in diagnosis"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrFillInDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNextApp.ResumeLayout(False)
        Me.GroupNextApp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtClientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrFillInDiagnosis As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblDiagnosisID As System.Windows.Forms.Label
    Friend WithEvents LblImpression As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboAppointStatus As System.Windows.Forms.ComboBox
    Friend WithEvents GroupNextApp As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAddTherapist As System.Windows.Forms.Button
    Friend WithEvents TxtAppointmentNote As System.Windows.Forms.TextBox
    Friend WithEvents TimeAppointment As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateAppointment As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboMeetWith As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChNextAppointment As System.Windows.Forms.CheckBox
End Class
