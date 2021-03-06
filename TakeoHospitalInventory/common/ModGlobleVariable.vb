Imports CrystalDecisions.Shared

Module ModGlobleVariable
    Public ACHIEVE As Boolean = False
    Public DIALOG_SAVE As DialogResult
    Public DIALOG_UPDATE As DialogResult
    Public DIALOG_DELETE As DialogResult
    '------Access Role----------------------------
    Public TBLACCESS_ROLE As DataTable
    Public AccessRole As Boolean = False
    Public MSG_SAVE As String = "Do you realy want to save?"
    Public MSG_UPDATE As String = "Do you realy want to update?"
    Public MSG_DELETE As String = "Do you realy want to delete?"
    Public MSG_UNDO_DELETE As String = "Do you realy want to undo delete?"
    Public MSG_SAVE_SUCCESS As String = "Save successfully."
    Public MSG_UPDATE_SUCCESS As String = "Update successfully."
    Public MSG_DELETE_SUCCESS As String = "Delete successfully."
    Public MSG_SAVE_ERROR As String = "Error save."
    Public MSG_UPDATE_ERROR As String = "Error update."
    Public MSG_DELETE_ERROR As String = "Error delete."
    Public SAVE_TITLE As String = "Save"
    Public UPDATE_TITLE As String = "Update"
    Public ERROR_TITLE As String = "Error"
    Public ROW_ID_GRID As Long
    Public AccRolesCashier As Boolean = False
    'Use to manage patientNo
    Public GLOBLE_PATIENT_NO As String
    Public FOLLOW_UP_NO As String
    Public GENERAL_DAO As New GeneralDAO
    Public nUser As String = "Takeo"

    'User Log in
    'Public USER_NAME As String
    'Public PASSWORD As String
    Public FRM_LOG_IN As String
    Public LOG_ON_TIME As String
    Public FRM_USER_ACOUNT As String
    Public DATE_DEFAULT_SETTING As Date

    ' Create Agent
    'Public myCharacter As AxAgentObjects.AxAgentEventMulticaster
    ' Public Login Form
    Public FLogin As frmLoginInventory
    Public MainForm As MainTakeoInventory
    Public MainFormApplicationPublic As MainAppKTG

    Public DEP_EOD As UCRunEndOfDay
    ' Display message for character agent
    Public Const MSG_PAYMENT As String = "Click here to update  or find for old patient."
    Public Const MSG_NEWOUTPATIENT As String = "We'll record patient informationt into new out-patient book."
    Public Const MSG_OLD_OUTPATIENT As String = "We'll record patient informationt into old out-patient book."
    Public Const MSG_INPATIENT As String = "We'll record patient information into in-patient book"

    ' Account Receivable
    Public AIDAR As Long
    Public DateAR As Date
    Public DateARUpdate As Date

    Public RoleAccess As String

    Dim DA_BusinesDay As New DSPatientReceiptTableAdapters.BusinessesTableAdapter
    Public Function RoundToLeft(ByVal d As Double, ByVal digits As Integer) As Double
        Dim rounding As Double = Math.Pow(10.0, digits)
        Return Math.Round(d / rounding, 0, MidpointRounding.AwayFromZero) * rounding
    End Function
    Function CheckMarkEOD() As Date
        Try
            Return CDate(DA_BusinesDay.GlobalBusinessDay).Date
        Catch ex As Exception
            Return GetDateServer.Date
        End Try

        'If DA_BusinesDay.SelectDateEOD(GeteDateServer().Date) = 0 Then
        '    Return GeteDateServer()
        'Else
        '    MessageBox.Show("The system is mark end of day. The system will move date to next day " & Format(GeteDateServer().AddDays(1).Date, "dd/MM/yyyy"), "E-O-D", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return GeteDateServer().AddDays(1).Date
        'End If
    End Function
    Function GeteDateServer() As Date
        Dim sql As String = "SELECT GetDate()"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Sub OnlyNumber(ByVal txtBox As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
                If e.KeyChar = "." Then
                    If txtBox.Text.IndexOf(".") = -1 Then
                        e.Handled = True
                    Else : e.Handled = True
                        Exit Sub
                    End If
                End If
            Case Else
                e.Handled = True
        End Select
    End Sub
    Dim CryDiskFileDestination As New DiskFileDestinationOptions()
    Public Function ExportCrystalToPDF(ByVal ObjCryStal As Object, ByVal ObjViewPDF As Object, ByVal PdfName As String) As Object ' AxAcroPDFLib.AxAcroPDF, ByVal PdfName As String) As AxAcroPDFLib.AxAcroPDF
        'If Me.InvokeRequired Then
        '    Me.Invoke(New MethodInvoker(AddressOf ViewPatientPrescrip))
        'Else
        ' Dim TblPrescription As DataTable = DA_Prescription.SelectPrescriptionWaitingID(WAITING_NO)

        Dim CrExportOptionsBig1 As ExportOptions

        CryDiskFileDestination.DiskFileName = My.Application.Info.DirectoryPath & "\" & PdfName & ".pdf"
        CrExportOptionsBig1 = ObjCryStal.ExportOptions
        With CrExportOptionsBig1
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CryDiskFileDestination
            .FormatOptions = CrFormatTypeOptionsBig1
        End With
        ObjCryStal.Export()
        Application.DoEvents()
        Application.DoEvents()
        ObjViewPDF.src = My.Application.Info.DirectoryPath & "\" & PdfName & ".pdf"
        ObjViewPDF.setZoom(50)
        ObjViewPDF.Refresh()
        ' ObjViewPDF.Dispose()
        Return ObjViewPDF
        'VReportPrescrip.ShowDialog()
        'VReportPrescrip.AxAcroPDFPrescription.Dispose()
        'ViewPrescrip.Close()
        'ViewPrescrip.Dispose()
        'VReportPrescrip.Close()
        'VReportPrescrip.Dispose()
        'Me.Close()
        'Me.Dispose()
        'End If

    End Function

End Module
