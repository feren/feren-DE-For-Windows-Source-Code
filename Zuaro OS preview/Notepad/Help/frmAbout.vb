Public Class frmAbout
    Inherits Form

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "More Information..." Then
            Me.Height = "574"
            Button1.Text = "Less Information"
        ElseIf Button1.Text = "Less Information" Then
            Me.Height = "496"
            Button1.Text = "More Information..."
        End If
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
End Class
