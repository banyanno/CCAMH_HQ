
Public Class FormSocialStatus
    Dim ds_se As New DS_SocialEconomicTableAdapters.CCAMH_SOCIAL_ECONOTableAdapter
    Private Sub btnSTCanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSTCanel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSTSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSTSave.Click
        If MessageBox.Show("Do you really want to save the client information?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            ' Function save new pateint register and screening book

            'If saveCCAMHClientInfo() = True Then
            '    MessageBox.Show("Client successfully saved!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '    'If IS_ONSCRENNING = True Then
            '    '    Me.DashScreeningRegis.RefreshAfterScreenRegis(DateRegis.Value.Date, DateRegis.Value.Date, PatientNo.Text)
            '    'End If
            '    'If ChPrintRegistration.Checked = True Then
            '    '    UIMainScreening.StatusLoading(True, "Loading")
            '    '    BgLoadingform.RunWorkerAsync()
            '    'Else
            '    '    ResetFormRegister()
            '    'End If

            'Else
            ds_se.saveSocialStatus(tbxSSDetail.Text, tbxSSCharge.Text, tbxSSMisc.Text) '(cbbxClientNo.Text, tbxSocialWorker.Text, tbxMisc.Text)
            MessageBox.Show("Client successfully saved!", "Social Detail", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            MessageBox.Show("Error Client Information. Please verify data and enter it again!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class