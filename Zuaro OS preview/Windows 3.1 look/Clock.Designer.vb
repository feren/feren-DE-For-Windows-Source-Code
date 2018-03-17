<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clock31
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clock31))
        Me.Time = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 48.0!)
        Me.Time.Location = New System.Drawing.Point(11, 80)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(273, 85)
        Me.Time.TabIndex = 0
        Me.Time.Text = "00:00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "00/00/0000"
        '
        'Timer1
        '
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(2, 207)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(509, 2)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(511, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 170)
        Me.Panel3.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 170)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 39)
        Me.Panel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(435, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "˅"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(458, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "˄"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(482, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "r"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Clock"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MonthCalendar1.Location = New System.Drawing.Point(281, 42)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 8
        '
        'Clock31
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(513, 209)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Time)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clock31"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
