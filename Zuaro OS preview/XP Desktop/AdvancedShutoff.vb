Public Class XPShutoff

    Private Sub AdvancedShutoff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Shut Off Zuaro OS"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Shut Off Zuaro OS" Then
            ShowTaskbar.Show()
            XPDesktop.Closable.Checked = True
            XPDesktop.Close()
            Form1.Close()
            Me.Close()
        ElseIf ComboBox1.Text = "Log Out" Then
            XPDesktop.Closable.Checked = True
            XPDesktop.Close()
            DesktopLoader.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub AdvancedShutoff_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub
End Class