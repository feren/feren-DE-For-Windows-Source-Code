Public Class Desktopswitcher

    Private Sub Desktopswitcher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        BackgroundImage = Desktop.BackgroundImage
        BackgroundImageLayout = Desktop.BackgroundImageLayout
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.BringToFront()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
        Label1.Text = "Desktop 1"
    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave
        Label1.Text = ""
    End Sub
End Class