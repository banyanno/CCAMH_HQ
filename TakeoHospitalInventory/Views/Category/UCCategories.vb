Imports System.Data.Common
Imports Janus.Windows.GridEX

Public Class UCCategories

    Dim ItemDataAdapter As DSCategoriesAndItemsTableAdapters.tblItemTableAdapter
    Dim ItemDataByCateIDAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ItemChemicalDataAdapter As DSCategoriesAndItemsTableAdapters.VItemChemicalDetailTableAdapter
    Dim CateRepo As ICategoryRepository = New CategoryRepository
    Dim cateTVFristChildName As String
    Dim ItemTableTemplate As DataTable
    Private THIDataContext As New BaseDataContext
    Dim ItemPriceDataAdapter As DSItemPriceTableAdapters.tblItemPriceTableAdapter
    Dim ItemExpireDetial As New DSItemPriceTableAdapters.ViewExpireDateDetialTableAdapter
    'Dim MTakeoInventory As MainTakeoInventory
    Dim MScreening As MainAppKTG
    Dim ItemReqTransaction As DSHospitalRequestToCaritasTableAdapters.V_ITEM_REQ_TRANSTableAdapter
    Dim ItemProviderDataAdapter As DSCategoriesAndItemsTableAdapters.V_ITEM_PROVIDERTableAdapter


    Private Sub UCCategories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'RefreshCategoryTV()
        'With CboSearchItem
        '    .DataSource = ItemDataByCateIDAdapter.GetData
        '    .DisplayMember = "ItemName"
        '    .ValueMember = "ItemID"
        '    .AutoCompleteMode = AutoCompleteMode.Suggest
        '    .AutoCompleteSource = AutoCompleteSource.ListItems
        '    .SelectedIndex = -1
        'End With
        'frmSubMain.StatusLoading(True)
        Application.DoEvents()
        BgLoadingCategories.RunWorkerAsync()
    End Sub
    Public Sub BindIntoDataGrid(ByVal pCateID)
        gridItems.DataSource = ItemDataByCateIDAdapter.GetItemDataByCateID(pCateID)
    End Sub

    Public Sub New(ByVal MTakeoInventory1 As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'Me.MTakeoInventory = MTakeoInventory1
        ItemDataAdapter = New DSCategoriesAndItemsTableAdapters.tblItemTableAdapter
        ItemDataByCateIDAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ItemPriceDataAdapter = New DSItemPriceTableAdapters.tblItemPriceTableAdapter
        ItemChemicalDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemChemicalDetailTableAdapter

        ItemReqTransaction = New DSHospitalRequestToCaritasTableAdapters.V_ITEM_REQ_TRANSTableAdapter
        ItemProviderDataAdapter = New DSCategoriesAndItemsTableAdapters.V_ITEM_PROVIDERTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New(ByVal MScreening As MainAppKTG)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MScreening = MScreening
        ItemDataAdapter = New DSCategoriesAndItemsTableAdapters.tblItemTableAdapter
        ItemDataByCateIDAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ItemPriceDataAdapter = New DSItemPriceTableAdapters.tblItemPriceTableAdapter
        ItemChemicalDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemChemicalDetailTableAdapter

        ItemReqTransaction = New DSHospitalRequestToCaritasTableAdapters.V_ITEM_REQ_TRANSTableAdapter
        ItemProviderDataAdapter = New DSCategoriesAndItemsTableAdapters.V_ITEM_PROVIDERTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    


    Public Sub RefreshCategoryTV()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf RefreshCategoryTV))
        Else
            Dim myCateRepo As ICategoryRepository = New CategoryRepository
            'Display data category TreeView
            TVCategories.Nodes.Clear()
            TVCategories.ImageList = ImageListCate
            TVCategories.Nodes.Add(New TreeNode("CCAMH-Inventory"))
            Dim tNode As New TreeNode
            tNode = TVCategories.Nodes(0)

            myCateRepo.PopulateTreeView(0, tNode)
            tNode.Expand()
            'Select fist node prevent user attempt to create new category without select on tree view node
            tNode.TreeView.SelectedNode = tNode.FirstNode
            tNode.TreeView.Focus()
        End If
       

    End Sub
    Private Sub TVCategories_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVCategories.AfterSelect
        Try
            'Dim cateID As Integer
            'Get selected TreeView node
            MScreening.StatusLoading(True, "Loading")
            Application.DoEvents()
            BgAfterTVSelected.RunWorkerAsync()
        Catch ex As Exception
        End Try            
    End Sub
    Sub ViewDataAfterTVSelected()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ViewDataAfterTVSelected))
        Else
            Dim tNode As New TreeNode
            tNode = TVCategories.SelectedNode
            If tNode.Text = "CCAMH-Inventory" Then
                gridItems.DataSource = ItemDataByCateIDAdapter.GetData
            Else
                gridItems.DataSource = ItemDataByCateIDAdapter.GetItemDataByCateID(CInt(tNode.Tag))
                lblCateName.Text = "Items in " & tNode.Text & " Category."
            End If
        End If
    End Sub
    Private Sub BgLoadingDepartment_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingCategories.DoWork
        RefreshCategoryTV()
        'ItemTableTemplate = ItemDataByCateIDAdapter.GetItemDataByCateID(CateRepo.GetCateIDByCateName("Default Category"))
    End Sub

    Private Sub BgLoadingDepartment_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingCategories.RunWorkerCompleted
        'gridItems.DataSource = ItemTableTemplate
        MScreening.StatusLoading(False, "")
    End Sub

    Private Sub menuRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'BgLoadingCategories.RunWorkerAsync()
    End Sub

  
   
    Dim ImageStream As System.IO.MemoryStream
    Private Sub gridItems_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridItems.SelectionChanged

        RefreshGridItemInfo()

    End Sub

  

    Private Sub RadBarcodNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBarcodNo.CheckedChanged
        TxtBarcodeNo.Enabled = True
        TxtBarcodeNo.Text = ""

        TxtItemName.Text = ""
        TxtItemName.Enabled = False
        

    End Sub

    Private Sub RadItemName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadItemName.CheckedChanged
        TxtBarcodeNo.Enabled = False
        TxtBarcodeNo.Text = ""
        
        TxtItemName.Enabled = True
    End Sub

    Private Sub TxtBarcodeNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarcodeNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridItems.DataSource = ItemDataByCateIDAdapter.GetDataByBarcode(TxtBarcodeNo.Text)
        End If
    End Sub

    Private Sub TxtBarcodeNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBarcodeNo.TextChanged
        gridItems.DataSource = ItemDataByCateIDAdapter.GetDataByBarcode(TxtBarcodeNo.Text)
    End Sub

  


    
    Dim IsItemDetial As Boolean = False
  

    Private Sub NewCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCategoryToolStripMenuItem.Click
        Dim FCategory As New frmCategory(Me)
        'Get selected TreeView node
        Dim tNode As New TreeNode
        tNode = TVCategories.SelectedNode
        FCategory.cateID = CInt(tNode.Tag)

        'In case that user select node text equal TakeoStockInventory implement function create new main category
        If tNode.Text = "TakeoStockInventory" Then
            FCategory.isCreateMainCate = True
        End If
        If FCategory.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RefreshCategoryTV()
            FCategory.Close()
            FCategory.Dispose()
        End If
    End Sub

    Private Sub NewItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewItemToolStripMenuItem.Click
        Dim FItem As New frmItem(Me)
        'Get selected TreeView node
        Dim tNode As New TreeNode
        tNode = TVCategories.SelectedNode
        FItem.cateID = CInt(tNode.Tag)
        If FItem.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RefreshCategoryTV()
            FItem.Close()
            FItem.Dispose()
        End If
    End Sub




    Private Sub BgAfterTVSelected_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgAfterTVSelected.DoWork
        MScreening.StatusLoading(True, "Loading...")
        Application.DoEvents()
        Me.ViewDataAfterTVSelected()
    End Sub

    Private Sub BgAfterTVSelected_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgAfterTVSelected.RunWorkerCompleted
        MScreening.StatusLoading(False, "")
    End Sub

    Sub RefreshGridItemInfo()
        Try
            'gridItems.WatermarkImage.Image = gridItems.SelectedItems(0).GetRow.Cells("Picture").Value
            GridExpireDetail.DataSource = ItemExpireDetial.SelectExpireByItemID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
            gridItemPrice.DataSource = ItemPriceDataAdapter.GetItemPriceDataByItemID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
            ' gridItemChemical.DataSource = ItemChemicalDataAdapter.GetItemChemicalDataByItemID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
            gridItemRecTrans.DataSource = ItemReqTransaction.GetRecItemTransByItemID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
            gridItemProvider.DataSource = ItemProviderDataAdapter.GetItemProviderByID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))

            'ImageStream = New System.IO.MemoryStream(CType(gridItems.SelectedItems(0).GetRow.Cells("Picture").Value, Byte()))
            PicItem.Image = gridItems.SelectedItems(0).GetRow.Cells("Picture").Value ' Image.FromStream(ImageStream)

        Catch ex As Exception
            'gridItemChemical.DataSource = Nothing
            gridItemPrice.DataSource = Nothing
            gridItemRecTrans.DataSource = Nothing
            PicItem.Image = Nothing
        End Try
    End Sub
    
    'Private Sub BtnRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    RefreshGridItemInfo()
    'End Sub


    Private Sub TxtItemName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemName.TextChanged

        Try
            gridItems.DataSource = ItemDataByCateIDAdapter.GetItemDatafilterByItemName("%" & TxtItemName.Text & "%")
        Catch ex As Exception

        End Try

    End Sub

    



    Private Sub TBNewPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBNewPrice.Click
        If Not gridItems.CurrentRow Is Nothing AndAlso gridItems.CurrentRow.RowType = RowType.Record Then

            Dim FItemPrice As New frmItemPrice
            FItemPrice.myItemID = Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value)
            FItemPrice.myItemName = gridItems.SelectedItems(0).GetRow.Cells("ItemName").Value
            FItemPrice.myBarcode = gridItems.SelectedItems(0).GetRow.Cells("Barcode").Value
            If FItemPrice.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                gridItemPrice.DataSource = ItemPriceDataAdapter.GetItemPriceDataByItemID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
            End If
        End If
    End Sub

    Private Sub BtnEditPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditPrice.Click
        'If Not gridItemPrice.CurrentRow Is Nothing AndAlso gridItemPrice.CurrentRow.RowType = RowType.Record Then

        '    Dim FItemPrice As New frmItemPrice

        '    FItemPrice.myItemID = Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value)
        '    FItemPrice.myItemName = gridItems.SelectedItems(0).GetRow.Cells("ItemName").Value
        '    FItemPrice.myBarcode = gridItems.SelectedItems(0).GetRow.Cells("Barcode").Value
        '    FItemPrice.lblSaveOption.Text = "1"
        '    FItemPrice.myItemPriceID = Val(gridItemPrice.SelectedItems(0).GetRow.Cells("ItemPriceID").Value)

        '    If FItemPrice.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        gridItemPrice.DataSource = ItemPriceDataAdapter.GetItemPriceDataByItemID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
        '    End If

        'End If
        If gridItems.SelectedItems.Count = 0 Then Exit Sub
        Dim FDrugPrice As New FormNewDrugPrice
        FDrugPrice.TxtMedicinceName.Text = gridItems.GetRow.Cells("ItemName").Value
        FDrugPrice.LblSaveMedic.Text = gridItemPrice.GetRow.Cells("ItemPriceID").Value
        FDrugPrice.TxtServiceMedA.Text = gridItemPrice.GetRow.Cells("PriceA").Value
        FDrugPrice.TxtServiceMedB.Text = gridItemPrice.GetRow.Cells("PriceB").Value
        FDrugPrice.TxtServiceMedC.Text = gridItemPrice.GetRow.Cells("PriceC").Value
        If FDrugPrice.ShowDialog() = DialogResult.OK Then
            gridItemPrice.DataSource = ItemPriceDataAdapter.GetItemPriceDataByItemID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
        End If
    End Sub

    Private Sub TBSetCurPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSetCurPrice.Click
        If Not gridItemPrice.CurrentRow Is Nothing AndAlso gridItemPrice.CurrentRow.RowType = RowType.Record Then
            If MessageBox.Show("Do you want save selected price use as current item price ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans
                Try
                    THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblItemPrice SET IsCurPrice={0} where ItemID={1}", 0, Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
                    Dim myItemPriceID As Integer = Val(gridItemPrice.SelectedItems(0).GetRow.Cells("ItemPriceID").Value)
                    THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblItemPrice SET IsCurPrice={0} where ItemPriceID={1}", 1, myItemPriceID)

                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    trans.Rollback()
                    THIDataContext.getTHIDataContext.Connection.Close()
                    MsgBox("Error :" + ex.Message)
                    Exit Sub
                Finally
                    trans = Nothing
                End Try
                MessageBox.Show("Save Update Current item price successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGridItemInfo()
            End If
        End If
    End Sub

    Private Sub TBCurrentPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBCurrentPrice.Click
        Try
            gridItemPrice.DataSource = ItemPriceDataAdapter.GetCurItemPriceDataByItemID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gridItemRecTrans_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles gridItemRecTrans.RowDoubleClick
        Dim ECost As New EditCost
        ECost.lblSaveOption.Text = gridItemRecTrans.GetRow.Cells("ProviderInfoID").Value
        ECost.txtBarcode.Text = gridItems.GetRow.Cells("Barcode").Value
        ECost.TxtItemName.Text = gridItems.GetRow.Cells("ItemName").Value
        ECost.TxtQTY.Text = gridItemRecTrans.GetRow.Cells("GivenQty").Value
        ECost.TxtOldCost.Text = gridItemRecTrans.GetRow.Cells("Cost").Value
        ECost.txtNewCost.Text = "0"
        ECost.TxtOldTotalCost.Text = gridItemRecTrans.GetRow.Cells("TotalCost").Value
        If ECost.ShowDialog() = DialogResult.OK Then
            gridItemRecTrans.DataSource = ItemReqTransaction.GetRecItemTransByItemID(Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
        End If
    End Sub

   
    
   

    Private Sub GridExpireDetail_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridExpireDetail.RowDoubleClick
        Dim FEditItemExpire As New EditeItemExpire
        FEditItemExpire.LblExpireID.Text = GridExpireDetail.GetRow.Cells("InventoryID").Value
        FEditItemExpire.LblItemName.Text = GridExpireDetail.GetRow.Cells("ItemName").Value
        FEditItemExpire.TxtQTY.Text = GridExpireDetail.GetRow.Cells("UnitsInStock").Value
        FEditItemExpire.DateExired.Value = GridExpireDetail.GetRow.Cells("EXPIRE_DATE").Value
        If FEditItemExpire.ShowDialog = DialogResult.OK Then
            GridExpireDetail.DataSource = ItemExpireDetial.SelectExpireByItemID(gridItems.GetRow.Cells("ItemID").Value)
            'Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value))
        End If
    End Sub

    Private Sub BtnNewCategory1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCategory1.Click

        Dim FCategory As New frmCategory(Me)
        'Get selected TreeView node
        Dim tNode As New TreeNode
        tNode = TVCategories.SelectedNode
        FCategory.cateID = CInt(tNode.Tag)

        'In case that user select node text equal TakeoStockInventory implement function create new main category
        If tNode.Text = "TakeoStockInventory" Then
            FCategory.isCreateMainCate = True
        End If
        If FCategory.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RefreshCategoryTV()
            FCategory.Close()
            FCategory.Dispose()
        End If
    End Sub

    Private Sub BtnNewItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewItem1.Click
        Dim FItem As New frmItem(Me)
        'Get selected TreeView node
        Dim tNode As New TreeNode
        tNode = TVCategories.SelectedNode
        FItem.cateID = CInt(tNode.Tag)
        If FItem.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RefreshCategoryTV()
            FItem.Close()
            FItem.Dispose()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not gridItems.CurrentRow Is Nothing AndAlso gridItems.CurrentRow.RowType = RowType.Record Then

            Dim FItemProviderInfo As New frmItemProviderInfo
            FItemProviderInfo.myitemID = Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value)
            FItemProviderInfo.myitemName = gridItems.SelectedItems(0).GetRow.Cells("ItemName").Value
            FItemProviderInfo.myBarcode = gridItems.SelectedItems(0).GetRow.Cells("Barcode").Value
            FItemProviderInfo.lblSaveOption.Text = "1"

            If FItemProviderInfo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            End If

        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        Dim FCategory As New frmCategory(Me)
        'Get selected TreeView node
        Dim tNode As New TreeNode
        tNode = TVCategories.SelectedNode
        FCategory.cateID = CInt(tNode.Tag)
        FCategory.lblSaveOption.Text = "1"

        If FCategory.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RefreshCategoryTV()
            FCategory.Close()
            FCategory.Dispose()
        End If
    End Sub

    Private Sub BtnEditItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditItem1.Click

        If Not gridItems.CurrentRow Is Nothing AndAlso gridItems.CurrentRow.RowType = RowType.Record Then

            Dim FItem As New frmItem(Me)
            FItem.lblSaveOption.Text = "1"
            FItem.myItemID = CInt(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value)
            FItem.myBarcode = gridItems.SelectedItems(0).GetRow.Cells("Barcode").Value
            FItem.myCateID = CInt(gridItems.SelectedItems(0).GetRow.Cells("CateID").Value)

            If FItem.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RefreshCategoryTV()
                FItem.Close()
                FItem.Dispose()
            End If
        End If
    End Sub

    Private Sub BtnDelete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete1.Click
        Dim tNode As New TreeNode
        Dim myNodeTag As Integer
        Dim myCate As New tblCategory
        Dim TransMsgStatus As String = ""
        Dim myCateRepo As ICategoryRepository = New CategoryRepository

        tNode = TVCategories.SelectedNode

        myNodeTag = CInt(tNode.Tag)

        '--- Prevent user delete Default Category
        If myNodeTag = 0 Then 'Or myNodeTag = 6 Then
            MsgBox("You cannot delete this category because it is a system category, not a item category.")
        Else
            If CateRepo.isCateHasSubCate(myNodeTag) Then 'Cannot delete category that have sub category inside
                MsgBox("You cannot delete categories which have subcategories.")
            Else

                myCate = myCateRepo.GetCateByID(myNodeTag)
                '--- validation delete category contents item.
                If myCate.ItemCount > 0 Then
                    MessageBox.Show("Cannot delete category contents item inside.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If MessageBox.Show("Are you sure to delete " & tNode.Text & "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans
                    '*** If delete main category move items to default category
                    If myCate.ParentID = 0 Then
                        'MsgBox("Items in this category will be moved to Default Category.")
                        Try
                            '** Move items in category attempt to delete to default category
                            THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblItem SET CateID={0} where CateID={1}", 6, myNodeTag)
                            '===
                            '** Update Itemcount of default category
                            THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblCategory SET ItemCount={0} where CateID= 6", myCate.ItemCount + CateRepo.GetItemCountByCateID(6))
                            '===
                            '** Delete main category
                            THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblCategory WHERE CateID={0}", myCate.CateID)
                            '===
                            trans.Commit()
                            THIDataContext.getTHIDataContext.Connection.Close()
                        Catch ex As Exception
                            TransMsgStatus = ex.Message
                            trans.Rollback()
                            THIDataContext.getTHIDataContext.Connection.Close()
                        End Try
                    Else 'Delete category and move items inside category to there main category (6) ( Msg : Items in this category will be moved to category ...)

                        Try
                            '** Move items in category attempt to delete to main category
                            THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblItem SET CateID={0} where CateID={1}", myCate.ParentID, myNodeTag)
                            '===

                            '** Update Itemcount of default category
                            THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblCategory SET ItemCount={0} where CateID= {1}", myCate.ItemCount + CateRepo.GetItemCountByCateID(myCate.ParentID), myCate.ParentID)
                            '===

                            '** Delete main category
                            THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblCategory WHERE CateID={0}", myNodeTag)
                            '===

                            trans.Commit()
                            THIDataContext.getTHIDataContext.Connection.Close()
                        Catch ex As Exception
                            TransMsgStatus = ex.Message
                            trans.Rollback()
                            THIDataContext.getTHIDataContext.Connection.Close()
                        End Try
                    End If
                End If
            End If
        End If
        RefreshCategoryTV()
    End Sub

 

    Private Sub BtnRefreshData2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RefreshGridItemInfo()
    End Sub

    Private Sub BtnAjustStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjustStock.Click

        '--- gridItems
        Dim FAdjustStock As New AdjustStockMainStock
        If Not gridItems.CurrentRow Is Nothing AndAlso gridItems.CurrentRow.RowType = RowType.Record Then

            FAdjustStock.isAdjustExistItem = True
            FAdjustStock.adjustItemID = Val(gridItems.SelectedItems(0).GetRow.Cells("ItemID").Value)
            FAdjustStock.adjustItemName = gridItems.SelectedItems(0).GetRow.Cells("ItemName").Value

            If IsDBNull(gridItems.SelectedItems(0).GetRow.Cells("Barcode").Value) = False Then
                FAdjustStock.adjustBarcode = gridItems.SelectedItems(0).GetRow.Cells("Barcode").Value
            End If

            If FAdjustStock.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'gridDepartItems.DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
            End If
        Else
            MessageBox.Show("Please select item in the list that you want to Adjust.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        '--- Update 29 12 2011
        'Dim FAdjustStock As New frmAdjustStock
        'If FAdjustStock.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    'gridDepartItems.DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
        'End If
    End Sub

    Private Sub BtnPrintItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintItem1.Click
        '---- print request order ----------
        MScreening.StatusLoading(True, "Loading")
        Application.DoEvents()
        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.ReportOption = 3
        MScreening.StatusLoading(False, "")

        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub PrintItemsInCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintItemsInCategoryToolStripMenuItem.Click
        MScreening.StatusLoading(True, "Loading")
        Application.DoEvents()
        Dim tNode As New TreeNode
        Dim myNodeTag As Integer

        tNode = TVCategories.SelectedNode
        myNodeTag = CInt(tNode.Tag)

        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.ReportOption = 4
        FRptRequestView.CateID = myNodeTag ' Pass CateID value
        MScreening.StatusLoading(False, "")
        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub PrintItemsAlertQuantityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintItemsAlertQuantityToolStripMenuItem.Click
        '---- print request order ----------
        MScreening.StatusLoading(True, "Loading")
        Application.DoEvents()
        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.ReportOption = 10
        MScreening.StatusLoading(False, "")
        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub PrintItemsAlertExpiredToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintItemsAlertExpiredToolStripMenuItem.Click
        '---- print request order ----------
        MScreening.StatusLoading(True, "Loading...")
        Application.DoEvents()
        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.ReportOption = 11
        MScreening.StatusLoading(False, "")
        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub BtnViewDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewDetail.Click
        If IsItemDetial = False Then
            SplitContainer2.Panel2Collapsed = False
            IsItemDetial = True
        Else
            SplitContainer2.Panel2Collapsed = True
            IsItemDetial = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        BgLoadingCategories.RunWorkerAsync()
    End Sub

    Private Sub BtnItemAttribute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemAttribute.Click
        Dim FMainFormAttribue As New MainFormAttribute
        FMainFormAttribue.ShowDialog()
    End Sub

    Private Sub BtnBrand_Click(sender As Object, e As EventArgs) Handles BtnBrand.Click
        Dim FBrand As New FormBrand
        FBrand.ShowDialog()
    End Sub
End Class
