Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer.RefreshReport()
       
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
   
            My.Forms.MainScreen.AdminBtn.Enabled = True
            My.Forms.MainScreen.CashierBtn.Enabled = True
            My.Forms.MainScreen.RegistrarBtn.Enabled = True
            My.Forms.MainScreen.AboutUsBtn.Enabled = True
            My.Forms.MainScreen.PictureBox1.Enabled = True
            My.Forms.MainScreen.Enabled = True
            My.Forms.MainScreen.Button5.Enabled = True
            Me.Close()
    End Sub
End Class