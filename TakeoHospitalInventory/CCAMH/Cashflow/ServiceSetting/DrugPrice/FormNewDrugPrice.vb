Public Class FormNewDrugPrice
    Dim DA_Items As New DSDrugPriceSettingTableAdapters.tblItemTableAdapter
    Dim DA_Drugprice As New DSDrugPriceSettingTableAdapters.tblItemPriceTableAdapter
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If ValidateTextField(TxtMedicinceName, "", ErrDrugPriceSetting) = False Then Exit Sub
        If ValidateTextField(TxtServiceMedA, "", ErrDrugPriceSetting) = False Then Exit Sub
        If ValidateTextField(TxtServiceMedB, "", ErrDrugPriceSetting) = False Then Exit Sub
        If ValidateTextField(TxtServiceMedC, "", ErrDrugPriceSetting) = False Then Exit Sub
        If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_Drugprice.UpdateDrugPrice(EmptyString(TxtServiceMedA.Text), EmptyString(TxtServiceMedB.Text), EmptyString(TxtServiceMedC.Text), LblSaveMedic.Text) = 1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class