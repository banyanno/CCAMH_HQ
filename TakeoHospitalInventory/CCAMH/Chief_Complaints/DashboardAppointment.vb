Public Class DashboardAppointment
    Dim DA_Therapist As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_Appointment_Detail As New DSAssessmentTableAdapters.CCAMH_VIEW_APPOINTMENT_DETAILTableAdapter
    Dim DA_ClientMg As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim DA_CaseAudit As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_OUTCOME_PROFILETableAdapter
    Dim DA_Appointment As New DSAssessmentTableAdapters.CCAMH_CLIENT_APPOINTSTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With CboSearchTherapistOrDoctor
            .DataSource = DA_Therapist.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
    End Sub
  
    Friend Sub FindClientMissing(DateAudit As DateTime, NumberMonthOrDay As Integer)
        If RadMissByDay.Checked = True Then
            GridClientAppointment.DataSource = DA_Appointment_Detail.FindingMissingAppByDay(DateAudit.Date, False, DateAudit.Date, NumberMonthOrDay)
        ElseIf RadMissByMonth.Checked = True Then
            GridClientAppointment.DataSource = DA_Appointment_Detail.SelectFindCaseDropOut(DateAudit.Date, False, DateAudit.Date, NumberMonthOrDay)
        End If

    End Sub
    Private Sub ViewAppointmentDetail()
        If GridClientAppointment.SelectedItems.Count = 0 Then
            Exit Sub
            TxtAppontmentWith.Text = ""
            TxtDateAppointment.Text = ""

            TxtAppointTime.Text = ""
            TxtAppointmentNote.Text = ""
            TxtAppointmentStatus.Text = ""
            ChIsCall.Checked = False

            TxtDateCalled.Text = ""
            txtAppointmentStatusNote.Text = ""
            TxtLastVisit.Text = ""
        Else
            TxtAppontmentWith.Text = GridClientAppointment.GetRow.Cells("APP_WITH_NAME").Value
            TxtDateAppointment.Text = GridClientAppointment.GetRow.Cells("APP_DATE").Text
            TxtAppointTime.Text = GridClientAppointment.GetRow.Cells("APP_TIME").Text
            TxtAppointmentNote.Text = GridClientAppointment.GetRow.Cells("APP_NOTE").Value
            TxtAppointmentStatus.Text = GridClientAppointment.GetRow.Cells("APP_STATUS").Value
            ChIsCall.Checked = GridClientAppointment.GetRow.Cells("APP_CALL_STATUS").Value
            TxtLastVisit.Text = Format(GetLastVisit(GridClientAppointment.GetRow.Cells("CLIENT_NO").Value), "dd/MM/yyyy")
            If TypeOf GridClientAppointment.GetRow.Cells("APP_CALL_DATE").Value Is DBNull Then
            Else

                TxtDateCalled.Text = GridClientAppointment.GetRow.Cells("APP_CALL_DATE").Text

            End If
            If TypeOf GridClientAppointment.GetRow.Cells("APP_STATUS_NOTE").Value Is DBNull Then
            Else
                txtAppointmentStatusNote.Text = GridClientAppointment.GetRow.Cells("APP_STATUS_NOTE").Value
            End If
        End If



    End Sub
    Private Sub RefreshTherapistList()
        GridListOfTherapist.DataSource = DA_Therapist.GetData
    End Sub



    Private Sub DashboardThearapist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshTherapistList()
        InitFindAppointmentOption()
    End Sub

    Private Sub BtnNewNextAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewNextAppointment.Click
        If GridClientAppointment.SelectedItems.Count = 0 Then Exit Sub
        Dim NextAppoint As New FormNextAppointment
        NextAppoint.TxtClientNo.Text = GridClientAppointment.GetRow.Cells("CLIENT_NO").Value
        NextAppoint.TxtClientNameKH.Text = GridClientAppointment.GetRow.Cells("CLIENT_NAME_KHM").Value
        NextAppoint.TxtClientNameEng.Text = GridClientAppointment.GetRow.Cells("CLIENT_NAME").Value
        NextAppoint.TxtClientSex.Text = GridClientAppointment.GetRow.Cells("CLIENT_SEX").Value
        NextAppoint.TxtClientAge.Text = GridClientAppointment.GetRow.Cells("CLIENT_AGE").Value
        If NextAppoint.ShowDialog = DialogResult.OK Then
            BtnFind_Click(sender, e)
        End If
    End Sub

    Private Sub BtnUpdateStatusApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateStatusApp.Click
        If GridClientAppointment.SelectedItems.Count = 0 Then Exit Sub
        If GridClientAppointment.GetRow.Cells("APP_ID").Text = "" Then Exit Sub
        Dim UpdateAppointmentStatus As New FormAppointmentstatusUpdate
        UpdateAppointmentStatus.LblAppointmentID.Text = GridClientAppointment.GetRow.Cells("APP_ID").Value
        If TypeOf GridClientAppointment.GetRow.Cells("APP_CALL_STATUS").Value Is DBNull Then
            UpdateAppointmentStatus.chCall.Checked = False
        Else
            UpdateAppointmentStatus.chCall.Checked = GridClientAppointment.GetRow.Cells("APP_CALL_STATUS").Value
        End If

        If TypeOf GridClientAppointment.GetRow.Cells("APP_CALL_DATE").Value Is DBNull Then
            UpdateAppointmentStatus.DateCall.Checked = False
        Else
            UpdateAppointmentStatus.DateCall.Value = GridClientAppointment.GetRow.Cells("APP_CALL_DATE").Value
        End If

        If TypeOf GridClientAppointment.GetRow.Cells("APP_STATUS").Value Is DBNull Then
            UpdateAppointmentStatus.CboAppointStatus.Text = ""
        Else
            UpdateAppointmentStatus.CboAppointStatus.Text = GridClientAppointment.GetRow.Cells("APP_STATUS").Value
        End If

        If TypeOf GridClientAppointment.GetRow.Cells("APP_STATUS_NOTE").Value Is DBNull Then
            UpdateAppointmentStatus.TxtAppointmentStatusNote.Text = ""
        Else
            UpdateAppointmentStatus.TxtAppointmentStatusNote.Text = GridClientAppointment.GetRow.Cells("APP_STATUS_NOTE").Value
        End If

        If UpdateAppointmentStatus.ShowDialog = DialogResult.OK Then
            BtnFind_Click(sender, e)
        End If
    End Sub

    Private Sub GridClientAppointment_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridClientAppointment.SelectionChanged
        ViewAppointmentDetail()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        GridClientAppointment.DataSource = DA_Appointment_Detail.GetData(Now.Date)
    End Sub

    Private Sub GridListOfTherapist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridListOfTherapist.Click
        Try
            GridClientAppointment.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded
            GridClientAppointment.DataSource = DA_Appointment_Detail.SelectAppointmentbyTherapist(GridListOfTherapist.GetRow.Cells("THERAPIST_ID").Value, DateSearchAppFrom.Value.Date, DateSearchAppTo.Value.Date)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RadDateAppointent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDateAppointent.CheckedChanged
        'DateSearchAppFrom.Enabled = RadDateAppointent.Checked
        'DateSearchAppTo.Enabled = RadDateAppointent.Checked
    End Sub

    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtSearchClientNo.Enabled = RadClientNo.Checked
        TxtSearchClientNo.Focus()
    End Sub


    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientName.CheckedChanged
        TxtSearchClientName.Enabled = RadClientName.Checked
        TxtSearchClientName.Focus()
    End Sub

    Private Sub RadTherapist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadTherapist.CheckedChanged
        CboSearchTherapistOrDoctor.Enabled = RadTherapist.Checked
        CboSearchTherapistOrDoctor.SelectedIndex = -1
        CboSearchTherapistOrDoctor.Focus()
    End Sub
    Private Sub InitFindAppointmentOption()
        If RadDateAppointent.Checked = True Then
            GridClientAppointment.DataSource = DA_Appointment_Detail.SelectAppointDateToDate(DateSearchAppFrom.Value.Date, DateSearchAppTo.Value.Date)
        ElseIf RadClientNo.Checked = True Then
            GridClientAppointment.DataSource = DA_Appointment_Detail.SelectAppointmentByClientNo(EmptyString(TxtSearchClientNo.Text))
        ElseIf RadClientName.Checked = True Then
            GridClientAppointment.DataSource = DA_Appointment_Detail.SelectAppointmentByClientNameEng(TxtSearchClientName.Text)
        ElseIf RadClientTelphone.Checked = True Then
            GridClientAppointment.DataSource = DA_Appointment_Detail.SelectAppointmentByPhoneNo(Now.Date, TxtTelephoneNo.Text)
        ElseIf RadTherapist.Checked = True Then
            GridClientAppointment.DataSource = DA_Appointment_Detail.SelectAppointmentbyTherapist(CboSearchTherapistOrDoctor.SelectedValue, DateSearchAppFrom.Value.Date, DateSearchAppTo.Value.Date)
        End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        InitFindAppointmentOption()
    End Sub

    Private Sub BtnFindCaseDropOut_Click(sender As Object, e As EventArgs) Handles BtnCaseDropOut.Click
        If GridClientAppointment.SelectedItems.Count = 0 Then Exit Sub
        If GridClientAppointment.GetRow.Cells("CLIENT_NO").Text = "" Then Exit Sub
        If DA_CaseAudit.CheckExisterDropOut(GridClientAppointment.GetRow.Cells("CLIENT_NO").Value) > 0 Then
            MessageBox.Show("The cleint already record to case drop-out!", "Drop-out", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim FCaseDropOut As New FormCaseDropOut(Me)
        FCaseDropOut.InitClientInfo(GridClientAppointment.GetRow.Cells("CLIENT_NO").Value)
        FCaseDropOut.RadDropOut.Checked = True
        FCaseDropOut.RadStopVisit.Enabled = False
        If FCaseDropOut.ShowDialog = DialogResult.OK Then
            DA_Appointment.UpdateAppointmentCaseDropOut(True, USER_NAME, Now.Date, GridClientAppointment.GetRow.Cells("APP_ID").Value)
        End If
    End Sub
    Private Function GetLastVisit(ClientNo As Double) As Date
        Dim LastVisit As Date
        For Each drows As DataRow In DA_ClientMg.SelectClientLastVisit(ClientNo).Rows
            LastVisit = CDate(drows("DATE_CREATE"))
        Next
        Return LastVisit.Date
    End Function

    Private Sub BtnFDropOut_Click(sender As Object, e As EventArgs) Handles BtnFDropOut.Click
        If ValidateDateField(DateCaseAuditDropOut, "", ErrorProvider1) = False Then Exit Sub
        If ValidateTextField(TxtNumberMonthOrDay, "", ErrorProvider1) = False Then Exit Sub
        GridClientAppointment.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded
        GridClientAppointment.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.FindClientMissing(Me.DateCaseAuditDropOut.Value.Date, EmptyString(TxtNumberMonthOrDay.Text))

    End Sub

    Private Sub BtnPrinAppointment_Click(sender As Object, e As EventArgs) Handles BtnPrinAppointment.Click
        Dim CRAppointment As New ReportAppoint
        Dim TblListAppointment As DataTable
        Dim Title As String = ""
        If RadDateAppointent.Checked = True Then
            TblListAppointment = DA_Appointment_Detail.SelectAppointDateToDate(DateSearchAppFrom.Value.Date, DateSearchAppTo.Value.Date)
            Title = "Appointment from: " & Format(DateSearchAppFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DateSearchAppTo.Value.Date, "dd/MM/yyyy")
        ElseIf RadClientNo.Checked = True Then
            TblListAppointment = DA_Appointment_Detail.SelectAppointmentByClientNo(EmptyString(TxtSearchClientNo.Text))
        ElseIf RadClientName.Checked = True Then
            TblListAppointment = DA_Appointment_Detail.SelectAppointmentByClientNameEng(TxtSearchClientName.Text)
        ElseIf RadTherapist.Checked = True Then

            TblListAppointment = DA_Appointment_Detail.SelectAppointmentbyTherapist(CboSearchTherapistOrDoctor.SelectedValue, DateSearchAppFrom.Value.Date, DateSearchAppTo.Value.Date)
            Title = "Appointment with " & CboSearchTherapistOrDoctor.Text & " from: " & Format(DateSearchAppFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DateSearchAppTo.Value.Date, "dd/MM/yyyy")
        End If
        CRAppointment.SetDataSource(TblListAppointment)
        CRAppointment.SetParameterValue("Title", Title)
        Dim FPublicReportViewer As New FormPublicReportViewer
        FPublicReportViewer.CrvViewer.ReportSource = CRAppointment
        FPublicReportViewer.ShowDialog()
    End Sub

    Private Sub TxtNumberMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumberMonthOrDay.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnPrintListLateAppointment_Click(sender As Object, e As EventArgs) Handles BtnPrintListLateAppointment.Click
        If ValidateDateField(DateCaseAuditDropOut, "", ErrorProvider1) = False Then Exit Sub
        If ValidateTextField(TxtNumberMonthOrDay, "", ErrorProvider1) = False Then Exit Sub
        Dim CRAppointment As New ReportAppoint
        Dim TblListAppointment As DataTable

        If RadMissByDay.Checked Then
            TblListAppointment = DA_Appointment_Detail.FindingMissingAppByDay(DateCaseAuditDropOut.Value.Date, False, DateCaseAuditDropOut.Value.Date, EmptyString(TxtNumberMonthOrDay.Text))
            CRAppointment.SetDataSource(TblListAppointment)
            CRAppointment.SetParameterValue("Title", "List of client missing appointment. Audit on:" & Format(DateCaseAuditDropOut.Value.Date, "dd/MM/yyyy") & " Duration: " & TxtNumberMonthOrDay.Text & " days ")
        ElseIf RadMissByMonth.Checked = True Then
            TblListAppointment = DA_Appointment_Detail.SelectFindCaseDropOut(DateCaseAuditDropOut.Value.Date, False, DateCaseAuditDropOut.Value.Date, EmptyString(TxtNumberMonthOrDay.Text))
            CRAppointment.SetDataSource(TblListAppointment)
            CRAppointment.SetParameterValue("Title", "List of client missing appointment. Audit on:" & Format(DateCaseAuditDropOut.Value.Date, "dd/MM/yyyy") & " Duration: " & TxtNumberMonthOrDay.Text & " months ")
        End If

        Dim FPublicReportViewer As New FormPublicReportViewer
        FPublicReportViewer.CrvViewer.ReportSource = CRAppointment
        FPublicReportViewer.ShowDialog()
    End Sub

    Private Sub BtnUpdateAppoint_Click(sender As Object, e As EventArgs) Handles BtnUpdateAppoint.Click
        If GridClientAppointment.SelectedItems.Count = 0 Then Exit Sub
        If GridClientAppointment.GetRow.Cells("APP_ID").Text = "" Then Exit Sub

        If GridClientAppointment.SelectedItems.Count = 0 Then Exit Sub
        Dim ClientAppoint As New FormNextAppointment
        ClientAppoint.LblSaveOption.Text = GridClientAppointment.GetRow.Cells("APP_ID").Value
        ClientAppoint.TxtClientNo.Text = GridClientAppointment.GetRow.Cells("CLIENT_NO").Value
        ClientAppoint.TxtClientNameKH.Text = GridClientAppointment.GetRow.Cells("CLIENT_NAME_KHM").Value
        ClientAppoint.TxtClientNameEng.Text = GridClientAppointment.GetRow.Cells("CLIENT_NAME").Value
        ClientAppoint.TxtClientSex.Text = GridClientAppointment.GetRow.Cells("CLIENT_SEX").Value
        ClientAppoint.TxtClientAge.Text = GridClientAppointment.GetRow.Cells("CLIENT_AGE").Value
        ClientAppoint.DateAppointment.Checked = True
        ClientAppoint.DateAppointment.Value = GridClientAppointment.GetRow.Cells("APP_DATE").Value
        ClientAppoint.CboMeetWith.Text = GridClientAppointment.GetRow.Cells("APP_WITH_NAME").Value
        ClientAppoint.TxtAppointmentNote.Text = GridClientAppointment.GetRow.Cells("APP_NOTE").Value
        If ClientAppoint.ShowDialog = DialogResult.OK Then
             BtnFind_Click(sender, e)
        End If

       
    End Sub

    Private Sub BtnTherapist_Click(sender As Object, e As EventArgs) Handles BtnTherapist.Click
        Dim NewTherapist As New FormTherapist
        If NewTherapist.ShowDialog = DialogResult.OK Then
            RefreshTherapistList()
        End If
    End Sub

  
    Private Sub BtnUpdateTherapist_Click(sender As Object, e As EventArgs) Handles BtnUpdateTherapist.Click
        If GridListOfTherapist.SelectedItems.Count = 0 Then Exit Sub
        Dim EditTherapist As New FormTherapist
        EditTherapist.lblSaveOption.Text = GridListOfTherapist.GetRow.Cells("THERAPIST_ID").Value
        EditTherapist.txtTherapistName.Text = GridListOfTherapist.GetRow.Cells("THERAPIST_NAME").Value
        EditTherapist.txtTherapistNotes.Text = GridListOfTherapist.GetRow.Cells("THERAPIST_NOTES").Value
        If EditTherapist.ShowDialog = DialogResult.OK Then
            RefreshTherapistList()
        End If
    End Sub

    Private Sub RadClientTelphone_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientTelphone.CheckedChanged
        TxtTelephoneNo.Enabled = RadClientTelphone.Checked
        TxtTelephoneNo.Focus()
    End Sub
End Class
