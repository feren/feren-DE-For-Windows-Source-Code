Public Class DeadBattery

    Private Sub DeadBattery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Shell("shutdown -h")
        Me.Close()
        Timer1.Stop()
    End Sub
End Class