Imports EE
Imports DAL


Public Class BLL_Reserva
    Dim _dalReservaVuelo As New DAL.DAL_ReservaViaje
    Dim _dalReservaAlojamiento As New DAL.DAL_ReservaAlojamiento



    Public Sub altaReserva(ByVal paramReservaAlojamiento As EE.BE_ReservaAlojamiento)
        Try
            Dim valor1 = DateDiff(DateInterval.Day, paramReservaAlojamiento.Fecha_Inicio, paramReservaAlojamiento.Fecha_Fin)

            Dim valor2 = Math.Round(valor1 * retornarPuntaje(1))
            paramReservaAlojamiento.puntaje = valor2
            _dalReservaAlojamiento.alta(paramReservaAlojamiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub altaReserva(ByVal paramReservaVuelo As EE.BE_ReservaViaje)
        Try
            Dim valor2 = retornarPuntaje(2)
            paramReservaVuelo.puntaje = valor2
            _dalReservaVuelo.alta(paramReservaVuelo)
        Catch ex As Exception

        End Try
    End Sub

    Public Function retornarPuntaje(ByVal idCoeficiente As Integer) As Double
        Try
            Return _dalReservaAlojamiento.retornarPuntaje(idCoeficiente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarReservaViaje() As List(Of BE_ReservaViaje)
        Try
            Return _dalReservaVuelo.consultarReserva()
        Catch ex As Exception

        End Try
    End Function

    Public Function consultarReservaviajeID(ByVal oReservaviaje As BE_ReservaViaje) As BE_ReservaViaje
        Try
            Return _dalReservaVuelo.ConsultarReservaviajeID(oReservaviaje)
        Catch ex As Exception

        End Try
    End Function

    Public Function consultarReservaAlojamiento() As List(Of EE.BE_ReservaAlojamiento)
        Try
            Return _dalReservaAlojamiento.consultarReserva()
        Catch ex As Exception

        End Try
    End Function
    Public Function consultarReservaViajeporDNI(ByVal oPasajero As BE_Pasajero) As List(Of BE_ReservaViaje)
        Try
            Return _dalReservaVuelo.consultarReservaviajeporPasajero(oPasajero)
        Catch ex As Exception

        End Try
    End Function


    Public Function calcularPunitorios(ByVal paramReserva As BE_ReservaViaje) As BE_Cancelacion
        Try
            Dim cantidadDiasFaltantes As Double = 0
            Dim porcentajeRetencion As Integer = 0
            'CALCULA LA CANTIDAD DE DIAS QUE HAY HASTA LA FECHA DE SALIDA
            Dim montoRetencion As Double = 0
            Dim montoDevuelto As Double = 0

            cantidadDiasFaltantes = DateDiff(DateInterval.Day, paramReserva.viaje.FechaHoraSalida, Today)
            'LLAMAR A BLL.CANCELACION.OBTENERPUNITORIOS(CANTIDADDIASFALTANTES)
            'EL VALOR QUE DEVUELVE ES EL % DE RETENCIÓN

            If cantidadDiasFaltantes <= 10 Then
                porcentajeRetencion = 0.5

            ElseIf cantidadDiasFaltantes >= 11 <= 30 Then
                porcentajeRetencion = 0.35

            ElseIf cantidadDiasFaltantes >= 31 <= 60 Then
                porcentajeRetencion = 0.2

            ElseIf cantidadDiasFaltantes >= 61 <= 90 Then
                porcentajeRetencion = 0.1

            ElseIf cantidadDiasFaltantes >= 91 Then
                porcentajeRetencion = 0
            End If
            
            Dim montoTotal As Double = paramReserva.viaje.Precio



            montoRetencion = montoTotal * porcentajeRetencion



            montoDevuelto = montoTotal - montoDevuelto

            Dim oCancelacion As New BE_Cancelacion
            oCancelacion.MontoDevuelto = montoDevuelto
            oCancelacion.MontoRetenido = montoRetencion
            oCancelacion.PorcentajeRetencion = porcentajeRetencion
            oCancelacion.MontoTotal = montoTotal
            oCancelacion.Reserva = paramReserva
            oCancelacion.Fechacancelacion = Today
            Return oCancelacion

        Catch ex As Exception

        End Try
    End Function

    Public Function calcularPunitorios(ByVal paramReserva As BE_ReservaAlojamiento) As BE_Cancelacion
        Try
            Dim cantidadDiasFaltantes As Integer = 0
            Dim porcentajeRetencion As Double = 0

            'CALCULA LA CANTIDAD DE DIAS QUE HAY HASTA LA FECHA DE SALIDA
            cantidadDiasFaltantes = DateDiff(DateInterval.Day, paramReserva.Fecha_Inicio, Today)
            'LLAMAR A BLL.CANCELACION.OBTENERPUNITORIOS(CANTIDADDIASFALTANTES)
            'EL VALOR QUE DEVUELVE ES EL % DE RETENCIÓN

            If cantidadDiasFaltantes <= 10 Then
                porcentajeRetencion = 0.5

            ElseIf cantidadDiasFaltantes >= 11 <= 30 Then
                porcentajeRetencion = 0.35

            ElseIf cantidadDiasFaltantes >= 31 <= 60 Then
                porcentajeRetencion = 0.2

            ElseIf cantidadDiasFaltantes >= 61 <= 90 Then
                porcentajeRetencion = 0.1

            ElseIf cantidadDiasFaltantes >= 91 Then
                porcentajeRetencion = 0
            End If

            'Dim porcentajeRetencion As Double = 0.2 'reemplazarlo

            'OBTENGO EL MONTO TOTAL
            Dim montoTotal As Double = paramReserva.MontoAlquiler

            'CALCULAR EL MONTO DE RETENCION POR PUNITORIO
            Dim montoRetencion As Double = 0
            montoRetencion = montoTotal * porcentajeRetencion

            'CALCULAR EL MONTO DEVUELTO AL PASAJERO
            Dim montoDevuelto As Double = 0
            montoDevuelto = montoTotal - montoDevuelto

            Dim oCancelacion As New BE_Cancelacion
            oCancelacion.MontoDevuelto = montoDevuelto
            oCancelacion.MontoRetenido = montoRetencion
            oCancelacion.PorcentajeRetencion = porcentajeRetencion
            oCancelacion.MontoTotal = montoTotal
            oCancelacion.Reserva = paramReserva
            Return oCancelacion

        Catch ex As Exception

        End Try
    End Function

   



End Class
