Public Class FormSocialServiceSetting
    Dim DA_ServiceNew As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_NEWSERVIEC_PARATableAdapter
    Dim DA_ServiceOld As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_OLDSERVICE_PARATableAdapter
    Dim DA_ServiceMedic As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_MEDICINCE_PARATableAdapter
    Dim DA_ServiceSpacial As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_SPACIALSERVICE_PARATableAdapter
    Private Sub BtnClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose1.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        If ValidateTextField(TxtServiceNewA, "", ErrServiceSocial) = False Then Exit Sub
        If ValidateTextField(TxtServiceNewB, "", ErrServiceSocial) = False Then Exit Sub
        If ValidateTextField(TxtServiceNewC, "", ErrServiceSocial) = False Then Exit Sub
        If LblSaveOptionNew.Text = 0 Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                DA_ServiceNew.UpdateUnuse(False)
                If DA_ServiceNew.InsertNewServiceFee(EmptyString(TxtServiceNewA.Text), EmptyString(TxtServiceNewB.Text), EmptyString(TxtServiceNewC.Text), True) = 1 Then
                    RefreshServiceNew()
                    CleanFormServiceNew()
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                DA_ServiceNew.UpdateUnuse(False)
                If DA_ServiceNew.UpdateServiceNew(EmptyString(TxtServiceNewA.Text), EmptyString(TxtServiceNewB.Text), EmptyString(TxtServiceNewC.Text).ToString, True, GridServiceNew.GetRow.Cells("NEW_PRICE_ID").Value.ToString) = 1 Then
                    RefreshServiceNew()
                    CleanFormServiceNew()
                End If
            End If
        End If
    End Sub
    Private Sub CleanFormServiceNew()
        LblSaveOptionNew.Text = "0"
        TxtServiceNewA.Text = ""
        TxtServiceNewB.Text = ""
        TxtServiceNewC.Text = ""
    End Sub
    Private Sub RefreshServiceNew()
        GridServiceNew.DataSource = DA_ServiceNew.GetData
    End Sub

    Private Sub BtnRemoveNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveNew.Click
        If GridServiceNew.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            If DA_ServiceNew.DeleteService(GridServiceNew.GetRow.Cells("NEW_PRICE_ID").Value.ToString) = 1 Then
                RefreshServiceNew()
                CleanFormServiceNew()
            End If
        End If
    End Sub

    Private Sub GridServiceNew_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridServiceNew.RowDoubleClick
        If GridServiceNew.SelectedItems.Count = 0 Then Exit Sub
        TxtServiceNewA.Text = GridServiceNew.GetRow.Cells("NEW_PRICE_A").Value
        TxtServiceNewB.Text = GridServiceNew.GetRow.Cells("NEW_PRICE_B").Value
        TxtServiceNewC.Text = GridServiceNew.GetRow.Cells("NEW_PRICE_C").Value
        LblSaveOptionNew.Text = GridServiceNew.GetRow.Cells("NEW_PRICE_ID").Value
    End Sub

    Private Sub LoadAllService()
        RefreshServiceNew()
        RefreshServiceOld()
     
    End Sub

    Private Sub FormSocialServiceSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAllService()
    End Sub

    Private Sub TxtServiceNewA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtServiceNewA.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtServiceNewB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtServiceNewB.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtServiceNewC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtServiceNewC.KeyPress
        SetDisableKeyString(e)
    End Sub



    '============================ Save for Old service social ===========================
    Private Sub CleanFormServiceOld()
        LblSaveServiceOld.Text = "0"
        TxtServiceOldA.Text = ""
        TxtServiceOldB.Text = ""
        TxtServiceOldC.Text = ""
        TxtServiceOldA.Focus()
    End Sub
    Private Sub RefreshServiceOld()
        GridServiceOld.DataSource = DA_ServiceOld.GetData
    End Sub
    Private Sub BtnAddServiceOld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddServiceOld.Click
        If ValidateTextField(TxtServiceOldA, "", ErrServiceSocial) = False Then Exit Sub
        If ValidateTextField(TxtServiceOldB, "", ErrServiceSocial) = False Then Exit Sub
        If ValidateTextField(TxtServiceOldC, "", ErrServiceSocial) = False Then Exit Sub
        If LblSaveServiceOld.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                DA_ServiceOld.UpdateServiceActive(False)
                If DA_ServiceOld.InsertOldService(EmptyString(TxtServiceOldA.Text), EmptyString(TxtServiceOldB.Text), EmptyString(TxtServiceOldC.Text), True) = 1 Then
                    RefreshServiceOld()
                    CleanFormServiceOld()
                End If
            End If
            
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                DA_ServiceOld.UpdateServiceActive(False)
                If DA_ServiceOld.UpdateServiceOld(EmptyString(TxtServiceOldA.Text), EmptyString(TxtServiceOldB.Text), EmptyString(TxtServiceOldC.Text), True, LblSaveServiceOld.Text) = 1 Then
                    RefreshServiceOld()
                    CleanFormServiceOld()
                End If
            End If
        End If
    End Sub

    Private Sub GridServiceOld_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridServiceOld.RowDoubleClick
        If GridServiceOld.SelectedItems.Count = 0 Then Exit Sub
        TxtServiceOldA.Text = GridServiceOld.GetRow.Cells("OLD_PRICE_A").Value
        TxtServiceOldB.Text = GridServiceOld.GetRow.Cells("OLD_PRICE_B").Value
        TxtServiceOldC.Text = GridServiceOld.GetRow.Cells("OLD_PRICE_C").Value
        LblSaveServiceOld.Text = GridServiceOld.GetRow.Cells("OLD_PRICE_ID").Value
    End Sub

    Private Sub BtnRemoveServiceOld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveServiceOld.Click
        If GridServiceOld.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            If DA_ServiceOld.DeleteServiceOld(GridServiceOld.GetRow.Cells("OLD_PRICE_ID").Value) = 1 Then
                RefreshServiceOld()
            End If
        End If
    End Sub

    Private Sub TxtServiceOldA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtServiceOldA.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtServiceOldB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtServiceOldB.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtServiceOldC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtServiceOldC.KeyPress
        SetDisableKeyString(e)
    End Sub



  



    Private Sub TxtServiceMedA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtServiceMedB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtServiceMedC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

   


  

    Private Sub TxtServiceSpacialA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub
End Class