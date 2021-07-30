<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENT_REGISTRATION_FORM
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PROVINCE = New System.Windows.Forms.ComboBox
        Me.cbodistrict = New System.Windows.Forms.ComboBox
        Me.CLIENT_Main_Panel = New System.Windows.Forms.Panel
        Me.lblTtile = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblSibing = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.lblReferBy = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.lblBroghtBy = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.txtSibling = New System.Windows.Forms.TextBox
        Me.lblMale = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.lblFemale = New System.Windows.Forms.Label
        Me.txtFemale = New System.Windows.Forms.TextBox
        Me.lblPosition = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.lblDOB = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.lblDateSeen = New System.Windows.Forms.Label
        Me.dtpDateSeen = New System.Windows.Forms.DateTimePicker
        Me.lblSchoolGoing = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.CLIENT_Main_Panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(117, 468)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(132, 494)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PROVINCE
        '
        Me.PROVINCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROVINCE.FormattingEnabled = True
        Me.PROVINCE.Location = New System.Drawing.Point(251, 468)
        Me.PROVINCE.Name = "PROVINCE"
        Me.PROVINCE.Size = New System.Drawing.Size(160, 26)
        Me.PROVINCE.TabIndex = 2
        '
        'cbodistrict
        '
        Me.cbodistrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodistrict.FormattingEnabled = True
        Me.cbodistrict.Location = New System.Drawing.Point(433, 468)
        Me.cbodistrict.Name = "cbodistrict"
        Me.cbodistrict.Size = New System.Drawing.Size(160, 26)
        Me.cbodistrict.TabIndex = 3
        '
        'CLIENT_Main_Panel
        '
        Me.CLIENT_Main_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CLIENT_Main_Panel.Controls.Add(Me.lblTtile)
        Me.CLIENT_Main_Panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENT_Main_Panel.ForeColor = System.Drawing.Color.Blue
        Me.CLIENT_Main_Panel.Location = New System.Drawing.Point(-1, 1)
        Me.CLIENT_Main_Panel.Name = "CLIENT_Main_Panel"
        Me.CLIENT_Main_Panel.Size = New System.Drawing.Size(991, 452)
        Me.CLIENT_Main_Panel.TabIndex = 4
        '
        'lblTtile
        '
        Me.lblTtile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTtile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTtile.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtile.Location = New System.Drawing.Point(-1, 0)
        Me.lblTtile.Name = "lblTtile"
        Me.lblTtile.Size = New System.Drawing.Size(991, 39)
        Me.lblTtile.TabIndex = 0
        Me.lblTtile.Text = "NEW PATIENT REGISTRATION"
        Me.lblTtile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblSchoolGoing)
        Me.Panel1.Controls.Add(Me.dtpDateSeen)
        Me.Panel1.Controls.Add(Me.lblDateSeen)
        Me.Panel1.Controls.Add(Me.dtpDOB)
        Me.Panel1.Controls.Add(Me.lblDOB)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.lblPosition)
        Me.Panel1.Controls.Add(Me.txtFemale)
        Me.Panel1.Controls.Add(Me.lblFemale)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.lblMale)
        Me.Panel1.Controls.Add(Me.txtSibling)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.lblSibing)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.lblReferBy)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.lblBroghtBy)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 226)
        Me.Panel1.TabIndex = 5
        '
        'lblSibing
        '
        Me.lblSibing.AutoSize = True
        Me.lblSibing.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSibing.Location = New System.Drawing.Point(12, 80)
        Me.lblSibing.Name = "lblSibing"
        Me.lblSibing.Size = New System.Drawing.Size(63, 18)
        Me.lblSibing.TabIndex = 9
        Me.lblSibing.Text = "Sibling:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(822, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Age:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Location = New System.Drawing.Point(597, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 30)
        Me.Panel2.TabIndex = 7
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Location = New System.Drawing.Point(96, 3)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(58, 22)
        Me.rdbMale.TabIndex = 1
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Checked = True
        Me.rdbFemale.Location = New System.Drawing.Point(3, 3)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(75, 22)
        Me.rdbFemale.TabIndex = 0
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(539, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sex:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(103, 39)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(395, 24)
        Me.TextBox4.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 39)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 18)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(597, 6)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(380, 24)
        Me.TextBox3.TabIndex = 3
        '
        'lblReferBy
        '
        Me.lblReferBy.AutoSize = True
        Me.lblReferBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferBy.Location = New System.Drawing.Point(507, 6)
        Me.lblReferBy.Name = "lblReferBy"
        Me.lblReferBy.Size = New System.Drawing.Size(78, 18)
        Me.lblReferBy.TabIndex = 2
        Me.lblReferBy.Text = "Refer By:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(103, 9)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(395, 24)
        Me.TextBox2.TabIndex = 1
        '
        'lblBroghtBy
        '
        Me.lblBroghtBy.AutoSize = True
        Me.lblBroghtBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBroghtBy.Location = New System.Drawing.Point(2, 9)
        Me.lblBroghtBy.Name = "lblBroghtBy"
        Me.lblBroghtBy.Size = New System.Drawing.Size(96, 18)
        Me.lblBroghtBy.TabIndex = 0
        Me.lblBroghtBy.Text = "Brought By:"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(907, 487)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 36)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(865, 41)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(77, 24)
        Me.txtAge.TabIndex = 10
        '
        'txtSibling
        '
        Me.txtSibling.Location = New System.Drawing.Point(103, 74)
        Me.txtSibling.Name = "txtSibling"
        Me.txtSibling.Size = New System.Drawing.Size(104, 24)
        Me.txtSibling.TabIndex = 11
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.Location = New System.Drawing.Point(234, 80)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(49, 18)
        Me.lblMale.TabIndex = 12
        Me.lblMale.Text = "Male:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(311, 74)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 24)
        Me.TextBox5.TabIndex = 13
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.Location = New System.Drawing.Point(446, 81)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(68, 18)
        Me.lblFemale.TabIndex = 14
        Me.lblFemale.Text = "Female:"
        '
        'txtFemale
        '
        Me.txtFemale.Location = New System.Drawing.Point(542, 77)
        Me.txtFemale.Name = "txtFemale"
        Me.txtFemale.Size = New System.Drawing.Size(102, 24)
        Me.txtFemale.TabIndex = 15
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(676, 83)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(75, 18)
        Me.lblPosition.TabIndex = 16
        Me.lblPosition.Text = "Position:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(749, 74)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(228, 44)
        Me.TextBox6.TabIndex = 17
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(20, 124)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(49, 18)
        Me.lblDOB.TabIndex = 18
        Me.lblDOB.Text = "DOB:"
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(103, 119)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(240, 24)
        Me.dtpDOB.TabIndex = 19
        '
        'lblDateSeen
        '
        Me.lblDateSeen.AutoSize = True
        Me.lblDateSeen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateSeen.Location = New System.Drawing.Point(433, 125)
        Me.lblDateSeen.Name = "lblDateSeen"
        Me.lblDateSeen.Size = New System.Drawing.Size(91, 18)
        Me.lblDateSeen.TabIndex = 20
        Me.lblDateSeen.Text = "Date Seen:"
        '
        'dtpDateSeen
        '
        Me.dtpDateSeen.Location = New System.Drawing.Point(542, 124)
        Me.dtpDateSeen.Name = "dtpDateSeen"
        Me.dtpDateSeen.Size = New System.Drawing.Size(243, 24)
        Me.dtpDateSeen.TabIndex = 21
        '
        'lblSchoolGoing
        '
        Me.lblSchoolGoing.AutoSize = True
        Me.lblSchoolGoing.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolGoing.Location = New System.Drawing.Point(3, 163)
        Me.lblSchoolGoing.Name = "lblSchoolGoing"
        Me.lblSchoolGoing.Size = New System.Drawing.Size(116, 18)
        Me.lblSchoolGoing.TabIndex = 22
        Me.lblSchoolGoing.Text = "School Going:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(381, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Level of Education:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(542, 163)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(435, 24)
        Me.TextBox7.TabIndex = 24
        '
        'CLIENT_REGISTRATION_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 529)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CLIENT_Main_Panel)
        Me.Controls.Add(Me.cbodistrict)
        Me.Controls.Add(Me.PROVINCE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CLIENT_REGISTRATION_FORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENT REGISTRATION"
        Me.CLIENT_Main_Panel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PROVINCE As System.Windows.Forms.ComboBox
    Friend WithEvents cbodistrict As System.Windows.Forms.ComboBox
    Friend WithEvents CLIENT_Main_Panel As System.Windows.Forms.Panel
    Friend WithEvents lblTtile As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblReferBy As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblBroghtBy As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblSibing As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtFemale As System.Windows.Forms.TextBox
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents lblMale As System.Windows.Forms.Label
    Friend WithEvents txtSibling As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateSeen As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateSeen As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents lblSchoolGoing As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
