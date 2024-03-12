Imports System.Runtime.InteropServices
Imports System.Text

Module SpotifyHelper

    Private _cachedSpotifyHandle As IntPtr = IntPtr.Zero
    Private _spotifyProcess As Process

    Public Sub SendHotkeyToSpotify(hotkey As String)

        If _spotifyProcess IsNot Nothing AndAlso _spotifyProcess.MainWindowHandle <> IntPtr.Zero Then

            If SetForegroundWindow(_spotifyProcess.MainWindowHandle) Then

                ShowWindowAsync(_spotifyProcess.MainWindowHandle, SW_MAXIMIZE)

                Threading.Thread.Sleep(200) ' Small delay to ensure window has time to respond
                SendKeys.SendWait(hotkey)
                ' Minimize the Spotify window immediately after sending the hotkey
                ShowWindow(_spotifyProcess.MainWindowHandle, SW_MINIMIZE)
            Else
                MessageBox.Show("Could not set Spotify to the foreground.")
            End If

        Else
            MessageBox.Show("Spotify process is not running.")
        End If
    End Sub

    Public Function GetSpotify() As IntPtr
        ' Check if the cached handle is still valid
        If _cachedSpotifyHandle <> IntPtr.Zero AndAlso IsWindowValid(_cachedSpotifyHandle) Then
            Return _cachedSpotifyHandle
        End If

        ' If not valid, reset cache and search again
        _cachedSpotifyHandle = IntPtr.Zero

        Dim procs = Process.GetProcessesByName("spotify")

        _spotifyProcess = procs.FirstOrDefault(Function(proc) Not String.IsNullOrWhiteSpace(proc.MainWindowTitle))

        For Each proc In procs
            For Each thread In proc.Threads
                Dim threadId As Integer = thread.Id
                EnumThreadWindows(threadId, Function(hWnd, lParam)
                                                Dim sb As New StringBuilder(256)
                                                GetClassName(hWnd, sb, sb.Capacity)
                                                Dim className = sb.ToString()
                                                If className = "Chrome_WidgetWin_0" Then
                                                    _cachedSpotifyHandle = hWnd
                                                    Return False ' Stop enumeration
                                                End If
                                                Return True ' Continue enumeration
                                            End Function, IntPtr.Zero)

                If _cachedSpotifyHandle <> IntPtr.Zero Then
                    Return _cachedSpotifyHandle
                End If
            Next
        Next

        ' Return IntPtr.Zero if Spotify is not found
        Return IntPtr.Zero
    End Function

    Private Function IsWindowValid(hWnd As IntPtr) As Boolean
        Return hWnd <> IntPtr.Zero AndAlso IsWindow(hWnd)
    End Function

End Module