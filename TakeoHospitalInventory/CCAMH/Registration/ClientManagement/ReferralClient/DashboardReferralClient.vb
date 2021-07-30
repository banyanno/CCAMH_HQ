Public Class DashboardReferralClient
    Dim DA_Refer As New DS_CCAMH_REFERTableAdapters.CCAMH_REFERTableAdapter
    Dim DA_Refer_Detail As New DS_CCAMH_REFERTableAdapters.CCAMH_REFER_DETAILTableAdapter
    Dim DA_VRefer_Detail As New DS_CCAMH_REFERTableAdapters.CCAMH_VIEW_REFER_DETAILTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitPara()
    End Sub
    Private Sub InitPara()
        With CboSearchReferral
            .DataSource = DA_Refer.GetData
            .ValueMember = "REFER_TO_ID"
            .DisplayMember = "REFER"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnNewRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewRefer.Click
        Dim FNewRefer As New FormRefer
        If FNewRefer.ShowDialog = DialogResult.OK Then
            RefreshRefer()
        End If
    End Sub
    Private Sub ViewDetailRefer()
        If GridClientReferDetail.SelectedItems.Count = 0 Then Exit Sub
        TxtReferTo.Text = GridClientReferDetail.GetRow.Cells("REFER").Text
        TxtClientName.Text = GridClientReferDetail.GetRow.Cells("CLIENT_NAME_KHM").Text
        TxtDateRefer.Text = GridClientReferDetail.GetRow.Cells("REFER_DATE").Text
        TxtReferNote.Text = GridClientReferDetail.GetRow.Cells("REFER_NOTE").Value
    End Sub
    Private Sub RefreshReferDetailBy(ByVal ReferID As Double)
        GridClientReferDetail.DataSource = DA_Refer_Detail.SelectReferByID(ReferID)
    End Sub
    Private Sub RefreshRefer()
        GridListOfRefer.DataSource = DA_Refer.GetData
    End Sub

    Private Sub BtnNewReferTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReferTo.Click
        If GridListOfRefer.SelectedItems.Count = 0 Then Exit Sub
        Dim FReferTo As New FormReferDetail
        FReferTo.TxtClientNo.ReadOnly = False
        FReferTo.BtnFinClient.Visible = True
        'FReferTo.LblSaveOption.Text = GridClientReferDetail.GetRow.Cells("REFER_TO_DETAIL_ID").Value
        'FReferTo.TxtClientNo.Text = GridListOfRefer.GetRow.Cells("CLIENT_NO").Value
        'FReferTo.TxtClientNameEng.Text = GridListOfRefer.GetRow.Cells("CLIENT_NAME").Value
        'FReferTo.TxtClientSex.Text = GridListOfRefer.GetRow.Cells("CLIENT_SEX").Value
        'FReferTo.TxtClientAge.Text = GridListOfRefer.GetRow.Cells("CLIENT_AGE").Value
        'FReferTo.CboRefer.SelectedValue = GridClientReferDetail.GetRow.Cells("REFER_TO_ID").Value
        'FReferTo.DateRefer.Checked = True
        'FReferTo.DateRefer.Value = GridClientReferDetail.GetRow.Cells("REFER_DATE").Value
        'FReferTo.TxtReferToMoreInfo.Text = GridClientReferDetail.GetRow.Cells("REFER_NOTE").Value
        If FReferTo.ShowDialog = DialogResult.OK Then
            GridClientReferDetail.DataSource = DA_VRefer_Detail.SelectByReferID(FReferTo.CboRefer.SelectedValue)
        End If
    End Sub

    Private Sub GridListOfRefer_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridListOfRefer.RowDoubleClick
        Dim FRefer As New FormRefer
        FRefer.lblSaveOption.Text = GridListOfRefer.GetRow.Cells("REFER_TO_ID").Value
        FRefer.TxtRefer.Text = GridListOfRefer.GetRow.Cells("REFER").Value
        FRefer.TxtReferNote.Text = GridListOfRefer.GetRow.Cells("REFER_NOTE").Value
        If FRefer.ShowDialog = DialogResult.OK Then
            RefreshRefer()
        End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If RadClientNo.Checked = True Then
            GridClientReferDetail.DataSource = DA_VRefer_Detail.SelectReferByClientNo(EmptyString(TxtSearchClientNo.Text))
        ElseIf RadDateReferTo.Checked = True Then
            GridClientReferDetail.DataSource = DA_VRefer_Detail.SelectReferDateToDate(DateSearchReferFrom.Value.Date, DateSearchReferTo.Value.Date)
        ElseIf RadClientName.Checked = True Then
            GridClientReferDetail.DataSource = DA_VRefer_Detail.SelectReferByClientName(TxtSearchClientName.Text)
        ElseIf RadRefer.Checked = True Then
            GridClientReferDetail.DataSource = DA_VRefer_Detail.SelectByReferID(CboSearchReferral.SelectedValue)
        End If
    End Sub

    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtSearchClientNo.Focus()
        TxtSearchClientNo.Select()
        TxtSearchClientNo.Enabled = RadClientNo.Checked
    End Sub

    Private Sub TxtSearchClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSearchClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientName.CheckedChanged
        TxtSearchClientName.Enabled = RadClientName.Checked
        TxtSearchClientName.Select()
        TxtSearchClientName.Focus()
    End Sub

    Private Sub RadRefer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadRefer.CheckedChanged
        CboSearchReferral.Enabled = RadRefer.Checked
        CboSearchReferral.Focus()
        CboSearchReferral.Select()
    End Sub

    Private Sub GridListOfRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridListOfRefer.Click
        If GridListOfRefer.SelectedItems.Count = 0 Then Exit Sub
        GridClientReferDetail.DataSource = DA_VRefer_Detail.SelectByReferID(GridListOfRefer.GetRow.Cells("REFER_TO_ID").Value)
    End Sub

    Private Sub GridClientReferDetail_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridClientReferDetail.SelectionChanged
        ViewDetailRefer()
    End Sub

    Private Sub DashboardReferralClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshRefer()
        BtnFind_Click(sender, e)
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshRefer()
    End Sub

    Private Sub GridClientReferDetail_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridClientReferDetail.RowDoubleClick
        If GridListOfRefer.SelectedItems.Count = 0 Then Exit Sub
        Dim FReferTo As New FormReferDetail
        FReferTo.LblSaveOption.Text = GridClientReferDetail.GetRow.Cells("REFER_TO_DETAIL_ID").Value
        FReferTo.TxtClientNo.Text = GridClientReferDetail.GetRow.Cells("CLIENT_NO").Value
        FReferTo.TxtClientNameKH.Text = GridClientReferDetail.GetRow.Cells("CLIENT_NAME_KHM").Value
        FReferTo.TxtClientNameEng.Text = GridClientReferDetail.GetRow.Cells("CLIENT_NAME").Value
        FReferTo.TxtClientSex.Text = GridClientReferDetail.GetRow.Cells("CLIENT_SEX").Value
        FReferTo.TxtClientAge.Text = GridClientReferDetail.GetRow.Cells("CLIENT_AGE").Value
        FReferTo.CboRefer.SelectedValue = GridClientReferDetail.GetRow.Cells("REFER_TO_ID").Value
        FReferTo.DateRefer.Checked = True
        FReferTo.DateRefer.Value = GridClientReferDetail.GetRow.Cells("REFER_DATE").Value
        FReferTo.TxtReferToMoreInfo.Text = GridClientReferDetail.GetRow.Cells("REFER_NOTE").Value
        If FReferTo.ShowDialog = DialogResult.OK Then
            GridClientReferDetail.DataSource = DA_VRefer_Detail.SelectByReferID(FReferTo.CboRefer.SelectedValue)
        End If
    End Sub

    Private Sub BtnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReport.Click
        ' If GridListOfRefer.SelectedItems.Count = 0 Then Exit Sub ' Is Nothing Then Exit Sub
        Dim FPrintPreview As New RegisPrintPreview
        Dim CrReferral As New ReportReferral
        Dim TbleReferral As DataTable = DA_VRefer_Detail.SelectReferallByIDDateToDate(CboSearchReferral.SelectedValue, DateSearchReferFrom.Value.Date, DateSearchReferTo.Value.Date)
        CrReferral.SetDataSource(TbleReferral)
        CrReferral.SetParameterValue("Title", "LIST OF REFERRAL AGENCY-" & CboSearchReferral.Text)
        CrReferral.SetParameterValue("Date", "From " & Format(DateSearchReferFrom.Value.Date, "dd/MM/yyyy") & " To " & Format(DateSearchReferTo.Value.Date, "dd/MM/yyyy"))
        FPrintPreview.CrystalReportObject = CrReferral
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
    End Sub
End Class
