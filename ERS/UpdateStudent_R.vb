﻿Imports System.IO
Imports System.Drawing.Imaging
Public Class UpdateStudent_R
    Dim encodeType As ImageFormat = ImageFormat.Jpeg
    Dim decoding As String = String.Empty
    Private Sub SearchStudent_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudent_btn.Click
        SearchStudent_r_Update_btn()
    End Sub

    Public Function base64toimage(ByVal base64code As String) As Image
        Dim imagebyte As Byte() = Convert.FromBase64String(base64code)
        Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
        Dim tmpImage As Image = Image.FromStream(ms, True)
        Return tmpImage
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            My.Forms.Screen_Registrar.Enabled = True
            RegistrarPanel.Show()
            Screen_Registrar.Show()
            Me.Close()
        End If
    End Sub

    Private Sub UpdateButton_a_Student_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton_a_Student.Click
        editstud_R()
    End Sub

    Private Sub UpdateStudent_R_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub sn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sn.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ag_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ag.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ag.TextChanged

    End Sub

    Private Sub con_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles con.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class