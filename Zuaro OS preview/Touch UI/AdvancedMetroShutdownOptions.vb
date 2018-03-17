Public Class AdvancedMetroShutDownOptions

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text = "...Shut Off Zuaro OS," Then
            ShowTaskbar.Show()
            StartScreen.Closable.Checked = True
            StartScreen.Close()
            Form1.Close()
            Me.Close()
        ElseIf ComboBox1.Text = "...Log Out," Then
            StartScreen.Closable.Checked = True
            StartScreen.Close()
            DesktopLoader.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AdvancedMetroLogonLoaderOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = "...Shut Off Zuaro OS,"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class