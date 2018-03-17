Public Class Boot

    Private Sub Boot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Windows.Forms.Cursor.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LogonLoader.Show()
        Windows.Forms.Cursor.Show()
        Me.Close()
    End Sub
End Class