Public Class DashboardWaitingPayment
    Dim DACCAMH_RECEIPT As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim DA_SpacialDetail As New DSCashCollectionTableAdapters.CCAMH_RECEPT_SPACIAL_SOCIAL_DETAILTableAdapter
    Public DA_Prescipt As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTIONTableAdapter
    Dim DA_Prescipt_Detial As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTION_DETIALTableAdapter
    Dim DA_MainPresc As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTIONTableAdapter
    Dim TblCCAMHReceipt As DataTable
    Dim MainKTG As MainAppKTG
    Sub New(ByVal MainKTG As MainAppKTG)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainKTG = MainKTG
        ' Add any initialization after the InitializeComponent() call.

    End Sub
   

  
    Public Sub FindReceiptByClientNo(ByVal ClientNo As Double)
        GridClientWaitingPayment.DataSource = DACCAMH_RECEIPT.SelectReceiptByClientNo(ClientNo, False)
    End Sub
    Public Sub FindReceiptByClientName(ByVal ClientName As String)
        GridClientWaitingPayment.DataSource = DACCAMH_RECEIPT.FindReceiptByName(ClientName, False)
    End Sub
    Public Sub FindReceiptByReceiptNo(ByVal ReceiptNo As Double)
        GridClientWaitingPayment.DataSource = DACCAMH_RECEIPT.SelectReceiptByReceiptNo(ReceiptNo, False)
    End Sub
    Public Sub FindReceiptByReceiptNoUseLike(ByVal ReceiptNo As String)
        GridClientWaitingPayment.DataSource = DACCAMH_RECEIPT.SelectReceiptNoUseLike(False, ReceiptNo)
    End Sub

    Private Sub RefreshWaitingPayment()
        GridClientWaitingPayment.DataSource = DACCAMH_RECEIPT.SelectClientWaitingPayment(False, False)
        LoadingTotalClient()
        'LblTotalWaiting.Text = DACCAMH_RECEIPT.TotalWaitingPayment(False)
        'LblTotalPaidNew.Text = FormatNumber(DACCAMH_RECEIPT.TotalClientPaidByReceiptType(ReceiptUtilityModule.RECEIPT_NEW, True, DFrom.Value.Date, DTo.Value.Date)) & "៛"
        'LblTotalPaidFollowup.Text = FormatNumber(DACCAMH_RECEIPT.TotalClientPaidByReceiptType(ReceiptUtilityModule.RECEIPT_FOLLOWUP, True, DFrom.Value.Date, DTo.Value.Date)) & "៛"
        'lblTotalPaidMedic.Text = FormatNumber(DACCAMH_RECEIPT.TotalClientPaidByReceiptType(ReceiptUtilityModule.RECEIPT_MED, True, DFrom.Value.Date, DTo.Value.Date)) & "៛"
        'LblTotalPaidSpacialService.Text = FormatNumber(DACCAMH_RECEIPT.TotalClientPaidByReceiptType(ReceiptUtilityModule.RECEIPT_SPACIAL, True, DFrom.Value.Date, DTo.Value.Date)) & "៛"
    End Sub
    Private Sub LoadingTotalClient()
        '==================== new client =========================
        LblNewFemale.Text = TotalNewFemale()
        LblNewMale.Text = TotalNewMale()
        LblTotalNewCleint.Text = CInt(LblNewFemale.Text) + CInt(LblNewMale.Text)

        '===================== Follow Up client ===================
        LblFollMale.Text = TotalFollMale()
        LblFollFemale.Text = TotalFollFemale()
        LblTotalFollowup.Text = CInt(LblFollFemale.Text) + CInt(LblFollMale.Text)

        '=================== Spacial Service Client ===============

        LblMedFemale.Text = TotalMedFemale()
        LblMedMale.Text = TotalMedMale()
        LblTotalMedicine.Text = CInt(LblMedFemale.Text) + CInt(LblMedMale.Text)
        '===================== Medicine service client ============

        LblSPFemale.Text = TotalSPFemale()
        LblSPMale.Text = TotalSPMale()
        LblTotalSP.Text = CInt(LblSPFemale.Text) + CInt(LblSPMale.Text)

    End Sub

    Private Function TotalNewMale() As Integer
        Return DACCAMH_RECEIPT.SelectCountGender("M", ReceiptUtilityModule.RECEIPT_NEW, DFrom.Value.Date, DTo.Value.Date)
    End Function
    Private Function TotalNewFemale() As Integer
        Return DACCAMH_RECEIPT.SelectCountGender("F", ReceiptUtilityModule.RECEIPT_NEW, DFrom.Value.Date, DTo.Value.Date)
    End Function

    Private Function TotalFollFemale() As Integer
        Return DACCAMH_RECEIPT.SelectCountGender("F", ReceiptUtilityModule.RECEIPT_FOLLOWUP, DFrom.Value.Date, DTo.Value.Date)
    End Function
    Private Function TotalFollMale() As Integer
        Return DACCAMH_RECEIPT.SelectCountGender("M", ReceiptUtilityModule.RECEIPT_FOLLOWUP, DFrom.Value.Date, DTo.Value.Date)
    End Function


    Private Function TotalMedFemale() As Integer
        Return DACCAMH_RECEIPT.SelectCountGender("F", ReceiptUtilityModule.RECEIPT_MED, DFrom.Value.Date, DTo.Value.Date)
    End Function
    Private Function TotalMedMale() As Integer
        Return DACCAMH_RECEIPT.SelectCountGender("M", ReceiptUtilityModule.RECEIPT_MED, DFrom.Value.Date, DTo.Value.Date)
    End Function
    Private Function TotalSPFemale() As Integer
        Return DACCAMH_RECEIPT.SelectCountGender("F", ReceiptUtilityModule.RECEIPT_SPACIAL, DFrom.Value.Date, DTo.Value.Date)
    End Function
    Private Function TotalSPMale() As Integer
        Return DACCAMH_RECEIPT.SelectCountGender("M", ReceiptUtilityModule.RECEIPT_SPACIAL, DFrom.Value.Date, DTo.Value.Date)
    End Function
    Private Sub DashboardWaitingPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtReceiptNo.Select()
        TxtReceiptNo.Focus()
        TxtReceiptNo.SelectAll()
        RefreshWaitingPayment()
    End Sub

 

   

    Private Sub BgPrintReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgPrintReceipt.DoWork

        TblCCAMHReceipt = DACCAMH_RECEIPT.SelectCashByReceiptNo(EmptyString(GridClientWaitingPayment.GetRow.Cells("RECEIPT_NO").Value))

    End Sub


    Private Sub DoPrintReceipt(ByVal DTable As DataTable)

        Dim FPrintPreview As New PrintPreviewCashReceipt

        If GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_NEW Then
            Dim CRNewReceipt As New CRNewClientReceipt
            FPrintPreview.IS_PRINT_NEWRECEIPT = True
            CRNewReceipt.SetDataSource(TblCCAMHReceipt)
            FPrintPreview.CrystalReportObject = CRNewReceipt


        ElseIf GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_FOLLOWUP Then
            Dim CRFollowUPReceipt As New CRFollowUpClientReceipt
            FPrintPreview.IS_PRINT_OLDRECEIPT = True
            CRFollowUPReceipt.SetDataSource(TblCCAMHReceipt)
            FPrintPreview.CrystalReportObject = CRFollowUPReceipt
        ElseIf GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_MED Then
            Dim CRMedReceipt As New CRMedClientReceipt
            FPrintPreview.IS_PRINT_MED = True
            CRMedReceipt.SetDataSource(TblCCAMHReceipt)
            FPrintPreview.CrystalReportObject = CRMedReceipt

        ElseIf GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_SPACIAL Then
            Dim CRSPReceipt As New CRSpacialClientReceipt
            FPrintPreview.IS_PRINT_SPRECEIPT = True
            CRSPReceipt.SetDataSource(TblCCAMHReceipt)
            FPrintPreview.CrystalReportObject = CRSPReceipt

        ElseIf GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_CONTRIBUTE Then

            Dim CRClientContribute As New CRClientReceiptContribute
            FPrintPreview.IS_PRINT_CONTRIBUTE = True
            CRClientContribute.SetDataSource(TblCCAMHReceipt)
            FPrintPreview.CrystalReportObject = CRClientContribute
        End If

        FPrintPreview.ShowDialog()
        FPrintPreview.Close()

        'End If
    End Sub
    Private Sub BgPrintReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgPrintReceipt.RunWorkerCompleted


        DoPrintReceipt(TblCCAMHReceipt)

        MainKTG.StatusLoading(False, "")
        Application.DoEvents()
        'BgPrintReport.RunWorkerAsync()
    End Sub

    Private Sub BtnMenuPrintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuPrintReceipt.Click
        If GridClientWaitingPayment.SelectedItems.Count = 0 Then Exit Sub
        MainKTG.StatusLoading(True, "Loading")
        Application.DoEvents()
        BgPrintReceipt.RunWorkerAsync()
    End Sub

    Private Sub BtnDeleteReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteReceipt.Click
        If GridClientWaitingPayment.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete receipt?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DACCAMH_RECEIPT.UpdateDeleteOrUndoReceipt(True, GridClientWaitingPayment.GetRow.Cells("RECEIPT_ID").Value) = 1 Then
                RefreshWaitingPayment()
            End If
        End If
    End Sub

    Private Sub BtnUndoReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndoReceipt.Click
        If GridClientWaitingPayment.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to undo receipt?", "Undo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DACCAMH_RECEIPT.UpdateDeleteOrUndoReceipt(False, GridClientWaitingPayment.GetRow.Cells("RECEIPT_ID").Value) = 1 Then
                RefreshWaitingPayment()
            End If
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
        LblTotalServiceNewConsult.Text = DACCAMH_RECEIPT.TotalServiceNew(ReceiptNo)
        LblTotalServiceFollowUp.Text = DACCAMH_RECEIPT.TotalServiceFollowup(ReceiptNo)
        LblTotalServiceContribute.Text = DACCAMH_RECEIPT.TotalServiceContribution(ReceiptNo)
        LblTotalServiceSpacial.Text = DACCAMH_RECEIPT.TotalServiceSpacial(ReceiptNo)
        LblTotalServiceMedicine.Text = DACCAMH_RECEIPT.TotalServiceMedicine(ReceiptNo)
        LblTotalPayment.Text = CDbl(LblTotalServiceNewConsult.Text) + CDbl(LblTotalServiceFollowUp.Text) + CDbl(LblTotalServiceContribute.Text) + CDbl(LblTotalServiceSpacial.Text) + CDbl(LblTotalServiceMedicine.Text)
    End Sub
    Private Sub BtnNewClientReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewClientReceipt.Click
        Dim NewCashReceipt As New NewClientReceipt
        NewCashReceipt.ShowDialog()
        RefreshWaitingPayment()
    End Sub

    Private Sub BtnFollowUpClientReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFollowUpClientReceipt.Click
        Dim FollowupCashReceipt As New FollowUpClientReceiptV1
        FollowupCashReceipt.ShowDialog()
        RefreshWaitingPayment()
    End Sub

    Private Sub BtnMedClientReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMedClientReceipt.Click
        Dim MedClientReceipt As New MedicinceClientReceipt
        MedClientReceipt.ShowDialog()
        RefreshWaitingPayment()
    End Sub

    Private Sub BtnSpacialServiceReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSpacialServiceReceipt.Click
        Dim SpacialService As New SpacialServiceReceipt1
        SpacialService.TxtReceiptNo.Text = GridClientWaitingPayment.GetRow.Cells("RECEIPT_NO").Value
        SpacialService.TxtClientNo.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NO").Value
        SpacialService.TxtClientName.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NAME").Value
        SpacialService.TxtClientSex.Text = GridClientWaitingPayment.GetRow.Cells("CLIEINT_SEX").Value
        SpacialService.TxtClientAge.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_AGE").Value
        SpacialService.FindingClientNo()
        If SpacialService.ShowDialog() = DialogResult.OK Then
            RefreshServiceDetail(SpacialService.TxtReceiptNo.Text)
        End If

    End Sub

    Private Sub BtnInCome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CashCollection As New FormCashCollection(MainFormApplicationPublic)
        CashCollection.ShowDialog()
    End Sub

    Private Sub TxtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtReceiptNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceiptNo.KeyUp
        If TxtReceiptNo.Text = "" Then
            RefreshWaitingPayment()
        Else
            FindReceiptByReceiptNoUseLike(EmptyString(TxtReceiptNo.Text))
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RefreshWaitingPayment()
    End Sub


    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim FFindClientReceipt As New FindClientInWaitingReceipt(Me)
        FFindClientReceipt.TopMost = True
        FFindClientReceipt.Show()
    End Sub

    

    Private Sub GridClientWaitingPayment_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridClientWaitingPayment.RowDoubleClick
        AddServiceMedicine()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If GridClientWaitingPayment.SelectedItems.Count = 0 Then Exit Sub
        BgPrintReceipt.RunWorkerAsync()
    End Sub

    Private Sub BtnClientContribute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientContribute.Click
        Dim FContributtion As New ClientContribution
        FContributtion.TxtReceiptNo.Text = GridClientWaitingPayment.GetRow.Cells("RECEIPT_NO").Value
        FContributtion.TxtClientNo.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NO").Value
        FContributtion.TxtClientName.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NAME").Value
        FContributtion.TxtClientAge.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_AGE").Value
        FContributtion.TxtClientSex.Text = GridClientWaitingPayment.GetRow.Cells("CLIEINT_SEX").Value
        FContributtion.FindingClientNo()
        If FContributtion.ShowDialog() = DialogResult.OK Then
            RefreshServiceDetail(FContributtion.TxtReceiptNo.Text)
        End If



    End Sub

    Private Sub BtnPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FPrescriotion As New FormPrescription
        If FPrescriotion.ShowDialog() = DialogResult.OK Then
            RefreshServiceDetail(FPrescriotion.TxtReceiptNo.Text)
        End If
        'RefreshWaitingPayment()
    End Sub

   

    Private Sub AddServiceMedicine()
        If GridClientWaitingPayment.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select client to add more service!", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim FIssueInvoice As New FormAddMoreSercice
        FIssueInvoice.TxtClientNo.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NO").Value
        FIssueInvoice.TxtClientName.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NAME").Value
        FIssueInvoice.TxtClientNameKH.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NAME_KH").Value
        FIssueInvoice.TxtClientSex.Text = GridClientWaitingPayment.GetRow.Cells("CLIEINT_SEX").Value
        FIssueInvoice.TxtClientAge.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_AGE").Value
        FIssueInvoice.TxtReceiptNo.Text = GridClientWaitingPayment.GetRow.Cells("RECEIPT_NO").Value
        FIssueInvoice.TxtExchangeRate.Text = GridClientWaitingPayment.GetRow.Cells("EXCHANGE_RATE").Value
        FIssueInvoice.DateReceipt.Value = GridClientWaitingPayment.GetRow.Cells("DATE_RECEIPT").Value
        FIssueInvoice.LblTotalServiceNewConsult.Text = FormatNumber(Me.LblTotalServiceNewConsult.Text)
        FIssueInvoice.LblTotalServiceFollowUp.Text = FormatNumber(Me.LblTotalServiceFollowUp.Text)

        FIssueInvoice.FindingClientNo()
        FIssueInvoice.CalculatePaymentSumarry()
        FIssueInvoice.ShowDialog()
        RefreshServiceDetail(FIssueInvoice.TxtReceiptNo.Text)
        RefreshWaitingPayment()

    End Sub

    Private Sub AddMedicineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddServiceMedicine()
    End Sub

    Private Sub AddSpacialServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SpacialService As New SpacialServiceReceipt1
        SpacialService.TxtReceiptNo.Text = GridClientWaitingPayment.GetRow.Cells("RECEIPT_NO").Value
        SpacialService.TxtClientNo.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NO").Value
        SpacialService.TxtClientName.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NAME").Value
        SpacialService.TxtClientSex.Text = GridClientWaitingPayment.GetRow.Cells("CLIEINT_SEX").Value
        SpacialService.TxtClientAge.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_AGE").Value
        SpacialService.FindingClientNo()
        If SpacialService.ShowDialog() = DialogResult.OK Then
            RefreshServiceDetail(SpacialService.TxtReceiptNo.Text)
        End If
    End Sub

    Private Sub AddContributeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FContributtion As New ClientContribution
        FContributtion.TxtReceiptNo.Text = GridClientWaitingPayment.GetRow.Cells("RECEIPT_NO").Value
        FContributtion.TxtClientNo.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NO").Value
        FContributtion.TxtClientName.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_NAME").Value
        FContributtion.TxtClientAge.Text = GridClientWaitingPayment.GetRow.Cells("CLIENT_AGE").Value
        FContributtion.TxtClientSex.Text = GridClientWaitingPayment.GetRow.Cells("CLIEINT_SEX").Value
        FContributtion.FindingClientNo()
        If FContributtion.ShowDialog() = DialogResult.OK Then
            RefreshServiceDetail(FContributtion.TxtReceiptNo.Text)
        End If
    End Sub

    Private Sub BtnAddMoreService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMoreService.Click
        AddServiceMedicine()
    End Sub

    Private Sub BtnViewDeleteReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewDeleteReceipt.Click
        GridClientWaitingPayment.DataSource = DACCAMH_RECEIPT.SelectClientWaitingPayment(False, True)
    End Sub

    Private Sub PrintReceiptTamplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReceiptTamplate.Click
        Dim FPrintPreview As New PrintPreviewCashReceipt
        Dim CrvReceipTemplate As New CRNewClientReceiptTemplate
        FPrintPreview.IS_PRINT_NEWRECEIPT = True
        FPrintPreview.CrystalReportObject = CrvReceipTemplate
        'If GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_NEW Then
        '    Dim CRNewReceipt As New CRNewClientReceipt
        '    FPrintPreview.IS_PRINT_NEWRECEIPT = True
        '    CRNewReceipt.SetDataSource(TblCCAMHReceipt)
        '    FPrintPreview.CrystalReportObject = CRNewReceipt


        'ElseIf GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_FOLLOWUP Then
        '    Dim CRFollowUPReceipt As New CRFollowUpClientReceipt
        '    FPrintPreview.IS_PRINT_OLDRECEIPT = True
        '    CRFollowUPReceipt.SetDataSource(TblCCAMHReceipt)
        '    FPrintPreview.CrystalReportObject = CRFollowUPReceipt
        'ElseIf GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_MED Then
        '    Dim CRMedReceipt As New CRMedClientReceipt
        '    FPrintPreview.IS_PRINT_MED = True
        '    CRMedReceipt.SetDataSource(TblCCAMHReceipt)
        '    FPrintPreview.CrystalReportObject = CRMedReceipt

        'ElseIf GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_SPACIAL Then
        '    Dim CRSPReceipt As New CRSpacialClientReceipt
        '    FPrintPreview.IS_PRINT_SPRECEIPT = True
        '    CRSPReceipt.SetDataSource(TblCCAMHReceipt)
        '    FPrintPreview.CrystalReportObject = CRSPReceipt

        'ElseIf GridClientWaitingPayment.GetRow.Cells("RECEIPT_TYPE").Value = ReceiptUtilityModule.RECEIPT_CONTRIBUTE Then

        '    Dim CRClientContribute As New CRClientReceiptContribute
        '    FPrintPreview.IS_PRINT_CONTRIBUTE = True
        '    CRClientContribute.SetDataSource(TblCCAMHReceipt)
        '    FPrintPreview.CrystalReportObject = CRClientContribute
        'End If

        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
    End Sub

 
    Private Sub BtnAddMoreReceipt_Click(sender As Object, e As EventArgs) Handles BtnAddMoreReceipt.Click
        Dim FMoreREeceipt As New MoreReceipt
        If FMoreREeceipt.ShowDialog = DialogResult.OK Then
            RefreshWaitingPayment()
        End If
    End Sub
End Class
