Public Class UIAssessedClients
    Dim DA_SCHEDULES As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_VIEW_ACTIVE_ADVISED_CLIENTSTableAdapter
    Dim DA_ASSESS_DETAIL As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_ASSESSMENT_DETAILTableAdapter
    Dim TblClient As DataTable
    Dim TblAssessDetail As DataTable
    Private Sub UIAssessedClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridClient.DataSource = DA_SCHEDULES.GetData
    End Sub

    Private Sub BtnClientRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientRefresh.Click
        DataGridClient.DataSource = DA_SCHEDULES.GetData
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim CRAssessPreview As New ReportAssessedClient
        Dim FPrintPreview As New AssessPrintPreview
        TblClient = DA_SCHEDULES.SelectClinicalByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        TblAssessDetail = DA_ASSESS_DETAIL.GetDataByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        CRAssessPreview.Database.Tables(0).SetDataSource(TblClient)
        CRAssessPreview.Database.Tables(1).SetDataSource(TblAssessDetail)
        FPrintPreview.CrystalReportObject = CRAssessPreview
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
    End Sub

    Private Sub BtnViewDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewDetail.Click
        If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim frmAssessment As New FormClinicalAuditAssessment
        frmAssessment.getIsUpdate = True
        frmAssessment.getPatientNo = DataGridClient.GetRow.Cells("CLIENT_NO").Value
        If frmAssessment.ShowDialog() = DialogResult.OK Then

        End If
    End Sub
End Class
