Public Class Gallery
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point
    Dim myimages As New ListBox


    Private Sub KittenFox_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.KittenFoxIcon.Visible = False
        Desktop.Panel1.BackColor = Color.Transparent
    End Sub

    Private Sub KittenFox_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles Me.Layout
        If WindowState = FormWindowState.Maximized Then
            Panel11.Visible = True
            Panel2.Visible = False
            Panel5.Visible = False
            Panel14.Visible = False
            Panel9.Visible = False
            Desktop.Panel1.BackColor = Color.Black
            WindowsShelf.BackColor = Color.Black
            PictureBox1.Image = My.Resources.CloseDark
            PictureBox2.BackgroundImage = My.Resources.MinimizeDark
            PictureBox3.Image = My.Resources.RestoreNew
            Panel13.BackColor = Color.Black
            Panel8.BackColor = Color.Black
            Label1.ForeColor = Color.White
        Else
            Panel11.Visible = False
            Panel2.Visible = True
            Panel5.Visible = True
            Panel14.Visible = True
            Panel9.Visible = True
            Desktop.Panel1.BackColor = Color.Transparent
            WindowsShelf.BackColor = Color.White
            PictureBox1.Image = My.Resources.CloseNew
            PictureBox2.BackgroundImage = My.Resources.MinimizeNew
            PictureBox3.Image = My.Resources.MaximizeNew
            Panel13.BackColor = Color.White
            Panel8.BackColor = Color.White
            Label1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub KittenFox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub KittenFox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Desktop.KittenFoxIcon.Visible = True

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Panel12.Visible = True
        Panel8.Visible = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Panel12.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        My.Computer.FileSystem.DeleteFile(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedIndex)
        If ListBox1.SelectedIndex = 0 Then
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        Else
            ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex - 1
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" Then

        Else
            ListBox1.Items.Clear()
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            myimages.Items.AddRange(IO.Directory.GetFiles(TextBox1.Text))
            imagesorter(myimages)
        End If
    End Sub

    Sub imagesorter(ByVal v1 As ListBox)
        Dim str As String

        For i = 0 To v1.Items.Count - 1
            v1.SelectedIndex = i
            str = IO.Path.GetExtension(v1.SelectedItem)
            If str = ".jpg" Or str = ".jpeg" Or str = ".JPG" Or str = ".JPEG" Or str = ".BMP" Or str = ".PNG" Or str = ".GIF" Or str = ".bmp" Or str = ".png" Or str = ".gif" Then
                If ListBox1.Items.Contains(v1.SelectedItem) Then
                Else
                    ListBox1.Items.Add(v1.SelectedItem)
                End If
            End If
        Next
        ListBox1.SelectedIndex = 0
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox4.ImageLocation = ListBox1.SelectedItem
        Me.Text = ListBox1.SelectedItem + " - Gallery"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub SetAsDeskWallpaperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetAsDeskWallpaperToolStripMenuItem.Click
        My.Settings.DesktopBackground = "Custom"
        My.Settings.DesktopBackPath = PictureBox4.ImageLocation
        Desktop.BackgroundImage = PictureBox4.Image
    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
            ListBox1.SelectedIndex = 0
        Else
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        End If
    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If ListBox1.SelectedIndex = 0 Then
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        Else
            ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex - 1
        End If
    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WindowState = FormWindowState.Maximized
    End Sub
End Class