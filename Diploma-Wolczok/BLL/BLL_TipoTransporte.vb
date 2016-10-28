Imports DAL
Imports EE

Public Class BLL_TipoTransporte

    Dim _daltipotransporte As New DAL_Tipotransporte

    Public Sub altatipotransporte(ByVal oTipotransporte As BE_TipoTransporte)
        Try
            _daltipotransporte.alta(oTipotransporte)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminarTipotransporte(ByVal oTipotransporte As BE_TipoTransporte)
        Try
            _daltipotransporte.eliminar(oTipotransporte)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificarTipotransporte(ByVal oTipotransporte As BE_TipoTransporte) As Boolean
        Try
            Return _daltipotransporte.modificar(oTipotransporte)
        Catch ex As Exception

        End Try
    End Function

    Public Function consultarTipotransporte(ByVal paramTipotrans As BE_TipoTransporte) As BE_TipoTransporte
        Return _daltipotransporte.consultarTipotransporte(paramTipotrans)
    End Function

    Public Function consultarTipoTransportes() As List(Of BE_TipoTransporte)
        Try
            Return _daltipotransporte.consultarTipotransportes()
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
