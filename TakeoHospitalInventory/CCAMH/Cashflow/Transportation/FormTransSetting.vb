Public Class FormTransSetting
    Dim DATRAN_SETTING As New DSCashCollectionTableAdapters.CCAMH_TRANS_OFFER_PARATableAdapter
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub TxtAmmountOffer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmmountOffer.KeyPress
        SetDisableKeyString(e)
    End Sub
    Private Sub RefreshTranPara()
        GridClientTransportation.DataSource = DATRAN_SETTING.GetData
        CleanForm()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtOffer, "", ErrSetting) = False Then Exit Sub
        If ValidateTextField(TxtAmmountOffer, "", ErrSetting) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DATRAN_SETTING.InsertNewTransPara(TxtOffer.Text, EmptyString(TxtAmmountOffer.Text)) = 1 Then

                    RefreshTranPara()
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DATRAN_SETTING.UpdateTransPara(TxtOffer.Text, EmptyString(TxtAmmountOffer.Text), LblSaveOption.Text) = 1 Then
                    RefreshTranPara()
                End If
            End If
        End If
    End Sub

    Private Sub FormTransSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshTranPara()
    End Sub

    Private Sub GridClientTransportation_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridClientTransportation.RowDoubleClick
        If GridClientTransportation.SelectedItems.Count = 0 Then Exit Sub
        LblSaveOption.Text = GridClientTransportation.GetRow.Cells("TRANS_OFFER_ID").Value
        TxtOffer.Text = GridClientTransportation.GetRow.Cells("TRANS_OFFER").Value
        TxtAmmountOffer.Text = GridClientTransportation.GetRow.Cells("TRANS_AMMOUNT").Value

    End Sub
    Private Sub CleanForm()
        LblSaveOption.Text = "0"
        TxtOffer.Text = ""
        TxtAmmountOffer.Text = ""
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If GridClientTransportation.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DATRAN_SETTING.DeleteTranPara(GridClientTransportation.GetRow.Cells("TRANS_OFFER_ID").Value) = 1 Then
                RefreshTranPara()
            End If
        End If
    End Sub
End Class