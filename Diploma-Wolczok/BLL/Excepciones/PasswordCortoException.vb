﻿Public Class PasswordCortoException
    Inherits ExcepcionPersonalizada

    Public Overrides Function Mensaje() As String
        Return BLL_Traduccion.TraducirMensaje("Excepcion_12")
    End Function

    Public Overrides Function Titulo() As String
        Return BLL_Traduccion.TraducirMensaje("Excepcion_Titulo_12")
    End Function
End Class
