﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.datelbl = New System.Windows.Forms.Label()
        Me.AdminBtn = New System.Windows.Forms.Button()
        Me.AboutUsBtn = New System.Windows.Forms.Button()
        Me.CashierBtn = New System.Windows.Forms.Button()
        Me.RegistrarBtn = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Pi = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Pi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/dd/yyyy - hh:mm:ss"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(1266, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(84, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'datelbl
        '
        Me.datelbl.AutoSize = True
        Me.datelbl.BackColor = System.Drawing.Color.White
        Me.datelbl.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datelbl.Location = New System.Drawing.Point(21, 699)
        Me.datelbl.Name = "datelbl"
        Me.datelbl.Size = New System.Drawing.Size(42, 26)
        Me.datelbl.TabIndex = 2
        Me.datelbl.Text = "Dat"
        '
        'AdminBtn
        '
        Me.AdminBtn.BackColor = System.Drawing.Color.Transparent
        Me.AdminBtn.BackgroundImage = CType(resources.GetObject("AdminBtn.BackgroundImage"), System.Drawing.Image)
        Me.AdminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminBtn.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold)
        Me.AdminBtn.ForeColor = System.Drawing.Color.White
        Me.AdminBtn.Location = New System.Drawing.Point(347, 201)
        Me.AdminBtn.Name = "AdminBtn"
        Me.AdminBtn.Size = New System.Drawing.Size(315, 82)
        Me.AdminBtn.TabIndex = 4
        Me.AdminBtn.Text = "Administrator"
        Me.AdminBtn.UseVisualStyleBackColor = False
        '
        'AboutUsBtn
        '
        Me.AboutUsBtn.BackColor = System.Drawing.Color.Transparent
        Me.AboutUsBtn.BackgroundImage = CType(resources.GetObject("AboutUsBtn.BackgroundImage"), System.Drawing.Image)
        Me.AboutUsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutUsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutUsBtn.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutUsBtn.ForeColor = System.Drawing.Color.White
        Me.AboutUsBtn.Location = New System.Drawing.Point(12, 201)
        Me.AboutUsBtn.Name = "AboutUsBtn"
        Me.AboutUsBtn.Size = New System.Drawing.Size(315, 82)
        Me.AboutUsBtn.TabIndex = 3
        Me.AboutUsBtn.Text = "About Us"
        Me.AboutUsBtn.UseVisualStyleBackColor = False
        '
        'CashierBtn
        '
        Me.CashierBtn.BackColor = System.Drawing.Color.Transparent
        Me.CashierBtn.BackgroundImage = CType(resources.GetObject("CashierBtn.BackgroundImage"), System.Drawing.Image)
        Me.CashierBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CashierBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CashierBtn.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold)
        Me.CashierBtn.ForeColor = System.Drawing.Color.White
        Me.CashierBtn.Location = New System.Drawing.Point(684, 201)
        Me.CashierBtn.Name = "CashierBtn"
        Me.CashierBtn.Size = New System.Drawing.Size(315, 82)
        Me.CashierBtn.TabIndex = 3
        Me.CashierBtn.Text = "Cashier"
        Me.CashierBtn.UseVisualStyleBackColor = False
        '
        'RegistrarBtn
        '
        Me.RegistrarBtn.BackgroundImage = CType(resources.GetObject("RegistrarBtn.BackgroundImage"), System.Drawing.Image)
        Me.RegistrarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegistrarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegistrarBtn.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold)
        Me.RegistrarBtn.ForeColor = System.Drawing.Color.White
        Me.RegistrarBtn.Location = New System.Drawing.Point(1021, 201)
        Me.RegistrarBtn.Name = "RegistrarBtn"
        Me.RegistrarBtn.Size = New System.Drawing.Size(315, 82)
        Me.RegistrarBtn.TabIndex = 3
        Me.RegistrarBtn.Text = "Registrar"
        Me.RegistrarBtn.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(1229, 670)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 51)
        Me.Button5.TabIndex = 3
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Pi
        '
        Me.Pi.BackColor = System.Drawing.Color.Transparent
        Me.Pi.ErrorImage = Nothing
        Me.Pi.InitialImage = Nothing
        Me.Pi.Location = New System.Drawing.Point(12, 196)
        Me.Pi.Name = "Pi"
        Me.Pi.Size = New System.Drawing.Size(1338, 533)
        Me.Pi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pi.TabIndex = 7
        Me.Pi.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(412, 289)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(587, 422)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(178, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(207, 178)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(742, 59)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "St. Martin de Porres Catholic School"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(656, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Paombong, Bulacan"
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.datelbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.RegistrarBtn)
        Me.Controls.Add(Me.CashierBtn)
        Me.Controls.Add(Me.AboutUsBtn)
        Me.Controls.Add(Me.AdminBtn)
        Me.Controls.Add(Me.Pi)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "MainScreen"
        Me.Text = "Enrollment and Record System"
        CType(Me.Pi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents datelbl As System.Windows.Forms.Label
    Friend WithEvents AdminBtn As System.Windows.Forms.Button
    Friend WithEvents AboutUsBtn As System.Windows.Forms.Button
    Friend WithEvents CashierBtn As System.Windows.Forms.Button
    Friend WithEvents RegistrarBtn As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Pi As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
