Public Class DashboardCCAHMIncomeSummary
    Dim DA_TotalCashCollection As New DSCashCollectionTableAdapters.CCAMH_VIEW_TOTAL_DIALYINCOMETableAdapter
    Dim DA_IncomeSummary As New DSCashCollectionTableAdapters.CCAMH_VIEW_INCOMESUMMARYTableAdapter
    Dim DA_SpacialDetail As New DSCashCollectionTableAdapters.CCAMH_RECEPT_SPACIAL_SOCIAL_DETAILTableAdapter
    Dim DA_MedDetail As New DSCashCollectionTableAdapters.CCAMH_RECEPT_MED_SOCIAL_DETAILTableAdapter
    Dim DACCAMH_RECEIPT As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim DA_Prescipt_Detial As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTION_DETIALTableAdapter
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter

    Dim mainForm As MainAppKTG

    Dim TblCCAMHReceipt As DataTable
    Dim TblReceiptDetail As DataTable
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
 
  

    Private Sub PreviewTotalCash(ByVal DaFrom As DateTime)
        GridDialyCashCollection.DataSource = TblDialyCashContribute
    End Sub

    Private Sub BGloading_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGloadDiallyCollection.DoWork

        TblDialyCashContribute = DA_TotalCashCollection.SelectIncomeDateToDate(DFrom.Value.Date, DTo.Value.Date) 'SelectTotalDialCashByDate(DFrom.Value.Date, DTo.Value.Date)
    End Sub

    Private Sub BGloading_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGloadDiallyCollection.RunWorkerCompleted
        If IS_PRINT_REPORT = False Then
            GridDialyCashCollection.DataSource = TblDialyCashContribute
        ElseIf IS_PRINT_REPORT = True Then
            Dim FPrintPreviedw As New PrintPreviewCashReceipt
            FPrintPreviedw.IS_PRINT_DIALY_CASHCONTRIBUTE = True
            Dim CDialyCash As New CRVDialyCashContributeCollection
            CDialyCash.SetDataSource(TblDialyCashContribute)
            CDialyCash.SetParameterValue("DateToDate", "From:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy"))
            FPrintPreviedw.CrystalReportObject = CDialyCash
            FPrintPreviedw.ShowDialog()
        End If

        Application.DoEvents()
        mainForm.StatusLoading(False, "")

    End Sub


    Private Sub BtnPrintWeeklyCashReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BGLoadingWeeklly_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGLoadingWeeklly.DoWork
        TblIncomeSummary = DA_IncomeSummary.SelectIncomeDateToDate(DFrom.Value.Date, DTo.Value.Date)
    End Sub

    Private Sub BGLoadingWeeklly_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGLoadingWeeklly.RunWorkerCompleted
        Dim FPrintPreviedw As New PrintPreviewCashReceipt
        FPrintPreviedw.IS_PRINT_WEEKLLY_CASH = True
        Dim CIncomeSumary As New CrySummaryIncome
        CIncomeSumary.SetDataSource(TblIncomeSummary)
        CIncomeSumary.SetParameterValue("DateToDate", "From:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy"))
        FPrintPreviedw.CrystalReportObject = CIncomeSumary
        FPrintPreviedw.ShowDialog()
        mainForm.StatusLoading(False, "")
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadReceiptClient.Checked = True Then
            RefreshWaitingPayment()
        ElseIf RadDiallyCashCollection.Checked = True Then
            IS_PRINT_REPORT = False
            mainForm.StatusLoading(True, "Loading...")
            Application.DoEvents()
            BGloadDiallyCollection.RunWorkerAsync()
        ElseIf RadClientContribute.Checked = True Then
            GridWeekllyCollection.DataSource = DA_IncomeSummary.SelectIncomeDateToDate(DFrom.Value.Date, DTo.Value.Date)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadReceiptClient.Checked = True Then
            IS_PRINT_REPORT = True
            mainForm.StatusLoading(True, "Loading...")
            Application.DoEvents()
            BGLoadingReceiptDetail.RunWorkerAsync()
        ElseIf RadDiallyCashCollection.Checked = True Then
            IS_PRINT_REPORT = True
            mainForm.StatusLoading(True, "Loading...")
            Application.DoEvents()
            BGloadDiallyCollection.RunWorkerAsync()
        ElseIf RadClientContribute.Checked = True Then
            mainForm.StatusLoading(True, "Printing")
            Application.DoEvents()
            BGLoadingWeeklly.RunWorkerAsync()
        End If
       
    End Sub

   


    Private Sub GridClientWaitingPayment_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridClientWaitingPayment.SelectionChanged
        If GridClientWaitingPayment.SelectedItems.Count = 0 Then Exit Sub
        RefreshServiceDetail(GridClientWaitingPayment.GetRow.Cells("RECEIPT_NO").Value)
    End Sub
    Private Sub RefreshServiceDetail(ByVal ReceiptNo As Double)

        GridPrescription.DataSource = DA_Prescipt_Detial.SelectMedicineByReceiptNo(ReceiptNo)
        GridServiceSpacial.DataSource = DA_SpacialDetail.SelectSpacialServiceByReceiptNo(ReceiptNo)
        CalculatePaymentSumarry(ReceiptNo)
    End Sub
    Private Sub CalculatePaymentSumarry(ByVal ReceiptNo As Double)
        Try
            LblTotalServiceNewConsult.Text = DACCAMH_RECEIPT.TotalServiceNew(ReceiptNo)
            LblTotalServiceFollowUp.Text = DACCAMH_RECEIPT.TotalServiceFollowup(ReceiptNo)
            LblTotalServiceContribute.Text = DACCAMH_RECEIPT.TotalServiceContribution(ReceiptNo)
            LblTotalServiceSpacial.Text = DACCAMH_RECEIPT.TotalServiceSpacial(ReceiptNo)
            LblTotalServiceMedicine.Text = DACCAMH_RECEIPT.TotalServiceMedicine(ReceiptNo)
            LblTotalPayment.Text = CDbl(LblTotalServiceNewConsult.Text) + CDbl(LblTotalServiceFollowUp.Text) + CDbl(LblTotalServiceContribute.Text) + CDbl(LblTotalServiceSpacial.Text) + CDbl(LblTotalServiceMedicine.Text)
        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub RefreshWaitingPayment()
        GridClientWaitingPayment.DataSource = DACCAMH_RECEIPT.SelectPatientPaidDateByDate(True, DFrom.Value.Date, DTo.Value.Date)
    End Sub

    Private Sub RadReceiptClient_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReceiptClient.CheckedChanged
        TabIncome.SelectedIndex = 0
        GroupPaymentSummary.Visible = RadReceiptClient.Checked
        UiTabPage1.Enabled = RadReceiptClient.Checked
    End Sub

    Private Sub RadDiallyCashCollection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDiallyCashCollection.CheckedChanged
        TabIncome.SelectedIndex = 1
        UiTabPage2.Enabled = RadDiallyCashCollection.Checked
    End Sub

    Private Sub RadClientContribute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientContribute.CheckedChanged
        TabIncome.SelectedIndex = 2
        UiTabPageContrition.Enabled = RadClientContribute.Checked
    End Sub

    'Private Sub TabImcome_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles TabImcome.SelectedTabChanged
    '    If TabImcome.SelectedIndex = 0 Then
    '        RadReceiptClient.Checked = True
    '    ElseIf TabImcome.SelectedIndex = 1 Then
    '        RadDiallyCashCollection.Checked = True
    '    ElseIf TabImcome.SelectedIndex = 2 Then
    '        RadClientContribute.Checked = True
    '    End If
    'End Sub

    Private Sub BGLoadingReceiptDetail_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGLoadingReceiptDetail.DoWork
        TblReceiptDetail = DACCAMH_RECEIPT.SelectPatientPaidDateByDate(True, DFrom.Value.Date, DTo.Value.Date)
    End Sub

    Private Sub BGLoadingReceiptDetail_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGLoadingReceiptDetail.RunWorkerCompleted


        If IS_PRINT_REPORT = False Then
            GridClientWaitingPayment.DataSource = TblReceiptDetail
        ElseIf IS_PRINT_REPORT = True Then
            Dim FPrintPreviedw As New PrintPreviewCashReceipt
            FPrintPreviedw.IS_PRINT_RECEIPT_DETAIL = True
            If ChViewDetial.Checked = False Then
                Dim CRReceiptDetailV2 As New CRVIncomeDetailV2
                CRReceiptDetailV2.SetDataSource(TblReceiptDetail)
                CRReceiptDetailV2.SetParameterValue("title", "From:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy"))
                FPrintPreviedw.CrystalReportObject = CRReceiptDetailV2
                FPrintPreviedw.ShowDialog()
            Else
                Dim CRReceiptDetail As New CRVIncomeDetail
                CRReceiptDetail.SetDataSource(TblReceiptDetail)
                CRReceiptDetail.SetParameterValue("title", "From:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy"))
                FPrintPreviedw.CrystalReportObject = CRReceiptDetail
                FPrintPreviedw.ShowDialog()
            End If

        End If

        Application.DoEvents()
        mainForm.StatusLoading(False, "")
    End Sub

    Private Sub BtnPrintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReceipt.Click
        If GridClientWaitingPayment.SelectedItems.Count = 0 Then Exit Sub
        Application.DoEvents()
        MainFormApplicationPublic.StatusLoading(True, "Loading...")
        BgPrintReceipt.RunWorkerAsync()
    End Sub

    Private Sub BgPrintReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgPrintReceipt.DoWork
        TblCCAMHReceipt = DACCAMH_RECEIPT.SelectCashByReceiptNo(EmptyString(GridClientWaitingPayment.GetRow.Cells("RECEIPT_NO").Value))
    End Sub

    Private Sub BgPrintReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgPrintReceipt.RunWorkerCompleted
        DoPrintReceipt(TblCCAMHReceipt)
        MainFormApplicationPublic.StatusLoading(False, "")

        Application.DoEvents()
        'BgPrintReport.RunWorkerAsync()
    End Sub
    Private Sub DoPrintReceipt(ByVal DTable As DataTable)
        Dim FPrintPreview As New PrintPreviewCashReceipt
        Dim CRNewReceipt As New CRNewClientReceipt
        FPrintPreview.IS_PRINT_NEWRECEIPT = True
        CRNewReceipt.SetDataSource(TblCCAMHReceipt)
        FPrintPreview.CrystalReportObject = CRNewReceipt
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()

        'End If
    End Sub

    Private Sub GridClientWaitingPayment_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridClientWaitingPayment.RowDoubleClick



        DoPrintReceipt()


    End Sub
    

    Private Sub DoPrintReceipt()
      
        Dim FPrintPreview As New PrintPreviewCashReceipt
        FPrintPreview.IS_PRINT_NEWRECEIPT = True
        Dim CRNewReceipt As New CRNewClientReceipt
        Dim TblIssueReceipt As DataTable = DAClientReceipt.SelectCashByReceiptNo(EmptyString(GridClientWaitingPayment.GetRow.Cells("RECEIPT_NO").Value))
        CRNewReceipt.SetDataSource(TblIssueReceipt)
        'CRNewReceipt.SetParameterValue("title", Now.Date)
        FPrintPreview.CrystalReportObject = CRNewReceipt

        FPrintPreview.ShowDialog()
        FPrintPreview.Close()


    End Sub

    
    Private Sub BGLoadingReceiptDetail_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BGLoadingReceiptDetail.ProgressChanged

    End Sub
End Class
