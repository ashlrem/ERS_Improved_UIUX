Public Class ChangePassC

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        chapassC()
    End Sub

    Private Sub ChangePassC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
        Me.ne1.Text = My.Forms.ForgotC.ne1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            MainScreen.Enabled = True
            My.Forms.MainScreen.Enabled = True
            My.Forms.MainScreen.AdminBtn.Visible = True
            My.Forms.MainScreen.CashierBtn.Visible = True
            My.Forms.MainScreen.RegistrarBtn.Visible = True
            My.Forms.MainScreen.AboutUsBtn.Visible = True
            My.Forms.MainScreen.PictureBox1.Visible = True
            Me.Close()
        End If
    End Sub
End Class