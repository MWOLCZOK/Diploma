Public Class BLL_Viaje


    Dim dalViaje As New DAL.DAL_Viaje



    Public Function consultarviajes(ByVal paramOrigen As EE.BE_Destino, ByVal paramDestino As EE.BE_Destino, ByVal paramFechaSalida As Date, ByVal paramTipoTransporte As EE.BE_TipoTransporte)
        Try

            Return dalViaje.consultarViajes(paramOrigen, paramDestino, paramFechaSalida, paramTipoTransporte)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarviajes(ByVal paramOrigen As EE.BE_Destino, ByVal paramDestino As EE.BE_Destino, ByVal paramFechaSalida As Date)
        Try
            Return dalViaje.consultarViajes(paramOrigen, paramDestino, paramFechaSalida)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarViaje(ByVal oViaje As EE.BE_Viaje) As EE.BE_Viaje
        Try
            Return dalViaje.consultarViaje(oViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub altaViaje(ByVal oViaje As EE.BE_Viaje)
        Try
            dalViaje.alta(oViaje)
        Catch ex As Exception

        End Try
    End Sub

End Class
