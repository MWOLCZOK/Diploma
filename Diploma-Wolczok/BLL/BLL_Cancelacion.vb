Imports DAL
Imports EE


Public Class BLL_Cancelacion

    Dim _cancelacion As New DAL_Cancelacion

    Public Sub alta(ByVal paramCancelacion As BE_Cancelacion)
        Try
            '   LA DESCRIPCION VIENE EN EL OBJETO DESDE EL FORMULARIO

            '   ACTUALIZAR EL ESTADO DE LA RESERVA


            '   ACTUALIZAR EL ESTADO DE LOS PAGOS DE LA RESERVA


            '   AGREGAR DATOS DE LA CANCELACION
            _cancelacion.alta(paramCancelacion)
        Catch ex As Exception
        End Try
    End Sub

    'Public Function obtenerPunitorios(ByVal paramReserva As BE_ReservaAlojamiento) As BE_Cancelacion
    '    Try
    '        Dim cantidaddiasfaltantes As Integer = 0
    '        Dim porcentajeRetencion As Double = 0
    '        cantidaddiasfaltantes = DateDiff(DateInterval.Day, paramReserva.Fecha_Inicio, Today)

    '        If cantidaddiasfaltantes <= 10 Then
    '            porcentajeRetencion = 0.5

    '        ElseIf cantidaddiasfaltantes >= 11 <= 30 Then
    '            porcentajeRetencion = 0.35

    '        ElseIf cantidaddiasfaltantes >= 31 <= 60 Then
    '            porcentajeRetencion = 0.2

    '        ElseIf cantidaddiasfaltantes >= 61 <= 90 Then
    '            porcentajeRetencion = 0.1

    '        ElseIf cantidaddiasfaltantes >= 91 Then
    '            porcentajeRetencion = 0
    '        End If

    '    Catch ex As Exception

    '    End Try





    'End Function





End Class
