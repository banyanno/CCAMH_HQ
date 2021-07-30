<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewDrugPrice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewDrugPrice))
        Me.PanelMain = New System.Windows.Forms.Panel
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.TxtMedicinceName = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtServiceMedC = New System.Windows.Forms.TextBox
        Me.TxtServiceMedA = New System.Windows.Forms.TextBox
        Me.TxtServiceMedB = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblSaveMedic = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.ErrDrugPriceSetting = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelMain.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrDrugPriceSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.BtnSave)
        Me.PanelMain.Controls.Add(Me.Panel6)
        Me.PanelMain.Controls.Add(Me.LblSaveMedic)
        Me.PanelMain.Controls.Add(Me.Label26)
        Me.PanelMain.Controls.Add(Me.BtnClose)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(400, 305)
        Me.PanelMain.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(203, 261)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(91, 37)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.TxtMedicinceName)
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(11, 52)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(379, 205)
        Me.Panel6.TabIndex = 0
        '
        'TxtMedicinceName
        '
        Me.TxtMedicinceName.BackColor = System.Drawing.Color.White
        Me.TxtMedicinceName.Location = New System.Drawing.Point(5, 43)
        Me.TxtMedicinceName.Name = "TxtMedicinceName"
        Me.TxtMedicinceName.ReadOnly = True
        Me.TxtMedicinceName.Size = New System.Drawing.Size(360, 32)
        Me.TxtMedicinceName.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TxtServiceMedC)
        Me.GroupBox1.Controls.Add(Me.TxtServiceMedA)
        Me.GroupBox1.Controls.Add(Me.TxtServiceMedB)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 111)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drug price setting"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(42, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 25)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "A"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(163, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 25)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "B"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(270, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 25)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "C"
        '
        'TxtServiceMedC
        '
        Me.TxtServiceMedC.Location = New System.Drawing.Point(242, 58)
        Me.TxtServiceMedC.Name = "TxtServiceMedC"
        Me.TxtServiceMedC.Size = New System.Drawing.Size(106, 32)
        Me.TxtServiceMedC.TabIndex = 2
        Me.TxtServiceMedC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtServiceMedA
        '
        Me.TxtServiceMedA.Location = New System.Drawing.Point(10, 58)
        Me.TxtServiceMedA.Name = "TxtServiceMedA"
        Me.TxtServiceMedA.Size = New System.Drawing.Size(106, 32)
        Me.TxtServiceMedA.TabIndex = 0
        Me.TxtServiceMedA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtServiceMedB
        '
        Me.TxtServiceMedB.Location = New System.Drawing.Point(126, 58)
        Me.TxtServiceMedB.Name = "TxtServiceMedB"
        Me.TxtServiceMedB.Size = New System.Drawing.Size(106, 32)
        Me.TxtServiceMedB.TabIndex = 1
        Me.TxtServiceMedB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Drug Name"
        '
        'LblSaveMedic
        '
        Me.LblSaveMedic.AutoSize = True
        Me.LblSaveMedic.Location = New System.Drawing.Point(25, 269)
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
        Me.Label26.Location = New System.Drawing.Point(15, 14)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(364, 26)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Medicince Scocial Economic Setting"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(300, 261)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(91, 37)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'ErrDrugPriceSetting
        '
        Me.ErrDrugPriceSetting.ContainerControl = Me
        '
        'FormNewDrugPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 305)
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormNewDrugPrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drug price setting"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrDrugPriceSetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtServiceMedC As System.Windows.Forms.TextBox
    Friend WithEvents TxtServiceMedB As System.Windows.Forms.TextBox
    Friend WithEvents TxtServiceMedA As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LblSaveMedic As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrDrugPriceSetting As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtMedicinceName As System.Windows.Forms.TextBox
End Class
