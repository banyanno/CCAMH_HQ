Imports System.IO

Public Class UIRegDashboard
    Dim DA_Client As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENTSTableAdapter

    Dim DA_CLient_Stat As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim DA_FamilyComeDetail As New DSFamilyComeTableAdapters.CLIENT_COMEWITH_INFO_DETAILTableAdapter
    Dim DA_Referred_Detail As New DSReferedTableAdapters.CCAMH_REFERED_DETIALTableAdapter
    Dim DA_Reg_Detail As New DS_CCAMHClientRegistrationTableAdapters.CLIENT_REGISTRATION_DETAILTableAdapter
    Dim DA_Client_Social As New DS_CCAMHClientRegistrationTableAdapters.CLIENT_CA_SOCIALTableAdapter
    Dim DA_Neuro_Detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_CLIENT_NEUROTableAdapter
    Dim DA_Psycho_Minor_Detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_PSYCHO_MINOR_DETAILTableAdapter
    Dim DA_Psycho_Major_Detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_PSYCHO_MAJOR_DETAILTableAdapter
    Dim DA_Disorder_Detail As New DS_CCAMHClient_ImpressionsTableAdapters.CCAMH_DDISORDER_DETAILTableAdapter

    Dim TblClient As DataTable
    Dim TblFamilyRelativeCome As DataTable
    Dim TblReferredDetail As DataTable
    Dim TblNeuroDetail As DataTable
    Dim TblPsychoMinorDetail As DataTable
    Dim TblPsychoMajorDetail As DataTable
    Dim TblDisorderDetail As DataTable
    Dim TblRegDetail As DataTable
    Dim DA_ClientManagement As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter
    Dim DA_CLIENT_INFO As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_VIEW_CLIENT_INFOTableAdapter
    Dim DA_ClientMG As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENT_MANAGMENTTableAdapter

    Dim DA_Reg_Preview As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_REG_PREVIEWTableAdapter

    Dim DA_View_ClientMG As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_VIEW_CLIENT_MANAGERMANT_V1TableAdapter

    Private Sub BtnViewDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewDetail.Click
        DataGridClient_RowDoubleClick(sender, e)
    End Sub


    Private Sub UIRegDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim STRSQL As String = "SELECT  COUNT(CASE WHEN client_sex = 'M' THEN 1 ELSE NULL END) AS Male, COUNT(CASE WHEN client_sex = 'F' THEN 1 ELSE NULL END) AS Female, COUNT(CLIENT_SEX) AS Total FROM CCAMH_CLIENTS"

        'Dim DA_Client1 As New SqlClient.SqlDataAdapter(STRSQL, DA_Client.Connection) ' DS_CCAMHClientRegistrationTableAdapters.CCAMH_CLIENTSTableAdapter
        'Dim regNewClient As New DataTable 'KTGSYS.DS_CCAMHClientRegistration.CCAMH_CLIENTSDataTable
        'Dim regFollowUp As DataTable

        '' Get Impression
        'Dim SQL_IMP As String = "select COUNT(case when CLIENT_PSYCHIATRIC=1 then 1 else NULL end) as GREEN,COUNT(case when CLIENT_NEUROLOGICAL=1 then 1 else NULL end) as BLUE,COUNT(case when CLIENT_DDISORDER=1 then 1 else NULL end) as YELLOW,COUNT(case when CLIENT_PSYCHOLOGICAL=1 then 1 else NULL end) as PINK from CLIENT_CA_SOCIAL"
        'Dim DA_Social As New SqlClient.SqlDataAdapter(SQL_IMP, DA_Client_Social.Connection)
        'Dim Impression As New DataTable

        'DA_Client1.Fill(regNewClient)
        'DA_Social.Fill(Impression)
        'regFollowUp = DA_Reg_Detail.GetRegFollowUp

        'For Each row As DataRow In regNewClient.Rows
        '    lblNewRegisterM.Text = row("Male")
        '    lblNewRegisterF.Text = row("Female")
        '    lblNewRegisterTotal.Text = row("Total")
        'Next

        'For Each row As DataRow In Impression.Rows
        '    lblImpBlue.Text = row("BLUE")
        '    lblImpGreen.Text = row("GREEN")
        '    lblImpPink.Text = row("PINK")
        '    lblImpYellow.Text = row("YELLOW")
        'Next

    End Sub
    Private Sub TotalRegistration()
        ' ======= condition 0= new regis, and 1= followup 
        'Dim TblRegisTotalNew As DataTable = DA_ClientManagement.SelectTotalClientRegist(0, DFrom.Value.Date, DTo.Value.Date)
        'Dim TblRegisTotalFollwUp As DataTable = DA_ClientManagement.SelectTotalClientRegist(1, DFrom.Value.Date, DTo.Value.Date)

        'For Each row As DataRow In TblRegisTotalNew.Rows
        '    lblNewRegisterM.Text = row("Male")
        '    lblNewRegisterF.Text = row("Female")
        '    lblNewRegisterTotal.Text = row("Total")
        'Next

        'For Each row As DataRow In TblRegisTotalFollwUp.Rows
        '    lblFollowUpM.Text = row("Male")
        '    lblFollowUpF.Text = row("Female")
        '    lblFollowUpTotal.Text = row("Total")
        'Next

        lblFollowUpM.Text = DA_View_ClientMG.TotalMaleRegister(1, DFrom.Value.Date, DTo.Value.Date)
        lblFollowUpF.Text = DA_View_ClientMG.TotalFemaleRegister(1, DFrom.Value.Date, DTo.Value.Date)
        lblFollowUpTotal.Text = CDbl(EmptyString(lblFollowUpM.Text)) + CDbl(EmptyString(lblFollowUpF.Text))

        lblNewRegisterM.Text = DA_View_ClientMG.TotalMaleRegister(0, DFrom.Value.Date, DTo.Value.Date)
        lblNewRegisterF.Text = DA_View_ClientMG.TotalFemaleRegister(0, DFrom.Value.Date, DTo.Value.Date)
        lblNewRegisterTotal.Text = CDbl(EmptyString(lblNewRegisterM.Text)) + CDbl(EmptyString(lblNewRegisterF.Text))
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New FormDiagnosis
        frm.ShowDialog()
    End Sub

    Private Sub btnUpdatePatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdatePatient.Click
        ' If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim frm As New FormClientRegistration1
            frm.getIsEdit = True
            frm.getPatientNo = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString ' DataGridClient.GetRow.Cells("CLIENT_NO").Value 'gridAppointment.GetRow.Cells(0).Value
            frm.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub BtnNewRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewRegistration.Click
        '    Dim frmClientReg As New FormClientRegistration
        Dim frmClientReg As New FormClientRegistration1
        ' frmClientReg.ShowDialog()
        If frmClientReg.ShowDialog() = DialogResult.OK Then

            ''''=================== Refresh Client registration ===========================
            RadClientNo.Checked = True
            Me.TxtClientNo.Text = frmClientReg.TxtClientNo.Text()
            FindClientInformation()
        End If
    End Sub


    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtClientNo.Enabled = RadClientNo.Checked
        TxtClientNo.Select()
        TxtClientNo.Focus()
    End Sub

    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNameKH.CheckedChanged
        TxtClientNameKh.Enabled = RadClientNameKH.Checked
        TxtClientNameKh.Focus()
        TxtClientNameKh.Select()
        TxtClientNameKh.SelectAll()
    End Sub

    Private Sub RadClientTel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientTel.CheckedChanged
        TxtClientTel.Enabled = RadClientTel.Checked
        TxtClientTel.Select()
        TxtClientTel.Focus()
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub



    Private Sub DataGridClient_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs)
        'If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim frm As New FormClientRegistration1
            frm.getIsEdit = True
            frm.getPatientNo = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString  'DataGridClient.GetRow.Cells("CLIENT_NO").Value
            frm.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateOrViewClientRegister.Click
        'If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim frm As New FormClientRegistration1
        frm.getIsEdit = True
        frm.getPatientNo = CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString) ' CDbl(DataGridClient.GetRow.Cells("CLIENT_NO").Value)
        frm.ShowDialog()
        FindClientInformation()
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindClientInformation()
    End Sub
    Private Sub FindClientInformation()
        If RadViewAllClient.Checked = True Then
            'DataGridClient.DataSource = DA_CLIENT_INFO.SelectAllClientDateToDate(DFrom.Value.Date, DTo.Value.Date)
            GridClientRegistration.DataSource = DA_CLIENT_INFO.SelectAllClientDateToDate(DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadClientNo.Checked = True Then
            ' DataGridClient.DataSource = DA_CLIENT_INFO.SelectClientByNo(EmptyString(TxtClientNo.Text))
            GridClientRegistration.DataSource = DA_CLIENT_INFO.SelectClientByNo(EmptyString(TxtClientNo.Text))
        ElseIf RadClientNameEng.Checked = True Then
            '  DataGridClient.DataSource = DA_CLIENT_INFO.SelectClientByEngname(TxtClientNameEng.Text)
            GridClientRegistration.DataSource = DA_CLIENT_INFO.SelectClientByEngname(TxtClientNameEng.Text)
        ElseIf RadClientNameKH.Checked = True Then
            ' DataGridClient.DataSource = DA_CLIENT_INFO.SelectClientByKhName(TxtClientNameKh.Text)
            GridClientRegistration.DataSource = DA_CLIENT_INFO.SelectClientByKhName(TxtClientNameKh.Text)
        ElseIf RadClientTel.Checked = True Then
            'DataGridClient.DataSource = DA_CLIENT_INFO.SelectClientByPhonNumber(TxtClientTel.Text)
            GridClientRegistration.DataSource = DA_CLIENT_INFO.SelectClientByPhonNumber(TxtClientTel.Text)
        ElseIf RadOldClientNo.Checked = True Then
            ' DataGridClient.DataSource = DA_CLIENT_INFO.SelectClientByOldNo(TxtOldClientNo.Text)
            GridClientRegistration.DataSource = DA_CLIENT_INFO.SelectClientByOldNo(TxtOldClientNo.Text)
        End If
        TotalRegistration()
    End Sub

    Private Sub BtnClientFollowupRegis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientFollowupRegis.Click
        '   If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        If DA_ClientMG.CheckExistingClientAtTheSameDay(1, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString, GetDateServer.Date) >= 1 Then
            MessageBox.Show("The client already register in client followup. Please check in manage cleint menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim FFollowUpReceipt As New FollowUpClientReceiptV1
        FFollowUpReceipt.TxtClientNo.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString 'DataGridClient.GetRow.Cells("CLIENT_NO").Value
        FFollowUpReceipt.TxtClientNo.ReadOnly = True
        FFollowUpReceipt.BtnFind_Click(sender, e)
        'FFollowUpReceipt.TxtClientAge.Text = DataGridClient.GetRow.Cells("").Value
        'FFollowUpReceipt.TxtClientSex.Text = DataGridClient.GetRow.Cells("").Value
        'If DataGridClient.GetRow.Cells("CLIENT_SOCIAL_SERVICETYPE").Value = "A" Then


        If FFollowUpReceipt.ShowDialog = DialogResult.OK Then
            DA_ClientMG.InsertClientManagement(FFollowUpReceipt.TxtClientNo.Text, FFollowUpReceipt.TxtClientName.Text, FFollowUpReceipt.TxtClientSex.Text, FFollowUpReceipt.TxtClientAge.Text, "", FFollowUpReceipt.CboDiagnosis.Text, FFollowUpReceipt.DateReceipt.Value.Date, 1, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_ADDRESS_PHONE").ToString, FFollowUpReceipt.LblDiagnosisID.Text, FFollowUpReceipt.LblImpression.Text, FFollowUpReceipt.LblDiagnosisID.Text, IIf(FFollowUpReceipt.CboMainTherapy.SelectedValue Is Nothing, Nothing, FFollowUpReceipt.CboMainTherapy.SelectedValue), FFollowUpReceipt.CboMainTherapy.Text)
            DA_ClientMG.UpdateAppointmentstatus(FFollowUpReceipt.CboAppointStatus.Text, DA_ClientMG.SelectClientMG_IDBYClientNo(FFollowUpReceipt.TxtClientNo.Text, FFollowUpReceipt.DateReceipt.Value.Date))
            DA_Client.UpdateNumVisit(FFollowUpReceipt.TxtClientNo.Text)
            TotalRegistration()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'If DataGridClient.SelectedItems.Count = 0 Then Exit Sub
        Dim FPrintPreview As New RegisPrintPreview
        Dim CRRegisPreview As New RegistrationPreview
        TblClient = DA_Reg_Preview.GetDataByClientNo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)
        TblFamilyRelativeCome = DA_FamilyComeDetail.SelectRelativeComeByClientNo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)
        TblReferredDetail = DA_Referred_Detail.SelectReferedByClientNo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)
        TblNeuroDetail = DA_Neuro_Detail.GetDataByClientNo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)

        TblPsychoMinorDetail = DA_Psycho_Minor_Detail.GetDataByClientNo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)
        TblPsychoMajorDetail = DA_Psycho_Major_Detail.GetDataByClientNo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)
        TblDisorderDetail = DA_Disorder_Detail.GetDataByClientNo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)


        ' CRRegisPreview.SetDataSource(TblClient)
        CRRegisPreview.Database.Tables(0).SetDataSource(TblClient)

        CRRegisPreview.Database.Tables(1).SetDataSource(TblNeuroDetail)
        CRRegisPreview.Database.Tables(2).SetDataSource(TblPsychoMinorDetail)
        CRRegisPreview.Database.Tables(3).SetDataSource(TblPsychoMajorDetail)
        CRRegisPreview.Database.Tables(4).SetDataSource(TblDisorderDetail)
        'CRRegisPreview.Database.Tables(5).SetDataSource(TblReferredDetail)
        CRRegisPreview.Subreports("ReferredByRecport").SetDataSource(TblReferredDetail)
        CRRegisPreview.Subreports("FamilyRelativeCome").SetDataSource(TblFamilyRelativeCome)
        ' CRRegisPreview.SetDataSource(TblClient)
        CRRegisPreview.Database.Tables(0).SetDataSource(TblClient)
        CRRegisPreview.Database.Tables(1).SetDataSource(TblNeuroDetail)
        FPrintPreview.CrystalReportObject = CRRegisPreview
        FPrintPreview.ShowDialog()
        FPrintPreview.Close()
    End Sub

    Private Sub RadOldClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadOldClientNo.CheckedChanged
        TxtOldClientNo.Enabled = RadOldClientNo.Checked
        TxtOldClientNo.Focus()
        TxtOldClientNo.SelectAll()
    End Sub


    Private Sub BtnPatientArchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPatientArchive.Click
        Dim FClientRegisterArchive As New FormClientRegisterArchive
        If FClientRegisterArchive.ShowDialog = DialogResult.OK Then

        End If
    End Sub


    Private Sub RadClientNameEng_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientNameEng.CheckedChanged
        TxtClientNameEng.Enabled = RadClientNameEng.Checked
        TxtClientNameEng.Select()
        TxtClientNameEng.Focus()
        TxtClientNameEng.SelectAll()
    End Sub

    Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        If e.Column.FieldName = "RowNo" Then
            e.Value = e.ListSourceRowIndex + 1

        End If
    End Sub








    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Try
            Dim select_value As Double = CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CLIENT_NO").ToString)
            'GridEX1.DataSource = DA_Reg_Preview.GetDataByClientNo(select_value)
            GridEX2.DataSource = DA_Client_Social.GetDataByClientNo(select_value)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnExportFile_Click(sender As Object, e As EventArgs) Handles BtnExportFile.Click
        Dim SaveFile As New SaveFileDialog
        SaveFile.Filter = "Excell(.xlsx)|*.xlsx|Win-Word(.docx)|*.docs|pdf-File(.pdf)|*.pdf"  ' Excell|*.xlsx || Win-Word|*.docs || PDF|*.pdf"
        SaveFile.Title = "Export Files"
        If SaveFile.ShowDialog = DialogResult.OK Then
            Dim Filename = SaveFile.FileName
            '' MessageBox.Show(Path.GetExtension(Filename))
            If Path.GetExtension(Filename) = ".xlsx" Then
                GridClientRegistration.ExportToXlsx(Filename)
                Process.Start(Filename)
            ElseIf Path.GetExtension(Filename) = ".docx" Then
                GridClientRegistration.ExportToDocx(Filename)
                Process.Start(Filename)
            ElseIf Path.GetExtension(Filename) = ".pdf" Then
                GridClientRegistration.ExportToPdf(Filename)
                Process.Start(Filename)
            End If
        End If
    End Sub
End Class
