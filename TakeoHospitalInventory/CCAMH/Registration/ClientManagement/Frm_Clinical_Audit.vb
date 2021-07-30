Public Class Frm_Clinical_Audit

    Dim DA_ClientMG As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim DA_Client_Social As New DS_CCAMHClientRegistrationTableAdapters.CLIENT_CA_SOCIALTableAdapter
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim client_no As Decimal = Decimal.Parse(hidden_client_no.Text)
        Dim is_audit As Boolean = 0
        If chbNo.Checked Then
            is_audit = 0
        End If
        If chbYes.Checked Then
            is_audit = 1
        End If

        DA_Client_Social.UpdateClinicalAudit(is_audit, client_no)
        DA_ClientMG.UpdateClinicalAudit(is_audit, client_no)
        MessageBox.Show("Data has been modified!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Private Sub chbNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbNo.CheckedChanged
        If chbNo.Checked Then
            chbYes.Checked = False
        End If
    End Sub

    Private Sub chbYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbYes.CheckedChanged
        If chbYes.Checked Then
            chbNo.Checked = False
        End If
    End Sub
End Class