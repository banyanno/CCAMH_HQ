Public Class UIFastTrackMainDashboard

    Dim DA_TrackingDetail As New DSFastTrackTableAdapters.CCAMH_VIEW_TRACKINGTableAdapter
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
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FFastTracking As New FormFastTracking
        If FFastTracking.ShowDialog = DialogResult.OK Then
            Me.RadClientNo.Checked = True
            Me.TxtSearchClientNo.Text = FFastTracking.TxtClientNo.Text
            FindClientTracking()
        End If
    End Sub
    Private Sub FindClientTracking()
        If RadViewAllFastTracking.Checked = True Then
            GridClientFastTrackingDetail.DataSource = DA_TrackingDetail.GetData
        ElseIf RadClientNo.Checked = True Then
            GridClientFastTrackingDetail.DataSource = DA_TrackingDetail.SelectTrackingByClientNo(EmptyString(TxtSearchClientNo.Text))
        ElseIf RadClientName.Checked = True Then
            GridClientFastTrackingDetail.DataSource = DA_TrackingDetail.SelectTrackingByName(TxtClientName.Text)
        ElseIf RadTherapy.Checked = True Then
            GridClientFastTrackingDetail.DataSource = DA_TrackingDetail.SelectTrackingByName(CboTherapy.Text)
        End If
    End Sub
    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtSearchClientNo.Enabled = RadClientNo.Checked
        TxtSearchClientNo.Select()
        TxtSearchClientNo.Focus()
        TxtSearchClientNo.SelectAll()
    End Sub

    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientName.CheckedChanged
        TxtSearchClientName.Enabled = RadClientName.Checked
        TxtSearchClientName.Focus()
        TxtSearchClientName.Select()
        TxtSearchClientName.SelectAll()
    End Sub

    Private Sub RadTherapy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadTherapy.CheckedChanged
        CboTherapy.Enabled = RadTherapy.Checked
        CboTherapy.Focus()
        CboTherapy.Select()
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindClientTracking()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FindClientTracking()
    End Sub

    Private Sub UIFastTrackMainDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FindClientTracking()
    End Sub

    Private Sub GridClientFastTrackingDetail_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridClientFastTrackingDetail.RowDoubleClick
        Dim FFastTracking As New FormFastTracking
        FFastTracking.LblSaveOption.Text = GridClientFastTrackingDetail.GetRow.Cells("FAST_TRACK_ID").Value
        FFastTracking.BtnFindClient.Visible = False
        FFastTracking.TxtClientNo.ReadOnly = True

        FFastTracking.TxtClientNo.Text = GridClientFastTrackingDetail.GetRow.Cells("CLIENT_NO").Value
        FFastTracking.TxtClientNameKH.Text = GridClientFastTrackingDetail.GetRow.Cells("CLIENT_NAME_KHM").Value
        FFastTracking.TxtClientNameEng.Text = GridClientFastTrackingDetail.GetRow.Cells("CLIENT_NAME").Value
        FFastTracking.TxtClientSex.Text = GridClientFastTrackingDetail.GetRow.Cells("CLIENT_SEX").Value
        FFastTracking.TxtClientAge.Text = GridClientFastTrackingDetail.GetRow.Cells("CAL_AGE").Value
        FFastTracking.TxtClientDateDOR.Text = GridClientFastTrackingDetail.GetRow.Cells("CLIENT_DATE_REG").Text
        FFastTracking.TxtClientContact.Text = GridClientFastTrackingDetail.GetRow.Cells("CLIENT_ADDRESS_PHONE").Value
        FFastTracking.TxtClientAddress.Text = GridClientFastTrackingDetail.GetRow.Cells("FULL_ADDRESS_KH").Value
        FFastTracking.DateLastFit.Checked = True
        FFastTracking.DateLastFit.Value = GridClientFastTrackingDetail.GetRow.Cells("DATE_OF_LAST_FIT").Value
        FFastTracking.DateFastTrack.Checked = True
        FFastTracking.DateFastTrack.Value = GridClientFastTrackingDetail.GetRow.Cells("DATE_OF_FAST_TRACT").Value
        FFastTracking.CboTherapy.Text = GridClientFastTrackingDetail.GetRow.Cells("THERAPY_NAME").Value
        Try
            FFastTracking.DateNextVisit.Checked = True
            FFastTracking.DateNextVisit.Value = GridClientFastTrackingDetail.GetRow.Cells("NEXT_VIST").Value
        Catch ex As Exception
            FFastTracking.DateNextVisit.Checked = False
            'FFastTracking.DateNextVisit.Value = Nothing
        End Try
        FFastTracking.CboCardLavel.Text = GridClientFastTrackingDetail.GetRow.Cells("CART_LAVEL").Value
        FFastTracking.TxtRemark.Text = GridClientFastTrackingDetail.GetRow.Cells("TRACK_NOTE").Value

        If FFastTracking.ShowDialog = DialogResult.OK Then
            Me.RadClientNo.Checked = True
            Me.TxtSearchClientNo.Text = FFastTracking.TxtClientNo.Text
            FindClientTracking()
        End If
    End Sub

    Private Sub BtnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReport.Click
        Dim FPrintPreview As New RegisPrintPreview
        Dim CrFastTracking As New ReportFastTracking
        Dim TbleFastTracking As DataTable = DA_TrackingDetail.GetData
        'Dim CRRegisPreview As New RegistrationPreview
        'TblClient = DA_Reg_Preview.GetDataByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        'TblFamilyRelativeCome = DA_FamilyComeDetail.SelectRelativeComeByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        'TblReferredDetail = DA_Referred_Detail.SelectReferedByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        'TblNeuroDetail = DA_Neuro_Detail.GetDataByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)

        'TblPsychoMinorDetail = DA_Psycho_Minor_Detail.GetDataByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        'TblPsychoMajorDetail = DA_Psycho_Major_Detail.GetDataByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        'TblDisorderDetail = DA_Disorder_Detail.GetDataByClientNo(DataGridClient.GetRow.Cells("CLIENT_NO").Value)


        ' CRRegisPreview.SetDataSource(TblClient)
        'CRRegisPreview.Database.Tables(0).SetDataSource(TblClient)

        'CRRegisPreview.Database.Tables(1).SetDataSource(TblNeuroDetail)
        'CRRegisPreview.Database.Tables(2).SetDataSource(TblPsychoMinorDetail)
        'CRRegisPreview.Database.Tables(3).SetDataSource(TblPsychoMajorDetail)
        'CRRegisPreview.Database.Tables(4).SetDataSource(TblDisorderDetail)
        ''CRRegisPreview.Database.Tables(5).SetDataSource(TblReferredDetail)
        'CRRegisPreview.Subreports("ReferredByRecport").SetDataSource(TblReferredDetail)
        'CRRegisPreview.Subreports("FamilyRelativeCome").SetDataSource(TblFamilyRelativeCome)
        '' CRRegisPreview.SetDataSource(TblClient)
        'CRRegisPreview.Database.Tables(0).SetDataSource(TblClient)
        'CRRegisPreview.Database.Tables(1).SetDataSource(TblNeuroDetail)
        CrFastTracking.SetDataSource(TbleFastTracking)
        FPrintPreview.CrystalReportObject = CrFastTracking
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
    End Sub
End Class
