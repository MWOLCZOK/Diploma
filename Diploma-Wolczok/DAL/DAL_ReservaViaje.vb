Imports DAL
Imports EE
Imports System.Data.SqlClient


Public Class DAL_ReservaViaje
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramReservaViaje As BE_ReservaViaje = DirectCast(paramobjeto, BE_ReservaViaje)
            Dim command As SqlCommand = Acceso.MiComando("Insert into ReservaViaje values (@ID, @ID_Viaje, @ID_Asiento, @ID_Pasajero, @NumeroReserva, @Estado, @Detalle, @Puntaje,@BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "ReservaViaje")))
                .Add(New SqlParameter("@ID_Viaje", paramReservaViaje.viaje.ID))
                .Add(New SqlParameter("@ID_Asiento", paramReservaViaje.Asiento.ID))
                .Add(New SqlParameter("@ID_Pasajero", paramReservaViaje.Pasajero.ID))
                .Add(New SqlParameter("@NumeroReserva", Acceso.TraerID("NumeroReserva", "ReservaAlojamiento")))
                .Add(New SqlParameter("@Estado", paramReservaViaje.Estado))
                .Add(New SqlParameter("@Detalle", paramReservaViaje.Detalle))
                .Add(New SqlParameter("@Puntaje", paramReservaViaje.puntaje))
                '.Add(New SqlParameter("@ID_Pago", paramReservaViaje.Pagoviaje))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramReservaViaje As BE_ReservaViaje = DirectCast(paramobjeto, BE_ReservaViaje)
            Dim command As SqlCommand = Acceso.MiComando("Update ReservaViaje set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramReservaViaje.ID))
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
            Dim paramReservaViaje As BE_ReservaViaje = DirectCast(paramobjeto, BE_ReservaViaje)
            Dim command As SqlCommand = Acceso.MiComando("Update ReservaViaje set ID_Viaje=@ID_Viaje, ID_Asiento=@ID_Asiento, ID_Pasajero=@ID_Pasajero, NumeroReserva=@NumeroReserva, Estado=@Estado, Detalle=@Detalle, Puntaje@Puntaje, ID_Pago@ID_Pago where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "ReservaViaje")))
                .Add(New SqlParameter("@ID_Viaje", paramReservaViaje.viaje.ID))
                .Add(New SqlParameter("@ID_Asiento", paramReservaViaje.Asiento.ID))
                .Add(New SqlParameter("@ID_Pasajero", paramReservaViaje.Pasajero.ID))
                .Add(New SqlParameter("@NumeroReserva", Acceso.TraerID("NumeroReserva", "ReservaAlojamiento")))
                .Add(New SqlParameter("@Estado", paramReservaViaje.Estado))
                .Add(New SqlParameter("@Detalle", paramReservaViaje.Detalle))
                .Add(New SqlParameter("@Puntaje", paramReservaViaje.puntaje))
                '.Add(New SqlParameter("@ID_Pago", paramReservaViaje.Pagoviaje))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarReserva() As List(Of BE_ReservaViaje)
        Try
            Dim consulta As String = ("Select * from ReservaViaje where BL=@BL")
            Dim miListaReserva As New List(Of BE_ReservaViaje)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaReserva.Add(Me.formatearReservaViaje(drow))
            Next
            Return miListaReserva
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarDestino(ByVal oReservaViaje As EE.BE_ReservaViaje) As EE.BE_ReservaViaje
        Try
            Dim consulta As String = ("Select * from ReservaViaje where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oReservaViaje.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearReservaViaje(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function consultarReservaviaje(ByVal oReservaViaje As BE_ReservaViaje) As List(Of BE_ReservaViaje)
        Try
            Dim consulta As String = ("Select * from ReservaViaje where ID=@ID and BL=@BL")
            Dim miListaReservaviaje As New List(Of BE_ReservaViaje)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oReservaViaje.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaReservaviaje.Add(Me.formatearReservaViaje(drow))
            Next
            Return miListaReservaviaje
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

    Public Function consultarReservaviajeporPasajero(ByVal oPasajero As BE_Pasajero) As List(Of BE_ReservaViaje)
        Try
            Dim consulta As String = ("Select * from ReservaViaje where BL=@BL")
            Dim miListaReservaviaje As New List(Of BE_ReservaViaje)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oPasajero.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                miListaReservaviaje.Add(Me.formatearReservaViaje(drow))
            Next
            Return miListaReservaviaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ConsultarReservaviajeID(ByVal oReservaviaje As BE_ReservaViaje) As BE_ReservaViaje
        Try
            Dim consulta As String = ("Select * from ReservaViaje where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oReservaviaje.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearReservaViaje(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Private Function formatearReservaViaje(ByVal paramDataRow As DataRow) As BE_ReservaViaje
        Dim oReservaViaje As New BE_ReservaViaje
        oReservaViaje.ID = paramDataRow.Item("ID")
        Dim oAsiento As New BE_Asiento
        oAsiento.ID = paramDataRow.Item("ID_Asiento")
        oReservaViaje.Asiento = (New DAL.DAL_Asiento).consultarAsiento(oAsiento)
        Dim oPasajero As New BE_Pasajero
        oPasajero.ID = paramDataRow.Item("ID_Pasajero")
        oReservaViaje.Pasajero = (New DAL.DAL_Pasajero).consultarPasajero(oPasajero)
        Dim oViaje As New BE_Viaje
        oViaje.ID = paramDataRow.Item("ID_Viaje")
        oReservaViaje.viaje = (New DAL.DAL_Viaje).consultarViaje(oViaje)
        oReservaViaje.NumeroReserva = paramDataRow.Item("NumeroReserva")
        oReservaViaje.Detalle = paramDataRow.Item("Detalle")
        oReservaViaje.Estado = paramDataRow.Item("Estado")
        oReservaViaje.puntaje = paramDataRow.Item("Puntaje")
        oReservaViaje.Pagoviaje = (New DAL_PagoViaje).consultarPagosviajes(oReservaViaje)
        Return oReservaViaje
    End Function



End Class
