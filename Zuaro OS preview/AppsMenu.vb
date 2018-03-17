Imports DevComponents.DotNetBar

Public Class AppsMenu

    Private Sub AppsMenu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Desktop.AppButton.BackgroundImage = Nothing
    End Sub

    Private Sub AppsMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        Desktop.AppButton.BackgroundImage = My.Resources.Taskbar
        CheckBox1.Checked = True
        UserNameToolStripMenuItem.Text = My.Settings.UserName
        If Desktop.Panel1.Dock = DockStyle.Top Then
            Panel2.Location = Panel5.Location
        End If
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub AppsMenu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Desktop.Cursor = Cursors.AppStarting
        KittenFox.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Desktop.Cursor = Cursors.AppStarting
        KittenFox.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        MsgBox("Sorry, Not yet implemented!", MsgBoxStyle.Critical)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        MsgBox("Sorry, Not yet implemented!", MsgBoxStyle.Critical)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Desktop.Cursor = Cursors.AppStarting
        Settings.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Desktop.Cursor = Cursors.AppStarting
        Settings.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Desktop.Cursor = Cursors.AppStarting
        EditorForm.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Desktop.Cursor = Cursors.AppStarting
        EditorForm.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Clock.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Clock.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Text = "Search Apps..."
            TextBox1.SelectAll()
        End If
        If TextBox1.Text = "KittenFox" Or TextBox1.Text = "K" Or TextBox1.Text = "Ki" Or TextBox1.Text = "Kit" Or TextBox1.Text = "Kitt" Or TextBox1.Text = "Kitte" Or TextBox1.Text = "Kitten" Or TextBox1.Text = "KittenF" Or TextBox1.Text = "KittenFo" Then
            Panel4.Visible = True
            Panel4.Dock = DockStyle.Fill
        Else
            Panel4.Visible = False
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Desktop.Cursor = Cursors.AppStarting
        RiPlayer.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Desktop.Cursor = Cursors.AppStarting
        RiPlayer.Show()
        Me.Close()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Desktop.Cursor = Cursors.AppStarting
        StoreDesktop.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Desktop.Cursor = Cursors.AppStarting
        StoreDesktop.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Desktop.Cursor = Cursors.AppStarting
        Snappy.Show()
        Me.Close()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Desktop.Cursor = Cursors.AppStarting
        Snappy.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click, Label16.Click
        Desktop.Cursor = Cursors.AppStarting
        Helpandtips.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs)
        ToolStripMenuItem1.ShowDropDown()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Desktop.Cursor = Cursors.AppStarting
        Settings.Show()
        Me.Close()
    End Sub

    Private Sub PowerOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerOptionsToolStripMenuItem.Click
        ShutOffOptions.Show()
        Me.Close()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        LogOffScreen.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox21_Click_1(sender As Object, e As EventArgs)
        ZOS_voice.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Page2.SendToBack()
        Button1.BackColor = Color.DodgerBlue
        Button2.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Page1.SendToBack()
        Button1.BackColor = Color.Gainsboro
        Button2.BackColor = Color.DodgerBlue
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        WindowsApps.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click, Label18.Click
        GoogleApp.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click, Label36.Click
        If FileIO.FileSystem.FileExists("C:\Program Files (x86)\Kingsoft\Kingsoft Office\office6\wps.exe") Then
            Process.Start("C:\Program Files (x86)\Kingsoft\Kingsoft Office\office6\wps.exe")
        Else
            KingsoftError.Show()
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click, Label19.Click
        YoutubeApp.Show()
        Me.Close()
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click, Label35.Click
        If FileIO.FileSystem.FileExists("C:\Program Files (x86)\Kingsoft\Kingsoft Office\office6\et.exe") Then
            Process.Start("C:\Program Files (x86)\Kingsoft\Kingsoft Office\office6\et.exe")
        Else
            KingsoftError.Show()
        End If
        Close()
    End Sub

    Private Sub Label32_Click_1(sender As Object, e As EventArgs) Handles PictureBox35.Click, Label32.Click
        If FileIO.FileSystem.FileExists("C:\Program Files (x86)\Kingsoft\Kingsoft Office\office6\wpp.exe") Then
            Process.Start("C:\Program Files (x86)\Kingsoft\Kingsoft Office\office6\wpp.exe")
        Else
            KingsoftError.Show()
        End If
        Close()
    End Sub


    Private Sub Label31_Click_1(sender As Object, e As EventArgs) Handles PictureBox34.Click, Label31.Click
        LiveChatApp.Show()
        Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click, Label11.Click
        Gallery.Show()
        Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Page1_Paint(sender As Object, e As PaintEventArgs) Handles Page1.Paint

    End Sub
End Class