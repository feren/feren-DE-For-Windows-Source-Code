<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowsApps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WindowsApps))
        Me.AxWebBrowser1 = New AxSHDocVw.AxWebBrowser()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AxWebBrowser2 = New AxSHDocVw.AxWebBrowser()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.AxWebBrowser2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWebBrowser1
        '
        Me.AxWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWebBrowser1.Enabled = True
        Me.AxWebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.AxWebBrowser1.OcxState = CType(resources.GetObject("AxWebBrowser1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWebBrowser1.Size = New System.Drawing.Size(734, 464)
        Me.AxWebBrowser1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(748, 496)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AxWebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(740, 470)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "System Programs Folder"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AxWebBrowser2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(740, 470)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User Programs Folder"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'AxWebBrowser2
        '
        Me.AxWebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWebBrowser2.Enabled = True
        Me.AxWebBrowser2.Location = New System.Drawing.Point(3, 3)
        Me.AxWebBrowser2.OcxState = CType(resources.GetObject("AxWebBrowser2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWebBrowser2.Size = New System.Drawing.Size(734, 464)
        Me.AxWebBrowser2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(721, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'WindowsApps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 496)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WindowsApps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Apps"
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.AxWebBrowser2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxWebBrowser1 As AxSHDocVw.AxWebBrowser
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents AxWebBrowser2 As AxSHDocVw.AxWebBrowser
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
