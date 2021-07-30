Public Class UCOpticalshopIncomStatement
    Dim DAOpticalShopIncomeS As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter
    Dim ObjReportIncome As New CryIncomeOpticalShop
    Dim MTakeoInventory As MainTakeoInventory
    Dim MScreening As MainAppKTG
    Sub New(ByVal MainForm As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        MTakeoInventory = MainForm
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New(ByVal MScreening As MainAppKTG)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MScreening = MScreening
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        Try
            RadAsTable.Checked = True
            MScreening.StatusLoading(True, "Loading")
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
       
    End Sub

    Sub LoadingAndPreviewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingAndPreviewReport))
        Else
            If RadAsTable.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = False
                SplitContainerIncomstatement.Panel2Collapsed = True
                GridReceipt.DataSource = DAOpticalShopIncomeS.GetDataByDateWithPaid(DateFrom.Value, DateTo.Value, 1)
            End If
            If RadViewReport.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = True
                SplitContainerIncomstatement.Panel2Collapsed = False
                Dim TblIncomeStatementTem As DataTable = DAOpticalShopIncomeS.GetDataByDateWithPaid(DateFrom.Value, DateTo.Value, 1)
                ObjReportIncome.SetDataSource(TblIncomeStatementTem)
                ObjReportIncome.SetParameterValue("Title", "From:" & Format(DateFrom.Value, "dd/MM/yyyy") & " To:" & Format(DateTo.Value, "dd/MM/yyyy"))
                CryViewOpticalshopIncome.ReportSource = ObjReportIncome
            End If
            If RadReceiptCancel.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = False
                SplitContainerIncomstatement.Panel2Collapsed = True
                GridReceipt.DataSource = DAOpticalShopIncomeS.GetDataByDateWithPaid(DateFrom.Value, DateTo.Value, 2)
            End If
            If RadReportCancel.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = True
                SplitContainerIncomstatement.Panel2Collapsed = False
                Dim TblIncomeStatementTem As DataTable = DAOpticalShopIncomeS.GetDataByDateWithPaid(DateFrom.Value, DateTo.Value, 2)
                ObjReportIncome.SetDataSource(TblIncomeStatementTem)
                ObjReportIncome.SetParameterValue("Title", "List Of Receipt Cancel From:" & Format(DateFrom.Value, "dd/MM/yyyy") & " To:" & Format(DateTo.Value, "dd/MM/yyyy"))
                CryViewOpticalshopIncome.ReportSource = ObjReportIncome
            End If

            If RadReceiptNil.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = False
                SplitContainerIncomstatement.Panel2Collapsed = True
                GridReceipt.DataSource = DAOpticalShopIncomeS.GetDataRecieptNilByDate(DateFrom.Value, DateTo.Value)
            End If

            If RadReportNil.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = True
                SplitContainerIncomstatement.Panel2Collapsed = False

                Dim TblIncomeStatementTem As DataTable = DAOpticalShopIncomeS.GetDataRecieptNilByDate(DateFrom.Value, DateTo.Value)
                ObjReportIncome.SetDataSource(TblIncomeStatementTem)
                ObjReportIncome.SetParameterValue("Title", "List Of Receipt Nil From:" & Format(DateFrom.Value, "dd/MM/yyyy") & " To:" & Format(DateTo.Value, "dd/MM/yyyy"))
                CryViewOpticalshopIncome.ReportSource = ObjReportIncome

            End If


        End If
    End Sub

    Private Sub RadViewReport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadViewReport.CheckedChanged
        Try
            MScreening.StatusLoading(True, "Loading")
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadAsTable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAsTable.CheckedChanged
        Try
            MScreening.StatusLoading(True, "Loading")
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadReceiptCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReceiptCancel.CheckedChanged
        Try
            MScreening.StatusLoading(True, "Loading")
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub RadReportCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReportCancel.CheckedChanged
        Try
            MScreening.StatusLoading(True, "Loading")
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        LoadingAndPreviewReport()
    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        MScreening.StatusLoading(False, "")
    End Sub

    Private Sub RadReceiptNil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReceiptNil.CheckedChanged
        Try
            MScreening.StatusLoading(True, "Loading")
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadReportNil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReportNil.CheckedChanged
        Try
            MScreening.StatusLoading(True, "Loading")
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnImpReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpReceipt.Click
        If MessageBox.Show("Do you want to import receipt?", "Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MScreening.StatusLoading(True, "Loading")
            BGImpOpticalTEH.RunWorkerAsync()
        End If
    End Sub

    Private Sub BGImpOpticalTEH_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGImpOpticalTEH.RunWorkerCompleted
        MScreening.StatusLoading(False, "Loading")
    End Sub
    Dim PatientTEHNo As Long = 0
    Dim S_ReceiptNo As Long = 0
    Dim DA_TEHReceipScreening As DatasetPatientTEHTableAdapters.IMP_tblPatientReceiptScreeninngTableAdapter
    Dim ReceiptNo, ReceiptDate, CustomerNo, MedicReal, MedicDolar, EyeGlassesReal, EyeGlassesDolar, TotalReal, TotalDolar, AmountInWords, AmountFigureReal, AmountFigureDolar _
, IsCurrency, IsDonation, DonationID, PayBySelf, PayByDonation, IsPaid, ReceiptNote, UserID, UserName, CusName, Sex, Age, Occupation, Address, DonationName, ReadyModDolar _
, ReadyModR, SpectacleDolar, SpectacleR, OtherDolar, OtherR, ReturnReal, ReturnDolar, FundRaisingR, FundRaisingDolar, IncomType, DonateAmount, SupportedAmtDolar, SupportedAmtR, TIME_CREATE As String
    Private Sub ImportReceipt()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf ImportReceipt))
        Else
            Dim GRows() As Janus.Windows.GridEX.GridEXRow
            GRows = GridReceipt.GetRows
            For I As Integer = 0 To GRows.Count - 1

                ReceiptNo = GridReceipt.GetRow(I).Cells("ReceiptNo").Value

                ReceiptDate = GridReceipt.GetRow(I).Cells("ReceiptDate").Value
                MedicReal = GridReceipt.GetRow(I).Cells("MedicReal").Value
                MedicDolar = GridReceipt.GetRow(I).Cells("MedicDolar").Value
                EyeGlassesReal = GridReceipt.GetRow(I).Cells("EyeGlassesReal").Value
                EyeGlassesDolar = GridReceipt.GetRow(I).Cells("EyeGlassesDolar").Value
                TotalReal = GridReceipt.GetRow(I).Cells("TotalReal").Value
                TotalDolar = GridReceipt.GetRow(I).Cells("TotalDolar").Value
                AmountInWords = GridReceipt.GetRow(I).Cells("AmountInWords").Value
                AmountFigureReal = GridReceipt.GetRow(I).Cells("AmountFigureReal").Value
                AmountFigureDolar = GridReceipt.GetRow(I).Cells("AmountFigureDolar").Value
                IsCurrency = GridReceipt.GetRow(I).Cells("IsCurrency").Value
                IsDonation = GridReceipt.GetRow(I).Cells("IsDonation").Value
                DonationID = GridReceipt.GetRow(I).Cells("DonationID").Value
                PayBySelf = GridReceipt.GetRow(I).Cells("PayBySelf").Value



                PayByDonation = GridReceipt.GetRow(I).Cells("PayByDonation").Value
                IsPaid = GridReceipt.GetRow(I).Cells("IsPaid").Value
                ReceiptNote = GridReceipt.GetRow(I).Cells("ReceiptNote").Value
                UserID = GridReceipt.GetRow(I).Cells("UserID").Value
                UserName = GridReceipt.GetRow(I).Cells("UserName").Value
                CusName = GridReceipt.GetRow(I).Cells("CusName").Value
                Sex = GridReceipt.GetRow(I).Cells("Sex").Value
                Age = GridReceipt.GetRow(I).Cells("Age").Value
                Occupation = GridReceipt.GetRow(I).Cells("Occupation").Value
                DonationName = GridReceipt.GetRow(I).Cells("DonationName").Value
                ReadyModDolar = GridReceipt.GetRow(I).Cells("ReadyModDolar").Value
                ReadyModR = GridReceipt.GetRow(I).Cells("ReadyModR").Value
                SpectacleDolar = GridReceipt.GetRow(I).Cells("SpectacleDolar").Value
                SpectacleR = GridReceipt.GetRow(I).Cells("SpectacleR").Value

                OtherDolar = GridReceipt.GetRow(I).Cells("OtherDolar").Value
                OtherR = GridReceipt.GetRow(I).Cells("OtherR").Value
                ReturnReal = GridReceipt.GetRow(I).Cells("ReturnReal").Value
                ReturnDolar = GridReceipt.GetRow(I).Cells("ReturnDolar").Value
                FundRaisingR = GridReceipt.GetRow(I).Cells("FundRaisingR").Value
                FundRaisingDolar = GridReceipt.GetRow(I).Cells("FundRaisingDolar").Value
                IncomType = GridReceipt.GetRow(I).Cells("IncomType").Value
                SupportedAmtDolar = GridReceipt.GetRow(I).Cells("SupportedAmtDolar").Value
                SupportedAmtR = GridReceipt.GetRow(I).Cells("SupportedAmtR").Value
                TIME_CREATE = GridReceipt.GetRow(I).Cells("TIME_CREATE").Value
                

                'CBool(DAScreeningBook.CheckStatusImport(PatientScreenNo)) = False And 
                If DA_TEHReceipScreening.CheckExistReceiptNo(ReceiptNo) = 0 Then
                    Application.DoEvents()
                    MainFormApplicationPublic.StatusUpdateLabel("Importing Patient:" & PatientScreenNo)
                    'If DA_TEHReceipScreening.ImpReceiptScreening(ReceiptNo, 0, ) = 1 Then
                    '    DAScreeningBook.UpateStatusImport(True, PatientScreenNo)
                    '    GridReceipt.GetRow(I).BeginEdit()
                    '    GridReceipt.GetRow(I).Cells("IMPORT_STATUS").Value = True
                    '    GridReceipt.GetRow(I).EndEdit()
                    'End If

                Else
                    Application.DoEvents()
                    MainFormApplicationPublic.StatusUpdateLabel(PatientScreenNo & " Imported")
                    MessageBox.Show("Patient " & PatientScreenNo & " was imported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Threading.Thread.Sleep(10)
                Application.DoEvents()
                'Dim GridSys As New Janus.Windows.GridEX.GridEXFormatStyle
                'GridSys.BackColor = Color.AliceBlue
                GridReceipt.Row = I 'GridReceipt.SelectedItems(I).GetRow.Position - 1
                ' MessageBox.Show(DGScreeningBook.Rows(IndexGrid).Cells("PatientNo").Value)
                ' DGScreeningBook.ClearSelection()
                'DGScreeningBook.CurrentCell = DGScreeningBook.Rows(IndexGrid).Cells(0)
                'DGScreeningBook.Rows(IndexGrid).Selected = True
                'DGScreeningBook.BeginEdit(False)
                'DGScreeningBook.CurrentCell = DGScreeningBook.Rows( '.Item(0, IndexGrid)  'DGScreeningBook.Rows(IndexGrid).Cells(0)
            Next
        End If
    End Sub
End Class
