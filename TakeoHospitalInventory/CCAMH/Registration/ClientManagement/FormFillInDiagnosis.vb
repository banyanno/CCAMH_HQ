Public Class FormFillInDiagnosis
    Dim DA_Diagnosis As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_DIAGNOSISTableAdapter
    Dim DA_Client As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim DA_ClientMG As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim DA_ClientManagement As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter

    Dim DA_THERPIST As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_NextApp As New DSAssessmentTableAdapters.CCAMH_CLIENT_APPOINTSTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDiagnosis
            .DataSource = DA_Diagnosis.GetData
            .ValueMember = "diag_cat_id"
            .DisplayMember = "diagnosis"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.
        IntParaTherapists()
    End Sub
    Private Sub IntParaTherapists()
        With CboMeetWith
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboDiagnosis, "", ErrFillInDiagnosis) = False Then Exit Sub
        If ChNextAppointment.Checked = True Then
            If ValidateCombobox(CboMeetWith, "", ErrFillInDiagnosis) = False Then Exit Sub
            If ValidateDateTimePicker(DateAppointment, "", ErrFillInDiagnosis) = False Then Exit Sub
        End If
        If CboDiagnosis.SelectedValue Is Nothing Then
            MessageBox.Show("Please select correct diagnosis!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_ClientMG.UpdateEnterDiagnosis(LblDiagnosisID.Text, CboDiagnosis.Text, CboDiagnosis.SelectedValue, LblImpression.Text, LblSaveOption.Text) = 1 Then
                DA_ClientManagement.UpdateAppointmentstatus(CboAppointStatus.Text, LblSaveOption.Text)
                
                '================ Insert new appointment ============
                If ChNextAppointment.Checked = True Then
                    DA_NextApp.InsertNewAppointment(TxtClientNo.Text, CboMeetWith.SelectedValue, CboMeetWith.Text, DateAppointment.Value.Date, TimeAppointment.Value, TxtAppointmentNote.Text, "", "", False, "")
                End If

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
            If DA_Client.UpdateDiagnosis(CboDiagnosis.SelectedValue, LblDiagnosisID.Text, CboDiagnosis.Text, LblImpression.Text, TxtClientNo.Text) = 1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
      
    End Sub

    
    Private Sub CboDiagnosis_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDiagnosis.SelectedValueChanged
        If CboDiagnosis.SelectedValue Is Nothing Then Exit Sub
        Try
            LblDiagnosisID.Text = DA_Diagnosis.SelectDiagnosisID(CboDiagnosis.Text)
            LblImpression.Text = DA_Diagnosis.SelectCategoryByDiagnosis(CboDiagnosis.Text)
        Catch ex As Exception
            LblDiagnosisID.Text = ""
        End Try


    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub ChNextAppointment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChNextAppointment.CheckedChanged
        GroupNextApp.Enabled = ChNextAppointment.Checked
    End Sub
End Class