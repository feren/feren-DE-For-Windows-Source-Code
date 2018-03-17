Public Class Clock_gadget
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point

    Private Sub Clock_gadget_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Label1.Text = TimeOfDay.Hour
        Clock_gadget_time.Show(Me)
    End Sub

    Private Sub Clock_gadget_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay.Hour
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        X = Control.MousePosition.X - Location.X
        Y = Control.MousePosition.Y - Location.Y
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Location = NewPoint
            Clock_gadget_time.Location = Location
        End If
    End Sub
End Class