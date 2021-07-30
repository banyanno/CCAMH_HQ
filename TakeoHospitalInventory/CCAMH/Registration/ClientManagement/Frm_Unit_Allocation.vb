Public Class Frm_Unit_Allocation
    Dim DA_ClientMG As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim DA_Client_Social As New DS_CCAMHClientRegistrationTableAdapters.CLIENT_CA_SOCIALTableAdapter

    Private Sub Frm_Unit_Allocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  MessageBox.Show(hidden_client_no.Text)
    End Sub

    Private Sub btnUnitSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitSave.Click
        Dim unit1, unit2 As Decimal
        Dim client_no As Decimal = Decimal.Parse(hidden_client_no.Text)
        If Trim(txtUnit1.Text) = "" Then
            unit1 = 0
        Else
            unit1 = Decimal.Parse(txtUnit1.Text)
        End If
        If Trim(txtUnit2.Text) = "" Then
            unit2 = 0
        Else
            unit2 = Decimal.Parse(txtUnit2.Text)
        End If

        If unit1 <> 0 Or unit2 <> 0 Then
            DA_Client_Social.UpdateUnitAllocation(unit1, unit2, client_no)
            DA_ClientMG.UpdateUnitAllocation(client_no)
            MessageBox.Show("Data has been modified!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub txtUnit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnit1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUnit2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnit2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

End Class