<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiPlayer))
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaxBtnLocation = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OrganizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeCurrentVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuteVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GoToPlayingVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenVideosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.PauseInfo = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimeoutVideo = New System.Windows.Forms.Timer(Me.components)
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxBtnLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.PauseInfo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Black
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(5, 560)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(826, 5)
        Me.Panel9.TabIndex = 10
        '
        'Panel10
        '
        Me.Panel10.Location = New System.Drawing.Point(0, 435)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 5)
        Me.Panel10.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox17)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MaxBtnLocation)
        Me.Panel1.Controls.Add(Me.PictureBox16)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 34)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox17
        '
        Me.PictureBox17.BackgroundImage = CType(resources.GetObject("PictureBox17.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox17.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox17.TabIndex = 5
        Me.PictureBox17.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(765, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(795, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(826, 5)
        Me.Panel8.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(381, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ri Player"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaxBtnLocation
        '
        Me.MaxBtnLocation.Location = New System.Drawing.Point(36, 4)
        Me.MaxBtnLocation.Name = "MaxBtnLocation"
        Me.MaxBtnLocation.Size = New System.Drawing.Size(28, 28)
        Me.MaxBtnLocation.TabIndex = 6
        Me.MaxBtnLocation.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackgroundImage = CType(resources.GetObject("PictureBox16.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox16.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox16.TabIndex = 4
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(831, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 565)
        Me.Panel2.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Panel4.Location = New System.Drawing.Point(0, 560)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 5)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 5)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 565)
        Me.Panel5.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.Panel6.Location = New System.Drawing.Point(0, 560)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 5)
        Me.Panel6.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 5)
        Me.Panel7.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizeToolStripMenuItem, Me.HomeToolStripMenuItem, Me.DisplayToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 34)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OrganizeToolStripMenuItem
        '
        Me.OrganizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumeCurrentVideoToolStripMenuItem, Me.MuteVolumeToolStripMenuItem, Me.ToolStripMenuItem1, Me.GoToPlayingVideoToolStripMenuItem, Me.ToolStripMenuItem2, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OrganizeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OrganizeToolStripMenuItem.Name = "OrganizeToolStripMenuItem"
        Me.OrganizeToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.OrganizeToolStripMenuItem.Text = "Organize"
        '
        'ResumeCurrentVideoToolStripMenuItem
        '
        Me.ResumeCurrentVideoToolStripMenuItem.Name = "ResumeCurrentVideoToolStripMenuItem"
        Me.ResumeCurrentVideoToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.ResumeCurrentVideoToolStripMenuItem.Text = "Resume Current Video"
        '
        'MuteVolumeToolStripMenuItem
        '
        Me.MuteVolumeToolStripMenuItem.Name = "MuteVolumeToolStripMenuItem"
        Me.MuteVolumeToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.MuteVolumeToolStripMenuItem.Text = "Mute Volume"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(227, 6)
        '
        'GoToPlayingVideoToolStripMenuItem
        '
        Me.GoToPlayingVideoToolStripMenuItem.Name = "GoToPlayingVideoToolStripMenuItem"
        Me.GoToPlayingVideoToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.GoToPlayingVideoToolStripMenuItem.Text = "Go to Playing Video"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(227, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenVideoToolStripMenuItem, Me.OpenVideosToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'OpenVideoToolStripMenuItem
        '
        Me.OpenVideoToolStripMenuItem.Name = "OpenVideoToolStripMenuItem"
        Me.OpenVideoToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.OpenVideoToolStripMenuItem.Text = "Open Music..."
        '
        'OpenVideosToolStripMenuItem
        '
        Me.OpenVideosToolStripMenuItem.Name = "OpenVideosToolStripMenuItem"
        Me.OpenVideosToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.OpenVideosToolStripMenuItem.Text = "Open Videos..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(172, 6)
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(5, 62)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(826, 2)
        Me.Panel11.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Music"
        Me.OpenFileDialog1.Title = "Open Music..."
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel17)
        Me.Panel12.Controls.Add(Me.Panel16)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(5, 64)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(826, 496)
        Me.Panel12.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.White
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 449)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(826, 2)
        Me.Panel17.TabIndex = 1
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel16.Controls.Add(Me.Label2)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel16.Location = New System.Drawing.Point(0, 451)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(826, 45)
        Me.Panel16.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(607, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Go to the Player >"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(826, 445)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.PauseInfo)
        Me.Panel13.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(5, 64)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(826, 496)
        Me.Panel13.TabIndex = 1
        '
        'PauseInfo
        '
        Me.PauseInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PauseInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PauseInfo.Controls.Add(Me.PictureBox3)
        Me.PauseInfo.Location = New System.Drawing.Point(331, 171)
        Me.PauseInfo.Name = "PauseInfo"
        Me.PauseInfo.Size = New System.Drawing.Size(164, 155)
        Me.PauseInfo.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Pause
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(15, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(135, 126)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel14
        '
        Me.Panel14.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Zuaro_OS_deskshade
        Me.Panel14.Controls.Add(Me.TrackBar1)
        Me.Panel14.Controls.Add(Me.Button5)
        Me.Panel14.Controls.Add(Me.Button4)
        Me.Panel14.Controls.Add(Me.ProgressBar1)
        Me.Panel14.Controls.Add(Me.Button3)
        Me.Panel14.Controls.Add(Me.Button2)
        Me.Panel14.Controls.Add(Me.Button1)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel14.Location = New System.Drawing.Point(0, 445)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(826, 51)
        Me.Panel14.TabIndex = 0
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(630, 14)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(116, 45)
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(752, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 25)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(789, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 25)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(146, 20)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(478, 10)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(97, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 25)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Play
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(56, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TimeoutVideo
        '
        Me.TimeoutVideo.Interval = 500
        '
        'RiPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(836, 565)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RiPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ri Player"
        Me.Panel9.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxBtnLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.PauseInfo.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OrganizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeCurrentVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuteVolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GoToPlayingVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents OpenVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PauseInfo As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents OpenVideosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaxBtnLocation As System.Windows.Forms.PictureBox
    Friend WithEvents TimeoutVideo As System.Windows.Forms.Timer
End Class
