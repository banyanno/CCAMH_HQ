<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCCAMHSummary
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
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView3 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView4 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SplineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SplineSeriesView2 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
        Dim Series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SplineSeriesView3 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
        Dim Series8 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SplineSeriesView4 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.LblDepartment = New System.Windows.Forms.Label()
        Me.BtnYears = New System.Windows.Forms.Button()
        Me.ChartControlMonthlyVisit = New DevExpress.XtraCharts.ChartControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTotalApp = New System.Windows.Forms.Label()
        Me.DateYear = New System.Windows.Forms.DateTimePicker()
        CType(Me.ChartControlMonthlyVisit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(-3, 622)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1408, 4)
        Me.Label1.TabIndex = 0
        '
        'LblUserName
        '
        Me.LblUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.ForeColor = System.Drawing.Color.Maroon
        Me.LblUserName.Location = New System.Drawing.Point(11, 641)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(116, 25)
        Me.LblUserName.TabIndex = 1
        Me.LblUserName.Text = "User Name:"
        '
        'LblDepartment
        '
        Me.LblDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblDepartment.AutoSize = True
        Me.LblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDepartment.ForeColor = System.Drawing.Color.Maroon
        Me.LblDepartment.Location = New System.Drawing.Point(11, 679)
        Me.LblDepartment.Name = "LblDepartment"
        Me.LblDepartment.Size = New System.Drawing.Size(119, 25)
        Me.LblDepartment.TabIndex = 2
        Me.LblDepartment.Text = "Department:"
        '
        'BtnYears
        '
        Me.BtnYears.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnYears.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYears.ForeColor = System.Drawing.Color.Maroon
        Me.BtnYears.Location = New System.Drawing.Point(1259, 663)
        Me.BtnYears.Name = "BtnYears"
        Me.BtnYears.Size = New System.Drawing.Size(135, 30)
        Me.BtnYears.TabIndex = 18
        Me.BtnYears.Text = "View"
        Me.BtnYears.UseVisualStyleBackColor = True
        '
        'ChartControlMonthlyVisit
        '
        Me.ChartControlMonthlyVisit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartControlMonthlyVisit.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
        XyDiagram1.AxisX.Label.Alignment = DevExpress.XtraCharts.AxisLabelAlignment.Center
        XyDiagram1.AxisX.NumericScaleOptions.AutoGrid = False
        XyDiagram1.AxisX.Title.Text = "Monthly"
        XyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControlMonthlyVisit.Diagram = XyDiagram1
        Me.ChartControlMonthlyVisit.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
        Me.ChartControlMonthlyVisit.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBoxAndMarker
        Me.ChartControlMonthlyVisit.Legend.Name = "Default Legend"
        Me.ChartControlMonthlyVisit.Location = New System.Drawing.Point(3, 13)
        Me.ChartControlMonthlyVisit.Name = "ChartControlMonthlyVisit"
        Series1.Name = "New Client"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(212, Byte), Integer))
        Series1.View = SideBySideBarSeriesView1
        Series2.Name = "Old Client"
        SideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(52, Byte), Integer))
        Series2.View = SideBySideBarSeriesView2
        Series3.Name = "Female"
        SideBySideBarSeriesView3.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(56, Byte), Integer))
        Series3.View = SideBySideBarSeriesView3
        Series4.Name = "Male"
        SideBySideBarSeriesView4.Color = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(0, Byte), Integer))
        Series4.View = SideBySideBarSeriesView4
        Series5.Name = "LineNewClient"
        SplineSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(212, Byte), Integer))
        SplineSeriesView1.LineTensionPercent = 100
        Series5.View = SplineSeriesView1
        Series6.Name = "LineOldClient"
        SplineSeriesView2.Color = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(52, Byte), Integer))
        Series6.View = SplineSeriesView2
        Series7.Name = "LineFemale"
        SplineSeriesView3.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(56, Byte), Integer))
        Series7.View = SplineSeriesView3
        Series8.Name = "LineMale"
        SplineSeriesView4.Color = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(0, Byte), Integer))
        Series8.View = SplineSeriesView4
        Me.ChartControlMonthlyVisit.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4, Series5, Series6, Series7, Series8}
        Me.ChartControlMonthlyVisit.Size = New System.Drawing.Size(1391, 606)
        Me.ChartControlMonthlyVisit.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(1145, 633)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Select Year:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kh Battambang", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(269, 633)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 43)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "ចំនួនអ្នកណាត់ជួប"
        '
        'LblTotalApp
        '
        Me.LblTotalApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTotalApp.Font = New System.Drawing.Font("Kh Battambang", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalApp.ForeColor = System.Drawing.Color.Maroon
        Me.LblTotalApp.Location = New System.Drawing.Point(269, 666)
        Me.LblTotalApp.Name = "LblTotalApp"
        Me.LblTotalApp.Size = New System.Drawing.Size(177, 43)
        Me.LblTotalApp.TabIndex = 24
        Me.LblTotalApp.Text = "0"
        Me.LblTotalApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateYear
        '
        Me.DateYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateYear.CustomFormat = "dd/MM/yyyy"
        Me.DateYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateYear.Location = New System.Drawing.Point(1259, 631)
        Me.DateYear.Name = "DateYear"
        Me.DateYear.Size = New System.Drawing.Size(135, 26)
        Me.DateYear.TabIndex = 25
        '
        'DashboardCCAMHSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Controls.Add(Me.DateYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChartControlMonthlyVisit)
        Me.Controls.Add(Me.BtnYears)
        Me.Controls.Add(Me.LblDepartment)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTotalApp)
        Me.Name = "DashboardCCAMHSummary"
        Me.Size = New System.Drawing.Size(1397, 710)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControlMonthlyVisit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblUserName As System.Windows.Forms.Label
    Friend WithEvents LblDepartment As System.Windows.Forms.Label
    Friend WithEvents BtnYears As System.Windows.Forms.Button
    Friend WithEvents ChartControlMonthlyVisit As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTotalApp As System.Windows.Forms.Label
    Friend WithEvents DateYear As System.Windows.Forms.DateTimePicker

End Class
