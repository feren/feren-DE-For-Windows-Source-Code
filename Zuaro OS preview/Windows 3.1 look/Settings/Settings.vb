Public Class Settings31

    Private Sub Settings_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Settings31info.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Settings31Background.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("control.exe")
    End Sub
End Class