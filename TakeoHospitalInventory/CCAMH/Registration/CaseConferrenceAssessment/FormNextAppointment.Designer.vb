<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNextAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNextAppointment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFindClient = New System.Windows.Forms.Button()
        Me.TxtClientAge = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtClientSex = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtClientNameEng = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtClientNameKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnAddTherapist = New System.Windows.Forms.Button()
        Me.TxtAppointmentNote = New System.Windows.Forms.TextBox()
        Me.TimeAppointment = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateAppointment = New System.Windows.Forms.DateTimePicker()
        Me.CboMeetWith = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ErrNextAppointment = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveOption = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrNextAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFindClient)
        Me.GroupBox1.Controls.Add(Me.TxtClientAge)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtClientSex)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtClientNameEng)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtClientNameKH)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtClientNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client info"
        '
        'BtnFindClient
        '
        Me.BtnFindClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFindClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnFindClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindClient.Enabled = False
        Me.BtnFindClient.FlatAppearance.BorderSize = 0
        Me.BtnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFindClient.ForeColor = System.Drawing.Color.White
        Me.BtnFindClient.Location = New System.Drawing.Point(182, 56)
        Me.BtnFindClient.Name = "BtnFindClient"
        Me.BtnFindClient.Size = New System.Drawing.Size(31, 27)
        Me.BtnFindClient.TabIndex = 8
        Me.BtnFindClient.Text = "..."
        Me.BtnFindClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFindClient.UseVisualStyleBackColor = False
        '
        'TxtClientAge
        '
        Me.TxtClientAge.Location = New System.Drawing.Point(302, 56)
        Me.TxtClientAge.Name = "TxtClientAge"
        Me.TxtClientAge.ReadOnly = True
        Me.TxtClientAge.Size = New System.Drawing.Size(70, 26)
        Me.TxtClientAge.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(298, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Age:"
        '
        'TxtClientSex
        '
        Me.TxtClientSex.Location = New System.Drawing.Point(219, 56)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(61, 26)
        Me.TxtClientSex.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sex:"
        '
        'TxtClientNameEng
        '
        Me.TxtClientNameEng.Location = New System.Drawing.Point(183, 123)
        Me.TxtClientNameEng.Name = "TxtClientNameEng"
        Me.TxtClientNameEng.ReadOnly = True
        Me.TxtClientNameEng.Size = New System.Drawing.Size(189, 26)
        Me.TxtClientNameEng.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name Eng"
        '
        'TxtClientNameKH
        '
        Me.TxtClientNameKH.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameKH.Location = New System.Drawing.Point(10, 119)
        Me.TxtClientNameKH.Name = "TxtClientNameKH"
        Me.TxtClientNameKH.ReadOnly = True
        Me.TxtClientNameKH.Size = New System.Drawing.Size(167, 30)
        Me.TxtClientNameKH.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name Kh"
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Location = New System.Drawing.Point(10, 56)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.ReadOnly = True
        Me.TxtClientNo.Size = New System.Drawing.Size(167, 26)
        Me.TxtClientNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnAddTherapist)
        Me.GroupBox2.Controls.Add(Me.TxtAppointmentNote)
        Me.GroupBox2.Controls.Add(Me.TimeAppointment)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DateAppointment)
        Me.GroupBox2.Controls.Add(Me.CboMeetWith)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 282)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Appointment Detail:"
        '
        'BtnAddTherapist
        '
        Me.BtnAddTherapist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddTherapist.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAddTherapist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddTherapist.FlatAppearance.BorderSize = 0
        Me.BtnAddTherapist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddTherapist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddTherapist.ForeColor = System.Drawing.Color.White
        Me.BtnAddTherapist.Location = New System.Drawing.Point(193, 60)
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
        Me.TxtAppointmentNote.Location = New System.Drawing.Point(10, 181)
        Me.TxtAppointmentNote.Multiline = True
        Me.TxtAppointmentNote.Name = "TxtAppointmentNote"
        Me.TxtAppointmentNote.Size = New System.Drawing.Size(369, 94)
        Me.TxtAppointmentNote.TabIndex = 6
        '
        'TimeAppointment
        '
        Me.TimeAppointment.CustomFormat = "dd/MM/yyyy"
        Me.TimeAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeAppointment.Location = New System.Drawing.Point(193, 118)
        Me.TimeAppointment.Name = "TimeAppointment"
        Me.TimeAppointment.Size = New System.Drawing.Size(132, 26)
        Me.TimeAppointment.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(189, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Appointment note"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Date"
        '
        'DateAppointment
        '
        Me.DateAppointment.Checked = False
        Me.DateAppointment.CustomFormat = "dd/MM/yyyy"
        Me.DateAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAppointment.Location = New System.Drawing.Point(10, 118)
        Me.DateAppointment.Name = "DateAppointment"
        Me.DateAppointment.ShowCheckBox = True
        Me.DateAppointment.Size = New System.Drawing.Size(167, 26)
        Me.DateAppointment.TabIndex = 2
        '
        'CboMeetWith
        '
        Me.CboMeetWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboMeetWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboMeetWith.FormattingEnabled = True
        Me.CboMeetWith.Location = New System.Drawing.Point(10, 58)
        Me.CboMeetWith.Name = "CboMeetWith"
        Me.CboMeetWith.Size = New System.Drawing.Size(167, 28)
        Me.CboMeetWith.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Meet with "
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
        Me.btnClose.Location = New System.Drawing.Point(298, 467)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 37)
        Me.btnClose.TabIndex = 3
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
        Me.btnSave.Location = New System.Drawing.Point(189, 467)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 38)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ErrNextAppointment
        '
        Me.ErrNextAppointment.ContainerControl = Me
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(12, 475)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.LblSaveOption.TabIndex = 4
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'FormNextAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 509)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormNextAppointment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Next appointment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrNextAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtClientNameEng As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNameKH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtClientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtClientSex As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateAppointment As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboMeetWith As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TimeAppointment As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtAppointmentNote As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ErrNextAppointment As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnAddTherapist As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents BtnFindClient As System.Windows.Forms.Button
End Class
