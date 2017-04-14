<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgot2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgot2))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ne1 = New System.Windows.Forms.Label()
        Me.ans2 = New System.Windows.Forms.TextBox()
        Me.ans1 = New System.Windows.Forms.TextBox()
        Me.sq2 = New System.Windows.Forms.Label()
        Me.sq1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(538, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 42)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ne1
        '
        Me.ne1.AutoSize = True
        Me.ne1.Location = New System.Drawing.Point(565, 164)
        Me.ne1.Name = "ne1"
        Me.ne1.Size = New System.Drawing.Size(39, 13)
        Me.ne1.TabIndex = 12
        Me.ne1.Text = "Label1"
        '
        'ans2
        '
        Me.ans2.Location = New System.Drawing.Point(64, 258)
        Me.ans2.MaxLength = 18
        Me.ans2.Name = "ans2"
        Me.ans2.Size = New System.Drawing.Size(294, 20)
        Me.ans2.TabIndex = 10
        '
        'ans1
        '
        Me.ans1.Location = New System.Drawing.Point(64, 164)
        Me.ans1.MaxLength = 18
        Me.ans1.Name = "ans1"
        Me.ans1.Size = New System.Drawing.Size(294, 20)
        Me.ans1.TabIndex = 9
        '
        'sq2
        '
        Me.sq2.AutoSize = True
        Me.sq2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sq2.Location = New System.Drawing.Point(28, 213)
        Me.sq2.Name = "sq2"
        Me.sq2.Size = New System.Drawing.Size(63, 20)
        Me.sq2.TabIndex = 7
        Me.sq2.Text = "Label1"
        '
        'sq1
        '
        Me.sq1.AutoSize = True
        Me.sq1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sq1.Location = New System.Drawing.Point(28, 119)
        Me.sq1.Name = "sq1"
        Me.sq1.Size = New System.Drawing.Size(63, 20)
        Me.sq1.TabIndex = 8
        Me.sq1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(538, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(538, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'forgot2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(696, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ne1)
        Me.Controls.Add(Me.ans2)
        Me.Controls.Add(Me.ans1)
        Me.Controls.Add(Me.sq2)
        Me.Controls.Add(Me.sq1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Location = New System.Drawing.Point(350, 50)
        Me.MaximumSize = New System.Drawing.Size(712, 371)
        Me.MinimumSize = New System.Drawing.Size(712, 371)
        Me.Name = "forgot2"
        Me.Text = "forgot2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ne1 As System.Windows.Forms.Label
    Friend WithEvents ans2 As System.Windows.Forms.TextBox
    Friend WithEvents ans1 As System.Windows.Forms.TextBox
    Friend WithEvents sq2 As System.Windows.Forms.Label
    Friend WithEvents sq1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
