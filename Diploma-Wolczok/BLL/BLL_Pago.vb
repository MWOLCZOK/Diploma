Imports EE

Imports DAL


Public Class BLL_PagoViaje

    Dim _dalpagoviaje As New DAL_Pago

    Public Sub altapagoviaje(ByVal paramPagoViaje As BE_Pago)
        Try
            Dim listaPago As New List(Of EE.BE_Pago)
            listaPago = _dalpagoviaje.validarPago(paramPagoViaje)
            paramPagoViaje.Finpago = calcularUltimoPago(listaPago, paramPagoViaje)
            _dalpagoviaje.alta(paramPagoViaje)
            If paramPagoViaje.Finpago = True Then
                Dim _bllVoucher As New BLL.BLL_Voucher
                Dim oVoucher As New EE.BE_Voucher
                oVoucher.FechaEmision = Today
                oVoucher.Reserva = paramPagoViaje.Reserva
                oVoucher.TipoReserva = paramPagoViaje.TipoReserva
                _bllVoucher.altaVoucher(oVoucher)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function calcularUltimoPago(ByVal pagosPrevios As List(Of EE.BE_Pago), ByVal pagoViaje As BE_Pago) As Boolean
        Try
            Dim montoAcumulado As Double = 0
            For Each pagoRealizado As BE_Pago In pagosPrevios
                montoAcumulado += pagoRealizado.Monto
            Next
            montoAcumulado = montoAcumulado + pagoViaje.Monto
            If montoAcumulado >= pagoViaje.Reserva.MontoReserva Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function

    Public Sub eliminarviaje(ByVal paramviaje As BE_Pago)
        Try
            _dalpagoviaje.eliminar(paramviaje)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificarpagoviaje(ByVal parampagoviaje As BE_Pago) As Boolean
        Try
            Return _dalpagoviaje.modificar(parampagoviaje)
        Catch ex As Exception
        End Try
    End Function

    Public Function validarPago(ByVal oPagoReserva As EE.BE_Pago) As Boolean
        Try
            Dim _listaPagos As New List(Of BE_Pago)
            _listaPagos = _dalpagoviaje.validarPago(oPagoReserva)
            Dim _montoAcumulado As Double = 0

            For Each _pago As BE_Pago In _listaPagos
                _montoAcumulado += _pago.Monto
            Next

            _montoAcumulado += oPagoReserva.Monto

            If _montoAcumulado > oPagoReserva.Reserva.MontoReserva Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

        End Try
    End Function

    Public Function consultarPagosViajes(ByVal oReservaviaje As BE_Reserva) As List(Of BE_Pago)
        Try
            Return _dalpagoviaje.consultarPagosviajes(oReservaviaje) ' este consultar pagosviajes es pagos (todos)
        Catch ex As Exception

        End Try
    End Function



End Class
