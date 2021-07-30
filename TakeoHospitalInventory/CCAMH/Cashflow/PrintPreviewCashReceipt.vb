Public Class PrintPreviewCashReceipt
    Public IS_PRINT_NEWRECEIPT As Boolean = False
    Public IS_PRINT_OLDRECEIPT As Boolean = False
    Public IS_PRINT_SPRECEIPT As Boolean = False
    Public IS_PRINT_MED As Boolean = False
    Public IS_PRINT_CONTRIBUTE As Boolean = False
    Public IS_PRINT_PRESCRIPTION As Boolean = False

    Public IS_PRINT_RECEIPT_DETAIL As Boolean = False
    Public IS_PRINT_DIALY_CASHCONTRIBUTE As Boolean = False
    Public IS_PRINT_WEEKLLY_CASH As Boolean = False
    Public IS_PRINT_DRUGPRICE As Boolean = False
    Public CrystalReportObject As Object
    Private Sub PrintPreviewCashReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IS_PRINT_NEWRECEIPT = True Then
            'ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") ' Me.AxAcroPDFVeiwer, "CCAMH_NewReceipt")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        ElseIf IS_PRINT_OLDRECEIPT = True Then
            ' ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") ' Me.AxAcroPDFVeiwer, "CCAMH_FollowUPReceipt")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        ElseIf IS_PRINT_MED = True Then
            'ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") ' Me.AxAcroPDFVeiwer, "CCAMH_Medicine")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        ElseIf IS_PRINT_SPRECEIPT = True Then
            ' ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") ' Me.AxAcroPDFVeiwer, "CCAMH_Spacial")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        ElseIf IS_PRINT_DIALY_CASHCONTRIBUTE = True Then
            'ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") 'Me.AxAcroPDFVeiwer, "CCAMH_CashContribute")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        ElseIf IS_PRINT_WEEKLLY_CASH = True Then
            ' ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") 'Me.AxAcroPDFVeiwer, "CCAMH_WeellyCashContribute")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        ElseIf IS_PRINT_PRESCRIPTION = True Then
            'ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") 'Me.AxAcroPDFVeiwer, "CCAMH_Prescription")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        ElseIf IS_PRINT_DRUGPRICE = True Then
            ' ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") 'Me.AxAcroPDFVeiwer, "CCAMH_DrugPrice")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        ElseIf IS_PRINT_CONTRIBUTE = True Then
            'ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") 'Me.AxAcroPDFVeiwer, "CCAMH_ContributeReceipt")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        ElseIf IS_PRINT_RECEIPT_DETAIL = True Then
            'ReceiptUtilityModule.ExportPDFViewer(CrystalReportObject, Nothing, "") ' Me.AxAcroPDFVeiwer, "CCAMH_ReceiptCollection")
            Me.CrystalReportViewer1.ReportSource = CrystalReportObject
        End If

    End Sub
End Class