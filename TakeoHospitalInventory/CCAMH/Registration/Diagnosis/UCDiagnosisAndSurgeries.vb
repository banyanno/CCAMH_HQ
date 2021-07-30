Public Class UCDiagnosisAndSurgeries

    Dim DA_DiagCategory As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_DIAGNOSIS_CATEGORYTableAdapter
    Dim DA_Diagnosis As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_DIAGNOSISTableAdapter

    
    

 


    Private Sub GridSubDiagnosis_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridSubDiagnosis.CellDoubleClick
        Try
            Dim fSubDiagnosis As New FRMDiagnosis
            fSubDiagnosis.LblSaveOption.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(0).Value
            fSubDiagnosis.LblMainDiagID.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(1).Value
            fSubDiagnosis.txtDiagnosis.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(2).Value
            fSubDiagnosis.txtDescription.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(3).Value
            fSubDiagnosis.TxtCode.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(4).Value
            fSubDiagnosis.ShowDialog()
            If fSubDiagnosis.DialogResult = DialogResult.OK Then
                GridSubDiagnosis.DataSource = ModDiagnosis.SelectSubDiagnosis(fSubDiagnosis.LblMainDiagID.Text)
            End If
        Catch ex As Exception

        End Try

    End Sub

    

    Private Sub DeleteSubDiagnosisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSubDiagnosisToolStripMenuItem.Click
        Try
            Dim rowIndex As Integer = GridSubDiagnosis.SelectedCells(0).RowIndex
            Dim subDiagnosisNo As String = GridSubDiagnosis.Rows(rowIndex).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModDiagnosis.DeleteSubDiagnosisBySSID(subDiagnosisNo) = 1 Then
                    MsgBox("Delete sub diagnosis successfully.", MsgBoxStyle.Information, "Delete")
                Else
                    MsgBox("Error delete sub diagnosis.", MsgBoxStyle.Critical, "Error")
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnFindSurgeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindSurgeries.Click
        GridSurgeries.DataSource = ModSurgeries.SelectSurgeriesByType(TxtSurgeries.Text)
        ModCommon.NumberAllRowHeaderDataGrid(GridSurgeries)
    End Sub

    Private Sub BtnNewSurgeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewSurgeries.Click
        Dim FSurgeries As New FRMSurgeryType
        FSurgeries.ShowDialog()
        If FSurgeries.isSurgClose = True Then
            LoadSurgeries(FSurgeries.TxtSurgeriesType.Text)
        End If
        FSurgeries.Dispose()
        FSurgeries.Close()
    End Sub
    Sub LoadSurgeries(ByVal Surgeries As String)
        GridSurgeries.DataSource = ModSurgeries.SelectSurgeriesByType(Surgeries)
        ModCommon.NumberAllRowHeaderDataGrid(GridSurgeries)
    End Sub

    Private Sub GridSurgeries_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridSurgeries.CellDoubleClick
        'Try
        Dim FSurgeries As New FRMSurgeryType
        FSurgeries.LblSaveOption.Text = GridSurgeries.Rows(e.RowIndex).Cells("TypeSID").Value
        FSurgeries.TxtSurgeriesType.Text = GridSurgeries.Rows(e.RowIndex).Cells("Surgeries").Value
        FSurgeries.TxtDescription.Text = GridSurgeries.Rows(e.RowIndex).Cells("SurgDescription").Value
        If TypeOf GridSurgeries.Rows(e.RowIndex).Cells("SurgeriesFee").Value Is DBNull Then
            FSurgeries.TxtSurgeryPrice.Text = 0
        Else
            FSurgeries.TxtSurgeryPrice.Text = GridSurgeries.Rows(e.RowIndex).Cells("SurgeriesFee").Value
        End If

        FSurgeries.ChTypeOther.Checked = GridSurgeries.Rows(e.RowIndex).Cells("TypeSurgeries").Value
        FSurgeries.ShowDialog()
        If FSurgeries.isSurgClose = True Then
            LoadSurgeries("")
        End If
        FSurgeries.Dispose()
        FSurgeries.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim rowIndex As Integer = GridSurgeries.SelectedCells(0).RowIndex
            Dim No As String = GridSurgeries.Rows(rowIndex).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModSurgeries.DeleteSurgeries(No) = 1 Then
                    MsgBox("Delete sub diagnosis successfully.", MsgBoxStyle.Information, "Delete")
                    LoadSurgeries("")
                Else
                    MsgBox("Error delete sub diagnosis.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim NDiagnosisCate As New FormDiagnosisCategory
        If NDiagnosisCate.ShowDialog = DialogResult.OK Then
            RefreshDiagnosisCate()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim NNewDiagnosis As New FormDiagnosisCCAMH(Me)
        If NNewDiagnosis.ShowDialog = DialogResult.OK Then
            ' RefreshDianosis()
            'If GridDiagnosisCategory.SelectedItems.Count = 0 Then Exit Sub
            GridDiagnosis.DataSource = DA_Diagnosis.SelectDiagosisByCategory(NNewDiagnosis.CboDiagnosisCategory.SelectedValue) 'GridDiagnosisCategory.GetRow.Cells("DIAGNOSIS_CAT_ID").Value)
        End If
    End Sub

    Private Sub GridDiagnosisCategory_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDiagnosisCategory.SelectionChanged
        If GridDiagnosisCategory.SelectedItems.Count = 0 Then Exit Sub
        RefreshDiagnosisByCategory(GridDiagnosisCategory.GetRow.Cells("DIAGNOSIS_CAT_ID").Value)
    End Sub
    Public Sub RefreshDiagnosisByCategory(ByVal CategoryID As Integer)
        GridDiagnosis.DataSource = DA_Diagnosis.SelectDiagosisByCategory(CategoryID)
    End Sub
    Private Sub RefreshDiagnosisCate()
        GridDiagnosisCategory.DataSource = DA_DiagCategory.GetData
    End Sub
    Private Sub RefreshDianosis()
        GridDiagnosis.DataSource = DA_Diagnosis.GetData
    End Sub

    Private Sub GridDiagnosisCategory_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDiagnosisCategory.RowDoubleClick
        If GridDiagnosisCategory.SelectedItems.Count = 0 Then Exit Sub
        Dim NDiagnosisCate As New FormDiagnosisCategory
        NDiagnosisCate.LblSaveOption.Text = GridDiagnosisCategory.GetRow.Cells("DIAGNOSIS_CAT_ID").Value
        NDiagnosisCate.TxtCategroy.Text = GridDiagnosisCategory.GetRow.Cells("DIAGNOSIS_CATETORY").Value
        If NDiagnosisCate.ShowDialog = DialogResult.OK Then
            RefreshDiagnosisCate()
        End If

    End Sub

    Private Sub GridDiagnosis_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDiagnosis.RowDoubleClick
        If GridDiagnosis.SelectedItems.Count = 0 Then Exit Sub
        Dim FDiagnosis As New FormDiagnosisCCAMH
        FDiagnosis.LblSaveOption.Text = GridDiagnosis.GetRow.Cells("diagnosis_id").Value
        FDiagnosis.CboDiagnosisCategory.Text = GridDiagnosis.GetRow.Cells("category").Value

        FDiagnosis.TxtCode.Text = GridDiagnosis.GetRow.Cells("Code").Value
        FDiagnosis.TxtDianosis.Text = GridDiagnosis.GetRow.Cells("diagnosis").Value
        If FDiagnosis.ShowDialog = DialogResult.OK Then
            'RefreshDianosis()
            GridDiagnosis.DataSource = DA_Diagnosis.SelectDiagosisByCategory(FDiagnosis.CboDiagnosisCategory.SelectedValue)
            'If GridDiagnosisCategory.SelectedItems.Count = 0 Then Exit Sub
            'GridDiagnosis.DataSource = DA_Diagnosis.SelectDiagosisByCategory(GridDiagnosisCategory.GetRow.Cells("DIAGNOSIS_CAT_ID").Value)
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshDiagnosisCate()
        'If GridDiagnosisCategory.SelectedItems.Count = 0 Then Exit Sub
        'GridDiagnosis.DataSource = DA_Diagnosis.SelectDiagosisByCategory(GridDiagnosisCategory.GetRow.Cells("DIAGNOSIS_CAT_ID").Value)
    End Sub

    Private Sub UCDiagnosisAndSurgeries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshDiagnosisCate()
    End Sub
End Class
