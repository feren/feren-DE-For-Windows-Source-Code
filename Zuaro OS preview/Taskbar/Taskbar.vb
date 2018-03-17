Option Explicit On
Option Strict On
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Public NotInheritable Class Taskbar
    Private Sub New()

    End Sub
    <DllImport("shell32.dll")> _
    Private Shared Function GetWindowText(hWnd As IntPtr, text As StringBuilder, count As Integer) As Integer

    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function EnumThreadWindows(ByVal threadID As Integer, pfnEnum As EnumThreadProc, lparam As IntPtr) As Boolean

    End Function
    <DllImport("user32.dll", setLastError:=True)> _
    Private Shared Function FindWindow(ByVal lpClassName As String, WindowName As String) As System.IntPtr

    End Function
    <DllImport("user32.dll", setLastError:=True)> _
    Private Shared Function FindWindowEx(ByVal parenthandle As IntPtr, childafter As IntPtr, ClassName As String, windowtitle As String) As IntPtr

    End Function
    <DllImport("user32.dll")> _
    Private Shared Function FindWindowEx(ByVal parentHWnd As IntPtr, ChildAfterHWnd As IntPtr, ClassName As IntPtr, windowtext As String) As IntPtr

    End Function
    <DllImport("user32.dll")> _
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Integer

    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowThreadProcessID(hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer

    End Function


    Private Const SW_HIDE As Integer = 0
    Private Const SW_SHOW As Integer = 5

    Private Const VistaStartMenuCaption As String = "Start"
    Private Shared VistaStartMenuWnd As IntPtr = IntPtr.Zero
    Private Delegate Function EnumThreadProc(ByVal hwnd As IntPtr, ByVal lparam As IntPtr) As Boolean


    Public Shared Sub Show()
        SetVisibility(True)
    End Sub

    Public Shared Sub Hide()
        SetVisibility(False)
    End Sub

    Public Shared WriteOnly Property Visible() As Boolean
        Set(ByVal value As Boolean)
            SetVisibility(value)

        End Set
    End Property

    Private Shared Sub SetVisibility(ByVal show As Boolean)
        Dim taskBarWnd As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
        Dim startWnd As IntPtr = FindWindowEx(taskBarWnd, IntPtr.Zero, "Button", "Start")
        If startWnd = IntPtr.Zero Then
            startWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, CType(&HC017, IntPtr), "Start")

        End If
        If startWnd = IntPtr.Zero Then
            startWnd = FindWindow("Button", Nothing)
            If startWnd = IntPtr.Zero Then
                startWnd = GetVistaStartMenuWnd(taskBarWnd)
            End If
        End If
        ShowWindow(taskBarWnd, If(show, SW_SHOW, SW_HIDE))
        ShowWindow(startWnd, If(show, SW_SHOW, SW_HIDE))
    End Sub

    Private Shared Function GetVistaStartMenuWnd(ByVal taskBarWnd As IntPtr) As IntPtr
        Dim procID As Integer
        Dim p As Process = Process.GetProcessById(procID)
        If p IsNot Nothing Then
            For Each t As ProcessThread In p.Threads
                EnumThreadWindows(t.Id, AddressOf MyEnumThreadWindowproc, IntPtr.Zero)

            Next
        End If
        Return VistaStartMenuWnd
    End Function

    Private Shared Function MyEnumThreadWindowproc(ByVal hWnd As IntPtr, ByVal lParam As IntPtr) As Boolean
        Dim Buffer As New StringBuilder(256)
        Return True
    End Function
End Class
