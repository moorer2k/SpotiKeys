Imports System.Runtime.InteropServices
Imports System.Text

Module NativeMethods

    Public Const SW_RESTORE As Integer = 9
    Public Const SW_MINIMIZE As Integer = 6

    Public Const WM_APPCOMMAND As Integer = &H319

    'https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-appcommand
    Public Enum AppCommand
        PlayPause = 14 * 65536
        [Stop] = 13 * 65536
        [Next] = 11 * 65536
        Previous = 12 * 65536
        VolDown = 9 * 65536
        VolUp = 10 * 65536
        Mute = 8 * 65536
    End Enum

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=False)>
    Public Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function SetForegroundWindow(hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function ShowWindow(hWnd As IntPtr, <MarshalAs(UnmanagedType.I4)> nCmdShow As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function ShowWindowAsync(hWnd As IntPtr, nCmdShow As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Delegate Function EnumThreadDelegate(hWnd As IntPtr, lParam As IntPtr) As Boolean

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function EnumThreadWindows(dwThreadId As Integer, lpfn As EnumThreadDelegate, lParam As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function GetClassName(hWnd As IntPtr, lpClassName As StringBuilder, nMaxCount As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Function IsWindow(hWnd As IntPtr) As Boolean
    End Function

End Module
