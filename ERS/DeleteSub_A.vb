Public Class DeleteSub_A

    Private Sub SearchSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cn.Close()
        SearchSubject_A_Delete_btn()
    End Sub

    Private Sub DeleteSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSubj_btn.Click
        deleteSubject_A()
    End Sub
    Private Sub DeleteSub_A_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Admin.Enabled = True
            Screen_Admin.Show()
            AdminPanel.Show()
        End If
    End Sub

    Private Sub DeleteSub_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub SearchSubj_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSubj_btn.Click
        SearchSubject_A_Delete_btn()
    End Sub
End Class