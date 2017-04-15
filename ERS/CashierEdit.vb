Imports System.IO
Imports System.Drawing.Imaging
Public Class CashierEdit
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vedit()
        PictureBox1.Image = base64toimage(pic)
        pic = ""
    End Sub

    Public Function base64toimage(ByVal base64code As String) As Image
        Dim imagebyte As Byte() = Convert.FromBase64String(base64code)
        Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
        Dim tmpImage As Image = Image.FromStream(ms, True)
        Return tmpImage
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        editC()
    End Sub
    Private Sub CashierEdit_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub CashierEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class