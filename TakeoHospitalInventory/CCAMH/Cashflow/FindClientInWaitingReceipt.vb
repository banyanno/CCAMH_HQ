Public Class FindClientInWaitingReceipt
    Dim PayWaiting As DashboardWaitingPayment
    Sub New(ByVal PayWaiting As DashboardWaitingPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PayWaiting = PayWaiting
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadFindByClientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientNo.CheckedChanged
        TxtClientNo.Enabled = RadClientNo.Checked
        TxtClientNo.Focus()
        TxtClientNo.SelectAll()
    End Sub

    Private Sub RadReceiptNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReceiptNo.CheckedChanged
        TxtReceiptNo.Enabled = RadReceiptNo.Checked
        TxtReceiptNo.Focus()
        TxtReceiptNo.SelectAll()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If RadReceiptNo.Checked = True Then
            Me.PayWaiting.FindReceiptByReceiptNo(EmptyString(TxtReceiptNo.Text))
        ElseIf RadClientNo.Checked = True Then
            Me.PayWaiting.FindReceiptByClientNo(EmptyString(TxtClientNo.Text))
        ElseIf RadClientName.Checked = True Then
            Me.PayWaiting.FindReceiptByClientName(TxtClientName.Text)
        End If
    End Sub

    Private Sub RadClientName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadClientName.CheckedChanged
        TxtClientName.Enabled = RadClientName.Checked
        TxtClientName.Focus()
        TxtClientName.SelectAll()
    End Sub
End Class