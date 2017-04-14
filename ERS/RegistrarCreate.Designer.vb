<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarCreate))
        Me.bd = New System.Windows.Forms.DateTimePicker()
        Me.add = New System.Windows.Forms.TextBox()
        Me.fn = New System.Windows.Forms.TextBox()
        Me.eadd = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ln = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.sq2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.statusTextBoxRegistrar = New System.Windows.Forms.TextBox()
        Me.mn = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sq1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cno = New System.Windows.Forms.TextBox()
        Me.pw = New System.Windows.Forms.TextBox()
        Me.rtp = New System.Windows.Forms.TextBox()
        Me.ans2 = New System.Windows.Forms.TextBox()
        Me.ans1 = New System.Windows.Forms.TextBox()
        Me.en = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bd
        '
        Me.bd.CustomFormat = "MM/dd/yyyy"
        Me.bd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bd.Location = New System.Drawing.Point(240, 153)
        Me.bd.Name = "bd"
        Me.bd.Size = New System.Drawing.Size(260, 20)
        Me.bd.TabIndex = 6
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(260, 123)
        Me.add.MaxLength = 40
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(345, 20)
        Me.add.TabIndex = 4
        '
        'fn
        '
        Me.fn.Location = New System.Drawing.Point(371, 93)
        Me.fn.MaxLength = 18
        Me.fn.Name = "fn"
        Me.fn.Size = New System.Drawing.Size(220, 20)
        Me.fn.TabIndex = 2
        '
        'eadd
        '
        Me.eadd.Location = New System.Drawing.Point(260, 183)
        Me.eadd.MaxLength = 18
        Me.eadd.Name = "eadd"
        Me.eadd.Size = New System.Drawing.Size(229, 20)
        Me.eadd.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(5, 183)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "TakePhoto"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ln
        '
        Me.ln.Location = New System.Drawing.Point(136, 93)
        Me.ln.MaxLength = 18
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(227, 20)
        Me.ln.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(558, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 37)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(5, 159)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "UploadPhoto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'sq2
        '
        Me.sq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sq2.FormattingEnabled = True
        Me.sq2.Items.AddRange(New Object() {"What is your favorite book?", "What is the first name of your bestfriend?", "What is the last three digits of your Social Security Number?"})
        Me.sq2.Location = New System.Drawing.Point(181, 265)
        Me.sq2.Name = "sq2"
        Me.sq2.Size = New System.Drawing.Size(267, 21)
        Me.sq2.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(3, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(649, 275)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(170, 38)
        Me.Button5.TabIndex = 18
        Me.Button5.UseVisualStyleBackColor = True
        '
        'statusTextBoxRegistrar
        '
        Me.statusTextBoxRegistrar.Location = New System.Drawing.Point(12, 78)
        Me.statusTextBoxRegistrar.Name = "statusTextBoxRegistrar"
        Me.statusTextBoxRegistrar.Size = New System.Drawing.Size(46, 20)
        Me.statusTextBoxRegistrar.TabIndex = 49
        Me.statusTextBoxRegistrar.Text = "Active"
        Me.statusTextBoxRegistrar.Visible = False
        '
        'mn
        '
        Me.mn.Location = New System.Drawing.Point(614, 93)
        Me.mn.MaxLength = 18
        Me.mn.Name = "mn"
        Me.mn.Size = New System.Drawing.Size(216, 20)
        Me.mn.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(696, 123)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(326, 531)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sq1
        '
        Me.sq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sq1.FormattingEnabled = True
        Me.sq1.Items.AddRange(New Object() {"What is your favorite pet?", "What is the zip code of your parents house?", "What is your mother's maiden name?"})
        Me.sq1.Location = New System.Drawing.Point(181, 208)
        Me.sq1.Name = "sq1"
        Me.sq1.Size = New System.Drawing.Size(267, 21)
        Me.sq1.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(842, 330)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'cno
        '
        Me.cno.Location = New System.Drawing.Point(624, 154)
        Me.cno.MaxLength = 11
        Me.cno.Name = "cno"
        Me.cno.Size = New System.Drawing.Size(206, 20)
        Me.cno.TabIndex = 7
        '
        'pw
        '
        Me.pw.Location = New System.Drawing.Point(604, 214)
        Me.pw.MaxLength = 18
        Me.pw.Name = "pw"
        Me.pw.Size = New System.Drawing.Size(226, 20)
        Me.pw.TabIndex = 14
        '
        'rtp
        '
        Me.rtp.Location = New System.Drawing.Point(604, 245)
        Me.rtp.MaxLength = 18
        Me.rtp.Name = "rtp"
        Me.rtp.Size = New System.Drawing.Size(226, 20)
        Me.rtp.TabIndex = 15
        '
        'ans2
        '
        Me.ans2.Location = New System.Drawing.Point(174, 292)
        Me.ans2.MaxLength = 30
        Me.ans2.Name = "ans2"
        Me.ans2.Size = New System.Drawing.Size(244, 20)
        Me.ans2.TabIndex = 13
        '
        'ans1
        '
        Me.ans1.Location = New System.Drawing.Point(181, 237)
        Me.ans1.MaxLength = 30
        Me.ans1.Name = "ans1"
        Me.ans1.Size = New System.Drawing.Size(235, 20)
        Me.ans1.TabIndex = 11
        '
        'en
        '
        Me.en.Location = New System.Drawing.Point(626, 184)
        Me.en.MaxLength = 18
        Me.en.Name = "en"
        Me.en.Size = New System.Drawing.Size(206, 20)
        Me.en.TabIndex = 9
        '
        'RegistrarCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.en)
        Me.Controls.Add(Me.ans2)
        Me.Controls.Add(Me.ans1)
        Me.Controls.Add(Me.rtp)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.cno)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.eadd)
        Me.Controls.Add(Me.sq2)
        Me.Controls.Add(Me.bd)
        Me.Controls.Add(Me.sq1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ln)
        Me.Controls.Add(Me.fn)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.mn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.statusTextBoxRegistrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "RegistrarCreate"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "RegistrarCreate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bd As System.Windows.Forms.DateTimePicker
    Friend WithEvents add As System.Windows.Forms.TextBox
    Friend WithEvents fn As System.Windows.Forms.TextBox
    Friend WithEvents eadd As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ln As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents sq2 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents statusTextBoxRegistrar As System.Windows.Forms.TextBox
    Friend WithEvents mn As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents sq1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cno As System.Windows.Forms.TextBox
    Friend WithEvents pw As System.Windows.Forms.TextBox
    Friend WithEvents rtp As System.Windows.Forms.TextBox
    Friend WithEvents ans2 As System.Windows.Forms.TextBox
    Friend WithEvents ans1 As System.Windows.Forms.TextBox
    Friend WithEvents en As System.Windows.Forms.TextBox
End Class
