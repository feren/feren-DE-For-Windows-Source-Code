Public Class NotepadForm
    Inherits Windows.Forms.Form
    Public DocumentName As String = "Untitled"
    Public DocumentPath As String

    'Code to run on the opnening of the main form(the program)
    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load the user settings from the last time it was opened
        Notepad.FileManipulation.LoadUserSettings()
        'Check if the program has been passed a path to open
        Notepad.FileManipulation.CheckCommandLine(EditorForm.txtMain)
    End Sub
    'Code to run on the closing of the main form
    Private Sub mainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Check if the document has been modified
        If CloseReason.UserClosing Then
            If EditorForm.txtMain.Modified = True Then
                'Ask the user if they want ro save the changes before closing
                Dim saveChanges As MsgBoxResult = MsgBox("Do you want to save the changes to " & DocumentName & "?", MsgBoxStyle.YesNoCancel, "Notepad")
                If saveChanges = MsgBoxResult.Cancel Then 'If cancel, then stop the shutdown process and allow the user to continue editing
                    e.Cancel = True
                    Return
                ElseIf saveChanges = MsgBoxResult.No Then 'If no, then continue on shutting the program down
                ElseIf saveChanges = MsgBoxResult.Yes Then 'If yes, then save the file, and shut down the program
                    Notepad.FileManipulation.Save(EditorForm.txtMain)
                End If
            Else 'if it hasn't, then "Houston we are clear for shutdown." :)
            End If
        End If
    End Sub
End Class