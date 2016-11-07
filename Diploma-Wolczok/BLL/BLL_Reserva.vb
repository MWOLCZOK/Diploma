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






End Class
