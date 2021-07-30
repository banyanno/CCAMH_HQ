
Public Class FormDiagnosis
    Dim ds_diagnosis As New DS_CCAMHClientRegistrationTableAdapters.CCAMH_DIAGNOSISTableAdapter
    Dim DTtable As DataTable
    'mDim cmdBld As New 
    Private rowPost As Integer
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FormDiagnosis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' TblClient = DAFormDiagnosis_Load_Client.GetData
        'DataGridClient.DataSource = TblClient
        DTtable = ds_diagnosis.GetData
        DGDiagnosis.DataSource = DTtable
        Dim myDRow As DataRow = DTtable.Rows(0)
        Dim strDiagnosis As String
        Dim strMis As String

        'strDiagnosis = myDRow("DIAGNOSIS")
        'strMis = myDRow("DIAGNOSIS_MISSC")
        'tbxDiagnosis.Text = strDiagnosis.ToString
        'tbxMisc.Text = strMis.ToString
        Me.showRecords()
        If tbxDiagnosis.Text <> "" And tbxMisc.Text <> "" Then
            btnSave.Text = "Update"
            If btnSave.Text = "Update" Then
                'DTtable.Rows(rowPost)("DIAGNOSIS") = tbxDiagnosis.Text
                'DTtable.Rows(rowPost)("DIAGNOSIS_MISSC") = tbxMisc.Text
                'ds_diagnosis.updateDiagnosis(tbxDiagnosis.Text, tbxMisc.Text)
                'Dim currROW As Integer
                'currROW = CInt(DTtable.Rows(rowPost)("DIAGNOSIS_NO"))
                'ds_diagnosis.updateDiagnosis(tbxDiagnosis.Text, tbxMisc.Text, currROW)
                'DTtable.Rows(rowPost)("DIAGNOSIS") = tbxDiagnosis.Text
                'DTtable.Rows(rowPost)("DIAGNOSIS_MISSC") = tbxMisc.Text
                btnSave_Click(sender, e)
            Else
                btnSave_Click(sender, e)
            End If

        End If
    End Sub
    Private Sub showRecords()
        If DTtable.Rows.Count = 0 Then
            tbxDiagnosis.Text = ""
            tbxMisc.Text = ""
            Exit Sub
        End If
        tbxDiagnosis.Text = DTtable.Rows(rowPost)("DIAGNOSIS").ToString
        tbxMisc.Text = DTtable.Rows(rowPost)("DIAGNOSIS_MISSC").ToString
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "Update" Then
            Dim currROW As Integer
            currROW = CInt(DTtable.Rows(rowPost)("DIAGNOSIS_NO"))
            ds_diagnosis.updateDiagnosis(tbxDiagnosis.Text, tbxMisc.Text, currROW)
        Else
            If MessageBox.Show("Do you really want to save the client information?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                ds_diagnosis.insertDiagnosis(tbxDiagnosis.Text, tbxMisc.Text)
                'FormDiagnosis_Load(sender, e)

            Else
                MessageBox.Show("Erro Diagnosis. Please verify data and enter it again!", "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub DGDiagnosis_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles DGDiagnosis.FormattingRow

    End Sub
End Class