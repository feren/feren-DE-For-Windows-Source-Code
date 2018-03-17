Public Class Store

    Private Sub StoreSplash_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub StoreNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TileItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem6.ItemClick
        YoutubeStoreApp.Show()
    End Sub

    Private Sub TileItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem7.ItemClick
        GoogleStoreApp.Show()
    End Sub
End Class
