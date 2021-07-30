Public Class FormSocialMedicinceSetting
    Dim DACategory As New DSSocialEconomicSettingTableAdapters.tblCategoryTableAdapter
    Dim DA_ServiceMedic As New DSSocialEconomicSettingTableAdapters.CCAMH_PRICE_MEDICINCE_PARATableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboCategory
            .DataSource = DACategory.GetData
            .ValueMember = "CateID"
            .DisplayMember = "CateName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

  
    Private Sub RefreshServiceMed()
        GridServiceMed.DataSource = DA_ServiceMedic.GetData
    End Sub
    Private Sub CleanFormServiceMed()
        LblSaveMedic.Text = "0"
        TxtServiceMedA.Text = ""
        TxtServiceMedB.Text = ""
        TxtServiceMedC.Text = ""
        TxtServiceMedA.Focus()
    End Sub

    Private Sub BtnAddMedA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMedA.Click
        If ValidateTextField(TxtServiceMedA, "", ErrServiceSocial) = False Then Exit Sub
        If ValidateTextField(TxtServiceMedB, "", ErrServiceSocial) = False Then Exit Sub
        If ValidateTextField(TxtServiceMedC, "", ErrServiceSocial) = False Then Exit Sub
        If LblSaveMedic.Text = "0" Then
            If DA_ServiceMedic.CheckExistingCatSetting(CInt(CboCategory.SelectedValue)) > 0 Then
                MessageBox.Show("The category item already exist setting in Social service.", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                DA_ServiceMedic.UpdateServiceMedActive(False)
                If DA_ServiceMedic.InsertServiceMed(EmptyString(TxtServiceMedA.Text), EmptyString(TxtServiceMedB.Text), EmptyString(TxtServiceMedC.Text), True, CInt(CboCategory.SelectedValue), CboCategory.Text) = 1 Then
                    RefreshServiceMed()
                    CleanFormServiceMed()
                End If
            End If
        Else
            If MessageBox.Show("Do you want to udate?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                DA_ServiceMedic.UpdateServiceMedActive(False)
                If DA_ServiceMedic.UpdateServiceMed(EmptyString(TxtServiceMedA.Text), EmptyString(TxtServiceMedB.Text), EmptyString(TxtServiceMedC.Text), True, CboCategory.SelectedValue.ToString, CboCategory.Text, LblSaveMedic.Text) = 1 Then
                    RefreshServiceMed()
                    CleanFormServiceMed()
                End If
            End If
        End If
    End Sub

    Private Sub GridServiceMed_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridServiceMed.RowDoubleClick
        LblSaveMedic.Text = GridServiceMed.GetRow.Cells("MEDIC_PRICE_ID").Value
        CboCategory.SelectedValue = GridServiceMed.GetRow.Cells("CATEGORY_ID").Value
        CboCategory.Text = GridServiceMed.GetRow.Cells("CATEGORY_NAME").Value
        TxtServiceMedA.Text = GridServiceMed.GetRow.Cells("MEDIC_PRICE_A").Value
        TxtServiceMedB.Text = GridServiceMed.GetRow.Cells("MEDIC_PRICE_B").Value
        TxtServiceMedC.Text = GridServiceMed.GetRow.Cells("MEDIC_PRICE_C").Value
        TxtServiceMedA.Focus()
    End Sub

    Private Sub FormSocialMedicinceSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshServiceMed()
    End Sub

    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnRemoveMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveMed.Click
        If GridServiceMed.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_ServiceMedic.DeleteSercieMed(GridServiceMed.GetRow.Cells("MEDIC_PRICE_ID").Value) = 1 Then
                RefreshServiceMed()
                CleanFormServiceMed()
            End If
        End If
    End Sub
End Class