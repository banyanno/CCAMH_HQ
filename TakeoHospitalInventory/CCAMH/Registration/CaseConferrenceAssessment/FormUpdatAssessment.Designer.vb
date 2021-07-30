<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdatAssessment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdatAssessment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAssessmentNote = New System.Windows.Forms.TextBox()
        Me.DateDoAssessment = New System.Windows.Forms.DateTimePicker()
        Me.CboAssessmentStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChDoAssessment = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtClientName = New System.Windows.Forms.TextBox()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.ErrAssessment = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BGSaveAndPrintReceipt = New System.ComponentModel.BackgroundWorker()
        Me.CboMainTherapy = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrAssessment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboMainTherapy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtAssessmentNote)
        Me.GroupBox1.Controls.Add(Me.DateDoAssessment)
        Me.GroupBox1.Controls.Add(Me.CboAssessmentStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ChDoAssessment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtClientName)
        Me.GroupBox1.Controls.Add(Me.TxtClientNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 416)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Assessment:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Assessment note:"
        '
        'TxtAssessmentNote
        '
        Me.TxtAssessmentNote.Location = New System.Drawing.Point(9, 325)
        Me.TxtAssessmentNote.Multiline = True
        Me.TxtAssessmentNote.Name = "TxtAssessmentNote"
        Me.TxtAssessmentNote.Size = New System.Drawing.Size(358, 80)
        Me.TxtAssessmentNote.TabIndex = 15
        '
        'DateDoAssessment
        '
        Me.DateDoAssessment.Checked = False
        Me.DateDoAssessment.CustomFormat = "dd/MM/yyyy"
        Me.DateDoAssessment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDoAssessment.Location = New System.Drawing.Point(182, 271)
        Me.DateDoAssessment.Name = "DateDoAssessment"
        Me.DateDoAssessment.ShowCheckBox = True
        Me.DateDoAssessment.Size = New System.Drawing.Size(185, 24)
        Me.DateDoAssessment.TabIndex = 14
        '
        'CboAssessmentStatus
        '
        Me.CboAssessmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAssessmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAssessmentStatus.FormattingEnabled = True
        Me.CboAssessmentStatus.Items.AddRange(New Object() {"", "Immediate", "Medium", "Later", "Free Consultation"})
        Me.CboAssessmentStatus.Location = New System.Drawing.Point(9, 267)
        Me.CboAssessmentStatus.Name = "CboAssessmentStatus"
        Me.CboAssessmentStatus.Size = New System.Drawing.Size(152, 28)
        Me.CboAssessmentStatus.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Appointment Ass-Date:"
        '
        'ChDoAssessment
        '
        Me.ChDoAssessment.AutoSize = True
        Me.ChDoAssessment.Location = New System.Drawing.Point(9, 213)
        Me.ChDoAssessment.Name = "ChDoAssessment"
        Me.ChDoAssessment.Size = New System.Drawing.Size(170, 22)
        Me.ChDoAssessment.TabIndex = 5
        Me.ChDoAssessment.Text = "Do detail assessment"
        Me.ChDoAssessment.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Assessment detail:"
        '
        'TxtClientName
        '
        Me.TxtClientName.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientName.Location = New System.Drawing.Point(9, 102)
        Me.TxtClientName.Name = "TxtClientName"
        Me.TxtClientName.ReadOnly = True
        Me.TxtClientName.Size = New System.Drawing.Size(278, 36)
        Me.TxtClientName.TabIndex = 3
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Location = New System.Drawing.Point(9, 54)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.ReadOnly = True
        Me.TxtClientNo.Size = New System.Drawing.Size(278, 24)
        Me.TxtClientNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client No:"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(218, 430)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 32)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(303, 430)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(79, 32)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrAssessment
        '
        Me.ErrAssessment.ContainerControl = Me
        '
        'CboMainTherapy
        '
        Me.CboMainTherapy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboMainTherapy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboMainTherapy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMainTherapy.FormattingEnabled = True
        Me.CboMainTherapy.Location = New System.Drawing.Point(9, 170)
        Me.CboMainTherapy.Name = "CboMainTherapy"
        Me.CboMainTherapy.Size = New System.Drawing.Size(278, 28)
        Me.CboMainTherapy.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Main Therapy"
        '
        'FormUpdatAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 468)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdatAssessment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update assessment:"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrAssessment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtClientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChDoAssessment As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboAssessmentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAssessmentNote As System.Windows.Forms.TextBox
    Friend WithEvents DateDoAssessment As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrAssessment As System.Windows.Forms.ErrorProvider
    Friend WithEvents BGSaveAndPrintReceipt As System.ComponentModel.BackgroundWorker
    Friend WithEvents CboMainTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
