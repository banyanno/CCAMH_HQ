Public Class FormFastTracking
    Dim DA_FastTracking As New DSFastTrackTableAdapters.CCAMH_FAST_TRACKINGTableAdapter
    Dim DA_FastrackingDetail As New DSFastTrackTableAdapters.CCAMH_VIEW_TRACKINGTableAdapter
    Dim DA_ClientInfo As New DSFastTrackTableAdapters.CCAMH_VIEW_ADVISED_CLIENTSTableAdapter
    Dim DA_Therapist As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboTherapy
            .DataSource = DA_Therapist.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If DA_FastTracking.CheckExistingTracking(EmptyString(TxtClientNo.Text)) > 0 Then
            MessageBox.Show("The client already exist in tracking detail. Please check again!", "Tracking", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClientNo.Select()
            TxtClientNo.Focus()
            TxtClientNo.SelectAll()
            Exit Sub
        End If
        If ValidateTextField(TxtClientNo, "", ErrTracking) = False Then Exit Sub
        If ValidateTextField(TxtClientNameKH, "", ErrTracking) = False Then Exit Sub
        If ValidateTextField(TxtClientNameEng, "", ErrTracking) = False Then Exit Sub
        If ValidateDateField(DateLastFit, "", ErrTracking) = False Then Exit Sub
        If ValidateDateField(DateFastTrack, "", ErrTracking) = False Then Exit Sub
        If ValidateCombobox(CboTherapy, "", ErrTracking) = False Then Exit Sub
        If ValidateCombobox(CboCardLavel, "", ErrTracking) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new client tracking?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_FastTracking.InsertNewClientTracking(Now.Date, EmptyString(TxtClientNo.Text), DateLastFit.Value.Date, DateFastTrack.Value.Date, IIf(DateNextVisit.Checked = True, DateNextVisit.Value.Date, Nothing), TxtRemark.Text, "", CboTherapy.Text, CboCardLavel.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update client tracking?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_FastTracking.UpdateTracking(DateLastFit.Value.Date, DateFastTrack.Value.Date, IIf(DateNextVisit.Checked = True, DateNextVisit.Value.Date, Nothing), TxtRemark.Text, CboTherapy.Text, CboCardLavel.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If

    End Sub
    Private Sub FindClientInfo(ByVal ClientNo As Double)
        Dim TblClient As DataTable = DA_ClientInfo.SelectClientInfo(ClientNo)
        If TblClient.Rows.Count = 0 Then
            MessageBox.Show("Client info not found. Please check client no again!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtClientNameKH.Text = ""
            TxtClientNameEng.Text = ""
            TxtClientDateDOR.Text = ""
            TxtClientSex.Text = ""
            TxtClientAge.Text = ""
            TxtClientContact.Text = ""
            TxtClientAddress.Text = ""
            TxtClientNo.Select()
            TxtClientNo.Focus()
            TxtClientNo.SelectAll()
        Else
            For Each Drows As DataRow In TblClient.Rows
                TxtClientNameKH.Text = Drows("CLIENT_NAME_KHM")
                TxtClientNameEng.Text = Drows("CLIENT_NAME")
                TxtClientDateDOR.Text = Format(Drows("CLIENT_DATE_REG"), "dd/MM/yyyy")
                TxtClientSex.Text = Drows("CLIENT_SEX")
                TxtClientAge.Text = Drows("CAL_AGE")
                TxtClientContact.Text = Drows("CLIENT_ADDRESS_PHONE")
                TxtClientAddress.Text = Drows("FULL_ADDRESS_KH")
            Next
        End If
       
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFindClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindClient.Click
        If ValidateTextField(TxtClientNo, "", ErrTracking) = False Then Exit Sub
        FindClientInfo(TxtClientNo.Text)
    End Sub

    Private Sub BtnTherapy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTherapy.Click
        Dim frm As New FormTherapist
        If frm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            With CboTherapy
                .DataSource = DA_Therapist.GetData
                .ValueMember = "THERAPIST_ID"
                .DisplayMember = "THERAPIST_NAME"
                .SelectedIndex = -1
            End With
        End If
    End Sub
End Class