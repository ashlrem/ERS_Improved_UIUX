Public Class DeletePayment

    Private Sub SearchAddpayemt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAddpayemt_btn.Click
        SearchDeletePayment_A()
    End Sub

    Private Sub DeletePayment_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePayment_btn.Click
        deletePayment_btn_a()
        midterm.Text = ""
        prelim.Text = ""
    End Sub

    Private Sub DeletePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
    Private Sub DeletePayment_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Cashier.Show()
            CashierPanel.Show()
            DeletePayment_btn.Visible = True
        End If
    End Sub
End Class