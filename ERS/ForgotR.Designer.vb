<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotR))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ne1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(167, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 33)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter Employee Number:"
        '
        'ne1
        '
        Me.ne1.Location = New System.Drawing.Point(176, 32)
        Me.ne1.MaxLength = 18
        Me.ne1.Name = "ne1"
        Me.ne1.Size = New System.Drawing.Size(119, 20)
        Me.ne1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(86, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Verify"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ForgotR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(326, 135)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ne1)
        Me.Controls.Add(Me.Button1)
        Me.Location = New System.Drawing.Point(350, 50)
        Me.MaximumSize = New System.Drawing.Size(342, 174)
        Me.MinimumSize = New System.Drawing.Size(342, 174)
        Me.Name = "ForgotR"
        Me.Text = "ForgotR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ne1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
