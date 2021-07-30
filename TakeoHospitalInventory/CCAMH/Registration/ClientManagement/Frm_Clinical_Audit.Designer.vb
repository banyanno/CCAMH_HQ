<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Clinical_Audit
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
        Me.chbNo = New System.Windows.Forms.CheckBox
        Me.chbYes = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtbAuditDate = New System.Windows.Forms.DateTimePicker
        Me.btnSave = New System.Windows.Forms.Button
        Me.hidden_client_no = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chbNo
        '
        Me.chbNo.AutoSize = True
        Me.chbNo.Location = New System.Drawing.Point(39, 28)
        Me.chbNo.Name = "chbNo"
        Me.chbNo.Size = New System.Drawing.Size(42, 17)
        Me.chbNo.TabIndex = 0
        Me.chbNo.Text = "NO"
        Me.chbNo.UseVisualStyleBackColor = True
        '
        'chbYes
        '
        Me.chbYes.AutoSize = True
        Me.chbYes.Location = New System.Drawing.Point(39, 63)
        Me.chbYes.Name = "chbYes"
        Me.chbYes.Size = New System.Drawing.Size(47, 17)
        Me.chbYes.TabIndex = 1
        Me.chbYes.Text = "YES"
        Me.chbYes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtbAuditDate)
        Me.GroupBox1.Controls.Add(Me.chbNo)
        Me.GroupBox1.Controls.Add(Me.chbYes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clinical Audit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "(If Yes, mention date)"
        '
        'dtbAuditDate
        '
        Me.dtbAuditDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbAuditDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbAuditDate.Location = New System.Drawing.Point(39, 95)
        Me.dtbAuditDate.Name = "dtbAuditDate"
        Me.dtbAuditDate.Size = New System.Drawing.Size(201, 22)
        Me.dtbAuditDate.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 179)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 35)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'hidden_client_no
        '
        Me.hidden_client_no.AutoSize = True
        Me.hidden_client_no.Location = New System.Drawing.Point(53, 236)
        Me.hidden_client_no.Name = "hidden_client_no"
        Me.hidden_client_no.Size = New System.Drawing.Size(0, 13)
        Me.hidden_client_no.TabIndex = 4
        Me.hidden_client_no.Visible = False
        '
        'Frm_Clinical_Audit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 226)
        Me.Controls.Add(Me.hidden_client_no)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Clinical_Audit"
        Me.Text = "Clinical Audit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chbNo As System.Windows.Forms.CheckBox
    Friend WithEvents chbYes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtbAuditDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents hidden_client_no As System.Windows.Forms.Label
End Class
