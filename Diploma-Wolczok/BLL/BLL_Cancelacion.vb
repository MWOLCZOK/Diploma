Imports DAL
Imports EE


Public Class BLL_Cancelacion

    Dim _cancelacion As New DAL_Cancelacion
    Dim _dalpago As New DAL_Pago
    Dim _dalreservaviaje As New DAL_ReservaViaje
    Dim _dalreservaaloja As New DAL_ReservaAlojamiento
    Dim _dalVoucher As New DAL_Voucher

    Public Sub altaCancelacion(ByVal paramCancelacion As BE_Cancelacion)
        Try
            _cancelacion.alta(paramCancelacion)
            For Each pagoReserva As EE.BE_Pago In paramCancelacion.Reserva.Pagoviaje
                _dalpago.actualizarpagocancel(paramCancelacion)
            Next
            If paramCancelacion.Reserva.TipoReserva = TipoReserva.Alojamiento Then
                _dalreservaaloja.actualizarreservaalojacancel(paramCancelacion.Reserva)
            Else
                _dalreservaviaje.actualizarreservaviajecancel(paramCancelacion.Reserva)
            End If
            _dalVoucher.cancelarVoucher(paramCancelacion.Reserva)
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub
End Class
