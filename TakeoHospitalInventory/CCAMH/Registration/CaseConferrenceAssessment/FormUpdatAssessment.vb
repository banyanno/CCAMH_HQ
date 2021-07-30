Public Class FormUpdatAssessment
    Dim DA_Assessment As New DS_ClientImpressionTableAdapters.CLIENT_CA_SOCIALTableAdapter 'DS_CCAMHClient_ImpressionsTableAdapters.CLIENT_CA_SOCIALTableAdapter
    Dim DA_THERPIST As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        IntParaTherapists()
    End Sub
    Private Sub IntParaTherapists()
        With CboMainTherapy
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrAssessment) = False Then Exit Sub
        If ValidateTextField(TxtClientName, "", ErrAssessment) = False Then Exit Sub
        If ValidateCombobox(CboAssessmentStatus, "", ErrAssessment) = False Then Exit Sub
        If ChDoAssessment.Checked = True Then
            If CboAssessmentStatus.Text <> "Normal" Then
                If ValidateDateTimePicker(DateDoAssessment, "", ErrAssessment) = False Then Exit Sub
            End If

        End If
        If MessageBox.Show("Do you want to update detail assessment?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_Assessment.UpdateAssessment(CboAssessmentStatus.Text, (IIf(DateDoAssessment.Checked = False, Nothing, DateDoAssessment.Value.Date)), TxtAssessmentNote.Text, ChDoAssessment.Checked, TxtClientNo.Text) = 1 Then
                DA_Assessment.UpdateMainTherapy(CInt(IIf(CboMainTherapy.SelectedValue Is Nothing, 0, CboMainTherapy.SelectedValue)), CboMainTherapy.Text, TxtClientNo.Text)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class