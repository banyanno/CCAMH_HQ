<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMGroupProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMGroupProperties))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblGroupID = New System.Windows.Forms.Label
        Me.Ch2 = New System.Windows.Forms.CheckedListBox
        Me.btnMove2 = New System.Windows.Forms.Button
        Me.btnMove1 = New System.Windows.Forms.Button
        Me.Ch1 = New System.Windows.Forms.CheckedListBox
        Me.TxtGroupName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TxtGroupName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 445)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Department Properties"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblGroupID)
        Me.GroupBox2.Controls.Add(Me.Ch2)
        Me.GroupBox2.Controls.Add(Me.btnMove2)
        Me.GroupBox2.Controls.Add(Me.btnMove1)
        Me.GroupBox2.Controls.Add(Me.Ch1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 389)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permistion"
        '
        'LblGroupID
        '
        Me.LblGroupID.AutoSize = True
        Me.LblGroupID.Location = New System.Drawing.Point(304, 59)
        Me.LblGroupID.Name = "LblGroupID"
        Me.LblGroupID.Size = New System.Drawing.Size(13, 13)
        Me.LblGroupID.TabIndex = 3
        Me.LblGroupID.Text = "0"
        Me.LblGroupID.Visible = False
        '
        'Ch2
        '
        Me.Ch2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ch2.Font = New System.Drawing.Font("Khmer OS", 9.75!)
        Me.Ch2.FormattingEnabled = True
        Me.Ch2.Location = New System.Drawing.Point(334, 20)
        Me.Ch2.Name = "Ch2"
        Me.Ch2.ScrollAlwaysVisible = True
        Me.Ch2.Size = New System.Drawing.Size(254, 348)
        Me.Ch2.TabIndex = 10
        '
        'btnMove2
        '
        Me.btnMove2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMove2.FlatAppearance.BorderSize = 0
        Me.btnMove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMove2.Image = CType(resources.GetObject("btnMove2.Image"), System.Drawing.Image)
        Me.btnMove2.Location = New System.Drawing.Point(265, 205)
        Me.btnMove2.Name = "btnMove2"
        Me.btnMove2.Size = New System.Drawing.Size(54, 35)
        Me.btnMove2.TabIndex = 9
        Me.btnMove2.UseVisualStyleBackColor = True
        '
        'btnMove1
        '
        Me.btnMove1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMove1.FlatAppearance.BorderSize = 0
        Me.btnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMove1.Image = CType(resources.GetObject("btnMove1.Image"), System.Drawing.Image)
        Me.btnMove1.Location = New System.Drawing.Point(265, 155)
        Me.btnMove1.Name = "btnMove1"
        Me.btnMove1.Size = New System.Drawing.Size(54, 35)
        Me.btnMove1.TabIndex = 8
        Me.btnMove1.UseVisualStyleBackColor = True
        '
        'Ch1
        '
        Me.Ch1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ch1.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch1.FormattingEnabled = True
        Me.Ch1.Location = New System.Drawing.Point(5, 19)
        Me.Ch1.Name = "Ch1"
        Me.Ch1.ScrollAlwaysVisible = True
        Me.Ch1.Size = New System.Drawing.Size(254, 348)
        Me.Ch1.TabIndex = 7
        '
        'TxtGroupName
        '
        Me.TxtGroupName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGroupName.Location = New System.Drawing.Point(112, 18)
        Me.TxtGroupName.Name = "TxtGroupName"
        Me.TxtGroupName.Size = New System.Drawing.Size(253, 23)
        Me.TxtGroupName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department Name:"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Maroon
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(221, 453)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(87, 41)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Maroon
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(312, 454)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(87, 39)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FRMGroupProperties
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(621, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMGroupProperties"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Properties"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblGroupID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtGroupName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Ch2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnMove2 As System.Windows.Forms.Button
    Friend WithEvents btnMove1 As System.Windows.Forms.Button
    Friend WithEvents Ch1 As System.Windows.Forms.CheckedListBox
End Class
