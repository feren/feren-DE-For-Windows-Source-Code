
Public Class LogOffScreen

    Private Sub LogonLoader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Form1.Show()
        Form1.SendToBack()
        Boot.Close()
        Windows.Forms.Cursor.Show()
        Desktop.BringToFront()
        Desktop.Closable.Checked = True
        AdvancedShutoff.Close()
        Desktop.Close()
        My.Settings.Save()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim EndPoint = Panel1.Location
        If PictureBox1.Location = EndPoint Then
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
        Logon.Show()
        Me.Close()
    End Sub
End Class