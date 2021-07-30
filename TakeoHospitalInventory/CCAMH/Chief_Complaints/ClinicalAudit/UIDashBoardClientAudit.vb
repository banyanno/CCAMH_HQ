Public Class UIDashBoardClientAudit
    Dim DA_ClientClinicalAudit As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_VIEW_ACTIVE_ADVISED_CLIENTSTableAdapter
    Dim DA_CLINICAL_AUDIT As New DS_CCAMH_ASSESSMENTSTableAdapters.VIEW_CLIENT_ASSESMENT_CLINICAL_AUDITTableAdapter
    Dim DA_ReferralOutRich As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_VIEW_REFER_DETAILTableAdapter
    Dim DA_CaseDropOut As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_OUTCOME_PROFILETableAdapter
    Dim DA_ASSESSMENT_INFO As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_CLIENT_ASSESSMENT_INFOTableAdapter
    Dim DA_App As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_CLIENT_APPOINTSTableAdapter
    Private Sub BtnPrintClinicalAudit_Click(sender As Object, e As EventArgs) Handles BtnPrintClinicalAudit.Click
        If GridClinicalAudit.SelectedItems.Count = 0 Then Exit Sub
        Dim FPrintPreveiw As New AssessPrintPreview
        Dim CRClinicalAudit As New ReportAssessedClient
        Dim tblClinicalAudit As DataTable = DA_ClientClinicalAudit.SelectClinicalByClientNo(GridClinicalAudit.GetRow.Cells("CLIENT_NO").Value)
        CRClinicalAudit.SetDataSource(tblClinicalAudit)
        FPrintPreveiw.CrystalReportViewer1.ReportSource = CRClinicalAudit
        FPrintPreveiw.ShowDialog()
    End Sub

    Private Sub RadClientClinicalAudit_CheckedChanged(sender As Object, e As EventArgs) Handles RadClinicalAuditClientNo.CheckedChanged
        TxtClinicalClientNo.Enabled = RadClinicalAuditClientNo.Checked
        TxtClinicalClientNo.Focus()
        TxtClinicalClientNo.SelectAll()

    End Sub

    Private Sub TxtClinicalClientNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClinicalClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadClientNameClinicalAudit_CheckedChanged(sender As Object, e As EventArgs) Handles RadClinicalClientName.CheckedChanged
        TxtClinicalClientName.Enabled = RadClinicalClientName.Checked
        TxtClinicalClientName.Focus()
        TxtClinicalClientName.SelectAll()
    End Sub
    Friend Sub InitTotalAuditClinicalAudit(DateClinicalAuditFrom As Date, DateClinicalAuditTo As Date)
        ' Me.GridClientNew.DataSource = DA_ClientManage.SelectDateToDateDetailAssNewOrOld(0, DateClinicalAuditFrom, DateClinicalAuditTo, True)
        'LblTotalClinicAudit.Text = (TotalAuditF + TotalAuditM)
        Dim TotalBlueF As Integer = DA_CLINICAL_AUDIT.TotalSexBlue("F", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalBlueM As Integer = DA_CLINICAL_AUDIT.TotalSexBlue("M", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalPinkF As Integer = DA_CLINICAL_AUDIT.TotalSexPink("F", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalPinkM As Integer = DA_CLINICAL_AUDIT.TotalSexPink("M", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalGreenF As Integer = DA_CLINICAL_AUDIT.TotalSexGreen("F", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalGreenM As Integer = DA_CLINICAL_AUDIT.TotalSexGreen("M", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalYellowF As Integer = DA_CLINICAL_AUDIT.TotalSexYellow("F", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalYellowM As Integer = DA_CLINICAL_AUDIT.TotalSexYellow("M", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        LblTotalPsycology.Text = ((TotalBlueF + TotalBlueM) + (TotalPinkF + TotalPinkM) + (TotalGreenF + TotalGreenM)).ToString & "(F=" & (TotalBlueF + TotalPinkF + TotalGreenF).ToString & ",M=" & (TotalBlueM + TotalPinkM + TotalGreenM) & ")"
        LblTotalNaro.Text = (TotalYellowF + TotalYellowM) & "(F=" & TotalYellowF & ",M=" & TotalYellowM & ")"
        Dim TotalOutKompongCham As Integer = DA_ReferralOutRich.TotalReferralToDateToDate(1, False, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalOutKpChnang As Integer = DA_ReferralOutRich.TotalReferralToDateToDate(2, False, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalOutBTB As Integer = DA_ReferralOutRich.TotalReferralToDateToDate(3, False, DateClinicalAuditFrom, DateClinicalAuditTo)
        LblTotalReferralToKgCham.Text = TotalOutKompongCham
        LblTotalReferralKGChnang.Text = TotalOutKpChnang
        LblTotalReferralBTB.Text = TotalOutBTB
        InitLabelWeek("Week " & GetWeekOfYear(StartDateWeek.Value.Date) & " th (" & StartDateWeek.Value.Date.Day & "-" & EndDateWeek.Value.Date.Day & " " & Format(EndDateWeek.Value.Date, "MMM yyyy") & ")")
    End Sub
    Friend Sub InitLabelWeek(Value As String)
        LblWeek.Text = Value
    End Sub
    Private Sub BtnFindClinicalAudit_Click(sender As Object, e As EventArgs) Handles BtnFindClinicalAudit.Click
        If RadClinicalAudit.Checked = True Then
            GridClinicalAudit.DataSource = DA_ClientClinicalAudit.SelectClinicalAuditDateToDate(DateClinicalAuditFrom.Value.Date, EndDateWeek.Value.Date)
        ElseIf RadClinicalAuditClientNo.Checked = True Then
            GridClinicalAudit.DataSource = DA_ClientClinicalAudit.SelectClinicalByClientNo(EmptyString(TxtClinicalClientNo.Text))
        ElseIf RadClinicalClientName.Checked = True Then
            GridClinicalAudit.DataSource = DA_ClientClinicalAudit.SelectClinicalAuditByName(TxtClinicalClientName.Text)
        ElseIf RadClinicalAuditWeek.Checked = True Then
            If ValidateCombobox(CboWeekOfYear, "", ErrorProvider1) = False Then Exit Sub
            If ValidateDateField(DateYear, "", ErrorProvider1) = False Then Exit Sub
            GridClinicalAudit.DataSource = DA_ClientClinicalAudit.SelectWeekAudited(DateYear.Value.Year, CboWeekOfYear.Text) 'GetWeekOfYear(StartDateWeek.Value.Date))
        ElseIf RadFullYear.Checked = True Then
            If ValidateDateField(DateFullYear, "", ErrorProvider1) = False Then Exit Sub
            GridClinicalAudit.DataSource = DA_ClientClinicalAudit.SelectCaseAuditFullYear(DateFullYear.Value.Year)
        End If

    End Sub
    Function GetWeekOfYear(DateOfYear As Date) As Integer
        Dim WeekNumber As Integer = DatePart(DateInterval.WeekOfYear, DateOfYear, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
        Return WeekNumber
    End Function
    Private Sub UpdateClinicalAudit_Click(sender As Object, e As EventArgs) Handles UpdateClinicalAudit.Click
        InitEditClientAudit
    End Sub

    Private Sub RadClinicalAuditWeek_CheckedChanged(sender As Object, e As EventArgs) Handles RadClinicalAuditWeek.CheckedChanged
        'LblWeek.Text = GetWeekOfYear()
        CboWeekOfYear.Enabled = RadClinicalAuditWeek.Checked
        DateYear.Enabled = RadClinicalAuditWeek.Checked
    End Sub
    Private Function GetWeekOfYear() As Integer
        Dim WeekNumber As Integer = DatePart(DateInterval.WeekOfYear, StartDateWeek.Value.Date, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
        Return WeekNumber
    End Function

    Private Sub DateClinicalWeekAudit_ValueChanged(sender As Object, e As EventArgs) Handles StartDateWeek.ValueChanged
        LblWeek.Text = GetWeekOfYear()
    End Sub


    Private Sub BtnListClientAudit_Click(sender As Object, e As EventArgs) Handles BtnListClientAudit.Click
        If ValidateDateField(DateAuditOn, "", ErrorProvider1) = False Then Exit Sub
        If ValidateDateField(StartDateWeek, "", ErrorProvider1) = False Then Exit Sub
        If ValidateDateField(EndDateWeek, "", ErrorProvider1) = False Then Exit Sub
        ' If GridClinicalAudit.GetRow.Cells("CLIENT_NO").Text = "" Then Exit Sub
        InitTotalAuditClinicalAudit(StartDateWeek.Value.Date, EndDateWeek.Value.Date)
        Dim RCClinicalAudit As New ReportClientClinicalAudit
        Dim TblClinicalAudit As DataTable = DA_ClientClinicalAudit.SelectWeekAudited(StartDateWeek.Value.Year, GetWeekOfYear(StartDateWeek.Value.Date))
        RCClinicalAudit.SetDataSource(TblClinicalAudit)
        RCClinicalAudit.SetParameterValue("DateClinicalAudit", Format(DateAuditOn.Value.Date, "dd.MM.yyyy"))
        RCClinicalAudit.SetParameterValue("WeekAudit", LblWeek.Text)
        RCClinicalAudit.SetParameterValue("TotalAudit", LblTotalClinicAudit.Text)
        RCClinicalAudit.SetParameterValue("TotalPsycology", LblTotalPsycology.Text)
        RCClinicalAudit.SetParameterValue("TotalNaro", LblTotalNaro.Text)
        RCClinicalAudit.SetParameterValue("TeferToCham", LblTotalReferralToKgCham.Text)
        RCClinicalAudit.SetParameterValue("ReferKChnang", LblTotalReferralKGChnang.Text)
        RCClinicalAudit.SetParameterValue("ReferToBTB", LblTotalReferralBTB.Text)
        Dim FAuditViewer As New AssessPrintPreview
        FAuditViewer.CrystalReportViewer1.ReportSource = RCClinicalAudit
        FAuditViewer.ShowDialog()

    End Sub

    Private Sub GridClinicalAudit_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridClinicalAudit.RowDoubleClick
        'InitEditClientAudit()
    End Sub
    Private Sub InitEditClientAudit()
        If GridClinicalAudit.SelectedItems.Count = 0 Then Exit Sub
        If GridClinicalAudit.GetRow.Cells("CLIENT_NO").Text = "" Then Exit Sub
        Dim FormClinicalAudit As New FormClinicalAuditAssessment
        FormClinicalAudit.LblSaveOption.Text = GridClinicalAudit.GetRow.Cells("CLIENT_ASSESS_ID").Value
        FormClinicalAudit.ShowClientInfo(GridClinicalAudit.GetRow.Cells("CLIENT_NO").Value)
        FormClinicalAudit.txtProvisionalDiagnosis.Text = GridClinicalAudit.GetRow.Cells("CLIENT_PRO_DIAGNOSIS").Value
        FormClinicalAudit.cboTherapist.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("THERAPIST_NAME").Value) = True, "", GridClinicalAudit.GetRow.Cells("THERAPIST_NAME").Value)
        Try
            FormClinicalAudit.DateClinicalAuditOn.Checked = True

            FormClinicalAudit.DateClinicalAuditOn.Value = GridClinicalAudit.GetRow.Cells("DATE_AUDIT_ON").Value
        Catch ex As Exception
            FormClinicalAudit.DateClinicalAuditOn.Value = Nothing
        End Try

        FormClinicalAudit.txtFinalDiagnosis.Text = GridClinicalAudit.GetRow.Cells("CLIENT_FINAL_DIAGNOSIS").Value
        FormClinicalAudit.TxtWeekUnderReview.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("WEEK_NO").Value) = True, "", GridClinicalAudit.GetRow.Cells("WEEK_NO").Value)
        FormClinicalAudit.TxtAssessmentCompleted.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("CLIENT_ASSESS_COMPLED").Value) = True, "", GridClinicalAudit.GetRow.Cells("CLIENT_ASSESS_COMPLED").Value)
        FormClinicalAudit.TxtAssessmentBeDone.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("CLIENT_ASSESS_TOBEDONE").Value) = True, "", GridClinicalAudit.GetRow.Cells("CLIENT_ASSESS_TOBEDONE").Value)
        FormClinicalAudit.txtMedication.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("CLIENT_MEDICATION").Value) = True, "", GridClinicalAudit.GetRow.Cells("CLIENT_MEDICATION").Value)
        FormClinicalAudit.txtOtherTherapies.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("CLIENT_OTHER_THERAPIES").Value) = True, "", GridClinicalAudit.GetRow.Cells("CLIENT_OTHER_THERAPIES").Value)
        FormClinicalAudit.txtResponseToTherapy.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("CLIENT_RESPONSE").Value) = True, "", GridClinicalAudit.GetRow.Cells("CLIENT_RESPONSE").Value)
        FormClinicalAudit.txtEngagement.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("CLIENT_RAPPORT_ENGAGEMENT").Value) = True, "", GridClinicalAudit.GetRow.Cells("CLIENT_RAPPORT_ENGAGEMENT").Value)
        FormClinicalAudit.txtLiasion.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("CLIENT_LIASION").Value) = True, "", GridClinicalAudit.GetRow.Cells("CLIENT_LIASION").Value)
        FormClinicalAudit.txtActionPlan.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("CLIENT_ACTION_PLAN").Value) = True, "", GridClinicalAudit.GetRow.Cells("CLIENT_ACTION_PLAN").Value)

        FormClinicalAudit.TxtNumberVisit.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("NUMBER_VISIT").Value) = True, "", GridClinicalAudit.GetRow.Cells("NUMBER_VISIT").Value)
        FormClinicalAudit.LblWeekLabel.Text = GridClinicalAudit.GetRow.Cells("WEEK_NO_LABEL").Text
        Try
            FormClinicalAudit.DateNextVisist.Checked = True
            FormClinicalAudit.DateNextVisist.Value = GridClinicalAudit.GetRow.Cells("NEXT_VISIT").Value
        Catch ex As Exception
            FormClinicalAudit.DateNextVisist.Checked = False
        End Try

        FormClinicalAudit.CboDiscussWriting.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("DISCUSS_WRITING").Value) = True, "", GridClinicalAudit.GetRow.Cells("DISCUSS_WRITING").Value)
        FormClinicalAudit.CboOnlyDiscuss.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("DISCUSS_ONLY").Value) = True, "", GridClinicalAudit.GetRow.Cells("DISCUSS_ONLY").Value)
        FormClinicalAudit.CboCall.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("CALL_CLIENT").Value) = True, "", GridClinicalAudit.GetRow.Cells("CALL_CLIENT").Value)
        FormClinicalAudit.TxtAuditRemark.Text = IIf(IsDBNull(GridClinicalAudit.GetRow.Cells("ASSEMENT_REMARK").Value) = True, "", GridClinicalAudit.GetRow.Cells("ASSEMENT_REMARK").Value)
        If FormClinicalAudit.ShowDialog = DialogResult.OK Then
            ' RadClinicalAuditClientNo.Checked = True
            GridClinicalAudit.DataSource = DA_ClientClinicalAudit.SelectClinicalByClientNo(EmptyString(GridClinicalAudit.GetRow.Cells("CLIENT_NO").Value))
        End If
    End Sub
    Private Sub BtnnFind_Click(sender As Object, e As EventArgs) Handles BtnnFind.Click
        If RadAllCaseAudit.Checked = True Then
            GridClientCaseDropOut.DataSource = DA_CaseDropOut.SelectAllCaseAudit(DFrom.Value.Date, DTo.Value.Date)

        ElseIf RadStopVisit.Checked = True Then
            GridClientCaseDropOut.DataSource = DA_CaseDropOut.SelectCaseAuditStopVisit(DFrom.Value.Date, DTo.Value.Date, True)
        ElseIf RadDropOut.Checked = True Then
            GridClientCaseDropOut.DataSource = DA_CaseDropOut.SelectCaseAuditDropOut(DFrom.Value.Date, DTo.Value.Date, True)
        End If
    End Sub

    
    Private Sub BtnDeleteCaseAudit_Click(sender As Object, e As EventArgs) Handles BtnDeleteCaseAudit.Click
        If GridClientCaseDropOut.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_CaseDropOut.DeleteCaseAudit(GridClientCaseDropOut.GetRow.Cells("OUTCOME_ID").Value) = 1 Then
                BtnnFind_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnNewCaseAudit_Click(sender As Object, e As EventArgs) Handles BtnNewCaseAudit.Click
     
        Dim FCaseDropOut As New FormCaseDropOut
        FCaseDropOut.TxtClientNo.ReadOnly = False
        FCaseDropOut.BtnFindClient.Visible = True
        ' FCaseDropOut.InitClientInfo(GridClientAppointment.GetRow.Cells("CLIENT_NO").Value)
        ' FCaseDropOut.RadDropOut.Checked = True
        If FCaseDropOut.ShowDialog = DialogResult.OK Then
            ' DA_Appointment.UpdateAppointmentCaseDropOut(True, USER_NAME, Now.Date, GridClientAppointment.GetRow.Cells("APP_ID").Value)
            BtnnFind_Click(sender, e)
        End If
    End Sub

    Private Sub BtnUpdateCashAudit_Click(sender As Object, e As EventArgs) Handles BtnUpdateCashAudit.Click
        initUpdateCaseAuditStopOrDropOut()

    End Sub
    Private Sub InitUpdateCaseAuditStopOrDropOut()
        If GridClientCaseDropOut.SelectedItems.Count = 0 Then Exit Sub
        Dim FCaseDropOut As New FormCaseDropOut
        FCaseDropOut.GroupClientIno.Enabled = False
        FCaseDropOut.InitClientInfo(GridClientCaseDropOut.GetRow.Cells("CLIENT_NO").Value)
        FCaseDropOut.LoadCaseAudit(GridClientCaseDropOut.GetRow.Cells("CLIENT_NO").Value)
        If FCaseDropOut.ShowDialog = DialogResult.OK Then
            BtnnFind_Click(sender, e)
            ' DA_Appointment.UpdateAppointmentCaseDropOut(True, USER_NAME, Now.Date, GridClientAppointment.GetRow.Cells("APP_ID").Value)
        End If
    End Sub

    Private Sub GridClientCaseDropOut_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridClientCaseDropOut.RowDoubleClick
        InitUpdateCaseAuditStopOrDropOut()
    End Sub

    Private Sub CboWeekOfYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboWeekOfYear.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadFullYear_CheckedChanged(sender As Object, e As EventArgs) Handles RadFullYear.CheckedChanged
        DateFullYear.Enabled = RadFullYear.Checked
    End Sub

    Private Sub GridClinicalAudit_SelectionChanged(sender As Object, e As EventArgs) Handles GridClinicalAudit.SelectionChanged
        Try
            DateAuditOn.Checked = True
            StartDateWeek.Checked = True
            EndDateWeek.Checked = True
            DateAuditOn.Value = GridClinicalAudit.GetRow.Cells("DATE_AUDIT_ON").Value
            StartDateWeek.Value = GridClinicalAudit.GetRow.Cells("WEEK_START_DATE").Value
            EndDateWeek.Value = GridClinicalAudit.GetRow.Cells("WEEK_END_DATE").Value
            InitTotalAuditClinicalAudit(StartDateWeek.Value.Date, EndDateWeek.Value.Date)
        Catch ex As Exception
            DateAuditOn.Checked = False
            StartDateWeek.Checked = False
            EndDateWeek.Checked = False
            DateAuditOn.Value = Now
            StartDateWeek.Value = Now
            EndDateWeek.Value = Now
        End Try
        
    End Sub

    
    Private Sub BtnPrintCaseDropOut_Click(sender As Object, e As EventArgs) Handles BtnPrintCaseDropOut.Click
        Dim FPreview As New FormPublicReportViewer
        Dim TblCaseDropOut As DataTable = DA_CaseDropOut.SelectAllCaseAudit(DFrom.Value.Date, DTo.Value.Date)
        Dim CRReportCaseDropOut As New ReportCaseDropOutProfile
        CRReportCaseDropOut.SetDataSource(TblCaseDropOut)
        CRReportCaseDropOut.SetParameterValue("Title", " From:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To " & Format(DTo.Value.Date, "dd/MM/yyyy"))
        FPreview.CrvViewer.ReportSource = CRReportCaseDropOut
        FPreview.ShowDialog()
    End Sub

    'Private Sub BtnUpdateNextVisit_Click(sender As Object, e As EventArgs) Handles BtnUpdateNextVisit.Click
    '    ' If GridClinicalAudit.SelectedItems.Count = 0 Then Exit Sub
    '    'MessageBox.Show(GridClinicalAudit.SelectedItems.Count)
    '    'For Each GRows As Janus.Windows.GridEX.GridEXRow In GridClinicalAudit.GetRows
    '    '    Dim ClientNo As Double = GRows.Cells("CLIENT_NO").Value
    '    '    MessageBox.Show(ClientNo)
    '    'Next
    '    'For i As Integer = 0 To GridClinicalAudit.GetRows.Count - 1 'SelectedItems.Count - 1
    '    '    Dim ClientNo As Double = GridClinicalAudit.GetRow(i).Cells("CLIENT_NO").Value
    '    '    ' MessageBox.Show(GetLastAppointment(ClientNo))
    '    '    Try
    '    '        DA_ASSESSMENT_INFO.UpdateDateNextVisit(GetLastAppointment(ClientNo).Date, ClientNo)
    '    '    Catch ex As Exception

    '    '    End Try

    '    'Next
    '    MessageBox.Show(GridClinicalAudit.GetRows.Count)
    '    For i As Integer = 0 To GridClinicalAudit.GetRows.Count - 1
    '        Dim ClientNo As Double = GridClinicalAudit.GetRow(i).Cells("CLIENT_NO").Value
    '        MessageBox.Show(ClientNo)
    '    Next
    'End Sub
    Private Function GetLastAppointment(ClientNo As Double) As Date
        Try
            For Each Drow As DataRow In DA_App.SelectAllAppointment(ClientNo).Rows
                Return Drow("APP_DATE")
            Next
            'Return DA_App.SelectLastAppointment(ClientNo)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Class
