Public Class DesktopLoader

    Private Sub LogonLoader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim EndPoint = Panel1.Location
        If PictureBox1.Location = EndPoint Then
            Desktop.Show()
            Timer2.Start()
            Timer1.Stop()
            Timer1.Enabled = False
        ElseIf Not PictureBox1.Location = EndPoint Then
            Dim Pics() As PictureBox = {PictureBox1}
            For x = 0 To Pics.Length - 1
                Pics(x).Left -= 3
            Next
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label1.Text = "Stiring the Sugar..." Then
            Timer3.Start()
            Timer2.Enabled = False
        Else
            Label1.Text = "Stiring the Sugar..."
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Close()
    End Sub
End Class