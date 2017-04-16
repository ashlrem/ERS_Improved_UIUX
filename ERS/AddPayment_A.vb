﻿Imports MySql.Data.MySqlClient

Public Class AddPayment_A

    Public t As Integer
    Private Sub AddPayment_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 320)
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)


    End Sub

    Private Sub fp_rdobnt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fp_rdobnt.CheckedChanged
        Payment_grp.Text = "Full payment"
        partialp.Text = ""
        Dim t As Integer = total.Text
        Dim totalB As Integer = totalBooks.Text
        total.Text = t
        If getSubj.SelectedItem.ToString = "Grade 1" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 2" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 3" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 4" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 5" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 6" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        End If
        EnterPartial_grp.Enabled = False
        Dim tuition As Integer
        tuition = t / 2
        Proceed_btn.Enabled = True
        prelim.Text = t
        total1.Text = "-"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If fp_rdobnt.Checked = True Then
            pp_rdbnt.Checked = False
            Proceed_btn.Enabled = True

        ElseIf pp_rdbnt.Checked = True Then
            Try
                fp_rdobnt.Checked = False
                Proceed_btn.Enabled = False

                Dim totalmin As Integer = total1.Text
                Dim min As Integer

                min = totalmin / 2

                Dim patial As Integer = partialp.Text

                If min <= patial Then
                    Dim tuition As Integer
                    Dim partialpayment As Integer
                    Dim total2 As Integer

                    tuition = total1.Text
                    partialpayment = partialp.Text

                    total2 = tuition - partialpayment
                    prelim.Text = total2
                    EnterPartial_grp.Enabled = False
                    Proceed_btn.Enabled = True

                Else
                    MsgBox("Partial payment should not be lessthan P " & min)
                End If
            Catch
            End Try

        End If



    End Sub
    Private Sub pp_rdbnt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_rdbnt.CheckedChanged
        EnterPartial_grp.Enabled = True
        Payment_grp.Text = "Partial payment"
        Proceed_btn.Enabled = False
        prelim.Text = "-"
        Dim totalB As Integer = totalBooks.Text
        If getSubj.SelectedItem.ToString = "Grade 1" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 2" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 3" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 4" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 5" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        ElseIf getSubj.SelectedItem.ToString = "Grade 6" Then
            t = total.Text
            t = t + totalB
            total1.Text = t
        End If
    End Sub

    Private Sub SearchAddpayemt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAddpayemt_btn.Click
        Try
            SearchAddPayment1_A()
            If grade.Text = "Grade 1" Then
                getSubj.Items.Clear()
                getSubj.Items.Add("Grade 2")
                getSubj.Items.Add("Grade 3")
                getSubj.Items.Add("Grade 4")
                getSubj.Items.Add("Grade 5")
                getSubj.Items.Add("Grade 6")

            ElseIf grade.Text = "Grade 2" Then
                getSubj.Items.Add("Grade 3")
                getSubj.Items.Add("Grade 4")
                getSubj.Items.Add("Grade 5")
                getSubj.Items.Add("Grade 6")

            ElseIf grade.Text = "Grade 3" Then
                getSubj.Items.Add("Grade 4")
                getSubj.Items.Add("Grade 5")
                getSubj.Items.Add("Grade 6")

            ElseIf grade.Text = "Grade 4" Then
                getSubj.Items.Add("Grade 5")
                getSubj.Items.Add("Grade 6")

            ElseIf grade.Text = "Grade 5" Then
                getSubj.Items.Add("Grade 6")

            End If
            If nameOS.Text = "--------" Then
                nameOS.Text = "--------"
                grade.Text = "--------"

            End If


        Catch ex As Exception
            MsgBox(ex)
        End Try


     
    End Sub


    Private Sub Proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proceed_btn.Click
        If fp_rdobnt.Checked = True Then
            Me.Text = ""
            Me.TopMost = False
            Reciept.TopMost = True
            Reciept.Show()
            'FullPayment_A()
            Subj1.Text = ""
            Subj2.Text = ""
            Subj3.Text = ""
            Subj4.Text = ""
            Subj5.Text = ""
            Subj6.Text = ""
            Subj7.Text = ""
            Subj8.Text = ""
            Subj9.Text = ""
            total.Text = ""
            p1.Text = ""
            p2.Text = ""
            p3.Text = ""
            p4.Text = ""
            p5.Text = ""
            p6.Text = ""
            p7.Text = ""
            p8.Text = ""
            p9.Text = ""
            totalBooks.Text = ""
            EnterPartial_grp.Enabled = False
            Payment_grp.Enabled = False
            fp_rdobnt.Enabled = False
            pp_rdbnt.Enabled = False
            miscellaneous_fee_grp.Enabled = False
            total1.Text = ""
            total.Text = ""
            sn.Enabled = True
            SearchAddpayemt_btn.Enabled = True

            total.Enabled = True
            Me.Enabled = False
        ElseIf pp_rdbnt.Checked = True Then
            Me.Text = ""
            Me.TopMost = False
            Reciept.TopMost = True
            Reciept.Show()
            Proceed_btn.Enabled = False
            'PartialPayment_A()
            Subj1.Text = ""
            Subj2.Text = ""
            Subj3.Text = ""
            Subj4.Text = ""
            Subj5.Text = ""
            Subj6.Text = ""
            Subj7.Text = ""
            Subj8.Text = ""
            Subj9.Text = ""
            total.Text = ""
            p1.Text = ""
            p2.Text = ""
            p3.Text = ""
            p4.Text = ""
            p5.Text = ""
            p6.Text = ""
            p7.Text = ""
            p8.Text = ""
            p9.Text = ""
            totalBooks.Text = ""

            EnterPartial_grp.Enabled = False
            Payment_grp.Enabled = False
            fp_rdobnt.Enabled = False
            pp_rdbnt.Enabled = False
            miscellaneous_fee_grp.Enabled = False
            sn.Enabled = True
            SearchAddpayemt_btn.Enabled = True
            total1.Text = ""
            total.Text = ""

            total.Enabled = True
            Me.Enabled = False
        End If
        nameOS.Text = "---"
        grade.Text = "---"
        Proceed_btn.Enabled = False

    End Sub
    Private Sub AddPayment_A_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Cashier.Enabled = True
            Screen_Cashier.Show()
            CashierPanel.Show()
        ElseIf a = MsgBoxResult.No Then
            Dim sa As New AddPayment_A
            sa.TopMost = True
            sa.Show()
        End If
    End Sub
    Private Sub enterTuition_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterTuition_btn.Click
        If total.Text = "" Then
            MsgBox("Please enter tuitionfee.")
        Else
            Try
                partialp.Text = ""
                t = total.Text
                total.Text = t
                Dim totalB As Integer = totalBooks.Text
                total1.Text = total.Text
                fp_rdobnt.Enabled = True
                pp_rdbnt.Enabled = True
                total.Enabled = False

                If getSubj.SelectedItem.ToString = "Grade 1" Then
                    t = total.Text
                    t = t + totalB
                    total1.Text = t
                ElseIf getSubj.SelectedItem.ToString = "Grade 2" Then
                    t = total.Text
                    t = t + totalB
                    total1.Text = t
                ElseIf getSubj.SelectedItem.ToString = "Grade 3" Then
                    t = total.Text
                    t = t + totalB
                    total1.Text = t
                ElseIf getSubj.SelectedItem.ToString = "Grade 4" Then
                    t = total.Text
                    t = t + totalB
                    total1.Text = t
                ElseIf getSubj.SelectedItem.ToString = "Grade 5" Then
                    t = total.Text
                    t = t + totalB
                    total1.Text = t
                ElseIf getSubj.SelectedItem.ToString = "Grade 6" Then
                    t = total.Text
                    t = t + totalB
                    total1.Text = t
                End If
            Catch
            End Try
        End If

    End Sub

    Private Sub getSubj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getSubj.SelectedIndexChanged
        Subj1.Text = "-"
        Subj2.Text = "-"
        Subj3.Text = "-"
        Subj4.Text = "-"
        Subj5.Text = "-"
        Subj6.Text = "-"
        Subj7.Text = "-"
        Subj8.Text = "-"
        Subj9.Text = "-"
        total.Text = "-"
        p1.Text = "0"
        p2.Text = "0"
        p3.Text = "0"
        p4.Text = "0"
        p5.Text = "0"
        p6.Text = "0"
        p7.Text = "0"
        p8.Text = "0"
        p9.Text = "0"
        totalBooks.Text = ""
        insert()
        Dim reg As String = "SELECT * FROM items_tbl WHERE (gradelevel ='" & getSubj.SelectedItem.ToString & "')"
        cn1.Open() 'open database connection ulit para maka connect tayo sa databae.

        Dim cmd As MySqlCommand = New MySqlCommand(reg, cn1)
        r = cmd.ExecuteReader() 'execute sql query
        Try
            If r.Read = True Then
                Subj1.Text = r("ItemName").ToString
                p1.Text = r("Price").ToString
                If r.Read = True Then
                    Subj2.Text = r("ItemName").ToString
                    p2.Text = r("Price").ToString
                End If
                If r.Read = True Then
                    Subj3.Text = r("ItemName").ToString
                    p3.Text = r("Price").ToString
                End If
                If r.Read = True Then
                    Subj4.Text = r("ItemName").ToString
                    p4.Text = r("Price").ToString
                End If
                If r.Read = True Then
                    Subj5.Text = r("ItemName").ToString
                    p5.Text = r("Price").ToString
                End If
                If r.Read = True Then
                    Subj6.Text = r("ItemName").ToString
                    p6.Text = r("Price").ToString
                End If
                If r.Read = True Then
                    Subj7.Text = r("ItemName").ToString
                    p7.Text = r("Price").ToString
                End If
                If r.Read = True Then
                    Subj8.Text = r("ItemName").ToString
                    p8.Text = r("Price").ToString
                End If
                If r.Read = True Then
                    Subj9.Text = r("ItemName").ToString
                    p9.Text = r("Price").ToString
                End If
            End If
            cn1.Close()
        Catch ex As Exception
        End Try
        cn1.Close()




        Dim total123 As Integer
        Dim il As Integer = IdLace.Text
        Dim pat As Integer = Patch.Text
        Dim s1 As Integer = p1.Text
        Dim s2 As Integer = p2.Text
        Dim s3 As Integer = p3.Text
        Dim s4 As Integer = p4.Text
        Dim s5 As Integer = p5.Text
        Dim s6 As Integer = p6.Text
        Dim s7 As Integer = p7.Text
        Dim s8 As Integer = p8.Text
        Dim s9 As Integer = p9.Text
        total123 = il + pat + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9
        totalBooks.Text = total123

    End Sub
    Private Sub sn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sn.TextChanged
        insert()
        Dim reg As String = "SELECT * FROM payment_tbl WHERE (Student_ID_No ='" & sn.Text & "')"
        cn1.Open() 'open database connection ulit para maka connect tayo sa databae.

        Dim cmd As MySqlCommand = New MySqlCommand(reg, cn1)
        r = cmd.ExecuteReader() 'execute sql query
        Try
            If r.Read Then
                Label24.Text = "P " & r("TotalAmountPaid").ToString & " Amout Paid!"
                cn1.Close()
            Else
                Label24.Text = "Student Number is not added in Cashier!"
                cn1.Close()
            End If
        Catch ex As Exception
        End Try
        cn1.Close()
    End Sub
End Class