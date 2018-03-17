Public Class DesktopOptions

    Private Sub DesktopOptions_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Desktop.Panel3.Visible = False
    End Sub

    Private Sub DesktopOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BackgroundImage = Desktop.BackgroundImage
        BackColor = Desktop.BackColor
        BackgroundImageLayout = Desktop.BackgroundImageLayout
        Timer1.Start()
        Timer1.Enabled = True
        Desktop.Panel3.Visible = True
        Panel1.BackgroundImage = Desktop.Panel1.BackgroundImage
        Panel1.BackgroundImageLayout = Desktop.Panel1.BackgroundImageLayout
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.LostFocus

    End Sub

    Private Sub DesktopOptions_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
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

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        ShutOffOptions.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click, Label3.Click
        About_Zuaro_OS.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click, Label4.Click
        StoreDesktop.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click, Label2.Click
        MsgBox("Sorry, Not yet implemented!", MsgBoxStyle.Critical)
    End Sub
End Class