<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinRConsultStatistic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinRConsultStatistic))
        Me.CrvConsulting = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrvConsulting
        '
        Me.CrvConsulting.ActiveViewIndex = -1
        Me.CrvConsulting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvConsulting.DisplayGroupTree = False
        Me.CrvConsulting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvConsulting.Location = New System.Drawing.Point(0, 0)
        Me.CrvConsulting.Name = "CrvConsulting"
        Me.CrvConsulting.SelectionFormula = ""
        Me.CrvConsulting.ShowGroupTreeButton = False
        Me.CrvConsulting.Size = New System.Drawing.Size(1168, 694)
        Me.CrvConsulting.TabIndex = 1
        Me.CrvConsulting.ViewTimeSelectionFormula = ""
        '
        'WinRConsultStatistic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 694)
        Me.Controls.Add(Me.CrvConsulting)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WinRConsultStatistic"
        Me.ShowInTaskbar = False
        Me.Text = "Consult Statistic"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvConsulting As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
