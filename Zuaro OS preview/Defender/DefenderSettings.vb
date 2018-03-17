Public Class DefenderSettings

    Private Sub DefenderSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Main.Location
        If My.Settings.AntivirusDB = "Internal" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        Main.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub DefenderSettings_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If My.Settings.AntivirusDB = "" Then
            My.Settings.AntivirusDB = "Internal"
            My.Settings.Save()
        Else
            My.Settings.AntivirusDB = ""
            My.Settings.Save()
        End If
    End Sub
End Class