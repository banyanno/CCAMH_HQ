<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMUpdateUserInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMUpdateUserInventory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CbMSManager = New System.Windows.Forms.CheckBox
        Me.CbHosManager = New System.Windows.Forms.CheckBox
        Me.CboDepartment = New System.Windows.Forms.ComboBox
        Me.TxtUserLogin = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.ErrUpdateUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TxtTempUserLogin = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridEODAccessRight = New System.Windows.Forms.DataGridView
        Me.cDepartID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cDepartName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.CbDepartment = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrUpdateUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridEODAccessRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbMSManager)
        Me.GroupBox1.Controls.Add(Me.CbHosManager)
        Me.GroupBox1.Controls.Add(Me.CboDepartment)
        Me.GroupBox1.Controls.Add(Me.TxtUserLogin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(324, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update User"
        '
        'CbMSManager
        '
        Me.CbMSManager.AutoSize = True
        Me.CbMSManager.Location = New System.Drawing.Point(346, 46)
        Me.CbMSManager.Name = "CbMSManager"
        Me.CbMSManager.Size = New System.Drawing.Size(125, 17)
        Me.CbMSManager.TabIndex = 12
        Me.CbMSManager.Text = "Main Stock Manager"
        Me.CbMSManager.UseVisualStyleBackColor = True
        '
        'CbHosManager
        '
        Me.CbHosManager.AutoSize = True
        Me.CbHosManager.Location = New System.Drawing.Point(346, 23)
        Me.CbHosManager.Name = "CbHosManager"
        Me.CbHosManager.Size = New System.Drawing.Size(104, 17)
        Me.CbHosManager.TabIndex = 11
        Me.CbHosManager.Text = "Hopital Manager"
        Me.CbHosManager.UseVisualStyleBackColor = True
        '
        'CboDepartment
        '
        Me.CboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDepartment.FormattingEnabled = True
        Me.CboDepartment.Location = New System.Drawing.Point(81, 63)
        Me.CboDepartment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CboDepartment.Name = "CboDepartment"
        Me.CboDepartment.Size = New System.Drawing.Size(228, 28)
        Me.CboDepartment.TabIndex = 2
        '
        'TxtUserLogin
        '
        Me.TxtUserLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUserLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserLogin.Location = New System.Drawing.Point(81, 23)
        Me.TxtUserLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtUserLogin.Name = "TxtUserLogin"
        Me.TxtUserLogin.Size = New System.Drawing.Size(228, 26)
        Me.TxtUserLogin.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Department:*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login:*"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(201, 120)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(64, 28)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(270, 120)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(62, 28)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(3, 135)
        Me.LblSaveOption.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 0
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'ErrUpdateUser
        '
        Me.ErrUpdateUser.ContainerControl = Me
        '
        'TxtTempUserLogin
        '
        Me.TxtTempUserLogin.Location = New System.Drawing.Point(22, 134)
        Me.TxtTempUserLogin.Name = "TxtTempUserLogin"
        Me.TxtTempUserLogin.Size = New System.Drawing.Size(100, 20)
        Me.TxtTempUserLogin.TabIndex = 3
        Me.TxtTempUserLogin.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridEODAccessRight)
        Me.GroupBox3.Controls.Add(Me.BtnRemove)
        Me.GroupBox3.Controls.Add(Me.BtnAdd)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.CbDepartment)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 188)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(525, 193)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "End-of-Day Access Rights"
        Me.GroupBox3.Visible = False
        '
        'GridEODAccessRight
        '
        Me.GridEODAccessRight.AllowUserToAddRows = False
        Me.GridEODAccessRight.BackgroundColor = System.Drawing.SystemColors.Window
        Me.GridEODAccessRight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridEODAccessRight.ColumnHeadersHeight = 35
        Me.GridEODAccessRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridEODAccessRight.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cDepartID, Me.cDepartName})
        Me.GridEODAccessRight.Location = New System.Drawing.Point(14, 48)
        Me.GridEODAccessRight.Name = "GridEODAccessRight"
        Me.GridEODAccessRight.RowTemplate.Height = 24
        Me.GridEODAccessRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridEODAccessRight.Size = New System.Drawing.Size(488, 139)
        Me.GridEODAccessRight.TabIndex = 26
        '
        'cDepartID
        '
        Me.cDepartID.HeaderText = "DepartmentID"
        Me.cDepartID.Name = "cDepartID"
        Me.cDepartID.Visible = False
        '
        'cDepartName
        '
        Me.cDepartName.HeaderText = "Department"
        Me.cDepartName.Name = "cDepartName"
        Me.cDepartName.Width = 300
        '
        'BtnRemove
        '
        Me.BtnRemove.Image = Global.KTGSYS.My.Resources.Resources.cross_circle
        Me.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemove.Location = New System.Drawing.Point(420, 19)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(82, 23)
        Me.BtnRemove.TabIndex = 9
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Image = Global.KTGSYS.My.Resources.Resources.plus_circle
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(339, 19)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 24)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Department:"
        '
        'CbDepartment
        '
        Me.CbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDepartment.FormattingEnabled = True
        Me.CbDepartment.Location = New System.Drawing.Point(92, 18)
        Me.CbDepartment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CbDepartment.Name = "CbDepartment"
        Me.CbDepartment.Size = New System.Drawing.Size(204, 24)
        Me.CbDepartment.TabIndex = 5
        '
        'FRMUpdateUserInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 153)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TxtTempUserLogin)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMUpdateUserInventory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrUpdateUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridEODAccessRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents CboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents TxtUserLogin As System.Windows.Forms.TextBox
    Friend WithEvents ErrUpdateUser As System.Windows.Forms.ErrorProvider
    Friend WithEvents CbMSManager As System.Windows.Forms.CheckBox
    Friend WithEvents CbHosManager As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTempUserLogin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridEODAccessRight As System.Windows.Forms.DataGridView
    Friend WithEvents cDepartID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDepartName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CbDepartment As System.Windows.Forms.ComboBox
End Class
