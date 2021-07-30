Public Class FindPatient
    Dim DashboarPatient As UCPatientPayment
    Sub New(ByVal DashboarPatient As UCPatientPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DashboarPatient = DashboarPatient
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub CboProNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboProNo.GotFocus
        With CboProNo
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
        End With
        'CboProNo.Text = ""
        CboProNo.Text = ""
        CboCommNo.Text = ""
        'TxtAddress.Text = ""
        Me.CboProNo.SelectAll()
    End Sub
    Private Sub CboDisNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboDisNo.GotFocus
        With CboProNo
            .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
            .DisplayMember = "DISTRICT"
            .ValueMember = "SrokCode"
        End With
        'CboDisNo.Text = ""
        'CboCommNo.Text = ""
        'TxtAddress.Text = ""
        Me.CboProNo.SelectAll()
    End Sub
    Private Sub CboCommNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommNo.GotFocus
        With CboCommNo
            .DataSource = ModProvince.SelectCommune(CInt(CboProNo.SelectedValue))
            .DisplayMember = "Commune"
            .ValueMember = "KhumCode"
        End With
        Me.CboCommNo.SelectAll()
    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Me.DashboarPatient.ActionFindPatien(EmptyString(TxtPatientSearchNo.Text.Trim), EmptyString(TxtOldPatientNo.Text.Trim), DateRFrom.Value, DateRTo.Value, _
            txtEngName.Text.Trim, _
            txtKhmerName.Text.Trim, _
            cboSex.Text.Trim, _
            CboProNo.Text.Trim, _
            CboDisNo.Text.Trim, _
            CboCommNo.Text.Trim)
    End Sub

    Private Sub FindPatient_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        MoveFormOnMouseDown(e)
    End Sub

    Private Sub FindPatient_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        MoveFormOnMouseMove(e, Me)
    End Sub
End Class