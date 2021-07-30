Public Class FormEditPrescription
    Dim DA_Item As New DSSocialEconomicSettingTableAdapters.VItemPriceOpticalShopTableAdapter
    Dim DA_EditPresc As New DSPrescriptionTableAdapters.CCAMH_PRESCRIPTION_DETIALTableAdapter
    Dim DA_Usage As New DSIssueInvoiceTableAdapters.CCAMH_MEDIC_USAGETableAdapter
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitParaMedicine()
        InitParaUsage()
    End Sub
    Private Sub InitParaMedicine()
        With CboMedicine
            .DataSource = DA_Item.SelectListItemFromPharmacy(26)
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub InitParaUsage()
        With CboUsageM
            .DataSource = DA_Usage.GetData
            .ValueMember = "USAGE_ID"
            .DisplayMember = "USAGE"
            .SelectedIndex = -1

        End With
        With CboUsageN
            .DataSource = DA_Usage.GetData
            .ValueMember = "USAGE_ID"
            .DisplayMember = "USAGE"
            .SelectedIndex = -1
        End With
        With CboUsageE
            .DataSource = DA_Usage.GetData
            .ValueMember = "USAGE_ID"
            .DisplayMember = "USAGE"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboMedicine, "", ErrorProvider1) = False Then Exit Sub
        If ValidateCombobox(CboUsageM, "", ErrorProvider1) = False Then Exit Sub
        If ValidateCombobox(CboUsageN, "", ErrorProvider1) = False Then Exit Sub
        If ValidateCombobox(CboUsageE, "", ErrorProvider1) = False Then Exit Sub
        If ValidateCombobox(CboRemark, "", ErrorProvider1) = False Then Exit Sub
        If ValidateTextField(TxtEditPrescriptNote, "", ErrorProvider1) = False Then Exit Sub
        If MessageBox.Show("Do you want to update prescription?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If DA_EditPresc.UpdateEditPrescription(CInt(CboMedicine.SelectedValue), CboMedicine.Text, CboUsageM.Text, CboUsageN.Text, CboUsageE.Text, EmptyString(TxtTotalQTY.Text), TxtEditPrescriptNote.Text, CboRemark.Text, LblPrescriptDedtail.Text) = 1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Error edit prescription!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub TxtTotalQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTotalQTY.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class