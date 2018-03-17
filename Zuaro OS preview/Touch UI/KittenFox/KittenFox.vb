Public Class KittenFoxTouch
    Dim int As Integer = 0
    Dim Favourites As String = My.Settings.UserFolder + "\KittenFoxFavourites.dat"
    Dim SW As IO.StreamWriter

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel11_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Toolbar.Paint

    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://kittenfoxspeeddial.weebly.com/")
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles BookmarksMenu.ItemClicked

    End Sub

    Private Sub TabControl1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub CloseTab(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KittenFox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        Browser.Name = "KittenFox"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        If My.Settings.FirstRunKittenFox = True Then
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://kittenfoxhome.weebly.com/")

        Else
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.KittenFoxHomepage)
        End If

        If IO.File.Exists(Favourites) = False Then
            IO.File.Create(Favourites)
        Else
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub Loading(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        Progress.Maximum = e.MaximumProgress
        Progress.Value = e.CurrentProgress
    End Sub

    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        TextBox1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Navigate(TextBox1.Text)
            KittenFox.ListBox1.Items.Add(TextBox1.Text)
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseClick
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        TabControl1.SelectTab(int)
        Browser.Name = "KittenFox"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.KittenFoxHomepage)
    End Sub

    Private Sub ContextMenuStrip2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not TabControl1.RowCount = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            int = int - 1
        End If
    End Sub

    Private Sub AddTabToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        TabControl1.SelectTab(int)
        Browser.Name = "KittenFox"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.KittenFoxHomepage)
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim FFox As New FirstBootKittenFox
        FFox.Show()
    End Sub

    Private Sub AddTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTabToolStripMenuItem.Click
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        TabControl1.SelectTab(int)
        Browser.Name = "KittenFox"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.KittenFoxHomepage)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub

    Private Sub WebsitePropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebsitePropertiesToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabToolStripMenuItem.Click
        If Not TabControl1.RowCount = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            int = int - 1
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        KittenFoxsettingsTouch.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseClick

    End Sub

    Private Sub Panel11_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FileToolStripMenuItem.ShowDropDown()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        TabControl1.SelectTab(int)
        Browser.Name = "KittenFox"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.KittenFoxHomepage)
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not TabControl1.RowCount = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            int = int - 1
        Else

        End If
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FFox As New FirstBootKittenFox
        FFox.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        FileToolStripMenuItem.ShowDropDown()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        KittenFoxsettingsTouch.Show()
    End Sub

    Private Sub PictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class