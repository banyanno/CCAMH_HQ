Public Class FindFixAsset
    Dim DA_FixAsset As New DS_FIXASSETTableAdapters.FIX_ASSETTableAdapter
    Dim DA_Dep As New DS_FIXASSETTableAdapters.tblDepartmentTableAdapter
    Dim DA_AssetCategory As New DS_FIXASSETTableAdapters.CCAMH_ASSET_CATEGORYTableAdapter
    Dim MainAsset As UFixInventory


    Sub New(MainAsset As UFixInventory)

        ' This call is required by the designer.
        InitializeComponent()
        With CboAssetLocation
            .DataSource = DA_Dep.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedIndex = -1
        End With
        With CboAssetCategory
            .DataSource = DA_AssetCategory.GetData
            .ValueMember = "ASSET_CATEGORY_ID"
            .DisplayMember = "ASSET_CATEGORY"
            .SelectedIndex = -1
        End With
        Me.MainAsset = MainAsset
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        If RadAssetCategory.Checked = True Then
            Me.MainAsset.FindByAssetCategory(CInt(CboAssetCategory.SelectedValue))
        ElseIf RadAssetName.Checked = True Then
            Me.MainAsset.FindByAssetName(Me.TxtAssetDescription.Text)
        ElseIf RadAssetUser.Checked = True Then
            Me.MainAsset.FindByUser(TxtAssetUser.Text)
        ElseIf RadAssetUser.Checked = True Then
            Me.MainAsset.FindByLocation(CInt(CboAssetLocation.SelectedValue))
        ElseIf RadAssetStatus.Checked = True Then
            Me.MainAsset.FindByAssetStatus(CboAssetStatus.Text)
        End If
    End Sub

    Private Sub RadAssetCategory_CheckedChanged(sender As Object, e As EventArgs) Handles RadAssetCategory.CheckedChanged
        CboAssetCategory.Enabled = RadAssetCategory.Checked
        CboAssetCategory.Focus()
    End Sub

    Private Sub RadAssetName_CheckedChanged(sender As Object, e As EventArgs) Handles RadAssetName.CheckedChanged
        TxtAssetDescription.Enabled = RadAssetName.Checked
        TxtAssetDescription.Focus()

    End Sub

    Private Sub RadAssetUser_CheckedChanged(sender As Object, e As EventArgs) Handles RadAssetUser.CheckedChanged
        TxtAssetUser.Enabled = RadAssetUser.Checked
        TxtAssetUser.Focus()
    End Sub

    Private Sub RadAssetLocation_CheckedChanged(sender As Object, e As EventArgs) Handles RadAssetLocation.CheckedChanged
        CboAssetLocation.Enabled = RadAssetLocation.Checked
        CboAssetLocation.Focus()
    End Sub
End Class