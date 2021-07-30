Public Class DashboardMainTherapy
    Dim DA_Therapist As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_View_ClientMG As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_VIEW_CLIENT_MANAGERMANT_V1TableAdapter
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Add any initialization after the InitializeComponent() call.
      
    End Sub
    Private Sub RefreshTherapistList()
        GridListOfTherapist.DataSource = DA_Therapist.GetData
    End Sub

    Private Sub BtnNewTherapy_Click(sender As Object, e As EventArgs) Handles BtnNewTherapy.Click
        Dim NewTherapist As New FormTherapist
        If NewTherapist.ShowDialog = DialogResult.OK Then
            RefreshTherapistList()
        End If
    End Sub
    Private Sub FindClientManagement()
        'If RadClientNew.Checked = True Then

        If RadAllClient.Checked = True Then
            Dim TblClient As DataTable = DA_View_ClientMG.SelectDateToDateWithNewOrOld(DFrom.Value.Date, DTo.Value.Date, 0)
            GridClientNew.DataSource = TblClient
        ElseIf RadClientNo.Checked = True Then
            GridClientNew.DataSource = DA_View_ClientMG.SelectClientManageByClientNoNewOrOld(0, EmptyString(TxtClientNo.Text))
        ElseIf RadClientName.Checked = True Then
            Dim stringUPper As String = TxtClientName.Text.ToUpper
            GridClientNew.DataSource = DA_View_ClientMG.SelectClientMGByNameNewOrOld(0, TxtClientName.Text.ToUpper)

        ElseIf RadClientTel.Checked = True Then

            GridClientNew.DataSource = DA_View_ClientMG.SelectClientMGByPhoneNewOrOld(0, TxtClientTel.Text)
       
        End If

    End Sub

    Private Sub BtnnFind_Click(sender As Object, e As EventArgs) Handles BtnnFind.Click
        FindClientManagement()
    End Sub

    Private Sub DashboardMainTherapy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTherapistList()
    End Sub

    'Private Sub GridListOfTherapist_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridListOfTherapist.RowDoubleClick
    '    GridClientNew.DataSource = DA_View_ClientMG.SelectByMainThearapy(0, GridListOfTherapist.GetRow.Cells("THERAPIST_NAME").Value)
    'End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        FindClientManagement()
    End Sub

    Private Sub TxtClientNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadClientNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientNo.CheckedChanged
        TxtClientNo.Enabled = RadClientNo.Checked
        TxtClientNo.Focus()
        TxtClientNo.Select()
    End Sub

    Private Sub RadClientName_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientName.CheckedChanged
        TxtClientName.Enabled = RadClientName.Checked
        TxtClientName.Focus()
        TxtClientName.Select()
    End Sub

    Private Sub RadClientTel_CheckedChanged(sender As Object, e As EventArgs) Handles RadClientTel.CheckedChanged
        TxtClientTel.Enabled = RadClientTel.Checked
        TxtClientTel.Focus()
        TxtClientTel.Select()
    End Sub

  
    Private Sub GridListOfTherapist_SelectionChanged(sender As Object, e As EventArgs) Handles GridListOfTherapist.SelectionChanged
        Try
            GridClientNew.DataSource = DA_View_ClientMG.SelectByMainThearapy(0, GridListOfTherapist.GetRow.Cells("THERAPIST_NAME").Value)
        Catch ex As Exception
            GridClientNew.DataSource = Nothing
        End Try
    End Sub

    Private Sub GridListOfTherapist_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridListOfTherapist.RowDoubleClick
        Dim NewTherapist As New FormTherapist
        NewTherapist.lblSaveOption.Text = GridListOfTherapist.GetRow.Cells("THERAPIST_ID").Value
        NewTherapist.txtTherapistName.Text = GridListOfTherapist.GetRow.Cells("THERAPIST_NAME").Value
        NewTherapist.txtTherapistNotes.Text = GridListOfTherapist.GetRow.Cells("THERAPIST_NOTES").Value
        If NewTherapist.ShowDialog = DialogResult.OK Then
            RefreshTherapistList()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If GridClientNew.SelectedItems.Count = 0 Then Exit Sub
        Dim FChangeThearapy As New FormChangeThearapy
        FChangeThearapy.TxtClientNo.Text = GridClientNew.GetRow.Cells("CLIENT_NO").Value
        FChangeThearapy.TxtClientName.Text = GridClientNew.GetRow.Cells("CLIENT_NAME_KHM").Value
        FChangeThearapy.CboThearapyName.Text = GridClientNew.GetRow.Cells("MAIN_THERAPY_NAME").Value
        FChangeThearapy.ShowDialog()
    End Sub

    Private Sub BtnPrintTherapis_Click(sender As Object, e As EventArgs) Handles BtnPrintTherapis.Click
        If GridListOfTherapist.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select therapy name before print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim tblMainTerapy As DataTable = DA_View_ClientMG.SelectByMainThearapy(0, GridListOfTherapist.GetRow.Cells("THERAPIST_NAME").Value)
        Dim RpClientManageTherapy As New ReportClientManageByThearpy
        RpClientManageTherapy.SetDataSource(tblMainTerapy)
        Dim ReportViewer As New FormPublicReportViewer
        ReportViewer.CrvViewer.ReportSource = RpClientManageTherapy
        ReportViewer.ShowDialog()
    End Sub
End Class
