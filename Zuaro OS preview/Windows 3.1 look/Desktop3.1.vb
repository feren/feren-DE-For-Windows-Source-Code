Public Class Desktop31
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point

    Private Sub Desktop31_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Desktop3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager31.Show()
        If My.Settings.DesktopBackLayout = "Stretch" Then
            BackgroundImageLayout = ImageLayout.Stretch
        End If
        If My.Settings.DesktopBackLayout = "Zoom" Then
            BackgroundImageLayout = ImageLayout.Zoom
        End If
        If My.Settings.DesktopBackLayout = "Tile" Then
            BackgroundImageLayout = ImageLayout.Tile
        End If
        If My.Settings.DesktopBackground = "OS" Or My.Settings.DesktopBackground = "Custom" Then
            If My.Settings.DesktopBackground = "OS" Then
                ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
                Dim rkWallPaper As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
                Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
                rkWallPaper.Close()
                ' Return the current wallpaper path
                Me.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
                XPDesktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
                LonghornDesktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
                Return
            End If
            If My.Settings.DesktopBackground = "Custom" Then
                Try
                    Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.DesktopBackPath)
                Catch ex As Exception
                    Me.BackgroundImage = Nothing
                    Me.BackColor = Color.Black
                End Try
            End If
        End If
    End Sub

    Private Sub Desktop31_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        SendToBack()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Manager31.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        RiPlayer31.Show()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Panel1.Location.X
        Y = Control.MousePosition.Y - Panel1.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Panel1.Location = NewPoint
        End If
    End Sub
End Class