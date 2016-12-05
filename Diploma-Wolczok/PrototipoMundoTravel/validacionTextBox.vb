Public Class validacionTextBox
    Shared Function SoloNumeros(ByVal paramChar As KeyPressEventArgs) As Boolean
        If Char.IsDigit(paramChar.KeyChar) Or paramChar.KeyChar = ControlChars.Back Then Return False Else Return True
    End Function

    Shared Function TextoyNumeros(ByVal paramChar As KeyPressEventArgs) As Boolean
        If Char.IsDigit(paramChar.KeyChar) Or Char.IsLetter(paramChar.KeyChar) Or paramChar.KeyChar = ControlChars.Back Then Return False Else Return True
    End Function

    Shared Function Monto(ByVal paramChar As KeyPressEventArgs) As Boolean
        If Char.IsDigit(paramChar.KeyChar) Or paramChar.KeyChar.ToString = "," Or paramChar.KeyChar = ControlChars.Back Then Return False Else Return True
    End Function

End Class
