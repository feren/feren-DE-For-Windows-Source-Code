Public Class DeskBackground

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Opacity = 0.9
        OpenWallpaperDialog1.ShowDialog()
        Opacity = 1.0
    End Sub

    Private Sub OpenWallpaperDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenWallpaperDialog1.FileOk
        Try
            Desktop.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            LonghornDesktop.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            StartScreen.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            XPDesktop.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            PictureBox16.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            PictureBox16.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception
            MsgBox("Something went Wrong!", MsgBoxStyle.Exclamation, "Zuaro OS Settings")
        End Try
        My.Settings.DesktopBackground = "Custom"
        My.Settings.DesktopBackPath = OpenWallpaperDialog1.FileName
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
        Dim rkWallPaper As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        ' Return the current wallpaper path
        Try
            Desktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
            PictureBox16.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
            PictureBox16.BackgroundImageLayout = Desktop.BackgroundImageLayout
            XPDesktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
            LonghornDesktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
            Return
        Catch ex As Exception
            MsgBox("Something went Wrong!", MsgBoxStyle.Exclamation, "Zuaro OS Settings")
        End Try
        My.Settings.Save()
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        SettingsColorDialogDesktop.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub DeskBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Desktop.Cursor = Cursors.Default
        WelcomeScr.Cursor = Cursors.Default
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        zoswallpaper.BringToFront()
        Label14.ForeColor = Color.YellowGreen
        Label13.ForeColor = Color.Silver
        Label15.ForeColor = Color.Silver
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        customwallpaper.BringToFront()
        Label13.ForeColor = Color.YellowGreen
        Label14.ForeColor = Color.Silver
        Label15.ForeColor = Color.Silver
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        colorwallpaper.BringToFront()
        Label15.ForeColor = Color.YellowGreen
        Label14.ForeColor = Color.Silver
        Label13.ForeColor = Color.Silver
    End Sub

    Private Sub StretchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StretchToolStripMenuItem.Click
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
        StartScreen.BackgroundImageLayout = ImageLayout.Stretch
        XPDesktop.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox16.BackgroundImageLayout = ImageLayout.Stretch
        My.Settings.DesktopBackLayout = "Stretch"
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        Desktop.BackgroundImageLayout = ImageLayout.Zoom
        StartScreen.BackgroundImageLayout = ImageLayout.Zoom
        XPDesktop.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox16.BackgroundImageLayout = ImageLayout.Zoom
        My.Settings.DesktopBackLayout = "Zoom"
    End Sub

    Private Sub TileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileToolStripMenuItem.Click
        Desktop.BackgroundImageLayout = ImageLayout.Tile
        StartScreen.BackgroundImageLayout = ImageLayout.Tile
        XPDesktop.BackgroundImageLayout = ImageLayout.Tile
        PictureBox16.BackgroundImageLayout = ImageLayout.Tile
        My.Settings.DesktopBackLayout = "Tile"
    End Sub

    Private Sub zoswallpaper_Paint(sender As Object, e As PaintEventArgs) Handles zoswallpaper.Paint

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        My.Settings.DesktopBackground = "Default"
        Desktop.BackgroundImage = My.Resources.Home_1_Month_Activate_
        Desktop.BackgroundImageLayout = ImageLayout.Center
        Desktop.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        My.Settings.DesktopBackground = "Summer Days"
        Desktop.BackgroundImage = My.Resources.Summer_days
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        My.Settings.DesktopBackground = "Grass Droplet"
        Desktop.BackgroundImage = My.Resources._____55_II_1920_1080
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        My.Settings.DesktopBackground = "Grid"
        Desktop.BackgroundImage = My.Resources.Grid
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        My.Settings.DesktopBackground = "Perspective"
        Desktop.BackgroundImage = My.Resources.Perspective
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        My.Settings.DesktopBackground = "Triangular"
        Desktop.BackgroundImage = My.Resources.Triangular
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        My.Settings.DesktopBackground = "Within"
        Desktop.BackgroundImage = My.Resources.Within
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        My.Settings.DesktopBackground = "Lake"
        Desktop.BackgroundImage = My.Resources.lake_frost_by_zaz369_d6yek84
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        My.Settings.DesktopBackground = "Windows"
        Desktop.BackgroundImage = My.Resources.windows_7_reimagined_wallpaper_by_gifteddeviant_d566kgg
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        My.Settings.DesktopBackground = "67 II"
        Desktop.BackgroundImage = My.Resources._____67_II_1920_1080
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        My.Settings.DesktopBackground = "90 II"
        Desktop.BackgroundImage = My.Resources._____90_II_1920_1080
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        My.Settings.DesktopBackground = "23 II"
        Desktop.BackgroundImage = My.Resources._____23_II_1920_1080
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        My.Settings.DesktopBackground = "42 III"
        Desktop.BackgroundImage = My.Resources._____42_III_1920_1080
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        My.Settings.DesktopBackground = "47 III"
        Desktop.BackgroundImage = My.Resources._____47_III_1920_1080
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs) Handles PictureBox50.Click
        My.Settings.DesktopBackground = "81 III"
        Desktop.BackgroundImage = My.Resources._____81_III_1920_1080
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        My.Settings.DesktopBackground = "86 III"
        Desktop.BackgroundImage = My.Resources._____86_III_1920_1080
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        My.Settings.DesktopBackground = "96 II"
        Desktop.BackgroundImage = My.Resources._____96_II_1920_1080
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        My.Settings.DesktopBackground = "Kitten"
        Desktop.BackgroundImage = My.Resources.sleepy_kitten_by_amelka_wonka_kitty_d3ecixm
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click

    End Sub
End Class