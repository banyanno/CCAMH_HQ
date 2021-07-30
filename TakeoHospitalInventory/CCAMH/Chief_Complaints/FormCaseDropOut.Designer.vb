<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCaseDropOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCaseDropOut))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateDropOut = New System.Windows.Forms.DateTimePicker()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GroupDropOut = New System.Windows.Forms.GroupBox()
        Me.ChNotKNow = New System.Windows.Forms.CheckBox()
        Me.ChLongDistance = New System.Windows.Forms.CheckBox()
        Me.ChPoor = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDropOutRemark = New System.Windows.Forms.TextBox()
        Me.GroupClientIno = New System.Windows.Forms.GroupBox()
        Me.BtnFindClient = New System.Windows.Forms.Button()
        Me.TxtClientReferBy = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblSaveOption = New System.Windows.Forms.Label()
        Me.TxtClientLastVisit = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtClientTherapistName = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtClientNoOfVisit = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtReponeTherapy = New System.Windows.Forms.TextBox()
        Me.TxtClientDrug = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtClientDiagnosis = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtClientLiveWithWhom = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtClientTelephone = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtClientAddress = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtClientMotherEducation = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtClientFatherEducation = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtClientMotherOccupation = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtClientFatherOccupation = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtClientClassGrad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtClientOrderOfTheirSibling = New System.Windows.Forms.TextBox()
        Me.TxtClientOrderOf = New System.Windows.Forms.Label()
        Me.TxtClientNoOfSibling = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateClientRegister = New System.Windows.Forms.DateTimePicker()
        Me.TxtClientSex = New System.Windows.Forms.TextBox()
        Me.TxtClientAge = New System.Windows.Forms.TextBox()
        Me.TxtClientNameEng = New System.Windows.Forms.TextBox()
        Me.TxtClientNameKh = New System.Windows.Forms.TextBox()
        Me.TxtClientNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupStopVisit = New System.Windows.Forms.GroupBox()
        Me.ChReferTo = New System.Windows.Forms.CheckBox()
        Me.ChBackToSchool = New System.Windows.Forms.CheckBox()
        Me.ChTreatmentCompleted = New System.Windows.Forms.CheckBox()
        Me.ChRespite = New System.Windows.Forms.CheckBox()
        Me.RadDropOut = New System.Windows.Forms.RadioButton()
        Me.RadStopVisit = New System.Windows.Forms.RadioButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupDropOut.SuspendLayout()
        Me.GroupClientIno.SuspendLayout()
        Me.GroupStopVisit.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(572, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date Drop-Out or Stop Visit"
        '
        'DateDropOut
        '
        Me.DateDropOut.Checked = False
        Me.DateDropOut.CustomFormat = "dd/MM/yyyy"
        Me.DateDropOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDropOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDropOut.Location = New System.Drawing.Point(572, 50)
        Me.DateDropOut.Name = "DateDropOut"
        Me.DateDropOut.ShowCheckBox = True
        Me.DateDropOut.Size = New System.Drawing.Size(249, 30)
        Me.DateDropOut.TabIndex = 1
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
        Me.BtnSave.Location = New System.Drawing.Point(572, 603)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(118, 45)
        Me.BtnSave.TabIndex = 19
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(696, 603)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(118, 45)
        Me.BtnCancel.TabIndex = 20
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'GroupDropOut
        '
        Me.GroupDropOut.Controls.Add(Me.ChNotKNow)
        Me.GroupDropOut.Controls.Add(Me.ChLongDistance)
        Me.GroupDropOut.Controls.Add(Me.ChPoor)
        Me.GroupDropOut.Enabled = False
        Me.GroupDropOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDropOut.Location = New System.Drawing.Point(572, 108)
        Me.GroupDropOut.Name = "GroupDropOut"
        Me.GroupDropOut.Size = New System.Drawing.Size(395, 76)
        Me.GroupDropOut.TabIndex = 21
        Me.GroupDropOut.TabStop = False
        '
        'ChNotKNow
        '
        Me.ChNotKNow.AutoSize = True
        Me.ChNotKNow.Location = New System.Drawing.Point(230, 35)
        Me.ChNotKNow.Name = "ChNotKNow"
        Me.ChNotKNow.Size = New System.Drawing.Size(93, 22)
        Me.ChNotKNow.TabIndex = 24
        Me.ChNotKNow.Text = "Not Know"
        Me.ChNotKNow.UseVisualStyleBackColor = True
        '
        'ChLongDistance
        '
        Me.ChLongDistance.AutoSize = True
        Me.ChLongDistance.Location = New System.Drawing.Point(87, 35)
        Me.ChLongDistance.Name = "ChLongDistance"
        Me.ChLongDistance.Size = New System.Drawing.Size(123, 22)
        Me.ChLongDistance.TabIndex = 23
        Me.ChLongDistance.Text = "Long-Distance"
        Me.ChLongDistance.UseVisualStyleBackColor = True
        '
        'ChPoor
        '
        Me.ChPoor.AutoSize = True
        Me.ChPoor.Location = New System.Drawing.Point(6, 35)
        Me.ChPoor.Name = "ChPoor"
        Me.ChPoor.Size = New System.Drawing.Size(60, 22)
        Me.ChPoor.TabIndex = 22
        Me.ChPoor.Text = "Poor"
        Me.ChPoor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(576, 476)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Remark:"
        '
        'TxtDropOutRemark
        '
        Me.TxtDropOutRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDropOutRemark.Location = New System.Drawing.Point(575, 497)
        Me.TxtDropOutRemark.Multiline = True
        Me.TxtDropOutRemark.Name = "TxtDropOutRemark"
        Me.TxtDropOutRemark.Size = New System.Drawing.Size(395, 100)
        Me.TxtDropOutRemark.TabIndex = 23
        '
        'GroupClientIno
        '
        Me.GroupClientIno.Controls.Add(Me.BtnFindClient)
        Me.GroupClientIno.Controls.Add(Me.TxtClientReferBy)
        Me.GroupClientIno.Controls.Add(Me.Label8)
        Me.GroupClientIno.Controls.Add(Me.LblSaveOption)
        Me.GroupClientIno.Controls.Add(Me.TxtClientLastVisit)
        Me.GroupClientIno.Controls.Add(Me.Label26)
        Me.GroupClientIno.Controls.Add(Me.TxtClientTherapistName)
        Me.GroupClientIno.Controls.Add(Me.Label25)
        Me.GroupClientIno.Controls.Add(Me.TxtClientNoOfVisit)
        Me.GroupClientIno.Controls.Add(Me.Label24)
        Me.GroupClientIno.Controls.Add(Me.TxtClientDrug)
        Me.GroupClientIno.Controls.Add(Me.Label22)
        Me.GroupClientIno.Controls.Add(Me.TxtClientDiagnosis)
        Me.GroupClientIno.Controls.Add(Me.Label21)
        Me.GroupClientIno.Controls.Add(Me.TxtClientLiveWithWhom)
        Me.GroupClientIno.Controls.Add(Me.Label20)
        Me.GroupClientIno.Controls.Add(Me.TxtClientTelephone)
        Me.GroupClientIno.Controls.Add(Me.Label19)
        Me.GroupClientIno.Controls.Add(Me.TxtClientAddress)
        Me.GroupClientIno.Controls.Add(Me.Label18)
        Me.GroupClientIno.Controls.Add(Me.TxtClientMotherEducation)
        Me.GroupClientIno.Controls.Add(Me.Label16)
        Me.GroupClientIno.Controls.Add(Me.TxtClientFatherEducation)
        Me.GroupClientIno.Controls.Add(Me.Label17)
        Me.GroupClientIno.Controls.Add(Me.TxtClientMotherOccupation)
        Me.GroupClientIno.Controls.Add(Me.Label15)
        Me.GroupClientIno.Controls.Add(Me.TxtClientFatherOccupation)
        Me.GroupClientIno.Controls.Add(Me.Label14)
        Me.GroupClientIno.Controls.Add(Me.TxtClientClassGrad)
        Me.GroupClientIno.Controls.Add(Me.Label13)
        Me.GroupClientIno.Controls.Add(Me.TxtClientOrderOfTheirSibling)
        Me.GroupClientIno.Controls.Add(Me.TxtClientOrderOf)
        Me.GroupClientIno.Controls.Add(Me.TxtClientNoOfSibling)
        Me.GroupClientIno.Controls.Add(Me.Label11)
        Me.GroupClientIno.Controls.Add(Me.DateClientRegister)
        Me.GroupClientIno.Controls.Add(Me.TxtClientSex)
        Me.GroupClientIno.Controls.Add(Me.TxtClientAge)
        Me.GroupClientIno.Controls.Add(Me.TxtClientNameEng)
        Me.GroupClientIno.Controls.Add(Me.TxtClientNameKh)
        Me.GroupClientIno.Controls.Add(Me.TxtClientNo)
        Me.GroupClientIno.Controls.Add(Me.Label10)
        Me.GroupClientIno.Controls.Add(Me.Label7)
        Me.GroupClientIno.Controls.Add(Me.Label6)
        Me.GroupClientIno.Controls.Add(Me.Label5)
        Me.GroupClientIno.Controls.Add(Me.Label4)
        Me.GroupClientIno.Controls.Add(Me.Label3)
        Me.GroupClientIno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupClientIno.Location = New System.Drawing.Point(12, 10)
        Me.GroupClientIno.Name = "GroupClientIno"
        Me.GroupClientIno.Size = New System.Drawing.Size(554, 708)
        Me.GroupClientIno.TabIndex = 24
        Me.GroupClientIno.TabStop = False
        Me.GroupClientIno.Text = "Client Information"
        '
        'BtnFindClient
        '
        Me.BtnFindClient.Location = New System.Drawing.Point(236, 47)
        Me.BtnFindClient.Name = "BtnFindClient"
        Me.BtnFindClient.Size = New System.Drawing.Size(42, 28)
        Me.BtnFindClient.TabIndex = 49
        Me.BtnFindClient.Text = "..."
        Me.BtnFindClient.UseVisualStyleBackColor = True
        Me.BtnFindClient.Visible = False
        '
        'TxtClientReferBy
        '
        Me.TxtClientReferBy.BackColor = System.Drawing.Color.White
        Me.TxtClientReferBy.Location = New System.Drawing.Point(285, 47)
        Me.TxtClientReferBy.Name = "TxtClientReferBy"
        Me.TxtClientReferBy.ReadOnly = True
        Me.TxtClientReferBy.Size = New System.Drawing.Size(261, 26)
        Me.TxtClientReferBy.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(285, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Refer By:"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(177, 14)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.LblSaveOption.TabIndex = 46
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'TxtClientLastVisit
        '
        Me.TxtClientLastVisit.BackColor = System.Drawing.Color.White
        Me.TxtClientLastVisit.Location = New System.Drawing.Point(422, 219)
        Me.TxtClientLastVisit.Name = "TxtClientLastVisit"
        Me.TxtClientLastVisit.Size = New System.Drawing.Size(124, 26)
        Me.TxtClientLastVisit.TabIndex = 45
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(422, 196)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(78, 20)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "Last Visit:"
        '
        'TxtClientTherapistName
        '
        Me.TxtClientTherapistName.BackColor = System.Drawing.Color.White
        Me.TxtClientTherapistName.Location = New System.Drawing.Point(285, 499)
        Me.TxtClientTherapistName.Name = "TxtClientTherapistName"
        Me.TxtClientTherapistName.ReadOnly = True
        Me.TxtClientTherapistName.Size = New System.Drawing.Size(257, 26)
        Me.TxtClientTherapistName.TabIndex = 43
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(285, 476)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 20)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Therapist Name:"
        '
        'TxtClientNoOfVisit
        '
        Me.TxtClientNoOfVisit.BackColor = System.Drawing.Color.White
        Me.TxtClientNoOfVisit.Location = New System.Drawing.Point(7, 499)
        Me.TxtClientNoOfVisit.Name = "TxtClientNoOfVisit"
        Me.TxtClientNoOfVisit.ReadOnly = True
        Me.TxtClientNoOfVisit.Size = New System.Drawing.Size(257, 26)
        Me.TxtClientNoOfVisit.TabIndex = 41
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 476)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 20)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "No.of visit:"
        '
        'TxtReponeTherapy
        '
        Me.TxtReponeTherapy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReponeTherapy.Location = New System.Drawing.Point(572, 368)
        Me.TxtReponeTherapy.Multiline = True
        Me.TxtReponeTherapy.Name = "TxtReponeTherapy"
        Me.TxtReponeTherapy.Size = New System.Drawing.Size(398, 104)
        Me.TxtReponeTherapy.TabIndex = 39
        '
        'TxtClientDrug
        '
        Me.TxtClientDrug.Location = New System.Drawing.Point(6, 556)
        Me.TxtClientDrug.Multiline = True
        Me.TxtClientDrug.Name = "TxtClientDrug"
        Me.TxtClientDrug.Size = New System.Drawing.Size(257, 104)
        Me.TxtClientDrug.TabIndex = 37
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(572, 341)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(149, 20)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Respone to therapy"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 529)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 20)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Drug"
        '
        'TxtClientDiagnosis
        '
        Me.TxtClientDiagnosis.BackColor = System.Drawing.Color.White
        Me.TxtClientDiagnosis.Location = New System.Drawing.Point(285, 445)
        Me.TxtClientDiagnosis.Name = "TxtClientDiagnosis"
        Me.TxtClientDiagnosis.ReadOnly = True
        Me.TxtClientDiagnosis.Size = New System.Drawing.Size(257, 26)
        Me.TxtClientDiagnosis.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(285, 422)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 20)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Diagnosis:"
        '
        'TxtClientLiveWithWhom
        '
        Me.TxtClientLiveWithWhom.BackColor = System.Drawing.Color.White
        Me.TxtClientLiveWithWhom.Location = New System.Drawing.Point(7, 445)
        Me.TxtClientLiveWithWhom.Name = "TxtClientLiveWithWhom"
        Me.TxtClientLiveWithWhom.ReadOnly = True
        Me.TxtClientLiveWithWhom.Size = New System.Drawing.Size(257, 26)
        Me.TxtClientLiveWithWhom.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 422)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 20)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Living with whom?"
        '
        'TxtClientTelephone
        '
        Me.TxtClientTelephone.BackColor = System.Drawing.Color.White
        Me.TxtClientTelephone.Location = New System.Drawing.Point(285, 389)
        Me.TxtClientTelephone.Name = "TxtClientTelephone"
        Me.TxtClientTelephone.ReadOnly = True
        Me.TxtClientTelephone.Size = New System.Drawing.Size(257, 26)
        Me.TxtClientTelephone.TabIndex = 31
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(285, 366)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 20)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Telephone"
        '
        'TxtClientAddress
        '
        Me.TxtClientAddress.BackColor = System.Drawing.Color.White
        Me.TxtClientAddress.Location = New System.Drawing.Point(7, 389)
        Me.TxtClientAddress.Name = "TxtClientAddress"
        Me.TxtClientAddress.ReadOnly = True
        Me.TxtClientAddress.Size = New System.Drawing.Size(257, 26)
        Me.TxtClientAddress.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 366)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Address:"
        '
        'TxtClientMotherEducation
        '
        Me.TxtClientMotherEducation.BackColor = System.Drawing.Color.White
        Me.TxtClientMotherEducation.Location = New System.Drawing.Point(285, 333)
        Me.TxtClientMotherEducation.Name = "TxtClientMotherEducation"
        Me.TxtClientMotherEducation.ReadOnly = True
        Me.TxtClientMotherEducation.Size = New System.Drawing.Size(261, 26)
        Me.TxtClientMotherEducation.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(285, 310)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(148, 20)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Mother's education:"
        '
        'TxtClientFatherEducation
        '
        Me.TxtClientFatherEducation.BackColor = System.Drawing.Color.White
        Me.TxtClientFatherEducation.Location = New System.Drawing.Point(7, 333)
        Me.TxtClientFatherEducation.Name = "TxtClientFatherEducation"
        Me.TxtClientFatherEducation.ReadOnly = True
        Me.TxtClientFatherEducation.Size = New System.Drawing.Size(257, 26)
        Me.TxtClientFatherEducation.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 310)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(145, 20)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Father's education:"
        '
        'TxtClientMotherOccupation
        '
        Me.TxtClientMotherOccupation.BackColor = System.Drawing.Color.White
        Me.TxtClientMotherOccupation.Location = New System.Drawing.Point(285, 276)
        Me.TxtClientMotherOccupation.Name = "TxtClientMotherOccupation"
        Me.TxtClientMotherOccupation.ReadOnly = True
        Me.TxtClientMotherOccupation.Size = New System.Drawing.Size(261, 26)
        Me.TxtClientMotherOccupation.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(285, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 20)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Mother's occupation:"
        '
        'TxtClientFatherOccupation
        '
        Me.TxtClientFatherOccupation.BackColor = System.Drawing.Color.White
        Me.TxtClientFatherOccupation.Location = New System.Drawing.Point(7, 276)
        Me.TxtClientFatherOccupation.Name = "TxtClientFatherOccupation"
        Me.TxtClientFatherOccupation.ReadOnly = True
        Me.TxtClientFatherOccupation.Size = New System.Drawing.Size(257, 26)
        Me.TxtClientFatherOccupation.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 253)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 20)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Father's occupation:"
        '
        'TxtClientClassGrad
        '
        Me.TxtClientClassGrad.BackColor = System.Drawing.Color.White
        Me.TxtClientClassGrad.Location = New System.Drawing.Point(285, 219)
        Me.TxtClientClassGrad.Name = "TxtClientClassGrad"
        Me.TxtClientClassGrad.Size = New System.Drawing.Size(132, 26)
        Me.TxtClientClassGrad.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(285, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Class's grade:"
        '
        'TxtClientOrderOfTheirSibling
        '
        Me.TxtClientOrderOfTheirSibling.BackColor = System.Drawing.Color.White
        Me.TxtClientOrderOfTheirSibling.Location = New System.Drawing.Point(131, 219)
        Me.TxtClientOrderOfTheirSibling.Name = "TxtClientOrderOfTheirSibling"
        Me.TxtClientOrderOfTheirSibling.ReadOnly = True
        Me.TxtClientOrderOfTheirSibling.Size = New System.Drawing.Size(136, 26)
        Me.TxtClientOrderOfTheirSibling.TabIndex = 17
        '
        'TxtClientOrderOf
        '
        Me.TxtClientOrderOf.AutoSize = True
        Me.TxtClientOrderOf.Location = New System.Drawing.Point(131, 196)
        Me.TxtClientOrderOf.Name = "TxtClientOrderOf"
        Me.TxtClientOrderOf.Size = New System.Drawing.Size(154, 20)
        Me.TxtClientOrderOf.TabIndex = 16
        Me.TxtClientOrderOf.Text = "Order of their sibling:"
        '
        'TxtClientNoOfSibling
        '
        Me.TxtClientNoOfSibling.BackColor = System.Drawing.Color.White
        Me.TxtClientNoOfSibling.Location = New System.Drawing.Point(7, 219)
        Me.TxtClientNoOfSibling.Name = "TxtClientNoOfSibling"
        Me.TxtClientNoOfSibling.ReadOnly = True
        Me.TxtClientNoOfSibling.Size = New System.Drawing.Size(119, 26)
        Me.TxtClientNoOfSibling.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(285, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Date Register:"
        '
        'DateClientRegister
        '
        Me.DateClientRegister.CustomFormat = "dd/MM/yyyy"
        Me.DateClientRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateClientRegister.Location = New System.Drawing.Point(285, 161)
        Me.DateClientRegister.Name = "DateClientRegister"
        Me.DateClientRegister.Size = New System.Drawing.Size(261, 26)
        Me.DateClientRegister.TabIndex = 13
        '
        'TxtClientSex
        '
        Me.TxtClientSex.BackColor = System.Drawing.Color.White
        Me.TxtClientSex.Location = New System.Drawing.Point(131, 161)
        Me.TxtClientSex.Name = "TxtClientSex"
        Me.TxtClientSex.ReadOnly = True
        Me.TxtClientSex.Size = New System.Drawing.Size(136, 26)
        Me.TxtClientSex.TabIndex = 12
        '
        'TxtClientAge
        '
        Me.TxtClientAge.BackColor = System.Drawing.Color.White
        Me.TxtClientAge.Location = New System.Drawing.Point(7, 161)
        Me.TxtClientAge.Name = "TxtClientAge"
        Me.TxtClientAge.ReadOnly = True
        Me.TxtClientAge.Size = New System.Drawing.Size(119, 26)
        Me.TxtClientAge.TabIndex = 11
        '
        'TxtClientNameEng
        '
        Me.TxtClientNameEng.BackColor = System.Drawing.Color.White
        Me.TxtClientNameEng.Location = New System.Drawing.Point(285, 103)
        Me.TxtClientNameEng.Name = "TxtClientNameEng"
        Me.TxtClientNameEng.ReadOnly = True
        Me.TxtClientNameEng.Size = New System.Drawing.Size(261, 26)
        Me.TxtClientNameEng.TabIndex = 10
        '
        'TxtClientNameKh
        '
        Me.TxtClientNameKh.BackColor = System.Drawing.Color.White
        Me.TxtClientNameKh.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientNameKh.Location = New System.Drawing.Point(7, 103)
        Me.TxtClientNameKh.Name = "TxtClientNameKh"
        Me.TxtClientNameKh.ReadOnly = True
        Me.TxtClientNameKh.Size = New System.Drawing.Size(261, 30)
        Me.TxtClientNameKh.TabIndex = 9
        '
        'TxtClientNo
        '
        Me.TxtClientNo.BackColor = System.Drawing.Color.White
        Me.TxtClientNo.Location = New System.Drawing.Point(7, 48)
        Me.TxtClientNo.Name = "TxtClientNo"
        Me.TxtClientNo.ReadOnly = True
        Me.TxtClientNo.Size = New System.Drawing.Size(227, 26)
        Me.TxtClientNo.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Client No:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "No.of sibling:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Sex:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Client Name Eng:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Client Name KH:"
        '
        'GroupStopVisit
        '
        Me.GroupStopVisit.Controls.Add(Me.ChReferTo)
        Me.GroupStopVisit.Controls.Add(Me.ChBackToSchool)
        Me.GroupStopVisit.Controls.Add(Me.ChTreatmentCompleted)
        Me.GroupStopVisit.Controls.Add(Me.ChRespite)
        Me.GroupStopVisit.Enabled = False
        Me.GroupStopVisit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupStopVisit.Location = New System.Drawing.Point(572, 230)
        Me.GroupStopVisit.Name = "GroupStopVisit"
        Me.GroupStopVisit.Size = New System.Drawing.Size(395, 108)
        Me.GroupStopVisit.TabIndex = 25
        Me.GroupStopVisit.TabStop = False
        '
        'ChReferTo
        '
        Me.ChReferTo.AutoSize = True
        Me.ChReferTo.Location = New System.Drawing.Point(6, 69)
        Me.ChReferTo.Name = "ChReferTo"
        Me.ChReferTo.Size = New System.Drawing.Size(85, 22)
        Me.ChReferTo.TabIndex = 25
        Me.ChReferTo.Text = "Refer To"
        Me.ChReferTo.UseVisualStyleBackColor = True
        '
        'ChBackToSchool
        '
        Me.ChBackToSchool.AutoSize = True
        Me.ChBackToSchool.Location = New System.Drawing.Point(255, 35)
        Me.ChBackToSchool.Name = "ChBackToSchool"
        Me.ChBackToSchool.Size = New System.Drawing.Size(134, 22)
        Me.ChBackToSchool.TabIndex = 24
        Me.ChBackToSchool.Text = "Back To School"
        Me.ChBackToSchool.UseVisualStyleBackColor = True
        '
        'ChTreatmentCompleted
        '
        Me.ChTreatmentCompleted.AutoSize = True
        Me.ChTreatmentCompleted.Location = New System.Drawing.Point(87, 35)
        Me.ChTreatmentCompleted.Name = "ChTreatmentCompleted"
        Me.ChTreatmentCompleted.Size = New System.Drawing.Size(162, 22)
        Me.ChTreatmentCompleted.TabIndex = 23
        Me.ChTreatmentCompleted.Text = "Treatment Complete"
        Me.ChTreatmentCompleted.UseVisualStyleBackColor = True
        '
        'ChRespite
        '
        Me.ChRespite.AutoSize = True
        Me.ChRespite.Location = New System.Drawing.Point(6, 35)
        Me.ChRespite.Name = "ChRespite"
        Me.ChRespite.Size = New System.Drawing.Size(77, 22)
        Me.ChRespite.TabIndex = 22
        Me.ChRespite.Text = "Respite"
        Me.ChRespite.UseVisualStyleBackColor = True
        '
        'RadDropOut
        '
        Me.RadDropOut.AutoSize = True
        Me.RadDropOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropOut.Location = New System.Drawing.Point(572, 90)
        Me.RadDropOut.Name = "RadDropOut"
        Me.RadDropOut.Size = New System.Drawing.Size(159, 24)
        Me.RadDropOut.TabIndex = 26
        Me.RadDropOut.TabStop = True
        Me.RadDropOut.Text = "Droup-out Reason"
        Me.RadDropOut.UseVisualStyleBackColor = True
        '
        'RadStopVisit
        '
        Me.RadStopVisit.AutoSize = True
        Me.RadStopVisit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadStopVisit.Location = New System.Drawing.Point(576, 205)
        Me.RadStopVisit.Name = "RadStopVisit"
        Me.RadStopVisit.Size = New System.Drawing.Size(95, 24)
        Me.RadStopVisit.TabIndex = 27
        Me.RadStopVisit.TabStop = True
        Me.RadStopVisit.Text = "Stop Visit"
        Me.RadStopVisit.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormCaseDropOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 721)
        Me.Controls.Add(Me.RadStopVisit)
        Me.Controls.Add(Me.RadDropOut)
        Me.Controls.Add(Me.GroupStopVisit)
        Me.Controls.Add(Me.GroupClientIno)
        Me.Controls.Add(Me.TxtDropOutRemark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupDropOut)
        Me.Controls.Add(Me.DateDropOut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtReponeTherapy)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label23)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCaseDropOut"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Case Stop visit and  Drop Out"
        Me.GroupDropOut.ResumeLayout(False)
        Me.GroupDropOut.PerformLayout()
        Me.GroupClientIno.ResumeLayout(False)
        Me.GroupClientIno.PerformLayout()
        Me.GroupStopVisit.ResumeLayout(False)
        Me.GroupStopVisit.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateDropOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupDropOut As System.Windows.Forms.GroupBox
    Friend WithEvents ChNotKNow As System.Windows.Forms.CheckBox
    Friend WithEvents ChLongDistance As System.Windows.Forms.CheckBox
    Friend WithEvents ChPoor As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDropOutRemark As System.Windows.Forms.TextBox
    Friend WithEvents GroupClientIno As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientNameEng As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientNameKh As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateClientRegister As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtClientNoOfSibling As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientClassGrad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtClientOrderOfTheirSibling As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientOrderOf As System.Windows.Forms.Label
    Friend WithEvents TxtClientMotherEducation As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtClientFatherEducation As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtClientMotherOccupation As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtClientFatherOccupation As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtClientDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtClientLiveWithWhom As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtClientTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtClientAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtClientLastVisit As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtClientTherapistName As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtClientNoOfVisit As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtReponeTherapy As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtClientDrug As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents GroupStopVisit As System.Windows.Forms.GroupBox
    Friend WithEvents ChBackToSchool As System.Windows.Forms.CheckBox
    Friend WithEvents ChTreatmentCompleted As System.Windows.Forms.CheckBox
    Friend WithEvents ChRespite As System.Windows.Forms.CheckBox
    Friend WithEvents RadDropOut As System.Windows.Forms.RadioButton
    Friend WithEvents RadStopVisit As System.Windows.Forms.RadioButton
    Friend WithEvents ChReferTo As System.Windows.Forms.CheckBox
    Friend WithEvents TxtClientReferBy As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnFindClient As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
