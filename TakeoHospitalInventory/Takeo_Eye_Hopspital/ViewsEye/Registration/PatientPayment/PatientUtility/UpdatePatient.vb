Public Class UpdatePatient
    Dim UPatientRegis As UCPatientPayment
    Dim xx, yy As Integer
    Sub New(ByVal UPatientRegis As UCPatientPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.UPatientRegis = UPatientRegis
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BntClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntClose.Click
        Me.Close()
    End Sub
    Private Sub CboProNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboProNo.GotFocus
        With CboProNo
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
        End With
        'CboProNo.Text = ""
        CboDisNo.Text = ""
        CboCommNo.Text = ""
        TxtAddress.Text = ""
        Me.CboProNo.SelectAll()
    End Sub
    Private Sub CboDisNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboDisNo.GotFocus
        With CboDisNo
            .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
            .DisplayMember = "DISTRICT"
            .ValueMember = "SrokCode"
        End With
        'CboDisNo.Text = ""
        'CboCommNo.Text = ""
        'TxtAddress.Text = ""
        Me.CboDisNo.SelectAll()
    End Sub
    Private Sub CboCommNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommNo.GotFocus
        With CboCommNo
            .DataSource = ModProvince.SelectCommune(CInt(CboDisNo.SelectedValue))
            .DisplayMember = "Commune"
            .ValueMember = "KhumCode"
        End With
        Me.CboCommNo.SelectAll()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(TxtPatientNo, "patient no", ErrPatient) = False Or _
       ValidateTextField(TxtNameEng, "Name English", ErrPatient) = False Or _
       ValidateTextField(TxtNameKhmer, "Name Khmer", ErrPatient) = False Or _
       ValidateTextField(TxtAgePatient, "Age", ErrPatient) = False Or _
       ValidateCombobox(CboOccupation, "Occupation", ErrPatient) = False Or _
       ValidateTextField(TxtTel, "Tel", ErrPatient) = False Or _
       ValidateCombobox(CboSexPatien, "Sex", ErrPatient) = False Or _
       ValidateCombobox(CboProNo, "Province", ErrPatient) = False Or _
       ValidateCombobox(CboDisNo, "District", ErrPatient) = False Or _
       ValidateCombobox(CboCommNo, "Commune", ErrPatient) = False _
       Then
            'showMerlin(100, 100)
            'Merlin("", "Suggest")
        Else
            If lblSaveOption.Text = "0" Then
                ModGlobleVariable.DIALOG_SAVE = MessageBox.Show(ModGlobleVariable.MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ModGlobleVariable.DIALOG_SAVE = System.Windows.Forms.DialogResult.Yes Then
                    'Dim i As Integer

                    'For i = 0 To 100000
                    ' Insert new patient sucessfully
                    If ModRegistration.NewRegistrationPatient(TxtPatientNo.Text, CStr(Now), CboProNo.Text, CboDisNo.Text, CboCommNo.Text, TxtNameEng.Text, TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, TxtAddress.Text, CboOccupation.Text, TxtTel.Text, "", Today.Year) = 1 Then
                        If ModRegistration.SavePatienToFollowUP(TxtPatientNo.Text) = 1 Then
                            MsgBox("The registration new patient successfully", MsgBoxStyle.Information)
                            UPatientRegis.ActionFindPatien(TxtPatientNo.Text, "0", "", "", "", "", "", "", "", "")
                        Else
                            MsgBox("Error new registratin. Please contact Developer1", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Error new registratin. Please contact Developer", MsgBoxStyle.Critical)
                    End If
                    'Next
                End If
            Else
                ModGlobleVariable.DIALOG_UPDATE = MessageBox.Show(ModGlobleVariable.MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ModGlobleVariable.DIALOG_UPDATE = DialogResult.Yes Then
                    If ModRegistration.UpdatePatient(lblSaveOption.Text, CboProNo.Text, CboDisNo.Text, CboCommNo.Text, TxtNameEng.Text, TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, TxtAddress.Text, CboOccupation.Text, TxtTel.Text, DateRegis.Value) = 1 Then
                        MsgBox("Update patient sucessffully.", MsgBoxStyle.Information, "Update")
                        UPatientRegis.ActionFindPatien(TxtPatientNo.Text, "0", "", "", "", "", "", "", "", "")
                        Me.Close()
                    Else
                        MsgBox("Update patient error.", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CboCommNo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.SelectedValueChanged
        Try
            TxtAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
        Catch ex As Exception

        End Try

    End Sub

    Private Sub UpdatePatient_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        'ModCommon.MoveFormOnMouseDown(e)
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub UpdatePatient_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        ModCommon.MoveFormOnMouseMove(e, Me)
    End Sub
End Class