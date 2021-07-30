Public Class DashboardTransportation
    Dim DATransaction As New DSCashCollectionTableAdapters.CCAMH_TRANSPORTATIONTableAdapter
    Dim DATransportDetail As New DSCashCollectionTableAdapters.CCAMH_TRANS_DETAILTableAdapter
    Private Sub BtnNewTransportation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewTransportation.Click
        Dim FTran As New FormTransportation
        If FTran.ShowDialog = DialogResult.OK Then
            RefreshClientByNo(FTran.TxtClientNo.Text)
        End If
    End Sub
    Private Sub RefreshClientByNo(ByVal ClientNo As Double)
        GridClientTransportation.DataSource = DATransaction.SelectTransportByClientNo(ClientNo)
    End Sub
    Private Sub RefreshClientDateFromTo(ByVal DFrom As Date, ByVal DTo As Date)
        GridClientTransportation.DataSource = DATransaction.SelectDateFromToTransportation(DFrom.Date, DTo.Date)
    End Sub

    Private Sub DashboardTransportation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshClientDateFromTo(DFrom.Value.Date, DTo.Value.Date)
    End Sub

    Private Sub BtnViewClientTransport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RefreshClientDateFromTo(DFrom.Value.Date, DTo.Value.Date)
    End Sub

    Private Sub btnTransportPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransportPara.Click
        Dim FTransSetting As New FormTransSetting
        FTransSetting.ShowDialog()
    End Sub

    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridTransDetail.FormattingRow

    End Sub

    Private Sub GridClientTransportation_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridClientTransportation.SelectionChanged
        If GridClientTransportation.SelectedItems.Count = 0 Then Exit Sub
        GridTransDetail.DataSource = DATransportDetail.SelectTransDetailByMasterID(GridClientTransportation.GetRow.Cells("TRANSPORT_ID").Value)
    End Sub

    Private Sub BtnUpdateTransport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateTransport.Click

        If GridClientTransportation.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim FTransport As New FormTransportation
            FTransport.IS_UPDATE = True
            FTransport.LblSaveOption.Text = GridClientTransportation.GetRow.Cells("TRANSPORT_ID").Value
            FTransport.DateReceipt.Checked = True
            FTransport.DateReceipt.Value = GridClientTransportation.GetRow.Cells("TRAN_DATE").Value
            FTransport.TxtClientNo.Text = GridClientTransportation.GetRow.Cells("CLIENT_NO").Value
            FTransport.TxtClientName.Text = GridClientTransportation.GetRow.Cells("CLIENT_NAME").Value
            FTransport.TxtClientSex.Text = GridClientTransportation.GetRow.Cells("CLIENT_SEX").Value
            FTransport.TxtClientAge.Text = GridClientTransportation.GetRow.Cells("CLIENT_AGE").Value
            FTransport.TxtAllocateTo.Text = GridClientTransportation.GetRow.Cells("ALLOCATE_TO").Value
            FTransport.CboProvince.Text = GridClientTransportation.GetRow.Cells("TRAN_PROVINCE").Value
            FTransport.TxtAmmount.Text = GridClientTransportation.GetRow.Cells("TRAN_AMOUNT").Value
            FTransport.TxtRemark.Text = GridClientTransportation.GetRow.Cells("TRAN_REMARK").Value
            FTransport.TblTranDetailZTem = DATransportDetail.SelectTransDetailByMasterID(GridClientTransportation.GetRow.Cells("TRANSPORT_ID").Value)
            FTransport.GridTransDetail.DataSource = FTransport.TblTranDetailZTem
            If FTransport.ShowDialog = DialogResult.OK Then
                RefreshClientByNo(FTransport.TxtClientNo.Text)
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub BtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReport.Click
        Dim FReport As New FormTransportReports
        FReport.ShowDialog()
    End Sub

    Private Sub BtnFindClientReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindClientReceipt.Click
        If RadAllClient.Checked = True Then
            GridClientTransportation.DataSource = DATransaction.SelectDateFromToTransportation(DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadByClientNo.Checked = True Then
            GridClientTransportation.DataSource = DATransaction.SelectByClientNo(DFrom.Value.Date, DTo.Value.Date, EmptyString(TxtSearchClientNo.Text))
        ElseIf RadByClientname.Checked = True Then
            GridClientTransportation.DataSource = DATransaction.SelectByClientName(DFrom.Value.Date, DTo.Value.Date, TxtSearchClientName.Text)
        End If
    End Sub

    Private Sub TxtSearchClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSearchClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadByClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByClientNo.CheckedChanged
        TxtSearchClientNo.Enabled = RadByClientNo.Checked
        TxtSearchClientNo.Focus()
        TxtSearchClientNo.SelectAll()
    End Sub

    Private Sub RadByClientname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByClientname.CheckedChanged
        TxtSearchClientName.Enabled = RadByClientname.Checked
        TxtSearchClientName.Focus()
        TxtSearchClientName.SelectAll()
    End Sub

    Private Sub BtnDeleteTransport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteTransport.Click
        If GridClientTransportation.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DATransaction.UpdateDeleteOrUndo(True, GridClientTransportation.GetRow.Cells("TRANSPORT_ID").Value) = 1 Then
                BtnFindClientReceipt_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub BtnUndoTransport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndoTransport.Click
        If GridClientTransportation.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to undo delete?", "Undo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DATransaction.UpdateDeleteOrUndo(False, GridClientTransportation.GetRow.Cells("TRANSPORT_ID").Value) = 1 Then
                BtnFindClientReceipt_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub GridClientTransportation_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridClientTransportation.RowDoubleClick
        BtnUpdateTransport_Click(sender, e)
    End Sub
End Class
