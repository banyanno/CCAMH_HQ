<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardReportUtility
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardReportUtility))
        Me.BtnScreeningBook = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.RadByStatistics = New System.Windows.Forms.RadioButton
        Me.RadByBooks = New System.Windows.Forms.RadioButton
        Me.GroupByScreenBook = New System.Windows.Forms.GroupBox
        Me.RadRefractBook = New System.Windows.Forms.RadioButton
        Me.RadReferBook = New System.Windows.Forms.RadioButton
        Me.RadScreenBook = New System.Windows.Forms.RadioButton
        Me.GroupByStatistict = New System.Windows.Forms.GroupBox
        Me.RadOpticalShop = New System.Windows.Forms.RadioButton
        Me.RadReferPickup = New System.Windows.Forms.RadioButton
        Me.RadReferalBySelf = New System.Windows.Forms.RadioButton
        Me.RadRefraction = New System.Windows.Forms.RadioButton
        Me.RadAllScreening = New System.Windows.Forms.RadioButton
        Me.CboScreeningPlace = New System.Windows.Forms.ComboBox
        Me.ChScreeningPlace = New System.Windows.Forms.CheckBox
        Me.CRVScreeningUtility = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BGloadingReport = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupByScreenBook.SuspendLayout()
        Me.GroupByStatistict.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnScreeningBook
        '
        Me.BtnScreeningBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnScreeningBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnScreeningBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnScreeningBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnScreeningBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnScreeningBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnScreeningBook.ForeColor = System.Drawing.Color.White
        Me.BtnScreeningBook.Image = CType(resources.GetObject("BtnScreeningBook.Image"), System.Drawing.Image)
        Me.BtnScreeningBook.Location = New System.Drawing.Point(7, 558)
        Me.BtnScreeningBook.Name = "BtnScreeningBook"
        Me.BtnScreeningBook.Size = New System.Drawing.Size(228, 72)
        Me.BtnScreeningBook.TabIndex = 4
        Me.BtnScreeningBook.Text = "Print Preview"
        Me.BtnScreeningBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnScreeningBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnScreeningBook.UseVisualStyleBackColor = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(61, 53)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(173, 27)
        Me.DateTo.TabIndex = 31
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd-MM-yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(61, 21)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(173, 27)
        Me.DateFrom.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(3, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 21)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "To:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(3, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 21)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "From:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadByStatistics)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadByBooks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupByScreenBook)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupByStatistict)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CboScreeningPlace)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChScreeningPlace)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnScreeningBook)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CRVScreeningUtility)
        Me.SplitContainer1.Size = New System.Drawing.Size(1498, 938)
        Me.SplitContainer1.SplitterDistance = 246
        Me.SplitContainer1.TabIndex = 33
        '
        'RadByStatistics
        '
        Me.RadByStatistics.AutoSize = True
        Me.RadByStatistics.Checked = True
        Me.RadByStatistics.Location = New System.Drawing.Point(19, 152)
        Me.RadByStatistics.Name = "RadByStatistics"
        Me.RadByStatistics.Size = New System.Drawing.Size(124, 25)
        Me.RadByStatistics.TabIndex = 38
        Me.RadByStatistics.TabStop = True
        Me.RadByStatistics.Text = "By Statisticts"
        Me.RadByStatistics.UseVisualStyleBackColor = True
        '
        'RadByBooks
        '
        Me.RadByBooks.AutoSize = True
        Me.RadByBooks.Location = New System.Drawing.Point(19, 183)
        Me.RadByBooks.Name = "RadByBooks"
        Me.RadByBooks.Size = New System.Drawing.Size(128, 25)
        Me.RadByBooks.TabIndex = 37
        Me.RadByBooks.Text = "View By Book"
        Me.RadByBooks.UseVisualStyleBackColor = True
        '
        'GroupByScreenBook
        '
        Me.GroupByScreenBook.Controls.Add(Me.RadRefractBook)
        Me.GroupByScreenBook.Controls.Add(Me.RadReferBook)
        Me.GroupByScreenBook.Controls.Add(Me.RadScreenBook)
        Me.GroupByScreenBook.Enabled = False
        Me.GroupByScreenBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupByScreenBook.Location = New System.Drawing.Point(7, 414)
        Me.GroupByScreenBook.Name = "GroupByScreenBook"
        Me.GroupByScreenBook.Size = New System.Drawing.Size(228, 140)
        Me.GroupByScreenBook.TabIndex = 36
        Me.GroupByScreenBook.TabStop = False
        Me.GroupByScreenBook.Text = "Screening Books"
        '
        'RadRefractBook
        '
        Me.RadRefractBook.AutoSize = True
        Me.RadRefractBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RadRefractBook.Location = New System.Drawing.Point(17, 105)
        Me.RadRefractBook.Name = "RadRefractBook"
        Me.RadRefractBook.Size = New System.Drawing.Size(150, 25)
        Me.RadRefractBook.TabIndex = 3
        Me.RadRefractBook.Text = "Refraction Book"
        Me.RadRefractBook.UseVisualStyleBackColor = True
        '
        'RadReferBook
        '
        Me.RadReferBook.AutoSize = True
        Me.RadReferBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RadReferBook.Location = New System.Drawing.Point(17, 70)
        Me.RadReferBook.Name = "RadReferBook"
        Me.RadReferBook.Size = New System.Drawing.Size(109, 25)
        Me.RadReferBook.TabIndex = 2
        Me.RadReferBook.Text = "Refer Book"
        Me.RadReferBook.UseVisualStyleBackColor = True
        '
        'RadScreenBook
        '
        Me.RadScreenBook.AutoSize = True
        Me.RadScreenBook.Checked = True
        Me.RadScreenBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RadScreenBook.Location = New System.Drawing.Point(17, 36)
        Me.RadScreenBook.Name = "RadScreenBook"
        Me.RadScreenBook.Size = New System.Drawing.Size(146, 25)
        Me.RadScreenBook.TabIndex = 1
        Me.RadScreenBook.TabStop = True
        Me.RadScreenBook.Text = "Screening Book"
        Me.RadScreenBook.UseVisualStyleBackColor = True
        '
        'GroupByStatistict
        '
        Me.GroupByStatistict.Controls.Add(Me.RadOpticalShop)
        Me.GroupByStatistict.Controls.Add(Me.RadReferPickup)
        Me.GroupByStatistict.Controls.Add(Me.RadReferalBySelf)
        Me.GroupByStatistict.Controls.Add(Me.RadRefraction)
        Me.GroupByStatistict.Controls.Add(Me.RadAllScreening)
        Me.GroupByStatistict.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupByStatistict.Location = New System.Drawing.Point(7, 216)
        Me.GroupByStatistict.Name = "GroupByStatistict"
        Me.GroupByStatistict.Size = New System.Drawing.Size(224, 192)
        Me.GroupByStatistict.TabIndex = 35
        Me.GroupByStatistict.TabStop = False
        Me.GroupByStatistict.Text = "View By:"
        '
        'RadOpticalShop
        '
        Me.RadOpticalShop.AutoSize = True
        Me.RadOpticalShop.Location = New System.Drawing.Point(6, 150)
        Me.RadOpticalShop.Name = "RadOpticalShop"
        Me.RadOpticalShop.Size = New System.Drawing.Size(130, 25)
        Me.RadOpticalShop.TabIndex = 0
        Me.RadOpticalShop.Text = "Optical Shop"
        Me.RadOpticalShop.UseVisualStyleBackColor = True
        '
        'RadReferPickup
        '
        Me.RadReferPickup.AutoSize = True
        Me.RadReferPickup.Location = New System.Drawing.Point(6, 88)
        Me.RadReferPickup.Name = "RadReferPickup"
        Me.RadReferPickup.Size = New System.Drawing.Size(177, 25)
        Me.RadReferPickup.TabIndex = 0
        Me.RadReferPickup.Text = "Refer To TEH Pickup"
        Me.RadReferPickup.UseVisualStyleBackColor = True
        '
        'RadReferalBySelf
        '
        Me.RadReferalBySelf.AutoSize = True
        Me.RadReferalBySelf.Location = New System.Drawing.Point(6, 57)
        Me.RadReferalBySelf.Name = "RadReferalBySelf"
        Me.RadReferalBySelf.Size = New System.Drawing.Size(167, 25)
        Me.RadReferalBySelf.TabIndex = 0
        Me.RadReferalBySelf.Text = "Refer To TEH Byself"
        Me.RadReferalBySelf.UseVisualStyleBackColor = True
        '
        'RadRefraction
        '
        Me.RadRefraction.AutoSize = True
        Me.RadRefraction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RadRefraction.Location = New System.Drawing.Point(6, 119)
        Me.RadRefraction.Name = "RadRefraction"
        Me.RadRefraction.Size = New System.Drawing.Size(109, 25)
        Me.RadRefraction.TabIndex = 0
        Me.RadRefraction.Text = "Refraction"
        Me.RadRefraction.UseVisualStyleBackColor = True
        '
        'RadAllScreening
        '
        Me.RadAllScreening.AutoSize = True
        Me.RadAllScreening.Checked = True
        Me.RadAllScreening.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RadAllScreening.Location = New System.Drawing.Point(6, 26)
        Me.RadAllScreening.Name = "RadAllScreening"
        Me.RadAllScreening.Size = New System.Drawing.Size(128, 25)
        Me.RadAllScreening.TabIndex = 0
        Me.RadAllScreening.TabStop = True
        Me.RadAllScreening.Text = "All Screening"
        Me.RadAllScreening.UseVisualStyleBackColor = True
        '
        'CboScreeningPlace
        '
        Me.CboScreeningPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboScreeningPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboScreeningPlace.Enabled = False
        Me.CboScreeningPlace.FormattingEnabled = True
        Me.CboScreeningPlace.Location = New System.Drawing.Point(7, 112)
        Me.CboScreeningPlace.Name = "CboScreeningPlace"
        Me.CboScreeningPlace.Size = New System.Drawing.Size(227, 29)
        Me.CboScreeningPlace.TabIndex = 34
        '
        'ChScreeningPlace
        '
        Me.ChScreeningPlace.AutoSize = True
        Me.ChScreeningPlace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ChScreeningPlace.Location = New System.Drawing.Point(7, 86)
        Me.ChScreeningPlace.Name = "ChScreeningPlace"
        Me.ChScreeningPlace.Size = New System.Drawing.Size(157, 25)
        Me.ChScreeningPlace.TabIndex = 33
        Me.ChScreeningPlace.Text = "Screening Place:"
        Me.ChScreeningPlace.UseVisualStyleBackColor = True
        '
        'CRVScreeningUtility
        '
        Me.CRVScreeningUtility.ActiveViewIndex = -1
        Me.CRVScreeningUtility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVScreeningUtility.DisplayGroupTree = False
        Me.CRVScreeningUtility.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVScreeningUtility.Location = New System.Drawing.Point(0, 0)
        Me.CRVScreeningUtility.Name = "CRVScreeningUtility"
        Me.CRVScreeningUtility.SelectionFormula = ""
        Me.CRVScreeningUtility.ShowGroupTreeButton = False
        Me.CRVScreeningUtility.ShowRefreshButton = False
        Me.CRVScreeningUtility.Size = New System.Drawing.Size(1248, 938)
        Me.CRVScreeningUtility.TabIndex = 0
        Me.CRVScreeningUtility.ViewTimeSelectionFormula = ""
        '
        'BGloadingReport
        '
        '
        'DashboardReportUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashboardReportUtility"
        Me.Size = New System.Drawing.Size(1498, 938)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupByScreenBook.ResumeLayout(False)
        Me.GroupByScreenBook.PerformLayout()
        Me.GroupByStatistict.ResumeLayout(False)
        Me.GroupByStatistict.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnScreeningBook As System.Windows.Forms.Button
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CRVScreeningUtility As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ChScreeningPlace As System.Windows.Forms.CheckBox
    Friend WithEvents CboScreeningPlace As System.Windows.Forms.ComboBox
    Friend WithEvents GroupByStatistict As System.Windows.Forms.GroupBox
    Friend WithEvents RadReferalBySelf As System.Windows.Forms.RadioButton
    Friend WithEvents RadRefraction As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllScreening As System.Windows.Forms.RadioButton
    Friend WithEvents RadReferPickup As System.Windows.Forms.RadioButton
    Friend WithEvents RadOpticalShop As System.Windows.Forms.RadioButton
    Friend WithEvents BGloadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupByScreenBook As System.Windows.Forms.GroupBox
    Friend WithEvents RadRefractBook As System.Windows.Forms.RadioButton
    Friend WithEvents RadReferBook As System.Windows.Forms.RadioButton
    Friend WithEvents RadScreenBook As System.Windows.Forms.RadioButton
    Friend WithEvents RadByStatistics As System.Windows.Forms.RadioButton
    Friend WithEvents RadByBooks As System.Windows.Forms.RadioButton

End Class
