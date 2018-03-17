Public Class StoreDesktop

    Private Sub StoreDesktop_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.StoreIcon.Visible = False
    End Sub

    Private Sub StoreSplash_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel1.Hide()
        Timer1.Stop()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub StoreNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable Then
            NoConnection.Visible = False
        Else
            NoConnection.Visible = True
        End If
        Panel1.Dock = DockStyle.Fill
        Timer1.Start()
        Desktop.StoreIcon.Visible = True
        Checkinstallstates()
        Label3.Text = My.Settings.UserName
        If My.Settings.Userimage = "Default" Then
            If My.Settings.Userimage = "Default" Then
                PictureBox2.Image = My.Resources.login_8
                PictureBox42.Image = My.Resources.login_8
            End If
        Else
            PictureBox2.Image = System.Drawing.Image.FromFile(My.Settings.Userimage)
            PictureBox42.Image = System.Drawing.Image.FromFile(My.Settings.Userimage)
        End If
    End Sub

    Sub Checkinstallstates()
        If FileIO.FileSystem.FileExists("C:\Program Files\Google\Chrome\Application\") Or FileIO.FileSystem.FileExists("C:\Program Files (x86)\Google\Chrome\Application\") Then
            Button1.Visible = False
        End If
        If FileIO.FileSystem.FileExists("C:\Program Files\Internet Explorer\") Then
            Button2.Visible = False
        End If
    End Sub

    Private Sub TileItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs)
        YoutubeStoreApp.Show()
    End Sub

    Private Sub TileItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs)
        GoogleStoreApp.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TileItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs)
        AviraStoreWindows.Show()
    End Sub

    Private Sub TileItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs)
        MicrosoftThemes.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BD86BC3D0-1E27-7460-C0C8-A43A85BA6F44%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers/update2/installers/ChromeSetup.exe")
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click, Label4.Click
        WebBrowsers.BringToFront()
        backbtn.Visible = True
        skinbackbtn.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub StoreDesktop_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Desktop.Cursor = Cursors.Default
        WelcomeScr.Cursor = Cursors.Default
    End Sub

    Private Sub FrontPage_Paint(sender As Object, e As PaintEventArgs) Handles FrontPage.Paint

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click

    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Panel15_Paint(sender As Object, e As PaintEventArgs) Handles Panel15.Paint

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles backbtn.Click, skinbackbtn.Click
        FrontPage.BringToFront()
        backbtn.Visible = False
        skinbackbtn.Visible = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click, Label5.Click
        Antiviruses.BringToFront()
        backbtn.Visible = True
        skinbackbtn.Visible = True
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, Label6.Click
        everdaylife.BringToFront()
        backbtn.Visible = True
        skinbackbtn.Visible = True
    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        WebBrowser1.Navigate("http://download.bullguard.com/BullGuardDownloader.exe")
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click

    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click

    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        SkinnedTBar.Visible = False
        Panel26.Visible = False
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        SkinnedTBar.Visible = True
        SkinnedTBar.BackgroundImage = My.Resources.Skin1Dark
        Panel26.Visible = False
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        SkinnedTBar.Visible = True
        SkinnedTBar.BackgroundImage = My.Resources.Skin2Dark
        Panel26.Visible = False
    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged
        Label57.Text = Label3.Text
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click, PictureBox36.Click
        Panel26.Visible = True
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        Close()
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        SkinnedTBar.Visible = True
        SkinnedTBar.BackgroundImage = My.Resources.Skin3
        Panel26.Visible = False
    End Sub

    Private Sub SkinnedTBar_Paint(sender As Object, e As PaintEventArgs) Handles SkinnedTBar.Paint

    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        If My.Computer.Network.IsAvailable Then
            NoConnection.Visible = True
        Else
            NoConnection.Visible = False
        End If
    End Sub
End Class
