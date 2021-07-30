Public Class FrmDDisorder

 

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Trim(txtSymptom.Text) = "" Then Exit Sub
        If lblDisorderSave.Text = "0" Then
            Dim diaglogSave As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaglogSave = System.Windows.Forms.DialogResult.Yes Then
                If MImpressions.InsertDDisorder(txtSymptom.Text, txtDescription.Text) = 1 Then
                    '  MsgBox(MSG_SAVE, MsgBoxStyle.Information, "Save")
                    GridDDisorder.DataSource = MImpressions.GetAllDisorder
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If

            End If
        Else
            Dim diaglogSave As DialogResult = MessageBox.Show(MSG_UPDATE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaglogSave = System.Windows.Forms.DialogResult.Yes Then
                If MImpressions.UpdateDDisorder(txtSymptom.Text, txtDescription.Text, lblDisorderSave.Text) = 1 Then
                    '  MsgBox(MSG_SAVE, MsgBoxStyle.Information, "Save")
                    GridDDisorder.DataSource = MImpressions.GetAllDisorder
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If

            End If
        End If
    End Sub

    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub FrmDDisorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridDDisorder.DataSource = MImpressions.GetAllDisorder
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If GridDDisorder.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If MImpressions.DeleteDDisorder(GridDDisorder.GetRow.Cells("SYMPTOM_ID").Value) = 1 Then
                GridDDisorder.DataSource = MImpressions.GetAllDisorder
            End If
        End If
    End Sub

    Private Sub GridDDisorder_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDDisorder.RowDoubleClick
        lblDisorderSave.Text = GridDDisorder.GetRow.Cells("SYMPTOM_ID").Value
        txtSymptom.Text = GridDDisorder.GetRow.Cells("SYMPTOM_NAME").Value
        Try
            txtDescription.Text = GridDDisorder.GetRow.Cells("DESCRIPTION").Value
        Catch ex As Exception
            txtDescription.Text = ""
        End Try

        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        lblDisorderSave.Text = "0"
        txtSymptom.Text = ""
        txtDescription.Text = ""
        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub

    Private Sub GridDDisorder_SelectionChanged(sender As Object, e As EventArgs) Handles GridDDisorder.SelectionChanged
        If GridDDisorder.SelectedItems.Count = 0 Then Exit Sub
        lblDisorderSave.Text = GridDDisorder.GetRow.Cells("SYMPTOM_ID").Value
        txtSymptom.Text = GridDDisorder.GetRow.Cells("SYMPTOM_NAME").Value
        Try
            txtDescription.Text = GridDDisorder.GetRow.Cells("DESCRIPTION").Value
        Catch ex As Exception
            txtDescription.Text = ""
        End Try

        txtSymptom.Focus()
        txtSymptom.Select()
    End Sub
End Class