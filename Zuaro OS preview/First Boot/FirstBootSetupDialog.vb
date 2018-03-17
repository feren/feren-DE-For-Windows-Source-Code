Public Class FirstBootSetupDialog

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox2.Visible = False
        WelcomeScr.BringToFront()
        Terms.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("If you decline, you wont be able to run Zuaro OS, are you sure?", "Zuaro OS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles TypePC.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TypePC.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PCos.BringToFront()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Button4.Enabled = True
            My.Settings.Device = "Mouse"
            RadioButton4.Text = "Use the Zuaro OS UI"
            RadioButton3.Text = "Windows 8"
            RadioButton8.Text = "Ubuntu"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            Button4.Enabled = True
            My.Settings.Device = "Touch"
            RadioButton4.Text = "Use the Zuaro OS Touch UI (Recommended for touch)"
            RadioButton3.Text = "Windows 8 (Recommended for touch)"
            RadioButton8.Text = "Ubuntu (Unity 8 (Based of Ubuntu Phone))"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TypePC.BringToFront()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        My.Settings.Look = "Default"
        Button7.Enabled = True
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Button4.Enabled = True
        My.Settings.Device = "Touch"
        RadioButton4.Text = "Use the Zuaro OS Touch UI (Recommended for touch)"
        RadioButton3.Text = "Windows 3.1 (Designed for touch)"
        RadioButton8.Text = "Ubuntu (Unity 8 (Based of Ubuntu Phone))"
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Button4.Enabled = True
        My.Settings.Device = "Mouse"
        RadioButton4.Text = "Use the Zuaro OS UI"
        RadioButton3.Text = "Windows 3.1"
        RadioButton8.Text = "Ubuntu"
    End Sub

    Private Sub PCos_Paint(sender As Object, e As PaintEventArgs) Handles PCos.Paint

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        My.Settings.Look = "3.1"
        Button7.Enabled = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        My.Settings.Look = "7"
        Button7.Enabled = True
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        My.Settings.Look = "XP"
        Button7.Enabled = True
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        My.Settings.Look = "Mac"
        Button7.Enabled = True
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        My.Settings.Look = "Ubuntu"
        Button7.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        desksrn.BringToFront()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PCos.BringToFront()
    End Sub

    Private Sub FirstBootSetupDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Closable.Checked = False Then
            e.Cancel = True
            If MessageBox.Show("Cancel Setup?", "Zuaro OS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Closable.Checked = True
                Me.Close()
            End If
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub FirstBootSetupDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox2.Text = My.Computer.Name
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ColorDialog1.ShowDialog()
        Dim MainColour As Color = ColorDialog1.Color
        PictureBox4.BackColor = MainColour
        My.Settings.MetroColour = ColorDialog1.Color
    End Sub

    Private Sub desksrn_Paint(sender As Object, e As PaintEventArgs) Handles desksrn.Paint

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        desksrn.BringToFront()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        My.Settings.UserName = TextBox9.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        My.Settings.Password = TextBox8.Text
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        UserFolderBrowserDialog.ShowDialog()
        My.Settings.UserFolder = UserFolderBrowserDialog.SelectedPath
        TextBox3.Text = UserFolderBrowserDialog.SelectedPath
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        DocumentBrowserDialog.ShowDialog()
        My.Settings.DocsFolder = DocumentBrowserDialog.SelectedPath
        TextBox4.Text = DocumentBrowserDialog.SelectedPath
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        PictureBrowserDialog.ShowDialog()
        My.Settings.PicsFolder = PictureBrowserDialog.SelectedPath
        TextBox5.Text = PictureBrowserDialog.SelectedPath
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        MusicBrowserDialog.ShowDialog()
        My.Settings.MusicFolder = MusicBrowserDialog.SelectedPath
        TextBox6.Text = MusicBrowserDialog.SelectedPath
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        VideoBrowserDialog.ShowDialog()
        My.Settings.VidsFolder = VideoBrowserDialog.SelectedPath
        TextBox7.Text = VideoBrowserDialog.SelectedPath
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox3.Text = "No user folder" Or TextBox4.Text = "No document folder" Or TextBox5.Text = "No pictures folder" Or TextBox6.Text = "No music folder" Or TextBox7.Text = "No videos Folder" Or CheckBox2.Checked = False Then
            MessageBox.Show("A field is empty or you have not selected a image, please fill it in or choose an image.", "Zuaro OS Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            confirmsrn.BringToFront()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        userimages.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox6.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        My.Settings.Userimage = OpenFileDialog1.FileName
        UserImage.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        CheckBox2.Checked = True
    End Sub

    Private Sub UserImage_Click(sender As Object, e As EventArgs) Handles UserImage.Click
        userimages.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        usersrn.BringToFront()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        helpsrn.BringToFront()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        helpsrn.BringToFront()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        My.Settings.Userimage = "Default"
        UserImage.BackgroundImage = My.Resources.login_8
        CheckBox2.Checked = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Closable.Checked = True
        MessageBox.Show("You will not be able to use Zuaro OS until you finish the first time setup.", "Zuaro OS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        usersrn.BringToFront()
    End Sub

    Private Sub confirmsrn_Paint(sender As Object, e As PaintEventArgs) Handles confirmsrn.Paint

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        My.Settings.FirstBootDone = True
        My.Settings.Save()
        DubugMenu.Show()
        Form1.Show()
        Closable.Checked = True
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        FirstBootKittenFox.Show()
        CType(FirstBootKittenFox.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://en-zuaroos.weebly.com/")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub userimages_Paint(sender As Object, e As PaintEventArgs) Handles userimages.Paint

    End Sub

    Private Sub UserFolderBrowserDialog_HelpRequest(sender As Object, e As EventArgs) Handles UserFolderBrowserDialog.HelpRequest

    End Sub

    Private Sub helpsrn_Paint(sender As Object, e As PaintEventArgs) Handles helpsrn.Paint

    End Sub
End Class