
Public Class ShutDownScreen

    Private Sub LogonLoader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Windows.Forms.Cursor.Hide()
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
        Form1.Close()
        ShowTaskbar.Show()
        Windows.Forms.Cursor.Show()
        My.Settings.Save()
        End
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity = 1.0 Then
            Me.Opacity = 0.9
            Form1.Show()
            Form1.TopMost = False
            Boot.Close()
            Timer1.Stop()
        End If
    End Sub
End Class