<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReferCenter
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbxReferredName = New System.Windows.Forms.TextBox
        Me.tbxReferredMisc = New System.Windows.Forms.TextBox
        Me.btnRCSave = New System.Windows.Forms.Button
        Me.btnRCCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REFERRED NAME:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Miscellenous:"
        '
        'tbxReferredName
        '
        Me.tbxReferredName.Location = New System.Drawing.Point(185, 52)
        Me.tbxReferredName.Multiline = True
        Me.tbxReferredName.Name = "tbxReferredName"
        Me.tbxReferredName.Size = New System.Drawing.Size(286, 35)
        Me.tbxReferredName.TabIndex = 2
        '
        'tbxReferredMisc
        '
        Me.tbxReferredMisc.Location = New System.Drawing.Point(185, 117)
        Me.tbxReferredMisc.Multiline = True
        Me.tbxReferredMisc.Name = "tbxReferredMisc"
        Me.tbxReferredMisc.Size = New System.Drawing.Size(286, 35)
        Me.tbxReferredMisc.TabIndex = 3
        '
        'btnRCSave
        '
        Me.btnRCSave.Location = New System.Drawing.Point(315, 164)
        Me.btnRCSave.Name = "btnRCSave"
        Me.btnRCSave.Size = New System.Drawing.Size(75, 32)
        Me.btnRCSave.TabIndex = 4
        Me.btnRCSave.Text = "Save"
        Me.btnRCSave.UseVisualStyleBackColor = True
        '
        'btnRCCancel
        '
        Me.btnRCCancel.Location = New System.Drawing.Point(396, 164)
        Me.btnRCCancel.Name = "btnRCCancel"
        Me.btnRCCancel.Size = New System.Drawing.Size(75, 32)
        Me.btnRCCancel.TabIndex = 5
        Me.btnRCCancel.Text = "Cancel"
        Me.btnRCCancel.UseVisualStyleBackColor = True
        '
        'FormReferCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(486, 208)
        Me.Controls.Add(Me.btnRCCancel)
        Me.Controls.Add(Me.btnRCSave)
        Me.Controls.Add(Me.tbxReferredMisc)
        Me.Controls.Add(Me.tbxReferredName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormReferCenter"
        Me.Text = "FormReferCenter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxReferredName As System.Windows.Forms.TextBox
    Friend WithEvents tbxReferredMisc As System.Windows.Forms.TextBox
    Friend WithEvents btnRCSave As System.Windows.Forms.Button
    Friend WithEvents btnRCCancel As System.Windows.Forms.Button
End Class
