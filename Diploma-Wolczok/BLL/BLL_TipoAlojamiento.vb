Imports EE

Public Class BLL_TipoAlojamiento
    Dim dalTipoAlojamiento As New DAL.DAL_TipoAlojamiento

    Public Sub altaTipoAlojamiento(ByVal paramTipoAlojamiento As BE_TipoAlojamiento)
        Try
            dalTipoAlojamiento.alta(paramTipoAlojamiento)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminarTipoAlojamiento(ByVal paramTipoAlojamiento As BE_TipoAlojamiento)
        Try
            dalTipoAlojamiento.eliminar(paramTipoAlojamiento)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificarTipoAlojamiento(ByVal paramTipoAlojamiento As BE_TipoAlojamiento)
        Try
            Return dalTipoAlojamiento.modificar(paramTipoAlojamiento)
        Catch ex As Exception

        End Try
    End Function


    Public Function consultarTipoAlojamientos() As List(Of BE_TipoAlojamiento)
        Try
            Return dalTipoAlojamiento.consultarTipoAlojamientos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarTipoAlojamiento(ByVal paramAlojamiento As EE.BE_TipoAlojamiento) As EE.BE_TipoAlojamiento
        Try
            Return dalTipoAlojamiento.consultarTipoAlojamiento(paramAlojamiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
