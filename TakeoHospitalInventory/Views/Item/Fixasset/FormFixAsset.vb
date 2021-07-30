Public Class FormFixAsset
    Dim DA_FixAsset As New DS_FIXASSETTableAdapters.FIX_ASSETTableAdapter
    Dim DA_Dep As New DS_FIXASSETTableAdapters.tblDepartmentTableAdapter
    Dim DA_AssetCategory As New DS_FIXASSETTableAdapters.CCAMH_ASSET_CATEGORYTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboLocation
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
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtAssetCode, "", ErrFixAsset) = False Then Exit Sub
        If ValidateDateTimePicker(DateBuy, "", ErrFixAsset) = False Then Exit Sub
        If ValidateCombobox(CboLocation, "", ErrFixAsset) = False Then Exit Sub
        If CboLocation.SelectedValue Is Nothing Then
            MessageBox.Show("Please select department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboLocation.Select()
            CboLocation.Focus()
            Exit Sub
        End If
        If ValidateCombobox(CboAssetCategory, "", ErrFixAsset) = False Then Exit Sub
        If CboAssetCategory.SelectedValue Is Nothing Then
            MessageBox.Show("Please select asset category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboAssetCategory.Select()
            CboAssetCategory.Focus()
            Exit Sub
        End If
        ' If ValidateCombobox(CboAssetStatus, "", ErrFixAsset) = False Then Exit Sub
        If CboAssetStatus.Text = "DISPOSAL" Then
            If ValidateDateField(DateDisposal, "", ErrFixAsset) = False Then Exit Sub
        End If
        If ValidateTextField(TxtDescriptionItem, "", ErrFixAsset) = False Then Exit Sub

        If ValidateTextField(TxtCost, "", ErrFixAsset) = False Then Exit Sub
        'If ValidateTextField(TxtDonor, "", ErrFixAsset) = False Then Exit Sub

        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new fix asset?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_FixAsset.InsertNewAsset(CboLocation.SelectedValue.ToString, CboLocation.Text, DateBuy.Value.Date, TxtDescriptionItem.Text, TxtAssetCode.Text, EmptyString(TxtCost.Text), TxtDonor.Text, TxtRemarks.Text, CboAssetCategory.SelectedValue, CboAssetCategory.Text, EmptyString(TxtQTY.Text), TxtDonor.Text, TxtUser.Text, TxtModelSerial.Text, CboAssetStatus.Text, IIf(DateDisposal.Checked = False, Nothing, DateDisposal.Value.Date)) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update fix asset?", "update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_FixAsset.UpdateFixAsset(CboLocation.SelectedValue.ToString, CboLocation.Text, DateBuy.Value.Date, TxtDescriptionItem.Text, TxtAssetCode.Text, EmptyString(TxtCost.Text), TxtDonor.Text, TxtRemarks.Text, CboAssetCategory.SelectedValue, CboAssetCategory.Text, EmptyString(TxtQTY.Text), TxtDonor.Text, TxtUser.Text, TxtModelSerial.Text, CboAssetStatus.Text, IIf(DateDisposal.Checked = False, Nothing, DateDisposal.Value.Date), LblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub TxtProductPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAddCategroy_Click(sender As Object, e As EventArgs) Handles BtnAddCategroy.Click
        Dim FAssetCatetory As New FormAssetCategory
        If FAssetCatetory.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            With CboAssetCategory
                .DataSource = DA_AssetCategory.GetData
                .ValueMember = "ASSET_CATEGORY_ID"
                .DisplayMember = "ASSET_CATEGORY"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Private Sub FormFixAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtAssetCode.Select()
        TxtAssetCode.Focus()
    End Sub

    Private Sub CboAssetStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAssetStatus.SelectedIndexChanged
        If CboAssetStatus.Text = "DISPOSAL" Then
            DateDisposal.Checked = False
            DateDisposal.Enabled = True
        Else
            DateDisposal.Checked = False
            DateDisposal.Enabled = False
        End If
        
    End Sub
End Class