Public Class Startmenu

    Private Sub Startmenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Windows7Desktop.startbtn.BackgroundImage = My.Resources.Logoicon
    End Sub

    Private Sub Startmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Windows7Desktop.BackColor
        BackgroundImage = Windows7Desktop.BackgroundImage
        BackgroundImageLayout = Windows7Desktop.BackgroundImageLayout
        Windows7Desktop.startbtn.BackgroundImage = My.Resources.Logoiconselected
        If My.Settings.Userimage = "Default" Then
            If My.Settings.Userimage = "Default" Then
                PictureBox1.BackgroundImage = My.Resources.login_8
            End If
        Else
            PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.Userimage)
        End If
        Button1.Text = My.Settings.UserName
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class