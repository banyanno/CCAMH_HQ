Public Class UICaseMonitoring
    Dim DA_THERPIST As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_CaseMonitoringDetail As New DSCaseMonitoringTableAdapters.CCAMH_VIEW_CASE_MONITORINGTableAdapter
    Dim DA_CasMonitoring As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_CASE_MONITORINGTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With CboTherapy
            .DataSource = DA_THERPIST.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub UICaseMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewDetailCaseMonitoring()
    End Sub
    Private Sub ViewDetailCaseMonitoring()
        If RadViewAllMonitoring.Checked = True Then
            GridCaseMonitoring.DataSource = DA_CaseMonitoringDetail.SelectCaseMonitoringDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        ElseIf RadClientNo.Checked = True Then
            GridCaseMonitoring.DataSource = DA_CaseMonitoringDetail.SelectCaseMonitoringByClientNo(EmptyString(TxtSearchClientNo.Text))
        ElseIf RadClientName.Checked = True Then
            GridCaseMonitoring.DataSource = DA_CaseMonitoringDetail.SelectClientNameEng(TxtSearchClientName.Text)
        ElseIf RadSearchClientPhone.Checked = True Then

            GridCaseMonitoring.DataSource = DA_CaseMonitoringDetail.SelectCaseMonitoringByPhone(TxtSearchClientPhone.Text)
        ElseIf RadTherapy.Checked = True Then
            GridCaseMonitoring.DataSource = DA_CaseMonitoringDetail.SelectCaseMonitorFacilater(CboTherapy.Text)
        End If
    End Sub

    Private Sub TxtSearchClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSearchClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        ViewDetailCaseMonitoring()
    End Sub

    Private Sub GridCaseMonitoring_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridCaseMonitoring.RowDoubleClick
        Dim FCaseMonitoring As New FormCaseMonitoring
        FCaseMonitoring.LblSaveOption.Text = GridCaseMonitoring.GetRow.Cells("MONITORING_ID").Value
        FCaseMonitoring.BtnFindClient.Visible = False
        FCaseMonitoring.TxtClientNo.ReadOnly = True
        FCaseMonitoring.TxtClientNo.Text = GridCaseMonitoring.GetRow.Cells("CLIENT_NO").Value
        FCaseMonitoring.TxtClientNameKH.Text = GridCaseMonitoring.GetRow.Cells("CLIENT_NAME_KHM").Value
        FCaseMonitoring.TxtClientNameEng.Text = GridCaseMonitoring.GetRow.Cells("CLIENT_NAME").Value
        FCaseMonitoring.TxtClientSex.Text = GridCaseMonitoring.GetRow.Cells("CLIENT_SEX").Value
        FCaseMonitoring.TxtClientAge.Text = GridCaseMonitoring.GetRow.Cells("CAL_AGE").Value
        FCaseMonitoring.DateCaseMonitoring.Text = GridCaseMonitoring.GetRow.Cells("DATE_CREATE").Value
        FCaseMonitoring.CboFacilater.Text = GridCaseMonitoring.GetRow.Cells("FACILATER").Value
        FCaseMonitoring.CboNotedBy.Text = GridCaseMonitoring.GetRow.Cells("NOTED_BY").Value
        FCaseMonitoring.TxtTherapyDrug.Text = GridCaseMonitoring.GetRow.Cells("DRUG").Value
        FCaseMonitoring.ChTherapyCounseling.Checked = GridCaseMonitoring.GetRow.Cells("COUNSELING").Value
        FCaseMonitoring.ChTherapyABT.Checked = GridCaseMonitoring.GetRow.Cells("ABT").Value
        FCaseMonitoring.ChTherapySpcialNeed.Checked = GridCaseMonitoring.GetRow.Cells("SPECIAL_NEED").Value
        FCaseMonitoring.CboTherapy.Text = GridCaseMonitoring.GetRow.Cells("THEARAPY_NAME").Value
        FCaseMonitoring.ChSeenBySelf.Checked = GridCaseMonitoring.GetRow.Cells("SELF_SEEEN_BY").Value
        FCaseMonitoring.CboSeenByOther.Text = GridCaseMonitoring.GetRow.Cells("OTHER_SEEN_BY").Value
        FCaseMonitoring.CboReferByNGO.Text = GridCaseMonitoring.GetRow.Cells("REFER_BY_NGO").Value
        FCaseMonitoring.CboReferBySchool.Text = GridCaseMonitoring.GetRow.Cells("REFER_BY_SCHOOL").Value
        FCaseMonitoring.TxtReferByOther.Text = GridCaseMonitoring.GetRow.Cells("REFER_BY_OTHER").Value
        FCaseMonitoring.TxtRemark.Text = GridCaseMonitoring.GetRow.Cells("REMARK").Value
        FCaseMonitoring.TxtClientContact.Text = GridCaseMonitoring.GetRow.Cells("CLIENT_ADDRESS_PHONE").Value
        FCaseMonitoring.TxtClientAddress.Text = IIf(IsDBNull(GridCaseMonitoring.GetRow.Cells("FULL_ADDRESS_KH").Value) = True, "", GridCaseMonitoring.GetRow.Cells("FULL_ADDRESS_KH").Value)

        If FCaseMonitoring.ShowDialog = DialogResult.OK Then
            ViewDetailCaseMonitoring()
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        ViewDetailCaseMonitoring()
    End Sub

    Private Sub BtnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReport.Click
        Dim FPrintPreview As New RegisPrintPreview
        Dim CrCaseMonitoring As New ReportCaseMonitoring
        Dim TbleCaseMonitoring As DataTable = DA_CaseMonitoringDetail.SelectCaseMonitoringDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        Dim WeekNumber As Integer = DatePart(DateInterval.WeekOfYear, DateFrom.Value.Date, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
        Dim ValTitle As String = "Week " & WeekNumber & "th (" & DateFrom.Value.Date.Day & Format(DateFrom.Value, "MMM") & " - " & DateTo.Value.Date.Day & " " & Format(DateTo.Value.Date, "MMM yyyy") & ")"
        CrCaseMonitoring.SetDataSource(TbleCaseMonitoring)
        CrCaseMonitoring.SetParameterValue("Title", ValTitle)
        FPrintPreview.CrystalReportObject = CrCaseMonitoring
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
    End Sub

    Private Sub BtnDeleteCaseMonitoring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteCaseMonitoring.Click
        If GridCaseMonitoring.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_CasMonitoring.DeleteCaseMonitoring(GridCaseMonitoring.GetRow.Cells("MONITORING_ID").Value) = 1 Then
                ViewDetailCaseMonitoring()
            End If
        End If
    End Sub

    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtSearchClientNo.Enabled = RadClientNo.Checked
        TxtSearchClientNo.Select()
        TxtSearchClientNo.SelectAll()
    End Sub

    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientName.CheckedChanged
        TxtSearchClientName.Enabled = RadClientName.Checked
        TxtSearchClientName.Select()
        TxtSearchClientName.SelectAll()
    End Sub

    Private Sub RadTherapy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadTherapy.CheckedChanged
        CboTherapy.Enabled = RadTherapy.Checked
        CboTherapy.Select()
        CboTherapy.SelectAll()
    End Sub

    Private Sub RadSearchClientPhone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSearchClientPhone.CheckedChanged
        TxtSearchClientPhone.Enabled = RadSearchClientPhone.Checked
        TxtSearchClientPhone.Select()
        TxtSearchClientPhone.SelectAll()
    End Sub
End Class
