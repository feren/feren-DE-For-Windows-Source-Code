Imports System.Net
Public Class Windows7Desktop

    Private Sub Windows7Desktop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        startbtn.BackColor = My.Settings.MetroColour
        Timer1.Start()
        Timer2.Start()
        If My.Settings.Userimage = "Default" Then
            If My.Settings.Userimage = "Default" Then
                Userimagebutton.Image = My.Resources.login_8
            End If
        Else
            Userimagebutton.Image = System.Drawing.Image.FromFile(My.Settings.Userimage)
        End If
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim OriginalTime, RoundedDownTime As DateTime
        OriginalTime = TimeOfDay
        RoundedDownTime = OriginalTime.AddSeconds(-OriginalTime.Second)
        Dim Power As PowerStatus = SystemInformation.PowerStatus
        BatteryLevel.Value = Power.BatteryLifePercent * 100
        Time.Text = RoundedDownTime
        BatteryLevelUpdate()
    End Sub

    Sub BatteryLevelUpdate()
        If BatteryLevel.Value = 100 Or BatteryLevel.Value = 99 Or BatteryLevel.Value = 98 Or BatteryLevel.Value = 97 Or BatteryLevel.Value = 96 Or BatteryLevel.Value = 95 Or BatteryLevel.Value = 94 Or BatteryLevel.Value = 95 Or BatteryLevel.Value = 94 Or BatteryLevel.Value = 93 Or BatteryLevel.Value = 92 Or BatteryLevel.Value = 91 Or BatteryLevel.Value = 90 Or BatteryLevel.Value = 89 Or BatteryLevel.Value = 88 Or BatteryLevel.Value = 87 Or BatteryLevel.Value = 86 Then
            PictureBox3.BackgroundImage = My.Resources.Battery_Icon_1_High
        End If
        If BatteryLevel.Value = 85 Or BatteryLevel.Value = 84 Or BatteryLevel.Value = 83 Or BatteryLevel.Value = 82 Or BatteryLevel.Value = 81 Or BatteryLevel.Value = 80 Or BatteryLevel.Value = 79 Or BatteryLevel.Value = 78 Or BatteryLevel.Value = 77 Or BatteryLevel.Value = 76 Or BatteryLevel.Value = 75 Or BatteryLevel.Value = 74 Or BatteryLevel.Value = 73 Or BatteryLevel.Value = 74 Or BatteryLevel.Value = 73 Or BatteryLevel.Value = 72 Or BatteryLevel.Value = 71 Or BatteryLevel.Value = 70 Or BatteryLevel.Value = 69 Or BatteryLevel.Value = 68 Or BatteryLevel.Value = 67 Or BatteryLevel.Value = 66 Then
            PictureBox3.BackgroundImage = My.Resources.Battery_Icon_2
        End If
        If BatteryLevel.Value = 65 Or BatteryLevel.Value = 64 Or BatteryLevel.Value = 63 Or BatteryLevel.Value = 62 Or BatteryLevel.Value = 61 Or BatteryLevel.Value = 60 Or BatteryLevel.Value = 59 Or BatteryLevel.Value = 58 Or BatteryLevel.Value = 57 Or BatteryLevel.Value = 56 Or BatteryLevel.Value = 55 Or BatteryLevel.Value = 54 Or BatteryLevel.Value = 53 Or BatteryLevel.Value = 52 Or BatteryLevel.Value = 51 Then
            PictureBox3.BackgroundImage = My.Resources.Battery_Icon_3
        End If
        If BatteryLevel.Value = 50 Or BatteryLevel.Value = 49 Or BatteryLevel.Value = 48 Or BatteryLevel.Value = 47 Or BatteryLevel.Value = 46 Or BatteryLevel.Value = 45 Or BatteryLevel.Value = 44 Or BatteryLevel.Value = 43 Or BatteryLevel.Value = 42 Or BatteryLevel.Value = 41 Or BatteryLevel.Value = 40 Or BatteryLevel.Value = 39 Or BatteryLevel.Value = 38 Or BatteryLevel.Value = 37 Or BatteryLevel.Value = 36 Then
            PictureBox3.BackgroundImage = My.Resources.Battery_Icon_4
        End If
        If BatteryLevel.Value = 35 Or BatteryLevel.Value = 34 Or BatteryLevel.Value = 33 Or BatteryLevel.Value = 32 Or BatteryLevel.Value = 31 Or BatteryLevel.Value = 30 Or BatteryLevel.Value = 29 Or BatteryLevel.Value = 28 Or BatteryLevel.Value = 27 Or BatteryLevel.Value = 26 Or BatteryLevel.Value = 25 Or BatteryLevel.Value = 24 Or BatteryLevel.Value = 23 Or BatteryLevel.Value = 22 Or BatteryLevel.Value = 21 Or BatteryLevel.Value = 20 Or BatteryLevel.Value = 19 Then
            PictureBox3.BackgroundImage = My.Resources.Battery_Icon_5
        End If
        If BatteryLevel.Value = 18 Or BatteryLevel.Value = 17 Or BatteryLevel.Value = 16 Or BatteryLevel.Value = 15 Or BatteryLevel.Value = 14 Or BatteryLevel.Value = 13 Or BatteryLevel.Value = 12 Or BatteryLevel.Value = 11 Or BatteryLevel.Value = 10 Or BatteryLevel.Value = 9 Or BatteryLevel.Value = 8 Then
            PictureBox3.BackgroundImage = My.Resources.Battery_Icon_6
        End If
        If BatteryLevel.Value = 7 Or BatteryLevel.Value = 6 Or BatteryLevel.Value = 5 Or BatteryLevel.Value = 4 Or BatteryLevel.Value = 3 Or BatteryLevel.Value = 2 Or BatteryLevel.Value = 1 Then
            PictureBox3.BackgroundImage = My.Resources.Battery_Icon_7_Low
        End If
        If BatteryLevel.Value = 1 Or BatteryLevel.Value = 0 Then
            DeadBattery.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If NetworkInformation.NetworkInterface.GetIsNetworkAvailable = True Then
            WIFIIcon.BackgroundImage = My.Resources.Wifi_Icon
        Else
            WIFIIcon.BackgroundImage = My.Resources.Wifi_Icon_5
        End If
    End Sub

    Private Sub WIFIIcon_Click(sender As Object, e As EventArgs) Handles WIFIIcon.Click

    End Sub

    Private Sub startbtn_Click(sender As Object, e As EventArgs) Handles startbtn.Click
        Startmenu.Show()
    End Sub
End Class