Public Class FormRefer
    Dim DA_Refer As New DS_CCAMH_REFERTableAdapters.CCAMH_REFERTableAdapter
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(TxtRefer, "", ErrRefer) = False Then Exit Sub
        If lblSaveOption.Text = 0 Then
            If MessageBox.Show("Do you want to save new refer?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Refer.InsertNewRefer(TxtRefer.Text, TxtReferNote.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Refer.UpdateRefer(TxtRefer.Text, TxtReferNote.Text, lblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
End Class