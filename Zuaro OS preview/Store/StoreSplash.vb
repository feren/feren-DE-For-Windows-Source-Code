Public Class StoreSplash

    Private Sub StoreSplash_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Closable.Checked = True Then
            e.Cancel = False
        ElseIf Closable.Checked = False Then
            Do Until Me.Location.Y = -Me.Height
                Me.Location = New Point(0, Me.Location.Y - 3)
            Loop
            Closable.Checked = True
            Me.Close()
        End If
    End Sub

    Sub Init() Handles Me.Load
        Me.Size = My.Computer.Screen.Bounds.Size
        Me.Location = New Point(0, -Me.Height)
        Me.Refresh()
    End Sub

    Sub Anim() Handles Me.Shown
        ' -- Falling
        Me.Refresh()
        Do Until Me.Location.Y = 0
            Me.Location = New Point(0, Me.Location.Y + 3)
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        
    End Sub

    Private Sub Init(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Closable.Checked = True
        Store.Show()
        Me.Close()
    End Sub
End Class
