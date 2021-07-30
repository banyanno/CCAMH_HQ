Public Class UFixInventory
    Dim DA_DEP As New DS_FIXASSETTableAdapters.tblDepartmentTableAdapter
    Dim DA_Fixasset As New DS_FIXASSETTableAdapters.FIX_ASSETTableAdapter
    Dim DA_CheckFixAsset As New DS_FIXASSETTableAdapters.FIX_ASSET_CHECKTableAdapter
    Dim DA_VIEW_FIXASSET As New DS_FIXASSETTableAdapters.VIEW_FIXASSETTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDepartment
            .DataSource = DA_DEP.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PopulateNodesFloor(ByVal dtbl As DataTable, ByVal nodes As TreeNodeCollection)
        nodes.Clear()
        For Each dr As DataRow In dtbl.Rows
            Dim tn As New TreeNode
            tn.Name = dr("DepartID").ToString
            tn.Text = dr("DepartName").ToString
            'tn.Tag = dr("FLOOR_DESCRIP").ToString
            nodes.Add(tn)
            'tn.ImageIndex = 0
        Next
    End Sub
    Friend Sub FindByAssetCategory(CateID As Integer)
        Me.GridFixAsset.DataSource = DA_Fixasset.SelectAssetCategory(CateID)
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
    End Sub
    Friend Sub FindByAssetName(Name As String)
        Me.GridFixAsset.DataSource = DA_Fixasset.SelectByItemName(Name)
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
    End Sub
    Friend Sub FindByUser(User As String)
        Me.GridFixAsset.DataSource = DA_Fixasset.SelectByUser(User)
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
    End Sub
    Friend Sub FindByLocation(Lication As String)
        Me.GridFixAsset.DataSource = DA_Fixasset.SelectByLocation(Lication)
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
    End Sub
    Friend Sub FindByAssetStatus(Status As String)
        Me.GridFixAsset.DataSource = DA_Fixasset.SelectByAssetStatus(Status)
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
    End Sub
    Sub RefreshDepart()
        Dim TblDep As DataTable = DA_DEP.GetData
        PopulateNodesFloor(TblDep, TreeDepartment.Nodes)
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
    End Sub

    Private Sub UFixInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
        RefreshDepart()
        TreeDepartment.Focus()
        TreeDepartment.Select()
        Try
            LoadFixAsset(TreeDepartment.SelectedNode.Name)
        Catch ex As Exception

        End Try
        ViewAsset_Click(sender, e)
    End Sub

    Private Sub LoadingFixAsset()
        GridFixAsset.DataSource = DA_Fixasset.GetData

    End Sub
    Private Sub LoadFixAsset(ByVal DepID As Integer)
        GridFixAsset.DataSource = DA_Fixasset.SelectFixAssetByDepID(DepID)
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FixAsset As New FormFixAsset
        If FixAsset.ShowDialog() = DialogResult.OK Then

            Try
                Dim dNode As TreeNode = TreeDepartment.SelectedNode
                GridFixAsset.DataSource = DA_Fixasset.SelectFixAssetByDepID(FixAsset.CboLocation.SelectedValue)
                SplitContainer2.Visible = True
                SplitContainer2.Dock = DockStyle.Fill
                CRVFixAsset.Visible = False
                ' GridFixAsset.DataSource = DA_Fixasset.GetData
            Catch ex As Exception

            End Try
            FixAsset.Dispose()
        End If
    End Sub


    Private Sub BtnUpdateFixAsset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateFixAsset.Click
        If GridFixAsset.SelectedItems.Count = 0 Then Exit Sub
        Dim FFixAsset As New FormFixAsset
        FFixAsset.LblSaveOption.Text = GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value
        FFixAsset.DateBuy.Checked = True
        FFixAsset.DateBuy.Value = GridFixAsset.GetRow.Cells("DATE_BUY").Value
        FFixAsset.CboLocation.SelectedValue = GridFixAsset.GetRow.Cells("DEP_ID").Value
        FFixAsset.TxtDescriptionItem.Text = GridFixAsset.GetRow.Cells("PRODUCT_NAME").Value
        FFixAsset.CboAssetCategory.Text = GridFixAsset.GetRow.Cells("ASSET_CATE_NAME").Value
        FFixAsset.TxtAssetCode.Text = GridFixAsset.GetRow.Cells("PRODUCT_CODE").Value
        FFixAsset.TxtUser.Text = GridFixAsset.GetRow.Cells("ASSET_USER").Value
        FFixAsset.TxtCost.Text = GridFixAsset.GetRow.Cells("PRODUCT_PRICE").Value
        FFixAsset.TxtDonor.Text = GridFixAsset.GetRow.Cells("BUYER").Value
        FFixAsset.TxtRemarks.Text = GridFixAsset.GetRow.Cells("DESCRIPTION").Value
        FFixAsset.CboAssetStatus.Text = IIf(IsDBNull(GridFixAsset.GetRow.Cells("ASSET_STATUS").Value), "", GridFixAsset.GetRow.Cells("ASSET_STATUS").Value)
        Try
            FFixAsset.DateDisposal.Checked = True
            FFixAsset.DateDisposal.Value = GridFixAsset.GetRow.Cells("DATE_DISPOSAL").Value
        Catch ex As Exception
            FFixAsset.DateDisposal.Checked = False
        End Try
        If FFixAsset.ShowDialog = DialogResult.OK Then
            GridFixAsset.DataSource = DA_Fixasset.SelectByFixAssetID(FFixAsset.LblSaveOption.Text)
        End If
        FFixAsset.Dispose()
    End Sub

    Private Sub TreeDepartment_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeDepartment.AfterSelect
        Try
            SplitContainer2.Visible = True
            SplitContainer2.Dock = DockStyle.Fill
            CRVFixAsset.Visible = False

            GridAssetCheck.DataSource = Nothing
            LoadFixAsset(TreeDepartment.SelectedNode.Name)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ViewAsset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAsset.Click
        SplitContainer2.Visible = True
        SplitContainer2.Dock = DockStyle.Fill
        CRVFixAsset.Visible = False
        GridFixAsset.DataSource = DA_Fixasset.GetData
    End Sub

    Private Sub BtnNewCheckAsset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCheckAsset.Click
        If GridFixAsset.SelectedItems.Count = 0 Then Exit Sub
        Dim FCheckAsset As New FormCheckItemFixAsset
        FCheckAsset.LblFixAssetID.Text = GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value
        FCheckAsset.TxtProductName.Text = GridFixAsset.GetRow.Cells("PRODUCT_NAME").Value
        FCheckAsset.TxtProductCode.Text = GridFixAsset.GetRow.Cells("PRODUCT_CODE").Value
        If FCheckAsset.ShowDialog = DialogResult.OK Then
            GridAssetCheck.DataSource = DA_CheckFixAsset.SelectCheckByAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
        End If
    End Sub

    Private Sub GridFixAsset_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridFixAsset.SelectionChanged
        Try
            GridAssetCheck.DataSource = DA_CheckFixAsset.SelectCheckByAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridFixAsset_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFixAsset.RowDoubleClick
        If GridFixAsset.SelectedItems.Count = 0 Then Exit Sub
        If GridFixAsset.GetRow.Cells("FIX_ASS_ID").Text = "" Then Exit Sub
        Dim FFixAsset As New FormFixAsset
        FFixAsset.LblSaveOption.Text = GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value
        ' FFixAsset.DateBuy.Checked = True
        FFixAsset.CboAssetCategory.SelectedValue = GridFixAsset.GetRow.Cells("ASSET_CATE_ID").Value
        FFixAsset.CboAssetCategory.Text = GridFixAsset.GetRow.Cells("ASSET_CATE_NAME").Value
        FFixAsset.TxtModelSerial.Text = GridFixAsset.GetRow.Cells("ASSET_MODEL").Value
        FFixAsset.DateBuy.Checked = True
        FFixAsset.DateBuy.Value = GridFixAsset.GetRow.Cells("DATE_BUY").Value
        FFixAsset.CboLocation.SelectedValue = GridFixAsset.GetRow.Cells("DEP_ID").Value
        FFixAsset.TxtDescriptionItem.Text = GridFixAsset.GetRow.Cells("PRODUCT_NAME").Value
        FFixAsset.TxtAssetCode.Text = GridFixAsset.GetRow.Cells("PRODUCT_CODE").Value
        FFixAsset.TxtQTY.Text = GridFixAsset.GetRow.Cells("ASSET_QTY").Value
        FFixAsset.TxtCost.Text = GridFixAsset.GetRow.Cells("PRODUCT_PRICE").Value
        FFixAsset.TxtUser.Text = GridFixAsset.GetRow.Cells("ASSET_USER").Value
        FFixAsset.TxtDonor.Text = GridFixAsset.GetRow.Cells("BUYER").Value
        FFixAsset.TxtRemarks.Text = GridFixAsset.GetRow.Cells("DESCRIPTION").Value
        Try
            FFixAsset.DateDisposal.Checked = True
            FFixAsset.DateDisposal.Value = GridFixAsset.GetRow.Cells("DATE_DISPOSAL").Value
        Catch ex As Exception
            FFixAsset.DateDisposal.Checked = False
        End Try
        If FFixAsset.ShowDialog = DialogResult.OK Then
            GridFixAsset.DataSource = DA_Fixasset.SelectByFixAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
        End If
        FFixAsset.Dispose()
    End Sub

    Private Sub GridAssetCheck_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAssetCheck.RowDoubleClick
        If GridAssetCheck.SelectedItems.Count = 0 Then Exit Sub
        Dim FCheckAsset As New FormCheckItemFixAsset
        FCheckAsset.LblSaveOption.Text = GridAssetCheck.GetRow.Cells("ASS_CHECK_ID").Value
        FCheckAsset.TxtProductName.Text = GridFixAsset.GetRow.Cells("PRODUCT_NAME").Value
        FCheckAsset.TxtProductCode.Text = GridFixAsset.GetRow.Cells("PRODUCT_CODE").Value
        FCheckAsset.DateCheck.Checked = True
        FCheckAsset.DateCheck.Value = GridAssetCheck.GetRow.Cells("DATE_CHECK").Value
        FCheckAsset.TxtNote.Text = GridAssetCheck.GetRow.Cells("CHECK_DESCRIPTION").Value

        If FCheckAsset.ShowDialog = DialogResult.OK Then
            GridFixAsset.DataSource = DA_Fixasset.SelectByFixAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
        End If
    End Sub

   

    
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If ValidateDateField(DateSelect, "", Error1) = False Then Exit Sub
        If ChByWithoutDate.Checked = False Then
            If ValidateDateField(DateBuyFrom, "", Error1) = False Then Exit Sub
            If ValidateDateField(DateBuyTo, "", Error1) = False Then Exit Sub
        End If
        If ChSelectStatus.Checked = True Then
            If ValidateCombobox(CboAssetStatus, "", Error1) = False Then Exit Sub
        End If
        If RadSelectByDepartment.Checked = True Then
            If ValidateCombobox(CboDepartment, "", Error1) = False Then Exit Sub
            If ChSelectStatus.Checked = True Then
                If ValidateCombobox(CboAssetStatus, "", Error1) = False Then Exit Sub
            End If
        End If
        SplitContainer2.Visible = False
        CRVFixAsset.Visible = True
        CRVFixAsset.Dock = DockStyle.Fill

        Dim TblViewAsset As DataTable
        If RadAllStatus.Checked = True Then
            If ChByWithoutDate.Checked = True Then
                If ChSelectStatus.Checked = True Then
                    If CboAssetStatus.Text = "DISPOSAL" Then
                        TblViewAsset = DA_Fixasset.SelectByAssetStatusWithDateDisposal(CboAssetStatus.Text, DFromDiposal.Value.Date, DToDiposal.Value.Date)
                    Else
                        TblViewAsset = DA_Fixasset.SelectByAssetStatus(CboAssetStatus.Text)
                    End If
                Else
                    TblViewAsset = DA_Fixasset.SelectAllStatusWithouthDate()
                End If

            Else
                If ChSelectStatus.Checked = True Then
                    If CboAssetStatus.Text = "DISPOSAL" Then
                        TblViewAsset = DA_Fixasset.SelectByAssetStatusWithDateDisposal(CboAssetStatus.Text, DFromDiposal.Value.Date, DToDiposal.Value.Date)
                    Else
                        TblViewAsset = DA_Fixasset.SelectByAssetStatus(CboAssetStatus.Text)
                    End If
                Else
                    TblViewAsset = DA_Fixasset.SelectAllStatus(DateBuyFrom.Value.Date, DateBuyTo.Value.Date)
                End If

            End If

        ElseIf RadSelectByDepartment.Checked = True Then
            If ChSelectStatus.Checked = False Then
                If ChByWithoutDate.Checked = True Then
                    TblViewAsset = DA_Fixasset.SelectByAllDepartmentIDWithouthDateBuy(CInt(CboDepartment.SelectedValue), 0)
                Else
                    TblViewAsset = DA_Fixasset.SelectByAllDepartmentID(CInt(CboDepartment.SelectedValue), 0, DateBuyFrom.Value.Date, DateBuyTo.Value.Date)
                End If

            Else
                If ChByWithoutDate.Checked = True Then
                    TblViewAsset = DA_Fixasset.SelectStatusWithLocationWithoutDate(CboAssetStatus.Text, CInt(CboDepartment.SelectedValue))
                   
                Else
                    TblViewAsset = DA_Fixasset.SelectStatusWithLocation(CboAssetStatus.Text, CInt(CboDepartment.SelectedValue), DateBuyFrom.Value.Date, DateBuyTo.Value.Date)
                End If

            End If

        End If
       
        Dim CFixAsset As New FixAssetV1  'CryFixAsset
        CFixAsset.SetDataSource(TblViewAsset)
        If RadAllStatus.Checked = True Then
            If ChSelectStatus.Checked = True Then
                CFixAsset.SetParameterValue("Title", CboAssetStatus.Text & " LIST OF FIX ASSETS FOR " & Format(DateSelect.Value, "yyyy"))
                If CboAssetStatus.Text = "DISPOSAL" Then
                    CFixAsset.SetParameterValue("Title", CboAssetStatus.Text & " LIST OF FIX ASSETS  Date Disposal From: " & Format(DFromDiposal.Value, "dd/MM/yyyy") & " To:" & Format(DToDiposal.Value, "dd/MM/yyyy"))
                End If
                CFixAsset.SetParameterValue("Location", "All Location")
            Else
                CFixAsset.SetParameterValue("Title", "MASTER, ACTUAL, DISPOSAL LIST OF FIX ASSETS FOR " & Format(DateSelect.Value, "yyyy"))
                CFixAsset.SetParameterValue("Location", "All Location")
            End If
           
        ElseIf RadSelectByDepartment.Checked = True Then
            If ChSelectStatus.Checked = True Then
                CFixAsset.SetParameterValue("Title", CboAssetStatus.Text & " OF FIX ASSETS FOR " & Format(DateSelect.Value, "yyyy"))
                CFixAsset.SetParameterValue("Location", CboDepartment.Text)
            Else
                CFixAsset.SetParameterValue("Title", "MASTER, ACTUAL, DISPOSAL OF FIX ASSETS FOR " & Format(DateSelect.Value, "yyyy"))
                CFixAsset.SetParameterValue("Location", CboDepartment.Text)
            End If
           


        End If
        CRVFixAsset.ReportSource = CFixAsset
    End Sub

    Private Sub BtnDeleteAsset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteAsset.Click
        If GridFixAsset.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'If DA_Fixasset.DeleteFixAsset(1, GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value) = 1 Then
            '    GridFixAsset.DataSource = DA_Fixasset.SelectByFixAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
            'End If
            If DA_Fixasset.DeleteFromDBByAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value) = 1 Then
                GridFixAsset.DataSource = DA_Fixasset.SelectByFixAssetID(GridFixAsset.GetRow.Cells("FIX_ASS_ID").Value)
            End If
        End If
    End Sub

    Private Sub BtnFindAsset_Click(sender As Object, e As EventArgs) Handles BtnFindAsset.Click
        Dim FFindFixAsset As New FindFixAsset(Me)
        FFindFixAsset.ShowDialog()
    End Sub

    Private Sub RadSelectByStatus_CheckedChanged(sender As Object, e As EventArgs) Handles RadSelectByDepartment.CheckedChanged
        CboDepartment.Enabled = RadSelectByDepartment.Checked
    End Sub

    Private Sub ChSelectLocation_CheckedChanged(sender As Object, e As EventArgs) Handles ChSelectStatus.CheckedChanged
        CboAssetStatus.Enabled = ChSelectStatus.Checked
        CboAssetStatus.Focus()
    End Sub

    Private Sub ChByWithoutDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChByWithoutDate.CheckedChanged
        If ChByWithoutDate.Checked = True Then
            DateBuyFrom.Enabled = False
            DateBuyTo.Enabled = False
        Else
            DateBuyFrom.Enabled = True
            DateBuyTo.Enabled = True
        End If
        
    End Sub

    Private Sub CboAssetStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAssetStatus.SelectedIndexChanged
        If CboAssetStatus.Text = "DISPOSAL" Then
            GroupDisposal.Enabled = True
        Else
            GroupDisposal.Enabled = False
        End If

    End Sub
End Class
