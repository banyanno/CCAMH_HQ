Public Class MainReferedBy
    Dim DA_Refer As New DSReferedTableAdapters.CCAMH_REFERED_BY_ORGTableAdapter
    Private Sub BtnNewReferedBy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReferedBy.Click
        Dim FReferedByORG As New ReferedByORG
        If FReferedByORG.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RefreshRefer()
        End If
    End Sub
    Private Sub RefreshRefer()
        GridReferBy.DataSource = DA_Refer.GetData
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RefreshRefer()
    End Sub

    Private Sub BtnUPdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUPdate.Click
        If GridReferBy.SelectedItems.Count = 0 Then Exit Sub
        Dim FReferedByORG As New ReferedByORG
        FReferedByORG.LblSaveOption.Text = GridReferBy.GetRow.Cells("REFER_BY_ID").Value
        FReferedByORG.CboReferType.Text = GridReferBy.GetRow.Cells("REFER_BY_CATEGORY").Value
        FReferedByORG.TxtReferBy.Text = GridReferBy.GetRow.Cells("REFER_BY").Value
        If FReferedByORG.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RefreshRefer()
        End If
    End Sub

    Private Sub BtnDetel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetel.Click
        If GridReferBy.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_Refer.DeleteRefered(GridReferBy.GetRow.Cells("REFER_BY_ID").Value) = 1 Then
                RefreshRefer()
            End If
        End If
    End Sub

    Private Sub MainReferedBy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshRefer()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class