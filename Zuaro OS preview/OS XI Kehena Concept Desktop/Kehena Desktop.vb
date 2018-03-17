Public Class KehenaDesktop

    Private Sub KehenaDesktop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
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

    Private Sub BubbleBar1_ButtonClick(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleBar1.ButtonClick

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TimeOfDay.Hour < 12 Then
            Label9.Text = Format(DateAndTime.TimeOfDay, "hh:mm") + " " + "AM"
        ElseIf TimeOfDay.Hour > 12 Then
            Label9.Text = Format(DateAndTime.TimeOfDay, "hh:mm") + " " + "PM"
        End If
    End Sub

    Private Sub BubbleButton3_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton3.Click
        StoreDesktop.Show()
    End Sub

    Private Sub BubbleButton1_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton1.Click
        FirstBootKittenFox.Show()
    End Sub
End Class