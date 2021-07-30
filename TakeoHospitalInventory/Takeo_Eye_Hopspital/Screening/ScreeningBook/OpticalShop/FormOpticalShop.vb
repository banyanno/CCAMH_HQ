Public Class FormOpticalShop
    Public DAOpticalShopBook As New DataSetScreeningBookTableAdapters.SCREENING_OPTICALSHOP_BOOKTableAdapter
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new optical shop?", "Screening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DAOpticalShopBook.InsertNewOpticalShop(LblScreenBookID.Text, DateScreening.Value.Date, PatientNo.Text, TxtMoreInfo.Text, False) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
            
        Else
            If MessageBox.Show("D you want to update?", "Screening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DAOpticalShopBook.UpdateOpShop(DateScreening.Value.Date, TxtMoreInfo.Text, LblScreenBookID.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
            
        End If
    End Sub
End Class