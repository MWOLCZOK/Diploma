Imports DAL
Imports EE
Imports System.Data.SqlClient
Imports System.Configuration


Public Class DAL_Habitacion
    Implements Master

    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramHabitacion As BE_Habitacion = DirectCast(paramobjeto, BE_Habitacion)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Destino values (@ID, @ID_Alojamiento, @CantidadCamas, @CantidadPersonas, @Cocina, @Escritorio, @Frigobar, @Mesa, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Habitacion")))
                .Add(New SqlParameter("@ID_Alojamiento", paramHabitacion.Alojamiento.ID))
                .Add(New SqlParameter("@CantidadCamas", paramHabitacion.CantidadCamas))
                .Add(New SqlParameter("@CantidadPersonas", paramHabitacion.CantidadPersonas))
                .Add(New SqlParameter("@Cocina", paramHabitacion.Cocina))
                .Add(New SqlParameter("@Escritorio", paramHabitacion.Escritorio))
                .Add(New SqlParameter("@Frigobar", paramHabitacion.Frigobar))
                .Add(New SqlParameter("@Mesa", paramHabitacion.Mesa))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramHabitacion As BE_Habitacion = DirectCast(paramobjeto, BE_Habitacion)
            Dim command As SqlCommand = Acceso.MiComando("Update Habitacion set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramHabitacion.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramHabitacion As BE_Habitacion = DirectCast(paramobjeto, BE_Habitacion)
            Dim command As SqlCommand = Acceso.MiComando("Update Habitacion set ID_Alojamiento=@ID_Alojamiento, CantidadCamas=@CantidadCamas, CantidadPersonas=@CantidadPersonas, Cocina=@Cocina, Escritorio=@Escritorio, Frigobar=@Frigobar where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramHabitacion.ID))
                .Add(New SqlParameter("@ID_Alojamiento", paramHabitacion.Alojamiento.ID))
                .Add(New SqlParameter("@CantidadCamas", paramHabitacion.CantidadCamas))
                .Add(New SqlParameter("@CantidadPersonas", paramHabitacion.CantidadPersonas))
                .Add(New SqlParameter("@Cocina", paramHabitacion.Cocina))
                .Add(New SqlParameter("@Escritorio", paramHabitacion.Escritorio))
                .Add(New SqlParameter("@Frigobar", paramHabitacion.Frigobar))
                .Add(New SqlParameter("@Mesa", paramHabitacion.Mesa))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Function

    Public Function ConsultarHabitaciones() As List(Of BE_Habitacion)
        Try
            Dim consulta As String = ("Select * from Habitacion where BL=@BL")
            Dim milistaHabitacion As New List(Of BE_Habitacion)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaHabitacion.Add(Me.formatearHabitacion(drow))
            Next
            Return milistaHabitacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultarHabitacion(ByVal oHabitacion As EE.BE_Habitacion) As BE_Habitacion
        Try
            Dim consulta As String = ("Select * from Habitacion where ID=@ID and BL=@BL")
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID", oHabitacion.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            If dt.Rows.Count = 1 Then
                Return Me.formatearHabitacion(dt.Rows(0))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultarHabitaciones(ByVal oAlojamiento As EE.BE_Alojamiento) As List(Of BE_Habitacion)
        Try
            Dim consulta As String = ("Select * from Habitacion where ID_Habitacion=@ID_Habitacion and BL=@BL")
            Dim milistaHabitacion As New List(Of BE_Habitacion)
            Dim Command As SqlCommand = Acceso.MiComando(consulta)
            With Command.Parameters
                .Add(New SqlParameter("@ID_Habitacion", oAlojamiento.ID))
                .Add(New SqlParameter("@BL", False))
            End With
            Dim dt As DataTable = Acceso.Lectura(Command)
            For Each drow As DataRow In dt.Rows
                milistaHabitacion.Add(Me.formatearHabitacion(drow))
            Next
            Return milistaHabitacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

  
    Private Function formatearHabitacion(ByVal paramDataRow As DataRow) As BE_Habitacion
        Dim oHabitacion As New BE_Habitacion
        oHabitacion.ID = paramDataRow.Item("ID")
        oHabitacion.CantidadCamas = paramDataRow.Item("CantidadCamas")
        oHabitacion.CantidadPersonas = paramDataRow.Item("CantidadPersonas")
        oHabitacion.Cocina = paramDataRow.Item("Cocina")
        oHabitacion.Frigobar = paramDataRow.Item("Frigobar")
        oHabitacion.Escritorio = paramDataRow.Item("Escritorio")
        oHabitacion.Mesa = paramDataRow.Item("Mesa")
        Return oHabitacion
    End Function

End Class
