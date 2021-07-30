Imports Janus.Windows.GridEX
Public Class FormSelectClinicalAudit
    Dim DA_ClientClinicalAudit As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_VIEW_ACTIVE_ADVISED_CLIENTSTableAdapter
    Dim DA_CLINICAL_AUDIT As New DS_CCAMH_ASSESSMENTSTableAdapters.VIEW_CLIENT_ASSESMENT_CLINICAL_AUDITTableAdapter
    Dim DA_ReferralOutRich As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_VIEW_REFER_DETAILTableAdapter
    Dim DA_CaseDropOut As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_OUTCOME_PROFILETableAdapter
    Dim DA_ASSESSMENT_INFO As New DS_CCAMH_ASSESSMENTSTableAdapters.CCAMH_CLIENT_ASSESSMENT_INFOTableAdapter
    Dim DA_ClientMg As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim DA_SOCIAL As New DS_CCAMH_ASSESSMENTSTableAdapters.CLIENT_CA_SOCIALTableAdapter
    Dim DA_CLIENT_INFO As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_VIEW_ADVISED_CLIENTSTableAdapter
    Dim DA_ClientManage As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_VIEW_CLIENT_MANAGERMANT_V1TableAdapter
    Dim DA_App As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_CLIENT_APPOINTSTableAdapter

    Friend Sub InitTotalAuditClinicalAudit(DateClinicalAuditFrom As Date, DateClinicalAuditTo As Date)
        ' Me.GridClientNew.DataSource = DA_ClientManage.SelectDateToDateDetailAssNewOrOld(0, DateClinicalAuditFrom, DateClinicalAuditTo, True)
        ' LblTotalClinicAudit.Text = (TotalAuditF + TotalAuditM)
        Dim TotalBlueF As Integer = DA_CLINICAL_AUDIT.TotalSexBlue("F", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalBlueM As Integer = DA_CLINICAL_AUDIT.TotalSexBlue("M", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalPinkF As Integer = DA_CLINICAL_AUDIT.TotalSexPink("F", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalPinkM As Integer = DA_CLINICAL_AUDIT.TotalSexPink("M", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalGreenF As Integer = DA_CLINICAL_AUDIT.TotalSexGreen("F", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalGreenM As Integer = DA_CLINICAL_AUDIT.TotalSexGreen("M", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalYellowF As Integer = DA_CLINICAL_AUDIT.TotalSexYellow("F", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalYellowM As Integer = DA_CLINICAL_AUDIT.TotalSexYellow("M", True, DateClinicalAuditFrom, DateClinicalAuditTo)
        LblTotalPsycology.Text = ((TotalBlueF + TotalBlueM) + (TotalPinkF + TotalPinkM) + (TotalGreenF + TotalGreenM)).ToString & "(F=" & (TotalBlueF + TotalPinkF + TotalGreenF).ToString & ",M=" & (TotalBlueM + TotalPinkM + TotalGreenM) & ")"
        LblTotalNaro.Text = (TotalYellowF + TotalYellowM) & "(F=" & TotalYellowF & ",M=" & TotalYellowM & ")"
        Dim TotalOutKompongCham As Integer = DA_ReferralOutRich.TotalReferralToDateToDate(1, False, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalOutKpChnang As Integer = DA_ReferralOutRich.TotalReferralToDateToDate(2, False, DateClinicalAuditFrom, DateClinicalAuditTo)
        Dim TotalOutBTB As Integer = DA_ReferralOutRich.TotalReferralToDateToDate(3, False, DateClinicalAuditFrom, DateClinicalAuditTo)
        LblTotalReferralToKgCham.Text = TotalOutKompongCham
        LblTotalReferralKGChnang.Text = TotalOutKpChnang
        LblTotalReferralBTB.Text = TotalOutBTB
      
    End Sub
    Friend Sub InitLabelWeek(Value As String)
        LblWeek.Text = Value
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Function GetLastVisit(ClientNo As Double) As Date
        Dim LastVisit As Date
        For Each drows As DataRow In DA_ClientMg.SelectClientLastVisit(ClientNo).Rows
            LastVisit = CDate(drows("DATE_CREATE"))
        Next
        Return LastVisit.Date
    End Function
    Private Function GetLastAppointment(ClientNo As Double) As Date
        Try
            Return DA_App.SelectLastAppointment(ClientNo)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateDateField(DateAuditOn, "", ErrorProvider1) = False Then Exit Sub
        If ValidateDateField(StartDateWeek, "", ErrorProvider1) = False Then Exit Sub
        If ValidateDateField(EndDateWeek, "", ErrorProvider1) = False Then Exit Sub
        InitLabelWeek("Week " & GetWeekOfYear(StartDateWeek.Value.Date) & "th (" & Format(StartDateWeek.Value.Date, "dd MMM") & "-" & EndDateWeek.Value.Date.Day & " " & Format(EndDateWeek.Value.Date, "MMM yyyy") & ")")
        InitTotalAuditClinicalAudit(StartDateWeek.Value.Date, EndDateWeek.Value.Date)
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        checkedRows = GridClientNew.GetCheckedRows()
        If checkedRows.Length = 0 Then
            MessageBox.Show("Please check at least 1 client to note clinical audit.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If MessageBox.Show("Do you want to save clinical audit?", "Clinical Audit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Dim ClientNo As Double = 0
                Dim DRegister As Date
                Dim ClientNameEng, ClientNameKh, AuditRemark As String
                Dim ClientSex As String, ClientAge As String, ClientDOB As Date
                Dim DateAssesment As Date
                For Each gRows As Janus.Windows.GridEX.GridEXRow In checkedRows
                    ClientNo = gRows.Cells("CLIENT_NO").Value
                    DRegister = gRows.Cells("CLIENT_DATE_REG").Value
                    ClientNameEng = gRows.Cells("CLIENT_NAME").Value
                    ClientNameKh = gRows.Cells("CLIENT_NAME_KHM").Value
                    ClientSex = gRows.Cells("CLIENT_SEX").Value
                    ClientAge = gRows.Cells("CLIENT_AGE").Value
                    'ClientDOB = gRows.Cells("").Value
                    AuditRemark = gRows.Cells("CLIENT_ADVICED_ASSESSMENT_NOTE").Value
                    DateAssesment = gRows.Cells("CLIENT_ADVISED_ASSESSMENT_DATE").Value

                    If DA_ClientClinicalAudit.CheckExistingClinicalAudit(gRows.Cells("CLIENT_NO").Value) < 1 Then
                        DA_ASSESSMENT_INFO.InsertClinicalAuditQuery(ClientNo, "", "", "", DateAssesment.Date, DRegister.Date, "", "", "", "", "", _
                                                                  "", 0, Now.Date, ClientNameEng, ClientNameKh, ClientSex, ClientAge, Nothing, _
                                                                  DA_CLIENT_INFO.SelectNumberVisit(ClientNo), GetLastAppointment(ClientNo), "", "", "", _
                                                                  AuditRemark, "", "0", "", "", "", DateAuditOn.Value.Date, GetWeekOfYear(StartDateWeek.Value.Date), _
                                                                  StartDateWeek.Value.Date, EndDateWeek.Value.Date, LblWeek.Text)
                        DA_SOCIAL.UpdateAssessedClient(ClientNo)
                    Else
                        MessageBox.Show("The Client No " & gRows.Cells("CLIENT_NO").Value & " " & ClientNameKh & " already exist in clinical audit list. Please check again!", "Infor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Application.DoEvents()
                    MainFormApplicationPublic.StatusLoading(True, "Saving")
                Next
                MainFormApplicationPublic.StatusLoading(False, "Saving")
                MessageBox.Show("Save clinical audit successfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim RCClinicalAudit As New ReportClientClinicalAudit
                Dim TblClinicalAudit As DataTable = DA_ClientClinicalAudit.SelectWeekAudited(StartDateWeek.Value.Year, GetWeekOfYear(StartDateWeek.Value.Date))
                RCClinicalAudit.SetDataSource(TblClinicalAudit)
                RCClinicalAudit.SetParameterValue("DateClinicalAudit", Format(DateAuditOn.Value.Date, "dd.MM.yyyy"))
                RCClinicalAudit.SetParameterValue("WeekAudit", LblWeek.Text) '& "th (" & Format(DateClinicalAuditFrom.Value.Date, "dd") & "-" & Format(DateClinicalAuditTo.Value.Date, "dd MM yyyy") & ")")
                RCClinicalAudit.SetParameterValue("TotalAudit", LblTotalClinicAudit.Text)
                RCClinicalAudit.SetParameterValue("TotalPsycology", LblTotalPsycology.Text)
                RCClinicalAudit.SetParameterValue("TotalNaro", LblTotalNaro.Text)
                RCClinicalAudit.SetParameterValue("TeferToCham", LblTotalReferralToKgCham.Text)
                RCClinicalAudit.SetParameterValue("ReferKChnang", LblTotalReferralKGChnang.Text)
                RCClinicalAudit.SetParameterValue("ReferToBTB", LblTotalReferralBTB.Text)
                Dim FAuditViewer As New AssessPrintPreview
                FAuditViewer.CrystalReportViewer1.ReportSource = RCClinicalAudit
                FAuditViewer.ShowDialog()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub


    Private Sub StartDateWeek_ValueChanged(sender As Object, e As EventArgs) Handles StartDateWeek.ValueChanged
        InitLabelWeek("Week " & WeekNumber & "th (" & Format(StartDateWeek.Value.Date, "dd MMM") & "-" & EndDateWeek.Value.Date.Day & " " & Format(EndDateWeek.Value.Date, "MMM yyyy") & ")")
    End Sub
    Function GetWeekOfYear(DateOfYear As Date) As Integer
        Dim WeekNumber As Integer = DatePart(DateInterval.WeekOfYear, DateOfYear, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
        Return WeekNumber
    End Function

    Private Sub EndDateWeek_ValueChanged(sender As Object, e As EventArgs) Handles EndDateWeek.ValueChanged
        InitLabelWeek("Week " & WeekNumber & "th (" & Format(StartDateWeek.Value.Date, "dd MMM") & "-" & EndDateWeek.Value.Date.Day & " " & Format(EndDateWeek.Value.Date, "MMM yyyy") & ")")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class