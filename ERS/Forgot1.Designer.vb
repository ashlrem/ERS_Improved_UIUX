<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forgot1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgot1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.sq1 = New System.Windows.Forms.Label()
        Me.sq2 = New System.Windows.Forms.Label()
        Me.ans1 = New System.Windows.Forms.TextBox()
        Me.ans2 = New System.Windows.Forms.TextBox()
        Me.ne1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(546, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(546, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 37)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(546, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 42)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Continue"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'sq1
        '
        Me.sq1.AutoSize = True
        Me.sq1.BackColor = System.Drawing.Color.Transparent
        Me.sq1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sq1.Location = New System.Drawing.Point(36, 153)
        Me.sq1.Name = "sq1"
        Me.sq1.Size = New System.Drawing.Size(63, 20)
        Me.sq1.TabIndex = 1
        Me.sq1.Text = "Label1"
        '
        'sq2
        '
        Me.sq2.AutoSize = True
        Me.sq2.BackColor = System.Drawing.Color.Transparent
        Me.sq2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sq2.Location = New System.Drawing.Point(36, 231)
        Me.sq2.Name = "sq2"
        Me.sq2.Size = New System.Drawing.Size(63, 20)
        Me.sq2.TabIndex = 1
        Me.sq2.Text = "Label1"
        '
        'ans1
        '
        Me.ans1.Location = New System.Drawing.Point(72, 188)
        Me.ans1.MaxLength = 30
        Me.ans1.Name = "ans1"
        Me.ans1.Size = New System.Drawing.Size(294, 20)
        Me.ans1.TabIndex = 1
        '
        'ans2
        '
        Me.ans2.Location = New System.Drawing.Point(72, 265)
        Me.ans2.MaxLength = 30
        Me.ans2.Name = "ans2"
        Me.ans2.Size = New System.Drawing.Size(294, 20)
        Me.ans2.TabIndex = 2
        '
        'ne1
        '
        Me.ne1.AutoSize = True
        Me.ne1.Location = New System.Drawing.Point(573, 171)
        Me.ne1.Name = "ne1"
        Me.ne1.Size = New System.Drawing.Size(39, 13)
        Me.ne1.TabIndex = 4
        Me.ne1.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(490, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Please answer your security questions."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(430, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "These questions will help us verify your identity."
        '
        'Forgot1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(702, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ne1)
        Me.Controls.Add(Me.ans2)
        Me.Controls.Add(Me.ans1)
        Me.Controls.Add(Me.sq2)
        Me.Controls.Add(Me.sq1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(350, 50)
        Me.MaximumSize = New System.Drawing.Size(712, 371)
        Me.MinimumSize = New System.Drawing.Size(712, 371)
        Me.Name = "Forgot1"
        Me.Text = "Forgot Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents sq1 As System.Windows.Forms.Label
    Friend WithEvents sq2 As System.Windows.Forms.Label
    Friend WithEvents ans1 As System.Windows.Forms.TextBox
    Friend WithEvents ans2 As System.Windows.Forms.TextBox
    Friend WithEvents ne1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
