﻿Imports System.IO
Imports System.Drawing.Imaging
Public Class UpdateRegistrar
    Dim encodeType As ImageFormat = ImageFormat.Jpeg
    Dim decoding As String = String.Empty
    Private Sub ValidateAccountUpdate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidateAccountUpdate_btn.Click
        vRegistrar_btn()
    End Sub

    Public Function base64toimage(ByVal base64code As String) As Image
        Dim imagebyte As Byte() = Convert.FromBase64String(base64code)
        Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
        Dim tmpImage As Image = Image.FromStream(ms, True)
        Return tmpImage
    End Function

    Private Sub update_account_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_account.Click
        updateAccntRegistrar_btn()
    End Sub
    Private Sub UpdateRegistrar_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Admin.Enabled = True
            Screen_Admin.Show()
            AdminPanel.Show()
        ElseIf a = MsgBoxResult.No Then
            Dim sa As New UpdateRegistrar
            sa.TopMost = True
            sa.Show()
        End If
    End Sub

    Private Sub UpdateRegistrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
        status.SelectedItem = "Active"
    End Sub

    Private Sub cno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub eadd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eadd.TextChanged, cno.TextChanged

    End Sub
End Class