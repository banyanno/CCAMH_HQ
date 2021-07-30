Imports Janus.Windows.GridEX

Public Class UCItemExpiredDate

    Public MTakeoInventory As MainAppKTG
    Dim DTItem As New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim DTItemExpiredDateList As New DSCategoriesAndItemsTableAdapters.VItemExpiredListTableAdapter
    Dim DTCategory As New DSCategoriesAndItemsTableAdapters.tblCategoryTableAdapter
    Dim RptItemExpiredDate As New CrItemExpiredDate

    Dim DA_ExpiredItemByReceived As New DSExpiredByReceivedItemTableAdapters.ViewSumaryItemExpiredTableAdapter
    Public Sub New(ByVal MTakeoInventory As MainAppKTG)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        InitCategory()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub InitCategory()
        With CboCategory
            .DataSource = DTCategory.GetData
            .ValueMember = "CateID"
            .DisplayMember = "CateName"
            .SelectedIndex = -1
        End With
    End Sub


    Private Sub ChBAllItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAllItem.CheckedChanged
        If ChBAllItem.Checked = True Then
            CBItem.Enabled = False
        Else
            CBItem.Enabled = True
        End If
    End Sub


    Private Sub ChBActivePeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBActivePeriod.CheckedChanged
        If ChBActivePeriod.Checked = True Then
            DTPFDate.Enabled = True
            DTPToDate.Enabled = True
        Else
            DTPFDate.Enabled = False
            DTPToDate.Enabled = False
        End If
    End Sub

    Private Sub UCItemExpiredDate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '--- Get list item
        With CBItem
            .DataSource = DTItem.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        MTakeoInventory.StatusLoading(True, "Loading ")
        Application.DoEvents()
        BGWExpiredDate.RunWorkerAsync()
    End Sub

    Private Sub BGWExpiredDate_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGWExpiredDate.DoWork
        MTakeoInventory.StatusLoading(True, "Loading")
        Application.DoEvents()
        Me.ViewData()
    End Sub
    Private Sub BGWExpiredDate_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGWExpiredDate.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False, "")
    End Sub

    Sub ViewData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ViewData))
        Else
            Dim IsViewReport As Integer = ControlPanelDisplay() ' Return 1 (report) , 0 (table)
            If IsViewReport = 1 Then
                Dim DTItemExpiredDate As New DataTable
              
                If ChCategory.Checked = True Then
                    If ChBActivePeriod.Checked = False Then
                        DTItemExpiredDate = DTItemExpiredDateList.GetData
                    Else
                        DTItemExpiredDate = DTItemExpiredDateList.GetItemExpiredDateInPeriod(DTPFDate.Value.Date, DTPToDate.Value.Date)
                    End If
                Else
                    If ChBActivePeriod.Checked = False Then
                        DTItemExpiredDate = DTItemExpiredDateList.GetDataByCategoryID(CboCategory.SelectedValue)
                    Else
                        DTItemExpiredDate = DTItemExpiredDateList.GetDataByCategoryID_With_Period(CboCategory.SelectedValue, DTPFDate.Value.Date, DTPToDate.Value.Date)
                    End If

                End If
                RptItemExpiredDate.SetDataSource(DTItemExpiredDate)
                If ChBActivePeriod.Checked = True Then
                    RptItemExpiredDate.SetParameterValue("fromDate", Format(DTPFDate.Value.Date, "dd/MMM/yyyy"))
                    RptItemExpiredDate.SetParameterValue("toDate", Format(DTPToDate.Value.Date, "dd/MMM/yyyy"))
                Else
                    RptItemExpiredDate.SetParameterValue("fromDate", "")
                    RptItemExpiredDate.SetParameterValue("toDate", "")
                End If
                CRVReportViewer.ReportSource = RptItemExpiredDate
                CRVReportViewer.Refresh()
            Else
                If ChCategory.Checked = True Then
                    If ChBActivePeriod.Checked = False Then
                        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetData
                    Else
                        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetItemExpiredDateInPeriod(DTPFDate.Value.Date, DTPToDate.Value.Date)
                    End If
                Else
                    If ChBActivePeriod.Checked = False Then
                        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetDataByCategoryID(CboCategory.SelectedValue)
                    Else
                        GridItemExpiredDate.DataSource = DTItemExpiredDateList.GetDataByCategoryID_With_Period(CboCategory.SelectedValue, DTPFDate.Value.Date, DTPToDate.Value.Date)
                    End If

                End If

            End If
        End If
    End Sub

    Function ControlPanelDisplay() As Integer
        If RBViewReport.Checked = True Then ' View as report
            SplitContainer2.Panel1Collapsed = True
            SplitContainer2.Panel2Collapsed = False
            Return 1
        Else ' View as table
            SplitContainer2.Panel1Collapsed = False
            SplitContainer2.Panel2Collapsed = True
            Return 0
        End If
    End Function


    Private Sub ChCategory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChCategory.CheckedChanged
        If ChCategory.Checked = True Then
            CboCategory.Enabled = False
        Else
            CboCategory.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheckItemExpiry.Click
        'ControlPanelDisplay()
        MTakeoInventory.StatusLoading(True, "Loading")
        'If ChViewReport.Checked = False Then
        '    'SplitContainer2.Panel1Collapsed = False
        '    'SplitContainer2.Panel2Collapsed = True
        'ElseIf ChViewReport.Checked = True Then
        '    'SplitContainer2.Panel1Collapsed = True
        '    'SplitContainer2.Panel2Collapsed = False
        'End If
        PopulateTableExpiry = False
        DA_ExpiredItemByReceived.RunUpdateReceiveBeforGenerateReport()
        Application.DoEvents()
        BGRunExpirReceive.RunWorkerAsync()


    End Sub
    Dim tblExpireReceive As DataTable = DA_ExpiredItemByReceived.SelectAllExpiry
    Dim PopulateTableExpiry As Boolean = False
    Dim TblGeneratReport As DataTable = DA_ExpiredItemByReceived.SelectAllExpiry
    Private Sub BGRunExpirReceive_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGRunExpirReceive.DoWork
        If PopulateTableExpiry = False Then
            tblExpireReceive = DA_ExpiredItemByReceived.SelectAllExpiry
        ElseIf PopulateTableExpiry = True Then
            checkedRows = GridItemExpiredDate.GetCheckedRows()
            Dim I As Integer = 0
            TblGeneratReport.Clear()
            For Each gRows As Janus.Windows.GridEX.GridEXRow In checkedRows
                Dim ExpiryDRows As DataRow = TblGeneratReport.NewRow()
                ExpiryDRows("RequestDetailID") = gRows.Cells("RequestDetailID").Value
                ExpiryDRows("ItemID") = gRows.Cells("ItemID").Value
                ExpiryDRows("EXPIRE_DATE") = gRows.Cells("EXPIRE_DATE").Value
                ExpiryDRows("UnitsInStock") = gRows.Cells("UnitsInStock").Value
                ExpiryDRows("CateID") = gRows.Cells("CateID").Value
                ExpiryDRows("ItemName") = gRows.Cells("ItemName").Value
                ExpiryDRows("CateName") = gRows.Cells("CateName").Value
                ExpiryDRows("ReceiveDateDetail") = gRows.Cells("ReceiveDateDetail").Value
                ExpiryDRows("StockAlertQty") = gRows.Cells("StockAlertQty").Value
                TblGeneratReport.Rows.Add(ExpiryDRows)
            Next

        End If

    End Sub

    Private Sub BGRunExpirReceive_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGRunExpirReceive.RunWorkerCompleted
        If PopulateTableExpiry = False Then
            GridItemExpiredDate.DataSource = tblExpireReceive
            PopDataExpiry()
        ElseIf PopulateTableExpiry = True Then
            Dim RepExpired As New ReportExpiredDetail
            RepExpired.SetDataSource(TblGeneratReport)
            CRVReportViewer.ReportSource = RepExpired
            RepExpired.SetParameterValue("Title", "Date Check: " & Format(DateReceiveFrom.Value, "dd/MM/yyyy")) '& " To " & Format(DateReceiveTo.Value, "dd/MM/yyyy"))
            RepExpired.SetParameterValue("ValueDateExpiry", DateReceiveFrom.Value.Date)
        End If

        MTakeoInventory.StatusLoading(False, "")
    End Sub

    Private Sub PopDataExpiry()

        For Each GRows As GridEXRow In GridItemExpiredDate.GetRows
            'GridItemExpiredDate.GetRow(
            '  GridItemExpiredDate.SetValue("DateDure", DateReceiveFrom.Value)
            GRows.BeginEdit()
            ' Dim D1 As DateTime = CType(GRows.Cells("ExpiredDateRecItem").Value, Date).Subtract(DateReceiveFrom.Value.Date)
            'Dim D2 As DateTime = DateReceiveFrom.Value.Date
            'Dim DateExpiry As New DateTime(D1.Year, D1.Month, D1.Day)
            'Dim DateDue As New DateTime(D2.Year, D2.Month, D2.Day)

            ' Dim DExpiry As TimeSpan = CType(GRows.Cells("ExpiredDateRecItem").Value, TimeSpan)

            'MessageBox.Show()
            Dim ValueDayLeft As Double = CType(GRows.Cells("EXPIRE_DATE").Value, Date).Subtract(DateReceiveFrom.Value.Date).TotalDays
            GRows.Cells("DateDure").Value = DateReceiveFrom.Value
            GRows.Cells("DayLeft").Value = ValueDayLeft
            GRows.EndEdit()
        Next

    End Sub
   
    Private Sub BtnPrintReport_Click(sender As Object, e As EventArgs) Handles BtnPrintReport.Click
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        checkedRows = GridItemExpiredDate.GetCheckedRows()
        If checkedRows.Length = 0 Then
            MessageBox.Show("Please check at least 1 item generate report.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            'MessageBox.Show(GridDrugReport.GetRows.Count)
            'If GridItemExpiredDate.SelectedItems.Count = 0 Then
            '    MessageBox.Show("You can not save drug audit. Please generate list of drug audit?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            'If MessageBox.Show("Do you want to save drug audit?", "Drug audit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '    MainFormApplicationPublic.StatusLoading(True, "Saving drug audit")
            '    'GridDrugReport.Row = 0
            '    '   DA_DrugAudit.DeleteDrugAudit()  ''DeleteDrugAuditByGeneratdate(Format(DFrom.Value.Date, "dd/MM/yyyy") & "-" & Format(DTo.Value.Date, "dd/MM/yyyy"))
            '    ' GridDrugReport.AllowEdit = False
            '    ' BgSaveDrugAudit.RunWorkerAsync()
            'End If
            MTakeoInventory.StatusLoading(True, "Loading")
            PopulateTableExpiry = True
            DA_ExpiredItemByReceived.RunUpdateReceiveBeforGenerateReport()
            Application.DoEvents()
            BGRunExpirReceive.RunWorkerAsync()
        End If
        'ControlPanelDisplay()
        
    End Sub
End Class
