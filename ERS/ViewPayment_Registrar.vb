Imports MySql.Data.MySqlClient

Public Class ViewPayment_Registrar

    Private Sub ViewPayment_Registrar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Registrar.Enabled = True
            Screen_Registrar.Show()
            RegistrarPanel.Show()
        ElseIf a = MsgBoxResult.No Then
            Dim sa As New ViewPayment_Registrar
            sa.TopMost = True
            sa.Show()
        End If
    End Sub

    Private Sub ViewPayment_Registrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub SearchAddpayemt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAddpayemt_btn.Click
        Dim conn As New MySqlConnection
        Try
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM payment_tbl WHERE (Student_ID_No ='" & sn.Text & "')"
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn)
            r = cmd.ExecuteReader()
            If r.Read Then
                If r("FirstPayment").ToString() = "0" Then
                    prelim.Text = "PAID"
                Else
                    prelim.Text = r("FirstPayment").ToString()
                End If

                If r("TotalAmountPaid").ToString() = "0" Then
                    midterm.Text = "PAID"
                Else
                    midterm.Text = r("TotalAmountPaid").ToString()
                End If

            Else
                MsgBox("Student Number not Found!")
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace)
        End Try
        conn.Close()
    End Sub
End Class