Public Class FormCome
    Dim DA_ComeInfo As New DSFamilyComeTableAdapters.CLIENT_COME_INFOTableAdapter



    Private Sub FormCome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridRelativeCome.DataSource = DA_ComeInfo.GetData
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboTypeOfRelative, "", ErrRelative) = False Then Exit Sub
        If ValidateTextField(TxtTypeRelative, "", ErrRelative) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_ComeInfo.InsertComeInfo(CboTypeOfRelative.Text, TxtTypeRelative.Text) = 1 Then
                    GridRelativeCome.DataSource = DA_ComeInfo.GetData
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_ComeInfo.UpdateFamilyInfo(CboTypeOfRelative.Text, TxtTypeRelative.Text, LblSaveOption.Text) = 1 Then
                    GridRelativeCome.DataSource = DA_ComeInfo.GetData
                End If
            End If
        End If

    End Sub

    Private Sub GridRelativeCome_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridRelativeCome.RowDoubleClick
        If GridRelativeCome.SelectedItems.Count = 0 Then Exit Sub
        LblSaveOption.Text = GridRelativeCome.GetRow.Cells("COME_INFO_ID").Value
        CboTypeOfRelative.Text = GridRelativeCome.GetRow.Cells("COME_TYPE").Value
        TxtTypeRelative.Text = GridRelativeCome.GetRow.Cells("COME_WITH").Value
        CboTypeOfRelative.Focus()
        CboTypeOfRelative.Select()
    End Sub

    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnNew_Click_1(sender As Object, e As EventArgs) Handles BtnNew.Click
        CboTypeOfRelative.Focus()
        CboTypeOfRelative.Select()
        LblSaveOption.Text = "0"
        CboTypeOfRelative.Text = ""
        TxtTypeRelative.Text = ""
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If GridRelativeCome.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_ComeInfo.DeleteFamilyInfo(GridRelativeCome.GetRow.Cells("COME_INFO_ID").Value) Then
                GridRelativeCome.DataSource = DA_ComeInfo.GetData
            End If
        End If
    End Sub
End Class