Public Class TouchSettings
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Closable.Checked = True Then
            e.Cancel = False
        ElseIf Closable.Checked = False Then
            Do Until Me.Location.Y = -Me.Height
                Me.Location = New Point(0, Me.Location.Y - 3)
            Loop
            Closable.Checked = True
            Me.Close()
        End If
    End Sub

    Sub Init() Handles Me.Load
        Me.Size = My.Computer.Screen.Bounds.Size
        Me.Location = New Point(0, -Me.Height)
        Me.Refresh()
    End Sub

    Sub Anim() Handles Me.Shown
        ' -- Falling
        Me.Refresh()
        Do Until Me.Location.Y = 0
            Me.Location = New Point(0, Me.Location.Y + 3)
        Loop
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        FirstBootKittenFox.Show()
        CType(FirstBootKittenFox.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://zuaroos.weebly.com/")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FirstBootKittenFox.Show()
        CType(FirstBootKittenFox.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://zuaroos.weebly.com/")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Panel2_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles About.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTab.Click
        About.Visible = True
        AboutTab.BackColor = Color.DimGray
        Wallpaper.Visible = False
        WallpaperTab.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WallpaperTab.Click
        About.Visible = False
        AboutTab.BackColor = Color.Transparent
        Wallpaper.Visible = True
        WallpaperTab.BackColor = Color.DimGray
    End Sub

    Private Sub TabControlPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlPanel1.Click

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenWallpaperDialog1.FileOk
        Try
            Desktop.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            LonghornDesktop.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            StartScreen.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            XPDesktop.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            PictureBox16.BackgroundImage = System.Drawing.Image.FromFile(OpenWallpaperDialog1.FileName)
            PictureBox16.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception
            MsgBox("Must Be a Picture!!!", MsgBoxStyle.Exclamation, "Zuaro OS Settings")
        End Try
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        OpenWallpaperDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
        Dim rkWallPaper As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        ' Return the current wallpaper path
        Desktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
        PictureBox16.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
        PictureBox16.BackgroundImageLayout = Desktop.BackgroundImageLayout
        XPDesktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
        LonghornDesktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
        Return
    End Sub

    Private Sub StretchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StretchToolStripMenuItem.Click
        Desktop.BackgroundImageLayout = ImageLayout.Stretch
        StartScreen.BackgroundImageLayout = ImageLayout.Stretch
        XPDesktop.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox16.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomToolStripMenuItem.Click
        Desktop.BackgroundImageLayout = ImageLayout.Zoom
        StartScreen.BackgroundImageLayout = ImageLayout.Zoom
        XPDesktop.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox16.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub TileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileToolStripMenuItem.Click
        Desktop.BackgroundImageLayout = ImageLayout.Tile
        StartScreen.BackgroundImageLayout = ImageLayout.Tile
        XPDesktop.BackgroundImageLayout = ImageLayout.Tile
        PictureBox16.BackgroundImageLayout = ImageLayout.Tile
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Wallpaper_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Wallpaper.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("rundll32.exe shell32.dll, Control_RunDLL desk.cpl,,2")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Shell("control.exe")
        Me.Close()
    End Sub

    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click

    End Sub

    Private Sub PictureBox43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox43.Click
        SettingsColorDialogDesktop.Show()
    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub
End Class