Public Class Logon

    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.Click

    End Sub

    Private Sub Logon_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Closable.Checked = True Then
            e.Cancel = False
        Else
            e.Cancel = True
            ShutoffScreen.Visible = True
        End If
    End Sub

    Private Sub Logon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShutoffScreen.Dock = DockStyle.Fill
        Timer1.Start()
        If SystemInformation.HighContrast = True Then
            BackColor = PictureBox2.BackColor
        End If
        usrname.Text = My.Settings.UserName
        If My.Settings.Userimage = "Default" Then
            If My.Settings.Userimage = "Default" Then
                OvalShape1.BackgroundImage = My.Resources.login_1
            End If
        Else
            OvalShape1.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Userimage)
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
            End If
        End If
        If My.Settings.DesktopBackground = "Custom" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.DesktopBackPath)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If TextBox1.Text = My.Settings.Password Then
            DesktopLoader.Show()
            Closable.Checked = True
            Me.Close()
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            TextBox1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TimeOfDay.Hour < 12 Then
            Label2.Text = Format(DateAndTime.TimeOfDay, "hh : mm") + " " + "AM"
        ElseIf TimeOfDay.Hour > 12 Then
            Label2.Text = Format(DateAndTime.TimeOfDay, "hh : mm") + " " + "PM"
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ShapeContainer1_Load(sender As Object, e As EventArgs) Handles ShapeContainer1.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles usrname.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ShutoffScreen.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShutoffScreen.Visible = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ShutDownScreen.Show()
        Closable.Checked = True
        TopMost = False
    End Sub

    Private Sub ShutoffScreen_VisibleChanged(sender As Object, e As EventArgs) Handles ShutoffScreen.VisibleChanged
        If ShutoffScreen.Visible = True Then
            Panel7.Visible = False
        Else
            Panel7.Visible = True
        End If
    End Sub

    Private Sub ZuaroOSZuroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZuaroOSZuroToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStripMenuItem1.ShowDropDown()
    End Sub
End Class