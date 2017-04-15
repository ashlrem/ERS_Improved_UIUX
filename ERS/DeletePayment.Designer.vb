<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletePayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletePayment))
        Me.SearchAddpayemt_btn = New System.Windows.Forms.Button()
        Me.sn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Payment_grp = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.midterm = New System.Windows.Forms.Label()
        Me.prelim = New System.Windows.Forms.Label()
        Me.DeletePayment_btn = New System.Windows.Forms.Button()
        Me.Payment_grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchAddpayemt_btn
        '
        Me.SearchAddpayemt_btn.BackgroundImage = CType(resources.GetObject("SearchAddpayemt_btn.BackgroundImage"), System.Drawing.Image)
        Me.SearchAddpayemt_btn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SearchAddpayemt_btn.ForeColor = System.Drawing.Color.White
        Me.SearchAddpayemt_btn.Location = New System.Drawing.Point(194, 32)
        Me.SearchAddpayemt_btn.Name = "SearchAddpayemt_btn"
        Me.SearchAddpayemt_btn.Size = New System.Drawing.Size(94, 36)
        Me.SearchAddpayemt_btn.TabIndex = 8
        Me.SearchAddpayemt_btn.Text = "Search"
        Me.SearchAddpayemt_btn.UseVisualStyleBackColor = True
        '
        'sn
        '
        Me.sn.Location = New System.Drawing.Point(55, 48)
        Me.sn.MaxLength = 18
        Me.sn.Name = "sn"
        Me.sn.Size = New System.Drawing.Size(121, 20)
        Me.sn.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search Student Number:"
        '
        'Payment_grp
        '
        Me.Payment_grp.Controls.Add(Me.Label10)
        Me.Payment_grp.Controls.Add(Me.Label8)
        Me.Payment_grp.Controls.Add(Me.midterm)
        Me.Payment_grp.Controls.Add(Me.prelim)
        Me.Payment_grp.Enabled = False
        Me.Payment_grp.Location = New System.Drawing.Point(55, 85)
        Me.Payment_grp.Name = "Payment_grp"
        Me.Payment_grp.Size = New System.Drawing.Size(233, 93)
        Me.Payment_grp.TabIndex = 10
        Me.Payment_grp.TabStop = False
        Me.Payment_grp.Text = "Partial Payment"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "SecondPayment:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "First Payment::"
        '
        'midterm
        '
        Me.midterm.AutoSize = True
        Me.midterm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midterm.Location = New System.Drawing.Point(115, 52)
        Me.midterm.Name = "midterm"
        Me.midterm.Size = New System.Drawing.Size(14, 18)
        Me.midterm.TabIndex = 1
        Me.midterm.Text = "-"
        '
        'prelim
        '
        Me.prelim.AutoSize = True
        Me.prelim.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prelim.Location = New System.Drawing.Point(115, 25)
        Me.prelim.Name = "prelim"
        Me.prelim.Size = New System.Drawing.Size(19, 18)
        Me.prelim.TabIndex = 1
        Me.prelim.Text = "- "
        '
        'DeletePayment_btn
        '
        Me.DeletePayment_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DeletePayment_btn.BackgroundImage = CType(resources.GetObject("DeletePayment_btn.BackgroundImage"), System.Drawing.Image)
        Me.DeletePayment_btn.Enabled = False
        Me.DeletePayment_btn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.DeletePayment_btn.ForeColor = System.Drawing.Color.White
        Me.DeletePayment_btn.Location = New System.Drawing.Point(55, 193)
        Me.DeletePayment_btn.Name = "DeletePayment_btn"
        Me.DeletePayment_btn.Size = New System.Drawing.Size(233, 61)
        Me.DeletePayment_btn.TabIndex = 11
        Me.DeletePayment_btn.Text = "Delete"
        Me.DeletePayment_btn.UseVisualStyleBackColor = False
        '
        'DeletePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 278)
        Me.Controls.Add(Me.DeletePayment_btn)
        Me.Controls.Add(Me.Payment_grp)
        Me.Controls.Add(Me.SearchAddpayemt_btn)
        Me.Controls.Add(Me.sn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(354, 311)
        Me.MinimumSize = New System.Drawing.Size(354, 311)
        Me.Name = "DeletePayment"
        Me.Text = "Payments"
        Me.Payment_grp.ResumeLayout(False)
        Me.Payment_grp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchAddpayemt_btn As System.Windows.Forms.Button
    Friend WithEvents sn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Payment_grp As System.Windows.Forms.GroupBox
    Friend WithEvents midterm As System.Windows.Forms.Label
    Friend WithEvents prelim As System.Windows.Forms.Label
    Friend WithEvents DeletePayment_btn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
