<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotepadForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotepadForm))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.YellowGreen)
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.White
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.PictureBox1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(694, 450)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "TabItem1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(694, 423)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(664, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'NotepadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NotepadForm"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notepad for Zuaro OS"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
