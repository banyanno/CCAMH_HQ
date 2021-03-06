Public Class FRMAChievNew
    Public isClose As Boolean = False
    Dim PatientAchieve As UCAchievePatient
    Sub New(ByVal patientAchieve As UCAchievePatient)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PatientAchieve = patientAchieve
        LoadNewPatientNo()
        ' Add any initialization after the InitializeComponent() call.
        With CboDiagnosis
            .DataSource = ModDiagnosis.SelectMainSurgery()
            .DisplayMember = "Surgery"
            .ValueMember = "SID"
            .Text = Nothing
        End With
        With CboOther
            .DataSource = ModDoctor.SelectOther
            .ValueMember = "Other"
            .SelectedValue = "No"
            .Text = Nothing
        End With
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LoadNewPatientNo()

        ' Add any initialization after the InitializeComponent() call.
        With TxtOccupation
            .DataSource = ModOccupation.SelectAllOccupation()
            .ValueMember = "Occupation"
            .SelectedValue = "OccNo"
            .Text = Nothing
        End With
        With CboDiagnosis
            .DataSource = ModDiagnosis.SelectMainSurgery()
            .DisplayMember = "Surgery"
            .ValueMember = "SID"
            .Text = Nothing
        End With
        With CboOther
            .DataSource = ModDoctor.SelectOther
            .ValueMember = "Other"
            .SelectedValue = "No"
            .Text = Nothing
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If DateRegistration.Checked = False Then
            MsgBox("Could you check date registration", MsgBoxStyle.Critical, "Error")
            DateRegistration.Select()
            DateRegistration.Focus()
            Exit Sub
        Else
            
        End If
        Dim d As String = DateRegistration.Value.Day
        Dim m As String = DateRegistration.Value.Month
        Dim y As String = DateRegistration.Value.Year
        Dim valueDate As Integer = CInt(y & m)

        If valueDate < 20109 Then
            Dim diagnosisTem As String
            If ValidateTextField(TxtReceiptNo, "ReceiptNo", ErrNewOut) = False Or _
            ValidateTextField(TxtNameEng, "english name", ErrNewOut) = False Or _
            ValidateTextField(TxtNameKhmer, "khmer name", ErrNewOut) = False Or _
            ValidateTextField(TxtAgePatient, "age", ErrNewOut) = False Or _
            ValidateCombobox(CboSexPatien, "sex", ErrNewOut) = False Or _
            ValidateTextField(TxtOldPatientNo, "", ErrNewOut) = False Or _
            ValidateCombobox(CboDiagnosis, "diagnosis", ErrNewOut) = False Or ValidateCombobox(TxtOccupation, "occupation", ErrNewOut) = False Then
                Exit Sub
            End If
            If ModNew_Outpatient.CheckOldPatientExisting(TxtOldPatientNo.Text) > 0 Then
                MsgBox("This patient already existing in system. Could you find this number" & TxtOldPatientNo.Text, MsgBoxStyle.Critical, "Error")
                TxtOldPatientNo.Focus()
                Exit Sub
            End If
            Dim ExistingPatientInfo As Integer = ModRegistration.CheckDuplicatePatient(TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, TxtAddress.Text)
            If ExistingPatientInfo <> 0 Then
                MessageBox.Show("Patient No​ " & ExistingPatientInfo & " have in system already." & Chr(13) & "Please pay attention for this patient as it is similar or unique to the existing in the system.", "Patient check duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If LblSaveOption.Text = "0" Then
                DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_SAVE = System.Windows.Forms.DialogResult.Yes Then
                    If ChTypeOther.Checked = True Then
                        diagnosisTem = "Others"
                    Else
                        diagnosisTem = CboDiagnosis.Text
                    End If
                    If ModCommon.CheckDuplicateHN(Me.TxtNewPatientNo.Text, "TblPatients") = True Then      '------------recall HN after redundency----------
                        MsgBox("PatientNo: " & TxtNewPatientNo.Text & " already existing in system. It will change to new number. Could you click save agian.", MsgBoxStyle.Exclamation, "PatientNo")
                        LoadNewPatientNo()
                        TxtNewPatientNo.Focus()
                        TxtNewPatientNo.SelectAll()
                    Else
                        If ModRegistration.NewRegistrationPatientAchieve(TxtOldPatientNo.Text, TxtNewPatientNo.Text, DateRegistration.Value, CboProNo.Text, CboDisNo.Text, CboCommNo.Text, TxtNameEng.Text, TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, TxtAddress.Text, TxtOccupation.Text, TxtTel.Text, "", Today.Year, True) = 1 Then
                            If ModNew_Outpatient.InsertNewBookAchieve(EmptyString(TxtReceiptNo.Text), TxtNewPatientNo.Text, CboDiagnosis.Text, diagnosisTem, EmptyString(TxtPatientFee.Text), "0", CboOther.Text, DateRegistration.Value, ChTypeOther.Checked) = 1 Then
                                MsgBox("Save achieve patient successfully.", MsgBoxStyle.Information, "Save")
                                ' PatientAchieve.showNewPatientBook(DateRegistration.Value, DateRegistration.Value)
                                isClose = True
                                Me.Close()
                            End If
                        Else
                            MsgBox("Error save achieve pateint.", MsgBoxStyle.Critical, "Error")
                        End If
                    End If

                End If
            End If
        Else
            MessageBox.Show("Patient achive data must before date(1-10-2010).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


       

    End Sub

    Private Sub CboCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub TxtOldPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOldPatientNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub TxtPatientFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientFee.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub
    Sub LoadNewPatientNo()
        TxtNewPatientNo.Text = ModCommon.GeneratePatientNoForScreening("No", "TblPatients")
    End Sub
    Sub ClearForm()
        'MsgBox(Today.Year)
        TxtReceiptNo.Text = ""
        TxtOldPatientNo.Text = ""
        TxtNewPatientNo.Text = ""
        TxtNameEng.Text = ""
        TxtNameKhmer.Text = ""
        TxtAgePatient.Text = ""
        CboSexPatien.Text = ""
        TxtTel.Text = ""
        TxtOccupation.Text = ""
        CboProNo.Text = ""
        CboDisNo.Text = ""
        CboCommNo.Text = ""
        TxtAddress.Text = ""
        TxtPatientFee.Text = ""
        CboDiagnosis.Text = ""
        CboOther.Text = ""
        TxtReceiptNo.Focus()
        LoadNewPatientNo()

    End Sub
    Private Sub CboProNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboProNo.GotFocus
        With CboProNo
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
            .SelectAll()
        End With
        CboDisNo.Text = ""
        CboCommNo.Text = ""
    End Sub
    Private Sub CboDisNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboDisNo.GotFocus
        With CboDisNo
            .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
            .DisplayMember = "DISTRICT"
            .ValueMember = "SrokCode"
            .SelectAll()
        End With
        CboCommNo.Text = ""
    End Sub

    Private Sub CboCommNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommNo.GotFocus
        With CboCommNo
            .DataSource = ModProvince.SelectCommune(CInt(CboDisNo.SelectedValue))
            .DisplayMember = "Commune"
            .ValueMember = "KhumCode"
            .SelectAll()
        End With
    End Sub
    Private Sub TxtAgePatient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAgePatient.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub TxtAgePatient_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAgePatient.KeyUp
        If e.KeyCode = 190 Then
            TxtAgePatient.Text = ""
        End If
        If TxtAgePatient.Text.Length > 2 Then
            MsgBox("Patient's age can not > 100.", MsgBoxStyle.Critical, "Error")
            TxtAgePatient.Text = ""
        End If
    End Sub

    Private Sub CboCommNo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.SelectedValueChanged
        TxtAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
    End Sub

    Private Sub CboSexPatien_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboSexPatien.KeyDown
        Select Case e.KeyCode
            Case Keys.F
                Me.CboSexPatien.Text = "F"
            Case Keys.M
                Me.CboSexPatien.Text = "M"
            Case Keys.Enter
                TxtTel.Focus()
            Case Else
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub CboSexPatien_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboSexPatien.KeyPress
        SetDisableKey(e)
    End Sub

    Private Sub DateRegistration_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateRegistration.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtReceiptNo.Focus()
        End If
    End Sub

    Private Sub TxtReceiptNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceiptNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtOldPatientNo.Focus()
        End If
    End Sub

    Private Sub TxtOldPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOldPatientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNewPatientNo.Focus()
        End If
    End Sub

    Private Sub TxtNewPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNewPatientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNameEng.Focus()
        End If
    End Sub

    Private Sub TxtNameEng_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNameEng.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNameKhmer.Focus()
        End If
    End Sub

    Private Sub TxtNameKhmer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNameKhmer.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAgePatient.Focus()
        End If
    End Sub

    Private Sub TxtTel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTel.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtOccupation.Focus()
        End If
    End Sub

    Private Sub TxtOccupation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CboProNo.Focus()
        End If
    End Sub

    Private Sub CboProNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboProNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboDisNo.Focus()
        End If
    End Sub

    Private Sub CboDisNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboDisNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboCommNo.Focus()
        End If
    End Sub

    Private Sub CboCommNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboCommNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAddress.Focus()
        End If
    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPatientFee.Focus()
        End If
    End Sub

    Private Sub TxtPatientFee_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientFee.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboDiagnosis.Focus()
        End If
    End Sub

    Private Sub CboDiagnosis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboDiagnosis.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboOther.Focus()
        End If
    End Sub

    Private Sub CboOther_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboOther.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave.Focus()
        End If
    End Sub

    Private Sub TxtAgePatient_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAgePatient.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboSexPatien.Focus()
        End If
    End Sub

  
    Private Sub FRMAChievNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
   
End Class