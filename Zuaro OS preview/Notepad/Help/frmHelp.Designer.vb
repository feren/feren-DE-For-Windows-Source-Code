<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.tbCntrlHelp = New System.Windows.Forms.TabControl()
        Me.tbFAQ = New System.Windows.Forms.TabPage()
        Me.rtfHelpDisplay = New System.Windows.Forms.RichTextBox()
        Me.tlstrpFAQs = New System.Windows.Forms.ToolStrip()
        Me.btnNotepadFAQ = New System.Windows.Forms.ToolStripButton()
        Me.btnEditingFAQ = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintingFAQ = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCntrlHelp.SuspendLayout()
        Me.tbFAQ.SuspendLayout()
        Me.tlstrpFAQs.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCntrlHelp
        '
        Me.tbCntrlHelp.Controls.Add(Me.tbFAQ)
        Me.tbCntrlHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCntrlHelp.Location = New System.Drawing.Point(0, 34)
        Me.tbCntrlHelp.Name = "tbCntrlHelp"
        Me.tbCntrlHelp.SelectedIndex = 0
        Me.tbCntrlHelp.Size = New System.Drawing.Size(655, 265)
        Me.tbCntrlHelp.TabIndex = 0
        '
        'tbFAQ
        '
        Me.tbFAQ.Controls.Add(Me.rtfHelpDisplay)
        Me.tbFAQ.Controls.Add(Me.tlstrpFAQs)
        Me.tbFAQ.Location = New System.Drawing.Point(4, 22)
        Me.tbFAQ.Name = "tbFAQ"
        Me.tbFAQ.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFAQ.Size = New System.Drawing.Size(647, 239)
        Me.tbFAQ.TabIndex = 0
        Me.tbFAQ.Text = "FAQ"
        Me.tbFAQ.ToolTipText = "Frequently Asked Questions"
        '
        'rtfHelpDisplay
        '
        Me.rtfHelpDisplay.BackColor = System.Drawing.Color.White
        Me.rtfHelpDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfHelpDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfHelpDisplay.Location = New System.Drawing.Point(56, 3)
        Me.rtfHelpDisplay.Name = "rtfHelpDisplay"
        Me.rtfHelpDisplay.ReadOnly = True
        Me.rtfHelpDisplay.Size = New System.Drawing.Size(588, 233)
        Me.rtfHelpDisplay.TabIndex = 0
        Me.rtfHelpDisplay.TabStop = False
        Me.rtfHelpDisplay.Text = "Please look at the FAQs on the left to try to solve you problem before sending a " & _
    "message to support."
        '
        'tlstrpFAQs
        '
        Me.tlstrpFAQs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tlstrpFAQs.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlstrpFAQs.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tlstrpFAQs.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlstrpFAQs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNotepadFAQ, Me.btnEditingFAQ, Me.btnPrintingFAQ})
        Me.tlstrpFAQs.Location = New System.Drawing.Point(3, 3)
        Me.tlstrpFAQs.Name = "tlstrpFAQs"
        Me.tlstrpFAQs.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tlstrpFAQs.Size = New System.Drawing.Size(53, 233)
        Me.tlstrpFAQs.TabIndex = 0
        Me.tlstrpFAQs.Text = "ToolStrip1"
        '
        'btnNotepadFAQ
        '
        Me.btnNotepadFAQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNotepadFAQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNotepadFAQ.Name = "btnNotepadFAQ"
        Me.btnNotepadFAQ.Size = New System.Drawing.Size(50, 17)
        Me.btnNotepadFAQ.Text = "Note"
        Me.btnNotepadFAQ.ToolTipText = "Notepad FAQ"
        '
        'btnEditingFAQ
        '
        Me.btnEditingFAQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEditingFAQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditingFAQ.Name = "btnEditingFAQ"
        Me.btnEditingFAQ.Size = New System.Drawing.Size(50, 17)
        Me.btnEditingFAQ.Text = "Editing"
        Me.btnEditingFAQ.ToolTipText = "Editing FAQ"
        '
        'btnPrintingFAQ
        '
        Me.btnPrintingFAQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPrintingFAQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintingFAQ.Name = "btnPrintingFAQ"
        Me.btnPrintingFAQ.Size = New System.Drawing.Size(50, 17)
        Me.btnPrintingFAQ.Text = "Printing"
        Me.btnPrintingFAQ.ToolTipText = "Printing FAQ"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(655, 34)
        Me.Panel3.TabIndex = 14
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Image = Global.Feren_OS_DE_preview.My.Resources.Resources.CloseNew
        Me.PictureBox5.Location = New System.Drawing.Point(624, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(39, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(577, 34)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Help"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbCntrlHelp)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHelp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tbCntrlHelp.ResumeLayout(False)
        Me.tbFAQ.ResumeLayout(False)
        Me.tbFAQ.PerformLayout()
        Me.tlstrpFAQs.ResumeLayout(False)
        Me.tlstrpFAQs.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbCntrlHelp As System.Windows.Forms.TabControl
    Friend WithEvents tbFAQ As System.Windows.Forms.TabPage
    Friend WithEvents tlstrpFAQs As System.Windows.Forms.ToolStrip
    Friend WithEvents rtfHelpDisplay As System.Windows.Forms.RichTextBox

    Friend WithEvents btnNotepadFAQ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditingFAQ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintingFAQ As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
