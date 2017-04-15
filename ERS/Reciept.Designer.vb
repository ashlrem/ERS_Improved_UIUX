<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reciept
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reciept))
        Me.print_btn = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.Label()
        Me.grade = New System.Windows.Forms.Label()
        Me.nameOS = New System.Windows.Forms.Label()
        Me.dateP = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.am2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.po = New System.Windows.Forms.Label()
        Me.am1 = New System.Windows.Forms.Label()
        Me.am = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'print_btn
        '
        Me.print_btn.BackgroundImage = CType(resources.GetObject("print_btn.BackgroundImage"), System.Drawing.Image)
        Me.print_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.print_btn.ForeColor = System.Drawing.Color.White
        Me.print_btn.Location = New System.Drawing.Point(199, 371)
        Me.print_btn.Name = "print_btn"
        Me.print_btn.Size = New System.Drawing.Size(211, 33)
        Me.print_btn.TabIndex = 1
        Me.print_btn.Text = "Print"
        Me.print_btn.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(787, 365)
        Me.ShapeContainer1.TabIndex = 11
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 460
        Me.LineShape4.X2 = 788
        Me.LineShape4.Y1 = 294
        Me.LineShape4.Y2 = 292
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 458
        Me.LineShape3.X2 = 786
        Me.LineShape3.Y1 = 258
        Me.LineShape3.Y2 = 256
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 119
        Me.LineShape2.X2 = 794
        Me.LineShape2.Y1 = 182
        Me.LineShape2.Y2 = 182
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 119
        Me.LineShape1.X2 = 794
        Me.LineShape1.Y1 = 219
        Me.LineShape1.Y2 = 219
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 36)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Saint Martin de Pores Catholic Church"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Official Reciept"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(380, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Paombong Bulacan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(121, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Payment of:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(523, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(130, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Grade Level:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Amount:"
        '
        'amount
        '
        Me.amount.AutoSize = True
        Me.amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(237, 155)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(13, 16)
        Me.amount.TabIndex = 10
        Me.amount.Text = "-"
        '
        'grade
        '
        Me.grade.AutoSize = True
        Me.grade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.Location = New System.Drawing.Point(237, 139)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(13, 16)
        Me.grade.TabIndex = 10
        Me.grade.Text = "-"
        '
        'nameOS
        '
        Me.nameOS.AutoSize = True
        Me.nameOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameOS.Location = New System.Drawing.Point(238, 123)
        Me.nameOS.Name = "nameOS"
        Me.nameOS.Size = New System.Drawing.Size(13, 16)
        Me.nameOS.TabIndex = 10
        Me.nameOS.Text = "-"
        '
        'dateP
        '
        Me.dateP.AutoSize = True
        Me.dateP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateP.Location = New System.Drawing.Point(574, 139)
        Me.dateP.Name = "dateP"
        Me.dateP.Size = New System.Drawing.Size(13, 16)
        Me.dateP.TabIndex = 10
        Me.dateP.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(386, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "TIN- 000-042-987"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(265, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Amount:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(411, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Form of Payment:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(591, 187)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Amount:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(474, 267)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 16)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Total:"
        '
        'am2
        '
        Me.am2.AutoSize = True
        Me.am2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.am2.Location = New System.Drawing.Point(591, 267)
        Me.am2.Name = "am2"
        Me.am2.Size = New System.Drawing.Size(11, 15)
        Me.am2.TabIndex = 10
        Me.am2.Text = "-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(423, 327)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 15)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "ASDC"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(130, 123)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(92, 16)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Rec'd From:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(147, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(33, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(103, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(199, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "P"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(395, 301)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 16)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Recieved By:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.am2)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.po)
        Me.Panel1.Controls.Add(Me.am1)
        Me.Panel1.Controls.Add(Me.am)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dateP)
        Me.Panel1.Controls.Add(Me.nameOS)
        Me.Panel1.Controls.Add(Me.grade)
        Me.Panel1.Controls.Add(Me.amount)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 365)
        Me.Panel1.TabIndex = 0
        '
        'po
        '
        Me.po.AutoSize = True
        Me.po.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.po.Location = New System.Drawing.Point(130, 224)
        Me.po.Name = "po"
        Me.po.Size = New System.Drawing.Size(11, 15)
        Me.po.TabIndex = 10
        Me.po.Text = "-"
        '
        'am1
        '
        Me.am1.AutoSize = True
        Me.am1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.am1.Location = New System.Drawing.Point(591, 224)
        Me.am1.Name = "am1"
        Me.am1.Size = New System.Drawing.Size(11, 15)
        Me.am1.TabIndex = 10
        Me.am1.Text = "-"
        '
        'am
        '
        Me.am.AutoSize = True
        Me.am.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.am.Location = New System.Drawing.Point(276, 224)
        Me.am.Name = "am"
        Me.am.Size = New System.Drawing.Size(11, 15)
        Me.am.TabIndex = 10
        Me.am.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(423, 224)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 15)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "CASH"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(416, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Reciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.print_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Reciept"
        Me.Text = "Reciept"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents print_btn As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents amount As System.Windows.Forms.Label
    Friend WithEvents grade As System.Windows.Forms.Label
    Friend WithEvents nameOS As System.Windows.Forms.Label
    Friend WithEvents dateP As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents am2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents po As System.Windows.Forms.Label
    Friend WithEvents am1 As System.Windows.Forms.Label
    Friend WithEvents am As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
