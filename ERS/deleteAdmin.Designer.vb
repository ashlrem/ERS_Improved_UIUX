﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deleteAdmin))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DeleteAccount_btn = New System.Windows.Forms.Button()
        Me.cno = New System.Windows.Forms.MaskedTextBox()
        Me.eadd = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.TextBox()
        Me.bd = New System.Windows.Forms.MaskedTextBox()
        Me.mn = New System.Windows.Forms.TextBox()
        Me.fn = New System.Windows.Forms.TextBox()
        Me.ln = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.en = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.DeleteAccount_btn)
        Me.GroupBox2.Controls.Add(Me.cno)
        Me.GroupBox2.Controls.Add(Me.eadd)
        Me.GroupBox2.Controls.Add(Me.add)
        Me.GroupBox2.Controls.Add(Me.bd)
        Me.GroupBox2.Controls.Add(Me.mn)
        Me.GroupBox2.Controls.Add(Me.fn)
        Me.GroupBox2.Controls.Add(Me.ln)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(16, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 247)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(291, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'DeleteAccount_btn
        '
        Me.DeleteAccount_btn.BackgroundImage = CType(resources.GetObject("DeleteAccount_btn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteAccount_btn.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.DeleteAccount_btn.ForeColor = System.Drawing.Color.White
        Me.DeleteAccount_btn.Location = New System.Drawing.Point(250, 214)
        Me.DeleteAccount_btn.Name = "DeleteAccount_btn"
        Me.DeleteAccount_btn.Size = New System.Drawing.Size(159, 27)
        Me.DeleteAccount_btn.TabIndex = 6
        Me.DeleteAccount_btn.Text = "Delete"
        Me.DeleteAccount_btn.UseVisualStyleBackColor = True
        '
        'cno
        '
        Me.cno.Location = New System.Drawing.Point(115, 188)
        Me.cno.Name = "cno"
        Me.cno.Size = New System.Drawing.Size(170, 20)
        Me.cno.TabIndex = 7
        '
        'eadd
        '
        Me.eadd.Location = New System.Drawing.Point(115, 162)
        Me.eadd.MaxLength = 40
        Me.eadd.Name = "eadd"
        Me.eadd.Size = New System.Drawing.Size(170, 20)
        Me.eadd.TabIndex = 6
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(115, 136)
        Me.add.MaxLength = 70
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(170, 20)
        Me.add.TabIndex = 5
        '
        'bd
        '
        Me.bd.Location = New System.Drawing.Point(115, 110)
        Me.bd.Name = "bd"
        Me.bd.Size = New System.Drawing.Size(170, 20)
        Me.bd.TabIndex = 4
        '
        'mn
        '
        Me.mn.Location = New System.Drawing.Point(115, 84)
        Me.mn.MaxLength = 18
        Me.mn.Name = "mn"
        Me.mn.Size = New System.Drawing.Size(170, 20)
        Me.mn.TabIndex = 3
        '
        'fn
        '
        Me.fn.Location = New System.Drawing.Point(115, 58)
        Me.fn.MaxLength = 18
        Me.fn.Name = "fn"
        Me.fn.Size = New System.Drawing.Size(170, 20)
        Me.fn.TabIndex = 2
        '
        'ln
        '
        Me.ln.Location = New System.Drawing.Point(115, 32)
        Me.ln.MaxLength = 18
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(170, 20)
        Me.ln.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(16, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ContactNumber:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(16, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Email_Account:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(16, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(16, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Birthday:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(16, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "MiddleName:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "GivenName:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(16, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Surname:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.en)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 81)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Validation"
        '
        'en
        '
        Me.en.Location = New System.Drawing.Point(129, 30)
        Me.en.MaxLength = 18
        Me.en.Name = "en"
        Me.en.Size = New System.Drawing.Size(141, 20)
        Me.en.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(276, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(49, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EmployeeID:"
        '
        'deleteAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 367)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "deleteAdmin"
        Me.Text = "Delete Admin"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DeleteAccount_btn As System.Windows.Forms.Button
    Friend WithEvents cno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents eadd As System.Windows.Forms.TextBox
    Friend WithEvents add As System.Windows.Forms.TextBox
    Friend WithEvents bd As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mn As System.Windows.Forms.TextBox
    Friend WithEvents fn As System.Windows.Forms.TextBox
    Friend WithEvents ln As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents en As System.Windows.Forms.TextBox
End Class
