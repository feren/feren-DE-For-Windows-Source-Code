Public Class WindowsApps

    Private Sub WindowsApps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWebBrowser1.Navigate("C:\ProgramData\Microsoft\Windows\Start Menu\Programs")
        AxWebBrowser2.Navigate(My.Settings.UserFolder + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs")
    End Sub

    Private Sub AxWebBrowser2_Enter(sender As Object, e As EventArgs) Handles AxWebBrowser2.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AxWebBrowser1.Navigate("C:\ProgramData\Microsoft\Windows\Start Menu\Programs")
        AxWebBrowser2.Navigate(My.Settings.UserFolder + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs")
    End Sub
End Class