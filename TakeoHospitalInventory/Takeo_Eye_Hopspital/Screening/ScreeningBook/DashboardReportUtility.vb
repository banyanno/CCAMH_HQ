Public Class DashboardReportUtility
    Dim DAScreening As New DataSetScreeningBookTableAdapters.SCREENING_BOOK_VIEWTableAdapter
    'Dim DAScreeningSetting As New DataSetSceenSettingTableAdapters.SCREEN_SYSTEMSETTINGTableAdapter
    Dim DARefraction As New DataSetScreeningBookTableAdapters.SCREENIG_REFRACTION_DEDAILTableAdapter
    Dim DARefer As New DataSetScreeningBookTableAdapters.SCREENING_REFERRAL_DETAILTableAdapter


    Dim TableReportForStatistic As DataTable
    Dim TableReportForBook As DataTable
    Dim TableReportRefraction As DataTable
    Dim TableReportRefer As DataTable

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'With CboScreeningPlace
        '    .DataSource = DAScreeningSetting.GetData
        '    .ValueMember = "SETTING_ID"
        '    .DisplayMember = "HEALTH_NAME"
        '    .SelectedIndex = -1
        'End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnScreeningBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnScreeningBook.Click
        MainFormApplicationPublic.StatusLoading(True, "Loading")
        BGloadingReport.RunWorkerAsync()

    End Sub

    Private Sub ChScreeningPlace_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChScreeningPlace.CheckedChanged
        CboScreeningPlace.Enabled = ChScreeningPlace.Checked
    End Sub
    Private Sub PrintReportUtiliy()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf PrintReportUtiliy))
        Else
            'If ChScreeningPlace.Checked = True Then
            '    TableReport = DAScreening.SelectTotalScreeningByPlaceDtoD(CboScreeningPlace.Text, DateFrom.Value.Date, DateTo.Value.Date)
            'Else
            ' ========================= In case print reports with statistics ===========================================================
            If RadByStatistics.Checked = True Then
                If RadAllScreening.Checked = True Then
                    If ChScreeningPlace.Checked = True Then
                        'TableReport = DAScreening.SelectTotalRefractionWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                        TableReportForStatistic = DAScreening.SelectTotalScreeningByPlaceDtoD(CboScreeningPlace.Text, DateFrom.Value.Date, DateTo.Value.Date)
                    Else
                        TableReportForStatistic = DAScreening.SelectTotalScreening(DateFrom.Value.Date, DateTo.Value.Date)
                    End If

                ElseIf RadRefraction.Checked = True Then
                    If ChScreeningPlace.Checked = True Then
                        TableReportForStatistic = DAScreening.SelectTotalRefractionWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                    Else
                        TableReportForStatistic = DAScreening.SelectTotalRefraction(DateFrom.Value.Date, DateTo.Value.Date)
                    End If
                ElseIf RadReferalBySelf.Checked = True Then
                    If ChScreeningPlace.Checked = True Then
                        TableReportForStatistic = DAScreening.SelectTotalReferbySelfWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                    Else
                        TableReportForStatistic = DAScreening.SelectTotalReferBySelf(DateFrom.Value.Date, DateTo.Value.Date)
                    End If
                ElseIf RadReferPickup.Checked = True Then
                    If ChScreeningPlace.Checked = True Then
                        TableReportForStatistic = DAScreening.SelectTotalReferPickupWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                    Else
                        TableReportForStatistic = DAScreening.SelectTotalReferPickup(DateFrom.Value.Date, DateTo.Value.Date)
                    End If
                ElseIf RadOpticalShop.Checked = True Then
                    If ChScreeningPlace.Checked = True Then
                        TableReportForStatistic = DAScreening.SelectTotalOpticalShopWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                    Else
                        TableReportForStatistic = DAScreening.SelectTotalOpticalShop(DateFrom.Value.Date, DateTo.Value.Date)
                    End If
                End If
                ' ========================= In case print reports with statistics ===========================================================
            ElseIf RadByBooks.Checked = True Then
                If RadScreenBook.Checked = True Then
                    TableReportForBook = DAScreening.SelectScreenBookDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
                ElseIf RadRefractBook.Checked = True Then
                    TableReportRefraction = DARefraction.SelectScreenRefractDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
                ElseIf RadReferBook.Checked = True Then
                    TableReportRefer = DARefer.SelectScreebReferralDateToDate(DateFrom.Value.Date, DateTo.Value.Date)


                End If
            End If

            'End If

        End If


    End Sub

    Private Sub BGloadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGloadingReport.RunWorkerCompleted



        If RadByBooks.Checked = True Then
            '======== Book Reports       =================
            If RadRefractBook.Checked = True Then
                Dim RVRefractionBook As New RefractionBookDetail
                RVRefractionBook.SetDataSource(TableReportRefraction)
                Me.CRVScreeningUtility.ReportSource = RVRefractionBook
                RVRefractionBook.SetParameterValue("Title", "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy"))
            ElseIf RadScreenBook.Checked = True Then
                Dim RVBookReports As New ScreeningBook
                RVBookReports.SetDataSource(TableReportForBook)
                Me.CRVScreeningUtility.ReportSource = RVBookReports
                RVBookReports.SetParameterValue("title", "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy"))
            ElseIf RadReferBook.Checked = True Then
                Dim RVReferBook As New ReferBookDetail
                RVReferBook.SetDataSource(TableReportRefer)
                Me.CRVScreeningUtility.ReportSource = RVReferBook
                RVReferBook.SetParameterValue("Title", "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy"))


            End If

        ElseIf RadByStatistics.Checked = True Then
            '======== Statistics Reports =================
            Dim RVStatistics As New ReportScreening
            Dim TitlePara As String
            Dim FuntionPara As String
            RVStatistics.SetDataSource(TableReportForStatistic)
            Me.CRVScreeningUtility.ReportSource = RVStatistics

            If RadAllScreening.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                    FuntionPara = "Screening"
                Else
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                    FuntionPara = "Screening"
                End If

            ElseIf RadRefraction.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                    FuntionPara = "Prescribtion For Refraction"
                Else
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                    FuntionPara = "Prescribtion For Refraction"
                End If
            ElseIf RadReferalBySelf.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                    FuntionPara = "Referred By self"
                Else
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                    FuntionPara = "Referred By self"
                End If
            ElseIf RadReferPickup.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                    FuntionPara = "Refered by Pickup"
                Else
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                    FuntionPara = "Refered by Pickup"
                End If
            ElseIf RadOpticalShop.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                    FuntionPara = "Optical Shop"
                Else
                    TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                    FuntionPara = "Optical Shop"
                End If
            End If
            RVStatistics.SetParameterValue("Title", TitlePara)
            RVStatistics.SetParameterValue("Function", FuntionPara)
        End If

        MainFormApplicationPublic.StatusLoading(False, "Loading")
    End Sub

    Private Sub BGloadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGloadingReport.DoWork
        PrintReportUtiliy()
    End Sub

    Private Sub RadByStatistics_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByStatistics.CheckedChanged
        GroupByStatistict.Enabled = RadByStatistics.Checked
    End Sub

    Private Sub RadByBooks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByBooks.CheckedChanged
        GroupByScreenBook.Enabled = RadByBooks.Checked
    End Sub
End Class
