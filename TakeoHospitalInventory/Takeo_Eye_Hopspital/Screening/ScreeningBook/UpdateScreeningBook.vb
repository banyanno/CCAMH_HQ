Public Class UpdateScreeningBook
    Dim DADiagnosis As New DataSetScreeningBookTableAdapters.TblSurgeryTableAdapter
    Dim DAVA As New DataSetScreeningBookTableAdapters.REFRACTION_VATableAdapter
    Dim DAScreeningBook As New DataSetScreeningBookTableAdapters.SCREENING_BOOKTableAdapter
    Dim DAReferral As New DataSetScreeningBookTableAdapters.SCREENING_REFERRAL_BOOKTableAdapter
    Dim DARefraction As New DataSetScreeningBookTableAdapters.SCREENING_REFRACTION_BOOKTableAdapter
    Dim DAOpticalShop As New DataSetScreeningBookTableAdapters.SCREENING_OPTICALSHOP_BOOKTableAdapter
    Dim DAAdd As New DSRefractionTableAdapters.REFRACTION_ADDTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        With cboDiagnosis
            .DataSource = DADiagnosis.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgery"
            .SelectedIndex = -1
        End With
       
        RefreshVA()
        RefreshAdd()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub RefreshVA()
        With CboVARight
            .DataSource = DAVA.GetData
            .DisplayMember = "REFRA_VA"
            .ValueMember = "RFRA_VA_ID"
            .SelectedIndex = -1
        End With
        With CboVALeft
            .DataSource = DAVA.GetData
            .DisplayMember = "REFRA_VA"
            .ValueMember = "RFRA_VA_ID"
            .SelectedIndex = -1
        End With
        With CboREPlusVARefract
            .DataSource = DAVA.GetData
            .DisplayMember = "REFRA_VA"
            .ValueMember = "RFRA_VA_ID"
            .SelectedIndex = -1
        End With
        With CboLEPlusVARefrac
            .DataSource = DAVA.GetData
            .DisplayMember = "REFRA_VA"
            .ValueMember = "RFRA_VA_ID"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        ' Call when we mouse move on Panel
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If LblSaveOption.Text <> "0" Then
            If MessageBox.Show("Do you want to update screening book?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If DAScreeningBook.UpdateScreeningBook(DateScreening.Value.Date, ChRefraction.Checked, ChOpticalshop.Checked, RadReferAndPickup.Checked, RadReferAndComeBySelf.Checked, TxtMoreInfo.Text, CboOnEye.Text, TxtComplain.Text, cboDiagnosis.Text, CboVARight.Text, CboVALeft.Text, TxtPlaceScreening.Text, ChHearing.Checked, ChUnderstanding.Checked, ChPhysicalDisability.Checked, ChSeeing.Checked, ChIsOld.Checked, LblSaveOption.Text) = 1 Then
                    ' Check in Referral
                    If ChReferral.Checked = True Then
                        If DAReferral.CheckExistingBookID(LblSaveOption.Text) = 0 Then
                            If RadReferAndComeBySelf.Checked = True Then
                                DAReferral.InsertNewReferral(LblSaveOption.Text, PatientNo.Text, CboVARight.Text, CboVALeft.Text, cboDiagnosis.Text, IIf(DateAppointment.Checked = True, DateAppointment.Value.Date, Nothing), False, TxtReferMoreInfo.Text, DateScreening.Value.Date)
                            End If
                            If RadReferAndPickup.Checked = True Then
                                DAReferral.InsertNewReferral(LblSaveOption.Text, PatientNo.Text, CboVARight.Text, CboVALeft.Text, cboDiagnosis.Text, IIf(DateAppointment.Checked = True, DateAppointment.Value.Date, Nothing), True, TxtReferMoreInfo.Text, DateScreening.Value.Date)
                            End If
                            ' in case update refer
                        Else

                            DAReferral.UpdateReferral(CboVARight.Text, CboVALeft.Text, cboDiagnosis.Text, IIf(DateAppointment.Checked = True, DateAppointment.Value.Date, Nothing), TxtReferMoreInfo.Text, LblSaveOption.Text)

                        End If
                    Else
                        DAReferral.DeleteReferralBookID(LblSaveOption.Text)
                    End If
                    ' Check in Refraction 
                    If ChRefraction.Checked = True Then
                        If DARefraction.CheckExistingRefraction(LblSaveOption.Text) = 0 Then
                            DARefraction.InsertNewRefraction(LblSaveOption.Text, DateScreening.Value.Date, PatientNo.Text, CboVARight.Text, CboVALeft.Text, cboDiagnosis.Text, TxtREPlus.Text, CboREPlusVARefract.Text, TxtLEPlus.Text, CboLEPlusVARefrac.Text, CboAdd.Text, True, TxtRefractNote.Text)
                        Else
                            DARefraction.UpdateRefraction(DateScreening.Value.Date, CboVARight.Text, CboVALeft.Text, cboDiagnosis.Text, TxtREPlus.Text, CboREPlusVARefract.Text, TxtREPlus.Text, CboLEPlusVARefrac.Text, CboAdd.Text, True, TxtRefractNote.Text, LblSaveOption.Text)
                        End If

                    Else
                        DARefraction.DeleteRefraction(LblSaveOption.Text)
                    End If
                    ' Check in Optical shop
                    If ChOpticalshop.Checked = True Then
                        If DAOpticalShop.CheckExistingOpShop(LblSaveOption.Text) = 0 Then
                            DAOpticalShop.InsertNewOpticalShop(LblSaveOption.Text, DateScreening.Value.Date, PatientNo.Text, TxtRefractNote.Text, False)
                        End If
                    Else
                        DAOpticalShop.DeleteOpticalShop(LblSaveOption.Text)
                    End If

                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub ChReferral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChReferral.CheckedChanged
        GBReferral.Enabled = ChReferral.Checked
        If ChReferral.Checked = False Then
            RadReferAndComeBySelf.Checked = False
            RadReferAndPickup.Checked = False
        End If
    End Sub

    Private Sub BtnMoreAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMoreAdd.Click
        Dim NAdd As New NewADDPara
        If NAdd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshAdd()
        End If
    End Sub
    Private Sub RefreshAdd()
        With CboADD
            .DataSource = DAAdd.GetData
            .ValueMember = "ADD_ID"
            .DisplayMember = "ADD_REFRACTION"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub BtnNewVA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewVA.Click
        Dim NewRefVA As New NewRefracVA
        If NewRefVA.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RefreshVA()
        End If
    End Sub

    Private Sub ChRefraction_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChRefraction.CheckedChanged
        GroupRefraction.Enabled = ChRefraction.Checked
    End Sub

 
End Class