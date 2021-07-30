Public Class FormCaseDropOut
    Dim DashAppointment As DashboardAppointment
    Dim DA_ClientInfo As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_VIEW_ADVISED_CLIENTSTableAdapter
    Dim DA_EDU As New DS_CCAMH_THERAPISTSTableAdapters.tblEducationTableAdapter
    Dim DA_OCU As New DS_CCAMH_THERAPISTSTableAdapters.TblOccupationTableAdapter
    Dim DA_ClientMg As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim DA_CaseStopOrDropOut As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_OUTCOME_PROFILETableAdapter
    Dim DA_Prescription As New DSCaseMonitoringTableAdapters.CCAMH_VIEW_PRESCRIPTIONTableAdapter
    Dim DA_Reffered As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_REFERED_DETIALTableAdapter
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'InitClientInfo(0)
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New(DashAppointment As DashboardAppointment)

        ' This call is required by the designer.
        InitializeComponent()
        Me.DashAppointment = DashAppointment
        ' InitClientInfo(0)
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Function GetLastVisit(ClientNo As Double) As Date
        Dim LastVisit As Date
        For Each drows As DataRow In DA_ClientMg.SelectClientLastVisit(ClientNo).Rows
            LastVisit = CDate(drows("DATE_CREATE"))
        Next
        Return LastVisit.Date
    End Function
    Public Sub InitLoadingMedicine(ByVal ClientNo As Double)
        Dim DrName As String = ""
        Dim MedicineName As String = ""

        For Each DRow In DA_Prescription.SelectAllMedicineByClientNo(ClientNo)
            DrName = DRow("DOCTOR_NAME")
            MedicineName = MedicineName & " " & DRow("MED_NAME")
        Next
        Me.TxtClientDrug.Text = MedicineName
    End Sub
    Public Sub LoadCaseAudit(ClientNo As Double)
        For Each Drow As DataRow In DA_CaseStopOrDropOut.SelectCaseAuditbyClientNo(ClientNo).Rows
            LblSaveOption.Text = Drow("OUTCOME_ID")
            ChPoor.Checked = Drow("DROP_OUT_POOR")
            ChLongDistance.Checked = Drow("DROP_OUT_LONG_DISTANCE")
            ChNotKNow.Checked = Drow("DROP_OUT_NOT_KNOW")
            RadDropOut.Checked = Drow("CASE_DROP_OUT")
            RadStopVisit.Checked = Drow("STOP_VISIT")
            ChRespite.Checked = Drow("STOP_VISIT_RESPITE")
            ChTreatmentCompleted.Checked = Drow("STOP_VISIT_TREATMENT_COMPLETE")
            ChBackToSchool.Checked = Drow("STOP_VISIT_BACK_TO_SCHOOL")
            ChReferTo.Checked = Drow("STOP_VISIT_REFER_TO")
            DateDropOut.Checked = True
            DateDropOut.Value = Drow("DATE_CREATE_OUTCOME")
            TxtReponeTherapy.Text = IIf(IsDBNull(Drow("RESPONE_TO_THERAPIST")), "", Drow("RESPONE_TO_THERAPIST"))
            TxtDropOutRemark.Text = Drow("OUTCOME_REMARK")
        Next
    End Sub
    Public Sub InitClientInfo(ClientNo As Double)
        If DA_ClientInfo.SelectClientInformation(ClientNo).Rows.Count > 0 Then
            For Each drows As DataRow In DA_ClientInfo.SelectClientInformation(ClientNo).Rows
                Me.TxtClientNo.Text = drows("CLIENT_NO")
                Me.TxtClientNameKh.Text = drows("CLIENT_NAME_KHM")
                Me.TxtClientNameEng.Text = drows("CLIENT_NAME")
                Me.TxtClientAge.Text = drows("CAL_AGE")
                Me.TxtClientSex.Text = drows("CLIENT_SEX")
                Me.DateClientRegister.Value = drows("CLIENT_DATE_REG")
                Me.TxtClientNoOfSibling.Text = IIf(IsDBNull(drows("CLIENT_SIBLING")), "", drows("CLIENT_SIBLING"))
                TxtClientOrderOfTheirSibling.Text = IIf(IsDBNull(drows("CLIENT_POSITION")), "", drows("CLIENT_SIBLING"))
                '   TxtClientClassGrad.Text = drows("")
                TxtClientLastVisit.Text = Format(GetLastVisit(CDbl(TxtClientNo.Text)), "dd/MM/yyyy")
                TxtClientFatherOccupation.Text = DA_OCU.SelectOccupation(IIf(IsDBNull(drows("CLIENT_FATHER_OCCUPATION")), 0, drows("CLIENT_FATHER_OCCUPATION")))
                TxtClientFatherEducation.Text = DA_EDU.SelectEducation(IIf(IsDBNull(drows("CLIENT_FATHER_EDUCATION")), 0, drows("CLIENT_FATHER_EDUCATION")))
                TxtClientMotherOccupation.Text = DA_OCU.SelectOccupation(IIf(IsDBNull(drows("CLIENT_MOTHER_OCCUPATION")), 0, drows("CLIENT_MOTHER_OCCUPATION")))
                TxtClientMotherEducation.Text = DA_EDU.SelectEducation(IIf(IsDBNull(drows("CLIENT_MOTHER_EDUCATION")), 0, drows("CLIENT_MOTHER_EDUCATION")))
                TxtClientAddress.Text = drows("PROV_EN")
                TxtClientTelephone.Text = drows("CLIENT_ADDRESS_PHONE")
                TxtClientLiveWithWhom.Text = "Family" 'drows("")
                TxtClientDiagnosis.Text = IIf(IsDBNull(drows("DIAGNOSIS")), "", drows("DIAGNOSIS"))
                TxtClientNoOfVisit.Text = drows("NUMBER_VISIT")
                TxtClientTherapistName.Text = IIf(IsDBNull(drows("MAIN_THERAPY_NAME")), "", drows("MAIN_THERAPY_NAME"))
                ' TxtClientDrug.Text = drows("")
                'TxtReponeTherapy.Text = drows("")
            Next
            InitLoadingMedicine(ClientNo)
            For Each drowReffer As DataRow In DA_Reffered.SelectClientRefferedByClientNo(ClientNo).Rows
                RerferedBy = RerferedBy & drowReffer("REFERED_FROM") & " "
            Next
            TxtClientReferBy.Text = RerferedBy
        Else

            Me.TxtClientNo.Text = ""
            Me.TxtClientNameKh.Text = ""
            Me.TxtClientNameEng.Text = ""
            Me.TxtClientAge.Text = ""
            Me.TxtClientSex.Text = ""
            Me.DateClientRegister.Value = ""
            Me.TxtClientNoOfSibling.Text = ""
            TxtClientOrderOfTheirSibling.Text = ""
            '   TxtClientClassGrad.Text = drows("")
            TxtClientLastVisit.Text = ""
            TxtClientFatherOccupation.Text = ""
            TxtClientFatherEducation.Text = ""
            TxtClientMotherOccupation.Text = ""
            TxtClientMotherEducation.Text = ""
            TxtClientAddress.Text = ""
            TxtClientTelephone.Text = ""
            TxtClientLiveWithWhom.Text = "Family" 'drows("")
            TxtClientDiagnosis.Text = ""
            TxtClientNoOfVisit.Text = ""
            TxtClientTherapistName.Text = ""
            ' TxtClientDrug.Text = drows("")
            'TxtReponeTherapy.Text = drows("")

            TxtClientReferBy.Text = ""
            Me.TxtClientDrug.Text = ""
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If LblSaveOption.Text = "0" Then
            'MessageBox.Show(DateDropOut.Value.Date)
            If ValidateTextField(TxtClientNo, "", ErrorProvider1) = False Then Exit Sub
            If ValidateTextField(TxtClientNameEng, "", ErrorProvider1) = False Then Exit Sub
            If ValidateTextField(TxtClientNameKh, "", ErrorProvider1) = False Then Exit Sub
            If ValidateDateField(DateDropOut, "", ErrorProvider1) = False Then Exit Sub
            If RadDropOut.Checked = True Then
                If DA_CaseStopOrDropOut.CheckExisterDropOut(TxtClientNo.Text) > 0 Then
                    MessageBox.Show("The client already record to case audit. Noted as case drop out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
           
            If MessageBox.Show("Do you want to save case drop-out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_CaseStopOrDropOut.InsertNewClientAuditDropOut_StopVisit(DateDropOut.Value.Date, TxtClientNo.Text, TxtClientNameKh.Text, _
                                                                    TxtClientNameEng.Text, TxtClientAge.Text, TxtClientSex.Text, TxtClientReferBy.Text, DateClientRegister.Value.Date, _
                                                                    TxtClientNoOfSibling.Text, EmptyString(TxtClientOrderOfTheirSibling.Text), TxtClientClassGrad.Text, _
                                                                    TxtClientFatherOccupation.Text, TxtClientMotherOccupation.Text, TxtClientFatherEducation.Text, _
                                                                    TxtClientMotherEducation.Text, TxtClientAddress.Text, TxtClientTelephone.Text, _
                                                                    TxtClientLiveWithWhom.Text, TxtClientDiagnosis.Text, TxtClientDrug.Text, _
                                                                    EmptyString(TxtClientNoOfVisit.Text), TxtClientTherapistName.Text, GetLastVisit(CDbl(TxtClientNo.Text)), _
                                                                    ChPoor.Checked, ChLongDistance.Checked, ChNotKNow.Checked, RadDropOut.Checked, _
                                                                    ChRespite.Checked, ChTreatmentCompleted.Checked, ChBackToSchool.Checked, ChReferTo.Checked, RadStopVisit.Checked, TxtDropOutRemark.Text, TxtReponeTherapy.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save case drop-out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update case drop-out?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_CaseStopOrDropOut.UpdateOutComeProfile(DateDropOut.Value.Date, ChPoor.Checked, ChLongDistance.Checked, ChNotKNow.Checked, RadDropOut.Checked, _
                                                   ChRespite.Checked, ChTreatmentCompleted.Checked, ChBackToSchool.Checked, ChReferTo.Checked, _
                                                   RadStopVisit.Checked, TxtDropOutRemark.Text, TxtReponeTherapy.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save case drop-out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub RadDropOut_CheckedChanged(sender As Object, e As EventArgs) Handles RadDropOut.CheckedChanged
        GroupDropOut.Enabled = RadDropOut.Checked
        ChRespite.Checked = False
        ChTreatmentCompleted.Checked = False
        ChBackToSchool.Checked = False
        ChReferTo.Checked = False

    End Sub

    
    Private Sub RadStopVisit_CheckedChanged(sender As Object, e As EventArgs) Handles RadStopVisit.CheckedChanged
        GroupStopVisit.Enabled = RadStopVisit.Checked
        ChPoor.Checked = False
        ChLongDistance.Checked = False
        ChNotKNow.Checked = False
    End Sub

    Private Sub TxtClientLastVisit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClientLastVisit.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtClientNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFindClient_Click(sender As Object, e As EventArgs) Handles BtnFindClient.Click
        InitClientInfo(EmptyString(TxtClientNo.Text))
    End Sub
End Class