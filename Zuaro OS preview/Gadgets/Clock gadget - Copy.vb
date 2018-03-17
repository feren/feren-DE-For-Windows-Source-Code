Imports System.Globalization
Public Class Clock_gadget_time
    Dim dt As Date = Date.Today

    Private Sub Clock_gadget_time_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = TimeOfDay.Minute
        Timer1.Start()
        Location = Clock_gadget.Location
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay.Minute
    End Sub
End Class