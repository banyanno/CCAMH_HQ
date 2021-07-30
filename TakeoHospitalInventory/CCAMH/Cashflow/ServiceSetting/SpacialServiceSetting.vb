Public Class SpacialServiceSetting
    Dim DA_Skill As New DSSocialEconomicSettingTableAdapters.CCAMH_SKILLTableAdapter
    Dim DA_Package As New DSSocialEconomicSettingTableAdapters.CCAMH_PACKAGETableAdapter
    Dim DA_SpacialSetting As New DSSocialEconomicSettingTableAdapters.CCAMH_SPACIAL_SERVICE_PACKAGETableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboSkill
            .DataSource = DA_Skill.GetData
            .ValueMember = "SKILL_ID"
            .DisplayMember = "SKILL_NAME"
            .SelectedIndex = -1
        End With
        With CboPackage
            .DataSource = DA_Package.GetData
            .ValueMember = "PACKAGE_ID"
            .DisplayMember = "PACKAGE_NAME"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnAddSkill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddSkill.Click
        Dim FnewSkill As New AddNewSkill
        If FnewSkill.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            With CboSkill
                .DataSource = DA_Skill.GetData
                .ValueMember = "SKILL_ID"
                .DisplayMember = "SKILL_NAME"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Private Sub BtnAddPackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPackage.Click
        Dim FNewPackage As New AddNewPackage
        If FNewPackage.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            With CboPackage
                .DataSource = DA_Package.GetData
                .ValueMember = "PACKAGE_ID"
                .DisplayMember = "PACKAGE_NAME"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateCombobox(CboSkill, "", ErrSpacial) = False Then Exit Sub
        If ValidateCombobox(CboPackage, "", ErrSpacial) = False Then Exit Sub
        If ValidateTextField(TxtServiceA, "", ErrSpacial) = False Then Exit Sub
        If ValidateTextField(TxtServiceB, "", ErrSpacial) = False Then Exit Sub
        If ValidateTextField(TxtServiceC, "", ErrSpacial) = False Then Exit Sub
        If CboSkill.SelectedValue Is Nothing Then
            MessageBox.Show("Please select correct value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboSkill.Focus()
            CboSkill.SelectAll()
            Exit Sub
        End If
        If CboPackage.SelectedValue Is Nothing Then
            MessageBox.Show("Please select correct value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboPackage.Focus()
            CboPackage.SelectAll()
            Exit Sub
        End If
        If MessageBox.Show("Do you want to save setting spacial service?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_SpacialSetting.InsertSpacialServicePackage(CboSkill.SelectedValue, CboPackage.Text, EmptyString(TxtServiceA.Text), EmptyString(TxtServiceB.Text), EmptyString(TxtServiceC.Text), CboSkill.Text) = 1 Then
                RefreshSpacialService()
            End If

        End If
    End Sub
    Private Sub RefreshSpacialService()
        GridServiceSpacial.DataSource = DA_SpacialSetting.GetData
        CboSkill.SelectedIndex = -1
        CboPackage.SelectedIndex = -1
        TxtServiceA.Text = ""
        TxtServiceB.Text = ""
        TxtServiceC.Text = ""
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If GridServiceSpacial.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete setting?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_SpacialSetting.DeleteSpacialService(GridServiceSpacial.GetRow.Cells("SKILL_SERVICE_ID").Value) = 1 Then
                RefreshSpacialService()
            End If

        End If
    End Sub

    Private Sub SpacialServiceSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshSpacialService()
    End Sub

    Private Sub TxtServiceA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtServiceA.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtServiceB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtServiceB.Click
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtServiceC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtServiceC.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class