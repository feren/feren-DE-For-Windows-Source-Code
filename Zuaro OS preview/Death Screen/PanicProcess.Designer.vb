<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanicProcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanicProcess))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.AppButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Userimagebutton = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.AppButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.Userimagebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(149, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(915, 256)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(488, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 188)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(482, 542)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Reboot Zuaro OS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Zuaro_OS_deskshade
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.AppButton)
        Me.Panel1.Controls.Add(Me.PictureBox9)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 577)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1212, 32)
        Me.Panel1.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel10.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Taskbar
        Me.Panel10.Controls.Add(Me.Label13)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Controls.Add(Me.PictureBox12)
        Me.Panel10.Controls.Add(Me.Label12)
        Me.Panel10.Controls.Add(Me.Label14)
        Me.Panel10.Location = New System.Drawing.Point(856, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(166, 32)
        Me.Panel10.TabIndex = 9
        '
        'AppButton
        '
        Me.AppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AppButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.AppButton.Image = CType(resources.GetObject("AppButton.Image"), System.Drawing.Image)
        Me.AppButton.Location = New System.Drawing.Point(0, 0)
        Me.AppButton.Name = "AppButton"
        Me.AppButton.Size = New System.Drawing.Size(62, 32)
        Me.AppButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppButton.TabIndex = 0
        Me.AppButton.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.Feren_OS_DE_preview.My.Resources.Resources.Shield
        Me.PictureBox9.Location = New System.Drawing.Point(822, 4)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(27, 24)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 6
        Me.PictureBox9.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Userimagebutton)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(988, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(224, 32)
        Me.Panel9.TabIndex = 8
        '
        'Userimagebutton
        '
        Me.Userimagebutton.Dock = System.Windows.Forms.DockStyle.Right
        Me.Userimagebutton.Image = CType(resources.GetObject("Userimagebutton.Image"), System.Drawing.Image)
        Me.Userimagebutton.Location = New System.Drawing.Point(190, 0)
        Me.Userimagebutton.Name = "Userimagebutton"
        Me.Userimagebutton.Size = New System.Drawing.Size(34, 32)
        Me.Userimagebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Userimagebutton.TabIndex = 1
        Me.Userimagebutton.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackgroundImage = CType(resources.GetObject("PictureBox12.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox12.Location = New System.Drawing.Point(8, -1)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(27, 32)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 3
        Me.PictureBox12.TabStop = False
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(125, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 32)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = ""
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(84, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 32)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = ""
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(43, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 32)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = ""
        Me.Label15.Visible = False
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 32)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = ""
        '
        'PanicProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1212, 609)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanicProcess"
        Me.Text = "PanicProcess"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.AppButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.Userimagebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents AppButton As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Userimagebutton As System.Windows.Forms.PictureBox
End Class
