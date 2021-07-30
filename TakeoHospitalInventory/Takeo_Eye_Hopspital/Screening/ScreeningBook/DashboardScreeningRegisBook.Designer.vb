<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardScreeningRegisBook
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardScreeningRegisBook))
        Dim GridEXScreeningBook_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXReferral_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.NotFillDiagnosis = New System.Windows.Forms.PictureBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.LblTotalNotFillDiagnosis = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.PicStartImport = New System.Windows.Forms.PictureBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.TxtTotalNotYetImport = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridEXScreeningBook = New Janus.Windows.GridEX.GridEX
        Me.CMScreeningBook = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnNewScreeningRegist = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdateScreening = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefraction = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateRefractionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewRefractionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReferral = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnUpdateReferral = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnNewReferral = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnOpticalShop = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnUpdateOpticalshop = New System.Windows.Forms.ToolStripMenuItem
        Me.NewOpticalShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.AdvanceSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ReferralPickup = New System.Windows.Forms.TabPage
        Me.GridEXReferral = New Janus.Windows.GridEX.GridEX
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtPatienNo = New System.Windows.Forms.TextBox
        Me.PicOpticalShop = New System.Windows.Forms.PictureBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.TxtTotalOpticalShop = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.PicReferral = New System.Windows.Forms.PictureBox
        Me.PicRefraction = New System.Windows.Forms.PictureBox
        Me.PicRgister = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TxtTotalReferralSelf = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtTotalReferralPickup = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtTotalRefraction = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanelSend = New System.Windows.Forms.Panel
        Me.TxtTotalRegister = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BGScreeningBook = New System.ComponentModel.BackgroundWorker
        Me.BGImportToTEH = New System.ComponentModel.BackgroundWorker
        Me.VSForOpticalshop = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.NotFillDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PicStartImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridEXScreeningBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMScreeningBook.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ReferralPickup.SuspendLayout()
        CType(Me.GridEXReferral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOpticalShop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PicReferral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRefraction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRgister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelSend.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.NotFillDiagnosis)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.PicStartImport)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.DateTo)
        Me.Panel1.Controls.Add(Me.DateFrom)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.TxtPatienNo)
        Me.Panel1.Controls.Add(Me.PicOpticalShop)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.PicReferral)
        Me.Panel1.Controls.Add(Me.PicRefraction)
        Me.Panel1.Controls.Add(Me.PicRgister)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PanelSend)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1309, 852)
        Me.Panel1.TabIndex = 0
        '
        'NotFillDiagnosis
        '
        Me.NotFillDiagnosis.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.NotFillDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NotFillDiagnosis.Image = CType(resources.GetObject("NotFillDiagnosis.Image"), System.Drawing.Image)
        Me.NotFillDiagnosis.Location = New System.Drawing.Point(758, -1)
        Me.NotFillDiagnosis.Name = "NotFillDiagnosis"
        Me.NotFillDiagnosis.Size = New System.Drawing.Size(40, 38)
        Me.NotFillDiagnosis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NotFillDiagnosis.TabIndex = 33
        Me.NotFillDiagnosis.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.LblTotalNotFillDiagnosis)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel6.Location = New System.Drawing.Point(750, 18)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(143, 70)
        Me.Panel6.TabIndex = 32
        '
        'LblTotalNotFillDiagnosis
        '
        Me.LblTotalNotFillDiagnosis.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblTotalNotFillDiagnosis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTotalNotFillDiagnosis.Location = New System.Drawing.Point(22, 44)
        Me.LblTotalNotFillDiagnosis.Name = "LblTotalNotFillDiagnosis"
        Me.LblTotalNotFillDiagnosis.Size = New System.Drawing.Size(96, 21)
        Me.LblTotalNotFillDiagnosis.TabIndex = 2
        Me.LblTotalNotFillDiagnosis.Text = "0"
        Me.LblTotalNotFillDiagnosis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(2, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Not Fill Daignosis"
        '
        'PicStartImport
        '
        Me.PicStartImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PicStartImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicStartImport.Image = CType(resources.GetObject("PicStartImport.Image"), System.Drawing.Image)
        Me.PicStartImport.Location = New System.Drawing.Point(618, -2)
        Me.PicStartImport.Name = "PicStartImport"
        Me.PicStartImport.Size = New System.Drawing.Size(40, 39)
        Me.PicStartImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicStartImport.TabIndex = 31
        Me.PicStartImport.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TxtTotalNotYetImport)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel5.Location = New System.Drawing.Point(610, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(135, 70)
        Me.Panel5.TabIndex = 30
        '
        'TxtTotalNotYetImport
        '
        Me.TxtTotalNotYetImport.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtTotalNotYetImport.ForeColor = System.Drawing.Color.White
        Me.TxtTotalNotYetImport.Location = New System.Drawing.Point(18, 45)
        Me.TxtTotalNotYetImport.Name = "TxtTotalNotYetImport"
        Me.TxtTotalNotYetImport.Size = New System.Drawing.Size(96, 21)
        Me.TxtTotalNotYetImport.TabIndex = 2
        Me.TxtTotalNotYetImport.Text = "0"
        Me.TxtTotalNotYetImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(2, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Not Yet Import:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(947, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Patient No:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SplitContainer1.Location = New System.Drawing.Point(7, 98)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridEXScreeningBook)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1297, 751)
        Me.SplitContainer1.SplitterDistance = 400
        Me.SplitContainer1.TabIndex = 28
        '
        'GridEXScreeningBook
        '
        Me.GridEXScreeningBook.AllowCardSizing = False
        Me.GridEXScreeningBook.AllowColumnDrag = False
        Me.GridEXScreeningBook.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXScreeningBook.ContextMenuStrip = Me.CMScreeningBook
        GridEXScreeningBook_DesignTimeLayout.LayoutString = resources.GetString("GridEXScreeningBook_DesignTimeLayout.LayoutString")
        Me.GridEXScreeningBook.DesignTimeLayout = GridEXScreeningBook_DesignTimeLayout
        Me.GridEXScreeningBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEXScreeningBook.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.GridEXScreeningBook.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEXScreeningBook.GroupByBoxVisible = False
        Me.GridEXScreeningBook.HeaderFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridEXScreeningBook.HeaderFormatStyle.FontSize = 11.0!
        Me.GridEXScreeningBook.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXScreeningBook.Location = New System.Drawing.Point(0, 0)
        Me.GridEXScreeningBook.Name = "GridEXScreeningBook"
        Me.GridEXScreeningBook.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridEXScreeningBook.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.GridEXScreeningBook.RecordNavigator = True
        Me.GridEXScreeningBook.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXScreeningBook.Size = New System.Drawing.Size(1297, 400)
        Me.GridEXScreeningBook.TabIndex = 26
        Me.GridEXScreeningBook.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridEXScreeningBook.VisualStyleManager = Me.VSForOpticalshop
        '
        'CMScreeningBook
        '
        Me.CMScreeningBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CMScreeningBook.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CMScreeningBook.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CMScreeningBook.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewScreeningRegist, Me.ToolStripSeparator1, Me.BtnUpdateScreening, Me.ToolStripMenuItem1, Me.BtnRefraction, Me.ToolStripMenuItem2, Me.BtnReferral, Me.ToolStripMenuItem3, Me.BtnOpticalShop, Me.ToolStripMenuItem4, Me.AdvanceSearchToolStripMenuItem})
        Me.CMScreeningBook.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.CMScreeningBook.Name = "CMScreeningBook"
        Me.CMScreeningBook.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.CMScreeningBook.ShowImageMargin = False
        Me.CMScreeningBook.Size = New System.Drawing.Size(290, 214)
        '
        'BtnNewScreeningRegist
        '
        Me.BtnNewScreeningRegist.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.BtnNewScreeningRegist.ForeColor = System.Drawing.Color.White
        Me.BtnNewScreeningRegist.Name = "BtnNewScreeningRegist"
        Me.BtnNewScreeningRegist.Size = New System.Drawing.Size(289, 30)
        Me.BtnNewScreeningRegist.Text = "New Registration Screening"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(286, 6)
        '
        'BtnUpdateScreening
        '
        Me.BtnUpdateScreening.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.BtnUpdateScreening.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateScreening.Image = CType(resources.GetObject("BtnUpdateScreening.Image"), System.Drawing.Image)
        Me.BtnUpdateScreening.Name = "BtnUpdateScreening"
        Me.BtnUpdateScreening.Size = New System.Drawing.Size(289, 30)
        Me.BtnUpdateScreening.Text = "Update Screening Utility"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(286, 6)
        '
        'BtnRefraction
        '
        Me.BtnRefraction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateRefractionToolStripMenuItem, Me.NewRefractionToolStripMenuItem})
        Me.BtnRefraction.ForeColor = System.Drawing.Color.White
        Me.BtnRefraction.Name = "BtnRefraction"
        Me.BtnRefraction.Size = New System.Drawing.Size(289, 30)
        Me.BtnRefraction.Text = "Refraction ..."
        Me.BtnRefraction.Visible = False
        '
        'UpdateRefractionToolStripMenuItem
        '
        Me.UpdateRefractionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.UpdateRefractionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UpdateRefractionToolStripMenuItem.Name = "UpdateRefractionToolStripMenuItem"
        Me.UpdateRefractionToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.UpdateRefractionToolStripMenuItem.Text = "Update Refraction"
        '
        'NewRefractionToolStripMenuItem
        '
        Me.NewRefractionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NewRefractionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NewRefractionToolStripMenuItem.Name = "NewRefractionToolStripMenuItem"
        Me.NewRefractionToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.NewRefractionToolStripMenuItem.Text = "New Refraction"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(286, 6)
        Me.ToolStripMenuItem2.Visible = False
        '
        'BtnReferral
        '
        Me.BtnReferral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnUpdateReferral, Me.BtnNewReferral})
        Me.BtnReferral.ForeColor = System.Drawing.Color.White
        Me.BtnReferral.Name = "BtnReferral"
        Me.BtnReferral.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always
        Me.BtnReferral.Size = New System.Drawing.Size(289, 30)
        Me.BtnReferral.Text = "Refer ..."
        Me.BtnReferral.Visible = False
        '
        'BtnUpdateReferral
        '
        Me.BtnUpdateReferral.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.BtnUpdateReferral.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnUpdateReferral.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateReferral.Name = "BtnUpdateReferral"
        Me.BtnUpdateReferral.Size = New System.Drawing.Size(180, 26)
        Me.BtnUpdateReferral.Text = "Upate Referral"
        '
        'BtnNewReferral
        '
        Me.BtnNewReferral.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnNewReferral.ForeColor = System.Drawing.Color.White
        Me.BtnNewReferral.Name = "BtnNewReferral"
        Me.BtnNewReferral.Size = New System.Drawing.Size(180, 26)
        Me.BtnNewReferral.Text = "New Referral"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(286, 6)
        Me.ToolStripMenuItem3.Visible = False
        '
        'BtnOpticalShop
        '
        Me.BtnOpticalShop.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnUpdateOpticalshop, Me.NewOpticalShopToolStripMenuItem})
        Me.BtnOpticalShop.ForeColor = System.Drawing.Color.White
        Me.BtnOpticalShop.Name = "BtnOpticalShop"
        Me.BtnOpticalShop.Size = New System.Drawing.Size(289, 30)
        Me.BtnOpticalShop.Text = "Optical Shop ..."
        Me.BtnOpticalShop.Visible = False
        '
        'BtnUpdateOpticalshop
        '
        Me.BtnUpdateOpticalshop.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnUpdateOpticalshop.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateOpticalshop.Name = "BtnUpdateOpticalshop"
        Me.BtnUpdateOpticalshop.Size = New System.Drawing.Size(223, 26)
        Me.BtnUpdateOpticalshop.Text = "Update Optical Shop"
        '
        'NewOpticalShopToolStripMenuItem
        '
        Me.NewOpticalShopToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NewOpticalShopToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NewOpticalShopToolStripMenuItem.Name = "NewOpticalShopToolStripMenuItem"
        Me.NewOpticalShopToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.NewOpticalShopToolStripMenuItem.Text = "New Optical Shop"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(286, 6)
        Me.ToolStripMenuItem4.Visible = False
        '
        'AdvanceSearchToolStripMenuItem
        '
        Me.AdvanceSearchToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.AdvanceSearchToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdvanceSearchToolStripMenuItem.Name = "AdvanceSearchToolStripMenuItem"
        Me.AdvanceSearchToolStripMenuItem.Size = New System.Drawing.Size(289, 30)
        Me.AdvanceSearchToolStripMenuItem.Text = "Advance Search"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.ReferralPickup)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(250, 29)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(3, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1297, 347)
        Me.TabControl1.TabIndex = 0
        '
        'ReferralPickup
        '
        Me.ReferralPickup.AutoScroll = True
        Me.ReferralPickup.BackColor = System.Drawing.SystemColors.Window
        Me.ReferralPickup.Controls.Add(Me.GridEXReferral)
        Me.ReferralPickup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ReferralPickup.Location = New System.Drawing.Point(4, 33)
        Me.ReferralPickup.Name = "ReferralPickup"
        Me.ReferralPickup.Size = New System.Drawing.Size(1289, 310)
        Me.ReferralPickup.TabIndex = 1
        Me.ReferralPickup.Text = " Refer Pickup  or By Self Book"
        Me.ReferralPickup.UseVisualStyleBackColor = True
        '
        'GridEXReferral
        '
        Me.GridEXReferral.AllowCardSizing = False
        Me.GridEXReferral.AllowColumnDrag = False
        Me.GridEXReferral.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridEXReferral_DesignTimeLayout.LayoutString = resources.GetString("GridEXReferral_DesignTimeLayout.LayoutString")
        Me.GridEXReferral.DesignTimeLayout = GridEXReferral_DesignTimeLayout
        Me.GridEXReferral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEXReferral.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.GridEXReferral.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEXReferral.GroupByBoxVisible = False
        Me.GridEXReferral.HeaderFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridEXReferral.HeaderFormatStyle.FontSize = 11.0!
        Me.GridEXReferral.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.GridEXReferral.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEXReferral.Location = New System.Drawing.Point(0, 0)
        Me.GridEXReferral.Name = "GridEXReferral"
        Me.GridEXReferral.RecordNavigator = True
        Me.GridEXReferral.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEXReferral.Size = New System.Drawing.Size(1289, 310)
        Me.GridEXReferral.TabIndex = 27
        '
        'DateTo
        '
        Me.DateTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(1050, 38)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(247, 27)
        Me.DateTo.TabIndex = 27
        '
        'DateFrom
        '
        Me.DateFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateFrom.CustomFormat = "dd-MM-yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(1050, 6)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(247, 27)
        Me.DateFrom.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(1012, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 21)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "To:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(992, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 21)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "From:"
        '
        'BtnFind
        '
        Me.BtnFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatAppearance.BorderSize = 0
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(1255, 69)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(42, 27)
        Me.BtnFind.TabIndex = 19
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'TxtPatienNo
        '
        Me.TxtPatienNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPatienNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatienNo.Location = New System.Drawing.Point(1050, 69)
        Me.TxtPatienNo.Name = "TxtPatienNo"
        Me.TxtPatienNo.Size = New System.Drawing.Size(205, 27)
        Me.TxtPatienNo.TabIndex = 18
        '
        'PicOpticalShop
        '
        Me.PicOpticalShop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PicOpticalShop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicOpticalShop.Image = CType(resources.GetObject("PicOpticalShop.Image"), System.Drawing.Image)
        Me.PicOpticalShop.Location = New System.Drawing.Point(487, -1)
        Me.PicOpticalShop.Name = "PicOpticalShop"
        Me.PicOpticalShop.Size = New System.Drawing.Size(40, 38)
        Me.PicOpticalShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicOpticalShop.TabIndex = 17
        Me.PicOpticalShop.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TxtTotalOpticalShop)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Location = New System.Drawing.Point(479, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(125, 70)
        Me.Panel4.TabIndex = 16
        '
        'TxtTotalOpticalShop
        '
        Me.TxtTotalOpticalShop.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtTotalOpticalShop.ForeColor = System.Drawing.Color.White
        Me.TxtTotalOpticalShop.Location = New System.Drawing.Point(13, 44)
        Me.TxtTotalOpticalShop.Name = "TxtTotalOpticalShop"
        Me.TxtTotalOpticalShop.Size = New System.Drawing.Size(96, 21)
        Me.TxtTotalOpticalShop.TabIndex = 2
        Me.TxtTotalOpticalShop.Text = "0"
        Me.TxtTotalOpticalShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(2, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Optical Shop:"
        '
        'PicReferral
        '
        Me.PicReferral.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PicReferral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicReferral.Image = CType(resources.GetObject("PicReferral.Image"), System.Drawing.Image)
        Me.PicReferral.Location = New System.Drawing.Point(322, -1)
        Me.PicReferral.Name = "PicReferral"
        Me.PicReferral.Size = New System.Drawing.Size(40, 38)
        Me.PicReferral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicReferral.TabIndex = 15
        Me.PicReferral.TabStop = False
        '
        'PicRefraction
        '
        Me.PicRefraction.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PicRefraction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRefraction.Image = CType(resources.GetObject("PicRefraction.Image"), System.Drawing.Image)
        Me.PicRefraction.Location = New System.Drawing.Point(178, 0)
        Me.PicRefraction.Name = "PicRefraction"
        Me.PicRefraction.Size = New System.Drawing.Size(40, 38)
        Me.PicRefraction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRefraction.TabIndex = 14
        Me.PicRefraction.TabStop = False
        '
        'PicRgister
        '
        Me.PicRgister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PicRgister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRgister.Image = CType(resources.GetObject("PicRgister.Image"), System.Drawing.Image)
        Me.PicRgister.Location = New System.Drawing.Point(17, 0)
        Me.PicRgister.Name = "PicRgister"
        Me.PicRgister.Size = New System.Drawing.Size(40, 38)
        Me.PicRgister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRgister.TabIndex = 13
        Me.PicRgister.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtTotalReferralSelf)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TxtTotalReferralPickup)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(314, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 70)
        Me.Panel3.TabIndex = 10
        '
        'TxtTotalReferralSelf
        '
        Me.TxtTotalReferralSelf.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtTotalReferralSelf.ForeColor = System.Drawing.Color.White
        Me.TxtTotalReferralSelf.Location = New System.Drawing.Point(108, 45)
        Me.TxtTotalReferralSelf.Name = "TxtTotalReferralSelf"
        Me.TxtTotalReferralSelf.Size = New System.Drawing.Size(50, 21)
        Me.TxtTotalReferralSelf.TabIndex = 5
        Me.TxtTotalReferralSelf.Text = "0"
        Me.TxtTotalReferralSelf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 21)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total By Self:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total Pickup:"
        '
        'TxtTotalReferralPickup
        '
        Me.TxtTotalReferralPickup.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtTotalReferralPickup.ForeColor = System.Drawing.Color.White
        Me.TxtTotalReferralPickup.Location = New System.Drawing.Point(108, 21)
        Me.TxtTotalReferralPickup.Name = "TxtTotalReferralPickup"
        Me.TxtTotalReferralPickup.Size = New System.Drawing.Size(50, 21)
        Me.TxtTotalReferralPickup.TabIndex = 2
        Me.TxtTotalReferralPickup.Text = "0"
        Me.TxtTotalReferralPickup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(67, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Refer"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtTotalRefraction)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(170, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(139, 70)
        Me.Panel2.TabIndex = 9
        '
        'TxtTotalRefraction
        '
        Me.TxtTotalRefraction.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtTotalRefraction.ForeColor = System.Drawing.Color.White
        Me.TxtTotalRefraction.Location = New System.Drawing.Point(20, 45)
        Me.TxtTotalRefraction.Name = "TxtTotalRefraction"
        Me.TxtTotalRefraction.Size = New System.Drawing.Size(96, 21)
        Me.TxtTotalRefraction.TabIndex = 2
        Me.TxtTotalRefraction.Text = "0"
        Me.TxtTotalRefraction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Refraction"
        '
        'PanelSend
        '
        Me.PanelSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PanelSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSend.Controls.Add(Me.TxtTotalRegister)
        Me.PanelSend.Controls.Add(Me.Label1)
        Me.PanelSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelSend.Location = New System.Drawing.Point(9, 19)
        Me.PanelSend.Name = "PanelSend"
        Me.PanelSend.Size = New System.Drawing.Size(156, 70)
        Me.PanelSend.TabIndex = 8
        '
        'TxtTotalRegister
        '
        Me.TxtTotalRegister.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtTotalRegister.ForeColor = System.Drawing.Color.White
        Me.TxtTotalRegister.Location = New System.Drawing.Point(29, 45)
        Me.TxtTotalRegister.Name = "TxtTotalRegister"
        Me.TxtTotalRegister.Size = New System.Drawing.Size(96, 21)
        Me.TxtTotalRegister.TabIndex = 2
        Me.TxtTotalRegister.Text = "0"
        Me.TxtTotalRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Registration"
        '
        'BGScreeningBook
        '
        '
        'BGImportToTEH
        '
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
        'DashboardScreeningRegisBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "DashboardScreeningRegisBook"
        Me.Size = New System.Drawing.Size(1320, 863)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NotFillDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PicStartImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridEXScreeningBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMScreeningBook.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ReferralPickup.ResumeLayout(False)
        CType(Me.GridEXReferral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOpticalShop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PicReferral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRefraction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRgister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelSend.ResumeLayout(False)
        Me.PanelSend.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelSend As System.Windows.Forms.Panel
    Friend WithEvents TxtTotalRegister As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TxtTotalReferralPickup As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtTotalRefraction As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PicRgister As System.Windows.Forms.PictureBox
    Friend WithEvents PicRefraction As System.Windows.Forms.PictureBox
    Friend WithEvents PicReferral As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalReferralSelf As System.Windows.Forms.Label
    Friend WithEvents PicOpticalShop As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TxtTotalOpticalShop As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtPatienNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReferralPickup As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMScreeningBook As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateScreening As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefraction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReferral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnOpticalShop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewScreeningRegist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRefractionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRefractionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnUpdateReferral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnNewReferral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnUpdateOpticalshop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewOpticalShopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BGScreeningBook As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicStartImport As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TxtTotalNotYetImport As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BGImportToTEH As System.ComponentModel.BackgroundWorker
    Friend WithEvents NotFillDiagnosis As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LblTotalNotFillDiagnosis As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AdvanceSearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridEXScreeningBook As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEXReferral As Janus.Windows.GridEX.GridEX
    Friend WithEvents VSForOpticalshop As Janus.Windows.Common.VisualStyleManager

End Class
