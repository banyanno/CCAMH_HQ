Public Class FormClinicalAuditAssessment
    Dim isEdit As Boolean = False
    Dim isUpdate As Boolean = False
    Dim patientNo As Double

    Dim DA_CLIENT_INFO As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_VIEW_ADVISED_CLIENTSTableAdapter
    Dim DA_Therapist As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_ASSESSMENTS As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_ASSESSMENTSTableAdapter
    Dim DA_ASSESSMENT_INFO As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_CLIENT_ASSESSMENT_INFOTableAdapter
    Dim DA_ASSESSMENT_DETAIL As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_ASSESSMENT_DETAILTableAdapter
    Dim DA_THERPIST As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_SOCIAL As New DS_CCAMH_ASSESSMENTSTableAdapters.CLIENT_CA_SOCIALTableAdapter
    Public tblAssessment As DataTable = New DS_CCAMH_ASSESSMENTS.CCAMH_ASSESSMENTSDataTable
    Public tblAssessDetail As DataTable = New DS_CCAMH_ASSESSMENTS.CCAMH_ASSESSMENT_DETAILDataTable
    Dim DA_ClientClinicalAudit As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_VIEW_ACTIVE_ADVISED_CLIENTSTableAdapter
    Dim DA_Reffered As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_REFERED_DETIALTableAdapter
    Dim TblClient As DataTable

    Public Property getIsUpdate() As Boolean
        Get
            Return isUpdate
        End Get
        Set(ByVal value As Boolean)
            isUpdate = value
        End Set
    End Property

    Public Property getIsEdit() As Boolean
        Get
            Return isEdit
        End Get
        Set(ByVal value As Boolean)
            isEdit = value
        End Set
    End Property

    Public Property getPatientNo() As Double
        Get
            Return patientNo
        End Get
        Set(ByVal value As Double)
            patientNo = value
        End Set
    End Property
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With cboTherapist
            .DataSource = DA_Therapist.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Friend Sub ShowClientInfo(ClientNo As Double)
        TblClient = DA_CLIENT_INFO.GetDataByClientNo(ClientNo)
        Dim RerferedBy As String
        For Each ClientDRows As DataRow In TblClient.Rows
            DateRegister.Value = Convert.ToDateTime(ClientDRows("CLIENT_DATE_REG").ToString)
            TxtClientNo.Text = ClientDRows("CLIENT_NO").ToString
            txtClientNameEng.Text = ClientDRows("CLIENT_NAME")
            TxtClientClientNameKh.Text = ClientDRows("CLIENT_NAME_KHM")
            txtClientAge.Text = ClientDRows("CLIENT_AGE")
            TxtClientSex.Text = ClientDRows("CLIENT_SEX")
            DateDOB.Value = Convert.ToDateTime(ClientDRows("CLIENT_DOB").ToString)
            TxtNumberVisit.Text = ClientDRows("NUMBER_VISIT")
            If IsDBNull(ClientDRows("MAIN_THERAPY_NAME")) = False Then
                cboTherapist.Text = ClientDRows("MAIN_THERAPY_NAME")
            Else

                cboTherapist.SelectedIndex = -1
            End If
        Next
        For Each drowReffer As DataRow In DA_Reffered.SelectClientRefferedByClientNo(ClientNo).Rows
            RerferedBy = RerferedBy & drowReffer("REFERED_FROM") & " "
        Next
        TxtRefferedBy.Text = RerferedBy
    End Sub
    Private Sub FormAssessment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If patientNo <> 0 Then
            If isUpdate = False Then
                RefreshTherapists()
            Else
                ' When Therapist update assessments
                Dim TblAssessmentInfo As DataTable
                ' Dim TblAssessDetail As DataTable
                TblAssessmentInfo = DA_ASSESSMENT_INFO.GetDataByClientNo(patientNo)

                For Each row As DataRow In TblAssessmentInfo.Rows
                    If IsDBNull(row("CLIENT_PRO_DIAGNOSIS")) = False Then
                        txtProvisionalDiagnosis.Text = row("CLIENT_PRO_DIAGNOSIS").ToString
                    End If
                    If IsDBNull(row("CLIENT_FINAL_DIAGNOSIS")) = False Then
                        txtFinalDiagnosis.Text = row("CLIENT_FINAL_DIAGNOSIS").ToString
                    End If
                    If IsDBNull(row("CLIENT_MEDICATION")) = False Then
                        txtMedication.Text = row("CLIENT_MEDICATION").ToString
                    End If
                    If IsDBNull(row("CLIENT_OTHER_THERAPIES")) = False Then
                        txtOtherTherapies.Text = row("CLIENT_OTHER_THERAPIES").ToString
                    End If
                    If IsDBNull(row("CLIENT_RESPONSE")) = False Then
                        txtResponseToTherapy.Text = row("CLIENT_RESPONSE").ToString
                    End If
                    If IsDBNull(row("CLIENT_RAPPORT_ENGAGEMENT")) = False Then
                        txtEngagement.Text = row("CLIENT_RAPPORT_ENGAGEMENT").ToString
                    End If
                    If IsDBNull(row("CLIENT_ACTION_PLAN")) = False Then
                        txtActionPlan.Text = row("CLIENT_ACTION_PLAN").ToString
                    End If
                    If IsDBNull(row("CLIENT_LIASION")) = False Then
                        txtLiasion.Text = row("CLIENT_LIASION").ToString
                    End If

                    'Dim Therapist_ID As Decimal

                    'If IsDBNull(row("THERAPIST_ID")) = False Then
                    '    Therapist_ID = Decimal.Parse(row("THERAPIST_ID"))
                    'Else
                    '    Therapist_ID = -1
                    'End If

                    'With cboTherapist
                    '    .DataSource = DA_THERPIST.GetData
                    '    .ValueMember = "THERAPIST_ID"
                    '    .DisplayMember = "THERAPIST_NAME"
                    '    .SelectedValue = Therapist_ID
                    'End With

                    tblAssessDetail = DA_ASSESSMENT_DETAIL.GetDataByClientNo(patientNo)
                    ' GridAssessment.DataSource = tblAssessDetail
                Next

            End If

        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtProvisionalDiagnosis_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProvisionalDiagnosis.Enter
        'SetKhmerLanguage()
    End Sub
    Function CheckExistingItem(ByVal ItemId As Integer, ByVal Grid As Janus.Windows.GridEX.GridEX) As Boolean
        For Each row As Janus.Windows.GridEX.GridEXRow In Grid.GetRows
            If row.Cells("ASSESS_ID").Value = ItemId Then
                Return True
                Exit Function
                'Else
                '    Return False
            End If
        Next
    End Function


    Private Sub txtAssessNotes_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        SetKhmerLanguage()
    End Sub

    'Private Sub assess_minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If GridAssessment.Row < 0 Then Exit Sub
    '    If MessageBox.Show("Do you want to remove this assessment item?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
    '        tblAssessDetail.BeginLoadData()
    '        tblAssessDetail.Rows.RemoveAt(GridAssessment.Row)
    '        tblAssessDetail.EndLoadData()
    '        GridAssessment.Refresh()
    '        GridAssessment.DataSource = tblAssessDetail
    '    End If
    'End Sub

    Private Sub btnAddTherapist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTherapist.Click
        Dim frm As New FormTherapist
        If frm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshTherapists()
        End If
    End Sub
    Private Sub RefreshTherapists()
        With cboTherapist
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' If cboTherapist.SelectedValue Is Nothing Then Exit Sub
        'If GridAssessment.Row < 0 Then Exit Sub
        If ValidateDateField(DateClinicalAuditOn, "", ErrClininicalAudit) = False Then Exit Sub
        If ValidateTextField(TxtClientNo, "", ErrClininicalAudit) = False Then Exit Sub
        If ValidateCombobox(cboTherapist, "", ErrClininicalAudit) = False Then Exit Sub
        Dim client_no As Decimal = patientNo
        Dim ClientNameEng As String = txtClientNameEng.Text
        Dim ClientNameKh As String = TxtClientClientNameKh.Text
        Dim ClientAge As Decimal = txtClientAge.Text
        Dim ClientSex As String = TxtClientSex.Text
        Dim ClientDOB As DateTime = DateDOB.Value.Date
        Dim ClientDRegister As DateTime = DateRegister.Value.Date
        Dim date_of_discuss As DateTime = DateClinicalAuditOn.Value.Date
        Dim DateNextVisit As DateTime = DateNextVisist.Value.Date
        Dim WeekUnderReview As Integer = EmptyString(TxtWeekUnderReview.Text)
        Dim NumberVisit As Integer = TxtNumberVisit.Text
        Dim Therapis As String = cboTherapist.Text
        Dim TherapisName As String = cboTherapist.Text
        Dim pre_diagnosis As String = txtProvisionalDiagnosis.Text
        Dim final_diagnosis As String = txtFinalDiagnosis.Text
        Dim therapist_id As Decimal = cboTherapist.SelectedValue
        Dim medication As String = txtMedication.Text
        Dim otherTherapy As String = txtOtherTherapies.Text
        Dim response As String = txtResponseToTherapy.Text
        Dim engagement As String = txtEngagement.Text
        Dim actionPlan As String = txtActionPlan.Text
        Dim mngPlan As String = ""
        Dim liasion As String = txtLiasion.Text
        If LblSaveOption.Text = "0" Then
            If DA_ASSESSMENT_INFO.CheckExistingClinicAudit(TxtClientNo.Text) > 0 Then
                MessageBox.Show("The client already exist in clinical audit. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If MessageBox.Show("Do you want to save new clinical audit?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_ASSESSMENT_INFO.InsertClinicalAuditQuery(TxtClientNo.Text, pre_diagnosis, mngPlan, final_diagnosis, date_of_discuss, _
                                                          date_of_discuss, medication, otherTherapy, response, engagement, liasion, _
                                                          actionPlan, therapist_id, Now.Date, ClientNameEng, ClientNameKh, _
                                                          ClientSex, ClientAge, ClientDOB, NumberVisit, IIf(DateNextVisist.Checked = True, DateNextVisist.Value.Date, Nothing), _
                                                          CboDiscussWriting.Text, CboOnlyDiscuss.Text, CboCall.Text, TxtAuditRemark.Text, TherapisName, TxtWeekUnderReview.Text, TxtAssessmentBeDone.Text, TxtAssessmentCompleted.Text, TxtRefferedBy.Text, DateClinicalAuditOn.Value.Date, TxtWeekUnderReview.Text, StartDateWeek.Value.Date, EndDateWeek.Value.Date, LblWeekLabel.Text) = 1 Then

                    'If GridAssessment.SelectedItems.Count > 0 Then
                    '    For Each GRow As Janus.Windows.GridEX.GridEXRow In GridAssessment.GetRows
                    '        DA_ASSESSMENT_DETAIL.InsertQuery(client_no, GRow.Cells("ASSESS_ID").Value, GRow.Cells("ASSESS_NAME").Value, GRow.Cells("ASSESS_DESCRIPTION").Value)
                    '    Next
                    'End If
                    DA_SOCIAL.UpdateAssessedClient(client_no)
                    MessageBox.Show("Assessments for client is successfully saved!", "Assessment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim FPrintPreveiw As New AssessPrintPreview
                    Dim CRClinicalAudit As New ReportAssessedClient
                    Dim tblClinicalAudit As DataTable = DA_ClientClinicalAudit.SelectClinicalByClientNo(Me.TxtClientNo.Text)
                    CRClinicalAudit.SetDataSource(tblClinicalAudit)
                    FPrintPreveiw.CrystalReportViewer1.ReportSource = CRClinicalAudit
                    FPrintPreveiw.ShowDialog()
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK

                End If
            End If

        Else
            If MessageBox.Show("Do you want to update clinical audit?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                DA_ASSESSMENT_INFO.UpdateAssessInfoByClientNo(pre_diagnosis, actionPlan, final_diagnosis, date_of_discuss, medication, otherTherapy, response, _
                                                              engagement, liasion, actionPlan, therapist_id, Now.Date, txtClientNameEng.Text, _
                                                              TxtClientClientNameKh.Text, TxtClientSex.Text, txtClientAge.Text, DateDOB.Value.Date, _
                                                              TxtNumberVisit.Text, DateNextVisist.Value.Date, CboDiscussWriting.Text, _
                                                              CboOnlyDiscuss.Text, CboCall.Text, TxtAuditRemark.Text, TxtWeekUnderReview.Text, _
                                                              TxtAssessmentBeDone.Text, TxtAssessmentCompleted.Text, cboTherapist.Text, TxtRefferedBy.Text, DateClinicalAuditOn.Value.Date, TxtWeekUnderReview.Text, StartDateWeek.Value.Date, EndDateWeek.Value.Date, LblWeekLabel.Text, LblSaveOption.Text)
                'If GridAssessment.SelectedItems.Count > 0 Then
                '    DA_ASSESSMENT_DETAIL.DeleteByClientNo(patientNo)
                '    For Each GRow As Janus.Windows.GridEX.GridEXRow In GridAssessment.GetRows
                '        DA_ASSESSMENT_DETAIL.UpdateByTherapist(patientNo, GRow.Cells("ASSESS_ID").Value, GRow.Cells("ASSESS_NAME").Value, GRow.Cells("ASSESS_DESCRIPTION").Value, GRow.Cells("ASSESS_COMPLETED").Value)
                '    Next
                'End If
                MessageBox.Show("Assessments for client is successfully update!", "Assessment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If


        End If


    End Sub

    

    Private Sub TxtNumberVisit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumberVisit.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class