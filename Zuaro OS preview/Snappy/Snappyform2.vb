Public Class Snappyform2

    Private Sub Snappyform2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Snappy.BackColor = Color.FromArgb(224, 224, 224)
        Snappy.TransparencyKey = Color.FromArgb(224, 224, 224)
        Snappy.BackgroundImage = Nothing
        Snappy.BackgroundImageLayout = ImageLayout.Tile

        Me.Opacity = 0.85
        Snappy.Opacity = 0.85
    End Sub

    Private Sub Snappyform2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Snappy.Close()
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Snappy.Timer1.Start()
        End If
    End Sub

    Private Sub Snappyform2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 80
        TextBox1.Text = "0"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        TextBox1.Text += 1

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Snappy.Timer1.Start()
        End If

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Snappy.Timer2.Start()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        Snappy.Timer2.Start()
    End Sub
End Class