Public Class FormFindItemAdjust
    Dim DashAdjustment As UCDashboardAdjustStock
    Sub New(DashAdjustment As UCDashboardAdjustStock)

        ' This call is required by the designer.
        InitializeComponent()
        Me.DashAdjustment = DashAdjustment
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        If ValidateTextField(TxtItemName, "", ErrorProvider1) = False Then Exit Sub
        DashAdjustment.FindAdjustByItemName(Me.TxtItemName.Text)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class