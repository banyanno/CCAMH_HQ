Imports CrystalDecisions.Shared
Module ReceiptUtilityModule

    Public RECEIPT_NEW = "NEW-CLIENT"
    Public RECEIPT_FOLLOWUP = "FOLLOWUP-CLIENT"
    Public RECEIPT_SPACIAL = "SPACIAL-CLIENT"
    Public RECEIPT_MED = "MED-CLIENT"
    Public RECEIPT_CONTRIBUTE As String = "CONTRIBUTION"
    Public SOCIAL_TYPE_A = "A"
    Public SOCIAL_TYPE_B = "B"
    Public SOCIAL_TYPE_C = "C"
    Dim DAClientReceipt As New DSCashCollectionTableAdapters.CCAMH_RECEIPTTableAdapter
    Dim DARate As New DSSocialEconomicSettingTableAdapters.CCAMH_EXCHANGE_RATETableAdapter
    Public Function GetReceiptMaxNo() As Double
        Dim DateServer As Date = ModGlobleVariable.GeteDateServer 'ModGlobleVariable.CheckMarkEOD '
        Dim years As Double = DateServer.Year
        Dim month As String = DateServer.Month.ToString
        If month.Length = 1 Then
            month = "0" & month
        Else
            month = month
        End If
        Dim IDNo As Double
        Try
            IDNo = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar("SELECT COUNT(RECEIPT_ID) FROM CCAMH_RECEIPT WHERE YEARS=" & years) + 1
        Catch ex As Exception
            IDNo = 1
        End Try
        Return years.ToString.Substring(2, 2) & month.ToString & IDNo.ToString
    End Function

    Public Sub ExportPDFViewer(ByVal ObjCrystala As Object, ByVal ObjPDFViewer As Object, ByVal NameFile As String) ' AxAcroPDFLib.AxAcroPDF, ByVal NameFile As String)
        'Dim DoctorConsult As New CRNewClientReceipt
        'Dim TblDrConsult As DataTable
        'If ChDoctor.Checked = True Then
        '    TblDrConsult = DA_DRConsult.SelectDateToDateWithDoctor(DateFrom.Value.Date, DateTo.Value.Date, CInt(CboDoctor.SelectedValue))
        'Else
        '    TblDrConsult = DA_DRConsult.SelectDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        'End If

        'DoctorConsult.SetDataSource(TblDrConsult)
        'DoctorConsult.SetParameterValue("Title", "From: " & DateFrom.Text & " To: " & DateTo.Text)
        ' Declare for export Big app form
        'Dim CrExportOptionsBig As ExportOptions
        'Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        'Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        'CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\" & NameFile & ".pdf"
        'CrExportOptionsBig = ObjCrystala.ExportOptions
        'With CrExportOptionsBig
        '    .ExportDestinationType = ExportDestinationType.DiskFile
        '    .ExportFormatType = ExportFormatType.PortableDocFormat
        '    .DestinationOptions = CrDiskFileDestinationOptionsBig
        '    .FormatOptions = CrFormatTypeOptionsBig
        'End With
        'ObjCrystala.Export()
        'Application.DoEvents()
        'Application.DoEvents()
        'ObjPDFViewer.src = My.Application.Info.DirectoryPath & "\" & NameFile & ".pdf"
        'ObjPDFViewer.setZoom(100)
    End Sub
    Public Function CheckDuplicateReceiptNo(ByVal ReceiptNo As Double) As Boolean
        If DAClientReceipt.CheckExistingReceiptNo(ReceiptNo) > 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function RefreshRecieptNo() As Double
        Return ReceiptUtilityModule.GetReceiptMaxNo()
    End Function
    Function GetSocialServieType(ByVal A As Boolean, ByVal B As Boolean, ByVal C As Boolean) As String
        If A = True Then
            Return "A"
        ElseIf B = True Then
            Return "B"
        ElseIf C = True Then
            Return "C"
        End If
    End Function
    Function GetValuePriceSocialService(ByVal AmmountSocialServie As Double, ByVal ServiceIS As Boolean) As Double
        If ServiceIS = True Then
            Return AmmountSocialServie
        Else
            Return 0
        End If
    End Function
    Function GetExchangeRate() As Double
        Dim tblRate As DataTable = DARate.GetData
        For Each rows As DataRow In tblRate.Rows
            Return rows("EXCHANGE_VALUE")
        Next
    End Function
End Module
