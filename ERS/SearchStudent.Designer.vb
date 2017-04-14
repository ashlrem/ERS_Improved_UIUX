<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchStudent
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.filterBox = New System.Windows.Forms.ComboBox()
        Me.filterText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNoOfStudent = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Location = New System.Drawing.Point(10, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(983, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'filterBox
        '
        Me.filterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterBox.FormattingEnabled = True
        Me.filterBox.Items.AddRange(New Object() {"Student_ID_No", "LastName", "GivenName", "MiddleName", "GradeLevel", "Section"})
        Me.filterBox.Location = New System.Drawing.Point(108, 19)
        Me.filterBox.Name = "filterBox"
        Me.filterBox.Size = New System.Drawing.Size(169, 21)
        Me.filterBox.TabIndex = 1
        '
        'filterText
        '
        Me.filterText.Location = New System.Drawing.Point(286, 18)
        Me.filterText.MaxLength = 18
        Me.filterText.Name = "filterText"
        Me.filterText.Size = New System.Drawing.Size(141, 20)
        Me.filterText.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number of Student Enrolled :"
        '
        'lblNoOfStudent
        '
        Me.lblNoOfStudent.AutoSize = True
        Me.lblNoOfStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfStudent.Location = New System.Drawing.Point(221, 326)
        Me.lblNoOfStudent.Name = "lblNoOfStudent"
        Me.lblNoOfStudent.Size = New System.Drawing.Size(13, 18)
        Me.lblNoOfStudent.TabIndex = 4
        Me.lblNoOfStudent.Text = "-"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(914, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Student No.:"
        '
        'SearchStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 370)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNoOfStudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.filterText)
        Me.Controls.Add(Me.filterBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(1013, 403)
        Me.MinimumSize = New System.Drawing.Size(1013, 403)
        Me.Name = "SearchStudent"
        Me.Text = "SearchStudent"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents filterBox As System.Windows.Forms.ComboBox
    Friend WithEvents filterText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNoOfStudent As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
