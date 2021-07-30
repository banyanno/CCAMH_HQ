Public Class MainAppKTG
    Dim Login As frmLoginInventory
    'Dim DA_DefaultSetting As New DataSetSceenSettingTableAdapters.SCREEN_SYSTEMSETTINGTableAdapter
    Private Delegate Sub DelShowLoadingPicture(ByVal visible As Boolean, ByVal TextLable As String)
    Private Delegate Sub DelShowLabel(ByVal TextLable As String)
    Public examinationForm As New UCRegistrationForm
    Dim UIMainMenu As UIScreening
    Sub New(ByVal login As frmLoginInventory)
        ' This call is required by the Windows Form Designer.
        Me.Login = login
        ModGlobleVariable.FLogin = login
        InitializeComponent()
        ModGlobleVariable.MainFormApplicationPublic = Me


        ' InitUserControle()
        Application.DoEvents()
        UIMainMenu = New UIScreening(Me, Me.Login)
        'CheckPermistionOnForm()
        ' Add any initialization after the InitializeComponent() call.
        'LoadDefaultAddressSetting()
        AddUserControl(PanelHeader, PanelDedail, UIMainMenu, "", True)
        LabelDepartment.Text = "User Name " & USER_NAME & " IN DEPT :" & DEPART_NAME
    End Sub

    Sub CreateRegisForm()
        AddUserControl(PanelHeader, PanelDedail, examinationForm, "", True)
    End Sub

    Private Sub MainScreening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBtnSwitchUser.Text = "Log out user: " & UserGlobleVariable.USER_NAME.ToUpper
        BtnDateTimeServer.Text = "Server Date: " & Format(ModGlobleVariable.GeteDateServer, "dd-MM-yyyy") '& " Version:20151108"
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub


    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        If MessageBox.Show("Do you want to exit this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(PanelHeader, PanelDedail, UIMainMenu, "", True)
    End Sub
    Public Sub StatusLoading(ByVal v As Boolean, ByVal TextLabel As String)
        If Me.Created Then
            RibboStatusBar.Invoke(New DelShowLoadingPicture(AddressOf UpdateVisibleLoading), New Object() {v, TextLabel})
        End If
    End Sub
    Public Sub StatusUpdateLabel(ByVal TextLabel As String)
        If Me.Created Then
            RibboStatusBar.Invoke(New DelShowLabel(AddressOf UpdateLabelLoading), New Object() {TextLabel})
        End If
    End Sub
    Private Sub UpdateVisibleLoading(ByVal v As Boolean, ByVal TextLabel As String)

        ContainerPicloading.Visible = v
        ContainerPicloading.Text = TextLabel
    End Sub
    Private Sub UpdateLabelLoading(ByVal TextLabel As String)
        ContainerPicloading.Text = TextLabel
    End Sub


    Private Sub DBtnSwitchUser_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DBtnSwitchUser.Click
        CreateSwitchUser()
    End Sub
    Sub CreateSwitchUser()
        FLogin.txtUserName.Text = ""
        FLogin.txtPassword.Text = ""
        FLogin.txtUserName.Focus()
        FLogin.txtUserName.Select()

        FLogin.Cursor = Cursors.Default
        FLogin.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DBtnChangePassword_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DBtnChangePassword.Click
        CreateChagePasswordForm()
    End Sub
    Sub CreateChagePasswordForm()
        Dim FChangeUserPwd As New FrmChangeUserPWD
        FChangeUserPwd.TxtUserName.Text = USER_NAME
        FChangeUserPwd.LblUserID.Text = USER_ID
        FChangeUserPwd.ShowDialog()
    End Sub

    Private Sub DropDownCommand3_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand3.Click
        CreateLockSystem()
    End Sub
    Sub CreateLockSystem()
        Dim FLockSys As New FRMLockSystem(Me)
        FLockSys.ShowDialog()
    End Sub

    Private Sub PanelHeader_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelHeader.MouseDown
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub ChMenuBar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChMenuBar.CheckedChanged
        If ChMenuBar.Checked = True Then
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Else
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        End If
    End Sub

    'Private Sub MainAppKTG_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    '    Application.Exit()
    'End Sub
End Class