Public Class RegisPrintPreview
    Public CrystalReportObject As Object

    Private Sub RegisPrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "CCAMH_NewReceipt")
        Me.CrystalReportViewer1.ReportSource = CrystalReportObject
    End Sub
End Class