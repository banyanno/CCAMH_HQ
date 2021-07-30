Imports Janus.Windows.GridEX

Public Class FormTransportation
    Dim DAProvince As New DSAddressTableAdapters.TBL_PROVINCETableAdapter
    Dim DATransportation As New DSCashCollectionTableAdapters.CCAMH_TRANSPORTATIONTableAdapter
    Dim DAClient As New DSCashCollectionTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim DA_OfferPara As New DSCashCollectionTableAdapters.CCAMH_TRANS_OFFER_PARATableAdapter

    Public TblTranDetailZTem As DataTable = New DSCashCollection.CCAMH_TRANS_DETAILDataTable
    Dim DA_TranDetail As New DSCashCollectionTableAdapters.CCAMH_TRANS_DETAILTableAdapter


    Public IS_UPDATE = False
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        With CboProvince
            .DataSource = DAProvince.GetData
            .ValueMember = "PROVINCEID"
            .DisplayMember = "PROV_EN"
            .SelectedValue = -1
        End With
        With CboOffer
            .DataSource = DA_OfferPara.GetData
            .ValueMember = "TRANS_OFFER_ID"
            .DisplayMember = "TRANS_OFFER"
            .SelectedIndex = -1
        End With
        TxtAmountOffer.Text = ""
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub



    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindingClientNo()
    End Sub
    Private Sub FindingClientNo()
        If ValidateTextField(TxtClientNo, "", ErrTransportation) = False Then Exit Sub
        Dim TblClient As DataTable = DAClient.SelectClientInfoByClientNo(EmptyString(TxtClientNo.Text))
        If TblClient.Rows.Count = 0 Then
            MessageBox.Show("Wrong client no. Please check again.", "Find Client", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClientNo.Focus()
            TxtClientNo.SelectAll()
            TxtClientName.Text = ""
            TxtClientSex.Text = ""
            TxtClientAge.Text = ""
        Else
            For Each DRows As DataRow In TblClient.Rows
                TxtClientName.Text = DRows("CLIENT_NAME")
                TxtClientSex.Text = DRows("CLIENT_SEX")
                TxtClientAge.Text = DRows("CLIENT_AGE")
            Next
        End If
    End Sub


    Private Sub TxtClientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindingClientNo()
        End If
    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        ' If ValidateTextField(TxtClientNo, "", ErrTransportation) = False Then Exit Sub
        If ValidateDateField(DateReceipt, "", ErrTransportation) = False Then Exit Sub
        If ValidateTextField(TxtClientName, "", ErrTransportation) = False Then Exit Sub
        If ValidateTextField(TxtClientSex, "", ErrTransportation) = False Then Exit Sub
        If ValidateTextField(TxtClientAge, "", ErrTransportation) = False Then Exit Sub



        If GridTransDetail.SelectedItems.Count = 0 Then
            MessageBox.Show("Please add transport service.", "Transport", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ValidateTextField(TxtAmmount, "", ErrTransportation) = False Then Exit Sub
        If ValidateCombobox(CboProvince, "", ErrTransportation) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new client transportation?", "Transport", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DATransportation.InsertNewTransportation(DateReceipt.Value.Date, TxtClientNo.Text, TxtClientName.Text, TxtClientSex.Text, TxtClientAge.Text, TxtAllocateTo.Text, EmptyString(TxtAmmount.Text), CboProvince.Text, TxtRemark.Text) = 1 Then
                    Dim MaxID As Double = DATransportation.GetLastInsert
                    '================ Loop to insert Transaction detail ============================
                    For Each GRow As GridEXRow In GridTransDetail.GetRows
                        DA_TranDetail.InsertTransportDetail(MaxID, GRow.Cells("TRAN_OFFER").Value, GRow.Cells("TRAN_OFFER_AMOUNT").Value, GetExchangeRate)
                    Next

                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to save new client transportation?", "Transport", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DATransportation.UpdateTransport(DateReceipt.Value.Date, TxtClientNo.Text, TxtClientName.Text, TxtClientSex.Text, TxtClientAge.Text, TxtAllocateTo.Text, EmptyString(TxtAmmount.Text), CboProvince.Text, TxtRemark.Text, LblSaveOption.Text) = 1 Then
                    DA_TranDetail.DeleteTransportDetail(LblSaveOption.Text)
                    '================ Loop to insert Transaction detail ============================
                    For Each GRow As GridEXRow In GridTransDetail.GetRows
                        DA_TranDetail.InsertTransportDetail(LblSaveOption.Text, GRow.Cells("TRAN_OFFER").Value, GRow.Cells("TRAN_OFFER_AMOUNT").Value, GetExchangeRate)
                    Next

                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If


    End Sub



    Private Sub TxtAmmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmmount.KeyPress
        SetDisableKeyString(e)
    End Sub



    Private Sub CboOffer_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboOffer.SelectedValueChanged
        If CboOffer.SelectedValue Is Nothing Then Exit Sub
        TxtAmountOffer.Text = ""
        Try
            TxtAmountOffer.Text = DA_OfferPara.GetOfferAmount(CboOffer.SelectedValue)
            TxtAmountOffer.Focus()
        Catch ex As Exception
            TxtAmountOffer.Text = ""
        End Try
    End Sub

    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click

        CallAddItem()
    End Sub
    Private Sub CallAddItem()
        If ValidateCombobox(CboOffer, "", ErrTransportation) = False Then Exit Sub
        If ValidateTextField(TxtAmountOffer, "", ErrTransportation) = False Then Exit Sub

        If CboOffer.SelectedValue Is Nothing Then
            MessageBox.Show("Please select the correct skill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboOffer.Focus()
            CboOffer.SelectAll()
            Exit Sub
        End If


        If CheckExistingItem(CboOffer.SelectedValue.ToString, "TRAN_DETAIL_ID") = True Then
            MessageBox.Show("The offer already add to list. Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboOffer.Focus()
            CboOffer.SelectAll()
            Exit Sub
        Else
            AddItemTem(CboOffer.SelectedValue, CboOffer.Text, NearestHundred(EmptyString(TxtAmountOffer.Text)))
        End If

    End Sub
    Function CheckExistingItem(ByVal ItemId As Integer, ByVal Field As String) As Boolean
        For Each row As Janus.Windows.GridEX.GridEXRow In GridTransDetail.GetRows
            If row.Cells(Field).Value = ItemId Then
                Return True
                Exit Function
                'Else
                '    Return False
            End If
        Next
    End Function
    '================ Add item ================================
    Private Sub AddItemTem(ByVal TRAN_DETAIL_ID As Integer, ByVal TRAN_OFFER As String, ByVal TRAN_OFFER_AMOUNT As Integer)
        Dim Drow As DataRow = TblTranDetailZTem.NewRow
        Drow("TRAN_DETAIL_ID") = TRAN_DETAIL_ID
        Drow("TRAN_OFFER") = TRAN_OFFER
        Drow("TRAN_OFFER_AMOUNT") = TRAN_OFFER_AMOUNT
        'Drow("PACKAGE_NAME") = PACKAGE_NAME
        'Drow("PACKAGE_PRICE") = PACKAGE_PRICE
        'Drow("PACKAGE_TYPE") = SocialType

        TblTranDetailZTem.Rows.Add(Drow)
        RefreshAddTem()
        TotalTransportAmount(Me.GridTransDetail, "TRAN_OFFER_AMOUNT")
        CleanForm()
    End Sub
    Private Sub TotalTransportAmount(ByVal GridEXDetail As GridEX, ByVal FielGrid As String)
        Dim TotalAmount As Double = 0
        For Each GRow As GridEXRow In GridEXDetail.GetRows
            TotalAmount = TotalAmount + CDbl(GRow.Cells(FielGrid).Value)
        Next
        TxtAmmount.Text = FormatNumber(TotalAmount)

    End Sub
    Private Sub RefreshAddTem()
        GridTransDetail.Refresh()
        GridTransDetail.DataSource = TblTranDetailZTem
    End Sub
    Private Sub CleanForm()
        CboOffer.SelectedIndex = -1
        CboOffer.Text = ""
        TxtAmountOffer.Text = ""
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click
        If GridTransDetail.Row < 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove medicine?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            RemoveItemTem(GridTransDetail.Row)
        End If
    End Sub
    Private Sub RemoveItemTem(ByVal index As Integer)
        TblTranDetailZTem.BeginLoadData()
        TblTranDetailZTem.Rows.RemoveAt(index)
        TblTranDetailZTem.EndLoadData()
        RefreshAddTem()
        TotalTransportAmount(GridTransDetail, "TRAN_OFFER_AMOUNT")
    End Sub

    'Private Sub FormTransportation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    If IS_UPDATE = True Then

    '    End If
    'End Sub

    Private Sub TxtAmountOffer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmountOffer.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtClientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub ChIsInCenter_CheckedChanged(sender As Object, e As EventArgs) Handles ChIsInCenter.CheckedChanged
        If ChIsInCenter.Checked = False Then
            TxtClientName.ReadOnly = False
            TxtClientSex.ReadOnly = False
            TxtClientAge.ReadOnly = False
        Else
            TxtClientName.ReadOnly = True
            TxtClientSex.ReadOnly = True
            TxtClientAge.ReadOnly = True
        End If
        
    End Sub

    Private Sub TxtClientAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClientAge.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class