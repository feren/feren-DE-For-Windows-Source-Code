<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiPlayer31
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiPlayer31))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 39)
        Me.Panel1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(758, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "˅"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(781, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "˄"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(805, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "r"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ri Player"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(836, 2)
        Me.Panel8.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(834, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 526)
        Me.Panel2.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Panel4.Location = New System.Drawing.Point(-3, 521)
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizeToolStripMenuItem, Me.HomeToolStripMenuItem, Me.DisplayToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(2, 39)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OrganizeToolStripMenuItem
        '
        Me.OrganizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumeCurrentVideoToolStripMenuItem, Me.MuteVolumeToolStripMenuItem, Me.ToolStripMenuItem1, Me.GoToPlayingVideoToolStripMenuItem, Me.ToolStripMenuItem2, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OrganizeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OrganizeToolStripMenuItem.Name = "OrganizeToolStripMenuItem"
        Me.OrganizeToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.OrganizeToolStripMenuItem.Text = "Organize"
        '
        'ResumeCurrentVideoToolStripMenuItem
        '
        Me.ResumeCurrentVideoToolStripMenuItem.Name = "ResumeCurrentVideoToolStripMenuItem"
        Me.ResumeCurrentVideoToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.ResumeCurrentVideoToolStripMenuItem.Text = "Resume Current Video"
        '
        'MuteVolumeToolStripMenuItem
        '
        Me.MuteVolumeToolStripMenuItem.Name = "MuteVolumeToolStripMenuItem"
        Me.MuteVolumeToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.MuteVolumeToolStripMenuItem.Text = "Mute Volume"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(222, 6)
        '
        'GoToPlayingVideoToolStripMenuItem
        '
        Me.GoToPlayingVideoToolStripMenuItem.Name = "GoToPlayingVideoToolStripMenuItem"
        Me.GoToPlayingVideoToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.GoToPlayingVideoToolStripMenuItem.Text = "Go to Playing Video"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(222, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenVideoToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'OpenVideoToolStripMenuItem
        '
        Me.OpenVideoToolStripMenuItem.Name = "OpenVideoToolStripMenuItem"
        Me.OpenVideoToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.OpenVideoToolStripMenuItem.Text = "Open Music..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(162, 6)
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(2, 67)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(832, 2)
        Me.Panel11.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Music"
        Me.OpenFileDialog1.Title = "Open Music..."
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(2, 67)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(832, 498)
        Me.Panel12.TabIndex = 13
        Me.Panel12.Visible = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(832, 1)
        Me.Panel13.TabIndex = 6
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(832, 498)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.Location = New System.Drawing.Point(0, 435)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 5)
        Me.Panel10.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(2, 563)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(832, 2)
        Me.Panel9.TabIndex = 10
        '
        'Panel7
        '
        Me.Panel7.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 5)
        Me.Panel7.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.Panel6.Location = New System.Drawing.Point(0, 521)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 5)
        Me.Panel6.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 39)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 526)
        Me.Panel5.TabIndex = 9
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 1)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(832, 1)
        Me.Panel14.TabIndex = 7
        '
        'RiPlayer31
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(836, 565)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RiPlayer31"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ri Player"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
End Class
