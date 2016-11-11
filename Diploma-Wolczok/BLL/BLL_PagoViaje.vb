Imports EE

Imports DAL


Public Class BLL_PagoViaje

    Dim _dalpagoviaje As New DAL_PagoViaje

    Public Sub altapagoviaje(ByVal paramPagoViaje As BE_PagoViaje)
        Try
            Dim listaPago As New List(Of EE.BE_PagoViaje)
            Dim bllPago As New BLL.BLL_PagoViaje
            bllPago.consultarPagosViajes(paramPagoViaje.Reservaviaje)
            paramPagoViaje.Finpago = calcularUltimoPago(listaPago, paramPagoViaje)
            _dalpagoviaje.alta(paramPagoViaje)
        Catch ex As Exception
        End Try
    End Sub

    Private Function calcularUltimoPago(ByVal pagosPrevios As List(Of EE.BE_PagoViaje), ByVal pagoViaje As BE_PagoViaje) As Boolean
        Try
            Dim montoAcumulado As Double = 0
            For Each pagoRealizado As BE_PagoViaje In pagosPrevios
                montoAcumulado += pagoRealizado.Monto
            Next
            montoAcumulado = montoAcumulado + pagoViaje.Monto
            If montoAcumulado >= pagoViaje.Reservaviaje.viaje.Precio Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function

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

    'Public Function consultarpagoviaje(ByVal oPagoviaje As BE_PagoViaje) As BE_PagoViaje
    '    Try
    '        Return _dalpagoviaje.consultarPagoviaje(oPagoviaje)
    '    Catch ex As Exception

    '    End Try
    'End Function

    Public Function consultarPagosViajes(ByVal oReservaviaje As BE_ReservaViaje) As List(Of BE_PagoViaje)
        Try
            Return _dalpagoviaje.consultarPagosviajes(oReservaviaje)
        Catch ex As Exception

        End Try
    End Function



End Class
