﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminCreate))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.eadd = New System.Windows.Forms.TextBox()
        Me.sq2 = New System.Windows.Forms.ComboBox()
        Me.bd = New System.Windows.Forms.DateTimePicker()
        Me.sq1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ln = New System.Windows.Forms.TextBox()
        Me.fn = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.add = New System.Windows.Forms.TextBox()
        Me.mn = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cno = New System.Windows.Forms.TextBox()
        Me.ans1 = New System.Windows.Forms.TextBox()
        Me.ans2 = New System.Windows.Forms.TextBox()
        Me.pw = New System.Windows.Forms.TextBox()
        Me.rtp = New System.Windows.Forms.TextBox()
        Me.en = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(326, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 181)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Take Photo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Upload Photo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'eadd
        '
        Me.eadd.Location = New System.Drawing.Point(258, 199)
        Me.eadd.MaxLength = 40
        Me.eadd.Name = "eadd"
        Me.eadd.Size = New System.Drawing.Size(229, 20)
        Me.eadd.TabIndex = 8
        '
        'sq2
        '
        Me.sq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sq2.FormattingEnabled = True
        Me.sq2.Items.AddRange(New Object() {"Who was your childhood hero?", "What is your oldest cousin's first and last name?", "What is your favorite movie?"})
        Me.sq2.Location = New System.Drawing.Point(182, 281)
        Me.sq2.Name = "sq2"
        Me.sq2.Size = New System.Drawing.Size(305, 21)
        Me.sq2.TabIndex = 12
        '
        'bd
        '
        Me.bd.CustomFormat = "MM/dd/yyyy"
        Me.bd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bd.Location = New System.Drawing.Point(258, 170)
        Me.bd.Name = "bd"
        Me.bd.Size = New System.Drawing.Size(229, 20)
        Me.bd.TabIndex = 6
        '
        'sq1
        '
        Me.sq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sq1.FormattingEnabled = True
        Me.sq1.Items.AddRange(New Object() {"What is your favorite book?", "What is the brand of your first car?", "What was the name of your second dog?"})
        Me.sq1.Location = New System.Drawing.Point(182, 226)
        Me.sq1.Name = "sq1"
        Me.sq1.Size = New System.Drawing.Size(305, 21)
        Me.sq1.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(698, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(766, 294)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 38)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(590, 294)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(170, 38)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Save"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ln
        '
        Me.ln.Location = New System.Drawing.Point(146, 110)
        Me.ln.MaxLength = 30
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(210, 20)
        Me.ln.TabIndex = 1
        '
        'fn
        '
        Me.fn.Location = New System.Drawing.Point(384, 110)
        Me.fn.MaxLength = 30
        Me.fn.Name = "fn"
        Me.fn.Size = New System.Drawing.Size(213, 20)
        Me.fn.TabIndex = 2
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(224, 139)
        Me.add.MaxLength = 70
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(384, 20)
        Me.add.TabIndex = 4
        '
        'mn
        '
        Me.mn.Location = New System.Drawing.Point(616, 111)
        Me.mn.MaxLength = 30
        Me.mn.Name = "mn"
        Me.mn.Size = New System.Drawing.Size(216, 20)
        Me.mn.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(873, 351)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'cno
        '
        Me.cno.Location = New System.Drawing.Point(626, 173)
        Me.cno.MaxLength = 11
        Me.cno.Name = "cno"
        Me.cno.Size = New System.Drawing.Size(206, 20)
        Me.cno.TabIndex = 7
        '
        'ans1
        '
        Me.ans1.Location = New System.Drawing.Point(182, 253)
        Me.ans1.MaxLength = 30
        Me.ans1.Name = "ans1"
        Me.ans1.Size = New System.Drawing.Size(305, 20)
        Me.ans1.TabIndex = 11
        '
        'ans2
        '
        Me.ans2.Location = New System.Drawing.Point(182, 309)
        Me.ans2.MaxLength = 30
        Me.ans2.Name = "ans2"
        Me.ans2.Size = New System.Drawing.Size(305, 20)
        Me.ans2.TabIndex = 13
        '
        'pw
        '
        Me.pw.Location = New System.Drawing.Point(626, 232)
        Me.pw.MaxLength = 18
        Me.pw.Name = "pw"
        Me.pw.Size = New System.Drawing.Size(214, 20)
        Me.pw.TabIndex = 14
        '
        'rtp
        '
        Me.rtp.Location = New System.Drawing.Point(626, 260)
        Me.rtp.MaxLength = 18
        Me.rtp.Name = "rtp"
        Me.rtp.Size = New System.Drawing.Size(215, 20)
        Me.rtp.TabIndex = 15
        '
        'en
        '
        Me.en.Location = New System.Drawing.Point(626, 199)
        Me.en.MaxLength = 18
        Me.en.Name = "en"
        Me.en.Size = New System.Drawing.Size(206, 20)
        Me.en.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(380, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 23)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Given Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(612, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(612, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 23)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(143, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 23)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Birthday"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(143, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(522, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 23)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Contact No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(505, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 23)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Employee No"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 19)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Security Question 1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 281)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 19)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Security Question 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(116, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 19)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Answer"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(116, 310)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 19)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Answer"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(505, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 23)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Password"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(493, 261)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 19)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Confirm Password"
        '
        'AdminCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(873, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.en)
        Me.Controls.Add(Me.ans2)
        Me.Controls.Add(Me.rtp)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.ans1)
        Me.Controls.Add(Me.cno)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.eadd)
        Me.Controls.Add(Me.sq2)
        Me.Controls.Add(Me.bd)
        Me.Controls.Add(Me.sq1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ln)
        Me.Controls.Add(Me.fn)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.mn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AdminCreate"
        Me.Text = "Admin Create"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents eadd As System.Windows.Forms.TextBox
    Friend WithEvents sq2 As System.Windows.Forms.ComboBox
    Friend WithEvents bd As System.Windows.Forms.DateTimePicker
    Friend WithEvents sq1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ln As System.Windows.Forms.TextBox
    Friend WithEvents fn As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents add As System.Windows.Forms.TextBox
    Friend WithEvents mn As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cno As System.Windows.Forms.TextBox
    Friend WithEvents ans1 As System.Windows.Forms.TextBox
    Friend WithEvents ans2 As System.Windows.Forms.TextBox
    Friend WithEvents pw As System.Windows.Forms.TextBox
    Friend WithEvents rtp As System.Windows.Forms.TextBox
    Friend WithEvents en As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
