Public Class DefenderConstructionMessage

    Private Sub DefenderConstructionMessage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ZuaroDefender.Enabled = True
    End Sub

    Private Sub DefenderConstructionMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ZuaroDefender.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class