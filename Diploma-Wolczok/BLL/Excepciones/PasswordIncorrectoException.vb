﻿Public Class PasswordIncorrectoException
    Inherits ExcepcionPersonalizada


    Public Overrides Function Mensaje() As String
        Return BLL_Traduccion.TraducirMensaje("Excepcion_6")

    End Function

    Public Overrides Function Titulo() As String
        Return BLL_Traduccion.TraducirMensaje("Excepcion_Titulo_6")

    End Function
End Class
