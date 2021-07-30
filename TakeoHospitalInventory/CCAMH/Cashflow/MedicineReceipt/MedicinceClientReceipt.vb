Imports Janus.Windows.GridEX

Public Class MedicinceClientReceipt
    Dim DA_Item As New DSSocialEconomicSettingTableAdapters.VItemPriceOpticalShopTableAdapter
    Dim DA_ItemPrice As New DSDrugPriceSettingTableAdapters.tblItemPriceTableAdapter
    Dim DAClient As New DSCashCollectionTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim TblItemTem As DataTable = New DSMedicinceReceipt.CCAMH_RECEPT_MED_SOCIAL_DETAILDataTable
    Dim DA_Med_ReceiptDetail As New DSMedicinceReceiptTableAdapters.CCAMH_RECEPT_MED_SOCIAL_DETAILTableAdapter
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim TblNewReceipt As DataTable
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboItem
            .DataSource = DA_Item.SelectByItemByDepartment(SALE_DEPART_ID)
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
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
    Private Sub LoadSocialServiceMedicince(ByVal ItemId As Integer)
        Try
            Dim TblItem As DataTable = DA_Item.SelelectItemByItemID(ItemId)
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

        CallAddItem()

    End Sub
    Private Sub CallAddItem()
        If ValidateCombobox(CboItem, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtQTY, "", ErrNewReceipt) = False Then Exit Sub
        If CInt(EmptyString(TxtServicePrice.Text)) <= 0 Then
            MessageBox.Show("Please enter social service price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtServicePrice.Select()
            TxtServicePrice.SelectAll()
            TxtServicePrice.Focus()
            Exit Sub
        End If
        If CboItem.SelectedValue Is Nothing Then
            MessageBox.Show("Please select the correct medicine!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboItem.Focus()
            CboItem.SelectAll()
            Exit Sub
        Else
            If CheckExistingItem(CboItem.SelectedValue.ToString) = True Then
                MessageBox.Show("The medicine already add to list. Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CboItem.Focus()
                CboItem.SelectAll()
                Exit Sub
            Else
                AddItemTem(CboItem.SelectedValue, CboItem.Text, LblCategoryId.Text, LblCatName.Text, EmptyString(TxtQTY.Text), TxtServicePrice.Text, LblSocialTypePrice.Text, (EmptyString(TxtQTY.Text) * CDbl(TxtServicePrice.Text)))
            End If


        End If
    End Sub
    Function CheckExistingItem(ByVal ItemId As Integer) As Boolean
        For Each row As Janus.Windows.GridEX.GridEXRow In GridServiceMed.GetRows
            If row.Cells("ITEM_ID").Value = ItemId Then
                Return True
                Exit Function
                'Else
                '    Return False
            End If
        Next
    End Function
    '================ Add item ================================
    Private Sub AddItemTem(ByVal ItemID As Integer, ByVal itemName As String, ByVal CatID As Integer, ByVal CateName As String, ByVal Qty As Integer, ByVal SocialPrice As Double, ByVal SocialType As String, ByVal SubTotal As Double)
        Dim Drow As DataRow = TblItemTem.NewRow
        Drow("ITEM_ID") = ItemID
        Drow("ITEM_NAME") = itemName
        Drow("CATE_ID") = CatID
        Drow("CATE_NAME") = CateName
        Drow("ITEM_QTY") = Qty
        Drow("SOCIAL_PRICE") = SocialPrice
        Drow("SOCIAL_TYPE") = SocialType
        Drow("SUB_TOTAL") = SubTotal
        TblItemTem.Rows.Add(Drow)
        RefreshAddTem()
        TotalReceiptMedicine()
        CleanForm()
    End Sub
    Private Sub TotalReceiptMedicine()
        Dim TotalAmount As Double = 0
        For Each GRow As GridEXRow In Me.GridServiceMed.GetRows
            TotalAmount = TotalAmount + CDbl(GRow.Cells("SUB_TOTAL").Value)
        Next
        TxtReceiptAmmount.Text = FormatNumber(TotalAmount)

    End Sub
    Private Sub CleanForm()
        CboItem.SelectedIndex = -1
        CboItem.Text = ""
        TxtQTY.Text = ""
        LblCategoryId.Text = ""
        LblCatName.Text = ""
        TxtServicePrice.Text = ""
        LblSocialTypePrice.Text = ""
        CboItem.Focus()
        CboItem.SelectAll()
    End Sub
    Private Sub RefreshAddTem()
        Try
            GridServiceMed.Refetch()
            GridServiceMed.DataSource = TblItemTem
        Catch ex As Exception

        End Try

    End Sub
    Private Sub RemoveItemTem(ByVal index As Integer)
        TblItemTem.BeginLoadData()
        TblItemTem.Rows.RemoveAt(index)
        TblItemTem.EndLoadData()
        RefreshAddTem()
        TotalReceiptMedicine()
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click
        'MessageBox.Show(GridServiceMed.Row)
        If GridServiceMed.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove medicine?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            RemoveItemTem(GridServiceMed.Row)
        End If

    End Sub

    Private Sub LblCatName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCatName.Click

    End Sub

    Private Sub TxtQTY_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQTY.KeyUp
        If e.KeyCode = Keys.Enter Then
            CallAddItem()
        End If

    End Sub



    Private Sub CboItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            CallAddItem()
        End If
    End Sub

    Private Sub TxtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTY.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtReceiptAmmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceiptAmmount.TextChanged
        Dim Riel As New riel()
        Dim Dollar As New dollar()

        Me.TxtAmmountInword.Text = Riel.Convert(Me.TxtReceiptAmmount.Text)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindingClientNo()
    End Sub
    Private Sub FindingClientNo()
        If ValidateTextField(TxtClientNo, "", ErrNewReceipt) = False Then Exit Sub
        Dim TblClient As DataTable = DAClient.SelectClientInfoByClientNo(EmptyString(TxtClientNo.Text))
        If TblClient.Rows.Count = 0 Then
            MessageBox.Show("Wrong client no. Please check again.", "Find Client", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClientNo.Focus()
            TxtClientNo.SelectAll()
            TxtClientName.Text = ""
            TxtClientSex.Text = ""
            TxtClientAge.Text = ""
            RadServiceA.Checked = False
            RadServiceB.Checked = False
            RadServiceC.Checked = False
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
                CboItem.Focus()
                CboItem.SelectAll()
            Next
        End If
    End Sub



    Private Sub MedicinceClientReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
        DateReceipt.Value = GetDateServer()
        TxtRecieveBy.Text = USER_NAME
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientName, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientSex, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientAge, "", ErrNewReceipt) = False Then Exit Sub

        If ValidateGroupBox(GBSocialServieType, True) = False Then
            GBSocialServieType.BackColor = Color.Khaki
            Exit Sub
        Else
            GBSocialServieType.BackColor = Color.Transparent
        End If
        If ValidateTextField(TxtReceiptNo, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateDateField(DateReceipt, "", ErrNewReceipt) = False Then Exit Sub
        If GridServiceMed.SelectedItems.Count = 0 Then
            MessageBox.Show("Must have one medicine in list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ValidateTextField(TxtReceiptAmmount, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtAmmountInword, "", ErrNewReceipt) = False Then Exit Sub
        If MessageBox.Show("Do you want to save new receipt?", "New Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            'If ReceiptUtilityModule.CheckDuplicateReceiptNo(EmptyString(TxtReceiptNo.Text)) = True Then
            Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
            'End If
            If SaveMedicineReceiptAndPrintReceipt() = 1 Then
                InsertReceiptMedDetail()
                Application.DoEvents()
                LblPrinting.Visible = True
                PicLoading.Visible = True
                Application.DoEvents()
                BGSaveAndPrintReceipt.RunWorkerAsync()

            End If
        End If
    End Sub
    Private Sub InsertReceiptMedDetail()
        For Each GRow As GridEXRow In GridServiceMed.GetRows
            DA_Med_ReceiptDetail.InsertMedicineDetail(TxtReceiptNo.Text, GRow.Cells("CATE_ID").Value, GRow.Cells("CATE_NAME").Value, GRow.Cells("ITEM_ID").Value, GRow.Cells("ITEM_NAME").Value, GRow.Cells("ITEM_QTY").Value, GRow.Cells("SOCIAL_PRICE").Value, GRow.Cells("SOCIAL_TYPE").Value, GRow.Cells("SUB_TOTAL").Value, "", "", "", "IN")
        Next
    End Sub
    Private Function SaveMedicineReceiptAndPrintReceipt() As Integer
        Return DAClientReceipt.InsertMedReceiptService(EmptyString(TxtReceiptNo.Text), ReceiptUtilityModule.RECEIPT_MED, _
                                                       ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), _
                                                    RadServiceA.Checked), ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), _
                                                    RadServiceB.Checked), ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceC.Checked), False, DateReceipt.Value.Year, GetDateServer.Date, DateReceipt.Value.Date, EmptyString(TxtReceiptAmmount.Text), (EmptyString(TxtReceiptAmmount.Text) / ReceiptUtilityModule.GetExchangeRate), ReceiptUtilityModule.GetExchangeRate, USER_NAME, TxtAmmountInword.Text, TxtClientNo.Text, TxtClientName.Text, TxtClientSex.Text, TxtClientAge.Text, "", "", ReceiptUtilityModule.GetSocialServieType(RadServiceA.Checked, RadServiceB.Checked, RadServiceC.Checked), 0)
    End Function

    Private Sub BGSaveAndPrintReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGSaveAndPrintReceipt.DoWork
        TblNewReceipt = DAClientReceipt.SelectCashByReceiptNo(EmptyString(TxtReceiptNo.Text))
    End Sub

    Private Sub BGSaveAndPrintReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGSaveAndPrintReceipt.RunWorkerCompleted
        DoPrintReceipt()
        LblPrinting.Visible = False
        PicLoading.Visible = False
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub DoPrintReceipt()
        Dim FPrintPreview As New PrintPreviewCashReceipt
        Dim ObjCRVReceipt As New CRMedClientReceipt
        ObjCRVReceipt.SetDataSource(TblNewReceipt)
        FPrintPreview.CrystalReportObject = ObjCRVReceipt
        FPrintPreview.IS_PRINT_OLDRECEIPT = True
        FPrintPreview.ShowDialog()

    End Sub

    Private Sub TxtClientNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClientNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            FindingClientNo()
        End If
    End Sub

    Private Sub RadServiceB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadServiceB.CheckedChanged
        If CboItem.SelectedValue Is Nothing Then Exit Sub
        LoadSocialServiceMedicince(CboItem.SelectedValue)
    End Sub

    Private Sub RadServiceA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadServiceA.CheckedChanged
        If CboItem.SelectedValue Is Nothing Then Exit Sub
        LoadSocialServiceMedicince(CboItem.SelectedValue)
    End Sub

    Private Sub RadServiceC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadServiceC.CheckedChanged
        If CboItem.SelectedValue Is Nothing Then Exit Sub
        LoadSocialServiceMedicince(CboItem.SelectedValue)
    End Sub

    Private Sub TxtServicePrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtServicePrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class