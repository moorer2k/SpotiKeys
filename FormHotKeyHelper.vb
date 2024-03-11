Public Class FormHotKeyHelper

    Private Sub TextHotKey_KeyDown(sender As Object, e As KeyEventArgs) Handles TextHotKey.KeyDown
        ' Using StringBuilder for efficient string manipulation
        Dim keysPressed As New Text.StringBuilder()

        ' Check for each modifier key
        If e.Control Then keysPressed.Append("Control+")
        If e.Shift Then keysPressed.Append("Shift+")
        If e.Alt Then keysPressed.Append("Alt+")

        ' Avoid appending ModifierKeys directly; only add the main key if it's not a control key
        If Not e.KeyCode = Keys.ControlKey AndAlso Not e.KeyCode = Keys.ShiftKey AndAlso Not e.KeyCode = Keys.Menu Then
            keysPressed.Append(e.KeyCode.ToString())
        End If

        TextHotKey.Text = keysPressed.ToString()
    End Sub

    'Private Sub TextHotKey_MouseDown(sender As Object, e As MouseEventArgs) Handles TextHotKey.MouseDown
    '    Dim mouseButtonPressed As String = e.Button.ToString()
    '    ' Display mouse button pressed with any combination of control keys
    '    TextHotKey.Text = If(Control.ModifierKeys <> Keys.None, Control.ModifierKeys.ToString().Replace(", ", " + ") + " + ", "") + mouseButtonPressed
    'End Sub

End Class