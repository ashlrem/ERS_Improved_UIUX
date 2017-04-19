<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen_Cashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Screen_Cashier))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatePaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletePaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewStudentPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashierPanelPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CashierPanelPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PaymentsToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(520, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPaymentToolStripMenuItem, Me.UpdatePaymentToolStripMenuItem, Me.DeletePaymentToolStripMenuItem, Me.ToolStripSeparator2, Me.ViewStudentPaymentToolStripMenuItem})
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PaymentsToolStripMenuItem.Text = "Payments"
        '
        'AddPaymentToolStripMenuItem
        '
        Me.AddPaymentToolStripMenuItem.Name = "AddPaymentToolStripMenuItem"
        Me.AddPaymentToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AddPaymentToolStripMenuItem.Text = "Add Payment"
        '
        'UpdatePaymentToolStripMenuItem
        '
        Me.UpdatePaymentToolStripMenuItem.Name = "UpdatePaymentToolStripMenuItem"
        Me.UpdatePaymentToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.UpdatePaymentToolStripMenuItem.Text = "Update Payment"
        '
        'DeletePaymentToolStripMenuItem
        '
        Me.DeletePaymentToolStripMenuItem.Name = "DeletePaymentToolStripMenuItem"
        Me.DeletePaymentToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.DeletePaymentToolStripMenuItem.Text = "Delete Payment"
        Me.DeletePaymentToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'ViewStudentPaymentToolStripMenuItem
        '
        Me.ViewStudentPaymentToolStripMenuItem.Name = "ViewStudentPaymentToolStripMenuItem"
        Me.ViewStudentPaymentToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ViewStudentPaymentToolStripMenuItem.Text = "View Student Payment"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchStudentToolStripMenuItem, Me.SearchPaymentToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        Me.SearchToolStripMenuItem.Visible = False
        '
        'SearchStudentToolStripMenuItem
        '
        Me.SearchStudentToolStripMenuItem.Name = "SearchStudentToolStripMenuItem"
        Me.SearchStudentToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SearchStudentToolStripMenuItem.Text = "Search Student"
        '
        'SearchPaymentToolStripMenuItem
        '
        Me.SearchPaymentToolStripMenuItem.Name = "SearchPaymentToolStripMenuItem"
        Me.SearchPaymentToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SearchPaymentToolStripMenuItem.Text = "Search Payment"
        '
        'CashierPanelPictureBox
        '
        Me.CashierPanelPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.CashierPanelPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CashierPanelPictureBox.ErrorImage = Nothing
        Me.CashierPanelPictureBox.InitialImage = Nothing
        Me.CashierPanelPictureBox.Location = New System.Drawing.Point(0, 24)
        Me.CashierPanelPictureBox.Name = "CashierPanelPictureBox"
        Me.CashierPanelPictureBox.Size = New System.Drawing.Size(520, 302)
        Me.CashierPanelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CashierPanelPictureBox.TabIndex = 2
        Me.CashierPanelPictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(50, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Screen_Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 326)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CashierPanelPictureBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Screen_Cashier"
        Me.Text = "Cashier"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CashierPanelPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdatePaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeletePaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewStudentPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashierPanelPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
