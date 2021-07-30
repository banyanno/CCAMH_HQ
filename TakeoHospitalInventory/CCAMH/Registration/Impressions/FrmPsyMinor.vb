Public Class FrmPsyMinor


    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Trim(txtSymptom.Text) = "" Then Exit Sub
        If lblPsyMinorSave.Text = "0" Then
            Dim diaglogSave As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaglogSave = System.Windows.Forms.DialogResult.Yes Then
                If MImpressions.InsertPsyMinor(txtSymptom.Text, txtDescription.Text) = 1 Then
                    '  MsgBox(MSG_SAVE, MsgBoxStyle.Information, "Save")
                    GridPsychoMinor.DataSource = MImpressions.GetAllPsyMinor
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If

            End If
        Else
            Dim diaglogSave As DialogResult = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaglogSave = System.Windows.Forms.DialogResult.Yes Then
                If MImpressions.UpdatePsyMinor(txtSymptom.Text, txtDescription.Text, lblPsyMinorSave.Text) = 1 Then
                    '  MsgBox(MSG_SAVE, MsgBoxStyle.Information, "Save")
                    GridPsychoMinor.DataSource = MImpressions.GetAllPsyMinor
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If

            End If
        End If
    End Sub
    'SYMPTOM_NAME =N'" & SYM_NAME & "',DESCRIPTION=N'" & DESC & "' WHERE SYMPTOM_ID=" 
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If GridPsychoMinor.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If MImpressions.DeletePsyMinor(GridPsychoMinor.GetRow.Cells("SYMPTOM_ID").Value) = 1 Then
                GridPsychoMinor.DataSource = MImpressions.GetAllPsyMinor
            End If
        End If
    End Sub

    Private Sub GridPsychoMinor_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPsychoMinor.RowDoubleClick
        If GridPsychoMinor.SelectedItems.Count = 0 Then Exit Sub
        lblPsyMinorSave.Text = GridPsychoMinor.GetRow.Cells("SYMPTOM_ID").Value
        Try
            txtSymptom.Text = GridPsychoMinor.GetRow.Cells("SYMPTOM_NAME").Value
        Catch ex As Exception
            txtSymptom.Text = ""
        End Try
        Try
            txtDescription.Text = GridPsychoMinor.GetRow.Cells("DESCRIPTION").Value
        Catch ex As Exception
            txtDescription.Text = ""
        End Try
        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        lblPsyMinorSave.Text = "0"
        txtSymptom.Text = ""
        txtDescription.Text = ""
        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub

    Private Sub GridPsychoMinor_SelectionChanged(sender As Object, e As EventArgs) Handles GridPsychoMinor.SelectionChanged
        If GridPsychoMinor.SelectedItems.Count = 0 Then Exit Sub
        lblPsyMinorSave.Text = GridPsychoMinor.GetRow.Cells("SYMPTOM_ID").Value
        Try
            txtSymptom.Text = GridPsychoMinor.GetRow.Cells("SYMPTOM_NAME").Value
        Catch ex As Exception
            txtSymptom.Text = ""
        End Try
        Try
            txtDescription.Text = GridPsychoMinor.GetRow.Cells("DESCRIPTION").Value
        Catch ex As Exception
            txtDescription.Text = ""
        End Try

        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub

    Private Sub FrmPsyMinor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GridPsychoMinor.DataSource = MImpressions.GetAllPsyMinor
    End Sub
End Class