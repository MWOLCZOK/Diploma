Imports EE

Imports DAL


Public Class BLL_PagoViaje

    Dim _dalpagoviaje As New DAL_Pago

    Public Sub altapagoviaje(ByVal paramPagoViaje As BE_Pago)
        Try
            Dim listaPago As New List(Of EE.BE_Pago)
            listaPago = consultarPagosViajes(paramPagoViaje.Reserva)
            paramPagoViaje.Finpago = calcularUltimoPago(listaPago, paramPagoViaje)
            _dalpagoviaje.alta(paramPagoViaje)
            If paramPagoViaje.Finpago = True Then
                ' ACA VA EL ALTA DE VOUCHER, LLAMAR A BLL VOUCHER.ALTA ( LLAMAR A ALTA DALVOUCHER)
                '_DALVOUCHER.ALTA(PARAMPAGOVIAJE.RESERVA), LE PASO UNA RESERVA

                ' PARA LA DALVOUCHER
                'FECHA EMISION = TODAY (PARA LA DAL)
                'ID_RESERVA = PARAMRESREVA.ID (PARA LA DAL)
                'TIPORESERVA = PARAMPAGOVIAJE.RESREVA.TIPORESERVA (PARA LA DAL)

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

    'Public Function consultarpagoviaje(ByVal oPagoviaje As BE_PagoViaje) As BE_PagoViaje
    '    Try
    '        Return _dalpagoviaje.consultarPagoviaje(oPagoviaje)
    '    Catch ex As Exception

    '    End Try
    'End Function

    Public Function consultarPagosViajes(ByVal oReservaviaje As BE_ReservaViaje) As List(Of BE_Pago)
        Try
            Return _dalpagoviaje.consultarPagosviajes(oReservaviaje) ' este consultar pagosviajes es pagos (todos)
        Catch ex As Exception

        End Try
    End Function



End Class
