<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFixAsset
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFixAsset))
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboLocation = New System.Windows.Forms.ComboBox()
        Me.TxtDescriptionItem = New System.Windows.Forms.TextBox()
        Me.TxtAssetCode = New System.Windows.Forms.TextBox()
        Me.TxtCost = New System.Windows.Forms.TextBox()
        Me.TxtDonor = New System.Windows.Forms.TextBox()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateDisposal = New System.Windows.Forms.DateTimePicker()
        Me.DateBuy = New System.Windows.Forms.DateTimePicker()
        Me.CboAssetStatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnAddCategroy = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CboAssetCategory = New System.Windows.Forms.ComboBox()
        Me.TxtQTY = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtModelSerial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblSaveOption = New System.Windows.Forms.Label()
        Me.ErrFixAsset = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ErrFixAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(354, 437)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 33)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(449, 437)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 33)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date of Purchase*:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description of item*:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Asset Code*:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Location*:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(372, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cost*:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Donor *:"
        '
        'CboLocation
        '
        Me.CboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboLocation.FormattingEnabled = True
        Me.CboLocation.Location = New System.Drawing.Point(6, 201)
        Me.CboLocation.Name = "CboLocation"
        Me.CboLocation.Size = New System.Drawing.Size(226, 28)
        Me.CboLocation.TabIndex = 6
        '
        'TxtDescriptionItem
        '
        Me.TxtDescriptionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescriptionItem.Location = New System.Drawing.Point(6, 94)
        Me.TxtDescriptionItem.Name = "TxtDescriptionItem"
        Me.TxtDescriptionItem.Size = New System.Drawing.Size(226, 26)
        Me.TxtDescriptionItem.TabIndex = 2
        '
        'TxtAssetCode
        '
        Me.TxtAssetCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAssetCode.Location = New System.Drawing.Point(6, 37)
        Me.TxtAssetCode.Name = "TxtAssetCode"
        Me.TxtAssetCode.Size = New System.Drawing.Size(226, 26)
        Me.TxtAssetCode.TabIndex = 0
        '
        'TxtCost
        '
        Me.TxtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCost.Location = New System.Drawing.Point(376, 261)
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(151, 26)
        Me.TxtCost.TabIndex = 10
        Me.TxtCost.Text = "0"
        '
        'TxtDonor
        '
        Me.TxtDonor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDonor.Location = New System.Drawing.Point(6, 261)
        Me.TxtDonor.Name = "TxtDonor"
        Me.TxtDonor.Size = New System.Drawing.Size(226, 26)
        Me.TxtDonor.TabIndex = 8
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(6, 313)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(521, 98)
        Me.TxtRemarks.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Remarks"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateDisposal)
        Me.Panel1.Controls.Add(Me.DateBuy)
        Me.Panel1.Controls.Add(Me.CboAssetStatus)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.BtnAddCategroy)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.CboAssetCategory)
        Me.Panel1.Controls.Add(Me.TxtQTY)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TxtUser)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtModelSerial)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtRemarks)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtDonor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtCost)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtAssetCode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtDescriptionItem)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CboLocation)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(5, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 419)
        Me.Panel1.TabIndex = 0
        '
        'DateDisposal
        '
        Me.DateDisposal.Checked = False
        Me.DateDisposal.CustomFormat = "dd/MM/yyyy"
        Me.DateDisposal.Enabled = False
        Me.DateDisposal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDisposal.Location = New System.Drawing.Point(396, 150)
        Me.DateDisposal.Name = "DateDisposal"
        Me.DateDisposal.ShowCheckBox = True
        Me.DateDisposal.Size = New System.Drawing.Size(131, 26)
        Me.DateDisposal.TabIndex = 25
        '
        'DateBuy
        '
        Me.DateBuy.Checked = False
        Me.DateBuy.CustomFormat = "dd/MM/yyyy"
        Me.DateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateBuy.Location = New System.Drawing.Point(259, 37)
        Me.DateBuy.Name = "DateBuy"
        Me.DateBuy.ShowCheckBox = True
        Me.DateBuy.Size = New System.Drawing.Size(226, 26)
        Me.DateBuy.TabIndex = 24
        '
        'CboAssetStatus
        '
        Me.CboAssetStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAssetStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAssetStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAssetStatus.DropDownWidth = 222
        Me.CboAssetStatus.FormattingEnabled = True
        Me.CboAssetStatus.Items.AddRange(New Object() {"", "ACTUAL", "DISPOSAL"})
        Me.CboAssetStatus.Location = New System.Drawing.Point(262, 149)
        Me.CboAssetStatus.Name = "CboAssetStatus"
        Me.CboAssetStatus.Size = New System.Drawing.Size(128, 28)
        Me.CboAssetStatus.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(395, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 20)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Date Disposal:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Asset Status:"
        '
        'BtnAddCategroy
        '
        Me.BtnAddCategroy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCategroy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCategroy.Location = New System.Drawing.Point(230, 148)
        Me.BtnAddCategroy.Name = "BtnAddCategroy"
        Me.BtnAddCategroy.Size = New System.Drawing.Size(29, 29)
        Me.BtnAddCategroy.TabIndex = 5
        Me.BtnAddCategroy.Text = "..."
        Me.BtnAddCategroy.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Asset Category*:"
        '
        'CboAssetCategory
        '
        Me.CboAssetCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAssetCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAssetCategory.DropDownWidth = 450
        Me.CboAssetCategory.FormattingEnabled = True
        Me.CboAssetCategory.Location = New System.Drawing.Point(6, 148)
        Me.CboAssetCategory.Name = "CboAssetCategory"
        Me.CboAssetCategory.Size = New System.Drawing.Size(222, 28)
        Me.CboAssetCategory.TabIndex = 4
        '
        'TxtQTY
        '
        Me.TxtQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQTY.Location = New System.Drawing.Point(259, 261)
        Me.TxtQTY.Name = "TxtQTY"
        Me.TxtQTY.Size = New System.Drawing.Size(90, 26)
        Me.TxtQTY.TabIndex = 9
        Me.TxtQTY.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(259, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Qty:"
        '
        'TxtUser
        '
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUser.Location = New System.Drawing.Point(259, 201)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(268, 26)
        Me.TxtUser.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(259, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "User:"
        '
        'TxtModelSerial
        '
        Me.TxtModelSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModelSerial.Location = New System.Drawing.Point(259, 94)
        Me.TxtModelSerial.Name = "TxtModelSerial"
        Me.TxtModelSerial.Size = New System.Drawing.Size(226, 26)
        Me.TxtModelSerial.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(259, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Model/Serial:"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(19, 541)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 4
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'ErrFixAsset
        '
        Me.ErrFixAsset.ContainerControl = Me
        '
        'FormFixAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 477)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFixAsset"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fix Asset Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrFixAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDescriptionItem As System.Windows.Forms.TextBox
    Friend WithEvents TxtAssetCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtCost As System.Windows.Forms.TextBox
    Friend WithEvents TxtDonor As System.Windows.Forms.TextBox
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ErrFixAsset As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtModelSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnAddCategroy As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CboAssetCategory As System.Windows.Forms.ComboBox
    Friend WithEvents CboAssetStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateBuy As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateDisposal As System.Windows.Forms.DateTimePicker
End Class
