Public Class MainScreen
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = DateTime.Now
        datelbl.Text = DateTimePicker1.Value
    End Sub
    Private Sub MainScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Size = SystemInformation.PrimaryMonitorSize()
        Me.Location = New Point(0, 0)
    End Sub
    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            close1()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsBtn.Click
        'PictureBox1.Visible = False
        'About.TopLevel = False
        'AdminBtn.Visible = False
        'CashierBtn.Visible = False
        'RegistrarBtn.Visible = False
        'AboutUsBtn.Visible = False
        'PictureBox1.Visible = False

        PictureBox1.Enabled = False
        AboutUsBtn.Enabled = False
        AdminBtn.Enabled = False
        CashierBtn.Enabled = False
        RegistrarBtn.Enabled = False
        AboutUsBtn.Enabled = False
        PictureBox1.Enabled = False
        Button5.Enabled = False
        Me.Enabled = False
        ForgotV.Close()
        RegistrarLogin.Close()
        LoginAdmin.Close()
        'Pi.Controls.Add(About)
        About.TopMost = True
        About.Show()

    End Sub
    Private Sub MainScreen_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        close1()
    End Sub

    Private Sub CashierBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashierBtn.Click

        PictureBox1.Visible = False
        AdminBtn.Visible = False
        CashierBtn.Visible = False
        RegistrarBtn.Visible = False
        AboutUsBtn.Visible = False
        PictureBox1.Visible = False
        ForgotV.Close()
        ForgotR.Close()
        ForgotC.Close()
        RegistrarLogin.Close()
        LoginAdmin.Close()
        Me.Enabled = False
        'CashierLogin.TopLevel = False
        'Pi.Controls.Add(CashierLogin)

        CashierLogin.TopMost = True
        CashierLogin.Show()
    End Sub

    Private Sub RegistrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarBtn.Click

        PictureBox1.Visible = False
        AdminBtn.Visible = False
        CashierBtn.Visible = False
        RegistrarBtn.Visible = False
        AboutUsBtn.Visible = False
        ForgotV.Close()
        ForgotR.Close()
        ForgotC.Close()
        Me.Enabled = False
        LoginAdmin.Close()
        CashierLogin.Close()

        'RegistrarLogin.TopLevel = False
        'Pi.Controls.Add(RegistrarLogin)

        RegistrarLogin.TopMost = True
        RegistrarLogin.Show()
    End Sub

    Private Sub AdminBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBtn.Click

        PictureBox1.Visible = False
        AdminBtn.Visible = False
        CashierBtn.Visible = False
        RegistrarBtn.Visible = False
        AboutUsBtn.Visible = False
        ForgotV.Close()
        ForgotR.Close()
        ForgotC.Close()
        RegistrarLogin.Close()
        CashierLogin.Close()
        Me.Enabled = False
        'LoginAdmin.TopLevel = True
        'Pi.Controls.Add(LoginAdmin)
        LoginAdmin.TopMost = True
        LoginAdmin.Show()
    End Sub
End Class