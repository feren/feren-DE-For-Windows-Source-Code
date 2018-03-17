Public Class frmColourChooser
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
    Dim bckgrndClr As Color = EditorForm.txtMain.BackColor
    Dim TextClr As Color = EditorForm.txtMain.ForeColor

    Private Sub frmColourChooser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Set the colour of the textbox in editor form to the colours chosen
        EditorForm.txtMain.BackColor = bckgrndClr
        EditorForm.txtMain.ForeColor = TextClr
        'Close the form
    End Sub

    Private Sub frmColourChooser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load the preview panes with the proper colours
        clrText.BackColor = EditorForm.txtMain.ForeColor
        'Load the txtPreview with the proper colours
        txtClrPreview.ForeColor = TextClr
        txtClrPreview.BackColor = bckgrndClr
        'Load the font of the txtMain textbox
        txtClrPreview.Font = EditorForm.txtMain.Font
    End Sub

    Private Sub btnChooseBckgrnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Load the user-chosen background colour
        bckgrndClr = Notepad.Editing.ChooseColour()
        'Change the setting Background colour to the chosen colour
        My.Settings.NotepadBackgroundColour = bckgrndClr
        'Display the preview to the user
        txtClrPreview.BackColor = bckgrndClr
    End Sub
    Private Sub btnChooseForeClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseForeClr.Click
        'Load the user-chosen text colour
        TextClr = Notepad.Editing.ChooseColour()
        'Change the setting Textcolour to the chosen colour
        My.Settings.NotepadTextColour = TextClr
        'Display the preview to the user
        clrText.BackColor = TextClr
        txtClrPreview.ForeColor = TextClr
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Set the colour of the textbox in editor form to the colours chosen
        EditorForm.txtMain.BackColor = bckgrndClr
        EditorForm.txtMain.ForeColor = TextClr
        'Close the form
        Me.Close()
    End Sub
    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        'Load the default colours
        bckgrndClr = Color.White
        TextClr = Color.Black
        'Change the setting Background colour to the default colour
        My.Settings.NotepadBackgroundColour = bckgrndClr
        My.Settings.NotepadTextColour = TextClr
        'Display the preview to the user
        clrText.BackColor = TextClr
        txtClrPreview.BackColor = bckgrndClr
        txtClrPreview.ForeColor = TextClr
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Close the form
        Me.Close()
    End Sub
End Class