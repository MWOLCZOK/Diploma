Imports EE
Imports DAL


Public Class BLL_PagoViaje

    Dim _dalpagoviaje As New DAL_PagoViaje

    Public Sub altapagoviaje(ByVal paramviaje As BE_PagoViaje)
        Try
            _dalpagoviaje.alta(paramviaje)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminarviaje(ByVal paramviaje As BE_PagoViaje)
        Try
            _dalpagoviaje.eliminar(paramviaje)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificarpagoviaje(ByVal parampagoviaje As BE_PagoViaje) As Boolean
        Try
            Return _dalpagoviaje.modificar(parampagoviaje)
        Catch ex As Exception
        End Try
    End Function

    Public Function consultarpagoviaje(ByVal oPagoviaje As BE_PagoViaje) As BE_PagoViaje
        Try
            Return _dalpagoviaje.consultarPagoviaje(oPagoviaje)
        Catch ex As Exception

        End Try
    End Function

    Public Function consultarPagosViajes(ByVal oPagosViajes As BE_PagoViaje) As List(Of BE_PagoViaje)
        Try
            Return _dalpagoviaje.consultarPagosviajes(oPagosViajes)
        Catch ex As Exception

        End Try
    End Function



End Class
