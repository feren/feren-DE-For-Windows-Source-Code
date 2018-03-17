<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KidZoneDesktop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KidZoneDesktop))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.WIFIIcon = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Time = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIFIIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Zuaro_OS_deskshade
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.WIFIIcon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 524)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 38)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = " Start"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox8.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.More
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox8.Location = New System.Drawing.Point(720, 3)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(36, 32)
        Me.PictureBox8.TabIndex = 11
        Me.PictureBox8.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox5.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Audio_Icon_3
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(794, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'WIFIIcon
        '
        Me.WIFIIcon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.WIFIIcon.Image = Global.Feren_OS_DE_preview.My.Resources.Resources.Wifi_Icon
        Me.WIFIIcon.Location = New System.Drawing.Point(762, 7)
        Me.WIFIIcon.Name = "WIFIIcon"
        Me.WIFIIcon.Size = New System.Drawing.Size(24, 25)
        Me.WIFIIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WIFIIcon.TabIndex = 9
        Me.WIFIIcon.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox3.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Battery_Icon_1_High
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(816, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.ZOS_Desk_White_new
        Me.Panel2.Controls.Add(Me.Time)
        Me.Panel2.Location = New System.Drawing.Point(376, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(91, 32)
        Me.Panel2.TabIndex = 2
        '
        'Time
        '
        Me.Time.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Time.ForeColor = System.Drawing.Color.Black
        Me.Time.Location = New System.Drawing.Point(20, 5)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(51, 23)
        Me.Time.TabIndex = 0
        Me.Time.Text = "00:00:00"
        Me.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KidZoneDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(843, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KidZoneDesktop"
        Me.Text = "Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIFIIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents WIFIIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Time As System.Windows.Forms.Label
End Class
