Imports System.Net
Imports System.Globalization
Public Class Desktop
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point
    Dim st As PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Userimagebutton.Click

    End Sub

    Private Sub Desktop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If Panel10.Visible = True Then
            Panel10.Visible = False
        End If
        If Panel6.Visible = True Then
            Panel6.Visible = False
        End If
        If Panel15.Visible = True Then
            Panel15.Visible = False
        End If
        If AppsMenu.CheckBox1.Checked = True Then
            AppsMenu.Close()
        End If
        SendToBack()
    End Sub

    Private Sub Desktop_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Closable.Checked = False Then
            e.Cancel = True
            AdvancedShutoff.Show()
        ElseIf Closable.Checked = True Then
            e.Cancel = False
        End If
    End Sub

    Private Sub Desktop_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        If AppsMenu.CheckBox1.Checked = True Then
            AppsMenu.Close()
        End If
        SendToBack()
    End Sub

    Sub DarkenScreen()

    End Sub

    Sub StartExplorer()
        Panel1.Visible = True
        Panel2.Visible = True
    End Sub

    Private Sub Desktop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clock_gadget.Show(Me)
        search_gadget.Show(Me)
        If My.Settings.AntivirusLiveProtection = True Then
            PictureBox11.BackgroundImage = My.Resources.Switch_on
            AutoProtection.Checked = True
        Else
            PictureBox11.BackgroundImage = My.Resources.Switch_off
            AutoProtection.Checked = False
        End If
        Label3.Text = My.Settings.UserName
        Dim dt As Date = Date.Today
        Label4.Text = dt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
        Loading.Start()
        If My.Settings.Defenderon = True Then
            Main.Show()
            Main.Hide()
        Else
            PictureBox9.Image = My.Resources.Shield
            MusicName.Text = "Defender is off. Click to turn it on."
        End If
        WelcomeScr.Show()
        Dim Power As PowerStatus = SystemInformation.PowerStatus
        BatteryLevel.Value = Power.BatteryLifePercent * 100
        If My.Computer.Network.IsAvailable Then
            WIFIIcon.Image = My.Resources.Wifi_Icon
        Else
            WIFIIcon.Image = My.Resources.Wifi_Icon_5
        End If
        BatteryLevelUpdate()
        If My.Settings.DesktopBackground = "OS" Or My.Settings.DesktopBackground = "Custom" Then
            If My.Settings.DesktopBackground = "OS" Then
                ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
                Dim rkWallPaper As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
                Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
                rkWallPaper.Close()
                ' Return the current wallpaper path
                Me.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
                Toasts.Show(Me)
                Toasts.Label3.Text = "You are logged in as " + My.Settings.UserName
                If My.Settings.Userimage = "Default" Then
                    If My.Settings.Userimage = "Default" Then
                        Toasts.PictureBox2.BackgroundImage = My.Resources.login_8
                    End If
                Else
                    Toasts.PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Userimage)
                End If
                Toasts.Toast1.Visible = True
                XPDesktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
                LonghornDesktop.BackgroundImage = System.Drawing.Image.FromFile(WallpaperPath)
                Return
            End If
            If My.Settings.DesktopBackground = "Custom" Then
                Try
                    Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.DesktopBackPath)
                    Toasts.Show(Me)
                    Toasts.Label3.Text = "You are logged in as " + My.Settings.UserName
                    If My.Settings.Userimage = "Default" Then
                        If My.Settings.Userimage = "Default" Then
                            Toasts.PictureBox2.BackgroundImage = My.Resources.login_8
                        End If
                    Else
                        Toasts.PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Userimage)
                    End If
                    Toasts.Toast1.Visible = True
                Catch ex As Exception
                    Me.BackgroundImage = PictureBox11.ErrorImage
                    Me.BackgroundImageLayout = ImageLayout.None
                    Me.BackColor = Color.Black
                    Toasts.Show(Me)
                    Toasts.Label3.Text = "You are logged in as " + My.Settings.UserName
                    If My.Settings.Userimage = "Default" Then
                        If My.Settings.Userimage = "Default" Then
                            Toasts.PictureBox2.BackgroundImage = My.Resources.login_8
                        End If
                    Else
                        Toasts.PictureBox2.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Userimage)
                    End If
                    Toasts.Toast1.Visible = True
                End Try
            End If
        End If
        Timer2.Start()
        Timer1.Start()
        If My.Settings.Userimage = "Default" Then
            If My.Settings.Userimage = "Default" Then
                Userimagebutton.Image = My.Resources.login_8
                PictureBox22.BackgroundImage = My.Resources.login_8
            End If
        Else
            Userimagebutton.Image = System.Drawing.Image.FromFile(My.Settings.Userimage)
            PictureBox22.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Userimage)
        End If
        Label1.Text = My.Settings.UserName
        If My.Settings.DesktopBackLayout = "Stretch" Then
            BackgroundImageLayout = ImageLayout.Stretch
        End If
        If My.Settings.DesktopBackLayout = "Zoom" Then
            BackgroundImageLayout = ImageLayout.Zoom
        End If
        If My.Settings.DesktopBackLayout = "Tile" Then
            BackgroundImageLayout = ImageLayout.Tile
        End If
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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buildtag.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim OriginalTime, RoundedDownTime As DateTime
        OriginalTime = TimeOfDay
        RoundedDownTime = OriginalTime.AddSeconds(-OriginalTime.Second)
        Dim Power As PowerStatus = SystemInformation.PowerStatus
        BatteryLevel.Value = Power.BatteryLifePercent * 100
        Time.Text = RoundedDownTime
        BatteryLevelUpdate()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppButton.Click
        If AppsMenu.CheckBox1.Checked = True Then
            AppsMenu.Close()
        Else
            AppsMenu.Show()
            AppsMenu.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.Click
        AppsMenu.Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WIFIIcon.Click
        If Panel16.Visible = False Then
            Panel16.Visible = True
        Else
            Panel16.Visible = False
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If Panel15.Visible = False Then
            Panel15.Visible = True
        Else
            Panel15.Visible = False
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        AppsMenu.Close()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AppsMenu.Close()
    End Sub

    Private Sub Time_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AppsMenu.Close()
    End Sub

    Private Sub Panel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Click
        AppsMenu.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If My.Computer.Network.IsAvailable Then
            If Wifi.Checked = True Then
            Else
                If Toasts.Toast1.Visible = True Then
                    Toasts.Label6.Text = "Wifi has been successfully established"
                    Toasts.PictureBox4.BackgroundImage = My.Resources.Wifi_Icon
                    Toasts.Toast2.Visible = True
                Else
                    Toasts.Label3.Text = "Wifi has been successfully established"
                    Toasts.PictureBox2.BackgroundImage = My.Resources.Wifi_Icon
                    Toasts.Toast1.Visible = True
                End If
            End If
            Label18.Text = "Connected"
            Label18.ForeColor = Color.OliveDrab
            PictureBox18.BackgroundImage = My.Resources._9_Beta__236_
            WIFIIcon.Image = My.Resources.Wifi_Icon
            Wifi.Checked = True
        Else
            If Wifi.Checked = False Then
            Else
                If Toasts.Toast1.Visible = True Then
                    Toasts.Label6.Text = "Wifi has been lost"
                    Toasts.PictureBox4.BackgroundImage = My.Resources.Wifi_Icon_5
                    Toasts.Toast2.Visible = True
                Else
                    Toasts.Label3.Text = "Wifi has been lost"
                    Toasts.PictureBox2.BackgroundImage = My.Resources.Wifi_Icon_5
                    Toasts.Toast1.Visible = True
                End If
                WIFIIcon.Image = My.Resources.Wifi_Icon_5
                Wifi.Checked = False
            End If
            Label18.Text = "Not Connected"
            Label18.ForeColor = Color.Red
            PictureBox18.BackgroundImage = My.Resources._9_Beta__231_
        End If
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AdvancedShutoff.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ZOSAssistantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZOSAssistantToolStripMenuItem.Click
        ZOS_voice.Show()
        ZOS_voice.BringToFront()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ZOS_voice.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If Panel6.Visible = True Then
            Panel6.Visible = False
        Else
            Panel6.Visible = True
        End If
    End Sub

    Private Sub PictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BackgroundPlus_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent)

    End Sub

    Private Sub Panel8_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel10_MouseLeave(sender As Object, e As EventArgs)
        Panel10.Visible = False
    End Sub

    Private Sub Panel10_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        RiPlayer.AxWindowsMediaPlayer1.Ctlcontrols.play()
        Label12.Visible = False
        Label15.Visible = True
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        RiPlayer.AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Label12.Visible = True
        Label15.Visible = False
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RiPlayer.Show()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.MouseDown
        RiPlayer.AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub Label14_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label14.MouseDown
        RiPlayer.AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub Label14_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label14.MouseUp
        RiPlayer.AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Label13_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label13.MouseUp
        RiPlayer.AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub KittenFoxIcon_Click(sender As Object, e As EventArgs) Handles KittenFoxIcon.Click
        KittenFox.BringToFront()
        KittenFox.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ExplorerIcon_Click(sender As Object, e As EventArgs) Handles ExplorerIcon.Click

    End Sub

    Private Sub RiPlayerIcon_Click(sender As Object, e As EventArgs) Handles RiPlayerIcon.Click
        RiPlayer.BringToFront()
        RiPlayer.WindowState = FormWindowState.Normal
    End Sub

    Private Sub StoreIcon_Click(sender As Object, e As EventArgs) Handles StoreIcon.Click
        StoreDesktop.BringToFront()
        StoreDesktop.WindowState = FormWindowState.Normal
    End Sub

    Private Sub GalleryIcon_Click(sender As Object, e As EventArgs) Handles GalleryIcon.Click

    End Sub

    Private Sub SettingsIcon_Click(sender As Object, e As EventArgs) Handles SettingsIcon.Click
        Settings.BringToFront()
        Settings.WindowState = FormWindowState.Normal
    End Sub

    Private Sub NotesIcon_Click(sender As Object, e As EventArgs) Handles NotesIcon.Click
        EditorForm.BringToFront()
        EditorForm.WindowState = FormWindowState.Normal
    End Sub

    Private Sub LookChangerIcon_Click(sender As Object, e As EventArgs) Handles LookChangerIcon.Click

    End Sub

    Private Sub TerminalIcon_Click(sender As Object, e As EventArgs) Handles TerminalIcon.Click

    End Sub

    Private Sub Desktop_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        SendToBack()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs)
        KittenFoxsettings.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        KittenFoxsettings.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        Dim FFox As New KittenFox
        FFox.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        KittenFox.Close()
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        KittenFox.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        KittenFox.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Explorermenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Explorermenu.Opening

    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LockWorkstationToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PowerOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem7_DropDownOpened(sender As Object, e As EventArgs)
        CtrlAltDel.Show()
    End Sub

    Private Sub ToolStripMenuItem7_DropDownOpening(sender As Object, e As EventArgs)
        CtrlAltDel.Show()
    End Sub

    Private Sub Desktop_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged

    End Sub

    Private Sub PictureBox9_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then

        End If
    End Sub

    Private Sub Loading_Tick(sender As Object, e As EventArgs) Handles Loading.Tick
        StartExplorer()
        Loading.Stop()
    End Sub

    Private Sub Label13_Click(sender As Object, e As MouseEventArgs) Handles Label13.MouseDown

    End Sub

    Private Sub Time_Click_1(sender As Object, e As EventArgs) Handles Time.Click, Label4.Click
        Panel5.Visible = True
        Stepindicator1.Checked = True
    End Sub

    Private Sub Panel5_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Panel5.DateChanged

    End Sub

    Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs) Handles Panel5.MouseLeave
        Stepindicator1.Checked = False
        Panel5.Visible = False
        Panel2.Visible = True
        AppsMenu.Close()
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        Panel10.Visible = True
    End Sub

    Private Sub Panel10_MouseHover(sender As Object, e As EventArgs) Handles Panel10.MouseHover

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles Userbutton.Click
        DesktopOptions.Show()
        AppsMenu.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Main.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        If Label10.Text = "Turn Off Defender" Then
            Main.Close()
            Engine.Close()
            PictureBox9.Image = My.Resources.Shield
            My.Settings.Defenderon = False
            Label5.Text = "Defender is off"
            PictureBox10.Image = My.Resources.Shield
            Label6.Enabled = False
            Label7.Enabled = False
            Label16.Enabled = False
            Label10.Text = "Turn on Defender"
            Panel7.BackColor = Color.Silver
            PictureBox11.Visible = False
        ElseIf Label10.Text = "Turn on Defender" Then
            Main.Show()
            Main.Hide()
            My.Settings.Defenderon = True
            Label6.Enabled = True
            Label7.Enabled = True
            Label16.Enabled = True
            Label10.Text = "Turn Off Defender"
            PictureBox11.Visible = True
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If AutoProtection.Checked = True Then
            PictureBox11.BackgroundImage = My.Resources.Switch_off
            AutoProtection.Checked = False
            Main.FileSystemWatcher1.EnableRaisingEvents = False
            Main.realtime.Text = "Real-time Disabled"
            My.Settings.AntivirusLiveProtection = False
            Main.livedisabled()
            Main.Button11.Enabled = True
            Main.Button12.Enabled = False
        ElseIf AutoProtection.Checked = False Then
            PictureBox11.BackgroundImage = My.Resources.Switch_on
            AutoProtection.Checked = True
            Main.FileSystemWatcher1.EnableRaisingEvents = True
            Main.realtime.Text = "Real-time Enabled"
            My.Settings.AntivirusLiveProtection = True
            If Main.ListBox2.Items.Count = 0 Then
                Main.Safe()
            Else
                Main.infected()
            End If
            Main.Button11.Enabled = False
            Main.Button12.Enabled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("shell:::{38A98528-6CBF-4CA9-8DC0-B1E1D10F7B1B}")
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        LogOffScreen.Show()
    End Sub

    Private Sub Panel17_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel17.MouseDown, Userimagebutton.MouseDown, Label3.MouseDown
        X = Control.MousePosition.X - Panel18.Location.X
        Y = Control.MousePosition.Y - Panel18.Location.Y
    End Sub

    Private Sub Panel17_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel17.MouseMove, Userimagebutton.MouseMove, Label3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Panel18.Location = NewPoint
        End If
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown, Panel2.MouseDown, Panel5.MouseDown
        X = Control.MousePosition.X - Panel18.Location.X
        Y = Control.MousePosition.Y - Panel18.Location.Y
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove, Label4.MouseMove, Panel5.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Panel18.Location = NewPoint
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub PictureBox12_Click_1(sender As Object, e As EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Desktop_addons.Show()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click

    End Sub

    Private Sub ChangeImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeImageToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox23.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub BubbleButton7_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton7.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Deskmenu.Hide()
        Cursor = Cursors.AppStarting
        DeskBackground.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Deskmenu.Hide()
        Panel1.Dock = DockStyle.Bottom
        Button3.Enabled = False
        Button4.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Deskmenu.Hide()
        Panel1.Dock = DockStyle.Top
        Button3.Enabled = True
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Deskmenu.Hide()
        LockScreen.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Deskmenu.Hide()
        Me.Refresh()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Deskmenu.Hide()
        ShutOffOptions.Show()
    End Sub

    Private Sub Desktop_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            X = Control.MousePosition.X - Deskmenu.Location.X
            Y = Control.MousePosition.Y - Deskmenu.Location.Y
            Deskmenu.Show()
        End If
    End Sub
End Class