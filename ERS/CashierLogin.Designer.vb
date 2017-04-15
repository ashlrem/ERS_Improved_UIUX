<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashierLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pw = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.en = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LoginCancelBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cashier"
        '
        'pw
        '
        Me.pw.Location = New System.Drawing.Point(249, 120)
        Me.pw.MaxLength = 30
        Me.pw.Name = "pw"
        Me.pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pw.Size = New System.Drawing.Size(163, 20)
        Me.pw.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(199, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 33)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'en
        '
        Me.en.Location = New System.Drawing.Point(249, 82)
        Me.en.MaxLength = 18
        Me.en.Name = "en"
        Me.en.Size = New System.Drawing.Size(163, 20)
        Me.en.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(100, 166)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(90, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password?"
        '
        'LoginCancelBtn
        '
        Me.LoginCancelBtn.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.LoginCancelBtn.Location = New System.Drawing.Point(308, 159)
        Me.LoginCancelBtn.Name = "LoginCancelBtn"
        Me.LoginCancelBtn.Size = New System.Drawing.Size(104, 27)
        Me.LoginCancelBtn.TabIndex = 5
        Me.LoginCancelBtn.Text = "Cancel"
        Me.LoginCancelBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password:"
        '
        'CashierLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(512, 215)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoginCancelBtn)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.en)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(350, 50)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(518, 221)
        Me.Name = "CashierLogin"
        Me.Text = "Sign In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pw As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents en As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LoginCancelBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
