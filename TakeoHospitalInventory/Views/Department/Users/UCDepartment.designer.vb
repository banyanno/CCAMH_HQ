<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDepartment))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.LsDepartment = New System.Windows.Forms.ListView
        Me.ContextDepartment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuGrantToDepart = New System.Windows.Forms.ToolStripMenuItem
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LsPermistion = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMenuEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnViewAllPermission = New System.Windows.Forms.ToolStripButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LsUser = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ToolStripUser = New System.Windows.Forms.ToolStrip
        Me.BtnNewUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEditUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnChangePassword = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnViewAllUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNew = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPermission = New System.Windows.Forms.ToolStripButton
        Me.BgLoadingDepartment = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextDepartment.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStripUser.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(952, 221)
        Me.SplitContainer1.SplitterDistance = 653
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1
        '
        'LsDepartment
        '
        Me.LsDepartment.BackColor = System.Drawing.Color.White
        Me.LsDepartment.BackgroundImageTiled = True
        Me.LsDepartment.ContextMenuStrip = Me.ContextDepartment
        Me.LsDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsDepartment.ForeColor = System.Drawing.Color.Navy
        Me.LsDepartment.HideSelection = False
        Me.LsDepartment.LargeImageList = Me.ImgList
        Me.LsDepartment.Location = New System.Drawing.Point(3, 77)
        Me.LsDepartment.Margin = New System.Windows.Forms.Padding(15)
        Me.LsDepartment.MultiSelect = False
        Me.LsDepartment.Name = "LsDepartment"
        Me.LsDepartment.Size = New System.Drawing.Size(647, 141)
        Me.LsDepartment.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LsDepartment.TabIndex = 1
        Me.LsDepartment.UseCompatibleStateImageBehavior = False
        '
        'ContextDepartment
        '
        Me.ContextDepartment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuGrantToDepart})
        Me.ContextDepartment.Name = "ContextMenuStrip1"
        Me.ContextDepartment.Size = New System.Drawing.Size(142, 26)
        '
        'MenuGrantToDepart
        '
        Me.MenuGrantToDepart.Name = "MenuGrantToDepart"
        Me.MenuGrantToDepart.Size = New System.Drawing.Size(141, 22)
        Me.MenuGrantToDepart.Text = "Permission..."
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "Merchant Account_50px.png")
        Me.ImgList.Images.SetKeyName(1, "Menu_50px.png")
        Me.ImgList.Images.SetKeyName(2, "Team_50px.png")
        Me.ImgList.Images.SetKeyName(3, "Client Management_30px.png")
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(952, 217)
        Me.SplitContainer2.SplitterDistance = 652
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LsPermistion)
        Me.GroupBox3.Controls.Add(Me.ToolStrip2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox3.Size = New System.Drawing.Size(296, 221)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Permission of Departement"
        '
        'LsPermistion
        '
        Me.LsPermistion.BackColor = System.Drawing.Color.White
        Me.LsPermistion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LsPermistion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LsPermistion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsPermistion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsPermistion.ForeColor = System.Drawing.Color.Navy
        Me.LsPermistion.HideSelection = False
        Me.LsPermistion.LargeImageList = Me.ImgList
        Me.LsPermistion.Location = New System.Drawing.Point(2, 71)
        Me.LsPermistion.MultiSelect = False
        Me.LsPermistion.Name = "LsPermistion"
        Me.LsPermistion.Size = New System.Drawing.Size(292, 149)
        Me.LsPermistion.TabIndex = 5
        Me.LsPermistion.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "NO"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 85
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Login Name"
        Me.ColumnHeader7.Width = 108
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Password"
        Me.ColumnHeader8.Width = 84
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator11, Me.BtnMenuEdit, Me.ToolStripSeparator8, Me.BtnViewAllPermission})
        Me.ToolStrip2.Location = New System.Drawing.Point(2, 20)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(292, 51)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(141, 48)
        Me.ToolStripButton1.Text = "   New Permission   "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 51)
        '
        'BtnMenuEdit
        '
        Me.BtnMenuEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMenuEdit.Image = CType(resources.GetObject("BtnMenuEdit.Image"), System.Drawing.Image)
        Me.BtnMenuEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMenuEdit.Name = "BtnMenuEdit"
        Me.BtnMenuEdit.Size = New System.Drawing.Size(95, 48)
        Me.BtnMenuEdit.Text = "       Edit       "
        Me.BtnMenuEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 51)
        '
        'BtnViewAllPermission
        '
        Me.BtnViewAllPermission.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnViewAllPermission.Image = CType(resources.GetObject("BtnViewAllPermission.Image"), System.Drawing.Image)
        Me.BtnViewAllPermission.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewAllPermission.Name = "BtnViewAllPermission"
        Me.BtnViewAllPermission.Size = New System.Drawing.Size(142, 48)
        Me.BtnViewAllPermission.Text = "      Refresh Data     "
        Me.BtnViewAllPermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LsUser)
        Me.GroupBox4.Controls.Add(Me.ToolStripUser)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox4.Size = New System.Drawing.Size(652, 217)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Users in department"
        '
        'LsUser
        '
        Me.LsUser.BackColor = System.Drawing.Color.White
        Me.LsUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LsUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LsUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LsUser.HideSelection = False
        Me.LsUser.LargeImageList = Me.ImgList
        Me.LsUser.Location = New System.Drawing.Point(2, 71)
        Me.LsUser.MultiSelect = False
        Me.LsUser.Name = "LsUser"
        Me.LsUser.Size = New System.Drawing.Size(648, 145)
        Me.LsUser.TabIndex = 1
        Me.LsUser.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NO"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 85
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Login Name"
        Me.ColumnHeader3.Width = 108
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Password"
        Me.ColumnHeader4.Width = 84
        '
        'ToolStripUser
        '
        Me.ToolStripUser.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripUser.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStripUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewUser, Me.ToolStripSeparator6, Me.BtnEditUser, Me.ToolStripSeparator12, Me.BtnChangePassword, Me.ToolStripSeparator7, Me.BtnViewAllUser, Me.ToolStripSeparator4, Me.BtnDeleteUser})
        Me.ToolStripUser.Location = New System.Drawing.Point(2, 20)
        Me.ToolStripUser.Name = "ToolStripUser"
        Me.ToolStripUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStripUser.Size = New System.Drawing.Size(648, 51)
        Me.ToolStripUser.TabIndex = 3
        Me.ToolStripUser.Text = "ToolStrip2"
        '
        'BtnNewUser
        '
        Me.BtnNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNewUser.Image = CType(resources.GetObject("BtnNewUser.Image"), System.Drawing.Image)
        Me.BtnNewUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewUser.Name = "BtnNewUser"
        Me.BtnNewUser.Size = New System.Drawing.Size(132, 48)
        Me.BtnNewUser.Text = "       New User       "
        Me.BtnNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 51)
        '
        'BtnEditUser
        '
        Me.BtnEditUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEditUser.Image = CType(resources.GetObject("BtnEditUser.Image"), System.Drawing.Image)
        Me.BtnEditUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditUser.Name = "BtnEditUser"
        Me.BtnEditUser.Size = New System.Drawing.Size(91, 48)
        Me.BtnEditUser.Text = "       Edit      "
        Me.BtnEditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 51)
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnChangePassword.Image = Global.KTGSYS.My.Resources.Resources.RightLeft2Red
        Me.BtnChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.Size = New System.Drawing.Size(168, 48)
        Me.BtnChangePassword.Text = "     Change Password     "
        Me.BtnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 51)
        '
        'BtnViewAllUser
        '
        Me.BtnViewAllUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnViewAllUser.Image = CType(resources.GetObject("BtnViewAllUser.Image"), System.Drawing.Image)
        Me.BtnViewAllUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnViewAllUser.Name = "BtnViewAllUser"
        Me.BtnViewAllUser.Size = New System.Drawing.Size(142, 48)
        Me.BtnViewAllUser.Text = "      Refresh Data     "
        Me.BtnViewAllUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 51)
        '
        'BtnDeleteUser
        '
        Me.BtnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteUser.Image = CType(resources.GetObject("BtnDeleteUser.Image"), System.Drawing.Image)
        Me.BtnDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteUser.Name = "BtnDeleteUser"
        Me.BtnDeleteUser.Size = New System.Drawing.Size(90, 48)
        Me.BtnDeleteUser.Text = "Delete User"
        Me.BtnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.BtnRefresh, Me.ToolStripSeparator3, Me.BtnPermission})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 20)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(647, 57)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.AutoSize = False
        Me.BtnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(102, 54)
        Me.BtnNew.Text = "New "
        Me.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = False
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(102, 54)
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 57)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.AutoSize = False
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(120, 54)
        Me.BtnRefresh.Text = "Refresh Data"
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 57)
        '
        'BtnPermission
        '
        Me.BtnPermission.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPermission.Image = CType(resources.GetObject("BtnPermission.Image"), System.Drawing.Image)
        Me.BtnPermission.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPermission.Name = "BtnPermission"
        Me.BtnPermission.Size = New System.Drawing.Size(137, 54)
        Me.BtnPermission.Text = "Permission Of Dep-"
        Me.BtnPermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BgLoadingDepartment
        '
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer3.Size = New System.Drawing.Size(952, 442)
        Me.SplitContainer3.SplitterDistance = 221
        Me.SplitContainer3.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LsDepartment)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 221)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Department"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 217)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Detail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date Create:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Function:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 26)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(174, 26)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(14, 117)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(274, 94)
        Me.TextBox3.TabIndex = 5
        '
        'UCDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.SplitContainer3)
        Me.Name = "UCDepartment"
        Me.Size = New System.Drawing.Size(952, 442)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextDepartment.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStripUser.ResumeLayout(False)
        Me.ToolStripUser.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents BgLoadingDepartment As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents LsDepartment As System.Windows.Forms.ListView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LsUser As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents BtnNewUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnChangePassword As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewAllUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewAllPermission As System.Windows.Forms.ToolStripButton
    Friend WithEvents LsPermistion As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextDepartment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuGrantToDepart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripUser As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPermission As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnMenuEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
