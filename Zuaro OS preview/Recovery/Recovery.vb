Public Class Recovery

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, Label2.Click
        If MessageBox.Show("ARE YOU SURE THAT YOU WANT TO RESET EVERYTHING ON ZUARO OS?  INSTALLED APPS, SAVED SETTINGS AND OTHER THINGS WILL BE LOST!   IT IS NOT UNDOABLE...", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            My.Settings.DesktopBackground = "Default"
            My.Settings.DesktopBackPath = ""
            My.Settings.DocsFolder = ""
            My.Settings.FirstBootDone = False
            My.Settings.FirstRunKittenFox = False
            My.Settings.KittenFoxHomepage = "kittenfoxspeeddial.weebly.com"
            My.Settings.KittenFoxStyle = "Default"
            My.Settings.MetroColour = DefaultBackColor
            My.Settings.MusicFolder = ""
            My.Settings.NotepadWordWrap = False
            My.Settings.Password = ""
            My.Settings.PicsFolder = ""
            My.Settings.UserFolder = ""
            My.Settings.Userimage = "Default"
            My.Settings.UserName = "User1"
            My.Settings.VidsFolder = ""
            ShowTaskbar.Show()
            MsgBox("Zuaro OS reset successful. Returned to default state. Click OK to exit...")
            My.Settings.Save()
            End
        End If
    End Sub
End Class