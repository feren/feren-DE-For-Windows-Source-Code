Public Class Settings31Background

    Private Sub Settings31Background_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.DesktopBackground = "OS"
        ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
        Dim rkWallPaper As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        ' Return the current wallpaper path
        Desktop31.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
        PictureBox16.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
        PictureBox16.BackgroundImageLayout = Desktop31.BackgroundImageLayout
        Return
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Opacity = 0.9
        OpenWallpaperDialog1.ShowDialog()
        Opacity = 1.0
    End Sub

    Private Sub OpenWallpaperDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenWallpaperDialog1.FileOk
        Try
            Desktop31.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            PictureBox16.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            PictureBox16.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception
            MsgBox("Something went Wrong!", MsgBoxStyle.Exclamation, "Zuaro OS Settings")
        End Try
        My.Settings.DesktopBackground = "Custom"
        My.Settings.DesktopBackPath = OpenWallpaperDialog1.FileName
    End Sub

    Private Sub StretchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StretchToolStripMenuItem.Click
        Desktop31.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox16.BackgroundImageLayout = ImageLayout.Stretch
        My.Settings.DesktopBackLayout = "Stretch"
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        Desktop31.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox16.BackgroundImageLayout = ImageLayout.Zoom
        My.Settings.DesktopBackLayout = "Zoom"
    End Sub

    Private Sub TileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileToolStripMenuItem.Click
        Desktop31.BackgroundImageLayout = ImageLayout.Tile
        PictureBox16.BackgroundImageLayout = ImageLayout.Tile
        My.Settings.DesktopBackLayout = "Tile"
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        zoswallpaper.BringToFront()
        Label14.ForeColor = Color.Black
        Label13.ForeColor = Color.Silver
        Label15.ForeColor = Color.Silver
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        customwallpaper.BringToFront()
        Label13.ForeColor = Color.Black
        Label14.ForeColor = Color.Silver
        Label15.ForeColor = Color.Silver
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        colorwallpaper.BringToFront()
        Label15.ForeColor = Color.Black
        Label14.ForeColor = Color.Silver
        Label13.ForeColor = Color.Silver
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        SettingsColorDialogDesktop31.Show()
    End Sub
End Class