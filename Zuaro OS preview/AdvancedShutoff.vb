Public Class AdvancedShutoff

    Private Sub AdvancedShutoff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub AdvancedShutoff_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub Button1_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles Button1.Layout

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShutDownScreen.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LogOffScreen.Show()
    End Sub
End Class