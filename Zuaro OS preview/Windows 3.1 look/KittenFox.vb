Imports System.Net
Public Class KittenFox31
    Dim int As Integer = 0
    Dim Favourites As String = My.Settings.UserFolder + "\KittenFoxFavourites.dat"
    Dim SW As IO.StreamWriter
    Dim X, Y As Integer
    Dim NewPoint As System.Drawing.Point

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel11_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://kittenfoxspeeddial.weebly.com/")
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub CloseTab(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KittenFox_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Desktop.KittenFoxIcon.Visible = False
    End Sub

    Private Sub KittenFox_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles Me.Layout

    End Sub

    Private Sub KittenFox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub KittenFox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Desktop.KittenFoxIcon.Visible = True
        If NetworkInformation.NetworkInterface.GetIsNetworkAvailable = True Then
            NoConnection.Visible = False
        Else
            NoConnection.Visible = True
        End If
        BackStage.Hide()
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

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub Loading(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            Progress.Maximum = e.MaximumProgress
            Progress.Value = e.CurrentProgress
        Catch ex As Exception
            Progress.Value = 0
        End Try
        If WindowState = FormWindowState.Maximized Then

        End If
    End Sub

    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        Label1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle + " - KittenFox"
        If Label1.Text = "Speed Dial - - KittenFox" Then
            Label1.Text = "Speed Dial - KittenFox"
        End If
        TextBox2.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Navigate(TextBox2.Text)
            ListBox1.Items.Add(TextBox2.Text)
        End If
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
        KittenFoxsettings.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub WindowsShelf_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel11_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Navigate(TextBox2.Text)
            ListBox1.Items.Add(TextBox2.Text)
        End If
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

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        Dim FFox As New KittenFox
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
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        KittenFoxsettings31.Show()
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub WindowsShelf_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Opacity = 0.8
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        Else
            Opacity = 1.0
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabControl1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Enter
        If WindowState = FormWindowState.Maximized Then

        End If
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If WindowState = FormWindowState.Maximized Then

        End If
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        KittenFoxsettings.Show()
    End Sub

    Private Sub Panel19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        FileToolStripMenuItem.ShowDropDown()
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles History.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        BackStage.Hide()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        BackStage.Show()
    End Sub

    Private Sub TextBox2_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Navigate(TextBox2.Text)
            ListBox1.Items.Add(TextBox2.Text)
        End If
    End Sub

    Private Sub PictureBox19_Click_1(sender As Object, e As EventArgs) Handles PictureBox19.Click
        CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Refresh()
    End Sub

    Private Sub PictureBox24_Click_1(sender As Object, e As EventArgs) Handles PictureBox24.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub PictureBox23_Click_1(sender As Object, e As EventArgs) Handles PictureBox23.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub ToolStripMenuItem10_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click

    End Sub

    Private Sub ToolStripMenuItem11_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click

    End Sub

    Private Sub ToolStripMenuItem12_Click_1(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Close()
    End Sub
End Class