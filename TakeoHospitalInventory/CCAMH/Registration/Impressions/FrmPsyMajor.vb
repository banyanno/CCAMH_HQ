Public Class FrmPsyMajor

    
    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Trim(txtSymptom.Text) = "" Then Exit Sub
        If lblPsyMajorSave.Text = "0" Then
            Dim diaglogSave As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaglogSave = System.Windows.Forms.DialogResult.Yes Then
                If MImpressions.InsertPsyMajor(txtSymptom.Text, txtDescription.Text) = 1 Then
                    '  MsgBox(MSG_SAVE, MsgBoxStyle.Information, "Save")
                    Me.GridPsychoMajor.DataSource = MImpressions.GetAllPsyMajor
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If

            End If
        Else
            Dim diaglogSave As DialogResult = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaglogSave = System.Windows.Forms.DialogResult.Yes Then
                If MImpressions.UpdatePsyMajor(txtSymptom.Text, txtDescription.Text, lblPsyMajorSave.Text) = 1 Then
                    '  MsgBox(MSG_SAVE, MsgBoxStyle.Information, "Save")
                    Me.GridPsychoMajor.DataSource = MImpressions.GetAllPsyMajor
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If

            End If
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        lblPsyMajorSave.Text = "0"
        txtSymptom.Text = ""
        txtDescription.Text = ""
        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub
    'SYMPTOM_NAME =N'" & SYM_NAME & "',DESCRIPTION=N'" & DESC & "' WHERE SYMPTOM_ID=" 
    Private Sub GridPsychoMajor_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPsychoMajor.RowDoubleClick
        lblPsyMajorSave.Text = GridPsychoMajor.GetRow.Cells("SYMPTOM_ID").Value
        txtSymptom.Text = GridPsychoMajor.GetRow.Cells("SYMPTOM_NAME").Value
        Try
            txtDescription.Text = GridPsychoMajor.GetRow.Cells("DESCRIPTION").Value
        Catch ex As Exception
            txtDescription.Text = ""
        End Try

        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If GridPsychoMajor.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If MImpressions.DeletePsyMajor(GridPsychoMajor.GetRow.Cells("SYMPTOM_ID").Value) = 1 Then
                Me.GridPsychoMajor.DataSource = MImpressions.GetAllPsyMajor
            End If
        End If
    End Sub

    Private Sub GridPsychoMajor_SelectionChanged(sender As Object, e As EventArgs) Handles GridPsychoMajor.SelectionChanged
        If GridPsychoMajor.SelectedItems.Count = 0 Then Exit Sub
        lblPsyMajorSave.Text = GridPsychoMajor.GetRow.Cells("SYMPTOM_ID").Value
        txtSymptom.Text = GridPsychoMajor.GetRow.Cells("SYMPTOM_NAME").Value
        Try
            txtDescription.Text = GridPsychoMajor.GetRow.Cells("DESCRIPTION").Value
        Catch ex As Exception
            txtDescription.Text = ""
        End Try

        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub

    Private Sub FrmPsyMajor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GridPsychoMajor.DataSource = MImpressions.GetAllPsyMajor
    End Sub
End Class