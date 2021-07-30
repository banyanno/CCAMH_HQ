Public Class FormReferDetail

    Dim DA_Refer As New DS_CCAMH_REFERTableAdapters.CCAMH_REFERTableAdapter
    Dim DA_Refer_Detail As New DS_CCAMH_REFERTableAdapters.CCAMH_REFER_DETAILTableAdapter
    Dim DA_View_ClientMG As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_VIEW_CLIENT_MANAGERMANT_V1TableAdapter
    Dim DA_THERPIST As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_Diagnosis As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_DIAGNOSISTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitPara()
    End Sub
    Private Sub InitPara()
        With CboRefer
            .DataSource = DA_Refer.GetData
            .ValueMember = "REFER_TO_ID"
            .DisplayMember = "REFER"
            .SelectedIndex = -1
        End With
        With CboTherapy
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
        With CboDiagnosis
            .DataSource = DA_Diagnosis.GetData
            .ValueMember = "diag_cat_id"
            .DisplayMember = "diagnosis"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(TxtClientNo, "", ErrReferTo) = False Then Exit Sub
        If ValidateCombobox(CboRefer, "", ErrReferTo) = False Then Exit Sub
        If ValidateDateField(DateRefer, "", ErrReferTo) = False Then Exit Sub
        If CboRefer.SelectedValue Is Nothing Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Refer_Detail.InsertNewReferDetail(CboRefer.SelectedValue, EmptyString(TxtClientNo.Text), DateRefer.Value.Date, TxtReferToMoreInfo.Text, 0, IIf(DateNextVisit.Checked = False, Nothing, DateNextVisit.Value.Date), CboTherapy.Text, CboDiagnosis.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Refer_Detail.UpdateReferDetail(CboRefer.SelectedValue, EmptyString(TxtClientNo.Text), DateRefer.Value.Date, TxtReferToMoreInfo.Text, 0, IIf(DateNextVisit.Checked = False, Nothing, DateNextVisit.Value.Date), CboTherapy.Text, CboDiagnosis.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnAddMoreRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMoreRefer.Click
        Dim FRefer As New FormRefer
        If FRefer.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            InitPara()
        End If
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFinClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFinClient.Click
        For Each Drow As DataRow In DA_View_ClientMG.SelectNewOrOldByClientNo(0, EmptyString(TxtClientNo.Text)).Rows
            TxtClientNameEng.Text = Drow("CLIENT_NAME")
            TxtClientNameKH.Text = Drow("CLIENT_NAME_KHM")
            TxtClientAge.Text = Drow("CLIENT_AGE")
            TxtClientSex.Text = Drow("CLIENT_SEX")
        Next
    End Sub
End Class