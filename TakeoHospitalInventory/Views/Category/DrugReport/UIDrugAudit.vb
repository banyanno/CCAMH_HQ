Imports Janus.Windows.GridEX
Public Class UIDrugAudit
    Dim DA_Item As New DSDrugReportTableAdapters.VItemListTableAdapter
    Dim DA_Item_Used As New DSDrugReportTableAdapters.VRunEndofDayResultTableAdapter
    Dim DA_ItemExpired As New DSDrugReportTableAdapters.ITEM_EXPIREDATE_DETAILTableAdapter
    Dim DT_DrugAuditTem As New DSDrugReport.CCAMH_DRUG_AUDITDataTable
    Dim DA_DrugAudit As New DSDrugReportTableAdapters.CCAMH_DRUG_AUDITTableAdapter


    Dim DA_Dep As New DSDrugReportTableAdapters.tblDepartmentTableAdapter
    Dim DA_StockDep As New DSDrugReportTableAdapters.tblCentralInventoryTableAdapter
    Dim ItemListInDepartDataAdapter As New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim DA_EODHistory As New DSDrugReportTableAdapters.tblEndofDayRunTableAdapter
    Dim DepatmentID As Integer
    Dim DepName As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        With CboDepartment
            .DataSource = DA_Dep.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Function GetItemValueExpired(itemNo As Double) As String
        Dim Expired As String = ""
        For Each drow As DataRow In DA_ItemExpired.SelectItemExpiredDetail(itemNo)
            Expired = Expired & drow("UnitsInStock") & "(" & Format(drow("EXPIRE_DATE"), "MM/yy") & "), "
        Next
        Return Expired
    End Function
    Private Sub BtnGeneratReport_Click(sender As Object, e As EventArgs) Handles BtnGeneratReport.Click
        If ValidateTextField(TxtNumberPercent, "", ErrDrugAudit) = False Then Exit Sub
        If ValidateDateTimePicker(DFrom, "", ErrDrugAudit) = False Then Exit Sub
        If ValidateDateTimePicker(DTo, "", ErrDrugAudit) = False Then Exit Sub
        If ValidateCombobox(CboDepartment, "", ErrDrugAudit) = False Then Exit Sub
        DepatmentID = CInt(CboDepartment.SelectedValue)
        DepName = CboDepartment.Text
        SplitContainer2.Panel2Collapsed = True
        BtnGeneratReport.Enabled = False
        BtnSave.Enabled = False
        GridDrugReport.Enabled = False
        BGRunSummary.RunWorkerAsync()

    End Sub
    Private Sub GeneratDrugAudit()
        If InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf GeneratDrugAudit))
        End If
        'GridDrugReport.ClearItems()

        DT_DrugAuditTem.Clear()
        'DT_DrugTem.
        MainFormApplicationPublic.StatusLoading(True, "Generate report....")
        Dim DRUG_AUDIT_ID As Double
        Dim CATEGORY_ID As Double
        Dim CATEGORY_NAME As String
        Dim ITEM_ID As Double
        Dim ITEM_NAME As String
        Dim NO_IN_BOOK As Double = 0
        Dim NO_COUNT As Double = 0
        Dim DIFFERENCE As Double = 0
        Dim DATE_OF_EXPIRY As String
        Dim DRUG_ISSUE As Integer = 0
        Dim ADD_PERCENT As Integer = 0
        Dim QTY_AFTER_ADDPERCENT As Double = 0
        Dim AMOUNT_TO_REQUIED6 As Double = 0
        Dim AMOUNT_TO_REQUIRED1YEAR As Double = 0
        Dim REMARK As String = ""
        Dim DATE_CREATE As DateTime
        Dim GENERATE_DATE As String = ""
        Dim START_DATE As DateTime
        Dim END_DATE As DateTime
        If DepatmentID = 28 Then
            For Each Drow As DataRow In DA_Item.GetData
                ' FlushMemory()
               
                Try
                    CATEGORY_ID = Drow("CateID")
                    CATEGORY_NAME = Drow("CateName")
                    ITEM_ID = Drow("ItemID")
                    ITEM_NAME = Drow("ItemName")
                    Try
                        If ChGetCurrrentStock.Checked = True Then
                            NO_IN_BOOK = DA_Item.SeletUnitInstock(ITEM_ID)
                        Else
                            NO_IN_BOOK = DA_EODHistory.SelectEndOfDayBook(DTo.Value.Date, Me.DepatmentID, ITEM_ID)
                        End If

                    Catch ex As Exception
                        NO_IN_BOOK = 0
                    End Try
                    If DepatmentID = 28 Then
                        Try
                            Dim F As String = GetItemValueExpired(ITEM_ID)
                            If F.Length <= 0 Then
                                DATE_OF_EXPIRY = ""
                            Else
                                DATE_OF_EXPIRY = (F.Substring(0, F.Length - 2))
                            End If
                        Catch ex As Exception
                            DATE_OF_EXPIRY = ""
                        End Try
                    Else
                        DATE_OF_EXPIRY = ""
                    End If

                    Try
                        DRUG_ISSUE = DA_Item_Used.TotalDrugIssued(ITEM_ID, DepatmentID, DFrom.Value.Date, DTo.Value.Date) 'DA_EODHistory.SelectTotalUsedDateToDate(DFrom.Value.Date, DTo.Value.Date, DepatmentID, ITEM_ID) 
                    Catch ex As Exception
                        DRUG_ISSUE = 0
                    End Try
                    ADD_PERCENT = EmptyString(TxtNumberPercent.Text)
                    QTY_AFTER_ADDPERCENT = (DRUG_ISSUE * ((ADD_PERCENT + 100) / 100))
                    AMOUNT_TO_REQUIED6 = QTY_AFTER_ADDPERCENT - NO_COUNT
                    AMOUNT_TO_REQUIRED1YEAR = AMOUNT_TO_REQUIED6 + QTY_AFTER_ADDPERCENT

                    Application.DoEvents()

                    AddItemTem(CATEGORY_ID, CATEGORY_NAME, ITEM_ID, ITEM_NAME, NO_IN_BOOK, NO_COUNT, DIFFERENCE, DATE_OF_EXPIRY, _
                               DRUG_ISSUE, ADD_PERCENT, QTY_AFTER_ADDPERCENT, AMOUNT_TO_REQUIED6, AMOUNT_TO_REQUIRED1YEAR, REMARK, _
                               Now.Date, Format(DFrom.Value.Date, "dd/MM/yyyy") & "-" & Format(DTo.Value.Date, "dd/MM/yyyy"), DFrom.Value.Date, DTo.Value.Date)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Audit", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
             
            Next
        Else
            For Each Drow As DataRow In ItemListInDepartDataAdapter.GetItemDataByDepartID(DepatmentID)
                ' FlushMemory()
                Try
                    CATEGORY_ID = Drow("CateID")
                    CATEGORY_NAME = Drow("CateName")
                    ITEM_ID = Drow("ItemID")
                    ITEM_NAME = Drow("ItemName")
                    Try
                        If ChGetCurrrentStock.Checked = True Then
                            NO_IN_BOOK = ItemListInDepartDataAdapter.SeletTotalCurrentQTY(Me.DepatmentID, ITEM_ID)
                        Else
                            NO_IN_BOOK = DA_EODHistory.SelectEndOfDayBook(DTo.Value.Date, Me.DepatmentID, ITEM_ID) ' ItemListInDepartDataAdapter.SeletTotalCurrentQTY(Me.DepatmentID, ITEM_ID)
                        End If

                    Catch ex As Exception
                        NO_IN_BOOK = 0
                    End Try
                    If DepatmentID = 28 Then
                        Try
                            Dim F As String = GetItemValueExpired(ITEM_ID)
                            If F.Length <= 0 Then
                                DATE_OF_EXPIRY = ""
                            Else
                                DATE_OF_EXPIRY = (F.Substring(0, F.Length - 2))
                            End If
                        Catch ex As Exception
                            DATE_OF_EXPIRY = ""
                        End Try
                    Else
                        DATE_OF_EXPIRY = ""
                    End If

                    Try
                        DRUG_ISSUE = DA_Item_Used.TotalDrugIssued(ITEM_ID, DepatmentID, DFrom.Value.Date, DTo.Value.Date) 'DA_EODHistory.SelectTotalUsedDateToDate(DFrom.Value.Date, DTo.Value.Date, Me.DepatmentID, ITEM_ID) '
                    Catch ex As Exception
                        DRUG_ISSUE = 0
                    End Try
                    ADD_PERCENT = EmptyString(TxtNumberPercent.Text)
                    QTY_AFTER_ADDPERCENT = (DRUG_ISSUE * ((ADD_PERCENT + 100) / 100))
                    AMOUNT_TO_REQUIED6 = QTY_AFTER_ADDPERCENT - NO_COUNT
                    AMOUNT_TO_REQUIRED1YEARV = AMOUNT_TO_REQUIED6 + QTY_AFTER_ADDPERCENT

                    Application.DoEvents()

                    AddItemTem(CATEGORY_ID, CATEGORY_NAME, ITEM_ID, ITEM_NAME, NO_IN_BOOK, NO_COUNT, DIFFERENCE, DATE_OF_EXPIRY, _
                               DRUG_ISSUE, ADD_PERCENT, QTY_AFTER_ADDPERCENT, AMOUNT_TO_REQUIED6, AMOUNT_TO_REQUIRED1YEARV, REMARK, _
                               Now.Date, Format(DFrom.Value.Date, "dd/MM/yyyy") & "-" & Format(DTo.Value.Date, "dd/MM/yyyy"), DFrom.Value.Date, DTo.Value.Date)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Audit", MessageBoxButtons.OK)
                End Try
               
            Next
        End If
        

    End Sub
    Private Sub AddItemTem(ByVal CATEGORY_ID As Double, ByVal CATEGORY_NAME As String, ByVal ITEM_ID As Double, ByVal ITEM_NAME As String, ByVal NO_IN_BOOK As Double, _
                         ByVal NO_COUNT As Double, ByVal DIFFERENCE As Double, ByVal DATE_OF_EXPIRY As String, ByVal DRUG_ISSUE As Double, ByVal ADD_PERCENT As Double, _
                         ByVal QTY_AFTER_ADDPERCENT As Double, ByVal AMOUNT_TO_REQUIED6 As Double, ByVal AMOUNT_TO_REQUIRED1YEARV As Double, ByVal REMARK As String, _
                         ByVal DATE_CREATE As Date, ByVal GENERATE_DATE As String, ByVal START_DATE As Date, END_DATE As Date)
        Dim Drow As DataRow = DT_DrugAuditTem.NewRow
        Drow("CATEGORY_ID") = CATEGORY_ID
        Drow("CATEGORY_NAME") = CATEGORY_NAME
        Drow("ITEM_ID") = ITEM_ID
        Drow("ITEM_NAME") = ITEM_NAME
        Drow("NO_IN_BOOK") = NO_IN_BOOK
        Drow("NO_COUNT") = NO_COUNT
        Drow("DIFFERENCE") = DIFFERENCE
        Drow("DATE_OF_EXPIRY") = DATE_OF_EXPIRY
        Drow("DRUG_ISSUE") = DRUG_ISSUE
        Drow("ADD_PERCENT") = ADD_PERCENT
        Drow("QTY_AFTER_ADDPERCENT") = QTY_AFTER_ADDPERCENT
        Drow("AMOUNT_TO_REQUIED6") = AMOUNT_TO_REQUIED6
        Drow("AMOUNT_TO_REQUIRED1YEARV") = AMOUNT_TO_REQUIRED1YEARV
        Drow("REMARK") = REMARK
        Drow("DATE_CREATE") = DATE_CREATE
        Drow("GENERATE_DATE") = GENERATE_DATE
        Drow("START_DATE") = START_DATE
        Drow("END_DATE") = END_DATE
        DT_DrugAuditTem.Rows.Add(Drow)
        GridDrugReport.DataSource = DT_DrugAuditTem
    End Sub

    Private Sub BGRunSummary_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGRunSummary.DoWork
        GeneratDrugAudit()
    End Sub

    Private Sub BGRunSummary_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGRunSummary.RunWorkerCompleted
        MainFormApplicationPublic.StatusLoading(False, "Generate report....")
        GridDrugReport.Refetch()
        GridDrugReport.Refresh()
        BtnGeneratReport.Enabled = True
        BtnSave.Enabled = True
        GridDrugReport.Enabled = True
    End Sub

   

    Private Sub GridDrugReport_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles GridDrugReport.CellEdited
        'MessageBox.Show("Hello")
        Dim row As GridEXRow = GridDrugReport.CurrentRow
        Try
            row.Cells("DIFFERENCE").Value = row.Cells("NO_COUNT").Value - row.Cells("NO_IN_BOOK").Value
        Catch ex As Exception

        End Try

        '(DRUG_ISSUE * (ADD_PERCENT / 100))
        row.Cells("QTY_AFTER_ADDPERCENT").Value = (CDbl(row.Cells("DRUG_ISSUE").Value) * ((CDbl(row.Cells("ADD_PERCENT").Value) + 100) / 100))
        row.Cells("AMOUNT_TO_REQUIED6").Value = row.Cells("QTY_AFTER_ADDPERCENT").Value - row.Cells("NO_COUNT").Value
        row.Cells("AMOUNT_TO_REQUIRED1YEARV").Value = row.Cells("AMOUNT_TO_REQUIED6").Value + row.Cells("QTY_AFTER_ADDPERCENT").Value
    End Sub

    Private Sub TxtNumberPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumberPercent.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        checkedRows = GridDrugReport.GetCheckedRows()
        If checkedRows.Length = 0 Then
            MessageBox.Show("Please check at least 1 item generate report.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            'MessageBox.Show(GridDrugReport.GetRows.Count)
            If GridDrugReport.SelectedItems.Count = 0 Then
                MessageBox.Show("You can not save drug audit. Please generate list of drug audit?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Do you want to save drug audit?", "Drug audit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MainFormApplicationPublic.StatusLoading(True, "Saving drug audit")
                'GridDrugReport.Row = 0
                DA_DrugAudit.DeleteDrugAudit()  ''DeleteDrugAuditByGeneratdate(Format(DFrom.Value.Date, "dd/MM/yyyy") & "-" & Format(DTo.Value.Date, "dd/MM/yyyy"))
                GridDrugReport.AllowEdit = False
                BtnGeneratReport.Enabled = False
                GridDrugReport.Enabled = False
                BtnSave.Enabled = False
                BgSaveDrugAudit.RunWorkerAsync()
            End If
        End If
        

    End Sub

    Private Sub BgSaveDrugAudit_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgSaveDrugAudit.DoWork
        InsertDrugAudit()
    End Sub
    Private Sub InsertDrugAudit()
        'If Me.InvokeRequired Then
        '    Me.Invoke(New MethodInvoker(AddressOf InsertDrugAudit))
        'End If
        checkedRows = GridDrugReport.GetCheckedRows()
        Dim I As Integer = 0
        ' MessageBox.Show(GridDrugReport.GetRows.Count)
        Dim CATEGORY_ID As Integer
        Dim CATEGORY_NAME As String
        Dim ITEM_ID As Integer
        Dim ITEM_NAME As String
        Dim NO_IN_BOOK As Double
        Dim NO_COUNT As Double
        Dim DIFFERENCE As Double
        Dim DATE_OF_EXPIRY As String
        Dim DRUG_ISSUE As Double
        Dim ADD_PERCENT As Integer
        Dim QTY_AFTER_ADDPERCENT As Double
        Dim AMOUNT_TO_REQUIED6 As Double
        Dim AMOUNT_TO_REQUIRED1YEARV As Double
        Dim REMARK As String
        Dim DATE_CREATE As Date
        Dim GENERATE_DATE As String
        Dim START_DATE As Date
        Dim END_DATE As Date
        For Each gRows As Janus.Windows.GridEX.GridEXRow In checkedRows
            Try
                CATEGORY_ID = gRows.Cells("CATEGORY_ID").Value
                CATEGORY_NAME = gRows.Cells("CATEGORY_NAME").Value
                ITEM_ID = gRows.Cells("ITEM_ID").Value
                ITEM_NAME = gRows.Cells("ITEM_NAME").Value
                NO_IN_BOOK = gRows.Cells("NO_IN_BOOK").Value
                NO_COUNT = gRows.Cells("NO_COUNT").Value
                DIFFERENCE = gRows.Cells("DIFFERENCE").Value
                DATE_OF_EXPIRY = IIf(TypeOf gRows.Cells("DATE_OF_EXPIRY").Value Is DBNull, "", gRows.Cells("DATE_OF_EXPIRY").Value)
                DRUG_ISSUE = IIf(TypeOf gRows.Cells("DRUG_ISSUE").Value Is DBNull, 0, gRows.Cells("DRUG_ISSUE").Value)
                ADD_PERCENT = IIf(TypeOf gRows.Cells("ADD_PERCENT").Value Is DBNull, 0, gRows.Cells("ADD_PERCENT").Value)
                QTY_AFTER_ADDPERCENT = gRows.Cells("QTY_AFTER_ADDPERCENT").Value
                AMOUNT_TO_REQUIED6 = gRows.Cells("AMOUNT_TO_REQUIED6").Value
                AMOUNT_TO_REQUIRED1YEARV = gRows.Cells("AMOUNT_TO_REQUIRED1YEARV").Value
                REMARK = gRows.Cells("REMARK").Value
                DATE_CREATE = gRows.Cells("DATE_CREATE").Value
                GENERATE_DATE = gRows.Cells("GENERATE_DATE").Value
                START_DATE = gRows.Cells("START_DATE").Value
                END_DATE = gRows.Cells("END_DATE").Value
                DA_DrugAudit.InsertNewDrugAudit(CATEGORY_ID, CATEGORY_NAME, ITEM_ID, ITEM_NAME, NO_IN_BOOK, NO_COUNT, DIFFERENCE, DATE_OF_EXPIRY, DRUG_ISSUE, ADD_PERCENT, QTY_AFTER_ADDPERCENT, AMOUNT_TO_REQUIED6, AMOUNT_TO_REQUIRED1YEARV, REMARK, DATE_CREATE.Date, GENERATE_DATE, START_DATE.Date, END_DATE.Date)
                Application.DoEvents()
                Threading.Thread.Sleep(10)
            Catch ex As Exception
                MessageBox.Show(ex.Message & " on " & ITEM_NAME & " Please refill again...", "Audit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
           


        Next
        
    End Sub

    Private Sub BgSaveDrugAudit_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgSaveDrugAudit.RunWorkerCompleted

        SplitContainer2.Panel2Collapsed = False
        Dim CDrugAudit As New CRDrugAudit
        Dim TblDrugAudit As DataTable = DA_DrugAudit.SelectDrugAudit(Format(DFrom.Value.Date, "dd/MM/yyyy") & "-" & Format(DTo.Value.Date, "dd/MM/yyyy"))
        CDrugAudit.SetDataSource(TblDrugAudit)
        CryViewer.ReportSource = CDrugAudit
        CDrugAudit.SetParameterValue("Title", CboDepartment.Text)
        MainFormApplicationPublic.StatusLoading(False, "Generate report....")
        BtnGeneratReport.Enabled = True
        BtnSave.Enabled = True
        GridDrugReport.Enabled = True
        MessageBox.Show("Save drug audit successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnSave_MouseHover(sender As Object, e As EventArgs) Handles BtnSave.MouseHover
        TxtNumberPercent.Focus()

    End Sub
End Class
