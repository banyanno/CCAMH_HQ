<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCaritasRequestOrder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCaritasRequestOrder))
        Dim gridCaritasRequestOrder123_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.MenuStripCate = New System.Windows.Forms.MenuStrip()
        Me.NewRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRecRequestItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuApprovedRecRequest = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintReportDrugReceivedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRefreshData = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnReceiveMoreItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboSupplier = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRecieveNotComplet = New System.Windows.Forms.Button()
        Me.BtnNotyetComplet = New System.Windows.Forms.Button()
        Me.BtnRequestCaristas = New System.Windows.Forms.Button()
        Me.BtnFilter = New System.Windows.Forms.Button()
        Me.BtnItemSupUsed = New System.Windows.Forms.Button()
        Me.BtnPrintSupGinven = New System.Windows.Forms.Button()
        Me.dptToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dptFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BgRunReceived = New System.ComponentModel.BackgroundWorker()
        Me.gridCaritasRequestOrder123 = New Janus.Windows.GridEX.GridEX()
        Me.MenuStripCate.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridCaritasRequestOrder123, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStripCate
        '
        Me.MenuStripCate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripCate.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStripCate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRequestToolStripMenuItem, Me.menuEdit, Me.menuDelete, Me.menuRecRequestItem, Me.ToolStripMenuItem3, Me.menuApprovedRecRequest, Me.menuPrint, Me.menuRefreshData, Me.BtnReceiveMoreItem})
        Me.MenuStripCate.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripCate.Name = "MenuStripCate"
        Me.MenuStripCate.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStripCate.Size = New System.Drawing.Size(1278, 58)
        Me.MenuStripCate.TabIndex = 10
        Me.MenuStripCate.Text = "MenuStrip1"
        '
        'NewRequestToolStripMenuItem
        '
        Me.NewRequestToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRequestToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NewRequestToolStripMenuItem.Image = CType(resources.GetObject("NewRequestToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewRequestToolStripMenuItem.Name = "NewRequestToolStripMenuItem"
        Me.NewRequestToolStripMenuItem.Size = New System.Drawing.Size(106, 54)
        Me.NewRequestToolStripMenuItem.Text = "New Request"
        Me.NewRequestToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuEdit
        '
        Me.menuEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menuEdit.Image = CType(resources.GetObject("menuEdit.Image"), System.Drawing.Image)
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(92, 54)
        Me.menuEdit.Text = "      Edit       "
        Me.menuEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuDelete
        '
        Me.menuDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menuDelete.Image = CType(resources.GetObject("menuDelete.Image"), System.Drawing.Image)
        Me.menuDelete.Name = "menuDelete"
        Me.menuDelete.Size = New System.Drawing.Size(103, 54)
        Me.menuDelete.Text = "      Delete      "
        Me.menuDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuRecRequestItem
        '
        Me.menuRecRequestItem.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuRecRequestItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menuRecRequestItem.Image = CType(resources.GetObject("menuRecRequestItem.Image"), System.Drawing.Image)
        Me.menuRecRequestItem.Name = "menuRecRequestItem"
        Me.menuRecRequestItem.Size = New System.Drawing.Size(107, 54)
        Me.menuRecRequestItem.Text = "Receive Item"
        Me.menuRecRequestItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(12, 54)
        '
        'menuApprovedRecRequest
        '
        Me.menuApprovedRecRequest.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuApprovedRecRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menuApprovedRecRequest.Image = CType(resources.GetObject("menuApprovedRecRequest.Image"), System.Drawing.Image)
        Me.menuApprovedRecRequest.Name = "menuApprovedRecRequest"
        Me.menuApprovedRecRequest.Size = New System.Drawing.Size(142, 54)
        Me.menuApprovedRecRequest.Text = "Approve  Received"
        Me.menuApprovedRecRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuPrint
        '
        Me.menuPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPurchaseOrderToolStripMenuItem, Me.ToolStripMenuItem2, Me.PrintReportDrugReceivedToolStripMenuItem1})
        Me.menuPrint.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menuPrint.Image = CType(resources.GetObject("menuPrint.Image"), System.Drawing.Image)
        Me.menuPrint.Name = "menuPrint"
        Me.menuPrint.Size = New System.Drawing.Size(100, 54)
        Me.menuPrint.Text = "   Reports   "
        Me.menuPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PrintPurchaseOrderToolStripMenuItem
        '
        Me.PrintPurchaseOrderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintPurchaseOrderToolStripMenuItem.Name = "PrintPurchaseOrderToolStripMenuItem"
        Me.PrintPurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.PrintPurchaseOrderToolStripMenuItem.Text = "Print Purchase Order"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(248, 6)
        '
        'PrintReportDrugReceivedToolStripMenuItem1
        '
        Me.PrintReportDrugReceivedToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintReportDrugReceivedToolStripMenuItem1.Name = "PrintReportDrugReceivedToolStripMenuItem1"
        Me.PrintReportDrugReceivedToolStripMenuItem1.Size = New System.Drawing.Size(251, 22)
        Me.PrintReportDrugReceivedToolStripMenuItem1.Text = "Print Report Drug Received"
        '
        'menuRefreshData
        '
        Me.menuRefreshData.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuRefreshData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menuRefreshData.Image = CType(resources.GetObject("menuRefreshData.Image"), System.Drawing.Image)
        Me.menuRefreshData.Name = "menuRefreshData"
        Me.menuRefreshData.Size = New System.Drawing.Size(111, 54)
        Me.menuRefreshData.Text = " Refresh Data"
        Me.menuRefreshData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.menuRefreshData.Visible = False
        '
        'BtnReceiveMoreItem
        '
        Me.BtnReceiveMoreItem.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReceiveMoreItem.Image = CType(resources.GetObject("BtnReceiveMoreItem.Image"), System.Drawing.Image)
        Me.BtnReceiveMoreItem.Name = "BtnReceiveMoreItem"
        Me.BtnReceiveMoreItem.Size = New System.Drawing.Size(121, 54)
        Me.BtnReceiveMoreItem.Text = "Receive more item"
        Me.BtnReceiveMoreItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CboSupplier)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnRequestCaristas)
        Me.GroupBox1.Controls.Add(Me.BtnFilter)
        Me.GroupBox1.Controls.Add(Me.BtnItemSupUsed)
        Me.GroupBox1.Controls.Add(Me.BtnPrintSupGinven)
        Me.GroupBox1.Controls.Add(Me.dptToDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dptFromDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1278, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(582, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Select Received From:"
        '
        'CboSupplier
        '
        Me.CboSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSupplier.FormattingEnabled = True
        Me.CboSupplier.Location = New System.Drawing.Point(583, 51)
        Me.CboSupplier.Name = "CboSupplier"
        Me.CboSupplier.Size = New System.Drawing.Size(268, 32)
        Me.CboSupplier.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRecieveNotComplet)
        Me.GroupBox2.Controls.Add(Me.BtnNotyetComplet)
        Me.GroupBox2.Location = New System.Drawing.Point(442, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 75)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Status"
        '
        'btnRecieveNotComplet
        '
        Me.btnRecieveNotComplet.BackColor = System.Drawing.Color.Linen
        Me.btnRecieveNotComplet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecieveNotComplet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecieveNotComplet.Location = New System.Drawing.Point(6, 45)
        Me.btnRecieveNotComplet.Name = "btnRecieveNotComplet"
        Me.btnRecieveNotComplet.Size = New System.Drawing.Size(122, 23)
        Me.btnRecieveNotComplet.TabIndex = 2
        Me.btnRecieveNotComplet.Text = "Received not complet"
        Me.btnRecieveNotComplet.UseVisualStyleBackColor = False
        '
        'BtnNotyetComplet
        '
        Me.BtnNotyetComplet.BackColor = System.Drawing.SystemColors.Control
        Me.BtnNotyetComplet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotyetComplet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotyetComplet.Location = New System.Drawing.Point(6, 17)
        Me.BtnNotyetComplet.Name = "BtnNotyetComplet"
        Me.BtnNotyetComplet.Size = New System.Drawing.Size(122, 23)
        Me.BtnNotyetComplet.TabIndex = 2
        Me.BtnNotyetComplet.Text = "Not yet received"
        Me.BtnNotyetComplet.UseVisualStyleBackColor = False
        '
        'BtnRequestCaristas
        '
        Me.BtnRequestCaristas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRequestCaristas.Location = New System.Drawing.Point(232, 53)
        Me.BtnRequestCaristas.Name = "BtnRequestCaristas"
        Me.BtnRequestCaristas.Size = New System.Drawing.Size(204, 25)
        Me.BtnRequestCaristas.TabIndex = 20
        Me.BtnRequestCaristas.Text = "View Report Request Item "
        Me.BtnRequestCaristas.UseVisualStyleBackColor = True
        '
        'BtnFilter
        '
        Me.BtnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFilter.Location = New System.Drawing.Point(232, 17)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(204, 27)
        Me.BtnFilter.TabIndex = 19
        Me.BtnFilter.Text = "Display"
        Me.BtnFilter.UseVisualStyleBackColor = True
        '
        'BtnItemSupUsed
        '
        Me.BtnItemSupUsed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnItemSupUsed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnItemSupUsed.Location = New System.Drawing.Point(857, 49)
        Me.BtnItemSupUsed.Name = "BtnItemSupUsed"
        Me.BtnItemSupUsed.Size = New System.Drawing.Size(156, 35)
        Me.BtnItemSupUsed.TabIndex = 18
        Me.BtnItemSupUsed.Text = "Find Received"
        Me.BtnItemSupUsed.UseVisualStyleBackColor = True
        '
        'BtnPrintSupGinven
        '
        Me.BtnPrintSupGinven.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintSupGinven.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintSupGinven.Image = Global.KTGSYS.My.Resources.Resources.document_print
        Me.BtnPrintSupGinven.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrintSupGinven.Location = New System.Drawing.Point(1019, 13)
        Me.BtnPrintSupGinven.Name = "BtnPrintSupGinven"
        Me.BtnPrintSupGinven.Size = New System.Drawing.Size(253, 71)
        Me.BtnPrintSupGinven.TabIndex = 17
        Me.BtnPrintSupGinven.Text = "Print Item Requested and Received"
        Me.BtnPrintSupGinven.UseVisualStyleBackColor = True
        '
        'dptToDate
        '
        Me.dptToDate.Checked = False
        Me.dptToDate.CustomFormat = "dd/MM/yyyy"
        Me.dptToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptToDate.Location = New System.Drawing.Point(66, 52)
        Me.dptToDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptToDate.Name = "dptToDate"
        Me.dptToDate.Size = New System.Drawing.Size(151, 26)
        Me.dptToDate.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "To Date:"
        '
        'dptFromDate
        '
        Me.dptFromDate.Checked = False
        Me.dptFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dptFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptFromDate.Location = New System.Drawing.Point(66, 18)
        Me.dptFromDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptFromDate.Name = "dptFromDate"
        Me.dptFromDate.Size = New System.Drawing.Size(151, 26)
        Me.dptFromDate.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "From Date:"
        '
        'BgRunReceived
        '
        '
        'gridCaritasRequestOrder123
        '
        gridCaritasRequestOrder123_DesignTimeLayout.LayoutString = resources.GetString("gridCaritasRequestOrder123_DesignTimeLayout.LayoutString")
        Me.gridCaritasRequestOrder123.DesignTimeLayout = gridCaritasRequestOrder123_DesignTimeLayout
        Me.gridCaritasRequestOrder123.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCaritasRequestOrder123.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gridCaritasRequestOrder123.GroupByBoxVisible = False
        Me.gridCaritasRequestOrder123.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.gridCaritasRequestOrder123.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.gridCaritasRequestOrder123.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridCaritasRequestOrder123.Hierarchical = True
        Me.gridCaritasRequestOrder123.Location = New System.Drawing.Point(0, 158)
        Me.gridCaritasRequestOrder123.Name = "gridCaritasRequestOrder123"
        Me.gridCaritasRequestOrder123.RecordNavigator = True
        Me.gridCaritasRequestOrder123.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.gridCaritasRequestOrder123.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridCaritasRequestOrder123.Size = New System.Drawing.Size(1278, 597)
        Me.gridCaritasRequestOrder123.TabIndex = 14
        Me.gridCaritasRequestOrder123.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        '
        'UCCaritasRequestOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridCaritasRequestOrder123)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStripCate)
        Me.Name = "UCCaritasRequestOrder"
        Me.Size = New System.Drawing.Size(1278, 755)
        Me.MenuStripCate.ResumeLayout(False)
        Me.MenuStripCate.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridCaritasRequestOrder123, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripCate As System.Windows.Forms.MenuStrip
    Friend WithEvents menuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRefreshData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRecRequestItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuApprovedRecRequest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dptToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dptFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnItemSupUsed As System.Windows.Forms.Button
    Friend WithEvents BtnPrintSupGinven As System.Windows.Forms.Button
    Friend WithEvents BtnFilter As System.Windows.Forms.Button
    Friend WithEvents BtnRequestCaristas As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRecieveNotComplet As System.Windows.Forms.Button
    Friend WithEvents BtnNotyetComplet As System.Windows.Forms.Button
    Friend WithEvents BgRunReceived As System.ComponentModel.BackgroundWorker
    Friend WithEvents gridCaritasRequestOrder123 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents BtnReceiveMoreItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPurchaseOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintReportDrugReceivedToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
