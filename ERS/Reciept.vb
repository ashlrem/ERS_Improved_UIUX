Imports System.IO
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing
Public Class Reciept
    Private Sub Reciept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Me.Location = New Point(1, 1)
        'Me.Size = SystemInformation.PrimaryMonitorSize()
        dateP.Text = DateTimePicker1.Value.ToString

        nameOS.Text = My.Forms.AddPayment_A.nameOS.Text
        grade.Text = My.Forms.AddPayment_A.grade.Text
        If My.Forms.AddPayment_A.pp_rdbnt.Checked = True Then
            amount.Text = My.Forms.AddPayment_A.partialp.Text
            po.Text = "First payment."
        ElseIf My.Forms.AddPayment_A.fp_rdobnt.Checked = True Then
            amount.Text = My.Forms.AddPayment_A.prelim.Text
            po.Text = "Full Payment."
        End If
        am.Text = amount.Text
        am1.Text = am.Text
        am2.Text = am1.Text

    End Sub
    Private Sub Reciept_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        AddPayment_A.Enabled = True
        UpdatePayment_A.Enabled = True
    End Sub
    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    Public Shared Function BitBlt(ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, _
    ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Long
    End Function
    Private memoryImage As Bitmap
    Private Sub CaptureScreen()
        Dim mygraphics As Graphics = Me.Panel1.CreateGraphics()
        Dim s As Size = Me.Panel1.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc()
        Dim dc2 As IntPtr = memoryGraphics.GetHdc()
        BitBlt(dc2, 0, 0, Me.Panel1.ClientRectangle.Width, Me.Panel1.ClientRectangle.Height, dc1, _
         0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub

    Private Sub print_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print_btn.Click
        CaptureScreen()
        Dim printDialog1 As PrintDialog = New PrintDialog
        printDialog1.Document = PrintDocument1
        Dim result As DialogResult = printDialog1.ShowDialog
        If (result = DialogResult.OK) Then
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
