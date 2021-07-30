Public Class FormCashCollection
    Dim DA_TotalCashCollection As New DSCashCollectionTableAdapters.CCAMH_VIEW_DAILY_CASHTableAdapter
    Dim DA_IncomeSummary As New DSCashCollectionTableAdapters.CCAMH_VIEW_INCOMESUMMARYTableAdapter
    Dim mainForm As MainAppKTG

    Dim TblDialyCashContribute As DataTable
    Dim TblIncomeSummary As DataTable
    Dim IS_PRINT_REPORT As Boolean = False
    Dim IS_WEEKLY As Boolean = False
    Sub New(ByVal mainForm As MainAppKTG)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.mainForm = mainForm
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnPreviewDialy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreviewDialy.Click
        IS_PRINT_REPORT = False
        mainForm.StatusLoading(True, "Loading...")
        Application.DoEvents()
        BGloadDiallyCollection.RunWorkerAsync()
    End Sub
    Private Sub BtnPrintCashDistribute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintCashDistribute.Click
        IS_PRINT_REPORT = True
        mainForm.StatusLoading(True, "Loading...")
        Application.DoEvents()
        BGloadDiallyCollection.RunWorkerAsync()
    End Sub

    Private Sub PreviewTotalCash(ByVal DaFrom As DateTime)
        GridDialyCashCollection.DataSource = TblDialyCashContribute
    End Sub

    Private Sub BGloading_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGloadDiallyCollection.DoWork

        TblDialyCashContribute = DA_TotalCashCollection.SelectTotalDialCashByDate(DFrom.Value.Date, DTo.Value.Date)
    End Sub

    Private Sub BGloading_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGloadDiallyCollection.RunWorkerCompleted
        If IS_PRINT_REPORT = False Then
            GridDialyCashCollection.DataSource = TblDialyCashContribute
        ElseIf IS_PRINT_REPORT = True Then
            Dim FPrintPreviedw As New PrintPreviewCashReceipt
            FPrintPreviedw.IS_PRINT_DIALY_CASHCONTRIBUTE = True
            Dim CDialyCash As New CRVDialyCashContributeCollection
            CDialyCash.SetDataSource(TblDialyCashContribute)
            CDialyCash.SetParameterValue("DateToDate", "From:" & DFrom.Value.Date & " To:" & DTo.Value.Date)
            FPrintPreviedw.CrystalReportObject = CDialyCash
            FPrintPreviedw.ShowDialog()
        End If

        Application.DoEvents()
        mainForm.StatusLoading(False, "")

    End Sub


    Private Sub BtnPrintWeeklyCashReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintWeeklyCashReport.Click
        BGLoadingWeeklly.RunWorkerAsync()
    End Sub

    Private Sub BGLoadingWeeklly_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGLoadingWeeklly.DoWork
        TblIncomeSummary = DA_IncomeSummary.SelectIncomeDateToDate(DContFrom.Value.Date, DContTo.Value.Date)
    End Sub

    Private Sub BGLoadingWeeklly_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGLoadingWeeklly.RunWorkerCompleted
        Dim FPrintPreviedw As New PrintPreviewCashReceipt
        FPrintPreviedw.IS_PRINT_WEEKLLY_CASH = True
        Dim CIncomeSumary As New CrySummaryIncome
        CIncomeSumary.SetDataSource(TblIncomeSummary)
        CIncomeSumary.SetParameterValue("DateToDate", "From:" & DContFrom.Value.Date & " To:" & DContTo.Value.Date)
        FPrintPreviedw.CrystalReportObject = CIncomeSumary
        FPrintPreviedw.ShowDialog()
    End Sub

    Private Sub BtnWeeklly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWeeklly.Click
        GridWeekllyCollection.DataSource = DA_IncomeSummary.SelectIncomeDateToDate(DContFrom.Value.Date, DContTo.Value.Date)
    End Sub
End Class