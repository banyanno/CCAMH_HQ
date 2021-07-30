Public Class UIScreening
    'Dim MScreening As MainScreening
    Dim Login As frmLoginInventory


    Public Department As UCDepartment
    Public LabourFac As UCLabourFactory
    Public Chemical As UCChemical
    Public UContainer As UCContainer
    Public UItemUnit As UCItemUnit
    Public UVendor As UCVendor
    Public UCate As UCCategories
    Public UFixAsset As UFixInventory
    Public UCabinet As UCCabinet
    Public UNewReceipt As MainOpticalShop

    Public UIncomeStatementOpticalShop As UCOpticalshopIncomStatement
    Public URequestOrderDep As New UCRequestOrder_V1
    Public UReciepReques As UCReceivedRequest
    Dim UDepToDep As UCDepartReceivedRequest
    Dim UDepartmentCurrenstock As UCDepartCurrentStock

    Dim DashboardWaitingPayment As UCDashboardWaitingPayment
    Dim DashBoardPatientConsult As MainConsuling
    Dim DashBordMedicalCertificate As MainMedicalCertificate
    Dim UVendor_V1 As UCVendor_V1
    Dim UDashboardAdjustStock As UCDashboardAdjustStock
    Dim UPrescriptionList As UCPrescriptionList
    Dim UMedicineOutsideHospital As UCMedicineOutsideHospital
    Dim UAppointment As UCAppointment
    Dim UCaritasRequestOrder As UCCaritasRequestOrder
    Dim UCountry As UCCountry

    Dim UOPStatisticReport As UCOpticalShopStatistic
    ' Dim UDasboardNil As UCDashBoardNil
    Dim UItemExpiredDate As UCItemExpiredDate

    'User Control for Takeo Eye hospital
    'Public UIScreen As New UIScreening
    Public ReceivePayemtn As DashbordReceiveReceipt

    Public examinationForm As UCRegistrationForm
    Public bed As UCBed
    Public newInPatient As UCNewInPatient
    Public CashReceipDashboad As UCDashbordCashReceipt
    Public CashCollection As UCashCollection
    Public WeeklySummary As UWeeklyCashCollection
    Public NewOldPatientBook As UCMainNew_Outpatient

    Public OldOutpatient As UCMainOld_Outpatient
    Public Inpatient As UCMainInpatient
    Public ConsultEachProvince As UCEachProvinceAndDistrict
    Public patientReferal As UCPatientReportUtility
    Public patientAchieve As UCAchievePatient
    Public AccountPayAble As UCMainAcountPayable
    Public patientVA As UCMainVA
    Public patientRefraction As MainRefraction
    Public PatientRefer As CUReferMain
    Public ReportOutPatient As UCOutPatientReport
    Public ReportInpatient As UCInpatientReport
    Public ReportOperation As UCOperationReport
    Public OT_AND_IOLlist As UCOT_AND_IOLList
    Public PostponeOT As New DashbardPostoneCancelOT
    Public Doctor As UCDoctor
    Public Diagnosis As UCDiagnosisAndSurgeries
    Dim UserManagement As UCMainUserManagement
    Public ProvinceAndOccupation As UCProvinceAndOccupation
    Dim URunEOD As UCRunEndOfDay
    Dim UShowAllItemBalacne As UIShowAllItemBalanceInDeppartment
    Dim UInhouseUsedITem As UCInhouseUsedItem
    Dim UBarcode As UIBarcodeGenerator
    Dim UReportItemTransaction As UCReportItemTransaction
    Dim UDrugReport As UIDrugReport
    Dim UDrugAudit As UIDrugAudit
    Dim URefferral As UCRefferralOfTEH


    '==================== New Interface CCAMH -===========================
    Dim DashboardSummary As DashboardCCAMHSummary
    Dim UICCAMHRegis As UIRegDashboard
    Dim UICCAMHCash As DashboardCashRecieve
    Dim PaymentSetting As DashboardCashSetting
    Dim CCAMHWaitingPayment As DashboardWaitingPayment
    Dim AdressSetting As DashboardAdress
    Dim ClientTransport As DashboardTransportation
    Dim DashCCAMHPharmacy As DashboardCCAMHPharmacy
    Dim DashCCHMHSaleMedicine As DashboardMedicineSale
    Dim DashIncomeSummary As DashboardCCAHMIncomeSummary
    Dim DashDrugPrice As DashboardSettingMedicincePrice
    Dim DashClientManagement As DashboardClientManagment

    Dim DashReportClient As DashboardCCAMHClientReports
    Dim UIChiefDash As UIChiefDashboard
    Dim UIAssessment As UIAssessedClients
    Dim UITherapistAppointment As New DashboardAppointment
    Dim UIDashReferral As New DashboardReferralClient

    Dim UIFastTrackDetail As New UIFastTrackMainDashboard
    Dim UCaseMonitoring As New UICaseMonitoring
    Dim UCaseAudit As New UIDashBoardClientAudit
    Dim UMainTherapy As DashboardMainTherapy
    Dim UMainReferfrom As DashboardRefferFrom

    Sub New(ByVal MScreening As MainAppKTG, ByVal LoginForm As frmLoginInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'Me.MScreening = MScreening
        Me.Login = LoginForm
        InitUserControle()
        ChangeInputLanguageBar()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    'Public PatientPayment As UCPatientPayment
    'Public ScreenDashboard As DashboardScreeningRegisBook
    ' Public ScreenSetting As DashboardSetting
    'Public DashReportUtility As DashboardReportUtility
    Sub InitUserControle()
        Me.Login.UpdateLabelStatus("Checking Permission", True)
        Application.DoEvents()
        ReceivePayemtn = New DashbordReceiveReceipt(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface 1.", True)
        Application.DoEvents()
        '  PatientPayment = New UCPatientPayment(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface 2.", True)
        Application.DoEvents()
        examinationForm = New UCRegistrationForm
        Login.UpdateLabelStatus("Creating user interface 3.", True)
        Application.DoEvents()
        bed = New UCBed
        Login.UpdateLabelStatus("Creating user interface 4.", True)
        Application.DoEvents()
        'newInPatient = New UCNewInPatient(Me.MScreening)
        Login.UpdateLabelStatus("Creating user interface 5.", True)
        Application.DoEvents()
        CashReceipDashboad = New UCDashbordCashReceipt
        Login.UpdateLabelStatus("Creating user interface 6.", True)
        Application.DoEvents()
        CashCollection = New UCashCollection
        Login.UpdateLabelStatus("Creating user interface 7.", True)
        Application.DoEvents()
        WeeklySummary = New UWeeklyCashCollection
        Login.UpdateLabelStatus("Creating user interface 8.", True)
        Application.DoEvents()
        NewOldPatientBook = New UCMainNew_Outpatient(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface 9.", True)
        Application.DoEvents()
        ' OldOutpatient = New UCMainOld_Outpatient(Me)
        Login.UpdateLabelStatus("Creating user interface 10.", True)
        Application.DoEvents()
        Inpatient = New UCMainInpatient
        Login.UpdateLabelStatus("Creating user interface 11.", True)
        Application.DoEvents()
        'ConsultEachProvince = New UCEachProvinceAndDistrict(Me)
        Login.UpdateLabelStatus("Creating user interface 12.", True)
        Application.DoEvents()
        patientReferal = New UCPatientReportUtility()
        Login.UpdateLabelStatus("Creating user interface 13.", True)
        Application.DoEvents()
        patientAchieve = New UCAchievePatient
        Login.UpdateLabelStatus("Creating user interface 14.", True)
        Application.DoEvents()
        patientVA = New UCMainVA
        Login.UpdateLabelStatus("Creating user interface 15.", True)
        Application.DoEvents()
        patientRefraction = New MainRefraction
        Login.UpdateLabelStatus("Creating user interface refraction.", True)
        Application.DoEvents()
        PatientRefer = New CUReferMain
        Login.UpdateLabelStatus("Creating user interface 16.", True)
        Application.DoEvents()
        'ReportOutPatient = New UCOutPatientReport(Me)
        Login.UpdateLabelStatus("Creating user interface 17.", True)
        Application.DoEvents()
        'ReportInpatient = New UCInpatientReport(Me)
        Login.UpdateLabelStatus("Creating user interface 18.", True)
        Application.DoEvents()
        ' ReportOperation = New UCOperationReport(Me)
        Login.UpdateLabelStatus("Creating user interface 19.", True)
        Application.DoEvents()
        OT_AND_IOLlist = New UCOT_AND_IOLList
        Login.UpdateLabelStatus("Creating user interface 20.", True)
        Application.DoEvents()
        Doctor = New UCDoctor
        Login.UpdateLabelStatus("Creating user interface 21.", True)
        Application.DoEvents()
        Diagnosis = New UCDiagnosisAndSurgeries
        Login.UpdateLabelStatus("Creating user interface 22.", True)
        Application.DoEvents()
        UserManagement = New UCMainUserManagement
        Login.UpdateLabelStatus("Creating user interface 23.", True)
        Application.DoEvents()
        ProvinceAndOccupation = New UCProvinceAndOccupation
        Login.UpdateLabelStatus("Creating user interface 24.", True)
        Application.DoEvents()
        URunEOD = New UCRunEndOfDay(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface 25.", True)
        Application.DoEvents()
        UShowAllItemBalacne = New UIShowAllItemBalanceInDeppartment(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface 26.", True)
        Application.DoEvents()
        UInhouseUsedITem = New UCInhouseUsedItem
        Login.UpdateLabelStatus("Creating user interface 27.", True)
        Application.DoEvents()
        UBarcode = New UIBarcodeGenerator
        Login.UpdateLabelStatus("Creating user interface 28.", True)
        Application.DoEvents()
        UReportItemTransaction = New UCReportItemTransaction(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface 29.", True)
        Application.DoEvents()
        UDrugReport = New UIDrugReport
        Login.UpdateLabelStatus("Creating user interface 30.", True)
        UDrugAudit = New UIDrugAudit

        URefferral = New UCRefferralOfTEH

        '=========== Checking user interface
        Department = New UCDepartment
        Login.UpdateLabelStatus("Creating user interface 30.", True)
        Application.DoEvents()
        LabourFac = New UCLabourFactory
        Login.UpdateLabelStatus("Creating user interface 31.", True)
        Application.DoEvents()
        Chemical = New UCChemical
        Login.UpdateLabelStatus("Creating user interface 32.", True)
        Application.DoEvents()
        UContainer = New UCContainer
        Login.UpdateLabelStatus("Creating user interface 33.", True)
        Application.DoEvents()
        UItemUnit = New UCItemUnit
        Login.UpdateLabelStatus("Creating user interface 34.", True)
        Application.DoEvents()
        UVendor = New UCVendor
        Login.UpdateLabelStatus("Creating user interface 35.", True)
        Application.DoEvents()
        UCate = New UCCategories(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Create interface Fix asset", True)
        UFixAsset = New UFixInventory
        Application.DoEvents()
        Login.UpdateLabelStatus("Creating user interface 36.", True)
        Application.DoEvents()
        UCabinet = New UCCabinet
        Login.UpdateLabelStatus("Creating user interface 37.", True)
        Application.DoEvents()
        UNewReceipt = New MainOpticalShop(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface 38.", True)
        Application.DoEvents()

        Login.UpdateLabelStatus("Creating user interface 39.", True)
        Application.DoEvents()
        UIncomeStatementOpticalShop = New UCOpticalshopIncomStatement(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface 40.", True)
        Application.DoEvents()
        UReciepReques = New UCReceivedRequest
        Login.UpdateLabelStatus("Creating user interface 41.", True)
        Application.DoEvents()
        UDepToDep = New UCDepartReceivedRequest
        Login.UpdateLabelStatus("Creating user interface 42.", True)
        Application.DoEvents()
        'UDepartmentCurrenstock = New UCDepartCurrentStock(Me)
        UDepartmentCurrenstock = New UCDepartCurrentStock(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface 43.", True)
        Application.DoEvents()
        Login.UpdateLabelStatus("Creating user interface 44.", True)
        Application.DoEvents()
        DashboardWaitingPayment = New UCDashboardWaitingPayment
        Login.UpdateLabelStatus("Creating user interface 45.", True)
        ' DashBoardPatientConsult = New MainConsuling(Me)
        Application.DoEvents()
        ' DashBordMedicalCertificate = New MainMedicalCertificate(Me)
        UVendor_V1 = New UCVendor_V1
        UDashboardAdjustStock = New UCDashboardAdjustStock
        Login.UpdateLabelStatus("Creating user interface 46.", True)
        Application.DoEvents()
        'UPrescriptionList = New UCPrescriptionList(Me)
        Application.DoEvents()
        UMedicineOutsideHospital = New UCMedicineOutsideHospital
        Login.UpdateLabelStatus("Creating user interface 47.", True)
        Application.DoEvents()
        UAppointment = New UCAppointment()
        Application.DoEvents()
        Login.UpdateLabelStatus("Creating user interface 47", True)
        UCaritasRequestOrder = New UCCaritasRequestOrder
        Login.UpdateLabelStatus("Creating user interface 48.", True)
        Application.DoEvents()
        UCountry = New UCCountry
        Login.UpdateLabelStatus("Creating user interface 49.", True)
        Application.DoEvents()

        Login.UpdateLabelStatus("Creating user interface 50.", True)
        Application.DoEvents()
        UOPStatisticReport = New UCOpticalShopStatistic(MainFormApplicationPublic)
        Login.UpdateLabelStatus("It is done creatint user interface.", True)
        Application.DoEvents()
        'UDasboardNil = New UCDashBoardNil(Me)
        ' AccountPayAble = New UCMainAcountPayable(Me)
        Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()

        UItemExpiredDate = New UCItemExpiredDate(MainFormApplicationPublic)
        Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()
        DEP_EOD = URunEOD


        '=============== Start Screening Interface ======================================
        Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()
        ScreenDashboard = New DashboardScreeningRegisBook

        Login.UpdateLabelStatus("Create user interface.", True)
        Application.DoEvents()
        ScreenSetting = New DashboardSetting
        Login.UpdateLabelStatus("Create User interface.", True)
        Application.DoEvents()
        DashReportUtility = New DashboardReportUtility

        ' =========================== New project for CCAHM =====================================
        Login.UpdateLabelStatus("Create User interface.", True)
        Application.DoEvents()
        DashboardSummary = New DashboardCCAMHSummary
        Login.UpdateLabelStatus("Create User interface.", True)
        Application.DoEvents()
        UICCAMHRegis = New UIRegDashboard

        Login.UpdateLabelStatus("Check CCAMH Cash...", True)
        Application.DoEvents()
        UICCAMHCash = New DashboardCashRecieve
        Login.UpdateLabelStatus("CCAMH Cash setting...", True)
        Application.DoEvents()
        DashCCAMHPharmacy = New DashboardCCAMHPharmacy(MainFormApplicationPublic)
        Login.UpdateLabelStatus("CCAMH Pharmacy ...", True)
        Application.DoEvents()

        DashCCHMHSaleMedicine = New DashboardMedicineSale(MainFormApplicationPublic)
        Login.UpdateLabelStatus("CCAMH Pharmacy ...", True)
        Application.DoEvents()
        DashIncomeSummary = New DashboardCCAHMIncomeSummary(MainFormApplicationPublic)
        Login.UpdateLabelStatus("CCAMH Income sumary ...", True)
        Application.DoEvents()

        DashDrugPrice = New DashboardSettingMedicincePrice(MainFormApplicationPublic)
        Login.UpdateLabelStatus("CCAMH Drug price setting...", True)
        Application.DoEvents()
        PaymentSetting = New DashboardCashSetting
        Login.UpdateLabelStatus("CCAMH Waiting cash receipt...", True)
        Application.DoEvents()
        CCAMHWaitingPayment = New DashboardWaitingPayment(MainFormApplicationPublic)
        Login.UpdateLabelStatus("CCAMH Waiting transportation...", True)
        Application.DoEvents()
        ClientTransport = New DashboardTransportation

        Application.DoEvents()
        Login.UpdateLabelStatus("CCAHM address setting...", True)
        Application.DoEvents()
        AdressSetting = New DashboardAdress

        Application.DoEvents()
        Login.UpdateLabelStatus("CCAHM client management setting...", True)
        Application.DoEvents()
        DashClientManagement = New DashboardClientManagment

        Application.DoEvents()
        Login.UpdateLabelStatus("Loading main therapy...", True)
        Application.DoEvents()
        UMainTherapy = New DashboardMainTherapy

        Application.DoEvents()
        Login.UpdateLabelStatus("Loading main refer from", True)
        Application.DoEvents()
        UMainReferfrom = New DashboardRefferFrom


        Application.DoEvents()

        Login.UpdateLabelStatus("CCAMH client reports...", True)
        Application.DoEvents()
        DashReportClient = New DashboardCCAMHClientReports

        Application.DoEvents()
        Login.UpdateLabelStatus("CCAMH client chief complaint...", True)
        UIChiefDash = New UIChiefDashboard

        Application.DoEvents()
        Login.UpdateLabelStatus("CCAMH client assesment...", True)
        UIAssessment = New UIAssessedClients

        Application.DoEvents()
        Login.UpdateLabelStatus("CCAMH Therapist mgr", True)
        UITherapistAppointment = New DashboardAppointment
        FlushMemory()
        Application.DoEvents()
        Login.UpdateLabelStatus("Start Begining balance Inventory:", True)
        DEP_EOD.RegisterBeginingBalanceItemQTY()

    End Sub



    Public Sub SetVisibleEnvisibleMenu()
        'If MenuVertical.Width = 0 Then
        '    MenuVertical.Width = 242
        '    Me.BtnNavigationBar.Image = Global.KTGSYS.My.Resources.Resources.Switch_On_40px1
        '    'BtnNavigationBar .Image =
        'Else
        '    MenuVertical.Width = 0
        '    Me.BtnNavigationBar.Image = Global.KTGSYS.My.Resources.Resources.Switch_Off_40px
        'End If
    End Sub

    Sub CheckPermistionOnForm()
        'Try
        Dim tblPermistion As DataTable = ModUser.GetMenuPermission(USER_NAME)
       

        ''--- Takeo Eye Operation Permission
        For indexBar = 0 To ButtonBarRegister.Groups.Count - 1
            For indexSubBar = 0 To ButtonBarRegister.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To tblPermistion.Rows.Count - 1
                    Login.UpdateLabelStatus("Checking user permistion...", True)
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If ButtonBarRegister.Groups(indexBar).Items(indexSubBar).Key = tblPermistion.Rows(indexMenu).Item(0) Then
                        ButtonBarRegister.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next


    End Sub
    Private Sub EnablePermision(ByVal PannelMenu As Panel, ByVal TablePermision As DataTable)
        For Each btn As Control In PannelMenu.Controls
            If TypeOf btn Is Button Then
                For Each row As DataRow In TablePermision.Rows
                    If btn.Tag = row("MenuNo") Then
                        btn.Enabled = True
                    End If

                Next
            End If
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'SetVisibleEnvisibleMenu()
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, PatientPayment, "", True)
    End Sub

    Private Sub BtnNavigationBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetVisibleEnvisibleMenu()
    End Sub


    Private Sub BtnPatientRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, PatientPayment, "", True)
    End Sub

    Private Sub BtnNewPatientBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, NewOldPatientBook, "", True)
    End Sub

    Private Sub BtnScreeningBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, ScreenDashboard, "", True)
    End Sub

    Private Sub BtnScreeningSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, ScreenSetting, "", True)
    End Sub

    Private Sub BtnOpticalShop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, UNewReceipt, "", True)
    End Sub

    Private Sub BtnPharmacty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, UDepartmentCurrenstock, "", True)
    End Sub

    Private Sub BtnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, DashReportUtility, "", True)
    End Sub

    Private Sub BtnOpticalShopReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, UOPStatisticReport, "", True)
    End Sub

    Private Sub BtnOpticalIncome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, UIncomeStatementOpticalShop, "", True)
    End Sub

    Private Sub BtnRequestItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, URequestOrderDep, "", True)

    End Sub

    Private Sub BtnItemTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, UReportItemTransaction, "", True)
    End Sub

    Private Sub BtnRefractionBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, patientRefraction, "", True)
    End Sub

    Private Sub BtnUserManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, Department, "", True)
        Department.InitDepartment()
    End Sub

    Private Sub UIScreening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show(My.Application.Info.Version.ToString & " " & My.Application.Info.Copyright)
        MainPanelNavegation.AutoHide = True
        CheckPermistionOnForm()
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashboardSummary, "", True)
        DashboardSummary.InitGeneratChart(Year(Now.Date))

        ' AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UICCAMHRegis, "", True)
    End Sub

    Private Sub BtnEndOfDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GeneralAddControl(uiPanelMainContainer, URunEOD, "Main inventory Run End Of Day.")
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, URunEOD, "", True)
    End Sub

    Private Sub BtnAdjustock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GeneralAddControl(uiPanelMainContainer, UDashboardAdjustStock, "Department items adjust stock.")
        AddUserControl(MainFormApplicationPublic.PanelHeader, MainFormApplicationPublic.PanelDedail, UDashboardAdjustStock, "", True)
    End Sub


    Private Sub BtnDashboardRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UICCAMHRegis, "", True)
    End Sub

    Private Sub BtnCashReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UICCAMHCash, "", True)
    End Sub

    Private Sub BtnPaymentSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, ClientTransport, "", True)
    End Sub

    Private Sub BtnSocialEconomicSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, PaymentSetting, "", True)
    End Sub

    Private Sub BtnCashCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, CCAMHWaitingPayment, "", True)
    End Sub

    Private Sub BtnUserManagement_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, Department, "", True)
    End Sub

    Private Sub BtnAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, AdressSetting, "", True)
    End Sub

    Private Sub BtnItemSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UCate, "", True)
    End Sub

    Private Sub BtnCorrentStockEachDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UShowAllItemBalacne, "", True)
    End Sub

    Private Sub BtnEndOfDay_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, URunEOD, "", True)
    End Sub

    Private Sub BtnItemTransaction_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UReportItemTransaction, "", True)
    End Sub

    Private Sub BtnInhouseUsed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UInhouseUsedITem, "", True)
    End Sub


    Private Sub BtnBarcodeSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UFixAsset, "Fix asset", True)
    End Sub

    Private Sub BtnApproveDepRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UReciepReques, "", True)
    End Sub

    Private Sub BtnMainInventoryRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UCaritasRequestOrder, "", True)
    End Sub

    Private Sub BtnApproveAdjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UDashboardAdjustStock, "", True)
    End Sub

    Private Sub DepartmentRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, URequestOrderDep, "", True)
    End Sub

    Private Sub ViewRequestDeptoDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UDepToDep, "", True)
    End Sub

    Private Sub CurrentStockInDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UDepartmentCurrenstock, "", True)
    End Sub

    Private Sub DepItemTransactionReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UReportItemTransaction, "", True)
    End Sub

    Private Sub BtnIssuePharmacyReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashCCAMHPharmacy, "", True)
        MainPanelNavegation.AutoHide = True
    End Sub

    Private Sub BtnSaleMedicince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashCCHMHSaleMedicine, "Give Medicine", True)
    End Sub

    Private Sub btnIncomeSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashIncomeSummary, "", True)
    End Sub

    Private Sub BtnMedicinePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashDrugPrice, "", True)
    End Sub


    Private Sub BtnClientManagment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashClientManagement, "", True)
    End Sub

    Private Sub BtnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, Diagnosis, "", True)
    End Sub




    Private Sub BtnListItmeExpire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UItemExpiredDate, "", True)
    End Sub

    Private Sub BtnClientReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashReportClient, "", True)
    End Sub

    Private Sub BtnChiefComplaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChiefComplaint.Click
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UIChiefDash, "", True)
    End Sub

    Private Sub BtnAssesmentSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAssesmentSchedule.Click
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UIAssessment, "", True)
    End Sub

    Private Sub BtnVender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UVendor_V1, "Fix asset", True)
    End Sub

    Private Sub PanelPharmacy_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub BtnDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, Doctor, "Doctor", True)
    End Sub


    Private Sub ButtonBar1_GroupClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.GroupEventArgs) Handles ButtonBarRegister.GroupClick
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashboardSummary, "", True)
        DashboardSummary.InitGeneratChart(Year(Now.Date))

    End Sub

    Private Sub BtnTherapist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UITherapistAppointment, "", True)
    End Sub


    Private Sub BtnReferTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UIDashReferral, "", True)
    End Sub

    Private Sub BtnFastTracking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UIFastTrackDetail, "", True)
    End Sub

    Private Sub BtnCaseMonitoring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UCaseMonitoring, "", True)
    End Sub

    Private Sub ButtonBarRegister_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBarRegister.ItemClick
        Select Case e.Item.Key
            ' ========================= Registration menu ==========================
            Case "Register Client"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UICCAMHRegis, "", True)
            Case "Manage Client"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashClientManagement, "", True)
            Case "Appointment"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UITherapistAppointment, "", True)
            Case "Client Reports"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashReportClient, "", True)
            Case "Register Setting"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, Diagnosis, "", True)
            Case "Client Referral To"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UIDashReferral, "", True)
            Case "Fast Track Details"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UIFastTrackDetail, "", True)
            Case "Case Monitoring"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UCaseMonitoring, "", True)
            Case "Client Audit"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UCaseAudit, "", True)
            Case "Main Therapy"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UMainTherapy, "", True)
            Case "Refer From"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UMainReferfrom, "", True)


                '======================= Department menu ==========================
            Case "Department Request"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, URequestOrderDep, "", True)
            Case "View Request Dep To Dep"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UDepToDep, "", True)
            Case "Current Stock In Department"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UDepartmentCurrenstock, "", True)
            Case "Dep Item Transaction Report"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UReportItemTransaction, "", True)

                '====================== Main Inventory Menu =======================

            Case "List of Item"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UCate, "", True)
            Case "Request Item"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UCaritasRequestOrder, "", True)
            Case "List of Expired Item"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UItemExpiredDate, "", True)
            Case "Approve Dep Request"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UReciepReques, "", True)
            Case "Approve Dep Adjust"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UDashboardAdjustStock, "", True)
            Case "End of Day Item"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, URunEOD, "", True)
            Case "Check Current Stock For All Dep"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UShowAllItemBalacne, "", True)
            Case "In House Used"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UInhouseUsedITem, "", True)
            Case "Fix Asset"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UFixAsset, "", True)
            Case "Item Transaction Reports"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UReportItemTransaction, "", True)
            Case "Vender and Donator"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UVendor_V1, "", True)
            Case "Drug Report"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UDrugReport, "", True)
            Case "Drug Audit"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UDrugAudit, "", True)


                '====================== System setting Menu =======================
            Case "User Management System"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, Department, "", True)
            Case "Social Economic setting"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, PaymentSetting, "", True)
            Case "Address Setting"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, AdressSetting, "", True)
            Case "Medicine Price"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashDrugPrice, "", True)


                '====================== Case collection Menu =======================
            Case "Waiting Issue Receipt"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, CCAMHWaitingPayment, "", True)
            Case "Income Summary"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashIncomeSummary, "", True)
            Case "Transportation"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, ClientTransport, "", True)
            Case "List of Client Spacial Serivice"
                '==================== Pharmay Menu =================================
            Case "Prescription"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashCCAMHPharmacy, "", True)
                MainPanelNavegation.AutoHide = True
            Case "Give Medicine"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, DashCCHMHSaleMedicine, "", True)
            Case "Doctor and Therapy"
                AddUserControl(MainFormApplicationPublic.PanelHeader, PanelMainDetail, UITherapistAppointment, "", True)
        End Select
    End Sub

    
End Class
