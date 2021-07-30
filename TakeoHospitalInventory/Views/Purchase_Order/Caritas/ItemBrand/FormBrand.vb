Public Class FormBrand

    Dim DA_Brand As New DSHospitalRequestToCaritasTableAdapters.ITEM_BRANDTableAdapter
    Private Sub BtnNewBrand_Click(sender As Object, e As EventArgs) Handles BtnNewBrand.Click
        Dim FNewBrand As New NewBrand
        If FNewBrand.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshBrand()
        End If
    End Sub
    Private Sub RefreshBrand()
        GridBrand.DataSource = DA_Brand.GetData
    End Sub

    Private Sub GridBrand_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridBrand.RowDoubleClick
        Dim FNewBrand As New NewBrand
        FNewBrand.LblSaveOption.Text = GridBrand.GetRow.Cells("BRAND_ID").Value
        FNewBrand.TxtBrandName.Text = GridBrand.GetRow.Cells("BRAND_NAME").Value
        If FNewBrand.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshBrand()
        End If
    End Sub

    Private Sub FormBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshBrand()
    End Sub
End Class