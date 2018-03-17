Public Class DesktopOptionsTouch

    Private Sub StartScreenOptions_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        StartScreen.Panel3.Visible = False
    End Sub

    Private Sub StartScreenOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BackgroundImage = StartScreen.BackgroundImage
        BackColor = StartScreen.BackColor
        BackgroundImageLayout = StartScreen.BackgroundImageLayout
        Timer1.Start()
        Timer1.Enabled = True
        StartScreen.Panel3.Visible = True
        PictureBox2.Image = StartScreen.Userimagebutton.Image
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.LostFocus

    End Sub

    Private Sub StartScreenOptions_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity = 100 Then
            Timer1.Stop()
            Timer1.Enabled = False
        Else : Me.Opacity = Me.Opacity + 1
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        AppsMenu.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ZOS_voice.Show()
        Me.Close()
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        StartScreen.Panel8.Visible = True
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        ShutOffOptions.Show()
        Me.Close()
    End Sub
End Class