<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSocialStatus
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSTCanel = New System.Windows.Forms.Button
        Me.btnSTSave = New System.Windows.Forms.Button
        Me.tbxSSMisc = New System.Windows.Forms.TextBox
        Me.tbxSSCharge = New System.Windows.Forms.TextBox
        Me.tbxSSDetail = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSTCanel)
        Me.Panel1.Controls.Add(Me.btnSTSave)
        Me.Panel1.Controls.Add(Me.tbxSSMisc)
        Me.Panel1.Controls.Add(Me.tbxSSCharge)
        Me.Panel1.Controls.Add(Me.tbxSSDetail)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 178)
        Me.Panel1.TabIndex = 0
        '
        'btnSTCanel
        '
        Me.btnSTCanel.Location = New System.Drawing.Point(469, 78)
        Me.btnSTCanel.Name = "btnSTCanel"
        Me.btnSTCanel.Size = New System.Drawing.Size(86, 38)
        Me.btnSTCanel.TabIndex = 5
        Me.btnSTCanel.Text = "Cancel"
        Me.btnSTCanel.UseVisualStyleBackColor = True
        '
        'btnSTSave
        '
        Me.btnSTSave.Location = New System.Drawing.Point(469, 22)
        Me.btnSTSave.Name = "btnSTSave"
        Me.btnSTSave.Size = New System.Drawing.Size(86, 34)
        Me.btnSTSave.TabIndex = 4
        Me.btnSTSave.Text = "Save"
        Me.btnSTSave.UseVisualStyleBackColor = True
        '
        'tbxSSMisc
        '
        Me.tbxSSMisc.Location = New System.Drawing.Point(145, 121)
        Me.tbxSSMisc.Multiline = True
        Me.tbxSSMisc.Name = "tbxSSMisc"
        Me.tbxSSMisc.Size = New System.Drawing.Size(281, 45)
        Me.tbxSSMisc.TabIndex = 3
        '
        'tbxSSCharge
        '
        Me.tbxSSCharge.Location = New System.Drawing.Point(145, 68)
        Me.tbxSSCharge.Multiline = True
        Me.tbxSSCharge.Name = "tbxSSCharge"
        Me.tbxSSCharge.Size = New System.Drawing.Size(281, 47)
        Me.tbxSSCharge.TabIndex = 2
        '
        'tbxSSDetail
        '
        Me.tbxSSDetail.Location = New System.Drawing.Point(145, 10)
        Me.tbxSSDetail.Multiline = True
        Me.tbxSSDetail.Name = "tbxSSDetail"
        Me.tbxSSDetail.Size = New System.Drawing.Size(281, 40)
        Me.tbxSSDetail.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Miscellaneous:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Charge:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detail:"
        '
        'FormSocialStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 180)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormSocialStatus"
        Me.Text = "FormSocialStatus"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSTCanel As System.Windows.Forms.Button
    Friend WithEvents btnSTSave As System.Windows.Forms.Button
    Friend WithEvents tbxSSMisc As System.Windows.Forms.TextBox
    Friend WithEvents tbxSSCharge As System.Windows.Forms.TextBox
    Friend WithEvents tbxSSDetail As System.Windows.Forms.TextBox
End Class
