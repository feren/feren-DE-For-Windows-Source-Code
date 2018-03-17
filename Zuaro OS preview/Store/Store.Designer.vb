<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Store
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Store))
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Closable = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem6 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem7 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem8 = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup3 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem2 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem3 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem4 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem5 = New DevExpress.XtraEditors.TileItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 750
        '
        'Closable
        '
        Me.Closable.AutoSize = True
        Me.Closable.Location = New System.Drawing.Point(-15, -16)
        Me.Closable.Name = "Closable"
        Me.Closable.Size = New System.Drawing.Size(81, 17)
        Me.Closable.TabIndex = 15
        Me.Closable.Text = "CheckBox1"
        Me.Closable.UseVisualStyleBackColor = True
        Me.Closable.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.PictureBox3.Location = New System.Drawing.Point(200, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 62)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'TileControl1
        '
        Me.TileControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TileControl1.AppearanceGroupText.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileControl1.AppearanceGroupText.ForeColor = System.Drawing.Color.Black
        Me.TileControl1.AppearanceGroupText.Options.UseFont = True
        Me.TileControl1.AppearanceGroupText.Options.UseForeColor = True
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.Groups.Add(Me.TileGroup3)
        Me.TileControl1.Location = New System.Drawing.Point(0, 123)
        Me.TileControl1.MaxId = 9
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.ShowGroupText = True
        Me.TileControl1.Size = New System.Drawing.Size(837, 424)
        Me.TileControl1.TabIndex = 13
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem6)
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Items.Add(Me.TileItem7)
        Me.TileGroup2.Items.Add(Me.TileItem8)
        Me.TileGroup2.Name = "TileGroup2"
        Me.TileGroup2.Text = "Essential ZOS Apps"
        '
        'TileItem6
        '
        Me.TileItem6.AppearanceItem.Normal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TileItem6.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gainsboro
        Me.TileItem6.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black
        Me.TileItem6.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem6.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem6.AppearanceItem.Normal.Options.UseForeColor = True
        TileItemElement1.Image = CType(resources.GetObject("TileItemElement1.Image"), System.Drawing.Image)
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement1.Text = "YouTube"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem6.Elements.Add(TileItemElement1)
        Me.TileItem6.Id = 5
        Me.TileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem6.Name = "TileItem6"
        '
        'TileItem1
        '
        Me.TileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gainsboro
        Me.TileItem1.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black
        Me.TileItem1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem1.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem1.AppearanceItem.Normal.Options.UseForeColor = True
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"), System.Drawing.Image)
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement2.Text = "Facebook"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem1.Elements.Add(TileItemElement2)
        Me.TileItem1.Id = 6
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem1.Name = "TileItem1"
        '
        'TileItem7
        '
        Me.TileItem7.AppearanceItem.Normal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TileItem7.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gainsboro
        Me.TileItem7.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black
        Me.TileItem7.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem7.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem7.AppearanceItem.Normal.Options.UseForeColor = True
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"), System.Drawing.Image)
        TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement3.Text = "Google Search"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem7.Elements.Add(TileItemElement3)
        Me.TileItem7.Id = 7
        Me.TileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem7.Name = "TileItem7"
        '
        'TileItem8
        '
        Me.TileItem8.AppearanceItem.Normal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TileItem8.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gainsboro
        Me.TileItem8.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black
        Me.TileItem8.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem8.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem8.AppearanceItem.Normal.Options.UseForeColor = True
        TileItemElement4.Image = CType(resources.GetObject("TileItemElement4.Image"), System.Drawing.Image)
        TileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement4.Text = "Bing Search"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem8.Elements.Add(TileItemElement4)
        Me.TileItem8.Id = 8
        Me.TileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem8.Name = "TileItem8"
        '
        'TileGroup3
        '
        Me.TileGroup3.Items.Add(Me.TileItem2)
        Me.TileGroup3.Items.Add(Me.TileItem3)
        Me.TileGroup3.Items.Add(Me.TileItem4)
        Me.TileGroup3.Items.Add(Me.TileItem5)
        Me.TileGroup3.Name = "TileGroup3"
        Me.TileGroup3.Text = "Windows Apps"
        '
        'TileItem2
        '
        Me.TileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.SteelBlue
        Me.TileItem2.AppearanceItem.Normal.BorderColor = System.Drawing.Color.SteelBlue
        Me.TileItem2.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem2.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement5.Image = CType(resources.GetObject("TileItemElement5.Image"), System.Drawing.Image)
        TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement5.Text = ""
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem2.Elements.Add(TileItemElement5)
        Me.TileItem2.Id = 1
        Me.TileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem2.Name = "TileItem2"
        '
        'TileItem3
        '
        Me.TileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TileItem3.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TileItem3.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem3.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement6.Image = CType(resources.GetObject("TileItemElement6.Image"), System.Drawing.Image)
        TileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement6.Text = "Google Chrome"
        TileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem3.Elements.Add(TileItemElement6)
        Me.TileItem3.Id = 2
        Me.TileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem3.Name = "TileItem3"
        '
        'TileItem4
        '
        Me.TileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TileItem4.AppearanceItem.Normal.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.TileItem4.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black
        Me.TileItem4.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem4.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem4.AppearanceItem.Normal.Options.UseForeColor = True
        TileItemElement7.Image = CType(resources.GetObject("TileItemElement7.Image"), System.Drawing.Image)
        TileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement7.Text = "MetroTwit"
        TileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem4.Elements.Add(TileItemElement7)
        Me.TileItem4.Id = 3
        Me.TileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem4.Name = "TileItem4"
        '
        'TileItem5
        '
        Me.TileItem5.AppearanceItem.Normal.BackColor = System.Drawing.Color.AliceBlue
        Me.TileItem5.AppearanceItem.Normal.BorderColor = System.Drawing.Color.AliceBlue
        Me.TileItem5.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black
        Me.TileItem5.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem5.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem5.AppearanceItem.Normal.Options.UseForeColor = True
        TileItemElement8.Image = CType(resources.GetObject("TileItemElement8.Image"), System.Drawing.Image)
        TileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement8.Text = "Pokki Start menu"
        TileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem5.Elements.Add(TileItemElement8)
        Me.TileItem5.Id = 4
        Me.TileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem5.Name = "TileItem5"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(769, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 55)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(221, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(549, 55)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "User1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kozuka Gothic Pr6N R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(97, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ZUARO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kozuka Gothic Pro EL", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(92, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 48)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "store"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Store
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 84)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Store
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(837, 548)
        Me.Controls.Add(Me.Closable)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TileControl1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Store"
        Me.Text = "Store"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Closable As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem6 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem7 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem8 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup3 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem2 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem3 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem4 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem5 As DevExpress.XtraEditors.TileItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
