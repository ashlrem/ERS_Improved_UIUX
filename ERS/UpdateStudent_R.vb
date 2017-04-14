Imports System.IO
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
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Registrar.Show()
            RegistrarPanel.Show()
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

    Private Sub nso_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nso_btn.Click
        Try
            If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                NSO2 = OpenFileDialog1.FileName
            End If
        Catch
        End Try
        If NSO2 = "none" Then
            nso_lbl.BackColor = Color.Red
        Else
            nso_lbl.BackColor = Color.Green
        End If
    End Sub

    Private Sub baptismal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baptismal_btn.Click
        Try
            If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                baptis = OpenFileDialog1.FileName
            End If
        Catch
        End Try
        If baptis = "none" Then
            baptismal_lbl.BackColor = Color.Red
        Else
            baptismal_lbl.BackColor = Color.Green
        End If
    End Sub

    Private Sub card_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles card_btn.Click
        Try
            If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                card = OpenFileDialog1.FileName
            End If
        Catch
        End Try
        If card = "none" Then
            card_lbl.BackColor = Color.Red
        Else
            card_lbl.BackColor = Color.Green
        End If
    End Sub

    Private Sub form137_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles form137_btn.Click
        Try
            If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                form137 = OpenFileDialog1.FileName
            End If
        Catch
        End Try
        If form137 = "none" Then
            form_lbl.BackColor = Color.Red
        Else
            form_lbl.BackColor = Color.Green
        End If
    End Sub

    Private Sub goodmoral_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goodmoral_btn.Click
        Try
            If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                goodMoral = OpenFileDialog1.FileName
            End If
        Catch
        End Try
        If goodMoral = "none" Then
            gm_lbl.BackColor = Color.Red
        Else
            gm_lbl.BackColor = Color.Green
        End If
    End Sub

    Private Sub sn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sn.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub sn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sn.TextChanged

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

    Private Sub con_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles con.TextChanged

    End Sub
End Class