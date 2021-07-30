Public Class FormSelectItem
    Dim DA_Item As New DSDrugReportTableAdapters.VItemListTableAdapter
    Dim DashDrugReport As UIDrugReport
    Sub New(DashDrugReport As UIDrugReport)

        ' This call is required by the designer.
        InitializeComponent()
        Me.DashDrugReport = DashDrugReport
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormSelectItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridItem.DataSource = DA_Item.GetData
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        checkedRows = GridItem.GetCheckedRows()
        If checkedRows.Length = 0 Then
            MessageBox.Show("Please check at least 1 item generate report.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            'MessageBox.Show(GridDrugReport.GetRows.Count)
            If GridItem.SelectedItems.Count = 0 Then
                MessageBox.Show("You can not save drug audit. Please generate list of drug audit?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Do you want to save generate drug report?", "Drug Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'MainFormApplicationPublic.StatusLoading(True, "Saving drug audit")
                ''GridDrugReport.Row = 0
                'DashDrugReport.BGRunSummary.RunWorkerAsync()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class