Imports System.Math
Imports System.Threading
Public Class NewPatientPayment
    Public isCloseReceipt As Boolean = False
    Dim ReportNOPR As ReportNewOutPatientReceipt
    Dim reportFormRegistration As New RegistrationForm
    Dim IS_Mo_Po_Tsyo As Boolean = False
    Dim tblPatient As DataTable
    Dim DA_Referral As New DSREFFERRAL_TEHTableAdapters.REFFERAL_TEHTableAdapter
    Public IS_UPDATE As Boolean = False
    Dim DA_PTrackingTime As New DataReportUtilityTableAdapters.PATIENT_TIMETRACKINGTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
      
        With CboOccupation
            .DataSource = ModOccupation.SelectAllOccupation()
            .ValueMember = "Occupation"
            .SelectedValue = "OccNo"
            .Text = Nothing
        End With
        ReportNOPR = New ReportNewOutPatientReceipt
        DateRegistration.Value = ModGlobleVariable.GeteDateServer
        dtpDateIn.Value = ModGlobleVariable.GeteDateServer
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
     
        AccRolesCashier = True
        isTrueFalse = False
        isCloseReceipt = False
        Me.Close()
    End Sub

    Private Sub txtAmountFigureR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountFigureR.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
        'If Asc(e.KeyChar) = Keys.Enter Then
        '    Call cmdFind_Click(sender, e)
        '    Me.txtHNFind.Focus()
        'End If
    End Sub

    Private Sub txtAmountFigureR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountFigureR.LostFocus
        If Me.txtAmountFigureR.Text.Trim = "" Then
            Me.txtAmountFigureR.Text = "0"
        End If
    End Sub

    Private Sub txtAmountFigureR_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAmountFigureR.MouseClick
        If Me.txtAmountFigureR.Text = "0" Then
            Me.txtAmountFigureR.Text = ""
        End If
    End Sub

    Private Sub txtAmountFigureD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountFigureD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtAmountFigureD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountFigureD.LostFocus
        If Me.txtAmountFigureD.Text.Trim = "" Then
            Me.txtAmountFigureD.Text = "0"
        End If
    End Sub

    Private Sub txtAmountFigureD_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAmountFigureD.MouseClick
        If Me.txtAmountFigureD.Text = "0" Then
            Me.txtAmountFigureD.Text = ""
        End If
    End Sub

    Private Sub InpatientPayment()
        Dim Riels As Double
        Dim Dollars As Double
        If Me.lblRielDolar.Text = "erol" And Me.chkRiel.Checked = True And Me.chkDollar.Checked = True Then
            Riels = Val(Me.txtAmountFigureD.Text) * Val(Me.txtRate.Text)
            Me.txtReturnR.Text = Round((Val(Me.txtAmountFigureR.Text) + Riels) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnD.Text = Round(Val(Me.txtReturnR.Text) / Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "duløa" And Me.chkRiel.Checked = True And Me.chkDollar.Checked = True Then
            Dollars = Val(Me.txtAmountFigureR.Text) / Val(Me.txtRate.Text)
            Me.txtReturnD.Text = Round((Val(Me.txtAmountFigureD.Text) + Dollars) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnR.Text = Round(Val(Me.txtReturnD.Text) * Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "erol" And Me.chkRiel.Checked = True Then
            Me.txtReturnR.Text = Round(Val(Me.txtAmountFigureR.Text) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnD.Text = Round(Val(Me.txtReturnR.Text) / Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "erol" And Me.chkDollar.Checked = True Then
            Riels = Val(Me.txtAmountFigureD.Text) * Val(Me.txtRate.Text)
            Me.txtReturnR.Text = Round((Val(Me.txtAmountFigureR.Text) + Riels) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnD.Text = Round(Val(Me.txtReturnR.Text) / Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "duløa" And Me.chkDollar.Checked = True Then
            Me.txtReturnD.Text = Round(Val(Me.txtAmountFigureD.Text) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnR.Text = Round(Val(Me.txtReturnD.Text) * Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "duløa" And Me.chkRiel.Checked = True Then
            Dollars = Val(Me.txtAmountFigureR.Text) / Val(Me.txtRate.Text)
            Me.txtReturnD.Text = Round((Val(Me.txtAmountFigureD.Text) + Dollars) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnR.Text = Round(Val(Me.txtReturnD.Text) * Val(Me.txtRate.Text), 2)
        End If
    End Sub

    Private Sub txtAmountFigureR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountFigureR.TextChanged
        Call InpatientPayment()
    End Sub

    Private Sub txtAmountFigureD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountFigureD.TextChanged
        Call InpatientPayment()
    End Sub

    Private Sub txtConsultation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConsultation.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtConsultation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConsultation.LostFocus
        If Me.txtConsultation.Text.Trim = "" Then
            Me.txtConsultation.Text = "0"
        End If
    End Sub

    Private Sub txConsultation_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtConsultation.MouseClick
        Me.txtConsultation.SelectAll()
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtConsultation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsultation.TextChanged

        If Me.txtConsultation.Text.Trim > "0" Then
            Me.txtTotal.Text = Me.txtConsultation.Text.Trim
            Call InpatientPayment()
            If Me.lblRielDolar.Text = "erol" Then
                'txtConsultation.Text = ""
            Else
                'txtConsultation.Text = ""
            End If
        Else
            Me.txtTotal.Text = "0"
        End If
    End Sub

    Private Sub rdConsultationR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdR.CheckedChanged
        If Me.rdR.Checked = True Then
            Me.txtConsultation.Enabled = True
            Me.txtConsultation.Text = ""
            Me.txtConsultation.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "OPFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtConsultation.Text = "0"
            Me.txtConsultation.Enabled = False
        End If
    End Sub

    Private Sub rdConsultationD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdD.CheckedChanged
        If Me.rdD.Checked = True Then
            Me.txtConsultation.Enabled = True
            Me.txtConsultation.Text = ""
            Me.txtConsultation.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "OPFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtConsultation.Text = "0"
            Me.txtConsultation.Enabled = False
        End If
    End Sub

    Sub GetRates()
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
                'If MRates.GetRateChange Is Nothing Then
                '    Exit Sub
                'End If
                Me.txtRate.Text = .Rows(0).Item(0)
            End If
        End With
    End Sub

    Private Sub frmInpatientReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblCashierLogin.Text = ""
        Me.lblCashierLogin.Text = ""
        Me.lblCashierLogin.Text = USER_NAME
        Me.lblCashier.Text = USER_NAME
        ' Me.SplitContainer1.SplitterDistance = Me.Height / 2
        InitChListReferral()
        Call GetRates()
        Call GetValueNew()
        LoadNewPatientNo()
        LoadNewReceiptNo()
        dtpDateIn.Checked = True
        If IS_UPDATE = False Then
            dtpDateIn.Checked = True
            dtpDateIn.Value = CheckMarkEOD()
            dtpDateIn.Enabled = False
        End If

    End Sub
    Sub InitChListReferral()
        With ChListReferral
            .Items.Clear()
            Dim TblReferral As DataTable = DA_Referral.GetData
            For Each DRow As DataRow In TblReferral.Rows
                .Items.Add(DRow("REFFERAL_NAME"))
            Next
        End With
    End Sub
    Sub GetValueNew()
        rdR.Checked = True

        Dim DA_NEW As New DSDEFAULT_VAL_OLD_NEWTableAdapters.DEFAULT_VALUE_NEWTableAdapter
        Dim D_TBL As DataTable = DA_NEW.GetData
        With D_TBL
            If .Rows.Count > 0 Then
                Me.txtConsultation.Text = .Rows(0).Item("DefaultValue")
            End If
        End With
        If Me.txtConsultation.Text.Trim > "0" Then
            Me.txtTotal.Text = Me.txtConsultation.Text.Trim
            Call InpatientPayment()
            If Me.lblRielDolar.Text = "erol" Then
                'txtConsultation.Text = ""
            Else
                'txtConsultation.Text = ""
            End If
        Else
            Me.txtTotal.Text = "0"
        End If
        'InpatientPayment()
    End Sub
    Function CheckStatusReferal() As Boolean

        For Each obj As Object In GrpReferal.Controls
            If TypeOf obj Is CheckBox Then
                Dim rd As CheckBox = CType(obj, CheckBox)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function
    Function GetTextReferral() As String
        Try
            Dim str As String
            For i As Int16 = 0 To GrpReferal.Controls.Count - 1
                Dim ch As CheckBox = CType(GrpReferal.Controls(i), CheckBox)
                If ch.Checked = True Then
                    str = str & " + " & ch.Text
                End If
            Next
            Return str.Substring(3)
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Function GetCombinePatientDisability() As String
        Try
            Dim str As String = ""
            For i As Int16 = 0 To GroupDisability.Controls.Count - 1
                Dim ch As CheckBox = CType(GroupDisability.Controls(i), CheckBox)
                If ch.Checked = True Then
                    str = CType(IIf(str = "", str & ch.Text, str & " + " & ch.Text), String)  ' str & " + " & ch.Text
                End If
            Next
            Return str
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Function GetTextReferralV1() As String
        Try
            Dim str As String = ""
            For i As Int16 = 0 To ChListReferral.Items.Count - 1
                If ChListReferral.GetItemChecked(i) = True Then
                    str = str & " + " & ChListReferral.Items(i).ToString
                End If
            Next
            Return str.Substring(3)
        Catch ex As Exception
            Return ""
        End Try
       
    End Function
    Function CheckMoPoGo() As Boolean
        For i As Int16 = 0 To ChListReferral.Items.Count - 1
            If ChListReferral.GetItemChecked(i) = True And ChListReferral.Items(i).ToString = "Mo.Po.Tsyo" Then
                Return True
            End If
        Next
    End Function
    Sub LoadNewReceiptNo()
        Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
    End Sub
    Sub LoadNewPatientNo()
        TxtPatientNo.Text = ModCommon.GeneratePatientNoForScreening("No", "TblPatients")
        txtHN.Text = TxtPatientNo.Text
    End Sub


    Private Sub chkRiel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRiel.CheckedChanged
        If Me.chkRiel.Checked = True Then
            Me.txtAmountFigureR.Enabled = True
            Me.txtAmountFigureR.Text = ""
            Me.txtAmountFigureR.Focus()
        Else
            Me.txtAmountFigureR.Enabled = False
            Me.txtAmountFigureR.Text = "0"
        End If
    End Sub

    Private Sub chkDollar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDollar.CheckedChanged
        If Me.chkDollar.Checked = True Then
            Me.txtAmountFigureD.Enabled = True
            Me.txtAmountFigureD.Text = ""
            Me.txtAmountFigureD.Focus()
        Else
            Me.txtAmountFigureD.Enabled = False
            Me.txtAmountFigureD.Text = "0"
        End If
    End Sub

    Sub ClearSearch()
        Me.txtHN.Text = ""
        Me.txtPatient.Text = ""

        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Text = "0"

        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Text = "0"
        Me.chkRiel.Checked = False
        Me.chkDollar.Checked = False

        Me.txtConsultation.Enabled = False
        Me.txtConsultation.Text = "0"
        Me.rdR.Checked = False
        Me.rdD.Checked = False

        Me.chkSocialFee.Checked = False

        Me.txtTotal.Text = "0"

        Me.txtReturnR.Text = "0"
        Me.txtReturnD.Text = "0"
    End Sub
    Sub ClearFormPatient()
        TxtNameEng.Text = ""
        TxtNameKhmer.Text = ""
        TxtAgePatient.Text = ""
        CboSexPatien.Text = ""
        TxtTel.Text = ""
        CboOccupation.Text = ""
        TxtOther.Text = ""
        CboProNo.Text = ""
        CboDisNo.Text = ""
        CboCommNo.Text = ""
        TxtAddress.Text = ""
        ChUnderstand.Checked = False
        ChHearing.Checked = False
        ChSeeing.Checked = False
        ChPhysical.Checked = False
        ChSelf.Checked = False
        ChPatient.Checked = False
        ChFriend.Checked = False
        ChCDMDP.Checked = False
        ChEyeScreenig.Checked = False
        ChChurch.Checked = False
        ChOtherNGO.Checked = False
        ChHealth.Checked = False
        ChOtherReferal.Checked = False
        DateRegistration.Checked = True
        dtpDateIn.Checked = False
        TxtNameEng.Focus()
        For Each obj As Object In GrpReferal.Controls
            Dim rd As CheckBox = CType(obj, CheckBox)
            rd.Checked = False
        Next
        For i As Int16 = 0 To ChListReferral.Items.Count - 1
            ChListReferral.SetItemChecked(i, False)
        Next
        Call GetValueNew()
    End Sub
    Sub ClearFormReceipt()
        Me.lblReceiptToPrintID.Text = ""
        '------------for printing receipt-------------
        'Me.txtHN.Text = ""
        'Me.txtPatient.Text = ""
        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Text = "0"
        Me.ChFree.Checked = False
        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Text = "0"
        Me.chkRiel.Checked = False
        Me.chkDollar.Checked = False
        Me.txtConsultation.Enabled = False
        Me.txtConsultation.Text = "0 "
        Me.rdR.Checked = False
        Me.rdD.Checked = False
        dtpDateIn.Checked = True
        dtpDateIn.Value = CheckMarkEOD()
        Me.chkSocialFee.Checked = False

        Me.txtTotal.Text = "0"

        Me.txtReturnR.Text = "0"
        Me.txtReturnD.Text = "0"
    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged
        Dim Riel As New riel()
        Dim Dollar As New dollar()
        If Me.lblRielDolar.Text = "erol" Then
            Me.txtAmountWord.Text = Riel.Convert(Me.txtTotal.Text)
        ElseIf Me.lblRielDolar.Text = "duløa" Then
            Me.txtAmountWord.Text = Dollar.Convert(Me.txtTotal.Text)
        End If
    End Sub

    Private Sub txtReturnR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReturnR.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtReturnR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReturnR.TextChanged
        If Me.txtReturnR.Text < 0 Then
            Me.txtReturnR.ForeColor = Color.Red
        Else
            Me.txtReturnR.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtReturnD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReturnD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtReturnD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReturnD.TextChanged
        If Me.txtReturnD.Text < 0 Then
            Me.txtReturnD.ForeColor = Color.Red
        Else
            Me.txtReturnD.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtAmountWord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountWord.TextChanged
        If Me.txtAmountWord.Text = "Error: that is too much for inputting this value." Then
            Me.txtAmountWord.ForeColor = Color.Red
        Else
            Me.txtAmountWord.ForeColor = Color.Black
        End If
    End Sub

    Private Function CheckSaveReceipt() As Boolean
        If Me.chkSocialFee.Checked = False Then
            If Me.lblCashier.Text = "" Then
                MsgBox("Please check the cashier name.", MsgBoxStyle.Information, "Cashier Confirm")
                Return False
            ElseIf Me.txtReceiptNumber.Text = "" Then
                MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number confirm")
                Me.txtReceiptNumber.Focus()
                Return False
            ElseIf Me.txtHN.Text = "" Then
                MsgBox("Please enter HN number.", MsgBoxStyle.Information, "HN confirm")
                Me.txtHN.Focus()
                Return False
            ElseIf Me.txtRate.Text = "" Then
                MsgBox("Please check the rate. This operation cannot work without rate.", MsgBoxStyle.Information, "Rate confirm")
                Me.txtRate.Focus()
                Return False
            ElseIf Me.txtPatient.Text = "" Then
                MsgBox("Please enter the patient name.", MsgBoxStyle.Information, "Patient confirm")
                Me.txtPatient.Focus()
                Return False
            ElseIf Me.rdR.Checked = False And Me.rdD.Checked = False Then
                MsgBox("Please enter the amount of consultation or artificial or other fee.", MsgBoxStyle.Information, "Hospital fee confirm")
                Me.rdR.Focus()
                Return False
            ElseIf Me.rdR.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter consultation fee in Riel.", MsgBoxStyle.Information, "Consultation fee Riel confirm")
                Me.txtConsultation.Focus()
                Return False
            ElseIf Me.rdD.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter consultation fee in Dollar.", MsgBoxStyle.Information, "Consultation fee Dollar confirm")
                Me.txtConsultation.Focus()
                Return False
            ElseIf Me.txtAmountWord.Text = "" Then
                MsgBox("Please enter the amount payment in word.", MsgBoxStyle.Information, "Amount payment word confirm")
                Me.txtAmountWord.Focus()
                Return False
            End If
            Return True
        End If
        Return True
    End Function
    Private Sub txtHN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHN.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtHN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHN.TextChanged
    End Sub

    Private Sub txtReceiptNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReceiptNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub


    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub


    Private Sub DoPrintNewReceipt()
        Try

            'If Me.lblReceiptToPrintID.Text <> "" Then
            ReportNOPR.SetDataSource(MNewOutpatientReceipt.ReportNewOutpatientReceipt(Me.txtReceiptNumber.Text).Tables(1))
            ReportNOPR.Refresh()
            printDocument.PrinterSettings.PrinterName = ModCommon.PrinterReceipt
            'MsgBox(printDocument.PrinterSettings.PrinterName)
            ReportNOPR.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
            ReportNOPR.PrintToPrinter(1, False, 1, 1)
            ReportNOPR.Dispose()
            ReportNOPR.Close()
            'End If
        Catch ex As Exception
            MsgBox("Can not find printer. " & ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub
    Private Sub DoPrintRegistrationForm()
        Try
            tblPatient = TblPatientReferalTableAdapter.GetDataByPatienNo(TxtPatientNo.Text)
            reportFormRegistration.SetDataSource(tblPatient)
            reportFormRegistration.Refresh()
            printDocument.PrinterSettings.PrinterName = ModCommon.PrinterRegistrationForm
            reportFormRegistration.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
            reportFormRegistration.PrintToPrinter(1, False, 1, 1)
            reportFormRegistration.Dispose()
            reportFormRegistration.Close()
        Catch ex As Exception
            MsgBox("Can not find printer." & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DoPrintRegistrationFormV2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf DoPrintRegistrationFormV2))
        Else
            Try
                Dim reportFormRegistrationV2 As New RegistrationFormV2
                tblPatient = TblPatientReferalTableAdapter.GetDataByPatienNo(TxtPatientNo.Text)
                Dim DA_PatientReferral As New DSPatientFormTableAdapters.REFFERAL_PATIENT_DETAILTableAdapter
                Dim tblPatientReferral As DataTable
                tblPatientReferral = DA_PatientReferral.GetDataByPatientNo(TxtPatientNo.Text)
                reportFormRegistrationV2.SetDataSource(tblPatient)
                reportFormRegistrationV2.Subreports("PatientReferralList").SetDataSource(tblPatientReferral)
                printDocument.PrinterSettings.PrinterName = ModCommon.PrinterRegistrationForm
                reportFormRegistrationV2.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
                reportFormRegistrationV2.PrintToPrinter(1, False, 1, 1)
                reportFormRegistrationV2.Dispose()
                reportFormRegistrationV2.Close()
            Catch ex As Exception
                MsgBox("Can not find printer." & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub

    Private Sub cmdAddRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddRate.Click
        Dim frmRates As New frmRates
        frmRates.ShowDialog()
        Call GetRates()
    End Sub

    Private Sub chkSocialFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSocialFee.CheckedChanged
        If Me.chkSocialFee.Checked = True Then
            Me.txtConsultation.Text = 0
        End If
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        dtpDateIn.Checked = True
        dtpDateIn.Value = CheckMarkEOD()
        ' Check Date Registration and Date Receipt
        If DateRegistration.Checked = False Then
            MsgBox("Please check date registration.", MsgBoxStyle.Critical, "Error")
            DateRegistration.Select()
            DateRegistration.Focus()
            Exit Sub
        Else
            If DateRegistration.Value.DayOfYear < ModGlobleVariable.GeteDateServer.DayOfYear Then
                MsgBox("Patient can not regis on date " & DateRegistration.Text, MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        End If
        If ChFree.Checked = False Then
            If dtpDateIn.Checked = False Then
                MsgBox("Please select date new patient receipt.", MsgBoxStyle.Critical, "Error")
                dtpDateIn.Select()
                dtpDateIn.Focus()
                Exit Sub
            Else
                If dtpDateIn.Value.DayOfYear < ModGlobleVariable.GeteDateServer.DayOfYear Then
                    MsgBox("Receipt can not give on date " & dtpDateIn.Text, MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            End If
        Else

        End If

        ' Check patient Validate
        If ValidateTextField(TxtPatientNo, "patient no", ErrPatient) = False Or _
                ValidateTextField(TxtNameEng, "Name English", ErrPatient) = False Or _
              ValidateTextField(TxtNameKhmer, "Name Khmer", ErrPatient) = False Or _
              ValidateTextField(TxtAgePatient, "Age", ErrPatient) = False Or _
              ValidateCombobox(CboSexPatien, "Sex", ErrPatient) = False Or _
              ValidateCombobox(CboProNo, "Province", ErrPatient) = False Or _
              ValidateCombobox(CboDisNo, "District", ErrPatient) = False Or _
              ValidateCombobox(CboCommNo, "Commune", ErrPatient) = False Or _
              ValidateCombobox(CboOccupation, "occupation", ErrPatient) = False _
              Then
            Exit Sub
        End If
        'Check existing province , Distric and commune
        If ModProvince.CheckProvince(CboProNo.Text) = 0 Then
            MsgBox("The Province name not correct in system! Could you check again.", MsgBoxStyle.Critical, "Error Province")
            CboProNo.Select()
            CboProNo.Focus()
            Exit Sub
        End If
        If ModProvince.CheckDistric(CboProNo.SelectedValue, CboDisNo.Text) = 0 Then
            MsgBox("The district name not correct in system! Could you check again.", MsgBoxStyle.Critical, "Error District")
            CboDisNo.Select()
            CboDisNo.Focus()
            Exit Sub
        End If
        If ModProvince.CheckCommun(CboDisNo.SelectedValue, CboCommNo.Text) = 0 Then
            MsgBox("The commune name not correct in system! Could you check again.", MsgBoxStyle.Critical, "Error District")
            CboCommNo.Select()
            CboCommNo.Focus()
            Exit Sub
        End If

        ' Check user duplicate name and address
        Dim ExistingPatientInfo As Double = ModRegistration.CheckDuplicatePatient(TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, TxtAddress.Text)
        If ExistingPatientInfo <> 0 Then
            MessageBox.Show("Patient No​ " & ExistingPatientInfo & " have in system already." & Chr(13) & "Please pay attention for this patient as it is similar or unique to the existing in the system.", "Patient check duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ModOccupation.checkOccupation(CboOccupation.Text) = 0 Then
            MsgBox("The Occupation name not correct in system! Could you check again.", MsgBoxStyle.Critical, "Error District")
            CboCommNo.Select()
            CboCommNo.Focus()
            Exit Sub
        End If
        '===========Check Referal from=============
        If GetTextReferralV1() = "" Then
            ChListReferral.BackColor = Color.Aqua
            MessageBox.Show("Please select referral.", "Referral", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            ChListReferral.BackColor = Color.White
        End If
        ' ========= Check Is Patient Mo_Po_Tsyo =================
        'If ChMoPoCho.Checked = True Then
        '    IS_Mo_Po_Tsyo = True
        'Else
        '    IS_Mo_Po_Tsyo = False
        'End If
        If CheckMoPoGo() = True Then
            IS_Mo_Po_Tsyo = True
        Else
            IS_Mo_Po_Tsyo = False
        End If
        'If CheckStatusReferal() = False Then
        '    MessageBox.Show("Please check referal from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    GrpReferal.BackColor = Color.Khaki
        '    Exit Sub
        'Else
        '    GrpReferal.BackColor = Color.Transparent
        'End If

        If ChFree.Checked = False Then
            If CheckSaveReceipt() = False Then
                Exit Sub
            End If
        End If

        If MessageBox.Show("Do you realy want save this patient?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            If ChFree.Checked = True Then
                If SaveProcessForNewPatient(ChFree.Checked) = True Then
                    cmdSave.Enabled = False
                    cmdClose.Enabled = False
                    LblLoadPring.Visible = True
                    PicLoadReport.Visible = True
                    BgLoadRegistrationForm.RunWorkerAsync()
                    dtpDateIn.Checked = True
                    DA_PTrackingTime.InsertPatientTracking(TxtPatientNo.Text, 0, CboSexPatien.Text, TxtAgePatient.Text, CheckMarkEOD().Date, Format(Now, "hh:mm:ss tt"), "", "", "", "", "", "", "", "")
                End If
            Else
                If SaveProcessForNewPatient(ChFree.Checked) = True Then
                    cmdSave.Enabled = False
                    cmdClose.Enabled = False
                    LblLoadPring.Visible = True
                    PicLoadReport.Visible = True
                    BgLoadReport.RunWorkerAsync()
                    dtpDateIn.Checked = True
                    DA_PTrackingTime.InsertPatientTracking(CDbl(TxtPatientNo.Text), 0, CboSexPatien.Text, TxtAgePatient.Text, CheckMarkEOD().Date, Format(Now, "hh:mm:ss tt"), "", "", "", "", "", "", "", "")
                End If
            End If
        End If
        'Call GetValueNew()
    End Sub

    Function SaveProcessForNewPatient(ByVal Free As Boolean) As Boolean
        If ModCommon.CheckDuplicateHN(Me.TxtPatientNo.Text, "TblPatients") = True Then      '------------recall HN after redundency----------
            LoadNewPatientNo()
        End If
        If MCashReceipt.CheckDuplicateReceiptNo(Me.txtReceiptNumber.Text, "tblPatientReceipt") = True Then
            LoadNewReceiptNo()
        End If
        '---------------Renew Receipt ID First time before saving----------------------------------------------------------

        Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim sqlComm As SqlClient.SqlCommand = Con.CreateCommand
        Dim Transaction As SqlClient.SqlTransaction = Nothing
        Transaction = Con.BeginTransaction
        sqlComm.Transaction = Transaction
        Try
            ' ========== Save New patient information =======================
            sqlComm.CommandText = SqlPatientInformation()
            sqlComm.ExecuteNonQuery()
            '=========== Save Patient Referral Detail ======================

            For i As Int16 = 0 To ChListReferral.Items.Count - 1
                If ChListReferral.GetItemChecked(i) = True Then
                    sqlComm.CommandText = SQLSavePatientReferral(TxtPatientNo.Text, ChListReferral.Items(i))
                    sqlComm.ExecuteNonQuery()
                End If
            Next

            ' =========== Save New Patient Receipt =========================
            If Free = False Then
                sqlComm.CommandText = SqlNewPatientReceipt()
                sqlComm.ExecuteNonQuery()
            End If

            ' =========== Save patient into patient followup ==================
            sqlComm.CommandText = SqlRegistrationFormForReferal()
            sqlComm.ExecuteNonQuery()
            ' =========== Save Patient into Book New Patient         ==================
            sqlComm.CommandText = SqlNewPatientBook()
            sqlComm.ExecuteNonQuery()
            If CheckMoPoGo() = True Then
                'Dim FMoPoCode As New FEnterMoPoTsyoCode
                'If FMoPoCode.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                sqlComm.CommandText = SavePatientMoPoTyso(TxtPatientNo.Text, FormatDateTime(DateRegistration.Value, DateFormat.ShortDate))
                sqlComm.ExecuteNonQuery()
                'Else
                '    Exit Function

            End If
            ' =========== End Transaction Patient Registration Form ==============
            Transaction.Commit()
            Transaction.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Transaction.Rollback()
            EnableFormControl()
            Return False
        Finally
            Con.Close()
            Con.Dispose()
        End Try
    End Function
    Function SqlPatientInformation() As String
        Return StringPatientInformation(TxtPatientNo.Text, DateRegistration.Value, CboProNo.Text, _
                                        CboDisNo.Text, CboCommNo.Text, TxtNameEng.Text, _
                                        TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, _
                                        TxtAddress.Text, CboOccupation.Text, TxtTel.Text, "", _
                                        DateRegistration.Value.Year, ModGlobleVariable.ACHIEVE, IS_Mo_Po_Tsyo, GetTextReferralV1, Format(GetDateServer, "hh:mm:ss tt").ToString)
    End Function

    Function StringPatientInformation( _
      ByVal PatientNo As String, _
      ByVal CreateDate As String, _
     ByVal province As String, _
     ByVal District As String, _
     ByVal Commune As String, _
     ByVal NameEng As String, _
     ByVal NameKh As String, _
     ByVal Age As String, _
     ByVal Sex As String, _
     ByVal address As String, _
     ByVal Occupation As String, _
     ByVal Tel As String, _
     ByVal neighbor As String, _
     ByVal Years As Integer, _
     ByVal Achieve As Boolean, _
     ByVal Is_MoPoTsyo As Boolean, ByVal ComBindRefferal As String, ByVal TIME_CREATE As String) As String
        Dim Field As String = ""
        If Sex = "M" Then
            Field = "Male"
        Else
            Field = "Female"
        End If
        Dim sql As String = "INSERT INTO TblPatients (" & _
        "PatientNo," & _
        "CreateDate," & _
        "Province," & _
        "District," & _
        "Commune," & _
        "NameEng," & _
        "NameKhmer," & _
        "Age," & Field & " ," & _
        "Sex," & _
        "Address," & _
        "Occupation," & _
        "Telephone," & _
        "Neighborly," & _
        "Years,Achieve,Is_MoPoTsyo,ComBindRefferal,TIME_CREATE) " & _
        " VALUES(" & PatientNo & " ,'" & _
        CreateDate & "','" & _
       province.Replace("'", "''") & "','" & _
        District.Replace("'", "''") & "','" & _
        Commune.Replace("'", "''") & "','" & _
        NameEng.Replace("'", "''") & "','" & _
        NameKh.Replace("'", "''") & "'," & _
        Age & ",'" & _
        Sex & "','" & _
        Sex & "','" & _
        address.Replace("'", "''") & "','" & _
        Occupation.Replace("'", "''") & "','" & _
        Tel.Replace("'", "''") & "','" & _
        neighbor.Replace("'", "''") & "'," & Years & ",'" & Achieve & "','" & Is_MoPoTsyo & "','" & ComBindRefferal & "','" & TIME_CREATE & "')"
        Return sql
    End Function

    Function SavePatientMoPoTyso(ByVal PatientNo As Double, ByVal DateFolowup As Date) As String
        Dim sql As String = "INSERT INTO TblMopoTyso (PatientNo,CreateDate) VALUES(" & PatientNo & ",'" & DateFolowup & "')"
        Return sql
    End Function
    Function SqlNewPatientReceipt() As String
        Return Me.StringNewOutpatientReceipt( _
        Me.txtReceiptNumber.Text, _
        Me.txtHN.Text, Me.txtPatient.Text.Replace("'", "''"), _
        Me.txtAmountFigureR.Text, _
        Me.txtAmountFigureD.Text, _
        IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
        IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
        IIf(Me.rdR.Checked = True, Me.txtTotal.Text, 0), _
        IIf(Me.rdD.Checked = True, Me.txtTotal.Text, 0), _
        IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
        IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
        IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
        IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
        Me.txtRate.Text, Me.txtAmountWord.Text, _
        IIf(Me.rdR.Checked = True Or Me.rdD.Checked = True, "1", "0"), _
        IIf(Me.chkSocialFee.Checked = True, 1, 0), _
        IIf(Me.chkSocialFee.Checked = False, 1, 0), _
        "NR", Me.lblCashier.Text, "", 1, Me.dtpDateIn.Value.Date, _
        Format(Date.Now(), "MM/dd/yyyy"), CheckMarkEOD().Year, Format(GetDateServer, "hh:mm:ss tt").ToString, "") ' Me.dtpDateIn.Value.Year)
    End Function

    Public Function StringNewOutpatientReceipt( _
           ByVal ReceiptNo As Long, _
           ByVal HN As Long, _
           ByVal PatientName As String, _
           ByVal CashRiel As Double, _
           ByVal CashUSD As Double, _
           ByVal TotalRiel As Double, _
           ByVal TotalUSD As Double, _
           ByVal ConsultationFeeRiel As Double, _
           ByVal ConsultationFeeUSD As Double, _
           ByVal SocialFeeRiel As Double, _
           ByVal SocialFeeUSD As Double, _
           ByVal FullFeeRiel As Double, _
           ByVal FullFeeUSD As Double, _
           ByVal Rates As Double, _
           ByVal AmountWord As String, _
           ByVal ConCON As String, _
           ByVal ConSocialFee As String, _
           ByVal ConFullFee As String, _
           ByVal ConGeneral As String, _
           ByVal CashierIn As String, _
           ByVal CashierUpdate As String, _
           ByVal PrintCount As Integer, _
           ByVal DateIn As Date, _
           ByVal DateNow As Date, _
           ByVal Years As Integer, ByVal TIME_CREATE As String, ByVal TIME_ISSUE As String) As String

        '-----tblPatientReceipt--------------------------------------------
        Dim sql As String = "INSERT INTO tblPatientReceipt " _
              & " (ReceiptNo, HN, PatientName, CashRiel, CashUSD, TotalRiel, TotalUSD," _
              & " ConsultationFeeRiel, ConsultationFeeUSD, SocialFeeRiel," _
              & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, Rates, AmoutWord, ConCON, ConSocialFee, ConFullFee," _
              & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, DateNow, Years,TIME_CREATE,TIME_ISSUE)" _
              & " VALUES(" & ReceiptNo & "," & HN & ",'" & PatientName & "'," _
              & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
              & ConsultationFeeRiel & "," & ConsultationFeeUSD & "," _
              & SocialFeeRiel & "," & SocialFeeUSD & "," _
              & FullFeeRiel & "," & FullFeeUSD & "," & Rates & ",'" _
              & AmountWord & "','" & ConCON & "','" & ConSocialFee & "','" & ConFullFee & "','" & ConGeneral & "','" _
              & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn & "','" & DateNow & "'," & Years & ",'" & TIME_CREATE & "','" & TIME_ISSUE & "')"
        Return sql
    End Function

    Function SqlRegistrationFormForReferal() As String
        Return Me.StringSaveReferal( _
                TxtPatientNo.Text, _
                DateRegistration.Value, _
                ChHearing.Checked, _
                ChUnderstand.Checked, _
                ChSeeing.Checked, _
                ChPhysical.Checked, _
                ChCDMDP.Checked, _
                ChEyeScreenig.Checked, _
                ChScreeningKV.Checked, _
                ChSelf.Checked, _
                ChPatient.Checked, _
                ChFriend.Checked, _
                ChOtherNGO.Checked, _
                ChChurch.Checked, _
                ChHealth.Checked, _
                ChOtherReferal.Checked, _
                ChPreyKabasVC.Checked, _
                ChPreyScreening.Checked, _
                ChSchoolScreening.Checked, _
                ChMoPoCho.Checked, _
                GetTextReferralV1(), Format(GetDateServer, "hh:mm:ss tt").ToString, GetCombinePatientDisability)
    End Function

    Function StringSaveReferal( _
               ByVal PatientNo As String _
              , ByVal CreateDate As String _
              , ByVal Hearing As Boolean _
              , ByVal Understand As Boolean _
              , ByVal Seeing As Boolean _
              , ByVal Physical As Boolean _
              , ByVal CDMDPatient As Boolean _
              , ByVal EyeScreeningTK As Boolean _
              , ByVal ScreeningKV As Boolean _
              , ByVal Self As Boolean _
              , ByVal PatientReferal As Boolean _
              , ByVal Friend_Relation As Boolean _
              , ByVal OtherNGO As Boolean _
              , ByVal Church As Boolean _
              , ByVal HealthWorker As Boolean _
              , ByVal OtherReferal As Boolean _
              , ByVal PreyKabasVC As Boolean _
              , ByVal PreyScreening As Boolean _
              , ByVal SchoolScreening As Boolean _
              , ByVal MoPoCho As Boolean _
              , ByVal CombinRefferal As String, ByVal TIME_CREATE As String, ByVal ComBindDisability As String) As String
        Dim sql As String = "INSERT INTO TblFollowUp " & _
                    "(PatientNo" & _
                    ",CreateDate" & _
                    ",Hearing" & _
                    ",Understand" & _
                    ",Seeing" & _
                    ",Physical" & _
                    ",CDMDPatient" & _
                    ",EyeSreening" & _
                    ",ScreeningKV" & _
                    ",Self" & _
                    ",PatientReferal" & _
                    ",Friend_Relation" & _
                    ",OtherNGO" & _
                    ",Church" & _
                    ",HealthWorker" & _
                    ",OtherReferal,PreyKabasVC,PreyScreening,SchoolScreening,MoPoCho,ComBindRefferal,TIME_CREATE,ComBindDisability)" & _
                    " VALUES " & _
                    "(" & PatientNo & _
                    ",'" & CreateDate & _
                    "','" & Hearing & _
                    "','" & Understand & _
                    "','" & Seeing & _
                    "','" & Physical & _
                    "','" & CDMDPatient & _
                    "','" & EyeScreeningTK & _
                    "','" & ScreeningKV & _
                    "','" & Self & _
                    "','" & PatientReferal & _
                    "','" & Friend_Relation & _
                    "','" & OtherNGO & _
                    "','" & Church & _
                    "','" & HealthWorker & _
                    "','" & OtherReferal & _
                    "','" & PreyKabasVC & _
                    "','" & PreyScreening & _
                    "','" & SchoolScreening & _
                    "','" & MoPoCho & _
                    "','" & CombinRefferal & _
                    "','" & TIME_CREATE & _
                    "','" & ComBindDisability & "')"
        Return sql
    End Function
    Function SQLSavePatientReferral(ByVal PATIENT_NO As Double, ByVal REFERRAL_FROM As String) As String
        Dim SQL As String = "INSERT INTO REFFERAL_PATIENT_DETAIL (PATIENT_NO,REFERRAL_FROM) VALUES(" & PATIENT_NO & ",'" & REFERRAL_FROM & "')"
        Return SQL
    End Function
    Function SqlNewPatientBook() As String
        Dim Riel As Integer
        Dim Dolar As Integer
        Dim receiptNo As Integer = EmptyString(txtReceiptNumber.Text)
        If ChFree.Checked = True Then
            Riel = 0
            Dolar = 0
            receiptNo = 0
        Else
            If rdR.Checked = True Then
                Riel = EmptyString(txtConsultation.Text)
                Dolar = 0
            End If
            If rdD.Checked = True Then
                Dolar = EmptyString(txtConsultation.Text)
                Riel = 0
            End If
        End If

        Return Me.StringInserNewOutpatient( _
                       receiptNo, _
                        TxtPatientNo.Text, _
                        "", _
                        "", _
                        Riel, _
                        Dolar, _
                        False, _
                        False, _
                        ChHearing.Checked, _
                        ChUnderstand.Checked, _
                        ChSeeing.Checked, _
                        ChPhysical.Checked, _
                        TxtOther.Text, _
                        DateRegistration.Value, GetTextReferralV1, Format(GetDateServer, "hh:mm:ss tt").ToString)
    End Function

    Function StringInserNewOutpatient( _
       ByVal ReceiptNo As String, _
       ByVal PatientNo As String, _
       ByVal Diagnosis As String, _
       ByVal DiagnosisTem As String, _
       ByVal PatientFee As String, _
       ByVal PatientDolar As String, _
       ByVal Prescribed As Boolean, _
       ByVal Dispensed As Boolean, _
       ByVal Hearing As Boolean, _
       ByVal Understand As Boolean, _
       ByVal Seeing As Boolean, _
       ByVal Physical As Boolean, _
       ByVal Other As String, _
       ByVal CreateDate As String, ByVal CombindRefferal As String, ByVal TIME_CREATE As String) As String
        Dim sql As String = "INSERT INTO TblNew_Old_OutPatient ( " & _
        "ReceiptNo," & _
        "PatientNo," & _
        "Diagnosis," & _
        "DiagnosisTem," & _
        "PatientFee," & _
        "PatientDolar," & _
        "Prescribed," & _
        "Dispensed," & _
        "Hearing," & _
        "Understand," & _
        "Seeing," & _
        "Physical," & _
        "Other," & _
        "CreateDate," & _
        "ComBindRefferal,TIME_CREATE)" & _
        " VALUES(" & _
        ReceiptNo & "," & _
        PatientNo & ",'" & _
        Diagnosis & "','" & _
        DiagnosisTem & "'," & _
        PatientFee & "," & _
        PatientDolar & ",'" & _
        Prescribed & "','" & _
        Dispensed & "','" & _
        Hearing & "','" & _
        Understand & "','" & _
        Seeing & "','" & _
        Physical & "','" & _
        Other & "','" & _
        CreateDate & "','" & CombindRefferal & "','" & TIME_CREATE & "')"
        Return sql
    End Function

    Private Sub TxtNameKhmer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNameKhmer.TextChanged
        txtPatient.Text = TxtNameKhmer.Text
    End Sub


    Private Sub BgLoadReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadReport.DoWork
        DoPrintNewReceipt()
        Thread.Sleep(500)
        Application.DoEvents()
        DoPrintRegistrationFormV2()
    End Sub

    Private Sub BgLoadReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadReport.RunWorkerCompleted
        EnableFormControl()
    End Sub

    Private Sub CboProNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboProNo.GotFocus

        Try
            With CboProNo
                .DataSource = ModProvince.SelectProvice()
                .DisplayMember = "Province"
                .ValueMember = "IDProvCode"
                .Text = Nothing
                '.SelectAll()
            End With
            CboDisNo.Text = Nothing
            CboCommNo.Text = Nothing
            TxtAddress.Text = Nothing
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CboDisNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboDisNo.GotFocus

        Try
            With CboDisNo
                .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
                .DisplayMember = "DISTRICT"
                .ValueMember = "SrokCode"
                .Text = Nothing
                '.SelectAll()
            End With
            CboCommNo.Text = Nothing
            TxtAddress.Text = Nothing
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CboCommNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommNo.GotFocus
        Try
            With CboCommNo
                .DataSource = ModProvince.SelectCommune(CInt(CboDisNo.SelectedValue))
                .DisplayMember = "Commune"
                .ValueMember = "KhumCode"
                .Text = Nothing
                '.SelectAll()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtAgePatient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAgePatient.KeyPress
        SetDisableKeyString(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.CboSexPatien.Focus()
        End If
    End Sub

    Private Sub TxtAgePatient_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAgePatient.KeyUp

        If e.KeyCode = 190 Then
            TxtAgePatient.Text = ""
        End If
        If TxtAgePatient.Text.Length > 2 Then
            MsgBox("Patient's age can not > 100.", MsgBoxStyle.Critical, "Error")
            TxtAgePatient.Text = ""
        End If
    End Sub

    Private Sub CboSexPatien_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboSexPatien.KeyDown
        Select Case e.KeyCode
            Case Keys.F
                Me.CboSexPatien.Text = "F"
            Case Keys.M
                Me.CboSexPatien.Text = "M"
            Case Keys.Enter
                TxtTel.Focus()
            Case Else
                If e.KeyCode = Keys.Enter Then
                    Me.TxtTel.Focus()
                End If
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub CboSexPatien_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboSexPatien.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TxtTel.Focus()
        End If
    End Sub

    Private Sub CboCommNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.TextChanged
        TxtAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
    End Sub



    Private Sub ChFree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChFree.Checked = True Then
            ClearFormReceipt()
        End If
    End Sub

    Private Sub BgLoadRegistrationForm_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadRegistrationForm.DoWork
        'DoPrintRegistrationForm()
        DoPrintRegistrationFormV2()
    End Sub

    Private Sub BgLoadRegistrationForm_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadRegistrationForm.RunWorkerCompleted
        EnableFormControl()
    End Sub
    Sub EnableFormControl()
        cmdSave.Enabled = True
        cmdClose.Enabled = True
        LblLoadPring.Visible = False
        PicLoadReport.Visible = False
        ClearFormPatient()
        ClearFormReceipt()
        LoadNewPatientNo()
        LoadNewReceiptNo()
        Call GetValueNew()
    End Sub

    Private Sub DateRegistration_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateRegistration.ValueChanged
        Dim firstDate As DateTime = GetDateServer.Date
        Dim secondDate As DateTime = DateRegistration.Value.Date
        Dim result As Int16 = DateTime.Compare(firstDate, secondDate)
        If result > 0 Then
            MessageBox.Show("You can not move less than current date", "Error Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateRegistration.Value = GetDateServer()
            DateRegistration.Select()
            DateRegistration.Focus()
            Exit Sub
            'Else
            '    dtpDateIn.Value = DateRegistration.Value
        End If

    End Sub

    Private Sub dtpDateIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateIn.ValueChanged
        DateRegistration.Value = dtpDateIn.Value
    End Sub

    Private Sub TxtNameEng_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNameEng.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                Dim StrFirst As String = TxtNameEng.Text.Substring(0, 1).ToUpper
                Dim StrLast As String = TxtNameEng.Text.Substring(1, TxtNameEng.Text.Length - 1)
                TxtNameEng.Text = StrFirst & StrLast
            Catch ex As Exception

            End Try
            TxtNameKhmer.Focus()

        End If
    End Sub

    Private Sub TxtNameKhmer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNameKhmer.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAgePatient.Focus()
        End If
    End Sub

    Private Sub TxtAgePatient_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAgePatient.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboSexPatien.Focus()
        End If
    End Sub

    Private Sub TxtTel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTel.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboOccupation.Focus()
        End If
    End Sub
    Private Sub CboOccupation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboOccupation.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtOther.Focus()
        End If
    End Sub

    Private Sub TxtOccupation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CboProNo.Focus()
        End If
    End Sub

    Private Sub CboProNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboProNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboDisNo.Focus()
        End If
    End Sub

    Private Sub CboDisNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboDisNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboCommNo.Focus()
        End If
    End Sub

    Private Sub CboCommNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboCommNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAddress.Focus()
            TxtAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
        End If
    End Sub

    Private Sub ChHearing_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChHearing.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChUnderstand.Focus()
        End If
    End Sub

    Private Sub ChUnderstand_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChUnderstand.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChSeeing.Focus()
        End If
    End Sub

    Private Sub ChSeeing_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChSeeing.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChPhysical.Focus()
        End If
    End Sub

    Private Sub ChPhysical_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChPhysical.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChSelf.Focus()
        End If
    End Sub

    Private Sub ChSelf_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChPatient.Focus()
        End If
    End Sub

    Private Sub ChPatient_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChFriend.Focus()
        End If
    End Sub

    Private Sub ChFriend_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChCDMDP.Focus()
        End If
    End Sub

    Private Sub ChCDMDP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChEyeScreenig.Focus()
        End If
    End Sub

    Private Sub ChEyeScreenig_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChChurch.Focus()
        End If
    End Sub

    Private Sub ChOtherNGO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChHealth.Focus()
        End If
    End Sub

    Private Sub ChChurch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChOtherNGO.Focus()
        End If
    End Sub

    Private Sub ChHealth_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChOtherReferal.Focus()
        End If
    End Sub

    Private Sub ChOtherReferal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChFree.Focus()
        End If
    End Sub

    Private Sub ChFree_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChFree.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtConsultation.Focus()
        End If
    End Sub

    Private Sub DateRegistration_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateRegistration.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPatientNo.Focus()
        End If
    End Sub

    Private Sub TxtPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNameEng.Focus()
        End If
    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChHearing.Focus()
        End If
    End Sub

    
    Private Sub ChFree_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChFree.CheckedChanged
        If ChFree.Checked = True Then
            GroupReceipt.Enabled = False
        Else
            GroupReceipt.Enabled = True
        End If
    End Sub

   
   
   
    Private Sub TxtNameEng_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNameEng.Leave
        Try
            Dim StrFirst As String = TxtNameEng.Text.Substring(0, 1).ToUpper
            Dim StrLast As String = TxtNameEng.Text.Substring(1, TxtNameEng.Text.Length - 1)
            TxtNameEng.Text = StrFirst & StrLast
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub TxtOther_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOther.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboProNo.Focus()
        End If
    End Sub

 
   
   
   
    
   
    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub NewPatientPayment_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        MoveFormOnMouseDown(e)
    End Sub

    Private Sub NewPatientPayment_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        MoveFormOnMouseMove(e, Me)
    End Sub
End Class