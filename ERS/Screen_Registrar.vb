Public Class Screen_Registrar


    Private Sub UpdateAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateRegistrarR.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(UpdateRegistrarR)
        RegistrarPanel.Hide()
        UpdateRegistrarR.Show()
    End Sub
    Private Sub UpdateSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateSubjectToolStripMenuItem.Click
        UpdateClass_R.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(UpdateClass_R)
        RegistrarPanel.Hide()
        UpdateClass_R.Show()
    End Sub

    Private Sub DeleteSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSubjectToolStripMenuItem.Click
        'DeleteSubj_R.TopLevel = False
        'RegistrarPanelPictureBox.Controls.Add(DeleteSubj_R)
        'RegistrarPanel.Hide()
        DeleteSubj_R.TopMost = True
        Me.Enabled = False
        DeleteSubj_R.Show()
    End Sub

    Private Sub UpdateStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStudentRecordToolStripMenuItem.Click
        'UpdateStudent_R.TopLevel = False
        'RegistrarPanelPictureBox.Controls.Add(UpdateStudent_R)
        'RegistrarPanel.Hide()
        UpdateStudent_R.TopMost = True
        Me.Enabled = False
        UpdateStudent_R.Show()
    End Sub

    Private Sub DeleteStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteStudentRecordToolStripMenuItem.Click

        'RegistrarPanelPictureBox.Controls.Add(DeleteStudent_R)
        'RegistrarPanel.Hide()
        DeleteStudent_R.TopMost = True
        Me.Enabled = False
        DeleteStudent_R.Show()
    End Sub

    Private Sub SearchStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudentToolStripMenuItem.Click
        'ViewStudent_R.TopLevel = False
        'RegistrarPanelPictureBox.Controls.Add(ViewStudent_R)
        'RegistrarPanel.Hide()
        ViewStudent_R.TopMost = True
        Me.Enabled = False
        ViewStudent_R.Show()
    End Sub

    Private Sub SubjectToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem1.Click
        'ViewClassR.TopLevel = False
        'RegistrarPanelPictureBox.Controls.Add(ViewClassR)
        'RegistrarPanel.Hide()
        ViewClass.TopMost = True
        Me.Enabled = False
        ViewClassR.Show()
    End Sub

    Private Sub AddStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentRecordToolStripMenuItem.Click

        'StudentCreate.TopLevel = False
        'RegistrarPanelPictureBox.Controls.Add(StudentCreate)
        'RegistrarPanel.Hide()
        StudentCreate.TopMost = True
        Me.Enabled = False
        StudentCreate.Show()
    End Sub

    Private Sub ViewStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentRecordToolStripMenuItem.Click
        'ViewStudent_R.TopLevel = False
        'RegistrarPanelPictureBox.Controls.Add(ViewStudent_R)
        'RegistrarPanel.Hide()
        ViewStudent_R.TopMost = True
        Me.Enabled = False
        ViewStudent_R.Show()
    End Sub

    Private Sub ViewSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSubjectToolStripMenuItem.Click
        'ViewClassR.TopLevel = False
        'RegistrarPanelPictureBox.Controls.Add(ViewClassR)
        'RegistrarPanel.Hide()
        ViewClass.TopMost = True
        Me.Enabled = False
        ViewClassR.Show()
    End Sub

    Private Sub AddSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubjectToolStripMenuItem.Click
        AddClassR.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(AddClassR)
        RegistrarPanel.Hide()
        AddClassR.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            My.Application.OpenForms.Cast(Of Form)() _
         .Except({My.Forms.MainScreen}) _
           .ToList() _
       .ForEach(Sub(form) form.Close())
            My.Forms.MainScreen.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            close1()
        End If
    End Sub

    Private Sub Screen_Registrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(1, 1)
        Me.Size = SystemInformation.PrimaryMonitorSize()
    End Sub

    Private Sub ViewEnrolledStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEnrolledStudentsToolStripMenuItem.Click
        'SearchStudent_R.TopLevel = False
        'RegistrarPanelPictureBox.Controls.Add(SearchStudent_R)
        'RegistrarPanel.Hide()
        SearchStudent_R.TopMost = True
        Me.Enabled = False
        SearchStudent_R.Show()
    End Sub
End Class