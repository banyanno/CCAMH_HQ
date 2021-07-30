Public Class FormReceiveMoreExistingItem
    Public ItemName As String
    Public ReqQuantity As String
    Public ItemID As Integer
    Public RequestDetailID As Double

    Dim CurrDataAdapter As DSCategoriesAndItemsTableAdapters.CURRENCYTableAdapter
    Public DTTmpRecItemAtt As DataTable = New DSHospitalRequestToCaritas.REC_ITEM_ATTDataTable
    Public DonationDataAdapter As DSOpticalShopTableAdapters.DONATIONTableAdapter
    Public ProviderDataAdapter As DSVendorsTableAdapters.tblVenderTableAdapter
    Public CaritasReqDetailDataAdapter As DSAddMoreReceiveTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
    Public CaritasItemProvider As DSAddMoreReceiveTableAdapters.CARITAS_REQ_ITEM_PROVIDER_INFOTableAdapter
    Public VendorRepo As IVendorRepository = New VendorRepository
    Dim ItemInfo As New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ItemPrice As New DSItemPriceTableAdapters.tblItemPriceTableAdapter
    Dim DA_ItemBrand As New DSHospitalRequestToCaritasTableAdapters.ITEM_BRANDTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        CurrDataAdapter = New DSCategoriesAndItemsTableAdapters.CURRENCYTableAdapter
        DonationDataAdapter = New DSOpticalShopTableAdapters.DONATIONTableAdapter
        ProviderDataAdapter = New DSVendorsTableAdapters.tblVenderTableAdapter
        CaritasReqDetailDataAdapter = New DSAddMoreReceiveTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
        CaritasItemProvider = New DSAddMoreReceiveTableAdapters.CARITAS_REQ_ITEM_PROVIDER_INFOTableAdapter
        With CbCost
            .DataSource = CurrDataAdapter.GetData
            .ValueMember = "CurrencyID"
            .DisplayMember = "Currency"
            .SelectedIndex = 0
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        With CbDonation
            .DataSource = ProviderDataAdapter.GetDonatorDataList
            .ValueMember = "VenderID"
            .DisplayMember = "VenderName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With CbVendor
            .DataSource = ProviderDataAdapter.GetVendorDataList
            .ValueMember = "VenderID"
            .DisplayMember = "VenderName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        
        CbDonation.Enabled = False
        CbVendor.Enabled = False
        ' Add any initialization after the InitializeComponent() call.
      


        gridProviderDetail.Columns("ProviderID").Visible = False
        gridProviderDetail.Columns("CurrencyID").Visible = False
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub RbVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbVendor.CheckedChanged
        If RbVendor.Checked = True Then
            CbVendor.Enabled = True
            CbDonation.Enabled = False
        Else
            CbVendor.Enabled = False
            CbDonation.Enabled = True
        End If
    End Sub

    Private Sub RbDonator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDonator.CheckedChanged
        If RbDonator.Checked = True Then
            CbVendor.Enabled = False
            CbDonation.Enabled = True
        Else
            CbVendor.Enabled = True
            CbDonation.Enabled = False
        End If
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateTextField(TxtCost, "", ErrorValidation) = False Then Exit Sub
        If ValidateTextField(TxtGivenQty, "", ErrorValidation) = False Then Exit Sub
        If ValidateDateField(DTPRecItemExpired, "", ErrorValidation) = False Then Exit Sub
        If RbDonator.Checked = False And RbVendor.Checked = False Then
            MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If RbDonator.Checked = True Then
            If CbDonation.SelectedValue Is Nothing Then
                MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If RbVendor.Checked = True Then
            If CbVendor.SelectedValue Is Nothing Then
                MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        Dim obj(10) As Object
        Dim ProviderName As String = ""
        Dim ProviderID As Integer = 0
        Dim totalCost As Double = 0
        If RbDonator.Checked = True Then
            ProviderName = CbDonation.Text
            ProviderID = CbDonation.SelectedValue
        End If

        If RbVendor.Checked = True Then
            ProviderName = CbVendor.Text
            ProviderID = CbVendor.SelectedValue
        End If

        totalCost = Val(TxtCost.Text) * Val(TxtGivenQty.Text)

        With gridProviderDetail
            obj(0) = ProviderName
            obj(1) = TxtGivenQty.Text
            obj(2) = TxtCost.Text
            obj(3) = CbCost.Text
            obj(4) = totalCost
            obj(5) = ProviderID
            obj(6) = CbCost.SelectedValue
            If DTPRecItemExpired.Checked = True Then
                'obj(7) = Format(DTPRecItemExpired.Value.Date, "dd/MM/yyyy")
                obj(7) = DTPRecItemExpired.Value.Date 'Format(DTPRecItemExpired.Value.Date, "dd/MM/yyyy")
            Else
                obj(7) = Nothing
            End If
            obj(8) = TxtReceiveAtributeNote.Text
            obj(9) = CboBrandName.Text
            obj(10) = TxtBatchNo.Text
            If gridProviderDetail.Rows.Count = 0 Then
                gridProviderDetail.Rows.Add(obj)
                TxtRecQuantity.Text = Val(TxtRecQuantity.Text) + Val(TxtGivenQty.Text)
                CleanFormReceived()
            Else
                If IsDupValidateProvider(obj, ProviderID, DTPRecItemExpired.Value.Date) = False Then
                    gridProviderDetail.Rows.Add(obj)
                    TxtRecQuantity.Text = Val(TxtRecQuantity.Text) + Val(TxtGivenQty.Text)
                    CleanFormReceived()
                Else
                    MessageBox.Show("Item's provider already Exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With
    End Sub
    Function IsDupValidateProvider(ByVal pObj() As Object, ByVal pProviderID As Integer, ByVal dateExpire As Date) As Boolean

        Dim IsExist As Boolean = False
        With gridProviderDetail
            For Each rRow As DataGridViewRow In .Rows
                If rRow.Cells("ProviderID").Value = pProviderID And rRow.Cells("ExpiredDate").Value = dateExpire Then
                    IsExist = True
                    Exit For
                    'Else
                    '    IsExist = False
                End If
            Next
        End With

        Return IsExist

    End Function
    Private Sub CleanFormReceived()
        RbVendor.Checked = False
        RbDonator.Checked = False
        CbDonation.SelectedIndex = -1
        CbVendor.SelectedIndex = -1
        TxtGivenQty.Text = ""
        TxtCost.Text = ""
        TxtReceiveAtributeNote.Text = ""
        CboBrandName.SelectedIndex = 1
        TxtBatchNo.Text = ""
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        With gridProviderDetail
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete selected provider ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    'TxtRecQuantity.Text = Val(TxtRecQuantity.Text) - Val(rRow.Cells("GivenQty").Value)
                    .Rows.Remove(rRow)
                End If
            Next
        End With
    End Sub

    Private Sub TxtGivenQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGivenQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'add more item to request item detial
        If ValidateCombobox(CboItemList, "", ErrorValidation) = False Then Exit Sub
        If gridProviderDetail.RowCount <= 0 Then
            MessageBox.Show("Can not save. please add one or more item receive detial!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            CaritasReqDetailDataAdapter.InsertNewIDRequestDetial(LblRequestID.Text, CInt(CboItemList.SelectedValue), 0, TxtRecQuantity.Text, TxtRecQuantity.Text, 0, 0, 0, CboItemList.Text, Now.Date, LblBarCode.Text, True, False, Now.Date, "", TxtAddMorenote.Text, CboBrandName.Text, TxtBatchNo.Text)
            Dim RequestDetailID = CaritasReqDetailDataAdapter.GetLastIDRequestDetial
            ' Save item provider detail with expire date ................
            With gridProviderDetail
                For Each rRow As DataGridViewRow In .Rows

                    CaritasItemProvider.InsertNewReceiveAttributeDetail(RequestDetailID, CInt(CboItemList.SelectedValue), Val(rRow.Cells("ProviderID").Value), rRow.Cells("ProviderName").Value, Val(rRow.Cells("GivenQty").Value), 0, 1, 1, 0, rRow.Cells("ExpiredDate").Value, rRow.Cells("ReceiveAtributeNote").Value, rRow.Cells("BrandName").Value, rRow.Cells("BatchNo").Value)

                Next
            End With
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End If
       
    End Sub

    Private Sub FormReceiveMoreExistingItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With CboItemList
            .DataSource = CaritasReqDetailDataAdapter.SelectItemByRequestID(LblRequestID.Text)
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
        With CboBrandName
            .DataSource = DA_ItemBrand.GetData
            .ValueMember = "BRAND_ID"
            .DisplayMember = "BRAND_NAME"
            .SelectedIndex = -1
        End With
    End Sub
End Class