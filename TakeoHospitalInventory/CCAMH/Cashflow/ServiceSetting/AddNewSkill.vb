Public Class AddNewSkill
    Dim DA_Skill As New DSSocialEconomicSettingTableAdapters.CCAMH_SKILLTableAdapter

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ValidateTextField(TxtSkill, "", ErrSkill) = False Then Exit Sub
        If MessageBox.Show("Do you want to save new skill?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_Skill.InsertNewSkill(TxtSkill.Text, "") = 1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
        
    End Sub
End Class