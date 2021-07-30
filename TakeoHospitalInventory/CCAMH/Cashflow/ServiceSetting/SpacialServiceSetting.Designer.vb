<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpacialServiceSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpacialServiceSetting))
        Dim GridServiceSpacial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PanelMain = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.BtnAddPackage = New System.Windows.Forms.Button
        Me.BtnAddSkill = New System.Windows.Forms.Button
        Me.CboPackage = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.CboSkill = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridServiceSpacial = New Janus.Windows.GridEX.GridEX
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TxtServiceC = New System.Windows.Forms.TextBox
        Me.TxtServiceB = New System.Windows.Forms.TextBox
        Me.TxtServiceA = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.LblSaveMedic = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ErrSpacial = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelMain.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.GridServiceSpacial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrSpacial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.Panel6)
        Me.PanelMain.Controls.Add(Me.LblSaveMedic)
        Me.PanelMain.Controls.Add(Me.Label26)
        Me.PanelMain.Controls.Add(Me.Button1)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(738, 510)
        Me.PanelMain.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.BtnAddPackage)
        Me.Panel6.Controls.Add(Me.BtnAddSkill)
        Me.Panel6.Controls.Add(Me.CboPackage)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.BtnRemove)
        Me.Panel6.Controls.Add(Me.CboSkill)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.GridServiceSpacial)
        Me.Panel6.Controls.Add(Me.BtnAdd)
        Me.Panel6.Controls.Add(Me.TxtServiceC)
        Me.Panel6.Controls.Add(Me.TxtServiceB)
        Me.Panel6.Controls.Add(Me.TxtServiceA)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(11, 52)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(720, 410)
        Me.Panel6.TabIndex = 4
        '
        'BtnAddPackage
        '
        Me.BtnAddPackage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPackage.FlatAppearance.BorderSize = 0
        Me.BtnAddPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPackage.ForeColor = System.Drawing.Color.White
        Me.BtnAddPackage.Image = CType(resources.GetObject("BtnAddPackage.Image"), System.Drawing.Image)
        Me.BtnAddPackage.Location = New System.Drawing.Point(218, 90)
        Me.BtnAddPackage.Name = "BtnAddPackage"
        Me.BtnAddPackage.Size = New System.Drawing.Size(39, 34)
        Me.BtnAddPackage.TabIndex = 10
        Me.BtnAddPackage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnAddPackage.UseVisualStyleBackColor = False
        '
        'BtnAddSkill
        '
        Me.BtnAddSkill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddSkill.FlatAppearance.BorderSize = 0
        Me.BtnAddSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddSkill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddSkill.ForeColor = System.Drawing.Color.White
        Me.BtnAddSkill.Image = CType(resources.GetObject("BtnAddSkill.Image"), System.Drawing.Image)
        Me.BtnAddSkill.Location = New System.Drawing.Point(219, 30)
        Me.BtnAddSkill.Name = "BtnAddSkill"
        Me.BtnAddSkill.Size = New System.Drawing.Size(39, 36)
        Me.BtnAddSkill.TabIndex = 9
        Me.BtnAddSkill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddSkill.UseVisualStyleBackColor = False
        '
        'CboPackage
        '
        Me.CboPackage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboPackage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboPackage.FormattingEnabled = True
        Me.CboPackage.Location = New System.Drawing.Point(4, 90)
        Me.CboPackage.Name = "CboPackage"
        Me.CboPackage.Size = New System.Drawing.Size(212, 32)
        Me.CboPackage.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Service C"
        '
        'BtnRemove
        '
        Me.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemove.FlatAppearance.BorderSize = 0
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ForeColor = System.Drawing.Color.White
        Me.BtnRemove.Image = CType(resources.GetObject("BtnRemove.Image"), System.Drawing.Image)
        Me.BtnRemove.Location = New System.Drawing.Point(666, 90)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(43, 32)
        Me.BtnRemove.TabIndex = 4
        Me.BtnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'CboSkill
        '
        Me.CboSkill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSkill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSkill.FormattingEnabled = True
        Me.CboSkill.Location = New System.Drawing.Point(3, 31)
        Me.CboSkill.Name = "CboSkill"
        Me.CboSkill.Size = New System.Drawing.Size(212, 32)
        Me.CboSkill.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Service"
        '
        'GridServiceSpacial
        '
        Me.GridServiceSpacial.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridServiceSpacial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridServiceSpacial.BackColor = System.Drawing.Color.White
        Me.GridServiceSpacial.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridServiceSpacial_DesignTimeLayout.LayoutString = resources.GetString("GridServiceSpacial_DesignTimeLayout.LayoutString")
        Me.GridServiceSpacial.DesignTimeLayout = GridServiceSpacial_DesignTimeLayout
        Me.GridServiceSpacial.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridServiceSpacial.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridServiceSpacial.GroupByBoxVisible = False
        Me.GridServiceSpacial.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridServiceSpacial.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridServiceSpacial.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridServiceSpacial.Location = New System.Drawing.Point(3, 130)
        Me.GridServiceSpacial.Name = "GridServiceSpacial"
        Me.GridServiceSpacial.RecordNavigator = True
        Me.GridServiceSpacial.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridServiceSpacial.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridServiceSpacial.Size = New System.Drawing.Size(711, 274)
        Me.GridServiceSpacial.TabIndex = 5
        Me.GridServiceSpacial.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(620, 90)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(43, 32)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'TxtServiceC
        '
        Me.TxtServiceC.Location = New System.Drawing.Point(508, 90)
        Me.TxtServiceC.Name = "TxtServiceC"
        Me.TxtServiceC.Size = New System.Drawing.Size(106, 32)
        Me.TxtServiceC.TabIndex = 2
        Me.TxtServiceC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtServiceB
        '
        Me.TxtServiceB.Location = New System.Drawing.Point(392, 90)
        Me.TxtServiceB.Name = "TxtServiceB"
        Me.TxtServiceB.Size = New System.Drawing.Size(106, 32)
        Me.TxtServiceB.TabIndex = 1
        Me.TxtServiceB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtServiceA
        '
        Me.TxtServiceA.Location = New System.Drawing.Point(273, 90)
        Me.TxtServiceA.Name = "TxtServiceA"
        Me.TxtServiceA.Size = New System.Drawing.Size(106, 32)
        Me.TxtServiceA.TabIndex = 0
        Me.TxtServiceA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(392, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 25)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Service B"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(273, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 25)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Service A"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 25)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Package "
        '
        'LblSaveMedic
        '
        Me.LblSaveMedic.AutoSize = True
        Me.LblSaveMedic.Location = New System.Drawing.Point(12, 388)
        Me.LblSaveMedic.Name = "LblSaveMedic"
        Me.LblSaveMedic.Size = New System.Drawing.Size(20, 25)
        Me.LblSaveMedic.TabIndex = 20
        Me.LblSaveMedic.Text = "0"
        Me.LblSaveMedic.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(217, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(303, 26)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Spacial Social Service Setting"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(640, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Close"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ErrSpacial
        '
        Me.ErrSpacial.ContainerControl = Me
        '
        'SpacialServiceSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 510)
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SpacialServiceSetting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spacial Service Setting"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.GridServiceSpacial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrSpacial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents CboSkill As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridServiceSpacial As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtServiceC As System.Windows.Forms.TextBox
    Friend WithEvents TxtServiceB As System.Windows.Forms.TextBox
    Friend WithEvents TxtServiceA As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LblSaveMedic As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboPackage As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddPackage As System.Windows.Forms.Button
    Friend WithEvents BtnAddSkill As System.Windows.Forms.Button
    Friend WithEvents ErrSpacial As System.Windows.Forms.ErrorProvider
End Class
