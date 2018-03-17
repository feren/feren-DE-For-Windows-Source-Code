<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainEmergency
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainEmergency))
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.detected = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.files = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox29 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Scanner = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Threats = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox30 = New System.Windows.Forms.PictureBox()
        Me.PictureBox31 = New System.Windows.Forms.PictureBox()
        Me.PictureBox32 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scanner.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Threats.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.White
        Me.ListBox2.ForeColor = System.Drawing.Color.Black
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 17
        Me.ListBox2.Location = New System.Drawing.Point(65, 13)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(714, 276)
        Me.ListBox2.TabIndex = 0
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox6.BackColor = System.Drawing.Color.YellowGreen
        Me.PictureBox6.Location = New System.Drawing.Point(81, 13)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 7)
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox5.Location = New System.Drawing.Point(83, 13)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(610, 7)
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.detected)
        Me.Panel2.Controls.Add(Me.total)
        Me.Panel2.Controls.Add(Me.files)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(7, 65)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 100)
        Me.Panel2.TabIndex = 2
        '
        'detected
        '
        Me.detected.AutoSize = True
        Me.detected.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.detected.Location = New System.Drawing.Point(159, 98)
        Me.detected.Name = "detected"
        Me.detected.Size = New System.Drawing.Size(18, 21)
        Me.detected.TabIndex = 5
        Me.detected.Text = "0"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.total.Location = New System.Drawing.Point(159, 67)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(18, 21)
        Me.total.TabIndex = 4
        Me.total.Text = "0"
        '
        'files
        '
        Me.files.AutoSize = True
        Me.files.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.files.Location = New System.Drawing.Point(159, 37)
        Me.files.Name = "files"
        Me.files.Size = New System.Drawing.Size(18, 21)
        Me.files.TabIndex = 3
        Me.files.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Infected Files: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Files: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Files Scanned: "
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(7, 233)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(758, 39)
        Me.TextBox1.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(191, 38)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBar1.Maximum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(535, 11)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.Path = "C:\"
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.PictureBox29)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 64)
        Me.Panel1.TabIndex = 17
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox8.Location = New System.Drawing.Point(762, 7)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox8.TabIndex = 9
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(778, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(85, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(197, 32)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Your PC is secure"
        '
        'PictureBox29
        '
        Me.PictureBox29.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.Shield_Green
        Me.PictureBox29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox29.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox29.Name = "PictureBox29"
        Me.PictureBox29.Size = New System.Drawing.Size(67, 58)
        Me.PictureBox29.TabIndex = 6
        Me.PictureBox29.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.Feren_OS_DE_preview.My.Resources.Resources.ZOS_Desk_White_new
        Me.Panel5.Controls.Add(Me.Button7)
        Me.Panel5.Controls.Add(Me.Button6)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Controls.Add(Me.Button8)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 136)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(791, 338)
        Me.Panel5.TabIndex = 19
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DimGray
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button7.Location = New System.Drawing.Point(595, 172)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(150, 138)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Settings"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button6.Location = New System.Drawing.Point(595, 28)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 138)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "About"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button4.Location = New System.Drawing.Point(320, 172)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(269, 138)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Auto Protection"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button5.Location = New System.Drawing.Point(45, 172)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(269, 138)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Threat list"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button3.Location = New System.Drawing.Point(320, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(269, 138)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Update"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button8.Location = New System.Drawing.Point(45, 28)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(269, 138)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Scan"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(791, 338)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Scanner
        '
        Me.Scanner.BackColor = System.Drawing.Color.White
        Me.Scanner.Controls.Add(Me.PictureBox7)
        Me.Scanner.Controls.Add(Me.PictureBox6)
        Me.Scanner.Controls.Add(Me.ProgressBar1)
        Me.Scanner.Controls.Add(Me.PictureBox5)
        Me.Scanner.Controls.Add(Me.TextBox1)
        Me.Scanner.Controls.Add(Me.Panel2)
        Me.Scanner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Scanner.Location = New System.Drawing.Point(0, 136)
        Me.Scanner.Name = "Scanner"
        Me.Scanner.Size = New System.Drawing.Size(791, 338)
        Me.Scanner.TabIndex = 20
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(55, 51)
        Me.PictureBox7.TabIndex = 5
        Me.PictureBox7.TabStop = False
        '
        'Threats
        '
        Me.Threats.BackColor = System.Drawing.Color.White
        Me.Threats.Controls.Add(Me.Button10)
        Me.Threats.Controls.Add(Me.Button9)
        Me.Threats.Controls.Add(Me.PictureBox9)
        Me.Threats.Controls.Add(Me.ListBox2)
        Me.Threats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Threats.ForeColor = System.Drawing.Color.Black
        Me.Threats.Location = New System.Drawing.Point(0, 136)
        Me.Threats.Name = "Threats"
        Me.Threats.Size = New System.Drawing.Size(791, 338)
        Me.Threats.TabIndex = 21
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(559, 296)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(117, 32)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "Remove selected"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(682, 296)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(97, 32)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "Remove All"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox9.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(55, 51)
        Me.PictureBox9.TabIndex = 6
        Me.PictureBox9.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Threats)
        Me.Panel6.Controls.Add(Me.Scanner)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Location = New System.Drawing.Point(57, 60)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(791, 521)
        Me.Panel6.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.PictureBox30)
        Me.Panel4.Controls.Add(Me.PictureBox31)
        Me.Panel4.Controls.Add(Me.PictureBox32)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(791, 72)
        Me.Panel4.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Kozuka Gothic Pr6N R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label13.Location = New System.Drawing.Point(86, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 26)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "ZUARO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kozuka Gothic Pro EL", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(93, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(168, 48)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "defender"
        '
        'PictureBox30
        '
        Me.PictureBox30.BackgroundImage = CType(resources.GetObject("PictureBox30.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox30.Location = New System.Drawing.Point(13, 7)
        Me.PictureBox30.Name = "PictureBox30"
        Me.PictureBox30.Size = New System.Drawing.Size(67, 58)
        Me.PictureBox30.TabIndex = 5
        Me.PictureBox30.TabStop = False
        '
        'PictureBox31
        '
        Me.PictureBox31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox31.Image = Global.Feren_OS_DE_preview.My.Resources.Resources.MinimizeNew
        Me.PictureBox31.Location = New System.Drawing.Point(705, 12)
        Me.PictureBox31.Name = "PictureBox31"
        Me.PictureBox31.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox31.TabIndex = 4
        Me.PictureBox31.TabStop = False
        '
        'PictureBox32
        '
        Me.PictureBox32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox32.Image = Global.Feren_OS_DE_preview.My.Resources.Resources.CloseNew
        Me.PictureBox32.Location = New System.Drawing.Point(745, 12)
        Me.PictureBox32.Name = "PictureBox32"
        Me.PictureBox32.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox32.TabIndex = 3
        Me.PictureBox32.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 474)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(791, 47)
        Me.Panel3.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(652, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Fix"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(13, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(307, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Nothing is wrong, if it is not broken, dont fix it!"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer3
        '
        Me.Timer3.Interval = 5
        '
        'MainEmergency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(904, 641)
        Me.Controls.Add(Me.Panel6)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainEmergency"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scanner.ResumeLayout(False)
        Me.Scanner.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Threats.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents detected As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents files As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox29 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Scanner As System.Windows.Forms.Panel
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Threats As System.Windows.Forms.Panel
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox30 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox31 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox32 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
