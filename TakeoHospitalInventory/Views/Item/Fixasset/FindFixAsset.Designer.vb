<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindFixAsset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindFixAsset))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboAssetLocation = New System.Windows.Forms.ComboBox()
        Me.CboAssetCategory = New System.Windows.Forms.ComboBox()
        Me.TxtAssetUser = New System.Windows.Forms.TextBox()
        Me.TxtAssetDescription = New System.Windows.Forms.TextBox()
        Me.RadAssetUser = New System.Windows.Forms.RadioButton()
        Me.RadAssetName = New System.Windows.Forms.RadioButton()
        Me.RadAssetLocation = New System.Windows.Forms.RadioButton()
        Me.RadAssetCategory = New System.Windows.Forms.RadioButton()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.CboAssetStatus = New System.Windows.Forms.ComboBox()
        Me.RadAssetStatus = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadAssetStatus)
        Me.GroupBox1.Controls.Add(Me.CboAssetStatus)
        Me.GroupBox1.Controls.Add(Me.CboAssetLocation)
        Me.GroupBox1.Controls.Add(Me.CboAssetCategory)
        Me.GroupBox1.Controls.Add(Me.TxtAssetUser)
        Me.GroupBox1.Controls.Add(Me.TxtAssetDescription)
        Me.GroupBox1.Controls.Add(Me.RadAssetUser)
        Me.GroupBox1.Controls.Add(Me.RadAssetName)
        Me.GroupBox1.Controls.Add(Me.RadAssetLocation)
        Me.GroupBox1.Controls.Add(Me.RadAssetCategory)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(384, 336)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Asset By:"
        '
        'CboAssetLocation
        '
        Me.CboAssetLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAssetLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAssetLocation.Enabled = False
        Me.CboAssetLocation.FormattingEnabled = True
        Me.CboAssetLocation.Location = New System.Drawing.Point(20, 237)
        Me.CboAssetLocation.Name = "CboAssetLocation"
        Me.CboAssetLocation.Size = New System.Drawing.Size(343, 26)
        Me.CboAssetLocation.TabIndex = 7
        '
        'CboAssetCategory
        '
        Me.CboAssetCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAssetCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAssetCategory.DropDownWidth = 500
        Me.CboAssetCategory.FormattingEnabled = True
        Me.CboAssetCategory.Location = New System.Drawing.Point(20, 54)
        Me.CboAssetCategory.Name = "CboAssetCategory"
        Me.CboAssetCategory.Size = New System.Drawing.Size(343, 26)
        Me.CboAssetCategory.TabIndex = 1
        '
        'TxtAssetUser
        '
        Me.TxtAssetUser.Enabled = False
        Me.TxtAssetUser.Location = New System.Drawing.Point(20, 176)
        Me.TxtAssetUser.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAssetUser.Name = "TxtAssetUser"
        Me.TxtAssetUser.Size = New System.Drawing.Size(343, 24)
        Me.TxtAssetUser.TabIndex = 5
        '
        'TxtAssetDescription
        '
        Me.TxtAssetDescription.Enabled = False
        Me.TxtAssetDescription.Location = New System.Drawing.Point(20, 114)
        Me.TxtAssetDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAssetDescription.Name = "TxtAssetDescription"
        Me.TxtAssetDescription.Size = New System.Drawing.Size(343, 24)
        Me.TxtAssetDescription.TabIndex = 3
        '
        'RadAssetUser
        '
        Me.RadAssetUser.AutoSize = True
        Me.RadAssetUser.Location = New System.Drawing.Point(20, 146)
        Me.RadAssetUser.Margin = New System.Windows.Forms.Padding(4)
        Me.RadAssetUser.Name = "RadAssetUser"
        Me.RadAssetUser.Size = New System.Drawing.Size(62, 22)
        Me.RadAssetUser.TabIndex = 4
        Me.RadAssetUser.Text = "User:"
        Me.RadAssetUser.UseVisualStyleBackColor = True
        '
        'RadAssetName
        '
        Me.RadAssetName.AutoSize = True
        Me.RadAssetName.Location = New System.Drawing.Point(20, 81)
        Me.RadAssetName.Margin = New System.Windows.Forms.Padding(4)
        Me.RadAssetName.Name = "RadAssetName"
        Me.RadAssetName.Size = New System.Drawing.Size(146, 22)
        Me.RadAssetName.TabIndex = 2
        Me.RadAssetName.Text = "Asset Description:"
        Me.RadAssetName.UseVisualStyleBackColor = True
        '
        'RadAssetLocation
        '
        Me.RadAssetLocation.AutoSize = True
        Me.RadAssetLocation.Location = New System.Drawing.Point(20, 208)
        Me.RadAssetLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.RadAssetLocation.Name = "RadAssetLocation"
        Me.RadAssetLocation.Size = New System.Drawing.Size(87, 22)
        Me.RadAssetLocation.TabIndex = 6
        Me.RadAssetLocation.Text = "Location:"
        Me.RadAssetLocation.UseVisualStyleBackColor = True
        '
        'RadAssetCategory
        '
        Me.RadAssetCategory.AutoSize = True
        Me.RadAssetCategory.Checked = True
        Me.RadAssetCategory.Location = New System.Drawing.Point(20, 25)
        Me.RadAssetCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.RadAssetCategory.Name = "RadAssetCategory"
        Me.RadAssetCategory.Size = New System.Drawing.Size(131, 22)
        Me.RadAssetCategory.TabIndex = 0
        Me.RadAssetCategory.TabStop = True
        Me.RadAssetCategory.Text = "Asset Category:"
        Me.RadAssetCategory.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Location = New System.Drawing.Point(214, 345)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(84, 35)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(303, 345)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 35)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CboAssetStatus
        '
        Me.CboAssetStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAssetStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAssetStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAssetStatus.DropDownWidth = 350
        Me.CboAssetStatus.FormattingEnabled = True
        Me.CboAssetStatus.Items.AddRange(New Object() {"ACTUAL", "DISPOSAL"})
        Me.CboAssetStatus.Location = New System.Drawing.Point(20, 294)
        Me.CboAssetStatus.Name = "CboAssetStatus"
        Me.CboAssetStatus.Size = New System.Drawing.Size(343, 26)
        Me.CboAssetStatus.TabIndex = 8
        '
        'RadAssetStatus
        '
        Me.RadAssetStatus.AutoSize = True
        Me.RadAssetStatus.Location = New System.Drawing.Point(20, 270)
        Me.RadAssetStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.RadAssetStatus.Name = "RadAssetStatus"
        Me.RadAssetStatus.Size = New System.Drawing.Size(113, 22)
        Me.RadAssetStatus.TabIndex = 9
        Me.RadAssetStatus.Text = "Asset Status:"
        Me.RadAssetStatus.UseVisualStyleBackColor = True
        '
        'FindFixAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 387)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindFixAsset"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Fix Asset"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAssetUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtAssetDescription As System.Windows.Forms.TextBox
    Friend WithEvents RadAssetUser As System.Windows.Forms.RadioButton
    Friend WithEvents RadAssetName As System.Windows.Forms.RadioButton
    Friend WithEvents RadAssetLocation As System.Windows.Forms.RadioButton
    Friend WithEvents RadAssetCategory As System.Windows.Forms.RadioButton
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents CboAssetLocation As System.Windows.Forms.ComboBox
    Friend WithEvents CboAssetCategory As System.Windows.Forms.ComboBox
    Friend WithEvents RadAssetStatus As System.Windows.Forms.RadioButton
    Friend WithEvents CboAssetStatus As System.Windows.Forms.ComboBox
End Class
