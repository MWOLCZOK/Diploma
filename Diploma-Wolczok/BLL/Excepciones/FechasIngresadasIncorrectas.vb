Public Class fechasIngresadasIncorrectas
    Inherits ExcepcionPersonalizada

    Public Overrides Function Mensaje() As String
        Return BLL_Traduccion.TraducirMensaje("Excepcion_5")

    End Function

    Public Overrides Function Titulo() As String
        Return BLL_Traduccion.TraducirMensaje("Excepcion_Titulo_5")

    End Function
End Class
