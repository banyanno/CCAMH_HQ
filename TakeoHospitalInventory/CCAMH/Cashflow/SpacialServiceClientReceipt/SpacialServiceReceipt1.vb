Imports Janus.Windows.GridEX

Public Class SpacialServiceReceipt1

    Dim DAClient As New DSCashCollectionTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim TblSpacialServiceTem As DataTable = New DSCashCollection.CCAMH_RECEPT_SPACIAL_SOCIAL_DETAILDataTable
    Dim DA_Spacial_ReceiptDetail As New DSCashCollectionTableAdapters.CCAMH_RECEPT_SPACIAL_SOCIAL_DETAILTableAdapter
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim DASkill As New DSSocialEconomicSettingTableAdapters.CCAMH_SKILLTableAdapter
    Dim DASpacialService As New DSSocialEconomicSettingTableAdapters.CCAMH_SPACIAL_SERVICE_PACKAGETableAdapter
    Dim TblNewReceipt As DataTable
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboSkill
            .DataSource = DASkill.GetData
            .ValueMember = "SKILL_ID"
            .DisplayMember = "SKILL_NAME"
            .SelectedIndex = -1
        End With

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


    Private Sub LoadSocialService(ByVal PackageID As Integer)
        Try
            Dim TblSpacialService As DataTable = DASpacialService.SelectBySocialServiceID(PackageID)
            For Each drows As DataRow In TblSpacialService.Rows
                LblSpacialID.Text = CboPackage.SelectedValue
                LblSpacialName.Text = drows("PACKAGE_NAME")
                If RadServiceA.Checked = True Then
                    TxtSpacialServicePrice.Text = drows("PACKAGE_A")
                    LblSocialType.Text = "A"
                ElseIf RadServiceB.Checked = True Then
                    TxtSpacialServicePrice.Text = drows("PACKAGE_B")
                    LblSocialType.Text = "B"
                ElseIf RadServiceC.Checked = True Then
                    TxtSpacialServicePrice.Text = drows("PACKAGE_C")
                    LblSocialType.Text = "C"
                End If

            Next
        Catch ex As Exception


        End Try
    End Sub

    Private Sub LoadServicePackage(ByVal SkillID As Integer)
        With CboPackage
            .DataSource = DASpacialService.SelectSpacialBySkillID(SkillID)
            .ValueMember = "SKILL_SERVICE_ID"
            .DisplayMember = "PACKAGE_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click

        CallAddSpacialService()

    End Sub
    Private Sub CallAddSpacialService()
        If ValidateCombobox(CboSkill, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateCombobox(CboPackage, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtSpacialServicePrice, "", ErrNewReceipt) = False Then Exit Sub
        If CboSkill.SelectedValue Is Nothing Then
            MessageBox.Show("Please select the correct skill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboSkill.Focus()
            CboSkill.SelectAll()
            Exit Sub
        End If
        If CboPackage.SelectedValue Is Nothing Then
            MessageBox.Show("Please select the correct skill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboPackage.Focus()
            CboPackage.SelectAll()
            Exit Sub
        End If

        If CheckExistingItemSpacialService(CboSkill.SelectedValue.ToString) = True Then
            MessageBox.Show("The skill already add to list. Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboSkill.Focus()
            CboSkill.SelectAll()
            Exit Sub
        Else
            AddTemSpacialService(CboSkill.SelectedValue, CboSkill.Text, CboPackage.SelectedValue, CboPackage.Text, EmptyString(TxtSpacialServicePrice.Text), LblSocialType.Text)
        End If


    End Sub
    Function CheckExistingItemSpacialService(ByVal ItemId As Integer) As Boolean
        For Each row As Janus.Windows.GridEX.GridEXRow In GridServiceMed.GetRows
            If row.Cells("SKILL_ID").Value = ItemId Then
                Return True
                Exit Function
                'Else
                '    Return False
            End If
        Next
    End Function
    '================ Add item ================================
    Private Sub AddTemSpacialService(ByVal SKILL_ID As Integer, ByVal SKILL_NAME As String, ByVal PACKAGE_ID As Integer, ByVal PACKAGE_NAME As String, ByVal PACKAGE_PRICE As Integer, ByVal SocialType As String)
        Dim Drow As DataRow = TblSpacialServiceTem.NewRow
        Drow("SKILL_ID") = SKILL_ID
        Drow("SKILL_NAME") = SKILL_NAME
        Drow("PACKAGE_ID") = PACKAGE_ID
        Drow("PACKAGE_NAME") = PACKAGE_NAME
        Drow("PACKAGE_PRICE") = PACKAGE_PRICE
        Drow("PACKAGE_TYPE") = SocialType

        TblSpacialServiceTem.Rows.Add(Drow)
        RefreshAddTemSpacialService()
        TotalReceiptSpacialService()
        CleanFormSpacialService()
    End Sub
    Private Sub TotalReceiptSpacialService()
        Dim TotalAmount As Double = 0
        For Each GRow As GridEXRow In Me.GridServiceMed.GetRows
            TotalAmount = TotalAmount + CDbl(GRow.Cells("PACKAGE_PRICE").Value)
        Next
        TxtReceiptAmmount.Text = FormatNumber(TotalAmount)

    End Sub
    Private Sub CleanFormSpacialService()
        CboSkill.SelectedIndex = -1
        CboSkill.Text = ""
        TxtSpacialServicePrice.Text = ""
        LblSpacialID.Text = ""
        LblSpacialName.Text = ""
        LblServicePrice.Text = ""
        LblSocialType.Text = ""
        CboPackage.SelectedIndex = -1
        CboPackage.Text = ""
        CboSkill.Focus()
        CboSkill.SelectAll()
    End Sub
    Private Sub RefreshAddTemSpacialService()
        Try
            GridServiceMed.Refetch()
            GridServiceMed.DataSource = TblSpacialServiceTem
        Catch ex As Exception

        End Try

    End Sub
    Private Sub RemoveItemTemSpacialService(ByVal index As Integer)
        TblSpacialServiceTem.BeginLoadData()
        TblSpacialServiceTem.Rows.RemoveAt(index)
        TblSpacialServiceTem.EndLoadData()
        RefreshAddTemSpacialService()
        TotalReceiptSpacialService()
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click
        'MessageBox.Show(GridServiceMed.Row)
        If GridServiceMed.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove medicine?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            RemoveItemTemSpacialService(GridServiceMed.Row)
        End If

    End Sub

    Private Sub LblCatName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSpacialName.Click

    End Sub

    Private Sub TxtQTY_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSpacialServicePrice.KeyUp
        If e.KeyCode = Keys.Enter Then
            CallAddSpacialService()
        End If

    End Sub



    Private Sub CboItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboSkill.KeyDown
        If e.KeyCode = Keys.Enter Then
            CallAddSpacialService()
        End If
    End Sub

    Private Sub TxtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSpacialServicePrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtReceiptAmmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceiptAmmount.TextChanged
        Dim Riel As New riel()
        Dim Dollar As New dollar()

        Me.TxtAmmountInword.Text = Riel.Convert(Me.TxtReceiptAmmount.Text)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindingClientNo()
    End Sub
    Public Sub FindingClientNo()
        If ValidateTextField(TxtClientNo, "", ErrNewReceipt) = False Then Exit Sub
        Dim TblClient As DataTable = DAClient.SelectClientInfoByClientNo(EmptyString(TxtClientNo.Text))
        If TblClient.Rows.Count = 0 Then
            MessageBox.Show("Wrong client no. Please check again.", "Find Client", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClientNo.Focus()
            TxtClientNo.SelectAll()
            TxtClientName.Text = ""
            TxtClientSex.Text = ""
            TxtClientAge.Text = ""
            RadServiceA.Checked = False
            RadServiceB.Checked = False
            RadServiceC.Checked = False
        Else
            For Each DRows As DataRow In TblClient.Rows
                TxtClientName.Text = DRows("CLIENT_NAME")
                TxtClientSex.Text = DRows("CLIENT_SEX")
                TxtClientAge.Text = DRows("CLIENT_AGE")
                If DRows("CLIENT_SOCIAL_SERVICETYPE") = ReceiptUtilityModule.SOCIAL_TYPE_A Then
                    RadServiceA.Checked = True
                ElseIf DRows("CLIENT_SOCIAL_SERVICETYPE") = ReceiptUtilityModule.SOCIAL_TYPE_B Then
                    RadServiceB.Checked = True
                ElseIf DRows("CLIENT_SOCIAL_SERVICETYPE") = ReceiptUtilityModule.SOCIAL_TYPE_C Then
                    RadServiceC.Checked = True
                End If
                CboSkill.Focus()
                CboSkill.SelectAll()
            Next
        End If
    End Sub




    'Private Sub MedicinceClientReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
    'End Sub

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
        If GridServiceMed.SelectedItems.Count = 0 Then
            MessageBox.Show("Must have one medicine in list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ValidateTextField(TxtReceiptAmmount, "", ErrNewReceipt) = False Then Exit Sub
        If ValidateTextField(TxtAmmountInword, "", ErrNewReceipt) = False Then Exit Sub
        If MessageBox.Show("Do you want to save new receipt?", "New Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            'If ReceiptUtilityModule.CheckDuplicateReceiptNo(EmptyString(TxtReceiptNo.Text)) = True Then
            ' Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
            ' End If
            SaveSpacialReceipt()
            DA_Spacial_ReceiptDetail.DeleteReceiptDetailByID(TxtReceiptNo.Text)
            InsertReceiptSpacialDetail()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            'Application.DoEvents()
            'LblPrinting.Visible = True
            'PicLoading.Visible = True
            Application.DoEvents()
            'BGSaveAndPrintReceipt.RunWorkerAsync()
            'End If
        End If
    End Sub
    Private Sub InsertReceiptSpacialDetail()
        For Each GRow As GridEXRow In GridServiceMed.GetRows
            DA_Spacial_ReceiptDetail.InsertReceiptSpacialReceipt(TxtReceiptNo.Text, GRow.Cells("SKILL_ID").Value, GRow.Cells("SKILL_NAME").Value, GRow.Cells("PACKAGE_ID").Value, GRow.Cells("PACKAGE_NAME").Value, GRow.Cells("PACKAGE_PRICE").Value, GRow.Cells("PACKAGE_TYPE").Value)
        Next
    End Sub
    Private Function SaveSpacialReceipt() As Integer
        'Return DAClientReceipt.InsertSpacialReceiptService(EmptyString(TxtReceiptNo.Text), ReceiptUtilityModule.RECEIPT_SPACIAL, _
        '                                               ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceA.Checked), _
        '                                               ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceB.Checked), _
        '                                            ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceC.Checked), False, DateReceipt.Value.Year, Now, DateReceipt.Value.Date, EmptyString(TxtReceiptAmmount.Text), _
        '                                            (EmptyString(TxtReceiptAmmount.Text) / ReceiptUtilityModule.GetExchangeRate), _
        '                                            ReceiptUtilityModule.GetExchangeRate, USER_NAME, TxtAmmountInword.Text, TxtClientNo.Text, TxtClientName.Text, _
        '                                            TxtClientSex.Text, TxtClientAge.Text, "", "", ReceiptUtilityModule.GetSocialServieType(RadServiceA.Checked, _RadServiceB.Checked, RadServiceC.Checked), _
        '                                            TxtReceiptNo.Text)
        Return DAClientReceipt.AddSpacialServiceUpdate(ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceA.Checked), _
                                                        ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceB.Checked), _
                                                        ReceiptUtilityModule.GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), RadServiceC.Checked), TxtReceiptNo.Text)

    End Function

    Private Sub BGSaveAndPrintReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGSaveAndPrintReceipt.DoWork
        TblNewReceipt = DAClientReceipt.SelectCashByReceiptNo(EmptyString(TxtReceiptNo.Text))
    End Sub

    Private Sub BGSaveAndPrintReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGSaveAndPrintReceipt.RunWorkerCompleted
        DoPrintReceipt()
        LblPrinting.Visible = False
        PicLoading.Visible = False
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub DoPrintReceipt()
        Dim FPrintPreview As New PrintPreviewCashReceipt
        Dim ObjCRVReceipt As New CRSpacialClientReceipt
        ObjCRVReceipt.SetDataSource(TblNewReceipt)
        FPrintPreview.CrystalReportObject = ObjCRVReceipt
        FPrintPreview.IS_PRINT_OLDRECEIPT = True
        FPrintPreview.ShowDialog()

    End Sub

    Private Sub CboSkill_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSkill.SelectedValueChanged
        Try
            LoadServicePackage(CboSkill.SelectedValue)
        Catch ex As Exception
            LblSpacialID.Text = ""
            LblSpacialName.Text = ""
            LblServicePrice.Text = ""
            LblSocialType.Text = ""
        End Try
    End Sub

    Private Sub CboPackage_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPackage.SelectedValueChanged
        Try
            If CboPackage.SelectedValue Is Nothing Then
                LblSpacialID.Text = ""
                LblSpacialName.Text = ""
                TxtSpacialServicePrice.Text = ""
                LblSocialType.Text = ""
                TxtSpacialServicePrice.Text = ""
                Exit Sub
            End If

            LoadSocialService(CInt(CboPackage.SelectedValue))
        Catch ex As Exception
            LblSpacialID.Text = ""
            LblSpacialName.Text = ""
            TxtSpacialServicePrice.Text = ""
            LblSocialType.Text = ""
            TxtSpacialServicePrice.Text = ""
        End Try
    End Sub

    Private Sub TxtClientNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClientNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            FindingClientNo()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FSpacialServiceSetting As New SpacialServiceSetting
        FSpacialServiceSetting.ShowDialog()
        With CboSkill
            .DataSource = DASkill.GetData
            .ValueMember = "SKILL_ID"
            .DisplayMember = "SKILL_NAME"
            .SelectedIndex = -1
        End With
    End Sub
End Class