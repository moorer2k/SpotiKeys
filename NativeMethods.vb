Imports System.Runtime.InteropServices
Imports System.Text

Module NativeMethods

    Public Const SW_HIDE As Integer = 0
    Public Const SW_SHOWNORMAL As Integer = 1
    Public Const SW_NORMAL As Integer = 1
    Public Const SW_SHOWMINIMIZED As Integer = 2
    Public Const SW_SHOWMAXIMIZED As Integer = 3
    Public Const SW_MAXIMIZE As Integer = 3
    Public Const SW_SHOWNOACTIVATE As Integer = 4
    Public Const SW_SHOW As Integer = 5
    Public Const SW_MINIMIZE As Integer = 6
    Public Const SW_SHOWMINNOACTIVE As Integer = 7
    Public Const SW_SHOWNA As Integer = 8
    Public Const SW_RESTORE As Integer = 9

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

    Delegate Function EnumThreadDelegate(hWnd As IntPtr, lParam As IntPtr) As Boolean

    ''' <summary>
    ''' Sends the specified message to a window or windows.
    ''' </summary>
    ''' <param name="hWnd">A handle to the window whose window procedure will receive the message.</param>
    ''' <param name="Msg">The message to be sent.</param>
    ''' <param name="wParam">Additional message-specific information.</param>
    ''' <param name="lParam">Additional message-specific information.</param>
    ''' <returns>The result of the message processing; its value depends on the message sent.</returns>
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=False)>
    Public Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    ''' <summary>
    ''' Brings the thread that created the specified window into the foreground and activates the window.
    ''' </summary>
    ''' <param name="hWnd">A handle to the window that should be activated and brought to the foreground.</param>
    ''' <returns>True if the window was brought to the foreground, False otherwise.</returns>
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function SetForegroundWindow(hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    ''' <summary>
    ''' Sets the specified window's show state.
    ''' </summary>
    ''' <param name="hWnd">A handle to the window.</param>
    ''' <param name="nCmdShow">Specifies how the window is to be shown.</param>
    ''' <returns>True if the window was previously visible, False otherwise.</returns>
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function ShowWindow(hWnd As IntPtr, <MarshalAs(UnmanagedType.I4)> nCmdShow As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    ''' <summary>
    ''' Sets the show state of a window without waiting for the operation to complete.
    ''' </summary>
    ''' <param name="hWnd">A handle to the window.</param>
    ''' <param name="nCmdShow">Specifies how the window is to be shown.</param>
    ''' <returns>True if the operation was successful, False otherwise.</returns>
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function ShowWindowAsync(hWnd As IntPtr, nCmdShow As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    ''' <summary>
    ''' Enumerates all non-child windows associated with a thread by passing the handle to each window, in turn, to an application-defined callback function.
    ''' </summary>
    ''' <param name="dwThreadId">The thread identifier.</param>
    ''' <param name="lpfn">A pointer to an application-defined callback function.</param>
    ''' <param name="lParam">An application-defined value to be passed to the callback function.</param>
    ''' <returns>True if the function succeeds, False otherwise.</returns>
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function EnumThreadWindows(dwThreadId As Integer, lpfn As EnumThreadDelegate, lParam As IntPtr) As Boolean
    End Function

    ''' <summary>
    ''' Retrieves the name of the class to which the specified window belongs.
    ''' </summary>
    ''' <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
    ''' <param name="lpClassName">The class name string.</param>
    ''' <param name="nMaxCount">The length of the lpClassName buffer.</param>
    ''' <returns>If the function succeeds, the number of characters copied to the buffer, not including the terminating null character; otherwise 0.</returns>
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function GetClassName(hWnd As IntPtr, lpClassName As StringBuilder, nMaxCount As Integer) As Integer
    End Function

    ''' <summary>
    ''' Determines whether the specified window handle identifies an existing window.
    ''' </summary>
    ''' <param name="hWnd">A handle to the window to be tested.</param>
    ''' <returns>True if the window handle identifies an existing window, False otherwise.</returns>
    <DllImport("user32.dll")>
    Public Function IsWindow(hWnd As IntPtr) As Boolean
    End Function

End Module
