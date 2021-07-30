Public Class ReferedByORG
    Dim DA_Refered As New DSReferedTableAdapters.CCAMH_REFERED_BY_ORGTableAdapter

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ValidateCombobox(CboReferType, "", ErrReferby) = False Then Exit Sub
        If ValidateTextField(TxtReferBy, "", ErrReferby) = False Then Exit Sub
        If LblSaveOption.Text = 0 Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Refered.InsertNewRefer(CboReferType.Text, TxtReferBy.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Refered.UpdateRefered(CboReferType.Text, TxtReferBy.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
       
    End Sub
End Class