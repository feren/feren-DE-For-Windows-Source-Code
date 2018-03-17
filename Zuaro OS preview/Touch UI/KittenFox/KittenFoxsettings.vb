Public Class KittenFoxsettingsTouch

    Private Sub KittenFoxsettings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FirstBootKittenFox.Enabled = True
        FirstBootKittenFox.BringToFront()
    End Sub

    Private Sub KittenFoxsettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FirstBootKittenFox.Enabled = False
        TextBox1.Text = My.Settings.KittenFoxHomepage
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        My.Settings.KittenFoxHomepage = TextBox1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        My.Settings.KittenFoxStyle = "Windows"
        KittenFoxTouch.Toolbar.Visible = False
        KittenFoxTouch.Progress.Dock = DockStyle.Top
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        My.Settings.KittenFoxStyle = "Default"
        KittenFoxTouch.Toolbar.Visible = True
        KittenFoxTouch.Progress.Dock = DockStyle.Bottom
    End Sub
End Class