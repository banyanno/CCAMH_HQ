Public Class FormExchangeRateSetting

    Dim DAExchangeRate As New DSSocialEconomicSettingTableAdapters.CCAMH_EXCHANGE_RATETableAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ValidateTextField(TxtSetNewExchangeRate, "", ErrExchange) = False Then Exit Sub
        If MessageBox.Show("Do you want to save new exchange rate?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            DAExchangeRate.DeleteExchangeRate()
            If DAExchangeRate.InsertNewExchangeRate(EmptyString(TxtSetNewExchangeRate.Text)) = 1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
      
    End Sub

    Private Sub TxtSetNewExchangeRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSetNewExchangeRate.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class