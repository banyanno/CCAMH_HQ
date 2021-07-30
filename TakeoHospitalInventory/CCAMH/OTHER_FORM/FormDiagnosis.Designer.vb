<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDiagnosis
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
        Dim DGDiagnosis_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDiagnosis))
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbxDiagnosis = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.DGDiagnosis = New Janus.Windows.GridEX.GridEX
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbxMisc = New System.Windows.Forms.TextBox
        CType(Me.DGDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diagnosis:"
        '
        'tbxDiagnosis
        '
        Me.tbxDiagnosis.Location = New System.Drawing.Point(102, 9)
        Me.tbxDiagnosis.Multiline = True
        Me.tbxDiagnosis.Name = "tbxDiagnosis"
        Me.tbxDiagnosis.Size = New System.Drawing.Size(422, 80)
        Me.tbxDiagnosis.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(530, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 31)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(530, 42)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DGDiagnosis
        '
        Me.DGDiagnosis.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        DGDiagnosis_DesignTimeLayout.LayoutString = resources.GetString("DGDiagnosis_DesignTimeLayout.LayoutString")
        Me.DGDiagnosis.DesignTimeLayout = DGDiagnosis_DesignTimeLayout
        Me.DGDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGDiagnosis.GroupByBoxVisible = False
        Me.DGDiagnosis.Location = New System.Drawing.Point(-4, 191)
        Me.DGDiagnosis.Name = "DGDiagnosis"
        Me.DGDiagnosis.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.DGDiagnosis.Size = New System.Drawing.Size(619, 178)
        Me.DGDiagnosis.TabIndex = 4
        Me.DGDiagnosis.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Miscellenous:"
        '
        'tbxMisc
        '
        Me.tbxMisc.Location = New System.Drawing.Point(102, 95)
        Me.tbxMisc.Multiline = True
        Me.tbxMisc.Name = "tbxMisc"
        Me.tbxMisc.Size = New System.Drawing.Size(422, 71)
        Me.tbxMisc.TabIndex = 6
        '
        'FormDiagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 370)
        Me.Controls.Add(Me.tbxMisc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGDiagnosis)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbxDiagnosis)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDiagnosis"
        Me.Text = "Diagnosis"
        CType(Me.DGDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DGDiagnosis As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxMisc As System.Windows.Forms.TextBox
End Class
