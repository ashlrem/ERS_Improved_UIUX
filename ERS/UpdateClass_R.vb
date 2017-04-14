Public Class UpdateClass_R

    Private Sub SearchSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSubj_btn.Click
        SearchSubject_R_Update_btn()
    End Sub

    Private Sub UpdateSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateSubj_btn.Click
        updateSubjR_btn()
    End Sub
    Private Sub UpdateSub_R_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
         Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Registrar.Show()
            RegistrarPanel.Show()
        End If
    End Sub

    Private Sub UpdateClass_R_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
End Class