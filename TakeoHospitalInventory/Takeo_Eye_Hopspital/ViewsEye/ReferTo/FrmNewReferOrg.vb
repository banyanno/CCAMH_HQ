Public Class FrmNewReferOrg

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If ValidateTextField(TxtReferName, "", ErrReferto) = False Then Exit Sub

        If lblSaveOption.Text = "0" Then
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = System.Windows.Forms.DialogResult.Yes Then
                If ModRefer.SaveRefer(TxtReferName.Text.Trim, TxtNote.Text.Trim) = 1 Then
                    MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = System.Windows.Forms.DialogResult.Yes Then
                If ModRefer.UpdateRefer(lblSaveOption.Text, TxtReferName.Text, TxtNote.Text.Trim) = 1 Then
                    MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class