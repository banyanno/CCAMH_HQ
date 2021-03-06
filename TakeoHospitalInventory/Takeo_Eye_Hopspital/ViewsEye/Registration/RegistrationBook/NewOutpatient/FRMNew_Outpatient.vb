Public Class FRMNew_Outpatient
    Public isNewClose As Boolean = False
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            With CboDiagnosis
                .DataSource = ModDiagnosis.SelectMainSurgery()
                .ValueMember = "Surgery"
                .SelectedValue = "SID"
                .Text = ""
                .SelectAll()
            End With
            With TxtOther
                .DataSource = ModDoctor.SelectOther
                .ValueMember = "Other"
                .SelectedValue = "No"
                .SelectAll()
            End With
        Catch ex As Exception

        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub ClearForm()
        TxtReceiptNo.Text = ""
        TxtPatientNo.Text = ""
        LblSaveOption.Text = "0"
        TxtPatientName.Text = ""
        TxtAge.Text = ""
        TxtSex.Text = ""
        TxtAddress.Text = ""
        TxtPatientFee.Text = ""
        CboDiagnosis.Text = Nothing
        TxtOther.Text = Nothing
    End Sub
    Private Sub CboCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        isNewClose = False
        Me.Close()
    End Sub

   
    Private Sub CboSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim Riel As Double
        Dim Dolar As Double
        Dim diagnosisTem As String
        ' សំរាប់ Check Dolar or Riel
        If RadioRiel.Checked = True Then
            Riel = EmptyString(TxtPatientFee.Text)
            Dolar = 0
        End If
        If RadioDolar.Checked = True Then
            Dolar = EmptyString(TxtPatientFee.Text)
            Riel = 0
        End If
        If DateFollowUp.Checked = False Then
            MsgBox("Please check date followup.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If CboDiagnosis.Text.Trim <> "" Then
            If ModDiagnosis.CheckNameDiagnosis(CboDiagnosis.Text) = 0 Then
                MsgBox("Daignosis not exist in system. could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Critical, "Error")
                CboDiagnosis.Focus()
                CboDiagnosis.SelectAll()
                Exit Sub
            End If
        End If
        If ValidateLabelField(TxtPatientName, "patient name", ErrNewOutPatient) = False Then
            MsgBox("Could you fill in receiptNo.", MsgBoxStyle.Critical)
            TxtReceiptNo.Focus()
            Exit Sub
        Else
            If LblSaveOption.Text = "0" Then
                If ModNew_Outpatient.CheckPatientOld(TxtPatientNo.Text) = True Then
                    MsgBox("The patient  already exist in New Patient Book.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                ' Check for write existing patient
                If ModNew_Outpatient.CheckReceiptAndPatient(TxtPatientNo.Text, TxtReceiptNo.Text) = True Then
                    MsgBox("The patient  already exist in New Patient Book.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_SAVE = System.Windows.Forms.DialogResult.Yes Then
                    If ModNew_Outpatient.InserNewOutpatient( _
                    EmptyString(TxtReceiptNo.Text), _
                    TxtPatientNo.Text, _
                    CboDiagnosis.Text, _
                    diagnosisTem, _
                    Riel, _
                    Dolar, _
                    ChPrescribed.Checked, _
                    ChDispensed.Checked, _
                    ChHearing.Checked, _
                    ChUnderstand.Checked, _
                    ChSeeing.Checked, _
                    ChPhysical.Checked, _
                    TxtOther.Text, DateFollowUp.Value, ChTypeOther.Checked) = 1 Then
                        MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, SAVE_TITLE)
                        isNewClose = True
                        Me.Close()
                    Else
                        MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, ERROR_TITLE)
                    End If
                End If
            Else
                DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_UPDATE = System.Windows.Forms.DialogResult.Yes Then
                    If ModNew_Outpatient.UpdateNewOutPatient( _
                    LblSaveOption.Text, _
                    TxtReceiptNo.Text, _
                    TxtPatientNo.Text, _
                    CboDiagnosis.Text, _
                    diagnosisTem, _
                    Riel, _
                    Dolar, _
                    ChPrescribed.Checked, _
                    ChDispensed.Checked, _
                    ChHearing.Checked, _
                    ChUnderstand.Checked, _
                    ChSeeing.Checked, _
                    ChPhysical.Checked, _
                    TxtOther.Text, DateFollowUp.Value, ChTypeOther.Checked) = 1 Then
                        MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, SAVE_TITLE)
                        isNewClose = True
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Else
                        MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, ERROR_TITLE)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub FRMNew_Outpatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtReceiptNo.Focus()

    End Sub

    Private Sub TxtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub LblLoadData_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblLoadData.LinkClicked
        LoadNewPatientInfo()
    End Sub
    Sub LoadNewPatientInfo()
        If ModValidation.CheckReceipt(TxtReceiptNo.Text) = False Then
            MsgBox("Invalid receipt new out-patient.", MsgBoxStyle.Critical, "Error")
        Else
            Dim TblReceiptNewpatient As DataTable = ModNew_Outpatient.SelectReceiptNewpatient(TxtReceiptNo.Text)
            Dim DRow As DataRow
            If TblReceiptNewpatient.Rows.Count > 0 Then
                For i As Integer = 0 To TblReceiptNewpatient.Rows.Count - 1
                    DRow = TblReceiptNewpatient.Rows(i)
                    TxtPatientNo.Text = DRow("PatientNo").ToString
                    TxtPatientName.Text = DRow("NameEng").ToString
                    TxtAge.Text = DRow("Age").ToString
                    TxtSex.Text = DRow("Sex").ToString
                    TxtAddress.Text = DRow("Address").ToString
                Next
            Else
                TxtPatientNo.Text = ""
                TxtPatientName.Text = ""
                TxtAge.Text = ""
                TxtSex.Text = ""
                TxtAddress.Text = ""
                TxtPatientFee.Text = ""
            End If

        End If
    End Sub
    Private Sub TxtPatientFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientFee.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub CboDiagnosis_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDiagnosis.SelectedValueChanged
        Try
            ChTypeOther.Checked = ModDiagnosis.SelectDiagnosisTypeOther(CboDiagnosis.Text)
        Catch ex As Exception
        End Try
    End Sub
End Class