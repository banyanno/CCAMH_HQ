Imports Janus.Windows.GridEX

Public Class MainFormAttribute
    Dim LabourDataAdapter As New DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
    Dim labourRepo As ILabourFactoryRepository = New LabourFactoryRepository


    Dim ChemicalDataAdapter As New DSChemicalTableAdapters.tblChemicalTableAdapter
    Dim chemicalRepo As IChemicalRepository = New ChemicalRepository

    Dim ContainerDataAdapter As New DSContainerTableAdapters.tblContainerTableAdapter
    Dim containerRepo As IContainerRepository = New ContainerRepository


    Dim ItemUnitDataAdapter As New DSItemUnitTableAdapters.tblItemUnitTableAdapter
    Dim itemUnitRepo As IItemUnitRepository = New ItemUnitRepository

    Dim CountryDataAdapter As New DSCategoriesAndItemsTableAdapters.COUNTRYTableAdapter

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click

        Dim FLabour As New frmLabourFactory(Me)
        FLabour.ShowDialog()
        FLabour.Close()
        FLabour.Dispose()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Not gridLabouratory.CurrentRow Is Nothing AndAlso gridLabouratory.CurrentRow.RowType = RowType.Record Then
            Dim FLabour As New frmLabourFactory(Me)
            FLabour.lblSaveOption.Text = "1"
            FLabour.labourID = gridLabouratory.GetValue("LabourFacID")
            FLabour.ShowDialog()
            FLabour.Close()
            FLabour.Dispose()
        End If
    End Sub
    Public Sub FillDataByLabourName(ByVal LabourName As String)
        gridLabouratory.DataSource = LabourDataAdapter.GetDataByLabourName(LabourName)
    End Sub
    Public Sub BindIntoDataGrid()
        gridLabouratory.DataSource = LabourDataAdapter.GetData
    End Sub
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        BindIntoDataGrid()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim labour As New tblLabourFactory
        Dim labourTransMsgStatus As String = ""

        If MessageBox.Show("Do you want delete labouratory ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            If Not gridLabouratory.CurrentRow Is Nothing AndAlso gridLabouratory.CurrentRow.RowType = RowType.Record Then
                labour = labourRepo.GetLabourFactoryByID(gridLabouratory.GetValue("LabourFacID"))
                labourTransMsgStatus = labourRepo.DeleteLabourFactory(labour)

                If labourTransMsgStatus <> "True" Then
                    MsgBox("Error delete labouratory.", MsgBoxStyle.Critical, "Error : " & labourTransMsgStatus)
                Else
                    MessageBox.Show("Delete labouratory successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BindIntoDataGrid()
                End If
            Else
                MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FChemical As New frmChemical(Me)
        FChemical.ShowDialog()
        FChemical.Close()
        FChemical.Dispose()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If Not gridChemical.CurrentRow Is Nothing AndAlso gridChemical.CurrentRow.RowType = RowType.Record Then
            Dim FChemical As New frmChemical(Me)
            FChemical.lblSaveOption.Text = "1"
            FChemical.chemicalID = gridChemical.GetValue("ChemicalID")
            FChemical.ShowDialog()
            FChemical.Close()
            FChemical.Dispose()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        gridChemical.DataSource = ChemicalDataAdapter.GetData
    End Sub
   
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim chemical As New tblChemical
        Dim chemicalTransMsgStatus As String = ""

        If MessageBox.Show("Do you want delete chemical ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            If Not gridChemical.CurrentRow Is Nothing AndAlso gridChemical.CurrentRow.RowType = RowType.Record Then

                chemical = chemicalRepo.GetChemicalByID(gridChemical.GetValue("ChemicalID"))
                chemicalTransMsgStatus = chemicalRepo.DeleteChemical(chemical)

                If chemicalTransMsgStatus <> "True" Then
                    MsgBox("Error delete chemical.", MsgBoxStyle.Critical, "Error : " & chemicalTransMsgStatus)
                Else
                    MessageBox.Show("Delete chemical successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    gridChemical.DataSource = ChemicalDataAdapter.GetData
                End If
            Else
                MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click

        Dim FContainer As New frmContainer(Me)
        FContainer.ShowDialog()
        FContainer.Close()
        FContainer.Dispose()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        If Not gridContainer.CurrentRow Is Nothing AndAlso gridContainer.CurrentRow.RowType = RowType.Record Then
            Dim FContainer As New frmContainer(Me)
            FContainer.lblSaveOption.Text = "1"
            FContainer.containerID = gridContainer.GetValue("ContainerID")
            FContainer.ShowDialog()
            FContainer.Close()
            FContainer.Dispose()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click

        Dim container As New tblContainer
        Dim containerTransMsgStatus As String = ""

        If MessageBox.Show("Do you want delete container ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Not gridContainer.CurrentRow Is Nothing AndAlso gridContainer.CurrentRow.RowType = RowType.Record Then

                container = containerRepo.GetContainerByID(gridContainer.GetValue("ContainerID"))
                containerTransMsgStatus = containerRepo.DeleteContainer(container)

                If containerTransMsgStatus <> "True" Then
                    MsgBox("Error delete container.", MsgBoxStyle.Critical, "Error : " & containerTransMsgStatus)
                Else
                    MessageBox.Show("Delete container successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    gridContainer.DataSource = ContainerDataAdapter.GetData
                End If
            Else
                MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        gridContainer.DataSource = ContainerDataAdapter.GetData
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        Dim FItemUnit As New frmItemUnit(Me)
        FItemUnit.ShowDialog()
        FItemUnit.Close()
        FItemUnit.Dispose()
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        If Not gridItemUnit.CurrentRow Is Nothing AndAlso gridItemUnit.CurrentRow.RowType = RowType.Record Then
            Dim FItemUnit As New frmItemUnit(Me)
            FItemUnit.lblSaveOption.Text = "1"
            FItemUnit.itemUnitID = gridItemUnit.GetValue("ItemUnitID")
            FItemUnit.ShowDialog()
            FItemUnit.Close()
            FItemUnit.Dispose()
        End If
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click

        Dim itemUnit As New tblItemUnit
        Dim itemUnitTransMsgStatus As String = ""

        If MessageBox.Show("Do you want delete Item Unit ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Not gridItemUnit.CurrentRow Is Nothing AndAlso gridItemUnit.CurrentRow.RowType = RowType.Record Then

                itemUnit = itemUnitRepo.GetItemUnitByID(gridItemUnit.GetValue("ItemUnitID"))
                itemUnitTransMsgStatus = itemUnitRepo.DeleteItemUnit(itemUnit)

                If itemUnitTransMsgStatus <> "True" Then
                    MsgBox("Error delete Item Unit .", MsgBoxStyle.Critical, "Error : " & itemUnitTransMsgStatus)
                Else
                    MessageBox.Show("Delete ItemUnit successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    gridItemUnit.DataSource = ItemUnitDataAdapter.GetData
                End If
            Else
                MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        gridItemUnit.DataSource = ItemUnitDataAdapter.GetData
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Dim FCountry As New frmCountry(Me)
        FCountry.ShowDialog()
        FCountry.Close()
        FCountry.Dispose()
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        gridCountry.DataSource = CountryDataAdapter.GetData
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        If Not gridCountry.CurrentRow Is Nothing AndAlso gridCountry.CurrentRow.RowType = RowType.Record Then
            Dim FCountry As New frmCountry(Me)
            FCountry.lblSaveOption.Text = "1"
            FCountry.countryID = gridCountry.GetValue("CountryID")
            FCountry.countryName = gridCountry.GetValue("Country")
            FCountry.ShowDialog()
            FCountry.Close()
            FCountry.Dispose()
        End If
    End Sub
End Class