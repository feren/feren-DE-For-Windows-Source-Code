Public Class LonghornDesktop

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        StepIndicator1.CurrentStep = (StepIndicator1.CurrentStep + 1)
        Panel2.Visible = True
        PictureBox1.BackgroundImage = My.Resources.Taskbar
        If StepIndicator1.CurrentStep = 2 Then
            StepIndicator1.CurrentStep = 0
            Panel2.Visible = False
            PictureBox1.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub StepIndicator1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StepIndicator1.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        AnalogClockControl1.Value = TimeOfDay
        TimeandDate.Text = TimeOfDay + " " + DateString
    End Sub

    Private Sub AnalogClockControl1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalogClockControl1.ValueChanged

    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Settings.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Settings.Show()
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Visible = False
        Panel2.Visible = False
        Panel4.Visible = False
        Reload.Start()
    End Sub

    Private Sub Reload_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reload.Tick
        Panel1.Visible = True
        Panel4.Visible = True
        Reload.Stop()
    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) Handles PictureBox11.Click, Label10.Click
        LonghornSettings.Show()
    End Sub
End Class
