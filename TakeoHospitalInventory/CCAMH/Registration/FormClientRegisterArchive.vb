Public Class FormClientRegisterArchive

    Dim ds_client As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim ds_client_social As New DS_CCAMHClientRegistrationTableAdapters.CLIENT_CA_SOCIALTableAdapter

    Dim occu As New DS_CCAMHClientRegistrationTableAdapters.TblOccupationTableAdapter
    Dim education As New DS_CCAMHClientRegistrationTableAdapters.tblEducationTableAdapter

    '---------------- Add new address -----------------------------------


    Dim DAProvince As New DSAddressTableAdapters.TBL_PROVINCETableAdapter
    Dim DADistrict As New DSAddressTableAdapters.TBL_DISTRICTTableAdapter
    Dim DACommune As New DSAddressTableAdapters.TBL_COMMUNETableAdapter
    Dim DAVillage As New DSAddressTableAdapters.TBL_VILLAGETableAdapter
    Dim DA_ClientMG As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter

    Dim DA_Diagnosis As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_DIAGNOSISTableAdapter

    Sub RefreshClientNo()
        TxtClientNo.Text = ModCommon.GeneratePatientNoForScreening("CLIENT_NO", "CCAMH_CLIENTS")
    End Sub

    Private Sub txtPatientNameKh_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPatientNameKh.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub txtPatientNameEn_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPatientNameEn.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub tbxFatherName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxFatherName.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub tbxMotherName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMotherName.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub tbxFatherAge_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxFatherAge.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub tbxMotherAge_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMotherAge.Enter
        SetEnglishLanguage()
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            With cbxProvince
                .DataSource = DAProvince.GetData
                .ValueMember = "PROVINCEID"
                .DisplayMember = "PROV_EN"
                .SelectedIndex = -1
            End With

        Catch ex As Exception

        End Try
        ' Add any initialization after the InitializeComponent() call.
        InitParaRegister()
    End Sub
   
    Private Sub InitParaRegister()
        With cbxMotherEducation
            .DataSource = Education.GetData
            .ValueMember = "eduNo"
            .DisplayMember = "Education"
            .SelectedIndex = -1
        End With
        With cbxFatherEducation
            .DataSource = Education.GetData
            .DisplayMember = "Education"
            .ValueMember = "eduNo"
            .SelectedIndex = -1
        End With
        With cbxFatherOccupation
            .DataSource = occu.GetData
            .DisplayMember = "Occupation"
            .ValueMember = "OccNo"
            .SelectedIndex = -1
        End With
        With cbxMotherOccupation
            .DataSource = occu.GetData
            .DisplayMember = "Occupation"
            .ValueMember = "OccNo"
            .SelectedIndex = -1
        End With
        With CboDiagnosis
            .DataSource = DA_Diagnosis.GetData
            .ValueMember = "diag_cat_id"
            .DisplayMember = "diagnosis"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub cbxProvince_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxProvince.SelectedValueChanged
        If cbxProvince.SelectedValue Is Nothing Then
            'CboDisNo.DataSource = Nothing
        Else
            Try
                '  MessageBox.Show(cbxProvince.SelectedValue)
                InitDistrict(CInt(cbxProvince.SelectedValue), cbxDistrict)

            Catch ex As Exception
                cbxDistrict.SelectedIndex = -1
                cbxCommune.SelectedIndex = -1
                cbxVillage.SelectedIndex = -1
                'CboDisNo.Text = ""
                'CboCommNo.Text = ""
                'CboVillage.Text = ""
                'TxtAddress.Text = ""
            End Try
        End If
    End Sub

    Private Sub cbxDistrict_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDistrict.SelectedValueChanged
        If cbxDistrict.SelectedValue Is Nothing Then
            ' CboCommNo.DataSource = Nothing
        Else
            Try

                InitCommune(CInt(cbxDistrict.SelectedValue), cbxCommune)
            Catch ex As Exception
                cbxDistrict.SelectedIndex = -1
                cbxCommune.SelectedIndex = -1
                cbxVillage.SelectedIndex = -1

            End Try
        End If
    End Sub
    Private Sub InitDistrict(ByVal ProvinceID As Integer, ByVal CDistrit As ComboBox)
        With CDistrit
            .DataSource = DADistrict.SelectDistrictByProvince(ProvinceID)
            .ValueMember = "DISTRICTID"
            .DisplayMember = "DIST_EN"
            .SelectedIndex = -1
        End With
        cbxProvince.SelectedValue = ProvinceID

    End Sub
    Private Sub InitCommune(ByVal DistrictID As Integer, ByVal CCommune As ComboBox)
        With CCommune
            .DataSource = DACommune.SelectCommuneByDistrict(DistrictID)
            .ValueMember = "COMMUNEID"
            .DisplayMember = "COMM_EN"
            .SelectedIndex = -1
        End With

    End Sub
    Private Sub InitVillage(ByVal CommuneID As Integer, ByVal CVillage As ComboBox)
        With CVillage
            .DataSource = DAVillage.SelectVillageByCOMMUNEID(CommuneID)
            .ValueMember = "VILLAGEID"
            .DisplayMember = "VILL_EN"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub cbxCommune_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCommune.SelectedValueChanged
        If cbxCommune.SelectedValue Is Nothing Then
            'CboVillage.DataSource = Nothing
        Else
            Try
                InitVillage(CInt(cbxCommune.SelectedValue), cbxVillage)
            Catch ex As Exception
                cbxDistrict.SelectedIndex = -1
                cbxCommune.SelectedIndex = -1
                cbxVillage.SelectedIndex = -1
                'CboVillage.Text = ""
                'TxtAddress.Text = ""
            End Try
        End If
    End Sub

    Private Sub BtnAddEducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddEducation.Click
        Dim frmEducation As New Education
        If frmEducation.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshEducation()
        End If
    End Sub
    Private Sub RefreshEducation()
        With cbxMotherEducation
            .DataSource = education.GetData
            .ValueMember = "eduNo"
            .DisplayMember = "Education"
            .SelectedIndex = -1
        End With
        With cbxFatherEducation
            .DataSource = education.GetData
            .DisplayMember = "Education"
            .ValueMember = "eduNo"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub BtnAddOccupation1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddOccupation1.Click
        Dim frmOccupation As New FrmNewOccupation
        If frmOccupation.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshOccupation()
        End If
    End Sub
    Private Sub RefreshOccupation()
        With cbxOccupation
            .DataSource = occu.GetData
            .DisplayMember = "Occupation"
            .ValueMember = "OccNo"
            .SelectedIndex = -1
        End With
        With cbxFatherOccupation
            .DataSource = occu.GetData
            .DisplayMember = "Occupation"
            .ValueMember = "OccNo"
            .SelectedIndex = -1
        End With
        With cbxMotherOccupation
            .DataSource = occu.GetData
            .DisplayMember = "Occupation"
            .ValueMember = "OccNo"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateDateField(dtbDOR, "", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(TxtClientNo, "", ErrClientRegis) = False Then
            Exit Sub
        End If
        If ValidateTextField(TxtOldIDCode, "", ErrClientRegis) = False Then
            Exit Sub
        End If
        If ValidateTextField(txtPatientNameKh, "", ErrClientRegis) = False Then
            Exit Sub
        End If
        If ValidateTextField(txtPatientNameEn, "", ErrClientRegis) = False Then
            Exit Sub
        End If

        If ValidateCombobox(cbxSex, "", ErrClientRegis) = False Then
            Exit Sub
        End If
        If ValidateTextField(tbxAge, "", ErrClientRegis) = False Then
            Exit Sub
        End If

        If ValidateTextField(TxtAgeWithMonth, "", ErrClientRegis) = False Then Exit Sub
      
       

        If ValidateTextField(tbxPhone, "", ErrClientRegis) = False Then

            Exit Sub
        End If
        If ValidateCombobox(cbxProvince, "", ErrClientRegis) = False Then

            Exit Sub
        End If
        If cbxProvince.SelectedValue Is Nothing Then
            cbxProvince.Select()
            cbxProvince.Select()
            cbxProvince.SelectAll()
            MessageBox.Show("wrong province name!", "Province", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If ValidateCombobox(cbxDistrict, "", ErrClientRegis) = False Then

            Exit Sub
        End If
        If cbxDistrict.SelectedValue Is Nothing Then
            cbxDistrict.Select()
            cbxDistrict.SelectAll()
            cbxDistrict.Focus()
            MessageBox.Show("wrong district name!", "district", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ValidateCombobox(cbxCommune, "", ErrClientRegis) = False Then

            Exit Sub
        End If
        If cbxCommune.SelectedValue Is Nothing Then
            cbxCommune.Select()
            cbxCommune.SelectAll()
            cbxCommune.Focus()
            MessageBox.Show("wrong commune name!", "Commune", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
        If ValidateCombobox(cbxVillage, "", ErrClientRegis) = False Then

            Exit Sub
        End If
        If cbxVillage.SelectedValue Is Nothing Then
            cbxVillage.Select()
            cbxVillage.SelectAll()
            cbxVillage.Focus()
            MessageBox.Show("wrong village name!", "village", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
       
        If CheckGroupValidateAsRadio(GroupSocialServiceType) = False Then
            'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupSocialServiceType.BackColor = Color.LightYellow

            Exit Sub
        Else
            GroupSocialServiceType.BackColor = Color.Transparent
        End If
        If CheckGroupValidateAsNormalCheckBox(GroupImpression) = False Then
            'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupImpression.BackColor = Color.LightYellow

            Exit Sub
        Else
            GroupImpression.BackColor = Color.Transparent
        End If
        If ValidateCombobox(CboDiagnosis, "", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(TxtNumberVisit, "", ErrClientRegis) = False Then Exit Sub
        If MessageBox.Show("Do you want to save client archive?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ds_client.CheckExistingClientNo(EmptyString(TxtClientNo.Text)) > 0 Then
                MessageBox.Show("Client no already exist. Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RefreshClientNo()
                TxtClientNo.Focus()
                TxtClientNo.Select()
                Exit Sub
            End If
            If ds_client.CheckExistingOldClientNo(TxtOldIDCode.Text) > 0 Then
                MessageBox.Show("The old client no already exist. Please check again old number again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtOldIDCode.Focus()
                TxtOldIDCode.Select()
                TxtOldIDCode.SelectAll()
                Exit Sub
            End If
            If saveCCAMHClientInfo() = True Then
                DA_ClientMG.InsertClientManagement(TxtClientNo.Text, txtPatientNameKh.Text, cbxSex.Text, tbxAge.Text, "", CboDiagnosis.Text, dtbDOR.Value.Date, 1, tbxPhone.Text, CboDiagnosis.SelectedValue, LblImpression.Text, CboDiagnosis.SelectedValue, Nothing, "")
                MessageBox.Show("Client successfully saved!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Error Client Information. Please verify data and enter it again!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Function saveCCAMHClientInfo() As Boolean
        'General Information


        Dim reliability_good As Boolean = 0
        Dim reliability_fair As Boolean = 0
        Dim reliability_poor As Boolean = 0
        Dim reliability As String

        Dim age As Integer
        Dim dob As Date
        Dim dor As Date
        Dim curDate As DateTime = Now

      
        reliability = "poor"



        If Trim(tbxAge.Text) = "" Then
            age = 0
        Else
            age = Integer.Parse(tbxAge.Text)
        End If

        dob = dtpDOB.Value.Date

        dor = dtbDOR.Value.Date

        Dim client_name, client_name_kh, occupation As String
        Dim client_id, sibling_no, sibling_m_no, sibling_f_no As Double
        Dim clientSex As Char
        Dim schoolYes As Boolean = 0
        Dim schoolNo As Boolean = 0
        Dim schoolNever As Boolean = 0
        Dim schoolDrop As Boolean = 0
        Dim schoolNA As Boolean = 0
        Dim schoolNY As Boolean = 0
        Dim position As Integer = 1
        client_name = txtPatientNameEn.Text
        client_name_kh = txtPatientNameKh.Text
        client_id = Decimal.Parse(TxtClientNo.Text)

        If cbxSex.Text = "F" Then
            clientSex = "F"
        Else
            clientSex = "M"
        End If


        sibling_no = 0

        sibling_m_no = 0
        

        position = 0
        occupation = "N/A"


        schoolYes = 1

        schoolNo = 1

        schoolNever = 1

        schoolDrop = 1

        schoolNA = 1

        schoolNY = 1


        Dim ce As Char
        If rbtnC.Checked Then
            ce = "C"
        Else
            ce = "E"
        End If




        Dim DateServer As Date = ModGlobleVariable.GeteDateServer
        Dim years As Integer = DateServer.Year

        ' Family Members
        Dim father_name, father_education, father_occ, mother_name, mother_education, mother_occ As String
        Dim father_age, mother_age As Integer
        father_name = tbxFatherName.Text
        mother_name = tbxMotherName.Text

        If Trim(tbxFatherAge.Text) = "" Then
            father_age = 0
        Else
            'If EmptyString(txtFamOthers.Text) > 100 Then
            '    txtFamOthers.Select()
            '    txtFamOthers.SelectAll()

            '    Exit Function
            'Else
            father_age = Integer.Parse(tbxFatherAge.Text)
            'End If

        End If

        If Trim(tbxMotherAge.Text) = "" Then
            mother_age = 0
        Else
            mother_age = Integer.Parse(tbxMotherAge.Text)
        End If

        father_education = cbxFatherEducation.SelectedValue
        mother_education = cbxMotherEducation.SelectedValue
        father_occ = cbxFatherOccupation.SelectedValue
        mother_occ = cbxMotherOccupation.SelectedValue

        Dim add_house, add_street, add_city, add_commune, add_district, add_province, phone As String
        add_house = tbxAddress.Text
        add_street = tbxStreet.Text
        add_city = cbxVillage.SelectedValue
        add_commune = cbxCommune.SelectedValue
        add_district = cbxDistrict.SelectedValue
        add_province = cbxProvince.SelectedValue
        phone = tbxPhone.Text

        ' Family History
        Dim client_nuclear As Boolean = 0 'CLIENT_NUCLEAR
        Dim client_inact As Boolean = 0
        Dim client_mental As Boolean = 0
        Dim client_retardation As Boolean = 0
        Dim client_consangonis As Boolean = 0
        Dim client_separated As Boolean = 0
        Dim client_epilepsis As Boolean = 0
        Dim client_other_illness As String = ""
        Dim other_misc As String = ""


        client_nuclear = 1
        
        client_consangonis = 1
       
        client_inact = 1
       
        client_separated = 1
       
        client_mental = 1
        
        client_epilepsis = 1
       
        client_retardation = 1
       
        client_other_illness = "N/A"

        other_misc = "N/A"
        ' Previous consultation
        Dim pre_treatment As Boolean
        Dim pre_treatment_detail As String

        pre_treatment = 0

        pre_treatment_detail = "N/A"

        ' Education
        Dim level_preschool As Boolean = 0
        Dim level_primary As Boolean = 0
        Dim level_secondary As Boolean = 0
        Dim level_highschool As Boolean = 0
        Dim level_vtraining As Boolean = 0
        Dim level_uni As Boolean = 0
        Dim level_na As Boolean = 0

       

        Dim perf_ba As Boolean = 0
        Dim perf_avg As Boolean = 0
        Dim perf_aa As Boolean = 0
        Dim perf_rc As Boolean = 0
        Dim perf_na As Boolean = 0

        

        Dim adjustment_wa As Boolean = 0
        Dim adjustment_bullying As Boolean = 0
        Dim adjustment_bullied As Boolean = 0
        Dim adjustment_sc As Boolean = 0
        Dim adjustment_tru As Boolean = 0
        Dim adjustment_na As Boolean = 0

        

        ' Comorbidity / Social status
        Dim comorbidity As Boolean = 0
        Dim clinicalaudit As Boolean = 0


        Dim poverty_card As Boolean = 0
        Dim poverty_other As String
        'If rdtComorbidityNo.Checked Then
        comorbidity = 0
        'End If
        'If rdtComorbidityYes.Checked Then
        comorbidity = 1
        ' End If
        'If rdbClinicalAuditNo.Checked Then
        clinicalaudit = 0
        'End If
        'If rdbClinicalAuditYes.Checked Then
        clinicalaudit = 1
        'End If


        'If rdbPovertyCardYes.Checked Then
        poverty_card = 1
        'End If
        'If rdbPovertyCardNo.Checked Then
        '    poverty_card = 0
        'End If
        poverty_other = ""

        Dim referto As String = "NA"


        Dim socialUnit As String


        socialUnit = "UNIT I"

        Dim socialType As String = "NA"

        If cxbTypeA.Checked Then
            socialType = "A"
        End If
        If cxbTypeB.Checked Then
            socialType = "B"
        End If
        If cxbTypeC.Checked Then
            socialType = "C"
        End If

        Dim unitAlloc1, unitAlloc2 As Decimal


        unitAlloc1 = 0


        'If Trim(txtUnitAlloc2.Text) = "" Then
        unitAlloc2 = 0
        'Else
        '    unitAlloc2 = Decimal.Parse(txtUnitAlloc2.Text)
        'End If

        Dim np_fit As Boolean = 0
        Dim np_jerk As Boolean = 0
        Dim np_blank As Boolean = 0
        Dim np_head As Boolean = 0
        Dim np_eye As Boolean = 0
        Dim np_oneside As Boolean = 0
        Dim np_other As Boolean = 0

        Dim pp_headache, pp_fear, pp_thinkalot, pp_worry, pp_steal, pp_disobie, pp_lie, pp_angry, pp_irrit, pp_sleep, pp_fainting, pp_other As Boolean

        Dim pp_mj_talk, pp_mj_laugh, pp_mj_straight, pp_mj_aggr, pp_mj_sleep, pp_mj_appit, pp_mj_break, pp_mj_shy, pp_mj_goaway, pp_mj_other As Boolean


        Dim dd_notalk, dd_nowalk, dd_playalone, dd_beat, dd_noresponding, dd_tip, dd_poormem, dd_poorunder, dd_poorstudy, dd_throwing, dd_drooling, dd_noneck, dd_other As Boolean


        Dim imp_neuro, imp_ddisorder, imp_psycho, imp_psychi As Boolean

        If cbxImprNeurological.Checked = True Then
            imp_neuro = 1
        End If
        If cbxImprDisorder.Checked = True Then
            imp_ddisorder = 1
        End If
        If cbxImprPsycho.Checked = True Then
            imp_psycho = 1
        End If
        If cbxImprPsychiatric.Checked = True Then
            imp_psychi = 1
        End If

        Dim client_np_notes, client_pp_notes, client_dd_notes As String
        client_np_notes = ""
        client_pp_notes = "" 'pp_notes.Text
        client_dd_notes = ""
        ' INSERT into tables
        ' ================================ If User add new ===============================================

        ds_client.InsertNewClient(client_id, client_name_kh, client_name, False, _
                                  False, False, False, _
                                  False, False, False, False, _
                                  False, reliability, clientSex, age, ce, dob, sibling_no, sibling_m_no, _
                                  sibling_f_no, dor, curDate, position, "NA", occupation, False, False, _
                                  False, False, False, False, False, False, _
                                  False, False, False, False, DateServer.Year, father_name, _
                                  father_education, father_age, father_occ, mother_name, mother_education, _
                                  mother_age, mother_occ, add_house, add_street, add_city, add_commune, add_district, _
                                  add_province, phone, client_nuclear, client_consangonis, client_inact, client_separated, _
                                  client_mental, client_epilepsis, client_retardation, client_other_illness, pre_treatment, _
                                  pre_treatment_detail, level_preschool, level_primary, level_secondary, level_highschool, _
                                  level_vtraining, level_uni, level_na, perf_ba, perf_avg, perf_aa, perf_rc, perf_na, adjustment_wa, _
                                  adjustment_bullying, adjustment_bullied, adjustment_sc, adjustment_tru, adjustment_na, _
                                  socialType, "A", TxtOldIDCode.Text, EmptyString(TxtNumberVisit.Text), TxtAgeWithMonth.Text)
        ds_client_social.InsertQuery(client_id, comorbidity, clinicalaudit, poverty_card, poverty_other, "N/A", Nothing, _
                                     unitAlloc1, unitAlloc2, socialType, referto, socialUnit, np_fit, np_jerk, np_blank, np_head, np_eye, _
                                     np_oneside, np_other, pp_headache, pp_fear, pp_thinkalot, pp_worry, pp_steal, pp_disobie, pp_lie, _
                                     pp_angry, pp_irrit, pp_sleep, pp_fainting, pp_other, pp_mj_talk, pp_mj_laugh, pp_mj_straight, _
                                     pp_mj_aggr, pp_mj_sleep, pp_mj_appit, pp_mj_break, pp_mj_shy, pp_mj_goaway, pp_mj_other, _
                                     dd_notalk, dd_nowalk, dd_playalone, dd_beat, dd_noresponding, dd_tip, dd_poormem, dd_poorunder, _
                                     dd_poorstudy, dd_throwing, dd_drooling, dd_noneck, dd_other, imp_psychi, imp_neuro, imp_ddisorder, _
                                     imp_psycho, client_np_notes, client_pp_notes, client_dd_notes, "N/A", False)
       
        Return True


    End Function


    Function CheckGroupValidateAsNormalCheckBox(ByVal GB As Object) As Boolean
        For Each obj As Object In GB.Controls
            If TypeOf obj Is CheckBox Then
                Dim Ch As CheckBox = CType(obj, CheckBox)
                If Ch.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function






    Function CheckGroupValidateAsRadio(ByVal GB As Object) As Boolean
        For Each obj As Object In GB.Controls
            If TypeOf obj Is RadioButton Then
                Dim Ch As RadioButton = CType(obj, RadioButton)
                If Ch.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function

    Private Sub tbxAge_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxAge.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub tbxAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxAge.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub tbxAge_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbxAge.KeyUp
        If EmptyString(tbxAge.Text) >= 100 Then
            MessageBox.Show("The age of client can not biger than 100 year", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            tbxAge.Focus()
            tbxAge.Select()
            tbxAge.SelectAll()
            tbxAge.Text = 0
        End If
        Try
            If e.KeyCode = Keys.Enter Then
            Else
                SubDate(tbxAge.Text)
            End If

        Catch ex As Exception
            dtpDOB.Value = Now
        End Try
        CallAgeWithMonth()
    End Sub
    Private Sub SubDate(ByVal valSub As Integer)
        dtpDOB.Value = Now
        dtpDOB.Value = dtpDOB.Value.AddYears(-valSub)
    End Sub

    Private Sub FormClientRegisterArchive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshClientNo()
    End Sub

    Private Sub dtpDOB_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDOB.KeyUp
        Try
            tbxAge.Text = (Now.Year - dtpDOB.Value.Year)
        Catch ex As Exception
            tbxAge.Text = "0"
        End Try
        CallAgeWithMonth()
    End Sub

    Private Sub tbxPhone_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxPhone.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub cxbTypeB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cxbTypeB.CheckedChanged

    End Sub

    Private Sub BtnAddProvince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProvince.Click
        Dim FProvince As New FormProvince
        If FProvince.ShowDialog() = DialogResult.OK Then
            Try
                With cbxProvince
                    .DataSource = DAProvince.GetData
                    .ValueMember = "PROVINCEID"
                    .DisplayMember = "PROV_EN"
                    .SelectedIndex = -1
                End With

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BtnaddDistrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnaddDistrict.Click
        If cbxProvince.SelectedValue Is Nothing Then Exit Sub
        Dim FDistrict As New FormDistrict
        FDistrict.LblProvince.Text = CInt(cbxProvince.SelectedValue)
        If FDistrict.ShowDialog() = DialogResult.OK Then

            Try
                InitDistrict(FDistrict.LblProvince.Text, cbxDistrict)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BtnAddCommue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCommue.Click
        If cbxDistrict.SelectedValue Is Nothing Then Exit Sub
        Dim FCommune As New FormCommune
        FCommune.LblDistrict.Text = CInt(cbxDistrict.SelectedValue)
        If FCommune.ShowDialog = DialogResult.OK Then
            Try

                InitCommune(FCommune.LblDistrict.Text, cbxCommune)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BtnAddVillage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddVillage.Click
        If cbxCommune.SelectedValue Is Nothing Then Exit Sub
        Dim FVillage As New FormVillage
        FVillage.LblCommune.Text = CInt(cbxCommune.SelectedValue)
        If FVillage.ShowDialog = DialogResult.OK Then
            ' RefreshVillage(FVillage.LblCommune.Text)
            Try

                InitVillage(FVillage.LblCommune.Text, cbxVillage)
            Catch ex As Exception

            End Try
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

    Private Sub BtnAddDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddDiagnosis.Click
        Dim NNewDiagnosis As New FormDiagnosisCCAMH
        If NNewDiagnosis.ShowDialog = DialogResult.OK Then
            With CboDiagnosis
                .DataSource = DA_Diagnosis.GetData
                .ValueMember = "diag_cat_id"
                .DisplayMember = "diagnosis"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumberVisit.KeyPress
        SetDisableKeyString(e)
    End Sub

    'Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
    '    CallAgeWithMonth()
    'End Sub
    Private Sub CallAgeWithMonth()
        TxtAgeWithMonth.Text = EmptyString(tbxAge.Text) & "Year/" & dtpDOB.Value.Date.Month & "Month"
    End Sub



End Class