Public Class DashboardSetting
    'Dim DASetting As New DataSetSceenSettingTableAdapters.SCREEN_SYSTEMSETTINGTableAdapter
   

    
    Private Sub RefreshScreenSetting()
        'DGSetting.Refresh()
        'DGSetting.DataSource = DASetting.GetData
        'DGSetting.Refresh()
        'ModCommon.NumberAllRowHeaderDataGrid(DGSetting)
    End Sub

    Private Sub DashboardSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshScreenSetting()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        CallUpdateSetting()
    End Sub

    Private Sub DGSetting_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGSetting.CellDoubleClick
        CallUpdateSetting()
    End Sub
    Private Sub CallUpdateSetting()
        If DGSetting.SelectedCells.Count = 0 Then Exit Sub
        Dim row As DataGridViewRow = Me.DGSetting.Rows(DGSetting.SelectedCells(0).RowIndex)
        Dim ScreenSetting As New ScreeningSetting
        ScreenSetting.LblSaveOption.Text = row.Cells("SETTING_ID").Value
        ScreenSetting.DateSetting.Checked = True
        ScreenSetting.DateSetting.Value = row.Cells("SETTING_DATE").Value
        ScreenSetting.TxtHealthName.Text = row.Cells("HEALTH_NAME").Value
        ScreenSetting.CboProNo.Text = row.Cells("PROVINCE").Value
        ScreenSetting.CboDisNo.Text = row.Cells("DISTRICT").Value
        ScreenSetting.CboCommNo.Text = row.Cells("COMMUNE").Value
        ScreenSetting.TxtFullAddress.Text = row.Cells("FULL_ADDRESS").Value
        ScreenSetting.ChDefaultsetting.Checked = row.Cells("IS_DEFOUL").Value
        If ScreenSetting.ShowDialog() = DialogResult.OK Then
            RefreshScreenSetting()
        End If
    End Sub

    Private Sub BtnNewSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewSetting.Click
        Dim SSetting As New ScreeningSetting
        If SSetting.ShowDialog() = DialogResult.OK Then
            RefreshScreenSetting()
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshScreenSetting()
    End Sub

    Private Sub BtnUpdateSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateSetting.Click
        CallUpdateSetting()
    End Sub
End Class
