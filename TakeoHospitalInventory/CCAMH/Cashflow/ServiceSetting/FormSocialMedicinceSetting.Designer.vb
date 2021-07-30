<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSocialMedicinceSetting
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
        Dim GridServiceMed_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSocialMedicinceSetting))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.PanelMain = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.BtnRemoveMed = New System.Windows.Forms.Button
        Me.CboCategory = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridServiceMed = New Janus.Windows.GridEX.GridEX
        Me.VSMInterface = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.BtnAddMedA = New System.Windows.Forms.Button
        Me.TxtServiceMedC = New System.Windows.Forms.TextBox
        Me.TxtServiceMedB = New System.Windows.Forms.TextBox
        Me.TxtServiceMedA = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.LblSaveMedic = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ErrServiceSocial = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelMain.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.GridServiceMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrServiceSocial, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelMain.Size = New System.Drawing.Size(692, 444)
        Me.PanelMain.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.BtnRemoveMed)
        Me.Panel6.Controls.Add(Me.CboCategory)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.GridServiceMed)
        Me.Panel6.Controls.Add(Me.BtnAddMedA)
        Me.Panel6.Controls.Add(Me.TxtServiceMedC)
        Me.Panel6.Controls.Add(Me.TxtServiceMedB)
        Me.Panel6.Controls.Add(Me.TxtServiceMedA)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(11, 52)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(673, 342)
        Me.Panel6.TabIndex = 4
        '
        'BtnRemoveMed
        '
        Me.BtnRemoveMed.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnRemoveMed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveMed.FlatAppearance.BorderSize = 0
        Me.BtnRemoveMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveMed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveMed.ForeColor = System.Drawing.Color.White
        Me.BtnRemoveMed.Location = New System.Drawing.Point(624, 35)
        Me.BtnRemoveMed.Name = "BtnRemoveMed"
        Me.BtnRemoveMed.Size = New System.Drawing.Size(43, 32)
        Me.BtnRemoveMed.TabIndex = 4
        Me.BtnRemoveMed.Text = "-"
        Me.BtnRemoveMed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRemoveMed.UseVisualStyleBackColor = False
        '
        'CboCategory
        '
        Me.CboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Location = New System.Drawing.Point(3, 34)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(229, 32)
        Me.CboCategory.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Category Medicince:"
        '
        'GridServiceMed
        '
        Me.GridServiceMed.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridServiceMed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridServiceMed.BackColor = System.Drawing.Color.White
        Me.GridServiceMed.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridServiceMed_DesignTimeLayout.LayoutString = resources.GetString("GridServiceMed_DesignTimeLayout.LayoutString")
        Me.GridServiceMed.DesignTimeLayout = GridServiceMed_DesignTimeLayout
        Me.GridServiceMed.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridServiceMed.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridServiceMed.GroupByBoxVisible = False
        Me.GridServiceMed.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridServiceMed.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridServiceMed.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridServiceMed.Location = New System.Drawing.Point(3, 73)
        Me.GridServiceMed.Name = "GridServiceMed"
        Me.GridServiceMed.RecordNavigator = True
        Me.GridServiceMed.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridServiceMed.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridServiceMed.Size = New System.Drawing.Size(663, 261)
        Me.GridServiceMed.TabIndex = 5
        Me.GridServiceMed.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridServiceMed.VisualStyleManager = Me.VSMInterface
        '
        'VSMInterface
        '
        JanusColorScheme1.ActiveCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme1.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme1.ControlColor = System.Drawing.Color.White
        JanusColorScheme1.ControlDarkColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme1.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.White
        JanusColorScheme1.InfoColor = System.Drawing.Color.White
        JanusColorScheme1.InfoTextColor = System.Drawing.Color.Black
        JanusColorScheme1.MenuColor = System.Drawing.Color.White
        JanusColorScheme1.MenuTextColor = System.Drawing.Color.Black
        JanusColorScheme1.Name = "DefaultInterface"
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.Black
        Me.VSMInterface.ColorSchemes.Add(JanusColorScheme1)
        Me.VSMInterface.DefaultColorScheme = Nothing
        '
        'BtnAddMedA
        '
        Me.BtnAddMedA.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAddMedA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMedA.FlatAppearance.BorderSize = 0
        Me.BtnAddMedA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMedA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMedA.ForeColor = System.Drawing.Color.White
        Me.BtnAddMedA.Location = New System.Drawing.Point(579, 35)
        Me.BtnAddMedA.Name = "BtnAddMedA"
        Me.BtnAddMedA.Size = New System.Drawing.Size(43, 32)
        Me.BtnAddMedA.TabIndex = 3
        Me.BtnAddMedA.Text = "+"
        Me.BtnAddMedA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddMedA.UseVisualStyleBackColor = False
        '
        'TxtServiceMedC
        '
        Me.TxtServiceMedC.Location = New System.Drawing.Point(463, 35)
        Me.TxtServiceMedC.Name = "TxtServiceMedC"
        Me.TxtServiceMedC.Size = New System.Drawing.Size(106, 32)
        Me.TxtServiceMedC.TabIndex = 2
        Me.TxtServiceMedC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtServiceMedB
        '
        Me.TxtServiceMedB.Location = New System.Drawing.Point(351, 35)
        Me.TxtServiceMedB.Name = "TxtServiceMedB"
        Me.TxtServiceMedB.Size = New System.Drawing.Size(106, 32)
        Me.TxtServiceMedB.TabIndex = 1
        Me.TxtServiceMedB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtServiceMedA
        '
        Me.TxtServiceMedA.Location = New System.Drawing.Point(239, 35)
        Me.TxtServiceMedA.Name = "TxtServiceMedA"
        Me.TxtServiceMedA.Size = New System.Drawing.Size(106, 32)
        Me.TxtServiceMedA.TabIndex = 0
        Me.TxtServiceMedA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(481, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 25)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Service C:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(371, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 25)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Service B:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(253, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 25)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Service A:"
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
        Me.Label26.Location = New System.Drawing.Point(123, 23)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(364, 26)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Medicince Scocial Economic Setting"
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
        Me.Button1.Location = New System.Drawing.Point(596, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Close"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ErrServiceSocial
        '
        Me.ErrServiceSocial.ContainerControl = Me
        '
        'FormSocialMedicinceSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 444)
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSocialMedicinceSetting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSocialMedicinceSetting"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.GridServiceMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrServiceSocial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents VSMInterface As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents ErrServiceSocial As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveMedic As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BtnRemoveMed As System.Windows.Forms.Button
    Friend WithEvents GridServiceMed As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnAddMedA As System.Windows.Forms.Button
    Friend WithEvents TxtServiceMedC As System.Windows.Forms.TextBox
    Friend WithEvents TxtServiceMedB As System.Windows.Forms.TextBox
    Friend WithEvents TxtServiceMedA As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
