Imports System.Math
Public Class FormForNewOutpatientAchive
    Dim PatientAchieve As UCAchievePatient
    Dim IS_Mo_Po_Tsyo As Boolean = False
    Dim DA_Referral As New DSREFFERRAL_TEHTableAdapters.REFFERAL_TEHTableAdapter
    Sub New(ByVal patientAchieve As UCAchievePatient)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PatientAchieve = patientAchieve
        LoadNewPatientNo()
        LoadOldPatientReceipt()
        ' Add any initialization after the InitializeComponent() call.
        With CboDiagnosis
            .DataSource = ModDiagnosis.SelectMainSurgery()
            .DisplayMember = "Surgery"
            .ValueMember = "SID"
            .Text = Nothing
        End With
        With CboOther
            .DataSource = ModDoctor.SelectOther
            .ValueMember = "Other"
            .SelectedValue = "No"
            .Text = Nothing
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()
        InitializeComponent()
        LoadNewPatientNo()
        LoadOldPatientReceipt()
        ' Add any initialization after the InitializeComponent() call.
        With TxtOccupation
            .DataSource = ModOccupation.SelectAllOccupation()
            .ValueMember = "Occupation"
            .SelectedValue = "OccNo"
            .Text = Nothing
        End With
        With CboDiagnosis
            .DataSource = ModDiagnosis.SelectMainSurgery()
            .DisplayMember = "Surgery"
            .ValueMember = "SID"
            .Text = Nothing
        End With
        With CboOther
            .DataSource = ModDoctor.SelectOther
            .ValueMember = "Other"
            .SelectedValue = "No"
            .Text = Nothing
        End With
    End Sub
    Sub LoadNewPatientNo()
        TxtNewPatientNo.Text = ModCommon.GeneratePatientNoForScreening("No", "TblPatients")
        txtHN.Text = ModCommon.GeneratePatientNoForScreening("No", "TblPatients")
    End Sub
    Sub LoadOldPatientReceipt()
        Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
    End Sub
    Private Sub FormForNewOutpatientAchive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplitContainer1.SplitterDistance = (Me.Height / 2)
        ' Load data for Old Patient receipt
        Me.lblCashierLogin.Text = ""
        Me.dtpDateIn.Checked = False
        Me.lblCashierLogin.Text = USER_NAME
        Me.lblCashier.Text = USER_NAME
        Call GetRates()
        Me.lblFees.Text = ""
        If isTrueFalse = False Then
            Me.lblReceiptToPrintID.Text = ""    '------------for printing receipt-------------
            Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
        Else
            'Call SearchOldOPReceipt()
        End If
        AccRolesCashier = False
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Cashier" Then
                    AccRolesCashier = True
                    Me.cmdSave.Enabled = False
                ElseIf .Item(0) = "New Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    Me.cmdSave.Enabled = True
                    AccRolesCashier = False
                ElseIf .Item(0) = "Old Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    Me.cmdSave.Enabled = True
                    AccRolesCashier = False
                ElseIf .Item(0) = "Administrator" Then
                    AccRolesCashier = True
                    Me.cmdSave.Enabled = True
                End If
            End With
        Next
        InitChListReferral()
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
    Sub GetRates()
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
                Me.txtRate.Text = .Rows(0).Item(0)
            End If
        End With
    End Sub
    Function CheckSave(ByVal Free As Boolean) As Boolean
        Dim month As Integer = DateRegistration.Value.Month
        Dim year As Integer = DateRegistration.Value.Year
        Dim d As Integer = DateRegistration.Value.Day
        Dim sValue As String = year & month
        If DateRegistration.Checked = False Then
            MsgBox("Could you check date registration", MsgBoxStyle.Critical, "Error")
            DateRegistration.Select()
            DateRegistration.Focus()
            Return False
        ElseIf CInt(sValue) >= 20109 Then
            MessageBox.Show("Patient achive data must before date(1-9-2010).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        ElseIf ValidateTextField(TxtReceiptNo, "ReceiptNo", ErrNewOut) = False Or _
                    ValidateTextField(TxtNameEng, "english name", ErrNewOut) = False Or _
                    ValidateTextField(TxtNameKhmer, "khmer name", ErrNewOut) = False Or _
                    ValidateTextField(TxtAgePatient, "age", ErrNewOut) = False Or _
                    ValidateCombobox(CboSexPatien, "sex", ErrNewOut) = False Or _
                    ValidateTextField(TxtOldPatientNo, "", ErrNewOut) = False Or _
                    ValidateCombobox(CboProNo, "", ErrNewOut) = False Or _
                    ValidateCombobox(CboDisNo, "", ErrNewOut) = False Or _
                    ValidateCombobox(CboCommNo, "", ErrNewOut) = False Or _
                    ValidateCombobox(CboDiagnosis, "diagnosis", ErrNewOut) = False Or _
                    ValidateCombobox(TxtOccupation, "occupation", ErrNewOut) = False Then
            Return False

        ElseIf ModNew_Outpatient.CheckOldPatientExisting(TxtOldPatientNo.Text) > 0 Then
            MsgBox("This patient already existing in system. Could you find this number" & TxtOldPatientNo.Text, MsgBoxStyle.Critical, "Error")
            TxtOldPatientNo.Focus()
            Return False
            '========================== Check validate on Old patient receipt =========================

        End If
        If Free = False Then
            'If dtpDateIn.Value.DayOfYear < ModGlobleVariable.GeteDateServer.DayOfYear Then
            '    MsgBox("Receipt date can not < " & ModGlobleVariable.GeteDateServer, MsgBoxStyle.Critical, "Error")
            '    Return False
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
            ElseIf Me.dtpDateIn.Checked = False Then
                MsgBox("Please select date to save.", MsgBoxStyle.Information, "Date confirm")
                Me.dtpDateIn.Focus()
                Return False
            ElseIf Me.txtRate.Text = "" Then
                MsgBox("Please check the rate. This operation cannot work without rate.", MsgBoxStyle.Information, "Rate confirm")
                Me.txtRate.Focus()
                Return False
            ElseIf Me.txtPatient.Text = "" Then
                MsgBox("Please enter the patient name.", MsgBoxStyle.Information, "Patient confirm")
                Me.txtPatient.Focus()
                Return False
            ElseIf Me.rdFollowUpR.Checked = False And Me.rdFollowUpD.Checked = False Then
                MsgBox("Please enter the amount of follow up or artificial or other fee.", MsgBoxStyle.Information, "Hospital fee confirm")
                Me.rdFollowUpR.Focus()
                Return False
            ElseIf Me.rdFollowUpR.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter follow up fee in Riel.", MsgBoxStyle.Information, "Follow up fee Riel confirm")
                Me.txtFollowUp.Focus()
                Return False
            ElseIf Me.rdFollowUpD.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter follow up fee in Dollar.", MsgBoxStyle.Information, "Follow up fee Dollar confirm")
                Me.txtFollowUp.Focus()
                Return False
            ElseIf Me.txtAmountWord.Text = "" Then
                MsgBox("Please enter the amount payment in word.", MsgBoxStyle.Information, "Amount payment word confirm")
                Me.txtAmountWord.Focus()
                Return False
            ElseIf AccRolesCashier = True Then
                If Me.chkRiel.Checked = False And Me.chkDollar.Checked = False Then
                    MsgBox("Please enter any amount in figure Riel or Dollar.", MsgBoxStyle.Information, "Amount figure Riel or Dollar confirm")
                    Me.chkRiel.Checked = True
                    Return False
                ElseIf Me.chkRiel.Checked = True And Me.chkDollar.Checked = True And Me.txtAmountFigureR.Text = "0" And Me.txtAmountFigureD.Text = "0" Then
                    MsgBox("Please enter amount figure Riel or Dollar.", MsgBoxStyle.Information, "Amount figure Riel or Dollar confirm")
                    Me.txtAmountFigureR.Focus()
                    Return False
                ElseIf Me.chkRiel.Checked = True And Me.txtAmountFigureR.Text = "0" Then
                    MsgBox("Please enter the amount of figure in Riel.", MsgBoxStyle.Information, "Amount figure Riel confirm")
                    Me.txtAmountFigureR.Focus()
                    Return False
                ElseIf Me.chkDollar.Checked = True And Me.txtAmountFigureD.Text = "0" Then
                    MsgBox("Please enter the amount of figure in Dollar.", MsgBoxStyle.Information, "Amount figure Dollar confirm")
                    Me.txtAmountFigureD.Focus()
                    Return False
                End If
            End If
            'If CheckStatusReferal() = False Then
            '    MessageBox.Show("Please check referal from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    GrpReferal.BackColor = Color.Khaki
            '    Return False
            'Else
            '    GrpReferal.BackColor = Color.Transparent
            '    Return True
            'End If
            If GetTextReferralV1() = "" Then
                ChListReferral.BackColor = Color.Aqua
                MessageBox.Show("Please check referal from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                ChListReferral.BackColor = Color.White
                Return True
            End If
        End If
        Return True
    End Function
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If CheckSave(ChPatientFree.Checked) = False Then
            Exit Sub
        End If
       

        Dim ExistingPatientInfo As Integer = ModRegistration.CheckDuplicatePatient(TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, TxtAddress.Text)
        If ExistingPatientInfo <> 0 Then
            MessageBox.Show("Patient No​ " & ExistingPatientInfo & " have in system already." & Chr(13) & "Please pay attention for this patient as it is similar or unique to the existing in the system.", "Patient check duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ChMoPoCho.Checked = True Then
            IS_Mo_Po_Tsyo = True
        Else
            IS_Mo_Po_Tsyo = False
        End If
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If SaveBacthPatientAchive() = True Then
                    MsgBox("Save achive patient successfully.", MsgBoxStyle.Information, "Save")
                    cmdSave.Enabled = False
                    PictureBox1.Visible = True
                    cmdClose.Enabled = False
                    LblPrinting.Visible = True
                    Me.lblID.Text = 0
                    AccRolesCashier = True
                    isTrueFalse = False
                    'Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
                    If ChPatientFree.Checked = False Then
                        BgPrint.RunWorkerAsync()
                    Else
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    End If

                Else
                    MessageBox.Show("Error, save achive patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If

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
    Dim checkPrint As Boolean = False
    Dim ReportOOPR As New ReportOldOutPatientReceipt
    Private Sub PrintReportOOPR()
        Try

            '-------------Report Form Active--------------------------------
            ReportOOPR.SetDataSource(MOldOutpatientReceipt.ReportOldOutpatientReceipt(Me.txtReceiptNumber.Text).Tables(1))
            If checkPrint = True Then
                Dim frmReportOOPR As New frmReportOldOutPatientReceipt
                frmReportOOPR.crvReportOldOutPatientReceipt.ReportSource = ReportOOPR
                ReportOOPR.Refresh()
                frmReportOOPR.ShowDialog()
                frmReportOOPR.Dispose()
                frmReportOOPR.Close()
            Else
                Try
                    printDocument.PrinterSettings.PrinterName = ModCommon.PrinterReceipt
                    ' printDocument.PrinterSettings.PaperSizes(0).Kind = Printing.PaperKind.A5
                    ReportOOPR.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
                    ReportOOPR.PrintOptions.PaperSize = Printing.PaperKind.A5  'CrystalDecisions.Shared.PaperSize.PaperA5
                    ReportOOPR.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                    ReportOOPR.PrintToPrinter(1, True, 1, 1)
                    ReportOOPR.Dispose()
                    ReportOOPR.Close()
                Catch ex As Exception
                    MsgBox("Can't find printer." & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Function SaveBacthPatientAchive() As Boolean         '--------------Question = Do check or count referal for every followup patient ?-------------------------
        '---------------Renew Receipt ID First time before saving----------------------------------------------------------
        
        Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim sqlComm As SqlClient.SqlCommand = Con.CreateCommand
        Dim Transaction As SqlClient.SqlTransaction = Nothing
        Transaction = Con.BeginTransaction
        sqlComm.Transaction = Transaction
        Try
            '------------recall HN after redundency----------
            If ModCommon.CheckDuplicateHN(Me.TxtNewPatientNo.Text, "TblPatients") = True Then
                'MsgBox("PatientNo: " & TxtNewPatientNo.Text & " already existing in system. It will change to new number. Could you click save agian.", MsgBoxStyle.Exclamation, "PatientNo")
                LoadNewPatientNo()
                TxtNewPatientNo.Focus()
                TxtNewPatientNo.SelectAll()
            End If
            If MCashReceipt.CheckDuplicateReceiptNo(Me.txtReceiptNumber.Text, "tblPatientReceipt") = True Then
                'MsgBox("Duplicatate ID receipt. Please click to save agian.", MsgBoxStyle.Critical, "Error")
                LoadOldPatientReceipt()
            End If
            '----------------------- Save to Patient table ------------------------------------------------------
            sqlComm.CommandText = DoSavePatients()
            sqlComm.ExecuteNonQuery()
            '-----------------------Save to tblPatientReceipt -----------------------------------------------------
            If ChPatientFree.Checked = False Then
                sqlComm.CommandText = SqlSaveOldOutpatientReceipt()
                sqlComm.ExecuteNonQuery()
            End If

            '---------------------- save to Old patient book-------------------------------------------------------
            sqlComm.CommandText = DoSaveOldPatientBook()
            sqlComm.ExecuteNonQuery()
           
            
            ' =========== Save Patient Registration Form         ==================
            sqlComm.CommandText = SqlSaveOrUpdateRegistrationFormForReferal()
            sqlComm.ExecuteNonQuery()
            'End If
            'Check condition for old patient Mo-po-Ch
            If ChMoPoCho.Checked = True Then
                'Dim FMoPoCode As New FEnterMoPoTsyoCode
                'If FMoPoCode.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                sqlComm.CommandText = StringPatientMoPoTyso(txtHN.Text, FormatDateTime(dtpDateIn.Value, DateFormat.ShortDate))
                sqlComm.ExecuteNonQuery()
                'Else
                '    Exit Function
            End If
            'End If
            Transaction.Commit()
            Transaction.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Transaction.Rollback()
            Return False
        Finally
            Con.Close()
            Con.Dispose()
        End Try
    End Function


    Function DoSavePatients() As String
        Return SqlSavePatients(TxtOldPatientNo.Text, TxtNewPatientNo.Text, DateRegistration.Value, CboProNo.Text, CboDisNo.Text, CboCommNo.Text, TxtNameEng.Text, TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, TxtAddress.Text, TxtOccupation.Text, TxtTel.Text, "", Today.Year, True, IS_Mo_Po_Tsyo)
    End Function
    Function SqlSavePatients(ByVal OldPatientNo As String, _
    ByVal NewPatientNo As String, _
    ByVal RegisDate As Date, _
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
    ByVal Achieve As Boolean, ByVal Is_MoPoTsyo As Boolean) As String
        Dim Field As String = ""
        If Sex = "M" Then
            Field = "Male"
        Else
            Field = "Female"
        End If

        Dim sql As String = "INSERT INTO TblPatients (" & _
        "PatientNo," & _
        "OlePatientNo," & _
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
        "Years,Achieve,Is_MoPoTsyo) " & _
        " VALUES(" & NewPatientNo & " ," & _
        OldPatientNo & " ,'" & _
        RegisDate & "','" & _
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
        neighbor.Replace("'", "''") & "'," & _
        Years & ",'" & _
        Achieve & "','" & Is_MoPoTsyo & "')"
        Return sql
    End Function
    Function DoSaveOldPatientBook() As String
        Dim Riel As Integer
        Dim Dolar As Integer
        If rdFollowUpR.Checked = True Then
            Riel = EmptyString(txtFollowUp.Text)
            Dolar = 0
        End If
        If rdFollowUpD.Checked = True Then
            Dolar = EmptyString(txtFollowUp.Text)
            Riel = 0
        End If
        Return SQLSaveOldPatientBook(IIf(ChPatientFree.Checked = False, EmptyString(txtReceiptNumber.Text), 0), _
        TxtNewPatientNo.Text, "", "", _
        Riel, Dolar, CboOther.Text, dtpDateIn.Value, ChTypeOther.Checked, GetTextReferralV1)
    End Function
    Function SQLSaveOldPatientBook( _
   ByVal ReceiptNo As String, _
    ByVal PatientNo As String, _
   ByVal Diagnosis As String, _
    ByVal DiagnosisTem As String, _
    ByVal PatientFeeReal As String, _
    ByVal PatientDolar As String, _
   ByVal Other As String, _
   ByVal CreateDate As Date, _
   ByVal TypeDiagnosis As Boolean, ByVal CombinDiagnosis As String) As String
        Dim sql As String = "INSERT INTO TblNew_Old_OutPatient ( " & _
        "ReceiptNo," & _
       "PatientNo," & _
        "Diagnosis," & _
        "DiagnosisTem," & _
        "PatientFee," & _
        "PatientDolar," & _
        "Other," & _
        "CreateDate," & _
        "Status," & _
        "TypeDiagnosis,ComBindRefferal) " & _
        "VALUES(" & _
        ReceiptNo & "," & _
        PatientNo & ",'" & _
        Diagnosis & "','" & _
        DiagnosisTem & "'," & _
        PatientFeeReal & "," & _
        PatientDolar & ",'" & _
        Other & "','" & _
        CreateDate & "','" & _
        "True','" & _
        TypeDiagnosis & _
        "','" & CombinDiagnosis & "')"
        Return sql
    End Function
    Function SqlSaveOldOutpatientReceipt() As String
        Return Me.SaveOldOutpatientReceipt(Me.txtReceiptNumber.Text, _
                        Me.txtHN.Text, _
                        Me.txtPatient.Text, _
                        Me.txtAmountFigureR.Text, _
                        Me.txtAmountFigureD.Text, _
                        IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                        IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                        IIf(Me.rdFollowUpR.Checked = True, Me.txtTotal.Text, 0), _
                        IIf(Me.rdFollowUpD.Checked = True, Me.txtTotal.Text, 0), _
                        IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                        IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                        IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                        IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                        Me.txtRate.Text, Me.txtAmountWord.Text, IIf(Me.rdFollowUpR.Checked = True Or Me.rdFollowUpD.Checked = True, "1", "0"), _
                        IIf(Me.chkSocialFee.Checked = True, 1, 0), _
                        IIf(Me.chkSocialFee.Checked = False, 1, 0), "OR", Me.lblCashier.Text, "", 1, _
                        Me.dtpDateIn.Value, dtpDateIn.Value.Year)
    End Function
    Function SaveOldOutpatientReceipt( _
      ByVal ReceiptNo As Long, ByVal HN As Long, ByVal PatientName As String, _
      ByVal CashRiel As Double, ByVal CashUSD As Double, _
      ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
      ByVal FollowUpFeeRiel As Double, ByVal FollowUpFeeUSD As Double, _
      ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
      ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, _
      ByVal AmountWord As String, ByVal ConFOL As String, ByVal ConSocialFee As String, _
      ByVal ConFullFee As String, ByVal ConGeneral As String, _
      ByVal CashierIn As String, ByVal CashierUpdate As String, _
      ByVal PrintCount As Integer, ByVal DateIn As Date, ByVal Years As Integer) As String

        Dim sql As String = " INSERT INTO tblPatientReceipt " _
                & " (ReceiptNo, HN, PatientName, CashRiel, CashUSD, TotalRiel, TotalUSD," _
                & " FollowUpFeeRiel, FollowUpFeeUSD, SocialFeeRiel," _
                & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, Rates, AmoutWord, ConFOL, ConSocialFee, ConFullFee," _
                & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, Years)" _
                & " VALUES(" & ReceiptNo & "," & HN & ",'" & PatientName & "'," _
                & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
                & FollowUpFeeRiel & "," & FollowUpFeeUSD & "," _
                & SocialFeeRiel & "," & SocialFeeUSD & "," _
                & FullFeeRiel & "," & FullFeeUSD & "," & Rates & ",'" _
                & AmountWord & "','" & ConFOL & "','" & ConSocialFee & "','" & ConFullFee & "','" & ConGeneral & "','" _
                & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn & "'," & Years & ")"
        Return sql

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


    Function SqlSaveOrUpdateRegistrationFormForReferal() As String
        Return Me.StringSaveReferal( _
               txtHN.Text, _
               dtpDateIn.Value, _
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
               GetTextReferralV1())
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
                , ByVal ComBindRefferal As String) As String
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
                    ",OtherReferal,PreyKabasVC,PreyScreening,SchoolScreening,MoPoCho,ComBindRefferal,FollowUpStatus)" & _
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
                    "','" & ComBindRefferal & "',1)"
        Return sql
    End Function
  
    Function StringPatientMoPoTyso(ByVal PatientNo As Integer, ByVal CreateDate As Date) As String
        Dim sql As String = "INSERT INTO TblMopoTyso (PatientNo,CreateDate) VALUES(" & PatientNo & ",'" & CreateDate & "')"
        Return sql
    End Function

    Private Sub CboProNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboProNo.GotFocus
        With CboProNo
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
            .SelectAll()
        End With
        CboDisNo.Text = ""
        CboCommNo.Text = ""
    End Sub

    Private Sub CboProNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboProNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboDisNo.Focus()
        End If
    End Sub

    Private Sub CboDisNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboDisNo.GotFocus
        With CboDisNo
            .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
            .DisplayMember = "DISTRICT"
            .ValueMember = "SrokCode"
            .SelectAll()
        End With
        CboCommNo.Text = ""
    End Sub

    Private Sub CboDisNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboDisNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboCommNo.Focus()
        End If
    End Sub

    Private Sub CboCommNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommNo.GotFocus
        With CboCommNo
            .DataSource = ModProvince.SelectCommune(CInt(CboDisNo.SelectedValue))
            .DisplayMember = "Commune"
            .ValueMember = "KhumCode"
            .SelectAll()
        End With
    End Sub

    Private Sub CboCommNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboCommNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAddress.Focus()
        End If
    End Sub

    Private Sub CboCommNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.SelectedIndexChanged
        TxtAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
    End Sub

    Private Sub TxtAgePatient_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAgePatient.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboSexPatien.Focus()
        End If
    End Sub

    Private Sub TxtAgePatient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAgePatient.KeyPress
        ModCommon.SetDisableKeyString(e)
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
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub CboSexPatien_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboSexPatien.KeyPress
        SetDisableKey(e)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub rdFollowUpR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdFollowUpR.CheckedChanged
        If Me.rdFollowUpR.Checked = True Then
            Me.txtFollowUp.Enabled = True
            Me.txtFollowUp.Text = ""
            Me.txtFollowUp.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "OPFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtFollowUp.Text = "0"
            Me.txtFollowUp.Enabled = False
        End If
    End Sub

    Private Sub rdFollowUpD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdFollowUpD.CheckedChanged
        If Me.rdFollowUpD.Checked = True Then
            Me.txtFollowUp.Enabled = True
            Me.txtFollowUp.Text = ""
            Me.txtFollowUp.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "OPFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtFollowUp.Text = "0"
            Me.txtFollowUp.Enabled = False
        End If
    End Sub

    Private Sub txtFollowUp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFollowUp.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtFollowUp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFollowUp.LostFocus
        If Me.txtFollowUp.Text.Trim = "" Then
            Me.txtFollowUp.Text = "0"
        End If
    End Sub

    Private Sub txtFollowUp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFollowUp.MouseClick
        Me.txtFollowUp.SelectAll()
    End Sub

    Private Sub txtFollowUp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFollowUp.TextChanged
        If Me.txtFollowUp.Text.Trim > "0" Then
            Me.txtTotal.Text = Me.txtFollowUp.Text.Trim
            Call InpatientPayment()
        Else
            Me.txtTotal.Text = "0"
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

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
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

    Private Sub txtAmountFigureR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountFigureR.TextChanged
        Call InpatientPayment()
    End Sub

    Private Sub txtAmountFigureR_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAmountFigureR.MouseClick
        If Me.txtAmountFigureR.Text = "0" Then
            Me.txtAmountFigureR.Text = ""
        End If
    End Sub

    Private Sub txtAmountFigureR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountFigureR.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtAmountFigureD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountFigureD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtAmountFigureD_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAmountFigureD.MouseClick
        If Me.txtAmountFigureD.Text = "0" Then
            Me.txtAmountFigureD.Text = ""
        End If
    End Sub

    Private Sub txtAmountFigureD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountFigureD.TextChanged
        Call InpatientPayment()
    End Sub

    Private Sub TxtNameKhmer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNameKhmer.TextChanged
        txtPatient.Text = TxtNameKhmer.Text
    End Sub

    Private Sub BgPrint_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgPrint.DoWork
        Call PrintReportOOPR()
    End Sub

    Private Sub ChPrintPreveiw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChPrintPreveiw.CheckedChanged
        checkPrint = ChPrintPreveiw.Checked
    End Sub

    Private Sub BgPrint_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgPrint.RunWorkerCompleted
        cmdSave.Enabled = True
        PictureBox1.Visible = False
        cmdClose.Enabled = True
        LblPrinting.Visible = True
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub TxtOldPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOldPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub DateRegistration_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateRegistration.ValueChanged
        'dtpDateIn.Checked = True
        'dtpDateIn.Value = DateRegistration.Value
    End Sub

    Private Sub dtpDateIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateIn.ValueChanged
        'DateRegistration.Checked = True
        'DateRegistration.Value = dtpDateIn.Value
    End Sub

    Private Sub ChPatientFree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChPatientFree.CheckedChanged
        If ChPatientFree.Checked = True Then
            GPReceiptOldPatient.Enabled = False
        Else
            GPReceiptOldPatient.Enabled = True
        End If
    End Sub

    
End Class