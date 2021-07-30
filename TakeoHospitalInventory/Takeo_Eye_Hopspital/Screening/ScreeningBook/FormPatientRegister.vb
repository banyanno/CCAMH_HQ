Imports System.Runtime.InteropServices
Imports CrystalDecisions.Shared

Public Class FormPatientRegister
    Dim DashScreeningRegis As DashboardScreeningRegisBook
    Dim IS_ONSCRENNING As Boolean = False
    'Dim DA_DefaultSetting As New DataSetSceenSettingTableAdapters.SCREEN_SYSTEMSETTINGTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboProNo
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal DashScreeningRegis As DashboardScreeningRegisBook, ByVal IS_ONSCRENNING As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboProNo
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
            .SelectedIndex = -1
        End With
        Me.DashScreeningRegis = DashScreeningRegis
        Me.IS_ONSCRENNING = IS_ONSCRENNING
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub FormPatientRegister_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        MoveFormOnMouseDown(e)
    End Sub

    Private Sub FormPatientRegister_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        MoveFormOnMouseMove(e, Me)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Public Sub LoadDefaultAddressSetting()
        'Dim TblSetting As DataTable = DA_DefaultSetting.SelectDefaultSetting
        'For Each rows As DataRow In TblSetting.Rows
        '    LblSettingID.Text = rows("SETTING_ID").ToString()
        '    DateRegis.Value = rows("SETTING_DATE")
        '    TxtHealthNameCenter.Text = rows("HEALTH_NAME").ToString
        '    CboProNo.Text = rows("PROVINCE").ToString
        '    CboDisNo.Text = rows("DISTRICT").ToString
        '    CboCommNo.Text = rows("COMMUNE").ToString
        '    TxtFullAddress.Text = rows("FULL_ADDRESS").ToString
        'Next
    End Sub

    Private Sub FormPatientRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ResetFormRegister()
    End Sub
    Sub LoadNewPatientNo()
        PatientNo.Text = ModCommon.GeneratePatientNoForScreening("No", "TblPatients")
        'txtHN.Text = TxtPatientNo.Text
    End Sub

    Function SaveProcessForNewPatient() As Boolean
        If ModCommon.CheckDuplicateHN(Me.PatientNo.Text, "TblPatients") = True Then      '------------recall HN after redundency----------
            LoadNewPatientNo()
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


            ' ========== Save new Screening book ================================
            sqlComm.CommandText = ScreeningBook()
            sqlComm.ExecuteNonQuery()

            '=== get Screening book No ====================
            sqlComm.CommandText = GetLastScreeningBookID()
            Dim SCREENING_BOOKID As Double = CDbl(sqlComm.ExecuteScalar.ToString)

            ' ================ Incase insert referfal ============================
            If RadReferAndPickup.Checked = True Then
                sqlComm.CommandText = InsertReferralBook(SCREENING_BOOKID, PatientNo.Text, "", "", "", True, "", DateRegis.Value.Date)
                sqlComm.ExecuteNonQuery()
            End If
            If RadReferAndComeBySelf.Checked = True Then
                sqlComm.CommandText = InsertReferralBook(SCREENING_BOOKID, PatientNo.Text, "", "", "", False, "", DateRegis.Value.Date)
                sqlComm.ExecuteNonQuery()
            End If
            '============ End function referral ===========================
            '================= Start function Refraction ==================
            If ChRefraction.Checked = True Then
                sqlComm.CommandText = InsertRefraction(SCREENING_BOOKID, DateRegis.Value.Date, PatientNo.Text, "", "", "", "", "", "", "", "", "", False)
                sqlComm.ExecuteNonQuery()
            End If

            '================= End function Refraction ====================
            '=========== Start Function Opticalshop ========================
            If ChOpticalshop.Checked = True Then
                sqlComm.CommandText = InsertOptShopBook(SCREENING_BOOKID, DateRegis.Value.Date, PatientNo.Text, "", False)
                sqlComm.ExecuteNonQuery()
            End If
            '=========== End Function Opticalshop ==========================
            '=========== Save Patient Referral Detail ======================

            'For i As Int16 = 0 To ChListReferral.Items.Count - 1
            '    If ChListReferral.GetItemChecked(i) = True Then
            '        sqlComm.CommandText = SQLSavePatientReferral(TxtPatientNo.Text, ChListReferral.Items(i))
            '        sqlComm.ExecuteNonQuery()
            '    End If
            'Next

            '' =========== Save New Patient Receipt =========================
            'If Free = False Then
            '    sqlComm.CommandText = SqlNewPatientReceipt()
            '    sqlComm.ExecuteNonQuery()
            'End If

            ' =========== Save patient into patient followup ==================
            'sqlComm.CommandText = SqlRegistrationFormForReferal()
            'sqlComm.ExecuteNonQuery()
            ' =========== Save Patient into Book New Patient         ==================
            'sqlComm.CommandText = SqlNewPatientBook()
            'sqlComm.ExecuteNonQuery()
            'If CheckMoPoGo() = True Then
            '    'Dim FMoPoCode As New FEnterMoPoTsyoCode
            '    'If FMoPoCode.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            '    sqlComm.CommandText = SavePatientMoPoTyso(TxtPatientNo.Text, FormatDateTime(DateRegistration.Value, DateFormat.ShortDate))
            '    sqlComm.ExecuteNonQuery()
            '    'Else
            '    '    Exit Function

            'End If
            ' =========== End Transaction Patient Registration Form ==============
            Transaction.Commit()
            Transaction.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Transaction.Rollback()
            'EnableFormControl()
            Return False
        Finally
            Con.Close()
            Con.Dispose()
        End Try
    End Function
    ' Registration New Pateint 
    Function SqlPatientInformation() As String
        Return StringPatientInformation(PatientNo.Text, DateRegis.Value.Date, CboProNo.Text, _
                                        CboDisNo.Text, CboCommNo.Text, TxtPatientName.Text, _
                                        TxtPatientNameKh.Text, TxtAge.Text, CboSex.Text, _
                                        TxtFullAddress.Text, "", TxtTel.Text, "", _
                                        GetDateServer.Date.Year, ModGlobleVariable.ACHIEVE, False, GetTextReferralV1, Format(GetDateServer, "hh:mm:ss tt").ToString)
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
        Commune.Replace("'", "''") & "',N'" & _
        NameEng.Replace("'", "''") & "',N'" & _
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
    '==================================== Screening Book =========================================
    Private Function ScreeningBook() As String
        Return InsertScreenBook(DateRegis.Value.Date, TxtHealthNameCenter.Text, LblSettingID.Text, PatientNo.Text, ChRefraction.Checked, ChOpticalshop.Checked, RadReferAndPickup.Checked, RadReferAndComeBySelf.Checked, TxtRegisterNote.Text, EmptyString(TxtReferencePatientNote.Text), ChHearing.Checked, ChUnderstanding.Checked, ChPhysicalDisability.Checked, ChSeeing.Checked, ChIsOld.Checked)
    End Function
    Private Function InsertScreenBook(ByVal SCREAN_DATE As DateTime, ByVal SCREEN_PLACE As String, ByVal SCREEN_ID As Integer, ByVal PATIENT_NO As Double, ByVal IS_REFRACTION As Boolean, ByVal IS_OPTICALSHOP As Boolean, ByVal IS_REFER_PICKUP As Boolean, ByVal IS_REFER_BYSELF As Boolean, ByVal SCREEN_NOTE As String, ByVal REFERENCE_PATIENNOTE As String, ByVal IS_HEARING As Boolean, ByVal IS_UNDERSTANDING As Boolean, ByVal IS_PHYSICAL As Boolean, ByVal IS_SEEING As Boolean, ByVal IS_OLDPATIENT As Boolean) As String
        Dim sql As String = "INSERT INTO SCREENING_BOOK (SCREAN_DATE,SCREEN_PLACE,SYS_SETTING,PATIENT_NO,IS_REFRACTION,IS_OPTICALSHOP,IS_REFER_PICKUP,IS_REFER_BYSELF,SCREEN_NOTE,REFERENCE_PATIENNOTE,IS_HEARING,IS_UNDERSTANDING,IS_PHYSICAL,IS_SEEING,IS_OLDPATIENT) VALUES('" & SCREAN_DATE & "',N'" & SCREEN_PLACE & "'," & SCREEN_ID & "," & PATIENT_NO & ",'" & IS_REFRACTION & "','" & IS_OPTICALSHOP & "','" & IS_REFER_PICKUP & "','" & IS_REFER_BYSELF & "',N'" & SCREEN_NOTE & "','" & REFERENCE_PATIENNOTE & "','" & IS_HEARING & "','" & IS_UNDERSTANDING & "','" & IS_PHYSICAL & "','" & IS_SEEING & "','" & IS_OLDPATIENT & "')"
        Return sql
    End Function
    Private Function GetLastScreeningBookID() As String
        Dim sql As String = "SELECT TOP 1 SCREEN_BOOKID FROM SCREENING_BOOK ORDER BY screen_bookid desc"
        Return sql
    End Function
    '==================================== End Screening Book End =========================================

    Private Function InsertReferralBook(ByVal SCREENING_BOOKID As Integer, ByVal PATIENT_NO As Double, ByVal VA_RIGHT As String, ByVal VA_LEFT As String, ByVal DIAGNOSIS As String, ByVal STATUS_PICKUP As Boolean, ByVal REFERRAL_NOTE As String, ByVal CREATE_DATE As Date) As String
        Dim sql As String = "INSERT INTO SCREENING_REFERRAL_BOOK(SCREENING_BOOKID,PATIENT_NO,VA_RIGHT,VA_LEFT,DIAGNOSIS,STATUS_PICKUP,REFERRAL_NOTE,CREATE_DATE) VALUES(" & SCREENING_BOOKID & "," & PATIENT_NO & ",'" & VA_RIGHT & "','" & VA_LEFT & "','" & DIAGNOSIS & "','" & STATUS_PICKUP & "','" & REFERRAL_NOTE & "','" & CREATE_DATE & "')"
        Return sql
    End Function

    Private Function InsertRefraction(ByVal SCREEN_BOOK_ID As Double, ByVal REFRACT_DATE As Date, ByVal PATIENT_NO As Double, ByVal VA_RIGHT As String, ByVal VA_LEFT As String, ByVal DIAGNOSIS As String, ByVal RE_PLUS As String, ByVal RE_VA As String, ByVal LE_PLUS As String, ByVal LE_VA As String, ByVal REFRACT_ADD As String, ByVal REFRACT_NOTE As String, ByVal SIGNATURE As Boolean) As String
        Dim SQL As String = "INSERT INTO SCREENING_REFRACTION_BOOK (SCREEN_BOOK_ID,REFRACT_DATE,PATIENT_NO,VA_RIGHT,VA_LEFT,DIAGNOSIS,RE_PLUS,RE_VA,LE_PLUS,LE_VA,REFRACT_ADD,SIGNATURE,REFRACT_NOTE) VALUES(" & SCREEN_BOOK_ID & ",'" & REFRACT_DATE & "'," & PATIENT_NO & ",'" & VA_RIGHT & "','" & VA_LEFT & "','" & DIAGNOSIS & "','" & RE_PLUS & "','" & RE_VA & "','" & LE_PLUS & "','" & LE_VA & "','" & REFRACT_ADD & "','" & REFRACT_NOTE & "','" & SIGNATURE & "')"
        Return SQL
    End Function

    Private Function InsertOptShopBook(ByVal SCREENBOOK_ID As Double, ByVal DATE_SCREENING As Date, ByVal PATIENT_NO As Double, ByVal OPTICALSHOP_NOTE As String, ByVal STATUS_PAY As Boolean) As String
        Dim SQL As String = "INSERT INTO SCREENING_OPTICALSHOP_BOOK (SCREENBOOK_ID,DATE_SCREENING,PATIENT_NO,OPTICALSHOP_NOTE,STATUS_PAY) VALUES(" & SCREENBOOK_ID & ",'" & DATE_SCREENING & "'," & PATIENT_NO & ",'" & OPTICALSHOP_NOTE & "','" & STATUS_PAY & "')"
        Return SQL
    End Function

    Private Sub CboDisNo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDisNo.DropDown
        If ValidateCombobox(CboProNo, "", ErrSaveRegis) = False Then Exit Sub
        With CboDisNo
            .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
            .DisplayMember = "DISTRICT"
            .ValueMember = "SrokCode"
        End With
    End Sub

    Private Sub CboCommNo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.DropDown
        If ValidateCombobox(CboDisNo, "", ErrSaveRegis) = False Then Exit Sub
        With CboCommNo
            .DataSource = ModProvince.SelectCommune(CInt(CboDisNo.SelectedValue))
            .DisplayMember = "Commune"
            .ValueMember = "KhumCode"
        End With
    End Sub

    Private Sub CboProNo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProNo.DropDown
        CboDisNo.Text = ""
        CboCommNo.Text = ""
        TxtFullAddress.Text = ""
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(DateRegis, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(PatientNo, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(TxtHealthNameCenter, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(TxtPatientName, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateCombobox(CboSex, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(TxtAge, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(TxtTel, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateCombobox(CboProNo, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateCombobox(CboDisNo, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateCombobox(CboCommNo, "", ErrSaveRegis) = False Then Exit Sub
        'If ValidateTextField(TxtFullAddress, "", ErrSaveRegis) = False Then Exit Sub
        If MessageBox.Show("Do you want to save patient registration.", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            ' Function save new pateint register and screening book

            If SaveProcessForNewPatient() = True Then
                MessageBox.Show("Patient registration successful!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
               
                'If IS_ONSCRENNING = True Then
                '    Me.DashScreeningRegis.RefreshAfterScreenRegis(DateRegis.Value.Date, DateRegis.Value.Date, PatientNo.Text)
                'End If
                If ChPrintRegistration.Checked = True Then
                    MainFormApplicationPublic.StatusLoading(True, "Loading")
                    BgLoadingform.RunWorkerAsync()
                Else
                    ResetFormRegister()
                End If

            Else
                MessageBox.Show("Error Patient registration. Please verify data entry again!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub

    Private Sub ResetFormRegister()
        LoadNewPatientNo()
        TxtPatientName.Focus()
        TxtPatientName.Select()
        TxtPatientName.SelectAll()
        TxtPatientName.Text = ""
        TxtPatientNameKh.Text = ""
        CboSex.SelectedIndex = -1
        TxtAge.Text = ""
        TxtTel.Text = ""
        'TxtFullAddress.Text = ""
        ChHearing.Checked = False
        ChUnderstanding.Checked = False
        ChPhysicalDisability.Checked = False
        ChSeeing.Checked = False
        ChIsOld.Checked = False
        ChReferral.Checked = False
        RadReferAndPickup.Checked = False
        RadReferAndComeBySelf.Checked = False
        ChRefraction.Checked = False
        ChOpticalshop.Checked = False
        TxtRegisterNote.Text = ""
        TxtReferencePatientNote.Text = ""
        LoadDefaultAddressSetting()
    End Sub

    Private Sub TxtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAge.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboCommNo_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.DropDownClosed
        Try
            TxtFullAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChReferral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChReferral.CheckedChanged
        GBReferral.Enabled = ChReferral.Checked
        If ChReferral.Checked = False Then
            RadReferAndComeBySelf.Checked = False
            RadReferAndPickup.Checked = False
        End If
    End Sub

    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ' Call when we mouse move on Panel
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub TxtReferencePatientNote_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReferencePatientNote.KeyPress
        SetDisableKeyString(e)
    End Sub



    Private Sub BgLoading_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingform.DoWork
        RefreshData()
    End Sub
    Dim DABookScreening As New DataSetScreeningBookTableAdapters.SCREENING_BOOK_VIEWTableAdapter
    Private Sub RefreshData()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf RefreshData))
        Else
            ' If ValReport = 1 Then

            Dim WReport As New ViewMedicalCertificat

            Dim screenForm As New ScreeningPatientForm
            Dim TPatient As DataTable = DABookScreening.SelectByPatientNo(PatientNo.Text)
            screenForm.SetDataSource(TPatient)

            ' RMedicalCertificate.PrintToPrinter(1, False, 1, 1)



            'Dim CrExportOptionsBig As ExportOptions
            'Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
            'CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\PatientCertificate.pdf"
            'CrExportOptionsBig = screenForm.ExportOptions
            'With CrExportOptionsBig
            '    .ExportDestinationType = ExportDestinationType.DiskFile
            '    .ExportFormatType = ExportFormatType.PortableDocFormat
            '    .DestinationOptions = CrDiskFileDestinationOptionsBig
            '    .FormatOptions = CrFormatTypeOptionsBig
            'End With

            'screenForm.Export()
            WReport.CrystalReportViewer1.ReportSource = screenForm '.src = My.Application.Info.DirectoryPath & "\PatientCertificate.pdf"

            WReport.ShowDialog()


          

        End If

    End Sub

    Private Sub BgLoadingform_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingform.RunWorkerCompleted
        MainFormApplicationPublic.StatusLoading(False, "Loading")
        ResetFormRegister()
    End Sub
End Class