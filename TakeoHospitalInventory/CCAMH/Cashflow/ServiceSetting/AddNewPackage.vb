Public Class AddNewPackage
    Dim DA_Package As New DSSocialEconomicSettingTableAdapters.CCAMH_PACKAGETableAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ValidateTextField(TxtPackage, "", ErrPackage) = False Then Exit Sub
        If MessageBox.Show("Do you want to save new package?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_Package.InsertNewPackage(TxtPackage.Text) = 1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class