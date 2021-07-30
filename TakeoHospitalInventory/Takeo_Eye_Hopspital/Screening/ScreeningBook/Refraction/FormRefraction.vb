Public Class FormRefraction
    Public DARefraction As New DataSetScreeningBookTableAdapters.SCREENING_REFRACTION_BOOKTableAdapter
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new refraction?", "Screening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DARefraction.InsertNewRefraction(LblScreenBookID.Text, DateScreening.Value.Date, PatientNo.Text, CboVARight.Text, CboVALeft.Text, cboDiagnosis.Text, TxtREPlus.Text, CboREPlusVA.Text, TxtLEPlus.Text, CboLEPlusVA.Text, CboAdd.Text, False, TxtMoreInfo.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update refraction?", "Screening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DARefraction.UpdateRefraction(DateScreening.Value.Date, CboVARight.Text, CboVALeft.Text, cboDiagnosis.Text, TxtREPlus.Text, CboREPlusVA.Text, TxtLEPlus.Text, CboLEPlusVA.Text, CboAdd.Text, False, TxtMoreInfo.Text, LblScreenBookID.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
End Class