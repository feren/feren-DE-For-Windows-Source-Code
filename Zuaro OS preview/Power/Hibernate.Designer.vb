<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HibernationScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HibernationScreen))
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Interval = 5075
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'CircularProgress1
        '
        Me.CircularProgress1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(332, 187)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.White
        Me.CircularProgress1.Size = New System.Drawing.Size(178, 177)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 2
        Me.CircularProgress1.Value = 75
        '
        'HibernationScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(843, 550)
        Me.Controls.Add(Me.CircularProgress1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HibernationScreen"
        Me.Opacity = 0.01R
        Me.Text = "Shutting Down..."
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
End Class
