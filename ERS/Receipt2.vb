﻿Public Class Receipt2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            UpdatePayment_A.TopMost = True
            UpdatePayment_A.Enabled = True
            UpdatePayment_A.Show()
            Me.TopMost = False
            Me.Close()
        ElseIf a = MsgBoxResult.No Then
        End If
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
    Private Sub print_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print_btn.Click
        CaptureScreen()
        Dim printDialog1 As PrintDialog = New PrintDialog
        printDialog1.Document = PrintDocument1
        Dim result As DialogResult = printDialog1.ShowDialog
        If (result = DialogResult.OK) Then
            prelimPay_btn()
            PrintDocument1.Print()
            Me.TopMost = False
            UpdatePayment_A.Enabled = True
            UpdatePayment_A.TopMost = True
            UpdatePayment_A.Text = "Update Payment"
            UpdatePayment_A.Show()
            Me.Close()
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub
    Private Sub Receipt2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dateP.Text = DateTimePicker1.Value.ToString

        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 320)
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
End Class