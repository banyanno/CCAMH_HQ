<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAppointment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardAppointment))
        Dim GridClientAppointment_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridListOfTherapist_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.MenuAppointment = New System.Windows.Forms.ToolStrip()
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNewNextAppointment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUpdateAppoint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUpdateStatusApp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCaseDropOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPrinAppointment = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridClientAppointment = New Janus.Windows.GridEX.GridEX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadMissByMonth = New System.Windows.Forms.RadioButton()
        Me.RadMissByDay = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnPrintListLateAppointment = New System.Windows.Forms.Button()
        Me.TxtNumberMonthOrDay = New System.Windows.Forms.TextBox()
        Me.DateCaseAuditDropOut = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnFDropOut = New System.Windows.Forms.Button()
        Me.TxtLastVisit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAppointTime = New System.Windows.Forms.TextBox()
        Me.TxtDateCalled = New System.Windows.Forms.TextBox()
        Me.TxtDateAppointment = New System.Windows.Forms.TextBox()
        Me.txtAppointmentStatusNote = New System.Windows.Forms.TextBox()
        Me.TxtAppointmentStatus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChIsCall = New System.Windows.Forms.CheckBox()
        Me.TxtAppontmentWith = New System.Windows.Forms.TextBox()
        Me.TxtAppointmentNote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridListOfTherapist = New Janus.Windows.GridEX.GridEX()
        Me.ToolThearapist = New System.Windows.Forms.ToolStrip()
        Me.BtnTherapist = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUpdateTherapist = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtTelephoneNo = New System.Windows.Forms.TextBox()
        Me.RadClientTelphone = New System.Windows.Forms.RadioButton()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.CboSearchTherapistOrDoctor = New System.Windows.Forms.ComboBox()
        Me.RadTherapist = New System.Windows.Forms.RadioButton()
        Me.TxtSearchClientName = New System.Windows.Forms.TextBox()
        Me.RadClientName = New System.Windows.Forms.RadioButton()
        Me.RadClientNo = New System.Windows.Forms.RadioButton()
        Me.DateSearchAppTo = New System.Windows.Forms.DateTimePicker()
        Me.TxtSearchClientNo = New System.Windows.Forms.TextBox()
        Me.DateSearchAppFrom = New System.Windows.Forms.DateTimePicker()
        Me.RadDateAppointent = New System.Windows.Forms.RadioButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuAppointment.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridClientAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridListOfTherapist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolThearapist.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuAppointment
        '
        Me.MenuAppointment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuAppointment.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuAppointment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator4, Me.BtnNewNextAppointment, Me.ToolStripSeparator2, Me.BtnUpdateAppoint, Me.ToolStripSeparator6, Me.BtnUpdateStatusApp, Me.ToolStripSeparator3, Me.BtnCaseDropOut, Me.ToolStripSeparator5, Me.BtnPrinAppointment})
        Me.MenuAppointment.Location = New System.Drawing.Point(0, 0)
        Me.MenuAppointment.Name = "MenuAppointment"
        Me.MenuAppointment.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuAppointment.Size = New System.Drawing.Size(1420, 58)
        Me.MenuAppointment.TabIndex = 0
        Me.MenuAppointment.Text = "ToolStrip1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(107, 55)
        Me.BtnRefresh.Text = "     Refresh     "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 58)
        '
        'BtnNewNextAppointment
        '
        Me.BtnNewNextAppointment.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnNewNextAppointment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnNewNextAppointment.Image = CType(resources.GetObject("BtnNewNextAppointment.Image"), System.Drawing.Image)
        Me.BtnNewNextAppointment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewNextAppointment.Name = "BtnNewNextAppointment"
        Me.BtnNewNextAppointment.Size = New System.Drawing.Size(173, 55)
        Me.BtnNewNextAppointment.Text = "  New next appointment"
        Me.BtnNewNextAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'BtnUpdateAppoint
        '
        Me.BtnUpdateAppoint.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnUpdateAppoint.Image = CType(resources.GetObject("BtnUpdateAppoint.Image"), System.Drawing.Image)
        Me.BtnUpdateAppoint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateAppoint.Name = "BtnUpdateAppoint"
        Me.BtnUpdateAppoint.Size = New System.Drawing.Size(190, 55)
        Me.BtnUpdateAppoint.Text = "Update Appointment info"
        Me.BtnUpdateAppoint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 58)
        '
        'BtnUpdateStatusApp
        '
        Me.BtnUpdateStatusApp.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnUpdateStatusApp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnUpdateStatusApp.Image = CType(resources.GetObject("BtnUpdateStatusApp.Image"), System.Drawing.Image)
        Me.BtnUpdateStatusApp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateStatusApp.Name = "BtnUpdateStatusApp"
        Me.BtnUpdateStatusApp.Size = New System.Drawing.Size(160, 55)
        Me.BtnUpdateStatusApp.Text = "Update appoint status"
        Me.BtnUpdateStatusApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 58)
        '
        'BtnCaseDropOut
        '
        Me.BtnCaseDropOut.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnCaseDropOut.Image = CType(resources.GetObject("BtnCaseDropOut.Image"), System.Drawing.Image)
        Me.BtnCaseDropOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCaseDropOut.Name = "BtnCaseDropOut"
        Me.BtnCaseDropOut.Size = New System.Drawing.Size(219, 55)
        Me.BtnCaseDropOut.Text = "    Note Case audit Drop-Out    "
        Me.BtnCaseDropOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 58)
        '
        'BtnPrinAppointment
        '
        Me.BtnPrinAppointment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnPrinAppointment.Image = CType(resources.GetObject("BtnPrinAppointment.Image"), System.Drawing.Image)
        Me.BtnPrinAppointment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrinAppointment.Name = "BtnPrinAppointment"
        Me.BtnPrinAppointment.Size = New System.Drawing.Size(142, 55)
        Me.BtnPrinAppointment.Text = "Print Appointment"
        Me.BtnPrinAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1420, 633)
        Me.SplitContainer1.SplitterDistance = 1085
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1085, 633)
        Me.SplitContainer2.SplitterDistance = 361
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridClientAppointment)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1083, 359)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client detail"
        '
        'GridClientAppointment
        '
        Me.GridClientAppointment.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientAppointment.BackColor = System.Drawing.Color.White
        Me.GridClientAppointment.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridClientAppointment.CardBorders = False
        GridClientAppointment_DesignTimeLayout.LayoutString = resources.GetString("GridClientAppointment_DesignTimeLayout.LayoutString")
        Me.GridClientAppointment.DesignTimeLayout = GridClientAppointment_DesignTimeLayout
        Me.GridClientAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientAppointment.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.None
        Me.GridClientAppointment.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GridClientAppointment.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientAppointment.GroupByBoxVisible = False
        Me.GridClientAppointment.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridClientAppointment.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClientAppointment.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridClientAppointment.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClientAppointment.Location = New System.Drawing.Point(3, 20)
        Me.GridClientAppointment.Name = "GridClientAppointment"
        Me.GridClientAppointment.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom
        Me.GridClientAppointment.RecordNavigator = True
        Me.GridClientAppointment.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientAppointment.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientAppointment.SelectedFormatStyle.BackColor = System.Drawing.Color.Gray
        Me.GridClientAppointment.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Gray
        Me.GridClientAppointment.Size = New System.Drawing.Size(1077, 336)
        Me.GridClientAppointment.TabIndex = 3
        Me.GridClientAppointment.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientAppointment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.TxtLastVisit)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtAppointTime)
        Me.GroupBox3.Controls.Add(Me.TxtDateCalled)
        Me.GroupBox3.Controls.Add(Me.TxtDateAppointment)
        Me.GroupBox3.Controls.Add(Me.txtAppointmentStatusNote)
        Me.GroupBox3.Controls.Add(Me.TxtAppointmentStatus)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ChIsCall)
        Me.GroupBox3.Controls.Add(Me.TxtAppontmentWith)
        Me.GroupBox3.Controls.Add(Me.TxtAppointmentNote)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1083, 266)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Appointment Detail:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadMissByMonth)
        Me.GroupBox5.Controls.Add(Me.RadMissByDay)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.BtnPrintListLateAppointment)
        Me.GroupBox5.Controls.Add(Me.TxtNumberMonthOrDay)
        Me.GroupBox5.Controls.Add(Me.DateCaseAuditDropOut)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.BtnFDropOut)
        Me.GroupBox5.Location = New System.Drawing.Point(584, 34)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(515, 242)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Finding Client Missing Appointment"
        '
        'RadMissByMonth
        '
        Me.RadMissByMonth.AutoSize = True
        Me.RadMissByMonth.Location = New System.Drawing.Point(301, 41)
        Me.RadMissByMonth.Name = "RadMissByMonth"
        Me.RadMissByMonth.Size = New System.Drawing.Size(123, 22)
        Me.RadMissByMonth.TabIndex = 30
        Me.RadMissByMonth.Text = "Miss by Month"
        Me.RadMissByMonth.UseVisualStyleBackColor = True
        '
        'RadMissByDay
        '
        Me.RadMissByDay.AutoSize = True
        Me.RadMissByDay.Checked = True
        Me.RadMissByDay.Location = New System.Drawing.Point(302, 16)
        Me.RadMissByDay.Name = "RadMissByDay"
        Me.RadMissByDay.Size = New System.Drawing.Size(107, 22)
        Me.RadMissByDay.TabIndex = 29
        Me.RadMissByDay.TabStop = True
        Me.RadMissByDay.Text = "Miss by Day"
        Me.RadMissByDay.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Select date audit on:"
        '
        'BtnPrintListLateAppointment
        '
        Me.BtnPrintListLateAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnPrintListLateAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintListLateAppointment.FlatAppearance.BorderSize = 0
        Me.BtnPrintListLateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintListLateAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintListLateAppointment.ForeColor = System.Drawing.Color.White
        Me.BtnPrintListLateAppointment.Location = New System.Drawing.Point(259, 105)
        Me.BtnPrintListLateAppointment.Name = "BtnPrintListLateAppointment"
        Me.BtnPrintListLateAppointment.Size = New System.Drawing.Size(243, 53)
        Me.BtnPrintListLateAppointment.TabIndex = 28
        Me.BtnPrintListLateAppointment.Text = "Print List Miss app"
        Me.BtnPrintListLateAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrintListLateAppointment.UseVisualStyleBackColor = False
        '
        'TxtNumberMonthOrDay
        '
        Me.TxtNumberMonthOrDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumberMonthOrDay.Location = New System.Drawing.Point(302, 65)
        Me.TxtNumberMonthOrDay.Name = "TxtNumberMonthOrDay"
        Me.TxtNumberMonthOrDay.Size = New System.Drawing.Size(122, 29)
        Me.TxtNumberMonthOrDay.TabIndex = 27
        Me.TxtNumberMonthOrDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateCaseAuditDropOut
        '
        Me.DateCaseAuditDropOut.Checked = False
        Me.DateCaseAuditDropOut.CustomFormat = "dd/MM/yyyy"
        Me.DateCaseAuditDropOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCaseAuditDropOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCaseAuditDropOut.Location = New System.Drawing.Point(10, 65)
        Me.DateCaseAuditDropOut.Name = "DateCaseAuditDropOut"
        Me.DateCaseAuditDropOut.ShowCheckBox = True
        Me.DateCaseAuditDropOut.Size = New System.Drawing.Size(243, 30)
        Me.DateCaseAuditDropOut.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(259, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 25)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = ">="
        '
        'BtnFDropOut
        '
        Me.BtnFDropOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnFDropOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFDropOut.FlatAppearance.BorderSize = 0
        Me.BtnFDropOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFDropOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFDropOut.ForeColor = System.Drawing.Color.White
        Me.BtnFDropOut.Image = CType(resources.GetObject("BtnFDropOut.Image"), System.Drawing.Image)
        Me.BtnFDropOut.Location = New System.Drawing.Point(10, 105)
        Me.BtnFDropOut.Name = "BtnFDropOut"
        Me.BtnFDropOut.Size = New System.Drawing.Size(243, 53)
        Me.BtnFDropOut.TabIndex = 22
        Me.BtnFDropOut.Text = "Finding Case Miss App"
        Me.BtnFDropOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnFDropOut.UseVisualStyleBackColor = False
        '
        'TxtLastVisit
        '
        Me.TxtLastVisit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TxtLastVisit.Location = New System.Drawing.Point(333, 100)
        Me.TxtLastVisit.Name = "TxtLastVisit"
        Me.TxtLastVisit.Size = New System.Drawing.Size(245, 29)
        Me.TxtLastVisit.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Last Visit:"
        '
        'TxtAppointTime
        '
        Me.TxtAppointTime.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppointTime.Location = New System.Drawing.Point(192, 100)
        Me.TxtAppointTime.Name = "TxtAppointTime"
        Me.TxtAppointTime.Size = New System.Drawing.Size(134, 30)
        Me.TxtAppointTime.TabIndex = 16
        Me.TxtAppointTime.Visible = False
        '
        'TxtDateCalled
        '
        Me.TxtDateCalled.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateCalled.Location = New System.Drawing.Point(10, 159)
        Me.TxtDateCalled.Name = "TxtDateCalled"
        Me.TxtDateCalled.Size = New System.Drawing.Size(133, 30)
        Me.TxtDateCalled.TabIndex = 15
        '
        'TxtDateAppointment
        '
        Me.TxtDateAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TxtDateAppointment.Location = New System.Drawing.Point(9, 103)
        Me.TxtDateAppointment.Name = "TxtDateAppointment"
        Me.TxtDateAppointment.Size = New System.Drawing.Size(133, 29)
        Me.TxtDateAppointment.TabIndex = 14
        '
        'txtAppointmentStatusNote
        '
        Me.txtAppointmentStatusNote.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointmentStatusNote.Location = New System.Drawing.Point(9, 209)
        Me.txtAppointmentStatusNote.Multiline = True
        Me.txtAppointmentStatusNote.Name = "txtAppointmentStatusNote"
        Me.txtAppointmentStatusNote.Size = New System.Drawing.Size(317, 54)
        Me.txtAppointmentStatusNote.TabIndex = 11
        '
        'TxtAppointmentStatus
        '
        Me.TxtAppointmentStatus.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppointmentStatus.Location = New System.Drawing.Point(192, 160)
        Me.TxtAppointmentStatus.Name = "TxtAppointmentStatus"
        Me.TxtAppointmentStatus.Size = New System.Drawing.Size(133, 30)
        Me.TxtAppointmentStatus.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Appointment status note:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Appointment status:"
        '
        'ChIsCall
        '
        Me.ChIsCall.AutoSize = True
        Me.ChIsCall.Location = New System.Drawing.Point(10, 135)
        Me.ChIsCall.Name = "ChIsCall"
        Me.ChIsCall.Size = New System.Drawing.Size(70, 22)
        Me.ChIsCall.TabIndex = 8
        Me.ChIsCall.Text = "Visited"
        Me.ChIsCall.UseVisualStyleBackColor = True
        '
        'TxtAppontmentWith
        '
        Me.TxtAppontmentWith.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppontmentWith.Location = New System.Drawing.Point(10, 47)
        Me.TxtAppontmentWith.Name = "TxtAppontmentWith"
        Me.TxtAppontmentWith.Size = New System.Drawing.Size(315, 30)
        Me.TxtAppontmentWith.TabIndex = 7
        '
        'TxtAppointmentNote
        '
        Me.TxtAppointmentNote.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppointmentNote.Location = New System.Drawing.Point(333, 160)
        Me.TxtAppointmentNote.Multiline = True
        Me.TxtAppointmentNote.Name = "TxtAppointmentNote"
        Me.TxtAppointmentNote.Size = New System.Drawing.Size(245, 104)
        Me.TxtAppointmentNote.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(189, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Time:"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(338, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Appointment note"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Date appointment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Meet with "
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer3.Size = New System.Drawing.Size(329, 631)
        Me.SplitContainer3.SplitterDistance = 199
        Me.SplitContainer3.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridListOfTherapist)
        Me.GroupBox1.Controls.Add(Me.ToolThearapist)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of therapist or doctors"
        '
        'GridListOfTherapist
        '
        Me.GridListOfTherapist.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridListOfTherapist.BackColor = System.Drawing.Color.White
        Me.GridListOfTherapist.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridListOfTherapist_DesignTimeLayout.LayoutString = resources.GetString("GridListOfTherapist_DesignTimeLayout.LayoutString")
        Me.GridListOfTherapist.DesignTimeLayout = GridListOfTherapist_DesignTimeLayout
        Me.GridListOfTherapist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridListOfTherapist.EmptyGridInfoAlignment = System.Drawing.ContentAlignment.TopRight
        Me.GridListOfTherapist.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridListOfTherapist.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridListOfTherapist.GroupByBoxVisible = False
        Me.GridListOfTherapist.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridListOfTherapist.HeaderFormatStyle.FontSize = 11.0!
        Me.GridListOfTherapist.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GridListOfTherapist.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridListOfTherapist.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridListOfTherapist.Location = New System.Drawing.Point(3, 67)
        Me.GridListOfTherapist.Name = "GridListOfTherapist"
        Me.GridListOfTherapist.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Custom
        Me.GridListOfTherapist.RecordNavigator = True
        Me.GridListOfTherapist.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridListOfTherapist.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridListOfTherapist.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridListOfTherapist.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridListOfTherapist.Size = New System.Drawing.Size(323, 129)
        Me.GridListOfTherapist.TabIndex = 24
        Me.GridListOfTherapist.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridListOfTherapist.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolThearapist
        '
        Me.ToolThearapist.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolThearapist.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolThearapist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnTherapist, Me.ToolStripSeparator7, Me.BtnUpdateTherapist})
        Me.ToolThearapist.Location = New System.Drawing.Point(3, 20)
        Me.ToolThearapist.Name = "ToolThearapist"
        Me.ToolThearapist.Size = New System.Drawing.Size(323, 47)
        Me.ToolThearapist.TabIndex = 25
        Me.ToolThearapist.Text = "ToolStrip1"
        '
        'BtnTherapist
        '
        Me.BtnTherapist.Image = CType(resources.GetObject("BtnTherapist.Image"), System.Drawing.Image)
        Me.BtnTherapist.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnTherapist.Name = "BtnTherapist"
        Me.BtnTherapist.Size = New System.Drawing.Size(86, 44)
        Me.BtnTherapist.Text = "New Therapist"
        Me.BtnTherapist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 47)
        '
        'BtnUpdateTherapist
        '
        Me.BtnUpdateTherapist.Image = CType(resources.GetObject("BtnUpdateTherapist.Image"), System.Drawing.Image)
        Me.BtnUpdateTherapist.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateTherapist.Name = "BtnUpdateTherapist"
        Me.BtnUpdateTherapist.Size = New System.Drawing.Size(106, 44)
        Me.BtnUpdateTherapist.Text = "Update Thearapist"
        Me.BtnUpdateTherapist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtTelephoneNo)
        Me.GroupBox4.Controls.Add(Me.RadClientTelphone)
        Me.GroupBox4.Controls.Add(Me.BtnFind)
        Me.GroupBox4.Controls.Add(Me.CboSearchTherapistOrDoctor)
        Me.GroupBox4.Controls.Add(Me.RadTherapist)
        Me.GroupBox4.Controls.Add(Me.TxtSearchClientName)
        Me.GroupBox4.Controls.Add(Me.RadClientName)
        Me.GroupBox4.Controls.Add(Me.RadClientNo)
        Me.GroupBox4.Controls.Add(Me.DateSearchAppTo)
        Me.GroupBox4.Controls.Add(Me.TxtSearchClientNo)
        Me.GroupBox4.Controls.Add(Me.DateSearchAppFrom)
        Me.GroupBox4.Controls.Add(Me.RadDateAppointent)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(329, 428)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Find more appointment"
        '
        'TxtTelephoneNo
        '
        Me.TxtTelephoneNo.Enabled = False
        Me.TxtTelephoneNo.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelephoneNo.Location = New System.Drawing.Point(3, 238)
        Me.TxtTelephoneNo.Name = "TxtTelephoneNo"
        Me.TxtTelephoneNo.Size = New System.Drawing.Size(313, 30)
        Me.TxtTelephoneNo.TabIndex = 20
        '
        'RadClientTelphone
        '
        Me.RadClientTelphone.AutoSize = True
        Me.RadClientTelphone.Location = New System.Drawing.Point(3, 209)
        Me.RadClientTelphone.Name = "RadClientTelphone"
        Me.RadClientTelphone.Size = New System.Drawing.Size(119, 22)
        Me.RadClientTelphone.TabIndex = 19
        Me.RadClientTelphone.Text = "Telephone No"
        Me.RadClientTelphone.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatAppearance.BorderSize = 0
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.ForeColor = System.Drawing.Color.White
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(6, 327)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(314, 42)
        Me.BtnFind.TabIndex = 18
        Me.BtnFind.Text = "Finding"
        Me.BtnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'CboSearchTherapistOrDoctor
        '
        Me.CboSearchTherapistOrDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSearchTherapistOrDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSearchTherapistOrDoctor.Enabled = False
        Me.CboSearchTherapistOrDoctor.FormattingEnabled = True
        Me.CboSearchTherapistOrDoctor.Location = New System.Drawing.Point(7, 295)
        Me.CboSearchTherapistOrDoctor.Name = "CboSearchTherapistOrDoctor"
        Me.CboSearchTherapistOrDoctor.Size = New System.Drawing.Size(313, 26)
        Me.CboSearchTherapistOrDoctor.TabIndex = 17
        '
        'RadTherapist
        '
        Me.RadTherapist.AutoSize = True
        Me.RadTherapist.Location = New System.Drawing.Point(7, 270)
        Me.RadTherapist.Name = "RadTherapist"
        Me.RadTherapist.Size = New System.Drawing.Size(155, 22)
        Me.RadTherapist.TabIndex = 16
        Me.RadTherapist.Text = "Therapist or Doctor"
        Me.RadTherapist.UseVisualStyleBackColor = True
        '
        'TxtSearchClientName
        '
        Me.TxtSearchClientName.Enabled = False
        Me.TxtSearchClientName.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchClientName.Location = New System.Drawing.Point(3, 176)
        Me.TxtSearchClientName.Name = "TxtSearchClientName"
        Me.TxtSearchClientName.Size = New System.Drawing.Size(313, 30)
        Me.TxtSearchClientName.TabIndex = 15
        '
        'RadClientName
        '
        Me.RadClientName.AutoSize = True
        Me.RadClientName.Location = New System.Drawing.Point(3, 146)
        Me.RadClientName.Name = "RadClientName"
        Me.RadClientName.Size = New System.Drawing.Size(137, 22)
        Me.RadClientName.TabIndex = 14
        Me.RadClientName.Text = "Client Name Eng"
        Me.RadClientName.UseVisualStyleBackColor = True
        '
        'RadClientNo
        '
        Me.RadClientNo.AutoSize = True
        Me.RadClientNo.Location = New System.Drawing.Point(6, 82)
        Me.RadClientNo.Name = "RadClientNo"
        Me.RadClientNo.Size = New System.Drawing.Size(91, 22)
        Me.RadClientNo.TabIndex = 5
        Me.RadClientNo.Text = "Client No:"
        Me.RadClientNo.UseVisualStyleBackColor = True
        '
        'DateSearchAppTo
        '
        Me.DateSearchAppTo.Checked = False
        Me.DateSearchAppTo.CustomFormat = "dd/MM/yyyy"
        Me.DateSearchAppTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateSearchAppTo.Location = New System.Drawing.Point(164, 52)
        Me.DateSearchAppTo.Name = "DateSearchAppTo"
        Me.DateSearchAppTo.Size = New System.Drawing.Size(152, 24)
        Me.DateSearchAppTo.TabIndex = 4
        '
        'TxtSearchClientNo
        '
        Me.TxtSearchClientNo.Enabled = False
        Me.TxtSearchClientNo.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchClientNo.Location = New System.Drawing.Point(3, 110)
        Me.TxtSearchClientNo.Name = "TxtSearchClientNo"
        Me.TxtSearchClientNo.Size = New System.Drawing.Size(313, 30)
        Me.TxtSearchClientNo.TabIndex = 13
        '
        'DateSearchAppFrom
        '
        Me.DateSearchAppFrom.Checked = False
        Me.DateSearchAppFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateSearchAppFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateSearchAppFrom.Location = New System.Drawing.Point(6, 52)
        Me.DateSearchAppFrom.Name = "DateSearchAppFrom"
        Me.DateSearchAppFrom.Size = New System.Drawing.Size(152, 24)
        Me.DateSearchAppFrom.TabIndex = 3
        '
        'RadDateAppointent
        '
        Me.RadDateAppointent.AutoSize = True
        Me.RadDateAppointent.Checked = True
        Me.RadDateAppointent.Location = New System.Drawing.Point(6, 23)
        Me.RadDateAppointent.Name = "RadDateAppointent"
        Me.RadDateAppointent.Size = New System.Drawing.Size(142, 22)
        Me.RadDateAppointent.TabIndex = 0
        Me.RadDateAppointent.TabStop = True
        Me.RadDateAppointent.Text = "Date appointment"
        Me.RadDateAppointent.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DashboardAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuAppointment)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Name = "DashboardAppointment"
        Me.Size = New System.Drawing.Size(1420, 691)
        Me.MenuAppointment.ResumeLayout(False)
        Me.MenuAppointment.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridClientAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridListOfTherapist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolThearapist.ResumeLayout(False)
        Me.ToolThearapist.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuAppointment As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewNextAppointment As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridListOfTherapist As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridClientAppointment As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateStatusApp As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAppontmentWith As System.Windows.Forms.TextBox
    Friend WithEvents TxtAppointmentNote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChIsCall As System.Windows.Forms.CheckBox
    Friend WithEvents txtAppointmentStatusNote As System.Windows.Forms.TextBox
    Friend WithEvents TxtAppointmentStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtSearchClientNo As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DateSearchAppTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateSearchAppFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadDateAppointent As System.Windows.Forms.RadioButton
    Friend WithEvents TxtDateCalled As System.Windows.Forms.TextBox
    Friend WithEvents TxtDateAppointment As System.Windows.Forms.TextBox
    Friend WithEvents RadClientName As System.Windows.Forms.RadioButton
    Friend WithEvents RadClientNo As System.Windows.Forms.RadioButton
    Friend WithEvents CboSearchTherapistOrDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents RadTherapist As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSearchClientName As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtAppointTime As System.Windows.Forms.TextBox
    Friend WithEvents BtnCaseDropOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnFDropOut As System.Windows.Forms.Button
    Friend WithEvents DateCaseAuditDropOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtLastVisit As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrinAppointment As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtNumberMonthOrDay As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnPrintListLateAppointment As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateAppoint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolThearapist As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnTherapist As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateTherapist As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtTelephoneNo As System.Windows.Forms.TextBox
    Friend WithEvents RadClientTelphone As System.Windows.Forms.RadioButton
    Friend WithEvents RadMissByMonth As System.Windows.Forms.RadioButton
    Friend WithEvents RadMissByDay As System.Windows.Forms.RadioButton

End Class
