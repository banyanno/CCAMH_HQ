Public Class FrmNewOccupation



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

   

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtOccupation, "", ErrOccupation) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            Dim DialogSave As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DialogSave = System.Windows.Forms.DialogResult.Yes Then
                If ModOccupation.InsertOccupation(TxtOccupation.Text) = 1 Then
                    MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                    GridOccupation.DataSource = ModOccupation.SelectAllOccupation
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            Dim DialogUpdate As DialogResult = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DialogUpdate = System.Windows.Forms.DialogResult.Yes Then
                If ModOccupation.UpdateOccupation(LblSaveOption.Text, TxtOccupation.Text) = 1 Then
                    MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                    GridOccupation.DataSource = ModOccupation.SelectAllOccupation
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        LblSaveOption.Text = "0"
        TxtOccupation.Text = ""
        TxtOccupation.Select()
        TxtOccupation.Focus()
    End Sub

    Private Sub FrmNewOccupation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridOccupation.DataSource = ModOccupation.SelectAllOccupation
    End Sub

    Private Sub GridOccupation_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridOccupation.RowDoubleClick
        If GridOccupation.SelectedItems.Count = 0 Then Exit Sub
        LblSaveOption.Text = GridOccupation.GetRow.Cells("OccNo").Value
        TxtOccupation.Text = GridOccupation.GetRow.Cells("Occupation").Value
    End Sub

    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If GridOccupation.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ModOccupation.DeleteOccupation(LblSaveOption.Text) = 1 Then
                GridOccupation.DataSource = ModOccupation.SelectAllOccupation
            End If
        End If
    End Sub

    Private Sub GridOccupation_SelectionChanged(sender As Object, e As EventArgs) Handles GridOccupation.SelectionChanged
        If GridOccupation.SelectedItems.Count = 0 Then Exit Sub
        LblSaveOption.Text = GridOccupation.GetRow.Cells("OccNo").Value
        TxtOccupation.Text = GridOccupation.GetRow.Cells("Occupation").Value
    End Sub
End Class