Public Class RiPlayer
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

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub CloseWindow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click, ExitToolStripMenuItem.Click, PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub OpenVideoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenVideoToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        Desktop.MusicName.Text = OpenFileDialog1.SafeFileName
        Try
            Desktop.PictureBox4.ImageLocation = OpenFileDialog1.FileName.Replace(OpenFileDialog1.SafeFileName, "\Folder.jpg")
        Catch ex As Exception
            Desktop.PictureBox4.Image = Desktop.PictureBox19.Image
        End Try
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            Desktop.Label12.Visible = True
            Desktop.Label15.Visible = False
            Button2.BackgroundImage = My.Resources.Play
            If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
                PauseInfo.Visible = True
            End If
        ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Desktop.Label12.Visible = False
            Desktop.Label15.Visible = True
            Button2.BackgroundImage = My.Resources.Pause
            PauseInfo.Visible = False
        End If
    End Sub

    Private Sub GoToPlayingVideoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToPlayingVideoToolStripMenuItem.Click
        Nowplaying()
    End Sub

    Sub Nowplaying()
        Panel13.Visible = True
        MenuStrip1.Visible = False
        Panel11.Visible = False
        Panel12.SendToBack()
        PictureBox16.Visible = True
        PictureBox17.Location = MaxBtnLocation.Location
        Opacity = 0.85
    End Sub

    Private Sub RiPlayer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Desktop.Cursor = Cursors.Default
    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Button2.BackgroundImage = My.Resources.Play
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            PauseInfo.Visible = True
        ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            Button2.BackgroundImage = My.Resources.Pause
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            PauseInfo.Visible = False
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Panel13.Visible = False
        MenuStrip1.Visible = True
        Panel11.Visible = True
        PictureBox16.Visible = False
        PictureBox17.Location = PictureBox16.Location
        Panel12.BringToFront()
        Opacity = 1
    End Sub

    Private Sub MuteVolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MuteVolumeToolStripMenuItem.Click
        AxWindowsMediaPlayer1.settings.volume = 0
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Nowplaying()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

    End Sub

    Private Sub Panel12_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel12.MouseMove

    End Sub

    Private Sub AxWindowsMediaPlayer1_MouseMoveEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseMoveEvent) Handles AxWindowsMediaPlayer1.MouseMoveEvent
        Showcontrols()
        TimeoutVideo.Stop()
        TimeoutVideo.Start()
    End Sub

    Sub Hidecontrols()
        Panel1.Visible = False
        Panel2.Visible = False
        Panel5.Visible = False
        Panel9.Visible = False
    End Sub

    Sub Showcontrols()
        Panel1.Visible = True
        Panel2.Visible = True
        Panel5.Visible = True
        Panel9.Visible = True
    End Sub

    Private Sub TimeoutVideo_Tick(sender As Object, e As EventArgs) Handles TimeoutVideo.Tick
        Hidecontrols()
        TimeoutVideo.Stop()
    End Sub
End Class