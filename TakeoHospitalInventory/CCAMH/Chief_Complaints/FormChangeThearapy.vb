Public Class FormChangeThearapy
    Dim DA_Therapist As New DS_CCAMH_THERAPISTSTableAdapters.CCAMH_THERAPISTSTableAdapter
    Dim DA_Assessment As New DS_ClientImpressionTableAdapters.CLIENT_CA_SOCIALTableAdapter 'DS_CCAMHClient_ImpressionsTableAdapters.CLIENT_CA_SOCIALTableAdapter
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        With CboThearapyName
            .DataSource = DA_Therapist.GetData
            .ValueMember = "THERAPIST_ID"
            .DisplayMember = "THERAPIST_NAME"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Do you want to change client to another therapy?", "Change Therapy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            DA_Assessment.UpdateMainTherapy(CInt(IIf(CboThearapyName.SelectedValue Is Nothing, 0, CboThearapyName.SelectedValue)), CboThearapyName.Text, TxtClientNo.Text)
            Me.Close()
        End If
    End Sub
End Class