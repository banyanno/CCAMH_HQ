Public Class DashboardCCAMHClientReports
    Dim DA_View_ClientMG As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_VIEW_CLIENT_MANAGERMANT_V1TableAdapter
    Dim CRVReportCLientAudit As New CCAHM_CLIENT_REPORT_AUDIT
    Private Sub RadPatient_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatient.CheckedChanged
        GroupPatient.Enabled = RadPatient.Checked
    End Sub
    Private Sub RadDiagnosisBreakup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDiagnosisBreakup.CheckedChanged
        GroupDiagnosisBreakup.Enabled = RadDiagnosisBreakup.Checked
    End Sub

    Private Sub BtnPrintPreviewWeekly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreviewWeekly.Click
        Dim TblNewClient As DataTable = DA_View_ClientMG.SelectDateToDateWithNewOrOld(DateFrom.Value.Date, DateTo.Value.Date, 0)  'DA_View_ClientMG.SelectAllClientMg(DateFrom.Value.Date, DateTo.Value.Date, 0)
        Dim TblOldClient As DataTable = DA_View_ClientMG.SelectDateToDateWithNewOrOld(DateFrom.Value.Date, DateTo.Value.Date, 1) 'DA_View_ClientMG.SelectAllClientMg(DateFrom.Value.Date, DateTo.Value.Date, 1)
        Dim DblTotalNewOlClient As DataTable = DA_View_ClientMG.SelectAllClientRegister(DateFrom.Value.Date, DateTo.Value.Date) 'DA_View_ClientMG.SelectDataClientDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        CRVReportCLientAudit.Subreports("NewClientReportAudit.rpt").SetDataSource(TblNewClient)
        CRVReportCLientAudit.Subreports("OldClientReportAudit.rpt").SetDataSource(TblOldClient)
        CRVReportCLientAudit.Subreports("NewOldClientReportAudit.rpt").SetDataSource(DblTotalNewOlClient)
        CRVReportCLientAudit.SetParameterValue("Title", "From: " & Format(DateFrom.Value, "dd-MMM-yyyy") & " To: " & Format(DateTo.Value, "dd-MMM-yyyy"))
        CryViewReport.ReportSource = CRVReportCLientAudit

    End Sub
End Class
