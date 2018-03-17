Imports System.Net
Public Class StartScreen
    Dim st As PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Userimagebutton.Click
        DesktopOptionsTouch.Show()
        AppsMenu.Close()
    End Sub

    Private Sub Desktop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If AppsMenu.CheckBox1.Checked = True Then
            AppsMenu.Close()
        End If
    End Sub

    Private Sub Desktop_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Closable.Checked = False Then
            e.Cancel = True
            AdvancedMetroShutDownOptions.Show()
        ElseIf Closable.Checked = True Then
            e.Cancel = False
        End If
    End Sub

    Private Sub Desktop_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        AppsMenu.Close()
    End Sub

    Sub DarkenScreen()

    End Sub

    Sub ChangebaloonColour()
        Panel6.BackColor = My.Settings.MetroColour
        Panel7.BackColor = My.Settings.MetroColour
        Panel8.BackColor = My.Settings.MetroColour
    End Sub

    Private Sub Desktop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Power As PowerStatus = SystemInformation.PowerStatus
        BatteryLevel.Value = Power.BatteryLifePercent * 100
        If NetworkInformation.NetworkInterface.GetIsNetworkAvailable = True Then
            WIFIIcon.Image = My.Resources.Wifi_Icon
        Else
            WIFIIcon.Image = My.Resources.Wifi_Icon_5
        End If
        BatteryLevelUpdate()
        Timer2.Start()
        Timer1.Start()
        Userimagebutton.Image = System.Drawing.Image.FromFile(My.Settings.Userimage)
        PictureBox4.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Userimage)
        Label7.Text = My.Settings.UserName
        Label1.Text = My.Settings.UserName
        ChangebaloonColour()
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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

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
            AppsMenuTouch.Close()
        Else
            AppsMenuTouch.Show()
            AppsMenuTouch.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StepIndicator1.CurrentStep = StepIndicator1.CurrentStep + 1
        Panel5.Visible = True
        Button1.BackColor = Color.WhiteSmoke
        AppsMenu.Close()
        If StepIndicator1.CurrentStep = 2 Then
            StepIndicator1.CurrentStep = 0
            Panel5.Visible = False
            Button1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.Click
        AppsMenu.Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WIFIIcon.Click
        AppsMenu.Close()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        AppsMenu.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        AppsMenu.Close()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AppsMenu.Close()
    End Sub

    Private Sub Time_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time.Click
        AppsMenu.Close()
    End Sub

    Private Sub Panel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Click
        AppsMenu.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If NetworkInformation.NetworkInterface.GetIsNetworkAvailable = True Then
            WIFIIcon.BackgroundImage = My.Resources.Wifi_Icon
        Else
            WIFIIcon.BackgroundImage = My.Resources.Wifi_Icon_5
        End If
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AdvancedShutoff.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Panel6.Visible = False
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

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Panel7.Visible = False
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Panel8.Visible = False
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Process.Start("C:\Program Files (x86)\Avira\My Avira\Avira.OE.Systray.exe", " /showMiniGui")
    End Sub

    Private Sub PictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BackgroundPlus_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent)

    End Sub

    Private Sub CommandLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel8.Visible = False
    End Sub

    Private Sub Panel8_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

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

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
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

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class