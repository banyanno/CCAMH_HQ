<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateScreeningBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateScreeningBook))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ChIsOld = New System.Windows.Forms.CheckBox
        Me.ChSeeing = New System.Windows.Forms.CheckBox
        Me.ChPhysicalDisability = New System.Windows.Forms.CheckBox
        Me.ChUnderstanding = New System.Windows.Forms.CheckBox
        Me.ChHearing = New System.Windows.Forms.CheckBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupRefraction = New System.Windows.Forms.GroupBox
        Me.BtnMoreAdd = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtRefractNote = New System.Windows.Forms.TextBox
        Me.CboAdd = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CboLEPlusVARefrac = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CboREPlusVARefract = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtLEPlus = New System.Windows.Forms.TextBox
        Me.TxtREPlus = New System.Windows.Forms.TextBox
        Me.ChReferral = New System.Windows.Forms.CheckBox
        Me.ChOpticalshop = New System.Windows.Forms.CheckBox
        Me.ChRefraction = New System.Windows.Forms.CheckBox
        Me.GBReferral = New System.Windows.Forms.GroupBox
        Me.TxtReferMoreInfo = New System.Windows.Forms.TextBox
        Me.RadReferAndComeBySelf = New System.Windows.Forms.RadioButton
        Me.RadReferAndPickup = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.DateAppointment = New System.Windows.Forms.DateTimePicker
        Me.TxtPlaceScreening = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.BtnNewVA = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.DateScreening = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtMoreInfo = New System.Windows.Forms.TextBox
        Me.TxtComplain = New System.Windows.Forms.TextBox
        Me.CboVALeft = New System.Windows.Forms.ComboBox
        Me.CboVARight = New System.Windows.Forms.ComboBox
        Me.cboDiagnosis = New System.Windows.Forms.ComboBox
        Me.CboOnEye = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrUpdateScreen = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.VSForOpticalshop = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.GroupRefraction.SuspendLayout()
        Me.GBReferral.SuspendLayout()
        CType(Me.ErrUpdateScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupRefraction)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 661)
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
        Me.BtnClose.Location = New System.Drawing.Point(754, 616)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 37)
        Me.BtnClose.TabIndex = 1
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
        Me.BtnSave.Location = New System.Drawing.Point(648, 616)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 37)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.UiTab1)
        Me.Panel2.Controls.Add(Me.TxtPlaceScreening)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.BtnNewVA)
        Me.Panel2.Controls.Add(Me.LblSaveOption)
        Me.Panel2.Controls.Add(Me.DateScreening)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.TxtMoreInfo)
        Me.Panel2.Controls.Add(Me.TxtComplain)
        Me.Panel2.Controls.Add(Me.CboVALeft)
        Me.Panel2.Controls.Add(Me.CboVARight)
        Me.Panel2.Controls.Add(Me.cboDiagnosis)
        Me.Panel2.Controls.Add(Me.CboOnEye)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
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
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(7, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(848, 522)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ChIsOld)
        Me.Panel3.Controls.Add(Me.ChSeeing)
        Me.Panel3.Controls.Add(Me.ChPhysicalDisability)
        Me.Panel3.Controls.Add(Me.ChUnderstanding)
        Me.Panel3.Controls.Add(Me.ChHearing)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Location = New System.Drawing.Point(428, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 122)
        Me.Panel3.TabIndex = 28
        '
        'ChIsOld
        '
        Me.ChIsOld.AutoSize = True
        Me.ChIsOld.ForeColor = System.Drawing.Color.Red
        Me.ChIsOld.Location = New System.Drawing.Point(9, 92)
        Me.ChIsOld.Name = "ChIsOld"
        Me.ChIsOld.Size = New System.Drawing.Size(119, 24)
        Me.ChIsOld.TabIndex = 5
        Me.ChIsOld.Text = "Is old patient"
        Me.ChIsOld.UseVisualStyleBackColor = True
        '
        'ChSeeing
        '
        Me.ChSeeing.AutoSize = True
        Me.ChSeeing.Location = New System.Drawing.Point(190, 62)
        Me.ChSeeing.Name = "ChSeeing"
        Me.ChSeeing.Size = New System.Drawing.Size(78, 24)
        Me.ChSeeing.TabIndex = 4
        Me.ChSeeing.Text = "Seeing"
        Me.ChSeeing.UseVisualStyleBackColor = True
        '
        'ChPhysicalDisability
        '
        Me.ChPhysicalDisability.AutoSize = True
        Me.ChPhysicalDisability.Location = New System.Drawing.Point(9, 62)
        Me.ChPhysicalDisability.Name = "ChPhysicalDisability"
        Me.ChPhysicalDisability.Size = New System.Drawing.Size(151, 24)
        Me.ChPhysicalDisability.TabIndex = 3
        Me.ChPhysicalDisability.Text = "Physical Disability"
        Me.ChPhysicalDisability.UseVisualStyleBackColor = True
        '
        'ChUnderstanding
        '
        Me.ChUnderstanding.AutoSize = True
        Me.ChUnderstanding.Location = New System.Drawing.Point(190, 32)
        Me.ChUnderstanding.Name = "ChUnderstanding"
        Me.ChUnderstanding.Size = New System.Drawing.Size(214, 24)
        Me.ChUnderstanding.TabIndex = 2
        Me.ChUnderstanding.Text = "Understanding/Intellectual"
        Me.ChUnderstanding.UseVisualStyleBackColor = True
        '
        'ChHearing
        '
        Me.ChHearing.AutoSize = True
        Me.ChHearing.Location = New System.Drawing.Point(9, 32)
        Me.ChHearing.Name = "ChHearing"
        Me.ChHearing.Size = New System.Drawing.Size(84, 24)
        Me.ChHearing.TabIndex = 1
        Me.ChHearing.Text = "Hearing"
        Me.ChHearing.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(2, 2)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 25)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Difficulty"
        '
        'UiTab1
        '
        Me.UiTab1.FlatBorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.UiTab1.Location = New System.Drawing.Point(429, 146)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black
        Me.UiTab1.Size = New System.Drawing.Size(410, 366)
        Me.UiTab1.TabIndex = 27
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.ChReferral)
        Me.UiTabPage1.Controls.Add(Me.ChOpticalshop)
        Me.UiTabPage1.Controls.Add(Me.ChRefraction)
        Me.UiTabPage1.Controls.Add(Me.GBReferral)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(406, 335)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Fuction Untility"
        '
        'GroupRefraction
        '
        Me.GroupRefraction.Controls.Add(Me.BtnMoreAdd)
        Me.GroupRefraction.Controls.Add(Me.Label22)
        Me.GroupRefraction.Controls.Add(Me.Label23)
        Me.GroupRefraction.Controls.Add(Me.Label18)
        Me.GroupRefraction.Controls.Add(Me.TxtRefractNote)
        Me.GroupRefraction.Controls.Add(Me.CboAdd)
        Me.GroupRefraction.Controls.Add(Me.Label21)
        Me.GroupRefraction.Controls.Add(Me.CboLEPlusVARefrac)
        Me.GroupRefraction.Controls.Add(Me.Label20)
        Me.GroupRefraction.Controls.Add(Me.CboREPlusVARefract)
        Me.GroupRefraction.Controls.Add(Me.Label19)
        Me.GroupRefraction.Controls.Add(Me.TxtLEPlus)
        Me.GroupRefraction.Controls.Add(Me.TxtREPlus)
        Me.GroupRefraction.Enabled = False
        Me.GroupRefraction.Location = New System.Drawing.Point(16, 616)
        Me.GroupRefraction.Name = "GroupRefraction"
        Me.GroupRefraction.Size = New System.Drawing.Size(145, 48)
        Me.GroupRefraction.TabIndex = 1
        Me.GroupRefraction.TabStop = False
        Me.GroupRefraction.Text = "Refraction info"
        Me.GroupRefraction.Visible = False
        '
        'BtnMoreAdd
        '
        Me.BtnMoreAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnMoreAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMoreAdd.FlatAppearance.BorderSize = 0
        Me.BtnMoreAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMoreAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMoreAdd.ForeColor = System.Drawing.Color.White
        Me.BtnMoreAdd.Location = New System.Drawing.Point(353, 89)
        Me.BtnMoreAdd.Name = "BtnMoreAdd"
        Me.BtnMoreAdd.Size = New System.Drawing.Size(29, 29)
        Me.BtnMoreAdd.TabIndex = 5
        Me.BtnMoreAdd.Text = "..."
        Me.BtnMoreAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnMoreAdd.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 13)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "(RE) P+"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(7, 126)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 13)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "More Info:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 63
        Me.Label18.Text = "ADD"
        '
        'TxtRefractNote
        '
        Me.TxtRefractNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRefractNote.Location = New System.Drawing.Point(7, 149)
        Me.TxtRefractNote.Multiline = True
        Me.TxtRefractNote.Name = "TxtRefractNote"
        Me.TxtRefractNote.Size = New System.Drawing.Size(375, 72)
        Me.TxtRefractNote.TabIndex = 6
        '
        'CboAdd
        '
        Me.CboAdd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAdd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAdd.FormattingEnabled = True
        Me.CboAdd.Location = New System.Drawing.Point(92, 90)
        Me.CboAdd.Name = "CboAdd"
        Me.CboAdd.Size = New System.Drawing.Size(259, 21)
        Me.CboAdd.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(230, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "VA"
        '
        'CboLEPlusVARefrac
        '
        Me.CboLEPlusVARefrac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboLEPlusVARefrac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboLEPlusVARefrac.FormattingEnabled = True
        Me.CboLEPlusVARefrac.Location = New System.Drawing.Point(267, 56)
        Me.CboLEPlusVARefrac.Name = "CboLEPlusVARefrac"
        Me.CboLEPlusVARefrac.Size = New System.Drawing.Size(115, 21)
        Me.CboLEPlusVARefrac.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(230, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 13)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "VA"
        '
        'CboREPlusVARefract
        '
        Me.CboREPlusVARefract.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboREPlusVARefract.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboREPlusVARefract.FormattingEnabled = True
        Me.CboREPlusVARefract.Location = New System.Drawing.Point(267, 22)
        Me.CboREPlusVARefract.Name = "CboREPlusVARefract"
        Me.CboREPlusVARefract.Size = New System.Drawing.Size(115, 21)
        Me.CboREPlusVARefract.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "(LE) P+"
        '
        'TxtLEPlus
        '
        Me.TxtLEPlus.Location = New System.Drawing.Point(92, 58)
        Me.TxtLEPlus.Name = "TxtLEPlus"
        Me.TxtLEPlus.Size = New System.Drawing.Size(131, 20)
        Me.TxtLEPlus.TabIndex = 2
        '
        'TxtREPlus
        '
        Me.TxtREPlus.Location = New System.Drawing.Point(92, 24)
        Me.TxtREPlus.Name = "TxtREPlus"
        Me.TxtREPlus.Size = New System.Drawing.Size(131, 20)
        Me.TxtREPlus.TabIndex = 0
        '
        'ChReferral
        '
        Me.ChReferral.AutoSize = True
        Me.ChReferral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ChReferral.Location = New System.Drawing.Point(14, 14)
        Me.ChReferral.Name = "ChReferral"
        Me.ChReferral.Size = New System.Drawing.Size(68, 24)
        Me.ChReferral.TabIndex = 0
        Me.ChReferral.Text = "Refer"
        Me.ChReferral.UseVisualStyleBackColor = True
        '
        'ChOpticalshop
        '
        Me.ChOpticalshop.AutoSize = True
        Me.ChOpticalshop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ChOpticalshop.Location = New System.Drawing.Point(250, 14)
        Me.ChOpticalshop.Name = "ChOpticalshop"
        Me.ChOpticalshop.Size = New System.Drawing.Size(119, 24)
        Me.ChOpticalshop.TabIndex = 0
        Me.ChOpticalshop.Text = "Optical Shop"
        Me.ChOpticalshop.UseVisualStyleBackColor = True
        Me.ChOpticalshop.Visible = False
        '
        'ChRefraction
        '
        Me.ChRefraction.AutoSize = True
        Me.ChRefraction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ChRefraction.Location = New System.Drawing.Point(114, 14)
        Me.ChRefraction.Name = "ChRefraction"
        Me.ChRefraction.Size = New System.Drawing.Size(102, 24)
        Me.ChRefraction.TabIndex = 0
        Me.ChRefraction.Text = "Refraction"
        Me.ChRefraction.UseVisualStyleBackColor = True
        Me.ChRefraction.Visible = False
        '
        'GBReferral
        '
        Me.GBReferral.Controls.Add(Me.TxtReferMoreInfo)
        Me.GBReferral.Controls.Add(Me.RadReferAndComeBySelf)
        Me.GBReferral.Controls.Add(Me.RadReferAndPickup)
        Me.GBReferral.Controls.Add(Me.Label17)
        Me.GBReferral.Controls.Add(Me.Label16)
        Me.GBReferral.Controls.Add(Me.DateAppointment)
        Me.GBReferral.Enabled = False
        Me.GBReferral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GBReferral.Location = New System.Drawing.Point(5, 40)
        Me.GBReferral.Name = "GBReferral"
        Me.GBReferral.Size = New System.Drawing.Size(391, 292)
        Me.GBReferral.TabIndex = 1
        Me.GBReferral.TabStop = False
        Me.GBReferral.Text = "Refer info"
        '
        'TxtReferMoreInfo
        '
        Me.TxtReferMoreInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReferMoreInfo.Location = New System.Drawing.Point(11, 123)
        Me.TxtReferMoreInfo.Multiline = True
        Me.TxtReferMoreInfo.Name = "TxtReferMoreInfo"
        Me.TxtReferMoreInfo.Size = New System.Drawing.Size(372, 163)
        Me.TxtReferMoreInfo.TabIndex = 3
        '
        'RadReferAndComeBySelf
        '
        Me.RadReferAndComeBySelf.AutoSize = True
        Me.RadReferAndComeBySelf.Location = New System.Drawing.Point(190, 28)
        Me.RadReferAndComeBySelf.Name = "RadReferAndComeBySelf"
        Me.RadReferAndComeBySelf.Size = New System.Drawing.Size(167, 24)
        Me.RadReferAndComeBySelf.TabIndex = 1
        Me.RadReferAndComeBySelf.TabStop = True
        Me.RadReferAndComeBySelf.Text = "Refer Come By Self"
        Me.RadReferAndComeBySelf.UseVisualStyleBackColor = True
        '
        'RadReferAndPickup
        '
        Me.RadReferAndPickup.AutoSize = True
        Me.RadReferAndPickup.Location = New System.Drawing.Point(11, 28)
        Me.RadReferAndPickup.Name = "RadReferAndPickup"
        Me.RadReferAndPickup.Size = New System.Drawing.Size(140, 24)
        Me.RadReferAndPickup.TabIndex = 0
        Me.RadReferAndPickup.TabStop = True
        Me.RadReferAndPickup.Text = "Refer By Pickup"
        Me.RadReferAndPickup.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 20)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Date Appoint:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 20)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "More Info refer:"
        '
        'DateAppointment
        '
        Me.DateAppointment.Checked = False
        Me.DateAppointment.CustomFormat = "dd/MM/yyyy"
        Me.DateAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAppointment.Location = New System.Drawing.Point(124, 61)
        Me.DateAppointment.Name = "DateAppointment"
        Me.DateAppointment.ShowCheckBox = True
        Me.DateAppointment.Size = New System.Drawing.Size(136, 26)
        Me.DateAppointment.TabIndex = 2
        '
        'TxtPlaceScreening
        '
        Me.TxtPlaceScreening.BackColor = System.Drawing.Color.White
        Me.TxtPlaceScreening.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlaceScreening.Location = New System.Drawing.Point(99, 53)
        Me.TxtPlaceScreening.Name = "TxtPlaceScreening"
        Me.TxtPlaceScreening.Size = New System.Drawing.Size(290, 30)
        Me.TxtPlaceScreening.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 20)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Place:"
        '
        'BtnNewVA
        '
        Me.BtnNewVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnNewVA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewVA.FlatAppearance.BorderSize = 0
        Me.BtnNewVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewVA.ForeColor = System.Drawing.Color.White
        Me.BtnNewVA.Location = New System.Drawing.Point(394, 308)
        Me.BtnNewVA.Name = "BtnNewVA"
        Me.BtnNewVA.Size = New System.Drawing.Size(29, 29)
        Me.BtnNewVA.TabIndex = 10
        Me.BtnNewVA.Text = "..."
        Me.BtnNewVA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNewVA.UseVisualStyleBackColor = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(19, 192)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(18, 20)
        Me.LblSaveOption.TabIndex = 19
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'DateScreening
        '
        Me.DateScreening.CustomFormat = "dd/MM/yyyy"
        Me.DateScreening.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateScreening.Location = New System.Drawing.Point(99, 17)
        Me.DateScreening.Name = "DateScreening"
        Me.DateScreening.Size = New System.Drawing.Size(290, 26)
        Me.DateScreening.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Date:"
        '
        'TxtMoreInfo
        '
        Me.TxtMoreInfo.Location = New System.Drawing.Point(8, 450)
        Me.TxtMoreInfo.Multiline = True
        Me.TxtMoreInfo.Name = "TxtMoreInfo"
        Me.TxtMoreInfo.Size = New System.Drawing.Size(415, 62)
        Me.TxtMoreInfo.TabIndex = 12
        '
        'TxtComplain
        '
        Me.TxtComplain.Location = New System.Drawing.Point(8, 362)
        Me.TxtComplain.Multiline = True
        Me.TxtComplain.Name = "TxtComplain"
        Me.TxtComplain.Size = New System.Drawing.Size(415, 62)
        Me.TxtComplain.TabIndex = 11
        '
        'CboVALeft
        '
        Me.CboVALeft.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboVALeft.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboVALeft.FormattingEnabled = True
        Me.CboVALeft.Location = New System.Drawing.Point(252, 308)
        Me.CboVALeft.Name = "CboVALeft"
        Me.CboVALeft.Size = New System.Drawing.Size(137, 28)
        Me.CboVALeft.TabIndex = 9
        '
        'CboVARight
        '
        Me.CboVARight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboVARight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboVARight.FormattingEnabled = True
        Me.CboVARight.Location = New System.Drawing.Point(99, 308)
        Me.CboVARight.Name = "CboVARight"
        Me.CboVARight.Size = New System.Drawing.Size(133, 28)
        Me.CboVARight.TabIndex = 8
        '
        'cboDiagnosis
        '
        Me.cboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDiagnosis.FormattingEnabled = True
        Me.cboDiagnosis.Location = New System.Drawing.Point(99, 248)
        Me.cboDiagnosis.Name = "cboDiagnosis"
        Me.cboDiagnosis.Size = New System.Drawing.Size(292, 28)
        Me.cboDiagnosis.TabIndex = 7
        '
        'CboOnEye
        '
        Me.CboOnEye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboOnEye.FormattingEnabled = True
        Me.CboOnEye.Items.AddRange(New Object() {"", "Right Eye", "Left Eye", "Both Eye"})
        Me.CboOnEye.Location = New System.Drawing.Point(251, 192)
        Me.CboOnEye.Name = "CboOnEye"
        Me.CboOnEye.Size = New System.Drawing.Size(137, 28)
        Me.CboOnEye.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 427)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(268, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Management and Recommendation:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(256, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "VA Left"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 339)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Presenting-Complain"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(97, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "VA Right"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(97, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Diagnosis:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(302, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "On Eye:"
        '
        'PatientAge
        '
        Me.PatientAge.BackColor = System.Drawing.Color.LightGray
        Me.PatientAge.Location = New System.Drawing.Point(172, 194)
        Me.PatientAge.Name = "PatientAge"
        Me.PatientAge.ReadOnly = True
        Me.PatientAge.Size = New System.Drawing.Size(63, 26)
        Me.PatientAge.TabIndex = 5
        Me.PatientAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Age"
        '
        'PatientSex
        '
        Me.PatientSex.BackColor = System.Drawing.Color.LightGray
        Me.PatientSex.Location = New System.Drawing.Point(99, 194)
        Me.PatientSex.Name = "PatientSex"
        Me.PatientSex.ReadOnly = True
        Me.PatientSex.Size = New System.Drawing.Size(62, 26)
        Me.PatientSex.TabIndex = 4
        Me.PatientSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Sex:"
        '
        'PatientName
        '
        Me.PatientName.BackColor = System.Drawing.Color.LightGray
        Me.PatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientName.Location = New System.Drawing.Point(99, 131)
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        Me.PatientName.Size = New System.Drawing.Size(290, 30)
        Me.PatientName.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Name:"
        '
        'PatientNo
        '
        Me.PatientNo.BackColor = System.Drawing.Color.LightGray
        Me.PatientNo.Location = New System.Drawing.Point(99, 95)
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        Me.PatientNo.Size = New System.Drawing.Size(290, 26)
        Me.PatientNo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Patient No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(379, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Eye Screening"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(345, 41)
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
        Me.Label1.Location = New System.Drawing.Point(329, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "មន្ទីរពេទ្យ ភ្នែក តាកែវ"
        '
        'ErrUpdateScreen
        '
        Me.ErrUpdateScreen.ContainerControl = Me
        '
        'VSForOpticalshop
        '
        JanusColorScheme1.ActiveCaptionColor = System.Drawing.Color.Tomato
        JanusColorScheme1.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme1.ControlDarkColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(102, Byte), Integer))
        JanusColorScheme1.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        JanusColorScheme1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(67, Byte), Integer))
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme1.InfoColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme1.InfoTextColor = System.Drawing.Color.FloralWhite
        JanusColorScheme1.MenuColor = System.Drawing.SystemColors.ActiveCaption
        JanusColorScheme1.MenuTextColor = System.Drawing.Color.DimGray
        JanusColorScheme1.Name = "Header"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.DarkBlue
        Me.VSForOpticalshop.ColorSchemes.Add(JanusColorScheme1)
        Me.VSForOpticalshop.DefaultColorScheme = "Header"
        '
        'UpdateScreeningBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 661)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateScreeningBook"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateScreeningBook"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage1.PerformLayout()
        Me.GroupRefraction.ResumeLayout(False)
        Me.GroupRefraction.PerformLayout()
        Me.GBReferral.ResumeLayout(False)
        Me.GBReferral.PerformLayout()
        CType(Me.ErrUpdateScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PatientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PatientSex As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtMoreInfo As System.Windows.Forms.TextBox
    Friend WithEvents TxtComplain As System.Windows.Forms.TextBox
    Friend WithEvents CboVALeft As System.Windows.Forms.ComboBox
    Friend WithEvents CboVARight As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents CboOnEye As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateScreening As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents BtnNewVA As System.Windows.Forms.Button
    Friend WithEvents ErrUpdateScreen As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtPlaceScreening As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ChRefraction As System.Windows.Forms.CheckBox
    Friend WithEvents ChOpticalshop As System.Windows.Forms.CheckBox
    Friend WithEvents ChReferral As System.Windows.Forms.CheckBox
    Friend WithEvents GBReferral As System.Windows.Forms.GroupBox
    Friend WithEvents RadReferAndComeBySelf As System.Windows.Forms.RadioButton
    Friend WithEvents RadReferAndPickup As System.Windows.Forms.RadioButton
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents VSForOpticalshop As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents TxtReferMoreInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DateAppointment As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CboAdd As System.Windows.Forms.ComboBox
    Friend WithEvents CboLEPlusVARefrac As System.Windows.Forms.ComboBox
    Friend WithEvents CboREPlusVARefract As System.Windows.Forms.ComboBox
    Friend WithEvents TxtLEPlus As System.Windows.Forms.TextBox
    Friend WithEvents TxtREPlus As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtRefractNote As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupRefraction As System.Windows.Forms.GroupBox
    Friend WithEvents BtnMoreAdd As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ChIsOld As System.Windows.Forms.CheckBox
    Friend WithEvents ChSeeing As System.Windows.Forms.CheckBox
    Friend WithEvents ChPhysicalDisability As System.Windows.Forms.CheckBox
    Friend WithEvents ChUnderstanding As System.Windows.Forms.CheckBox
    Friend WithEvents ChHearing As System.Windows.Forms.CheckBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
