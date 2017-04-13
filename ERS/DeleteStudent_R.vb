﻿Imports System.IO
Imports System.Drawing.Imaging
Public Class DeleteStudent_R
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            My.Forms.Screen_Registrar.Enabled = True
            Screen_Registrar.Show()
            RegistrarPanel.Show()
        End If
        Me.Close()
    End Sub

    Private Sub SearchStudent_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudent_btn.Click
        SearchStudent_R_Delete_btn()
    End Sub

    Public Function base64toimage(ByVal base64code As String) As Image
        Dim imagebyte As Byte() = Convert.FromBase64String(base64code)
        Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
        Dim tmpImage As Image = Image.FromStream(ms, True)
        Return tmpImage
    End Function

    Private Sub DeleteButton_a_Student_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton_a_Student.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to delete Student Info?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            dropstudR()
        End If

    End Sub

    Private Sub DeleteStudent_R_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
End Class