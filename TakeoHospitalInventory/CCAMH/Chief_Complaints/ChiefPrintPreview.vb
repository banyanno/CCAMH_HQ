Public Class ChiefPrintPreview
    Public CrystalReportObject As Object
    Private Sub ChiefPrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "CCAMH_ChiefComplaint")
        Me.CrystalReportViewer1.ReportSource = CrystalReportObject
    End Sub
End Class