Imports Janus.Windows.GridEX

Public Class FormAddMoreSercice

    Dim DA_Usage As New DSIssueInvoiceTableAdapters.CCAMH_MEDIC_USAGETableAdapter
    Dim DA_ItemInPharmacy As New DSSocialEconomicSettingTableAdapters.VItemPriceOpticalShopTableAdapter

    Dim DA_Doctor As New DSPrescriptionTableAdapters.TblDoctorTableAdapter
    Public DA_Prescipt As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTIONTableAdapter
    Dim DA_Prescipt_Detial As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTION_DETIALTableAdapter
    Public TblPresciptionTem As DataTable = New DSPrescription.CCAMH_PRESCRIPTION_DETIALDataTable
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter

    Dim DAClient As New DSCashCollectionTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim DA_Med_ReceiptDetail As New DSMedicinceReceiptTableAdapters.CCAMH_RECEPT_MED_SOCIAL_DETAILTableAdapter

    Dim TblPrescriptionReport As DataTable
    ' Dim DA_PrescriptionReport As New DSPrescriptionTableAdapters.CCAMH_VIEW_PRESCRIPTIONTableAdapter
    Public PrescriptonID As Double
    Public DA_RECEIPT As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim DA_Assessment As New DS_ClientImpressionTableAdapters.CLIENT_CA_SOCIALTableAdapter 'DS_CCAMHClient_ImpressionsTableAdapters.CLIENT_CA_SOCIALTableAdapter


    '===========================================================================
    Dim TblSpacialServiceTem As DataTable = New DSCashCollection.CCAMH_RECEPT_SPACIAL_SOCIAL_DETAILDataTable
    Dim DA_Spacial_ReceiptDetail As New DSCashCollectionTableAdapters.CCAMH_RECEPT_SPACIAL_SOCIAL_DETAILTableAdapter
    Dim DASkill As New DSSocialEconomicSettingTableAdapters.CCAMH_SKILLTableAdapter
    Dim DASpacialService As New DSSocialEconomicSettingTableAdapters.CCAMH_SPACIAL_SERVICE_PACKAGETableAdapter
    Dim TblIssueReceipt As DataTable

    Dim DA_Therapist As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_NextApp As New DSAssessmentTableAdapters.CCAMH_CLIENT_APPOINTSTableAdapter
    Dim DA_Presciption As New DSPrescriptionTableAdapters.CCAMH_VIEW_PRESCRIPTIONTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboTherapistOrDoctor
            .DataSource = DA_Therapist.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
        With CboMainTherapy
            .DataSource = DA_Therapist.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
        With CboSkill
            .DataSource = DASkill.GetData
            .ValueMember = "SKILL_ID"
            .DisplayMember = "SKILL_NAME"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.
        InitParaUsage()
        InitParaMedicine()
        ' Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
    End Sub
    Private Sub InitParaMedicine()
        With CboItem
            .DataSource = DA_ItemInPharmacy.SelectListItemFromPharmacy(26)
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub InitParaUsage()
        With CboUsageM
            .DataSource = DA_Usage.GetData
            .ValueMember = "USAGE_ID"
            .DisplayMember = "USAGE"
            .SelectedIndex = -1

        End With
        With CboUsageN
            .DataSource = DA_Usage.GetData
            .ValueMember = "USAGE_ID"
            .DisplayMember = "USAGE"
            .SelectedIndex = -1
        End With
        With CboUsageE
            .DataSource = DA_Usage.GetData
            .ValueMember = "USAGE_ID"
            .DisplayMember = "USAGE"
            .SelectedIndex = -1
        End With
    End Sub


    Private Function FractionToDecimal(ByVal frac As String) As String
        'Code from http://amrelgarhytech.blogspot.com/2008/03/fraction-to-decimal.html ,,Fixed error to get to work.
        Dim decimalVal As String = "0"
        Dim upper As Decimal = 0
        Dim lower As Decimal = 0
        Dim remain As Decimal = 0
        Try
            If frac.IndexOf("/") <> -1 Then

                If frac.IndexOf(" ") <> -1 Then
                    remain = CType(frac.Substring(0, frac.IndexOf(" ")), Decimal)
                    frac = frac.Substring(frac.IndexOf(" "))
                End If

            End If
            upper = CType(frac.Substring(0, frac.IndexOf("/")), Decimal)
            lower = CType(frac.Substring(frac.IndexOf("/") + 1), Decimal)
            If upper > lower Then
                Return "Error Please Check Fraction"
            Else
                decimalVal = (remain + (upper / lower)).ToString
            End If

            Return decimalVal

        Catch ex As Exception
            Return CInt(frac)
        End Try

    End Function
    Private Sub CalDayAndTotalUsed()
        Try
            'If ValidateDateTimePicker(DatePrescription, "", ErrAddService) = False Then Exit Sub
            'If ValidateDateTimePicker(DateNextVisit, "", ErrAddService) = False Then Exit Sub
            If ValidateTextField(TxtTotalDayUsed, "", ErrAddService) = False Then Exit Sub
            Dim DateNextVisit As DateTime = DateNextVisit1.Value
            Dim DatePrescript As DateTime = DatePrescription.Value
            Dim TotalDay As Double = DateNextVisit.Subtract(DatePrescript).TotalDays
            If TotalDay < 0 Then
                TxtTotalDay.Text = 0
                TxtTotalDayUsed.Text = 0
            Else
                TxtTotalDay.Text = TotalDay
                ' TxtTotalDayUsed.Text = TotalDay
            End If

            'If TotalDay <= 0 Then
            '    'MessageBox.Show("Total day can not =0 or smaller than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            If ValidateCombobox(CboUsageM, "", ErrAddService) = False Then Exit Sub
            If ValidateCombobox(CboUsageN, "", ErrAddService) = False Then Exit Sub
            If ValidateCombobox(CboUsageE, "", ErrAddService) = False Then Exit Sub

            Dim TotalPrescrip As Double = (CDbl(EmptyString(CboUsageM.Text)) + CDbl(EmptyString(CboUsageN.Text)) + CDbl(EmptyString(CboUsageE.Text)))
            '  MessageBox.Show((CDbl(TotalPrescrip * CDbl(EmptyString(TxtTotalDayUsed.Text)))))
            TxtTotalQTY.Text = Math.Ceiling((CDbl(TotalPrescrip * CDbl(EmptyString(TxtTotalDayUsed.Text))))) 'RoundToLeftValueForKHR((CDbl(TotalPrescrip * CDbl(EmptyString(TxtTotalDayUsed.Text)))), 2)
            ' Dim a As Double = Math.Ceiling((CDbl(TotalPrescrip * CDbl(EmptyString(TxtTotalDayUsed.Text))))) ', 2, MidpointRounding.AwayFromZero)
            ' MessageBox.Show(a)
            'RoundToLeft((FractionToDecimal(EmptyString(CboUsageM.Text)) * CDec(LblTotalDay.Text)) + (FractionToDecimal(EmptyString(CboUsageN.Text)) * CDec(LblTotalDay.Text)) + (FractionToDecimal(EmptyString(CboUsageE.Text)) * CDec(LblTotalDay.Text)), 0)
        Catch ex As Exception
            TxtTotalDay.Text = "0"
            ' MessageBox.Show(ex.Message)
            TxtTotalQTY.Text = "0"
        End Try

    End Sub
    Private Sub BtnAddUsage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddUsage.Click
        Dim FAddUsage As New FormAddUsage
        If FAddUsage.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            InitParaUsage()
        End If
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click
        If GridPrescription.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove item prescription?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            RemoveItemTem(GridPrescription.Row)
        End If
        TotalReceiptMedicine()
        CalculatePaymentSumarry()
    End Sub
    Private Sub RemoveItemTem(ByVal index As Integer)
        TblPresciptionTem.BeginLoadData()
        TblPresciptionTem.Rows.RemoveAt(index)
        TblPresciptionTem.EndLoadData()
        RefreshAddTem()
        CalculatePaymentSumarry()
    End Sub
    Private Sub DtPrescription_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatePrescription.ValueChanged
        CalDayAndTotalUsed()
    End Sub

    Private Sub DtNextVisit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateNextVisit1.ValueChanged
        CalDayAndTotalUsed()
        TxtTotalDayUsed.Text = TxtTotalDay.Text
    End Sub

    Private Sub CboItem_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboItem.SelectedValueChanged
        Try
            LoadSocialServiceMedicince(CboItem.SelectedValue.ToString)
        Catch ex As Exception
            LblCategoryId.Text = ""
            LblCatName.Text = ""
            TxtCorrentQTY.Text = ""
            TxtItemPrice.Text = ""
            LblSocialTypePrice.Text = ""
        End Try
    End Sub

    Private Sub LoadServicePackage(ByVal SkillID As Integer)
        With CboPackage
            .DataSource = DASpacialService.SelectSpacialBySkillID(SkillID)
            .ValueMember = "SKILL_SERVICE_ID"
            .DisplayMember = "PACKAGE_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub LoadSocialServiceMedicince(ByVal ItemId As Integer)
        Try
            Dim QTY_ItemPending As Integer = 0
            ' Get information from pending medicine in prescription........
            For Each rows In DA_Presciption.SelectPendingQTYItem(ItemId, False).Rows
                QTY_ItemPending = QTY_ItemPending + CInt(rows("MED_QTY"))
            Next

            'MessageBox.Show(QTY_ItemPending)
            Dim TblItem As DataTable = DA_ItemInPharmacy.SelectItemPriceByDepartment(ItemId, 26) 'SelelectItemByItemID(ItemId)
            For Each drows As DataRow In TblItem.Rows
                LblCategoryId.Text = drows("ItemID")
                LblCatName.Text = drows("CateName")
                TxtCorrentQTY.Text = CInt(drows("UnitsInStock")) - QTY_ItemPending
                If RadServiceA.Checked = True Then
                    TxtItemPrice.Text = drows("PriceA")
                    LblSocialTypePrice.Text = "A"
                ElseIf RadServiceB.Checked = True Then
                    TxtItemPrice.Text = drows("PriceB")
                    LblSocialTypePrice.Text = "B"
                ElseIf RadServiceC.Checked = True Then
                    TxtItemPrice.Text = drows("PriceC")
                    LblSocialTypePrice.Text = "C"
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click
        If ValidateDateTimePicker(DatePrescription, "", ErrAddService) = False Then Exit Sub
        If RadMedicineIncenter.Checked = True Then
            If ValidateCombobox(CboItem, "", ErrAddService) = False Then Exit Sub
            If CboItem.SelectedValue Is Nothing Then
                CboItem.Focus()
                CboItem.Select()
                Exit Sub
            End If
            If CInt(EmptyString(TxtCorrentQTY.Text)) <= 0 Then
                MessageBox.Show("Out of stock. Please check item in stock pharmacy!", "Error", MessageBoxButtons.OK)
                TxtCorrentQTY.Focus()
                TxtCorrentQTY.Select()
                TxtCorrentQTY.SelectAll()
                Exit Sub
            End If
        End If

        ' If ValidateDateTimePicker(DateNextVisit1, "", ErrAddService) = False Then Exit Sub



        If CInt(EmptyString(TxtTotalDayUsed.Text)) <= 0 Then
            MessageBox.Show("Please check total days used!", "Error", MessageBoxButtons.OK)
            TxtTotalDayUsed.Focus()
            TxtTotalDayUsed.Select()
            TxtTotalDayUsed.SelectAll()
            Exit Sub
        End If
        If RadMedicineIncenter.Checked = True Then
            If ValidateCombobox(CboItem, "", ErrAddService) = False Then Exit Sub
            If CboItem.SelectedValue Is Nothing Then Exit Sub
            If CheckExistingItem(CboItem.Text) = True Then
                If MessageBox.Show("Medicine already in list. Do you want to add?", "Medicine", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = System.Windows.Forms.DialogResult.Yes Then
                Else
                    Exit Sub
                End If
            End If
        End If
        If RadMedicineOutcenter.Checked = True Then
            If ValidateTextField(TxtMedicineOut, "", ErrAddService) = False Then Exit Sub
            If CheckExistingItem(TxtMedicineOut.Text) = True Then
                If MessageBox.Show("Medicine already in list. Do you want to add?", "Medicine", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = System.Windows.Forms.DialogResult.Yes Then
                Else
                    Exit Sub
                End If
            End If
        End If

        If ValidateCombobox(CboUsageM, "", ErrAddService) = False Then Exit Sub
        If ValidateCombobox(CboUsageN, "", ErrAddService) = False Then Exit Sub
        If ValidateCombobox(CboUsageE, "", ErrAddService) = False Then Exit Sub
        If ValidateTextField(TxtTotalQTY, "", ErrAddService) = False Then Exit Sub
        'CalDayAndTotalUsed()
        If RadMedicineIncenter.Checked = True Then
            If CInt(EmptyString(TxtTotalQTY.Text)) > CInt(EmptyString(TxtCorrentQTY.Text)) Then
                MessageBox.Show("You can not enter QTY biger then corrent stock. Please check with pharmachy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        '=========================================================

        Dim SubTotal As Double = 0
        If RadMedicineIncenter.Checked = True Then
            SubTotal = RoundToLeftValueForKHR(EmptyString(TxtItemPrice.Text) * EmptyString(EmptyString(TxtTotalQTY.Text)), 2)
        Else
            SubTotal = 0
        End If

        AddItemTem(CDbl(IIf(RadMedicineIncenter.Checked = True, CboItem.SelectedValue, 999)), CStr(IIf(RadMedicineIncenter.Checked = True, CboItem.Text, TxtMedicineOut.Text)), CboUsageM.Text, CboUsageN.Text, CboUsageE.Text, EmptyString(TxtTotalQTY.Text), EmptyString(TxtItemPrice.Text), SubTotal, CStr(IIf(RadMedicineIncenter.Checked = True, "IN", "OUT")))
        CalculatePaymentSumarry()
    End Sub

    Function CheckExistingItem(ByVal Item As String) As Boolean
        For Each row As Janus.Windows.GridEX.GridEXRow In GridPrescription.GetRows
            'If row.Cells("MED_ID").Value = ItemId Then
            '    Return True
            '    Exit Function
            '    'Else
            '    '    Return False
            'End If
            If row.Cells("MED_NAME").Value.ToString.Trim = Item.Trim Then
                Return True
                Exit Function
            End If
        Next
    End Function
    Private Sub AddItemTem(ByVal MED_ID As Integer, ByVal MED_NAME As String, ByVal MED_M As String, ByVal MED_N As String, ByVal MED_E As String, ByVal MED_QTY As Integer, ByVal MED_PRICE As Double, ByVal SubTotal As Double, ByVal REMARK As String)
        Dim Drow As DataRow = TblPresciptionTem.NewRow
        Drow("MED_ID") = MED_ID
        Drow("MED_NAME") = MED_NAME
        Drow("MED_M") = MED_M
        Drow("MED_N") = MED_N
        Drow("MED_E") = MED_E
        Drow("MED_QTY") = MED_QTY
        Drow("MED_PRICE") = MED_PRICE
        Drow("MED_SUB_TOTAL") = SubTotal
        Drow("REMARK") = REMARK
        TblPresciptionTem.Rows.Add(Drow)
        RefreshAddTem()
        TotalReceiptMedicine()
        CleanForm()

    End Sub
    Private Sub TotalReceiptMedicine()
        Dim TotalAmount As Double = 0
        For Each GRow As GridEXRow In Me.GridPrescription.GetRows
            If GRow.Cells("REMARK").Value <> "OUT" Then
                TotalAmount = TotalAmount + CDbl(IIf(RadServiceC.Checked = True, 0, CDbl(GRow.Cells("MED_SUB_TOTAL").Value)))
            End If

        Next
        LblTotalServiceMedicine.Text = FormatNumber(RoundToLeftValueForKHR(TotalAmount, 2)) 'FormatNumber(NearestHundred(TotalAmount))

    End Sub
    Private Sub RefreshAddTem()
        'Try
        GridPrescription.Refresh()

        GridPrescription.DataSource = TblPresciptionTem

        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub CleanForm()
        'DtPrescription.Checked = False
        'DtNextVisit.Checked = False
        'LblTotalDay.Text = "0"
        CboItem.SelectedIndex = -1
        CboUsageM.SelectedIndex = -1
        CboUsageN.SelectedIndex = -1
        CboUsageE.SelectedIndex = -1
        TxtTotalDayUsed.Text = EmptyString(TxtTotalDay.Text)
        TxtTotalQTY.Text = "0"
        TxtCorrentQTY.Text = "0"
        CboItem.Focus()
        CboItem.Select()
        CboItem.SelectAll()
    End Sub

    Private Sub CboUsageM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboUsageM.SelectedValueChanged
        CalDayAndTotalUsed()
    End Sub

    Private Sub CboUsageN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboUsageN.SelectedIndexChanged
        CalDayAndTotalUsed()
    End Sub

    Private Sub CboUsageE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboUsageE.SelectedIndexChanged
        CalDayAndTotalUsed()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub SetFreeService()
        If ChFreeNewClient.Checked = True Then
            DA_RECEIPT.UpdateFreeNewClient(0, 0, 0, 0, TxtReceiptNo.Text)
        End If
        If ChFreeFollowup.Checked = True Then
            DA_RECEIPT.UpdateFreeOldClient(0, 0, 0, 0, TxtReceiptNo.Text)
        End If
        If ChFreeMedicine.Checked = True Then
            DA_RECEIPT.UpdateFreeMed(0, 0, 0, TxtReceiptNo.Text)
        End If
        If ChFreeSpacialService.Checked = True Then
            DA_RECEIPT.UpdateFreeSP(0, 0, 0, 0, TxtReceiptNo.Text)
        End If

    End Sub
    Private Function GetListPrecription() As String
        Dim ValMedicine As String = ""
        For i As Integer = 0 To GridPrescription.RowCount - 1
            ValMedicine = ValMedicine & " " & GridPrescription.GetRow(i).Cells("MED_NAME").Value
        Next
        Return ValMedicine
    End Function
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrAddService) = False Then Exit Sub
        If ValidateTextField(TxtClientName, "", ErrAddService) = False Then Exit Sub
        If ValidateTextField(TxtClientSex, "", ErrAddService) = False Then Exit Sub
        If ValidateTextField(TxtClientAge, "", ErrAddService) = False Then Exit Sub
        If DateAppointment.Checked = True Then
            If ValidateCombobox(CboMainTherapy, "", ErrAddService) = False Then Exit Sub

        End If
        If chIsFreeReceipt.Checked = False Then
            If CDbl(LblTotalReceiveUSDKHR.Text) < CDbl(LblTotalServicePayment.Text) Then
                MessageBox.Show("You can not receive small ammount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtReceivedKHR.Focus()
                TxtReceivedKHR.Select()
                TxtReceivedKHR.SelectAll()
                Exit Sub
            End If
        End If


        If MessageBox.Show("Do you issue this receipt?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            '====================== Start save  Prescription =============
            'If GridPrescription.SelectedItems.Count > 0 Then


            If DA_Prescipt.CheckExsitingPrescription(TxtReceiptNo.Text) > 0 Then
                DA_Prescipt.DeletePrescriptByReceiptNo(TxtReceiptNo.Text)
                DA_Prescipt_Detial.DeletePrescriptByReceiptNo(TxtReceiptNo.Text)
            End If
            ' Incase have medicine ...........................
            If GridPrescription.SelectedItems.Count > 0 Then
                If DA_Prescipt.InsertNewPrescription(TxtClientNo.Text, TxtClientName.Text, TxtClientAge.Text, TxtClientSex.Text, "", CboTherapistOrDoctor.Text, DatePrescription.Value.Date, IIf(DateNextVisit1.Checked = False, Nothing, DateNextVisit1.Value.Date), False, "", TxtReceiptNo.Text) = 1 Then

                    '==================
                    DA_RECEIPT.UpdateIsMedicineReceipt(CDbl(TxtReceiptNo.Text))
                    PrescriptonID = CDbl(DA_Prescipt.GetLastInsert)
                    For Each GRow As GridEXRow In GridPrescription.GetRows
                        DA_Prescipt_Detial.InsertPresDetial(PrescriptonID, GRow.Cells("MED_ID").Value, _
                                                             GRow.Cells("MED_NAME").Value, GRow.Cells("MED_M").Value, _
                                                             GRow.Cells("MED_N").Value, GRow.Cells("MED_E").Value, _
                                                             GRow.Cells("MED_QTY").Value, GRow.Cells("MED_PRICE").Value, GRow.Cells("MED_SUB_TOTAL").Value, GRow.Cells("REMARK").Value, TxtReceiptNo.Text)

                    Next
                    UpdateMedicineReceipt(TxtReceiptNo.Text)
                End If
            End If

            'End If


            '========================== Sart save spacial service ===============
            'If GridSpacialService.SelectedItems.Count > 0 Then
            SaveSpacialReceipt()
            DA_Spacial_ReceiptDetail.DeleteReceiptDetailByID(TxtReceiptNo.Text)
            InsertReceiptSpacialDetail()
            'End If


            '========================= sart save contribution receipt =============
            DAClientReceipt.AddContributionUpdate(EmptyString(TxtReceiptContributeAmmount.Text), TxtReceiptNo.Text)

            '======================== start save mascllauus =======================
            DAClientReceipt.AddMiscellaneousUpdate(EmptyString(TxtMiscellaneous.Text), TxtReceiptNo.Text)

            DAClientReceipt.UpdateRecievedBy(USER_NAME, TxtReceiptNo.Text)

            '======================= Next Appointment ====================
            If DateAppointment.Checked = True Then
                DA_NextApp.InsertNewAppointment(TxtClientNo.Text, CboMainTherapy.SelectedValue, CboMainTherapy.Text, DateAppointment.Value.Date, Nothing, "", "", "", False, GetListPrecription)
            End If


            '======================= Update payment ======================
            InitUpdatePayment()

            LblPrinting.Visible = True
            PicLoading.Visible = True

            Application.DoEvents()

            BGSaveAndPrintReceipt.RunWorkerAsync()

        End If

    End Sub
    Private Sub InsertReceiptSpacialDetail()
        For Each GRow As GridEXRow In GridSpacialService.GetRows
            DA_Spacial_ReceiptDetail.InsertReceiptSpacialReceipt(TxtReceiptNo.Text, GRow.Cells("SKILL_ID").Value, GRow.Cells("SKILL_NAME").Value, GRow.Cells("PACKAGE_ID").Value, GRow.Cells("PACKAGE_NAME").Value, GRow.Cells("PACKAGE_PRICE").Value, GRow.Cells("PACKAGE_TYPE").Value)
        Next
    End Sub
    Private Function SaveSpacialReceipt() As Integer

        Return DAClientReceipt.AddSpacialServiceUpdate(ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(LblTotalServiceSpacial.Text), RadServiceA.Checked), _
                                                        ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(LblTotalServiceSpacial.Text), RadServiceB.Checked), _
                                                        ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(LblTotalServiceSpacial.Text), RadServiceC.Checked), TxtReceiptNo.Text)

    End Function
    '============================== Process save receipt medicine ====================
    Private Function UpdateMedicineReceipt(ByVal ReceiptNO As Double) As Integer
        Return DAClientReceipt.UpdateReceiptByPrescriptID(ReceiptUtilityModule.RECEIPT_MED, ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(LblTotalServiceMedicine.Text), RadServiceA.Checked), _
                                                          ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(LblTotalServiceMedicine.Text), RadServiceB.Checked), _
                                                          CDbl(IIf(RadServiceC.Checked = True, GetTotalMedicineC, 0)), False, _
                                                          EmptyString(LblTotalServiceMedicine.Text), (EmptyString(LblTotalServiceMedicine.Text) / ReceiptUtilityModule.GetExchangeRate), _
                                                "", "", ReceiptNO)
        'Return DAClientReceipt.UpdateReceiptByPrescriptID(ReceiptUtilityModule.RECEIPT_MED, ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(LblTotalServiceMedicine.Text), RadServiceA.Checked), _
        '                                                ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(LblTotalServiceMedicine.Text), RadServiceB.Checked), _
        '                                                 ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(LblTotalServiceMedicine.Text), RadServiceC.Checked), False, _
        '                                                EmptyString(LblTotalServiceMedicine.Text), (EmptyString(LblTotalServiceMedicine.Text) / ReceiptUtilityModule.GetExchangeRate), _
        '                                      "", "", ReceiptNO)
    End Function
    Function GetTotalMedicineC() As Double
        Dim TotalAmount As Double = 0
        For Each GRow As GridEXRow In Me.GridPrescription.GetRows
            If GRow.Cells("REMARK").Value <> "OUT" Then
                TotalAmount = TotalAmount + CDbl(GRow.Cells("MED_SUB_TOTAL").Value)
            End If
        Next
        Return TotalAmount
    End Function
    Private Sub InitUpdatePayment()
        ' Update New payment --------------------------------------------
        DA_RECEIPT.UpdatePaymentNew(USER_NAME, True, EmptyString(TxtReceivedKHR.Text), EmptyString(TxtReceivedUSD.Text), EmptyString(TxtReturnKHR.Text), EmptyString(TxtReturnUSD.Text), EmptyString(LblTotalServiceNewConsult.Text), EmptyString(TxtReceivedUSD.Text), chIsFreeReceipt.Checked, CDbl(LblTotalServicePayment.Text), TxtAmountInWordReceive.Text, (CDbl(LblTotalServicePayment.Text) / CDbl(TxtExchangeRate.Text)), ChFreeNewClient.Checked, CDbl(TxtReceiptNo.Text))
        ' Update followup payment --------------------------------------------
        DA_RECEIPT.UpdatePaymentOld(USER_NAME, True, EmptyString(TxtReceivedKHR.Text), EmptyString(TxtReceivedUSD.Text), EmptyString(TxtReturnKHR.Text), EmptyString(TxtReturnUSD.Text), EmptyString(LblTotalServiceFollowUp.Text), EmptyString(TxtReceivedUSD.Text), chIsFreeReceipt.Checked, CDbl(LblTotalServicePayment.Text), (CDbl(LblTotalServicePayment.Text) / CDbl(TxtExchangeRate.Text)), ChFreeFollowup.Checked, CDbl(TxtReceiptNo.Text))

        DA_RECEIPT.UpdatePaymentSpacial(USER_NAME, True, EmptyString(TxtReceivedKHR.Text), EmptyString(TxtReceivedUSD.Text), EmptyString(TxtReturnKHR.Text), EmptyString(TxtReturnUSD.Text), EmptyString(LblTotalServiceSpacial.Text), EmptyString(TxtReceivedUSD.Text), chIsFreeReceipt.Checked, CDbl(LblTotalServicePayment.Text), (CDbl(LblTotalServicePayment.Text) / CDbl(TxtExchangeRate.Text)), ChFreeSpacialService.Checked, CDbl(TxtReceiptNo.Text))
        DA_RECEIPT.UpdatePaymentMedicince(USER_NAME, True, EmptyString(TxtReceivedKHR.Text), EmptyString(TxtReceivedUSD.Text), EmptyString(TxtReturnKHR.Text), EmptyString(TxtReturnUSD.Text), EmptyString(LblTotalServiceMedicine.Text), EmptyString(TxtReceivedUSD.Text), chIsFreeReceipt.Checked, CDbl(LblTotalServicePayment.Text), (CDbl(LblTotalServicePayment.Text) / CDbl(TxtExchangeRate.Text)), ChFreeMedicine.Checked, CDbl(TxtReceiptNo.Text))
        DA_RECEIPT.UpdatePayContribution(USER_NAME, True, EmptyString(TxtReceivedKHR.Text), EmptyString(TxtReceivedUSD.Text), EmptyString(TxtReturnKHR.Text), EmptyString(TxtReturnUSD.Text), EmptyString(LblTotalServiceContribute.Text), CDbl(LblTotalServicePayment.Text), (CDbl(LblTotalServicePayment.Text) / CDbl(TxtExchangeRate.Text)), CDbl(TxtReceiptNo.Text))
        SetFreeService()

    End Sub

    '============================== Process save receipt medicine ====================
    'Private Function SaveMedicineReceipt(ByVal PrescriptionID As Double) As Integer
    '    Return DAClientReceipt.InsertMedReceiptService(EmptyString(TxtReceiptNo.Text), ReceiptUtilityModule.RECEIPT_MED, _
    '                                                   ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), _
    '                                                RadServiceA.Checked), ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), _
    '                                                RadServiceB.Checked), ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), _
    '                                                RadServiceC.Checked), False, DtPrescription.Value.Year, Now, DtNextVisit.Value.Date, _
    '                                                EmptyString(TxtReceiptAmmount.Text), (EmptyString(TxtReceiptAmmount.Text) / ReceiptUtilityModule.GetExchangeRate), _
    '                                                ReceiptUtilityModule.GetExchangeRate, USER_NAME, TxtAmmountInword.Text, TxtClientNo.Text, TxtClientName.Text, TxtClientSex.Text, _
    '                                                TxtClientAge.Text, "", "", ReceiptUtilityModule.GetSocialServieType(RadServiceA.Checked, RadServiceB.Checked, RadServiceC.Checked), PrescriptionID)
    'End Function
    'Private Sub InsertReceiptMedDetail()
    '    For Each GRow As GridEXRow In GridPrescription.GetRows
    '        DA_Med_ReceiptDetail.InsertMedicineDetail(TxtReceiptNo.Text, 0, "", GRow.Cells("MED_ID").Value, GRow.Cells("MED_NAME").Value, GRow.Cells("MED_QTY").Value, GRow.Cells("MED_PRICE").Value, "", GRow.Cells("MED_SUB_TOTAL").Value, GRow.Cells("MED_M").Value, GRow.Cells("MED_N").Value, GRow.Cells("MED_E").Value, GRow.Cells("REMARK").Value)
    '    Next
    'End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindingClientNo()
    End Sub
    Public Sub FindingClientNo()
        If ValidateTextField(TxtClientNo, "", ErrAddService) = False Then Exit Sub
        Dim TblClient As DataTable = DAClient.SelectClientInfoByClientNo(EmptyString(TxtClientNo.Text))
        If TblClient.Rows.Count = 0 Then
            MessageBox.Show("Wrong client no. Please check again.", "Find Client", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClientNo.Focus()
            TxtClientNo.SelectAll()
            TxtClientName.Text = ""
            TxtClientSex.Text = ""
            TxtClientAge.Text = ""
            'RadServiceA.Checked = False
            'RadServiceB.Checked = False
            'RadServiceC.Checked = False
        Else
            For Each DRows As DataRow In TblClient.Rows
                TxtClientName.Text = DRows("CLIENT_NAME")
                TxtClientSex.Text = DRows("CLIENT_SEX")
                TxtClientAge.Text = DRows("CLIENT_AGE")
                If DRows("CLIENT_SOCIAL_SERVICETYPE") = ReceiptUtilityModule.SOCIAL_TYPE_A Then
                    RadServiceA.Checked = True
                ElseIf DRows("CLIENT_SOCIAL_SERVICETYPE") = ReceiptUtilityModule.SOCIAL_TYPE_B Then
                    RadServiceB.Checked = True
                ElseIf DRows("CLIENT_SOCIAL_SERVICETYPE") = ReceiptUtilityModule.SOCIAL_TYPE_C Then
                    RadServiceC.Checked = True
                End If
                'TxtReceiptAmmount.Focus()
                'TxtReceiptAmmount.SelectAll()
            Next
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FSpacialServiceSetting As New SpacialServiceSetting
        FSpacialServiceSetting.ShowDialog()
        With CboSkill
            .DataSource = DASkill.GetData
            .ValueMember = "SKILL_ID"
            .DisplayMember = "SKILL_NAME"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub CboSkill_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboSkill.KeyDown
        If e.KeyCode = Keys.Enter Then
            CallAddSpacialService()
        End If
    End Sub

    Private Sub CallAddSpacialService()
        If ValidateCombobox(CboSkill, "", ErrAddService) = False Then Exit Sub
        If ValidateCombobox(CboPackage, "", ErrAddService) = False Then Exit Sub
        If ValidateTextField(TxtSpacialServicePrice, "", ErrAddService) = False Then Exit Sub
        If CboSkill.SelectedValue Is Nothing Then
            MessageBox.Show("Please select the correct skill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboSkill.Focus()
            CboSkill.SelectAll()
            Exit Sub
        End If
        If CboPackage.SelectedValue Is Nothing Then
            MessageBox.Show("Please select the correct skill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboPackage.Focus()
            CboPackage.SelectAll()
            Exit Sub
        End If

        If CheckExistingItemSpacialService(CboSkill.SelectedValue.ToString) = True Then
            MessageBox.Show("The skill already add to list. Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboSkill.Focus()
            CboSkill.SelectAll()
            Exit Sub
        Else
            AddTemSpacialService(CboSkill.SelectedValue, CboSkill.Text, CboPackage.SelectedValue, CboPackage.Text, EmptyString(TxtSpacialServicePrice.Text), LblSocialType.Text)
        End If
    End Sub
    Function CheckExistingItemSpacialService(ByVal ItemId As Integer) As Boolean
        For Each row As Janus.Windows.GridEX.GridEXRow In GridSpacialService.GetRows
            If row.Cells("SKILL_ID").Value = ItemId Then
                Return True
                Exit Function
                'Else
                '    Return False
            End If
        Next
    End Function
    Private Sub AddTemSpacialService(ByVal SKILL_ID As Integer, ByVal SKILL_NAME As String, ByVal PACKAGE_ID As Integer, ByVal PACKAGE_NAME As String, ByVal PACKAGE_PRICE As Integer, ByVal SocialType As String)
        Dim Drow As DataRow = TblSpacialServiceTem.NewRow
        Drow("SKILL_ID") = SKILL_ID
        Drow("SKILL_NAME") = SKILL_NAME
        Drow("PACKAGE_ID") = PACKAGE_ID
        Drow("PACKAGE_NAME") = PACKAGE_NAME
        Drow("PACKAGE_PRICE") = PACKAGE_PRICE
        Drow("PACKAGE_TYPE") = SocialType
        TblSpacialServiceTem.Rows.Add(Drow)
        RefreshAddTemSpacialService()
        TotalReceiptSpacialService()
        CleanFormSpacialService()
    End Sub
    Private Sub RefreshAddTemSpacialService()
        Try
            GridSpacialService.Refetch()
            GridSpacialService.DataSource = TblSpacialServiceTem
        Catch ex As Exception

        End Try

    End Sub
    Private Sub TotalReceiptSpacialService()
        Dim TotalAmount As Double = 0
        For Each GRow As GridEXRow In Me.GridSpacialService.GetRows
            TotalAmount = TotalAmount + CDbl(GRow.Cells("PACKAGE_PRICE").Value)
        Next
        LblTotalServiceSpacial.Text = FormatNumber(TotalAmount)

    End Sub
    Private Sub CleanFormSpacialService()
        CboSkill.SelectedIndex = -1
        CboSkill.Text = ""
        TxtSpacialServicePrice.Text = ""
        LblSpacialID.Text = ""
        LblSpacialName.Text = ""
        LblServicePrice.Text = ""
        LblSocialType.Text = ""
        CboPackage.SelectedIndex = -1
        CboPackage.Text = ""
        CboSkill.Focus()
        CboSkill.SelectAll()
    End Sub

    Private Sub CboSkill_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSkill.SelectedValueChanged
        Try
            LoadServicePackage(CboSkill.SelectedValue)
        Catch ex As Exception
            LblSpacialID.Text = ""
            LblSpacialName.Text = ""
            LblServicePrice.Text = ""
            LblSocialType.Text = ""
        End Try
    End Sub

    Private Sub CboPackage_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPackage.SelectedValueChanged
        Try
            If CboPackage.SelectedValue Is Nothing Then
                LblSpacialID.Text = ""
                LblSpacialName.Text = ""
                TxtSpacialServicePrice.Text = ""
                LblSocialType.Text = ""
                TxtSpacialServicePrice.Text = ""
                Exit Sub
            End If

            LoadSocialService(CInt(CboPackage.SelectedValue))
        Catch ex As Exception
            LblSpacialID.Text = ""
            LblSpacialName.Text = ""
            TxtSpacialServicePrice.Text = ""
            LblSocialType.Text = ""
            TxtSpacialServicePrice.Text = ""
        End Try
    End Sub
    Private Sub LoadSocialService(ByVal PackageID As Integer)
        Try
            Dim TblSpacialService As DataTable = DASpacialService.SelectBySocialServiceID(PackageID)
            For Each drows As DataRow In TblSpacialService.Rows
                LblSpacialID.Text = CboPackage.SelectedValue
                LblSpacialName.Text = drows("PACKAGE_NAME")
                If RadServiceA.Checked = True Then
                    TxtSpacialServicePrice.Text = drows("PACKAGE_A")
                    LblSocialType.Text = "A"
                ElseIf RadServiceB.Checked = True Then
                    TxtSpacialServicePrice.Text = drows("PACKAGE_B")
                    LblSocialType.Text = "B"
                ElseIf RadServiceC.Checked = True Then
                    TxtSpacialServicePrice.Text = drows("PACKAGE_C")
                    LblSocialType.Text = "C"
                End If
            Next
        Catch ex As Exception


        End Try
    End Sub

    Private Sub BtnAddSpacial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddSpacial.Click
        CallAddSpacialService()
        CalculatePaymentSumarry()
    End Sub

    Private Sub BtnRemoveSpacial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveSpacial.Click
        If GridSpacialService.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove medicine?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            RemoveItemTemSpacialService(GridSpacialService.Row)
            CalculatePaymentSumarry()
        End If
    End Sub
    Private Sub RemoveItemTemSpacialService(ByVal index As Integer)
        TblSpacialServiceTem.BeginLoadData()
        TblSpacialServiceTem.Rows.RemoveAt(index)
        TblSpacialServiceTem.EndLoadData()
        RefreshAddTemSpacialService()
        TotalReceiptSpacialService()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtReceivedKHR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceivedKHR.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtReceivedKHR_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceivedKHR.KeyUp
        CalReceiveCash(EmptyString(TxtReceivedKHR.Text), EmptyString(TxtReceivedUSD.Text))
    End Sub
    Private Sub CalReceiveCash(ByVal AmountR As Double, ByVal AmountUSD As Double)
        LblTotalReceiveUSDKHR.Text = NearestHundred((AmountR + (AmountUSD * CDbl(TxtExchangeRate.Text))))
        TxtReturnKHR.Text = FormatNumber(NearestHundred(FormatNumber(CDbl(LblTotalReceiveUSDKHR.Text) - CDbl(LblTotalServicePayment.Text))))
        TxtReturnUSD.Text = FormatNumber((EmptyString(TxtReturnKHR.Text) / CDbl(TxtExchangeRate.Text))) '(CDbl(LblTotalReceiveUSDKHR.Text) / CDbl(TxtExchangeRate.Text)) 'NearestHundred(FormatNumber(((CDbl(LblTotalReceiveUSDKHR.Text) / CDbl(TxtExchangeRate.Text))))) ' - (CDbl(TxtAmount.Text) / CDbl(TxtExchangeRate.Text)))))
    End Sub

    Private Sub BtnCalculater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculater.Click
        Try
            System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CalculatePaymentSumarry()

        Dim FinalValue As Double = (CDbl(EmptyString(LblTotalServiceNewConsult.Text)) + CDbl(EmptyString(LblTotalServiceFollowUp.Text)) + CDbl(EmptyString(LblTotalServiceContribute.Text)) + CDbl(EmptyString(LblTotalServiceSpacial.Text)) + CDbl(EmptyString(LblTotalServiceMedicine.Text)) + CDbl(EmptyString(LblTotalMiscellaneous.Text)))

        LblTotalServicePayment.Text = FormatNumber(RoundToLeftValueForKHR(FinalValue, 2)) ' FormatNumber(NearestHundred(FinalValue)) ' FormatNumber(Math.Round(CDbl(FinalValue) / 100, 0) * 100)

    End Sub


    Private Sub TxtReceiptContributeAmmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptContributeAmmount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtReceiptContributeAmmount_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceiptContributeAmmount.KeyUp
        If TxtReceiptContributeAmmount.Text = "" Then
            LblTotalServiceContribute.Text = "0"
        Else
            LblTotalServiceContribute.Text = FormatNumber(EmptyString(TxtReceiptContributeAmmount.Text))
        End If

        CalculatePaymentSumarry()
    End Sub

    Private Sub LblTotalPayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTotalServicePayment.TextChanged
        Dim Riel As New riel()
        Dim Dollar As New dollar()

        Me.TxtAmountInWordReceive.Text = Riel.Convert(Me.LblTotalServicePayment.Text)
    End Sub

    Private Sub TxtReceiptContributeAmmount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceiptContributeAmmount.Click
        TxtReceiptContributeAmmount.SelectAll()
    End Sub

    Private Sub RadMedicineOutcenter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMedicineOutcenter.CheckedChanged
        TxtMedicineOut.Enabled = RadMedicineOutcenter.Checked
        TxtCorrentQTY.Text = 0
    End Sub

    Private Sub RadMedicineIncenter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMedicineIncenter.CheckedChanged
        CboItem.Enabled = RadMedicineIncenter.Checked
        CboItem.SelectedIndex = -1
    End Sub

    Private Sub BGSaveAndPrintReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGSaveAndPrintReceipt.RunWorkerCompleted
        'MessageBox.Show("Client payment successfully!", "Paid", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DoPrintReceipt()
        LblPrinting.Visible = False
        PicLoading.Visible = False
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
    Private Sub DoPrintReceipt()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf DoPrintReceipt))
        Else
            Dim FPrintPreview As New PrintPreviewCashReceipt
            FPrintPreview.IS_PRINT_NEWRECEIPT = True
            Dim CRNewReceipt As New CRNewClientReceipt
            CRNewReceipt.SetDataSource(TblIssueReceipt)
            'CRNewReceipt.SetParameterValue("title", Now.Date)
            FPrintPreview.CrystalReportObject = CRNewReceipt

            FPrintPreview.ShowDialog()
            FPrintPreview.Close()
        End If

    End Sub

    Private Sub BGSaveAndPrintReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGSaveAndPrintReceipt.DoWork
        TblIssueReceipt = DAClientReceipt.SelectCashByReceiptNo(EmptyString(TxtReceiptNo.Text))
    End Sub

    Private Sub TxtServicePrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtItemPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtReceivedKHR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceivedKHR.Click
        TxtReceivedKHR.Focus()
        TxtReceivedKHR.Select()
        TxtReceivedKHR.SelectAll()
    End Sub

    Private Sub TxtReceivedUSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceivedUSD.Click
        TxtReceivedUSD.Focus()
        TxtReceivedUSD.Select()
        TxtReceivedUSD.SelectAll()
    End Sub

    Private Sub TxtReceivedUSD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceivedUSD.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtReceivedUSD_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceivedUSD.KeyUp
        CalReceiveCash(EmptyString(TxtReceivedKHR.Text), EmptyString(TxtReceivedUSD.Text))
    End Sub

    Private Sub TxtTotalQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotalQTY.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub ChFreeSpacialService_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChFreeSpacialService.CheckedChanged
        If ChFreeSpacialService.Checked = True Then
            ChFreeSpacialService.Text = "Spacial service:"
            LblTotalServiceSpacial.Text = "0"
        ElseIf ChFreeSpacialService.Checked = False Then
            ChFreeSpacialService.Text = "Free Spacial service:"
            TotalReceiptSpacialService()
        End If
        CalculatePaymentSumarry()
    End Sub

    Private Sub ChFreeMedicine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChFreeMedicine.CheckedChanged
        If ChFreeMedicine.Checked = True Then
            'ChFreeMedicine.Text = "Medicine:"
            LblTotalServiceMedicine.Text = "0"
        ElseIf ChFreeMedicine.Checked = False Then
            'ChFreeMedicine.Text = "Free Medicine:"
            TotalReceiptMedicine()
        End If
        CalculatePaymentSumarry()
    End Sub
    'LblTotalServiceNewConsult.Text = DACCAMH_RECEIPT.TotalServiceNew(ReceiptNo)
    '  LblTotalServiceFollowUp.Text = DACCAMH_RECEIPT.TotalServiceFollowup(ReceiptNo)
    '  LblTotalServiceContribute.Text = DACCAMH_RECEIPT.TotalServiceContribution(ReceiptNo)
    '  LblTotalServiceSpacial.Text = DACCAMH_RECEIPT.TotalServiceSpacial(ReceiptNo)
    '  LblTotalServiceMedicine.Text = DACCAMH_RECEIPT.TotalServiceMedicine(ReceiptNo)
    Private Sub ChFreeNewClient_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChFreeNewClient.CheckedChanged
        If ChFreeNewClient.Checked = True Then
            'ChFreeNewClient.Text = "New Client:"
            LblTotalServiceNewConsult.Text = "0"
        ElseIf ChFreeNewClient.Checked = False Then
            'ChFreeNewClient.Text = "Free New Client:"
            LblTotalServiceNewConsult.Text = FormatNumber(DA_RECEIPT.TotalServiceNew(TxtReceiptNo.Text))
        End If
        CalculatePaymentSumarry()
    End Sub

    Private Sub ChFollowupFree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChFreeFollowup.CheckedChanged
        If ChFreeFollowup.Checked = True Then
            ' ChFollowupFree.Text = "Followup Client:"
            LblTotalServiceFollowUp.Text = "0"
        ElseIf ChFreeFollowup.Checked = False Then
            'ChFollowupFree.Text = "Free Followup Client:"
            LblTotalServiceFollowUp.Text = FormatNumber(DA_RECEIPT.TotalServiceFollowup(TxtReceiptNo.Text))
        End If
        CalculatePaymentSumarry()
    End Sub

    Private Sub BtnAddMoreDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMoreDoctor.Click
        Dim NewTherapist As New FormTherapist
        If NewTherapist.ShowDialog = DialogResult.OK Then
            With CboTherapistOrDoctor
                .DataSource = DA_Therapist.GetData
                .ValueMember = "THERAPIST_ID"
                .DisplayMember = "THERAPIST_NAME"
                .SelectedIndex = -1
            End With
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(Math.Round(CDbl(LblTotalServicePayment.Text) / 100, 0) * 100)
    End Sub

    Private Sub TxtTotalDayUsed_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotalDayUsed.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtTotalDayUsed_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTotalDayUsed.KeyUp
        CalDayAndTotalUsed()
    End Sub

    Private Sub TxtMiscellaneous_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMiscellaneous.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtMiscellaneous_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMiscellaneous.KeyUp
        If TxtMiscellaneous.Text = "" Then
            LblTotalMiscellaneous.Text = "0"
        Else
            LblTotalMiscellaneous.Text = FormatNumber(EmptyString(TxtMiscellaneous.Text))
        End If

        CalculatePaymentSumarry()
    End Sub

    Private Sub TxtSpacialServicePrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSpacialServicePrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub FormAddMoreSercice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CboMainTherapy.Text = DA_Assessment.GetMainTherapy(TxtClientNo.Text)
            CboItem.Select()
            CboItem.Focus()

        Catch ex As Exception
            CboMainTherapy.Text = ""
        End Try
    End Sub

    Private Sub RadServiceA_CheckedChanged(sender As Object, e As EventArgs) Handles RadServiceA.CheckedChanged
        TblPresciptionTem.BeginLoadData()
        TblPresciptionTem.Rows.Clear()
        TblPresciptionTem.EndLoadData()
        RefreshAddTem()
        TotalReceiptMedicine()
        CalculatePaymentSumarry()
    End Sub

    Private Sub RadServiceB_CheckedChanged(sender As Object, e As EventArgs) Handles RadServiceB.CheckedChanged
        TblPresciptionTem.BeginLoadData()
        TblPresciptionTem.Rows.Clear()
        TblPresciptionTem.EndLoadData()
        RefreshAddTem()
        TotalReceiptMedicine()
        CalculatePaymentSumarry()
    End Sub

    Private Sub RadServiceC_CheckedChanged(sender As Object, e As EventArgs) Handles RadServiceC.CheckedChanged
        TblPresciptionTem.BeginLoadData()
        TblPresciptionTem.Rows.Clear()
        TblPresciptionTem.EndLoadData()
        RefreshAddTem()
        TotalReceiptMedicine()
        CalculatePaymentSumarry()
    End Sub
End Class