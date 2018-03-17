<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop31
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop31))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rewindbtn = New System.Windows.Forms.Label()
        Me.pausebtn = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.playbtn = New System.Windows.Forms.Label()
        Me.fastforwardbtn = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(13, 481)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 61)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.CloseToolStripMenuItem.Text = "close"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(84, 481)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 61)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rewindbtn)
        Me.Panel1.Controls.Add(Me.pausebtn)
        Me.Panel1.Controls.Add(Me.PictureBox12)
        Me.Panel1.Controls.Add(Me.playbtn)
        Me.Panel1.Controls.Add(Me.fastforwardbtn)
        Me.Panel1.Location = New System.Drawing.Point(36, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(166, 34)
        Me.Panel1.TabIndex = 3
        '
        'rewindbtn
        '
        Me.rewindbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.rewindbtn.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rewindbtn.ForeColor = System.Drawing.Color.White
        Me.rewindbtn.Location = New System.Drawing.Point(26, 0)
        Me.rewindbtn.Name = "rewindbtn"
        Me.rewindbtn.Size = New System.Drawing.Size(35, 34)
        Me.rewindbtn.TabIndex = 21
        Me.rewindbtn.Text = ""
        '
        'pausebtn
        '
        Me.pausebtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.pausebtn.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pausebtn.ForeColor = System.Drawing.Color.White
        Me.pausebtn.Location = New System.Drawing.Point(61, 0)
        Me.pausebtn.Name = "pausebtn"
        Me.pausebtn.Size = New System.Drawing.Size(35, 34)
        Me.pausebtn.TabIndex = 23
        Me.pausebtn.Text = ""
        Me.pausebtn.Visible = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.whitemusicsmallnewnewnewnew_
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox12.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(23, 32)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 19
        Me.PictureBox12.TabStop = False
        '
        'playbtn
        '
        Me.playbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.playbtn.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playbtn.ForeColor = System.Drawing.Color.White
        Me.playbtn.Location = New System.Drawing.Point(96, 0)
        Me.playbtn.Name = "playbtn"
        Me.playbtn.Size = New System.Drawing.Size(35, 34)
        Me.playbtn.TabIndex = 20
        Me.playbtn.Text = ""
        '
        'fastforwardbtn
        '
        Me.fastforwardbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.fastforwardbtn.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fastforwardbtn.ForeColor = System.Drawing.Color.White
        Me.fastforwardbtn.Location = New System.Drawing.Point(131, 0)
        Me.fastforwardbtn.Name = "fastforwardbtn"
        Me.fastforwardbtn.Size = New System.Drawing.Size(35, 34)
        Me.fastforwardbtn.TabIndex = 22
        Me.fastforwardbtn.Text = ""
        '
        'Desktop31
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Home_1_Month_Activate_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(900, 554)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Desktop31"
        Me.ShowInTaskbar = False
        Me.Text = "Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rewindbtn As System.Windows.Forms.Label
    Friend WithEvents pausebtn As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents playbtn As System.Windows.Forms.Label
    Friend WithEvents fastforwardbtn As System.Windows.Forms.Label
End Class
