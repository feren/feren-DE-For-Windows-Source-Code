<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Windows7Desktop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Windows7Desktop))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Userimagebutton = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Time = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WIFIIcon = New System.Windows.Forms.PictureBox()
        Me.startbtn = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BatteryLevel = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Userimagebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIFIIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Zuaro_OS_deskshade
        Me.Panel1.Controls.Add(Me.Userimagebutton)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Time)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.WIFIIcon)
        Me.Panel1.Controls.Add(Me.startbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 539)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 42)
        Me.Panel1.TabIndex = 0
        '
        'Userimagebutton
        '
        Me.Userimagebutton.Dock = System.Windows.Forms.DockStyle.Right
        Me.Userimagebutton.Image = CType(resources.GetObject("Userimagebutton.Image"), System.Drawing.Image)
        Me.Userimagebutton.Location = New System.Drawing.Point(798, 0)
        Me.Userimagebutton.Name = "Userimagebutton"
        Me.Userimagebutton.Size = New System.Drawing.Size(43, 42)
        Me.Userimagebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Userimagebutton.TabIndex = 12
        Me.Userimagebutton.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox8.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.More
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox8.Location = New System.Drawing.Point(571, 5)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(36, 32)
        Me.PictureBox8.TabIndex = 11
        Me.PictureBox8.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(755, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 41)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox5.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Audio_Icon_3
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(645, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'Time
        '
        Me.Time.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Time.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Time.ForeColor = System.Drawing.Color.White
        Me.Time.Location = New System.Drawing.Point(696, 1)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(101, 42)
        Me.Time.TabIndex = 1
        Me.Time.Text = "00:00:00"
        Me.Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox3.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Battery_Icon_1_High
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(667, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'WIFIIcon
        '
        Me.WIFIIcon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.WIFIIcon.Image = Global.Feren_OS_DE_preview.My.Resources.Resources.Wifi_Icon
        Me.WIFIIcon.Location = New System.Drawing.Point(613, 9)
        Me.WIFIIcon.Name = "WIFIIcon"
        Me.WIFIIcon.Size = New System.Drawing.Size(24, 25)
        Me.WIFIIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WIFIIcon.TabIndex = 9
        Me.WIFIIcon.TabStop = False
        '
        'startbtn
        '
        Me.startbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.startbtn.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Logoicon
        Me.startbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.startbtn.Location = New System.Drawing.Point(3, 0)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(39, 40)
        Me.startbtn.TabIndex = 0
        Me.startbtn.TabStop = False
        '
        'Timer1
        '
        '
        'BatteryLevel
        '
        Me.BatteryLevel.Location = New System.Drawing.Point(-106, 173)
        Me.BatteryLevel.Name = "BatteryLevel"
        Me.BatteryLevel.Size = New System.Drawing.Size(100, 23)
        Me.BatteryLevel.TabIndex = 14
        Me.BatteryLevel.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'Windows7Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Home_1_Month_Activate_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(841, 581)
        Me.Controls.Add(Me.BatteryLevel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Windows7Desktop"
        Me.Text = "Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.Userimagebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIFIIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents startbtn As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents WIFIIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Userimagebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BatteryLevel As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
