<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPROGNOSIS
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbxPROGNOSIS = New System.Windows.Forms.TextBox
        Me.tbxPROGMisc = New System.Windows.Forms.TextBox
        Me.btnPROGSave = New System.Windows.Forms.Button
        Me.btnPROGCancel = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnPROGCancel)
        Me.Panel1.Controls.Add(Me.btnPROGSave)
        Me.Panel1.Controls.Add(Me.tbxPROGMisc)
        Me.Panel1.Controls.Add(Me.tbxPROGNOSIS)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 208)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Miscellaneous:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROGNOSIS:"
        '
        'tbxPROGNOSIS
        '
        Me.tbxPROGNOSIS.Location = New System.Drawing.Point(119, 26)
        Me.tbxPROGNOSIS.Multiline = True
        Me.tbxPROGNOSIS.Name = "tbxPROGNOSIS"
        Me.tbxPROGNOSIS.Size = New System.Drawing.Size(227, 35)
        Me.tbxPROGNOSIS.TabIndex = 2
        '
        'tbxPROGMisc
        '
        Me.tbxPROGMisc.Location = New System.Drawing.Point(119, 67)
        Me.tbxPROGMisc.Multiline = True
        Me.tbxPROGMisc.Name = "tbxPROGMisc"
        Me.tbxPROGMisc.Size = New System.Drawing.Size(227, 40)
        Me.tbxPROGMisc.TabIndex = 3
        '
        'btnPROGSave
        '
        Me.btnPROGSave.Location = New System.Drawing.Point(119, 163)
        Me.btnPROGSave.Name = "btnPROGSave"
        Me.btnPROGSave.Size = New System.Drawing.Size(84, 33)
        Me.btnPROGSave.TabIndex = 4
        Me.btnPROGSave.Text = "Save"
        Me.btnPROGSave.UseVisualStyleBackColor = True
        '
        'btnPROGCancel
        '
        Me.btnPROGCancel.Location = New System.Drawing.Point(246, 163)
        Me.btnPROGCancel.Name = "btnPROGCancel"
        Me.btnPROGCancel.Size = New System.Drawing.Size(88, 33)
        Me.btnPROGCancel.TabIndex = 5
        Me.btnPROGCancel.Text = "Cancel"
        Me.btnPROGCancel.UseVisualStyleBackColor = True
        '
        'FormPROGNOSIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 209)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPROGNOSIS"
        Me.Text = "FormPROGNOSIS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPROGCancel As System.Windows.Forms.Button
    Friend WithEvents btnPROGSave As System.Windows.Forms.Button
    Friend WithEvents tbxPROGMisc As System.Windows.Forms.TextBox
    Friend WithEvents tbxPROGNOSIS As System.Windows.Forms.TextBox
End Class
