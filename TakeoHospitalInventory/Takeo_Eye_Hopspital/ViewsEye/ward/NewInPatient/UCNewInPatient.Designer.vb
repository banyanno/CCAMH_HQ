<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCNewInPatient
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim GridNewInPatient_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPrepareOT_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCNewInPatient))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridNewInPatient = New Janus.Windows.GridEX.GridEX
        Me.ContextNewInPatient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DaillyBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.OTRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnPrepareOTRegistrattion1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MoveToListOTToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMovePatientWaiting1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnSetToNormal1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnReferal = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPermissionLeave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNoPermissionLeave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.MUndoCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripMenuItem
        Me.DSWardWithOT = New KTGSYS.DSWardWithOT
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.GridPrepareOT = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuPrepareOT = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoveToWaitingOTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DSPrepareOTList = New KTGSYS.DSPrepareOTList
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GridDiallyBook = New System.Windows.Forms.DataGridView
        Me.DaillyBookNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewInpatientNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Eye1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Treatment = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuTreatment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GDailyInpatient = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnViewDailyInpatient = New System.Windows.Forms.Button
        Me.BtnDailyInpatient = New System.Windows.Forms.Button
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.LblTotalSurgery = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.LblOthers = New System.Windows.Forms.Label
        Me.LblCorneaUlcer = New System.Windows.Forms.Label
        Me.LblWaitingOT = New System.Windows.Forms.Label
        Me.LblOtherOT = New System.Windows.Forms.Label
        Me.LblCataractOT = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.lblDischarge = New System.Windows.Forms.Label
        Me.LblAdmision = New System.Windows.Forms.Label
        Me.lblInpatient = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReloadData = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.TxtPatientNo = New System.Windows.Forms.ToolStripTextBox
        Me.BtnFind = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPreStaying = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewDiallyBook = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.BtnPrepareOTRegistrattion = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMovePatientWaiting = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnSetToNormal = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton
        Me.Referal = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator
        Me.PermissionLeave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.NoPermissionLeave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton
        Me.SaveDailyInPatient = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewDailyInpatient = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnOrder = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.Statistic = New System.Windows.Forms.ToolStripButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkSaveDailyInpatientByDate = New System.Windows.Forms.CheckBox
        Me.BtnUndoInPatient = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnViewOTHistory = New System.Windows.Forms.Button
        Me.BtnShow = New System.Windows.Forms.Button
        Me.DateToAdmid = New System.Windows.Forms.DateTimePicker
        Me.DateFromAdmid = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.BtnViewListOT = New System.Windows.Forms.Button
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnFindHistoryPatient = New System.Windows.Forms.Button
        Me.BtnReportDisease = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnNewInpatient = New System.Windows.Forms.Button
        Me.BgLoadNewInpatient = New System.ComponentModel.BackgroundWorker
        Me.V_NewInpatientDetialTableAdapter = New KTGSYS.DSWardWithOTTableAdapters.V_NewInpatientDetialTableAdapter
        Me.View_OTRegistrationTableAdapter = New KTGSYS.DSWardWithOTTableAdapters.View_OTRegistrationTableAdapter
        Me.V_IOLRegistrationTableAdapter = New KTGSYS.DSWardWithOTTableAdapters.V_IOLRegistrationTableAdapter
        Me.V_NewInpatientDetialTableAdapterPrepare = New KTGSYS.DSPrepareOTListTableAdapters.V_NewInpatientDetialTableAdapter
        Me.View_OTRegistrationTableAdapterPrepare = New KTGSYS.DSPrepareOTListTableAdapters.View_OTRegistrationTableAdapter
        Me.V_IOLRegistrationTableAdapterPrepare = New KTGSYS.DSPrepareOTListTableAdapters.V_IOLRegistrationTableAdapter
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.BtnPrintPatientFollowup = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintDischrge = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridNewInPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextNewInPatient.SuspendLayout()
        CType(Me.DSWardWithOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.GridPrepareOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuPrepareOT.SuspendLayout()
        CType(Me.DSPrepareOTList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.GridDiallyBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuTreatment.SuspendLayout()
        Me.GDailyInpatient.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1342, 1200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New In-patient"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SplitContainer2)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(3, 109)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1336, 1088)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "New In-patient Book"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 34)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1330, 1051)
        Me.SplitContainer2.SplitterDistance = 714
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridNewInPatient)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox9)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(1326, 710)
        Me.SplitContainer1.SplitterDistance = 557
        Me.SplitContainer1.TabIndex = 2
        '
        'GridNewInPatient
        '
        Me.GridNewInPatient.AllowChildTableGroups = True
        Me.GridNewInPatient.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridNewInPatient.BackColor = System.Drawing.Color.White
        Me.GridNewInPatient.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet
        Me.GridNewInPatient.ContextMenuStrip = Me.ContextNewInPatient
        Me.GridNewInPatient.DataMember = "V_NewInpatientDetial"
        Me.GridNewInPatient.DataSource = Me.DSWardWithOT
        GridNewInPatient_DesignTimeLayout.LayoutString = resources.GetString("GridNewInPatient_DesignTimeLayout.LayoutString")
        Me.GridNewInPatient.DesignTimeLayout = GridNewInPatient_DesignTimeLayout
        Me.GridNewInPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNewInPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridNewInPatient.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridNewInPatient.GroupByBoxVisible = False
        Me.GridNewInPatient.GroupRowFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.GridNewInPatient.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridNewInPatient.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.GridNewInPatient.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridNewInPatient.Hierarchical = True
        Me.GridNewInPatient.Location = New System.Drawing.Point(0, 0)
        Me.GridNewInPatient.Name = "GridNewInPatient"
        Me.GridNewInPatient.RecordNavigator = True
        Me.GridNewInPatient.RowFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridNewInPatient.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridNewInPatient.SelectedFormatStyle.BackColor = System.Drawing.Color.Silver
        Me.GridNewInPatient.SelectedFormatStyle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GridNewInPatient.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridNewInPatient.Size = New System.Drawing.Size(1326, 710)
        Me.GridNewInPatient.TabIndex = 1
        '
        'ContextNewInPatient
        '
        Me.ContextNewInPatient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaillyBooksToolStripMenuItem, Me.ToolStripSeparator2, Me.OTRegistrationToolStripMenuItem, Me.ToolStripMenuItem1, Me.LeaveToolStripMenuItem, Me.ToolStripMenuItem3, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator11, Me.BtnCancel})
        Me.ContextNewInPatient.Name = "ContextMenuStrip1"
        Me.ContextNewInPatient.Size = New System.Drawing.Size(184, 138)
        '
        'DaillyBooksToolStripMenuItem
        '
        Me.DaillyBooksToolStripMenuItem.Name = "DaillyBooksToolStripMenuItem"
        Me.DaillyBooksToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DaillyBooksToolStripMenuItem.Text = "Dailly Books..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'OTRegistrationToolStripMenuItem
        '
        Me.OTRegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrepareOTRegistrattion1, Me.MoveToListOTToolStripMenuItem, Me.BtnMovePatientWaiting1, Me.ToolStripMenuItem2, Me.BtnSetToNormal1})
        Me.OTRegistrationToolStripMenuItem.Name = "OTRegistrationToolStripMenuItem"
        Me.OTRegistrationToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OTRegistrationToolStripMenuItem.Text = "OT Registration"
        '
        'BtnPrepareOTRegistrattion1
        '
        Me.BtnPrepareOTRegistrattion1.Name = "BtnPrepareOTRegistrattion1"
        Me.BtnPrepareOTRegistrattion1.Size = New System.Drawing.Size(260, 22)
        Me.BtnPrepareOTRegistrattion1.Text = "Prepare OT Registration..."
        '
        'MoveToListOTToolStripMenuItem
        '
        Me.MoveToListOTToolStripMenuItem.Name = "MoveToListOTToolStripMenuItem"
        Me.MoveToListOTToolStripMenuItem.Size = New System.Drawing.Size(257, 6)
        '
        'BtnMovePatientWaiting1
        '
        Me.BtnMovePatientWaiting1.Name = "BtnMovePatientWaiting1"
        Me.BtnMovePatientWaiting1.Size = New System.Drawing.Size(260, 22)
        Me.BtnMovePatientWaiting1.Text = "Move Patient Waiting to List OT >>"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(257, 6)
        '
        'BtnSetToNormal1
        '
        Me.BtnSetToNormal1.Name = "BtnSetToNormal1"
        Me.BtnSetToNormal1.Size = New System.Drawing.Size(260, 22)
        Me.BtnSetToNormal1.Text = "Set To Normal"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 6)
        '
        'LeaveToolStripMenuItem
        '
        Me.LeaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnReferal, Me.ToolStripMenuItem4, Me.BtnPermissionLeave, Me.ToolStripMenuItem5, Me.BtnNoPermissionLeave})
        Me.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        Me.LeaveToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LeaveToolStripMenuItem.Text = "Leave"
        '
        'BtnReferal
        '
        Me.BtnReferal.Name = "BtnReferal"
        Me.BtnReferal.Size = New System.Drawing.Size(184, 22)
        Me.BtnReferal.Text = "Referal"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(181, 6)
        '
        'BtnPermissionLeave
        '
        Me.BtnPermissionLeave.Name = "BtnPermissionLeave"
        Me.BtnPermissionLeave.Size = New System.Drawing.Size(184, 22)
        Me.BtnPermissionLeave.Text = "Permission Leave"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(181, 6)
        '
        'BtnNoPermissionLeave
        '
        Me.BtnNoPermissionLeave.Name = "BtnNoPermissionLeave"
        Me.BtnNoPermissionLeave.Size = New System.Drawing.Size(184, 22)
        Me.BtnNoPermissionLeave.Text = "No Permission Leave"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MCancel, Me.ToolStripMenuItem6, Me.MUndoCancel})
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DeleteToolStripMenuItem.Text = "Remove"
        '
        'MCancel
        '
        Me.MCancel.Name = "MCancel"
        Me.MCancel.Size = New System.Drawing.Size(142, 22)
        Me.MCancel.Text = "Cancel"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(139, 6)
        Me.ToolStripMenuItem6.Visible = False
        '
        'MUndoCancel
        '
        Me.MUndoCancel.Name = "MUndoCancel"
        Me.MUndoCancel.Size = New System.Drawing.Size(142, 22)
        Me.MUndoCancel.Text = "Undo Cancel"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(180, 6)
        '
        'BtnCancel
        '
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(183, 22)
        Me.BtnCancel.Text = "Postpone/Cancel OT"
        '
        'DSWardWithOT
        '
        Me.DSWardWithOT.DataSetName = "DSWardWithOT"
        Me.DSWardWithOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GridPrepareOT)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(96, 100)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Prepare For Operation List"
        '
        'GridPrepareOT
        '
        Me.GridPrepareOT.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPrepareOT.ContextMenuStrip = Me.ContextMenuPrepareOT
        Me.GridPrepareOT.DataMember = "V_NewInpatientDetial"
        Me.GridPrepareOT.DataSource = Me.DSPrepareOTList
        GridPrepareOT_DesignTimeLayout.LayoutString = resources.GetString("GridPrepareOT_DesignTimeLayout.LayoutString")
        Me.GridPrepareOT.DesignTimeLayout = GridPrepareOT_DesignTimeLayout
        Me.GridPrepareOT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrepareOT.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridPrepareOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPrepareOT.GroupByBoxVisible = False
        Me.GridPrepareOT.Hierarchical = True
        Me.GridPrepareOT.Location = New System.Drawing.Point(3, 22)
        Me.GridPrepareOT.Name = "GridPrepareOT"
        Me.GridPrepareOT.RecordNavigator = True
        Me.GridPrepareOT.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPrepareOT.Size = New System.Drawing.Size(90, 75)
        Me.GridPrepareOT.TabIndex = 2
        '
        'ContextMenuPrepareOT
        '
        Me.ContextMenuPrepareOT.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToWaitingOTToolStripMenuItem})
        Me.ContextMenuPrepareOT.Name = "ContextMenuPrepareOT"
        Me.ContextMenuPrepareOT.Size = New System.Drawing.Size(202, 26)
        '
        'MoveToWaitingOTToolStripMenuItem
        '
        Me.MoveToWaitingOTToolStripMenuItem.Name = "MoveToWaitingOTToolStripMenuItem"
        Me.MoveToWaitingOTToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.MoveToWaitingOTToolStripMenuItem.Text = "<< Move To Waiting OT"
        '
        'DSPrepareOTList
        '
        Me.DSPrepareOTList.DataSetName = "DSPrepareOTList"
        Me.DSPrepareOTList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SplitContainer3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1326, 329)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dailly Book"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox7)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GDailyInpatient)
        Me.SplitContainer3.Size = New System.Drawing.Size(1320, 310)
        Me.SplitContainer3.SplitterDistance = 534
        Me.SplitContainer3.TabIndex = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GridDiallyBook)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(534, 310)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'GridDiallyBook
        '
        Me.GridDiallyBook.AllowUserToAddRows = False
        Me.GridDiallyBook.AllowUserToDeleteRows = False
        Me.GridDiallyBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridDiallyBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridDiallyBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDiallyBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DaillyBookNo, Me.NewInpatientNo1, Me.PatientNo1, Me.Eye1, Me.Treatment, Me.CreateDate})
        Me.GridDiallyBook.ContextMenuStrip = Me.ContextMenuTreatment
        Me.GridDiallyBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiallyBook.Location = New System.Drawing.Point(3, 16)
        Me.GridDiallyBook.Name = "GridDiallyBook"
        Me.GridDiallyBook.ReadOnly = True
        Me.GridDiallyBook.RowHeadersWidth = 25
        Me.GridDiallyBook.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDiallyBook.RowTemplate.Height = 35
        Me.GridDiallyBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDiallyBook.Size = New System.Drawing.Size(528, 291)
        Me.GridDiallyBook.TabIndex = 0
        '
        'DaillyBookNo
        '
        Me.DaillyBookNo.DataPropertyName = "DaillyBookNo"
        Me.DaillyBookNo.HeaderText = "No"
        Me.DaillyBookNo.Name = "DaillyBookNo"
        Me.DaillyBookNo.ReadOnly = True
        Me.DaillyBookNo.Visible = False
        '
        'NewInpatientNo1
        '
        Me.NewInpatientNo1.DataPropertyName = "NewInpatientNo"
        Me.NewInpatientNo1.HeaderText = "NewInpatientNo"
        Me.NewInpatientNo1.Name = "NewInpatientNo1"
        Me.NewInpatientNo1.ReadOnly = True
        Me.NewInpatientNo1.Visible = False
        '
        'PatientNo1
        '
        Me.PatientNo1.DataPropertyName = "PatientNo"
        Me.PatientNo1.HeaderText = "PatientNo"
        Me.PatientNo1.Name = "PatientNo1"
        Me.PatientNo1.ReadOnly = True
        Me.PatientNo1.Visible = False
        '
        'Eye1
        '
        Me.Eye1.DataPropertyName = "Eye"
        Me.Eye1.HeaderText = "Eye"
        Me.Eye1.Name = "Eye1"
        Me.Eye1.ReadOnly = True
        '
        'Treatment
        '
        Me.Treatment.DataPropertyName = "Treatment"
        Me.Treatment.HeaderText = "Treatment"
        Me.Treatment.Name = "Treatment"
        Me.Treatment.ReadOnly = True
        Me.Treatment.Width = 200
        '
        'CreateDate
        '
        Me.CreateDate.DataPropertyName = "CreateDate"
        Me.CreateDate.HeaderText = "Date Treatment"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.ReadOnly = True
        Me.CreateDate.Width = 200
        '
        'ContextMenuTreatment
        '
        Me.ContextMenuTreatment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1})
        Me.ContextMenuTreatment.Name = "ContextMenuTreatment"
        Me.ContextMenuTreatment.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'GDailyInpatient
        '
        Me.GDailyInpatient.Controls.Add(Me.Label7)
        Me.GDailyInpatient.Controls.Add(Me.BtnViewDailyInpatient)
        Me.GDailyInpatient.Controls.Add(Me.BtnDailyInpatient)
        Me.GDailyInpatient.Controls.Add(Me.TxtNote)
        Me.GDailyInpatient.Controls.Add(Me.Label28)
        Me.GDailyInpatient.Controls.Add(Me.Label37)
        Me.GDailyInpatient.Controls.Add(Me.Label36)
        Me.GDailyInpatient.Controls.Add(Me.Label35)
        Me.GDailyInpatient.Controls.Add(Me.Label34)
        Me.GDailyInpatient.Controls.Add(Me.Label33)
        Me.GDailyInpatient.Controls.Add(Me.Label32)
        Me.GDailyInpatient.Controls.Add(Me.LblTotalSurgery)
        Me.GDailyInpatient.Controls.Add(Me.Label27)
        Me.GDailyInpatient.Controls.Add(Me.Label26)
        Me.GDailyInpatient.Controls.Add(Me.Label25)
        Me.GDailyInpatient.Controls.Add(Me.Label24)
        Me.GDailyInpatient.Controls.Add(Me.LblOthers)
        Me.GDailyInpatient.Controls.Add(Me.LblCorneaUlcer)
        Me.GDailyInpatient.Controls.Add(Me.LblWaitingOT)
        Me.GDailyInpatient.Controls.Add(Me.LblOtherOT)
        Me.GDailyInpatient.Controls.Add(Me.LblCataractOT)
        Me.GDailyInpatient.Controls.Add(Me.Label15)
        Me.GDailyInpatient.Controls.Add(Me.Label14)
        Me.GDailyInpatient.Controls.Add(Me.Label4)
        Me.GDailyInpatient.Controls.Add(Me.Label18)
        Me.GDailyInpatient.Controls.Add(Me.Label13)
        Me.GDailyInpatient.Controls.Add(Me.Label12)
        Me.GDailyInpatient.Controls.Add(Me.Label17)
        Me.GDailyInpatient.Controls.Add(Me.Label6)
        Me.GDailyInpatient.Controls.Add(Me.Label2)
        Me.GDailyInpatient.Controls.Add(Me.Label11)
        Me.GDailyInpatient.Controls.Add(Me.Label16)
        Me.GDailyInpatient.Controls.Add(Me.LblTotal)
        Me.GDailyInpatient.Controls.Add(Me.lblDischarge)
        Me.GDailyInpatient.Controls.Add(Me.LblAdmision)
        Me.GDailyInpatient.Controls.Add(Me.lblInpatient)
        Me.GDailyInpatient.Controls.Add(Me.Label10)
        Me.GDailyInpatient.Controls.Add(Me.Label9)
        Me.GDailyInpatient.Controls.Add(Me.Label3)
        Me.GDailyInpatient.Controls.Add(Me.Label5)
        Me.GDailyInpatient.Controls.Add(Me.Label21)
        Me.GDailyInpatient.Controls.Add(Me.Label20)
        Me.GDailyInpatient.Controls.Add(Me.Label19)
        Me.GDailyInpatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GDailyInpatient.Location = New System.Drawing.Point(0, 0)
        Me.GDailyInpatient.Name = "GDailyInpatient"
        Me.GDailyInpatient.Size = New System.Drawing.Size(782, 310)
        Me.GDailyInpatient.TabIndex = 0
        Me.GDailyInpatient.TabStop = False
        Me.GDailyInpatient.Text = "Nurse Oncall"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(299, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 64)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "ចំណាំ: Nurse must save every time at the end of day."
        '
        'BtnViewDailyInpatient
        '
        Me.BtnViewDailyInpatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewDailyInpatient.Location = New System.Drawing.Point(409, 94)
        Me.BtnViewDailyInpatient.Name = "BtnViewDailyInpatient"
        Me.BtnViewDailyInpatient.Size = New System.Drawing.Size(78, 39)
        Me.BtnViewDailyInpatient.TabIndex = 26
        Me.BtnViewDailyInpatient.Text = "View Daily Inpatient"
        Me.BtnViewDailyInpatient.UseVisualStyleBackColor = True
        '
        'BtnDailyInpatient
        '
        Me.BtnDailyInpatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDailyInpatient.Location = New System.Drawing.Point(303, 94)
        Me.BtnDailyInpatient.Name = "BtnDailyInpatient"
        Me.BtnDailyInpatient.Size = New System.Drawing.Size(99, 39)
        Me.BtnDailyInpatient.TabIndex = 25
        Me.BtnDailyInpatient.Text = "Save Daily In-Patient"
        Me.BtnDailyInpatient.UseVisualStyleBackColor = True
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(11, 183)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(281, 48)
        Me.TxtNote.TabIndex = 24
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 166)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(33, 13)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Note:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(233, 156)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(13, 13)
        Me.Label37.TabIndex = 22
        Me.Label37.Text = "="
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(233, 128)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(13, 13)
        Me.Label36.TabIndex = 21
        Me.Label36.Text = "="
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(233, 100)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(13, 13)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "="
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(233, 74)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 13)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "="
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(233, 50)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 13)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "="
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(233, 29)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 13)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "="
        '
        'LblTotalSurgery
        '
        Me.LblTotalSurgery.Location = New System.Drawing.Point(252, 29)
        Me.LblTotalSurgery.Name = "LblTotalSurgery"
        Me.LblTotalSurgery.Size = New System.Drawing.Size(40, 13)
        Me.LblTotalSurgery.TabIndex = 16
        Me.LblTotalSurgery.Text = "0"
        Me.LblTotalSurgery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(97, 55)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 13)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "="
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(97, 107)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 13)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "="
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(97, 80)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 13)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "="
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(97, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 13)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "="
        '
        'LblOthers
        '
        Me.LblOthers.Location = New System.Drawing.Point(252, 156)
        Me.LblOthers.Name = "LblOthers"
        Me.LblOthers.Size = New System.Drawing.Size(40, 13)
        Me.LblOthers.TabIndex = 1
        Me.LblOthers.Text = "0"
        Me.LblOthers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCorneaUlcer
        '
        Me.LblCorneaUlcer.Location = New System.Drawing.Point(252, 128)
        Me.LblCorneaUlcer.Name = "LblCorneaUlcer"
        Me.LblCorneaUlcer.Size = New System.Drawing.Size(40, 13)
        Me.LblCorneaUlcer.TabIndex = 1
        Me.LblCorneaUlcer.Text = "0"
        Me.LblCorneaUlcer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblWaitingOT
        '
        Me.LblWaitingOT.Location = New System.Drawing.Point(252, 100)
        Me.LblWaitingOT.Name = "LblWaitingOT"
        Me.LblWaitingOT.Size = New System.Drawing.Size(40, 13)
        Me.LblWaitingOT.TabIndex = 1
        Me.LblWaitingOT.Text = "0"
        Me.LblWaitingOT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblOtherOT
        '
        Me.LblOtherOT.Location = New System.Drawing.Point(252, 76)
        Me.LblOtherOT.Name = "LblOtherOT"
        Me.LblOtherOT.Size = New System.Drawing.Size(40, 13)
        Me.LblOtherOT.TabIndex = 1
        Me.LblOtherOT.Text = "0"
        Me.LblOtherOT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCataractOT
        '
        Me.LblCataractOT.Location = New System.Drawing.Point(252, 50)
        Me.LblCataractOT.Name = "LblCataractOT"
        Me.LblCataractOT.Size = New System.Drawing.Size(40, 13)
        Me.LblCataractOT.TabIndex = 1
        Me.LblCataractOT.Text = "0"
        Me.LblCataractOT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(157, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "OTHERS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(157, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "C. ULCER"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.PeachPuff
        Me.Label4.Location = New System.Drawing.Point(408, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 18)
        Me.Label4.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(408, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 18)
        Me.Label18.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(157, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "WAITING"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(169, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Post Other"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(302, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 18)
        Me.Label17.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "TOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SURGERY"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(169, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Post Cat."
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(302, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 18)
        Me.Label16.TabIndex = 7
        '
        'LblTotal
        '
        Me.LblTotal.Location = New System.Drawing.Point(116, 107)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(33, 13)
        Me.LblTotal.TabIndex = 5
        Me.LblTotal.Text = "0"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDischarge
        '
        Me.lblDischarge.Location = New System.Drawing.Point(116, 80)
        Me.lblDischarge.Name = "lblDischarge"
        Me.lblDischarge.Size = New System.Drawing.Size(33, 13)
        Me.lblDischarge.TabIndex = 5
        Me.lblDischarge.Text = "0"
        Me.lblDischarge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAdmision
        '
        Me.LblAdmision.Location = New System.Drawing.Point(116, 55)
        Me.LblAdmision.Name = "LblAdmision"
        Me.LblAdmision.Size = New System.Drawing.Size(33, 13)
        Me.LblAdmision.TabIndex = 5
        Me.LblAdmision.Text = "0"
        Me.LblAdmision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInpatient
        '
        Me.lblInpatient.Location = New System.Drawing.Point(116, 29)
        Me.lblInpatient.Name = "lblInpatient"
        Me.lblInpatient.Size = New System.Drawing.Size(33, 13)
        Me.lblInpatient.TabIndex = 5
        Me.lblInpatient.Text = "0"
        Me.lblInpatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(9, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 30)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "DICHARGE (REDONE)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ADMISSION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(429, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "រាប់ជាជម្ងឺផ្សេងៗ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "INPATIENT"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(429, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 22)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "អ្នកមានជម្ងឺ C. Ulcer"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(323, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 22)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "អ្នកវះកាត់រួច"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(323, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 22)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "អ្នករងចាំវះកាត់"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.BtnReloadData, Me.ToolStripSeparator8, Me.ToolStripLabel1, Me.TxtPatientNo, Me.BtnFind, Me.ToolStripSeparator6, Me.btnPreStaying, Me.ToolStripSeparator10, Me.BtnNewDiallyBook, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator3, Me.ToolStripDropDownButton2, Me.ToolStripSeparator4, Me.ToolStripDropDownButton3, Me.ToolStripSeparator7, Me.BtnOrder, Me.ToolStripSeparator9, Me.Statistic})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 76)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1336, 33)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 33)
        '
        'BtnReloadData
        '
        Me.BtnReloadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnReloadData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnReloadData.ForeColor = System.Drawing.Color.Blue
        Me.BtnReloadData.Image = CType(resources.GetObject("BtnReloadData.Image"), System.Drawing.Image)
        Me.BtnReloadData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReloadData.Name = "BtnReloadData"
        Me.BtnReloadData.Size = New System.Drawing.Size(108, 30)
        Me.BtnReloadData.Text = "Refresh Data"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 30)
        Me.ToolStripLabel1.Text = "Patient No:"
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(200, 33)
        '
        'BtnFind
        '
        Me.BtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnFind.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFind.ForeColor = System.Drawing.Color.Blue
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(34, 30)
        Me.BtnFind.Text = "Find"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 33)
        '
        'btnPreStaying
        '
        Me.btnPreStaying.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPreStaying.Enabled = False
        Me.btnPreStaying.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPreStaying.ForeColor = System.Drawing.Color.Blue
        Me.btnPreStaying.Image = CType(resources.GetObject("btnPreStaying.Image"), System.Drawing.Image)
        Me.btnPreStaying.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreStaying.Name = "btnPreStaying"
        Me.btnPreStaying.Size = New System.Drawing.Size(94, 30)
        Me.btnPreStaying.Tag = "Print P-Staying"
        Me.btnPreStaying.Text = "Print P-Staying"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 33)
        '
        'BtnNewDiallyBook
        '
        Me.BtnNewDiallyBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnNewDiallyBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNewDiallyBook.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewDiallyBook.Image = CType(resources.GetObject("BtnNewDiallyBook.Image"), System.Drawing.Image)
        Me.BtnNewDiallyBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewDiallyBook.Name = "BtnNewDiallyBook"
        Me.BtnNewDiallyBook.Size = New System.Drawing.Size(101, 30)
        Me.BtnNewDiallyBook.Text = "Dailly Books"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrepareOTRegistrattion, Me.ToolStripMenuItem7, Me.BtnMovePatientWaiting, Me.ToolStripMenuItem9, Me.BtnSetToNormal})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(136, 30)
        Me.ToolStripDropDownButton1.Text = "OT Registration"
        '
        'BtnPrepareOTRegistrattion
        '
        Me.BtnPrepareOTRegistrattion.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrepareOTRegistrattion.Name = "BtnPrepareOTRegistrattion"
        Me.BtnPrepareOTRegistrattion.Size = New System.Drawing.Size(329, 22)
        Me.BtnPrepareOTRegistrattion.Text = "Prepare OT Registration..."
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(326, 6)
        '
        'BtnMovePatientWaiting
        '
        Me.BtnMovePatientWaiting.ForeColor = System.Drawing.Color.Blue
        Me.BtnMovePatientWaiting.Name = "BtnMovePatientWaiting"
        Me.BtnMovePatientWaiting.Size = New System.Drawing.Size(329, 22)
        Me.BtnMovePatientWaiting.Text = "Move Patient Waiting to List OT >>"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(326, 6)
        '
        'BtnSetToNormal
        '
        Me.BtnSetToNormal.ForeColor = System.Drawing.Color.Blue
        Me.BtnSetToNormal.Name = "BtnSetToNormal"
        Me.BtnSetToNormal.Size = New System.Drawing.Size(329, 22)
        Me.BtnSetToNormal.Text = "Set To Normal"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Referal, Me.ToolStripMenuItem10, Me.PermissionLeave, Me.ToolStripMenuItem8, Me.NoPermissionLeave})
        Me.ToolStripDropDownButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(65, 30)
        Me.ToolStripDropDownButton2.Text = "Leave"
        '
        'Referal
        '
        Me.Referal.ForeColor = System.Drawing.Color.Blue
        Me.Referal.Name = "Referal"
        Me.Referal.Size = New System.Drawing.Size(229, 22)
        Me.Referal.Text = "Referal"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(226, 6)
        '
        'PermissionLeave
        '
        Me.PermissionLeave.ForeColor = System.Drawing.Color.Blue
        Me.PermissionLeave.Name = "PermissionLeave"
        Me.PermissionLeave.Size = New System.Drawing.Size(229, 22)
        Me.PermissionLeave.Text = "Permission Leave"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(226, 6)
        '
        'NoPermissionLeave
        '
        Me.NoPermissionLeave.ForeColor = System.Drawing.Color.Blue
        Me.NoPermissionLeave.Name = "NoPermissionLeave"
        Me.NoPermissionLeave.Size = New System.Drawing.Size(229, 22)
        Me.NoPermissionLeave.Text = "No Permission Leave"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveDailyInPatient, Me.ToolStripMenuItem11, Me.ViewDailyInpatient})
        Me.ToolStripDropDownButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripDropDownButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripDropDownButton3.Image = Global.KTGSYS.My.Resources.Resources.alarm_hareketli
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(117, 30)
        Me.ToolStripDropDownButton3.Text = "Nurse on call"
        '
        'SaveDailyInPatient
        '
        Me.SaveDailyInPatient.ForeColor = System.Drawing.Color.Blue
        Me.SaveDailyInPatient.Name = "SaveDailyInPatient"
        Me.SaveDailyInPatient.Size = New System.Drawing.Size(194, 22)
        Me.SaveDailyInPatient.Text = "Save Daily In-Patient"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(191, 6)
        '
        'ViewDailyInpatient
        '
        Me.ViewDailyInpatient.ForeColor = System.Drawing.Color.Blue
        Me.ViewDailyInpatient.Name = "ViewDailyInpatient"
        Me.ViewDailyInpatient.Size = New System.Drawing.Size(194, 22)
        Me.ViewDailyInpatient.Text = "View Daily Inpatient"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 33)
        '
        'BtnOrder
        '
        Me.BtnOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnOrder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnOrder.ForeColor = System.Drawing.Color.Blue
        Me.BtnOrder.Image = CType(resources.GetObject("BtnOrder.Image"), System.Drawing.Image)
        Me.BtnOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(134, 30)
        Me.BtnOrder.Text = "Group Type of Patient"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 33)
        '
        'Statistic
        '
        Me.Statistic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Statistic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Statistic.ForeColor = System.Drawing.Color.Blue
        Me.Statistic.Image = CType(resources.GetObject("Statistic.Image"), System.Drawing.Image)
        Me.Statistic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Statistic.Name = "Statistic"
        Me.Statistic.Size = New System.Drawing.Size(117, 30)
        Me.Statistic.Text = "In Patient Statistic"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSaveDailyInpatientByDate)
        Me.GroupBox3.Controls.Add(Me.BtnUndoInPatient)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.BtnViewListOT)
        Me.GroupBox3.Controls.Add(Me.BtnFindHistoryPatient)
        Me.GroupBox3.Controls.Add(Me.BtnReportDisease)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.BtnNewInpatient)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1336, 60)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'chkSaveDailyInpatientByDate
        '
        Me.chkSaveDailyInpatientByDate.AutoSize = True
        Me.chkSaveDailyInpatientByDate.Enabled = False
        Me.chkSaveDailyInpatientByDate.Location = New System.Drawing.Point(1237, 26)
        Me.chkSaveDailyInpatientByDate.Name = "chkSaveDailyInpatientByDate"
        Me.chkSaveDailyInpatientByDate.Size = New System.Drawing.Size(169, 17)
        Me.chkSaveDailyInpatientByDate.TabIndex = 10
        Me.chkSaveDailyInpatientByDate.Text = "&Update Daily Inpatient by date"
        Me.chkSaveDailyInpatientByDate.UseVisualStyleBackColor = True
        Me.chkSaveDailyInpatientByDate.Visible = False
        '
        'BtnUndoInPatient
        '
        Me.BtnUndoInPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUndoInPatient.Location = New System.Drawing.Point(559, 12)
        Me.BtnUndoInPatient.Name = "BtnUndoInPatient"
        Me.BtnUndoInPatient.Size = New System.Drawing.Size(98, 36)
        Me.BtnUndoInPatient.TabIndex = 9
        Me.BtnUndoInPatient.Text = "Undo Patient"
        Me.BtnUndoInPatient.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ToolStrip2)
        Me.GroupBox4.Controls.Add(Me.BtnViewOTHistory)
        Me.GroupBox4.Controls.Add(Me.BtnShow)
        Me.GroupBox4.Controls.Add(Me.DateToAdmid)
        Me.GroupBox4.Controls.Add(Me.DateFromAdmid)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Location = New System.Drawing.Point(665, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(603, 44)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Patient Admission"
        '
        'BtnViewOTHistory
        '
        Me.BtnViewOTHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewOTHistory.Location = New System.Drawing.Point(296, 15)
        Me.BtnViewOTHistory.Name = "BtnViewOTHistory"
        Me.BtnViewOTHistory.Size = New System.Drawing.Size(91, 23)
        Me.BtnViewOTHistory.TabIndex = 4
        Me.BtnViewOTHistory.Text = "View OT History"
        Me.BtnViewOTHistory.UseVisualStyleBackColor = True
        '
        'BtnShow
        '
        Me.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShow.Location = New System.Drawing.Point(231, 15)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(63, 23)
        Me.BtnShow.TabIndex = 3
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'DateToAdmid
        '
        Me.DateToAdmid.CustomFormat = "dd/MM/yyyy"
        Me.DateToAdmid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateToAdmid.Location = New System.Drawing.Point(141, 17)
        Me.DateToAdmid.Name = "DateToAdmid"
        Me.DateToAdmid.Size = New System.Drawing.Size(84, 20)
        Me.DateToAdmid.TabIndex = 0
        '
        'DateFromAdmid
        '
        Me.DateFromAdmid.CustomFormat = "dd/MM/yyyy"
        Me.DateFromAdmid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFromAdmid.Location = New System.Drawing.Point(36, 17)
        Me.DateFromAdmid.Name = "DateFromAdmid"
        Me.DateFromAdmid.Size = New System.Drawing.Size(84, 20)
        Me.DateFromAdmid.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "From:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(118, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(23, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "To:"
        '
        'BtnViewListOT
        '
        Me.BtnViewListOT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewListOT.ImageIndex = 1
        Me.BtnViewListOT.ImageList = Me.imageList1
        Me.BtnViewListOT.Location = New System.Drawing.Point(437, 12)
        Me.BtnViewListOT.Name = "BtnViewListOT"
        Me.BtnViewListOT.Size = New System.Drawing.Size(115, 37)
        Me.BtnViewListOT.TabIndex = 7
        Me.BtnViewListOT.Text = "Prepare Operation"
        Me.BtnViewListOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnViewListOT.UseVisualStyleBackColor = True
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "sort_ascending.ico")
        Me.imageList1.Images.SetKeyName(1, "sort_descending.ico")
        '
        'BtnFindHistoryPatient
        '
        Me.BtnFindHistoryPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindHistoryPatient.Location = New System.Drawing.Point(313, 12)
        Me.BtnFindHistoryPatient.Name = "BtnFindHistoryPatient"
        Me.BtnFindHistoryPatient.Size = New System.Drawing.Size(118, 37)
        Me.BtnFindHistoryPatient.TabIndex = 6
        Me.BtnFindHistoryPatient.Text = "Find In Patient history"
        Me.BtnFindHistoryPatient.UseVisualStyleBackColor = True
        '
        'BtnReportDisease
        '
        Me.BtnReportDisease.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReportDisease.Location = New System.Drawing.Point(215, 12)
        Me.BtnReportDisease.Name = "BtnReportDisease"
        Me.BtnReportDisease.Size = New System.Drawing.Size(93, 37)
        Me.BtnReportDisease.TabIndex = 6
        Me.BtnReportDisease.Text = "Report Disease"
        Me.BtnReportDisease.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(101, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Print Prepare OT list"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnNewInpatient
        '
        Me.BtnNewInpatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewInpatient.Location = New System.Drawing.Point(6, 12)
        Me.BtnNewInpatient.Name = "BtnNewInpatient"
        Me.BtnNewInpatient.Size = New System.Drawing.Size(89, 37)
        Me.BtnNewInpatient.TabIndex = 2
        Me.BtnNewInpatient.Text = "&New In-patient"
        Me.BtnNewInpatient.UseVisualStyleBackColor = True
        '
        'BgLoadNewInpatient
        '
        '
        'V_NewInpatientDetialTableAdapter
        '
        Me.V_NewInpatientDetialTableAdapter.ClearBeforeFill = True
        '
        'View_OTRegistrationTableAdapter
        '
        Me.View_OTRegistrationTableAdapter.ClearBeforeFill = True
        '
        'V_IOLRegistrationTableAdapter
        '
        Me.V_IOLRegistrationTableAdapter.ClearBeforeFill = True
        '
        'V_NewInpatientDetialTableAdapterPrepare
        '
        Me.V_NewInpatientDetialTableAdapterPrepare.ClearBeforeFill = True
        '
        'View_OTRegistrationTableAdapterPrepare
        '
        Me.View_OTRegistrationTableAdapterPrepare.ClearBeforeFill = True
        '
        'V_IOLRegistrationTableAdapterPrepare
        '
        Me.V_IOLRegistrationTableAdapterPrepare.ClearBeforeFill = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(392, 12)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(158, 25)
        Me.ToolStrip2.TabIndex = 5
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.DropDownButtonWidth = 20
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintPatientFollowup, Me.ToolStripMenuItem12, Me.BtnPrintDischrge})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripSplitButton1.Text = "Patient Discharge"
        '
        'BtnPrintPatientFollowup
        '
        Me.BtnPrintPatientFollowup.Name = "BtnPrintPatientFollowup"
        Me.BtnPrintPatientFollowup.Size = New System.Drawing.Size(204, 22)
        Me.BtnPrintPatientFollowup.Text = "Report Patient follow up"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(201, 6)
        '
        'BtnPrintDischrge
        '
        Me.BtnPrintDischrge.Name = "BtnPrintDischrge"
        Me.BtnPrintDischrge.Size = New System.Drawing.Size(204, 22)
        Me.BtnPrintDischrge.Text = "Report Patient Discharge"
        '
        'UCNewInPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCNewInPatient"
        Me.Size = New System.Drawing.Size(1342, 1200)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridNewInPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextNewInPatient.ResumeLayout(False)
        CType(Me.DSWardWithOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.GridPrepareOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuPrepareOT.ResumeLayout(False)
        CType(Me.DSPrepareOTList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.GridDiallyBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuTreatment.ResumeLayout(False)
        Me.GDailyInpatient.ResumeLayout(False)
        Me.GDailyInpatient.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridDiallyBook As System.Windows.Forms.DataGridView
    Friend WithEvents Leave1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Leave2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ContextNewInPatient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DaillyBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OTRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GDailyInpatient As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNewInpatient As System.Windows.Forms.Button
    Friend WithEvents LeaveTest As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveFromInpatient As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ContextMenuTreatment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents q As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents LeaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReferal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPermissionLeave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNoPermissionLeave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DSWardWithOT As KTGSYS.DSWardWithOT
    Friend WithEvents V_NewInpatientDetialTableAdapter As KTGSYS.DSWardWithOTTableAdapters.V_NewInpatientDetialTableAdapter
    Friend WithEvents View_OTRegistrationTableAdapter As KTGSYS.DSWardWithOTTableAdapters.View_OTRegistrationTableAdapter
    Friend WithEvents BgLoadNewInpatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents V_IOLRegistrationTableAdapter As KTGSYS.DSWardWithOTTableAdapters.V_IOLRegistrationTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblDischarge As System.Windows.Forms.Label
    Friend WithEvents LblAdmision As System.Windows.Forms.Label
    Friend WithEvents lblInpatient As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblOtherOT As System.Windows.Forms.Label
    Friend WithEvents LblCataractOT As System.Windows.Forms.Label
    Friend WithEvents LblOthers As System.Windows.Forms.Label
    Friend WithEvents LblCorneaUlcer As System.Windows.Forms.Label
    Friend WithEvents LblWaitingOT As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridNewInPatient As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReportDisease As System.Windows.Forms.Button
    Friend WithEvents BtnFindHistoryPatient As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPrepareOT As Janus.Windows.GridEX.GridEX
    Friend WithEvents DSPrepareOTList As KTGSYS.DSPrepareOTList
    Friend WithEvents V_NewInpatientDetialTableAdapterPrepare As KTGSYS.DSPrepareOTListTableAdapters.V_NewInpatientDetialTableAdapter
    Friend WithEvents View_OTRegistrationTableAdapterPrepare As KTGSYS.DSPrepareOTListTableAdapters.View_OTRegistrationTableAdapter
    Friend WithEvents V_IOLRegistrationTableAdapterPrepare As KTGSYS.DSPrepareOTListTableAdapters.V_IOLRegistrationTableAdapter
    Friend WithEvents BtnPrepareOTRegistrattion1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToListOTToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnMovePatientWaiting1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuPrepareOT As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MoveToWaitingOTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents LblTotalSurgery As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents DaillyBookNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewInpatientNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eye1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Treatment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents BtnDailyInpatient As System.Windows.Forms.Button
    Friend WithEvents BtnViewDailyInpatient As System.Windows.Forms.Button
    Friend WithEvents BtnViewListOT As System.Windows.Forms.Button
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSetToNormal1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DateFromAdmid As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateToAdmid As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents MCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MUndoCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnUndoInPatient As System.Windows.Forms.Button
    Friend WithEvents chkSaveDailyInpatientByDate As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewDiallyBook As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrepareOTRegistrattion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnMovePatientWaiting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSetToNormal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Referal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PermissionLeave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReloadData As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NoPermissionLeave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SaveDailyInPatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewDailyInpatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Statistic As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtPatientNo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BtnFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewOTHistory As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPreStaying As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents BtnPrintPatientFollowup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintDischrge As System.Windows.Forms.ToolStripMenuItem

End Class
