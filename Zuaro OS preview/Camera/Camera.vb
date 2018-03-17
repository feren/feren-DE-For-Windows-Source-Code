Imports Emgu.CV
Imports Emgu.CV.Util
Imports Emgu.CV.Structure
Public Class Camera
    Dim capturez As Capture = New Capture

    Private Sub Camera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim imagez As Image(Of Bgr, Byte) = capturez.RetrieveBgrFrame()
        PictureBox1.Image = imagez.ToBitmap()
    End Sub
End Class