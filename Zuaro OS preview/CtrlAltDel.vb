Public Class CtrlAltDel

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundImage = Desktop.BackgroundImage
        BackgroundImageLayout = Desktop.BackgroundImageLayout
        BackColor = Desktop.BackColor
        Timer1.Start()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity = 1.0 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub ShutOffOptions_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CheckBox1.Checked = False Then
            e.Cancel = True
            Timer2.Start()
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity <= 0.1 Then
            CheckBox1.Checked = True
            Me.Close()
            Timer2.Stop()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ShutOffOptions.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LogOffScreen.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        LockScreen.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Shell("taskmgr.exe")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        LogOffScreen.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Shell("utilman.exe")
    End Sub
End Class