﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateAdmin))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.UpdateAdmin_btn = New System.Windows.Forms.Button()
        Me.cno = New System.Windows.Forms.TextBox()
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
        Me.ValidateAccountUpdate_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.status)
        Me.GroupBox2.Controls.Add(Me.UpdateAdmin_btn)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 247)
        Me.GroupBox2.TabIndex = 14
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
        'status
        '
        Me.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"Active"})
        Me.status.Location = New System.Drawing.Point(291, 119)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(103, 21)
        Me.status.TabIndex = 13
        '
        'UpdateAdmin_btn
        '
        Me.UpdateAdmin_btn.BackgroundImage = CType(resources.GetObject("UpdateAdmin_btn.BackgroundImage"), System.Drawing.Image)
        Me.UpdateAdmin_btn.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.UpdateAdmin_btn.ForeColor = System.Drawing.Color.White
        Me.UpdateAdmin_btn.Location = New System.Drawing.Point(250, 214)
        Me.UpdateAdmin_btn.Name = "UpdateAdmin_btn"
        Me.UpdateAdmin_btn.Size = New System.Drawing.Size(159, 27)
        Me.UpdateAdmin_btn.TabIndex = 6
        Me.UpdateAdmin_btn.Text = "Update Account"
        Me.UpdateAdmin_btn.UseVisualStyleBackColor = True
        '
        'cno
        '
        Me.cno.Location = New System.Drawing.Point(115, 188)
        Me.cno.MaxLength = 11
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
        Me.Label7.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(23, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ContactNumber:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(23, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Email_Account:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(23, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(23, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Birthday:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(23, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "MiddleName:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(23, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "GivenName:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(23, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Surname:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.en)
        Me.GroupBox1.Controls.Add(Me.ValidateAccountUpdate_btn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 81)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Validation"
        '
        'en
        '
        Me.en.Location = New System.Drawing.Point(111, 31)
        Me.en.MaxLength = 18
        Me.en.Name = "en"
        Me.en.Size = New System.Drawing.Size(170, 20)
        Me.en.TabIndex = 0
        '
        'ValidateAccountUpdate_btn
        '
        Me.ValidateAccountUpdate_btn.BackgroundImage = CType(resources.GetObject("ValidateAccountUpdate_btn.BackgroundImage"), System.Drawing.Image)
        Me.ValidateAccountUpdate_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidateAccountUpdate_btn.ForeColor = System.Drawing.Color.White
        Me.ValidateAccountUpdate_btn.Location = New System.Drawing.Point(298, 22)
        Me.ValidateAccountUpdate_btn.Name = "ValidateAccountUpdate_btn"
        Me.ValidateAccountUpdate_btn.Size = New System.Drawing.Size(75, 36)
        Me.ValidateAccountUpdate_btn.TabIndex = 2
        Me.ValidateAccountUpdate_btn.Text = "Validate"
        Me.ValidateAccountUpdate_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EmployeeID:"
        '
        'UpdateAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 367)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "UpdateAdmin"
        Me.Text = "UpdateAdmin"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UpdateAdmin_btn As System.Windows.Forms.Button
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
    Friend WithEvents en As System.Windows.Forms.TextBox
    Friend WithEvents ValidateAccountUpdate_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.ComboBox
    Friend WithEvents cno As System.Windows.Forms.TextBox
End Class