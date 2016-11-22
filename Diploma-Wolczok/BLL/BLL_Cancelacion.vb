Imports DAL
Imports EE


Public Class BLL_Cancelacion

    Dim _cancelacion As New DAL_Cancelacion
    Dim _dalpago As New DAL_Pago
    Dim _dalreservaviaje As New DAL_ReservaViaje
    Dim _dalreservaaloja As New DAL_ReservaAlojamiento

    Public Sub alta(ByVal paramCancelacion As BE_Cancelacion, ByVal paramPago As BE_Pago, ByVal paramReservaviaje As BE_ReservaViaje, ByVal paramReservaAloja As BE_ReservaAlojamiento)
        Try
            '   LA DESCRIPCION VIENE EN EL OBJETO DESDE EL FORMULARIO

            '   ACTUALIZAR EL ESTADO DE LA RESERVA


            '   ACTUALIZAR EL ESTADO DE LOS PAGOS DE LA RESERVA


            '   AGREGAR DATOS DE LA CANCELACION
            _cancelacion.alta(paramCancelacion)
            _dalpago.actualizarpagocancel(paramCancelacion)
            Dim oListaReserva As New List(Of BE_ReservaViaje)
            For Each reservavi In oListaReserva
                _dalreservaviaje.actualizarreservaviajecancel(reservavi)
            Next
            Dim oListaReservaaloja As New List(Of BE_ReservaViaje)
            For Each reservaal In oListaReservaaloja
                _dalreservaaloja.actualizarreservaalojacancel(reservaal)
            Next
            Dim oListapago As New List(Of BE_Pago)
            For Each oPago In oListapago
                _dalpago.actualizarpagocancel(oPago)
            Next
            '_dalreservaaloja.actualizarreservaalojacancel(paramCancelacion)
            '_dalreservaviaje.actualizarreservaviajecancel(paramCancelacion)

        Catch ex As Exception
        End Try
    End Sub


End Class
