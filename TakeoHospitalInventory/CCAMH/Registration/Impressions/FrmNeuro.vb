Public Class FrmNeuro

 

   

   
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Trim(txtSymptom.Text) = "" Then Exit Sub
        If lblNeuroSave.Text = "0" Then
            Dim diaglogSave As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaglogSave = System.Windows.Forms.DialogResult.Yes Then
                If MImpressions.InsertNeuro(txtSymptom.Text, txtDescription.Text) = 1 Then
                    '  MsgBox(MSG_SAVE, MsgBoxStyle.Information, "Save")
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If

            End If
        Else
            Dim diaglogSave As DialogResult = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaglogSave = System.Windows.Forms.DialogResult.Yes Then
                If MImpressions.UpdateNeuro(txtSymptom.Text, txtDescription.Text, lblNeuroSave.Text) = 1 Then
                    '  MsgBox(MSG_SAVE, MsgBoxStyle.Information, "Save")
                    Me.GridNeuro.DataSource = MImpressions.GetAllNeuro
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If

            End If
        End If
    End Sub

    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If GridNeuro.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If MImpressions.DeleteNeuro(lblNeuroSave.Text) = 1 Then
                Me.GridNeuro.DataSource = MImpressions.GetAllNeuro
            End If
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        lblNeuroSave.Text = "0"
        txtSymptom.Text = ""
        txtDescription.Text = ""
        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub

    Private Sub FrmNeuro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GridNeuro.DataSource = MImpressions.GetAllNeuro
    End Sub
    'SYMPTOM_NAME =N'" & SYM_NAME & "',DESCRIPTION=N'" & DESC & "' WHERE SYMPTOM_ID=" 
    Private Sub GridNeuro_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridNeuro.RowDoubleClick
        lblNeuroSave.Text = GridNeuro.GetRow.Cells("SYMPTOM_ID").Value
        txtSymptom.Text = GridNeuro.GetRow.Cells("SYMPTOM_NAME").Value
        txtDescription.Text = GridNeuro.GetRow.Cells("DESCRIPTION").Value
        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub

    Private Sub GridNeuro_SelectionChanged(sender As Object, e As EventArgs) Handles GridNeuro.SelectionChanged
        If GridNeuro.SelectedItems.Count = 0 Then Exit Sub
        lblNeuroSave.Text = GridNeuro.GetRow.Cells("SYMPTOM_ID").Value
        txtSymptom.Text = GridNeuro.GetRow.Cells("SYMPTOM_NAME").Value
        txtDescription.Text = GridNeuro.GetRow.Cells("DESCRIPTION").Value
        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub
End Class