Imports EE
Imports DAL

Public Class BLL_Habitacion
    Dim _dalHabitacion As New DAL_Habitacion

    Public Sub altaHabitacion(ByVal paramHabitacion As BE_Habitacion)
        Try
            _dalHabitacion.alta(paramHabitacion)
        Catch ex As Exception
            Throw New errorEnInsertException
        End Try
    End Sub

    Public Sub eliminarHabitacion(ByVal paramHabitacion As BE_Habitacion)
        Try
            _dalHabitacion.eliminar(paramHabitacion)
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificarHabitacion(ByVal paramHabitacion As BE_Habitacion) As Boolean
        Try
            Return _dalHabitacion.modificar(paramHabitacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultarHabitaciones() As List(Of BE_Habitacion)
        Return _dalHabitacion.ConsultarHabitaciones()
    End Function


    Public Function ConsultarHabitaciones(ByVal paramAlojamiento As EE.BE_Alojamiento) As List(Of BE_Habitacion)
        Return _dalHabitacion.ConsultarHabitaciones(paramAlojamiento)
    End Function

    Public Function ConsultarHabitacion(ByVal paramHabitacion As EE.BE_Habitacion) As BE_Habitacion
        Return _dalHabitacion.ConsultarHabitacion(paramHabitacion)
    End Function
End Class
