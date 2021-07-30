<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardWaitingPayment
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
        Dim GridClientWaitingPayment_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardWaitingPayment))
        Dim GridPrescription_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridServiceSpacial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GridClientWaitingPayment = New Janus.Windows.GridEX.GridEX()
        Me.ContextWaitingReceipt = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnMenuPrintReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDeleteReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUndoReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.BgPrintReceipt = New System.ComponentModel.BackgroundWorker()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTotalServiceFollowUp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblTotalPayment = New System.Windows.Forms.Label()
        Me.LblTotalServiceSpacial = New System.Windows.Forms.Label()
        Me.LblTotalServiceContribute = New System.Windows.Forms.Label()
        Me.LblTotalServiceMedicine = New System.Windows.Forms.Label()
        Me.LblTotalServiceNewConsult = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridPrescription = New Janus.Windows.GridEX.GridEX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GridServiceSpacial = New Janus.Windows.GridEX.GridEX()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnAddMoreReceipt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.BtnNewClientReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnFollowUpClientReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnMedClientReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSpacialServiceReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnClientContribute = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnAddMoreService = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.BtnViewDeleteReceipt = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrintReceiptTemplate = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintReceiptTamplate = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.LblTotalSP = New System.Windows.Forms.Label()
        Me.LblSPFemale = New System.Windows.Forms.Label()
        Me.LblSPMale = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.LblTotalMedicine = New System.Windows.Forms.Label()
        Me.LblMedFemale = New System.Windows.Forms.Label()
        Me.LblMedMale = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.LblTotalFollowup = New System.Windows.Forms.Label()
        Me.LblFollFemale = New System.Windows.Forms.Label()
        Me.LblFollMale = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LblTotalNewCleint = New System.Windows.Forms.Label()
        Me.LblNewFemale = New System.Windows.Forms.Label()
        Me.LblNewMale = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GridClientWaitingPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextWaitingReceipt.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridServiceSpacial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridClientWaitingPayment
        '
        Me.GridClientWaitingPayment.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientWaitingPayment.BackColor = System.Drawing.Color.White
        Me.GridClientWaitingPayment.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridClientWaitingPayment.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.AllCells
        Me.GridClientWaitingPayment.ContextMenuStrip = Me.ContextWaitingReceipt
        GridClientWaitingPayment_DesignTimeLayout.LayoutString = resources.GetString("GridClientWaitingPayment_DesignTimeLayout.LayoutString")
        Me.GridClientWaitingPayment.DesignTimeLayout = GridClientWaitingPayment_DesignTimeLayout
        Me.GridClientWaitingPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientWaitingPayment.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.GridClientWaitingPayment.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridClientWaitingPayment.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridClientWaitingPayment.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientWaitingPayment.GroupByBoxVisible = False
        Me.GridClientWaitingPayment.HeaderFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridClientWaitingPayment.HeaderFormatStyle.ForeColor = System.Drawing.Color.Maroon
        Me.GridClientWaitingPayment.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridClientWaitingPayment.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClientWaitingPayment.Location = New System.Drawing.Point(0, 0)
        Me.GridClientWaitingPayment.Name = "GridClientWaitingPayment"
        Me.GridClientWaitingPayment.RecordNavigator = True
        Me.GridClientWaitingPayment.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientWaitingPayment.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientWaitingPayment.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridClientWaitingPayment.SettingsKey = "GridClientWaitingPayment"
        Me.GridClientWaitingPayment.Size = New System.Drawing.Size(1060, 737)
        Me.GridClientWaitingPayment.TabIndex = 6
        Me.GridClientWaitingPayment.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientWaitingPayment.UseCompatibleTextRendering = False
        Me.GridClientWaitingPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ContextWaitingReceipt
        '
        Me.ContextWaitingReceipt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnMenuPrintReceipt, Me.ToolStripMenuItem1, Me.BtnDeleteReceipt, Me.ToolStripMenuItem3, Me.BtnUndoReceipt})
        Me.ContextWaitingReceipt.Name = "ContextMenuStrip1"
        Me.ContextWaitingReceipt.Size = New System.Drawing.Size(169, 82)
        '
        'BtnMenuPrintReceipt
        '
        Me.BtnMenuPrintReceipt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenuPrintReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMenuPrintReceipt.Name = "BtnMenuPrintReceipt"
        Me.BtnMenuPrintReceipt.Size = New System.Drawing.Size(168, 22)
        Me.BtnMenuPrintReceipt.Text = "Re-Print Receipt"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 6)
        '
        'BtnDeleteReceipt
        '
        Me.BtnDeleteReceipt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteReceipt.Name = "BtnDeleteReceipt"
        Me.BtnDeleteReceipt.Size = New System.Drawing.Size(168, 22)
        Me.BtnDeleteReceipt.Text = "Delete Receipt"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(165, 6)
        '
        'BtnUndoReceipt
        '
        Me.BtnUndoReceipt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUndoReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUndoReceipt.Name = "BtnUndoReceipt"
        Me.BtnUndoReceipt.Size = New System.Drawing.Size(168, 22)
        Me.BtnUndoReceipt.Text = "Undo Receipt"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(1226, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Date From:"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(1236, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Date To:"
        '
        'DFrom
        '
        Me.DFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DFrom.CustomFormat = "dd-MM-yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(1288, 10)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(104, 20)
        Me.DFrom.TabIndex = 13
        '
        'DTo
        '
        Me.DTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTo.CustomFormat = "dd-MM-yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(1288, 36)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(104, 20)
        Me.DTo.TabIndex = 14
        '
        'BgPrintReceipt
        '
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 64)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(1400, 737)
        Me.SplitContainer1.SplitterDistance = 670
        Me.SplitContainer1.TabIndex = 17
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GridClientWaitingPayment)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1400, 737)
        Me.SplitContainer3.SplitterDistance = 1060
        Me.SplitContainer3.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblTotalServiceFollowUp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LblTotalPayment)
        Me.GroupBox1.Controls.Add(Me.LblTotalServiceSpacial)
        Me.GroupBox1.Controls.Add(Me.LblTotalServiceContribute)
        Me.GroupBox1.Controls.Add(Me.LblTotalServiceMedicine)
        Me.GroupBox1.Controls.Add(Me.LblTotalServiceNewConsult)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 737)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment summary:"
        '
        'LblTotalServiceFollowUp
        '
        Me.LblTotalServiceFollowUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalServiceFollowUp.ForeColor = System.Drawing.Color.Maroon
        Me.LblTotalServiceFollowUp.Location = New System.Drawing.Point(165, 121)
        Me.LblTotalServiceFollowUp.Name = "LblTotalServiceFollowUp"
        Me.LblTotalServiceFollowUp.Size = New System.Drawing.Size(141, 20)
        Me.LblTotalServiceFollowUp.TabIndex = 15
        Me.LblTotalServiceFollowUp.Text = "0"
        Me.LblTotalServiceFollowUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Followup Client:"
        '
        'LblTotalPayment
        '
        Me.LblTotalPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalPayment.ForeColor = System.Drawing.Color.Maroon
        Me.LblTotalPayment.Location = New System.Drawing.Point(166, 302)
        Me.LblTotalPayment.Name = "LblTotalPayment"
        Me.LblTotalPayment.Size = New System.Drawing.Size(141, 20)
        Me.LblTotalPayment.TabIndex = 13
        Me.LblTotalPayment.Text = "0"
        Me.LblTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalServiceSpacial
        '
        Me.LblTotalServiceSpacial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalServiceSpacial.ForeColor = System.Drawing.Color.Maroon
        Me.LblTotalServiceSpacial.Location = New System.Drawing.Point(165, 253)
        Me.LblTotalServiceSpacial.Name = "LblTotalServiceSpacial"
        Me.LblTotalServiceSpacial.Size = New System.Drawing.Size(141, 20)
        Me.LblTotalServiceSpacial.TabIndex = 12
        Me.LblTotalServiceSpacial.Text = "0"
        Me.LblTotalServiceSpacial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalServiceContribute
        '
        Me.LblTotalServiceContribute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalServiceContribute.ForeColor = System.Drawing.Color.Maroon
        Me.LblTotalServiceContribute.Location = New System.Drawing.Point(165, 162)
        Me.LblTotalServiceContribute.Name = "LblTotalServiceContribute"
        Me.LblTotalServiceContribute.Size = New System.Drawing.Size(141, 20)
        Me.LblTotalServiceContribute.TabIndex = 11
        Me.LblTotalServiceContribute.Text = "0"
        Me.LblTotalServiceContribute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalServiceMedicine
        '
        Me.LblTotalServiceMedicine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalServiceMedicine.ForeColor = System.Drawing.Color.Maroon
        Me.LblTotalServiceMedicine.Location = New System.Drawing.Point(165, 208)
        Me.LblTotalServiceMedicine.Name = "LblTotalServiceMedicine"
        Me.LblTotalServiceMedicine.Size = New System.Drawing.Size(141, 20)
        Me.LblTotalServiceMedicine.TabIndex = 10
        Me.LblTotalServiceMedicine.Text = "0"
        Me.LblTotalServiceMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalServiceNewConsult
        '
        Me.LblTotalServiceNewConsult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalServiceNewConsult.ForeColor = System.Drawing.Color.Maroon
        Me.LblTotalServiceNewConsult.Location = New System.Drawing.Point(165, 73)
        Me.LblTotalServiceNewConsult.Name = "LblTotalServiceNewConsult"
        Me.LblTotalServiceNewConsult.Size = New System.Drawing.Size(141, 20)
        Me.LblTotalServiceNewConsult.TabIndex = 9
        Me.LblTotalServiceNewConsult.Text = "0"
        Me.LblTotalServiceNewConsult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(90, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total service KHR"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(188, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Spacial service:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(230, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Medicine:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Constribute:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "New Client :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(90, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Service"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridPrescription)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label8)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GridServiceSpacial)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer2.Size = New System.Drawing.Size(150, 46)
        Me.SplitContainer2.SplitterDistance = 75
        Me.SplitContainer2.TabIndex = 0
        '
        'GridPrescription
        '
        Me.GridPrescription.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPrescription.BackColor = System.Drawing.Color.White
        Me.GridPrescription.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridPrescription_DesignTimeLayout.LayoutString = resources.GetString("GridPrescription_DesignTimeLayout.LayoutString")
        Me.GridPrescription.DesignTimeLayout = GridPrescription_DesignTimeLayout
        Me.GridPrescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrescription.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridPrescription.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPrescription.GroupByBoxVisible = False
        Me.GridPrescription.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridPrescription.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPrescription.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPrescription.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPrescription.Location = New System.Drawing.Point(0, 23)
        Me.GridPrescription.Name = "GridPrescription"
        Me.GridPrescription.RecordNavigator = True
        Me.GridPrescription.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridPrescription.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPrescription.Size = New System.Drawing.Size(73, 21)
        Me.GridPrescription.TabIndex = 41
        Me.GridPrescription.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridPrescription.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Medicine Detail"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridServiceSpacial
        '
        Me.GridServiceSpacial.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridServiceSpacial.BackColor = System.Drawing.Color.White
        Me.GridServiceSpacial.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridServiceSpacial_DesignTimeLayout.LayoutString = resources.GetString("GridServiceSpacial_DesignTimeLayout.LayoutString")
        Me.GridServiceSpacial.DesignTimeLayout = GridServiceSpacial_DesignTimeLayout
        Me.GridServiceSpacial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridServiceSpacial.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridServiceSpacial.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridServiceSpacial.GroupByBoxVisible = False
        Me.GridServiceSpacial.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridServiceSpacial.HeaderFormatStyle.ForeColor = System.Drawing.Color.Maroon
        Me.GridServiceSpacial.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridServiceSpacial.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridServiceSpacial.Location = New System.Drawing.Point(0, 23)
        Me.GridServiceSpacial.Name = "GridServiceSpacial"
        Me.GridServiceSpacial.RecordNavigator = True
        Me.GridServiceSpacial.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridServiceSpacial.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridServiceSpacial.Size = New System.Drawing.Size(69, 21)
        Me.GridServiceSpacial.TabIndex = 7
        Me.GridServiceSpacial.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridServiceSpacial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Gainsboro
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 23)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Spacial Service Detail"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(10)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddMoreReceipt, Me.ToolStripSplitButton1, Me.ToolStripSeparator7, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.BtnAddMoreService, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.BtnViewDeleteReceipt, Me.BtnPrintReceiptTemplate, Me.PrintReceiptTamplate})
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1203, 57)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnAddMoreReceipt
        '
        Me.BtnAddMoreReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAddMoreReceipt.Image = CType(resources.GetObject("BtnAddMoreReceipt.Image"), System.Drawing.Image)
        Me.BtnAddMoreReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddMoreReceipt.Name = "BtnAddMoreReceipt"
        Me.BtnAddMoreReceipt.Size = New System.Drawing.Size(127, 54)
        Me.BtnAddMoreReceipt.Text = "    Add More Receipt   "
        Me.BtnAddMoreReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 25
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewClientReceipt, Me.ToolStripMenuItem2, Me.BtnFollowUpClientReceipt, Me.ToolStripMenuItem4, Me.BtnMedClientReceipt, Me.ToolStripMenuItem5, Me.BtnSpacialServiceReceipt, Me.ToolStripMenuItem6, Me.BtnClientContribute})
        Me.ToolStripSplitButton1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(148, 54)
        Me.ToolStripSplitButton1.Text = "Create Receipt   "
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripSplitButton1.Visible = False
        '
        'BtnNewClientReceipt
        '
        Me.BtnNewClientReceipt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnNewClientReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNewClientReceipt.Name = "BtnNewClientReceipt"
        Me.BtnNewClientReceipt.Size = New System.Drawing.Size(244, 26)
        Me.BtnNewClientReceipt.Text = "New Client Receipt"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(241, 6)
        '
        'BtnFollowUpClientReceipt
        '
        Me.BtnFollowUpClientReceipt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnFollowUpClientReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFollowUpClientReceipt.Name = "BtnFollowUpClientReceipt"
        Me.BtnFollowUpClientReceipt.Size = New System.Drawing.Size(244, 26)
        Me.BtnFollowUpClientReceipt.Text = "Followup Client Receipt"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(241, 6)
        Me.ToolStripMenuItem4.Visible = False
        '
        'BtnMedClientReceipt
        '
        Me.BtnMedClientReceipt.DoubleClickEnabled = True
        Me.BtnMedClientReceipt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnMedClientReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMedClientReceipt.Name = "BtnMedClientReceipt"
        Me.BtnMedClientReceipt.Size = New System.Drawing.Size(244, 26)
        Me.BtnMedClientReceipt.Text = "Medicine Cleint Receipt"
        Me.BtnMedClientReceipt.Visible = False
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(241, 6)
        Me.ToolStripMenuItem5.Visible = False
        '
        'BtnSpacialServiceReceipt
        '
        Me.BtnSpacialServiceReceipt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnSpacialServiceReceipt.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSpacialServiceReceipt.Name = "BtnSpacialServiceReceipt"
        Me.BtnSpacialServiceReceipt.Size = New System.Drawing.Size(244, 26)
        Me.BtnSpacialServiceReceipt.Text = "Spacial Service Receipt"
        Me.BtnSpacialServiceReceipt.Visible = False
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(241, 6)
        Me.ToolStripMenuItem6.Visible = False
        '
        'BtnClientContribute
        '
        Me.BtnClientContribute.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnClientContribute.ForeColor = System.Drawing.Color.Maroon
        Me.BtnClientContribute.Name = "BtnClientContribute"
        Me.BtnClientContribute.Size = New System.Drawing.Size(244, 26)
        Me.BtnClientContribute.Text = "Client Contribute Receipt"
        Me.BtnClientContribute.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(160, 54)
        Me.ToolStripButton1.Text = "View Waiting Payment"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 57)
        '
        'BtnAddMoreService
        '
        Me.BtnAddMoreService.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnAddMoreService.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAddMoreService.Image = CType(resources.GetObject("BtnAddMoreService.Image"), System.Drawing.Image)
        Me.BtnAddMoreService.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddMoreService.Name = "BtnAddMoreService"
        Me.BtnAddMoreService.Size = New System.Drawing.Size(141, 54)
        Me.BtnAddMoreService.Text = "     Issuse Receipt    "
        Me.BtnAddMoreService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(109, 54)
        Me.ToolStripButton2.Text = "    Find client   "
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(149, 54)
        Me.ToolStripButton4.Text = "    Re-print receipt    "
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton4.Visible = False
        '
        'BtnViewDeleteReceipt
        '
        Me.BtnViewDeleteReceipt.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnViewDeleteReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnViewDeleteReceipt.Image = CType(resources.GetObject("BtnViewDeleteReceipt.Image"), System.Drawing.Image)
        Me.BtnViewDeleteReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewDeleteReceipt.Name = "BtnViewDeleteReceipt"
        Me.BtnViewDeleteReceipt.Size = New System.Drawing.Size(156, 54)
        Me.BtnViewDeleteReceipt.Text = "View Receipt Deleted"
        Me.BtnViewDeleteReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnPrintReceiptTemplate
        '
        Me.BtnPrintReceiptTemplate.Name = "BtnPrintReceiptTemplate"
        Me.BtnPrintReceiptTemplate.Size = New System.Drawing.Size(6, 57)
        '
        'PrintReceiptTamplate
        '
        Me.PrintReceiptTamplate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.PrintReceiptTamplate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PrintReceiptTamplate.Image = CType(resources.GetObject("PrintReceiptTamplate.Image"), System.Drawing.Image)
        Me.PrintReceiptTamplate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintReceiptTamplate.Name = "PrintReceiptTamplate"
        Me.PrintReceiptTamplate.Size = New System.Drawing.Size(182, 54)
        Me.PrintReceiptTamplate.Text = "  Print Receipt Tamplate   "
        Me.PrintReceiptTamplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtReceiptNo)
        Me.Panel2.Controls.Add(Me.Label44)
        Me.Panel2.Controls.Add(Me.LblTotalSP)
        Me.Panel2.Controls.Add(Me.LblSPFemale)
        Me.Panel2.Controls.Add(Me.LblSPMale)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Controls.Add(Me.LblTotalMedicine)
        Me.Panel2.Controls.Add(Me.LblMedFemale)
        Me.Panel2.Controls.Add(Me.LblMedMale)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.LblTotalFollowup)
        Me.Panel2.Controls.Add(Me.LblFollFemale)
        Me.Panel2.Controls.Add(Me.LblFollMale)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.LblTotalNewCleint)
        Me.Panel2.Controls.Add(Me.LblNewFemale)
        Me.Panel2.Controls.Add(Me.LblNewMale)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Font = New System.Drawing.Font("Kh Battambang", 11.0!)
        Me.Panel2.Location = New System.Drawing.Point(-19, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1433, 10)
        Me.Panel2.TabIndex = 20
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtReceiptNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReceiptNo.Location = New System.Drawing.Point(1205, 34)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.Size = New System.Drawing.Size(205, 35)
        Me.TxtReceiptNo.TabIndex = 32
        '
        'Label44
        '
        Me.Label44.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.Maroon
        Me.Label44.Location = New System.Drawing.Point(1200, 4)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(134, 27)
        Me.Label44.TabIndex = 31
        Me.Label44.Text = "Find by receipt no:"
        '
        'LblTotalSP
        '
        Me.LblTotalSP.AutoSize = True
        Me.LblTotalSP.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblTotalSP.Location = New System.Drawing.Point(784, 59)
        Me.LblTotalSP.Name = "LblTotalSP"
        Me.LblTotalSP.Size = New System.Drawing.Size(17, 22)
        Me.LblTotalSP.TabIndex = 30
        Me.LblTotalSP.Text = "0"
        '
        'LblSPFemale
        '
        Me.LblSPFemale.AutoSize = True
        Me.LblSPFemale.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblSPFemale.Location = New System.Drawing.Point(878, 33)
        Me.LblSPFemale.Name = "LblSPFemale"
        Me.LblSPFemale.Size = New System.Drawing.Size(17, 22)
        Me.LblSPFemale.TabIndex = 29
        Me.LblSPFemale.Text = "0"
        '
        'LblSPMale
        '
        Me.LblSPMale.AutoSize = True
        Me.LblSPMale.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblSPMale.Location = New System.Drawing.Point(785, 30)
        Me.LblSPMale.Name = "LblSPMale"
        Me.LblSPMale.Size = New System.Drawing.Size(17, 22)
        Me.LblSPMale.TabIndex = 28
        Me.LblSPMale.Text = "0"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label37.Location = New System.Drawing.Point(723, 59)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(37, 22)
        Me.Label37.TabIndex = 27
        Me.Label37.Text = "សរុប:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label38.Location = New System.Drawing.Point(833, 33)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(29, 22)
        Me.Label38.TabIndex = 26
        Me.Label38.Text = "ស្រី:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label39.Location = New System.Drawing.Point(720, 30)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(37, 22)
        Me.Label39.TabIndex = 25
        Me.Label39.Text = "ប្រុស:"
        '
        'LblTotalMedicine
        '
        Me.LblTotalMedicine.AutoSize = True
        Me.LblTotalMedicine.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblTotalMedicine.Location = New System.Drawing.Point(537, 57)
        Me.LblTotalMedicine.Name = "LblTotalMedicine"
        Me.LblTotalMedicine.Size = New System.Drawing.Size(17, 22)
        Me.LblTotalMedicine.TabIndex = 24
        Me.LblTotalMedicine.Text = "0"
        '
        'LblMedFemale
        '
        Me.LblMedFemale.AutoSize = True
        Me.LblMedFemale.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblMedFemale.Location = New System.Drawing.Point(617, 30)
        Me.LblMedFemale.Name = "LblMedFemale"
        Me.LblMedFemale.Size = New System.Drawing.Size(17, 22)
        Me.LblMedFemale.TabIndex = 23
        Me.LblMedFemale.Text = "0"
        '
        'LblMedMale
        '
        Me.LblMedMale.AutoSize = True
        Me.LblMedMale.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblMedMale.Location = New System.Drawing.Point(537, 30)
        Me.LblMedMale.Name = "LblMedMale"
        Me.LblMedMale.Size = New System.Drawing.Size(17, 22)
        Me.LblMedMale.TabIndex = 22
        Me.LblMedMale.Text = "0"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label31.Location = New System.Drawing.Point(488, 57)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 22)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "សរុប:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label32.Location = New System.Drawing.Point(578, 30)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(29, 22)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "ស្រី:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label33.Location = New System.Drawing.Point(488, 30)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(37, 22)
        Me.Label33.TabIndex = 19
        Me.Label33.Text = "ប្រុស:"
        '
        'LblTotalFollowup
        '
        Me.LblTotalFollowup.AutoSize = True
        Me.LblTotalFollowup.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblTotalFollowup.Location = New System.Drawing.Point(316, 57)
        Me.LblTotalFollowup.Name = "LblTotalFollowup"
        Me.LblTotalFollowup.Size = New System.Drawing.Size(17, 22)
        Me.LblTotalFollowup.TabIndex = 18
        Me.LblTotalFollowup.Text = "0"
        '
        'LblFollFemale
        '
        Me.LblFollFemale.AutoSize = True
        Me.LblFollFemale.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblFollFemale.Location = New System.Drawing.Point(407, 30)
        Me.LblFollFemale.Name = "LblFollFemale"
        Me.LblFollFemale.Size = New System.Drawing.Size(17, 22)
        Me.LblFollFemale.TabIndex = 17
        Me.LblFollFemale.Text = "0"
        '
        'LblFollMale
        '
        Me.LblFollMale.AutoSize = True
        Me.LblFollMale.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblFollMale.Location = New System.Drawing.Point(315, 30)
        Me.LblFollMale.Name = "LblFollMale"
        Me.LblFollMale.Size = New System.Drawing.Size(17, 22)
        Me.LblFollMale.TabIndex = 16
        Me.LblFollMale.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label25.Location = New System.Drawing.Point(266, 57)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 22)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "សរុប:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label26.Location = New System.Drawing.Point(360, 30)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 22)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "ស្រី:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label27.Location = New System.Drawing.Point(262, 30)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 22)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "ប្រុស:"
        '
        'LblTotalNewCleint
        '
        Me.LblTotalNewCleint.AutoSize = True
        Me.LblTotalNewCleint.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblTotalNewCleint.Location = New System.Drawing.Point(99, 60)
        Me.LblTotalNewCleint.Name = "LblTotalNewCleint"
        Me.LblTotalNewCleint.Size = New System.Drawing.Size(17, 22)
        Me.LblTotalNewCleint.TabIndex = 12
        Me.LblTotalNewCleint.Text = "0"
        '
        'LblNewFemale
        '
        Me.LblNewFemale.AutoSize = True
        Me.LblNewFemale.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblNewFemale.Location = New System.Drawing.Point(178, 32)
        Me.LblNewFemale.Name = "LblNewFemale"
        Me.LblNewFemale.Size = New System.Drawing.Size(17, 22)
        Me.LblNewFemale.TabIndex = 11
        Me.LblNewFemale.Text = "0"
        '
        'LblNewMale
        '
        Me.LblNewMale.AutoSize = True
        Me.LblNewMale.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblNewMale.Location = New System.Drawing.Point(99, 32)
        Me.LblNewMale.Name = "LblNewMale"
        Me.LblNewMale.Size = New System.Drawing.Size(17, 22)
        Me.LblNewMale.TabIndex = 10
        Me.LblNewMale.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(34, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "សរុប:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(713, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(222, 27)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "សេវាកម្មពិសេស(Spacial Service)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(134, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 22)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "ស្រី:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Gray
        Me.Label18.Location = New System.Drawing.Point(668, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(1, 81)
        Me.Label18.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(34, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 22)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "ប្រុស:"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Gray
        Me.Label20.Location = New System.Drawing.Point(455, -1)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(1, 81)
        Me.Label20.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(487, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(144, 27)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "ថ្នាំពេទ្យ (Medicines)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(258, 3)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(181, 27)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "ពិនិត្យឡើងវិញ (Follow-up)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(17, 3)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(210, 27)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = " ការពិគ្រោះជំងឺ ថ្មី(Consultation)"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Gray
        Me.Label24.Location = New System.Drawing.Point(240, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(1, 81)
        Me.Label24.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.DFrom)
        Me.Panel1.Controls.Add(Me.DTo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1400, 64)
        Me.Panel1.TabIndex = 21
        '
        'DashboardWaitingPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "DashboardWaitingPayment"
        Me.Size = New System.Drawing.Size(1400, 801)
        CType(Me.GridClientWaitingPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextWaitingReceipt.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridServiceSpacial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridClientWaitingPayment As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContextWaitingReceipt As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BgPrintReceipt As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnMenuPrintReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUndoReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GridServiceSpacial As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents BtnNewClientReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFollowUpClientReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnMedClientReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSpacialServiceReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblTotalSP As System.Windows.Forms.Label
    Friend WithEvents LblSPFemale As System.Windows.Forms.Label
    Friend WithEvents LblSPMale As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents LblTotalMedicine As System.Windows.Forms.Label
    Friend WithEvents LblMedFemale As System.Windows.Forms.Label
    Friend WithEvents LblMedMale As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents LblTotalFollowup As System.Windows.Forms.Label
    Friend WithEvents LblFollFemale As System.Windows.Forms.Label
    Friend WithEvents LblFollMale As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents LblTotalNewCleint As System.Windows.Forms.Label
    Friend WithEvents LblNewFemale As System.Windows.Forms.Label
    Friend WithEvents LblNewMale As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClientContribute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblTotalServiceSpacial As System.Windows.Forms.Label
    Friend WithEvents LblTotalServiceContribute As System.Windows.Forms.Label
    Friend WithEvents LblTotalServiceMedicine As System.Windows.Forms.Label
    Friend WithEvents LblTotalServiceNewConsult As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblTotalPayment As System.Windows.Forms.Label
    Friend WithEvents GridPrescription As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblTotalServiceFollowUp As System.Windows.Forms.Label
    Friend WithEvents BtnAddMoreService As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnViewDeleteReceipt As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrintReceiptTemplate As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintReceiptTamplate As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnAddMoreReceipt As System.Windows.Forms.ToolStripButton

End Class
