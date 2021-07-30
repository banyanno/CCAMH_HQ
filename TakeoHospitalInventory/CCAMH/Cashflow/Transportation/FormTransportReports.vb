Public Class FormTransportReports
    Dim DA_Transportation As New DSCashCollectionTableAdapters.CCAMH_TRANSPORTATIONTableAdapter
    Dim CRVObjTransport As New CRVTransportSupported
    Dim TblTransport As DataTable
    Private Sub BtnFindClientReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindClientReceipt.Click
        TblTransport = DA_Transportation.SelectTransportByDateToDateWithDeleteStatus(DFrom.Value.Date, DTo.Value.Date, False)
        CRVObjTransport.SetDataSource(TblTransport)
        CRVObjTransport.SetParameterValue("DateFromTO", "From:" & DFrom.Text & " To:" & DTo.Text)
        Me.CrystalReportViewer1.ReportSource = CRVObjTransport
        'ModGlobleVariable.ExportCrystalToPDF(CRVObjTransport, Me.AxAcroPDF1, "Transportation")
        ''AxAcroPDF1.ShowPropertyPages()
        'Me.AxAcroPDF1.Refresh()
        Me.Refresh()
    End Sub
End Class