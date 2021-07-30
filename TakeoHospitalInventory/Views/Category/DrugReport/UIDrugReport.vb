Imports Janus.Windows.GridEX

Public Class UIDrugReport
    Dim DA_Item As New DSDrugReportTableAdapters.VItemListTableAdapter

    Dim DA_IssueToDep As New DSDrugReportTableAdapters.CCAMH_VIEW_ISSUE_DEP_RECEIVETableAdapter
    Dim DA_AdjustDep As New DSDrugReportTableAdapters.tblAdjustStockHistoryTableAdapter
    Dim DA_Received As New DSDrugReportTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
    Dim DA_ItemExpired As New DSDrugReportTableAdapters.ITEM_EXPIREDATE_DETAILTableAdapter
    Dim DA_Begining As New DSDrugReportTableAdapters.tblBeginBalanceTraceTableAdapter
    Dim DT_DrugTem As New DSDrugReport.Table_DrugReportDataTable
    Dim JanusGrid As GridEX
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGeneratReport.Click
        If ValidateDateField(DFrom, "", ErrorProvider1) = False Then Exit Sub
        If ValidateDateField(DTo, "", ErrorProvider1) = False Then Exit Sub
        'BtnGeneratReport.Enabled = False
        'Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        'checkedRows = GridDrugReport.GetCheckedRows()
        'If checkedRows.Length = 0 Then
        '    MessageBox.Show("Please check at least 1 item generate report.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'Else

        'End If
        Dim FSelectItem As New FormSelectItem(Me)
        If FSelectItem.ShowDialog = DialogResult.OK Then
            JanusGrid = FSelectItem.GridItem
            BGRunSummary.RunWorkerAsync()
        End If


    End Sub

    Private Sub GeneratDrugReport()
        If InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf GeneratDrugReport))
        End If
        Dim CateID As Integer
        Dim CateName As String
        Dim ItemID As Integer
        Dim ItemName As String
        Dim Total_Begining As Integer
        Dim Total_Receive As Integer
        Dim Total_Current_stock As Integer
        Dim Total_Pharmacy As Integer
        Dim Total_Pharmacy_Adjust As Integer = 0
        Dim Total_BTB As Integer
        Dim Total_BTB_Adjust As Integer = 0
        Dim Total_KPC As Integer
        Dim Total_KPC_Adjust As Integer = 0
        Dim Total_Donation As Integer
        Dim Total_Donation_Adjust As Integer = 0
        Dim Total_Issue As Integer
        Dim Total_Balance As Integer
        Dim Total_Expired As String
        Dim GenerateDate As String
        Dim DateGenFrom As Date = Me.DFrom.Value.Date
        Dim DateGenTo As Date = Me.DTo.Value.Date
        DT_DrugTem.Clear()
        'DT_DrugTem.
        MainFormApplicationPublic.StatusLoading(True, "Generate report....")
        checkedRows = JanusGrid.GetCheckedRows()
        Dim I As Integer = 0
        If ChFormulaAdjustock.Checked = True Then
            For Each gRows As Janus.Windows.GridEX.GridEXRow In checkedRows
                FlushMemory()
                CateID = gRows.Cells("CateID").Value
                CateName = gRows.Cells("CateName").Value
                ItemID = gRows.Cells("ItemID").Value
                ItemName = gRows.Cells("ItemName").Value
                Try
                    Total_Begining = DA_Begining.SelectBeginingItemByDate(28, DFrom.Value.Date, ItemID)
                Catch ex As Exception
                    Total_Begining = 0
                End Try

                Try
                    Total_Receive = IIf(IsNothing(DA_Received.TotalReceived(ItemID, DFrom.Value.Date, DTo.Value.Date)), 0, DA_Received.TotalReceived(ItemID, DFrom.Value.Date, DTo.Value.Date))
                Catch ex As Exception
                    Total_Receive = 0
                End Try
                Try

                Catch ex As Exception

                End Try
                Total_Current_stock = DA_Item.SeletUnitInstock(ItemID) 'Total_Begining + Total_Receive
                '============================== Get value give medicine with department Pharmacy ==============
                Try
                    Total_Pharmacy = DA_IssueToDep.TotalIssueToDep(DFrom.Value.Date, DTo.Value.Date, ItemID, 26)
                    Total_Pharmacy_Adjust = DA_AdjustDep.GetTotalAdjust(26, ItemID, DFrom.Value.Date, DTo.Value.Date, True)
                Catch ex As Exception
                    Total_Pharmacy = 0
                End Try
                '============================== Get value give medicine with department BTB ==============
                Try
                    Total_BTB = DA_IssueToDep.TotalIssueToDep(DFrom.Value.Date, DTo.Value.Date, ItemID, 45)
                    Total_BTB_Adjust = DA_AdjustDep.GetTotalAdjust(45, ItemID, DFrom.Value.Date, DTo.Value.Date, True)
                Catch ex As Exception
                    Total_BTB = 0
                End Try
                '============================== Get value give medicine with department KPC ==============
                Try
                    Total_KPC = DA_IssueToDep.TotalIssueToDep(DFrom.Value.Date, DTo.Value.Date, ItemID, 42)
                    Total_KPC_Adjust = DA_AdjustDep.GetTotalAdjust(42, ItemID, DFrom.Value.Date, DTo.Value.Date, True)
                Catch ex As Exception
                    Total_KPC = 0
                End Try
                Try
                    Total_Donation = DA_IssueToDep.TotalIssueToDep(DFrom.Value.Date, DTo.Value.Date, ItemID, 46)
                    Total_Donation_Adjust = DA_AdjustDep.GetTotalAdjust(46, ItemID, DFrom.Value.Date, DTo.Value.Date, True)
                Catch ex As Exception
                    Total_Donation = 0
                End Try

                Total_Issue = (Total_Pharmacy + Total_Pharmacy_Adjust) + (Total_BTB + Total_BTB_Adjust) + (Total_KPC + Total_KPC_Adjust) + (Total_Donation + Total_Donation_Adjust)
                If Total_Issue > 0 Then
                    Total_Balance = (Total_Begining + Total_Receive) - (Total_Issue)  'Total_Current_stock - Total_Issue
                Else
                    ' Some time value ov TotalIssue negative...
                    Total_Balance = (Total_Begining + Total_Receive) + (Total_Issue)  'Total_Current_stock - Total_Issue
                End If

                Try
                    Dim F As String = GetItemValueExpired(ItemID)
                    If F.Length <= 0 Then
                        Total_Expired = ""
                    Else
                        Total_Expired = (F.Substring(0, F.Length - 2))
                    End If
                Catch ex As Exception
                    Total_Expired = ""
                End Try

                Application.DoEvents()

                AddItemTem(CateID, CateName, ItemID, ItemName, Total_Begining, Total_Receive, Total_Current_stock, (Total_Pharmacy + Total_Pharmacy_Adjust), (Total_BTB + Total_BTB_Adjust), (Total_KPC + Total_KPC_Adjust), (Total_Donation + Total_Donation_Adjust), Total_Issue, Total_Balance, Total_Expired, Format(DFrom.Value.Date, "dd/MM/yyyy") & "-" & Format(DTo.Value.Date, "dd/MM/yyyy"), DFrom.Value.Date, DTo.Value.Date)

            Next

            ' Normal without add adjust stock to function....
        Else
            For Each gRows As Janus.Windows.GridEX.GridEXRow In checkedRows
                FlushMemory()
                CateID = gRows.Cells("CateID").Value
                CateName = gRows.Cells("CateName").Value
                ItemID = gRows.Cells("ItemID").Value
                ItemName = gRows.Cells("ItemName").Value
                Try
                    Total_Begining = DA_Begining.SelectBeginingItemByDate(28, DFrom.Value.Date, ItemID)
                Catch ex As Exception
                    Total_Begining = 0
                End Try

                Try
                    Total_Receive = IIf(IsNothing(DA_Received.TotalReceived(ItemID, DFrom.Value.Date, DTo.Value.Date)), 0, DA_Received.TotalReceived(ItemID, DFrom.Value.Date, DTo.Value.Date))
                Catch ex As Exception
                    Total_Receive = 0
                End Try
                Try

                Catch ex As Exception

                End Try
                Total_Current_stock = DA_Item.SeletUnitInstock(ItemID) 'Total_Begining + Total_Receive
                '============================== Get value give medicine with department Pharmacy ==============
                Try
                    Total_Pharmacy = DA_IssueToDep.TotalIssueToDep(DFrom.Value.Date, DTo.Value.Date, ItemID, 26)

                Catch ex As Exception
                    Total_Pharmacy = 0
                End Try
                '============================== Get value give medicine with department BTB ==============
                Try
                    Total_BTB = DA_IssueToDep.TotalIssueToDep(DFrom.Value.Date, DTo.Value.Date, ItemID, 45)

                Catch ex As Exception
                    Total_BTB = 0
                End Try
                '============================== Get value give medicine with department KPC ==============
                Try
                    Total_KPC = DA_IssueToDep.TotalIssueToDep(DFrom.Value.Date, DTo.Value.Date, ItemID, 42)

                Catch ex As Exception
                    Total_KPC = 0
                End Try
                Try
                    Total_Donation = DA_IssueToDep.TotalIssueToDep(DFrom.Value.Date, DTo.Value.Date, ItemID, 46)

                Catch ex As Exception
                    Total_Donation = 0
                End Try

                Total_Issue = (Total_Pharmacy) + (Total_BTB) + (Total_KPC) + (Total_Donation)

                Total_Balance = (Total_Begining + Total_Receive) - (Total_Issue)  'Total_Current_stock - Total_Issue

                Try
                    Dim F As String = GetItemValueExpired(ItemID)
                    If F.Length <= 0 Then
                        Total_Expired = ""
                    Else
                        Total_Expired = (F.Substring(0, F.Length - 2))
                    End If
                Catch ex As Exception
                    Total_Expired = ""
                End Try

                Application.DoEvents()

                AddItemTem(CateID, CateName, ItemID, ItemName, Total_Begining, Total_Receive, Total_Current_stock, (Total_Pharmacy), (Total_BTB), (Total_KPC), (Total_Donation), Total_Issue, Total_Balance, Total_Expired, Format(DFrom.Value.Date, "dd/MM/yyyy") & "-" & Format(DTo.Value.Date, "dd/MM/yyyy"), DFrom.Value.Date, DTo.Value.Date)

            Next
        End If
        
        'For Each Drow As DataRow In DA_Item.GetData

        'Next
        'GridDrugReport.DataSource = DT_DrugTem
    End Sub
    Private Sub AddItemTem(ByVal CATEGORY_ID As Integer, ByVal CATEGORY_NAME As String, ByVal ITEM_ID As Integer, ByVal ITEM_NAME As String, ByVal BEGING_BALANCE As Integer, _
                           ByVal TOTAL_RECEIVED As Integer, ByVal CURRENT_STOCK As Integer, ByVal PHARMACY As Integer, ByVal TO_BTB As Integer, ByVal TO_KPC As Integer, _
                           ByVal DONATION As Integer, ByVal ISSUE_TOTAL As Integer, ByVal BALANCE As Integer, ByVal TOTAL_EXPIRED As String, _
                           ByVal GENERATE_REPORT As String, ByVal DATE_START As Date, ByVal DATE_END As Date)
        Dim Drow As DataRow = DT_DrugTem.NewRow
        Drow("CATEGORY_ID") = CATEGORY_ID
        Drow("CATEGORY_NAME") = CATEGORY_NAME
        Drow("ITEM_ID") = ITEM_ID
        Drow("ITEM_NAME") = ITEM_NAME
        Drow("BEGING_BALANCE") = BEGING_BALANCE
        Drow("TOTAL_RECEIVED") = TOTAL_RECEIVED
        Drow("CURRENT_STOCK") = CURRENT_STOCK
        Drow("PHARMACY") = PHARMACY
        Drow("TO_BTB") = TO_BTB
        Drow("TO_KPC") = TO_KPC
        Drow("DONATION") = DONATION
        Drow("ISSUE_TOTAL") = ISSUE_TOTAL
        Drow("BALANCE") = BALANCE
        Drow("TOTAL_EXPIRED") = TOTAL_EXPIRED
        Drow("GENERATE_REPORT") = GENERATE_REPORT
        Drow("DATE_START") = DATE_START
        Drow("DATE_END") = DATE_END
        DT_DrugTem.Rows.Add(Drow)
        GridDrugReport.DataSource = DT_DrugTem
    End Sub

    Private Sub BGRunSummary_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGRunSummary.DoWork
        GeneratDrugReport()
    End Sub

    Function GetItemValueExpired(itemNo As Double) As String
        Dim Expired As String = ""
        For Each drow As DataRow In DA_ItemExpired.SelectItemExpiredDetail(itemNo)
            Expired = Expired & drow("UnitsInStock") & "(" & Format(drow("EXPIRE_DATE"), "MM/yy") & "), "
        Next
        Return Expired
    End Function

    Private Sub BGRunSummary_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGRunSummary.RunWorkerCompleted
        Dim DTB_Tem As DataTable = DT_DrugTem
        Dim DrugReport As New CRDrugReport
        DrugReport.SetDataSource(DTB_Tem)
        DrugReport.SetParameterValue("Title", "From:" & Format(DFrom.Value.Date, "dd/MM/yy") & " - " & Format(DTo.Value.Date, "dd/MM/yy"))
        Me.CryViewer.ReportSource = DrugReport
        MainFormApplicationPublic.StatusLoading(False, "")
        BtnGeneratReport.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        For Each Drow As DataRow In DA_Item.GetData
            Dim F As String = GetItemValueExpired(Drow("ItemID"))
            If F.Length <= 0 Then
                MessageBox.Show("Nothing")
            Else
                MessageBox.Show(F.Substring(0, F.Length - 2))
            End If
        Next
    End Sub
End Class
