Public Class FormTherapist
    Dim DA_THERPIST As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(txtTherapistName, "", ErrThearapist) = False Then Exit Sub
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new therapist?", "Therapit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_THERPIST.InsertQuery(Trim(txtTherapistName.Text), txtTherapistNotes.Text) = 1 Then
                    MsgBox("Therapist has been saved.", MsgBoxStyle.Information, "Save")
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
          
        Else
            If MessageBox.Show("Do you want to update therapist info?", "Therapit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_THERPIST.UpdateTherapyInfo(txtTherapistName.Text, txtTherapistNotes.Text, lblSaveOption.Text) = 1 Then
                    MsgBox("Therapist has been update.", MsgBoxStyle.Information, "Update")
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If


    End Sub

    Private Sub FormTherapist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class