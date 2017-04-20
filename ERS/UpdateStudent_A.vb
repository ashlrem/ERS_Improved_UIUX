﻿Imports System.IO
Imports System.Drawing.Imaging
Public Class UpdateStudent_A
    Dim encodeType As ImageFormat = ImageFormat.Jpeg
    Dim decoding As String = String.Empty
    Private Sub SearchStudent_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudent_btn.Click
        Try
            SearchStudent_A_Update_btn()
            If gradeLabel.Text = "Kinder" Then
                glComboBox.Items.Clear()
                glComboBox.Items.Add("Grade 1")
                glComboBox.Items.Add("Grade 2")
                glComboBox.Items.Add("Grade 3")
                glComboBox.Items.Add("Grade 4")
                glComboBox.Items.Add("Grade 5")
                glComboBox.Items.Add("Grade 6")

            ElseIf gradeLabel.Text = "Grade 1" Then
                glComboBox.Items.Clear()
                glComboBox.Items.Add("Grade 2")
                glComboBox.Items.Add("Grade 3")
                glComboBox.Items.Add("Grade 4")
                glComboBox.Items.Add("Grade 5")
                glComboBox.Items.Add("Grade 6")

            ElseIf gradeLabel.Text = "Grade 2" Then
                glComboBox.Items.Clear()
                glComboBox.Items.Add("Grade 3")
                glComboBox.Items.Add("Grade 4")
                glComboBox.Items.Add("Grade 5")
                glComboBox.Items.Add("Grade 6")

            ElseIf gradeLabel.Text = "Grade 3" Then
                glComboBox.Items.Clear()
                glComboBox.Items.Add("Grade 4")
                glComboBox.Items.Add("Grade 5")
                glComboBox.Items.Add("Grade 6")

            ElseIf gradeLabel.Text = "Grade 4" Then
                glComboBox.Items.Clear()
                glComboBox.Items.Add("Grade 5")
                glComboBox.Items.Add("Grade 6")

            ElseIf gradeLabel.Text = "Grade 5" Then
                glComboBox.Items.Clear()
                glComboBox.Items.Add("Grade 6")

            ElseIf gradeLabel.Text = "Grade 6" Then
                glComboBox.Items.Clear()
                glComboBox.Items.Add("Graduate")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Function base64toimage(ByVal base64code As String) As Image
        Dim imagebyte As Byte() = Convert.FromBase64String(base64code)
        Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
        Dim tmpImage As Image = Image.FromStream(ms, True)
        Return tmpImage
    End Function

    Private Sub UpdateButton_a_Student_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton_a_Student.Click
        editstud()
        gradeLabel.Text = "--"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Admin.Enabled = True
            Screen_Admin.Top = True
            AdminPanel.Show()
            Screen_Admin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub UpdateStudent_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

 


    Private Sub con_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles con.KeyPress
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
    Private Sub sn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sn.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class