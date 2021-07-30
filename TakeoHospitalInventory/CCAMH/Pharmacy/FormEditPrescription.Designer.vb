<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditPrescription))
        Me.CboUsageE = New System.Windows.Forms.ComboBox()
        Me.CboUsageN = New System.Windows.Forms.ComboBox()
        Me.CboUsageM = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtTotalQTY = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEditPrescriptNote = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboMedicine = New System.Windows.Forms.ComboBox()
        Me.LblPrescriptDedtail = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CboRemark = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboUsageE
        '
        Me.CboUsageE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboUsageE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboUsageE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUsageE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboUsageE.FormattingEnabled = True
        Me.CboUsageE.Location = New System.Drawing.Point(191, 84)
        Me.CboUsageE.Name = "CboUsageE"
        Me.CboUsageE.Size = New System.Drawing.Size(68, 26)
        Me.CboUsageE.TabIndex = 3
        '
        'CboUsageN
        '
        Me.CboUsageN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboUsageN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboUsageN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUsageN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboUsageN.FormattingEnabled = True
        Me.CboUsageN.Location = New System.Drawing.Point(106, 84)
        Me.CboUsageN.Name = "CboUsageN"
        Me.CboUsageN.Size = New System.Drawing.Size(70, 26)
        Me.CboUsageN.TabIndex = 2
        '
        'CboUsageM
        '
        Me.CboUsageM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboUsageM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboUsageM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUsageM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboUsageM.FormattingEnabled = True
        Me.CboUsageM.Location = New System.Drawing.Point(25, 84)
        Me.CboUsageM.Name = "CboUsageM"
        Me.CboUsageM.Size = New System.Drawing.Size(68, 26)
        Me.CboUsageM.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(292, 61)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 22)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "QTY Use"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(210, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 22)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "E"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(42, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 22)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "M"
        '
        'TxtTotalQTY
        '
        Me.TxtTotalQTY.BackColor = System.Drawing.Color.White
        Me.TxtTotalQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtTotalQTY.Location = New System.Drawing.Point(279, 86)
        Me.TxtTotalQTY.Name = "TxtTotalQTY"
        Me.TxtTotalQTY.Size = New System.Drawing.Size(73, 26)
        Me.TxtTotalQTY.TabIndex = 4
        Me.TxtTotalQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(133, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 22)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "N"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 22)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Edit Prescription Note"
        '
        'TxtEditPrescriptNote
        '
        Me.TxtEditPrescriptNote.BackColor = System.Drawing.Color.White
        Me.TxtEditPrescriptNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEditPrescriptNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtEditPrescriptNote.Location = New System.Drawing.Point(25, 208)
        Me.TxtEditPrescriptNote.Multiline = True
        Me.TxtEditPrescriptNote.Name = "TxtEditPrescriptNote"
        Me.TxtEditPrescriptNote.Size = New System.Drawing.Size(327, 82)
        Me.TxtEditPrescriptNote.TabIndex = 6
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(175, 296)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(177, 39)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Cancel"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(25, 296)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(144, 39)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Medicine Name"
        '
        'CboMedicine
        '
        Me.CboMedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedicine.FormattingEnabled = True
        Me.CboMedicine.Location = New System.Drawing.Point(25, 34)
        Me.CboMedicine.Name = "CboMedicine"
        Me.CboMedicine.Size = New System.Drawing.Size(327, 28)
        Me.CboMedicine.TabIndex = 0
        '
        'LblPrescriptDedtail
        '
        Me.LblPrescriptDedtail.AutoSize = True
        Me.LblPrescriptDedtail.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrescriptDedtail.Location = New System.Drawing.Point(255, 6)
        Me.LblPrescriptDedtail.Name = "LblPrescriptDedtail"
        Me.LblPrescriptDedtail.Size = New System.Drawing.Size(17, 22)
        Me.LblPrescriptDedtail.TabIndex = 65
        Me.LblPrescriptDedtail.Text = "0"
        Me.LblPrescriptDedtail.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CboRemark
        '
        Me.CboRemark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboRemark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRemark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboRemark.FormattingEnabled = True
        Me.CboRemark.Items.AddRange(New Object() {"IN", "OUT"})
        Me.CboRemark.Location = New System.Drawing.Point(25, 147)
        Me.CboRemark.Name = "CboRemark"
        Me.CboRemark.Size = New System.Drawing.Size(151, 26)
        Me.CboRemark.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 22)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Medicin In/Out Center:"
        '
        'FormEditPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 344)
        Me.Controls.Add(Me.CboRemark)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblPrescriptDedtail)
        Me.Controls.Add(Me.CboMedicine)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtEditPrescriptNote)
        Me.Controls.Add(Me.CboUsageE)
        Me.Controls.Add(Me.CboUsageN)
        Me.Controls.Add(Me.CboUsageM)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtTotalQTY)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label19)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditPrescription"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Prescription"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboUsageE As System.Windows.Forms.ComboBox
    Friend WithEvents CboUsageN As System.Windows.Forms.ComboBox
    Friend WithEvents CboUsageM As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtEditPrescriptNote As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboMedicine As System.Windows.Forms.ComboBox
    Friend WithEvents LblPrescriptDedtail As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CboRemark As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
