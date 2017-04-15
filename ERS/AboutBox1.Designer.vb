<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox1))
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "ERS.About.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(430, 58)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.ShowBackButton = False
        Me.ReportViewer.ShowContextMenu = False
        Me.ReportViewer.ShowCredentialPrompts = False
        Me.ReportViewer.ShowDocumentMapButton = False
        Me.ReportViewer.ShowExportButton = False
        Me.ReportViewer.ShowFindControls = False
        Me.ReportViewer.ShowPageNavigationControls = False
        Me.ReportViewer.ShowParameterPrompts = False
        Me.ReportViewer.ShowPrintButton = False
        Me.ReportViewer.ShowProgress = False
        Me.ReportViewer.ShowPromptAreaButton = False
        Me.ReportViewer.ShowRefreshButton = False
        Me.ReportViewer.ShowStopButton = False
        Me.ReportViewer.ShowToolBar = False
        Me.ReportViewer.ShowZoomControl = False
        Me.ReportViewer.Size = New System.Drawing.Size(627, 395)
        Me.ReportViewer.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Paombong Bulacan"
        '
        'LabelProductName
        '
        Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(9, 9)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 30)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(1071, 30)
        Me.LabelProductName.TabIndex = 22
        Me.LabelProductName.Text = "St. Martin de Porres Catholic School"
        Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelVersion
        '
        Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersion.Location = New System.Drawing.Point(9, 9)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(1071, 17)
        Me.LabelVersion.TabIndex = 19
        Me.LabelVersion.Text = "Paombong, Bulacan"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(940, 436)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(117, 22)
        Me.OKButton.TabIndex = 20
        Me.OKButton.Text = "&OK"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(-22, 30)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(494, 451)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 21
        Me.LogoPictureBox.TabStop = False
        '
        'AboutBox1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReportViewer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(1095, 534)
        Me.MinimumSize = New System.Drawing.Size(1095, 534)
        Me.Name = "AboutBox1"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AboutBox1"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

End Class
