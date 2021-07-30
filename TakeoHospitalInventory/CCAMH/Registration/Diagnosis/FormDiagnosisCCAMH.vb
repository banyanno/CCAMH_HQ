Public Class FormDiagnosisCCAMH
    Dim DA_DiagCategory As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_DIAGNOSIS_CATEGORYTableAdapter

    Dim DA_Diagosis As New DS_CCAHMH_CLIENT_MGTableAdapters.CCAMH_DIAGNOSISTableAdapter
    Dim UDiagnosis As UCDiagnosisAndSurgeries
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDiagnosisCategory
            .DataSource = DA_DiagCategory.GetData
            .ValueMember = "DIAGNOSIS_CAT_ID"
            .DisplayMember = "DIAGNOSIS_CATETORY"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal UDiagnosis As UCDiagnosisAndSurgeries)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.UDiagnosis = UDiagnosis
        With CboDiagnosisCategory
            .DataSource = DA_DiagCategory.GetData
            .ValueMember = "DIAGNOSIS_CAT_ID"
            .DisplayMember = "DIAGNOSIS_CATETORY"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboDiagnosisCategory, "", ErrDiagnosis) = False Then Exit Sub
        If ValidateTextField(TxtDianosis, "", ErrDiagnosis) = False Then Exit Sub
        If CboDiagnosisCategory Is Nothing Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Diagosis.InsertNewDiagnosis(TxtCode.Text, TxtDianosis.Text, "", CboDiagnosisCategory.SelectedValue, CboDiagnosisCategory.Text) = 1 Then
                    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Try
                        UDiagnosis.RefreshDiagnosisByCategory(Me.CboDiagnosisCategory.SelectedValue)
                        CleanForm()
                    Catch ex As Exception
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    End Try
                   
                End If

            End If
        Else
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DA_Diagosis.UpdateDiagnosis(TxtCode.Text, TxtDianosis.Text, CboDiagnosisCategory.SelectedValue, CboDiagnosisCategory.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If

            End If
        End If
    End Sub
    Private Sub CleanForm()
        TxtCode.Text = ""
        TxtDianosis.Text = ""
    End Sub
End Class