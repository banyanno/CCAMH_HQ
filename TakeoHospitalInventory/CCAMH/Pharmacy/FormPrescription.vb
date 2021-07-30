Imports Janus.Windows.GridEX

Public Class FormPrescription
    Dim DA_Doctor As New DSPrescriptionTableAdapters.TblDoctorTableAdapter
    Public DA_Prescipt As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTIONTableAdapter
    Dim DA_Prescipt_Detial As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTION_DETIALTableAdapter
    Public TblPresciptionTem As DataTable = New DSPrescription.CCAMH_PRESCRIPTION_DETIALDataTable
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim DA_Item As New DSSocialEconomicSettingTableAdapters.VItemPriceOpticalShopTableAdapter
    Dim DAClient As New DSCashCollectionTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim DA_Med_ReceiptDetail As New DSMedicinceReceiptTableAdapters.CCAMH_RECEPT_MED_SOCIAL_DETAILTableAdapter

    Dim TblPrescriptionReport As DataTable
    Dim DA_PrescriptionReport As New DSPrescriptionTableAdapters.CCAMH_VIEW_PRESCRIPTIONTableAdapter
    Public PrescriptonID As Double

    Public DA_MEDICDETAIL_Receipt As New DSCashCollectionTableAdapters.CCAMH_RECEPT_MED_SOCIAL_DETAILTableAdapter
    Public DA_RECEIPT As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDoctor
            .DataSource = DA_Doctor.GetData
            .DisplayMember = "DoctorName"
            .ValueMember = "DoctorNo"
            .SelectedIndex = -1
        End With
        With CboItem
            .DataSource = DA_Item.SelectListItemFromPharmacy(26)
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.
        Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
    End Sub
    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindingClientNo()
    End Sub
    Private Sub FindingClientNo()
        If ValidateTextField(TxtClientNo, "", ErrPrescription) = False Then Exit Sub
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

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub
    Private Sub LoadSocialServiceMedicince(ByVal ItemId As Integer)
        Try
            Dim TblItem As DataTable = DA_Item.SelectItemPriceByDepartment(ItemId, 26) 'SelelectItemByItemID(ItemId)
            For Each drows As DataRow In TblItem.Rows
                LblCategoryId.Text = drows("ItemID")
                LblCatName.Text = drows("CateName")
                TxtCorrentQTY.Text = drows("UnitsInStock")
                If RadServiceA.Checked = True Then
                    TxtServicePrice.Text = drows("PriceA")
                    LblSocialTypePrice.Text = "A"
                ElseIf RadServiceB.Checked = True Then
                    TxtServicePrice.Text = drows("PriceB")
                    LblSocialTypePrice.Text = "B"
                ElseIf RadServiceC.Checked = True Then
                    TxtServicePrice.Text = drows("PriceC")
                    LblSocialTypePrice.Text = "C"
                End If

            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click
        If RadMedicineIncenter.Checked = True Then
            If ValidateCombobox(CboItem, "", ErrPrescription) = False Then Exit Sub
            If CboItem.SelectedValue Is Nothing Then Exit Sub
            If CheckExistingItem(CboItem.Text) = True Then Exit Sub
        End If
        If RadMedicineOutcenter.Checked = True Then
            If ValidateTextField(TxtMedicineOut, "", ErrPrescription) = False Then Exit Sub

            If CheckExistingItem(TxtMedicineOut.Text) = True Then Exit Sub
        End If

        If ValidateTextField(TxtM, "", ErrPrescription) = False Then Exit Sub
        If ValidateTextField(TxtN, "", ErrPrescription) = False Then Exit Sub
        If ValidateTextField(TxtE, "", ErrPrescription) = False Then Exit Sub
        If ValidateTextField(TxtQTY, "", ErrPrescription) = False Then Exit Sub
        Dim SubTotal As Double = 0
        If RadMedicineIncenter.Checked = True Then
            SubTotal = EmptyString(TxtServicePrice.Text) * EmptyString(EmptyString(TxtQTY.Text))
        Else
            SubTotal = 0
        End If

        AddItemTem(CDbl(IIf(RadMedicineIncenter.Checked = True, CboItem.SelectedValue, 999)), CStr(IIf(RadMedicineIncenter.Checked = True, CboItem.Text, TxtMedicineOut.Text)), TxtM.Text, TxtN.Text, TxtE.Text, EmptyString(TxtQTY.Text), EmptyString(TxtServicePrice.Text), SubTotal, CStr(IIf(RadMedicineIncenter.Checked = True, "IN", "OUT")))

    End Sub
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
            TotalAmount = TotalAmount + CDbl(GRow.Cells("MED_SUB_TOTAL").Value)
        Next
        TxtReceiptAmmount.Text = FormatNumber(TotalAmount)

    End Sub
    Private Sub RefreshAddTem()
        'Try
        GridPrescription.Refresh()

        GridPrescription.DataSource = TblPresciptionTem

        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub CleanForm()
        CboItem.SelectedIndex = -1
        TxtM.Text = ""
        TxtN.Text = ""
        TxtE.Text = ""
        TxtQTY.Text = ""
        TxtCorrentQTY.Text = ""
        CboItem.Focus()
        CboItem.Select()
        CboItem.SelectAll()
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click
        If GridPrescription.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove item prescription?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            RemoveItemTem(GridPrescription.Row)
        End If
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
    Private Sub RemoveItemTem(ByVal index As Integer)
        TblPresciptionTem.BeginLoadData()
        TblPresciptionTem.Rows.RemoveAt(index)
        TblPresciptionTem.EndLoadData()
        RefreshAddTem()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrPrescription) = False Then Exit Sub
        If ValidateTextField(TxtClientName, "", ErrPrescription) = False Then Exit Sub
        If ValidateTextField(TxtClientSex, "", ErrPrescription) = False Then Exit Sub
        If ValidateTextField(TxtClientAge, "", ErrPrescription) = False Then Exit Sub
        If GridPrescription.SelectedItems.Count = 0 Then Exit Sub

        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                LblPrinting.Visible = True
                PicLoading.Visible = True
                If DA_Prescipt.InsertNewPrescription(TxtClientNo.Text, TxtClientName.Text, TxtClientAge.Text, TxtClientSex.Text, "", CboDoctor.Text, DatePrescription.Value.Date, IIf(DateNextVisit.Checked = False, Nothing, DateNextVisit.Value.Date), False, TxtPrescriptNote.Text, "0") = 1 Then
                    PrescriptonID = CDbl(DA_Prescipt.GetLastInsert)
                    For Each GRow As GridEXRow In GridPrescription.GetRows

                        DA_Prescipt_Detial.InsertPresDetial(PrescriptonID, GRow.Cells("MED_ID").Value, _
                                                             GRow.Cells("MED_NAME").Value, GRow.Cells("MED_M").Value, _
                                                             GRow.Cells("MED_N").Value, GRow.Cells("MED_E").Value, _
                                                             GRow.Cells("MED_QTY").Value, GRow.Cells("MED_PRICE").Value, GRow.Cells("MED_SUB_TOTAL").Value, GRow.Cells("REMARK").Value, 0)

                    Next
                    '================= do save to medicince receipt ==============================
                    ' If ReceiptUtilityModule.CheckDuplicateReceiptNo(EmptyString(TxtReceiptNo.Text)) = True Then
                    Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
                    ' End If
                    If SaveMedicineReceipt(PrescriptonID) = 1 Then
                        InsertReceiptMedDetail()
                    End If
                    BgLoadingPrescription.RunWorkerAsync()

                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                LblPrinting.Visible = True
                PicLoading.Visible = True
                If DA_Prescipt.UpdatePrescription(TxtClientNo.Text, TxtClientName.Text, TxtClientAge.Text, TxtClientSex.Text, "", CboDoctor.Text, DatePrescription.Value.Date, IIf(DateNextVisit.Checked = False, Nothing, DateNextVisit.Value.Date), LblSaveOption.Text) = 1 Then
                    DA_Prescipt_Detial.DeletePrescDetailByID(LblSaveOption.Text)
                    DA_MEDICDETAIL_Receipt.DeleteMedByReceiptNo(EmptyString(TxtReceiptNo.Text))
                    For Each GRow As GridEXRow In GridPrescription.GetRows
                        DA_Prescipt_Detial.InsertPresDetial(LblSaveOption.Text, GRow.Cells("MED_ID").Value, _
                                                             GRow.Cells("MED_NAME").Value, GRow.Cells("MED_M").Value, _
                                                             GRow.Cells("MED_N").Value, GRow.Cells("MED_E").Value, _
                                                             GRow.Cells("MED_QTY").Value, GRow.Cells("MED_PRICE").Value, GRow.Cells("MED_SUB_TOTAL").Value, GRow.Cells("REMARK").Value, 0)

                    Next
                    If UpdateMedicineReceipt(EmptyString(TxtReceiptNo.Text)) = 1 Then
                        InsertReceiptMedDetail()
                    End If

                    BgLoadingPrescription.RunWorkerAsync()

                End If
            End If
        End If
    End Sub
    Private Sub InsertReceiptMedDetail()
        For Each GRow As GridEXRow In GridPrescription.GetRows
            DA_Med_ReceiptDetail.InsertMedicineDetail(TxtReceiptNo.Text, 0, "", GRow.Cells("MED_ID").Value, GRow.Cells("MED_NAME").Value, GRow.Cells("MED_QTY").Value, GRow.Cells("MED_PRICE").Value, "", GRow.Cells("MED_SUB_TOTAL").Value, GRow.Cells("MED_M").Value, GRow.Cells("MED_N").Value, GRow.Cells("MED_E").Value, GRow.Cells("REMARK").Value)
        Next
    End Sub
    Private Sub BgLoadingPrescription_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingPrescription.DoWork
        TblPrescriptionReport = DA_PrescriptionReport.SelectPrescription(PrescriptonID)
    End Sub

    Private Sub BgLoadingPrescription_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingPrescription.RunWorkerCompleted

        DoPrint()
        LblPrinting.Visible = False
        PicLoading.Visible = False
    End Sub
    Private Sub DoPrint()
        Dim FPrintPreview As New PrintPreviewCashReceipt
        Dim ObjCRVReceipt As New CrvPrescription
        ObjCRVReceipt.SetDataSource(TblPrescriptionReport)
        FPrintPreview.CrystalReportObject = ObjCRVReceipt
        FPrintPreview.IS_PRINT_PRESCRIPTION = True
        FPrintPreview.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub TxtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTY.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtClientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindingClientNo()
        End If
    End Sub

    Private Sub CboItem_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboItem.SelectedValueChanged
        Try
            LoadSocialServiceMedicince(CboItem.SelectedValue.ToString)
        Catch ex As Exception
            LblCategoryId.Text = ""
            LblCatName.Text = ""
            TxtCorrentQTY.Text = ""
            TxtServicePrice.Text = ""
            LblSocialTypePrice.Text = ""
        End Try
    End Sub

    Private Sub TxtReceiptAmmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceiptAmmount.TextChanged
        Dim Riel As New riel()
        Dim Dollar As New dollar()
        Me.TxtAmmountInword.Text = Riel.Convert(Me.TxtReceiptAmmount.Text)
    End Sub

    '============================== Process save receipt medicine ====================
    Private Function SaveMedicineReceipt(ByVal PrescriptionID As Double) As Integer
        Return DAClientReceipt.InsertMedReceiptService(EmptyString(TxtReceiptNo.Text), ReceiptUtilityModule.RECEIPT_MED, _
                                                       ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), _
                                                    RadServiceA.Checked), ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), _
                                                    RadServiceB.Checked), ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), _
                                                    RadServiceC.Checked), False, DatePrescription.Value.Year, Now, DatePrescription.Value.Date, _
                                                    EmptyString(TxtReceiptAmmount.Text), (EmptyString(TxtReceiptAmmount.Text) / ReceiptUtilityModule.GetExchangeRate), _
                                                    ReceiptUtilityModule.GetExchangeRate, USER_NAME, TxtAmmountInword.Text, TxtClientNo.Text, TxtClientName.Text, TxtClientSex.Text, _
                                                    TxtClientAge.Text, "", "", ReceiptUtilityModule.GetSocialServieType(RadServiceA.Checked, RadServiceB.Checked, RadServiceC.Checked), PrescriptionID)
    End Function

    '============================== Process save receipt medicine ====================
    Private Function UpdateMedicineReceipt(ByVal ReceiptNO As Double) As Integer
        Return DAClientReceipt.UpdateReceiptByPrescriptID(ReceiptUtilityModule.RECEIPT_MED, ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceA.Checked), _
                                                          ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceB.Checked), _
                                                          ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceC.Checked), False, _
                                                          EmptyString(TxtReceiptAmmount.Text), (EmptyString(TxtReceiptAmmount.Text) / ReceiptUtilityModule.GetExchangeRate), _
                                                TxtAmmountInword.Text, "", ReceiptNO)
    End Function
  
    Private Sub RadOutcenter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMedicineOutcenter.CheckedChanged
        TxtMedicineOut.Enabled = RadMedicineOutcenter.Checked
        TxtMedicineOut.Select()
        TxtMedicineOut.Focus()
        TxtMedicineOut.SelectAll()
    End Sub

    Private Sub RadMedicineIncenter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMedicineIncenter.CheckedChanged
        CboItem.Enabled = RadMedicineIncenter.Checked
    End Sub

    Private Sub BtnAddMoreDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMoreDoctor.Click
        Dim FDoctor As New FRMNewDoctor
        FDoctor.ShowDialog()
        If FDoctor.isDoctorClose = True Then
            With CboDoctor
                .DataSource = DA_Doctor.GetData
                .DisplayMember = "DoctorName"
                .ValueMember = "DoctorNo"
                .SelectedIndex = -1
            End With
        End If
    End Sub
End Class