﻿Public Class restoreerroneoexception
    Inherits ExcepcionPersonalizada


    Public Overrides Function Mensaje() As String
        Return BLL_Traduccion.TraducirMensaje("Excepcion_16")
    End Function

    Public Overrides Function Titulo() As String
        Return BLL_Traduccion.TraducirMensaje("Excepcion_Titulo_16")
    End Function
End Class
