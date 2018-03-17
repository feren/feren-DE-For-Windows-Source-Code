Public Class MsgStyle

    Private Sub MsgStyle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label1.Text = My.Settings.AntivirusTitle
        TextBox1.Text = My.Settings.AntivirusMessage
    End Sub

    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub MsgStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim x As Double
            x = "0,020"
            If Me.Opacity <= 0.9 Then
                Me.Opacity += x
            ElseIf (Me.Opacity + x > 0.9) Then
                Timer1.Stop()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub
End Class