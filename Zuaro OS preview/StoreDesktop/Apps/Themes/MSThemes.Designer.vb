<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MicrosoftThemes
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
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MicrosoftThemes))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Back
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(200, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 62)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kozuka Gothic Pr6N R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(97, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 26)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ZUARO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kozuka Gothic Pro EL", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(92, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 48)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "store"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Store
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 84)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 2)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 548)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(842, 2)
        Me.Panel2.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 546)
        Me.Panel3.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(840, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 546)
        Me.Panel4.TabIndex = 22
        '
        'TileControl1
        '
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.Location = New System.Drawing.Point(24, 121)
        Me.TileControl1.MaxId = 1
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(150, 148)
        Me.TileControl1.TabIndex = 23
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Name = "TileGroup2"
        Me.TileGroup2.Text = Nothing
        '
        'TileItem1
        '
        Me.TileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TileItem1.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White
        Me.TileItem1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem1.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem1.AppearanceItem.Normal.Options.UseForeColor = True
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"), System.Drawing.Image)
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement2.Text = ""
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem1.Elements.Add(TileItemElement2)
        Me.TileItem1.Id = 0
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem1.Name = "TileItem1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(162, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(818, 63)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Microsoft themes on the MS Website"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Location = New System.Drawing.Point(597, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(244, 83)
        Me.Panel5.TabIndex = 26
        '
        'WebControl1
        '
        Me.WebControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebControl1.Location = New System.Drawing.Point(24, 263)
        Me.WebControl1.Size = New System.Drawing.Size(806, 275)
        Me.WebControl1.Source = New System.Uri("http://windows.microsoft.com/en-GB/windows/themes", System.UriKind.Absolute)
        Me.WebControl1.TabIndex = 27
        '
        'MicrosoftThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(842, 550)
        Me.Controls.Add(Me.WebControl1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TileControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MicrosoftThemes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Youtube for Zuaro OS"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.DarkGray
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
End Class
