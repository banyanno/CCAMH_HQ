Public Class DashboardCashSetting

    Dim DAServiceNew As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_NEWSERVIEC_PARATableAdapter
    Dim DAServiceOld As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_OLDSERVICE_PARATableAdapter
    Dim DAServiceMed As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_MEDICINCE_PARATableAdapter
    Dim DAServiceSpacial As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_SPACIALSERVICE_PARATableAdapter
    Dim DAExchangeRate As New DSSocialEconomicSettingTableAdapters.CCAMH_EXCHANGE_RATETableAdapter
    Private Sub BtnSocialReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSocialReceipt.Click
        Dim FSocialSetting As New FormSocialServiceSetting
        FSocialSetting.ShowDialog()
    End Sub

    

    Private Sub RefreshSocialService()
        Dim TblServiceNew As DataTable = DAServiceNew.SelectServiceActiveNew(True)
        Dim TblServiceOld As DataTable = DAServiceOld.SelectActiveServiceOld(True)
        Dim TblServiceMed As DataTable = DAServiceMed.SelectServiceActiveMed(True)
        Dim TblServiceSp As DataTable = DAServiceSpacial.SelectServiceActiveSpacial(True)
        Dim TblExchangeRate As DataTable = DAExchangeRate.GetData
        For Each RowsNew As DataRow In TblServiceNew.Rows
            LblServiceNewA.Text = RowsNew("NEW_PRICE_A") & " ៛"
            LblServiceNewB.Text = RowsNew("NEW_PRICE_B") & " ៛"
            LblServiceNewC.Text = RowsNew("NEW_PRICE_C") & " ៛"
        Next
        For Each RowsOld As DataRow In TblServiceOld.Rows
            LblServiceOldA.Text = RowsOld("OLD_PRICE_A") & " ៛"
            LblServiceOldB.Text = RowsOld("OLD_PRICE_B") & " ៛"
            LblServiceOldC.Text = RowsOld("OLD_PRICE_C") & " ៛"

        Next
        For Each RowsMed As DataRow In TblServiceMed.Rows
            LblServiceMedA.Text = RowsMed("MEDIC_PRICE_A") & " ៛"
            LblServiceMedB.Text = RowsMed("MEDIC_PRICE_B") & " ៛"
            LblServiceMedC.Text = RowsMed("MEDIC_PRICE_C") & " ៛"

        Next
        For Each RowSp As DataRow In TblServiceSp.Rows
            LblServiceSpacialA.Text = RowSp("SP_PRICE_A") & " ៛"
            LblServiceSpacialB.Text = RowSp("SP_PRICE_B") & " ៛"
            LblServiceSpacialC.Text = RowSp("SP_PRICE_C") & " ៛"
        Next
        For Each RowExchange As DataRow In TblExchangeRate.Rows
            TxtExchangeRate.Text = RowExchange("EXCHANGE_VALUE") & " ៛"
        Next
    End Sub

    Private Sub BtnServiceSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnServiceSetting.Click
        RefreshSocialService()
    End Sub

    Private Sub BtnExchangeRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExchangeRate.Click
        Dim FExchangeRate As New FormExchangeRateSetting
        If FExchangeRate.ShowDialog = DialogResult.OK Then

            Dim TblExchangeRate As DataTable = DAExchangeRate.GetData
            For Each RowExchange As DataRow In TblExchangeRate.Rows
                TxtExchangeRate.Text = RowExchange("EXCHANGE_VALUE") & " ៛"
            Next
        End If
    End Sub

    Private Sub BtnMedicinceSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMedicinceSetting.Click
        Dim FSocialMedicince As New FormSocialMedicinceSetting
        FSocialMedicince.ShowDialog()
    End Sub

    Private Sub BtnSpacialServiceSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSpacialServiceSetting.Click
        Dim FSpacialServiceSetting As New SpacialServiceSetting
        FSpacialServiceSetting.ShowDialog()
    End Sub
End Class
