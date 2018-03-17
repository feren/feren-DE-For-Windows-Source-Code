Public Class KingsoftError

    Private Sub KingsoftError_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StoreDesktop.Show()
        StoreDesktop.WebBrowser1.Navigate("http://www.ksosoft.com/download/office_free_2013.exe")
        Me.Close()
    End Sub
End Class