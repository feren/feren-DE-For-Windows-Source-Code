Public Class TouchExplorer

    Private Sub Explorer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OneDriveBrowser.BringToFront()
        Panel1.BackColor = Color.SteelBlue
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DropBoxBrowser.BringToFront()
        Panel1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Explorer.BringToFront()
        Panel1.BackColor = Color.DimGray
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.BackColor = Color.SteelBlue Then
            If OneDriveBrowser.CanGoBack = True Then
                OneDriveBrowser.GoBack()
            End If
        End If
        If Panel1.BackColor = Color.DodgerBlue Then
            If DropBoxBrowser.CanGoBack = True Then
                DropBoxBrowser.GoBack()
            End If
        End If
        If Panel1.BackColor = Color.DimGray Then
            If Explorer.CanGoBack = True Then
                Explorer.GoBack()
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Panel1.BackColor = Color.SteelBlue Then
            If OneDriveBrowser.CanGoForward = True Then
                OneDriveBrowser.GoForward()
            End If
        End If
        If Panel1.BackColor = Color.DodgerBlue Then
            If DropBoxBrowser.CanGoForward = True Then
                DropBoxBrowser.GoForward()
            End If
        End If
        If Panel1.BackColor = Color.DimGray Then
            If Explorer.CanGoForward = True Then
                Explorer.GoForward()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class