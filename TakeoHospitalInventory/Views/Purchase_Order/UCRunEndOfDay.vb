Imports System.Data.Common
Imports Janus.Windows.GridEX

Public Class UCRunEndOfDay
    Dim MScreening As MainAppKTG
    Dim ItemInDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim MainStockItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim EndofDayRunDataAdapter As DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
    Dim DepartDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Private THIDataContext As New BaseDataContext
    Dim EndofDayRepo As IEndofDayRepository = New EndofDayRepository
    Dim VEODAccessRightDA As DSUserManagementTableAdapters.VEODAccessRightTableAdapter
    Dim MTakeoInventory As MainTakeoInventory


    Dim DA_Request As New DSEODTableAdapters.tblRequestTableAdapter
    Dim DA_Req_Detail As New DSEODTableAdapters.tblRequestDetailTableAdapter
    Dim DA_Received As New DSEODTableAdapters.tblReceivedTableAdapter
    Dim DA_Received_detail As New DSEODTableAdapters.tblReceivedDetailTableAdapter
    Dim DA_Used As New DSEODTableAdapters.tblUsedTableAdapter
    Dim DA_UsedDetail As New DSEODTableAdapters.tblUsedDetailTableAdapter
    Dim DA_AdjustHis As New DSEODTableAdapters.tblAdjustStockHistoryTableAdapter
    Dim DA_Req_Caritas As New DSEODTableAdapters.CARITAS_REQUEST_INVENTORYTableAdapter
    Dim DA_Req_Carit_Detail As New DSEODTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
    Dim DA_EODRun As New DSEODTableAdapters.tblEndofDayRunTableAdapter
    Dim DA_EODStatus As New DSEODTableAdapters.tblEndofDayRunStatusTableAdapter

    '========
    Dim DA_BeginingTract As New DSEODTableAdapters.tblBeginBalanceTraceTableAdapter
    Dim DA_DepStock As New DSEODTableAdapters.tblDeptStockTableAdapter
    Dim DA_MainStock As New DSEODTableAdapters.tblCentralInventoryTableAdapter

    Public Sub New(ByVal MTakeoInventory As MainTakeoInventory)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        EndofDayRunDataAdapter = New DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        ItemInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        MainStockItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        VEODAccessRightDA = New DSUserManagementTableAdapters.VEODAccessRightTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New(ByVal MScreening As MainAppKTG)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MScreening = MScreening
        EndofDayRunDataAdapter = New DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        ItemInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        MainStockItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        VEODAccessRightDA = New DSUserManagementTableAdapters.VEODAccessRightTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCRunEndOfDay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Initial combo department
        With cbDepart
            '.DataSource = DepartDataAdapter.GetDepartDataByDepartID(CInt(DEPART_ID))
            .DataSource = VEODAccessRightDA.GetEODAccessRightByUserID(CInt(USER_ID)) '-- Get department list available for user run EOD
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With cbDepartS
            '.DataSource = DepartDataAdapter.GetDepartDataByDepartID(CInt(DEPART_ID))
            .DataSource = DepartDataAdapter.GetData '-- Get department list available for user run EOD
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(GetDateServer.Date, GetDateServer.Date)
        'RunEndofDayStatus(REDCalendar.SelectionEnd.Date)

        '------- Activate Combo Department ------
        cbDepart.Enabled = Not (ChBAll.Checked)
        cbDepartS.Enabled = Not (ChBAllS.Checked)
        SplitContainer1.SplitterDistance = Me.Height / 3

    End Sub

    Private Sub BtnProcessEndOfDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcessEndOfDay.Click

        If MessageBox.Show("Do you want process run end of day ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            MTakeoInventory.StatusLoading(True)
            Application.DoEvents()
            If BgLoadingRunEOD.IsBusy = True Then
                BgLoadingRunEOD.CancelAsync()
            Else
                BgLoadingRunEOD.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        If ChBAllS.Checked = False Then
            If ValidateCombobox(cbDepartS, "", ErrorEOD) = False Then Exit Sub

            Try
                Dim myDepartID As Integer = cbDepartS.SelectedValue
                Dim fromDate As Date = dptFromDate.Value.Date
                Dim toDate As Date = dptToDate.Value.Date

                gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllItemEndofDaySearch(myDepartID, fromDate, toDate)
            Catch ex As Exception

            End Try
        Else
            Try
                Dim fromDate As Date = dptFromDate.Value.Date
                Dim toDate As Date = dptToDate.Value.Date
                gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(fromDate, toDate)
            Catch ex As Exception

            End Try
        End If

    End Sub

    'Private Sub REDCalendar_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)
    '    RunEndofDayStatus(REDCalendar.SelectionStart.Date)
    'End Sub

    Sub RunEndofDayStatus(ByVal pDate As Date)
        If EndofDayRepo.IsRunEndofDayInParticularDay(CInt(DEPART_ID), pDate) = False Then
            LbNotYet.Visible = True
            LbReady.Visible = False
        Else
            LbNotYet.Visible = False
            LbReady.Visible = True
        End If
    End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        If ValidateCombobox(cbDepartS, "", ErrorEOD) = False Then Exit Sub

        Dim FRptRequestView As New frmReportViewer

        '  FRptRequestView.ReportOption = 9
        FRptRequestView.ReportOption = 16
        FRptRequestView.FDate = dptFromDate.Value.Date
        FRptRequestView.TDate = dptToDate.Value.Date
        FRptRequestView.DepartID = cbDepartS.SelectedValue
        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub BgLoadingRunEOD_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingRunEOD.DoWork

        Try
            MenuReceivedAll.Enabled = False
        Catch ex As Exception

        End Try
        Try
            MenuReadyInOT.Enabled = False
        Catch ex As Exception

        End Try

        RubEndOfDay()
    End Sub
    Friend Sub RerunBeginingBalanceItemQTY(DateRunEDO As Date)
        Dim DateServer As Date = DateRunEDO.Date
        Dim DepartTable As DataTable = DepartDataAdapter.GetData

        For Each RowDep As DataRow In DepartTable.Rows
            Application.DoEvents()
            ' MessageBox.Show(DateServer)
            If CInt(RowDep("DepartID")) = 28 Then
                For Each rowItemMain As DataRow In MainStockItemDataAdapter.GetData
                    Application.DoEvents()
                    Dim QTY_EOD As Integer = DA_EODRun.SelectBeginQTYRerun(CInt(rowItemMain("ItemID")), 28, DateServer.Date) 'DA_MainStock.SelectCurrentStockMainDep(28, CInt(rowItemMain("ItemID")))
                    DA_BeginingTract.DeleteBeginingBalanceQTY(DateServer.Date, 28, rowItemMain("ItemID"))
                    DA_BeginingTract.InsertNewBegninig(28, DateServer.Date, QTY_EOD, rowItemMain("ItemID"))
                Next
            Else
                For Each RowItemDep As DataRow In ItemInDepartDataAdapter.GetItemDataByDepartID(CInt(RowDep("DepartID")))
                    Application.DoEvents()
                    'MessageBox.Show(CInt(RowDep("DepartID")) & " Item" & CInt(RowItemDep("ItemID")))

                    Dim Get_BeginQTY As Integer = DA_EODRun.SelectBeginQTYRerun(CInt(RowItemDep("ItemID")), CInt(RowDep("DepartID")), DateServer.Date) 'DA_DepStock.SelectLastQTYDepart(CInt(RowDep("DepartID")), CInt(RowItemDep("ItemID")))
                    DA_BeginingTract.DeleteBeginingBalanceQTY(DateServer.Date, CInt(RowDep("DepartID")), CInt(RowItemDep("ItemID")))
                    DA_BeginingTract.InsertNewBegninig(CInt(RowDep("DepartID")), DateServer.Date, Get_BeginQTY, CInt(RowItemDep("ItemID")))
                Next
            End If
        Next
    End Sub
    Friend Sub RegisterBeginingBalanceItemQTY()
        Dim DateServer As Date = GetDateServer.Date
        Dim DepartTable As DataTable = DepartDataAdapter.GetData

        For Each RowDep As DataRow In DepartTable.Rows
            Application.DoEvents()
            ' MessageBox.Show(DateServer)
            If CInt(RowDep("DepartID")) = 28 Then
                For Each rowItemMain As DataRow In MainStockItemDataAdapter.GetData
                    Application.DoEvents()
                    Dim QTYLast As Integer = DA_MainStock.SelectCurrentStockMainDep(28, CInt(rowItemMain("ItemID")))
                    Dim QTYBeginMan As Integer = 0
                    Try
                        If QTYBeginMan = DA_BeginingTract.GetBeginingItemBalance(28, DateServer.Date, rowItemMain("ItemID")) Is Nothing Then
                            QTYBeginMan = 0
                        Else
                            QTYBeginMan = DA_BeginingTract.GetBeginingItemBalance(28, DateServer.Date, rowItemMain("ItemID"))
                        End If
                        Console.WriteLine("Start........ main " & QTYBeginMan)
                    Catch ex As Exception
                        'MessageBox.Show(CInt(RowDep("DepartID")) & " Item " & CInt(rowItemMain("ItemID")))
                        Console.WriteLine("Start error........ Main invetor\y " & QTYBeginMan)
                        Console.WriteLine(CInt(RowDep("DepartID")) & " Item " & CInt(rowItemMain("ItemID")))
                        QTYBeginMan = 0
                    End Try
                    If QTYBeginMan = 0 Then
                        ' Select Case existing begintrack......
                        If DA_BeginingTract.CheckExisingBegining(28, rowItemMain("ItemID"), DateServer.Date) < 1 Then
                            DA_BeginingTract.InsertNewBegninig(28, DateServer.Date, QTYLast, rowItemMain("ItemID"))
                        End If

                    End If
                Next
            Else
                For Each RowItemDep As DataRow In ItemInDepartDataAdapter.GetItemDataByDepartID(CInt(RowDep("DepartID")))
                    Application.DoEvents()
                    'MessageBox.Show(CInt(RowDep("DepartID")) & " Item" & CInt(RowItemDep("ItemID")))
                    Dim QTYLast As Integer = DA_DepStock.SelectLastQTYDepart(CInt(RowDep("DepartID")), CInt(RowItemDep("ItemID")))
                    Dim QTYBeginMan As Integer = 0
                    Try
                        ' MsgBox(RowDep("DepartID") & "  " & RowItemDep("ItemID"))
                        If DA_BeginingTract.GetBeginingItemBalance(CInt(RowDep("DepartID")), DateServer.Date, CInt(RowItemDep("ItemID"))) Is Nothing Then
                            QTYBeginMan = 0
                        Else
                            QTYBeginMan = DA_BeginingTract.GetBeginingItemBalance(CInt(RowDep("DepartID")), DateServer.Date, CInt(RowItemDep("ItemID")))
                        End If

                        Console.WriteLine("Start........ another " & QTYBeginMan)
                    Catch ex As Exception
                        Console.WriteLine("Start error........ another " & QTYBeginMan)
                        Console.WriteLine(CInt(RowDep("DepartID")) & " Item " & CInt(RowItemDep("ItemID")))
                        QTYBeginMan = 0
                    End Try

                    If QTYBeginMan = 0 Then
                        If DA_BeginingTract.CheckExisingBegining(CInt(RowDep("DepartID")), CInt(RowItemDep("ItemID")), DateServer.Date) < 1 Then
                            DA_BeginingTract.InsertNewBegninig(CInt(RowDep("DepartID")), DateServer.Date, QTYLast, CInt(RowItemDep("ItemID")))
                        End If
                    End If
                Next

            End If

        Next
    End Sub

    ' =============================
    Private Function GetTotaRequest(RunEDO As Date, DepID As Integer, ItemID As Integer) As Double
        Dim TotalRequest As Integer = 0
        For Each rowReques As DataRow In DA_Request.GetRequestListByDate(RunEDO, DepID)
            For Each RowReqDetail As DataRow In DA_Req_Detail.GetReqIDandItemDetail(rowReques("RequestID"), ItemID).Rows
                TotalRequest = TotalRequest + CInt(RowReqDetail("Quantity"))
                'DA_EODRun.InsertReqToEOD(RunEDO, CInt(row("DepartID")), CInt(USER_ID), CInt(RowReqDetail("ItemID")), CInt(RowReqDetail("Quantity")), 0, 0, 0, 0)
            Next
        Next
        Return TotalRequest
    End Function
    Private Function GetTotalUsedByItem(RunEDO As Date, DepID As Integer, ItemID As Integer) As Double
        Dim TotalUsed As Integer = 0
        For Each RowUsed As DataRow In DA_Used.GetUseListByDate(RunEDO, DepID).Rows
            For Each RowUseDetail As DataRow In DA_UsedDetail.SelectUseIDAndItemID(RowUsed("UsedID"), ItemID).Rows
                TotalUsed = TotalUsed + CInt(RowUseDetail("UsedQuantity"))
                'DA_EODRun.InsertReqToEOD(RunEDO.Date, CInt(row("DepartID")), CInt(USER_ID), CInt(RowUseDetail("ItemID")), 0, 0, CInt(RowUseDetail("UsedQuantity")), 0, 0)
            Next
        Next
        Return TotalUsed
    End Function
    Private Function GetTotalReceivedByItem(RunEDO As Date, DepID As Integer, ItemID As Integer) As Double
        Dim TotalReceived As Integer = 0
        For Each RowReceived As DataRow In DA_Received.GetRecievedListByDate(RunEDO, DepID).Rows
            For Each RowReceive As DataRow In DA_Received_detail.SelectByRecievedIDandItemID(RowReceived("ReceivedID"), ItemID).Rows
                TotalReceived = TotalReceived + CInt(RowReceive("ReceivedQuantity"))
                ' DA_EODRun.InsertReqToEOD(RunEDO, CInt(row("DepartID")), CInt(USER_ID), CInt(RowReceive("ItemID")), 0, CInt(RowReceive("ReceivedQuantity")), 0, 0, 0)
            Next
        Next
        Return TotalReceived
    End Function
    Private Function GetTotalAdjust(RunEDO As Date, DepID As Integer, ItemID As Integer) As Double
        Dim TotalAjust As Integer = 0
        For Each RowAdjust As DataRow In DA_AdjustHis.SelectUsedDetailWithItemID(RunEDO, DepID, ItemID).Rows
            TotalAjust = TotalAjust + CInt(RowAdjust("Difference"))
            ' DA_EODRun.InsertReqToEOD(RunEDO.Date, CInt(row("DepartID")), CInt(USER_ID), CInt(RowAdjust("ItemID")), 0, 0, 0, CInt(RowAdjust("Difference")), 0)
        Next
        Return TotalAjust
    End Function
    Private Function GetTotalReceivedMainInventoryByItem(RunEDO As Date, ItemID As Integer) As Double
        Dim TotalReceivedMain As Integer = 0
        For Each RowCarReqDetail As DataRow In DA_Req_Carit_Detail.SelectReceivedByItemid(RunEDO, ItemID) 'GetCaritasReqDetailListByReqID(RowCaristas("RequestID"))
            TotalReceivedMain += CInt(RowCarReqDetail("ReceivedQuantity"))
            ' DA_EODRun.InsertReqToEOD(RunEDO.Date, CInt(RowDep("DepartID")), CInt(USER_ID), CInt(RowCarReqDetail("ItemID")), CInt(RowCarReqDetail("RequestQuantity")), CInt(RowCarReqDetail("ReceivedQuantity")), 0, 0, 0)
        Next
        Return TotalReceivedMain
    End Function
    Sub RubEndOfDay()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf RubEndOfDay))
        Else

            If ChBAll.Checked = True Then ' else of block chbAll = false -------------------------------------------------------------------------------------------------------------------------------
                Dim DepartTable As DataTable = DepartDataAdapter.GetData
                ' Dim RunEDO As Date = Me.REDCalendar.SelectionEnd.Date
                '==================== loop all department to eod ======================================
                Dim SD As Date = StartDateEOD.Value.Date
                Dim ED As Date = EndDateEOD.Value.Date
                For offset = 0 To (ED - SD).Days
                    Dim RunEDO As Date = SD.AddDays(offset).Date

                    For Each RowDep As DataRow In DepartTable.Rows
                        MScreening.StatusLoading(True, "Start " & RowDep("DepartName") & " " & Format(RunEOD, "dd/MM/yyyy"))
                        Application.DoEvents()

                        '=================== Re-run EOD ===============================
                        DA_EODRun.DeleteEODByDepID(CInt(RowDep("DepartID")), RunEDO)
                        DA_EODStatus.DeleteEODStatusByDepID(CInt(RowDep("DepartID")), RunEDO)
                        DA_EODStatus.InsertNewEODStatusByDepID(RunEDO, 1, CInt(RowDep("DepartID")))

                        Dim TotalBeginingBalance As Integer = 0
                        Dim TotalRequest As Integer = 0
                        Dim TotalReceived As Integer = 0
                        'Dim TotalRequestItemCaritas As Integer = 0
                        'Dim TotalReceiveCar As Integer = 0
                        Dim TotalUsed As Integer = 0
                        Dim TotalAjust As Integer = 0
                        Dim ItemID As Integer = 0
                        Dim TotalEndBalance As Integer = 0


                        If CInt(RowDep("DepartID")) = MAIN_STOCK_DEPART_ID Then
                            For Each DrowItem As DataRow In MainStockItemDataAdapter.GetData.Rows
                                'TotalBeginingBalance = DA_EODRun.SelectBeginQTYRerun(CInt(DrowItem("ItemID")), CInt(RowDep("DepartID")), RunEDO.Date)
                                TotalBeginingBalance = IIf(IsNothing(DA_EODRun.SelectBeginQTYRerun(CInt(DrowItem("ItemID")), CInt(RowDep("DepartID")), RunEDO.Date)), 0, DA_EODRun.SelectBeginQTYRerun(CInt(DrowItem("ItemID")), CInt(RowDep("DepartID")), RunEDO.Date))
                                TotalRequest = GetTotaRequest(RunEDO, CInt(RowDep("DepartID")), CInt(DrowItem("ItemID")))
                                TotalUsed = GetTotalUsedByItem(RunEDO, CInt(RowDep("DepartID")), CInt(DrowItem("ItemID")))
                                TotalReceived = GetTotalReceivedMainInventoryByItem(RunEDO, CInt(DrowItem("ItemID")))
                                TotalAjust = GetTotalAdjust(RunEDO, CInt(RowDep("DepartID")), CInt(DrowItem("ItemID")))
                                TotalEndBalance = ((TotalBeginingBalance + TotalReceived) + TotalAjust) - TotalUsed
                                DA_EODRun.InsertLastUpdateEOD(RunEDO.Date, CInt(RowDep("DepartID")), CInt(USER_ID), CInt(DrowItem("ItemID")), TotalRequest, TotalReceived, TotalUsed, TotalAjust, TotalBeginingBalance, TotalEndBalance)
                                MScreening.StatusLoading(True, "Start " & CInt(DrowItem("ItemID")) & " " & Format(RunEOD, "dd"))
                                Application.DoEvents()
                            Next
                        Else
                            For Each DrowItem As DataRow In ItemInDepartDataAdapter.GetItemDataByDepartID(CInt(RowDep("DepartID"))).Rows
                                TotalBeginingBalance = IIf(IsNothing(DA_EODRun.SelectBeginQTYRerun(CInt(DrowItem("ItemID")), CInt(RowDep("DepartID")), RunEDO.Date)), 0, DA_EODRun.SelectBeginQTYRerun(CInt(DrowItem("ItemID")), CInt(RowDep("DepartID")), RunEDO.Date))
                                TotalRequest = GetTotaRequest(RunEDO, CInt(RowDep("DepartID")), CInt(DrowItem("ItemID")))
                                TotalUsed = GetTotalUsedByItem(RunEDO, CInt(RowDep("DepartID")), CInt(DrowItem("ItemID")))
                                TotalReceived = GetTotalReceivedByItem(RunEDO, CInt(RowDep("DepartID")), CInt(DrowItem("ItemID")))
                                TotalAjust = GetTotalAdjust(RunEDO, CInt(RowDep("DepartID")), CInt(DrowItem("ItemID")))
                                TotalEndBalance = ((TotalBeginingBalance + TotalReceived) + TotalAjust) - TotalUsed
                                DA_EODRun.InsertLastUpdateEOD(RunEDO.Date, CInt(RowDep("DepartID")), CInt(USER_ID), CInt(DrowItem("ItemID")), TotalRequest, TotalReceived, TotalUsed, TotalAjust, TotalBeginingBalance, TotalEndBalance)
                                MScreening.StatusLoading(True, "Start " & CInt(DrowItem("ItemID")) & " " & Format(RunEOD, "dd"))
                                Application.DoEvents()
                            Next

                        End If
                    Next
                Next
            End If
          
        End If
    End Sub

    Private Sub BgLoadingRunEOD_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingRunEOD.RunWorkerCompleted
        'MTakeoInventory.StatusLoading(False)

        Try
            MenuReceivedAll.Enabled = True
        Catch ex As Exception

        End Try
        Try
            MenuReadyInOT.Enabled = True
        Catch ex As Exception

        End Try
        gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(StartDateEOD.Value.Date, EndDateEOD.Value.Date)
        MScreening.StatusLoading(False, "Loading")
        MessageBox.Show("Process run end of day successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    Public Sub BtnEndofDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEndofDay.Click
        'If MessageBox.Show("Do you want process run end of day ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
        '   MTakeoInventory.StatusLoading(True)
        '  MScreening.StatusLoading(True, "Loading")
        If ValidateDateField(StartDateEOD, "", ErrorEOD) = False Then Exit Sub
        If ValidateDateField(EndDateEOD, "", ErrorEOD) = False Then Exit Sub


        If BgLoadingRunEOD.IsBusy = True Then
            BgLoadingRunEOD.CancelAsync()
        Else
            BgLoadingRunEOD.RunWorkerAsync()
        End If
        'End If
    End Sub


    Private Sub ChBAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAll.CheckedChanged
        cbDepart.Enabled = Not (ChBAll.Checked)

    End Sub


    Private Sub ChBAllS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAllS.CheckedChanged
        cbDepartS.Enabled = Not (ChBAllS.Checked)
    End Sub


    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
       
        If ValidateDateField(StartDateEOD, "", ErrorEOD) = False Then Exit Sub
        If ValidateDateField(EndDateEOD, "", ErrorEOD) = False Then Exit Sub
        Dim SD As Date = StartDateEOD.Value.Date
        Dim ED As Date = EndDateEOD.Value.Date
        For offset = 0 To (ED - SD).Days
            Dim d As Date = SD.AddDays(offset).Date
            MessageBox.Show(d)
            Me.RerunBeginingBalanceItemQTY(d)
        Next
        'Dim initDay As Integer = 0
        'Do While SD <= ED
        '    '   MsgBox(SD.DayOfWeek.ToString)

        '    SD = SD.AddDays(initDay)
        '    MessageBox.Show(SD.Date)
        '    initDay += 1
        'Loop
    End Sub
End Class
