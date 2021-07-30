Public Class FormCaseMonitoring
    Dim DA_CasMonitoring As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_CASE_MONITORINGTableAdapter
    Dim DA_THERPIST As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_ReferedBy As New DSReferedTableAdapters.CCAMH_REFERED_BY_ORGTableAdapter
    Dim DA_Prescription As New DSCaseMonitoringTableAdapters.CCAMH_VIEW_PRESCRIPTIONTableAdapter
    Dim DA_ReferByClientDetail As New DSCaseMonitoringTableAdapters.CCAMH_REFERED_DETIALTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        IntParaTherapists()
    End Sub
    Private Sub IntParaTherapists()
        With CboFacilater
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
        With CboTherapy
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
        With CboReferByNGO
            .DataSource = DA_ReferedBy.GetData
            .ValueMember = "refer_by_category"
            .DisplayMember = "REFER_BY"
            .SelectedIndex = -1
        End With
        With CboReferBySchool
            .DataSource = DA_ReferedBy.GetData
            .ValueMember = "refer_by_category"
            .DisplayMember = "REFER_BY"
            .SelectedIndex = -1
        End With
        With CboSeenByOther
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Public Sub InitLoadingMedicine(ByVal ClientNo As Double, ByVal DatePres As Date)
        Dim DrName As String = ""
        Dim MedicineName As String = ""

        For Each DRow In DA_Prescription.SelectMedicineByClientNo(ClientNo, DatePres)
            DrName = DRow("DOCTOR_NAME")
            MedicineName = MedicineName & " " & DRow("MED_NAME")
        Next
        'Me.CboFacilater.Text = DrName
        Me.TxtTherapyDrug.Text = MedicineName

    End Sub
    Public Sub InitLoadReferBy(ByVal ClientNo As Double)
        Dim Refer As String
        For Each Drow In DA_ReferByClientDetail.SelectReferDetailByClientNo(ClientNo)
            Refer = Refer & " " & Drow("REFERED_FROM")
        Next
        Me.TxtReferBy.Text = Refer
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrMonitoring) = False Then Exit Sub
        If ValidateTextField(TxtClientNameEng, "", ErrMonitoring) = False Then Exit Sub
        If ValidateCombobox(CboFacilater, "", ErrMonitoring) = False Then Exit Sub
        If ValidateCombobox(CboNotedBy, "", ErrMonitoring) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new case monitoring?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_CasMonitoring.InsertNewCaseMonitoring(LblMonitoringID.Text, TxtClientNo.Text, CboFacilater.Text, CboNotedBy.Text, TxtTherapyDrug.Text, ChTherapyCounseling.Checked, ChTherapyABT.Checked, ChTherapySpcialNeed.Checked, CboTherapy.Text, ChSeenBySelf.Checked, CboSeenByOther.Text, CboReferByNGO.Text, CboReferBySchool.Text, TxtReferBy.Text, TxtRemark.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to save new case monitoring?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_CasMonitoring.UpdateMonitoringCase(CboFacilater.Text, CboNotedBy.Text, TxtTherapyDrug.Text, ChTherapyCounseling.Checked, ChTherapyABT.Checked, ChTherapySpcialNeed.Checked, CboTherapy.Text, ChSeenBySelf.Checked, CboSeenByOther.Text, CboReferByNGO.Text, CboReferBySchool.Text, TxtReferBy.Text, TxtRemark.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub FormCaseMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboNotedBy.Text = USER_NAME
    End Sub
End Class