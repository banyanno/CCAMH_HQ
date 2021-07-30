Imports System.Data.Common
Imports Tulpep.NotificationWindow
Public Class DashboardMedicineSale
    Dim MainForm As MainAppKTG
    Private KTGDataContext As New BaseDataContext
    Private KTGBaseContext As New BaseDataContext
    Dim DA_MainReceipt As New DSPrescriptionTableAdapters.CCAMH_RECEIPTTableAdapter
    'Dim DA_ReceiptMedDetial As New DSPrescriptionTableAdapters.CCAMH_RECEPT_MED_SOCIAL_DETAILTableAdapter
    Public DA_Prescipt As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTIONTableAdapter
    Dim DA_Prescipt_Detial As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTION_DETIALTableAdapter
    Dim DA_Presciption As New DSPrescriptionTableAdapters.CCAMH_VIEW_PRESCRIPTIONTableAdapter
    Dim TblPrescription As DataTable
    Sub New(ByVal MainForm As MainAppKTG)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainForm = MainForm
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub InitPopupMessage(NumberPrescript As Integer)
        Dim objPopup As New PopupNotifier
        objPopup.TitleFont = New Font("Arial", 15, FontStyle.Bold)
        objPopup.TitleColor = Color.BlueViolet
        'objPopup.AnimationInterval = 1000
        objPopup.BodyColor = Color.DarkSalmon

        objPopup.TitleText = "CCAMH ..."
        objPopup.ContentFont = New Font("Arial", 12, FontStyle.Regular)
        ' objPopup.Contentco = New Font("Arial", 12, FontStyle.Regular)
        objPopup.ContentText = "Hello pharmacy. You have (" & NumberPrescript & ") clients are waiting issue medicine. please check....."
        objPopup.Popup()

    End Sub
    Private Sub ProcessCutStock(ByVal ReceiptNo As Double, ByVal ReceiptDate As DateTime)
        KTGDataContext.getTHIDataContext.Connection.Close()
        KTGDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = KTGDataContext.getTHIDataContext.Connection.BeginTransaction
        KTGDataContext.getTHIDataContext.Transaction = trans
        Dim TblRecMedicine As DataTable = DA_Prescipt_Detial.SelectPrescriptionDetailForupdateStock(ReceiptNo, "IN") 'DA_ReceiptMedDetial.SelectReceiptNoWIthItemInCenter(ReceiptNo, "IN")
        

        '--- Insert tblUsed  SALE_DEPART_ID =26
        Dim mytblUsed As New tblUsed

        mytblUsed.UsedDepartID = SALE_DEPART_ID
        mytblUsed.UsedDate = CDate(ReceiptDate).Date  'GetDateServer.Date

        mytblUsed.UsedDescription = "Sold in pharmacy receipt : " & ReceiptNo & " To Client No: " & GridListWaitingMedicine.GetRow.Cells("CLIENT_NO").Value & " Name: " & GridListWaitingMedicine.GetRow.Cells("CLIENT_NAME").Value
        mytblUsed.UsedUserID = CInt(USER_ID)

        KTGDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
        KTGDataContext.getTHIDataContext.SubmitChanges()

        For Each DRow_USED As DataRow In TblRecMedicine.Rows
            Dim itemID As Integer = CInt(DRow_USED("MED_ID"))
            '--- Updata Pharmacy stock
            ' SALE_DEPART_ID
            Dim qDepartStock = From departStock In KTGDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = SALE_DEPART_ID And departStock.ItemID = itemID

            Dim myDepartStock = qDepartStock.SingleOrDefault
            myDepartStock.UnitsInStock = myDepartStock.UnitsInStock - CInt(DRow_USED("MED_QTY"))
            KTGDataContext.getTHIDataContext.SubmitChanges()

            '--- Insert tblUsedDetail
            Dim mytblUsedDetail As New tblUsedDetail
            mytblUsedDetail.UsedID = mytblUsed.UsedID
            mytblUsedDetail.ItemID = itemID
            mytblUsedDetail.UsedQuantity = CInt(DRow_USED("MED_QTY"))

            KTGDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
            KTGDataContext.getTHIDataContext.SubmitChanges()
        Next
        

        trans.Commit()
        KTGDataContext.getTHIDataContext.Connection.Close()

        MessageBox.Show("The update give medicine successfully.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
       
       
    End Sub

    Private Sub DashboardMedicineSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        findClientGiveMedicine()
        ' TimerCheckPrescription.Start()
    End Sub
    Private Sub findClientGiveMedicine()
        If RadAllClient.Checked = True Then
            GridListWaitingMedicine.DataSource = DA_MainReceipt.SelectWaitingGiveMedicine(DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadWaitingMedicine.Checked = True Then
            GridListWaitingMedicine.DataSource = DA_MainReceipt.SelectAllWaitingGiveMedicine(True, False)
        ElseIf RadReceiptNo.Checked = True Then
            GridListWaitingMedicine.DataSource = DA_MainReceipt.SelectWaitingWithReceiptNo(DFrom.Value.Date, DTo.Value.Date, EmptyString(TxtReceiptNo.Text))
        ElseIf RadClientNo.Checked = True Then
            GridListWaitingMedicine.DataSource = DA_MainReceipt.SelectWaitbyPatientNo(EmptyString(TxtClientNo.Text))
        ElseIf RadClientNameKH.Checked = True Then
            GridListWaitingMedicine.DataSource = DA_MainReceipt.SelectPrescriptByKhName(TxtClientNameKH.Text)
        ElseIf RadClientNameEng.Checked = True Then
            GridListWaitingMedicine.DataSource = DA_MainReceipt.SelectPrescriptByClientNameEng(TxtClientNameEng.Text)
        End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        findClientGiveMedicine()
    End Sub

    Private Sub GridListWaitingMedicine_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridListWaitingMedicine.SelectionChanged
        Try
            GridPrescription.DataSource = DA_Prescipt_Detial.SelectMedicineByReceiptNo(GridListWaitingMedicine.GetRow.Cells("RECEIPT_NO").Value)
        Catch ex As Exception
            GridPrescription.DataSource = Nothing
        End Try
    End Sub

    Private Sub BtnGiveMedicine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGiveMedicine.Click
        'MessageBox.Show(SALE_DEPART_ID)
        If SALE_DEPART_ID <> 26 Then
            MessageBox.Show("You are can not give medicine. Because you are login wrong department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If GridListWaitingMedicine.SelectedItems.Count = 0 Then Exit Sub
        If CBool(GridListWaitingMedicine.GetRow.Cells("IS_GIVE_MEDICINCE").Value) = True Then
            MessageBox.Show("The client already give medicine.", "Give", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Do you want to give medicine?", "Give", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            BtnGiveMedicine.Enabled = False
            ProcessCutStock(GridListWaitingMedicine.GetRow.Cells("RECEIPT_NO").Value, GridListWaitingMedicine.GetRow.Cells("DATE_RECEIPT").Value)
            DA_MainReceipt.UpdateSatatusGiveMedicine(True, CDbl(GridListWaitingMedicine.GetRow.Cells("RECEIPT_ID").Value))
            'DEP_EOD.BtnEndofDay_Click(sender, e)
            findClientGiveMedicine()
            BtnGiveMedicine.Enabled = True
        End If

    End Sub

    Private Sub RadReceiptNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReceiptNo.CheckedChanged
        TxtReceiptNo.Enabled = RadReceiptNo.Checked
        TxtReceiptNo.Focus()
        TxtReceiptNo.SelectAll()
    End Sub

    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtClientNo.Enabled = RadClientNo.Checked
        TxtClientNo.Focus()
        TxtClientNo.SelectAll()
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RadWaitingMedicine.Checked = True
        findClientGiveMedicine()
    End Sub

    Private Sub BtnMedicineOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMedicineOut.Click
        Dim FListMedicineOutside As New FormListMedicineOutsite
        FListMedicineOutside.ShowDialog()
    End Sub

    Private Sub GridListWaitingMedicine_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridListWaitingMedicine.RowDoubleClick
        BtnGiveMedicine_Click(sender, e)
    End Sub

    Private Sub TxtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If GridListWaitingMedicine.SelectedItems.Count = 0 Then Exit Sub
        MainForm.StatusLoading(True, "Loading")
        bgPrescription.RunWorkerAsync()
    End Sub

    Private Sub bgPrescription_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgPrescription.DoWork
        TblPrescription = DA_Presciption.SelectPrescriptionByReceiptNo(GridListWaitingMedicine.GetRow.Cells("RECEIPT_NO").Value)
    End Sub

    Private Sub bgPrescription_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgPrescription.RunWorkerCompleted
        BtnGiveMedicine.Enabled = True
        DoPrint()
        MainForm.StatusLoading(False, "")

    End Sub
    Private Sub DoPrint()
        Dim FPrintPreview As New PrintPreviewCashReceipt
        Dim ObjCRVReceipt As New CrvPrescription
        ObjCRVReceipt.SetDataSource(TblPrescription)
        FPrintPreview.CrystalReportObject = ObjCRVReceipt
        FPrintPreview.IS_PRINT_PRESCRIPTION = True
        FPrintPreview.ShowDialog()

    End Sub
    Dim TotalWaitingPrescript As Double = 0
    
    'Private Sub TimerCheckPrescription_Tick(sender As Object, e As EventArgs) Handles TimerCheckPrescription.Tick
    '    TotalWaitingPrescript = DA_MainReceipt.TotalWaitingPrescript(False)
    '    If TotalWaitingPrescript > 0 Then
    '        InitPopupMessage(TotalWaitingPrescript)
    '    End If
    'End Sub

    Private Sub RadClientNameKH_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientNameKH.CheckedChanged
        TxtClientNameKH.Enabled = RadClientNameKH.Checked
        TxtClientNameKH.Focus()
        TxtClientNameKH.Select()

    End Sub

    Private Sub RadClientNameEng_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientNameEng.CheckedChanged
        TxtClientNameEng.Enabled = RadClientNameEng.Checked
        TxtClientNameEng.Focus()
        TxtClientNameEng.Select()
    End Sub

    Private Sub TxtClientNameKH_Enter(sender As Object, e As EventArgs) Handles TxtClientNameKH.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub TxtClientNameEng_Enter(sender As Object, e As EventArgs) Handles TxtClientNameEng.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub TxtReceiptNo_Enter(sender As Object, e As EventArgs) Handles TxtReceiptNo.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub TxtClientNo_Enter(sender As Object, e As EventArgs) Handles TxtClientNo.Enter
        SetEnglishLanguage()
    End Sub

   
    Private Sub BtnEidtMedicinePrescription_Click(sender As Object, e As EventArgs) Handles BtnEidtMedicinePrescription.Click
        If GridListWaitingMedicine.SelectedItems.Count = 0 Then Exit Sub

        If CBool(GridListWaitingMedicine.GetRow.Cells("IS_GIVE_MEDICINCE").Value) = True Then
            MessageBox.Show("The client already give medicine.", "Give", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If GridPrescription.SelectedItems.Count = 0 Then Exit Sub

        Dim FEditMedicinePrescrip As New FormEditPrescription
        FEditMedicinePrescrip.LblPrescriptDedtail.Text = GridPrescription.GetRow.Cells("PRESC_DETIAL_ID").Value
        FEditMedicinePrescrip.CboMedicine.SelectedValue = GridPrescription.GetRow.Cells("MED_ID").Value
        FEditMedicinePrescrip.CboMedicine.Text = GridPrescription.GetRow.Cells("MED_NAME").Value
        FEditMedicinePrescrip.CboUsageM.Text = GridPrescription.GetRow.Cells("MED_M").Value
        FEditMedicinePrescrip.CboUsageN.Text = GridPrescription.GetRow.Cells("MED_N").Value
        FEditMedicinePrescrip.CboUsageE.Text = GridPrescription.GetRow.Cells("MED_E").Value
        FEditMedicinePrescrip.TxtTotalQTY.Text = GridPrescription.GetRow.Cells("MED_QTY").Value
        FEditMedicinePrescrip.TxtEditPrescriptNote.Text = IIf(IsDBNull(GridPrescription.GetRow.Cells("PRESCRIPT_NOTE_EDIT").Value), "", GridPrescription.GetRow.Cells("PRESCRIPT_NOTE_EDIT").Value)
        If FEditMedicinePrescrip.ShowDialog = DialogResult.OK Then
            GridListWaitingMedicine_SelectionChanged(sender, e)
        End If
    End Sub
End Class
