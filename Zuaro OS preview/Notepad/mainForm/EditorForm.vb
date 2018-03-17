Public Class EditorForm
    Inherits Form
    Public DocumentName As String = "Untitled"
    Public DocumentPath As String

    Private Sub EditorForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.NotesIcon.Visible = False
    End Sub

    'Code to run on the opnening of the main form(the program)
    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load the user settings from the last time it was opened
        Notepad.FileManipulation.LoadUserSettings()
        'Check if the program has been passed a path to open
        Notepad.FileManipulation.CheckCommandLine(txtMain)
        Desktop.NotesIcon.Visible = True
    End Sub
    'Code to run on the closing of the main form
    Private Sub mainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Check if the document has been modified
        If CloseReason.UserClosing Then
            If txtMain.Modified = True Then
                'Ask the user if they want ro save the changes before closing
                Dim saveChanges As MsgBoxResult = MsgBox("Do you want to save the changes to " & DocumentName & "?", MsgBoxStyle.YesNoCancel, "Notepad")
                If saveChanges = MsgBoxResult.Cancel Then 'If cancel, then stop the shutdown process and allow the user to continue editing
                    e.Cancel = True
                    Return
                ElseIf saveChanges = MsgBoxResult.No Then 'If no, then continue on shutting the program down
                ElseIf saveChanges = MsgBoxResult.Yes Then 'If yes, then save the file, and shut down the program
                    Notepad.FileManipulation.Save(txtMain)
                End If
            Else 'if it hasn't, then "Houston we are clear for shutdown." :)
            End If
        End If

        'Save the current program settings
        Notepad.FileManipulation.SaveUserSettings()
        'End the program using the end statement to close everything opened by the program
        frmColourChooser.Close()
    End Sub

    'This code is run to update the user interface
    Private Sub applicationRefreshTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles applicationRefreshTimer.Tick

        'Run the check for the availibility of the cut,copy,delete buttons
        If txtMain.SelectionLength < 0 Then
            cutTool.Enabled = False
            copyTool.Enabled = False
            deleteTool.Enabled = False
        ElseIf txtMain.SelectionLength > 0 Then
            cutTool.Enabled = True
            copyTool.Enabled = True
            deleteTool.Enabled = True
        End If

        'Run the check for the availibility of the paste button
        If Clipboard.ContainsText Then
            pasteTool.Enabled = True
        Else
            pasteTool.Enabled = False
        End If

        'Run the check for the availibility of the find,findnext,replace,selectall buttons
        If txtMain.Text = Nothing Then
            findTool.Enabled = False
            findNextTool.Enabled = False
            replaceTool.Enabled = False
            selectAllTool.Enabled = False
        Else
            findTool.Enabled = True
            findNextTool.Enabled = True
            replaceTool.Enabled = True
            selectAllTool.Enabled = True
        End If
        'Set the printing settings to the name of the document
        mainDocument.DocumentName = DocumentName
        'Update the user interface by displaying the current document name by the editorform's title
        Label1.Text = "Note - " & DocumentName
    End Sub


    'File Menu button code
    'each button calls the sub it is assigned to from the Notepad namespace
    Private Sub newTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.FileManipulation.NewDocument(txtMain)
    End Sub
    Private Sub addFileTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddFile.Show()
    End Sub
    Private Sub openTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.FileManipulation.Open(txtMain)
    End Sub
    Private Sub saveTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.FileManipulation.Save(txtMain)
    End Sub
    Private Sub saveAsTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.FileManipulation.SaveAs(txtMain)
    End Sub
    'Printing code; does not yet print the colours selected by the user
    Private Sub pageSetupTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pageSetupDialog.ShowDialog()
    End Sub
    Private Sub printTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If printDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            mainDocument.Print()
        End If
    End Sub
    Private Sub mainDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles mainDocument.PrintPage
        e.Graphics.DrawString(txtMain.Text, txtMain.Font, Brushes.Black, 100, 100)
    End Sub
    Private Sub exitTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    'Edit Menu button code
    'each button calls the sub it is assigned to from the Notepad namespace
    Private Sub chooseClrTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmColourChooser.Show()
    End Sub
    Private Sub undoTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.Undo(txtMain)
    End Sub
    Private Sub cutTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.Cut(txtMain)
    End Sub
    Private Sub copyTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.Copy(txtMain)
    End Sub
    Private Sub pasteTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.Paste(txtMain)
    End Sub
    Private Sub deleteTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtMain.SelectedText = ""
    End Sub
    Private Sub selectAllTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.SelectAll(txtMain)
    End Sub
    Private Sub timeDateTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.insertDateTime(txtMain)
    End Sub
    Private Sub findTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        findReplaceForm.Show()
    End Sub
    Private Sub findNextTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        findReplaceForm.Show()
    End Sub
    Private Sub replaceTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        findReplaceForm.Show()
    End Sub

    'Format Menu button code
    'each button calls the sub it is assigned to from the Notepad namespace
    Private Sub wordWrapTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.ChangeWordWrap()
    End Sub
    Private Sub fontTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.ChooseFont(txtMain)
    End Sub

    'Help menu button code
    'Each button calls the form it is assigned to
    Private Sub helpTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmHelp.Show()
    End Sub
    Private Sub aboutTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAbout.Show()
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmColourChooser.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.FileManipulation.Save(txtMain)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.FileManipulation.NewDocument(txtMain)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.Cut(txtMain)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.Copy(txtMain)
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Notepad.Editing.Paste(txtMain)
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtMain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabControlPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtMain_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMain.TextChanged

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Notepad.FileManipulation.Save(txtMain)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If printDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            mainDocument.Print()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If MsgBox("Delete this note?", MsgBoxStyle.YesNo, "Note") = MsgBoxResult.Yes Then
            If Label1.Text = "Note - Untitled" Then
                txtMain.Text = ""
            Else
                My.Computer.FileSystem.DeleteFile(PathofFile.Text)
                txtMain.Modified = False
                Notepad.FileManipulation.NewDocument(txtMain)
                txtMain.Text = ""
            End If
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles findTool.Click
        findReplaceForm.Show()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Notepad.Editing.ChooseFont(txtMain)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Notepad.FileManipulation.NewDocument(txtMain)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Notepad.FileManipulation.Open(txtMain)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Notepad.FileManipulation.Save(txtMain)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Notepad.FileManipulation.SaveAs(txtMain)
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        pageSetupDialog.ShowDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If printDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            mainDocument.Print()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Notepad.Editing.Undo(txtMain)
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cutTool.Click
        Notepad.Editing.Cut(txtMain)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles copyTool.Click
        Notepad.Editing.Copy(txtMain)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pasteTool.Click
        Notepad.Editing.Paste(txtMain)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteTool.Click
        txtMain.SelectedText = ""
    End Sub

    Private Sub FindNextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles findNextTool.Click
        findReplaceForm.Show()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles replaceTool.Click
        findReplaceForm.Show()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectAllTool.Click
        Notepad.Editing.SelectAll(txtMain)
    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeDateToolStripMenuItem.Click
        Notepad.Editing.insertDateTime(txtMain)
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wordWrapTool.Click
        Notepad.Editing.ChangeWordWrap()
    End Sub

    Private Sub ColourChooserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColourChooserToolStripMenuItem.Click
        frmColourChooser.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click
        frmHelp.Show()
    End Sub

    Private Sub AboutNotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutNotepadToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub EditorForm_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Close()
    End Sub

    Private Sub EditorForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Desktop.Cursor = Cursors.Default
    End Sub
End Class