Public Class Helpandtips

    Private Sub Helpandtips_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel11.BackgroundImage = Desktop.BackgroundImage
        Panel11.BackgroundImageLayout = Desktop.BackgroundImageLayout
        Panel11.BackColor = Desktop.BackColor
        Panel16.BackgroundImage = Desktop.BackgroundImage
        Panel16.BackgroundImageLayout = Desktop.BackgroundImageLayout
        Panel16.BackColor = Desktop.BackColor
        Panel26.BackgroundImage = Desktop.BackgroundImage
        Panel26.BackgroundImageLayout = Desktop.BackgroundImageLayout
        Panel26.BackColor = Desktop.BackColor
        Panel32.BackgroundImage = Desktop.BackgroundImage
        Panel32.BackgroundImageLayout = Desktop.BackgroundImageLayout
        Panel32.BackColor = Desktop.BackColor
        Panel23.BackgroundImage = Desktop.BackgroundImage
        Panel23.BackgroundImageLayout = Desktop.BackgroundImageLayout
        Panel23.BackColor = Desktop.BackColor
        Panel31.BackgroundImage = Desktop.BackgroundImage
        Panel31.BackgroundImageLayout = Desktop.BackgroundImageLayout
        Panel31.BackColor = Desktop.BackColor
    End Sub

    Private Sub Panel36_Paint(sender As Object, e As PaintEventArgs) Handles Panel36.Paint

    End Sub

    Private Sub Panel37_Paint(sender As Object, e As PaintEventArgs) Handles Panel37.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Helpandtips_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Desktop.Cursor = Cursors.Default
        WelcomeScr.Cursor = Cursors.Default
    End Sub
End Class