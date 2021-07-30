<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReferDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReferDetail))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboTherapy = New System.Windows.Forms.ComboBox()
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnFinClient = New System.Windows.Forms.Button()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateNextVisit = New System.Windows.Forms.DateTimePicker()
        Me.BtnAddMoreRefer = New System.Windows.Forms.Button()
        Me.TxtReferToMoreInfo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateRefer = New System.Windows.Forms.DateTimePicker()
        Me.CboRefer = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblSaveOption = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ErrReferTo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrReferTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboTherapy)
        Me.GroupBox1.Controls.Add(Me.CboDiagnosis)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BtnFinClient)
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
        Me.GroupBox1.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(503, 219)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client info"
        '
        'CboTherapy
        '
        Me.CboTherapy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboTherapy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTherapy.FormattingEnabled = True
        Me.CboTherapy.Location = New System.Drawing.Point(270, 167)
        Me.CboTherapy.Name = "CboTherapy"
        Me.CboTherapy.Size = New System.Drawing.Size(226, 28)
        Me.CboTherapy.TabIndex = 13
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(9, 167)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(246, 28)
        Me.CboDiagnosis.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(268, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Therapy"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Diagnosis:"
        '
        'BtnFinClient
        '
        Me.BtnFinClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnFinClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinClient.FlatAppearance.BorderSize = 0
        Me.BtnFinClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFinClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinClient.ForeColor = System.Drawing.Color.White
        Me.BtnFinClient.Location = New System.Drawing.Point(267, 56)
        Me.BtnFinClient.Name = "BtnFinClient"
        Me.BtnFinClient.Size = New System.Drawing.Size(41, 29)
        Me.BtnFinClient.TabIndex = 8
        Me.BtnFinClient.Text = "..."
        Me.BtnFinClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFinClient.UseVisualStyleBackColor = False
        Me.BtnFinClient.Visible = False
        '
        'TxtClientAge
        '
        Me.TxtClientAge.Location = New System.Drawing.Point(420, 56)
        Me.TxtClientAge.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtClientAge.Name = "TxtClientAge"
        Me.TxtClientAge.ReadOnly = True
        Me.TxtClientAge.Size = New System.Drawing.Size(75, 26)
        Me.TxtClientAge.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(416, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Age:"
        '
        'TxtClientSex
        '
        Me.TxtClientSex.Location = New System.Drawing.Point(322, 56)
        Me.TxtClientSex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(60, 26)
        Me.TxtClientSex.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sex:"
        '
        'TxtClientNameEng
        '
        Me.TxtClientNameEng.Location = New System.Drawing.Point(267, 111)
        Me.TxtClientNameEng.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtClientNameEng.Name = "TxtClientNameEng"
        Me.TxtClientNameEng.ReadOnly = True
        Me.TxtClientNameEng.Size = New System.Drawing.Size(228, 26)
        Me.TxtClientNameEng.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name Eng"
        '
        'TxtClientNameKH
        '
        Me.TxtClientNameKH.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameKH.Location = New System.Drawing.Point(8, 109)
        Me.TxtClientNameKH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtClientNameKH.Name = "TxtClientNameKH"
        Me.TxtClientNameKH.ReadOnly = True
        Me.TxtClientNameKH.Size = New System.Drawing.Size(248, 30)
        Me.TxtClientNameKH.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name Kh"
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Location = New System.Drawing.Point(8, 59)
        Me.TxtClientNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.ReadOnly = True
        Me.TxtClientNo.Size = New System.Drawing.Size(248, 26)
        Me.TxtClientNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.DateNextVisit)
        Me.GroupBox2.Controls.Add(Me.BtnAddMoreRefer)
        Me.GroupBox2.Controls.Add(Me.TxtReferToMoreInfo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DateRefer)
        Me.GroupBox2.Controls.Add(Me.CboRefer)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(505, 271)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Referral detail"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(266, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Next Visit"
        '
        'DateNextVisit
        '
        Me.DateNextVisit.Checked = False
        Me.DateNextVisit.CustomFormat = "dd/MM/yyyy"
        Me.DateNextVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateNextVisit.Location = New System.Drawing.Point(268, 115)
        Me.DateNextVisit.Name = "DateNextVisit"
        Me.DateNextVisit.ShowCheckBox = True
        Me.DateNextVisit.Size = New System.Drawing.Size(229, 26)
        Me.DateNextVisit.TabIndex = 8
        '
        'BtnAddMoreRefer
        '
        Me.BtnAddMoreRefer.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAddMoreRefer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMoreRefer.FlatAppearance.BorderSize = 0
        Me.BtnAddMoreRefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMoreRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMoreRefer.ForeColor = System.Drawing.Color.White
        Me.BtnAddMoreRefer.Location = New System.Drawing.Point(268, 54)
        Me.BtnAddMoreRefer.Name = "BtnAddMoreRefer"
        Me.BtnAddMoreRefer.Size = New System.Drawing.Size(41, 29)
        Me.BtnAddMoreRefer.TabIndex = 7
        Me.BtnAddMoreRefer.Text = "..."
        Me.BtnAddMoreRefer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddMoreRefer.UseVisualStyleBackColor = False
        '
        'TxtReferToMoreInfo
        '
        Me.TxtReferToMoreInfo.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferToMoreInfo.Location = New System.Drawing.Point(11, 179)
        Me.TxtReferToMoreInfo.Multiline = True
        Me.TxtReferToMoreInfo.Name = "TxtReferToMoreInfo"
        Me.TxtReferToMoreInfo.Size = New System.Drawing.Size(485, 82)
        Me.TxtReferToMoreInfo.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Remark"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Date"
        '
        'DateRefer
        '
        Me.DateRefer.Checked = False
        Me.DateRefer.CustomFormat = "dd/MM/yyyy"
        Me.DateRefer.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRefer.Location = New System.Drawing.Point(12, 115)
        Me.DateRefer.Name = "DateRefer"
        Me.DateRefer.ShowCheckBox = True
        Me.DateRefer.Size = New System.Drawing.Size(246, 26)
        Me.DateRefer.TabIndex = 2
        '
        'CboRefer
        '
        Me.CboRefer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboRefer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRefer.FormattingEnabled = True
        Me.CboRefer.Location = New System.Drawing.Point(12, 55)
        Me.CboRefer.Name = "CboRefer"
        Me.CboRefer.Size = New System.Drawing.Size(246, 28)
        Me.CboRefer.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Referral to:"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(131, 508)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.LblSaveOption.TabIndex = 7
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
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
        Me.btnClose.Location = New System.Drawing.Point(411, 504)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 39)
        Me.btnClose.TabIndex = 6
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
        Me.btnSave.Location = New System.Drawing.Point(302, 504)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 40)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ErrReferTo
        '
        Me.ErrReferTo.ContainerControl = Me
        '
        'FormReferDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 549)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormReferDetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refer Detail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrReferTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtClientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtClientSex As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNameEng As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNameKH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtReferToMoreInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateRefer As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboRefer As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ErrReferTo As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnAddMoreRefer As System.Windows.Forms.Button
    Friend WithEvents BtnFinClient As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents CboTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateNextVisit As System.Windows.Forms.DateTimePicker
End Class
