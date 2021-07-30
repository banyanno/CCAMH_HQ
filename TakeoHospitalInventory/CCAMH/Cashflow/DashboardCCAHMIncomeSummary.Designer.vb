<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCCAHMIncomeSummary
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
        Dim GridClientWaitingPayment_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardCCAHMIncomeSummary))
        Dim GridPrescription_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridServiceSpacial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridDialyCashCollection_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridWeekllyCollection_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.TabIncome = New Janus.Windows.UI.Tab.UITab()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridClientWaitingPayment = New Janus.Windows.GridEX.GridEX()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridPrescription = New Janus.Windows.GridEX.GridEX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GridServiceSpacial = New Janus.Windows.GridEX.GridEX()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage()
        Me.GridDialyCashCollection = New Janus.Windows.GridEX.GridEX()
        Me.UiTabPageContrition = New Janus.Windows.UI.Tab.UITabPage()
        Me.GridWeekllyCollection = New Janus.Windows.GridEX.GridEX()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BGLoadingWeeklly = New System.ComponentModel.BackgroundWorker()
        Me.BGloadDiallyCollection = New System.ComponentModel.BackgroundWorker()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ChViewDetial = New System.Windows.Forms.CheckBox()
        Me.GroupPaymentSummary = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnPrintReceipt = New System.Windows.Forms.Button()
        Me.LblTotalServiceFollowUp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTotalPayment = New System.Windows.Forms.Label()
        Me.LblTotalServiceSpacial = New System.Windows.Forms.Label()
        Me.LblTotalServiceContribute = New System.Windows.Forms.Label()
        Me.LblTotalServiceMedicine = New System.Windows.Forms.Label()
        Me.LblTotalServiceNewConsult = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadReceiptClient = New System.Windows.Forms.RadioButton()
        Me.RadClientContribute = New System.Windows.Forms.RadioButton()
        Me.RadDiallyCashCollection = New System.Windows.Forms.RadioButton()
        Me.BGLoadingReceiptDetail = New System.ComponentModel.BackgroundWorker()
        Me.BgPrintReceipt = New System.ComponentModel.BackgroundWorker()
        CType(Me.TabIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabIncome.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridClientWaitingPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridServiceSpacial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.GridDialyCashCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPageContrition.SuspendLayout()
        CType(Me.GridWeekllyCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupPaymentSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabIncome
        '
        Me.TabIncome.BackColor = System.Drawing.SystemColors.Control
        Me.TabIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabIncome.FlatBorderColor = System.Drawing.Color.Cornsilk
        Me.TabIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabIncome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabIncome.ImageSize = New System.Drawing.Size(30, 30)
        Me.TabIncome.Location = New System.Drawing.Point(0, 0)
        Me.TabIncome.Name = "TabIncome"
        Me.TabIncome.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Black
        Me.TabIncome.OfficeCustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabIncome.Size = New System.Drawing.Size(1267, 680)
        Me.TabIncome.TabIndex = 2
        Me.TabIncome.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2, Me.UiTabPageContrition})
        Me.TabIncome.UseCompatibleTextRendering = True
        Me.TabIncome.UseThemes = False
        Me.TabIncome.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.SplitContainer1)
        Me.UiTabPage1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiTabPage1.Image = CType(resources.GetObject("UiTabPage1.Image"), System.Drawing.Image)
        Me.UiTabPage1.Key = "Receipt client detail"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 37)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(1265, 642)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "   Receipt client detail   "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridClientWaitingPayment)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1265, 642)
        Me.SplitContainer1.SplitterDistance = 473
        Me.SplitContainer1.TabIndex = 18
        '
        'GridClientWaitingPayment
        '
        Me.GridClientWaitingPayment.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridClientWaitingPayment.BackColor = System.Drawing.Color.White
        Me.GridClientWaitingPayment.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridClientWaitingPayment.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.AllCells
        GridClientWaitingPayment_DesignTimeLayout.LayoutString = resources.GetString("GridClientWaitingPayment_DesignTimeLayout.LayoutString")
        Me.GridClientWaitingPayment.DesignTimeLayout = GridClientWaitingPayment_DesignTimeLayout
        Me.GridClientWaitingPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientWaitingPayment.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridClientWaitingPayment.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridClientWaitingPayment.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridClientWaitingPayment.GroupByBoxVisible = False
        Me.GridClientWaitingPayment.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridClientWaitingPayment.HeaderFormatStyle.ForeColor = System.Drawing.Color.Maroon
        Me.GridClientWaitingPayment.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridClientWaitingPayment.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridClientWaitingPayment.Location = New System.Drawing.Point(0, 0)
        Me.GridClientWaitingPayment.Name = "GridClientWaitingPayment"
        Me.GridClientWaitingPayment.RecordNavigator = True
        Me.GridClientWaitingPayment.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridClientWaitingPayment.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientWaitingPayment.SettingsKey = "GridClientWaitingPayment"
        Me.GridClientWaitingPayment.Size = New System.Drawing.Size(1265, 473)
        Me.GridClientWaitingPayment.TabIndex = 6
        Me.GridClientWaitingPayment.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridClientWaitingPayment.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridClientWaitingPayment.UseCompatibleTextRendering = False
        Me.GridClientWaitingPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridPrescription)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GridServiceSpacial)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer2.Size = New System.Drawing.Size(1265, 165)
        Me.SplitContainer2.SplitterDistance = 707
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
        Me.GridPrescription.Location = New System.Drawing.Point(0, 29)
        Me.GridPrescription.Name = "GridPrescription"
        Me.GridPrescription.RecordNavigator = True
        Me.GridPrescription.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridPrescription.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPrescription.Size = New System.Drawing.Size(707, 136)
        Me.GridPrescription.TabIndex = 42
        Me.GridPrescription.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridPrescription.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(707, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Medicine Detail"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GridServiceSpacial.Location = New System.Drawing.Point(0, 0)
        Me.GridServiceSpacial.Name = "GridServiceSpacial"
        Me.GridServiceSpacial.RecordNavigator = True
        Me.GridServiceSpacial.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridServiceSpacial.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridServiceSpacial.Size = New System.Drawing.Size(554, 165)
        Me.GridServiceSpacial.TabIndex = 7
        Me.GridServiceSpacial.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridServiceSpacial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Gainsboro
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(554, 165)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Spacial Service Detail"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.GridDialyCashCollection)
        Me.UiTabPage2.Enabled = False
        Me.UiTabPage2.Image = CType(resources.GetObject("UiTabPage2.Image"), System.Drawing.Image)
        Me.UiTabPage2.Key = "DialCashCollection"
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 37)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1265, 642)
        Me.UiTabPage2.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Dially Cash Collection"
        '
        'GridDialyCashCollection
        '
        Me.GridDialyCashCollection.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDialyCashCollection.BackColor = System.Drawing.Color.White
        Me.GridDialyCashCollection.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridDialyCashCollection.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.AllCells
        GridDialyCashCollection_DesignTimeLayout.LayoutString = resources.GetString("GridDialyCashCollection_DesignTimeLayout.LayoutString")
        Me.GridDialyCashCollection.DesignTimeLayout = GridDialyCashCollection_DesignTimeLayout
        Me.GridDialyCashCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDialyCashCollection.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridDialyCashCollection.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridDialyCashCollection.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridDialyCashCollection.GroupByBoxVisible = False
        Me.GridDialyCashCollection.HeaderFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridDialyCashCollection.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridDialyCashCollection.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridDialyCashCollection.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridDialyCashCollection.Location = New System.Drawing.Point(0, 0)
        Me.GridDialyCashCollection.Name = "GridDialyCashCollection"
        Me.GridDialyCashCollection.RecordNavigator = True
        Me.GridDialyCashCollection.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridDialyCashCollection.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDialyCashCollection.SettingsKey = "GridClientWaitingPayment"
        Me.GridDialyCashCollection.Size = New System.Drawing.Size(1265, 642)
        Me.GridDialyCashCollection.TabIndex = 7
        Me.GridDialyCashCollection.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridDialyCashCollection.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDialyCashCollection.UseCompatibleTextRendering = False
        Me.GridDialyCashCollection.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'UiTabPageContrition
        '
        Me.UiTabPageContrition.Controls.Add(Me.GridWeekllyCollection)
        Me.UiTabPageContrition.Enabled = False
        Me.UiTabPageContrition.Image = CType(resources.GetObject("UiTabPageContrition.Image"), System.Drawing.Image)
        Me.UiTabPageContrition.Key = "ClientContributestatement"
        Me.UiTabPageContrition.Location = New System.Drawing.Point(1, 37)
        Me.UiTabPageContrition.Name = "UiTabPageContrition"
        Me.UiTabPageContrition.Size = New System.Drawing.Size(1265, 642)
        Me.UiTabPageContrition.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Navy
        Me.UiTabPageContrition.TabStop = True
        Me.UiTabPageContrition.Text = "Client Contribute statement"
        '
        'GridWeekllyCollection
        '
        Me.GridWeekllyCollection.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridWeekllyCollection.BackColor = System.Drawing.Color.White
        Me.GridWeekllyCollection.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridWeekllyCollection.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.AllCells
        GridWeekllyCollection_DesignTimeLayout.LayoutString = resources.GetString("GridWeekllyCollection_DesignTimeLayout.LayoutString")
        Me.GridWeekllyCollection.DesignTimeLayout = GridWeekllyCollection_DesignTimeLayout
        Me.GridWeekllyCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridWeekllyCollection.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridWeekllyCollection.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridWeekllyCollection.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridWeekllyCollection.GroupByBoxVisible = False
        Me.GridWeekllyCollection.HeaderFormatStyle.BackColor = System.Drawing.Color.OldLace
        Me.GridWeekllyCollection.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridWeekllyCollection.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridWeekllyCollection.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridWeekllyCollection.Location = New System.Drawing.Point(0, 0)
        Me.GridWeekllyCollection.Name = "GridWeekllyCollection"
        Me.GridWeekllyCollection.RecordNavigator = True
        Me.GridWeekllyCollection.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridWeekllyCollection.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridWeekllyCollection.SettingsKey = "GridClientWaitingPayment"
        Me.GridWeekllyCollection.Size = New System.Drawing.Size(1265, 642)
        Me.GridWeekllyCollection.TabIndex = 8
        Me.GridWeekllyCollection.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridWeekllyCollection.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridWeekllyCollection.UseCompatibleTextRendering = False
        Me.GridWeekllyCollection.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(129, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 55)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Print Preview"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(7, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 55)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Preview"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(129, 134)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(106, 24)
        Me.DTo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 27)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Date To:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(7, 134)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(114, 24)
        Me.DFrom.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 27)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Date From:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BGLoadingWeeklly
        '
        '
        'BGloadDiallyCollection
        '
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.ForeColor = System.Drawing.Color.Maroon
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TabIncome)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ChViewDetial)
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupPaymentSummary)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.RadReceiptClient)
        Me.SplitContainer3.Panel2.Controls.Add(Me.RadClientContribute)
        Me.SplitContainer3.Panel2.Controls.Add(Me.DTo)
        Me.SplitContainer3.Panel2.Controls.Add(Me.RadDiallyCashCollection)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.DFrom)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer3.Size = New System.Drawing.Size(1532, 682)
        Me.SplitContainer3.SplitterDistance = 1269
        Me.SplitContainer3.TabIndex = 3
        '
        'ChViewDetial
        '
        Me.ChViewDetial.AutoSize = True
        Me.ChViewDetial.Location = New System.Drawing.Point(143, 12)
        Me.ChViewDetial.Name = "ChViewDetial"
        Me.ChViewDetial.Size = New System.Drawing.Size(103, 17)
        Me.ChViewDetial.TabIndex = 28
        Me.ChViewDetial.Text = "View old version"
        Me.ChViewDetial.UseVisualStyleBackColor = True
        '
        'GroupPaymentSummary
        '
        Me.GroupPaymentSummary.Controls.Add(Me.Label11)
        Me.GroupPaymentSummary.Controls.Add(Me.Label12)
        Me.GroupPaymentSummary.Controls.Add(Me.BtnPrintReceipt)
        Me.GroupPaymentSummary.Controls.Add(Me.LblTotalServiceFollowUp)
        Me.GroupPaymentSummary.Controls.Add(Me.Label1)
        Me.GroupPaymentSummary.Controls.Add(Me.LblTotalPayment)
        Me.GroupPaymentSummary.Controls.Add(Me.LblTotalServiceSpacial)
        Me.GroupPaymentSummary.Controls.Add(Me.LblTotalServiceContribute)
        Me.GroupPaymentSummary.Controls.Add(Me.LblTotalServiceMedicine)
        Me.GroupPaymentSummary.Controls.Add(Me.LblTotalServiceNewConsult)
        Me.GroupPaymentSummary.Controls.Add(Me.Label5)
        Me.GroupPaymentSummary.Controls.Add(Me.Label10)
        Me.GroupPaymentSummary.Controls.Add(Me.Label9)
        Me.GroupPaymentSummary.Controls.Add(Me.Label7)
        Me.GroupPaymentSummary.Controls.Add(Me.Label6)
        Me.GroupPaymentSummary.Controls.Add(Me.Label8)
        Me.GroupPaymentSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPaymentSummary.Location = New System.Drawing.Point(6, 225)
        Me.GroupPaymentSummary.Name = "GroupPaymentSummary"
        Me.GroupPaymentSummary.Size = New System.Drawing.Size(246, 442)
        Me.GroupPaymentSummary.TabIndex = 27
        Me.GroupPaymentSummary.TabStop = False
        Me.GroupPaymentSummary.Text = "Payment summary:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(87, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "0"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(175, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Other:"
        '
        'BtnPrintReceipt
        '
        Me.BtnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintReceipt.Location = New System.Drawing.Point(13, 383)
        Me.BtnPrintReceipt.Name = "BtnPrintReceipt"
        Me.BtnPrintReceipt.Size = New System.Drawing.Size(217, 42)
        Me.BtnPrintReceipt.TabIndex = 16
        Me.BtnPrintReceipt.Text = "Print Receipt"
        Me.BtnPrintReceipt.UseVisualStyleBackColor = True
        '
        'LblTotalServiceFollowUp
        '
        Me.LblTotalServiceFollowUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalServiceFollowUp.ForeColor = System.Drawing.Color.Maroon
        Me.LblTotalServiceFollowUp.Location = New System.Drawing.Point(89, 121)
        Me.LblTotalServiceFollowUp.Name = "LblTotalServiceFollowUp"
        Me.LblTotalServiceFollowUp.Size = New System.Drawing.Size(141, 20)
        Me.LblTotalServiceFollowUp.TabIndex = 15
        Me.LblTotalServiceFollowUp.Text = "0"
        Me.LblTotalServiceFollowUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Followup Client:"
        '
        'LblTotalPayment
        '
        Me.LblTotalPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalPayment.ForeColor = System.Drawing.Color.Maroon
        Me.LblTotalPayment.Location = New System.Drawing.Point(89, 356)
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
        Me.LblTotalServiceSpacial.Location = New System.Drawing.Point(89, 210)
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
        Me.LblTotalServiceContribute.Location = New System.Drawing.Point(87, 263)
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
        Me.LblTotalServiceMedicine.Location = New System.Drawing.Point(87, 163)
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
        Me.LblTotalServiceNewConsult.Location = New System.Drawing.Point(89, 73)
        Me.LblTotalServiceNewConsult.Name = "LblTotalServiceNewConsult"
        Me.LblTotalServiceNewConsult.Size = New System.Drawing.Size(141, 20)
        Me.LblTotalServiceNewConsult.TabIndex = 9
        Me.LblTotalServiceNewConsult.Text = "0"
        Me.LblTotalServiceNewConsult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total service KHR"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(110, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Spacial service:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(152, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Medicine:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(133, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Constribute:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "New Client :"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(9, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 22)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Service"
        '
        'RadReceiptClient
        '
        Me.RadReceiptClient.AutoSize = True
        Me.RadReceiptClient.Checked = True
        Me.RadReceiptClient.Location = New System.Drawing.Point(7, 11)
        Me.RadReceiptClient.Name = "RadReceiptClient"
        Me.RadReceiptClient.Size = New System.Drawing.Size(118, 17)
        Me.RadReceiptClient.TabIndex = 2
        Me.RadReceiptClient.TabStop = True
        Me.RadReceiptClient.Text = "Receipt client detail"
        Me.RadReceiptClient.UseVisualStyleBackColor = True
        '
        'RadClientContribute
        '
        Me.RadClientContribute.AutoSize = True
        Me.RadClientContribute.Location = New System.Drawing.Point(7, 78)
        Me.RadClientContribute.Name = "RadClientContribute"
        Me.RadClientContribute.Size = New System.Drawing.Size(150, 17)
        Me.RadClientContribute.TabIndex = 1
        Me.RadClientContribute.Text = "Client contribute statement"
        Me.RadClientContribute.UseVisualStyleBackColor = True
        '
        'RadDiallyCashCollection
        '
        Me.RadDiallyCashCollection.AutoSize = True
        Me.RadDiallyCashCollection.Location = New System.Drawing.Point(7, 45)
        Me.RadDiallyCashCollection.Name = "RadDiallyCashCollection"
        Me.RadDiallyCashCollection.Size = New System.Drawing.Size(124, 17)
        Me.RadDiallyCashCollection.TabIndex = 0
        Me.RadDiallyCashCollection.Text = "Dially cash collection"
        Me.RadDiallyCashCollection.UseVisualStyleBackColor = True
        '
        'BGLoadingReceiptDetail
        '
        '
        'BgPrintReceipt
        '
        '
        'DashboardCCAHMIncomeSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer3)
        Me.Name = "DashboardCCAHMIncomeSummary"
        Me.Size = New System.Drawing.Size(1532, 682)
        CType(Me.TabIncome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabIncome.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridClientWaitingPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridServiceSpacial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.GridDialyCashCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPageContrition.ResumeLayout(False)
        CType(Me.GridWeekllyCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupPaymentSummary.ResumeLayout(False)
        Me.GroupPaymentSummary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabIncome As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridDialyCashCollection As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPageContrition As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridWeekllyCollection As Janus.Windows.GridEX.GridEX
    Friend WithEvents BGLoadingWeeklly As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGloadDiallyCollection As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridClientWaitingPayment As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridServiceSpacial As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents RadClientContribute As System.Windows.Forms.RadioButton
    Friend WithEvents RadDiallyCashCollection As System.Windows.Forms.RadioButton
    Friend WithEvents RadReceiptClient As System.Windows.Forms.RadioButton
    Friend WithEvents BGLoadingReceiptDetail As System.ComponentModel.BackgroundWorker
    Friend WithEvents GridPrescription As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPaymentSummary As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotalServiceFollowUp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblTotalPayment As System.Windows.Forms.Label
    Friend WithEvents LblTotalServiceSpacial As System.Windows.Forms.Label
    Friend WithEvents LblTotalServiceContribute As System.Windows.Forms.Label
    Friend WithEvents LblTotalServiceMedicine As System.Windows.Forms.Label
    Friend WithEvents LblTotalServiceNewConsult As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents BgPrintReceipt As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ChViewDetial As System.Windows.Forms.CheckBox

End Class
