Imports EE
Imports DAL


Public Class BLL_Reserva
    Dim _dalReservaVuelo As New DAL.DAL_ReservaVuelo
    Dim _dalReservaAlojamiento As New DAL.DAL_ReservaAlojamiento

    Public Sub altaReserva(ByVal paramReservaAlojamiento As EE.BE_ReservaAlojamiento)
        Try
            _dalReservaAlojamiento.alta(paramReservaAlojamiento)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub altaReserva(ByVal paramReservaVuelo As EE.BE_ReservaViaje)
        Try

        Catch ex As Exception

        End Try
    End Sub


End Class
