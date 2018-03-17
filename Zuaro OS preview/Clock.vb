Public Class Clock

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Today
        Time.Text = TimeOfDay
    End Sub

    Private Sub Clock_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Desktop.Cursor = Cursors.Default
    End Sub
End Class