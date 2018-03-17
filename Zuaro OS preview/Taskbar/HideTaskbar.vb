Partial Public Class HideTaskbar
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub HideTaskbar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Taskbar.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class