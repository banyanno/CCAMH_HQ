Public Class FormReferral
    Public DAReferralBook As New DataSetScreeningBookTableAdapters.SCREENING_REFERRAL_BOOKTableAdapter
    Public DADiagnosis As New DataSetScreeningBookTableAdapters.TblSurgeryTableAdapter
    Public DAVA As New DataSetScreeningBookTableAdapters.REFRACTION_VATableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        InitParameter()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub InitParameter()
        With cboDiagnosis
            .DataSource = DADiagnosis.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgery"
            .SelectedIndex = -1
        End With
        With CboVARight
            .DataSource = DAVA.GetData
            .DisplayMember = "REFRA_VA"
            .ValueMember = "RFRA_VA_ID"
            .SelectedIndex = -1
        End With
        With CboVALeft
            .DataSource = DAVA.GetData
            .DisplayMember = "REFRA_VA"
            .ValueMember = "RFRA_VA_ID"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        ' Call when we mouse move on Panel
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Dim emp As Nullable(Of Date)
        'emp = System.DBNull.Value
        If LblSaveOption.Text <> "0" Then
            If MessageBox.Show("Do you want to update patient referral?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DAReferralBook.UpdateReferral(CboVARight.Text, CboVALeft.Text, cboDiagnosis.Text, IIf(DateAppointment.Checked = True, DateAppointment.Value.Date, Nothing), TxtMoreInfo.Text, LblSaveOption.Text) Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to save referral?", "Screening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DAReferralBook.InsertNewReferral(LblScreenBookID.Text, PatientNo.Text, CboVARight.Text, CboVALeft.Text, cboDiagnosis.Text, DateAppointment.Value.Date, ChPickup.Checked, TxtMoreInfo.Text, DateScreening.Value.Date) = 1 Then

                End If
            End If
        End If
    End Sub
End Class