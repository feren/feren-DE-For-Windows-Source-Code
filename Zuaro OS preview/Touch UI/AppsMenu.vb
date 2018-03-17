Imports DevComponents.DotNetBar

Public Class AppsMenuTouch

    Private Sub AppsMenu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Desktop.AppButton.BackgroundImage = Nothing
    End Sub

    Private Sub AppsMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        Desktop.AppButton.BackgroundImage = My.Resources.Taskbar
        CheckBox1.Checked = True
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub AppsMenu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        KittenFoxTouchSplash.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        KittenFoxTouchSplash.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        TouchExplorer.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        TouchExplorer.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        TouchSettings.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        TouchSettings.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        EditorForm.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        EditorForm.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        LockScreen.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        LockScreen.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Text = "Search Apps..."
            TextBox1.SelectAll()
        End If
        If TextBox1.Text = "KittenFox" Or TextBox1.Text = "K" Or TextBox1.Text = "Ki" Or TextBox1.Text = "Kit" Or TextBox1.Text = "Kitt" Or TextBox1.Text = "Kitte" Or TextBox1.Text = "Kitten" Or TextBox1.Text = "KittenF" Or TextBox1.Text = "KittenFo" Then
            Panel4.Visible = True
            Panel4.Dock = DockStyle.Fill
        Else
            Panel4.Visible = False
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        RiPlayer.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        RiPlayer.Show()
        Me.Close()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        StoreDesktop.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        StoreDesktop.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class