Public Class Education

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(txtEducation, "", ErrorEducation) = False Then Exit Sub


        If lblEduSave.Text = "0" Then
            Dim diaglogSave As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaglogSave = System.Windows.Forms.DialogResult.Yes Then
                If MEducation.InsertEducation(txtEducation.Text) = 1 Then
                    MsgBox(MSG_SAVE, MsgBoxStyle.Information, "Save")
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If

            End If
        Else
            Dim DialogUpdate As DialogResult = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DialogUpdate = System.Windows.Forms.DialogResult.Yes Then
                If MEducation.UpdateEduation(lblEduSave.Text, txtEducation.Text) = 1 Then
                    MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If

        'Dim frmClientRegistration As New FormClientRegistration
        'FormClientRegistration_Load()
    End Sub

End Class