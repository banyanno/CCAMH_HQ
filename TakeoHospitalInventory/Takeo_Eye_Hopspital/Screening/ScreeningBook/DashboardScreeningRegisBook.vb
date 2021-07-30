Public Class DashboardScreeningRegisBook
    Dim DAScreeningBook As New DataSetScreeningBookTableAdapters.SCREENING_BOOKTableAdapter
    Dim DAScreeningBookDetail As New DataSetScreeningBookTableAdapters.SCREENING_BOOK_VIEWTableAdapter
    Dim DAReferralBookDetail As New DataSetScreeningBookTableAdapters.SCREENING_REFERRAL_DETAILTableAdapter
    Dim DARefractionBookDedail As New DataSetScreeningBookTableAdapters.SCREENIG_REFRACTION_DEDAILTableAdapter
    Dim DAOpticalshopBookDetail As New DataSetScreeningBookTableAdapters.SCREENING_OPTICALSHOP_DETIALTableAdapter

    Private TableScreenBook, TableReferralBook, TableRefractionBook, TableOpticalShop As DataTable
    Private Sub TabControl1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        'Select Case e.Index
        '    Case 0
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(125, 0, 34)), e.Bounds)
        '    Case 1
        '        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(6766336)), e.Bounds)
        'End Select

        Dim paddedBounds As Rectangle = e.Bounds
        paddedBounds.Inflate(-1, -1)
        e.Graphics.DrawString(TabControl1.TabPages(e.Index).Text, Me.Font, SystemBrushes.HighlightText, paddedBounds)
    End Sub

    Private Sub TxtFind_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatienNo.KeyPress
        SetDisableKeyString(e)
    End Sub
    Private Sub CallScreeningBooks()
        MainFormApplicationPublic.StatusLoading(True, "Loading")
        BGScreeningBook.RunWorkerAsync()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        CallScreeningBooks()
    End Sub
    Private Sub BGScreeningBook_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGScreeningBook.DoWork
        SearchingScreening()
    End Sub
    Private Sub SearchingScreening()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf SearchingScreening))
        Else
            If TxtPatienNo.Text.Trim <> "" Then
                TableScreenBook = DAScreeningBookDetail.SelectScreenBookDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
                TableReferralBook = DAReferralBookDetail.SelectScreenReferralDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
                TableRefractionBook = DARefractionBookDedail.SelectScreenRefractionDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
                TableOpticalShop = DAOpticalshopBookDetail.SelectScreenOpticalShopDateToDateWithPatientNO(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
            Else
                TableScreenBook = DAScreeningBookDetail.SelectScreenBookDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
                TableReferralBook = DAReferralBookDetail.SelectScreebReferralDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
                TableRefractionBook = DARefractionBookDedail.SelectScreenRefractDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
                TableOpticalShop = DAOpticalshopBookDetail.SelectScreenOpticalShopDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            End If
        End If
    End Sub
    Private Sub BGScreeningBook_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGScreeningBook.RunWorkerCompleted
        'If TxtPatienNo.Text.Trim <> "" Then
        ' Load Data Screening book
        GridEXScreeningBook.DataSource = TableScreenBook
        'DGScreeningBook.DataSource = TableScreenBook
        'ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
        ' Load data for referral book
        GridEXReferral.DataSource = TableReferralBook
        ' ModCommon.NumberAllRowHeaderDataGrid(DGReferral)
        ' Loading data for Refraction Book
        'DGRefraction.DataSource = TableRefractionBook
        ' ModCommon.NumberAllRowHeaderDataGrid(DGRefraction)

        ' Loading Data for Optical shop book
        'DGOpticalShop.DataSource = TableOpticalShop
        ' ModCommon.NumberAllRowHeaderDataGrid(DGOpticalShop)
        'Else

        '    ' Load Data Screening book
        '    DGScreeningBook.DataSource = 
        '    ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
        '    ' Load data for referral book
        '    DGReferral.DataSource = 
        '    ModCommon.NumberAllRowHeaderDataGrid(DGReferral)

        '    ' Loading data for Refraction Book
        '    DGRefraction.DataSource =
        '    ModCommon.NumberAllRowHeaderDataGrid(DGRefraction)

        '    ' Loading Data for Optical shop book
        '    DGOpticalShop.DataSource = 
        '    ModCommon.NumberAllRowHeaderDataGrid(DGOpticalShop)
        'End If

        ' Call Total Regis, Refraction, Referral and Optical shop
        DisplayTotalScreening(DateFrom.Value.Date, DateTo.Value.Date)
        'CheckBlankDiagnosis(Me.DGScreeningBook)
        MainFormApplicationPublic.StatusLoading(False, "Loading")
    End Sub
    Private Sub DashboardScreeningRegisBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DGScreeningBook.AutoGenerateColumns = False
        'DGReferral.AutoGenerateColumns = False
        'DGRefraction.AutoGenerateColumns = False
        'DGOpticalShop.AutoGenerateColumns = False
        TxtPatienNo.Focus()
        TxtPatienNo.Select()
        TxtPatienNo.SelectAll()

        'For Each items As ToolStripItem In CMScreeningBook.Items
        '    If TypeOf items Is ToolStripMenuItem Then
        '        MsgBox(items.Name)
        '        items.BackColor = Color.Black

        '        items.ForeColor = Color.White

        '    End If

        '    'For Each meh As ToolStripMenuItem In it
        '    '    meh.BackColor = Color.Black
        '    '    meh.ForeColor = Color.White
        '    '    'For Each lolCat As ToolStripMenuItem In meh.DropDownItems
        '    '    '    lolCat.BackColor = Color.Black
        '    '    '    lolCat.ForeColor = Color.White
        '    '    'Next
        '    'Next
        'Next
    End Sub

    Private Sub DGScreeningBook_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub
        'Dim dgRow As DataGridViewRow = DGScreeningBook.Rows(DGScreeningBook.SelectedCells(0).RowIndex)
        'DisplayUtiliyBookByScreenID(dgRow.Cells("SCREEN_BOOKID").Value)
    End Sub
    Private Sub DisplayUtiliyBookByScreenID(ByVal ScreenID As Double)
        GridEXReferral.DataSource = DAReferralBookDetail.SelectReferralByScreenBookID(ScreenID)
        'DGRefraction.DataSource = DARefractionBookDedail.SelectRefractionByScreenBookID(ScreenID)
        'DGOpticalShop.DataSource = DAOpticalshopBookDetail.SelectOpticalByScreenBookID(ScreenID)
    End Sub
    Private Sub DisplayTotalScreening(ByVal DateFrom As Date, ByVal DateTo As Date)
        TxtTotalRegister.Text = DAScreeningBookDetail.TotalScreen(DateFrom, DateTo)
        TxtTotalRefraction.Text = DAScreeningBookDetail.TotalPatientRefraction(DateFrom, DateTo)
        TxtTotalReferralPickup.Text = DAScreeningBookDetail.TotalPatientReferralPickup(DateFrom, DateTo)
        TxtTotalReferralSelf.Text = DAScreeningBookDetail.TotalPatientReferralBySelf(DateFrom, DateTo)
        TxtTotalOpticalShop.Text = DAScreeningBookDetail.TotalPatientOpticalshop(DateFrom, DateTo)
        TxtTotalNotYetImport.Text = DAScreeningBookDetail.TotalNotYetImport(DateFrom, DateTo)
        LblTotalNotFillDiagnosis.Text = DAScreeningBookDetail.TotalPatientNotFillDiagnosis(DateFrom, DateTo)
    End Sub
    Private Sub CheckBlankDiagnosis(ByVal DG As DataGridView)
        For Each rows As DataGridViewRow In DG.Rows
            BlankDiagnosis = rows.Cells.Item("DIAGNOSISScreening").Value.ToString.Trim
            'DelOption = rows.Cells.Item("DeleteOption").Value.ToString.Trim
            'VA = rows.Cells.Item("VAStatus").Value.ToString
            'If VA = "False" Then
            '    rows.DefaultCellStyle.BackColor = Color.Bisque
            'End If
            If BlankDiagnosis = "" Then
                rows.DefaultCellStyle.BackColor = Color.FromArgb(222, 182, 174)
            End If
            'If DelOption = "True" Then
            '    rows.DefaultCellStyle.BackColor = Color.DarkKhaki
            'End If
        Next
        NumberAllRowHeaderDataGrid(DG)
    End Sub

    Private Sub BtnUpdateScreening_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateScreening.Click
        'If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub
        'Dim GRows As DataGridViewRow = DGScreeningBook.Rows(DGScreeningBook.SelectedCells(0).RowIndex)
        If GridEXScreeningBook.SelectedItems.Count = 0 Then Exit Sub
        Dim UpdateSNBook As New UpdateScreeningBook
        UpdateSNBook.LblSaveOption.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value
        UpdateSNBook.DateScreening.Value = GridEXScreeningBook.GetRow.Cells("SCREAN_DATE").Value
        UpdateSNBook.TxtPlaceScreening.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_PLACE").Value
        UpdateSNBook.PatientNo.Text = GridEXScreeningBook.GetRow.Cells("PatientNo").Value
        UpdateSNBook.PatientName.Text = GridEXScreeningBook.GetRow.Cells("NameEng").Value
        UpdateSNBook.PatientSex.Text = GridEXScreeningBook.GetRow.Cells("Sex").Value
        UpdateSNBook.PatientAge.Text = GridEXScreeningBook.GetRow.Cells("Age").Value
        UpdateSNBook.CboOnEye.Text = GridEXScreeningBook.GetRow.Cells("ON_EYE").Value
        UpdateSNBook.cboDiagnosis.Text = GridEXScreeningBook.GetRow.Cells("DIAGNOSIS").Value
        UpdateSNBook.CboVARight.Text = GridEXScreeningBook.GetRow.Cells("VA_RIGHT").Value
        UpdateSNBook.CboVALeft.Text = GridEXScreeningBook.GetRow.Cells("VA_LEFT").Value
        UpdateSNBook.TxtComplain.Text = GridEXScreeningBook.GetRow.Cells("PRESENTING_COMPLAIN").Value
        UpdateSNBook.TxtMoreInfo.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_NOTE").Value
        UpdateSNBook.ChRefraction.Checked = GridEXScreeningBook.GetRow.Cells("IS_REFRACTION").Value
        UpdateSNBook.ChOpticalshop.Checked = GridEXScreeningBook.GetRow.Cells("IS_OPTICALSHOP").Value
        UpdateSNBook.ChHearing.Checked = GridEXScreeningBook.GetRow.Cells("IS_HEARING").Value
        UpdateSNBook.ChUnderstanding.Checked = GridEXScreeningBook.GetRow.Cells("IS_UNDERSTANDING").Value
        UpdateSNBook.ChPhysicalDisability.Checked = GridEXScreeningBook.GetRow.Cells("IS_PHYSICAL").Value
        UpdateSNBook.ChSeeing.Checked = GridEXScreeningBook.GetRow.Cells("IS_SEEING").Value
        UpdateSNBook.ChIsOld.Checked = GridEXScreeningBook.GetRow.Cells("IS_OLDPATIENT").Value

        ' Call view update Referal
        GetInfoRefer(UpdateSNBook, UpdateSNBook.LblSaveOption.Text)

        '============ Call View upate Refracton ======================
        GetInfoRefraction(UpdateSNBook, UpdateSNBook.LblSaveOption.Text)

        If UpdateSNBook.ShowDialog = DialogResult.OK Then
            GridEXScreeningBook.DataSource = DAScreeningBookDetail.SelectScreenBookDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(UpdateSNBook.PatientNo.Text))
            DisplayUtiliyBookByScreenID(CDbl(UpdateSNBook.LblSaveOption.Text))
            ' ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
        End If
    End Sub
    Private Sub GetInfoRefer(ByVal UpdateSNBook As UpdateScreeningBook, ByVal BookID As Double)
        'Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        Dim TblRefer As DataTable = DAReferralBookDetail.SelectReferralByScreenBookID(BookID)
        If TblRefer.Rows.Count > 0 Then
            For Each rows As DataRow In TblRefer.Rows
                UpdateSNBook.ChReferral.Checked = True
                If rows("STATUS_PICKUP") = True Then
                    UpdateSNBook.RadReferAndPickup.Checked = True
                    UpdateSNBook.DateAppointment.Checked = True
                    UpdateSNBook.DateAppointment.Value = rows("CREATE_DATE")
                Else
                    UpdateSNBook.DateAppointment.Checked = False
                    UpdateSNBook.RadReferAndComeBySelf.Checked = True
                End If
                UpdateSNBook.TxtReferMoreInfo.Text = rows("REFERRAL_NOTE")
            Next

        End If

    End Sub
    Private Sub GetInfoRefraction(ByVal UpdateSNBook As UpdateScreeningBook, ByVal BookID As Double)
        'Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        Dim TblRefraction As DataTable = DARefractionBookDedail.SelectRefractionByScreenBookID(BookID)
        If TblRefraction.Rows.Count > 0 Then
            For Each rows As DataRow In TblRefraction.Rows
                UpdateSNBook.ChRefraction.Checked = True
                UpdateSNBook.TxtREPlus.Text = rows("RE_PLUS")
                UpdateSNBook.TxtLEPlus.Text = rows("LE_PLUS")

                UpdateSNBook.CboREPlusVARefract.Text = rows("RE_VA")
                UpdateSNBook.CboLEPlusVARefrac.Text = rows("LE_VA")
                UpdateSNBook.CboAdd.Text = rows("REFRACT_ADD")
                UpdateSNBook.TxtRefractNote.Text = rows("REFRACT_NOTE")
            Next
        End If
    End Sub
    Private Sub GetInfoOpticalShop(ByVal UpdateSNBook As UpdateScreeningBook, ByVal bookId As Double)
        Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        Dim TblRefraction As DataTable = DAReferralBookDetail.SelectReferralByScreenBookID(GRows.Cells("SCREEN_BOOKID").Value)
        If TblRefraction.Rows.Count > 0 Then
            For Each rows As DataRow In TblRefraction.Rows
                UpdateSNBook.ChRefraction.Checked = True
                UpdateSNBook.TxtREPlus.Text = rows("RE_PLUS")
                UpdateSNBook.TxtLEPlus.Text = rows("LE_PLUS")

                UpdateSNBook.CboREPlusVARefract.Text = rows("RE_VA")
                UpdateSNBook.CboLEPlusVARefrac.Text = rows("LE_VA")
                UpdateSNBook.CboAdd.Text = rows("REFRACT_ADD")
                UpdateSNBook.TxtReferMoreInfo.Text = rows("REFRACT_NOTE")

            Next
        End If
    End Sub
    Public Sub RefreshAfterScreenRegis(ByVal DFrom As Date, ByVal DTo As Date, ByVal PatientNo As Double)
        GridEXScreeningBook.DataSource = DAScreeningBookDetail.SelectScreenBookDateToDateWithPatientNo(DFrom, DTo, EmptyString(PatientNo))

    End Sub

    Private Sub BtnNewScreeningRegist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewScreeningRegist.Click
        Dim RegistScreening As New FormPatientRegister(Me, True)
        RegistScreening.ShowDialog()
    End Sub

    Private Sub BtnUpdateReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateReferral.Click
        If GridEXScreeningBook.SelectedItems.Count = 0 Then Exit Sub

        'Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GridEXScreeningBook.GetRow.Cells("IS_REFER_PICKUP").Value) = False AndAlso (GridEXScreeningBook.GetRow.Cells("IS_REFER_BYSELF").Value) = False Then Exit Sub
        Dim FReferral As New FormReferral
        FReferral.LblSaveOption.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value

        FReferral.DateScreening.Value = GridEXScreeningBook.GetRow.Cells("SCREAN_DATE").Value
        FReferral.PatientNo.Text = GridEXScreeningBook.GetRow.Cells("PatientNo").Value
        FReferral.PatientName.Text = GridEXScreeningBook.GetRow.Cells("NameEng").Value
        FReferral.PatientSex.Text = GridEXScreeningBook.GetRow.Cells("Sex").Value
        FReferral.PatientAge.Text = GridEXScreeningBook.GetRow.Cells("Age").Value
        FReferral.CboOnEye.Text = GridEXScreeningBook.GetRow.Cells("ON_EYE").Value
        FReferral.cboDiagnosis.Text = GridEXScreeningBook.GetRow.Cells("DIAGNOSISScreening").Value
        FReferral.CboVARight.Text = GridEXScreeningBook.GetRow.Cells("VA_RIGHTScreening").Value
        FReferral.CboVALeft.Text = GridEXScreeningBook.GetRow.Cells("VA_LEFTScreening").Value
        If GridEXScreeningBook.GetRow.Cells("IS_REFER_PICKUP").Value = True Then
            FReferral.ChPickup.Checked = True
        Else
            FReferral.ChPickup.Checked = False
        End If
        If FReferral.ShowDialog() = DialogResult.OK Then

        End If
    End Sub



    Private Sub BtnNewReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReferral.Click
        If GridEXScreeningBook.SelectedItems.Count = 0 Then Exit Sub

        'Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GridEXScreeningBook.GetRow.Cells("IS_REFER_PICKUP").Value) = False AndAlso (GridEXScreeningBook.GetRow.Cells("IS_REFER_BYSELF").Value) = False Then Exit Sub
        Dim FReferral As New FormReferral
        If FReferral.DAReferralBook.CheckExistingBookID(GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value) <> 0 Then
            MessageBox.Show("The patient already register into referral book. please check again!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FReferral.Close()
            FReferral.Dispose()
            Exit Sub
        End If
        FReferral.LblSaveOption.Text = "0"
        FReferral.LblScreenBookID.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value
        FReferral.DateScreening.Value = GridEXScreeningBook.GetRow.Cells("SCREAN_DATE").Value
        FReferral.PatientNo.Text = GridEXScreeningBook.GetRow.Cells("PatientNo").Value
        FReferral.PatientName.Text = GridEXScreeningBook.GetRow.Cells("NameEng").Value
        FReferral.PatientSex.Text = GridEXScreeningBook.GetRow.Cells("Sex").Value
        FReferral.PatientAge.Text = GridEXScreeningBook.GetRow.Cells("Age").Value
        FReferral.CboOnEye.Text = GridEXScreeningBook.GetRow.Cells("ON_EYE").Value
        FReferral.cboDiagnosis.Text = GridEXScreeningBook.GetRow.Cells("DIAGNOSISScreening").Value
        FReferral.CboVARight.Text = GridEXScreeningBook.GetRow.Cells("VA_RIGHTScreening").Value
        FReferral.CboVALeft.Text = GridEXScreeningBook.GetRow.Cells("VA_LEFTScreening").Value
        FReferral.ChPickup.Enabled = True
        If FReferral.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub BtnUpdateOpticalshop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateOpticalshop.Click
        If GridEXScreeningBook.SelectedItems.Count = 0 Then Exit Sub
        'Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GridEXScreeningBook.GetRow.Cells("IS_OPTICALSHOP").Value) = False Then Exit Sub
        Dim FOpticalShop As New FormOpticalShop
        FOpticalShop.LblSaveOption.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value
        FOpticalShop.LblScreenBookID.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value
        FOpticalShop.DateScreening.Value = GridEXScreeningBook.GetRow.Cells("SCREAN_DATE").Value
        FOpticalShop.PatientNo.Text = GridEXScreeningBook.GetRow.Cells("PatientNo").Value
        FOpticalShop.PatientName.Text = GridEXScreeningBook.GetRow.Cells("NameEng").Value
        FOpticalShop.PatientSex.Text = GridEXScreeningBook.GetRow.Cells("Sex").Value
        FOpticalShop.PatientAge.Text = GridEXScreeningBook.GetRow.Cells("Age").Value
        If FOpticalShop.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub NewOpticalShopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOpticalShopToolStripMenuItem.Click
        If GridEXScreeningBook.SelectedItems.Count = 0 Then Exit Sub
        'Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GridEXScreeningBook.GetRow.Cells("IS_OPTICALSHOP").Value) = False Then Exit Sub
        Dim FOpticalShop As New FormOpticalShop
        If FOpticalShop.DAOpticalShopBook.CheckExistingOpShop(GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value) <> 0 Then
            MessageBox.Show("The patient already register into optical shop book. please check again!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FOpticalShop.Close()
            FOpticalShop.Dispose()
            Exit Sub
        End If
        FOpticalShop.LblSaveOption.Text = "0"
        FOpticalShop.LblScreenBookID.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value
        FOpticalShop.DateScreening.Value = GridEXScreeningBook.GetRow.Cells("SCREAN_DATE").Value
        FOpticalShop.PatientNo.Text = GridEXScreeningBook.GetRow.Cells("PatientNo").Value
        FOpticalShop.PatientName.Text = GridEXScreeningBook.GetRow.Cells("NameEng").Value
        FOpticalShop.PatientSex.Text = GridEXScreeningBook.GetRow.Cells("Sex").Value
        FOpticalShop.PatientAge.Text = GridEXScreeningBook.GetRow.Cells("Age").Value
        If FOpticalShop.ShowDialog() = DialogResult.OK Then

        End If
    End Sub


    Private Sub UpdateRefractionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateRefractionToolStripMenuItem.Click
        If GridEXScreeningBook.SelectedItems.Count = 0 Then Exit Sub

        'Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GridEXScreeningBook.GetRow.Cells("IS_REFRACTION").Value) = False Then Exit Sub
        Dim FRefraction As New FormRefraction
        'If FReferral.DAReferralBook.CheckExistingBookID(GRows.Cells("SCREEN_BOOKID").Value) <> 0 Then
        '    MessageBox.Show("The patient already register into referral book. please check again!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    FReferral.Close()
        '    FReferral.Dispose()
        '    Exit Sub
        'End If
        FRefraction.LblSaveOption.Text = "0"
        FRefraction.LblScreenBookID.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value
        FRefraction.DateScreening.Value = GridEXScreeningBook.GetRow.Cells("SCREAN_DATE").Value
        FRefraction.PatientNo.Text = GridEXScreeningBook.GetRow.Cells("PatientNo").Value
        FRefraction.PatientName.Text = GridEXScreeningBook.GetRow.Cells("NameEng").Value
        FRefraction.PatientSex.Text = GridEXScreeningBook.GetRow.Cells("Sex").Value
        FRefraction.PatientAge.Text = GridEXScreeningBook.GetRow.Cells("Age").Value
        FRefraction.CboOnEye.Text = GridEXScreeningBook.GetRow.Cells("ON_EYE").Value
        FRefraction.cboDiagnosis.Text = GridEXScreeningBook.GetRow.Cells("DIAGNOSISScreening").Value
        FRefraction.CboVARight.Text = GridEXScreeningBook.GetRow.Cells("VA_RIGHTScreening").Value
        FRefraction.CboVALeft.Text = GridEXScreeningBook.GetRow.Cells("VA_LEFTScreening").Value
        If FRefraction.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub NewRefractionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRefractionToolStripMenuItem.Click
        If GridEXScreeningBook.SelectedItems.Count = 0 Then Exit Sub

        'Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GridEXScreeningBook.GetRow.Cells("IS_REFRACTION").Value) = False Then Exit Sub
        Dim FRefraction As New FormRefraction
        If FRefraction.DARefraction.CheckExistingRefraction(GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value) <> 0 Then
            MessageBox.Show("The patient already register into referral book. please check again!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FRefraction.Close()
            FRefraction.Dispose()
            Exit Sub
        End If
        FRefraction.LblSaveOption.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value
        FRefraction.LblScreenBookID.Text = GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value
        FRefraction.DateScreening.Value = GridEXScreeningBook.GetRow.Cells("SCREAN_DATE").Value
        FRefraction.PatientNo.Text = GridEXScreeningBook.GetRow.Cells("PatientNo").Value
        FRefraction.PatientName.Text = GridEXScreeningBook.GetRow.Cells("NameEng").Value
        FRefraction.PatientSex.Text = GridEXScreeningBook.GetRow.Cells("Sex").Value
        FRefraction.PatientAge.Text = GridEXScreeningBook.GetRow.Cells("Age").Value
        FRefraction.CboOnEye.Text = GridEXScreeningBook.GetRow.Cells("ON_EYE").Value
        FRefraction.cboDiagnosis.Text = GridEXScreeningBook.GetRow.Cells("DIAGNOSISScreening").Value
        FRefraction.CboVARight.Text = GridEXScreeningBook.GetRow.Cells("VA_RIGHTScreening").Value
        FRefraction.CboVALeft.Text = GridEXScreeningBook.GetRow.Cells("VA_LEFTScreening").Value
        If FRefraction.ShowDialog() = DialogResult.OK Then

        End If
    End Sub
    ' Call Index grid to import user
    Private IndexGrid As Integer = 0
    Private PateintTEHNo As Double = 0
    Dim DAPatientTEH As New DatasetPatientTEHTableAdapters.IMP_TblPatientsScreeningTableAdapter
    Dim DADateServer As New DatasetPatientTEHTableAdapters.TableGetDateServerTableAdapter
    Private Sub PicStartImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicStartImport.Click
        If MessageBox.Show("Do you want to import patients to TEH sys?", "Screening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MainFormApplicationPublic.StatusLoading(True, "Loading")
            BGImportToTEH.RunWorkerAsync()
        End If

    End Sub
    'Declare for patient para:
    Dim PatientScreenNo, PatientSReferNo As Double
    Dim PatientTEHNo As Double
    Dim PatientSEngName, PatientSKhname, PatientSProvince, PatientSDistrict, PatientSCommune, PatientSAddress, PatientSSex, PatientSMale, PatientSFemale, ScreeningPlace As String
    Dim PatientSAge As Integer
    Dim DateScreeningRegis As DateTime
    Private Sub ImportPatientScreeningToTEH()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf ImportPatientScreeningToTEH))
        Else
            Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
            checkedRows = GridEXScreeningBook.GetRows
            For I As Integer = 0 To checkedRows.Count - 1
                PatientTEHNo = 0
                PatientScreenNo = GridEXScreeningBook.GetRow(I).Cells("PatientNo").Value

                PatientSReferNo = GridEXScreeningBook.GetRow(I).Cells("REFERENCE_PATIENNOTE").Value
                DateScreeningRegis = GridEXScreeningBook.GetRow(I).Cells("SCREAN_DATE").Value
                PatientSEngName = GridEXScreeningBook.GetRow(I).Cells("NameEng").Value
                PatientSKhname = GridEXScreeningBook.GetRow(I).Cells("NameKhmer").Value
                PatientSProvince = GridEXScreeningBook.GetRow(I).Cells("Province").Value
                PatientSDistrict = GridEXScreeningBook.GetRow(I).Cells("District").Value
                PatientSCommune = GridEXScreeningBook.GetRow(I).Cells("Commune").Value
                PatientSAddress = GridEXScreeningBook.GetRow(I).Cells("Address").Value
                PatientSMale = IIf(GridEXScreeningBook.GetRow(I).Cells("Sex").Value = "M", "M", Nothing)
                PatientSFemale = IIf(GridEXScreeningBook.GetRow(I).Cells("Sex").Value = "F", "F", Nothing)
                'GridEXScreeningBook.GetRow(I).Cells("Female").Value
                PatientSSex = GridEXScreeningBook.GetRow(I).Cells("Sex").Value
                PatientSAge = GridEXScreeningBook.GetRow(I).Cells("Age").Value
                ScreeningPlace = GridEXScreeningBook.GetRow(I).Cells("SCREEN_PLACE").Value

                'CBool(DAScreeningBook.CheckStatusImport(PatientScreenNo)) = False And 
                If DAPatientTEH.CheckExistingScreeningNo(PatientScreenNo) = 0 Then
                    Application.DoEvents()
                    MainFormApplicationPublic.StatusUpdateLabel("Importing Patient:" & PatientScreenNo)
                    If DAPatientTEH.ImportPatientScreeningToTEHSYS(PatientScreenNo, 0, DateScreeningRegis.Date, PatientSProvince, PatientSDistrict, PatientSCommune, PatientSEngName, PatientSKhname, PatientSAge, PatientSMale, PatientSFemale, PatientSSex, PatientSAddress, "", "", "", DateScreeningRegis.Year, False, False, "", "", "", Format(DADateServer.SelectDateSVR, "HH:mm:ss")) = 1 Then
                        DAScreeningBook.UpateStatusImport(True, PatientScreenNo)
                        GridEXScreeningBook.GetRow(I).BeginEdit()
                        GridEXScreeningBook.GetRow(I).Cells("IMPORT_STATUS").Value = True
                        GridEXScreeningBook.GetRow(I).EndEdit()
                    End If

                Else
                    Application.DoEvents()
                    MainFormApplicationPublic.StatusUpdateLabel(PatientScreenNo & " Imported")
                    MessageBox.Show("Patient " & PatientScreenNo & " was imported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Threading.Thread.Sleep(10)
                Application.DoEvents()
                'Dim GridSys As New Janus.Windows.GridEX.GridEXFormatStyle
                'GridSys.BackColor = Color.AliceBlue
                GridEXScreeningBook.Row = I 'GridEXScreeningBook.SelectedItems(I).GetRow.Position - 1
                ' MessageBox.Show(DGScreeningBook.Rows(IndexGrid).Cells("PatientNo").Value)
                ' DGScreeningBook.ClearSelection()
                'DGScreeningBook.CurrentCell = DGScreeningBook.Rows(IndexGrid).Cells(0)
                'DGScreeningBook.Rows(IndexGrid).Selected = True
                'DGScreeningBook.BeginEdit(False)
                'DGScreeningBook.CurrentCell = DGScreeningBook.Rows( '.Item(0, IndexGrid)  'DGScreeningBook.Rows(IndexGrid).Cells(0)
            Next
        End If



        'IndexGrid = 0
        'For I As Integer = 0 To GridEXScreeningBook.SelectedItems.Count - 1 'GRows.Cells.Count - 1
        '    IndexGrid = I
        '    PatientTEHNo = 0
        '    If DAPatientTEH.CheckExistingPatient(GeneratePatientNoForTEH) > 0 Then
        '        PateintTEHNo = GeneratePatientNoForTEH()
        '    Else
        '        PateintTEHNo = GeneratePatientNoForTEH()
        '    End If
        '    PatientScreenNo = DGScreeningBook.Rows(IndexGrid).Cells("PatientNo").Value

        '    PatientSReferNo = DGScreeningBook.Rows(IndexGrid).Cells("REFERENCE_PATIENNOTE").Value
        '    PatientSEngName = DGScreeningBook.Rows(IndexGrid).Cells("NameEng").Value
        '    PatientSKhname = DGScreeningBook.Rows(IndexGrid).Cells("NameKhmer").Value
        '    PatientSProvince = DGScreeningBook.Rows(IndexGrid).Cells("Province").Value
        '    PatientSDistrict = DGScreeningBook.Rows(IndexGrid).Cells("District").Value
        '    PatientSCommune = DGScreeningBook.Rows(IndexGrid).Cells("Commune").Value
        '    PatientSAddress = DGScreeningBook.Rows(IndexGrid).Cells("Address").Value
        '    'PatientSMale = DGScreeningBook.Rows(IndexGrid).Cells("Male").Value
        '    'PatientSFemale = DGScreeningBook.Rows(IndexGrid).Cells("Female").Value
        '    PatientSSex = DGScreeningBook.Rows(IndexGrid).Cells("Sex").Value
        '    PatientSAge = DGScreeningBook.Rows(IndexGrid).Cells("Age").Value
        '    ScreeningPlace = DGScreeningBook.Rows(IndexGrid).Cells("SCREEN_PLACE").Value


        '    If CBool(DAScreeningBook.CheckStatusImport(PatientScreenNo)) = False And DAPatientTEH.CheckExistingScreeningNo(PatientScreenNo) = 0 Then
        '        Application.DoEvents()
        '        UIMainScreening.StatusUpdateLabel("Importing Patient:" & PatientScreenNo)
        '        If DAPatientTEH.ImportPatientScreeningToTEHSys(PateintTEHNo, DADateServer.SelectDateSVR.Value.Date, PatientSProvince, PatientSDistrict, PatientSCommune, PatientSEngName, PatientSKhname, PatientSAge, PatientSMale, PatientSFemale, PatientSSex, PatientSAddress, "", "", DADateServer.SelectDateSVR.Value.Year, ScreeningPlace, Format(DADateServer.SelectDateSVR, "HH:mm:ss"), PatientScreenNo, True, Now.Date, PatientSReferNo) = 1 Then
        '            DAScreeningBook.UpateStatusImport(True, PatientScreenNo)
        '            DGScreeningBook.Rows(IndexGrid).Cells("IMPORT_STATUS").Value = True
        '        End If

        '    Else
        '        Application.DoEvents()
        '        UIMainScreening.StatusUpdateLabel(PatientScreenNo & " Imported")
        '    End If

        '    Threading.Thread.Sleep(10)
        '    Application.DoEvents()
        '    ' MessageBox.Show(DGScreeningBook.Rows(IndexGrid).Cells("PatientNo").Value)
        '    DGScreeningBook.ClearSelection()
        '    'DGScreeningBook.CurrentCell = DGScreeningBook.Rows(IndexGrid).Cells(0)
        '    DGScreeningBook.Rows(IndexGrid).Selected = True
        '    'DGScreeningBook.BeginEdit(False)
        '    'DGScreeningBook.CurrentCell = DGScreeningBook.Rows( '.Item(0, IndexGrid)  'DGScreeningBook.Rows(IndexGrid).Cells(0)

        '    IndexGrid = IndexGrid + I
        'Next
    End Sub
    'Function GeneratePatientNoForTEH() As String
    '    Dim DateServerTEH As Date = DADateServer.SelectDateSVR
    '    Dim Years As Integer = DateServerTEH.Year
    '    Dim Month As String = DateServerTEH.Month.ToString
    '    If Month.Length = 1 Then
    '        Month = "0" & Month
    '    Else
    '        Month = Month
    '    End If
    '    Dim IDHN As Double
    '    Try
    '        'MsgBox("SELECT MAX(" & FieldNo & ") FROM " & Table & " Where Years=" & Years & "")
    '        IDHN = DAPatientTEH.AutoNoPatient(Years) + 1  'ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar("SELECT COUNT(" & FieldNo & ") FROM " & Table & " WHERE YEARS=" & years) + 1
    '    Catch ex As Exception
    '        IDHN = 1
    '    End Try
    '    Return Years & Month.ToString & IDHN.ToString
    'End Function

    Private Sub BGImportToTEH_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGImportToTEH.DoWork
        ImportPatientScreeningToTEH()
    End Sub

    Private Sub BGImportToTEH_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGImportToTEH.RunWorkerCompleted
        MainFormApplicationPublic.StatusLoading(False, "Loading")
        MessageBox.Show("Import patients is done!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub





    Private Sub TxtPatienNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatienNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnUpdateScreening_Click(sender, e)
        End If
    End Sub



    Private Sub GridEXScreeningBook_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridEXScreeningBook.SelectionChanged
        Try
            'If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub
            'Dim dgRow As DataGridViewRow = DGScreeningBook.Rows(DGScreeningBook.SelectedCells(0).RowIndex)
            DisplayUtiliyBookByScreenID(GridEXScreeningBook.GetRow.Cells("SCREEN_BOOKID").Value) '' dgRow.Cells("SCREEN_BOOKID").Value)
        Catch ex As Exception

        End Try
    End Sub
End Class
