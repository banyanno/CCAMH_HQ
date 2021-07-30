<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Unit_Allocation
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
        Me.btnUnitSave = New System.Windows.Forms.Button
        Me.txtUnit1 = New System.Windows.Forms.TextBox
        Me.txtUnit2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.hidden_client_no = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnUnitSave
        '
        Me.btnUnitSave.Location = New System.Drawing.Point(78, 147)
        Me.btnUnitSave.Name = "btnUnitSave"
        Me.btnUnitSave.Size = New System.Drawing.Size(164, 44)
        Me.btnUnitSave.TabIndex = 0
        Me.btnUnitSave.Text = "Save"
        Me.btnUnitSave.UseVisualStyleBackColor = True
        '
        'txtUnit1
        '
        Me.txtUnit1.Location = New System.Drawing.Point(78, 37)
        Me.txtUnit1.Multiline = True
        Me.txtUnit1.Name = "txtUnit1"
        Me.txtUnit1.Size = New System.Drawing.Size(164, 40)
        Me.txtUnit1.TabIndex = 1
        '
        'txtUnit2
        '
        Me.txtUnit2.Location = New System.Drawing.Point(78, 83)
        Me.txtUnit2.Multiline = True
        Me.txtUnit2.Name = "txtUnit2"
        Me.txtUnit2.Size = New System.Drawing.Size(164, 42)
        Me.txtUnit2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "UNIT I"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "UNIT II"
        '
        'hidden_client_no
        '
        Me.hidden_client_no.AutoSize = True
        Me.hidden_client_no.Location = New System.Drawing.Point(128, 219)
        Me.hidden_client_no.Name = "hidden_client_no"
        Me.hidden_client_no.Size = New System.Drawing.Size(0, 13)
        Me.hidden_client_no.TabIndex = 5
        Me.hidden_client_no.Visible = False
        '
        'Frm_Unit_Allocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 290)
        Me.Controls.Add(Me.hidden_client_no)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUnit2)
        Me.Controls.Add(Me.txtUnit1)
        Me.Controls.Add(Me.btnUnitSave)
        Me.Name = "Frm_Unit_Allocation"
        Me.Text = "Unit Allocation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUnitSave As System.Windows.Forms.Button
    Friend WithEvents txtUnit1 As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents hidden_client_no As System.Windows.Forms.Label
End Class
