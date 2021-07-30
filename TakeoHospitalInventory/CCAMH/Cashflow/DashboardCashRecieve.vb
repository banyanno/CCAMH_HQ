Public Class DashboardCashRecieve
    Dim DACashCollection As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Private Sub BtnCashReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCashReceipt.Click
        Dim NewCashReceipt As New NewClientReceipt
        NewCashReceipt.ShowDialog()
    End Sub

    Private Sub BtnFollowUpReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFollowUpReceipt.Click
        Dim FollowupCashReceipt As New FollowUpClientReceiptV1
        FollowupCashReceipt.ShowDialog()
    End Sub

    Private Sub BtnMedicineReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMedicineReceipt.Click
        Dim MedClientReceipt As New MedicinceClientReceipt
        MedClientReceipt.ShowDialog()
    End Sub

    Private Sub BtnSpacialService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSpacialService.Click
        Dim SpacialSv As New SpacialServiceReceipt1
        SpacialSv.ShowDialog()
    End Sub

    Private Sub DashboardCashRecieve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblDateServer.Text = Format(GetDateServer.Date, "dd-MM-yyyy")
    End Sub
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        LoadingTotalClient()
    End Sub
    Private Function TotalNewMale() As Integer
        'Return DACashCollection.SelectCountGender("M", ReceiptUtilityModule.RECEIPT_NEW, GetDateServer.Date)
    End Function
    Private Function TotalNewFemale() As Integer
        'Return DACashCollection.SelectCountGender("F", ReceiptUtilityModule.RECEIPT_NEW, GetDateServer.Date)
    End Function

    Private Function TotalFollFemale() As Integer
        'Return DACashCollection.SelectCountGender("F", ReceiptUtilityModule.RECEIPT_FOLLOWUP, GetDateServer.Date)
    End Function
    Private Function TotalFollMale() As Integer
        'Return DACashCollection.SelectCountGender("M", ReceiptUtilityModule.RECEIPT_FOLLOWUP, GetDateServer.Date)
    End Function


    Private Function TotalMedFemale() As Integer
        'Return DACashCollection.SelectCountGender("F", ReceiptUtilityModule.RECEIPT_MED, GetDateServer.Date)
    End Function
    Private Function TotalMedMale() As Integer
        'Return DACashCollection.SelectCountGender("M", ReceiptUtilityModule.RECEIPT_MED, GetDateServer.Date)
    End Function
    Private Function TotalSPFemale() As Integer
        'Return DACashCollection.SelectCountGender("F", ReceiptUtilityModule.RECEIPT_SPACIAL, GetDateServer.Date)
    End Function
    Private Function TotalSPMale() As Integer
        'Return DACashCollection.SelectCountGender("M", ReceiptUtilityModule.RECEIPT_SPACIAL, GetDateServer.Date)
    End Function
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

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FShowAll As New FrmIssueReceipt
        FShowAll.ShowDialog()
    End Sub
End Class
