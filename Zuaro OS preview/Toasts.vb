Public Class Toasts

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Toast1.Visible = False
    End Sub

    Private Sub Toasts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = Desktop.BackgroundImage
        BackgroundImageLayout = Desktop.BackgroundImageLayout
        BackColor = Desktop.BackColor
    End Sub

    Private Sub Panel19_Paint(sender As Object, e As PaintEventArgs) Handles Panel19.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Toast2.Visible = False
    End Sub
End Class