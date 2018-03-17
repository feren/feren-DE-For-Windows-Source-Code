' This code is (c) 2009 Microsoft Corporation, written by Lucian Wischik.
' It is released under the Microsoft Public License, http://www.microsoft.com/opensource/licenses.mspx#Ms-PL


Public Class Camera
    ' Note: WebCamLib.dll is x86 only, so we need to build this app for x86 architecture.
    Dim Touchless1 As New TouchlessLib.TouchlessMgr


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Eliminate flicker on repaint:
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        Me.UpdateStyles()

        ' Set up the webcam to fire an event when it captures a frame:
        If Touchless1.Cameras.Count = 0 Then MessageBox.Show("This application needs a webcam") : Return
        Touchless1.CurrentCamera = Touchless1.Cameras.First
        AddHandler Touchless1.CurrentCamera.OnImageCaptured, AddressOf Form1_Capture

        ' Give the user an opportunity to tweak the camera settings:
        Touchless1.CurrentCamera.ShowPropertiesDialog(Me.Handle)
    End Sub

    Private Sub Form1_Capture()
        ' This event runs in a worker thread owned by Touchless. We want to handle the event
        ' in the main UI thread, so we use BeginInvoke. Note: this is still fine even if the
        ' form has been disposed before our invoke ends up happening.
        Me.BeginInvoke(New EventHandler(AddressOf Me.Invalidate))
    End Sub

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim b = Touchless1.CurrentCamera.GetCurrentImage
        If b IsNot Nothing Then e.Graphics.DrawImage(b, 0, 0, Width, Height)
    End Sub
End Class
