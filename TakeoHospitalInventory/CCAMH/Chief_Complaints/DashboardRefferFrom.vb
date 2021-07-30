Public Class DashboardRefferFrom
    Dim DA_ReferedBy As New DSReferedTableAdapters.CCAMH_REFERED_BY_ORGTableAdapter
    Dim DA_ReferedFrom As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_VIEW_REFERED_FROMTableAdapter
    Private Sub DashboardRefferFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridListOfReferFrom.DataSource = DA_ReferedBy.GetData
    End Sub

    Private Sub GridListOfReferFrom_SelectionChanged(sender As Object, e As EventArgs) Handles GridListOfReferFrom.SelectionChanged
        Try
            GridClientReferFrom.DataSource = DA_ReferedFrom.SelectReferFromDateToDate(GridListOfReferFrom.GetRow.Cells("REFER_BY").Value, DFrom.Value.Date, DTo.Value.Date)
        Catch ex As Exception
            GridClientReferFrom.DataSource = Nothing
        End Try
    End Sub

    Private Sub BtnnFind_Click(sender As Object, e As EventArgs) Handles BtnnFind.Click
        Dim TblClientReferFrom As DataTable
        If RadAllClient.Checked = True Then
            TblClientReferFrom = DA_ReferedFrom.SelectAllReferFrom(DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadClientNo.Checked = True Then
            TblClientReferFrom = DA_ReferedFrom.SelectReferByClientNo(EmptyString(TxtClientNo.Text))
        ElseIf RadClientName.Checked = True Then
            TblClientReferFrom = DA_ReferedFrom.SelectReferFromByClientName(TxtClientName.Text)
        ElseIf RadClientTel.Checked = True Then
            TblClientReferFrom = DA_ReferedFrom.SelectReferByPhone(TxtClientTel.Text)
        End If
        GridClientReferFrom.DataSource = TblClientReferFrom
    End Sub

    Private Sub BtnPrintReferFrom_Click(sender As Object, e As EventArgs) Handles BtnPrintReferFrom.Click
        If GridListOfReferFrom.SelectedItems.Count = 0 Then Exit Sub
        Dim TblReferFrom As DataTable = DA_ReferedFrom.SelectReferFromDateToDate(GridListOfReferFrom.GetRow.Cells("REFER_BY").Value, DFrom.Value.Date, DTo.Value.Date)
        Dim RClientReferFrom As New ReportReferFrom
        RClientReferFrom.SetDataSource(TblReferFrom)
        RClientReferFrom.SetParameterValue("Title", "Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy"))
        Dim FViewer As New FormPublicReportViewer
        FViewer.CrvViewer.ReportSource = RClientReferFrom
        FViewer.ShowDialog()
    End Sub

    Private Sub TxtClientNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadClientNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientNo.CheckedChanged
        TxtClientNo.Enabled = RadClientNo.Checked
        TxtClientNo.Focus()
    End Sub

    Private Sub RadClientName_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientName.CheckedChanged
        TxtClientName.Enabled = RadClientName.Checked
        TxtClientName.Focus()
    End Sub

    Private Sub RadClientTel_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientTel.CheckedChanged
        TxtClientTel.Enabled = RadClientTel.Checked
        TxtClientTel.Focus()
    End Sub
End Class
