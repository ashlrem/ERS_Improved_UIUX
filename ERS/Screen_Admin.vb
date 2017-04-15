Public Class Screen_Admin

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
        'My.Forms.MainScreen.AdminBtn.Visible = True
        'My.Forms.MainScreen.CashierBtn.Visible = True
        'My.Forms.MainScreen.RegistrarBtn.Visible = True
        'My.Forms.MainScreen.AboutUsBtn.Visible = True
        'My.Forms.MainScreen.PictureBox1.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            close1()
        End If
    End Sub

    Private Sub Screen_Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Size = SystemInformation.PrimaryMonitorSize()
        AdminPanelPictureBox.Size = Me.Size
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub AddStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentRecordToolStripMenuItem.Click
        StudentCreate.TopMost = True
        Me.Enabled = False
        'StudentCreate.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(StudentCreate)
        'AdminPanel.Hide()
        StudentCreate.Show()
    End Sub

    Private Sub AddSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubjectToolStripMenuItem.Click
        AddClass.TopMost = True
        Me.Enabled = False
        'AddClass.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(AddClass)
        'AdminPanel.Hide()
        AddClass.Show()
    End Sub

    Private Sub AddAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAdminToolStripMenuItem.Click
        AdminCreate_1.TopMost = True
        'AdminCreate_1.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(AdminCreate_1)
        'AdminPanel.Hide()
        Me.Enabled = False
        AdminCreate_1.Show()
    End Sub

    Private Sub AddRegistrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRegistrarToolStripMenuItem.Click
        RegistrarCreate.TopMost = True
        'RegistrarCreate.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(RegistrarCreate)
        Me.Enabled = False
        'AdminPanel.Hide()
        RegistrarCreate.Show()
    End Sub

    Private Sub AddCashierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCashierToolStripMenuItem.Click
        CashierCreate.TopMost = True
        Me.Enabled = False
        'CashierCreate.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(CashierCreate)
        'AdminPanel.Hide()
        CashierCreate.Show()
    End Sub

    Private Sub DeleteAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAdminToolStripMenuItem.Click
        deleteAdmin.TopMost = True
        Me.Enabled = False
        'deleteAdmin.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(deleteAdmin)
        'AdminPanel.Hide()
        Me.Enabled = False
        deleteAdmin.Show()
    End Sub

    Private Sub DeleteRegistrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRegistrarToolStripMenuItem.Click
        DeleteRegistrar.TopMost = True
        Me.Enabled = False
        'DeleteRegistrar.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(DeleteRegistrar)
        'AdminPanel.Hide()
        DeleteRegistrar.Show()
    End Sub

    Private Sub DeleteCashierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCashierToolStripMenuItem.Click
        DeleteCashier.TopMost = True
        Me.Enabled = False
        'DeleteCashier.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(DeleteCashier)
        'AdminPanel.Hide()
        DeleteCashier.Show()
    End Sub

    Private Sub UpdateStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStudentRecordToolStripMenuItem.Click
        UpdateStudent_A.TopMost = True
        Me.Enabled = False
        'UpdateStudent_A.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(UpdateStudent_A)
        'AdminPanel.Hide()
        UpdateStudent_A.Show()
    End Sub

    Private Sub ViewStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentRecordToolStripMenuItem.Click
        ViewStudent.TopMost = True
        Me.Enabled = False
        'ViewStudent.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(ViewStudent)
        'AdminPanel.Hide()
        ViewStudent.Show()
    End Sub


    Private Sub UpdateSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateSubjectToolStripMenuItem.Click
        UpdateClass_A.TopMost = True
        Me.Enabled = False
        'UpdateClass_A.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(UpdateClass_A)
        'AdminPanel.Hide()
        UpdateClass_A.Show()
    End Sub

    Private Sub DeleteSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSubjectToolStripMenuItem.Click
        DeleteSub_A.TopMost = True
        Me.Enabled = False
        'DeleteSub_A.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(DeleteSub_A)
        'AdminPanel.Hide()
        DeleteSub_A.Show()
    End Sub

    Private Sub DeleteStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteStudentRecordToolStripMenuItem.Click
        DeleteStudent_A.TopMost = True
        Me.Enabled = False
        'DeleteStudent_A.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(DeleteStudent_A)
        'AdminPanel.Hide()
        DeleteStudent_A.Show()
    End Sub

    Private Sub ViewRegistrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRegistrarToolStripMenuItem.Click
        'DeleteRegistrar.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(DeleteRegistrar)
        deleteAdmin.TopMost = True
        Me.Enabled = False
        'AdminPanel.Hide()
        My.Forms.DeleteRegistrar.Button2.Hide()
        My.Forms.DeleteRegistrar.Text = "View Registrar Account"
        DeleteRegistrar.Show()
    End Sub

    Private Sub ViewAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAdminToolStripMenuItem.Click
        'deleteAdmin.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(deleteAdmin)
        deleteAdmin.TopMost = True
        Me.Enabled = False
        'AdminPanel.Hide()
        My.Forms.deleteAdmin.DeleteAccount_btn.Hide()
        My.Forms.deleteAdmin.Text = "View Admin Account"
        deleteAdmin.Show()
    End Sub

    Private Sub SearchAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAdminToolStripMenuItem.Click
        'deleteAdmin.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(deleteAdmin)
        Me.Enabled = False
        'AdminPanel.Hide()
        My.Forms.deleteAdmin.DeleteAccount_btn.Hide()
        My.Forms.deleteAdmin.Text = "View Admin Account"
        deleteAdmin.Show()
    End Sub

    Private Sub SearchRegistrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchRegistrarToolStripMenuItem.Click
        'DeleteRegistrar.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(DeleteRegistrar)
        Me.Enabled = False
        'AdminPanel.Hide()
        My.Forms.DeleteRegistrar.Button2.Hide()
        My.Forms.DeleteRegistrar.Text = "View Registrar Account"
        DeleteRegistrar.Show()
    End Sub

    Private Sub SearchCashierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCashierToolStripMenuItem.Click
        'DeleteCashier.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(DeleteCashier)
        Me.Enabled = False
        'AdminPanel.Hide()
        My.Forms.DeleteCashier.Button2.Hide()
        My.Forms.DeleteCashier.Text = "View Cashier Account"
        DeleteCashier.Show()
    End Sub

    Private Sub ViewCashierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCashierToolStripMenuItem.Click
        'DeleteCashier.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(DeleteCashier)
        DeleteCashier.TopMost = True
        Me.Enabled = False
        My.Forms.DeleteCashier.Button2.Hide()
        My.Forms.DeleteCashier.Text = "View Cashier Account"
        DeleteCashier.Show()
    End Sub

    Private Sub SearchStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudentToolStripMenuItem.Click
        'ViewStudent.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(ViewStudent)
        Me.Enabled = False
        'AdminPanel.Hide()
        ViewStudent.Show()
    End Sub

    Private Sub SearchSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewClass.TopMost = True
        'ViewClass.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(ViewClass)
        'AdminPanel.Hide()
        ViewClass.Show()
    End Sub

    Private Sub ViewSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewClass.TopMost = True
        'ViewClass.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(ViewClass)
        'AdminPanel.Hide()
        ViewClass.Show()
    End Sub

    Private Sub UpdateAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAdminToolStripMenuItem.Click
        UpdateAdmin.TopMost = True
        'UpdateAdmin.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(UpdateAdmin)
        'AdminPanel.Hide()
        Me.Enabled = False
        UpdateAdmin.Show()
    End Sub

    Private Sub UpdateRegistrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateRegistrarToolStripMenuItem.Click
        UpdateRegistrar.TopMost = True
        Me.Enabled = False
        'UpdateRegistrar.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(UpdateRegistrar)
        'AdminPanel.Hide()
        UpdateRegistrar.Show()
    End Sub

    Private Sub UpdateCashierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCashierToolStripMenuItem.Click
        UpdateCashier.TopMost = True
        Me.Enabled = False
        'UpdateCashier.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(UpdateCashier)
        'AdminPanel.Hide()
        UpdateCashier.Show()
    End Sub

    Private Sub ViewEnrolledStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEnrolledStudentsToolStripMenuItem.Click
        SearchStudent.TopMost = True
        Me.Enabled = False
        'SearchStudent.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(SearchStudent)
        'AdminPanel.Hide()
        SearchStudent.Show()
    End Sub

    Private Sub SearchArchiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchArchiveToolStripMenuItem.Click
        StudentArchive.TopMost = True
        Me.Enabled = False
        'StudentArchive.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(StudentArchive)
        'AdminPanel.Hide()
        StudentArchive.Show()
    End Sub

    Private Sub RestoreStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreStudentRecordToolStripMenuItem.Click
        StudentArchive.TopMost = True
        Me.Enabled = False
        'StudentArchive.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(StudentArchive)
        'AdminPanel.Hide()
        StudentArchive.Show()
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemToolStripMenuItem.Click
        'addBookItem.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(addBookItem)
        Me.Enabled = False
        'AdminPanel.Hide()
        addBookItem.Show()
    End Sub

    Private Sub UpdateItemPriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateItemPriceToolStripMenuItem.Click
        'UpdatePriceItem.TopLevel = False
        'AdminPanelPictureBox.Controls.Add(UpdatePriceItem)
        Me.Enabled = False
        'AdminPanel.Hide()
        UpdatePriceItem.Show()
    End Sub
    Private Sub ToolStripSeparator3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSeparator3.Click

    End Sub
End Class