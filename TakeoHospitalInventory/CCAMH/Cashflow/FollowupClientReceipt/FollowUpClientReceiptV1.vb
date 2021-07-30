Public Class FollowUpClientReceiptV1

    Dim DAClient As New DSCashCollectionTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim DA_Assessment As New DS_ClientImpressionTableAdapters.CLIENT_CA_SOCIALTableAdapter 'DS_CCAMHClient_ImpressionsTableAdapters.CLIENT_CA_SOCIALTableAdapter
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim DASocialServiceFollowUp As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_OLDSERVICE_PARATableAdapter
    Dim DA_PatientDiagnosis As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim CRNewReceipt As New CRNewClientReceipt
    Dim TblNewReceipt As DataTable
    Dim DA_Diagnosis As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_DIAGNOSISTableAdapter
    Dim DA_THERPIST As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_APPOINTMENT As New DSAssessmentTableAdapters.CCAMH_CLIENT_APPOINTSTableAdapter
    Dim IS_ADD_Service As Boolean = False
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With CboDiagnosis
            .DataSource = DA_Diagnosis.GetData
            .ValueMember = "diagnosis_id"
            .DisplayMember = "diagnosis"
            .SelectedIndex = -1
        End With
        With CboMainTherapy
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub BtnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ' Call when we mouse move on Panel
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientName, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientSex, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientAge, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateCombobox(CboDiagnosis, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateCombobox(CboAppointStatus, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateGroupBox(GBSocialServieType, True) = False Then
            GBSocialServieType.BackColor = Color.Khaki
            Exit Sub
        Else
            GBSocialServieType.BackColor = Color.Transparent
        End If

        If ValidateTextField(TxtReceiptNo, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateDateField(DateReceipt, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtReceiptAmmount, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtAmmountInword, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateCombobox(CboMainTherapy, "", ErrNewReceipt) = False Then Exit Sub
        If CboMainTherapy.SelectedValue Is Nothing Then
            MessageBox.Show("Doesn't have Therapy name in system! pls check name agan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboMainTherapy.Select()
            CboMainTherapy.Focus()
            CboMainTherapy.SelectAll()
            Exit Sub
        End If
        If MessageBox.Show("Do you want to save new receipt?", "New Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ' If ReceiptUtilityModule.CheckDuplicateReceiptNo(EmptyString(TxtReceiptNo.Text)) = True Then
            Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()

            If SaveReceiptAndPrintReceipt() = 1 Then
                'DA_ClientMG.UpdateEnterDiagnosis(LblDiagnosisID.Text, CboDiagnosis.Text, CboDiagnosis.SelectedValue, LblImpression.Text, LblSaveOption.Text)

                Application.DoEvents()
                LblPrinting.Visible = True
                PicLoading.Visible = True
                Application.DoEvents()
                DA_Assessment.UpdateMainTherapy(CInt(IIf(CboMainTherapy.SelectedValue Is Nothing, 0, CboMainTherapy.SelectedValue)), CboMainTherapy.Text, TxtClientNo.Text)
                ' Update appointment ......................................
                '============= Is appointment date call = last visit of client -------------------------------------
                DA_APPOINTMENT.UpdateAppClientVisited("Note from registration.", True, GetDateServer.Date, CboAppointStatus.Text, TxtClientNo.Text, False)
                BGSaveAndPrintReceipt.RunWorkerAsync()
            End If
        End If
    End Sub
    Private Function SaveReceiptAndPrintReceipt() As Integer
        Return DAClientReceipt.InsertFollowupReceiptService(EmptyString(TxtReceiptNo.Text), ReceiptUtilityModule.RECEIPT_FOLLOWUP, ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceA.Checked), ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceB.Checked), ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceC.Checked), False, DateReceipt.Value.Year, GetDateServer.Date, DateReceipt.Value.Date, EmptyString(TxtReceiptAmmount.Text), (EmptyString(TxtReceiptAmmount.Text) / ReceiptUtilityModule.GetExchangeRate), ReceiptUtilityModule.GetExchangeRate, USER_NAME, TxtAmmountInword.Text, TxtClientNo.Text, TxtClientName.Text, TxtClientSex.Text, TxtClientAge.Text, "", "", ReceiptUtilityModule.GetSocialServieType(RadServiceA.Checked, RadServiceB.Checked, RadServiceC.Checked), TxtClientNameKH.Text)
    End Function
    Function GetPriceSocialService() As Double
        Dim tblSocial As DataTable = DASocialServiceFollowUp.SelectActiveServiceOld(True)
        For Each Rows As DataRow In tblSocial.Rows
            If RadServiceA.Checked = True Then
                Return Rows("OLD_PRICE_A")
            ElseIf RadServiceB.Checked = True Then
                Return Rows("OLD_PRICE_B")
            ElseIf RadServiceC.Checked = True Then
                Return Rows("OLD_PRICE_C")
            End If
        Next
    End Function
    Public Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
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
            CboMainTherapy.Text = ""
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
                Try
                    CboMainTherapy.Text = DA_Assessment.GetMainTherapy(TxtClientNo.Text)
                Catch ex As Exception
                    CboMainTherapy.Text = ""
                End Try

                TxtReceiptAmmount.Focus()
                TxtReceiptAmmount.SelectAll()
            Next
            For Each DRowDiag As DataRow In DA_PatientDiagnosis.SelectDiagnosisByClientNo(EmptyString(TxtClientNo.Text))
                'If CboDiagnosis.SelectedValue Is Nothing Then Exit Sub
                'Try
                '    LblDiagnosisID.Text = DA_Diagnosis.SelectDiagnosisID(CboDiagnosis.Text)
                '    LblImpression.Text = DA_Diagnosis.SelectCategoryByDiagnosis(CboDiagnosis.Text)
                'Catch ex As Exception
                '    LblDiagnosisID.Text = ""
                'End Try

                CboDiagnosis.SelectedValue = DRowDiag("DIAGNOSIS_ID")
            Next
        End If
    End Sub

    Private Sub RadServiceA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadServiceA.CheckedChanged
        TxtReceiptAmmount.Text = FormatNumber(GetPriceSocialService(), 2)
    End Sub

    Private Sub RadServiceB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadServiceB.CheckedChanged
        TxtReceiptAmmount.Text = FormatNumber(GetPriceSocialService(), 2)
    End Sub

    Private Sub RadServiceC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadServiceC.CheckedChanged
        TxtReceiptAmmount.Text = FormatNumber(GetPriceSocialService(), 2)
    End Sub

    Private Sub FollowUpClientReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
        DateReceipt.Value = GetDateServer()
    End Sub

    Private Sub TxtReceiptAmmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceiptAmmount.TextChanged
        Dim Riel As New riel()
        Dim Dollar As New dollar()

        Me.TxtAmmountInword.Text = Riel.Convert(Me.TxtReceiptAmmount.Text)
    End Sub

    Private Sub BGSaveAndPrintReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGSaveAndPrintReceipt.DoWork
        TblNewReceipt = DAClientReceipt.SelectCashByReceiptNo(EmptyString(TxtReceiptNo.Text))
    End Sub

    Private Sub BGSaveAndPrintReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGSaveAndPrintReceipt.RunWorkerCompleted
        DoPrintReceipt()
        LblPrinting.Visible = False
        PicLoading.Visible = False
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
    Private Sub DoPrintReceipt()
        Dim FPrintPreview As New PrintPreviewCashReceipt

        Dim ObjCRVReceipt As New CRFollowUpClientReceipt
        ObjCRVReceipt.SetDataSource(TblNewReceipt)
        FPrintPreview.CrystalReportObject = ObjCRVReceipt
        FPrintPreview.IS_PRINT_OLDRECEIPT = True
        FPrintPreview.ShowDialog()

    End Sub

    Private Sub TxtReceiptAmmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptAmmount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtClientNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClientNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            BtnFind_Click(sender, e)
        End If
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboDiagnosis_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDiagnosis.SelectedValueChanged
        'If CboDiagnosis.SelectedValue Is Nothing Then Exit Sub
        Try
            LblDiagnosisID.Text = DA_Diagnosis.SelectDiagnosisID(CboDiagnosis.Text)
            LblImpression.Text = DA_Diagnosis.SelectCategoryByDiagnosis(CboDiagnosis.Text)
        Catch ex As Exception
            LblDiagnosisID.Text = ""
        End Try
    End Sub


   
End Class