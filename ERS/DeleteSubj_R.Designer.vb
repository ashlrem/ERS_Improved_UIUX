<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteSubj_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteSubj_R))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sec = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeleteSubj_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchSubj_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.subj = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sec)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DeleteSubj_btn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 74)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject Information"
        '
        'sec
        '
        Me.sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sec.FormattingEnabled = True
        Me.sec.Location = New System.Drawing.Point(104, 29)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(160, 21)
        Me.sec.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Section"
        '
        'DeleteSubj_btn
        '
        Me.DeleteSubj_btn.BackgroundImage = CType(resources.GetObject("DeleteSubj_btn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteSubj_btn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.DeleteSubj_btn.ForeColor = System.Drawing.Color.White
        Me.DeleteSubj_btn.Location = New System.Drawing.Point(294, 19)
        Me.DeleteSubj_btn.Name = "DeleteSubj_btn"
        Me.DeleteSubj_btn.Size = New System.Drawing.Size(75, 40)
        Me.DeleteSubj_btn.TabIndex = 6
        Me.DeleteSubj_btn.Text = "Delete"
        Me.DeleteSubj_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Grade Level:"
        '
        'SearchSubj_btn
        '
        Me.SearchSubj_btn.BackgroundImage = CType(resources.GetObject("SearchSubj_btn.BackgroundImage"), System.Drawing.Image)
        Me.SearchSubj_btn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SearchSubj_btn.ForeColor = System.Drawing.Color.White
        Me.SearchSubj_btn.Location = New System.Drawing.Point(294, 19)
        Me.SearchSubj_btn.Name = "SearchSubj_btn"
        Me.SearchSubj_btn.Size = New System.Drawing.Size(75, 38)
        Me.SearchSubj_btn.TabIndex = 2
        Me.SearchSubj_btn.Text = "Search"
        Me.SearchSubj_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.subj)
        Me.GroupBox1.Controls.Add(Me.SearchSubj_btn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 81)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Subject"
        '
        'subj
        '
        Me.subj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subj.FormattingEnabled = True
        Me.subj.Items.AddRange(New Object() {"Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6"})
        Me.subj.Location = New System.Drawing.Point(104, 30)
        Me.subj.Name = "subj"
        Me.subj.Size = New System.Drawing.Size(160, 21)
        Me.subj.TabIndex = 4
        '
        'DeleteSubj_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 199)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "DeleteSubj_R"
        Me.Text = "DeleteSubj_R"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents sec As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DeleteSubj_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchSubj_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents subj As System.Windows.Forms.ComboBox
End Class
