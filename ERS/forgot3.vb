Imports MySql.Data.MySqlClient

Public Class forgot3
    Dim cn As New MySqlConnection

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.MainScreen.AdminBtn.Visible = True
        My.Forms.MainScreen.CashierBtn.Visible = True
        My.Forms.MainScreen.RegistrarBtn.Visible = True
        My.Forms.MainScreen.AboutUsBtn.Visible = True
        My.Forms.MainScreen.PictureBox1.Visible = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ans1.Text = ""
        ans2.Text = ""
        Me.Close()
        ForgotC.Show()
    End Sub

    Private Sub forgot3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.Close()

        Me.ne1.Text = My.Forms.ForgotR.ne1.Text
        cn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
        Dim r As MySqlDataReader
        Dim reg As String = "SELECT * FROM registrar_account WHERE (EmployeeID ='" & ne1.Text & "')"
        cn.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
        r = cmd.ExecuteReader()
        If r.Read Then
            sq1.Text = r("SecurityQuestion1").ToString() & "."
            sq2.Text = r("SecurityQuestion2").ToString() & "."
            cn.Close()
        Else
            MsgBox("EmployeeID not Found!")
            ' en.Focus()
            cn.Close()
        End If
        cn.Close()
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 270)
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Forms.MainScreen.AdminBtn.Visible = True
        My.Forms.MainScreen.CashierBtn.Visible = True
        My.Forms.MainScreen.RegistrarBtn.Visible = True
        My.Forms.MainScreen.AboutUsBtn.Visible = True
        My.Forms.MainScreen.PictureBox1.Visible = True
        My.Forms.MainScreen.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ans1.Text = ""
        ans2.Text = ""
        ForgotR.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        forgotRR()
    End Sub
End Class