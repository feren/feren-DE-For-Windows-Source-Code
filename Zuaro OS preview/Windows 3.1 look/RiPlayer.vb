Public Class RiPlayer31
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point

    Private Sub RiPlayer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.RiPlayerIcon.Visible = False
    End Sub

    Private Sub RiPlayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Desktop.RiPlayerIcon.Visible = True
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub CloseWindow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenVideoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenVideoToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            Desktop.Label12.Visible = True
            Desktop.Label15.Visible = False
        ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Desktop.Label12.Visible = False
            Desktop.Label15.Visible = True
        End If
    End Sub

    Private Sub GoToPlayingVideoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToPlayingVideoToolStripMenuItem.Click
        Nowplaying()
    End Sub

    Sub Nowplaying()
        Panel12.Visible = True
        MenuStrip1.Visible = False
        Panel11.Visible = False
    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub
End Class