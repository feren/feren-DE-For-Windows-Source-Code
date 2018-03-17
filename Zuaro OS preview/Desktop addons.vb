Public Class Desktop_addons

    Private Sub Desktop_addons_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles SwitchButton1.ValueChanged
        If SwitchButton1.Value = True Then
            Desktop.Panel1.Dock = DockStyle.Top
            Desktop.BubbleBar1.Visible = True
            Close()
        End If
    End Sub
End Class