Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO

Public Class DashboardClientManagment
    Dim DA_ClientManagement As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim DA_View_ClientMG As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_VIEW_CLIENT_MANAGERMANT_V1TableAdapter

    Dim DA_Client As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim DA_CLIENT_INFO As New DS_ClientImpressionTableAdapters.CCAMH_VIEW_ADVISED_CLIENTSTableAdapter  'DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_VIEW_ADVISED_CLIENTSTableAdapter
    Dim DA_Chief_Detail As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_VIEW_CHIEFCOMPLAINTSTableAdapter
    Dim DA_ClientClinicalAudit As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_VIEW_ACTIVE_ADVISED_CLIENTSTableAdapter
    Dim TblClient As DataTable
    Dim TblChief As DataTable
    Dim DA_CaseAudit As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_OUTCOME_PROFILETableAdapter
    Private Sub RadClientNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabClientManagement.SelectedIndex = 0
    End Sub

    Private Sub TotalCalNewClientRegist()
        '' ======= condition 0= new regis, and 1= followup 
        'Try
        '    Dim TblRegisTotalNew As DataTable = DA_View_ClientMG.SelectTotalClientRegister(0, DFrom.Value.Date, DTo.Value.Date)


        'For Each row As DataRow In TblRegisTotalNew.Rows
        lblNewRegisterM.Text = DA_View_ClientMG.TotalMaleRegister(0, DFrom.Value.Date, DTo.Value.Date)
        lblNewRegisterF.Text = DA_View_ClientMG.TotalFemaleRegister(0, DFrom.Value.Date, DTo.Value.Date)
        lblNewRegisterTotal.Text = CDbl(EmptyString(lblNewRegisterM.Text)) + CDbl(EmptyString(lblNewRegisterF.Text))
        LblTotalDiagnosisNewClient.Text = CDbl(DA_View_ClientMG.SelectCountTotalNotFileDiagnosis(DFrom.Value.Date, DTo.Value.Date, 0))
        'Next
        'Catch ex As Exception

        'End Try



    End Sub
    Private Sub TotalCalFollowUpClient()
        'Dim TblRegisTotalFollwUp As DataTable = DA_View_ClientMG.SelectTotalClientRegister(1, DateFollowFrom.Value.Date, DateFollowTo.Value.Date)
        'For Each row As DataRow In TblRegisTotalFollwUp.Rows
        lblFollowUpM.Text = DA_View_ClientMG.TotalMaleRegister(1, DateFollowFrom.Value.Date, DateFollowTo.Value.Date) 'row("Male")
        lblFollowUpF.Text = DA_View_ClientMG.TotalFemaleRegister(1, DateFollowFrom.Value.Date, DateFollowTo.Value.Date) 'row("Female")
        lblFollowUpTotal.Text = CDbl(EmptyString(lblFollowUpM.Text)) + CDbl(EmptyString(lblFollowUpF.Text)) ' row("Total")

        lblTotalNotFillDiagnosisFollowup.Text = CDbl(DA_View_ClientMG.SelectCountTotalNotFileDiagnosis(DateFollowFrom.Value.Date, DateFollowTo.Value.Date, 1))
        LblTotalNotMonitoring.Text = DA_View_ClientMG.TotalNotMonitoring(1, 0, DateFollowFrom.Value.Date, DateFollowTo.Value.Date)
        'Next
    End Sub
    Private Sub FindClientManagement()
        'If RadClientNew.Checked = True Then

        If RadAllClient.Checked = True Then
            Dim TblClient As DataTable = DA_View_ClientMG.SelectDateToDateWithNewOrOld(DFrom.Value.Date, DTo.Value.Date, 0)

            GridClientNewV1.DataSource = TblClient
        ElseIf RadClientNo.Checked = True Then

            GridClientNewV1.DataSource = DA_View_ClientMG.SelectClientManageByClientNoNewOrOld(0, EmptyString(TxtNewClientNo.Text))
        ElseIf RadClientName.Checked = True Then
            Dim stringUPper As String = TxtNewClientName.Text.ToUpper

            GridClientNewV1.DataSource = DA_View_ClientMG.SelectClientMGByNameNewOrOld(0, TxtNewClientName.Text.ToUpper)
        ElseIf RadNewClientOldNo.Checked = True Then

            GridClientNewV1.DataSource = DA_View_ClientMG.SelectClientMGByClientOLDNo(0, TxtNewClientOldNo.Text)
        ElseIf RadClientTel.Checked = True Then


            GridClientNewV1.DataSource = DA_View_ClientMG.SelectClientMGByPhoneNewOrOld(0, TxtNewClientTel.Text)
        ElseIf RadAssStatus.Checked = True Then

            GridClientNewV1.DataSource = DA_View_ClientMG.SelectClientAssStatusDateToDateNewOrOld(0, DFrom.Value.Date, DTo.Value.Date, CboAdviseAssessment.Text)
        ElseIf RadVeiwDetailAssesment.Checked = True Then

            GridClientNewV1.DataSource = DA_View_ClientMG.SelectDateToDateDetailAssNewOrOld(0, DFrom.Value.Date, DTo.Value.Date, True)
        End If

    End Sub

    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtNewClientNo.Enabled = RadClientNo.Checked
        TxtNewClientNo.Focus()
        TxtNewClientNo.SelectAll()
    End Sub

    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientName.CheckedChanged
        TxtNewClientName.Enabled = RadClientName.Checked
        TxtNewClientName.Focus()
        TxtNewClientName.SelectAll()
    End Sub

    Private Sub RadClientTel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientTel.CheckedChanged
        TxtNewClientTel.Enabled = RadClientTel.Checked
        TxtNewClientTel.Focus()
        TxtNewClientTel.SelectAll()
    End Sub

    Private Sub BtnnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnnFind.Click
        FindClientManagement()
        CalculatTotalNewClientAssessment()
        TotalCalNewClientRegist()
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNewClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnSocialWorker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim FSelectStaff As New FormUnitStaffRepond
            FSelectStaff.TxtClientNo.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString 'GridClientNew.GetRow.Cells("CLIENT_NO").Value
            FSelectStaff.TxtClientName.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLEINT_NAME").ToString ' GridClientNew.GetRow.Cells("CLEINT_NAME").Value
            FSelectStaff.TxtSex.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_SEX").ToString ' GridClientNew.GetRow.Cells("CLIENT_SEX").Value
            FSelectStaff.TxtAge.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_AGE").ToString 'GridClientNew.GetRow.Cells("CLIENT_AGE").Value
            ' FSelectStaff.TxtTel.Text = GridClientNew.GetRow.Cells("CLIENT_TEL").Value
            If FSelectStaff.ShowDialog() = DialogResult.OK Then
                ' Do something
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SocialWorkerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If GridClientNew.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim FSelectStaff As New FormUnitStaffRepond
            FSelectStaff.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub UnitAllocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New Frm_Unit_Allocation
            frm.hidden_client_no.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString ' GridClientNew.GetRow.Cells("CLIENT_NO").Value
            frm.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClinicalAuditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New Frm_Clinical_Audit
            frm.hidden_client_no.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString
            frm.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnClientRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientRefresh.Click
        BtnnFind_Click(sender, e)
    End Sub

    Private Sub DiagnosisICD10ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EnterDiagnosis()
    End Sub
    Private Sub EnterDiagnosis()
        If TabClientManagement.SelectedIndex = 0 Then

            Try
                Dim FillDiagnosis As New FormFillInDiagnosis
                FillDiagnosis.TxtClientNo.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString ' GridClientNew.GetRow.Cells("CLIENT_NO").Value
                FillDiagnosis.TxtClientName.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NAME_KHM").ToString ' GridClientNew.GetRow.Cells("CLIENT_NAME_KHM").Value
                FillDiagnosis.CboDiagnosis.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DIAGNOSIS").ToString 'IIf(TypeOf ( GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DIAGNOSIS").ToString Is DBNull, "", GridClientNew.GetRow.Cells("DIAGNOSIS").Value)
                FillDiagnosis.LblSaveOption.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_MG_ID").ToString ' GridClientNew.GetRow.Cells("CLIENT_MG_ID").Value
                If FillDiagnosis.ShowDialog = DialogResult.OK Then
                    GridClientNewV1.DataSource = DA_View_ClientMG.SelectDateToDateWithNewOrOld(DFrom.Value.Date, DTo.Value.Date, 0)
                    TotalCalNewClientRegist()
                End If
            Catch ex As Exception

            End Try
           
        ElseIf TabClientManagement.SelectedIndex = 1 Then
            Try
                Dim FillDiagnosis As New FormFillInDiagnosis
                FillDiagnosis.TxtClientNo.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString 'GridClientFollowup.GetRow.Cells("CLIENT_NO").Value
                FillDiagnosis.TxtClientName.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NAME_KHM").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NAME_KHM").Value
                FillDiagnosis.CboDiagnosis.Text = GridView1.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "DIAGNOSIS").ToString ' IIf(TypeOf (GridClientFollowup.GetRow.Cells("").Value) Is DBNull, "", GridClientFollowup.GetRow.Cells("DIAGNOSIS").Value)
                FillDiagnosis.LblSaveOption.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_MG_ID").ToString 'GridClientFollowup.GetRow.Cells("CLIENT_MG_ID").Value
                If FillDiagnosis.ShowDialog = DialogResult.OK Then
                    GridClientFollowupV1.DataSource = DA_View_ClientMG.SelectDateToDateWithNewOrOld(DateFollowFrom.Value.Date, DateFollowTo.Value.Date, 1)
                    TotalCalFollowUpClient()
                End If
            Catch ex As Exception

            End Try

        End If


    End Sub

    Private Sub BtnEnterDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EnterDiagnosis()
    End Sub


    Private Sub CalculatTotalNewClientAssessment()

        'Immediate
        'Medium
        'Later
        'Normal
        LblNormalTotal.Text = DA_CLIENT_INFO.TotalAssessmentStatus("Normal", DFrom.Value.Date, DTo.Value.Date)

        LblLaterTotal.Text = DA_CLIENT_INFO.TotalAssessmentStatus("Later", DFrom.Value.Date, DTo.Value.Date)
        LblLaterDoNotAss.Text = DA_CLIENT_INFO.TotalDoAssessmentDateToDateWithStatus("Later", False, DFrom.Value.Date, DTo.Value.Date)
        LblLaterTotalDoneAssesst.Text = DA_CLIENT_INFO.TotalDoAssessmentDateToDateWithStatus("Later", True, DFrom.Value.Date, DTo.Value.Date)

        LblMediumTotal.Text = DA_CLIENT_INFO.TotalAssessmentStatus("Medium", DFrom.Value.Date, DTo.Value.Date)
        LblMediumDoNotAsses.Text = DA_CLIENT_INFO.TotalDoAssessmentDateToDateWithStatus("Medium", False, DFrom.Value.Date, DTo.Value.Date)
        LblMediumDoneAsses.Text = DA_CLIENT_INFO.TotalDoAssessmentDateToDateWithStatus("Medium", True, DFrom.Value.Date, DTo.Value.Date)

        LblImmeTotal.Text = DA_CLIENT_INFO.TotalAssessmentStatus("Immediate", DFrom.Value.Date, DTo.Value.Date)
        LblImmeDonotAsses.Text = DA_CLIENT_INFO.TotalDoAssessmentDateToDateWithStatus("Immediate", False, DFrom.Value.Date, DTo.Value.Date)
        lblImmeDoneAass.Text = DA_CLIENT_INFO.TotalDoAssessmentDateToDateWithStatus("Immediate", True, DFrom.Value.Date, DTo.Value.Date)



    End Sub

    Private Sub RegularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            If MessageBox.Show("Do you want to update status appointment?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If DA_ClientManagement.UpdateAppointmentstatus("Regular", GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_MG_ID").ToString) = 1 Then
                    MessageBox.Show("Update appointment successful.", "Update", MessageBoxButtons.OK)
                    BtnnFind_Click(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub IrregularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If MessageBox.Show("Do you want to update status appointment?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If DA_ClientManagement.UpdateAppointmentstatus("Irregular", GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_MG_ID").ToString) = 1 Then
                    MessageBox.Show("Update appointment successful.", "Update", MessageBoxButtons.OK)
                    BtnnFind_Click(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub



    Private Sub BtnAppRegular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If MessageBox.Show("Do you want to update status appointment?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If DA_ClientManagement.UpdateAppointmentstatus("Regular", GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_MG_ID").ToString) = 1 Then
                    MessageBox.Show("Update appointment successful.", "Update", MessageBoxButtons.OK)
                    BtnnFind_Click(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnAppIrregular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If MessageBox.Show("Do you want to update status appointment?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If DA_ClientManagement.UpdateAppointmentstatus("Irregular", GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_MG_ID").ToString) = 1 Then
                    MessageBox.Show("Update appointment successful.", "Update", MessageBoxButtons.OK)
                    BtnnFind_Click(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub EnterDiagnosisICD10ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EnterDiagnosis()
    End Sub

    Private Sub EnterDiagnosisICD10ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EnterDiagnosis()
    End Sub


    Private Sub BtnDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDiagnosis.Click
        EnterDiagnosis()
    End Sub


    Private Sub DashboardClientManagment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnnFind_Click(sender, e)
    End Sub

    Private Sub BtnNextAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextAppointment.Click
        NextAppointment()

    End Sub
    Private Sub NextAppointment()
        If TabClientManagement.SelectedIndex = 0 Then
            Try
                Dim NextAppoint As New FormNextAppointment

                NextAppoint.TxtClientNo.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString ' GridClientNew.GetRow.Cells("CLIENT_NO").Value
                NextAppoint.TxtClientNameKH.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NAME_KHM").ToString ' GridClientNew.GetRow.Cells("CLIENT_NAME_KHM").Value
                NextAppoint.TxtClientNameEng.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NAME").ToString ' GridClientNew.GetRow.Cells("CLIENT_NAME").Value
                NextAppoint.TxtClientSex.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_SEX").ToString ' GridClientNew.GetRow.Cells("CLIENT_SEX").Value
                NextAppoint.TxtClientAge.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_AGE").ToString ' GridClientNew.GetRow.Cells("CLIENT_AGE").Value
                If NextAppoint.ShowDialog = DialogResult.OK Then
                    MessageBox.Show("Save new appointment sussesful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NextAppoint.Close()
                End If
            Catch ex As Exception

            End Try

        ElseIf TabClientManagement.SelectedIndex = 1 Then
            Try

            Catch ex As Exception

            End Try
            Dim NextAppoint As New FormNextAppointment

            NextAppoint.TxtClientNo.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString 'GridClientFollowup.GetRow.Cells("CLIENT_NO").Value
            NextAppoint.TxtClientNameKH.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NAME_KHM").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NAME_KHM").Value
            NextAppoint.TxtClientNameEng.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NAME").ToString 'GridClientFollowup.GetRow.Cells("CLIENT_NAME").Value
            NextAppoint.TxtClientSex.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_SEX").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_SEX").Value
            NextAppoint.TxtClientAge.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_AGE").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_AGE").Value
            If NextAppoint.ShowDialog = DialogResult.OK Then
                MessageBox.Show("Save new appointment sussesful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NextAppoint.Close()
            End If
        End If
    End Sub

    Private Sub BtnUpdateAssessment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateAssessment.Click
        Try
            Dim FUpdateAssessment As New FormUpdatAssessment
            FUpdateAssessment.TxtClientNo.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString ' GridClientNew.GetRow.Cells("CLIENT_NO").Value
            FUpdateAssessment.TxtClientName.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NAME").ToString 'GridClientNew.GetRow.Cells("CLIENT_NAME").Value
            FUpdateAssessment.ChDoAssessment.Checked = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_ADVICED_ASSESSMENT_DETAIL").ToString ' GridClientNew.GetRow.Cells("CLIENT_ADVICED_ASSESSMENT_DETAIL").Value
            FUpdateAssessment.CboAssessmentStatus.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_ADVISED_ASSESSMENT").ToString 'GridClientNew.GetRow.Cells("CLIENT_ADVISED_ASSESSMENT").Value
            If TypeOf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_ADVISED_ASSESSMENT_DATE") Is DBNull Then
                FUpdateAssessment.DateDoAssessment.Checked = False
            Else
                FUpdateAssessment.DateDoAssessment.Checked = True
                FUpdateAssessment.DateDoAssessment.Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_ADVISED_ASSESSMENT_DATE")
            End If
            FUpdateAssessment.TxtAssessmentNote.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_ADVICED_ASSESSMENT_NOTE") ' GridClientNew.GetRow.Cells("CLIENT_ADVICED_ASSESSMENT_NOTE").Value
            If FUpdateAssessment.ShowDialog() = DialogResult.OK Then
                RadClientNo.Checked = True
                TxtNewClientNo.Text = FUpdateAssessment.TxtClientNo.Text
                BtnnFind_Click(sender, e)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RadAssStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAssStatus.CheckedChanged
        CboAdviseAssessment.Enabled = RadAssStatus.Checked
    End Sub

    Private Sub PrintNewCaseConferenceFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNewCaseConferenceFormToolStripMenuItem.Click
        Try

        Catch ex As Exception

        End Try

        Dim CRChiefPreview As New ReportChiefComplaint
        Dim FPrintPreview As New ChiefPrintPreview
        TblClient = DA_CLIENT_INFO.GetDataByClientNo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString, DFrom.Value.Date, DTo.Value.Date)
        TblChief = DA_Chief_Detail.GetDataByClientNo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)
        CRChiefPreview.Database.Tables(0).SetDataSource(TblClient)
        CRChiefPreview.Database.Tables(1).SetDataSource(TblChief)
        FPrintPreview.CrystalReportObject = CRChiefPreview
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
    End Sub

    Private Sub PrintListCaseConferenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintListCaseConferenceToolStripMenuItem.Click
        Dim FSelectDateAssessment As New FormSelectDateAssessment
        If FSelectDateAssessment.ShowDialog = DialogResult.OK Then
            Dim ListOfWaitingAssess As New ViewListofDetailAssessment
            Dim FPrintPreview As New ChiefPrintPreview
            Dim TblClietAssessment As DataTable = DA_CLIENT_INFO.SelectListOfClientAssessment(FSelectDateAssessment.DateFrom.Value.Date, FSelectDateAssessment.DateTo.Value.Date, True)
            ListOfWaitingAssess.SetDataSource(TblClietAssessment)
            ListOfWaitingAssess.SetParameterValue("title", "From:" & FSelectDateAssessment.DateFrom.Value.Date & " To:" & FSelectDateAssessment.DateTo.Value.Date)
            FPrintPreview.CrystalReportObject = ListOfWaitingAssess
            FPrintPreview.ShowDialog()
            FPrintPreview.Close()
            FSelectDateAssessment.Close()
        End If
    End Sub


    Private Sub BtnViewClientDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewClientDetail.Click
        Try
            Dim frm As New FormClientRegistration1
            frm.getIsEdit = True
            'frm.btnSave.Visible = False
            frm.getPatientNo = CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)
            frm.ShowDialog()
            frm.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtFollowClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFollowClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadFollowClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadFollowClientNo.CheckedChanged
        TxtFollowClientNo.Enabled = RadFollowClientNo.Checked
        TxtFollowClientNo.Select()
        TxtFollowClientNo.Focus()
    End Sub

    Private Sub RadFollowClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadFollowClientName.CheckedChanged
        TxtFollowName.Enabled = RadFollowClientName.Checked
        TxtFollowName.Select()
        TxtFollowName.Focus()
    End Sub

    Private Sub RadFollowTel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadFollowTel.CheckedChanged
        TxtFollowClientTel.Enabled = RadFollowTel.Checked
        TxtFollowClientTel.Select()
        TxtFollowClientTel.Focus()
    End Sub


    Private Sub BtnFindFollowClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindFollowClient.Click
        If RadFollowUpAll.Checked = True Then
            GridClientFollowupV1.DataSource = DA_View_ClientMG.SelectDateToDateWithNewOrOld(DateFollowFrom.Value.Date, DateFollowTo.Value.Date, 1)
        ElseIf RadFollowClientNo.Checked = True Then
            GridClientFollowupV1.DataSource = DA_View_ClientMG.SelectClientManageByClientNoNewOrOld(1, EmptyString(TxtFollowClientNo.Text))
        ElseIf RadFollowUpOldClientNo.Checked = True Then
            GridClientFollowupV1.DataSource = DA_View_ClientMG.SelectClientMGByClientOLDNo(1, TxtFollowUpOldClientNo.Text)
        ElseIf RadFollowClientName.Checked = True Then
            GridClientFollowupV1.DataSource = DA_View_ClientMG.SelectClientMGByNameNewOrOld(1, TxtFollowName.Text.ToUpper)
        ElseIf RadFollowTel.Checked = True Then
            GridClientFollowupV1.DataSource = DA_View_ClientMG.SelectClientMGByPhoneNewOrOld(1, TxtFollowClientTel.Text)
        End If
        TotalCalFollowUpClient()
    End Sub



    Private Sub BtnNextAppointFollowup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextAppointFollowup.Click
        NextAppointment()
    End Sub


    Private Sub BtnViewClientFollowupDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewClientFollowupDetail.Click
        Try
            Dim frm As New FormClientRegistration1
            frm.getIsEdit = True
            frm.btnSave.Visible = False
            frm.getPatientNo = CDbl(GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString)
            frm.ShowDialog()
            frm.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnEnterDiagnosisFollowup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnterDiagnosisFollowup.Click
        EnterDiagnosis()
    End Sub

    Private Sub BtnAddNewReferTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNewReferTo.Click
        Try
            Dim FReferTo As New FormReferDetail
            FReferTo.TxtClientNo.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString ' GridClientNew.GetRow.Cells("CLIENT_NO").Value
            FReferTo.TxtClientNameKH.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NAME_KHM").ToString 'GridClientNew.GetRow.Cells("CLIENT_NAME_KHM").Value
            FReferTo.TxtClientNameEng.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NAME").ToString ' GridClientNew.GetRow.Cells("CLIENT_NAME").Value
            FReferTo.TxtClientSex.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_SEX").ToString ' GridClientNew.GetRow.Cells("CLIENT_SEX").Value
            FReferTo.TxtClientAge.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_AGE").ToString ' GridClientNew.GetRow.Cells("CLIENT_AGE").Value

            If FReferTo.ShowDialog = DialogResult.OK Then

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnCaseMonitoring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCaseMonitoring.Click
        Try

        Catch ex As Exception

        End Try
        Dim FCaseMonitoring As New FormCaseMonitoring
        FCaseMonitoring.LblMonitoringID.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_MG_ID").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_MG_ID").Value
        FCaseMonitoring.BtnFindClient.Visible = False
        FCaseMonitoring.TxtClientNo.ReadOnly = True
        FCaseMonitoring.TxtClientNo.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NO").Value
        FCaseMonitoring.TxtClientNameKH.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NAME_KHM").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NAME_KHM").Value
        FCaseMonitoring.TxtClientNameEng.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NAME").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NAME").Value
        FCaseMonitoring.TxtClientSex.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_SEX").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_SEX").Value
        FCaseMonitoring.TxtClientAge.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CAL_AGE").ToString ' GridClientFollowup.GetRow.Cells("CAL_AGE").Value
        FCaseMonitoring.DateCaseMonitoring.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "DATE_CREATE").ToString 'GridClientFollowup.GetRow.Cells("DATE_CREATE").Value
        FCaseMonitoring.TxtClientContact.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_ADDRESS_PHONE").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_ADDRESS_PHONE").Value
        'Try
        '    FCaseMonitoring.CboFacilater.Text = GridClientFollowup.GetRow.Cells("THERAPY_NAME").Value
        'Catch ex As Exception
        '    FCaseMonitoring.CboFacilater.Text = ""
        'End Try
        Try
            FCaseMonitoring.CboTherapy.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "MAIN_THERAPY_NAME").ToString ' GridClientFollowup.GetRow.Cells("MAIN_THERAPY_NAME").Value
        Catch ex As Exception
            FCaseMonitoring.CboTherapy.Text = ""
        End Try
        FCaseMonitoring.TxtClientAddress.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "FULL_ADDRESS_KH").ToString '' 'IIf(TypeOf GridClientFollowup.GetRow.Cells("FULL_ADDRESS_KH").Value Is DBNull, "", GridClientFollowup.GetRow.Cells("FULL_ADDRESS_KH").Value)
        FCaseMonitoring.InitLoadingMedicine(GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString, GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "DATE_CREATE").ToString)
        FCaseMonitoring.InitLoadReferBy(GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString)
        If FCaseMonitoring.ShowDialog = DialogResult.OK Then
            DA_ClientManagement.UpdateCaseMonitoring(True, FCaseMonitoring.LblMonitoringID.Text)
            BtnFindFollowClient_Click(sender, e)
        End If
    End Sub




    Private Sub RadFollowUpOldClientNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadFollowUpOldClientNo.CheckedChanged
        TxtFollowUpOldClientNo.Enabled = RadFollowUpOldClientNo.Checked
        TxtFollowUpOldClientNo.Select()
        TxtFollowUpOldClientNo.Focus()
    End Sub

    Private Sub RadNewClientOldNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadNewClientOldNo.CheckedChanged
        TxtNewClientOldNo.Enabled = RadNewClientOldNo.Checked
        TxtNewClientOldNo.Select()
        TxtNewClientOldNo.Focus()
    End Sub

    Private Sub BtnChangeTherapy_Click(sender As Object, e As EventArgs) Handles BtnChangeTherapy.Click
        '  If GridClientNew.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim FChangeThearapy As New FormChangeThearapy
            FChangeThearapy.TxtClientNo.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString 'GridClientNew.GetRow.Cells("CLIENT_NO").Value
            FChangeThearapy.TxtClientName.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NAME_KHM").ToString ' GridClientNew.GetRow.Cells("CLIENT_NAME_KHM").Value
            Try
                FChangeThearapy.CboThearapyName.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "MAIN_THERAPY_NAME").ToString ' GridClientNew.GetRow.Cells("MAIN_THERAPY_NAME").Value
            Catch ex As Exception
                FChangeThearapy.CboThearapyName.Text = ""
            End Try
            FChangeThearapy.ShowDialog()
            BtnnFind_Click(sender, e)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnChangeTherapy2_Click(sender As Object, e As EventArgs) Handles BtnChangeTherapy2.Click
        'If GridClientFollowup.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim FChangeThearapy As New FormChangeThearapy
            FChangeThearapy.TxtClientNo.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NO").Value
            FChangeThearapy.TxtClientName.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NAME_KHM").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NAME_KHM").Value
            Try
                FChangeThearapy.CboThearapyName.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "MAIN_THERAPY_NAME").ToString 'GridClientFollowup.GetRow.Cells("MAIN_THERAPY_NAME").Value
            Catch ex As Exception
                FChangeThearapy.CboThearapyName.Text = ""
            End Try
            FChangeThearapy.ShowDialog()
            BtnFindFollowClient_Click(sender, e)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnStopVisit_Click(sender As Object, e As EventArgs) Handles BtnStopVisit.Click
        '  If GridClientFollowup.SelectedItems.Count = 0 Then Exit Sub
        Try
            If GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString = "" Then Exit Sub
            'If DA_CaseAudit.CheckExisterDropOut(GridClientFollowup.GetRow.Cells("CLIENT_NO").Value) > 0 Then
            '    MessageBox.Show("The cleint already record to case audit!", "case audit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            Dim FCaseDropOut As New FormCaseDropOut
            FCaseDropOut.InitClientInfo(GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString)
            FCaseDropOut.RadStopVisit.Checked = True
            If FCaseDropOut.ShowDialog = DialogResult.OK Then
                ' DA_Appointment.UpdateAppointmentCaseDropOut(True, USER_NAME, Now.Date, GridClientAppointment.GetRow.Cells("APP_ID").Value)
            End If
        Catch ex As Exception

        End Try

    End Sub




    Private Sub BtnGenerateAudit_Click(sender As Object, e As EventArgs) Handles BtnGenerateAudit.Click
        If RadVeiwDetailAssesment.Checked = False Then
            MessageBox.Show("Please select detail assesment. Befor generate clinical audit list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim FSelectClinicalAudit As New FormSelectClinicalAudit
        Dim WeekNumber As Integer = DatePart(DateInterval.WeekOfYear, DFrom.Value.Date, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
        FSelectClinicalAudit.StartDateWeek.Checked = True
        FSelectClinicalAudit.StartDateWeek.Value = DFrom.Value
        FSelectClinicalAudit.EndDateWeek.Checked = True
        FSelectClinicalAudit.EndDateWeek.Value = DTo.Value
        FSelectClinicalAudit.InitLabelWeek("Week " & WeekNumber & "th (" & Format(DFrom.Value.Date, "dd MMM") & "-" & DTo.Value.Date.Day & " " & Format(DTo.Value.Date, "MMM yyyy") & ")")
        FSelectClinicalAudit.InitTotalAuditClinicalAudit(DFrom.Value.Date, DTo.Value.Date)
        FSelectClinicalAudit.GridClientNew.DataSource = DA_View_ClientMG.SelectDateToDateDetailAssNewOrOld(0, DFrom.Value.Date, DTo.Value.Date, True)
        If FSelectClinicalAudit.ShowDialog() = DialogResult.OK Then

        End If
    End Sub
    Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        If e.Column.FieldName = "RowNo" Then
            e.Value = e.ListSourceRowIndex + 1

        End If
    End Sub
    Private Sub BtnReferalToOldClient_Click(sender As Object, e As EventArgs) Handles BtnReferalToOldClient.Click
        '  If GridClientFollowup.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim FReferTo As New FormReferDetail
            FReferTo.TxtClientNo.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NO").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NO").Value
            FReferTo.TxtClientNameKH.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NAME_KHM").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NAME_KHM").Value
            FReferTo.TxtClientNameEng.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_NAME").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_NAME").Value
            FReferTo.TxtClientSex.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_SEX").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_SEX").Value
            FReferTo.TxtClientAge.Text = GridViewFollowup.GetRowCellValue(GridViewFollowup.FocusedRowHandle, "CLIENT_AGE").ToString ' GridClientFollowup.GetRow.Cells("CLIENT_AGE").Value

            If FReferTo.ShowDialog = DialogResult.OK Then

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim view As GridView = CType(sender, GridView)
        If e.RowHandle >= 0 Then

            Dim AssessmentDetail As String = view.GetRowCellDisplayText(e.RowHandle, view.Columns("CLIENT_ADVICED_ASSESSMENT_DETAIL"))
            'MessageBox.Show(priority)
            If AssessmentDetail = "Checked" Then
                e.Appearance.BackColor = Color.FromArgb(192, 192, 255)
                e.Appearance.BackColor2 = Color.White
            End If

        End If
    End Sub

    Private Sub BtnExportFile_Click(sender As Object, e As EventArgs) Handles BtnExportFile.Click
        Dim SaveFile As New SaveFileDialog
        SaveFile.Filter = "Excell(.xlsx)|*.xlsx|Win-Word(.docx)|*.docs|pdf-File(.pdf)|*.pdf"  ' Excell|*.xlsx || Win-Word|*.docs || PDF|*.pdf"
        SaveFile.Title = "Export Files"
        If SaveFile.ShowDialog = DialogResult.OK Then
            Dim Filename = SaveFile.FileName
            '' MessageBox.Show(Path.GetExtension(Filename))
            If Path.GetExtension(Filename) = ".xlsx" Then
                GridClientNewV1.ExportToXlsx(Filename)
                Process.Start(Filename)
            ElseIf Path.GetExtension(Filename) = ".docx" Then
                GridClientNewV1.ExportToDocx(Filename)
                Process.Start(Filename)
            ElseIf Path.GetExtension(Filename) = ".pdf" Then
                GridClientNewV1.ExportToPdf(Filename)
                Process.Start(Filename)
            End If
        End If
    End Sub

    Private Sub GridViewFollowup_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewFollowup.CustomUnboundColumnData
        If e.Column.FieldName = "RowNo" Then
            e.Value = e.ListSourceRowIndex + 1

        End If
    End Sub

    Private Sub GridViewFollowup_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridViewFollowup.RowStyle
        Dim view As GridView = CType(sender, GridView)
        If e.RowHandle >= 0 Then

            Dim AssessmentDetail As String = view.GetRowCellDisplayText(e.RowHandle, view.Columns("IS_MONINTORING"))
            'MessageBox.Show(AssessmentDetail)
            If AssessmentDetail = "Unchecked" Then
                e.Appearance.BackColor = Color.FromArgb(192, 192, 255)
                e.Appearance.BackColor2 = Color.White
            End If

        End If
    End Sub

    Private Sub BtnExportOldClient_Click(sender As Object, e As EventArgs) Handles BtnExportOldClient.Click
        Dim SaveFile As New SaveFileDialog
        SaveFile.Filter = "Excell(.xlsx)|*.xlsx|Win-Word(.docx)|*.docs|pdf-File(.pdf)|*.pdf"  ' Excell|*.xlsx || Win-Word|*.docs || PDF|*.pdf"
        SaveFile.Title = "Export Files"
        If SaveFile.ShowDialog = DialogResult.OK Then
            Dim Filename = SaveFile.FileName
            '' MessageBox.Show(Path.GetExtension(Filename))
            If Path.GetExtension(Filename) = ".xlsx" Then
                GridClientFollowupV1.ExportToXlsx(Filename)
                Process.Start(Filename)
            ElseIf Path.GetExtension(Filename) = ".docx" Then
                GridClientFollowupV1.ExportToDocx(Filename)
                Process.Start(Filename)
            ElseIf Path.GetExtension(Filename) = ".pdf" Then
                GridClientFollowupV1.ExportToPdf(Filename)
                Process.Start(Filename)
            End If
        End If
    End Sub
End Class
