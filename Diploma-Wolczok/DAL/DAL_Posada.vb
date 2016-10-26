Imports EE
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DAL_Posada

    Implements Master



    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramPosada As BE_Posada = DirectCast(paramobjeto, BE_Posada)
            Dim command As SqlCommand = Acceso.MiComando("Update Alojamiento set ID_Destino=@ID_Destino, ID_TipoAlojamiento=@ID_TipoAlojamiento, Nombre=@Nombre, Descripcion=@Descripcion, Estrellas=@Estrellas, Ubicacion=@Ubicacion, Ambientes=@Ambientes, PrecioAlquiler=@PrecioAlquiler, ConectividadWifi=@ConectividadWifi, Gimnasio=@Gimnasio, Mascotas=@Mascotas, Piscina=@Piscina, Sauna@Sauna, ServicioAireAcond=@ServicioAireAcond, ServicioDesayuno=@ServicioDesayuno, ServicioTV=@ServicioTV, Cochera=@Cochera, Amoblado=@Amoblado, Cocina=@Cocina, HabitacionPrivada=@HabitacionPrivada where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Alojamiento")))
                .Add(New SqlParameter("@ID_Destino", paramPosada.Destino.ID))
                .Add(New SqlParameter("@ID_TipoAlojamiento", paramPosada.TipoAlojamiento.ID))
                .Add(New SqlParameter("@Nombre", paramPosada.Nombre))
                .Add(New SqlParameter("@Descripcion", paramPosada.Descripcion))
                .Add(New SqlParameter("@Estrellas", paramPosada.Estrellas))
                .Add(New SqlParameter("@Ubicacion", paramPosada.Ubicacion))
                .Add(New SqlParameter("@Ambientes", paramPosada.Ambientes))
                .Add(New SqlParameter("@PrecioAlquiler", paramPosada.PrecioAlquiler))
                .Add(New SqlParameter("@ConectividadWifi", paramPosada.ConectividadWifi))
                .Add(New SqlParameter("@Gimnasio", DBNull.Value))
                .Add(New SqlParameter("@Mascotas", paramPosada.Mascota))
                .Add(New SqlParameter("@Piscina", paramPosada.Piscina))
                .Add(New SqlParameter("@Sauna", DBNull.Value))
                .Add(New SqlParameter("@ServicioAireAcond", paramPosada.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramPosada.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramPosada.ServicioTV))
                .Add(New SqlParameter("@Cochera", DBNull.Value))
                .Add(New SqlParameter("@Amoblado", DBNull.Value))
                .Add(New SqlParameter("@Cocina", DBNull.Value))
                .Add(New SqlParameter("@HabitacionPrivada", DBNull.Value))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramPosada As BE_Posada = DirectCast(paramobjeto, BE_Posada)
            Dim command As SqlCommand = Acceso.MiComando("Update Alojamiento set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramPosada.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramPosada As BE_Posada = DirectCast(paramobjeto, BE_Posada)
            Dim command As SqlCommand = Acceso.MiComando("Update Alojamiento set ID_Destino=@ID_Destino, ID_TipoAlojamiento=@ID_TipoAlojamiento, Nombre=@Nombre, Descripcion=@Descripcion, Estrellas=@Estrellas, Ubicacion=@Ubicacion, Ambientes=@Ambientes, PrecioAlquiler=@PrecioAlquiler, ConectividadWifi=@ConectividadWifi, Gimnasio=@Gimnasio, Mascotas=@Mascotas, Piscina=@Piscina, Sauna@Sauna, ServicioAireAcond=@ServicioAireAcond, ServicioDesayuno=@ServicioDesayuno, ServicioTV=@ServicioTV, Cochera=@Cochera, Amoblado=@Amoblado, Cocina=@Cocina, HabitacionPrivada=@HabitacionPrivada where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Alojamiento")))
                .Add(New SqlParameter("@ID_Destino", paramPosada.Destino.ID))
                .Add(New SqlParameter("@ID_TipoAlojamiento", paramPosada.TipoAlojamiento.ID))
                .Add(New SqlParameter("@Nombre", paramPosada.Nombre))
                .Add(New SqlParameter("@Descripcion", paramPosada.Descripcion))
                .Add(New SqlParameter("@Estrellas", paramPosada.Estrellas))
                .Add(New SqlParameter("@Ubicacion", paramPosada.Ubicacion))
                .Add(New SqlParameter("@Ambientes", paramPosada.Ambientes))
                .Add(New SqlParameter("@PrecioAlquiler", paramPosada.PrecioAlquiler))
                .Add(New SqlParameter("@ConectividadWifi", paramPosada.ConectividadWifi))
                .Add(New SqlParameter("@Gimnasio", DBNull.Value))
                .Add(New SqlParameter("@Mascotas", paramPosada.Mascota))
                .Add(New SqlParameter("@Piscina", paramPosada.Piscina))
                .Add(New SqlParameter("@Sauna", DBNull.Value))
                .Add(New SqlParameter("@ServicioAireAcond", paramPosada.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramPosada.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramPosada.ServicioTV))
                .Add(New SqlParameter("@Cochera", DBNull.Value))
                .Add(New SqlParameter("@Amoblado", DBNull.Value))
                .Add(New SqlParameter("@Cocina", DBNull.Value))
                .Add(New SqlParameter("@HabitacionPrivada", DBNull.Value))
            End With

            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
        End Try
    End Function
End Class
