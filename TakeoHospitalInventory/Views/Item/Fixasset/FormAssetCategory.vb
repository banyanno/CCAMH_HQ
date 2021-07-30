Public Class FormAssetCategory
    Dim DA_AssetCategory As New DS_FIXASSETTableAdapters.CCAMH_ASSET_CATEGORYTableAdapter
    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub FormAssetCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridAssetCategory.DataSource = DA_AssetCategory.GetData
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        lblSaveOption.Text = "0"
        txtAssetCategory.Text = ""
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If ValidateTextField(txtAssetCategory, "", ErrorProvider1) = False Then Exit Sub
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new asset category?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_AssetCategory.InsertNewAsset(txtAssetCategory.Text) = 1 Then
                    GridAssetCategory.DataSource = DA_AssetCategory.GetData 'Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update asset category?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_AssetCategory.UpdateAssetCategory(txtAssetCategory.Text, lblSaveOption.Text) = 1 Then
                    GridAssetCategory.DataSource = DA_AssetCategory.GetData 'Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub GridAssetCategory_SelectionChanged(sender As Object, e As EventArgs) Handles GridAssetCategory.SelectionChanged
        If GridAssetCategory.SelectedItems.Count = 0 Then Exit Sub
        lblSaveOption.Text = GridAssetCategory.GetRow.Cells("ASSET_CATEGORY_ID").Value
        txtAssetCategory.Text = GridAssetCategory.GetRow.Cells("ASSET_CATEGORY").Value
    End Sub
End Class