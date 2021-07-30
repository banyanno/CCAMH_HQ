Public Class ScreeningSetting
    'Dim DASetting As New DataSetSceenSettingTableAdapters.SCREEN_SYSTEMSETTINGTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboProNo
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    'Private Sub CboProNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboProNo.GotFocus
    '    With CboProNo
    '        .DataSource = ModProvince.SelectProvice()
    '        .DisplayMember = "Province"
    '        .ValueMember = "IDProvCode"
    '    End With
    '    'CboProNo.Text = ""
    '    ' CboProNo.Text = ""
    '    'CboCommNo.Text = ""
    '    'TxtAddress.Text = ""
    '    Me.CboProNo.SelectAll()
    'End Sub
    Private Sub CboDisNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboDisNo.GotFocus
        If ValidateCombobox(CboProNo, "", ErrSetting) = False Then Exit Sub
        With CboDisNo
            .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
            .DisplayMember = "DISTRICT"
            .ValueMember = "SrokCode"
            .SelectedIndex = -1
        End With
        'CboDisNo.Text = ""
        'CboCommNo.Text = ""
        'TxtAddress.Text = ""

    End Sub
    Private Sub CboCommNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommNo.GotFocus
        If ValidateCombobox(CboDisNo, "", ErrSetting) = False Then Exit Sub
        With CboCommNo
            .DataSource = ModProvince.SelectCommune(CInt(CboDisNo.SelectedValue))
            .DisplayMember = "Commune"
            .ValueMember = "KhumCode"
        End With
        'Me.CboCommNo.SelectAll()
    End Sub
    'Private Sub CboCommNo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.SelectedValueChanged

    '    TxtFullAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
    'End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(DateSetting, "", ErrSetting) = False Then Exit Sub
        If ValidateTextField(TxtHealthName, "", ErrSetting) = False Then Exit Sub
        If ValidateCombobox(CboProNo, "", ErrSetting) = False Then Exit Sub
        If ValidateCombobox(CboDisNo, "", ErrSetting) = False Then Exit Sub
        If ValidateCombobox(CboCommNo, "", ErrSetting) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new setting?", "Setting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                'DASetting.UpdateDefault(False)
                'If DASetting.InsertNewSetting(DateSetting.Value.Date, TxtHealthName.Text, CboProNo.Text, CboDisNo.Text, CboCommNo.Text, TxtFullAddress.Text, ChDefaultsetting.Checked, "") = 1 Then
                '    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                'End If
            End If
        Else
            If MessageBox.Show("Do you want to update setting?", "Setting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                'If DASetting.UpdateScreenSetting(DateSetting.Value.Date, TxtHealthName.Text, CboProNo.Text, CboDisNo.Text, CboCommNo.Text, TxtFullAddress.Text, ChDefaultsetting.Checked, "", LblSaveOption.Text) = 1 Then
                '    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                'End If
            End If
        End If
    End Sub

    'Private Sub CboDisNo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDisNo.DropDown
    '    If ValidateCombobox(CboProNo, "", ErrSetting) = False Then Exit Sub
    '    Try
    '        With CboDisNo
    '            .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
    '            .DisplayMember = "DISTRICT"
    '            .ValueMember = "SrokCode"
    '        End With
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub CboProNo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProNo.DropDown
        CboDisNo.SelectedIndex = -1
        CboCommNo.SelectedIndex = -1
        TxtFullAddress.Text = ""
    End Sub



 
    Private Sub CboCommNo_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.DropDownClosed
        Try
            TxtFullAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ' Call when we mouse move on Panel
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
End Class