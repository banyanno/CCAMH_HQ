Public Class NewClientReceipt

    Dim DAClient As New DSCashCollectionTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim DASocialServiceNew As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_NEWSERVIEC_PARATableAdapter
  
    Dim CRNewReceipt As New CRNewClientReceipt
    Dim TblNewReceipt As DataTable
    Dim AmmountA As Double = 0
    Dim AmmountB As Double = 0
    Dim AmmountC As Double = 0
    Function GetPriceSocialService() As Double
        Dim tblSocial As DataTable = DASocialServiceNew.SelectServiceActiveNew(True)
        For Each Rows As DataRow In tblSocial.Rows
            If RadServiceA.Checked = True Then
                Return Rows("NEW_PRICE_A")
            ElseIf RadServiceB.Checked = True Then
                Return Rows("NEW_PRICE_B")
            ElseIf RadServiceC.Checked = True Then
                Return Rows("NEW_PRICE_C")
            End If
        Next
    End Function
    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub NewClientReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
        DateReceipt.Value = GetDateServer()
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindingClientNo()
    End Sub
    Private Sub FindingClientNo()
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
                If DRows("CLIENT_SOCIAL_SERVICETYPE") = ReceiptUtilityModule.SOCIAL_TYPE_A Then
                    RadServiceA.Checked = True
                ElseIf DRows("CLIENT_SOCIAL_SERVICETYPE") = ReceiptUtilityModule.SOCIAL_TYPE_B Then
                    RadServiceB.Checked = True
                ElseIf DRows("CLIENT_SOCIAL_SERVICETYPE") = ReceiptUtilityModule.SOCIAL_TYPE_C Then
                    RadServiceC.Checked = True
                End If
                TxtReceiptAmmount.Focus()
                TxtReceiptAmmount.SelectAll()
            Next
        End If
    End Sub
    Private Sub TxtReceiptAmmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceiptAmmount.TextChanged
        Dim Riel As New riel()
        Dim Dollar As New dollar()

        Me.TxtAmmountInword.Text = Riel.Convert(Me.TxtReceiptAmmount.Text)


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

    Private Sub TxtReceiptAmmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptAmmount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientName, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientSex, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtClientAge, "", ErrNewReceipt) = False Then Exit Sub

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
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new receipt?", "New Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                'If ReceiptUtilityModule.CheckDuplicateReceiptNo(EmptyString(TxtReceiptNo.Text)) = True Then
                Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
                'End If
                If SaveNewReceiptAndPrintReceipt() = 1 Then
                    Application.DoEvents()
                    LblPrinting.Visible = True
                    PicLoading.Visible = True
                    Application.DoEvents()
                    BGSaveAndPrintReceipt.RunWorkerAsync()

                End If
            End If
        Else
            If MessageBox.Show("Do you want to udpate new receipt?", "New Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                If SaveNewReceiptAndPrintReceipt() = 1 Then
                    Application.DoEvents()
                    LblPrinting.Visible = True
                    PicLoading.Visible = True
                    Application.DoEvents()
                    BGSaveAndPrintReceipt.RunWorkerAsync()

                End If
            End If

        End If
        
    End Sub
    Private Function SaveNewReceiptAndPrintReceipt() As Integer
        Return DAClientReceipt.InsertNewReceiptService(EmptyString(TxtReceiptNo.Text), ReceiptUtilityModule.RECEIPT_NEW, GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceA.Checked), GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceB.Checked), GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceC.Checked), False, DateReceipt.Value.Year, GetDateServer.Date, DateReceipt.Value.Date, EmptyString(TxtReceiptAmmount.Text), (EmptyString(TxtReceiptAmmount.Text) / 4100), 4100, USER_NAME, TxtAmmountInword.Text, TxtClientNo.Text, TxtClientName.Text, TxtClientSex.Text, TxtClientAge.Text, "", "", ReceiptUtilityModule.GetSocialServieType(RadServiceA.Checked, RadServiceB.Checked, RadServiceC.Checked), TxtClientNameKH.Text)
    End Function

   

    Private Sub BGSaveAndPrintReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGSaveAndPrintReceipt.DoWork
        TblNewReceipt = DAClientReceipt.SelectCashByReceiptNo(EmptyString(TxtReceiptNo.Text))
    End Sub
    Private Sub DoPrintReceipt()
        Dim FPrintPreview As New PrintPreviewCashReceipt

        Dim CRNewReceipt As New CRNewClientReceipt
        CRNewReceipt.SetDataSource(TblNewReceipt)
        FPrintPreview.CrystalReportObject = CRNewReceipt
        CRNewReceipt.SetParameterValue("title", Now.Date)
        FPrintPreview.IS_PRINT_NEWRECEIPT = True
        FPrintPreview.ShowDialog()
        CleanFormNewReceipt()
        FPrintPreview.Close()
    End Sub
    Private Sub BGSaveAndPrintReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGSaveAndPrintReceipt.RunWorkerCompleted
        DoPrintReceipt()
        LblPrinting.Visible = False
        PicLoading.Visible = False

    End Sub
    Private Sub CleanFormNewReceipt()
        TxtClientNo.Text = ""
        TxtClientName.Text = ""
        TxtClientAge.Text = ""
        TxtClientSex.Text = ""
        RadServiceA.Checked = False
        RadServiceB.Checked = False
        RadServiceC.Checked = False
        Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
        TxtReceiptAmmount.Text = 0
        TxtAmmountInword.Text = ""
        TxtRecieveBy.Text = USER_NAME
    End Sub

    Private Sub TxtClientNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClientNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            BtnFind_Click(sender, e)
        End If

    End Sub
End Class