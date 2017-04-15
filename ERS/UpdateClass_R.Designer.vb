<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateClass_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateClass_R))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sec = New System.Windows.Forms.ComboBox()
        Me.UpdateSubj_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.subj = New System.Windows.Forms.TextBox()
        Me.SearchSubj_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sec)
        Me.GroupBox2.Controls.Add(Me.UpdateSubj_btn)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(16, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 79)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject Information"
        '
        'sec
        '
        Me.sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sec.FormattingEnabled = True
        Me.sec.Location = New System.Drawing.Point(93, 28)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(121, 21)
        Me.sec.TabIndex = 7
        '
        'UpdateSubj_btn
        '
        Me.UpdateSubj_btn.BackgroundImage = CType(resources.GetObject("UpdateSubj_btn.BackgroundImage"), System.Drawing.Image)
        Me.UpdateSubj_btn.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.UpdateSubj_btn.ForeColor = System.Drawing.Color.White
        Me.UpdateSubj_btn.Location = New System.Drawing.Point(243, 21)
        Me.UpdateSubj_btn.Name = "UpdateSubj_btn"
        Me.UpdateSubj_btn.Size = New System.Drawing.Size(75, 32)
        Me.UpdateSubj_btn.TabIndex = 6
        Me.UpdateSubj_btn.Text = "Update"
        Me.UpdateSubj_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Section:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.subj)
        Me.GroupBox1.Controls.Add(Me.SearchSubj_btn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 81)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Section"
        '
        'subj
        '
        Me.subj.Location = New System.Drawing.Point(96, 31)
        Me.subj.MaxLength = 18
        Me.subj.Name = "subj"
        Me.subj.Size = New System.Drawing.Size(141, 20)
        Me.subj.TabIndex = 0
        '
        'SearchSubj_btn
        '
        Me.SearchSubj_btn.BackgroundImage = CType(resources.GetObject("SearchSubj_btn.BackgroundImage"), System.Drawing.Image)
        Me.SearchSubj_btn.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.SearchSubj_btn.ForeColor = System.Drawing.Color.White
        Me.SearchSubj_btn.Location = New System.Drawing.Point(243, 24)
        Me.SearchSubj_btn.Name = "SearchSubj_btn"
        Me.SearchSubj_btn.Size = New System.Drawing.Size(75, 32)
        Me.SearchSubj_btn.TabIndex = 2
        Me.SearchSubj_btn.Text = "Search"
        Me.SearchSubj_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Section"
        '
        'UpdateClass_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 215)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "UpdateClass_R"
        Me.Text = "Update Class Section"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UpdateSubj_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents subj As System.Windows.Forms.TextBox
    Friend WithEvents SearchSubj_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sec As System.Windows.Forms.ComboBox
End Class
