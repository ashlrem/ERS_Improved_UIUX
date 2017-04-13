Public Class DeleteSubj_R

    Private Sub DeleteSubj_R_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            My.Forms.Screen_Registrar.Enabled = True
            Screen_Registrar.Show()
            RegistrarPanel.Show()
        ElseIf a = MsgBoxResult.No Then
            Dim sa As New DeleteSubj_R
            sa.TopLevel = True
            sa.Show()
        End If
    End Sub
    Private Sub DeleteSubj_R_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub DeleteSubj_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSubj_btn.Click
        deleteSubject_R()
    End Sub

    Private Sub SearchSubj_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSubj_btn.Click
        cn.Close()
        SearchSubject_R_Delete_btn()
    End Sub
End Class