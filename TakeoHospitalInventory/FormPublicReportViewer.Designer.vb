<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPublicReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPublicReportViewer))
        Me.CrvViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrvViewer
        '
        Me.CrvViewer.ActiveViewIndex = -1
        Me.CrvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrvViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrvViewer.Name = "CrvViewer"
        Me.CrvViewer.Size = New System.Drawing.Size(1055, 618)
        Me.CrvViewer.TabIndex = 0
        Me.CrvViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormPublicReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 618)
        Me.Controls.Add(Me.CrvViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPublicReportViewer"
        Me.ShowInTaskbar = False
        Me.Text = "Print Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
