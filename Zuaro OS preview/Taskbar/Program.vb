Option Explicit On
Option Strict On
Imports System.Windows.Forms
NotInheritable Class Program
    Private Sub New()

    End Sub
    <STAThread()> _
    Friend Shared Sub main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
    End Sub
End Class
