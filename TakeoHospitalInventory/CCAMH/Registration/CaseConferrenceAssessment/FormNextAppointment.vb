Public Class FormNextAppointment
    Dim DA_THERPIST As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_NextApp As New DSAssessmentTableAdapters.CCAMH_CLIENT_APPOINTSTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        IntParaTherapists()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrNextAppointment) = False Then Exit Sub
        If ValidateTextField(TxtClientNameKH, "", ErrNextAppointment) = False Then Exit Sub
        If ValidateTextField(TxtClientNameEng, "", ErrNextAppointment) = False Then Exit Sub
        If ValidateCombobox(CboMeetWith, "", ErrNextAppointment) = False Then Exit Sub
        If ValidateDateTimePicker(DateAppointment, "", ErrNextAppointment) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new appointment?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_NextApp.InsertNewAppointment(TxtClientNo.Text, CboMeetWith.SelectedValue, CboMeetWith.Text, DateAppointment.Value.Date, TimeAppointment.Value, TxtAppointmentNote.Text, "", "", False, "") = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If

            End If
        Else
            If MessageBox.Show("Do you want to update appointment?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_NextApp.UpdateNextAppointment(TxtClientNo.Text, CboMeetWith.SelectedValue, CboMeetWith.Text, DateAppointment.Value.Date, TimeAppointment.Value, TxtAppointmentNote.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnAddTherapist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddTherapist.Click
        Dim frm As New FormTherapist
        If frm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            IntParaTherapists()
        End If
    End Sub
    Private Sub IntParaTherapists()
        With CboMeetWith
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub FormNextAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class