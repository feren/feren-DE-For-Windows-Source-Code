Public Class DeskTweaking

    Private Sub DeskTweaking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaskPreview.BackColor = Desktop.BackColor
        TaskPreview.BackgroundImage = Desktop.BackgroundImage
        TaskPreview.BackgroundImageLayout = Desktop.BackgroundImageLayout
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        OpenTaskbarImageDialog.ShowDialog()
    End Sub

    Private Sub OpenTaskbarImageDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenTaskbarImageDialog.FileOk
        Desktop.Panel1.BackgroundImage = System.Drawing.Image.FromFile(OpenTaskbarImageDialog.FileName)
        Desk.BackgroundImage = Desktop.Panel1.BackgroundImage
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        OpenAppButtonImageDialog.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Desktop.Panel1.BackgroundImageLayout = ImageLayout.Tile
        Desk.BackgroundImageLayout = ImageLayout.Tile
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Desktop.Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Desk.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub OpenAppButtonImageDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenAppButtonImageDialog.FileOk
        Desktop.AppButton.Image = System.Drawing.Image.FromFile(OpenAppButtonImageDialog.FileName)
        AppButton.Image = Desktop.AppButton.Image
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Desktop.AppButton.SizeMode = ImageLayout.Center
        AppButton.SizeMode = ImageLayout.Center
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Desktop.AppButton.SizeMode = ImageLayout.Stretch
        AppButton.SizeMode = ImageLayout.Stretch
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        OpenTopBarImageDialog.ShowDialog()
    End Sub

    Private Sub OpenTopBarImageDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenTopBarImageDialog.FileOk
        Desktop.Panel2.BackgroundImage = System.Drawing.Image.FromFile(OpenTopBarImageDialog.FileName)
        TopBar.BackgroundImage = Desktop.Panel2.BackgroundImage
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Desktop.Panel2.BackgroundImageLayout = ImageLayout.Tile
        TopBar.BackgroundImageLayout = ImageLayout.Tile
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Desktop.Panel2.BackgroundImageLayout = ImageLayout.Stretch
        TopBar.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        OpenTopBarButtonImageDialog.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenTrayImageDialog.ShowDialog()
    End Sub

    Private Sub OpenTrayImageDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenTrayImageDialog.FileOk
        Desktop.Panel9.BackgroundImage = System.Drawing.Image.FromFile(OpenTrayImageDialog.FileName)
        Tray.BackgroundImage = System.Drawing.Image.FromFile(OpenTrayImageDialog.FileName)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Desktop.Panel9.BackgroundImageLayout = ImageLayout.Tile
        Tray.BackgroundImageLayout = ImageLayout.Tile
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Desktop.Panel9.BackgroundImageLayout = ImageLayout.Stretch
        Tray.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
End Class