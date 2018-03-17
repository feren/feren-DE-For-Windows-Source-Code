<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColourChooser
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColourChooser))
        Me.txtClrPreview = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.clrText = New System.Windows.Forms.PictureBox()
        Me.btnChooseForeClr = New System.Windows.Forms.Button()
        CType(Me.clrText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtClrPreview
        '
        Me.txtClrPreview.Location = New System.Drawing.Point(183, 10)
        Me.txtClrPreview.Multiline = True
        Me.txtClrPreview.Name = "txtClrPreview"
        Me.txtClrPreview.ReadOnly = True
        Me.txtClrPreview.Size = New System.Drawing.Size(242, 27)
        Me.txtClrPreview.TabIndex = 3
        Me.txtClrPreview.Text = "Text"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(265, 44)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Close"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(346, 44)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 5
        Me.btnDefault.Text = "Reset"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'clrText
        '
        Me.clrText.BackColor = System.Drawing.Color.Black
        Me.clrText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clrText.Location = New System.Drawing.Point(99, 10)
        Me.clrText.Name = "clrText"
        Me.clrText.Size = New System.Drawing.Size(78, 27)
        Me.clrText.TabIndex = 1
        Me.clrText.TabStop = False
        '
        'btnChooseForeClr
        '
        Me.btnChooseForeClr.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnChooseForeClr.Location = New System.Drawing.Point(8, 10)
        Me.btnChooseForeClr.Name = "btnChooseForeClr"
        Me.btnChooseForeClr.Size = New System.Drawing.Size(85, 27)
        Me.btnChooseForeClr.TabIndex = 2
        Me.btnChooseForeClr.Text = "Change"
        Me.btnChooseForeClr.UseVisualStyleBackColor = True
        '
        'frmColourChooser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 72)
        Me.Controls.Add(Me.clrText)
        Me.Controls.Add(Me.btnChooseForeClr)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtClrPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColourChooser"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colour Chooser"
        Me.TopMost = True
        CType(Me.clrText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtClrPreview As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents clrText As System.Windows.Forms.PictureBox
    Friend WithEvents btnChooseForeClr As System.Windows.Forms.Button
End Class
