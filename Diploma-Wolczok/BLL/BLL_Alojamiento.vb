Public Class BLL_Alojamiento

    Dim dalAlojamiento As New DAL.DAL_Alojamiento
    Public Function consultarAlojamiento(ByVal paramDestino As EE.BE_Destino, ByVal paramFechaInicio As Date, ByVal paramFechaFin As Date)
        Try
            Return dalAlojamiento.consultarAlojamiento(paramDestino, paramFechaInicio, paramFechaFin)
        Catch ex As Exception

        End Try
    End Function

   

End Class
