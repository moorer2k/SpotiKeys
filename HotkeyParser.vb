
Public Class HotkeyParser

    Private Shared ReadOnly keyMap As Dictionary(Of String, Keys) = InitializeKeyMap()

    Private Shared Function InitializeKeyMap() As Dictionary(Of String, Keys)
        Dim map As New Dictionary(Of String, Keys)(StringComparer.OrdinalIgnoreCase)
        ' Use reflection to get all values from the Keys enum
        Dim values As Array = [Enum].GetValues(GetType(Keys))
        For Each key As Keys In values
            Dim keyName As String = [Enum].GetName(GetType(Keys), key)
            ' Some Keys enum values map to the same integer value, check before adding
            If Not map.ContainsKey(keyName) Then
                map.Add(keyName, key)
            End If
        Next
        Return map
    End Function
    Public Shared Function ParseKey(keyName As String) As Keys
        If keyMap.ContainsKey(keyName) Then
            Return keyMap(keyName)
        Else
            Return Keys.None
        End If
    End Function

    Public Shared Function ParseModifier(modifierString As String) As Keys
        Dim modifiers = Keys.None ' Initialize with no modifier.
        Dim modifierNames = modifierString.Split("+")

        For Each name In modifierNames
            Dim modifier = Keys.None
            ' Try to get the modifier key value from the keyMap, fall back to Keys.None if not found.
            If keyMap.TryGetValue(name, modifier) Then
                ' Combine the modifiers using bitwise OR.
                modifiers = modifiers Or modifier
            End If
        Next

        Return modifiers
    End Function

End Class