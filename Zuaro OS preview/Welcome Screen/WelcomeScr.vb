Public Class WelcomeScr

    Private Sub WelcomeScr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Label4.Click
        Desktop.Cursor = Cursors.AppStarting
        Cursor = Cursors.AppStarting
        StoreDesktop.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, PictureBox2.Click
        Desktop.Cursor = Cursors.AppStarting
        Cursor = Cursors.AppStarting
        Helpandtips.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, Label5.Click
        Desktop.Cursor = Cursors.AppStarting
        Cursor = Cursors.AppStarting
        DeskBackground.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click, Label8.Click
        About_Zuaro_OS.Show()
    End Sub
End Class