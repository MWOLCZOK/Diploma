Public Class nombreRepetidoException
    Inherits ExcepcionPersonalizada

    Public Overrides Function Mensaje() As String
        Return BLL_Traduccion.TraducirMensaje("Excepcion_19")

    End Function

    Public Overrides Function Titulo() As String
        Return BLL_Traduccion.TraducirMensaje("Titulo_Mensaje_0")

    End Function
End Class
