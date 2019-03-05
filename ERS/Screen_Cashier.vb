﻿Public Class Screen_Cashier

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

    Private Sub AddPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPaymentToolStripMenuItem.Click
        AddPayment_A.TopMost = True
        Me.Enabled = False
        AddPayment_A.Show()
        AddPayment_A.Text = "Add payment"
    End Sub
    Private Sub UpdatePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatePaymentToolStripMenuItem.Click
        UpdatePayment_A.TopMost = True
        Me.Enabled = False
        UpdatePayment_A.Show()
        UpdatePayment_A.Text = "Update Payment"
    End Sub

    Private Sub DeletePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePaymentToolStripMenuItem.Click
        DeletePayment.TopMost = True
        Me.Enabled = False
        DeletePayment.Show()
    End Sub

    Private Sub ViewStudentPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentPaymentToolStripMenuItem.Click
        DeletePayment.TopMost = False
        Me.Enabled = False
        DeletePayment.Show()
        My.Forms.DeletePayment.DeletePayment_btn.Visible = False
        My.Forms.DeletePayment.Text = "View Payment"
    End Sub

    Private Sub SearchStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudentToolStripMenuItem.Click
        'ViewStud_C.TopLevel = False
        'CashierPanelPictureBox.Controls.Add(ViewStud_C)
        'CashierPanel.Hide()
        Me.Enabled = False
        ViewStud_C.TopMost = True
        ViewStud_C.Show()
    End Sub

    Private Sub SearchPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchPaymentToolStripMenuItem.Click
        'DeletePayment.TopLevel = False
        'CashierPanelPictureBox.Controls.Add(DeletePayment)
        'CashierPanel.Hide()
        DeletePayment.TopMost = True
        Me.Enabled = False
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