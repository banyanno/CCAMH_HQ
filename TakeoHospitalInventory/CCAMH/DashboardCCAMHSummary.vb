Imports DevExpress.XtraCharts
Imports KTGSYS.DSDashboardSummaryTableAdapters

Public Class DashboardCCAMHSummary


    '  Dim DA_ClientManagement As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim DA_Summary As New DSDashboardSummaryTableAdapters.DataVisualTableAdapter
    Dim DA_App As New DSAssessmentTableAdapters.CCAMH_VIEW_APPOINTMENT_DETAILTableAdapter
    Private Sub DashboardCCAMHSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TotalRegistration()
        'Series.ArgumentScaleType = ScaleType.Numerical
        'Series.ArgumentDataMember = "Argument"
        'Series.ValueScaleType = ScaleType.Numerical
        'Series.ValueDataMembers.AddRange(New String() {"Value"})
        LblDepartment.Text = "Department: " & DEPART_NAME
        LblUserName.Text = "User Name: " & USER_NAME
    End Sub
    Private Sub TotalRegistration()
        ' ======= condition 0= new regis, and 1= followup 
        'Dim TblRegisTotalNew As DataTable = DA_ClientManagement.SelectTotalClientRegist(0, DateFrom.Value.Date, DateTo.Value.Date)
        'Dim TblRegisTotalFollwUp As DataTable = DA_ClientManagement.SelectTotalClientRegist(1, DateFrom.Value.Date, DateTo.Value.Date)

        'For Each row As DataRow In TblRegisTotalNew.Rows
        '    'lblNewRegisterM.Text = row("Male")
        '    'lblNewRegisterF.Text = row("Female")
        '    'lblNewRegisterTotal.Text = row("Total")
        'Next

        'For Each row As DataRow In TblRegisTotalFollwUp.Rows
        '    'lblFollowUpM.Text = row("Male")
        '    'lblFollowUpF.Text = row("Female")
        '    'lblFollowUpTotal.Text = row("Total")
        'Next
        'With ChartNewClient
        '    .DataSource = TblRegisTotalNew
        'End With
    End Sub
    Friend Sub InitGeneratChart(Years As Double)
        LblTotalApp.Text = DA_App.TotalAppointByDate(DateYear.Value.Date)
        Dim TblDataSummary As DataTable = DA_Summary.GetData(Years)
        'MessageBox.Show(TblDataSummary.Rows.Count)
        ' ChartControlMonthlyVisit.Series("New Client").DataSource = TblDataSummary
        With ChartControlMonthlyVisit.Series("New Client")
            .DataSource = TblDataSummary
            .ArgumentScaleType = ScaleType.Numerical
            .ArgumentDataMember = "Monthly"
            .ValueScaleType = ScaleType.Numerical
            .ValueDataMembers.AddRange(New String() {"TotalNew"})
        End With
        With ChartControlMonthlyVisit.Series("Old Client")
            .DataSource = TblDataSummary
            .ArgumentScaleType = ScaleType.Numerical
            .ArgumentDataMember = "Monthly"
            .ValueScaleType = ScaleType.Numerical
            .ValueDataMembers.AddRange(New String() {"TotalOld"})
        End With
        With ChartControlMonthlyVisit.Series("Female")
            .DataSource = TblDataSummary
            .ArgumentScaleType = ScaleType.Numerical
            .ArgumentDataMember = "Monthly"
            .ValueScaleType = ScaleType.Numerical
            .ValueDataMembers.AddRange(New String() {"TotalF"})
        End With
        With ChartControlMonthlyVisit.Series("Male")
            .DataSource = TblDataSummary
            .ArgumentScaleType = ScaleType.Numerical
            .ArgumentDataMember = "Monthly"
            .ValueScaleType = ScaleType.Numerical
            .ValueDataMembers.AddRange(New String() {"TotalM"})
        End With
        '===========================================================


        With ChartControlMonthlyVisit.Series("LineNewClient")
            .DataSource = TblDataSummary
            .ArgumentScaleType = ScaleType.Numerical
            .ArgumentDataMember = "Monthly"
            .ValueScaleType = ScaleType.Numerical
            .ValueDataMembers.AddRange(New String() {"TotalNew"})
        End With
        With ChartControlMonthlyVisit.Series("LineOldClient")
            .DataSource = TblDataSummary
            .ArgumentScaleType = ScaleType.Numerical
            .ArgumentDataMember = "Monthly"
            .ValueScaleType = ScaleType.Numerical
            .ValueDataMembers.AddRange(New String() {"TotalOld"})
        End With

        With ChartControlMonthlyVisit.Series("LineFemale")
            .DataSource = TblDataSummary
            .ArgumentScaleType = ScaleType.Numerical
            .ArgumentDataMember = "Monthly"
            .ValueScaleType = ScaleType.Numerical
            .ValueDataMembers.AddRange(New String() {"TotalF"})
        End With
        With ChartControlMonthlyVisit.Series("LineMale")
            .DataSource = TblDataSummary
            .ArgumentScaleType = ScaleType.Numerical
            .ArgumentDataMember = "Monthly"
            .ValueScaleType = ScaleType.Numerical
            .ValueDataMembers.AddRange(New String() {"TotalM"})
        End With
        ' Specify data members to bind the series.
        'series.ArgumentScaleType = ScaleType.Numerical;
        'series.ArgumentDataMember = "Argument";
        'series.ValueScaleType = ScaleType.Numerical;
        'series.ValueDataMembers.AddRange(new string[] { "Value" });


    End Sub
    
    Private Sub BtnYears_Click(sender As Object, e As EventArgs) Handles BtnYears.Click
        InitGeneratChart(CInt(EmptyString(Year(DateYear.Value.Date))))
    End Sub

    Private Sub CboYears_KeyPress(sender As Object, e As KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

  
End Class
