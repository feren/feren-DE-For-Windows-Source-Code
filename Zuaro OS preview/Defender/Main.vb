Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Windows.Forms

Public Class Main
    'Declarations
    Dim DataBase As String
    Dim Drag As Boolean
    Dim Xaxys As Integer
    Dim Yaxys As Integer
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Try
            Dim x As Double
            x = "0,020"
            If Me.Opacity <= 0.82 Then
                Me.Opacity += x
            ElseIf (Me.Opacity + x > 0.82) Then
                Timer4.Stop()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Shown
        'Start & enable real-time
        Timer4.Start()
        PictureBox6.Width = 0
        FileSystemWatcher1.EnableRaisingEvents = False
        realtime.Text = "Real-time Disabled"
        If ListBox2.Items.Count = 0 Then
            Safe()
            If My.Settings.AntivirusLiveProtection = True Then
                FileSystemWatcher1.EnableRaisingEvents = True
                realtime.Text = "Real-time Enabled"
                Button11.Enabled = False
                Button12.Enabled = True
                Safe()
            ElseIf My.Settings.AntivirusLiveProtection = False Then
                realtime.Text = "Real-time Disabled"
                livedisabled()
                Button11.Enabled = True
                Button12.Enabled = False
            End If
        Else
            infected()
        End If
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub
    Sub Safe()
        PictureBox1.BackgroundImage = Nothing
        Panel1.BackColor = PictureBox2.BackColor
        Panel3.BackColor = Panel1.BackColor
        Label11.Text = "Nothing is wrong, if it is not broken, dont fix it!"
        PictureBox29.BackgroundImage = My.Resources.Shield_Green
        Label12.Text = "Your PC is secure"
        Button1.Enabled = False
        Desktop.PictureBox9.Image = My.Resources.Shield_Green
        Desktop.PictureBox10.Image = My.Resources.Shield_Green
        Desktop.Panel7.BackColor = PictureBox2.BackColor
        Desktop.Label5.Text = "Protected"
    End Sub
    Sub infected()
        PictureBox1.BackgroundImage = My.Resources.Redbgnew
        Panel1.BackColor = PictureBox8.BackColor
        Panel3.BackColor = Panel1.BackColor
        Label11.Text = "Your PC is infected with viruses. Unauthorized mouse movement to suspicious activity can occur."
        PictureBox29.BackgroundImage = My.Resources.Shield_Red
        Label12.Text = "Your PC is at risk!"
        Button1.Enabled = True
        Desktop.PictureBox9.Image = My.Resources.Shield_Red
        Desktop.PictureBox10.Image = My.Resources.Shield_Red
        Desktop.Panel7.BackColor = PictureBox8.BackColor
        Desktop.Label5.Text = "Infected"
    End Sub
    Sub livedisabled()
        Label11.Text = "Auto-Protection is off, unless you are protected by something else, you may want to turn it on."
        Button1.Enabled = True
        Desktop.PictureBox9.Image = My.Resources.Shield_yellow
        Button11.Enabled = True
        Button12.Enabled = False
        Desktop.PictureBox10.Image = My.Resources.Shield_yellow
        Desktop.Label5.Text = "Live is off"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        files.Text = "0"
        FolderBrowserDialog1.SelectedPath = ("C:/")

        Try
            For Each strDir As String In
            System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

                For Each strFile As String In System.IO.Directory.GetFiles(strDir)

                    ListBox1.Items.Add(strFile)

                Next

            Next
        Catch ex As Exception
        End Try

        Timer1.Start()
    End Sub
    Private Sub FileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        'Live protection
        Try
            Labellastreal.Text = e.FullPath
            ListBox3.Items.Add(Labellastreal.Text)
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("md5.txt").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next
            f.Close()
            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                Found.ShowDialog()

            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try

    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        'Live protection
        Try
            Labellastreal.Text = e.FullPath
            ListBox3.Items.Add(Labellastreal.Text)
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("md5.txt").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next
            f.Close()
            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                Found.ShowDialog()

            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try

    End Sub

    Private Sub FileSystemWatcher1_Renamed(ByVal sender As System.Object, ByVal e As System.IO.RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        'Live protection
        Try
            Labellastreal.Text = e.FullPath
            ListBox3.Items.Add(Labellastreal.Text)
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("md5.txt").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next
            f.Close()
            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                Found.ShowDialog()

            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'VirusKill
        Try
            If Not ListBox2.Items.Count = 0 Then
                ListBox2.SelectedIndex += 1
                Kill(ListBox1.SelectedItem)
                ListBox2.Items.Remove(ListBox2.SelectedItem)
            Else
                Timer1.Stop()
                Timer2.Stop()

                MsgBox("Threat Was Removed Successfully!", MsgBoxStyle.Information)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Custom scan progression & scan
        ProgressBar1.Maximum = Conversions.ToString(ListBox1.Items.Count)

        total.Text = Conversions.ToString(ListBox1.Items.Count)

        If Not ProgressBar1.Value = ProgressBar1.Maximum Then
            Try

                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                TextBox1.Text = ListBox1.SelectedItem.ToString
            Catch ex As Exception
            End Try



            Try

                Dim scanbox As New TextBox
                Dim read As String = My.Computer.FileSystem.ReadAllText("md5.txt")
                ProgressBar1.Increment(1)
                PictureBox6.Width = PictureBox6.Width + 610 / ProgressBar1.Maximum
                If PictureBox6.Width >= 610 Then
                    PictureBox6.Width = 610
                End If
                detected.Text = Conversions.ToString(ListBox2.Items.Count)
                files.Text = Conversions.ToString(ProgressBar1.Value)
                scanbox.Text = read.ToString
                Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
                Dim f As FileStream = New FileStream(ListBox1.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                f = New FileStream(ListBox1.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(f)
                Dim hash As Byte() = md5.Hash
                Dim buff As StringBuilder = New StringBuilder
                Dim hashByte As Byte
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next

                If scanbox.Text.Contains(buff.ToString) Then



                    ListBox2.Items.Add(ListBox1.SelectedItem)
                End If
            Catch ex As Exception
            End Try
        Else
            Timer1.Stop()
            PictureBox6.Width = 610
            My.Settings.AntivirusMessage = "Scan finished !"
            My.Settings.AntivirusTitle = "Scan information"
            My.Settings.Save()
            MsgStyle.Show()
            If ListBox1.Items.Count = 0 Then
                MsgBox("No Threats were detected, Scan Window will close!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'browse & scan start
        total.Text = 0
        detected.Text = 0
        files.Text = 0
        PictureBox6.Width = 0
        ProgressBar1.Maximum = 0
        ProgressBar1.Value = 0

        FolderBrowserDialog1.ShowDialog()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Scanner.BringToFront()
        Try
            For Each strDir As String In
            System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

                For Each strFile As String In System.IO.Directory.GetFiles(strDir)

                    ListBox1.Items.Add(strFile)

                Next

            Next
        Catch ex As Exception
        End Try

        Timer1.Start()
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FileSystemWatcher1.EnableRaisingEvents = True
        realtime.Text = "Real-time Enabled"
        My.Settings.AntivirusLiveProtection = True
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FileSystemWatcher1.EnableRaisingEvents = False
        realtime.Text = "Real-time Disabled"
        My.Settings.AntivirusLiveProtection = False
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel6.BringToFront()
        WebBrowser1.Navigate("http://en-zuaroos.weebly.com/database-updater.html")
    End Sub

    Private Sub Main_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - Yaxys
            Me.Left = Windows.Forms.Cursor.Position.X - Xaxys
        End If
    End Sub

    Private Sub Main_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        Xaxys = Windows.Forms.Cursor.Position.X - Me.Left
        Yaxys = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Main_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub TabPage1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = True
        Xaxys = Windows.Forms.Cursor.Position.X - Me.Left
        Yaxys = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TabPage1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - Yaxys
            Me.Left = Windows.Forms.Cursor.Position.X - Xaxys
        End If
    End Sub

    Private Sub TabPage1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = False
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - Yaxys
            Me.Left = Windows.Forms.Cursor.Position.X - Xaxys
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = False
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = True
        Xaxys = Windows.Forms.Cursor.Position.X - Me.Left
        Yaxys = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - Yaxys
            Me.Left = Windows.Forms.Cursor.Position.X - Xaxys
        End If
    End Sub

    Private Sub Label5_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = False
    End Sub

    Private Sub Label5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = True
        Xaxys = Windows.Forms.Cursor.Position.X - Me.Left
        Yaxys = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = False
    End Sub

    Private Sub PictureBox2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = True
        Xaxys = Windows.Forms.Cursor.Position.X - Me.Left
        Yaxys = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - Yaxys
            Me.Left = Windows.Forms.Cursor.Position.X - Xaxys
        End If
    End Sub

    Private Sub PictureBox9_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - Yaxys
            Me.Left = Windows.Forms.Cursor.Position.X - Xaxys
        End If
    End Sub

    Private Sub PictureBox8_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - Yaxys
            Me.Left = Windows.Forms.Cursor.Position.X - Xaxys
        End If
    End Sub

    Private Sub PictureBox10_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - Yaxys
            Me.Left = Windows.Forms.Cursor.Position.X - Xaxys
        End If
    End Sub

    Private Sub PictureBox8_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = True
        Xaxys = Windows.Forms.Cursor.Position.X - Me.Left
        Yaxys = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox10_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = True
        Xaxys = Windows.Forms.Cursor.Position.X - Me.Left
        Yaxys = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox9_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = True
        Xaxys = Windows.Forms.Cursor.Position.X - Me.Left
        Yaxys = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox9_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = False
    End Sub

    Private Sub PictureBox10_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = False
    End Sub

    Private Sub PictureBox8_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Drag = False
    End Sub
    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Timer2.Start()
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            Kill(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)



            MsgBox("Threat Was Removed Successfully!", MsgBoxStyle.Information)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_TextUpdate(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Engine.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Me.Hide()
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel5.BringToFront()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Panel5.BringToFront()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Threats.BringToFront()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Label11.Text = "Your PC is infected with viruses. Unauthorized mouse movement to suspicious activity can occur." Then
            total.Text = 0
            detected.Text = 0
            files.Text = 0
            PictureBox6.Width = 0
            ProgressBar1.Maximum = 0
            ProgressBar1.Value = 0
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            Scanner.BringToFront()
            Try
                For Each strDir As String In
                System.IO.Directory.GetDirectories("C:\")

                    For Each strFile As String In System.IO.Directory.GetFiles(strDir)

                        ListBox1.Items.Add(strFile)

                    Next

                Next
            Catch ex As Exception
            End Try

            Timer1.Start()
        End If
        If Label11.Text = "Auto-Protection is off, unless you are protected by something else, you may want to turn it on." Then
            FileSystemWatcher1.EnableRaisingEvents = True
            realtime.Text = "Real-time Enabled"
            If ListBox2.Items.Count = 0 Then
                Safe()
            Else
                infected()
            End If
            My.Settings.AntivirusLiveProtection = True
        End If
        Button11.Enabled = False
        Button12.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DefenderSettings.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Panel5.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        liveprotection.BringToFront()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FileSystemWatcher1.EnableRaisingEvents = True
        realtime.Text = "Real-time Enabled"
        My.Settings.AntivirusLiveProtection = True
        If ListBox2.Items.Count = 0 Then
            Safe()
        Else
            infected()
        End If
        Button11.Enabled = False
        Button12.Enabled = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FileSystemWatcher1.EnableRaisingEvents = False
        realtime.Text = "Real-time Disabled"
        My.Settings.AntivirusLiveProtection = False
        livedisabled()
        Button11.Enabled = True
        Button12.Enabled = False
    End Sub

    Private Sub Threats_Paint(sender As Object, e As PaintEventArgs) Handles Threats.Paint

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Panel5.BringToFront()
    End Sub
End Class