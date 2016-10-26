Public Class BLL_Alojamiento

    Dim dalAlojamiento As New DAL.DAL_Alojamiento
    Public Function consultarAlojamiento(ByVal paramDestino As EE.BE_Destino, ByVal paramFechaInicio As Date, ByVal paramFechaFin As Date) As List(Of EE.BE_Alojamiento)
        Try
            Return dalAlojamiento.consultarAlojamiento(paramDestino, paramFechaInicio, paramFechaFin)
        Catch ex As Exception

        End Try
    End Function


    Public Function consultarAlojamientos() As List(Of EE.BE_Alojamiento)
        Try
            Return dalAlojamiento.consultarAlojamientos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function consultarAlojamiento(ByVal paramAlojamiento As EE.BE_Alojamiento) As EE.BE_Alojamiento
        Try
            Return dalAlojamiento.consultarAlojamiento(paramAlojamiento)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



End Class
