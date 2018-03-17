<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Snappy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Snappy))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 377)
        Me.Panel5.TabIndex = 9
        Me.Panel5.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.Panel6.Location = New System.Drawing.Point(0, 372)
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
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(5, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(661, 5)
        Me.Panel8.TabIndex = 7
        Me.Panel8.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(5, 372)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(661, 5)
        Me.Panel9.TabIndex = 10
        Me.Panel9.Visible = False
        '
        'Panel10
        '
        Me.Panel10.Location = New System.Drawing.Point(0, 435)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 5)
        Me.Panel10.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(666, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 377)
        Me.Panel2.TabIndex = 8
        Me.Panel2.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Panel4.Location = New System.Drawing.Point(0, 372)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 5)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 5)
        Me.Panel3.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(661, 367)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Snappy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(671, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Snappy"
        Me.Panel5.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
