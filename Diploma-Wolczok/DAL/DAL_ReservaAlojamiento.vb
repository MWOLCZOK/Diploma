Imports DAL
Imports EE
Imports System.Data.SqlClient


Public Class DAL_ReservaAlojamiento
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramReservaAloja As BE_ReservaAlojamiento = DirectCast(paramobjeto, BE_ReservaAlojamiento)
            Dim command As SqlCommand = Acceso.MiComando("Insert into ReservaAlojamiento values (@ID, @ID_Habitacion, @ID_Pasajero, @NumeroReserva, @FechaInicio, @FechaFin, @Estado, @Detalle, @Puntaje, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "ReservaAlojamiento")))
                .Add(New SqlParameter("@ID_Habitacion", paramReservaAloja.Habitacion.ID))
                .Add(New SqlParameter("@ID_Pasajero", paramReservaAloja.Pasajero.ID))
                .Add(New SqlParameter("@NumeroReserva", Acceso.TraerID("NumeroReserva", "ReservaAlojamiento")))
                .Add(New SqlParameter("@FechaInicio", paramReservaAloja.Fecha_Inicio))
                .Add(New SqlParameter("@FechaFin", paramReservaAloja.Fecha_Fin))
                .Add(New SqlParameter("@Estado", paramReservaAloja.Estado))
                .Add(New SqlParameter("@Detalle", paramReservaAloja.Detalle))
                .Add(New SqlParameter("@Puntaje", paramReservaAloja.puntaje))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramReservaAloja As BE_ReservaAlojamiento = DirectCast(paramobjeto, BE_ReservaAlojamiento)
            Dim command As SqlCommand = Acceso.MiComando("Update ReservaAlojamiento set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramReservaAloja.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramReservaAloja As BE_ReservaAlojamiento = DirectCast(paramobjeto, BE_ReservaAlojamiento)
            Dim command As SqlCommand = Acceso.MiComando("Update ReservaAlojamiento set ID_Habitacion=@ID_Habitacion, ID_Pasajero=@ID_Pasajero, NumeroReserva=@NumeroReserva, FechaInicio=@FechaInicio, FechaFin=@FechaFin, Estado=@Estado, Detalle=@Detalle, Puntaje@Puntaje where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "ReservaAlojamiento")))
                .Add(New SqlParameter("@ID_Habitacion", paramReservaAloja.Habitacion.ID))
                .Add(New SqlParameter("@ID_Pasajero", paramReservaAloja.Pasajero.ID))
                .Add(New SqlParameter("@NumeroReserva", paramReservaAloja.NumeroReserva))
                .Add(New SqlParameter("@FechaInicio", paramReservaAloja.Fecha_Inicio))
                .Add(New SqlParameter("@FechaFin", paramReservaAloja.Fecha_Fin))
                .Add(New SqlParameter("@Estado", paramReservaAloja.Estado))
                .Add(New SqlParameter("@Detalle", paramReservaAloja.Detalle))
                .Add(New SqlParameter("@Puntaje", paramReservaAloja.puntaje))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarReserva() As List(Of BE_ReservaAlojamiento)
        Try
            Dim consulta As String = ("Select * from ReservaAlojamiento where BL=@BL")
            Dim miListaReserva As New List(Of BE_ReservaAlojamiento)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaReserva.Add(Me.formatearReservaAlojamiento(drow))
            Next
            Return miListaReserva
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarDestino(ByVal oReservaAlojamiento As EE.BE_ReservaAlojamiento) As EE.BE_ReservaAlojamiento
        Try
            Dim consulta As String = ("Select * from ReservaAlojamiento where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oReservaAlojamiento.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearReservaAlojamiento(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function retornarPuntaje(ByVal idCoeficiente As Integer) As Double
        Try
            Dim consulta As String = ("Select coeficiente from Puntaje where ID=@ID")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", idCoeficiente))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return CDbl(dt.Rows(0).Item(0))
            Else
                Return 1
            End If
        Catch ex As Exception

        End Try
    End Function


    Private Function formatearReservaAlojamiento(ByVal paramDataRow As DataRow) As BE_ReservaAlojamiento
        Dim oReservaAlojamiento As New BE_ReservaAlojamiento
        oReservaAlojamiento.ID = paramDataRow.Item("ID")
        Dim oHabitacion As New BE_Habitacion
        oHabitacion.ID = paramDataRow.Item("ID_Habitacion")
        oReservaAlojamiento.NumeroReserva = paramDataRow.Item("NumeroReserva")
        oReservaAlojamiento.Habitacion = (New DAL.DAL_Habitacion).ConsultarHabitacion(oHabitacion)
        oReservaAlojamiento.Fecha_Inicio = paramDataRow.Item("FechaInicio")
        oReservaAlojamiento.Fecha_Fin = paramDataRow.Item("FechaFin")
        oReservaAlojamiento.Detalle = paramDataRow.Item("Detalle")
        oReservaAlojamiento.Estado = paramDataRow.Item("Estado")
        oReservaAlojamiento.puntaje = paramDataRow.Item("Puntaje")

        Return oReservaAlojamiento
    End Function
End Class
