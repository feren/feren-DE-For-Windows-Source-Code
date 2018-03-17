Public Class search_gadget
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point

    Private Sub search_gadget_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, PictureBox1.MouseDown
        X = Control.MousePosition.X - Location.X
        Y = Control.MousePosition.Y - Location.Y
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Location = NewPoint
        End If
    End Sub
End Class