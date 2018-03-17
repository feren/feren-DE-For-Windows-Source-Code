Public Class AviraStoreWindows

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("http://install.avira-update.com/package/oe/win/en/avira_oe_client_antivirus_en.exe")
    End Sub

    Private Sub GoogleStoreApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FileIO.FileSystem.FileExists("C:\Program Files (x86)\Avira\AntiVir Desktop\avcenter.exe") Or FileIO.FileSystem.FileExists("C:\Program Files\Avira\AntiVir Desktop\avcenter.exe") Then
            Button1.Enabled = False
            Button1.Visible = False
            Button2.Visible = True
        End If
    End Sub
End Class