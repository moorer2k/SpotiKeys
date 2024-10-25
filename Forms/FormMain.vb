Imports NHotkey
Imports NHotkey.WindowsForms
Imports SpotiKey.Modules
Imports SpotiKey.Utils

Public Class FormMain

    Private _spotifyHwnd As IntPtr

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Select Case ButtonRegister.Text
            Case "Register"
                CheckSetSpotify()
                ButtonRegister.Text = "Unregister"
            Case "Unregister" -
                HotkeyManager.Current.IsEnabled = False
                ButtonRegister.Text = "Register"
        End Select
    End Sub

    Private Sub RegisterHotkeysFromFile(filePath As String)
        Dim lines As String() = IO.File.ReadAllLines(filePath)
        For Each line As String In lines
            Dim parts As String() = line.Split("="c)
            If parts.Length = 2 Then
                Dim action As String = parts(0).Trim()
                Dim keys As String = parts(1).Trim()
                RegisterHotkey(action, keys)
            End If
        Next
    End Sub

    Private Sub RegisterHotkey(action As String, keyCombination As String)
        Try
            Dim parts As String() = keyCombination.Split("+"c)
            Dim modifierNames = parts.Take(parts.Length - 1) ' Take all but the last element as modifiers
            Dim keyName = parts.Last() ' The last element is the key

            Dim modifiers = HotkeyParser.ParseModifier(String.Join("+", modifierNames))
            Dim key = HotkeyParser.ParseKey(keyName)

            HotkeyManager.Current.AddOrReplace(action, key Or modifiers, AddressOf HotkeyPressed)
            LabelStatus.Text = "Status: Registered hotkeys!"
        Catch ex As Exception
            Console.WriteLine($"Error registering hotkey {action}: {ex.Message}")
        End Try
    End Sub

    Private Sub HotkeyPressed(sender As Object, e As HotkeyEventArgs)
        e.Handled = True
        Select Case e.Name
            Case "VolUp"
                NativeMethods.SendMessage(_spotifyHwnd, NativeMethods.WM_APPCOMMAND, 0, New IntPtr(CInt(NativeMethods.AppCommand.VolUp)))
            Case "VolDown"
                NativeMethods.SendMessage(_spotifyHwnd, NativeMethods.WM_APPCOMMAND, 0, New IntPtr(CInt(NativeMethods.AppCommand.VolDown)))
            Case "PrevTrack"
                NativeMethods.SendMessage(_spotifyHwnd, NativeMethods.WM_APPCOMMAND, 0, New IntPtr(CInt(NativeMethods.AppCommand.Previous)))
            Case "NextTrack"
                NativeMethods.SendMessage(_spotifyHwnd, NativeMethods.WM_APPCOMMAND, 0, New IntPtr(CInt(NativeMethods.AppCommand.Next)))
            Case "PlayPause"
                NativeMethods.SendMessage(_spotifyHwnd, NativeMethods.WM_APPCOMMAND, 0, New IntPtr(CInt(NativeMethods.AppCommand.PlayPause)))
            Case "Like"
                SpotifyHelper.SendHotkeyToSpotify("+%(b)")
            Case "Dislike"
                SpotifyHelper.SendHotkeyToSpotify("+%(b)")
        End Select
    End Sub

    Private Sub CheckSetSpotify()
        _spotifyHwnd = SpotifyHelper.GetSpotify()
        If _spotifyHwnd <> IntPtr.Zero Then
            RegisterHotkeysFromFile($"{Application.StartupPath}\Hotkeys.txt")
            HotkeyManager.Current.IsEnabled = True
        Else
            LabelStatus.Text = "Status: Failure!"
        End If
    End Sub

    Private Sub ButtonHotKey_Click(sender As Object, e As EventArgs) Handles ButtonHotKey.Click
        Dim frmHotKey As New FormHotKeyHelper
        frmHotKey.ShowDialog()
    End Sub

    Private Sub FormMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        HideWindow(True)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        ShowWindow()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        ShowWindow()
    End Sub

    Private Sub HideWindow(resized As Boolean)

        If resized Then
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Hide() ' Hide the form
                NotifyIcon1.Visible = True ' Show the NotifyIcon in the system tray
            End If
        Else
            Me.WindowState = FormWindowState.Minimized
            Me.Hide() ' Hide the form
            NotifyIcon1.Visible = True ' Show the NotifyIcon in the system tray
        End If

    End Sub

    Private Sub ShowWindow()
        Me.Show() ' Show the form
        Me.WindowState = FormWindowState.Normal ' Restore the window to normal state
        NotifyIcon1.Visible = False ' Optionally hide the NotifyIcon once the form is visible
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub GitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GitToolStripMenuItem.Click
        Process.Start("https://github.com/moorer2k/SpotiKeys")
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSettings()

        If My.Settings.AutoRegister Then
            ButtonRegister.Enabled = False
            CheckSetSpotify()
        End If
        If My.Settings.AutoMinimize Then
            HideWindow(False)
        End If

    End Sub

    Private Sub LoadSettings()
        CheckAutoMin.Checked = My.Settings.AutoMinimize
        CheckAutoReg.Checked = My.Settings.AutoRegister
    End Sub

    Private Sub CheckAutoReg_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAutoReg.CheckedChanged
        My.Settings.AutoRegister = CheckAutoReg.Checked
        My.Settings.Save()
    End Sub

    Private Sub CheckAutoMin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAutoMin.CheckedChanged
        My.Settings.AutoMinimize = CheckAutoMin.Checked
        My.Settings.Save()
    End Sub

End Class