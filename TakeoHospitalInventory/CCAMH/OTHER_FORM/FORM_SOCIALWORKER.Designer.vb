<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_SOCIALWORKER
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
        Me.btnSWCancel = New System.Windows.Forms.Button
        Me.btnSWSave = New System.Windows.Forms.Button
        Me.tbxMisc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbxSocialWorker = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbbxClientNo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSWCancel)
        Me.Panel1.Controls.Add(Me.btnSWSave)
        Me.Panel1.Controls.Add(Me.tbxMisc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbxSocialWorker)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbbxClientNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 196)
        Me.Panel1.TabIndex = 0
        '
        'btnSWCancel
        '
        Me.btnSWCancel.Location = New System.Drawing.Point(426, 22)
        Me.btnSWCancel.Name = "btnSWCancel"
        Me.btnSWCancel.Size = New System.Drawing.Size(90, 30)
        Me.btnSWCancel.TabIndex = 7
        Me.btnSWCancel.Text = "Cancel"
        Me.btnSWCancel.UseVisualStyleBackColor = True
        '
        'btnSWSave
        '
        Me.btnSWSave.Location = New System.Drawing.Point(336, 22)
        Me.btnSWSave.Name = "btnSWSave"
        Me.btnSWSave.Size = New System.Drawing.Size(90, 30)
        Me.btnSWSave.TabIndex = 6
        Me.btnSWSave.Text = "Save"
        Me.btnSWSave.UseVisualStyleBackColor = True
        '
        'tbxMisc
        '
        Me.tbxMisc.Location = New System.Drawing.Point(142, 133)
        Me.tbxMisc.Multiline = True
        Me.tbxMisc.Name = "tbxMisc"
        Me.tbxMisc.Size = New System.Drawing.Size(242, 50)
        Me.tbxMisc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Miscellenous:"
        '
        'tbxSocialWorker
        '
        Me.tbxSocialWorker.Location = New System.Drawing.Point(142, 69)
        Me.tbxSocialWorker.Multiline = True
        Me.tbxSocialWorker.Name = "tbxSocialWorker"
        Me.tbxSocialWorker.Size = New System.Drawing.Size(242, 47)
        Me.tbxSocialWorker.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Social Worker:"
        '
        'cbbxClientNo
        '
        Me.cbbxClientNo.FormattingEnabled = True
        Me.cbbxClientNo.Location = New System.Drawing.Point(142, 28)
        Me.cbbxClientNo.Name = "cbbxClientNo"
        Me.cbbxClientNo.Size = New System.Drawing.Size(164, 24)
        Me.cbbxClientNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client No:"
        '
        'FORM_SOCIALWORKER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(530, 196)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FORM_SOCIALWORKER"
        Me.Text = "Social Worker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxSocialWorker As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbbxClientNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSWSave As System.Windows.Forms.Button
    Friend WithEvents tbxMisc As System.Windows.Forms.TextBox
    Friend WithEvents btnSWCancel As System.Windows.Forms.Button
End Class
