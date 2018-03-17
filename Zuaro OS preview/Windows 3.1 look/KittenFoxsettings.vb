Public Class KittenFoxsettings31
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point

    Private Sub KittenFoxsettings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KittenFox.Enabled = True
        KittenFox.BringToFront()
    End Sub

    Private Sub KittenFoxsettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KittenFox.Enabled = False
        TextBox1.Text = My.Settings.KittenFoxHomepage
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        My.Settings.KittenFoxHomepage = TextBox1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        My.Settings.KittenFoxStyle = "Windows"
        KittenFox.WindowsShelf.Visible = True
        KittenFox.Panel5.BackColor = KittenFox.WindowsShelf.BackColor
        KittenFox.Panel2.BackColor = KittenFox.WindowsShelf.BackColor
        KittenFox.Panel9.BackColor = KittenFox.WindowsShelf.BackColor
        KittenFox.Progress.Dock = DockStyle.Top
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        My.Settings.KittenFoxStyle = "Default"
        KittenFox.WindowsShelf.Visible = False
        KittenFox.Panel5.BackColor = Color.WhiteSmoke
        KittenFox.Panel2.BackColor = Color.WhiteSmoke
        KittenFox.Panel9.BackColor = Color.WhiteSmoke
        KittenFox.Progress.Dock = DockStyle.Bottom
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub
End Class