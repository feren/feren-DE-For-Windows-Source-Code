Public Class ZOS_voice

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub ZOS_voice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Desktop.BackgroundImage
        Me.BackgroundImageLayout = Desktop.BackgroundImageLayout
        Me.BackColor = Desktop.BackColor
    End Sub
End Class