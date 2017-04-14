Public Class Screen_Cashier

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            My.Application.OpenForms.Cast(Of Form)() _
         .Except({My.Forms.MainScreen}) _
           .ToList() _
       .ForEach(Sub(form) form.Close())
            My.Forms.MainScreen.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            close1()
        End If
    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateCashierC.TopLevel = False
        CashierPanelPictureBox.Controls.Add(UpdateCashierC)
        CashierPanel.Hide()
        UpdateCashierC.Show()
    End Sub

    Private Sub AddPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPaymentToolStripMenuItem.Click
        AddPayment_A.TopLevel = False
        CashierPanelPictureBox.Controls.Add(AddPayment_A)
        CashierPanel.Hide()
        AddPayment_A.Show()
    End Sub
    Private Sub UpdatePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatePaymentToolStripMenuItem.Click
        UpdatePayment_A.TopLevel = False
        CashierPanelPictureBox.Controls.Add(UpdatePayment_A)
        CashierPanel.Hide()
        UpdatePayment_A.Show()
    End Sub

    Private Sub DeletePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePaymentToolStripMenuItem.Click
        DeletePayment.TopLevel = False
        CashierPanelPictureBox.Controls.Add(DeletePayment)
        CashierPanel.Hide()
        DeletePayment.Show()
    End Sub

    Private Sub ViewStudentPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentPaymentToolStripMenuItem.Click
        DeletePayment.TopLevel = False
        CashierPanelPictureBox.Controls.Add(DeletePayment)
        CashierPanel.Hide()
        DeletePayment.Show()
        My.Forms.DeletePayment.DeletePayment_btn.Visible = False
        My.Forms.DeletePayment.Text = "View Payment"
    End Sub

    Private Sub SearchStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudentToolStripMenuItem.Click
        ViewStud_C.TopLevel = False
        CashierPanelPictureBox.Controls.Add(ViewStud_C)
        CashierPanel.Hide()
        ViewStud_C.Show()
    End Sub

    Private Sub SearchPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchPaymentToolStripMenuItem.Click
        DeletePayment.TopLevel = False
        CashierPanelPictureBox.Controls.Add(DeletePayment)
        CashierPanel.Hide()
        DeletePayment.Show()
        My.Forms.DeletePayment.DeletePayment_btn.Visible = False
        My.Forms.DeletePayment.Text = "View Payment"
    End Sub

    Private Sub Screen_Cashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(1, 1)
        Me.Size = SystemInformation.PrimaryMonitorSize()
    End Sub
End Class