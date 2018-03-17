Public Class Splash

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity = 1.0 Then
            Timer2.start()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If My.Settings.FirstBootDone = False Then
            FirstBootSetupDialog.Show()
            Me.Close()
        Else
            DubugMenu.Show()
            Me.Close()
        End If
    End Sub
End Class