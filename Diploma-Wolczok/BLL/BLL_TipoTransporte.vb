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

    Public Function consultarTipotransporte(ByVal oTipotransporte As BE_TipoTransporte, ByVal paramFechaInicio As Date, ByVal paramFechaFin As Date) As BE_TipoTransporte
        Return _daltipotransporte.consultarTipotransporte(oTipotransporte)
    End Function

    Public Function consultarTipotransportes() As List(Of BE_TipoTransporte)
        Return _daltipotransporte.consultarTipotransportes()
    End Function



End Class
