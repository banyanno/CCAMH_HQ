Public Class FormPROGNOSIS
    Dim ds_prognosis As New DS_CCAMHPrognosisTableAdapters.CCAMH_PROGNOSISTableAdapter
    Private Sub btnPROGCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPROGCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnPROGSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPROGSave.Click
        If MessageBox.Show("Do you really want to save the client information?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            ds_prognosis.savePrognosis(tbxPROGNOSIS.Text, tbxPROGMisc.Text) '(tbxSSDetail.Text, tbxSSCharge.Text, tbxSSMisc.Text) '(cbbxClientNo.Text, tbxSocialWorker.Text, tbxMisc.Text)
            MessageBox.Show("Client successfully saved!", "Prognosis Detail", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            MessageBox.Show("Error Prognosis Information. Please verify data and enter it again!", "Prognosis", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class