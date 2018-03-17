
Public Class RebootScreen

    Private Sub LogonLoader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        My.Settings.Save()
        Desktop.BringToFront()
        Boot.Close()
        Desktop.BringToFront()
        Desktop.Closable.Checked = True
        AdvancedShutoff.Close()
        My.Settings.Save()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Application.Restart()
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity = 1.0 Then
            Me.Opacity = 0.9
            Form1.Show()
            Boot.Close()
            Form1.TopMost = False
            Timer1.Stop()
        End If
    End Sub
End Class