Public Class LiveChatApp

    Private Sub YoutubeTouch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWebBrowser1.GoBack()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWebBrowser1.GoForward()
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(ByVal sender As System.Object, ByVal e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles AxWebBrowser1.ShowCreatedWebView

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class