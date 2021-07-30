Public Class FormFindPrescription
    Dim Main As DashboardCCAMHPharmacy
    Sub New(ByVal Main As DashboardCCAMHPharmacy)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Main = Main
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If RadClientNo.Checked = True Then
            Main.FindByClientNo(EmptyString(TxtClientNo.Text), DFrom.Value.Date, DTo.Value.Date)
        ElseIf RadAllClient.Checked = True Then
            Main.FindPrescriptionAllClient(DFrom.Value.Date, DTo.Value.Date)

        ElseIf RadClientName.Checked = True Then
            Main.FindByClientName(TxtClientName.Text, DFrom.Value.Date, DTo.Value.Date)
        End If
    End Sub

    Private Sub RadClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtClientNo.Enabled = RadClientNo.Checked
    End Sub

    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientName.CheckedChanged
        TxtClientName.Enabled = RadClientName.Checked
    End Sub
End Class