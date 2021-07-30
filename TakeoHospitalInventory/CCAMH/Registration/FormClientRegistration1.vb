
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class FormClientRegistration1

    Dim ds_client As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim ds_client_social As New DS_CCAMHClientRegistrationTableAdapters.CLIENT_CA_SOCIALTableAdapter
    Dim ds_client_reg_detail As New DS_CCAMHClientRegistrationTableAdapters.CLIENT_REGISTRATION_DETAILTableAdapter
    Dim DASocialServiceNew As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_NEWSERVIEC_PARATableAdapter
    Dim education As New DS_CCAMHClientRegistrationTableAdapters.tblEducationTableAdapter
    Dim ds_neuro As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_NEUROTableAdapter
    Dim ds_psycho_minor As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_PSYCHO_MINORTableAdapter
    Dim ds_psycho_major As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_PSYCHO_MAJORTableAdapter
    Dim ds_dev_disorder As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_CLIENT_DDISORDERTableAdapter
    Dim ds_neuro_detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_CLIENT_NEUROTableAdapter
    Dim ds_psycho_minor_detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_PSYCHO_MINOR_DETAILTableAdapter
    Dim ds_psycho_major_detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_PSYCHO_MAJOR_DETAILTableAdapter
    Dim ds_ddisorder_detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_DDISORDER_DETAILTableAdapter
    Public tblNeuro As DataTable = New DS_CCAMHClient_Impressions.CCAMH_NEURODataTable
    Public tblDDisorder As DataTable = New DS_CCAMHClient_Impressions.CCAMH_CLIENT_DDISORDERDataTable
    Public tblPsychoMinor As DataTable = New DS_CCAMHClient_Impressions.CCAMH_PSYCHO_MINORDataTable
    Public tblPsychoMajor As DataTable = New DS_CCAMHClient_Impressions.CCAMH_PSYCHO_MAJORDataTable
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim occu As New DS_CCAMHClientRegistrationTableAdapters.TblOccupationTableAdapter
    Dim ds_pos As New DS_CCAMHClient_POSITIONSTableAdapters.CCAMH_POSITIONSTableAdapter
    Dim tblDataClient As DataTable
    Dim tblSocial As DataTable
    Dim sibling As Integer
    Dim maleSibling As Integer
    Dim femaleSibling As Integer
    Dim patientNo As Double
    Dim isEdit As Boolean = False

    '=================================== Address ==================================
    '================ Add client relative come with ==============================
    Dim DA_RELATIVE_COME_DETAIL As New DSFamilyComeTableAdapters.CLIENT_COMEWITH_INFO_DETAILTableAdapter
    Dim Table_Relative_come_detail As DataTable = New DSFamilyCome.CLIENT_COMEWITH_INFO_DETAILDataTable
    Dim DA_RELATIVE_INFO As New DSFamilyComeTableAdapters.CLIENT_COME_INFOTableAdapter


    '---------------- Add new address -----------------------------------


    Dim DAProvince As New DSAddressTableAdapters.TBL_PROVINCETableAdapter
    Dim DADistrict As New DSAddressTableAdapters.TBL_DISTRICTTableAdapter
    Dim DACommune As New DSAddressTableAdapters.TBL_COMMUNETableAdapter
    Dim DAVillage As New DSAddressTableAdapters.TBL_VILLAGETableAdapter
    Dim DA_ClientMG As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter

    '================= Refered by ===================================

    Dim DA_ReferedBy As New DSReferedTableAdapters.CCAMH_REFERED_BY_ORGTableAdapter
    Dim Table_Refered As DataTable = New DSRefered.CCAMH_REFERED_DETIALDataTable
    Dim DA_ReferedByDetial As New DSReferedTableAdapters.CCAMH_REFERED_DETIALTableAdapter

    Dim TblNewReceipt As DataTable
    Dim AmmountA As Double = 0
    Dim AmmountB As Double = 0
    Dim AmmountC As Double = 0


    '================= Print Application fomr client =======================
    Dim TblClient As DataTable
    Dim TblFamilyRelativeCome As DataTable
    Dim TblReferredDetail As DataTable
    Dim TblNeuroDetail As DataTable
    Dim TblPsychoMinorDetail As DataTable
    Dim TblPsychoMajorDetail As DataTable
    Dim TblDisorderDetail As DataTable
    Dim TblRegDetail As DataTable
    Dim DA_Reg_Preview As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_REG_PREVIEWTableAdapter
    Dim DA_FamilyComeDetail As New DSFamilyComeTableAdapters.CLIENT_COMEWITH_INFO_DETAILTableAdapter
    Dim DA_Referred_Detail As New DSReferedTableAdapters.CCAMH_REFERED_DETIALTableAdapter
    Dim DA_Neuro_Detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_CLIENT_NEUROTableAdapter
    Dim DA_Psycho_Minor_Detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_PSYCHO_MINOR_DETAILTableAdapter
    Dim DA_Psycho_Major_Detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_PSYCHO_MAJOR_DETAILTableAdapter
    Dim DA_Disorder_Detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_DDISORDER_DETAILTableAdapter

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
        InitAllComboParamenter()
    End Sub
    Private Sub InitClientProperties(ByVal ClientIDAuto As Double)
        GridRelativeCome.DataSource = DA_RELATIVE_COME_DETAIL.SelectRelativeComeByClientNo(ClientIDAuto)
        GridReferedBy.DataSource = DA_ReferedByDetial.SelectReferedByClientNo(ClientIDAuto)

    End Sub


    Function CheckGroupValidateAsJanusCheckBox(ByVal GB As Object) As Boolean
        For Each obj As Object In GB.Controls
            If TypeOf obj Is Janus.Windows.EditControls.UICheckBox Then
                Dim Ch As UICheckBox = CType(obj, Janus.Windows.EditControls.UICheckBox)
                If Ch.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
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
    Public Property getPatientNo() As Double
        Get
            Return patientNo
        End Get
        Set(ByVal value As Double)
            patientNo = value
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
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        SetEnglishLanguage()
        Me.Close()
    End Sub


    Private Sub FormClientRegistration1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' WHen click update, patienNo != 0
        '    cbxlNeuro.Items.Item(0).C

        If patientNo <> 0 Then ' When Edit patientNo is not 0
            tblDataClient = ds_client.SelectClientByNo(patientNo)
            tblSocial = ds_client_social.GetDataByClientNo(patientNo)
            PanelNewReceipt.Visible = False
            For Each row As DataRow In tblDataClient.Rows
                TxtClientNo.Text = row("CLIENT_NO")
                'If row("CLIENT_INFORMANT_RELATIVE_FATHER") = True Then
                '    cbxFather.Checked = True
                'End If
                'If row("CLIENT_INFORMANT_RELATIVE_MOTHER") = True Then
                '    cbxMother.Checked = True
                'End If
                'If row("CLIENT_INFORMANT_RELATIVE_GRANDFATHER") = True Then
                '    cbxGrandfather.Checked = True
                'End If
                'If row("CLIENT_INFORMANT_RELATIVE_GRANDMOTHER") = True Then
                '    cbxGrandmother.Checked = True
                'End If
                'If row("CLIENT_INFORMANT_RELATIVE_AUNTY") = True Then
                '    cbxAunty.Checked = True
                'End If
                'If row("CLIENT_INFORMANT_RELATIVE_UNCLE") = True Then
                '    cbxUncle.Checked = True
                'End If
                'If row("CLIENT_INFORMANT_RELATIVE_OTHER") = True Then
                '    cbxRelOthers.Checked = True
                'End If

                If Trim(row("CLIENT_RELIABILITY").ToString) = "good" Then
                    cbxRelGood.Checked = True
                ElseIf Trim(row("CLIENT_RELIABILITY").ToString) = "fair" Then
                    cbxRelFair.Checked = True
                ElseIf Trim(row("CLIENT_RELIABILITY").ToString) = "poor" Then
                    cbxRelPoor.Checked = True
                End If

                'If row("CLIENT_REFERED_BY_PEOPLE_SELF") = True Then
                '    cbxSelf.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_PEOPLE_NEIGHBOR") = True Then
                '    cbxNeighbor.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_PEOPLE_RELATIVE") = True Then
                '    cbxRelative.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_PEOPLE_FRIEND") = True Then
                '    cbxFriends.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_HOSPITAL_HC") = True Then
                '    cbxHC.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_PEOPLE_PRIVATE") = True Then
                '    cbxPrivate.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_PEOPLE_KBH") = True Then
                '    cbxKBH.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_PEOPLE_KSFS") = True Then
                '    cbxKSFH.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_PEOPLE_NPH") = True Then
                '    cbxNPH.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_MEDIA_FBOOK") = True Then
                '    cbxFB.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_MEDIA_TV") = True Then
                '    cbxTV.Checked = True
                'End If
                'If row("CLIENT_REFERED_BY_MEDIA_NPAPERS") = True Then
                '    cbxNewspaper.Checked = True
                'End If

                If row("CLIENT_C_E") = "C" Then
                    rbtnC.Checked = True
                ElseIf row("CLIENT_C_E") = "E" Then
                    rbtnE.Checked = True
                End If

                cbxSex.SelectedItem = row("CLIENT_SEX")
                cbxSchoolYes.Checked = True
                txtPatientNameKh.Text = row("CLIENT_NAME_KHM")
                txtPatientNameEn.Text = row("CLIENT_NAME")
                txtSiblingNo.Text = row("CLIENT_SIBLING")
                txtSiblingNoM.Text = row("CLIENT_BROTHER")
                txtSiblingNoF.Text = row("CLIENT_SISTER")
                tbxAge.Text = row("CLIENT_AGE")
                dtpDOB.Value = row("CLIENT_DOB")
                TxtAgeWithMonth.Text = IIf(IsDBNull(row("CLIENT_AGE_MONTH")), "", row("CLIENT_AGE_MONTH"))
                dtbDOR.Value = Convert.ToDateTime(Trim(row("CLIENT_DATE_REG").ToString))
                '   dtbDOR.Value = Convert.ToDateTime(row("CLIENT_DATE_REG")).ToString("MM/dd/yyyy") 'DateTime.ParseExact(row("CLIENT_DATE_REG"), "dd/MM/yyyy", DATE_DEFAULT_SETTING)

                tbxFatherName.Text = row("CLIENT_FATHER_NAME")
                tbxFatherAge.Text = row("CLIENT_FATHER_AGE")
                cbxFatherOccupation.SelectedText = row("CLIENT_FATHER_AGE")
                tbxMotherName.Text = row("CLIENT_MOTHER_NAME")
                tbxMotherAge.Text = row("CLIENT_MOTHER_AGE")
                ' Set Comboboxes 
                Dim selected_occupation As Decimal
                If IsDBNull(row("CLIENT_OCCUPATION")) Or Trim(row("CLIENT_OCCUPATION").ToString) = "" Then
                    selected_occupation = -1
                Else
                    Try
                        selected_occupation = Decimal.Parse(row("CLIENT_OCCUPATION"))
                    Catch ex As Exception

                    End Try

                End If

                With cbxOccupation
                    .DataSource = occu.GetData
                    .DisplayMember = "Occupation"
                    .ValueMember = "OccNo"
                    .SelectedValue = selected_occupation
                End With
                ' -----------------------------------

                If IsDBNull(row("CLIENT_POSITION")) = False And Trim(row("CLIENT_POSITION").ToString) <> "" Then
                    txtPosition.Text = row("CLIENT_POSITION")
                End If

                ' ------------------------------------
                Dim selected_father_edu As Decimal
                If IsDBNull(row("CLIENT_FATHER_EDUCATION")) Or Trim(row("CLIENT_FATHER_EDUCATION").ToString) = "" Then
                    selected_father_edu = -1
                Else
                    selected_father_edu = Decimal.Parse(row("CLIENT_FATHER_EDUCATION"))
                End If
                With cbxFatherEducation
                    .DataSource = education.GetData
                    .DisplayMember = "Education"
                    .ValueMember = "eduNo"
                    .SelectedValue = selected_father_edu
                End With
                ' ------------------------------------
                Dim selected_mother_edu As Decimal
                If IsDBNull(row("CLIENT_MOTHER_EDUCATION")) Or Trim(row("CLIENT_MOTHER_EDUCATION").ToString) = "" Then
                    selected_mother_edu = -1
                Else
                    selected_mother_edu = Decimal.Parse(row("CLIENT_MOTHER_EDUCATION"))
                End If
                With cbxMotherEducation
                    .DataSource = education.GetData
                    .DisplayMember = "Education"
                    .ValueMember = "eduNo"
                    .SelectedValue = selected_mother_edu
                End With
                ' --------------------------------------
                Dim selected_father_occ As Decimal
                If IsDBNull(row("CLIENT_FATHER_OCCUPATION")) Or Trim(row("CLIENT_FATHER_OCCUPATION").ToString) = "" Then
                    selected_father_occ = -1
                Else
                    selected_father_occ = Decimal.Parse(row("CLIENT_FATHER_OCCUPATION"))
                End If
                With cbxFatherOccupation
                    .DataSource = occu.GetData
                    .DisplayMember = "Occupation"
                    .ValueMember = "OccNo"
                    .SelectedValue = selected_father_occ
                End With
                ' ----------------------------------
                Dim selected_mother_occ As Decimal
                If IsDBNull(row("CLIENT_MOTHER_OCCUPATION")) Or Trim(row("CLIENT_MOTHER_OCCUPATION").ToString) = "" Then
                    selected_mother_occ = -1
                Else
                    selected_mother_occ = Decimal.Parse(row("CLIENT_MOTHER_OCCUPATION"))
                End If
                With cbxMotherOccupation
                    .DataSource = occu.GetData
                    .DisplayMember = "Occupation"
                    .ValueMember = "OccNo"
                    .SelectedValue = selected_mother_occ
                End With
                ' ---------------------------------
                Dim selected_province As Decimal
                If IsDBNull(row("CLIENT_ADDRESS_PROVINCE")) Or Trim(row("CLIENT_ADDRESS_PROVINCE").ToString) = "" Then
                    selected_province = -1
                Else
                    selected_province = Decimal.Parse(row("CLIENT_ADDRESS_PROVINCE"))
                End If
                cbxProvince.SelectedValue = row("CLIENT_ADDRESS_PROVINCE")
                cbxDistrict.SelectedValue = row("CLIENT_ADDRESS_DISTRICT")
                cbxCommune.SelectedValue = row("CLIENT_ADDRESS_COMMUNE")
                cbxVillage.SelectedValue = row("CLIENT_ADDRESS_CITY")
                '------------------------------------
                Dim selected_district As Decimal
                If IsDBNull(row("CLIENT_ADDRESS_DISTRICT")) Or Trim(row("CLIENT_ADDRESS_DISTRICT").ToString) = "" Then
                    selected_district = -1
                Else
                    selected_district = Decimal.Parse(row("CLIENT_ADDRESS_DISTRICT"))
                End If

                ' ----------------------------------
                Dim selected_commune As Decimal
                If IsDBNull(row("CLIENT_ADDRESS_COMMUNE")) Or Trim(row("CLIENT_ADDRESS_COMMUNE").ToString) = "" Then
                    selected_commune = -1
                Else
                    selected_commune = Decimal.Parse(row("CLIENT_ADDRESS_COMMUNE"))
                End If

                ' ------------------------------------
                Dim selected_city As Decimal
                If IsDBNull(row("CLIENT_ADDRESS_CITY")) Or Trim(row("CLIENT_ADDRESS_CITY").ToString) = "" Then
                    selected_city = -1
                Else
                    selected_city = Decimal.Parse(row("CLIENT_ADDRESS_CITY"))
                End If

                ' End Set Comboboxes
                tbxAddress.Text = row("CLIENT_ADDRESS_HOUSE")
                tbxStreet.Text = row("CLIENT_ADDRESS_STREET")
                tbxPhone.Text = row("CLIENT_ADDRESS_PHONE")

                If row("CLIENT_FAMILIY_HISTORY_NUCLEAR") = True Then
                    cbxNuclear.Checked = True
                End If
                If row("CLIENT_FAMILIY_HISTORY_CONT") = True Then
                    cbxFamConsang.Checked = True
                End If
                If row("CLIENT_FAMILIY_HISTORY_INTACT") = True Then
                    cbxFamIntact.Checked = True
                End If
                If row("CLIENT_FAMILIY_HISTORY_SEP") = True Then
                    cbxFamSep.Checked = True
                End If
                If row("CLIENT_FAMILIY_HISTORY_MENTAL") = True Then
                    cbxFamMI.Checked = True
                End If
                If row("CLIENT_FAMILIY_HISTORY_EPILEPSY") = True Then
                    cbxFamEpilepsy.Checked = True
                End If
                If row("CLIENT_FAMILIY_HISTORY_RETARDATION") = True Then
                    cbxMentalRet.Checked = True
                End If
                If Trim(row("CLIENT_FAMILIY_HISTORY_OTHER").ToString) <> "" Then
                    cbxFamOthers.Checked = True
                    txtFamOthers.Text = row("CLIENT_FAMILIY_HISTORY_OTHER")
                End If

                If row("CLIENT_PREVIOUS_CONST_YN") = True Then
                    rdbPreviousConstYes.Checked = True
                Else
                    rdbPreviousConstNo.Checked = True
                End If
                txtPreviousConstDetails.Text = row("CLIENT_PREVIOUS_CONST_DETAILS")
                If row("CLIENT_EDU_LEVEL_PRE") = True Then
                    cbxEduPreschool.Checked = True
                End If
                If row("CLIENT_EDU_LEVEL_PRIMARY") = True Then
                    cbxEduPrimary.Checked = True
                End If
                If row("CLIENT_EDU_LEVEL_SECONDARY") = True Then
                    cbxEduSecondary.Checked = True
                End If
                If row("CLIENT_EDU_LEVEL_HIGH") = True Then
                    cbxEduHigh.Checked = True
                End If
                If row("CLIENT_EDU_LEVEL_TRAINING") = True Then
                    cbxEduVocat.Checked = True
                End If
                If row("CLIENT_EDU_LEVEL_UNI") = True Then
                    cbxEduUni.Checked = True
                End If
                If row("CLIENT_EDU_LEVEL_NA") = True Then
                    cbxEduNA.Checked = True
                End If

                If row("CLIENT_PER_BA") = True Then
                    cbxPerBA.Checked = True
                End If
                If row("CLIENT_PER_AVG") = True Then
                    cbxPerAvg.Checked = True
                End If
                If row("CLIENT_PER_AA") = True Then
                    cbxPerAA.Checked = True
                End If
                If row("CLIENT_PER_RC") = True Then
                    cbxPerRC.Checked = True
                End If
                If row("CLIENT_PER_NA") = True Then
                    cbxPerNA.Checked = True
                End If

                If row("CLIENT_ADJUSTMENT_WA") = True Then
                    cbxAdjWA.Checked = True
                End If
                If row("CLIENT_ADJUSTMENT_BULLYING") = True Then
                    cbxAdjBy.Checked = True
                End If
                If row("CLIENT_ADJUSTMENT_BULLIED") = True Then
                    cbxAdjBd.Checked = True
                End If
                If row("CLIENT_ADJUSTMENT_SC") = True Then
                    cbxSchCom.Checked = True
                End If
                If row("CLIENT_ADJUSTMENT_TRUANCY") = True Then
                    cbxSchTru.Checked = True
                End If
                If row("CLIENT_ADJUSTMENT_NA") = True Then
                    cbxAdjNA.Checked = True
                End If

            Next

            ' ============== View Family come ===============
            Table_Relative_come_detail = DA_RELATIVE_COME_DETAIL.SelectRelativeComeByClientNo(patientNo)
            GridRelativeCome.DataSource = Table_Relative_come_detail

            '=============== view Refferred by ==============
            Table_Refered = DA_ReferedByDetial.SelectReferedByClientNo(patientNo)
            GridReferedBy.DataSource = Table_Refered
            'Neurological Problem *
            tblNeuro = ds_neuro_detail.GetDataByClientNo(patientNo)
            GridNeuro.DataSource = tblNeuro
            ' Developmental Disorder
            tblDDisorder = ds_ddisorder_detail.GetDataByClientNo(patientNo)
            GridDDisorder.DataSource = tblDDisorder
            ' Psychological Problems
            tblPsychoMajor = ds_psycho_major_detail.GetDataByClientNo(patientNo)
            GridPsychoMajor.DataSource = tblPsychoMajor

            tblPsychoMinor = ds_psycho_minor_detail.GetDataByClientNo(patientNo)
            GridPsychoMinor.DataSource = tblPsychoMinor

            For Each row As DataRow In tblSocial.Rows
                '' Chief Complaint and Comorbidity/Social Tab
                ' Impression
                If row("CLIENT_NEUROLOGICAL") = True Then
                    cbxImprNeurological.Checked = True
                End If
                If row("CLIENT_PSYCHIATRIC") = True Then
                    cbxImprPsychiatric.Checked = True
                End If
                If row("CLIENT_PSYCHOLOGICAL") = True Then
                    cbxImprPsycho.Checked = True
                End If
                If row("CLIENT_DDISORDER") = True Then
                    cbxImprDisorder.Checked = True
                End If

                'Comorbidity
                If row("CLIENT_COMORBIDITY") = True Then
                    rdtComorbidityYes.Checked = True
                Else
                    rdtComorbidityNo.Checked = True
                End If
                If row("CLIENT_CLINICAL_AUDIT") = True Then
                    rdbClinicalAuditYes.Checked = True
                Else
                    rdbClinicalAuditNo.Checked = True
                End If

                If row("CLIENT_SOCIAL_SERVICETYPE") = "A" Then
                    cxbTypeA.Checked = True
                ElseIf row("CLIENT_SOCIAL_SERVICETYPE") = "B" Then
                    cxbTypeB.Checked = True
                ElseIf row("CLIENT_SOCIAL_SERVICETYPE") = "C" Then
                    cxbTypeC.Checked = True
                End If

                If row("CLIENT_POVERTY_CARD") = True Then
                    rdbPovertyCardYes.Checked = True
                Else
                    rdbPovertyCardNo.Checked = True
                End If

                txtPovertyOther.Text = row("CLIENT_POVERTY_OTHERS")


                '' ================= Case advice to do assessment ========================

                CboAdviseAssessment.Text = row("CLIENT_ADVISED_ASSESSMENT")
                If TypeOf row("CLIENT_ADVISED_ASSESSMENT_DATE") Is DBNull Then
                    DateAssessDate.Checked = False
                Else
                    DateAssessDate.Checked = True
                    DateAssessDate.Value = row("CLIENT_ADVISED_ASSESSMENT_DATE")
                End If
                If TypeOf row("CLIENT_ADVICED_ASSESSMENT_NOTE") Is DBNull Then
                    TxtAdviseAssessmentNote.Text = ""
                Else
                    TxtAdviseAssessmentNote.Text = row("CLIENT_ADVICED_ASSESSMENT_NOTE")
                End If

              
                If TypeOf row("CLIENT_ADVISED_ASSESSMENT_DATE") Is DBNull Then
                Else
                    DateAssessDate.Value = row("CLIENT_ADVISED_ASSESSMENT_DATE")
                End If


                If Trim(row("CLIENT_REFER_TO").ToString) = "KBH" Then
                    rdbReferKBH.Checked = True
                End If
                If Trim(row("CLIENT_REFER_TO").ToString) = "SFH" Then
                    rdbReferSFH.Checked = True
                End If
                If Trim(row("CLIENT_REFER_TO").ToString) = "NPH" Then
                    rdbReferNPH.Checked = True
                End If
                If Trim(row("CLIENT_REFER_TO").ToString) = "EXC" Then
                    rdbReferEXC.Checked = True
                End If
                If Trim(row("CLIENT_REFER_TO").ToString) = "VI" Then
                    rdbReferVI.Checked = True
                End If
                If Trim(row("CLIENT_REFER_TO").ToString) = "TEH" Then
                    rdbReferTEH.Checked = True
                End If
                If Trim(row("CLIENT_REFER_TO").ToString) = "ANGDOUNG" Then
                    rdbReferAng.Checked = True
                End If
                If Trim(row("CLIENT_REFER_TO").ToString) = "HH" Then
                    rdbReferHH.Checked = True
                End If
                If Trim(row("CLIENT_REFER_TO").ToString) = "OTHER" Then
                    rdbReferOther.Checked = True
                End If

                If Trim(row("CLIENT_SOCIAL_WORKER").ToString) = "UNIT II" Then
                    RadSocialUnitII.Checked = True
                ElseIf Trim(row("CLIENT_SOCIAL_WORKER").ToString) = "UNIT I" Then
                    RadSocialUnitI.Checked = True 'rdbSocialUnit1.Checked = True
                End If

                txtUnitAlloc1.Text = row("CLIENT_UNIT_ALL_1")
                txtUnitAlloc2.Text = row("CLIENT_UNIT_ALL_2")

            Next
        Else
            LoadNewClientNo() ' If Add New

            ' SetAllComboboxes()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmOccupation As New FrmNewOccupation
        frmOccupation.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmOccupation As New FrmNewOccupation
        frmOccupation.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmOccupation As New FrmNewOccupation
        frmOccupation.ShowDialog()
    End Sub
    Sub LoadNewClientNo()
        TxtClientNo.Text = ModCommon.GeneratePatientNoForScreening("CLIENT_NO", "CCAMH_CLIENTS")
        Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
    End Sub
    Sub ResetFormClientRegistration()
        LoadNewClientNo()
    End Sub
    Private Sub btnEducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEducation As New Education
        frmEducation.ShowDialog()
    End Sub

    Private Sub btnMotherEducaiton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEducation As New Education
        frmEducation.ShowDialog()
    End Sub

    Private Sub btnFatherEducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEducation As New Education
        frmEducation.ShowDialog()
    End Sub
    Private Sub btnAddProvince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmProvince As New FrmNewProvince
        frmProvince.ShowDialog()
    End Sub

    Private Sub btnAddDistrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmDistrict As New FrmNewDistrict
        frmDistrict.ShowDialog()
    End Sub

    Private Sub btnAddCommune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmCommune As New FNewCommune
        frmCommune.ShowDialog()
    End Sub

    Private Sub btnAddVillage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frmVillage As New FrmNewProvince

    End Sub

    Private Sub btnProvince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmProvince As New FrmNewProvince
        frmProvince.ShowDialog()
    End Sub

    Private Sub btnClientOccupation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmOccupation As New FrmNewOccupation
        frmOccupation.ShowDialog()
    End Sub

    Private Sub btnFathOccupation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmOccupation As New FrmNewOccupation
        frmOccupation.ShowDialog()
    End Sub

    Private Sub btnMothOccupation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmOccupation As New FrmNewOccupation
        frmOccupation.ShowDialog()
    End Sub

    Private Sub btnClientEducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEducation As New Education
        frmEducation.ShowDialog()
    End Sub

    Private Sub btnFathEduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEducation As New Education
        frmEducation.ShowDialog()
    End Sub

    Private Sub btnMothEducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEducation As New Education
        frmEducation.ShowDialog()
    End Sub

    Private Sub btnDistrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmDistrict As New FrmNewDistrict
        frmDistrict.ShowDialog()
    End Sub

    Private Sub btnCommune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmCommune As New FNewCommune
        frmCommune.ShowDialog()
    End Sub

    Private Sub btnVillage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmVillage As New FrmNewProvince
        frmVillage.ShowDialog()
    End Sub
    Private Sub RelativeCome()
        With CboRelativeCome
            .DataSource = DA_RELATIVE_INFO.GetData
            .DisplayMember = "COME_WITH"
            .ValueMember = "COME_TYPE"

            .SelectedIndex = -1
        End With
    End Sub
    Private Sub ReferedBy()
        With CboReferedby
            .DataSource = DA_ReferedBy.GetData
            .ValueMember = "refer_by_category"
            .DisplayMember = "REFER_BY"
            .SelectedIndex = -1
        End With
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

    Private Sub RefreshImpression()
        With cboNeuro
            .DataSource = ds_neuro.GetData
            .ValueMember = "SYMPTOM_ID"
            .DisplayMember = "SYMPTOM_NAME"
            .SelectedIndex = -1
        End With

        With cboPsychoMinor
            .DataSource = ds_psycho_minor.GetData
            .ValueMember = "SYMPTOM_ID"
            .DisplayMember = "SYMPTOM_NAME"
            .SelectedIndex = -1
        End With

        With cboPsychoMajor
            .DataSource = ds_psycho_major.GetData
            .ValueMember = "SYMPTOM_ID"
            .DisplayMember = "SYMPTOM_NAME"
            .SelectedIndex = -1
        End With

        With cboDevDisorder
            .DataSource = ds_dev_disorder.GetData
            .ValueMember = "SYMPTOM_ID"
            .DisplayMember = "SYMPTOM_NAME"
            .SelectedIndex = -1
        End With


    End Sub

    Function InitAllComboParamenter()
        RefreshOccupation()
        RefreshEducation()
        RefreshImpression()
        RelativeCome()
        ReferedBy()
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        '==================== check family relative come with ============
        If GridRelativeCome.SelectedItems.Count = 0 Then
            GroupRelativeCome.BackColor = Color.LightYellow
            tbcMain.SelectedIndex = 0
            Exit Sub
        Else
            GroupRelativeCome.BackColor = Color.Transparent
        End If
        '===================== Check condition group book ================ 
        'If CheckGroupValidateAsJanusCheckBox(GroupRelativeCome) = False Then
        '    'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    GroupRelativeCome.BackColor = Color.LightYellow
        '    tbcMain.SelectedIndex = 0
        '    Exit Sub
        'Else
        '    GroupRelativeCome.BackColor = Color.Transparent
        'End If
        If CheckGroupValidateAsJanusCheckBox(GroupReliability) = False Then
            'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupReliability.BackColor = Color.LightYellow
            tbcMain.SelectedIndex = 0
            Exit Sub
        Else
            GroupReliability.BackColor = Color.Transparent
        End If
        If ValidateTextField(TxtClientNo, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 0
            Exit Sub
        End If
        If ValidateTextField(txtPatientNameKh, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 0
            Exit Sub
        End If
        If ValidateTextField(txtPatientNameEn, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 0
            Exit Sub
        End If

        If ValidateCombobox(cbxSex, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 0
            Exit Sub
        End If
        If ValidateTextField(tbxAge, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 0
            Exit Sub
        End If
        If ValidateTextField(TxtAgeWithMonth, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 0
            Exit Sub
        End If
        'If CheckGroupValidateAsJanusCheckBox(GroupReferedBy) = False Then
        '    'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    GroupReferedBy.BackColor = Color.LightYellow
        '    tbcMain.SelectedIndex = 0
        '    Exit Sub
        'Else
        '    GroupReferedBy.BackColor = Color.Transparent
        'End If
        If GridReferedBy.SelectedItems.Count = 0 Then
            GbReferredBy.BackColor = Color.LightYellow
            tbcMain.SelectedIndex = 0
            Exit Sub
        Else
            GbReferredBy.BackColor = Color.Transparent
        End If

        If ValidateTextField(tbxFatherName, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 1
            Exit Sub
        End If
        If ValidateTextField(tbxMotherName, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 1
            Exit Sub
        End If
        If ValidateCombobox(cbxProvince, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 1
            Exit Sub
        End If
        If cbxProvince Is Nothing Then
            cbxProvince.Select()
            cbxProvince.Select()
            cbxProvince.SelectAll()
            MessageBox.Show("wrong province name!", "Province", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If ValidateCombobox(cbxDistrict, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 1
            Exit Sub
        End If
        If cbxDistrict Is Nothing Then
            cbxDistrict.Select()
            cbxDistrict.SelectAll()
            cbxDistrict.Focus()
            MessageBox.Show("wrong district name!", "district", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ValidateCombobox(cbxCommune, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 1
            Exit Sub
        End If
        If cbxCommune Is Nothing Then
            cbxCommune.Select()
            cbxCommune.SelectAll()
            cbxCommune.Focus()
            MessageBox.Show("wrong commune name!", "Commune", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
        If ValidateCombobox(cbxVillage, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 1
            Exit Sub
        End If
        If cbxVillage Is Nothing Then
            cbxVillage.Select()
            cbxVillage.SelectAll()
            cbxVillage.Focus()
            MessageBox.Show("wrong village name!", "village", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ValidateTextField(tbxPhone, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 1
            Exit Sub
        End If
        If CheckGroupValidateAsNormalCheckBox(GroupFamilyHistory) = False Then
            'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupFamilyHistory.BackColor = Color.LightYellow
            tbcMain.SelectedIndex = 1
            Exit Sub
        Else
            GroupFamilyHistory.BackColor = Color.Transparent
        End If

        If CheckGroupValidateAsNormalCheckBox(GroupEducation) = False Then
            'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupEducation.BackColor = Color.LightYellow
            tbcMain.SelectedIndex = 1
            Exit Sub
        Else
            GroupEducation.BackColor = Color.Transparent
        End If
        If CheckGroupValidateAsNormalCheckBox(GroupImpression) = False Then
            'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupImpression.BackColor = Color.LightYellow
            tbcMain.SelectedIndex = 2
            Exit Sub
        Else
            GroupImpression.BackColor = Color.Transparent
        End If
        If CheckGroupValidateAsRadio(GroupPreviusConsult) = False Then
            'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupPreviusConsult.BackColor = Color.LightYellow
            tbcMain.SelectedIndex = 2
            Exit Sub
        Else
            GroupPreviusConsult.BackColor = Color.Transparent
        End If
        If CheckGroupValidateAsRadio(GroupSocialServiceType) = False Then
            'MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupSocialServiceType.BackColor = Color.LightYellow
            tbcMain.SelectedIndex = 2
            Exit Sub
        Else
            GroupSocialServiceType.BackColor = Color.Transparent
        End If
        If ValidateCombobox(CboAdviseAssessment, "", ErrClientRegis) = False Then
            tbcMain.SelectedIndex = 2
            CboAdviseAssessment.Select()
            CboAdviseAssessment.Focus()

            Exit Sub
        End If
        '==================== Do event save ============================


        If MessageBox.Show("Do you really want to save the client information?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            ' Function save new pateint register and screening book
            If patientNo <> 0 Then
                If saveCCAMHClientInfo() = True Then
                    MessageBox.Show("Client successfully saved!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error Client Information. Please verify data and enter it again!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                '====================== in case save new client
                If ValidateTextField(TxtReceiptNo, "", ErrClientRegis) = False Then
                    tbcMain.SelectedIndex = 2
                    Exit Sub
                End If
                If ValidateDateField(DateReceipt, "", ErrClientRegis) = False Then
                    tbcMain.SelectedIndex = 2
                    Exit Sub
                End If
                If ValidateTextField(TxtReceiptAmmount, "", ErrClientRegis) = False Then
                    tbcMain.SelectedIndex = 2
                    Exit Sub
                End If
                If ValidateTextField(TxtAmmountInword, "", ErrClientRegis) = False Then
                    tbcMain.SelectedIndex = 2
                    Exit Sub
                End If
                If ModCommon.CheckDuplicateClientNo(TxtClientNo.Text, "CCAMH_CLIENTS") = True Then
                    MessageBox.Show("The client No already in system. The No will generate the new one.", "Load ID", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadNewClientNo()
                End If
                Application.DoEvents()



                ' save new client ============================= 
                If saveCCAMHClientInfo() = True Then
                    DA_ClientMG.InsertClientManagement(TxtClientNo.Text, txtPatientNameKh.Text, cbxSex.Text, EmptyString(tbxAge.Text), "", "", dtbDOR.Value.Date, 0, tbxPhone.Text, Nothing, "", Nothing, Nothing, "")
                    'If ReceiptUtilityModule.CheckDuplicateReceiptNo(EmptyString(TxtReceiptNo.Text)) = True Then
                    Me.TxtReceiptNo.Text = ReceiptUtilityModule.RefreshRecieptNo()
                    'End If
                    If SaveNewReceiptAndPrintReceipt() = 1 Then
                        Application.DoEvents()
                        LblPrinting.Visible = True
                        PicLoading.Visible = True
                        Application.DoEvents()
                        BGSaveAndPrintReceipt.RunWorkerAsync()
                    End If

                Else
                    MessageBox.Show("Error Client Information. Please verify data and enter it again!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End If
    End Sub
   
    Private Sub DoPrintApplicationform()
        Dim FPrintPreview As New RegisPrintPreview
        Dim CRRegisPreview As New RegistrationPreview
        ' CRRegisPreview.SetDataSource(TblClient)
        CRRegisPreview.Database.Tables(0).SetDataSource(TblClient)

        CRRegisPreview.Database.Tables(1).SetDataSource(TblNeuroDetail)
        CRRegisPreview.Database.Tables(2).SetDataSource(TblPsychoMinorDetail)
        CRRegisPreview.Database.Tables(3).SetDataSource(TblPsychoMajorDetail)
        CRRegisPreview.Database.Tables(4).SetDataSource(TblDisorderDetail)
        'CRRegisPreview.Database.Tables(5).SetDataSource(TblReferredDetail)
        CRRegisPreview.Subreports("ReferredByRecport").SetDataSource(TblReferredDetail)
        CRRegisPreview.Subreports("FamilyRelativeCome").SetDataSource(TblFamilyRelativeCome)
        ' CRRegisPreview.SetDataSource(TblClient)
        CRRegisPreview.Database.Tables(0).SetDataSource(TblClient)
        CRRegisPreview.Database.Tables(1).SetDataSource(TblNeuroDetail)
        FPrintPreview.CrystalReportObject = CRRegisPreview
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
    End Sub
    Private Function SaveNewReceiptAndPrintReceipt() As Integer
        Return DAClientReceipt.InsertNewReceiptService(EmptyString(TxtReceiptNo.Text), ReceiptUtilityModule.RECEIPT_NEW, GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), cxbTypeA.Checked), GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), cxbTypeB.Checked), GetValuePriceSocialService(EmptyString(TxtReceiptAmmount.Text), cxbTypeC.Checked), False, DateReceipt.Value.Year, GetDateServer.Date, DateReceipt.Value.Date, EmptyString(TxtReceiptAmmount.Text), (EmptyString(TxtReceiptAmmount.Text) / GetExchangeRate()), GetExchangeRate, "", TxtAmmountInword.Text, TxtClientNo.Text, txtPatientNameEn.Text, cbxSex.Text, EmptyString(tbxAge.Text), "", "", ReceiptUtilityModule.GetSocialServieType(cxbTypeA.Checked, cxbTypeB.Checked, cxbTypeC.Checked), txtPatientNameKh.Text)
    End Function
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
       
        If cbxRelGood.Checked Then
            reliability = "good"
        End If
        If cbxRelFair.Checked Then
            reliability = "fair"
        End If
        If cbxRelPoor.Checked Then
            reliability = "poor"
        End If
       

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

        If Trim(txtSiblingNo.Text) = "" Then
            sibling_no = 0
        Else
            sibling_no = Decimal.Parse(txtSiblingNo.Text)
        End If

        If Trim(txtSiblingNoM.Text) = "" Then
            sibling_m_no = 0
        Else
            sibling_m_no = Decimal.Parse(txtSiblingNoM.Text)
        End If

        If Trim(txtSiblingNoF.Text) = "" Then
            sibling_f_no = 0
        Else
            sibling_f_no = Decimal.Parse(txtSiblingNoF.Text)
        End If

        If Trim(txtPosition.Text) <> "" Then
            position = Integer.Parse(txtPosition.Text)
        End If

        occupation = cbxOccupation.SelectedValue

        If cbxSchoolYes.Checked Then
            schoolYes = 1
        End If
        If cbxSchoolNo.Checked Then
            schoolNo = 1
        End If
        If cbxSchoolNever.Checked Then
            schoolNever = 1
        End If
        If cbxSchoolDrop.Checked Then
            schoolDrop = 1
        End If
        If cbxSchoolNA.Checked Then
            schoolNA = 1
        End If
        If cbxSchoolNY.Checked Then
            schoolNY = 1
        End If

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

        If cbxNuclear.Checked Then
            client_nuclear = 1
        End If
        If cbxFamConsang.Checked Then
            client_consangonis = 1
        End If
        If cbxFamIntact.Checked Then
            client_inact = 1
        End If
        If cbxFamSep.Checked Then
            client_separated = 1
        End If
        If cbxFamMI.Checked Then
            client_mental = 1
        End If
        If cbxFamEpilepsy.Checked Then
            client_epilepsis = 1
        End If
        If cbxMentalRet.Checked Then
            client_retardation = 1
        End If
        If cbxFamOthers.Checked Then
            client_other_illness = txtFamOthers.Text
        End If
        other_misc = txtFamOthers.Text
        ' Previous consultation
        Dim pre_treatment As Boolean
        Dim pre_treatment_detail As String
        If rdbPreviousConstNo.Checked Then
            pre_treatment = 0
        End If
        If rdbPreviousConstYes.Checked Then
            pre_treatment = 1
        End If
        pre_treatment_detail = txtPreviousConstDetails.Text

        ' Education
        Dim level_preschool As Boolean = 0
        Dim level_primary As Boolean = 0
        Dim level_secondary As Boolean = 0
        Dim level_highschool As Boolean = 0
        Dim level_vtraining As Boolean = 0
        Dim level_uni As Boolean = 0
        Dim level_na As Boolean = 0

        If cbxEduPreschool.Checked Then
            level_preschool = 1
        End If
        If cbxEduPrimary.Checked Then
            level_primary = 1
        End If
        If cbxEduSecondary.Checked Then
            level_secondary = 1
        End If
        If cbxEduHigh.Checked Then
            level_highschool = 1
        End If
        If cbxEduVocat.Checked Then
            level_vtraining = 1
        End If
        If cbxEduUni.Checked Then
            level_uni = 1
        End If
        If cbxEduNA.Checked Then
            level_na = 1
        End If

        Dim perf_ba As Boolean = 0
        Dim perf_avg As Boolean = 0
        Dim perf_aa As Boolean = 0
        Dim perf_rc As Boolean = 0
        Dim perf_na As Boolean = 0

        If cbxPerBA.Checked Then
            perf_ba = 1
        End If
        If cbxPerAvg.Checked Then
            perf_avg = 1
        End If
        If cbxPerAA.Checked Then
            perf_aa = 1
        End If
        If cbxPerRC.Checked Then
            perf_rc = 1
        End If
        If cbxPerNA.Checked Then
            perf_na = 1
        End If

        Dim adjustment_wa As Boolean = 0
        Dim adjustment_bullying As Boolean = 0
        Dim adjustment_bullied As Boolean = 0
        Dim adjustment_sc As Boolean = 0
        Dim adjustment_tru As Boolean = 0
        Dim adjustment_na As Boolean = 0

        If cbxAdjWA.Checked Then
            adjustment_wa = 1
        End If
        If cbxAdjBy.Checked Then
            adjustment_bullying = 1
        End If
        If cbxAdjBd.Checked Then
            adjustment_bullied = 1
        End If
        If cbxSchCom.Checked Then
            adjustment_sc = 1
        End If
        If cbxSchTru.Checked Then
            adjustment_tru = 1
        End If
        If cbxAdjNA.Checked Then
            adjustment_na = 1
        End If

        ' Comorbidity / Social status
        Dim comorbidity As Boolean = 0
        Dim clinicalaudit As Boolean = 0


        Dim poverty_card As Boolean = 0
        Dim poverty_other As String
        If rdtComorbidityNo.Checked Then
            comorbidity = 0
        End If
        If rdtComorbidityYes.Checked Then
            comorbidity = 1
        End If
        If rdbClinicalAuditNo.Checked Then
            clinicalaudit = 0
        End If
        If rdbClinicalAuditYes.Checked Then
            clinicalaudit = 1
        End If

      
        If rdbPovertyCardYes.Checked Then
            poverty_card = 1
        End If
        If rdbPovertyCardNo.Checked Then
            poverty_card = 0
        End If
        poverty_other = txtPovertyOther.Text
        advised_assess_date = IIf(DateAssessDate.Checked = True, DateAssessDate.Value.Date, Nothing)

        Dim referto As String = "NA"

        If rdbReferKBH.Checked Then
            referto = "KBH"
        End If
        If rdbReferSFH.Checked Then
            referto = "SFH"
        End If
        If rdbReferNPH.Checked Then
            referto = "NPH"
        End If
        If rdbReferEXC.Checked Then
            referto = "EXC"
        End If
        If rdbReferVI.Checked Then
            referto = "VI"
        End If
        If rdbReferTEH.Checked Then
            referto = "TEH"
        End If
        If rdbReferAng.Checked Then
            referto = "ANGDOUNG"
        End If
        If rdbReferHH.Checked Then
            referto = "HH"
        End If
        If rdbReferOther.Checked Then
            referto = "OTHER"
        End If
        Dim socialUnit As String

        If RadSocialUnitI.Checked Then
            socialUnit = "UNIT I"
        End If
        If RadSocialUnitII.Checked Then
            socialUnit = "UNIT II"
        End If

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

        If Trim(txtUnitAlloc1.Text) = "" Then
            unitAlloc1 = 0
        Else
            unitAlloc1 = Decimal.Parse(txtUnitAlloc1.Text)
        End If

        If Trim(txtUnitAlloc2.Text) = "" Then
            unitAlloc2 = 0
        Else
            unitAlloc2 = Decimal.Parse(txtUnitAlloc2.Text)
        End If

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
        client_np_notes = np_notes.Text
        client_pp_notes = "" 'pp_notes.Text
        client_dd_notes = dd_notes.Text
        ' INSERT into tables
        ' ================================ If User add new ===============================================
        If isEdit = False Then
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
                                      socialType, "A", TxtOldIDCode.Text, 1, TxtAgeWithMonth.Text)
            ds_client_social.InsertQuery(client_id, comorbidity, clinicalaudit, poverty_card, poverty_other, CboAdviseAssessment.Text, IIf(DateAssessDate.Checked = True, DateAssessDate.Value.Date, Nothing), _
                                         unitAlloc1, unitAlloc2, socialType, referto, socialUnit, np_fit, np_jerk, np_blank, np_head, np_eye, _
                                         np_oneside, np_other, pp_headache, pp_fear, pp_thinkalot, pp_worry, pp_steal, pp_disobie, pp_lie, _
                                         pp_angry, pp_irrit, pp_sleep, pp_fainting, pp_other, pp_mj_talk, pp_mj_laugh, pp_mj_straight, _
                                         pp_mj_aggr, pp_mj_sleep, pp_mj_appit, pp_mj_break, pp_mj_shy, pp_mj_goaway, pp_mj_other, _
                                         dd_notalk, dd_nowalk, dd_playalone, dd_beat, dd_noresponding, dd_tip, dd_poormem, dd_poorunder, _
                                         dd_poorstudy, dd_throwing, dd_drooling, dd_noneck, dd_other, imp_psychi, imp_neuro, imp_ddisorder, _
                                         imp_psycho, client_np_notes, client_pp_notes, client_dd_notes, TxtAdviseAssessmentNote.Text, ChDoDetailAssesst.Checked)
            '============== Save Information relative =============
            If GridRelativeCome.SelectedItems.Count >= 0 Then
                DA_RELATIVE_COME_DETAIL.DeleteClientComeWithInfo(TxtClientNo.Text)
                For Each GRow As GridEXRow In GridRelativeCome.GetRows
                    DA_RELATIVE_COME_DETAIL.InsertComeWithDetail(TxtClientNo.Text, GRow.Cells("COME_TYPE").Value, GRow.Cells("COME_WITH").Value, GRow.Cells("COME_WITH_NOTE").Value)
                Next
            End If
            '============== Save Refered by ========================
            If GridReferedBy.SelectedItems.Count > 0 Then
                DA_ReferedByDetial.DeleteReferedByClientNo(EmptyString(TxtClientNo.Text))
                For Each Grow As Janus.Windows.GridEX.GridEXRow In GridReferedBy.GetRows
                    DA_ReferedByDetial.InsertNewRefered(client_id, Grow.Cells("CLIENT_NO").Value, Grow.Cells("REFERED_FROM").Value, Grow.Cells("REFERED_TYPE").Value, Grow.Cells("REFFERED_NOTE").Value)
                Next
            End If
            ' Save Impression
            ' GridNeuro
            If GridNeuro.SelectedItems.Count > 0 Then
                For Each GRow As Janus.Windows.GridEX.GridEXRow In GridNeuro.GetRows
                    ds_neuro_detail.InsertQuery(client_id, GRow.Cells("SYMPTOM_ID").Value, GRow.Cells("DESCRIPTION").Value, GRow.Cells("SYMPTOM_NAME").Value)
                Next

            End If
            If GridPsychoMinor.SelectedItems.Count > 0 Then
                For Each GRow As Janus.Windows.GridEX.GridEXRow In GridPsychoMinor.GetRows
                    ds_psycho_minor_detail.InsertQuery(client_id, GRow.Cells("SYMPTOM_ID").Value, GRow.Cells("DESCRIPTION").Value, GRow.Cells("SYMPTOM_NAME").Value)
                Next

            End If
            If GridPsychoMajor.SelectedItems.Count > 0 Then
                For Each GRow As Janus.Windows.GridEX.GridEXRow In GridPsychoMajor.GetRows
                    ds_psycho_major_detail.InsertQuery(client_id, GRow.Cells("SYMPTOM_ID").Value, GRow.Cells("DESCRIPTION").Value, GRow.Cells("SYMPTOM_NAME").Value)
                Next
            End If
            If GridDDisorder.SelectedItems.Count > 0 Then
                For Each GRow As Janus.Windows.GridEX.GridEXRow In GridDDisorder.GetRows
                    ds_ddisorder_detail.InsertQuery(client_id, GRow.Cells("SYMPTOM_ID").Value, GRow.Cells("DESCRIPTION").Value, GRow.Cells("SYMPTOM_NAME").Value)
                Next
            End If

            ' End Save Impression
            ds_client_reg_detail.InsertQuery(client_id, client_name, "N", dor, "W")



            '  ======================== UPDATE CLIENT INFORMATION ============================================
        Else
            ds_client.UpdateClientInfo(client_name, client_name_kh, False, False, False, False, False, False, False, False, False, reliability, clientSex, age, ce, dob, sibling_no, sibling_f_no, sibling_m_no, dor, curDate, position, "NA", occupation, False, False, False, False, False, False, False, False, False, False, False, False, DateServer.Year, father_name, father_education, father_age, father_occ, mother_name, mother_education, mother_age, mother_occ, add_house, add_street, add_city, add_commune, add_district, add_province, phone, client_nuclear, client_consangonis, client_inact, client_separated, client_mental, client_epilepsis, client_retardation, client_other_illness, pre_treatment, pre_treatment_detail, level_preschool, level_primary, level_secondary, level_highschool, level_vtraining, level_uni, level_na, perf_ba, perf_avg, perf_aa, perf_rc, perf_na, adjustment_wa, adjustment_bullying, adjustment_bullied, adjustment_sc, adjustment_tru, adjustment_na, socialType, TxtOldIDCode.Text, TxtAgeWithMonth.Text, client_id, client_id)
            ' Update social service =================
            ds_client_social.UpdateQuery(comorbidity, clinicalaudit, poverty_card, poverty_other, IIf(DateAssessDate.Checked = True, DateAssessDate.Value.Date, Nothing), unitAlloc1, unitAlloc2, socialType, referto, socialUnit, np_fit, np_jerk, np_blank, np_head, np_eye, np_oneside, np_other, pp_headache, pp_fear, pp_thinkalot, pp_worry, pp_steal, pp_disobie, pp_lie, pp_angry, pp_irrit, pp_sleep, pp_fainting, pp_other, pp_mj_talk, pp_mj_laugh, pp_mj_straight, pp_mj_aggr, pp_mj_sleep, pp_mj_appit, pp_mj_break, pp_mj_shy, pp_mj_goaway, pp_mj_other, dd_notalk, dd_nowalk, dd_playalone, dd_beat, dd_noresponding, dd_tip, dd_poormem, dd_poorunder, dd_poorstudy, dd_throwing, dd_drooling, dd_noneck, dd_other, imp_psychi, imp_neuro, imp_ddisorder, imp_psycho, CboAdviseAssessment.Text, client_np_notes, client_pp_notes, client_dd_notes, TxtAdviseAssessmentNote.Text, client_id)
            If GridRelativeCome.SelectedItems.Count >= 0 Then
                DA_RELATIVE_COME_DETAIL.DeleteClientComeWithInfo(TxtClientNo.Text)
                For Each GRow As GridEXRow In GridRelativeCome.GetRows
                    DA_RELATIVE_COME_DETAIL.InsertComeWithDetail(TxtClientNo.Text, GRow.Cells("COME_TYPE").Value, GRow.Cells("COME_WITH").Value, GRow.Cells("COME_WITH_NOTE").Value)
                Next
            End If

            If GridReferedBy.SelectedItems.Count > 0 Then
                DA_ReferedByDetial.DeleteReferedByClientNo(EmptyString(TxtClientNo.Text))
                For Each Grow As Janus.Windows.GridEX.GridEXRow In GridReferedBy.GetRows
                    DA_ReferedByDetial.InsertNewRefered(client_id, Grow.Cells("CLIENT_NO").Value, Grow.Cells("REFERED_FROM").Value, Grow.Cells("REFERED_TYPE").Value, Grow.Cells("REFFERED_NOTE").Value)
                Next
            End If
            If GridNeuro.SelectedItems.Count > 0 Then
                ds_neuro_detail.DeleteDataByClientNo(client_id)
                For Each GRow As Janus.Windows.GridEX.GridEXRow In GridNeuro.GetRows
                    ds_neuro_detail.InsertQuery(client_id, GRow.Cells("SYMPTOM_ID").Value, GRow.Cells("DESCRIPTION").Value, GRow.Cells("SYMPTOM_NAME").Value)
                Next
            End If
            If GridPsychoMinor.SelectedItems.Count > 0 Then
                ds_psycho_minor_detail.DeleteDataByClientNo(client_id)
                For Each GRow As Janus.Windows.GridEX.GridEXRow In GridPsychoMinor.GetRows
                    ds_psycho_minor_detail.InsertQuery(client_id, GRow.Cells("SYMPTOM_ID").Value, GRow.Cells("DESCRIPTION").Value, GRow.Cells("SYMPTOM_NAME").Value)
                Next

            End If
            If GridPsychoMajor.SelectedItems.Count > 0 Then
                ds_psycho_major_detail.DeleteDataByClientNo(client_id)
                For Each GRow As Janus.Windows.GridEX.GridEXRow In GridPsychoMajor.GetRows
                    ds_psycho_major_detail.InsertQuery(client_id, GRow.Cells("SYMPTOM_ID").Value, GRow.Cells("DESCRIPTION").Value, GRow.Cells("SYMPTOM_NAME").Value)
                Next
            End If
            If GridDDisorder.SelectedItems.Count > 0 Then
                ds_ddisorder_detail.DeleteDataByClientNo(client_id)
                For Each GRow As Janus.Windows.GridEX.GridEXRow In GridDDisorder.GetRows
                    ds_ddisorder_detail.InsertQuery(client_id, GRow.Cells("SYMPTOM_ID").Value, GRow.Cells("DESCRIPTION").Value, GRow.Cells("SYMPTOM_NAME").Value)
                Next
            End If
        End If

        Return True

    End Function



    Private Sub btnSocialWorker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmSocialWorker As New FORM_SOCIALWORKER
        frmSocialWorker.ShowDialog()
    End Sub

    Private Sub btnSocialStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmSocialStatus As New FormSocialStatus
        frmSocialStatus.ShowDialog()
    End Sub


    Private Sub btnPrognosAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmPrognosis As New FormPROGNOSIS
        frmPrognosis.ShowDialog()
    End Sub

    Private Sub btnReferParam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmReferredCenter As New FormReferCenter
        frmReferredCenter.ShowDialog()
    End Sub

    Private Sub btnCaseAllocationParam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmSocialWorker As New FORM_SOCIALWORKER
        frmSocialWorker.ShowDialog()
    End Sub



    Private Sub rbtnC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnC.Click
        rbtnE.Checked = False
    End Sub


    Private Sub rbtnE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnE.Click
        rbtnC.Checked = False
    End Sub

    Private Sub rdbPreviousConstNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbPreviousConstNo.Click
        rdbPreviousConstYes.Checked = False
    End Sub

    Private Sub rdbPreviousConstYes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbPreviousConstYes.Click
        rdbPreviousConstNo.Checked = False
    End Sub

    Private Sub tbxAge_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxAge.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub tbxAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxAge.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub tbxFatherAge_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxFatherAge.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub tbxFatherAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxFatherAge.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbxMotherAge_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxMotherAge.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub tbxMotherAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMotherAge.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtUnitAlloc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUnitAlloc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSiblingNo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSiblingNo.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub txtSiblingNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSiblingNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSiblingNoM_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSiblingNoM.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub txtSiblingNoM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSiblingNoM.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSiblingNoF_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSiblingNoF.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub txtSiblingNoF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSiblingNoF.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
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

    Private Sub Label33_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label33.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub


    Function GetPriceSocialService() As Double
        Dim tblSocial As DataTable = DASocialServiceNew.SelectServiceActiveNew(True)
        For Each Rows As DataRow In tblSocial.Rows
            If cxbTypeA.Checked = True Then
                Return Rows("NEW_PRICE_A")
            ElseIf cxbTypeB.Checked = True Then
                Return Rows("NEW_PRICE_B")
            ElseIf cxbTypeC.Checked = True Then
                Return Rows("NEW_PRICE_C")
            End If
        Next
    End Function





    Private Sub TxtReceiptAmmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceiptAmmount.TextChanged
        Dim Riel As New riel()
        Dim Dollar As New dollar()

        Me.TxtAmmountInword.Text = Riel.Convert(Me.TxtReceiptAmmount.Text)
    End Sub

    Private Sub BGSaveAndPrintReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGSaveAndPrintReceipt.DoWork
        TblNewReceipt = DAClientReceipt.SelectCashByReceiptNo(EmptyString(TxtReceiptNo.Text))
        'TblClient = DA_Reg_Preview.GetDataByClientNo(EmptyString(TxtClientNo.Text))
        'TblFamilyRelativeCome = DA_FamilyComeDetail.SelectRelativeComeByClientNo(EmptyString(TxtClientNo.Text))
        'TblReferredDetail = DA_Referred_Detail.SelectReferedByClientNo(EmptyString(TxtClientNo.Text))
        'TblNeuroDetail = DA_Neuro_Detail.GetDataByClientNo(EmptyString(TxtClientNo.Text))
        'TblPsychoMinorDetail = DA_Psycho_Minor_Detail.GetDataByClientNo(EmptyString(TxtClientNo.Text))
        'TblPsychoMajorDetail = DA_Psycho_Major_Detail.GetDataByClientNo(EmptyString(TxtClientNo.Text))
        'TblDisorderDetail = DA_Disorder_Detail.GetDataByClientNo(EmptyString(TxtClientNo.Text))
    End Sub

    Private Sub BGSaveAndPrintReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGSaveAndPrintReceipt.RunWorkerCompleted
        DoPrintReceipt()
        'DoPrintApplicationform()
        LblPrinting.Visible = False
        PicLoading.Visible = False
        MessageBox.Show("Client successfully saved!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
    Private Sub DoPrintReceipt()
        Dim FPrintPreview As New PrintPreviewCashReceipt

        Dim CRNewReceipt As New ReportNewClientReceipt
        CRNewReceipt.SetDataSource(TblNewReceipt)
        FPrintPreview.CrystalReportObject = CRNewReceipt

        FPrintPreview.IS_PRINT_NEWRECEIPT = True
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
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
    Private Sub cxbTypeA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cxbTypeA.CheckedChanged
        TxtReceiptAmmount.Text = FormatNumber(GetPriceSocialService(), 2)
    End Sub

    Private Sub cxbTypeB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cxbTypeB.CheckedChanged
        TxtReceiptAmmount.Text = FormatNumber(GetPriceSocialService(), 2)
    End Sub

    Private Sub cxbTypeC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cxbTypeC.CheckedChanged
        TxtReceiptAmmount.Text = FormatNumber(GetPriceSocialService(), 2)
    End Sub

    Private Sub BtnAddOccupation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddOccupation.Click
        Dim frmOccupation As New FrmNewOccupation
        If frmOccupation.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshOccupation()
        End If

    End Sub

    Private Sub BtnAddOccupation1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddOccupation1.Click
        Dim frmOccupation As New FrmNewOccupation
        If frmOccupation.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshOccupation()
        End If
    End Sub

    Private Sub BtnAddOccupation2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddOccupation2.Click
        Dim frmOccupation As New FrmNewOccupation
        If frmOccupation.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshOccupation()
        End If
    End Sub

    Private Sub BtnAddEducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddEducation.Click
        Dim frmEducation As New Education
        If frmEducation.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshEducation()
        End If
    End Sub

    Private Sub BtnAddEducation1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddEducation1.Click
        Dim frmEducation As New Education
        If frmEducation.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshEducation()
        End If
    End Sub

    Private Sub txtPatientNameKh_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatientNameKh.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub txtPatientNameEn_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatientNameEn.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub TxtOldIDCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOldIDCode.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub tbxFatherName_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxFatherName.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub tbxMotherName_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxMotherName.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub tbxPhone_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxPhone.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub tbxAddress_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxAddress.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub tbxStreet_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxStreet.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub txtFamOthers_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFamOthers.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub txtPreviousConstDetails_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPreviousConstDetails.Enter
        SetEnglishLanguage()
    End Sub

    Private Sub np_notes_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        SetKhmerLanguage()
    End Sub

    Private Sub pp_notes_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        SetKhmerLanguage()
    End Sub

    Private Sub dd_notes_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        SetKhmerLanguage()
    End Sub

    Private Sub txtPosition_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPosition.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged
        If getIsEdit = False Then
            Try
                Dim curDate As DateTime = Now
                Dim Dob As DateTime = dtpDOB.Value.Date
                Dim t As TimeSpan = curDate - Dob
                Dim diff As Integer = t.Days
                Dim months As Integer = Math.Floor(diff / 30.475)
                tbxAge.Text = Math.Round(months / 12)

            Catch ex As Exception
                tbxAge.Text = "0"
            End Try
            CallAgeWithMonth()
        End If
        


    End Sub

   


    Private Sub neuro_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles neuro_add.Click
        If cboNeuro.SelectedValue Is Nothing Then Exit Sub
        If cboNeuro.SelectedValue Is Nothing Then
            MessageBox.Show("Don't have neuro in list, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckExistingItem(cboNeuro.SelectedValue, GridNeuro) = True Then Exit Sub
        Dim Drow As DataRow = tblNeuro.NewRow
        Drow("SYMPTOM_NAME") = cboNeuro.Text
        Drow("DESCRIPTION") = np_notes.Text
        Drow("SYMPTOM_ID") = cboNeuro.SelectedValue
        tblNeuro.Rows.Add(Drow)
        GridNeuro.Refresh()
        GridNeuro.DataSource = tblNeuro
        np_notes.Text = ""
    End Sub
    Private Sub neuro_minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles neuro_minus.Click
        If GridNeuro.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove this symptom from Neurological Problem?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            tblNeuro.BeginLoadData()
            tblNeuro.Rows.RemoveAt(GridNeuro.Row)
            tblNeuro.EndLoadData()
            GridNeuro.Refresh()
            GridNeuro.DataSource = tblNeuro
        End If
    End Sub

    Private Sub btn_dd_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dd_add.Click
        If cboDevDisorder.SelectedValue Is Nothing Then Exit Sub
        If cboDevDisorder.SelectedValue Is Nothing Then
            MessageBox.Show("Don't have Disorder in list, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckExistingItem(cboDevDisorder.SelectedValue, GridDDisorder) = True Then Exit Sub
        Dim Drow As DataRow = tblDDisorder.NewRow
        Drow("SYMPTOM_NAME") = cboDevDisorder.Text
        Drow("DESCRIPTION") = dd_notes.Text
        Drow("SYMPTOM_ID") = cboDevDisorder.SelectedValue
        tblDDisorder.Rows.Add(Drow)
        GridDDisorder.Refresh()
        GridDDisorder.DataSource = tblDDisorder
        dd_notes.Text = ""
    End Sub
    Private Sub btn_dd_minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dd_minus.Click
        If GridDDisorder.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove this symptom from Developmental Disorder?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            tblDDisorder.BeginLoadData()
            tblDDisorder.Rows.RemoveAt(GridDDisorder.Row)
            tblDDisorder.EndLoadData()
            GridDDisorder.Refresh()
            GridDDisorder.DataSource = tblDDisorder
        End If
    End Sub

    Private Sub btn_psyminor_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_psyminor_add.Click
        If cboPsychoMinor.SelectedValue Is Nothing Then Exit Sub
        If cboPsychoMinor.SelectedValue Is Nothing Then
            MessageBox.Show("Don't have PsychoMinor in list, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckExistingItem(cboPsychoMinor.SelectedValue, GridPsychoMinor) = True Then Exit Sub

        Dim Drow As DataRow = tblPsychoMinor.NewRow
        Drow("SYMPTOM_NAME") = cboPsychoMinor.Text
        Drow("DESCRIPTION") = pp_minor_notes.Text
        Drow("SYMPTOM_ID") = cboPsychoMinor.SelectedValue
        tblPsychoMinor.Rows.Add(Drow)
        GridPsychoMinor.Refresh()
        GridPsychoMinor.DataSource = tblPsychoMinor
        pp_minor_notes.Text = ""
    End Sub
    Private Sub btn_psycho_minor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_psycho_minor.Click
        If GridPsychoMinor.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove this symptom from Psychological Problem?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            tblPsychoMinor.BeginLoadData()
            tblPsychoMinor.Rows.RemoveAt(GridPsychoMinor.Row)
            tblPsychoMinor.EndLoadData()
            GridPsychoMinor.Refresh()
            GridPsychoMinor.DataSource = tblPsychoMinor
        End If
    End Sub
    Function CheckExistingItem(ByVal ItemId As Integer, ByVal Grid As Janus.Windows.GridEX.GridEX) As Boolean
        For Each row As Janus.Windows.GridEX.GridEXRow In Grid.GetRows
            If row.Cells("SYMPTOM_ID").Value = ItemId Then
                Return True
                Exit Function
                'Else
                '    Return False
            End If
        Next
    End Function

    Private Sub np_notes_Enter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles np_notes.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub dd_notes_Enter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dd_notes.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub pp_minor_notes_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pp_minor_notes.Enter
        SetKhmerLanguage()
    End Sub

    Private Sub pp_major_notes_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pp_major_notes.Enter
        SetKhmerLanguage()
    End Sub


    Private Sub btn_psymajor_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_psymajor_add.Click
        If cboPsychoMajor.SelectedValue Is Nothing Then Exit Sub
      
        If CheckExistingItem(cboPsychoMajor.SelectedValue, GridPsychoMajor) = True Then Exit Sub

        Dim Drow As DataRow = tblPsychoMajor.NewRow
        Drow("SYMPTOM_NAME") = cboPsychoMajor.Text
        Drow("DESCRIPTION") = pp_major_notes.Text
        Drow("SYMPTOM_ID") = cboPsychoMajor.SelectedValue
        tblPsychoMajor.Rows.Add(Drow)
        GridPsychoMajor.Refresh()
        GridPsychoMajor.DataSource = tblPsychoMajor
        pp_major_notes.Text = ""
    End Sub

    Private Sub btn_psymajor_minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_psymajor_minus.Click
        If GridPsychoMajor.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove this symptom from Psychological Problem?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            tblPsychoMajor.BeginLoadData()
            tblPsychoMajor.Rows.RemoveAt(GridPsychoMajor.Row)
            tblPsychoMajor.EndLoadData()
            GridPsychoMajor.Refresh()
            GridPsychoMajor.DataSource = tblPsychoMajor
        End If
    End Sub


    Private Sub btnNeuro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeuro.Click
        Dim frmNeuro As New FrmNeuro
        If frmNeuro.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshImpression()
        End If
    End Sub

    Private Sub btnDDisorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDDisorder.Click
        Dim frmDisorder As New FrmDDisorder
        If frmDisorder.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshImpression()
        End If
    End Sub

    Private Sub btnPsyMinor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPsyMinor.Click
        Dim frmPsyMinor As New FrmPsyMinor
        If frmPsyMinor.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshImpression()
        End If
    End Sub

    Private Sub btnPsyMajor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPsyMajor.Click
        Dim frmPsyMajor As New FrmPsyMajor
        If frmPsyMajor.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshImpression()
        End If
    End Sub


    Private Sub dtpDOB_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDOB.KeyUp
        Try
            tbxAge.Text = (Now.Year - dtpDOB.Value.Year)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAddProvince_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProvince.Click
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


    Private Sub BtnaddDistrict_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnaddDistrict.Click
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

    Private Sub BtnAddVillage_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddVillage.Click
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

    Private Sub cbxDistrict_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDistrict.DropDown
        If ValidateCombobox(cbxProvince, "", ErrClientRegis) = False Then
            cbxDistrict.SelectedIndex = -1
            Exit Sub
        End If


    End Sub

    Private Sub cbxCommune_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCommune.DropDown
        If ValidateCombobox(cbxDistrict, "", ErrClientRegis) = False Then
            cbxCommune.SelectedIndex = -1
            Exit Sub
        End If

    End Sub

    Private Sub cbxVillage_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxVillage.DropDown
        If ValidateCombobox(cbxCommune, "", ErrClientRegis) = False Then
            cbxVillage.SelectedIndex = -1
            Exit Sub
        End If

    End Sub

    Private Sub BtnAddMoreReferedBy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMoreReferedBy.Click
        Dim MainReBy As New MainReferedBy
        If MainReBy.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ReferedBy()
        End If
    End Sub



    Public Function CheckExistingData(ByVal ValueRow As String, ByVal ColumIndex As String, ByVal DTable As DataTable) As Boolean

        For Each DRow As DataRow In DTable.Rows
            If DRow(ColumIndex) = ValueRow Then
                Return True
                Exit Function
            End If
        Next

    End Function
    Private Sub AddToDataGrideJanus(ByVal DTableObject As DataTable, ByVal DRow As DataRow, ByVal GrideJanus As GridEX)
        DTableObject.Rows.Add(DRow)
        Application.DoEvents()
        GrideJanus.Refetch()
        GrideJanus.DataSource = DTableObject
        GrideJanus.Refresh()
    End Sub

    Private Sub BtnAddRefered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddRefered.Click
        If ValidateCombobox(CboReferedby, "", ErrClientRegis) = False Then Exit Sub
        If CboReferedby.SelectedValue Is Nothing Then
            MessageBox.Show("Don't have Refered in list, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim DrowRefered As DataRow = Table_Refered.NewRow
        DrowRefered("CLIENT_NO") = TxtClientNo.Text
        DrowRefered("REFERED_TYPE") = CboReferedby.SelectedValue
        DrowRefered("REFERED_FROM") = CboReferedby.Text
        DrowRefered("REFFERED_NOTE") = TxtReferNote.Text
        If CheckExistingData(CboReferedby.Text, "REFERED_FROM", Table_Refered) = True Then
            MessageBox.Show("The refered by already exist in list?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddToDataGrideJanus(Table_Refered, DrowRefered, Me.GridReferedBy)
            'RefreshDataGrideJanus(Me.GridInvestigate, Table_InvestigateRequest)
            CboReferedby.SelectedIndex = -1
            TxtReferNote.Text = ""
        End If
    End Sub

    Private Sub BtnSubRefered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubRefered.Click
        If GridReferedBy.SelectedItems.Count = 0 Then Exit Sub
        RemoveDataFromGridJanus("REFERED_FROM", Me.GridReferedBy.GetRow.Cells("REFERED_FROM").Value, Table_Refered, Me.GridReferedBy)
    End Sub
    Public Sub RemoveDataFromGridJanus(ByVal columName As String, ByVal value As String, ByVal DTable As DataTable, ByVal JanusGrid As GridEX)

        Dim iterateIndex As Integer = 0
        Dim newDataTable As DataTable = DTable.Copy
        For Each row As DataRow In newDataTable.Rows
            If row(columName) = value Then
                DTable.Rows.RemoveAt(iterateIndex)
            Else
                iterateIndex += 1
            End If
        Next

        Application.DoEvents()
        JanusGrid.Refetch()
        JanusGrid.DataSource = DTable

    End Sub

    Private Sub CboAdviseAssessment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboAdviseAssessment.SelectedIndexChanged
        If CboAdviseAssessment.Text = "Normal" Then
            DateAssessDate.Enabled = False
            TxtAdviseAssessmentNote.Enabled = False
            ChDoDetailAssesst.Checked = False
        Else
            If CboAdviseAssessment.Text = "Immediate" Then
                ChDoDetailAssesst.Checked = True
            End If
            DateAssessDate.Enabled = True
            TxtAdviseAssessmentNote.Enabled = True
        End If
    End Sub

    Private Sub BtnAddMoreRelativeCome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMoreRelativeCome.Click
        Dim FamilyCome As New FormCome
        If FamilyCome.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RelativeCome()
        End If
    End Sub

    Private Sub BtnAddRelativeCome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddRelativeCome.Click
        If ValidateCombobox(CboRelativeCome, "", ErrClientRegis) = False Then Exit Sub
        If CboRelativeCome.SelectedValue Is Nothing Then
            MessageBox.Show("Don't have relative in list, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim DrowRelative As DataRow = Table_Relative_come_detail.NewRow
        DrowRelative("CLIENT_NO") = TxtClientNo.Text
        DrowRelative("COME_TYPE") = CboRelativeCome.SelectedValue
        DrowRelative("COME_WITH") = CboRelativeCome.Text
        DrowRelative("COME_WITH_NOTE") = TxtRelativeComeNote.Text
        If CheckExistingData(CboRelativeCome.Text, "COME_WITH", Table_Relative_come_detail) = True Then
            MessageBox.Show("The refered by already exist in list?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddToDataGrideJanus(Table_Relative_come_detail, DrowRelative, Me.GridRelativeCome)
            'RefreshDataGrideJanus(Me.GridInvestigate, Table_InvestigateRequest)
            CboRelativeCome.SelectedIndex = -1
            TxtRelativeComeNote.Text = ""
        End If
    End Sub

    Private Sub BtnRemoveRelativeCome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveRelativeCome.Click
        If GridRelativeCome.SelectedItems.Count = 0 Then Exit Sub
        RemoveDataFromGridJanus("COME_WITH", Me.GridRelativeCome.GetRow.Cells("COME_WITH").Value, Table_Relative_come_detail, Me.GridRelativeCome)
    End Sub
    Private Sub CallAgeWithMonth()
        Dim yr As Integer = DateDiff(DateInterval.Year, dtpDOB.Value, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, dtpDOB.Value, Now) Mod 12
        Dim day As Integer = DateDiff(DateInterval.Day, dtpDOB.Value, Now) Mod 30 - 10

        TxtAgeWithMonth.Text = EmptyString(yr) & "Y/" & month & "M"
    End Sub
    
    
   
    Private Sub rbtnC_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnC.CheckedChanged
        CallAgeWithMonth()
    End Sub

    Private Sub rbtnE_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnE.CheckedChanged
        CallAgeWithMonth()
    End Sub
End Class