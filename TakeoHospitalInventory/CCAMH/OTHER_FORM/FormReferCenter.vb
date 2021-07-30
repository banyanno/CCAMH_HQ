Public Class FormReferCenter
    Dim ds_refercenter As New DS_CCAMHReferCenterTableAdapters.CCAMH_REFER_PARAMETERTableAdapter
    Private Sub btnRCCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnRCSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCSave.Click
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
            ' ds_se.saveSocialStatus(tbxSSDetail.Text, tbxSSCharge.Text, tbxSSMisc.Text) '(cbbxClientNo.Text, tbxSocialWorker.Text, tbxMisc.Text)
            ds_refercenter.saveReferredCenter(tbxReferredMisc.Text, tbxReferredName.Text)
            MessageBox.Show("Referred Center successfully saved!", "Referred Center Detail", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            MessageBox.Show("Error Referred center Information. Please verify data and enter it again!", "Referred Center", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class