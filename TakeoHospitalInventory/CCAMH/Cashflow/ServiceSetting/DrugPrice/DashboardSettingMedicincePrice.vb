Public Class DashboardSettingMedicincePrice
    Dim MainKTG As MainAppKTG
    Dim DA_DrugPrice As New DSDrugPriceSettingTableAdapters.CCAMH_VIEW_DRUG_PRICETableAdapter
    Dim TblDrugPrice As DataTable
    Sub New(ByVal MainKTG As MainAppKTG)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainKTG = MainKTG
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnNewPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewPrice.Click
        If GridDrugPrice.SelectedItems.Count = 0 Then Exit Sub
        Dim FDrugPrice As New FormNewDrugPrice
        FDrugPrice.TxtMedicinceName.Text = GridDrugPrice.GetRow.Cells("ItemName").Value
        FDrugPrice.LblSaveMedic.Text = GridDrugPrice.GetRow.Cells("ItemPriceID").Value
        FDrugPrice.TxtServiceMedA.Text = GridDrugPrice.GetRow.Cells("PriceA").Value
        FDrugPrice.TxtServiceMedB.Text = GridDrugPrice.GetRow.Cells("PriceB").Value
        FDrugPrice.TxtServiceMedC.Text = GridDrugPrice.GetRow.Cells("PriceC").Value
        If FDrugPrice.ShowDialog() = DialogResult.OK Then
            RefreshItemPriceByID(FDrugPrice.LblSaveMedic.Text)
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshItemPrice()
    End Sub
    Private Sub RefreshItemPrice()
        GridDrugPrice.DataSource = DA_DrugPrice.GetData
    End Sub
    Private Sub RefreshItemPriceByID(ByVal ItemPriceID As Double)
        GridDrugPrice.DataSource = DA_DrugPrice.SelectByItemPriceID(ItemPriceID)
    End Sub
    Private Sub FindItemByName(ByVal DrugName As String)
        GridDrugPrice.DataSource = DA_DrugPrice.SelectByName(DrugName)
    End Sub
    Private Sub TxtFindByName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFindByName.KeyUp
        FindItemByName(TxtFindByName.Text)
    End Sub

    Private Sub DashboardSettingMedicincePrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtFindByName.Select()
        TxtFindByName.Focus()
        TxtFindByName.SelectAll()
        RefreshItemPrice()
    End Sub

    Private Sub BtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReport.Click
        MainKTG.StatusLoading(True, "Printing")
        BgLoadingReport.RunWorkerAsync()
    End Sub

    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        TblDrugPrice = DA_DrugPrice.GetData
    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        Dim FPrintPreviedw As New PrintPreviewCashReceipt
        FPrintPreviedw.IS_PRINT_DRUGPRICE = True
        Dim CrObject As New CrvDrugPrice
        CrObject.SetDataSource(TblDrugPrice)
        'CrObject.SetParameterValue("DateToDate", "From:" & DContFrom.Value.Date & " To:" & DContTo.Value.Date)
        FPrintPreviedw.CrystalReportObject = CrObject
        FPrintPreviedw.ShowDialog()
        MainKTG.StatusLoading(False, "")
    End Sub
    Private Sub DoPrint()

    End Sub

    Private Sub GridDrugPrice_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDrugPrice.RowDoubleClick
        BtnNewPrice_Click(sender, e)
    End Sub
End Class
