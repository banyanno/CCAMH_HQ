Public Class FormUnitStaffRepond

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrUnit) = False Then Exit Sub
        If ValidateTextField(TxtClientName, "", ErrUnit) = False Then Exit Sub
        If ValidateTextField(TxtSex, "", ErrUnit) = False Then Exit Sub
        'If ValidateTextField(TxtTel, "", ErrUnit) = False Then Exit Sub
        If ValidateCombobox(CboStaffInunit, "", ErrUnit) = False Then Exit Sub
        If ValidateDateTimePicker(DateCreate, "", ErrUnit) = False Then Exit Sub
        If MessageBox.Show("", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            'ldfjldjflsdjfsdl
        End If

    End Sub
End Class