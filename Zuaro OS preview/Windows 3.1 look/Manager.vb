Public Class Manager31

    Private Sub Manager31_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Closable.Checked = False Then
            e.Cancel = True
            If MessageBox.Show("Exit Zuaro OS?", "Zuaro OS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Closable.Checked = True
                Me.Close()
                Desktop31.Close()
                e.Cancel = False
            End If
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Manager31_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout
        If WindowState = FormWindowState.Minimized Then
            Desktop31.PictureBox1.Visible = True
            Opacity = 0.01
        Else
            Desktop31.PictureBox1.Visible = False
            Opacity = 1
        End If
    End Sub

    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RiPlayer31.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        About31.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        KittenFox31.Show()
    End Sub


    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Clock31.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        StoreDesktop.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Snappy.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Settings31.Show()
    End Sub
End Class