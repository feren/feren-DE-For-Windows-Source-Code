Public Class frmHelp
    Inherits Form
    'FAQCode
    Private Sub btnNotepadFAQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotepadFAQ.Click
        UncheckAllBtns()
        btnNotepadFAQ.Checked = True
        Notepad.FileManipulation.OpenRTFResource(My.Resources.ntpdHelpFile, rtfHelpDisplay)
    End Sub
    Private Sub btnEditingFAQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditingFAQ.Click
        UncheckAllBtns()
        btnEditingFAQ.Checked = True
        Notepad.FileManipulation.OpenRTFResource(My.Resources.editHelpFile, rtfHelpDisplay)
    End Sub
    Private Sub btnPrintingFAQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintingFAQ.Click
        UncheckAllBtns()
        btnPrintingFAQ.Checked = True
        Notepad.FileManipulation.OpenRTFResource(My.Resources.printingHelpFile, rtfHelpDisplay)
    End Sub
    Private Sub UncheckAllBtns()
        btnEditingFAQ.Checked = False
        btnPrintingFAQ.Checked = False
        btnNotepadFAQ.Checked = False
    End Sub

    Private Sub frmHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Close()
    End Sub
End Class