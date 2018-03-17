Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Logon.BringToFront()
        Boot.BringToFront()
    End Sub

    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Boot.Show()
        Logon.Close()
        DesktopLoader.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Boot.Show()
            Logon.Close()
        Catch ex As Exception
        End Try
        DesktopLoader.Close()
        HideTaskbar.Show()
    End Sub
End Class
