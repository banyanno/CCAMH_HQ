'Public Class CLIENT_REGISTRATION_FORM
'    'Dim da_client As New DS_RegistrationTableAdapters.CCAMH_CLIENTSTableAdapter
'    'Dim da_province As New DS_RegistrationTableAdapters.tblProvincesTableAdapter
'    'Dim da_distict As New DS_RegistrationTableAdapters.tblDistrictsTableAdapter


'    'Private Sub CLIENT_REGISTRATION_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.MaximumSizeChanged
'    '    With PROVINCE
'    '        .DataSource = da_province.GetData
'    '        .ValueMember = "IDProvCode"
'    '        .DisplayMember = "Province"
'    '    End With
'    'End Sub

'    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'    '    da_client.INSERT_NEW_CLIENT(1, "AB", "M", 1, Now(), 2, 1, Now, "YES", "NON", "SAN", "UNIVER.", "TEACHER", "TAK", "HIGH SCHOOL", "HOUSWIFE", "#11", "22", "AA", "BB", "CC", "PP", "XXXXX", "REFERE", False, True, False, "AAAA", "TESTEST", "TEST ddd", "REFE ADV", 2019)
'    'End Sub


'    'Private Sub PROVINCE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROVINCE.SelectedIndexChanged
'    '    Try
'    '        With cbodistrict
'    '            .DataSource = da_distict.selectDisctrict_by_Province(PROVINCE.SelectedValue)
'    '            .ValueMember = "SrokCode"
'    '            .DisplayMember = "DISTRICT"
'    '        End With
'    '    Catch ex As Exception

'    '    End Try

'    'End Sub


'    'Private Sub lblTtile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTtile.Click

'    'End Sub

'    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

'    '    If MessageBox.Show("Do you want to close the registration?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
'    '        Me.Close()

'    '    End If



'    'End Sub
'End Class