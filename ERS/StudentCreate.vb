Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class StudentCreate

    Public s As String

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                pic = OpenFileDialog1.FileName
            End If
            PictureBox1.Image = Image.FromFile(pic)
        Catch
            MsgBox("Please select picture.")

            PictureBox1.Image = PictureBox1.ErrorImage
        End Try
    End Sub
    Public Function imagetobase64(ByVal image As Image, ByVal format As ImageFormat) As String
        Using ms As New MemoryStream()
            image.Save(ms, format)
            Dim imageByte As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageByte)
            Return base64String
        End Using
    End Function
    Public Shared Function ag(ByVal DOfB As Object) As String
        If (Month(Date.Today) * 100) + Date.Today.Day >= (Month(DOfB) * 100) + DOfB.Day Then
            Return DateDiff(DateInterval.Year, DOfB, Date.Today)
        Else
            Return DateDiff(DateInterval.Year, DOfB, Date.Today) - 1
        End If
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentCreateEnrollBtn.Click
        StudentNo = ""
        If (cont.Text = "" Or age.Text = "" Or sn.Text = "" Or gen.SelectedItem = "" Or ln.Text = "" Or fn.Text = "" Or mn.Text = "" Or add.Text = "" Or pi.Text = "" Or rel.Text = "" Or citi.Text = "" Or sy.Text = "" Or gl.Text = "" Or mon.Text = "" Or mono.Text = "" Or fon.Text = "" Or fono.Text = "" Or gdn.Text = "" Or rl.Text = "") Then
            MsgBox("Please fill the empty fields!")
        Else
            Dim encodingtypestring As String = String.Empty
            Try
                If PictureBox1.ImageLocation.ToLower.EndsWith(".jpg") Then
                    encodeType = ImageFormat.Jpeg
                    encodingtypestring = "data:image/jpeg:base64,"
                ElseIf PictureBox1.ImageLocation.ToLower.EndsWith(".png") Then
                    encodeType = ImageFormat.Png
                    encodingtypestring = "data:image/png:base64,"
                End If
            Catch
            End Try
            Try
                decoding = encodingtypestring
                pic = encodingtypestring & imagetobase64(PictureBox1.Image, encodeType)


                If CheckBox1.Checked = True Then
                    s = "Yes"
                ElseIf CheckBox1.Checked = False Then
                    s = "No"
                End If

                Dim objConn As New MySqlConnection
                Dim ins As New MySqlCommand
                Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
                objConn.ConnectionString = cn
                objConn.Open()
                Dim b As String = bd.Value.ToString("MM/dd/yyyy")

                sn_check()


                If StudentNo = "" Then

                    If CheckBox2.Checked = True Then
                        NSO2 = ""
                        NSO2 = "YES"
                    ElseIf CheckBox2.Checked = False Then
                        NSO2 = ""
                        NSO2 = "No"
                    End If


                    If CheckBox3.Checked = True Then
                        baptis = ""
                        baptis = "YES"
                    ElseIf CheckBox3.Checked = False Then
                        baptis = ""
                        baptis = "No"
                    End If

                    If CheckBox4.Checked = True Then
                        card = ""
                        card = "YES"
                    ElseIf CheckBox4.Checked = False Then
                        card = ""
                        card = "No"
                    End If

                    If CheckBox5.Checked = True Then
                        goodMoral = ""
                        goodMoral = "YES"
                    ElseIf CheckBox5.Checked = False Then
                        goodMoral = ""
                        goodMoral = "No"
                    End If


                    If CheckBox6.Checked = True Then
                        form137 = ""
                        form137 = "YES"
                    ElseIf CheckBox6.Checked = False Then
                        form137 = ""
                        form137 = "No"
                    End If

                    Try
                        ins.Connection = objConn
                        ins.CommandText = "INSERT INTO student_info VALUES(@Photo, @Student_ID_No, @LastName, @GivenName, @MiddleName, @Birthday, @Birth_Place, @Gender, @Address, @Age, @Citizenship, @Religion, @SchoolYear, @GradeLevel, @Section, @Scholar, @MotherName, @OccupationM, @FatherName, @OccupationF, @Guardian, @Relation, @Contact, @NSO, @Baptismal, @Name_Of_LastSchool, @Address_of_LastSchool, @UploadCard, @UploadForm137, @UploadGoodMoral)"
                        ins.Parameters.AddWithValue("@Photo", pic)
                        ins.Parameters.AddWithValue("@Student_ID_No", sn.Text)
                        ins.Parameters.AddWithValue("@LastName", ln.Text)
                        ins.Parameters.AddWithValue("@GivenName", fn.Text)
                        ins.Parameters.AddWithValue("@MiddleName", mn.Text)
                        ins.Parameters.AddWithValue("@Birthday", b)
                        ins.Parameters.AddWithValue("@Birth_Place", bp.Text)
                        ins.Parameters.AddWithValue("@Gender", gen.SelectedItem.ToString)
                        ins.Parameters.AddWithValue("@Address", add.Text)
                        ins.Parameters.AddWithValue("@Age", age.Text)
                        ins.Parameters.AddWithValue("@Citizenship", citi.Text)
                        ins.Parameters.AddWithValue("@Religion", rel.Text)
                        ins.Parameters.AddWithValue("@SchoolYear", sy.Text)
                        ins.Parameters.AddWithValue("@GradeLevel", gl.SelectedItem.ToString)
                        ins.Parameters.AddWithValue("@Section", sec.SelectedItem.ToString)
                        ins.Parameters.AddWithValue("@Scholar", s)
                        ins.Parameters.AddWithValue("@MotherName", mon.Text)
                        ins.Parameters.AddWithValue("@OccupationM", mono.Text)
                        ins.Parameters.AddWithValue("@FatherName", fon.Text)
                        ins.Parameters.AddWithValue("@OccupationF", fono.Text)
                        ins.Parameters.AddWithValue("@Guardian", gdn.Text)
                        ins.Parameters.AddWithValue("@Relation", rl.Text)
                        ins.Parameters.AddWithValue("@Contact", cont.Text)
                        ins.Parameters.AddWithValue("@NSO", NSO2)
                        ins.Parameters.AddWithValue("@Baptismal", baptis)
                        ins.Parameters.AddWithValue("@Name_Of_LastSchool", nols.Text)
                        ins.Parameters.AddWithValue("@Address_of_LastSchool", addScho.Text)
                        ins.Parameters.AddWithValue("@UploadCard", card)
                        ins.Parameters.AddWithValue("@UploadForm137", form137)
                        ins.Parameters.AddWithValue("@UploadGoodMoral", goodMoral)

                        ins.ExecuteNonQuery()
                        MsgBox("Student Added!!")

                        If CheckBox1.Checked = True Then
                            CheckBox1.Checked = False
                        End If

                        If CheckBox2.Checked = True Then
                            CheckBox2.Checked = False
                        End If

                        If CheckBox3.Checked = True Then
                            CheckBox3.Checked = False
                        End If

                        If CheckBox4.Checked = True Then
                            CheckBox4.Checked = False
                        End If

                        If CheckBox5.Checked = True Then
                            CheckBox5.Checked = False
                        End If

                        If CheckBox6.Checked = True Then
                            CheckBox6.Checked = False
                        End If
                        pic = ""
                        PictureBox1.Image = Nothing
                        AddSubClear()

                        objConn.Close()

                    Catch ex As Exception
                        MessageBox.Show("Student ID already exists!")
                    End Try
                Else
                    MsgBox("Student ID already exist in the Database!")
                End If

            Catch
                MsgBox("Must upload picture.")
            End Try
        End If

    End Sub

    Private Sub bd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bd.ValueChanged
        age.Text = ag(bd.Value)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentCreateBackBtn.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            If My.Forms.AdminPanel.Enabled = True Then
                Screen_Registrar.Enabled = True
                RegistrarPanel.Show()
                Screen_Registrar.Show()
                Me.Close()
            ElseIf My.Forms.RegistrarPanel.Enabled = True Then
                Screen_Admin.Enabled = True
                AdminPanel.Show()
                Screen_Admin.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Transferee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transferee.CheckedChanged
        If (Transferee.Checked = True) Then
            nols.Enabled = True
            CheckBox3.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            addScho.Enabled = True
        ElseIf (Transferee.Checked = False) Then
            nols.Enabled = False
            CheckBox3.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            addScho.Enabled = True
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Webcam.Show()
        Me.Enabled = False
    End Sub
    Private Sub gl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gl.SelectedIndexChanged
        cn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
        Dim r As MySqlDataReader
        Dim reg As String = "SELECT Section FROM subject_tbl where Grade_Level = '" & gl.SelectedItem.ToString & "'"
        cn.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
        r = cmd.ExecuteReader()
        If r.Read Then
            sec.Items.Clear()
            sec.Items.Add(r("Section").ToString())
            While (r.Read())
                sec.Items.Add(r("Section").ToString())
            End While
        Else
            MessageBox.Show("No Section Found")
        End If

        cn.Close()
    End Sub

    Private Sub StudentCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height) + 380
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)

    End Sub


    Private Sub sn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sn.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub sn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sn.TextChanged
        If sn.Text = "" Then
            Label24.Text = " -"
        Else

            insert()
            Dim reg As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & sn.Text & "')"
            cn1.Open() 'open database connection ulit para maka connect tayo sa databae.

            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn1)
            r = cmd.ExecuteReader() 'execute sql query
            Try
                If r.Read Then
                    ToolTip1.SetToolTip(sn, "Student Number is not Available!")
                    Label24.ForeColor = Color.Red
                    Label24.Text = "Student Number is not Available!"
                    cn1.Close()
                Else
                    Label24.Text = "Student Number is Available!"
                    ToolTip1.SetToolTip(sn, "Student Number is Available!")
                    Label24.ForeColor = Color.Green
                    cn1.Close()
                End If
            Catch ex As Exception
            End Try
            cn1.Close()
        End If
    End Sub

    Private Sub cont_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cont.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class