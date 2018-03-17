
Public Class HibernationScreen

    Private Sub LogonLoader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        CircularProgress1.IsRunning = True
        My.Settings.Save()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("LogonLoader -h")
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
       
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity = 1.0 Then
            Me.Opacity = 0.9
            Timer1.Stop()
        End If
    End Sub
End Class