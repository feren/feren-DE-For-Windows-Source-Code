Public Class SettingsColorDialogDesktop

    Private Sub CustomColorBlender1_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomColorBlender1.SelectedColorChanged
        Desktop.BackColor = CustomColorBlender1.SelectedColor
        Deskbackground.PictureBox16.BackColor = CustomColorBlender1.SelectedColor
        TextBox1.Text = CustomColorBlender1.SelectedColor.R
        TextBox2.Text = CustomColorBlender1.SelectedColor.G
        TextBox3.Text = CustomColorBlender1.SelectedColor.B
    End Sub

    Private Sub ColorCombControl1_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorCombControl1.SelectedColorChanged
        Desktop.BackColor = ColorCombControl1.SelectedColor
        Deskbackground.PictureBox16.BackColor = ColorCombControl1.SelectedColor
        CustomColorBlender1.SelectedColor = ColorCombControl1.SelectedColor
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Desktop.BackColor = ColorTranslator.FromOle(RGB(TextBox1.Text, CustomColorBlender1.SelectedColor.G, CustomColorBlender1.SelectedColor.B))
        Deskbackground.PictureBox16.BackColor = ColorTranslator.FromOle(RGB(TextBox1.Text, CustomColorBlender1.SelectedColor.G, CustomColorBlender1.SelectedColor.B))
        CustomColorBlender1.SelectedColor = ColorTranslator.FromOle(RGB(TextBox1.Text, CustomColorBlender1.SelectedColor.G, CustomColorBlender1.SelectedColor.B))
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Desktop.BackColor = ColorTranslator.FromOle(RGB(CustomColorBlender1.SelectedColor.R, TextBox2.Text, Desktop.BackColor.B))
        Deskbackground.PictureBox16.BackColor = ColorTranslator.FromOle(RGB(CustomColorBlender1.SelectedColor.R, TextBox2.Text, CustomColorBlender1.SelectedColor.B))
        CustomColorBlender1.SelectedColor = ColorTranslator.FromOle(RGB(CustomColorBlender1.SelectedColor.R, TextBox2.Text, CustomColorBlender1.SelectedColor.B))
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Desktop.BackColor = ColorTranslator.FromOle(RGB(CustomColorBlender1.SelectedColor.R, CustomColorBlender1.SelectedColor.G, TextBox3.Text))
        Deskbackground.PictureBox16.BackColor = ColorTranslator.FromOle(RGB(CustomColorBlender1.SelectedColor.R, CustomColorBlender1.SelectedColor.G, TextBox3.Text))
        CustomColorBlender1.SelectedColor = ColorTranslator.FromOle(RGB(CustomColorBlender1.SelectedColor.R, CustomColorBlender1.SelectedColor.G, TextBox3.Text))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class