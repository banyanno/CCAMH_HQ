<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainPoMoSypo
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
        Dim GridPatientMoPoTsyo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainPoMoSypo))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SplitMain = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GrpTypeDR = New System.Windows.Forms.GroupBox
        Me.LblNotFill = New System.Windows.Forms.Label
        Me.LblFill = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictLoading = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GrpDiagnosis = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GrpDiabete = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateMoTo = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.DateMoFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.SplitListMoPoTysoAndReport = New System.Windows.Forms.SplitContainer
        Me.GridPatientMoPoTsyo = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewMoPotsyo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEnterMPC = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BGMoPoTsyo = New System.ComponentModel.BackgroundWorker
        Me.DataMoPoTsyo = New KTGSYS.DataMoPoTsyo
        Me.V_MoPoTysoTableAdapter = New KTGSYS.DataMoPoTsyoTableAdapters.V_MoPoTysoTableAdapter
        Me.GroupBox2.SuspendLayout()
        Me.SplitMain.Panel1.SuspendLayout()
        Me.SplitMain.Panel2.SuspendLayout()
        Me.SplitMain.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GrpTypeDR.SuspendLayout()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDiagnosis.SuspendLayout()
        Me.GrpDiabete.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SplitListMoPoTysoAndReport.Panel1.SuspendLayout()
        Me.SplitListMoPoTysoAndReport.Panel2.SuspendLayout()
        Me.SplitListMoPoTysoAndReport.SuspendLayout()
        CType(Me.GridPatientMoPoTsyo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataMoPoTsyo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SplitMain)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(963, 753)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patients Mo.Po.Tsyo NGO got eye check at Takeo Eye Hospital"
        '
        'SplitMain
        '
        Me.SplitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitMain.Location = New System.Drawing.Point(2, 26)
        Me.SplitMain.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SplitMain.Name = "SplitMain"
        '
        'SplitMain.Panel1
        '
        Me.SplitMain.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitMain.Panel2
        '
        Me.SplitMain.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitMain.Size = New System.Drawing.Size(959, 724)
        Me.SplitMain.SplitterDistance = 272
        Me.SplitMain.SplitterWidth = 3
        Me.SplitMain.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.Splitter1)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(272, 724)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GrpTypeDR)
        Me.GroupBox6.Controls.Add(Me.GrpDiagnosis)
        Me.GroupBox6.Controls.Add(Me.GrpDiabete)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Khmer OS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(2, 212)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox6.Size = New System.Drawing.Size(268, 509)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "សំគាល់"
        '
        'GrpTypeDR
        '
        Me.GrpTypeDR.Controls.Add(Me.LblNotFill)
        Me.GrpTypeDR.Controls.Add(Me.LblFill)
        Me.GrpTypeDR.Controls.Add(Me.Label5)
        Me.GrpTypeDR.Controls.Add(Me.Label4)
        Me.GrpTypeDR.Controls.Add(Me.PictLoading)
        Me.GrpTypeDR.Controls.Add(Me.Label21)
        Me.GrpTypeDR.Controls.Add(Me.Label19)
        Me.GrpTypeDR.Controls.Add(Me.Label18)
        Me.GrpTypeDR.Controls.Add(Me.Label17)
        Me.GrpTypeDR.Controls.Add(Me.Label16)
        Me.GrpTypeDR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpTypeDR.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpTypeDR.Location = New System.Drawing.Point(2, 225)
        Me.GrpTypeDR.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GrpTypeDR.Name = "GrpTypeDR"
        Me.GrpTypeDR.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GrpTypeDR.Size = New System.Drawing.Size(264, 281)
        Me.GrpTypeDR.TabIndex = 3
        Me.GrpTypeDR.TabStop = False
        Me.GrpTypeDR.Text = "ដំណាក់កាលនៃជំងឺ Type of DR"
        '
        'LblNotFill
        '
        Me.LblNotFill.Location = New System.Drawing.Point(78, 129)
        Me.LblNotFill.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNotFill.Name = "LblNotFill"
        Me.LblNotFill.Size = New System.Drawing.Size(68, 23)
        Me.LblNotFill.TabIndex = 4
        Me.LblNotFill.Text = "0"
        Me.LblNotFill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFill
        '
        Me.LblFill.Location = New System.Drawing.Point(78, 107)
        Me.LblFill.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFill.Name = "LblFill"
        Me.LblFill.Size = New System.Drawing.Size(68, 23)
        Me.LblFill.TabIndex = 4
        Me.LblFill.Text = "0"
        Me.LblFill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 129)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total Not Fill:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Fill:"
        '
        'PictLoading
        '
        Me.PictLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictLoading.Image = Global.KTGSYS.My.Resources.Resources.loading_bar
        Me.PictLoading.Location = New System.Drawing.Point(4, 253)
        Me.PictLoading.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictLoading.Name = "PictLoading"
        Me.PictLoading.Size = New System.Drawing.Size(169, 24)
        Me.PictLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictLoading.TabIndex = 2
        Me.PictLoading.TabStop = False
        Me.PictLoading.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(157, 26)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 22)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "4 = Proliferative DR"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 70)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(140, 22)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "3 = Severe proliferative DR"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(157, 48)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 22)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "5 = CSME"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 48)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(151, 22)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "2 = Moderate proliferative DR"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 26)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 22)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "1 = Mild non-proliferative DR"
        '
        'GrpDiagnosis
        '
        Me.GrpDiagnosis.Controls.Add(Me.Label15)
        Me.GrpDiagnosis.Controls.Add(Me.Label14)
        Me.GrpDiagnosis.Controls.Add(Me.Label13)
        Me.GrpDiagnosis.Controls.Add(Me.Label12)
        Me.GrpDiagnosis.Controls.Add(Me.Label11)
        Me.GrpDiagnosis.Controls.Add(Me.Label10)
        Me.GrpDiagnosis.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpDiagnosis.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDiagnosis.Location = New System.Drawing.Point(2, 116)
        Me.GrpDiagnosis.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GrpDiagnosis.Name = "GrpDiagnosis"
        Me.GrpDiagnosis.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GrpDiagnosis.Size = New System.Drawing.Size(264, 109)
        Me.GrpDiagnosis.TabIndex = 2
        Me.GrpDiagnosis.TabStop = False
        Me.GrpDiagnosis.Text = "រោគវិនិច្ឆ័យ Diagnosis"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(127, 54)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 22)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "5 = Refractive error"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(127, 76)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 22)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "6 = Other deseases"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(127, 32)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 22)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "4 = Glaucom"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 54)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 22)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "2 = Cataract"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 76)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 22)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "3 = Pteriguim"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 32)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 22)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "1 = Retina desease"
        '
        'GrpDiabete
        '
        Me.GrpDiabete.Controls.Add(Me.Label9)
        Me.GrpDiabete.Controls.Add(Me.Label8)
        Me.GrpDiabete.Controls.Add(Me.Label7)
        Me.GrpDiabete.Controls.Add(Me.Label6)
        Me.GrpDiabete.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpDiabete.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDiabete.Location = New System.Drawing.Point(2, 25)
        Me.GrpDiabete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GrpDiabete.Name = "GrpDiabete"
        Me.GrpDiabete.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GrpDiabete.Size = New System.Drawing.Size(264, 91)
        Me.GrpDiabete.TabIndex = 1
        Me.GrpDiabete.TabStop = False
        Me.GrpDiabete.Text = "រយះពេលមានជំងឺទឹកនោមផ្អែម​ Period of Diabete"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 22)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "4 = > 5 years"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(87, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 22)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "3 = < 5 years"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 48)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "2 = < 4 years"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "1 = < 3 years"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Black
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(2, 209)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(268, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateMoTo)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DateMoFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(2, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(268, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Mo.Po.Tyso's patient By:"
        '
        'DateMoTo
        '
        Me.DateMoTo.CustomFormat = "dd/MM/yyyy"
        Me.DateMoTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateMoTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateMoTo.Location = New System.Drawing.Point(69, 71)
        Me.DateMoTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DateMoTo.Name = "DateMoTo"
        Me.DateMoTo.Size = New System.Drawing.Size(126, 26)
        Me.DateMoTo.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(33, 135)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateMoFrom
        '
        Me.DateMoFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateMoFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateMoFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateMoFrom.Location = New System.Drawing.Point(69, 29)
        Me.DateMoFrom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DateMoFrom.Name = "DateMoFrom"
        Me.DateMoFrom.Size = New System.Drawing.Size(126, 26)
        Me.DateMoFrom.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "To:"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.Location = New System.Drawing.Point(154, 135)
        Me.BtnPrintPreview.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(105, 35)
        Me.BtnPrintPreview.TabIndex = 2
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(68, 103)
        Me.TxtPatientNo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(191, 26)
        Me.TxtPatientNo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Patient No:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SplitListMoPoTysoAndReport)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox5.Size = New System.Drawing.Size(684, 724)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Mo.Po.Tyso's patient list"
        '
        'SplitListMoPoTysoAndReport
        '
        Me.SplitListMoPoTysoAndReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitListMoPoTysoAndReport.Location = New System.Drawing.Point(2, 16)
        Me.SplitListMoPoTysoAndReport.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SplitListMoPoTysoAndReport.Name = "SplitListMoPoTysoAndReport"
        '
        'SplitListMoPoTysoAndReport.Panel1
        '
        Me.SplitListMoPoTysoAndReport.Panel1.AutoScroll = True
        Me.SplitListMoPoTysoAndReport.Panel1.Controls.Add(Me.GridPatientMoPoTsyo)
        Me.SplitListMoPoTysoAndReport.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitListMoPoTysoAndReport.Panel2
        '
        Me.SplitListMoPoTysoAndReport.Panel2.Controls.Add(Me.CRViewer)
        Me.SplitListMoPoTysoAndReport.Panel2Collapsed = True
        Me.SplitListMoPoTysoAndReport.Size = New System.Drawing.Size(680, 705)
        Me.SplitListMoPoTysoAndReport.SplitterDistance = 331
        Me.SplitListMoPoTysoAndReport.SplitterWidth = 3
        Me.SplitListMoPoTysoAndReport.TabIndex = 0
        '
        'GridPatientMoPoTsyo
        '
        GridPatientMoPoTsyo_DesignTimeLayout.LayoutString = resources.GetString("GridPatientMoPoTsyo_DesignTimeLayout.LayoutString")
        Me.GridPatientMoPoTsyo.DesignTimeLayout = GridPatientMoPoTsyo_DesignTimeLayout
        Me.GridPatientMoPoTsyo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientMoPoTsyo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPatientMoPoTsyo.GroupByBoxVisible = False
        Me.GridPatientMoPoTsyo.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientMoPoTsyo.Location = New System.Drawing.Point(0, 0)
        Me.GridPatientMoPoTsyo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GridPatientMoPoTsyo.Name = "GridPatientMoPoTsyo"
        Me.GridPatientMoPoTsyo.RecordNavigator = True
        Me.GridPatientMoPoTsyo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPatientMoPoTsyo.Size = New System.Drawing.Size(680, 676)
        Me.GridPatientMoPoTsyo.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Khmer OS", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BtnNewMoPotsyo, Me.ToolStripSeparator4, Me.BtnEnterMPC, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 676)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(680, 29)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BtnNewMoPotsyo
        '
        Me.BtnNewMoPotsyo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNewMoPotsyo.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewMoPotsyo.ForeColor = System.Drawing.Color.Red
        Me.BtnNewMoPotsyo.Image = CType(resources.GetObject("BtnNewMoPotsyo.Image"), System.Drawing.Image)
        Me.BtnNewMoPotsyo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewMoPotsyo.Name = "BtnNewMoPotsyo"
        Me.BtnNewMoPotsyo.Size = New System.Drawing.Size(122, 26)
        Me.BtnNewMoPotsyo.Text = "New ម.ព.ជ Patient"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 29)
        '
        'BtnEnterMPC
        '
        Me.BtnEnterMPC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnEnterMPC.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnterMPC.ForeColor = System.Drawing.Color.Red
        Me.BtnEnterMPC.Image = CType(resources.GetObject("BtnEnterMPC.Image"), System.Drawing.Image)
        Me.BtnEnterMPC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEnterMPC.Name = "BtnEnterMPC"
        Me.BtnEnterMPC.Size = New System.Drawing.Size(138, 26)
        Me.BtnEnterMPC.Text = "Update Patient ម.ព.ជ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(22, 26)
        Me.ToolStripLabel1.Text = "    "
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(170, 26)
        Me.ToolStripLabel2.Text = "នាក់ជំងឺមិនទាន់បញ្ជូលទិន្នន័យគ្រប់"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.DisplayGroupTree = False
        Me.CRViewer.DisplayStatusBar = False
        Me.CRViewer.DisplayToolbar = False
        Me.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewer.Location = New System.Drawing.Point(0, 0)
        Me.CRViewer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.SelectionFormula = ""
        Me.CRViewer.ShowCloseButton = False
        Me.CRViewer.ShowGotoPageButton = False
        Me.CRViewer.ShowGroupTreeButton = False
        Me.CRViewer.Size = New System.Drawing.Size(96, 100)
        Me.CRViewer.TabIndex = 0
        Me.CRViewer.ViewTimeSelectionFormula = ""
        '
        'BGMoPoTsyo
        '
        '
        'DataMoPoTsyo
        '
        Me.DataMoPoTsyo.DataSetName = "DataMoPoTsyo"
        Me.DataMoPoTsyo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_MoPoTysoTableAdapter
        '
        Me.V_MoPoTysoTableAdapter.ClearBeforeFill = True
        '
        'FormMainPoMoSypo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 753)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "FormMainPoMoSypo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Po-Mo-Sypo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitMain.Panel1.ResumeLayout(False)
        Me.SplitMain.Panel2.ResumeLayout(False)
        Me.SplitMain.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GrpTypeDR.ResumeLayout(False)
        Me.GrpTypeDR.PerformLayout()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDiagnosis.ResumeLayout(False)
        Me.GrpDiagnosis.PerformLayout()
        Me.GrpDiabete.ResumeLayout(False)
        Me.GrpDiabete.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.SplitListMoPoTysoAndReport.Panel1.ResumeLayout(False)
        Me.SplitListMoPoTysoAndReport.Panel1.PerformLayout()
        Me.SplitListMoPoTysoAndReport.Panel2.ResumeLayout(False)
        Me.SplitListMoPoTysoAndReport.ResumeLayout(False)
        CType(Me.GridPatientMoPoTsyo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataMoPoTsyo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitMain As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitListMoPoTysoAndReport As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPatientMoPoTsyo As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateMoTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateMoFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpTypeDR As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GrpDiagnosis As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GrpDiabete As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents PictLoading As System.Windows.Forms.PictureBox
    Friend WithEvents BGMoPoTsyo As System.ComponentModel.BackgroundWorker
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnEnterMPC As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewMoPotsyo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblNotFill As System.Windows.Forms.Label
    Friend WithEvents LblFill As System.Windows.Forms.Label
    Friend WithEvents DataMoPoTsyo As KTGSYS.DataMoPoTsyo
    Friend WithEvents V_MoPoTysoTableAdapter As KTGSYS.DataMoPoTsyoTableAdapters.V_MoPoTysoTableAdapter
End Class
