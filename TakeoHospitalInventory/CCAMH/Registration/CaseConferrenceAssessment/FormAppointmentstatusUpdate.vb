Public Class FormAppointmentstatusUpdate
    Dim DA_AppointStatus As New DSAssessmentTableAdapters.CCAMH_CLIENT_APPOINTSTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateCombobox(CboAppointStatus, "", ErrAppStatus) = False Then Exit Sub
        If chCall.Checked = True Then
            If ValidateDateTimePicker(DateCall, "", ErrAppStatus) = False Then Exit Sub
        End If
        If MessageBox.Show("Do you want to update status appointment?", "Oppointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_AppointStatus.UpdateAppointmentStatus(TxtAppointmentStatusNote.Text, chCall.Checked, IIf(chCall.Checked = True, DateCall.Value, Nothing), CboAppointStatus.Text, LblAppointmentID.Text) = 1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class