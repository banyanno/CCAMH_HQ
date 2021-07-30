Public Class DashboardCCAMHPharmacy
    Dim MainForm As MainAppKTG
    Dim TblPrescription As DataTable
    Dim DA_Presciption As New DSPrescriptionTableAdapters.CCAMH_VIEW_PRESCRIPTIONTableAdapter
    Dim DA_MainPresc As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTIONTableAdapter
    Dim DA_SubPresc As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTION_DETIALTableAdapter
    Sub New(ByVal MainForm As MainAppKTG)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainForm = MainForm
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnNewPrescriptionPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewPrescriptionPrescription.Click
        Dim FPrescription As New FormPrescription
        If FPrescription.ShowDialog() = DialogResult.OK Then
            'FindByClientNo(FPrescription.TxtClientNo.Text, FPrescription.DatePrescription.Value.Date, FPrescription.DatePrescription.Value.Date)
            GridPrescription.DataSource = DA_MainPresc.SelectPrescriptionCurrentdate(Now.Date, Now.Date)
        End If
    End Sub

    Private Sub BtnPrintCashDistribute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintCashDistribute.Click
        If GridPrescription.SelectedItems.Count = 0 Then Exit Sub
        MainForm.StatusLoading(True, "Loading")
        bgPrescription.RunWorkerAsync()
    End Sub

    Private Sub bgPrescription_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgPrescription.DoWork
        TblPrescription = DA_Presciption.SelectPrescription(GridPrescription.GetRow.Cells("PRESC_ID").Value)
    End Sub

    Private Sub bgPrescription_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgPrescription.RunWorkerCompleted
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

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        GridPrescription.DataSource = DA_MainPresc.SelectPrescriptionCurrentdate(Now.Date, Now.Date)
    End Sub
    Public Sub FindPrescriptionAllClient(ByVal DFrom As Date, ByVal DTo As Date)
        GridPrescription.DataSource = DA_MainPresc.SelectPrescriptionCurrentdate(DFrom, DTo)
    End Sub
    Public Sub FindByClientNo(ByVal ClientNo As Double, ByVal DateFrom As Date, ByVal DateTo As Date)
        GridPrescription.DataSource = DA_MainPresc.SelectDateToDateByClientNo(DateFrom.Date, DateTo.Date, ClientNo)
    End Sub
    Public Sub FindByClientName(ByVal ClientName As String, ByVal DFrom As Date, ByVal Dto As Date)
        GridPrescription.DataSource = DA_MainPresc.SelectDateToDateByName(DFrom.Date, Dto.Date, ClientName)
    End Sub

    Private Sub BtnFindPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPrescription.Click
        Dim FFindPresc As New FormFindPrescription(Me)
        FFindPresc.Show()
    End Sub

    Private Sub GridPrescription_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPrescription.SelectionChanged
        If GridPrescription.SelectedItems.Count = 0 Then Exit Sub
        GridPrescriptionDetail.DataSource = DA_Presciption.SelectPrescription(GridPrescription.GetRow.Cells("PRESC_ID").Value)
    End Sub

    Private Sub DashboardCCAMHPharmacy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridPrescription.DataSource = DA_MainPresc.SelectPrescriptionCurrentdate(Now.Date, Now.Date)
    End Sub

    Private Sub BtnEditPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditPrescription.Click
        If GridPrescription.SelectedItems.Count = 0 Then Exit Sub
        If CBool(GridPrescription.GetRow.Cells("IS_RECEIVED").Value) = True Then
            MessageBox.Show("Client already received medicine. you can not update!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim FPrescription As New FormPrescription
        FPrescription.TxtReceiptNo.Text = FPrescription.DA_RECEIPT.GetReceiptNobyPrescriptID(GridPrescription.GetRow.Cells("PRESC_ID").Value)
        FPrescription.LblSaveOption.Text = GridPrescription.GetRow.Cells("PRESC_ID").Value
        FPrescription.PrescriptonID = GridPrescription.GetRow.Cells("PRESC_ID").Value
        FPrescription.TxtClientNo.Text = GridPrescription.GetRow.Cells("CLIENT_NO").Value
        FPrescription.TxtClientName.Text = GridPrescription.GetRow.Cells("CLIENT_NAME").Value
        FPrescription.TxtClientSex.Text = GridPrescription.GetRow.Cells("CLIENT_SEX").Value
        FPrescription.TxtClientAge.Text = GridPrescription.GetRow.Cells("CLIENT_AGE").Value
        FPrescription.DatePrescription.Value = GridPrescription.GetRow.Cells("DATE_PRESCR").Value
        FPrescription.CboDoctor.Text = GridPrescription.GetRow.Cells("DOCTOR_NAME").Value
        FPrescription.TblPresciptionTem = DA_SubPresc.SelectPrescriptionByPreID(GridPrescription.GetRow.Cells("PRESC_ID").Value)
        If TypeOf (GridPrescription.GetRow.Cells("DATE_NEXT_VISIT").Value) Is DBNull Then
            
        Else
            FPrescription.DateNextVisit.Checked = True
            FPrescription.DateNextVisit.Value = GridPrescription.GetRow.Cells("DATE_NEXT_VISIT").Value

        End If
        FPrescription.GridPrescription.DataSource = FPrescription.TblPresciptionTem
        If FPrescription.ShowDialog() = DialogResult.OK Then
            FindByClientNo(FPrescription.TxtClientNo.Text, FPrescription.DatePrescription.Value.Date, FPrescription.DatePrescription.Value.Date)
        End If
    End Sub

   
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click

        If RadClientNo.Checked = True Then
            FindByClientNo(EmptyString(TxtClientNo.Text), DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadAllClient.Checked = True Then
            FindPrescriptionAllClient(DFrom.Value.Date, DTo.Value.Date)

        ElseIf RadClientName.Checked = True Then
            FindByClientName(TxtClientName.Text, DFrom.Value.Date, DTo.Value.Date)
        End If

    End Sub

    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtClientNo.Enabled = RadClientNo.Checked
        TxtClientNo.Focus()
        TxtClientNo.Select()
        TxtClientNo.SelectAll()

    End Sub

    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientName.CheckedChanged
        TxtClientName.Enabled = RadClientName.Checked
        TxtClientName.Focus()
        TxtClientName.Select()
        TxtClientName.SelectAll()
    End Sub

   
    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub GridPrescription_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPrescription.RowDoubleClick
        BtnEditPrescription_Click(sender, e)
    End Sub
End Class
