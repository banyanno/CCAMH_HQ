<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFastTracking
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFastTracking))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtClientAddress = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtClientContact = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtClientAge = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtClientSex = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtClientNameEng = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtClientNameKH = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnFindClient = New System.Windows.Forms.Button
        Me.TxtClientNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtRemark = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.CboCardLavel = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.DateNextVisit = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.CboTherapy = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DateFastTrack = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.DateLastFit = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.ErrTracking = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TxtClientDateDOR = New System.Windows.Forms.TextBox
        Me.BtnTherapy = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtClientDateDOR)
        Me.Panel1.Controls.Add(Me.TxtClientAddress)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtClientContact)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtClientAge)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtClientSex)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtClientNameEng)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtClientNameKH)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnFindClient)
        Me.Panel1.Controls.Add(Me.TxtClientNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 432)
        Me.Panel1.TabIndex = 0
        '
        'TxtClientAddress
        '
        Me.TxtClientAddress.BackColor = System.Drawing.Color.White
        Me.TxtClientAddress.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientAddress.Location = New System.Drawing.Point(8, 366)
        Me.TxtClientAddress.Multiline = True
        Me.TxtClientAddress.Name = "TxtClientAddress"
        Me.TxtClientAddress.ReadOnly = True
        Me.TxtClientAddress.Size = New System.Drawing.Size(216, 60)
        Me.TxtClientAddress.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 345)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "DOR:"
        '
        'TxtClientContact
        '
        Me.TxtClientContact.BackColor = System.Drawing.Color.White
        Me.TxtClientContact.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientContact.Location = New System.Drawing.Point(8, 310)
        Me.TxtClientContact.Name = "TxtClientContact"
        Me.TxtClientContact.ReadOnly = True
        Me.TxtClientContact.Size = New System.Drawing.Size(216, 32)
        Me.TxtClientContact.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 289)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Contact:"
        '
        'TxtClientAge
        '
        Me.TxtClientAge.BackColor = System.Drawing.Color.White
        Me.TxtClientAge.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientAge.Location = New System.Drawing.Point(131, 254)
        Me.TxtClientAge.Name = "TxtClientAge"
        Me.TxtClientAge.ReadOnly = True
        Me.TxtClientAge.Size = New System.Drawing.Size(93, 32)
        Me.TxtClientAge.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 231)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Age:"
        '
        'TxtClientSex
        '
        Me.TxtClientSex.BackColor = System.Drawing.Color.White
        Me.TxtClientSex.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientSex.Location = New System.Drawing.Point(8, 254)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(102, 32)
        Me.TxtClientSex.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 231)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sex:"
        '
        'TxtClientNameEng
        '
        Me.TxtClientNameEng.BackColor = System.Drawing.Color.White
        Me.TxtClientNameEng.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameEng.Location = New System.Drawing.Point(8, 195)
        Me.TxtClientNameEng.Name = "TxtClientNameEng"
        Me.TxtClientNameEng.ReadOnly = True
        Me.TxtClientNameEng.Size = New System.Drawing.Size(216, 32)
        Me.TxtClientNameEng.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 172)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Name Eng:"
        '
        'TxtClientNameKH
        '
        Me.TxtClientNameKH.BackColor = System.Drawing.Color.White
        Me.TxtClientNameKH.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameKH.Location = New System.Drawing.Point(8, 135)
        Me.TxtClientNameKH.Name = "TxtClientNameKH"
        Me.TxtClientNameKH.ReadOnly = True
        Me.TxtClientNameKH.Size = New System.Drawing.Size(216, 32)
        Me.TxtClientNameKH.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name Kh"
        '
        'BtnFindClient
        '
        Me.BtnFindClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindClient.FlatAppearance.BorderSize = 0
        Me.BtnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindClient.Image = CType(resources.GetObject("BtnFindClient.Image"), System.Drawing.Image)
        Me.BtnFindClient.Location = New System.Drawing.Point(227, 17)
        Me.BtnFindClient.Name = "BtnFindClient"
        Me.BtnFindClient.Size = New System.Drawing.Size(39, 34)
        Me.BtnFindClient.TabIndex = 2
        Me.BtnFindClient.UseVisualStyleBackColor = True
        '
        'TxtClientNo
        '
        Me.TxtClientNo.Location = New System.Drawing.Point(8, 27)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.Size = New System.Drawing.Size(216, 24)
        Me.TxtClientNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtRemark)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.BtnTherapy)
        Me.GroupBox1.Controls.Add(Me.CboCardLavel)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.DateNextVisit)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CboTherapy)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.DateFastTrack)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DateLastFit)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(303, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 437)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fast track details"
        '
        'TxtRemark
        '
        Me.TxtRemark.Location = New System.Drawing.Point(19, 240)
        Me.TxtRemark.Multiline = True
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(290, 167)
        Me.TxtRemark.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 211)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 18)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Remark"
        '
        'CboCardLavel
        '
        Me.CboCardLavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCardLavel.FormattingEnabled = True
        Me.CboCardLavel.Items.AddRange(New Object() {"", "A", "B", "C"})
        Me.CboCardLavel.Location = New System.Drawing.Point(163, 180)
        Me.CboCardLavel.Name = "CboCardLavel"
        Me.CboCardLavel.Size = New System.Drawing.Size(122, 26)
        Me.CboCardLavel.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(160, 157)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Card lavel:"
        '
        'DateNextVisit
        '
        Me.DateNextVisit.Checked = False
        Me.DateNextVisit.CustomFormat = "dd/MM/yyyy"
        Me.DateNextVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateNextVisit.Location = New System.Drawing.Point(19, 182)
        Me.DateNextVisit.Name = "DateNextVisit"
        Me.DateNextVisit.ShowCheckBox = True
        Me.DateNextVisit.Size = New System.Drawing.Size(132, 24)
        Me.DateNextVisit.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 158)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 18)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Next visit:"
        '
        'CboTherapy
        '
        Me.CboTherapy.FormattingEnabled = True
        Me.CboTherapy.Location = New System.Drawing.Point(19, 125)
        Me.CboTherapy.Name = "CboTherapy"
        Me.CboTherapy.Size = New System.Drawing.Size(265, 26)
        Me.CboTherapy.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 103)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Therapy Name"
        '
        'DateFastTrack
        '
        Me.DateFastTrack.Checked = False
        Me.DateFastTrack.CustomFormat = "dd/MM/yyyy"
        Me.DateFastTrack.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFastTrack.Location = New System.Drawing.Point(154, 76)
        Me.DateFastTrack.Name = "DateFastTrack"
        Me.DateFastTrack.ShowCheckBox = True
        Me.DateFastTrack.Size = New System.Drawing.Size(127, 24)
        Me.DateFastTrack.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(162, 48)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Date of fast track"
        '
        'DateLastFit
        '
        Me.DateLastFit.Checked = False
        Me.DateLastFit.CustomFormat = "dd/MM/yyyy"
        Me.DateLastFit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateLastFit.Location = New System.Drawing.Point(19, 76)
        Me.DateLastFit.Name = "DateLastFit"
        Me.DateLastFit.ShowCheckBox = True
        Me.DateLastFit.Size = New System.Drawing.Size(126, 24)
        Me.DateLastFit.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 48)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Date of last fit"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(437, 449)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(90, 36)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(533, 449)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 36)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(300, 457)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(16, 18)
        Me.LblSaveOption.TabIndex = 4
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'ErrTracking
        '
        Me.ErrTracking.ContainerControl = Me
        '
        'TxtClientDateDOR
        '
        Me.TxtClientDateDOR.BackColor = System.Drawing.Color.White
        Me.TxtClientDateDOR.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientDateDOR.Location = New System.Drawing.Point(8, 75)
        Me.TxtClientDateDOR.Name = "TxtClientDateDOR"
        Me.TxtClientDateDOR.ReadOnly = True
        Me.TxtClientDateDOR.Size = New System.Drawing.Size(216, 32)
        Me.TxtClientDateDOR.TabIndex = 17
        '
        'BtnTherapy
        '
        Me.BtnTherapy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTherapy.FlatAppearance.BorderSize = 0
        Me.BtnTherapy.Location = New System.Drawing.Point(293, 123)
        Me.BtnTherapy.Name = "BtnTherapy"
        Me.BtnTherapy.Size = New System.Drawing.Size(28, 28)
        Me.BtnTherapy.TabIndex = 2
        Me.BtnTherapy.Text = "..."
        Me.BtnTherapy.UseVisualStyleBackColor = True
        '
        'FormFastTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 490)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFastTracking"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fast Tracking"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrTracking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtClientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtClientSex As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNameEng As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNameKH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnFindClient As System.Windows.Forms.Button
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtClientContact As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtClientAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateFastTrack As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateLastFit As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CboTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents CboCardLavel As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateNextVisit As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ErrTracking As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtClientDateDOR As System.Windows.Forms.TextBox
    Friend WithEvents BtnTherapy As System.Windows.Forms.Button
End Class
