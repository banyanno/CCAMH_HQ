Public Class NewBrand
    Dim DA_Brand As New DSHospitalRequestToCaritasTableAdapters.ITEM_BRANDTableAdapter
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtBrandName, "", ErrBrandName) = False Then Exit Sub

        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new item brand?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Brand.InsertNewBrand(TxtBrandName.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to save new item brand?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Brand.UpdateBrand(TxtBrandName.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class