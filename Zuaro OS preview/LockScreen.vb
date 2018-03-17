Public Class LockScreen

    Sub Init() Handles Me.Load
        OvalShape1.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Userimage)
        Me.Size = My.Computer.Screen.Bounds.Size
        Me.Location = New Point(0, -Me.Height)
    End Sub

    Sub Anim() Handles Me.Shown
        ' -- Falling

        Do Until Me.Location.Y = 0
            Me.Location = New Point(0, Me.Location.Y + 3)
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Init(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Closable.Checked = False
        BackgroundImage = Desktop.BackgroundImage
        BackgroundImageLayout = Desktop.BackgroundImageLayout
        BackColor = Desktop.BackColor
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TimeOfDay.Hour < 12 Then
            Label2.Text = Format(DateAndTime.TimeOfDay, "hh : mm") + " " + "AM"
        ElseIf TimeOfDay.Hour > 12 Then
            Label2.Text = Format(DateAndTime.TimeOfDay, "hh : mm") + " " + "PM"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub GLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Visible = True
    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        TextBox1.Visible = False
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Visible = False
    End Sub

    Private Sub LockScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Visible = True
        CheckBox1.Checked = False
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.BringToFront()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Shell("shutdown -h")
        Panel2.Visible = False
        StepIndicator1.CurrentStep = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel2.Visible = True
        StepIndicator1.CurrentStep = StepIndicator1.CurrentStep + 1
        If StepIndicator1.CurrentStep = 2 Then
            Panel2.Visible = False
            StepIndicator1.CurrentStep = 0
        End If
    End Sub

    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.Click

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If TextBox1.Text = My.Settings.Password Then
            Closable.Checked = True
            Me.Close()
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            TextBox1.ForeColor = Color.Red
        End If
    End Sub
End Class
