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

Public Class MainEmergency
    'Declarations
    Dim DataBase As String
    Dim Drag As Boolean
    Dim Xaxys As Integer
    Dim Yaxys As Integer
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Timer4.Stop()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer3.Start()
        'Start & enable real-time
        Timer4.Start()
        PictureBox6.Width = 0
        FileSystemWatcher1.EnableRaisingEvents = False
        If ListBox2.Items.Count = 0 Then
            Safe()
        Else
            infected()
        End If
    End Sub
    Private Sub Safe()
        PictureBox1.BackgroundImage = Nothing
        Panel1.BackColor = PictureBox2.BackColor
        Panel3.BackColor = Panel1.BackColor
        Label11.Text = "Nothing is wrong, if it is not broken, dont fix it!"
        PictureBox29.BackgroundImage = My.Resources.Shield_Green
        Label12.Text = "Your PC is secure"
        Button1.Enabled = False
    End Sub
    Private Sub infected()
        PictureBox1.BackgroundImage = My.Resources.Redbgnew
        Panel1.BackColor = PictureBox8.BackColor
        Panel3.BackColor = Panel1.BackColor
        Label11.Text = "Your PC is infected with viruses. Unauthorized mouse movement to suspicious activity can occur."
        PictureBox29.BackgroundImage = My.Resources.Shield_Red
        Label12.Text = "Your PC is at risk!"
        Button1.Enabled = True
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

                    ListBox2.Items.Add(strFile)

                Next

            Next
        Catch ex As Exception
        End Try

        Timer1.Start()
    End Sub
    Private Sub FileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
       
    End Sub

    Private Sub FileSystemWatcher1_Renamed(ByVal sender As System.Object, ByVal e As System.IO.RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'VirusKill
        Try
            If Not ListBox2.Items.Count = 0 Then
                ListBox2.SelectedIndex += 1
                Kill(ListBox2.SelectedItem)
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
        ProgressBar1.Maximum = Conversions.ToString(ListBox2.Items.Count)

        total.Text = Conversions.ToString(ListBox2.Items.Count)

        If Not ProgressBar1.Value = ProgressBar1.Maximum Then
            Try

                ListBox2.SelectedIndex = ListBox2.SelectedIndex + 1
                TextBox1.Text = ListBox2.SelectedItem.ToString
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
                Dim f As FileStream = New FileStream(ListBox2.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                f = New FileStream(ListBox2.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(f)
                Dim hash As Byte() = md5.Hash
                Dim buff As StringBuilder = New StringBuilder
                Dim hashByte As Byte
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next

                If scanbox.Text.Contains(buff.ToString) Then



                    ListBox2.Items.Add(ListBox2.SelectedItem)
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
            Threats.BringToFront()
            If ListBox2.Items.Count = 0 Then
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
        ListBox2.Items.Clear()
        ListBox2.Items.Clear()
        Scanner.BringToFront()
        Try
            For Each strDir As String In
            System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

                For Each strFile As String In System.IO.Directory.GetFiles(strDir)

                    ListBox2.Items.Add(strFile)

                Next

            Next
        Catch ex As Exception
        End Try

        Timer1.Start()
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Engine.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If My.Settings.AntivirusDB = "" Then
            My.Settings.AntivirusDB = "Internal"
            My.Settings.Save()
        Else
            My.Settings.AntivirusDB = ""
            My.Settings.Save()
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Me.Close()
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        If Label11.Text = "Your PC is infected with viruses. Unauthorized mouse movement to suspicious activity can occur." Then
            total.Text = 0
            detected.Text = 0
            files.Text = 0
            PictureBox6.Width = 0
            ProgressBar1.Maximum = 0
            ProgressBar1.Value = 0
            ListBox2.Items.Clear()
            ListBox2.Items.Clear()
            Scanner.BringToFront()
            Try
                For Each strDir As String In
                System.IO.Directory.GetDirectories("C:\")

                    For Each strFile As String In System.IO.Directory.GetFiles(strDir)

                        ListBox2.Items.Add(strFile)

                    Next

                Next
            Catch ex As Exception
            End Try

            Timer1.Start()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        BringToFront()
    End Sub
End Class