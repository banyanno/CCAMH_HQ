Public Class UIChiefDashboard

    Dim DA_Chief_Detail As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_VIEW_CHIEFCOMPLAINTSTableAdapter
    Dim DA_Client_ASSESS As New DS_ClientImpressionTableAdapters.CCAMH_VIEW_ADVISED_CLIENTSTableAdapter  'DS_CCAMHClient_ImpressionsTableAdapters.CLIENT_CA_SOCIALTableAdapter
    Dim DA_CLIENT_INFO As New DS_ClientImpressionTableAdapters.CCAMH_VIEW_ADVISED_CLIENTSTableAdapter 'DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_VIEW_ADVISED_CLIENTSTableAdapter
    Dim TblClient As DataTable
    Dim TblChief As DataTable

    Private Sub UIChiefDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        FindClientInformation()

    End Sub
    Private Sub CalculatTotalAssessment()

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

	
    Private Sub FindClientInformation()

        If RadViewAllClient.Checked = True Then
            DataGridClient.DataSource = DA_CLIENT_INFO.GetAllDateToDate(DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadClientNo.Checked = True Then
            DataGridClient.DataSource = DA_CLIENT_INFO.GetDataByClientNo(EmptyString(TxtClientNo.Text), DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadClientName.Checked = True Then
            DataGridClient.DataSource = DA_CLIENT_INFO.GetDataByClientName(TxtClientName.Text, DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadClientTel.Checked = True Then
            DataGridClient.DataSource = DA_CLIENT_INFO.GetDataByPhone(TxtClientTel.Text, DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadAssStatus.Checked = True Then
            DataGridClient.DataSource = DA_CLIENT_INFO.SelectAssementStatusDateToDate(CboAdviseAssessment.Text, DFrom.Value.Date, DTo.Value.Date) ' cboStatus.SelectedValue)
        End If
        CalculatTotalAssessment()
    End Sub
   
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If DataGridClient.SelectedItems.Count = 0 Then Exit Sub

        Dim CRChiefPreview As New ReportChiefComplaint
        Dim FPrintPreview As New ChiefPrintPreview
        TblClient = DA_CLIENT_INFO.GetDataByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value, DFrom.Value.Date, DTo.Value.Date)
        TblChief = DA_Chief_Detail.GetDataByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        CRChiefPreview.Database.Tables(0).SetDataSource(TblClient)
        CRChiefPreview.Database.Tables(1).SetDataSource(TblChief)
        FPrintPreview.CrystalReportObject = CRChiefPreview
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
    End Sub

    Private Sub BtnNewRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewRegistration.Click
        If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim frmAssessment As New FormClinicalAuditAssessment
        frmAssessment.getIsEdit = True
        frmAssessment.getPatientNo = DataGridClient.GetRow.Cells("CLIENT_NO").Value
        ' frmClientReg.ShowDialog()
        If frmAssessment.ShowDialog() = DialogResult.OK Then


        End If
    End Sub

    Private Sub DataGridClient_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridClient.Click
        If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim select_value As Decimal
        select_value = DataGridClient.GetRow.Cells("CLIENT_NO").Value
        'GridEX1.DataSource = DA_Reg_Preview.GetDataByClientNo(select_value)
    End Sub


    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtClientNo.Enabled = RadClientNo.Checked
        TxtClientNo.Select()
        TxtClientNo.Focus()
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindClientInformation()
    End Sub

    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientName.CheckedChanged
        TxtClientName.Enabled = RadClientName.Checked
        TxtClientName.Select()
        TxtClientName.Focus()
    End Sub

    Private Sub RadClientTel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientTel.CheckedChanged
        TxtClientTel.Enabled = RadClientTel.Checked
        TxtClientTel.Select()
        TxtClientTel.Focus()
    End Sub

    Private Sub BtnClientRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FindClientInformation()
    End Sub

    Private Sub RadAssStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAssStatus.CheckedChanged
        CboAdviseAssessment.Enabled = RadAssStatus.Checked
        CboAdviseAssessment.Select()
        CboAdviseAssessment.Focus()
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnUpdateDetailAssesment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateDetailAssesment.Click
        If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim FUpdateAssessment As New FormUpdatAssessment
        FUpdateAssessment.TxtClientNo.Text = DataGridClient.GetRow.Cells("CLIENT_NO").Value
        FUpdateAssessment.TxtClientName.Text = DataGridClient.GetRow.Cells("CLIENT_NAME").Value
        FUpdateAssessment.ChDoAssessment.Checked = DataGridClient.GetRow.Cells("CLIENT_ADVICED_ASSESSMENT_DETAIL").Value
        FUpdateAssessment.CboAssessmentStatus.Text = DataGridClient.GetRow.Cells("CLIENT_ADVISED_ASSESSMENT").Value
        If TypeOf DataGridClient.GetRow.Cells("CLIENT_ADVISED_ASSESSMENT_DATE").Value Is DBNull Then
            FUpdateAssessment.DateDoAssessment.Checked = False
        Else
            FUpdateAssessment.DateDoAssessment.Checked = True
            FUpdateAssessment.DateDoAssessment.Value = DataGridClient.GetRow.Cells("CLIENT_ADVISED_ASSESSMENT_DATE").Value
        End If
        FUpdateAssessment.TxtAssessmentNote.Text = DataGridClient.GetRow.Cells("CLIENT_ADVICED_ASSESSMENT_NOTE").Value
        If FUpdateAssessment.ShowDialog() = DialogResult.OK Then
            RadClientNo.Checked = True
            TxtClientNo.Text = FUpdateAssessment.TxtClientNo.Text
            FindClientInformation()
        End If

    End Sub

    Private Sub BtnViewClientDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewClientDetail.Click
        If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim frm As New FormClientRegistration1
        frm.getIsEdit = True
        frm.getPatientNo = CDbl(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        frm.ShowDialog()
    End Sub

    Private Sub BtnPrintListOfDetailAssess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintListOfDetailAssess.Click
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

    Private Sub BtnNextAppointMent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextAppointMent.Click
        If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim NextAppoint As New FormNextAppointment
        NextAppoint.TxtClientNo.Text = DataGridClient.GetRow.Cells("CLIENT_NO").Value
        NextAppoint.TxtClientNameKH.Text = DataGridClient.GetRow.Cells("CLIENT_NAME_KHM").Value
        NextAppoint.TxtClientNameEng.Text = DataGridClient.GetRow.Cells("CLIENT_NAME").Value
        NextAppoint.TxtClientSex.Text = DataGridClient.GetRow.Cells("CLIENT_SEX").Value
        NextAppoint.TxtClientAge.Text = DataGridClient.GetRow.Cells("CLIENT_AGE").Value
        If NextAppoint.ShowDialog = DialogResult.OK Then
            MessageBox.Show("Save new appointment sussesful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NextAppoint.Close()
        End If
    End Sub

    Private Sub DataGridClient_FormattingRow(sender As Object, e As Janus.Windows.GridEX.RowLoadEventArgs) Handles DataGridClient.FormattingRow

    End Sub
End Class
