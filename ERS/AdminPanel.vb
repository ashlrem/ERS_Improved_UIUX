Imports System.IO
Imports System.Drawing.Imaging
Public Class AdminPanel
    Dim encodeType As ImageFormat = ImageFormat.Jpeg
    Dim decoding As String = String.Empty
    Private Sub AdminPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(1, 1)
        Me.Size = SystemInformation.PrimaryMonitorSize()
        Me.empl.Text = My.Forms.LoginAdmin.en.Text
        adminPan()
        PictureBox3.Image = base64toimage(pic)
        pic = ""
    End Sub
    Public Function base64toimage(ByVal base64code As String) As Image
        Dim imagebyte As Byte() = Convert.FromBase64String(base64code)
        Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
        Dim tmpImage As Image = Image.FromStream(ms, True)

        Return tmpImage
    End Function

End Class