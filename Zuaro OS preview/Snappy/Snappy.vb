Public Class Snappy
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point

    Private Sub Snappy_BackgroundImageChanged(sender As Object, e As EventArgs) Handles Me.BackgroundImageChanged
        PictureBox1.BackgroundImage = BackgroundImage
    End Sub

    Private Sub Snappy_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Snappyform2.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Snappy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Snappyform2.Show(Me)
        Snappyform2.Location = New Point(Me.Location.X + Me.Size.Width, Math.Round(Me.Location.Y + ((Me.Size.Height / 2) - (Snappyform2.Size.Height / 2))))
        Snappyform2.Width = 80

        Me.BackColor = Color.Crimson
        Me.TransparencyKey = Color.Crimson
    End Sub

    Private Sub Snappy_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If (Me.Location.X + Me.Size.Width) >= Screen.PrimaryScreen.Bounds.Size.Width Then
            Snappyform2.Location = New Point((Me.Location.X + Me.Size.Width) - Snappyform2.Size.Width, Math.Round(Me.Location.Y + ((Me.Size.Height / 2) - (Snappyform2.Size.Height / 2))))
            Snappyform2.Width = 80
        Else

            Snappyform2.Location = New Point(Me.Location.X + Me.Size.Width, Math.Round(Me.Location.Y + ((Me.Size.Height / 2) - (Snappyform2.Size.Height / 2))))
            Snappyform2.Width = 80
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = 0
        Snappyform2.Opacity = 0

        Try

            Dim screenshot As Bitmap
            Dim graph As Graphics

            screenshot = New Bitmap(Me.ClientSize.Width, Me.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            graph = Graphics.FromImage(screenshot)
            graph.CopyFromScreen(Me.Location.X + 8, Me.Location.Y + 8, 0, 0, Me.ClientSize, CopyPixelOperation.SourceCopy)
            screenshot.Save("C:\Users\" & SystemInformation.UserName & "\Desktop\Screenshot" & Snappyform2.TextBox1.Text & ".png", System.Drawing.Imaging.ImageFormat.Png)
            Timer1.Stop()
            Me.Opacity = 0.85
            Snappyform2.Opacity = 0.85

        Catch ex As Exception

            Timer1.Stop()
            MsgBox("Something went wrong!", MsgBoxStyle.Critical, "Error")
            Timer1.Stop()
            Me.Opacity = 0.85
            Snappyform2.Opacity = 0.85
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Me.Opacity = 0
        Snappyform2.Opacity = 0

        Try

            Dim screenshot1 As Bitmap
            Dim graph1 As Graphics

            screenshot1 = New Bitmap(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            graph1 = Graphics.FromImage(screenshot1)
            graph1.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy)
            screenshot1.Save("C:\Users\" & SystemInformation.UserName & "\Desktop\Screenshot" & Snappyform2.TextBox1.Text & ".png", System.Drawing.Imaging.ImageFormat.Png)

            Me.BackgroundImage = screenshot1
            Me.BackColor = Color.White
            Me.BackgroundImageLayout = ImageLayout.Zoom
            Me.Refresh()
            Me.Size = New Size(Math.Round(Screen.PrimaryScreen.Bounds.Size.Width / 2), Math.Round(Screen.PrimaryScreen.Bounds.Size.Height / 2))

            Timer2.Stop()
            Me.Opacity = 1
            Snappyform2.Opacity = 0.85

        Catch ex As Exception

            Timer2.Stop()
            MsgBox("Something went wrong!", MsgBoxStyle.Critical, "Error")
            Timer2.Stop()
            Me.Opacity = 0.85
            Snappyform2.Opacity = 0.85
        End Try
    End Sub

    Private Sub Panel5_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel5.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + Me.Location.X - MousePosition.X, Me.Size.Height)
            Me.Location = New Point(MousePosition.X, Me.Location.Y)
        End If
    End Sub

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel7.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + Me.Location.X - MousePosition.X, Me.Size.Height)
            Me.Location = New Point(MousePosition.X, Me.Location.Y)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (Me.Location.Y - MousePosition.Y))
            Me.Location = New Point(Me.Location.X, MousePosition.Y)
        End If
    End Sub

    Private Sub Panel6_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel6.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + Me.Location.X - MousePosition.X, Me.Size.Height)
            Me.Location = New Point(MousePosition.X, Me.Location.Y)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, MousePosition.Y - Me.Location.Y)
        End If
    End Sub

    Private Sub Panel8_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel8.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (Me.Location.Y - MousePosition.Y))
            Me.Location = New Point(Me.Location.X, MousePosition.Y)
        End If
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(MousePosition.X - Me.Location.X, Me.Size.Height)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (Me.Location.Y - MousePosition.Y))
            Me.Location = New Point(Me.Location.X, MousePosition.Y)
        End If
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(MousePosition.X - Me.Location.X, Me.Size.Height)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, MousePosition.Y - Me.Location.Y)
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(MousePosition.X - Me.Location.X, Me.Size.Height)
        End If
    End Sub

    Private Sub Panel9_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel9.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, MousePosition.Y - Me.Location.Y)
        End If
    End Sub

    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + Me.Location.X - MousePosition.X, Me.Size.Height)
            Me.Location = New Point(MousePosition.X, Me.Location.Y)
        End If
    End Sub

    Private Sub Snappy_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Desktop.Cursor = Cursors.Default
    End Sub
End Class