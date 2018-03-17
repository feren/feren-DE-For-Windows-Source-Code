Public Class Users

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub


    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel12.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        My.Settings.Userimage = "Default"
        Desktop.Userimagebutton.Image = My.Resources.login_8
        UserImage.Image = My.Resources.login_8
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox5.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        My.Settings.Userimage = OpenFileDialog1.FileName
        Desktop.Userimagebutton.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        UserImage.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub UserImage_Click(sender As Object, e As EventArgs) Handles UserImage.Click
        Panel12.Visible = True
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        My.Settings.UserName = TextBox9.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        My.Settings.Password = TextBox8.Text
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        UserFolderBrowserDialog.ShowDialog()
        My.Settings.UserFolder = UserFolderBrowserDialog.SelectedPath
        TextBox3.Text = UserFolderBrowserDialog.SelectedPath
    End Sub

    Private Sub UserFolderBrowserDialog_HelpRequest(sender As Object, e As EventArgs) Handles UserFolderBrowserDialog.HelpRequest

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        DocumentBrowserDialog.ShowDialog()
        My.Settings.DocsFolder = DocumentBrowserDialog.SelectedPath
        TextBox4.Text = DocumentBrowserDialog.SelectedPath
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        PictureBrowserDialog.ShowDialog()
        My.Settings.PicsFolder = PictureBrowserDialog.SelectedPath
        TextBox5.Text = PictureBrowserDialog.SelectedPath
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        MusicBrowserDialog.ShowDialog()
        My.Settings.MusicFolder = MusicBrowserDialog.SelectedPath
        TextBox6.Text = MusicBrowserDialog.SelectedPath
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        VideoBrowserDialog.ShowDialog()
        My.Settings.VidsFolder = VideoBrowserDialog.SelectedPath
        TextBox7.Text = VideoBrowserDialog.SelectedPath
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox9.Text = My.Settings.UserName
        TextBox8.Text = My.Settings.Password
        TextBox3.Text = My.Settings.UserFolder
        TextBox4.Text = My.Settings.DocsFolder
        TextBox5.Text = My.Settings.PicsFolder
        TextBox6.Text = My.Settings.MusicFolder
        TextBox7.Text = My.Settings.VidsFolder
    End Sub
End Class