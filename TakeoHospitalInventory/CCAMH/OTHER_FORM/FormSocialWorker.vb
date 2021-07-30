Public Class FORM_SOCIALWORKER
    Dim ds_socialworker As New DS_SocialWorkerTableAdapters.CCAMH_SOCIAL_WORKERTableAdapter
    Dim clientNo As New DS_SocialWorkerTableAdapters.CCAMH_CLIENTSTableAdapter
    Private Sub FORM_SOCIALWORKER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cbbxClientNo
            .DataSource = clientNo.getClientNo
            .ValueMember = "CLIENT_NO"
            .DisplayMember = "CLIENT_NO"
        End With
    End Sub

    Private Sub btnSWSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSWSave.Click
        'ds_socialworker.saveSocialWorker(cbbxClientNo.Text, tbxSocialWorker.Text, tbxMisc.Text)

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
            ds_socialworker.saveSocialWorker(cbbxClientNo.Text, tbxSocialWorker.Text, tbxMisc.Text)
            MessageBox.Show("Client successfully saved!", "Social Worker", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            MessageBox.Show("Error Client Information. Please verify data and enter it again!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnSWCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSWCancel.Click
        Me.Dispose()
    End Sub
End Class