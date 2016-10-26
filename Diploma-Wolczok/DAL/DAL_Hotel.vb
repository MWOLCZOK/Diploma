Imports EE
Imports System.Data.SqlClient
Imports System.Configuration
Imports DAL


Public Class DAL_Hotel

    Implements Master



    Public Sub alta(paramobjeto As Object) Implements Master.alta
        Try
            Dim paramHotel As BE_Hotel = DirectCast(paramobjeto, BE_Hotel)
            Dim command As SqlCommand = Acceso.MiComando("Insert into Alojamiento values (@ID, @ID_Destino, @ID_TipoAlojamiento, @Nombre, @Descripcion, @Estrellas, @Ubicacion, @Ambientes, @PrecioAlquiler, @ConectividadWifi, @Gimnasio, @Mascotas, @Piscina, @Sauna, @ServicioAireAcond, @ServicioDesayuno, @ServicioTV, @Cochera, @Amoblado, @Cocina,@HabitacionPrivada, @BL)")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Hotel")))
                .Add(New SqlParameter("@ID_Destino", paramHotel.Destino.ID))
                .Add(New SqlParameter("@ID_TipoAlojamiento", paramHotel.TipoAlojamiento.ID))
                .Add(New SqlParameter("@Nombre", paramHotel.Nombre))
                .Add(New SqlParameter("@Descripcion", paramHotel.Descripcion))
                .Add(New SqlParameter("@Estrellas", paramHotel.Estrellas))
                .Add(New SqlParameter("@Ubicacion", paramHotel.Ubicacion))
                .Add(New SqlParameter("@Ambientes", paramHotel.Ambientes))
                .Add(New SqlParameter("@PrecioAlquiler", paramHotel.PrecioAlquiler))
                .Add(New SqlParameter("@ConectividadWifi", paramHotel.ConectividadWifi))
                .Add(New SqlParameter("@Gimnasio", paramHotel.Gimnasio))
                .Add(New SqlParameter("@Mascotas", paramHotel.Mascota))
                .Add(New SqlParameter("@Piscina", paramHotel.Piscina))
                .Add(New SqlParameter("@Sauna", paramHotel.Sauna))
                .Add(New SqlParameter("@ServicioAireAcond", paramHotel.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramHotel.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramHotel.ServicioTV))
                .Add(New SqlParameter("@Cochera", paramHotel.Cochera))
                .Add(New SqlParameter("@Amoblado", DBNull.Value))
                .Add(New SqlParameter("@Cocina", paramHotel.Cochera))
                .Add(New SqlParameter("@HabitacionPrivada", DBNull.Value))
                .Add(New SqlParameter("@BL", False))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub eliminar(paramobjeto As Object) Implements Master.eliminar
        Try
            Dim paramHotel As BE_Hotel = DirectCast(paramobjeto, BE_Hotel)
            Dim command As SqlCommand = Acceso.MiComando("Update Alojamiento set BL=@BL where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", paramHotel.ID))
                .Add(New SqlParameter("@BL", True))
            End With
            Acceso.Escritura(command)
            command.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Function modificar(paramobjeto As Object) As Boolean Implements Master.modificar
        Try
            Dim paramHotel As BE_Hotel = DirectCast(paramobjeto, BE_Hotel)
            Dim command As SqlCommand = Acceso.MiComando("Update Alojamiento set ID_Destino=@ID_Destino, ID_TipoAlojamiento=@ID_TipoAlojamiento, Nombre=@Nombre, Descripcion=@Descripcion, Estrellas=@Estrellas, Ubicacion=@Ubicacion, Ambientes=@Ambientes, PrecioAlquiler=@PrecioAlquiler, ConectividadWifi=@ConectividadWifi, Gimnasio=@Gimnasio, Mascotas=@Mascotas, Piscina=@Piscina, Sauna@Sauna, ServicioAireAcond=@ServicioAireAcond, ServicioDesayuno=@ServicioDesayuno, ServicioTV=@ServicioTV, Cochera=@Cochera, Amoblado=@Amoblado, Cocina=@Cocina, HabitacionPrivada=@HabitacionPrivada where ID=@ID")
            With command.Parameters
                .Add(New SqlParameter("@ID", Acceso.TraerID("ID", "Alojamiento")))
                .Add(New SqlParameter("@ID_Destino", paramHotel.Destino.ID))
                .Add(New SqlParameter("@ID_TipoAlojamiento", paramHotel.TipoAlojamiento.ID))
                .Add(New SqlParameter("@Nombre", paramHotel.Nombre))
                .Add(New SqlParameter("@Descripcion", paramHotel.Descripcion))
                .Add(New SqlParameter("@Estrellas", paramHotel.Estrellas))
                .Add(New SqlParameter("@Ubicacion", paramHotel.Ubicacion))
                .Add(New SqlParameter("@Ambientes", paramHotel.Ambientes))
                .Add(New SqlParameter("@PrecioAlquiler", paramHotel.PrecioAlquiler))
                .Add(New SqlParameter("@ConectividadWifi", paramHotel.ConectividadWifi))
                .Add(New SqlParameter("@Gimnasio", paramHotel.Gimnasio))
                .Add(New SqlParameter("@Mascotas", paramHotel.Mascota))
                .Add(New SqlParameter("@Piscina", paramHotel.Piscina))
                .Add(New SqlParameter("@Sauna", paramHotel.Sauna))
                .Add(New SqlParameter("@ServicioAireAcond", paramHotel.ServicioAireAcond))
                .Add(New SqlParameter("@ServicioDesayuno", paramHotel.Desayuno))
                .Add(New SqlParameter("@ServicioTV", paramHotel.ServicioTV))
                .Add(New SqlParameter("@Cochera", paramHotel.Cochera))
                .Add(New SqlParameter("@Amoblado", DBNull.Value))
                .Add(New SqlParameter("@Cocina", paramHotel.Cochera))
                .Add(New SqlParameter("@HabitacionPrivada", DBNull.Value))
            End With
            Acceso.Escritura(command)
            command.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function consultarHosteles() As List(Of BE_Hotel)
    '    Try
    '        Dim consulta As String = ("Select * from Hotel where BL=@BL")
    '        Dim milistaHoteles As New List(Of BE_Hotel)
    '        Dim Command As SqlCommand = Acceso.MiComando(consulta)
    '        With Command.Parameters
    '            .Add(New SqlParameter("@BL", False))
    '        End With
    '        Dim dt As DataTable = Acceso.Lectura(Command)
    '        For Each drow As DataRow In dt.Rows
    '            milistaHoteles.Add(Me.formatearHotel(drow))
    '        Next
    '        Return milistaHoteles
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Private Function formatearHotel(ByVal paramDataRow As DataRow) As BE_Hotel
    '    Dim oHotel As New BE_Hotel
    '    oHotel.ID = paramDataRow.Item("ID")
    '    Dim oDestino As New BE_Destino
    '    oDestino.ID = paramDataRow.Item("ID_Destino")
    '    oHotel.Destino = (New DAL.DAL_Destino).consultarDestino(oDestino)
    '    Dim oTipoAlojamiento As New BE_TipoAlojamiento
    '    oTipoAlojamiento.ID = paramDataRow.Item("ID_TipoAlojamiento")
    '    oHotel.TipoAlojamiento = (New DAL.DAL_TipoAlojamiento).consultarTipoAlojamiento(oTipoAlojamiento)
    '    oHotel.Nombre = paramDataRow.Item("Nombre")
    '    oHotel.Descripcion = paramDataRow.Item("Descripcion")
    '    oHotel.Estrellas = paramDataRow.Item("Estrellas")
    '    oHotel.Ubicacion = paramDataRow.Item("Ubicacion")
    '    oHotel.Ambientes = paramDataRow.Item("Ambientes")
    '    oHotel.PrecioAlquiler = paramDataRow.Item("PrecioAlquiler")
    '    oHotel.ConectividadWifi = paramDataRow.Item("ConectividadWifi")
    '    oHotel.Gimnasio = paramDataRow.Item("Gimnasio")
    '    oHotel.Mascota = paramDataRow.Item("Mascotas")
    '    oHotel.Piscina = paramDataRow.Item("Piscina")
    '    oHotel.Sauna = paramDataRow.Item("Sauna")
    '    oHotel.ServicioAireAcond = paramDataRow.Item("ServicioAireAcond")
    '    oHotel.Desayuno = paramDataRow.Item("Desayuno")
    '    oHotel.ServicioTV = paramDataRow.Item("ServicioTV")
    '    oHotel.Cochera = paramDataRow.Item("Cochera")
    '    Dim oListaHabitaciones As New List(Of EE.BE_Habitacion)
    '    oListaHabitaciones = (New DAL.DAL_Habitacion).ConsultarHabitaciones(oHotel)
    '    oHotel.ListaHabitaciones = oListaHabitaciones
    '    Return oHotel
    'End Function
End Class
