Public Class BLL_Traduccion
    Public Shared Function TraducirMensaje(ByVal paramCodigo As String) As String
        Dim MiPalabra As New EE.BE_Palabras
        MiPalabra.Codigo = paramCodigo
        For Each MiTraduccion As EE.BE_Palabras In BLL.SessionBLL.SesionActual.ObtenerUsuarioActual.idioma.Palabras
            If MiTraduccion.Codigo = paramCodigo Then
                Return MiTraduccion.Traduccion
            End If
        Next
        Return "Mensaje Sin Traducción"
    End Function
End Class
