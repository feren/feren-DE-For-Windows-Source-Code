<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorForm))
        Me.applicationRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.mainDocument = New System.Drawing.Printing.PrintDocument()
        Me.printDialog = New System.Windows.Forms.PrintDialog()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PathofFile = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cutTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.findTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.findNextTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.replaceTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.selectAllTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.wordWrapTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourChooserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutNotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'applicationRefreshTimer
        '
        Me.applicationRefreshTimer.Enabled = True
        '
        'pageSetupDialog
        '
        Me.pageSetupDialog.Document = Me.mainDocument
        '
        'mainDocument
        '
        Me.mainDocument.DocumentName = "Untitled"
        '
        'printDialog
        '
        Me.printDialog.Document = Me.mainDocument
        Me.printDialog.UseEXDialog = True
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.YellowGreen)
        '
        'txtMain
        '
        Me.txtMain.AllowDrop = True
        Me.txtMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMain.Location = New System.Drawing.Point(0, 58)
        Me.txtMain.MaxLength = 2147483647
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMain.Size = New System.Drawing.Size(822, 388)
        Me.txtMain.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 446)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 38)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(455, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 42)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(414, -3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 45)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(373, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 45)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(338, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 45)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PathofFile
        '
        Me.PathofFile.Location = New System.Drawing.Point(713, 35)
        Me.PathofFile.Name = "PathofFile"
        Me.PathofFile.Size = New System.Drawing.Size(97, 20)
        Me.PathofFile.TabIndex = 5
        Me.PathofFile.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormalToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 34)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(822, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.PageSetupToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(129, 6)
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(129, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.ToolStripMenuItem3, Me.cutTool, Me.copyTool, Me.pasteTool, Me.deleteTool, Me.ToolStripMenuItem4, Me.findTool, Me.findNextTool, Me.replaceTool, Me.ToolStripMenuItem5, Me.selectAllTool, Me.TimeDateToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(122, 6)
        '
        'cutTool
        '
        Me.cutTool.Name = "cutTool"
        Me.cutTool.Size = New System.Drawing.Size(125, 22)
        Me.cutTool.Text = "Cut"
        '
        'copyTool
        '
        Me.copyTool.Name = "copyTool"
        Me.copyTool.Size = New System.Drawing.Size(125, 22)
        Me.copyTool.Text = "Copy"
        '
        'pasteTool
        '
        Me.pasteTool.Name = "pasteTool"
        Me.pasteTool.Size = New System.Drawing.Size(125, 22)
        Me.pasteTool.Text = "Paste"
        '
        'deleteTool
        '
        Me.deleteTool.Name = "deleteTool"
        Me.deleteTool.Size = New System.Drawing.Size(125, 22)
        Me.deleteTool.Text = "Delete"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(122, 6)
        '
        'findTool
        '
        Me.findTool.Name = "findTool"
        Me.findTool.Size = New System.Drawing.Size(125, 22)
        Me.findTool.Text = "Find..."
        '
        'findNextTool
        '
        Me.findNextTool.Name = "findNextTool"
        Me.findNextTool.Size = New System.Drawing.Size(125, 22)
        Me.findNextTool.Text = "Find Next"
        '
        'replaceTool
        '
        Me.replaceTool.Name = "replaceTool"
        Me.replaceTool.Size = New System.Drawing.Size(125, 22)
        Me.replaceTool.Text = "Replace"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(122, 6)
        '
        'selectAllTool
        '
        Me.selectAllTool.Name = "selectAllTool"
        Me.selectAllTool.Size = New System.Drawing.Size(125, 22)
        Me.selectAllTool.Text = "Select All"
        '
        'TimeDateToolStripMenuItem
        '
        Me.TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem"
        Me.TimeDateToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.TimeDateToolStripMenuItem.Text = "Time/Date"
        '
        'FormalToolStripMenuItem
        '
        Me.FormalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.wordWrapTool, Me.FontToolStripMenuItem})
        Me.FormalToolStripMenuItem.Name = "FormalToolStripMenuItem"
        Me.FormalToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.FormalToolStripMenuItem.Text = "&Format"
        '
        'wordWrapTool
        '
        Me.wordWrapTool.Checked = True
        Me.wordWrapTool.CheckState = System.Windows.Forms.CheckState.Checked
        Me.wordWrapTool.Name = "wordWrapTool"
        Me.wordWrapTool.Size = New System.Drawing.Size(134, 22)
        Me.wordWrapTool.Text = "Word Wrap"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.FontToolStripMenuItem.Text = "Font..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColourChooserToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ColourChooserToolStripMenuItem
        '
        Me.ColourChooserToolStripMenuItem.Name = "ColourChooserToolStripMenuItem"
        Me.ColourChooserToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ColourChooserToolStripMenuItem.Text = "Colour Chooser"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.ToolStripMenuItem6, Me.AboutNotepadToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(151, 6)
        '
        'AboutNotepadToolStripMenuItem
        '
        Me.AboutNotepadToolStripMenuItem.Name = "AboutNotepadToolStripMenuItem"
        Me.AboutNotepadToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AboutNotepadToolStripMenuItem.Text = "About Notepad"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(822, 34)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Image = Global.Feren_OS_DE_preview.My.Resources.Resources.CloseNew
        Me.PictureBox5.Location = New System.Drawing.Point(791, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Kozuka Gothic Pro L", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(39, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Notes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Image = Global.Feren_OS_DE_preview.My.Resources.Resources.MaximizeNew
        Me.PictureBox6.Location = New System.Drawing.Point(760, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Image = Global.Feren_OS_DE_preview.My.Resources.Resources.MinimizeNew
        Me.PictureBox7.Location = New System.Drawing.Point(729, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 4
        Me.PictureBox7.TabStop = False
        '
        'EditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.PathofFile)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EditorForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents applicationRefreshTimer As System.Windows.Forms.Timer
    Friend WithEvents pageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents mainDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents printDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PathofFile As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cutTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents copyTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pasteTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents deleteTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents findTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents findNextTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents replaceTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents selectAllTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wordWrapTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColourChooserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutNotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox

End Class
