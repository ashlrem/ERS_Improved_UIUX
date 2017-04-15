Public Class addBookItem



    Private Sub addBookItem_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Admin.Enabled = True
            Screen_Admin.Show()
            AdminPanel.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If gradelvl.SelectedItem = "" Or price.Text = "" Or itemName.Text = "" Then
            MsgBox("Please enter the empty fields!")
        Else
            addBook()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        price.Text = ""
        gradelvl.SelectedIndex = -1
        itemName.Text = ""
    End Sub

    Private Sub addBookItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height + 60)
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2) - 10
    End Sub

    Private Sub price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles price.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class