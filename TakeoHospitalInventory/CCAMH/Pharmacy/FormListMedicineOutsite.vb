Public Class FormListMedicineOutsite
    Dim DA_MedicineOutside As New DSPrescriptionTableAdapters.CCAMH_VIEW_PRESCRIPTIONTableAdapter

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        Dim tblMedicine As DataTable = DA_MedicineOutside.SelectPrescriptionWithItemDetail(DateFrom.Value.Date, DateTo.Value.Date, "OUT")
        Dim CRVMedOutside As New CRVMedicineOutsite
        CRVMedOutside.SetDataSource(tblMedicine)
        Me.CrystalReportViewer1.ReportSource = CRVMedOutside
        CRVMedOutside.SetParameterValue("title", "From: " & Format(DateFrom.Value, "dd/MM/yyy") & " To: " & Format(DateTo.Value, "dd/MM/yyyy"))
    End Sub
End Class