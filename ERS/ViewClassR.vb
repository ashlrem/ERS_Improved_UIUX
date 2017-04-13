Imports MySql.Data.MySqlClient

Public Class ViewClassR

    Private Sub ViewSubjectR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub SearchSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSubj_btn.Click
        cn.Close()
        SearchSubject_R_View_btn()
    End Sub
    Private Sub ViewClassR_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            My.Forms.Screen_Registrar.Enabled = True
            Screen_Registrar.Show()
            RegistrarPanel.Show()
        ElseIf a = MsgBoxResult.No Then
            Dim sa As New ViewClassR
            sa.TopMost = True
            sa.Show()
        End If
    End Sub

    Private Sub subj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subj.SelectedIndexChanged, sec.SelectedIndexChanged

    End Sub
End Class