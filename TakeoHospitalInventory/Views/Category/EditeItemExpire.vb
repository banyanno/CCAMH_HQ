Public Class EditeItemExpire
    Dim DA_EditExpire As New DSDepartmentStockTableAdapters.ITEM_EXPIREDATE_DETAILTableAdapter
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If MessageBox.Show("Do you want to update QTY expire?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_EditExpire.UpdateItemQTYExpire(EmptyString(TxtQTY.Text), DateExired.Value.Date, LblExpireID.Text) = 1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class