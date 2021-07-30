Public Class MoreReceipt
    Dim DAClient As New DSCashCollectionTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        If ValidateTextField(TxtClientNo, "", ErrNewReceipt) = False Then Exit Sub
        Dim TblClient As DataTable = DAClient.SelectClientInfoByClientNo(EmptyString(TxtClientNo.Text))
        If TblClient.Rows.Count = 0 Then
            MessageBox.Show("Wrong client no. Please check again.", "Find Client", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClientNo.Focus()
            TxtClientNo.SelectAll()
            TxtClientName.Text = ""
            TxtClientNameKH.Text = ""
            TxtClientSex.Text = ""
            TxtClientAge.Text = ""
            RadServiceA.Checked = False
            RadServiceB.Checked = False
            RadServiceC.Checked = False

        Else
            For Each DRows As DataRow In TblClient.Rows
                TxtClientName.Text = DRows("CLIENT_NAME")
                TxtClientNameKH.Text = DRows("CLIENT_NAME_KHM")
                TxtClientSex.Text = DRows("CLIENT_SEX")
                TxtClientAge.Text = DRows("CLIENT_AGE")
                If DRows("CLIENT_SOCIAL_SERVICETYPE") = SOCIAL_TYPE_A Then
                    RadServiceA.Checked = True
                ElseIf DRows("CLIENT_SOCIAL_SERVICETYPE") = SOCIAL_TYPE_B Then
                    RadServiceB.Checked = True
                ElseIf DRows("CLIENT_SOCIAL_SERVICETYPE") = SOCIAL_TYPE_C Then
                    RadServiceC.Checked = True
                End If
            Next
           
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientName, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientSex, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientAge, "", ErrNewReceipt) = False Then Exit Sub
        'If ValidateCombobox(CboDiagnosis, "", ErrNewReceipt) = False Then Exit Sub
        'If ValidateCombobox(CboAppointStatus, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateGroupBox(GBSocialServieType, True) = False Then
            GBSocialServieType.BackColor = Color.Khaki
            Exit Sub
        Else
            GBSocialServieType.BackColor = Color.Transparent
        End If

        If ValidateTextField(TxtReceiptNo, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateDateField(DateReceipt, "", ErrNewReceipt) = False Then Exit Sub
        ' If ValidateTextField(TxtReceiptAmmount, "", ErrNewReceipt) = False Then Exit Sub
        ' If ValidateTextField(TxtAmmountInword, "", ErrNewReceipt) = False Then Exit Sub
        'If ValidateCombobox(CboMainTherapy, "", ErrNewReceipt) = False Then Exit Sub
       
        If MessageBox.Show("Do you want to save new receipt?", "New Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ' If ReceiptUtilityModule.CheckDuplicateReceiptNo(EmptyString(TxtReceiptNo.Text)) = True Then
            Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()

            If SaveReceiptAndPrintReceipt() = 1 Then
                'DA_ClientMG.UpdateEnterDiagnosis(LblDiagnosisID.Text, CboDiagnosis.Text, CboDiagnosis.SelectedValue, LblImpression.Text, LblSaveOption.Text)

                'Application.DoEvents()
                'LblPrinting.Visible = True
                'PicLoading.Visible = True
                'Application.DoEvents()
                'DA_Assessment.UpdateMainTherapy(CInt(IIf(CboMainTherapy.SelectedValue Is Nothing, 0, CboMainTherapy.SelectedValue)), CboMainTherapy.Text, TxtClientNo.Text)
                '' Update appointment ......................................
                'DA_APPOINTMENT.UpdateAppClientVisited("Note from registration.", True, GetDateServer.Date, CboAppointStatus.Text, TxtClientNo.Text, False)
                'BGSaveAndPrintReceipt.RunWorkerAsync()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
    Private Function SaveReceiptAndPrintReceipt() As Integer
        Return DAClientReceipt.InsertFollowupReceiptService(EmptyString(TxtReceiptNo.Text), ReceiptUtilityModule.RECEIPT_FOLLOWUP, _
                                                            ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), _
                                                            RadServiceA.Checked), ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceB.Checked), _
                                                        ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceC.Checked), False, _
                                                        DateReceipt.Value.Year, GetDateServer.Date, DateReceipt.Value.Date, EmptyString(TxtReceiptAmmount.Text), _
                                                        (EmptyString(TxtReceiptAmmount.Text) / ReceiptUtilityModule.GetExchangeRate), _
                                                        ReceiptUtilityModule.GetExchangeRate, USER_NAME, TxtAmmountInword.Text, TxtClientNo.Text, _
                                                        TxtClientName.Text, TxtClientSex.Text, TxtClientAge.Text, "", "", _
                                                        ReceiptUtilityModule.GetSocialServieType(RadServiceA.Checked, RadServiceB.Checked, RadServiceC.Checked), TxtClientNameKH.Text)
    End Function

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    'Private Sub RadServiceA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadServiceA.CheckedChanged
    '    TxtReceiptAmmount.Text = FormatNumber(GetPriceSocialService(), 2)
    'End Sub

    'Private Sub RadServiceB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadServiceB.CheckedChanged
    '    TxtReceiptAmmount.Text = FormatNumber(GetPriceSocialService(), 2)
    'End Sub

    'Private Sub RadServiceC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadServiceC.CheckedChanged
    '    TxtReceiptAmmount.Text = FormatNumber(GetPriceSocialService(), 2)
    'End Sub
    'Private Sub MoreReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
    '    DateReceipt.Value = GetDateServer()
    'End Sub

  
    Private Sub MoreReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
        DateReceipt.Value = GetDateServer()
    End Sub

    Private Sub TxtClientNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class