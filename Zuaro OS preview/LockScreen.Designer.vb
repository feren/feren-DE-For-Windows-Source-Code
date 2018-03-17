<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LockScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LockScreen))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Closable = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StepIndicator1 = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Closable
        '
        Me.Closable.AutoSize = True
        Me.Closable.Location = New System.Drawing.Point(-68, -12)
        Me.Closable.Name = "Closable"
        Me.Closable.Size = New System.Drawing.Size(81, 17)
        Me.Closable.TabIndex = 2
        Me.Closable.Text = "CheckBox1"
        Me.Closable.UseVisualStyleBackColor = True
        Me.Closable.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(726, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(110, 41)
        Me.Panel2.TabIndex = 8
        Me.Panel2.Visible = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(0, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 36)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Hibernate"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(800, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(230, 84)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'StepIndicator1
        '
        Me.StepIndicator1.CurrentStep = 0
        Me.StepIndicator1.Location = New System.Drawing.Point(1004, 310)
        Me.StepIndicator1.Name = "StepIndicator1"
        Me.StepIndicator1.Size = New System.Drawing.Size(400, 4)
        Me.StepIndicator1.TabIndex = 7
        Me.StepIndicator1.Text = "StepIndicator1"
        Me.StepIndicator1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 63)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "00 : 00"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(514, 277)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(199, 27)
        Me.Panel3.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(172, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(6, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(167, 23)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-273, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(621, 43)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "User1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OvalShape1
        '
        Me.OvalShape1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OvalShape1.BackColor = System.Drawing.Color.Transparent
        Me.OvalShape1.BackgroundImage = CType(resources.GetObject("OvalShape1.BackgroundImage"), System.Drawing.Image)
        Me.OvalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OvalShape1.BorderColor = System.Drawing.Color.Transparent
        Me.OvalShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.OvalShape1.FillColor = System.Drawing.Color.Transparent
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape1.Location = New System.Drawing.Point(354, 219)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.OvalShape1.Size = New System.Drawing.Size(141, 142)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(849, 581)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LockScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(849, 581)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StepIndicator1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Closable)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LockScreen"
        Me.Text = "Lock Screen"
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Closable As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StepIndicator1 As DevComponents.DotNetBar.Controls.StepIndicator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer

End Class
