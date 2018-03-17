Public Class Settings31info

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        KittenFox31.Show()
        CType(KittenFox31.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://zuaroos.weebly.com/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class