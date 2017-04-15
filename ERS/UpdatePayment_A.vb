Imports MySql.Data.MySqlClient
Public Class UpdatePayment_A
    Public TotalPaid As Integer

    Private Sub SearchAddpayemt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAddpayemt_btn.Click
        Dim conn As New MySqlConnection ' <---
        ' Me.sn.Text = My.Forms.AdminPanel.TextBox1.Text
        'Me.FormBorderStyle = 0
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM 	student_info WHERE (Student_ID_No ='" & sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                grade.Text = r("GradeLevel").ToString()
                SearchUpdatePayment_A()
            Else
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace.ToString) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub

    Private Sub pre_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pre_btn.Click
        Me.Text = ""
        Me.TopMost = False
        Reciept.TopMost = True

        Dim lastpayment As Integer
        lastpayment = prelim.Text
        total = TotalPaid + lastpayment

        SearchUpdatePayment_A()

        If prelim.Text = "0" Then
            MsgBox("Already paid!")
            pre_btn.Visible = False
            Me.Enabled = False
        End If

        Reciept.Show()
    End Sub
    Private Sub UpdatePayment_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
    Private Sub UpadatePayment_A_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Cashier.Enabled = True
            Screen_Cashier.Show()
            CashierPanel.Show()
        ElseIf a = MsgBoxResult.No Then
            Dim sa As New UpdatePayment_A
            sa.TopMost = True
            sa.Show()
        End If
    End Sub
End Class